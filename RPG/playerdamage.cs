// PLAYERDAMAGE NEEDS MAJOR CLEANUP

exec(newcombat);


function Client::onKilled(%clientId, %killerId, %damageType, %outzone)
{
	dbecho($dbechoMode, "Client::onKilled(" @ %clientId @ ", " @ %killerId @ ", " @ %damageType @ ")");

	//This function is NOT an event, it must be MANUALLY CALLED!
	//At this point, the client can still be queried for getItemCounts, but is not considered an object anymore.

	//we can award the other players exp
	if (!%outzone) DistributeExpForKilling(%clientId);

	//The player with the killshot gets the official "kill"
	if(!IsInCommaList(fetchData(%killerId, "TempKillList"), Client::getName(%clientId)))
		storeData(%killerId, "TempKillList", AddToCommaList(fetchData(%killerId, "TempKillList"), Client::getName(%clientId)));

	if(%killerId != %clientId)
	{
		//a human player killed %clientId
		%n = Client::getName(%killerId);

		Client::sendMessage(%clientId, 0, "You were killed by " @ %n @ "!");

		//if(fetchData(%killerId, "bounty") == Client::getName(%clientId))
		//	storeData(%killerId, "bounty", fetchData(%clientId, "LVL") @ " !Q@W#E$R%T^Y&U*I(O)P");
	}
	else if(%killerId == %clientId)
	{
		Client::sendMessage(%clientId, 0, "You killed yourself!");
	}
	else if(%damageType == 11 || %damageType == 12 || %damageType == 2)
	{
		Client::sendMessage(%clientId, 0, "You were killed!");
	}

	%owner = $CruAI[%clientId,$AiOwner];
	if (%owner != "")
		CruAiTerminatePet(%owner,%clientId,True);

	UnHide(%clientId);

	//========================================================================================================================

	echo("GAME: kill " @ %killerId @ " " @ %clientId @ " " @ %damageType);
	%clientId.guiLock = true;
	Client::setGuiMode(%clientId, $GuiModePlay);

	Game::clientKilled(%clientId, %killerId);
}

function Game::clientKilled(%playerId, %killerId)
{
	dbecho($dbechoMode, "Game::clientKilled(" @ %playerId @ ", " @ %killerId @ ")");

	%set = nameToID("MissionCleanup/ObjectivesSet");
	for(%i = 0; (%obj = Group::getObject(%set, %i)) != -1; %i++)
		GameBase::virtual(%obj, "clientKilled", %playerId, %killerId);
}

function Player::onKilled(%this)
{
	dbecho($dbechoMode, "Player::onKilled(" @ %this @ ")");
	//========================================================================================================================
	%this.NoLadderPickup = 0;
	//========================================================================================================================
	%clientId = Player::getClient(%this);
	%killerId = fetchData(%clientId, "tmpkillerid");
	storeData(%clientId, "tmpkillerid", "");
	$ResSick[%clientId] = 1;
	//========================================================================================================================
	Client::setControlObject(%clientId.possessId, %clientId.possessId);
	Client::setControlObject(%clientId, %clientId);
	storeData(%clientId.possessId, "dumbAIflag", "");
	$possessedBy[%clientId.possessId] = "";
	//========================================================================================================================
	%tmploot = "";
	if(fetchData(%clientId, "COINS") > 0)
		%tmploot = %tmploot @ "COINS " @ floor(fetchData(%clientId, "COINS")) @ " ";
	storeData(%clientId, "COINS", 0);
	if (Player::isAiControlled(Client::GetOwnedObject(%clientId))) {
		if ($PlayerBackpack[%clientId] != "")
			%tmploot = %tmploot @ " " @ $PlayerBackpack[%clientId];
		$PlayerBackpack[%clientId] = "";
		//-------------------------------------------------------------------------------------------
		if ((%ex = $MONSTEREXLOOT[%clientId]) != "")		
			%tmploot = %tmploot @ " " @ CZ::CreateMonsterExLoot(%ex,fetchData(%clientId,"LVL"));
		//-------------------------------------------------------------------------------------------
		if (MTRB(1,6) == 1)
			%tmploot = %tmploot @ " 999HealthPotion 1";
		if (MTRB(1,6) == 1)
			%tmpLoot = %tmpLoot @ " 999EnergyVial 1";
		if (MTRB(1,12) == 1)
			%tmploot = %tmploot @ " " @ Loot::Integrity() @ " 1";
		if (MTRB(1,18) == 1)
			%tmpLoot = %tmpLoot @ " 999PortalScroll 1";
		if (MTRB(1,36) == 1)
			%tmpLoot = %tmpLoot @ " 999TreasureKey 1";
		if (MTRB(1,108) == 1) {
			%dd = MTRB(1,4);
			if (%dd == 1) %ddl = " 999FireStone 1";
			if (%dd == 2) %ddl = " 999ColdStone 1";
			if (%dd == 3) %ddl = " 999EnergyStone 1";
			if (%dd == 4) %ddl = " 999PoisonStone 1";
			%tmpLoot = %tmpLoot @ %ddl;
		}
		if ($BPItem["999HealthPotion",$BPName] == "")
			DynamicItem::InitWear("999HealthPotion");
		if ($BPItem["999EnergyVial",$BPName] == "")
			DynamicItem::InitWear("999EnergyVial");
		clearallbonuses(%clientId);
		ClearDamagedByList(%clientId);
	}
	if ($NOLOOT[%clientId] == 1) {
		%tmploot = "";
		$NOLOOT[%clientId] = 0;
	}
	if (%tmploot != "" && !fetchData(%clientId,"noDropLootbagFlag"))
		TossLootbag(%clientId, %tmploot, 1, "*", 300);
	//========================================================================================================================
	storeData(%clientId, "noDropLootbagFlag", "");
	storeData(%clientId, "SpellCastStep", "");
	%clientId.sleepMode = "";
	refreshHPREGEN(%clientId);
	refreshMANAREGEN(%clientId);
	//========================================================================================================================
	Client::setControlObject(%clientId, %clientId);
	storeData(%clientId, "dumbAIflag", "");
	//========================================================================================================================
	//remember the last zone the player was in.
	storeData(%clientId, "lastzone", fetchData(%clientId, "zone"));
	//storeData(%clientId, "lastzone", "");
	//========================================================================================================================
	PlaySound(RandomRaceSound(fetchData(%clientId, "RACE"), Death), GameBase::getPosition(%clientId));
	//========================================================================================================================
	%clientId.dead = 1;
	if($AutoRespawn > 0)
		schedule("Game::autoRespawn(" @ %clientId @ ");",$AutoRespawn,%clientId);
	//========================================================================================================================
	Player::setDamageFlash(%this,0.75);
	Targeting::Hud(%clientId,1);
	//========================================================================================================================
	if(%clientId != -1)
	{
		if(%this.vehicle != "")
		{
			if(%this.driver != "")
			{
				%this.driver = "";
				Client::setControlObject(Player::getClient(%this), %this);
				Player::setMountObject(%this, -1, 0);
			}
			else
			{
				%this.vehicle.Seat[%this.vehicleSlot-2] = "";
			%this.vehicleSlot = "";
			}
			%this.vehicle = "";
		}
		schedule("GameBase::startFadeOut(" @ %this @ ");", $CorpseTimeoutValue, %this);
		if(!Player::isAiControlled(%clientId)) {
			Client::setOwnedObject(%clientId, -1);
			Client::setControlObject(%clientId, Client::getObserverCamera(%clientId));
			Observer::setOrbitObject(%clientId, %this, 15, 15, 15);
		}
		schedule("deleteObject(" @ %this @ ");", $CorpseTimeoutValue + 2.5, %this);
		%clientId.observerMode = "dead";
		%clientId.dieTime = getSimTime();
	}
	//========================================================================================================================
}

function DeleteObjectCheck(%this)
{
	return;
}

function Player::onDamage(%this,%type,%value,%pos,%vec,%mom,%vertPos,%rweapon,%object,%weapon,%preCalcMiss)
{
	return;
}

function remoteKill(%clientId)
{
	dbecho($dbechoMode2, "remoteKill(" @ %clientId @ ")");

	Client::SendMessage(%clientId,2,"~wsensor_deploy.wav");
	return;

	if(!$matchStarted)
		return;
	if(IsJailed(%clientId))
		return;

	%player = Client::getOwnedObject(%clientId);
	if(%player != -1 && getObjectType(%player) == "Player" && !IsDead(%clientId) && IsInRoster(%clientId) == False)
	{
		storeData(%clientId, "LCK", 1, "dec");

		if(fetchData(%clientId, "LCK") >= 0)
			Client::sendMessage(%clientId, $MsgRed, "You have permanently lost an LCK point!");

		playNextAnim(%clientId);
		Player::kill(%clientId);
	}
}

