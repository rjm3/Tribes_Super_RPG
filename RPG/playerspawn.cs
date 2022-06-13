function Game::pickObserverSpawn(%clientId)
{
	dbecho($dbechoMode2, "Game::pickObserverSpawn(" @ %clientId @ ")");

	%group = nameToID("MissionGroup\\ObserverDropPoints");
	%count = Group::objectCount(%group);

	if(%group == -1 || !%count)
		%group = nameToID("MissionGroup\\Teams\\team0\\DropPoints");
	%count = Group::objectCount(%group);
	if(%group == -1 || !%count)
		%group = nameToID("MissionGroup\\Teams\\team1\\DropPoints");
	%count = Group::objectCount(%group);
	if(%group == -1 || !%count)
		return -1;
	%spawnIdx = %clientId.lastObserverSpawn + 1;
	if(%spawnIdx >= %count)
		%spawnIdx = 0;
	%clientId.lastObserverSpawn = %spawnIdx;

	return Group::getObject(%group, %spawnIdx);
}

function Game::pickPlayerSpawn(%clientId, %respawn)
{
	dbecho($dbechoMode2, "Game::pickPlayerSpawn(" @ %clientId @ ", " @ %respawn @ ")");

	if(fetchData(%clientId, "lastzone") == "")
		%group = nameToID("MissionGroup/Teams/team0/DropPoints");
	else {
		%zone = fetchData(%clientId, "lastzone");
		if ((%death = GetZoneData(%zone,$ZoneDeath)) != "") {
			storeData(%clientId,"lastzone","");
			storeData(%clientId,"zone",%death);
			return "CRUSPAWN " @ GetZoneData(%zone,$ZoneDeathPos);
		}
	}
		%group = nameToID("MissionGroup/Zones/" @ Object::getName(fetchData(%clientId, "lastzone")) @ "/DropPoints");

	%count = Group::objectCount(%group);
	if(!%count)
		return -1;
	%spawnIdx = floor(getRandom() * (%count - 0.1));
	%value = %count;

	for(%i = %spawnIdx; %i < %value; %i++)
	{
		%set = newObject("set",SimSet);
		%obj = Group::getObject(%group, %i);
		if(containerBoxFillSet(%set,$SimPlayerObjectType|$VehicleObjectType,GameBase::getPosition(%obj),2,2,4,0) == 0)
		{
			deleteObject(%set);
			return %obj;		
		}
		if(%i == %count - 1)
		{
			%i = -1;
			%value = %spawnIdx;
		}
		deleteObject(%set);
	}
	return false;
}

function Game::GetSpawnArmor(%clientId)
{
	%race = fetchData(%clientId, "RACE");
	%crurace = fetchData(%clientId, "CruRACE");	

	%newrace = "";
	if (%race == "Shelter" || %race == "Arcane" || %race == "Minotaur") {
		if (%crurace == "Nephilim" || %crurace == "Orc")
			%newrace = Client::getGender(%clientId) @ "BigHuman";
		else
			%newrace = Client::getGender(%clientId) @ "Human";
	}
	if (%newrace != "") %race = %newrace;

	%armor = $RaceToArmorType[%race];
	return %armor;
}

function Game::playerSpawn(%clientId, %respawn)
{
	dbecho($dbechoMode2, "Game::playerSpawn(" @ %clientId @ ", " @ %respawn @ ")");

	if(!$ghosting)
		return false;

	Client::clearItemShopping(%clientId);
	Client::clearItemBuying(%clientId);

	if (!%respawn) {
		DisableTeamHud(%clientId);
	}

	if(fetchData(%clientId, "isMimic"))
	{
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
		storeData(%clientId, "isMimic", "");
	}

	if(%clientId.RespawnMeInArena)
	{
		%group = nameToID("MissionGroup\\TheArena\\TeleportEntranceMarkers");

		if(%group != -1)
		{
			%num = Group::objectCount(%group);

			%r = floor(getRandom() * %num);
			%spawnMarker = Group::getObject(%group, %r);
		}
		else
		{
			%spawnMarker = Game::pickPlayerSpawn(%clientId, %respawn);
		}

		RefreshArenaTextBox(%clientId);
	}
	else
	{
		%spawnMarker = Game::pickPlayerSpawn(%clientId, %respawn);

		//the player is spawning normally, ie. not in the arena
		storeData(%clientId, "inArena", "");
		CloseArenaTextBox(%clientId);
	}

	if(%spawnMarker || getWord(%spawnmarker,0) == "CRUSPAWN" || %spawnmarker == -1)
	{
		%clientId.guiLock = "";
		%clientId.dead = "";
		if (getWord(%spawnMarker,0) == "CRUSPAWN") {
			%spawnPos = getWord(%spawnMarker,1) @ " " @ getWord(%spawnMarker,2) @ " " @ getWord(%spawnMarker,3);
			%spawnRot = "0 0 0";
		}
		else if (%spawnMarker == -1)
		{
			%spawnPos = "31 75 168";
			%spawnRot = "0 0 0";
		}
		else
		{
			%spawnPos = GameBase::getPosition(%spawnMarker);
			%spawnRot = GameBase::getRotation(%spawnMarker);
		}
		if (fetchData(%clientId, "campPos") != "" && !%respawn)
		{
			//if the player HAS a campPos and it is his FIRST TIME SPAWNING, then spawn him at this campPos
			%spawnPos = fetchData(%clientId, "campPos");
			%spawnRot = fetchData(%clientId, "campRot");
		}

		
		%armor = Game::GetSpawnArmor(%clientId);

		//------------------------------------------------------
		// BATTLE RESTRICTION
		if ($Battling[%clientId] == 1) {
			BattleDied(%clientId);
			%faction = GetPlayerFaction(%clientId);
			%spawnPos = $ReadyRoom[%faction];
		}
		//------------------------------------------------------

		if (!%respawn) SetConnectionId(%clientId);
		setLifeId(%clientId);
		
		// if (!%respawn) schedule("remoteEval("@%clientId@",LockAndCaptureControls,crucible);",1.0);

		%pl = spawnPlayer(%armor, %spawnPos, %spawnRot);
		PlaySound(SoundSpawn2, %spawnPos);
		GameBase::startFadeIn(Client::getOwnedObject(%clientId));

		echo("SPAWN: cl:" @ %clientId @ " pl:" @ %pl @ " marker:" @ %spawnMarker @ " position: " @ %spawnPos @ " armor:" @ %armor);

		if(%pl != -1)
		{
			UpdateTeam(%clientId);
			GameBase::setTeam(%pl, Client::getTeam(%clientId));
			Client::setOwnedObject(%clientId, %pl);
			Client::setControlObject(%clientId, %pl);
			Game::playerSpawned(%pl, %clientId, %armor, %respawn);

			if(%respawn)	      
			{
				GameBase::setDamageLevel(Client::getOwnedObject(%clientId),0.6);
				%armor = Player::getArmor(%clientId);
				%b = %armor.maxenergy * 0.4;
				GameBase::setEnergy(Client::getOwnedObject(%clientId),%b);
			}
			else
			{
				setHP(%clientId, fetchData(%clientId, "tmphp"));
				setMANA(%clientId, fetchData(%clientId, "tmpmana"));
				storeData(%clientId, "tmphp", "");
				storeData(%clientId, "tmpmana", "");
			}
			
			storeData(%clientId.possessId, "dumbAIflag", "");
		}
		return true;
	}
	else
	{
		Client::sendMessage(%clientId,0,"Sorry No Respawn Positions Are Empty - Try again later ");
		return false;
	}
}

function Game::playerSpawned(%pl, %clientId, %armor, %respawn)
{
	dbecho($dbechoMode2, "Game::playerSpawned(" @ %pl @ ", " @ %clientId @ ", " @ %armor @ ")");
	//=======================================================================================================
	storeData(%clientId, "HasLoadedAndSpawned", True);
	//=======================================================================================================
	if(%clientId.RespawnMeInArena)
	{
		//give him his equipment back
		RestorePreviousEquipment(%clientId);

		%clientId.RespawnMeInArena = "";
	}
	else
	{
		GiveThisStuff(%clientId, fetchData(%clientId, "spawnStuff"), False);
	}
	//=======================================================================================================
	InitWearVisuals(%clientId);
	//=======================================================================================================
	%autostartfocus = $AutoStartFocus[%clientId];
	echo("AUTO START SAVED FOCUS " @ %autostartfocus);
	if (getWord(%autostartfocus,0) != -1)
		AutoStartSavedFocus(%clientId,%autostartfocus);
	//=======================================================================================================
	if(fetchData(%clientId, "LCK") < 0)
		storeData(%clientId, "LCK", 0);
	//=======================================================================================================
	// remoteEval(%clientId,"ActivateCRUHUD");
	//=======================================================================================================
	$TargetCur[%clientId,0] = "";
	$TargetList[%clientId,0] = "";
	$TargetTemp[%clientId,0] = "";
	$TargetPrev[%clientId,0] = "";
	$TargetCur[%clientId,1] = "";
	$TargetList[%clientId,1] = "";
	$TargetTemp[%clientId,1] = "";
	$TargetPrev[%clientId,1] = "";
	//=======================================================================================================
	$Rooted[%clientId] = 0;
	$Stunned[%clientId] = 0;
	RefreshATK(%clientId);
	RefreshAll(%clientId);
	$STATUSCOLD[%clientId] = 0;
	$STATUSMELEE[%clientId] = 0;
	$STATUSPROJ[%clientId] = 0;
	$STATUSPOISON[%clientId] = 0;
	$STATUSENERGY[%clientId] = 0;
	$POISONINIT[%clientId] = "";
	$POISONHIT[%clientId] = "";
	$BLEEDING[%clientId] = 0;
	$BLEEDHIT[%clientId] = "";
	$BLEEDINIT[%clientId] = "";
	$STATUSFIRE[%clientId] = 0;
	$IGNITED[%clientId] = 0;
	$IGNITEHIT[%clientId] = 0;
	//=======================================================================================================
	ClearMysticRelic(%clientId);
	//=======================================================================================================
	ClearPlayerNpc(%clientId);
	//=======================================================================================================
	if (!%respawn) LoadAllPassives(%clientId);
	//=======================================================================================================
	$HealDelta[%clientId] = 4;
	$ManaDelta[%clientId] = 4;
	$HealDeltaTick[%clientId] = 4;
	$ManaDeltaTick[%clientId] = 4;
	$HealPotion[%clientId] = 0;
	$EnergyVial[%clientId] = 0;
	ClearMapBonus(%clientId);
	//=======================================================================================================
	if ($ResSick[%clientId] == 1) {
		$RESTIMER[%clientId] = 60;
		$ResSick[%clientId] = 0;
		GameBase::setDamageLevel(Client::getOwnedObject(%clientId),0.6);
		%armor = Player::getArmor(%clientId);
		%b = %armor.maxenergy * 0.4;
		GameBase::setEnergy(Client::getOwnedObject(%clientId),%b);
	}
} 

function Game::autoRespawn(%clientId)
{
	dbecho($dbechoMode2, "Game::autoRespawn(" @ %clientId @ ")");

	if(%clientId.dead == 1)
		Game::playerSpawn(%clientId, True);
}