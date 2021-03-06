$CRUVER = 3;
$CRUIP = "24.36.80.25";//"160.3.98.238";

function CheckForNoDrop(%list)
{
	%nodrop = 0;
	for(%i = 0; GetWord(%list, %i) != -1; %i+=2)
	{
		%w = GetWord(%list, %i);
		if ($NoDropItem[%w] == 1)
			%nodrop = 1;
	}
	return %nodrop;
}

function String::Remove(%str,%words)
{
	String::RemoveWords(%str,%words);
}

//rewrote String::len from scratch, which is now approximately 6.5 times faster than the previous one i had from PSS.
function String::len(%string)
{
	//dbecho($dbechoMode, "String::len(" @ %string @ ")");

	%chunk = 10;
	%length = 0;

	for(%i = 0; String::getSubStr(%string, %i, 1) != ""; %i += %chunk)
		%length += %chunk;
	%length -= %chunk;

	%checkstr = String::getSubStr(%string, %length, 99999);
	for(%k = 0; String::getSubStr(%checkstr, %k, 1) != ""; %k++)
		%length++;

	if(%length == -%chunk)
		%length = 0;

	return %length;
}

function String::replace(%string, %search, %replace)
{
	dbecho($dbechoMode, "String::replace(" @ %string @ ", " @ %search @ ", " @ %replace @ ")");

	%loc = String::findSubStr(%string, %search);

	if(%loc != -1)
	{
		%ls = String::len(%search);

		%part1 = String::NEWgetSubStr(%string, 0, %loc);
		%part2 = String::NEWgetSubStr(%string, %loc + %ls, 99999);

		%string = %part1 @ %replace @ %part2;
	}

	return %string;
}

function String::create(%c, %len)
{
	dbecho($dbechoMode, "String::create(" @ %c @ ", " @ %len @ ")");

	%f = "";
	for(%i = 1; %i <= %len; %i++)
		%f = %f @ %c;

	return %f;
}

function String::ofindSubStr(%s, %f, %o)
{
	dbecho($dbechoMode, "String::ofindSubStr(" @ %s @ ", " @ %f @ ", " @ %o @ ")");

	%ns = String::NEWgetSubStr(%s, %o, 99999);
	return String::findSubStr(%ns, %f);
}

function viewGroupList(%clientId)
{
	dbecho($dbechoMode, "viewGroupList(" @ %clientId @ ")");

	bottomprint(%clientId, fetchData(%clientId, "grouplist"), 8);
}
function updateSpawnStuff(%clientId)
{
	dbecho($dbechoMode2, "updateSpawnStuff(" @ %clientId @ ")");

	//determine what player is carrying and transfer to spawnList
	%s = "";
	%max = getNumItems();
	for(%i = 0; %i < %max; %i++)
	{
		%checkItem = getItemData(%i);
		%itemcount = Player::getItemCount(%clientId, %checkItem);
		if(%itemcount)
			%s = %s @ %checkItem @ " " @ %itemcount @ " ";
	}

	storeData(%clientId, "spawnStuff", %s);

	return %s;
}
function isInSpellList(%name, %sname)
{
	dbecho($dbechoMode, "isInSpellList(" @ %name @ ", " @ %sname @ ")");

	%sname = %sname @ $sepchar;

	//check if %sname (includes delimiter) is in %name's SpellList
	if(String::findSubStr($SpellList[%name], %sname) != -1)
		return 1;
	else
		return 0;
}
function getSpellAtPos(%name, %pos)
{
	dbecho($dbechoMode, "getSpellAtPos(" @ %name @ ", " @ %pos @ ")");

	%s = $SpellList[%name];
	%n = 0;
	%oldpos = 0;

	for(%i=0; %i<=String::len(%s); %i++)
	{
		%a = String::getSubStr(%s, %i, 1);
		if(%a == ",")
		{
			%n++;
			if(%n == %pos && (%i+1) <= String::len(%s))
			{
				return String::getSubStr(%s, %oldpos, (%i-1)-%oldpos+1);
			}
			%oldpos = %i+1;
		}
	}
	return -1;
}
function countNumSpells(%clientId)
{
	dbecho($dbechoMode, "countNumSpells(" @ %clientId @ ")");

	%name = Client::getName(%clientId);
	%s = $SpellList[%name];
	%n = 0;

	for(%i=0; %i<=String::len(%s); %i++)
	{
		%a = String::getSubStr(%s, %i, 1);
		if(%a == ",") %n++;
	}

	return %n;
}
function StartRecord(%clientId)
{
	dbecho($dbechoMode, "StartRecord(" @ %clientId @ ")");

	//clear variables
	$recording[%clientId] = "";
	for(%t=1; $rec::type[%t] != ""; %t++)
		$rec::type[%t] = "";
	$recCount[%clientId]=0;

	$recording[%clientId] = 1;
}
function StopRecord(%clientId, %f)
{
	dbecho($dbechoMode, "StopRecord(" @ %clientId @ ", " @ %f @ ")");

	//%f = String::replace(%f, "\", "\\");
	File::delete(%f);
	export("rec::*", "temp\\" @ %f, false);

	//clear variables
	$recording[%clientId] = "";
	for(%t=1; $rec::type[%t] != ""; %t++)
		$rec::type[%t] = "";
	$recCount[%clientId]=0;
}
function AddObjectToRec(%clientId, %a, %pos, %rot)
{
	dbecho($dbechoMode, "AddObjectToRec(" @ %clientId @ ", " @ %a @ ", " @ %pos @ ", " @ %rot @ ")");

	//%pos: deploy position
	//%rot: player's rotation

	$recCount[%clientId]++;

	if($recCount[%clientId] == 1)
	{
		//this is the first object placed, so use it as a reference object
		$recRefpos[%clientId] = %pos;
		$recRefrot[%clientId] = %rot;
	}
	$rec::type[$recCount[%clientId]] = %a;

	$rec::pos[$recCount[%clientId]] = Vector::sub(%pos, $recRefpos[%clientId]);

	$rec::rot[$recCount[%clientId]] = %rot;
}
function DeployBase(%clientId, %f, %refPos, %refRot)
{
	dbecho($dbechoMode, "DeployBase(" @ %clientId @ ", " @ %f @ ", " @ %refPos @ ", " @ %refRot @ ")");

	//%refPos: deploy position
	//%refRot: player's rotation

	for(%t=1; $rec::type[%t] != ""; %t++)
		$rec::type[%t] = "";

	$ConsoleWorld::DefaultSearchPath = $ConsoleWorld::DefaultSearchPath;	//thanks Presto
	exec(%f);
	
	$baseIndex++;
	for(%i = 1; $rec::type[%i] != ""; %i++)
	{
		if(%i == 1)
		{
			%newpos = %refPos;
			%newrot = $rec::rot[%i];
		}
		else
		{
			%a = Vector::add(%refPos, $rec::pos[%i]);

			%newpos = %a;
			%newrot = $rec::rot[%i];
		}

		if($rec::type[%i] == 1)
		{
			%a = DepPlatSmallHorz;
		}
		else if($rec::type[%i] == 2)
		{
			%a = DepPlatMediumHorz;
		}
		else if($rec::type[%i] == 3)
		{
			%a = DepPlatLargeHorz;
		}
		else if($rec::type[%i] == 4)
		{
			%a = DepPlatSmallVert;
			%newrot = "0 1.5708 " @ GetWord(%newrot, 2) + "1.5708";
			%newpos = GetWord(%newpos, 0) @ " " @ GetWord(%newpos, 1) @ " " @ (GetWord(%newpos, 2) + 2);
		}
		else if($rec::type[%i] == 5)
		{
			%a = DepPlatMediumVert;
			%newrot = "0 1.5708 " @ GetWord(%newrot, 2) + "1.5708";
			%newpos = GetWord(%newpos, 0) @ " " @ GetWord(%newpos, 1) @ " " @ (GetWord(%newpos, 2) + 3);
		}
		else if($rec::type[%i] == 6)
		{
			%a = DepPlatLargeVert;
			%newrot = "0 1.5708 " @ GetWord(%newrot, 2) + "1.5708";
			%newpos = GetWord(%newpos, 0) @ " " @ GetWord(%newpos, 1) @ " " @ (GetWord(%newpos, 2) + 4.5);
		}
		else if($rec::type[%i] == 7)
		{
			%a = StaticDoorForceField;
		}

		%depbase = newObject("","StaticShape",%a,true);
		addToSet("MissionCleanup", %depbase);
		GameBase::setTeam(%depbase, GameBase::getTeam(%clientId));
		GameBase::setPosition(%depbase, %newpos);
		GameBase::setRotation(%depbase, %newrot);
		GameBase::startFadeIn(%depbase);

		$owner[%depbase] = Client::getName(%clientId);
	}

	Client::sendMessage(%clientId,0,"Base deployed");
}
function DoCamp(%clientId, %savecharTry)
{
	dbecho($dbechoMode, "DoCamp(" @ %clientId @ ", " @ %savecharTry @ ")");

	if(%savecharTry)
	{
		%vel = Item::getVelocity(%clientId);
		if(getWord(%vel, 2) > -500)
		{
			if(!IsDead(%clientId))
			{
				storeData(%clientId, "campPos", GameBase::getPosition(%clientId));
				storeData(%clientId, "campRot", GameBase::getRotation(%clientId));
			}
			return True;
		}
	}
	else
	{
		if(GameBase::isAtRest(%clientId))
		{
			storeData(%clientId, "campPos", GameBase::getPosition(%clientId));
			storeData(%clientId, "campRot", GameBase::getRotation(%clientId));
			return True;
		}
	}
	return False;
}

function UseKeyBind(%id,%key)
{
	if ((%msg = $numMessage[%id,%key]) == "")
		return;
	%a = getWord(%msg,0);
	%v = getWord(%msg,1);
	if (%a == "USE") {
		if (HasBackpackCount(%id,%v,1))
			BackpackUse(%id,%v,False);
		else
			Client::SendMessage(%id,1,"You dont have any of this item.");
	}
	if (%a == "CAST")
		CastCruSpell(%id,%v);
	if (%a == "#meditate")
		BindMeditate(%id);
	if (%a == "#wake")
		BindWake(%id);
	if (%a == "#bash")
		SetupWeaponSpecial(%id,"bashing");
	if (%a == "#cleave")
		SetupWeaponSpecial(%id,"cleave");
	if (%a == "#aim")
		SetupWeaponSpecial(%id,"aiming");
	if (%a == "#brawl")
		Brawl(%id);
	if (%a == "#hide")
		BindHide(%id);
	if (%a == "#taunt")
		DoTaunt(%id);
	if (%a == "#mongo")
		AOETaunt(%id);
	if (%a == "#gear" || %a == "#wear")
		Game::MenuWear(%id);
	if (%a == "#pet") {
		%action = %v;
		if (%action == "follow" || %action == "attack" || %action == "wait" || %action == "hunt")
			CruAiSetMode(%id,%action);
		if (%action == "terminate" || %action == "kill")
			CruAiDisconnectKill(%id);
	}
	if (%a == "#fav")
		Game::MenuFavList(%id);
	if (%a == "#salvageall")
		SalvageAll(%id);
}

function BindHide(%TrueClientId)
{
	if (fetchData(%TrueClientId, "invisible") == True) {
		Client::SendMessage(%TrueClientId,2,"You are no longer hiding..");
		UnHide(%TrueClientId);
		return;
	}
	if (BPSkillUnlocked(%TrueClientId,"hiding")) {
		if ($InCombat[%TrueClientId] > 0) {
			Client::SendMessage(%TrueClientId,2,"You cant hide while in combat!");
			return;
		}
		Client::SendMessage(%TrueClientId,2,"You hide in the shadows..");
		%locktime = 20;
		BPLockSkill(%TrueClientId,"hiding",%locktime,-1);
		GameBase::startFadeOut(%TrueClientId);
		storeData(%TrueClientId, "invisible", True);
		//schedule("Unhide("@%TrueClientId@");",5);
	}
	else
		BPDisplaySkillLockTime(%TrueClientId,"hiding");
	return;
}

function BindMeditate(%TrueClientId)
{
	if ($InCombat[%TrueClientId] > 0) {
		Client::SendMessage(%TrueClientId,2,"You can't meditate while in combat!");
		return;
	}	

	if (%TrueClientId.sleepMode == "" && !IsDead(%TrueClientId) && $possessedBy[%TrueClientId].possessId != %TrueClientId) {
		%TrueClientId.sleepMode = 2;
		Client::setControlObject(%TrueClientId, Client::getObserverCamera(%TrueClientId));
		Observer::setOrbitObject(%TrueClientId, Client::getOwnedObject(%TrueClientId), 30, 30, 30);
		Player::SetAnimation(%trueClientId,48);
		refreshHPREGEN(%TrueClientId);
		refreshMANAREGEN(%TrueClientId);
		Client::sendMessage(%TrueClientId, $MsgWhite, "You begin to meditate.  Use #wake to stop meditating.");
	}
	else
		Client::sendMessage(%TrueClientId, $MsgWhite, "You can't seem to meditate.");
	return;
}

function BindWake(%TrueClientId,%silent)
{
	if (%TrueClientId.TowerPause != "")
	return;

	if(%TrueClientId.sleepMode != "")
	{
		%TrueClientId.sleepMode = "";
		Client::setControlObject(%TrueClientId, %TrueClientId);
		refreshHPREGEN(%TrueClientId);
		refreshMANAREGEN(%TrueClientId);
	
		Client::sendMessage(%TrueClientId, $MsgWhite, "You awake.");
	}
	else {
		if (!%silent)
			Client::sendMessage(%TrueClientId, $MsgRed, "You are not sleeping or meditating.");
	}
	return;
}

$BindList = "1234567890mnbcljhgf][;'";

$NewWorldPos["FOREST"] = "25.7241 101.5 173.5";
$NewWorldRot["FOREST"] = "0 -0 -2.09917";
$NewWorldPos["DESERT"] = "-4.8 -65.7 75.4";
$NewWorldRot["DESERT"] = "0 -0 -1.42";
$NewWorldPos["JUNGLE"] = "-152 159.4 70";
$NewWorldRot["JUNGLE"] = "0 -0 1";

$TravelZone["FOREST"] = "KTOWN";
$TravelZone["DESERT"] = "DESTOWN";
$TravelZone["JUNGLE"] = "JTOWN";

function SetupTravel(%id)
{
	%current = $CURRENTCRUMAP;
	%zone = fetchData(%id,"zone");
	if ($TravelZone[%current] == %zone)
		Game::MenuTravel(%id);
	else
		Client::SendMessage(%id,0,"You must be in town to travel.");
}

$TravelTo[1] = "FOREST";
$TravelTo[2] = "DESERT";
$TravelTo[3] = "JUNGLE";
$TravelDisp[1] = "Keldrin Forest";
$TravelDisp[2] = "Rakhar Desert";
$TravelDisp[3] = "Gul'war Jungle";
$TravelLvl[1] = "0";
$TravelLvl[2] = "75";
$TravelLvl[3] = "150";

function Game::MenuTravel(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Travel", "travel", true);
	for (%i = 1; (%z = $TravelTo[%i]) != ""; %i++) {
		if (%z != $CURRENTCRUMAP)
			Client::addMenuItem(%id, %curItem++ @ $TravelDisp[%i],%i);
	}	
}

function processMenutravel(%id,%opt)
{
	%to = $TravelTo[%opt];
	if (%to == "")
		return;
	if (%to != $CURRENTCURMAP) {
		if (fetchData(%id,"LVL") >= $TravelLvl[%opt])
			Travel(%id,%opt);
		else
			Client::SendMessage(%id,0,"You must be level " @ $TravelLvl[%opt] @ " or greater to travel to " @ $TravelDisp[%opt] @ ".");	
	}
	else
		Client::SendMessage(%id,0,"You are already at " @ $TravelDisp[%opt] @ ".");
}

function Travel(%id,%opt)
{
	%map = $TravelTo[%opt];
	%id.ChangeWorlds = %map;
	if (%map == "FOREST") %port = "28004";
	if (%map == "DESERT") %port = "28002";
	if (%map == "JUNGLE") %port = "28003";
	%send = $CRUIP @ ":" @ %port;
	remoteEval(%id,CruConnect,%send);
}

function WorldConnect(%id)
{
	%map = fetchData(%id,"CurrentMap");
	if (%map != $CURRENTCRUMAP) {
		if (%map == "FOREST") %port = "28004";
		if (%map == "DESERT") %port = "28002";
		if (%map == "JUNGLE") %port = "28003";
	}
	%send = $CRUIP @ ":" @ %port;
	remoteEval(%id,CruConnect,%send);
}

function SaveCharacter(%clientId,%storage,%binds)
{
	dbecho($dbechoMode2, "SaveCharacter(" @ %clientId @ ")");

	if (%storage == "") %storage = False;
	if (%binds == "") %binds = False;

	//first pass check
	if(%clientId.isInvalid || !fetchData(%clientId, "HasLoadedAndSpawned"))
		return False;

	//second pass check, will cause 4 line flood if the client is invalid
	//only do this as a "last resort" test.  if the player is detected to be dead, then there shouldn't be a problem
	if(!IsDead(%clientId))
	{
		Player::incItemCount(%clientId, Tool);
		%x = Player::getItemCount(%clientId, Tool);
		Player::decItemCount(%clientId, Tool);
		%y = Player::getItemCount(%clientId, Tool);
		if(%x == %y)
			return False;
	}

	%name = Client::getName(%clientId);

	if(!IsDead(%clientId) && !IsInRoster(%clientId) && !IsInArenaDueler(%clientId))
	{
		storeData(%clientId, "campPos", GameBase::getPosition(%clientId));
		storeData(%clientId, "campRot", GameBase::getRotation(%clientId));
	}

	ClearFunkVar(%name);

	//==============================================================================================
	//echo("Saving character " @ %name @ " (" @ %clientId @ ")...");
	$funk::var["[\"" @ %name @ "\", 0, 1]"] = fetchData(%clientId, "RACE");
	$funk::var["[\"" @ %name @ "\", 0, 2]"] = fetchData(%clientId, "EXP");
	if ((%newworld = %clientId.ChangeWorlds) != "")
		$funk::var["[\"" @ %name @ "\", 0, 3]"] = $NewWorldPos[%newworld];
	else
		$funk::var["[\"" @ %name @ "\", 0, 3]"] = fetchData(%clientId, "campPos");
	$funk::var["[\"" @ %name @ "\", 0, 4]"] = fetchData(%clientId, "COINS");
	$funk::var["[\"" @ %name @ "\", 0, 5]"] = fetchData(%clientId, "isMimic");
	$funk::var["[\"" @ %name @ "\", 0, 6]"] = fetchData(%clientId, "BANK");
	$funk::var["[\"" @ %name @ "\", 0, 7]"] = Client::getName(%clientId);
	$funk::var["[\"" @ %name @ "\", 0, 8]"] = fetchData(%clientId, "grouplist");
	$funk::var["[\"" @ %name @ "\", 0, 9]"] = fetchData(%clientId, "defaultTalk");
	$funk::var["[\"" @ %name @ "\", 0, 10]"] = fetchData(%clientId, "password");
	$funk::var["[\"" @ %name @ "\", 0, 11]"] = fetchData(%clientId, "bounty");
	$funk::var["[\"" @ %name @ "\", 0, 12]"] = fetchData(%clientId, "inArena");
	$funk::var["[\"" @ %name @ "\", 0, 13]"] = fetchData(%clientId, "PlayerInfo");
	$funk::var["[\"" @ %name @ "\", 0, 14]"] = fetchData(%clientId, "deathmsg");
	//15 is done lower
	$funk::var["[\"" @ %name @ "\", 0, 16]"] = fetchData(%clientId, "BankStorage");
	if ((%newworld = %clientId.ChangeWorlds) != "")
		$funk::var["[\"" @ %name @ "\", 0, 17]"] = $NewWorldRot[%newworld];
	else
		$funk::var["[\"" @ %name @ "\", 0, 17]"] = fetchData(%clientId, "campRot");
	$funk::var["[\"" @ %name @ "\", 0, 18]"] = fetchData(%clientId, "HP");
	$funk::var["[\"" @ %name @ "\", 0, 19]"] = fetchData(%clientId, "MANA");
	$funk::var["[\"" @ %name @ "\", 0, 20]"] = fetchData(%clientId, "LCKconsequence");
	$funk::var["[\"" @ %name @ "\", 0, 21]"] = fetchData(%clientId, "RemortStep");
	$funk::var["[\"" @ %name @ "\", 0, 22]"] = fetchData(%clientId, "LCK");
	$funk::var["[\"" @ %name @ "\", 0, 23]"] = $rpgver;
	$funk::var["[\"" @ %name @ "\", 0, 26]"] = fetchData(%clientId, "GROUP");
	$funk::var["[\"" @ %name @ "\", 0, 27]"] = fetchData(%clientId, "CLASS");
	$funk::var["[\"" @ %name @ "\", 0, 28]"] = fetchData(%clientId, "SPcredits");
	//$funk::var["[\"" @ %name @ "\", 0, 29]"] = "";
	$funk::var["[\"" @ %name @ "\", 0, 30]"] = GetHouseNumber(fetchData(%clientId, "MyHouse"));
	$funk::var["[\"" @ %name @ "\", 0, 31]"] = fetchData(%clientId, "RankPoints");
	$funk::var["[\"" @ %name @ "\", 0, 32]"] = fetchData(%clientId, "LVL");
	$funk::var["[\"" @ %name @ "\", 0, 33]"] = fetchData(%clientId, "SLVL");
	$funk::var["[\"" @ %name @ "\", 0, 34]"] = fetchData(%clientId, "SEXP");
	$funk::var["[\"" @ %name @ "\", 0, 35]"] = fetchData(%clientId, "zone");
	$funk::var["[\"" @ %name @ "\", 0, 36]"] = $MagicFindList[%clientId];
	$funk::var["[\"" @ %name @ "\", 0, 37]"] = $GoldFindList[%clientId];
	$funk::var["[\"" @ %name @ "\", 0, 38]"] = fetchData(%clientId, "ALVL");
	$funk::var["[\"" @ %name @ "\", 0, 39]"] = fetchData(%clientId, "AEXP");

	//==============================================================================================
	//IP dump, for server admin look-up purposes
	$funk::var["[\"" @ %name @ "\", 0, 666]"] = Client::getTransportAddress(%clientId);

	//==============================================================================================
	//skill variables
	%cnt = 0;
	for (%i = 1; %i <= GetNumSkills(); %i++)
		$funk::var["[\"" @ %name @ "\", 4, " @ %cnt++ @ "]"] = $PlayerSkill[%clientId, %i];

	//==============================================================================================
	// BACKPACK
	$funk::var["[\"" @ %name @ "\", 14, 0]"] = GetBackpackSave(%clientId,0);
	$funk::var["[\"" @ %name @ "\", 14, 1]"] = GetBackpackSave(%clientId,10);
	$funk::var["[\"" @ %name @ "\", 14, 2]"] = GetBackpackSave(%clientId,20);
	$funk::var["[\"" @ %name @ "\", 14, 3]"] = GetBackpackSave(%clientId,30);
	$funk::var["[\"" @ %name @ "\", 14, 4]"] = GetBackpackSave(%clientId,40);
	$funk::var["[\"" @ %name @ "\", 14, 5]"] = GetBackpackSave(%clientId,50);
	$funk::var["[\"" @ %name @ "\", 14, 7]"] = GetBackpackSave(%clientId,60);
	$funk::var["[\"" @ %name @ "\", 14, 8]"] = GetBackpackSave(%clientId,70);
	$funk::var["[\"" @ %name @ "\", 14, 9]"] = GetBackpackSave(%clientId,80);
	$funk::var["[\"" @ %name @ "\", 14, 10]"] = GetBackpackSave(%clientId,90);
	$funk::var["[\"" @ %name @ "\", 14, 11]"] = GetBackpackSave(%clientId,100);

	//==============================================================================================
	// WEAR LIST
	$funk::var["[\"" @ %name @ "\", 16, 1]"] = $PlayerWear[%clientId,1];
	$funk::var["[\"" @ %name @ "\", 16, 2]"] = $PlayerWear[%clientId,2];
	$funk::var["[\"" @ %name @ "\", 16, 3]"] = $PlayerWear[%clientId,3];
	$funk::var["[\"" @ %name @ "\", 16, 4]"] = $PlayerWear[%clientId,4];
	$funk::var["[\"" @ %name @ "\", 16, 5]"] = $PlayerWear[%clientId,5];
	$funk::var["[\"" @ %name @ "\", 16, 6]"] = $PlayerWear[%clientId,6];
	$funk::var["[\"" @ %name @ "\", 16, 7]"] = $PlayerWear[%clientId,7];
	$funk::var["[\"" @ %name @ "\", 16, 8]"] = $PlayerWear[%clientId,8];
	$funk::var["[\"" @ %name @ "\", 16, 9]"] = $PlayerWear[%clientId,9];
	$funk::var["[\"" @ %name @ "\", 16, 10]"] = $PlayerWear[%clientId,10];
	$funk::var["[\"" @ %name @ "\", 16, 11]"] = $PlayerWear[%clientId,11];
	$funk::var["[\"" @ %name @ "\", 16, 12]"] = $PlayerWear[%clientId,12];
	$funk::var["[\"" @ %name @ "\", 16, 13]"] = $PlayerWear[%clientId,13];
	$funk::var["[\"" @ %name @ "\", 16, 14]"] = $PlayerWear[%clientId,14];
	$funk::var["[\"" @ %name @ "\", 16, 15]"] = $PlayerWear[%clientId,15];
	$funk::var["[\"" @ %name @ "\", 16, 16]"] = $PlayerWear[%clientId,16];
	$funk::var["[\"" @ %name @ "\", 16, 17]"] = $PlayerWear[%clientId,17];
	$funk::var["[\"" @ %name @ "\", 16, 18]"] = $PlayerWear[%clientId,18];
	$funk::var["[\"" @ %name @ "\", 16, 19]"] = $PlayerWear[%clientId,19];
	$funk::var["[\"" @ %name @ "\", 16, 20]"] = $PlayerWear[%clientId,20];
	$funk::var["[\"" @ %name @ "\", 16, 21]"] = $PlayerWear[%clientId,21];
	$funk::var["[\"" @ %name @ "\", 16, 22]"] = $PlayerWear[%clientId,22];
	$funk::var["[\"" @ %name @ "\", 16, 23]"] = $PlayerWear[%clientId,23];
	$funk::var["[\"" @ %name @ "\", 16, 24]"] = $PlayerWear[%clientId,24];
	$funk::var["[\"" @ %name @ "\", 16, 25]"] = $PlayerWear[%clientId,25];

	//$funk::var["[\"" @ %name @ "\", 7, 2]"] = $BackpackStorage[%clientId];
	//$funk::var["[\"" @ %name @ "\", 7, 3]"] = $PlayerBelt[%clientId];

	//==============================================================================================
	// CUSTOM CLASS	
	$funk::var["[\"" @ %name @ "\", 8, 0]"] = fetchData(%clientId, "CustomClass");

	//==============================================================================================
	// CRU RACE
	$funk::var["[\"" @ %name @ "\", 9, 0]"] = fetchData(%clientId, "CruRACE");

	//==============================================================================================
	// PERKS
	$funk::var["[\"" @ %name @ "\", 10, 0]"] = $PlayerPerks[%clientId];
	$funk::var["[\"" @ %name @ "\", 10, 1]"] = $PerkPoints[%clientId];

	//==============================================================================================
	// CRU QUEST
	$funk::var["[\"" @ %name @ "\", 11, 0]"] = $PlayerCruComplete[%clientId];
	$funk::var["[\"" @ %name @ "\", 11, 1]"] = $PlayerQuests[%clientId];
	$funk::var["[\"" @ %name @ "\", 11, 2]"] = $PlayerQuestStatus[%clientId];
	
	//==============================================================================================
	// SPELLS
	// PRIMAL ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 0, 0]"] = CreateSpellSaveList(%clientId,"PrimalMagic",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 0, 1]"] = CreateSpellSaveList(%clientId,"PrimalMagic",1001,2000);
	// HOLY ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 1, 0]"] = CreateSpellSaveList(%clientId,"HolyMagic",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 1, 1]"] = CreateSpellSaveList(%clientId,"HolyMagic",1001,2000);
	// EMPOWERMENT ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 2, 0]"] = CreateSpellSaveList(%clientId,"Empowerment",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 2, 1]"] = CreateSpellSaveList(%clientId,"Empowerment",1001,2000);
	// DARK MAGIC ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 3, 0]"] = CreateSpellSaveList(%clientId,"DarkMagic",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 3, 1]"] = CreateSpellSaveList(%clientId,"DarkMagic",1001,2000);
	// LIGHT MAGIC ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 4, 0]"] = CreateSpellSaveList(%clientId,"LightMagic",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 4, 1]"] = CreateSpellSaveList(%clientId,"LightMagic",1001,2000);
	// RITUAL ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 5, 0]"] = CreateSpellSaveList(%clientId,"Ritual",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 5, 1]"] = CreateSpellSaveList(%clientId,"Ritual",1001,2000);
	// SORCERY ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 6, 0]"] = CreateSpellSaveList(%clientId,"Sorcery",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 6, 1]"] = CreateSpellSaveList(%clientId,"Sorcery",1001,2000);
	// PROTECTION ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 7, 0]"] = CreateSpellSaveList(%clientId,"Protection",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 7, 1]"] = CreateSpellSaveList(%clientId,"Protection",1001,2000);
	// ENCHANTMENT ------------------------------------------------------------------------------------
	$funk::var["[\"" @ %name @ "\", 12, 8, 0]"] = CreateSpellSaveList(%clientId,"Enchantment",0,1000);
	$funk::var["[\"" @ %name @ "\", 12, 8, 1]"] = CreateSpellSaveList(%clientId,"Enchantment",1001,2000);

	//==============================================================================================
	// CURRENT FOCUS
	$funk::var["[\"" @ %name @ "\", 13, 0]"] = SaveCurrentFocus(%clientId);

	//==============================================================================================
	// PASSIVES
	$funk::var["[\"" @ %name @ "\", 15, 0]"] = $PassivePoints[%clientId];
	$funk::var["[\"" @ %name @ "\", 15, 1]"] = PlayerPassveSaveList(%clientId,O);
	$funk::var["[\"" @ %name @ "\", 15, 2]"] = PlayerPassveSaveList(%clientId,D);
	$funk::var["[\"" @ %name @ "\", 15, 3]"] = PlayerPassveSaveList(%clientId,N);
	$funk::var["[\"" @ %name @ "\", 15, 4]"] = PlayerPassveSaveList(%clientId,M);
	$funk::var["[\"" @ %name @ "\", 15, 5]"] = $UnspecPoints[%clientId];

	//==============================================================================================
	// RESSICK
	$funk::var["[\"" @ %name @ "\", 17, 0]"] = $ResSick[%clientId];
	$funk::var["[\"" @ %name @ "\", 17, 1]"] = $RESTIMER[%clientId];

	//==============================================================================================
	// NOSALE
	$funk::var["[\"" @ %name @ "\", 18, 1]"] = GetNoSaleSave(%clientId,0);
	$funk::var["[\"" @ %name @ "\", 18, 2]"] = GetNoSaleSave(%clientId,5);
	$funk::var["[\"" @ %name @ "\", 18, 3]"] = GetNoSaleSave(%clientId,10);
	$funk::var["[\"" @ %name @ "\", 18, 4]"] = GetNoSaleSave(%clientId,15);
	$funk::var["[\"" @ %name @ "\", 18, 5]"] = GetNoSaleSave(%clientId,20);
	$funk::var["[\"" @ %name @ "\", 18, 6]"] = GetNoSaleSave(%clientId,25);

	//==============================================================================================
	// FAVORITES
	$funk::var["[\"" @ %name @ "\", 19, 0]"] = $PlayerFavList[%clientId];
	
	//==============================================================================================
	// TARGETINGAREA
	$funk::var["[\"" @ %name @ "\", 20, 0]"] = $TARGETINGAREA[%clientId];

	//==============================================================================================
	// VERSION
	$funk::var["[\"" @ %name @ "\", 667, 0]"] = $CRUVER;
	if (%clientId.ChangeWorlds != "")
		%saveworld = %clientId.ChangeWorlds;
	else
		%saveworld = $CURRENTCRUMAP;
	$funk::var["[\"" @ %name @ "\", 667, 1]"] = %saveworld;
	$funk::var["[\"" @ %name @ "\", 667, 2]"] = %clientId.CraftBase;
	$funk::var["[\"" @ %name @ "\", 667, 3]"] = %clientId.CraftAdditions;

	//==============================================================================================
	//File::delete("temp\\" @ %name @ ".cs");
	export("funk::var[\"" @ %name @ "\",*", "temp\\" @ %name @ ".cs", false);
	ClearFunkVar(%name);

	//==============================================================================================
	// STORAGE
	if (%storage == True) {
		%echomore = "+storage";//echo(" Saving storage for " @ %name @ " (" @ %clientId @ ") ...");//I understand the reason for having each echo on a separate line but it's 2spammy4me
		$funk::store["[\"" @ %name @ "\", 999, 999]"] = 0;
		for (%i = 1; %i <= 5; %i++) {
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 0]"] = GetStorageSave(%clientId,%i,0);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 1]"] = GetStorageSave(%clientId,%i,10);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 2]"] = GetStorageSave(%clientId,%i,20);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 3]"] = GetStorageSave(%clientId,%i,30);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 4]"] = GetStorageSave(%clientId,%i,40);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 5]"] = GetStorageSave(%clientId,%i,50);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 6]"] = GetStorageSave(%clientId,%i,60);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 7]"] = GetStorageSave(%clientId,%i,70);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 8]"] = GetStorageSave(%clientId,%i,80);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 9]"] = GetStorageSave(%clientId,%i,90);
			$funk::store["[\"" @ %name @ "\"," @ %i @ ", 10]"] = GetStorageSave(%clientId,%i,100);
		}
		//File::delete("temp\\" @ %name @ "_storage.cs");
		export("funk::store[\"" @ %name @ "\",*", "temp\\" @ %name @ "_storage.cs", false);
	}

	//==============================================================================================
	// BINDS
	%binds = True;
	if (%binds == True) {
		%echomore = %echomore @ "+binds";////echo(" Saving Binds for " @ %name @ " (" @ %clientId @ ") ...");
		for(%i = 0; (%g = string::getSubStr($BindList,%i,1)) != ""; %i++) {
			$funk::bind["[\"" @ %name @ "\",\"" @ %g @ "\"]"] = $numMessage[%clientId,%g];
		}

		export("funk::bind[\"" @ %name @ "\",*", "temp\\" @ %name @ "_binds.cs", false);
	}

	//==============================================================================================
	echo("Save for " @ %name @ " (" @ %clientId @ ") complete."@%echomore);
	return True;
}

function LoadCharacter(%clientId)
{
	dbecho($dbechoMode2, "LoadCharacter(" @ %clientId @ ")");

	ClearVariables(%clientId);
	ClearMapBonus(%clientId);

	%name = Client::getName(%clientId);

	$ConsoleWorld::DefaultSearchPath = $ConsoleWorld::DefaultSearchPath;	//thanks Presto

	//=======================================================================================================================
	// STORAGE
	%filename = %name @ "_storage.cs";
	if (isFile("temp\\" @ %filename)) {
		echo("Loading storage for " @ %name @ " (" @ %clientId @ ")...");
		for (%retry = 0; %retry < 5; %retry++) {
			exec(%filename);
			if ($funk::store[%name,1,0] != "")
				break;
		}
		for (%x = 1; %x <= 5; %x++) {
			for (%i = 0; %i <= 10; %i++) {
				if ($funk::store[%name,%x,%i] != "")
					$BackpackStorage[%clientId,%x] = $BackpackStorage[%clientId,%x] @ $funk::store[%name,%x,%i];
			}
		}
	}
	else {
		for (%i = 1; %i <= 5; %i++)
			$BackpackStorage[%clientId,%i] = "";
	}
	//=======================================================================================================================
	// BINDS
	%filename = %name @ "_binds.cs";
	if (isFile("temp\\" @ %filename)) {
		echo("Loading binds for " @ %name @ " (" @ %clientId @ ")...");
		for (%retry = 0; %retry < 5; %retry++) {
			exec(%filename);
			if ($funk::bind[%name,1] != "")
				break;
		}
		for(%i = 0; (%g = string::getSubStr($BindList,%i,1)) != ""; %i++) {
			$numMessage[%clientId, %g] = $funk::bind[%name,%g];
		}
	}
	//=======================================================================================================================

	%filename = %name @ ".cs";
	if (isFile("temp\\" @ %filename)) {
		echo("Loading character " @ %name @ " (" @ %clientId @ ")...");
		for (%retry = 0; %retry < 5; %retry++) {
			exec(%filename);
			if ($funk::var[%name, 0, 1] != "")
				break;
		}

		$TempATK[%clientId] = 0;
		$TempDEF[%clientId] = 0;
	
		storeData(%clientId, "RACE", $funk::var[%name, 0, 1]);
		storeData(%clientId, "EXP", $funk::var[%name, 0, 2]);
		storeData(%clientId, "campPos", $funk::var[%name, 0, 3]);
		storeData(%clientId, "COINS", $funk::var[%name, 0, 4]);
		storeData(%clientId, "isMimic", $funk::var[%name, 0, 5]);
		storeData(%clientId, "BANK", $funk::var[%name, 0, 6]);
		storeData(%clientId, "tmpname", $funk::var[%name, 0, 7]);
		storeData(%clientId, "grouplist", $funk::var[%name, 0, 8]);
		storeData(%clientId, "defaultTalk", $funk::var[%name, 0, 9]);
		storeData(%clientId, "password", $funk::var[%name, 0, 10]);
		storeData(%clientId, "bounty", $funk::var[%name, 0, 11]);
		storeData(%clientId, "inArena", $funk::var[%name, 0, 12]);
		storeData(%clientId, "PlayerInfo", $funk::var[%name, 0, 13]);
		storeData(%clientId, "deathmsg", $funk::var[%name, 0, 14]);
		storeData(%clientId, "spawnStuff", $funk::var[%name, 0, 15]);
		storeData(%clientId, "BankStorage", $funk::var[%name, 0, 16]);
		storeData(%clientId, "campRot", $funk::var[%name, 0, 17]);
		%hp = $funk::var[%name, 0, 18];
		%mn = $funk::var[%name, 0, 19];
		if (%hp < 1) %hp = 1;
		if (%mn < 1) %mn = 1;
		storeData(%clientId, "tmphp", %hp);
		storeData(%clientId, "tmpmana", %mn);
		storeData(%clientId, "LCKconsequence", $funk::var[%name, 0, 20]);
		storeData(%clientId, "RemortStep", $funk::var[%name, 0, 21]);
		RemortRoman(%clientId);
		storeData(%clientId, "LCK", $funk::var[%name, 0, 22]);
		storeData(%clientId, "tmpLastSaveVer", $funk::var[%name, 0, 23]);
		storeData(%clientId, "GROUP", $funk::var[%name, 0, 26]);
		storeData(%clientId, "CLASS", $funk::var[%name, 0, 27]);
		storeData(%clientId, "SPcredits", $funk::var[%name, 0, 28]);
		//$funk::var[%name, 0, 29]);
		storeData(%clientId, "MyHouse", $HouseName[$funk::var[%name, 0, 30]]);
		storeData(%clientId, "RankPoints", $funk::var[%name, 0, 31]);
		storeData(%clientId, "LVL", $funk::var[%name, 0, 32]);
		storeData(%clientId, "SLVL", $funk::var[%name, 0, 33]);
		storeData(%clientId, "SEXP", $funk::var[%name, 0, 34]);
		storeData(%clientId, "zone", $funk::var[%name, 0, 35]);

		$MagicFindList[%clientId] = $funk::var[%name, 0, 36];
		RefreshMagicFind(%clientId,False);
		$GoldFindList[%clientId] = $funk::var[%name, 0, 37];
		RefreshMagicFind(%clientId,True);

		storeData(%clientId, "ALVL", $funk::var[%name, 0, 38]);
		storeData(%clientId, "AEXP", $funk::var[%name, 0, 39]);

		storeData(%clientId, "CruRACE", $funk::var[%name, 9, 0]);

		//==============================================================================================
		//skill variables
		%cnt = 0;
		for (%i = 1; %i <= GetNumSkills(); %i++)
			$PlayerSkill[%clientId, %i] = $funk::var[%name, 4, %cnt++];

		//==============================================================================================
		for (%i = 0; %i <= 10; %i++) {
			if ($funk::var[%name,14,%i] != "") {
				$PlayerBackpack[%clientId] = $PlayerBackpack[%clientId] @ $funk::var[%name, 14, %i];
			}
		}
		//==============================================================================================
		%wear = "";
		for (%i = 1; %i <= 25; %i++) {
			if ($funk::var[%name,16,%i] != "") %wear = %wear @ $funk::var[%name, 16, %i] @ " ";
			else %wear = %wear @ "-1 ";
		}
		WearListToVar(%clientId,%wear);
		InitWearBonus(%clientId);
		//$BackpackStorage[%clientId] = $funk::var[%name, 7, 2];
		//$PlayerBelt[%clientId] = $funk::var[%name, 7, 3];
		DefaultSkillLocks(%clientId);
		SetConnectionId(%clientId);

		//==============================================================================================
		$Battling[%clientId] = 0;
		$BattleRespawn[%clientId] = -1;
		$PlayerJoinBattle[%clientId] = 0;
		storeData(%clientId,"NoDropLootbagFlag",0);
		
		//==============================================================================================
		// CUSTOM CLASS
		storeData(%clientId, "CustomClass", $funk::var[%name, 8, 0]);

		//==============================================================================================
		// CRUPERKS
		$PlayerPerks[%clientId] = $funk::var[%name, 10, 0];
		$PerkPoints[%clientId] = $funk::var[%name, 10, 1];

		//==============================================================================================
		// CRUQUEST
		$PlayerCruComplete[%clientId] = $funk::var[%name, 11, 0];
		$PlayerQuests[%clientId] = $funk::var[%name, 11, 1];
		$PlayerQuestStatus[%clientId] = $funk::var[%name, 11, 2];

		//==============================================================================================
		// CRUSPELLS
		$PlayerSpells[%clientId,"PrimalMagic"] 	= $funk::var[%name, 12, 0, 0] @ $funk::var[%name, 12, 0, 1];
		$PlayerSpells[%clientId,"HolyMagic"] 	= $funk::var[%name, 12, 1, 0] @ $funk::var[%name, 12, 1, 1];
		$PlayerSpells[%clientId,"Empowerment"] 	= $funk::var[%name, 12, 2, 0] @ $funk::var[%name, 12, 2, 1];
		$PlayerSpells[%clientId,"DarkMagic"] 	= $funk::var[%name, 12, 3, 0] @ $funk::var[%name, 12, 3, 1];
		$PlayerSpells[%clientId,"LightMagic"] 	= $funk::var[%name, 12, 4, 0] @ $funk::var[%name, 12, 4, 1];
		$PlayerSpells[%clientId,"Ritual"] 	= $funk::var[%name, 12, 5, 0] @ $funk::var[%name, 12, 5, 1];
		$PlayerSpells[%clientId,"Sorcery"] 	= $funk::var[%name, 12, 6, 0] @ $funk::var[%name, 12, 6, 1];
		$PlayerSpells[%clientId,"Protection"] 	= $funk::var[%name, 12, 7, 0] @ $funk::var[%name, 12, 7, 1];
		$PlayerSpells[%clientId,"Enchantment"] 	= $funk::var[%name, 12, 8, 0] @ $funk::var[%name, 12, 8, 1];

		//==============================================================================================
		$CurPlayerSpells[%clientId] = "";

		//==============================================================================================
		$AutoStartFocus[%clientId] = $funk::var[%name, 13, 0];

		//==============================================================================================
		DynamicItem::InitCreate(%clientId);

		//==============================================================================================
		$PlayerHotbar[%clientId] = "IceSpike -1 -1 -1 -1 -1 -1 -1 -1 -1";

		//==============================================================================================
		if(fetchData(%clientId, "RemortStep") == "")
			storeData(%clientId, "RemortStep", 0);
		if(fetchData(%clientId, "LCKconsequence") == "")
			storeData(%clientId, "LCKconsequence", "death");
		if(fetchData(%clientId, "tmphp") == "")
			storeData(%clientId, "tmphp", 1);
		if(fetchData(%clientId, "tmpmana") == "")
			storeData(%clientId, "tmpmana", 1);
		if(fetchData(%clientId, "tmpname") == "")
			storeData(%clientId, "tmpname", %name);

		//==============================================================================================
		// TARGETING
		$TargetCur[%clientId,0] = "";
		$TargetList[%clientId,0] = "";
		$TargetTemp[%clientId,0] = "";
		$TargetPrev[%clientId,0] = "";
		$TargetCur[%clientId,1] = "";
		$TargetList[%clientId,1] = "";
		$TargetTemp[%clientId,1] = "";
		$TargetPrev[%clientId,1] = "";

		//==============================================================================================
		// PASSIVES
		$PassiveTemp[%clientId] = "";
		$PassiveTempNoLvl[%clientId] = "";
		$PassiveChange[%clientId] = 0;
		$PassiveGen[%clientId] = "";
		$PassivePoints[%clientId] = $funk::var[%name, 15, 0];
		$PlayerPassiveSave[%clientId,O] = $funk::var[%name, 15, 1];
		$PlayerPassiveSave[%clientId,D] = $funk::var[%name, 15, 2];
		$PlayerPassiveSave[%clientId,N] = $funk::var[%name, 15, 3];
		$PlayerPassiveSave[%clientId,M] = $funk::var[%name, 15, 4];
		$UnspecPoints[%clientId] = $funk::var[%name, 15, 5];

		//==============================================================================================
		// RES SICK
		$ResSick[%clientId] = $funk::var[%name, 17, 0];
		$RESTIMER[%clientId] = $funk::var[%name, 17, 1];

		//==============================================================================================
		// NO SALE
		%nosale = "";
		for (%i = 1; %i <= 6; %i++)
			%nosale = %nosale @ $funk::var[%name,18,%i];
		$PlayerNoSale[%clientId] = %nosale;
		CheckNoSaleCreate(%clientId);

		//==============================================================================================
		// FAVORITES
		$PlayerFavList[%clientId] = $funk::var[%name, 19, 0];

		//==============================================================================================
		// TARGETINGAREA
		$TARGETINGAREA[%clientId] = $funk::var[%name, 20, 0];
		
		//===========================================================
		// WEIGHT
		RefreshWeight(%clientId);

		//===========================================================
		// VERSION
		%version = $funk::var[%name, 667, 0];
		// CURRENT WORLD
		%currentmap = $funk::var[%name, 667, 1];
		if (%currentmap == "")
			%currentmap = "FOREST";
		storeData(%clientId, "CurrentMap", %currentmap);
		WorldConnect(%clientId);
		// CRAFTING
		%clientId.CraftBase = $funk::var[%name, 667, 2];
		%clientId.CraftAdditions = $funk::var[%name, 667, 3];
		DynamicItem::InitWear(%clientId.CraftBase);
		DynamicItem::InitWear(%clientId.CraftAdditions);

		echo("Load complete.");
	}
	else {
		
		// CREATE NEW PLAYER

		$TempATK[%clientId] = 0;
		$TempDEF[%clientId] = 0;

		//give defaults
		echo("Giving defaults to new player " @ %clientId);
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
		storeData(%clientId, "EXP", 0);
		storeData(%clientId, "campPos", "");
		storeData(%clientId, "BANK", $initbankcoins);
		storeData(%clientId, "grouplist", "");
		storeData(%clientId, "defaultTalk", "#say");
		storeData(%clientId, "password", $Client::info[%clientId, 5]);
		storeData(%clientId, "LCK", $initLCK);
		storeData(%clientId, "PlayerInfo", "");
		storeData(%clientId, "ignoreGlobal", "");
		storeData(%clientId, "LCKconsequence", "death");
		storeData(%clientId, "tmphp", "");
		storeData(%clientId, "tmpmana", "");
		storeData(%clientId, "RemortStep", 0);
		storeData(%clientId, "tmpname", %name);
		storeData(%clientId, "tmpLastSaveVer", $rpgver);
		storeData(%clientId, "bounty", 0);
		storeData(%clientId, "isMimic", "");
		storeData(%clientId, "MyHouse", "");
		storeData(%clientId, "RankPoints", 0);
		storeData(%clientId, "LVL", 1);
		storeData(%clientId, "SLVL", 0);
		storeData(%clientId, "SEXP", 0);
		storeData(%clientId, "zone", "Wilderness");
		storeData(%clientId, "ALVL", 0);
		storeData(%clientId, "AEXP", 0);

		storeData(%clientId, "CruRACE","Human");

		%clientId.choosingRace = True;
	
		//==============================================================================================
		// GIVE INITIAL ITEMS
		$PlayerBackpack[%clientId] = BackpackNewPlayer();

		//==============================================================================================
		$PlayerBelt[%clientId] = "";
		DefaultSkillLocks(%clientId);
		SetConnectionId(%clientId);

		//==============================================================================================
		$Battling[%clientId] = 0;
		$BattleRespawn[%clientId] = -1;
		$PlayerJoinBattle[%clientId] = 0;
		storeData(%clientId,"NoDropLootbagFlag",0);
		
		//==============================================================================================
		storeData(%clientId, "CustomClass", "");

		//==============================================================================================
		// CRUQUEST
		$PlayerCruComplete[%clientId] = "";
		$PlayerQuests[%clientId] = "";
		$PlayerQuestStatus[%clientId] = "";

		//==============================================================================================
		$PlayerSpells[%clientId,1] = "";
		$PlayerSpells[%clientId,2] = "";
		$PlayerSpells[%clientId,3] = "";

		//==============================================================================================
		// CRUPERKS
		$PlayerPerks[%clientId] = "";
		$PerkPoints[%clientId] = 0;

		//==============================================================================================
		// CURSPELLS
		$PlayerSpells[%clientId,"PrimalMagic"] 	= $DefaultSpellList["PrimalMagic"];
		$PlayerSpells[%clientId,"HolyMagic"] 	= $DefaultSpellList["HolyMagic"];
		$PlayerSpells[%clientId,"Empowerment"] 	= $DefaultSpellList["Empowerment"];
		$PlayerSpells[%clientId,"DarkMagic"] 	= $DefaultSpellList["DarkMagic"];
		$PlayerSpells[%clientId,"LightMagic"] 	= $DefaultSpellList["LightMagic"];
		$PlayerSpells[%clientId,"Ritual"] 	= $DefaultSpellList["Ritual"];
		$PlayerSpells[%clientId,"Sorcery"] 	= $DefaultSpellList["Sorcery"];
		$PlayerSpells[%clientId,"Protection"] 	= $DefaultSpellList["Protection"];
		$PlayerSpells[%clientId,"Enchantment"] 	= $DefaultSpellList["Enchantment"];
		
		//==============================================================================================
		SetAllSkills(%clientId, 0);
		storeData(%clientId, "spawnStuff", "");

		//==============================================================================================
		DynamicItem::InitCreate(%clientId);
		for (%i = 0; %i <= 30; %i++)
			$PlayerWear[%clientId,%i] = "";

		//==============================================================================================
		$MagicFindList[%clientId] = "0 0 0 0 0 0 0 0 0 0";
		RefreshMagicFind(%clientId,False);
		$GoldFindList[%clientId] = "0 0 0 0 0 0 0 0 0 0";
		RefreshMagicFind(%clientId,True);		

		//==============================================================================================
		// TARGETING
		$TargetCur[%clientId,0] = "";
		$TargetList[%clientId,0] = "";
		$TargetTemp[%clientId,0] = "";
		$TargetPrev[%clientId,0] = "";
		$TargetCur[%clientId,1] = "";
		$TargetList[%clientId,1] = "";
		$TargetTemp[%clientId,1] = "";
		$TargetPrev[%clientId,1] = "";

		//==============================================================================================	
		// PASSIVES
		$PassiveTemp[%clientId] = "";
		$PassiveTempNoLvl[%clientId] = "";
		$PassiveGen[%clientId] = "";
		$PassiveChange[%clientId] = 0;
		$PassivePoints[%clientId] = 1;
		$PlayerPassiveSave[%clientId,O] = $PassiveSave[O];
		$PlayerPassiveSave[%clientId,D] = $PassiveSave[D];
		$PlayerPassiveSave[%clientId,N] = $PassiveSave[N];
		$PlayerPassiveSave[%clientId,M] = $PassiveSave[M];
		$UnspecPoints[%clientId] = 0;

		//==============================================================================================
		// RESSICK
		$ResSick[%clientId] = 0;
		$RESTIMER[%clientId] = 0;

		//==============================================================================================
		// NOSALE
		$PlayerNoSale[%clientId] = "";

		//==============================================================================================
		// FAVORITES
		$PlayerFavList[%clientId] = "";
		
		//==============================================================================================
		// TARGETINGAREA
		$TARGETINGAREA[%clientId] = 0;

		//==============================================================================================
		// DEFAULT BINDS
		for(%i = 0; (%g = string::getSubStr($BindList,%i,1)) != ""; %i++)
			$numMessage[%clientId, %g] = $funk::bind[%name,%g];
		$numMessage[%clientId,h] = "USE 999HealthPotion";
		$numMessage[%clientId,j] = "USE 999EnergyVial";
		$numMessage[%clientId,m] = "#meditate";
		$numMessage[%clientId,n] = "#wake";
		$numMessage[%clientId,g] = "#gear";

		//==============================================================================================
		// VERSION
		%version = $CRUVER;
		storeData(%clientId, "CurrentMap", "FOREST");
		//storeData(%clientId, "CurrentMap", "JUNGLE");
		WorldConnect(%clientId);
		%clientId.CraftBase = "";
		%clientId.CraftAdditions = "";
		
	}

	ClearFunkVar(%name);

	UpdateVersion(%clientId,%version);
}

function UpdateVersion(%id,%ver)
{
	if (%ver == "")
		%ver = 0;
	//=============================================================================================================
	// Fix the save list for empowerment skills, all learned skills are reset for the player
	if (%ver < 1) {
		$PlayerSpells[%id,"Empowerment"] = $DefaultSpellList["Empowerment"];
		Client::SendMessage(%id,3,"[SERVER UPDATE] Your learned Empowerment spell list was reset.");
	}
	//=============================================================================================================
	// Increased the SP to 80 per level, all old characters recieve the missing sp
	if (%ver < 2) {
		%lvl = fetchData(%id,"LVL");
		%c2 = %lvl * 10;
		storeData(%id, "SPcredits", %c2, "inc");
		Client::SendMessage(%id,3,"[SERVER UPDATE] You recieved " @ %c2 @ " SP Credits.");
	}
	//=============================================================================================================
	// Fixed Race for older players
	if (%ver < 3) {
		%cruRace = fetchData(%id,"CruRACE");
		if (%cruRace == "Nephilim" || %cruRace == "Orc")
			storeData(%id, "RACE", Client::getGender(%id) @ "BigHuman");
		else
			storeData(%id, "RACE", Client::getGender(%id) @ "Human");
		Client::SendMessage(%id,3,"[SERVER UPDATE] Your internal race was updated.");
	}
}

function BackpackNewPlayer()
{
	%m = "";
	%m = %m @ TierItem::RandomItem("CorrodedSword",1) @ " 1 ";
	%m = %m @ TierItem::RandomItem("CorrodedSpike",1) @ " 1 ";
	%m = %m @ TierItem::RandomItem("PineBow",1) @ " 1 ";
	%m = %m @ TierItem::RandomItem("DriftwoodMace",1) @ " 1 ";
	%m = %m @ TierItem::RandomItem("TwigWand",1) @ " 1 ";
	%m = %m @ TierItem::RandomItem("OldwoodStaff",1) @ " 1 ";
	%m = %m @ "001CrystalFireball 1 ";
	%m = %m @ "001CrystalIronFist 1 ";
	%m = %m @ "999HealthPotion 25 ";
	%m = %m @ "999EnergyVial 25 ";
	return %m;
}

function OnOrOfflineGive(%name, %award)
{
	dbecho($dbechoMode, "OnOrOfflineGive(" @ %name @ ", " @ %award @ ")");

	%clientId = NEWgetClientByName(%name);
	//messageAll($MsgRed, "DEBUG: %name: " @ %name);
	//messageAll($MsgRed, "DEBUG: %clientId: " @ %clientId);
	//messageAll($MsgRed, "DEBUG: %award: " @ %award);
	if(%clientId != -1)
	{
		//player is in-game, simply store the item in storage
		Client::sendMessage(%clientId, $MsgBeige, "You have received a prize for downloading Theory Of Trance music, check your storage!");
		for(%i = 0; GetWord(%award, %i) != -1; %i+=2)
			storeData(%clientId, "BankStorage", SetStuffString(fetchData(%clientId, "BankStorage"), GetWord(%award, %i), GetWord(%award, %i+1)));
	}
	else
	{
		//player is not in-game. load character file, make changes, then save
		%filename = %name @ ".cs";

		$ConsoleWorld::DefaultSearchPath = $ConsoleWorld::DefaultSearchPath;	//thanks Presto

		if(isFile("temp\\" @ %filename))
		{
			//load character
			ClearFunkVar(%name);
			exec(%filename);

			//pass variables thru, while adding the awarded item
			$funk::var["[\"" @ %name @ "\", 0, 1]"] = $funk::var[%name, 0, 1];
			$funk::var["[\"" @ %name @ "\", 0, 2]"] = $funk::var[%name, 0, 2];
			$funk::var["[\"" @ %name @ "\", 0, 3]"] = $funk::var[%name, 0, 3];
			$funk::var["[\"" @ %name @ "\", 0, 4]"] = $funk::var[%name, 0, 4];
			$funk::var["[\"" @ %name @ "\", 0, 5]"] = $funk::var[%name, 0, 5];
			$funk::var["[\"" @ %name @ "\", 0, 6]"] = $funk::var[%name, 0, 6];
			$funk::var["[\"" @ %name @ "\", 0, 7]"] = $funk::var[%name, 0, 7];
			$funk::var["[\"" @ %name @ "\", 0, 8]"] = $funk::var[%name, 0, 8];
			$funk::var["[\"" @ %name @ "\", 0, 9]"] = $funk::var[%name, 0, 9];
			$funk::var["[\"" @ %name @ "\", 0, 10]"] = $funk::var[%name, 0, 10];
			$funk::var["[\"" @ %name @ "\", 0, 11]"] = $funk::var[%name, 0, 11];
			$funk::var["[\"" @ %name @ "\", 0, 12]"] = $funk::var[%name, 0, 12];
			$funk::var["[\"" @ %name @ "\", 0, 13]"] = $funk::var[%name, 0, 13];
			$funk::var["[\"" @ %name @ "\", 0, 14]"] = $funk::var[%name, 0, 14];
			$funk::var["[\"" @ %name @ "\", 0, 15]"] = $funk::var[%name, 0, 15];
			for(%i = 0; GetWord(%award, %i) != -1; %i+=2)
				$funk::var["[\"" @ %name @ "\", 0, 16]"] = SetStuffString($funk::var[%name, 0, 16], GetWord(%award, %i), GetWord(%award, %i+1));
			$funk::var["[\"" @ %name @ "\", 0, 17]"] = $funk::var[%name, 0, 17];
			$funk::var["[\"" @ %name @ "\", 0, 18]"] = $funk::var[%name, 0, 18];
			$funk::var["[\"" @ %name @ "\", 0, 19]"] = $funk::var[%name, 0, 19];
			$funk::var["[\"" @ %name @ "\", 0, 20]"] = $funk::var[%name, 0, 20];
			$funk::var["[\"" @ %name @ "\", 0, 21]"] = $funk::var[%name, 0, 21];
			$funk::var["[\"" @ %name @ "\", 0, 22]"] = $funk::var[%name, 0, 22];
			$funk::var["[\"" @ %name @ "\", 0, 23]"] = $funk::var[%name, 0, 23];
			$funk::var["[\"" @ %name @ "\", 0, 26]"] = $funk::var[%name, 0, 26];
			$funk::var["[\"" @ %name @ "\", 0, 27]"] = $funk::var[%name, 0, 27];
			$funk::var["[\"" @ %name @ "\", 0, 28]"] = $funk::var[%name, 0, 28];
			//$funk::var["[\"" @ %name @ "\", 0, 29]"] = $funk::var[%name, 0, 29];
			$funk::var["[\"" @ %name @ "\", 0, 30]"] = $funk::var[%name, 0, 30];
			$funk::var["[\"" @ %name @ "\", 0, 31]"] = $funk::var[%name, 0, 31];
			$funk::var["[\"" @ %name @ "\", 0, 666]"] = $funk::var[%name, 0, 666];

			//skills
			%cnt = 0;
			for(%i = 1; %i <= GetNumSkills(); %i++)
			{
				%cnt++;
				$funk::var["[\"" @ %name @ "\", 4, " @ %cnt @ "]"] = $funk::var[%name, 4, %cnt];
				%cnt++;
				$funk::var["[\"" @ %name @ "\", 4, " @ %cnt @ "]"] = $funk::var[%name, 4, %cnt];
			}

			//quests
			for(%i = 1; $funk::var[%name, 2, %i] != ""; %i++)
				$funk::var["[\"" @ %name @ "\", 2, " @ %i @ "]"] = $funk::var[%name, 2, %i];
			for(%i = 1; $funk::var[%name, 3, %i] != ""; %i++)
				$funk::var["[\"" @ %name @ "\", 3, " @ %i @ "]"] = $funk::var[%name, 3, %i];

			//bonus state variables
			for(%i = 1; %i <= $maxBonusStates; %i++)
			{
				$funk::var["[\"" @ %name @ "\", 5, " @ %i @ "]"] = $funk::var[%name, 5, %i];
				$funk::var["[\"" @ %name @ "\", 6, " @ %i @ "]"] = $funk::var[%name, 6, %i];
			}

			//save character
			File::delete("temp\\" @ %name @ ".cs");
			export("funk::var[\"" @ %name @ "\",*", "temp\\" @ %name @ ".cs", false);

			ClearFunkVar(%name);
		}
	}
}

function ResetPlayer(%clientId)
{
	dbecho($dbechoMode2, "ResetPlayer(" @ %clientId @ ")");

	%name = Client::getName(%clientId);
	%filename = %name @ ".cs";

	File::delete("temp\\" @ %filename);

	LoadCharacter(%clientId);

	StartStatSelection(%clientId);
}

function SaveWorld()
{

	return;

	dbecho($dbechoMode, "SaveWorld()");

	echo("Saving world '" @ $missionName @ "_worldsave_.cs'...");
	messageAll(2, "SaveWorld in progress... This process might induce temporary lag");
	%i = 0;
	%ii = 0;
	%othercnt = 0;
	while(%othercnt < 15)
	{
		%i++;
		%ID = 8361 + %i;
		%obj = GameBase::getDataName(%ID);
		if(String::findSubStr($WorldSaveList, "|" @ %obj @ "|") != -1)
		{
			%ii++;
			echo("Saving object #" @ %ii @ " : " @ %obj);
			$world::object[%ii] = %obj;
			$world::owner[%ii] = $owner[%ID];
			$world::pos[%ii] = GameBase::getPosition(%ID);
			$world::rot[%ii] = GameBase::getRotation(%ID);
			$world::team[%ii] = GameBase::getTeam(%ID);
			$world::special[%ii] = "";
			//modify special depending on the item
			if(%obj == "Lootbag")
			{
				%loot = $loot[%ID];
				%w0 = getWord(%loot, 0);
				%w1 = getWord(%loot, 1);
				if(%w1 != "*")
					%loot = %w0 @ " * " @ String::getSubStr(%loot, String::len(%w0)+String::len(%w1)+2, 99999);
				$world::special[%ii] = %loot;
			}
		}

		if(%obj == "")
			%othercnt++;
		else
			%othercnt = 0;

	}
	echo("Deleting old file before save for '" @ $missionName @ "_worldsave_.cs'...");
	File::delete("temp\\" @ $missionName @ "_worldsave_.cs");

	export("world::*", "temp\\" @ $missionName @ "_worldsave_.cs", false);
	echo("Save complete.");
	messageAll(2, "SaveWorld complete.");
}
function LoadWorld()
{

	return;
	dbecho($dbechoMode, "LoadWorld()");

	%filename = $missionName @ "_worldsave_.cs";

	if(isFile("temp\\" @ %filename))
	{
		//load world
		echo("Loading world '" @ $missionName @ "_worldsave_.cs'...");
		messageAll(2, "LoadWorld in progress...");

		$ConsoleWorld::DefaultSearchPath = $ConsoleWorld::DefaultSearchPath;	//thanks Presto
		exec(%filename);

		for(%i = 1; $world::object[%i] != ""; %i++)
		{
			echo("Loading (spawning) object #" @ %i @ " : " @ $world::object[%i]);
			if($world::object[%i] == "DepPlatSmallHorz" || $world::object[%i] == "DepPlatMediumHorz" || $world::object[%i] == "DepPlatSmallVert" || $world::object[%i] == "DepPlatMediumVert")
			{
				DeployPlatform($world::owner[%i], $world::team[%i], $world::pos[%i], $world::rot[%i], $world::object[%i]);
			}
			else if($world::object[%i] == "StaticDoorForceField")
			{
				DeployForceField($world::owner[%i], $world::team[%i], $world::pos[%i], $world::rot[%i]);
			}
			else if($world::object[%i] == "DeployableTree")
			{
				DeployTree($world::owner[%i], $world::team[%i], $world::pos[%i], $world::rot[%i]);
			}
			else if($world::object[%i] == "Lootbag")
			{
				DeployLootbag($world::pos[%i], $world::rot[%i], $world::special[%i]);
			}
		}
		echo("Load complete.");
		messageAll(2, "LoadWorld complete.");
	}
	else
	{
		echo("ERROR: Couldn't find world '" @ $missionName @ "_worldsave_.cs'");
	}
}	
function DeployPlatform(%name, %team, %pos, %rot, %plattype)
{
	dbecho($dbechoMode, "DeployPlatform(" @ %name @ ", " @ %team @ ", " @ %pos @ ", " @ %rot @ ", " @ %plattype @ ")");

	%platform = newObject("", "StaticShape", %plattype, true);

	$owner[%platform] = %name;

	if($recording[getClientByName(%name)] == 1)
		AddObjectToRec(getClientByName(%name), 1, %pos, %rot);

//	if(%plattype == "DepPlatSmallVert")
//	{
//		%rot = "0 1.5708 " @ GetWord(%rot, 2) + "1.5708";
//		%pos = GetWord(%pos, 0) @ " " @ GetWord(%pos, 1) @ " " @ (GetWord(%pos, 2) + 2);
//	}
//	else if(%plattype == "DepPlatMediumVert")
//	{
//		%rot = "0 1.5708 " @ GetWord(%rot, 2) + "1.5708";
//		%pos = GetWord(%pos, 0) @ " " @ GetWord(%pos, 1) @ " " @ (GetWord(%pos, 2) + 3);
//	}
//	else if(%plattype == "DepPlatLargeVert")
//	{
//		%rot = "0 1.5708 " @ GetWord(%rot, 2) + "1.5708";
//		%pos = GetWord(%pos, 0) @ " " @ GetWord(%pos, 1) @ " " @ (GetWord(%pos, 2) + 4.5);
//	}

	addToSet("MissionCleanup", %platform);
	GameBase::setTeam(%platform, %team);
	GameBase::setPosition(%platform, %pos);
	GameBase::setRotation(%platform, %rot);
	Gamebase::setMapName(%platform, %plattype);
	GameBase::startFadeIn(%platform);
	playSound(SoundPickupBackpack, %pos);
	playSound(ForceFieldOpen, %pos);
}

function DeployLootbag(%pos, %rot, %special, %rock)
{
	dbecho($dbechoMode, "DeployLootbag(" @ %pos @ ", " @ %rot @ ", " @ %special @ ")");

	if (%rock == "")
		%lootbag = newObject("", "Item", "Lootbag", 1, false);
	else
		%lootbag = newObject("", "Item", "Lootrock", 1, false);

	$loot[%lootbag] = %special;

 	addToSet("MissionCleanup", %lootbag);
	
	GameBase::setPosition(%lootbag, %pos);
	GameBase::setRotation(%lootbag, %rot);
	GameBase::setMapName(%lootbag, "Backpack");

	return %lootbag;
}

function NEWgetClientByName(%name)
{
	dbecho($dbechoMode, "NEWgetClientByName(" @ %name @ ")");

	%list = GetEveryoneIdList();
	for(%i = 0; GetWord(%list, %i) != -1; %i++)
	{
		%id = GetWord(%list, %i);
		%displayName = Client::getName(%id);
		if(String::ICompare(%name, %displayName) == 0)
			return %id;
	}
	return -1;
}

function clipTrailingNumbers(%str)
{
	dbecho($dbechoMode, "clipTrailingNumbers(" @ %str @ ")");

	for(%i=0; %i <= String::len(%str); %i++)
	{
		%a = String::getSubStr(%str, %i, 1);
		%b = (%a+1-1);

		if(String::ICompare(%b, %a) == 0)
			break;
	}
	%pos = %i;

	return String::getSubStr(%str, 0, %pos);
}

function UpdateAppearance(%clientId)
{
	//echo(" UPDATE APPEARANCE " @ %clientId);
	%weararmor = False;
	%armor = $PlayerWear[%clientId,12];
	%vis = "";
	%apm = "";
	//===============================================================================================
	// ARMOR CHECK
	if (%armor != -1 && %armor != "") {
		%weararmor = True;
		%vis = $BPItem[%armor,$BPVis];
		if ($BPRobed[%vis])
			%apm = "Robed";
	}
	//===============================================================================================
	%weapon = $PlayerWear[%clientId,13];
	//===============================================================================================
	%race = fetchData(%clientId, "RACE");
	%model = Player::getArmor(%clientId);
	%cw = String::getSubStr(%model, String::findSubStr(%model, "Armor"), 99999);
	%cw = "Armor7";
	%crurace = fetchData(%clientId,"CruRACE");
	if (%crurace == "Nephilim" || %crurace == "Orc") %big = "Big";
	else %big = "";
	//===============================================================================================
	if (%race == "MaleHuman" || %race == "FemaleHuman" || %race == "MaleBigHuman" || %race == "FemaleBigHuman")
	{
		if (%vis == "")
			%skinbase = "rpgbase";
		else
			%skinbase = %vis;
		if (%crurace == "Orc")
			%skinbase = "orc" @ %skinbase;
		if (%crurace == "DarkElf")
			%skinbase = "delf" @ %skinbase;
		if (%crurace == "ShadowOrc")
			%skinbase = "dorc" @ %skinbase;
		if (%crurace == "Cambion")
			%skinbase = "cam" @ %skinbase;
		Client::SetSkin(%clientId,%skinbase);
	}
	else if (%race == "DeathKnight")
	{
		%skinbase = "swolf";
		%apm = "";
		%cw = "Armor22";
		%armor = 0;
		Client::SetSkin(%clientId,%skinbase);
	}
	else if (%race == "Demon")
	{
		%skinbase = "undead";
		%apm = "";
		%cw = "Armor";
		Client::SetSkin(%clientId,%skinbase);
	}
	else if (%race == "Minotaur")
	{
		%skinbase = "minred";
		%apm = "";
		%cw = "Armor";
		Client::SetSkin(%clientId,%skinbase);
	}
	else if (%race == "Arcane")
	{
		%skinbase = "swolf";
		%apm = "";
		%race = "invisable";
		%cw = "armor";
	}
	else if (%race == "Shelter")
	{
		if (%vis == "")
			%skinbase = "rpgbase";
		else
			%skinbase = %vis;
		if (%crurace == "Orc")
			%skinbase = "orc" @ %skinbase;
		if (%crurace == "DarkElf")
			%skinbase = "delf" @ %skinbase;
		if (%crurace == "ShadowOrc")
			%skinbase = "dorc" @ %skinbase;
		if (%crurace == "Cambion")
			%skinbase = "cam" @ %skinbase;
		Client::SetSkin(%clientId,%skinbase);
		if (Client::GetGender(%clientId) == "Male")
			%race = "Male"@%big@"Human";
		else
			%race = "Female"@%big@"Human";
		%apm = "";
		%cw = "Armor0";
	}
	else
	{
		%p = $RaceToArmorType[%race];
		%armor = -1;
	}
	//===============================================================================================
	// UPDATE PLAYER MODEL
	%player = Client::GetOwnedObject(%clientId);
	if(%armor != -1)
		%p = %race @ %apm @ %cw;
	%ae = GameBase::getEnergy(%player);
	if (Player::getArmor(%clientId) != %p && %p != "" && $Snared[%clientId] != 1 && $Rooted[%clientId] != 1)
	{
		Player::setArmor(%clientId, %p);
		GameBase::setEnergy(%player, %ae);
	}
}

function UpdateTeam(%clientId)
{
	dbecho($dbechoMode, "UpdateTeam(" @ %clientId @ ")");

	%t = $TeamForRace[fetchData(%clientId, "RACE")];

	GameBase::setTeam(%clientId, %t);
}

function ChangeRace(%clientId, %race)
{
	dbecho($dbechoMode, "ChangeRace(" @ %clientId @ ", " @ %race @ ")");

	%cruRace = fetchData(%clientId,"CruRACE");
	if (%cruRace == "Nephilim" || %cruRace == "Orc")
		%big = "Big";
	else
		%big = "";

	if(%race == "DeathKnight")
		storeData(%clientId, "RACE", "DeathKnight");
	else if(%race == "Minotaur") {
		PlaySound("Sound0735",Gamebase::GetPosition(%clientId));
		storeData(%clientId, "RACE", "Minotaur");
	}
	else if(%race == "Demon")
		storeData(%clientId, "RACE", "Demon");
	else if(%race == "Human") {
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ %big @ "Human");
	}
	else if(%race == "MaleHuman")
		storeData(%clientId, "RACE", "MaleHuman");
	else if(%race == "FemaleHuman")
		storeData(%clientId, "RACE", "FemaleHuman");
	else if(%race == "MaleBigHuman")
		storeData(%clientId, "RACE", "MaleBigHuman");
	else if(%race == "FemaleBigHuman")
		storeData(%clientId, "RACE", "FemaleBigHuman");
	else if(%race == "Arcane")
		storeData(%clientId, "RACE", "Arcane");
	else if (%race == "Shelter")
		storeData(%clientId, "RACE", "Shelter");

	//setHP(%clientId, fetchData(%clientId, "MaxHP"));
	//setMANA(%clientId, fetchData(%clientId, "MaxMANA"));

	RefreshAll(%clientId);
}

function ClearVariables(%clientId)
{
	dbecho($dbechoMode2, "ClearVariables(" @ %clientId @ ")");

	%name = Client::getName(%clientId);

	//clear variables

	ClearFunkVar(%name);

	$possessedBy[%clientId] = "";

	//this is only for bots
	$BotFollowDirective[fetchData(%clientId, "BotInfoAiName")] = "";

	//clear directives
	$aidirectiveTable[%clientId, 99] = "";

	%clientId.IsInvalid = "";
	%clientId.currentShop = "";
	%clientId.currentBank = "";
	%clientId.currentSmith = "";
	%clientId.adminLevel = "";
	%clientId.lastWaitActionTime = "";
	%clientId.choosingGroup = "";
	%clientId.choosingClass = "";
	%clientId.choosingRace = "";
	%clientId.ConfirmRace = "";
	%clientId.possessId = "";
	%clientId.sleepMode = "";
	%clientId.lastSaveCharTime = "";
	%clientId.replyTo = "";
	%clientId.stealType = "";
	%clientId.lastTriggerTime = "";
	%clientId.lastFireTime = "";
	%clientId.lastItemPickupTime = "";
	%clientId.MusicTicksLeft = "";
	%clientId.doExport = "";
	%clientId.TryingToSteal = "";
	%clientId.lastGetWeight = "";
	%clientId.echoOff = "";
	%clientId.lastMissMessage = "";
	%clientId.lastMinePos = "";
	%clientId.bulkNum = "";
	%clientId.zoneLastPos = "";
	%clientId.MimicClass = "";

	//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
	%clientId.BSellPrice = "";
	%clientId.BSellCount = "";
	%clientId.BSellItem = "";
	//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

	for(%i = 0; (%id = GetWord($TownBotList, %i)) != -1; %i++)
	{
		$state[%id, %clientId] = "";
		if($QuestCounter[%name, %id.name] != "")
			$QuestCounter[%name, %id.name] = "";
	}

	for(%i = 1; %i <= $maxDamagedBy; %i++)
		$damagedBy[%name, %i] = "";

	SetAllSkills(%clientId, "");

	ClearEvents(%clientId);

	deleteVariables("BonusState" @ %clientId @ "*");
	deleteVariables("BonusStateCnt" @ %clientId @ "*");

	deleteVariables("ClientData" @ %clientId @ "*");
}
function ClearFunkVar(%name)
{
	dbecho($dbechoMode2, "ClearFunkVar(" @ %name @ ")");

	%method = 1;
	if(%method == 0)
	{
		//clear regular data
		for(%i = 1; %i <= 35; %i++)
		{
			$funk::var["[\"" @ %name @ "\", 0, " @ %i @ "]"] = "";
			$funk::var[%name, 0, %i] = "";
		}
	
		for(%i = 1; $funk::var["[\"" @ %name @ "\", 2, " @ %i @ "]"] != ""; %i++)
			$funk::var["[\"" @ %name @ "\", 2, " @ %i @ "]"] = "";
		for(%i = 1; $funk::var[%name, 2, %i] != ""; %i++)
			$funk::var[%name, 2, %i] = "";
	
		for(%i = 1; $funk::var["[\"" @ %name @ "\", 3, " @ %i @ "]"] != ""; %i++)
			$funk::var["[\"" @ %name @ "\", 3, " @ %i @ "]"] = "";
		for(%i = 1; $funk::var[%name, 3, %i] != ""; %i++)
			$funk::var[%name, 3, %i] = "";
	
		for(%i = 1; $funk::var["[\"" @ %name @ "\", 4, " @ %i @ "]"] != ""; %i++)
			$funk::var["[\"" @ %name @ "\", 4, " @ %i @ "]"] = "";
		for(%i = 1; $funk::var[%name, 4, %i] != ""; %i++)
			$funk::var[%name, 4, %i] = "";

		$funk::var[%name, 7, 0] = "";
		$funk::var[%name, 7, 1] = "";
		$funk::var[%name, 7, 2] = "";
	}
	else
	{
		deleteVariables("funk::var[\"" @ %name @ "\"*");
		deleteVariables("funk::var" @ %name @ "*");
		deleteVariables("funk::store[\"" @ %name @ "\"*");
		deleteVariables("funk::store" @ %name @ "*");
	}
}

function Down(%t)
{
	dbecho($dbechoMode, "Down(" @ %t @ ")");

	%tinsec = %t * 60;
	for(%i = %t; %i > 1; %i--)
	{
		%a = (%tinsec - (60 * %i));
		schedule("dmsg(" @ %i @ ", \"minutes\");", %a);
	}

	if(%tinsec > 60)
		%startfrom = 60;
	else
		%startfrom = %tinsec;

	for(%i = %startfrom; %i >= 1; %i -= 10)
	{
		%a = (%tinsec - %i);
		schedule("dmsg(" @ %i @ ", \"seconds\");", %a);
	}
	schedule("focusserver();quit();", %tinsec);
}
function d(%t)
{
	Down(%t);
}
function dmsg(%i, %w)
{
	echo("========= SERVER RESTARTING IN " @ %i @ " " @ %w @ " =========");
	messageAll(1, "Server restarting in " @ %i @ " " @ %w @ ", please disconnect to save your character.");
}

function GetEveryoneIdList()
{
	dbecho($dbechoMode, "GetEveryoneIdList()");

	%list = "";
	%list = %list @ GetPlayerIdList();
	%list = %list @ GetBotIdList();
	return %list;
}
function GetEveryoneNameList()
{
	dbecho($dbechoMode, "GetEveryoneNameList()");

	%list = "";
	%list = %list @ GetPlayerNameList();
	%list = %list @ GetBotNameList();
	return %list;
}

function GetBotIdList()
{
	dbecho($dbechoMode, "GetBotIdList()");

	%list = "";

	%tempSet = nameToID("MissionCleanup");
	if(%tempSet != -1)
	{
		%num = Group::objectCount(%tempSet);
		for(%i = 0; %i <= %num-1; %i++)
		{
			%tempItem = Group::getObject(%tempSet, %i);

			if(getObjectType(%tempItem) == "Player")
			{
				%clientId = Player::getClient(%tempItem);
				if(Player::isAiControlled(%clientId))
				{
					%list = %list @ %clientId @ " ";
				}
			}
		}
	}

	return %list;
}
function GetBotNameList()
{
	dbecho($dbechoMode, "GetBotNameList()");

	%list = "";

	%tempSet = nameToID("MissionCleanup");
	if(%tempSet != -1)
	{
		%num = Group::objectCount(%tempSet);
		for(%i = 0; %i <= %num-1; %i++)
		{
			%tempItem = Group::getObject(%tempSet, %i);
			if(getObjectType(%tempItem) == "Player")
			{
				%clientId = Player::getClient(%tempItem);
				if(Player::isAiControlled(%clientId))
				{
					//%list = %list @ Client::getName(%clientId) @ " ";
					%list = %list @ fetchData(%clientId, "BotInfoAiName") @ " ";
				}
			}
		}
	}

	return %list;
}
function GetPlayerIdList()
{
	dbecho($dbechoMode, "GetPlayerIdList()");

	%list = "";
	for(%c = Client::getFirst(); %c != -1; %c = Client::getNext(%c))
	{
		%list = %list @ %c @ " ";
	}
	return %list;
}
function GetPlayerNameList()
{
	dbecho($dbechoMode, "GetPlayerNameList()");

	%list = "";
	for(%c = Client::getFirst(); %c != -1; %c = Client::getNext(%c))
	{
		%list = %list @ Client::getName(%c) @ " ";
	}
	return %list;
}

function ChangeWeather()
{
	dbecho($dbechoMode, "ChangeWeather()");

	//credits go to LabRat for the original code for this... Thanks Lab!
	if(OddsAre(1))
	{
		$isRaining = "";

		%intensity = getRandom();

		%x = -1 + (getRandom() * 1.5);
		%y = -1 + (getRandom() * 1.5);

		%z = -300 + (floor(getRandom() * 40));
		%vec = %x @ " " @ %y @ " " @ %z;

		%t = floor(getRandom() * 100);

		if ($CURRENTCRUMAP == "FOREST")
			%chance = 50;
		if ($CURRENTCRUMAP == "DESERT")
			%chance = 10;
		if ($CURRENTCRUMAP == "JUNGLE")
			%chance = 75;

		%rain = MTRB(1,100);
			
		if(%chance <= %rain)
		{
			%type = 1;			//rain
			$isRaining = True;
			//setTerrainVisibility(8, 600, 0);
		}
		else
		{
			%type = -1;			//stop any weather
			//setTerrainVisibility(8, 1000, 700);
		}

		if(isObject("weather"))
			deleteObject("weather");

		%vec = "0.1 0 -75";

		if(%type == 1)
			%weather = newObject("weather", Snowfall, %intensity, %vec, 0, %type);
	}
}

$CrucibleValidChars = "qwertyuiopasdfghjklzxcvbnm_-1234567890";

function FindInvalidChar(%name)
{
	dbecho($dbechoMode, "FindInvalidChar(" @ %name @ ")");

	//looks for invalid characters in player's name
	for(%a = 1; %a <= String::len($invalidChars); %a++)
	{
		%b = String::getSubStr($invalidChars, %a-1, 1);
		if(String::findSubStr(%name, %b) != -1)
		{
			return %a-1;
		}
	}
	return "";
}

function CheckForReservedWords(%name)
{
	dbecho($dbechoMode, "CheckForReservedWords(" @ %name @ ")");

	%w[%c++] = "ArenaGladiator";
	%w[%c++] = "Traveller";
	%w[%c++] = "Goblin";
	%w[%c++] = "Gnoll";
	%w[%c++] = "Orc";
	%w[%c++] = "Ogre";
	%w[%c++] = "Elf";
	%w[%c++] = "Undead";
	%w[%c++] = "Minotaur";

	//exact words
	%ew[%d++] = "rpgfunk";
	%ew[%d++] = "crystal";
	%ew[%d++] = "game";
	%ew[%d++] = "item";
	%ew[%d++] = "mine";
	%ew[%d++] = "vehicle";
	%ew[%d++] = "comchat";
	%ew[%d++] = "server";
	%ew[%d++] = "turret";
	%ew[%d++] = "player";
	%ew[%d++] = "observer";
	%ew[%d++] = "ai";
	%ew[%d++] = "client";
	%ew[%d++] = "station";
	%ew[%d++] = "admin";
	%ew[%d++] = "staticshape";
	%ew[%d++] = "armordata";
	%ew[%d++] = "baseexpdata";
	%ew[%d++] = "baseprojdata";
	%ew[%d++] = "clientdefaults";
	%ew[%d++] = "nsound";
	%ew[%d++] = "shopping";
	%ew[%d++] = "zone";
	%ew[%d++] = "specialarmors";
	%ew[%d++] = "accessory";
	%ew[%d++] = "enemyarmors";
	%ew[%d++] = "spawn";
	%ew[%d++] = "registerobjects";
	%ew[%d++] = "registeruserobjects";
	%ew[%d++] = "tsdefaultmatprops";
	%ew[%d++] = "rpgstats";
	%ew[%d++] = "classes";
	%ew[%d++] = "weapons";
	%ew[%d++] = "globals";
	%ew[%d++] = "humanarmors";
	%ew[%d++] = "remote";
	%ew[%d++] = "playerspawn";
	%ew[%d++] = "gameevents";
	%ew[%d++] = "connectivity";
	%ew[%d++] = "playerdamage";
	%ew[%d++] = "economy";
	%ew[%d++] = "itemevents";
	%ew[%d++] = "weaponhandling";
	%ew[%d++] = "depbase";
	%ew[%d++] = "weight";
	%ew[%d++] = "mana";
	%ew[%d++] = "hp";
	%ew[%d++] = "rpgarena";
	%ew[%d++] = "ferry";
	%ew[%d++] = "spells";
	%ew[%d++] = "skills";
	%ew[%d++] = "serverdefaults";
	%ew[%d++] = "sleep";
	%ew[%d++] = "plugs";
	%ew[%d++] = "editorconfig";
	%ew[%d++] = "worlds";
	%ew[%d++] = "changemission";
	%ew[%d++] = "commander";
	%ew[%d++] = "editmission";
	%ew[%d++] = "gui";
	%ew[%d++] = "interiorlight";
	%ew[%d++] = "ircclient";
	%ew[%d++] = "med";
	%ew[%d++] = "missionlist";
	%ew[%d++] = "missiontypes";
	%ew[%d++] = "newmission";
	%ew[%d++] = "sae";
	%ew[%d++] = "playersetup";
	%ew[%d++] = "registervolume";
	%ew[%d++] = "ted";
	%ew[%d++] = "trees";
	%ew[%d++] = "trigger";
	%ew[%d++] = "basedebrisdata";
	%ew[%d++] = "beacon";
	%ew[%d++] = "chatmenu";
	%ew[%d++] = "clientdefaults";
	%ew[%d++] = "dm";
	%ew[%d++] = "editor";
	%ew[%d++] = "keys";
	%ew[%d++] = "loadshow";
	%ew[%d++] = "marker";
	%ew[%d++] = "menu";
	%ew[%d++] = "mission";
	%ew[%d++] = "move";
	%ew[%d++] = "moveable";
	%ew[%d++] = "options";
	%ew[%d++] = "sensor";
	%ew[%d++] = "sound";
	%ew[%d++] = "tag";
	%ew[%d++] = "terrains";
	%ew[%d++] = "objectives";
	%ew[%d++] = "tmpPrize";
	%ew[%d++] = "all";

	for(%i = 1; %w[%i] != ""; %i++)
	{
		if(String::findSubStr(%name, %w[%i]) != -1)
			return %w[%i];
	}
	for(%i = 1; %ew[%i] != ""; %i++)
	{
		if(String::ICompare(%name, %ew[%i]) == 0)
			return %ew[%i];
	}

	%list = GetBotNameList();
	for(%i = 0; (%b = GetWord(%list, %i)) != -1; %i++)
	{
		if(String::findSubStr(%name, %b) != -1)
			return %b;
	}

	return "";
}

function CheckForProtectedWords(%string)
{
	dbecho($dbechoMode, "CheckForProtectedWords(" @ %string @ ")");

	//this function checks for words that shouldn't be used in the #if statement due to its extremely powerful nature
	%w[1] = "Admin";
	%w[2] = "ResetPlayer";
	%w[3] = "storedata";
	%w[4] = "down";
	%w[5] = "quit";
	%w[6] = "eval";
	
	for(%i = 1; %w[%i] != ""; %i++)
	{
		if(String::findSubStr(%string, %w[%i]) != -1)
			return %w[%i];
	}

	return "";
}

function RandomPositionXY(%minrad, %maxrad)
{
	dbecho($dbechoMode, "RandomPositionXY(" @ %minrad @ ", " @ %maxrad @ ")");

	%diff = %maxrad - %minrad;

	%tmpX = floor(getRandom() * (%diff*2)) - %diff;
	if(%tmpX < 0)
		%tmpX -= %minrad;
	else
		%tmpX += %minrad;

	%tmpY = floor(getRandom() * (%diff*2)) - %diff;
	if(%tmpY < 0)
		%tmpY -= %minrad;
	else
		%tmpY += %minrad;

	return %tmpX @ " " @ %tmpY @ " ";
}

function OddsAre(%n)
{
	dbecho($dbechoMode, "OddsAre(" @ %n @ ")");

	%a = floor(getRandom() * %n);
	if(%a == %n-1)
		return True;
	else
		return False;
}

function TeleportToMarker(%clientId, %markergroup, %testpos, %random)
{
	dbecho($dbechoMode, "TeleportToMarker(" @ %clientId @ ", " @ %markergroup @ ", " @ %testpos @ ", " @ %random @ ")");

	%group = nameToID("MissionGroup\\" @ %markergroup);

	if(%group != -1)
	{	
		%num = Group::objectCount(%group);

		if(%random)
		{
			%r = floor(getRandom() * %num);
		      %marker = Group::getObject(%group, %r);
		
			%worldLoc = GameBase::getPosition(%marker);
	
			if(%testpos)
			{
				%set = newObject("tempset", SimSet);
				%n = containerBoxFillSet(%set, $SimPlayerObjectType, %worldLoc, 1.0, 1.0, 1.5, getWord(%worldLoc, 2));
				deleteObject(%set);

				if(%n > 0)
				{
					GameBase::setPosition(%clientId, %worldLoc);
					return %worldLoc;
				}
			}
			else
			{
				GameBase::setPosition(%clientId, %worldLoc);
				return %worldLoc;
			}
		}
		else
		{
			for(%i = 0; %i <= %num-1; %i++)
			{
			      %marker = Group::getObject(%group, %i);
			
				%worldLoc = GameBase::getPosition(%marker);
		
				if(%testpos)
				{
					//this is part of the method SF uses for their teleporters.  thanks Hosed
					%set = newObject("tempset", SimSet);
					%n = containerBoxFillSet(%set, $SimPlayerObjectType, %worldLoc, 1.0, 1.0, 1.5, getWord(%worldLoc, 2));
					deleteObject(%set);

					if(%n == 0)
					{
						GameBase::setPosition(%clientId, %worldLoc);
						return %worldLoc;
					}
				}
				else
				{
					GameBase::setPosition(%clientId, %worldLoc);
					return %worldLoc;
				}
			}
		}
	}
	
	return False;
}

function TossLootbag(%clientId, %loot, %vel, %namelist, %t)
{
	dbecho($dbechoMode2, "TossLootbag(" @ %clientId @ ", " @ %loot @ ", " @ %vel @ ", " @ %namelist @ ", " @ %t @ ")");

	%player = Client::getOwnedObject(%clientId);
	%ownerName = Client::getName(%clientId);

	%lootbag = newObject("", "Item", "Lootbag", 1, false);

	//echo(" LOOT BAG " @ %lootbag);

	//------------------------------------
	// CHECK FOR BOT DROP AND DISABLE
	if (!Player::IsAiControlled(%clientId))
		%lootbag.NoBonus = 1;
	%object = Client::GetOwnedObject(%clientId);
	if (%object.NoDropBonus)
		%lootbag.NoBonus = 1;
	%object.NoDropBonus = 0;
	//------------------------------------
	// CHECK FOR LADDER AND DISABLE
	if (IsLadderPlayer(%clientId))
		%lootbag.Ladder = 1;
	if (Player::IsAiControlled(%clientId))
		%lootbag.AiDropped = 1;
	if (%player.NoLadderPickup == 1)
		%lootbag.NoLadderPickup = 1;
	//------------------------------------

	if(%t > 0)
		schedule("$loot[" @ %lootbag @ "] = \"" @ %ownerName @ " * " @ %loot @ "\";", %t, %lootbag);
	else
	{
		$LootbagPopTime = 120;
		if($LootbagPopTime != -1)
		{
			schedule("Item::Pop(" @ %lootbag @ ");", $LootbagPopTime, %lootbag);
			schedule("storeData(" @ %clientId @ ", \"lootbaglist\", RemoveFromCommaList(\"" @ fetchData(%clientId, "lootbaglist") @ "\", " @ %lootbag @ "));", $LootbagPopTime, %lootbag);
		}
	}

	%loot = %ownerName @ " " @ %namelist @ " " @ %loot;

	$loot[%lootbag] = %loot;
	storeData(%clientId, "lootbaglist", AddToCommaList(fetchData(%clientId, "lootbaglist"), %lootbag));

	addToSet("MissionCleanup", %lootbag);
	GameBase::setMapName(%lootbag, "Backpack");
	GameBase::throw(%lootbag, %player, %vel, false);

	//schedule("spawnblue(" @ %lootbag @ ");",2.0);

	//Make sure there aren't more than 15 packs per player... This is to resolve lag problems

	%lootbaglist = fetchData(%clientId, "lootbaglist");

	//if(CountObjInCommaList(%lootbaglist) > 5)
	//{
	//	%p = String::findSubStr(%lootbaglist, ",");
	//	%w = String::getSubStr(%lootbaglist, 0, %p);
	//
	//	Item::Pop(%w);
	//	storeData(%clientId, "lootbaglist", RemoveFromCommaList(%lootbaglist, %w));
	//}

}

function spawnblue(%lootbag)
{
	%glow = newObject("GLOWGREEN" @ %lootbag, StaticShape, PACK_GGREEN);
	addToSet("MissionCleanup", %glow);
	GameBase::setMapName(%glow, "Backpack");
	%pos = GameBase::getPosition(%lootbag);
	GameBase::setPosition(%glow, %pos);
	%lootbag.Glow = %glow;
	
}

function ChangeSky(%sky)
{
	dbecho($dbechoMode, "ChangeSky(" @ %sky @ ")");

	%group = nameToId("MissionGroup\\LandScape");
	if(%group != -1)
	{
		%count = Group::objectCount(%group);
		for(%i = 0; %i <= %count-1; %i++)
		{
			%object = Group::getObject(%group, %i);
			if(getObjectType(%object) == "Sky")
			{
				deleteobject(%object);
			}
		}
	}

	%newsky = newObject(Sky, Sky, 0, 0, 0, %sky, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
	addToSet("MissionGroup\\LandScape", %newsky);
}

function RefreshAll(%clientId,%noapp)
{
	dbecho($dbechoMode, "RefreshAll(" @ %clientId @ ")");
	RefreshWeight(%clientId);
	if (!%noapp)
		UpdateAppearance(%clientId);
	refreshHPREGEN(%clientId);
	refreshMANAREGEN(%clientId);
	Game::refreshClientScore(%clientId);
}

function HasThisStuff(%clientId, %list, %multiplier)
{
	dbecho($dbechoMode, "HasThisStuff(" @ %clientId @ ", " @ %list @ ")");

	echo("HASTHISSTUFF " @ %list);

	if(%list == "")
		return True;

	if(%multiplier == "" || %multiplier <= 0)
		%multiplier = 1;

	%name = Client::getName(%clientId);

	//--------
	// PASS 1
	//--------
	%flag = False;

	for(%i = 0; GetWord(%list, %i) != -1; %i+=2)
	{
		%w = GetWord(%list, %i);
		%w2 = GetWord(%list, %i+1);
		%tw2 = %w2 * 1;
		if(%tw2 == %w2)
			%w2 *= %multiplier;

		if(%w == "LVLG")
		{
			if(fetchData(%clientId, "LVL") > %w2)
				%flag = True;
			else
				%flag = 667;
		}
		else if(%w == "LVLS")
		{
			if(fetchData(%clientId, "LVL") < %w2)
				%flag = True;
			else
				%flag = 667;
		}
		else if(%w == "LVLE")
		{
			if(fetchData(%clientId, "LVL") == %w2)
				%flag = True;
			else
				%flag = 667;
		}
	}

	if(%flag == 667)
		return %flag;


	//--------
	// PASS 2
	//--------
	%cntindex = 0;
	%flag = False;

	for(%i = 0; GetWord(%list, %i) != -1; %i+=2)
	{
		%w = GetWord(%list, %i);
		%w2 = GetWord(%list, %i+1);
		%tw2 = %w2 * 1;
		if(%tw2 == %w2)
			%w2 *= %multiplier;

		if(%w == "CNT")
		{
			%cntindex++;
			%tmpcnt[%cntindex] = %w2;
		}
		else if(%w == "CNTAFFECTS")
		{
			%tmpcntaffects[%cntindex] = %w2;
		}
	}

	//Process the counter data, if any
	for(%i = 1; %tmpcnt[%i] != ""; %i++)
	{
		if(%tmpcnt[%i] != "" && %tmpcntaffects[%i] != "")
		{
			%firstchar = String::getSubStr(%tmpcnt[%i], 0, 1);
			%n = floor(String::getSubStr(%tmpcnt[%i], 1, 9999));
			if(%firstchar == "<")
			{
				if($QuestCounter[%name, %tmpcntaffects[%i]] < %n)
					%flag = True;
				else
					%flag = 666;
			}
			else if(%firstchar == ">")
			{
				if($QuestCounter[%name, %tmpcntaffects[%i]] > %n)
					%flag = True;
				else
					%flag = 666;
			}
			else if(%firstchar == "=")
			{
				if($QuestCounter[%name, %tmpcntaffects[%i]] == %n)
					%flag = True;
				else
					%flag = 666;
			}
		}
		if(%flag == 666)
			return %flag;
	}


	//--------
	// PASS 3
	//--------
	%flag = True;

	for(%i = 0; GetWord(%list, %i) != -1; %i+=2)
	{
		%w = GetWord(%list, %i);
		%w2 = GetWord(%list, %i+1);
		%tw2 = %w2 * 1;
		if(%tw2 == %w2)
			%w2 *= %multiplier;

		if(%w == "COINS")
		{
			if(fetchData(%clientId, "COINS") >= %w2)
				%flag = True;
			else
				return False;
		}
		else if(%w == "REMORT")
		{
			if(fetchData(%clientId, "RemortStep") >= %w2)
				%flag = True;
			else
				return False;
		}
		else if(%w == "RankPoints")
		{
			if(fetchData(%clientId, "RankPoints") >= %w2)
				%flag = True;
			else
				return False;
		}
		else if(%w == "AI")
		{
			%isAI = Player::isAIcontrolled(%clientId);
			if(%isAI == %w2)
				%flag = True;
			else
				return False;
		}
		else if(%w == "EXP")
		{
			if(fetchData(%clientId, "EXP") >= %w2)
				%flag = True;
			else
				return False;
		}

		// ADDED CRU QUEST --------------------------------------------------------------------

		else if (%w == "NQUEST") {
			%flag = True;
			if (HasCruQuest(%clientId,%w2) == True)
				return False;
			if (HasCruQuestComplete(%clientId,%w2) == True)
				return False;
		}

		else if (%w == "CQUEST") {
			if (HasCruQuestComplete(%clientId,%w2) == True)
				%flag = True;
			else
				return False;
		}

		else if (%w == "HQUEST") {
			echo("CHECKING HQUEST " @ %w2);
			if (HasCruQuest(%clientId,%w2) == True)
				%flag = True;
			else
				return False;
		}

		// END CRU QUEST ----------------------------------------------------------------------



		else if (%w != "COINS" && %w != "REMORT" && %w != "LVLG" && %w != "LVLS" && %w != "LVLE" && %w != "CNT" && %w != "CNTAFFECTS" && %w != "RankPoints" && %w != "AI" && %w != "EXP" && %w != "NQUEST" && %w != "CQUEST" && %w != "HQUEST")
		{
			if (IsBackpackItem(%w)) {
				if (HasBackpackCount(%clientId,%w,%w2) == true) {
					%flag = True;
				}
				else {
					return False;
				}
			}
			else {
				if(Player::getItemCount(%clientId, %w) >= %w2)
					%flag = True;
				else
					return False;
			}
		}
	}

	return %flag;
}

function TakeThisStuff(%clientId, %list, %multiplier)
{
	dbecho($dbechoMode, "TakeThisStuff(" @ %clientId @ ", " @ %list @ ")");

	if(%multiplier == "" || %multiplier <= 0)
		%multiplier = 1;

	for(%i = 0; GetWord(%list, %i) != -1; %i+=2)
	{
		%w = GetWord(%list, %i);
		%w2 = GetWord(%list, %i+1);
		%tw2 = %w2 * 1;
		if(%tw2 == %w2)
			%w2 *= %multiplier;

		if(%w == "COINS")
		{
			if(fetchData(%clientId, "COINS") >= %w2)
				storeData(%clientId, "COINS", %w2, "dec");
			else
				return False;
		}
		else if(%w == "EXP")
		{
			if(fetchData(%clientId, "EXP") >= %w2)
				storeData(%clientId, "EXP", %w2, "dec");
			else
				return False;
		}
		else if(%w == "CNT" || %w == "CNTAFFECTS" || %w == "LVLG" || %w == "LVLS" || %w == "LVLE")
		{
			//ignore
		}
		else
		{
			if (isBackpackItem(%w)) {
				RemoveFromBackpack(%clientId,%w,%w2 * -1);
			}
			else {
				
				%amount = Player::getItemCount(%clientId, %w);
				if(%amount >= %w2)
					Player::setItemCount(%clientId, %w, %amount-%w2);
				else
					return False;
			}
		}
	}

	return True;
}

// RANDOM LOOT GROUP

$LootGroup[starters,1] = "Leather";
$LootGroup[starters,2] = "SnakeSkin";
$LootGroup[starters,3] = "SteelPlate";
$LootGroup[starters,4] = "ChainMesh";

function RandomLootGroup(%g)
{
	if ($LootGroup[%g,1] == "")
		return False;
	%t = 0;
	for (%i = 1; (%item = $LootGroup[%g,%i]) != ""; %i++) {
		%t++;
	}
	%r = floor(getRandom() * %t + 1);
	return $LootGroup[%g,%r];
}

function GiveThisStuff(%clientId, %list, %echo, %multiplier, %nobonus)
{
	dbecho($dbechoMode, "GiveThisStuff(" @ %clientId @ ", " @ %list @ ", " @ %echo @ ")");

	if (%nobonus == "")
		%nobonus = 0;

	%name = Client::getName(%clientId);

	if(%multiplier == "" || %multiplier <= 0)
		%multiplier = 1;

	%cntindex = 0;

	for(%i = 0; GetWord(%list, %i) != -1; %i+=2)
	{
		%w = GetWord(%list, %i);
		%w2 = GetWord(%list, %i+1);

		//if there is a / in %w2, then what trails after the / is the minimum random number between 0 and 100 which
		//is applied as a percentage to the starting number of %w2
		%spos = String::findSubStr(%w2, "/");
		if(%spos > 0)
		{
			%original = String::getSubStr(%w2, 0, %spos);
			%perc = String::getSubStr(%w2, %spos+1, 99999);

			// orig 1
			// perc = -9000

			%r = floor(getRandom() * (100-%perc))+%perc+1;
		
			// r = getrandom() * 9100 + -8999
			// r = getrandom () * 101
			
			if(%r > 100) %r = 100;

			%w2 = round(%original * (%r/100));
			if(%w2 < 0) %w2 = 0;
		}

		//if there is a d in %w2 AND it has a number on either side, then it's a dice roll
		%dpos = String::findSubStr(%w2, "d");
		%l1 = String::getSubStr(%w2, %dpos-1, 1);
		%l2 = floor(%l1);
		%r1 = String::getSubStr(%w2, %dpos+1, 1);
		%r2 = floor(%r1);
		if(%dpos > 0 && String::ICompare(%l1, %l2) == 0 && String::ICompare(%r1, %r2) == 0)
		{
			%w2 = GetRoll(%w2);
			if(%w2 < 1) %w2 = 1;
		}

		%tw2 = %w2 * 1;
		if(%tw2 == %w2)
			%w2 *= %multiplier;

		

		if (String::findSubStr(%w,"LOOTGROUP") != -1) {
			%g = String::getSubStr(%w2, 10, 99999);
			%w = RandomLootGroup(%g);
			if (%w == False)
				%w2 = 0;
		}


		//------------------------------------------------------------
		// MANUAL SETS

		if (%w == "SETINVIS") {
			player::setArmor(%clientId,invisablearmor);
		}

		if (%w == "SETANIMATION") {
			CruAniLoop(%clientId,%w2);
		}

		if (%w == "WEAPON") {
			%vis = $BPItem[%w2,$BPVis];
			Player::MountItem(%clientId,%vis,0);
			$PlayerWear[%clientId,13] = %w2;
		}

		if (%w == "CRURACE") {
			storeData(%clientId,"CruRACE",%w2);
		}
		//------------------------------------------------------------

		if(%w == "COINS")
		{
			storeData(%clientId, "COINS", %w2, "inc");
			if(%echo) Client::sendMessage(%clientId, 0, "You received " @ %w2 @ " coins.");
			SideBonus(%clientId,$GoldBonus,%w2,%nobonus);
		}
		else if(%w == "EXP")
		{
			storeData(%clientId, "EXP", %w2, "inc");
			if(%echo) Client::sendMessage(%clientId, 0, "You received " @ %w2 @ " experience.");
			SideBonus(%clientId,$ExpBonus,%w2,%nobonus);
		}
		else if(%w == "LCK")
		{
			storeData(%clientId, "LCK", %w2, "inc");
			if(%echo) Client::sendMessage(%clientId, 0, "You received " @ %w2 @ " LCK.");
			SideBonus(%clientId,$LckBonus,%w2,%nobonus);
		}
		else if(%w == "SP")
		{
			storeData(%clientId, "SPcredits", %w2, "inc");
			if(%echo) Client::sendMessage(%clientId, 0, "You received " @ %w2 @ " Skill Points.");
			SideBonus(%clientId,$SpBonus,%w2,%nobonus);
		}
		else if(%w == "CLASS")
		{
			storeData(%clientId, "CLASS", %w2);
			storeData(%clientId, "GROUP", $ClassGroup[fetchData(%clientId, "CLASS")]);
		}
		else if(%w == "LVL")
		{
			//note: the class MUST be specified in %stuff prior to this call
			storeData(%clientId, "EXP", GetExp(%w2, %clientId) + 100);
		}
		else if(%w == "TEAM")
		{
			GameBase::setTeam(%clientId, %w2);
			if(%echo) Client::sendMessage(%clientId, 0, "Team set to " @ %w2 @ ".");
		}
		else if(%w == "RankPoints")
		{
			storeData(%clientId, "RankPoints", %w2, "inc");
			if(%echo) Client::sendMessage(%clientId, 0, "You received " @ %w2 @ " Rank Points.");
			SideBonus(%clientId,$RankBonus,%w2,%nobonus);
		}
		else if(%w == "CNT")
		{
			%cntindex++;
			%tmpcnt[%cntindex] = %w2;
		}
		else if(%w == "CNTAFFECTS")
		{
			%tmpcntaffects[%cntindex] = %w2;
		}

		// ADDED CRU QUEST ---------------------------------------------------------
		else if (%w == "GQUEST") {
			AddCruQuest(%clientId,%w2);
		}
		else if (%w == "QUESTINCKILL") {
			$QuestInc[%clientId,KILL] = %w2;
		}
		else if (%w == "INCQUEST") {
			IncCruQuest(%clientId,%w2);
		}
		else if (%w == "CQUEST") {
			$PlayerCruComplete[%clientId] = $PlayerCurComplete[%clientid] @ %w2 @ " ";
		}
		// END CRU QUEST  ----------------------------------------------------------

		else
		{
			if (isBackpackItem(%w)) {
				if (%w2 > 0) {	
					Item::giveItem(%clientId, %w, %w2, 0);
				}
			}
			else {
				if (%w2 > 0) {		
					Item::giveItem(%clientId, %w, %w2, %echo);
				}
			}
		}
	}

	RefreshAll(%clientId);

	//Process the counter data, if any
	for(%i = 1; %tmpcnt[%i] != ""; %i++)
	{
		if(%tmpcnt[%i] != "" && %tmpcntaffects[%i] != "")
		{
			%first = String::getSubStr(%tmpcnt[%i], 0, 1);
			if(%first == "+" || %first == "-")
				$QuestCounter[%name, %tmpcntaffects[%i]] += floor(%tmpcnt[%i]);
			else
				$QuestCounter[%name, %tmpcntaffects[%i]] = floor(%tmpcnt[%i]);
		}
	}
}
	
function getSpawnIndex(%aiName)
{
	dbecho($dbechoMode, "getSpawnIndex(" @ %aiName @ ")");

	for(%i = 1; $spawnIndex[%i] != ""; %i++)
	{
		if($spawnIndex[%i] == %aiName)
			return %i;
	}
	return -1;
}

function FellOffMap(%id)
{
	dbecho($dbechoMode, "FellOffMap(" @ %id @ ")");

	RefreshAll(%id);

	if(Player::isAiControlled(%id))
	{
		storeData(%id, "noDropLootbagFlag", True);
		playNextAnim(%id);
		Player::Kill(%id);
	}
	else
	{
		CheckAndBootFromArena(%id);
		Item::setVelocity(%id, "0 0 0");
		TeleportToMarker(%id, "TheArena\\TeleportExitMarkers", 0, 0);

		Client::sendMessage(%id, $MsgRed, "You were restored to the arena exit marker.");
	}
}

function SetStuffString(%stuff, %item, %amount)
{
	dbecho($dbechoMode, "SetStuffString(" @ %stuff @ ", " @ %item @ ", " @ %amount @ ")");

	//replaces both Add and Remove stuff string functions by enabling negative values for %amount

	%stuff = FixStuffString(%stuff);

	%pos = String::findSubStr(%stuff, " " @ %item @ " ");

	if(%pos != -1)
	{
		%a = String::NEWgetSubStr(%stuff, %pos+1, 99999);
		%amt = GetWord(%a, 1);	//getword 0 would be the item, so getword 1 is the amount (which follows the item)

		%part1 = String::NEWgetSubStr(%stuff, 0, %pos+1);
		%part2 = String::NEWgetSubStr(%stuff, %pos+String::len(%item)+String::len(%amt)+3, 99999);

		%b = %amt + %amount;
		if(%b <= 0)
			%part3 = "";
		else
			%part3 = %item @ " " @ %b @ " ";

		%final = %part1 @ %part2 @ %part3;
	}
	else
		%final = %stuff @ %item @ " " @ %amount @ " ";

	return %final;
}

function GetStuffStringCount(%stuff, %item)
{
	dbecho($dbechoMode, "GetStuffStringCount(" @ %stuff @ ", " @ %item @ ")");

	%stuff = FixStuffString(%stuff);

	%pos = String::findSubStr(%stuff, " " @ %item @ " ");

	if(%pos != -1)
	{
		%a = String::NEWgetSubStr(%stuff, %pos+1, 99999);
		%amt = GetWord(%a, 1);

		return %amt;
	}

	return 0;
}

function FixStuffString(%stuff)
{
	dbecho($dbechoMode, "FixStuffString(" @ %stuff @ ")");

	%nstuff = " ";
	for(%i = 0; GetWord(%stuff, %i) != -1; %i++)
	{
		%w = GetWord(%stuff, %i);
		%nstuff = %nstuff @ %w @ " ";
	}

	return %nstuff;
}

function IsStuffStringEquiv(%s1, %s2, %dblCheck)
{
	dbecho($dbechoMode, "IsStuffStringEquiv(" @ %s1 @ ", " @ %s2 @ ", " @ %dblCheck @ ")");

	//this function COULD be laggy, it all depends on how many items are in %s1.  Below 5, IMO, should be just fine

	%s1 = " " @ %s1;
	%s2 = " " @ %s2;
	for(%x = 0; (%w = GetWord(%s1, %x)) != -1; %x+=2)
	{
		%w2 = GetWord(%s1, %x+1);

		if(String::findSubStr(%s2, " " @ %w @ " " @ %w2) == -1)
			return False;
	}
	if(%x == 0)			//do a dblCheck if %s1 is null.
		%dblCheck = True;

	if(%dblCheck)
	{
		//This will slow down the function, but will get a more accurate reading.
		//If you do NOT do a dblCheck, then %s2 could contain additional items that %s1 does not contain, and still
		//return True.  If this is not a concern, then you don't have to do a dblCheck
		for(%x = 0; (%w = GetWord(%s2, %x)) != -1; %x+=2)
		{
			%w2 = GetWord(%s2, %x+1);
	
			if(String::findSubStr(%s1, " " @ %w @ " " @ %w2) == -1)
				return False;
		}
	}

	return True;
}

//$tst = "I am typing a whole bunch of bullshit on this screen so I can fix this stupid bug concerning the storage. The string::getsubstr function can only get two-hundred fifty five (255) characters from a string, so whenever this function was performed on the storage stuff string, alot of info would get lost. Players were actually capable of spawning items that aren't normally supposed to be spawned, like the Deployable Base for example. This is a big problem, but with this NEWgetSubStr function that I wrote, which splits up strings into chunks of 255 in order to get the string portion properly, the storage bug should go away and there should be a hell of a lot less cheating.";
function String::NEWgetSubStr(%s, %x, %y)
{
	dbecho($dbechoMode, "String::NEWgetSubStr(" @ %s @ ", " @ %x @ ", " @ %y @ ")");

	%len = %y;
	%chunks = floor(%len / 255) + 1;

	%q = %len;
	%nx = %x;
	%final = "";

	for(%i = 1; %i <= %chunks; %i++)
	{
		%q = %q - 255;
		if(%q <= 0)
			%chunkLen = %q+255;
		else
			%chunkLen = 255;

		%final = %final @ String::getSubStr(%s, %nx, %chunkLen);
		%nx = %nx + %chunkLen;
	}

	return %final;
}

function GetRoll(%roll, %optionalMinMax)
{
	dbecho($dbechoMode, "GetRoll(" @ %roll @ ", " @ %optionalMinMax @ ")");

	//this function accepts the following syntax, where N is any positive number NOT containing a +:
	//NdN
	//NdN+N
	//NdN-N
	//NdNxN
	//NdN+NxN
	//NdN-NxN

	%d = String::findSubStr(%roll, "d");
	%p = String::findSubStr(%roll, "+");
	if(%p == -1)
		%m = String::findSubStr(%roll, "-");
	%x = String::findSubStr(%roll, "x");

	if(%d == -1)
		return %roll;

	if(%x == -1)
		%x = String::len(%roll);

	%numDice = floor(String::getSubStr(%roll, 0, %d));
	if(%p != -1)
	{
		%diceFaces = String::getSubStr(%roll, %d+1, %p-%d-1);
		%bonus = String::getSubStr(%roll, %p+1, %x-1);
	}
	else if(%p == -1 && %m != -1)
	{
		%diceFaces = String::getSubStr(%roll, %d+1, %m-%d-1);
		%bonus = -String::getSubStr(%roll, %m+1, %x-1);
	}
	else
		%diceFaces = String::getSubStr(%roll, %d+1, 99999);

	%total = 0;
	for(%i = 1; %i <= %numDice; %i++)
	{
		if(%optionalMinMax == "min")
			%r = 1;
		else if(%optionalMinMax == "max")
			%r = %diceFaces;
		else
			%r = floor(getRandom() * %diceFaces)+1;

		%total += %r;
	}

	if(%bonus != "")
		%total += %bonus;

	if(%x != String::len(%roll))
		%total *= String::getSubStr(%roll, %x+1, 99999);

	return %total;
}

function GetCombo(%n)
{
	dbecho($dbechoMode, "GetCombo(" @ %n @ ")");

	//--- This is used so ComboTables don't get overwritten by simultaneous calls ---
	$w++;
	if($w > 20) $w = 1;
	//-------------------------------------------------------------------------------

	for(%i = 1; $ComboTable[$w, %i] != ""; %i++)
		$ComboTable[$w, %i] = "";

	%cnt = 0;

	while(%i != -1)
	{
		for(%i = 0; pow(2, %i) <= %n; %i++){}
		%i--;

		if(%i >= 0)
		{
			$ComboTable[$w, %cnt++] = pow(2, %i);
			%n -= pow(2, %i);
		}
	}

	return $w;
}

function IsPartOfCombo(%combo, %n)
{
	dbecho($dbechoMode, "IsPartOfCombo(" @ %combo @ ", " @ %n @ ")");

	%w = GetCombo(%combo);

	%flag = false;

	for(%i = 1; $ComboTable[%w, %i] != ""; %i++)
	{
		if(%n == $ComboTable[%w, %i])
			%flag = true;

		//It's a good idea to clean up after oneself, especially with all the ComboTables that would be floating around
		$ComboTable[%w, %i] = "";
	}

	return %flag;
}

function IsDead(%id)
{
	%clientId = Player::getClient(%id);
	%player = Client::getOwnedObject(%clientId);
	if (Player::isAiControlled(%player)) {
		if ($AIISDEAD[%id] == 1)
			return True;
	}
	if (%player == -1)
		return True;
	else
		return False;
}

function Cap(%n, %lb, %ub)
{
	if(%lb != "inf")
	{
		if(%n < %lb)
			%n = %lb;
	}
	if(%ub != "inf")
	{
		if(%n > %ub)
			%n = %ub;
	}
	return %n;
}

function MaxCap(%n,%c)
{
	if (%n > %c)
		return %c;
	else
		return %n;
}

function GetNESW(%pos1, %pos2)
{
	dbecho($dbechoMode, "GetNESW(" @ %pos1 @ ", " @ %pos2 @ ")");

	%v1 = Vector::sub(%pos1, %pos2);
	%v2 = Vector::getRotation(%v1);
	%a = GetWord(%v2, 2);

	if(%a >= 2.7475 && %a <= 3.15 || %a >= -3.15 && %a <= -2.7475)
		%d = "North";
	else if(%a >= 1.9625 && %a <= 2.7475)
		%d = "North East";
	else if(%a >= 1.1775 && %a <= 1.9625)
		%d = "East";
	else if(%a >= 0.3925 && %a <= 1.1775)
		%d = "South East";
	else if(%a >= -0.3925 && %a <= 0.3925)
		%d = "South";
	else if(%a >= -1.1775 && %a <= -0.3925)
		%d = "South West";
	else if(%a >= -1.9625 && %a <= -1.1775)
		%d = "West";
	else if(%a >= -2.7475 && %a <= -1.9625)
		%d = "North West";

	return %d;
}

function SetOnGround(%clientId, %extraZ)
{
	dbecho($dbechoMode, "SetOnGround(" @ %clientId @ ", " @ %extra2 @ ")");

	%maxdist = 5000;

	%origpos = GameBase::getPosition(%clientId);

	%x = GetWord(%origpos, 0);
	%y = GetWord(%origpos, 1);
	%z = GetWord(%origpos, 2);

	%finalpos = %x @ " " @ %y @ " " @ %z + %extraZ;

	GameBase::setPosition(%clientId, %finalpos);

	%index = 0;
	//for(%i = 0; %i >= -3.15; %i -= 1.57)
	for(%i = 0; %i >= -4.725; %i -= 0.785)
	{
		if(GameBase::getLOSinfo(Client::getOwnedObject(%clientId), %maxdist, %i @ " 0 0"))
		{
			%index++;
			%pos[%index] = $los::position;
		}
	}

	%closest = %maxdist+1;
	for(%j = 1; %j <= %index; %j++)
	{
		%dist = Vector::getDistance(%pos[%j], %finalpos);
		if(%dist < %closest)
		{
			%closest = %dist;
			%closestIndex = %j;
		}
	}

	if(%pos[%closestIndex] != "")
		GameBase::setPosition(%clientId, %pos[%closestIndex]);
	else
		GameBase::setPosition(%clientId, %origpos);

	return %pos[%closestIndex];
}

function WalkSlowInvisLoop(%clientId, %delay, %grace)
{
	dbecho($dbechoMode, "WalkSlowInvisLoop(" @ %clientId @ ", " @ %delay @ ", " @ %grace @ ")");

	%pos = GameBase::getPosition(%clientId);
	if(fetchData(%clientId, "lastPos") == "")
		storeData(%clientId, "lastPos", %pos);

	if(Vector::getDistance(%pos, fetchData(%clientId, "lastPos")) <= %grace && fetchData(%clientId, "invisible"))
	{
		storeData(%clientId, "lastPos", GameBase::getPosition(%clientId));
		schedule("WalkSlowInvisLoop(" @ %clientId @ ", " @ %delay @ ", " @ %grace @ ");", %delay, %clientId);
	}
	else
	{
		if(fetchData(%clientId, "invisible"))
			UnHide(%clientId);

		Client::sendMessage(%clientId, $MsgRed, "You are no longer Hiding In Shadows.");

	}
}
function UnHide(%clientId)
{
	//dbecho($dbechoMode, "UnHide(" @ %clientId @ ")");
	if(fetchData(%clientId, "invisible"))
	{
		GameBase::startFadeIn(%clientId);
		storeData(%clientId, "invisible", "");
	}
	//storeData(%clientId, "lastPos", "");
	//storeData(%clientId, "blockHide", True);
	//schedule("storeData(" @ %clientId @ ", \"blockHide\", \"\");", 10);
}

function DisplayGetInfo(%clientId, %id, %obj)
{
	dbecho($dbechoMode, "DisplayGetInfo(" @ %clientId @ ", " @ %id @ ", " @ %obj @ ")");

	if(%clientId.adminLevel >= 1)
		%showid = %id @ " (" @ %obj @ ")";
	else
		%showid = "";

	if(fetchData(%id, "MyHouse") != "")
		%house = "*** Proud member of <f2>" @ fetchData(%id, "MyHouse") @ "<f0>";
	else
		%house = "";

	%msg = "<f1>" @ Client::getName(%id) @ ", LEVEL " @ fetchData(%id, "LVL") @ "+" @ fetchData(%id,"ALVL") @ " " @ fetchData(%id, "CruRACE") @ " " @ getFinalCLASS(%id) @ "<f0> " @ " " @ %showid @ "\n" @ %house @ "\n" @ fetchData(%id, "PlayerInfo");
	if(fetchData(%id, "PlayerInfo") == "")
		%msg = %msg @ "This player has not setup his/her information.  Use #setinfo to set this type of information.";

	bottomprint(%clientId, %msg, floor(String::len(%msg) / 20));
}

function AddToTargetList(%clientId, %cl)
{
	dbecho($dbechoMode, "AddToTargetList(" @ %clientId @ ", " @ %cl @ ")");

	%name = Client::getName(%cl);
	if(!IsInCommaList(fetchData(%clientId, "targetlist"), %name))
	{
		storeData(%clientId, "targetlist", AddToCommaList(fetchData(%clientId, "targetlist"), %name));

		Client::sendMessage(%cl, $MsgRed, Client::getName(%clientId) @ " wants you dead!  Travel carefully!");
		Client::sendMessage(%clientId, $MsgRed, %name @ " has been notified of your intentions.");

		schedule("RemoveFromTargetList(" @ %clientId @ ", " @ %cl @ ");", 10 * 60);
	}
}
function RemoveFromTargetList(%clientId, %cl)
{
	dbecho($dbechoMode, "RemoveFromTargetList(" @ %clientId @ ", " @ %cl @ ")");

	%name = Client::getName(%cl);
	if(IsInCommaList(fetchData(%clientId, "targetlist"), %name))
	{
		storeData(%clientId, "targetlist", RemoveFromCommaList(fetchData(%clientId, "targetlist"), %name));

		Client::sendMessage(%cl, $MsgBeige, Client::getName(%clientId) @ " was forced to declare a truce.");
		Client::sendMessage(%clientId, $MsgBeige, %name @ " has expired on your target-list.");
	}
}

$TierItemTypeDisp[0] = "Common";
$TierItemTypeDisp[1] = "Basic";
$TierItemTypeDisp[2] = "Improved";
$TierItemTypeDisp[3] = "Fine";
$TierItemTypeDisp[4] = "Magic";
$TierItemTypeDisp[5] = "Rare";
$TierItemTypeDisp[6] = "Legendary";
$TierItemTypeDisp[7] = "Set";
$TierItemTypeDisp[8] = "Unique";
$TierItemTypeDisp["NA"] = "";

$TierColor[0] = "<f2>"; $TierTranslate[0] = false;
$TierColor[1] = "<f2>"; $TierTranslate[1] = false;
$TierColor[2] = "<f2>"; $TierTranslate[2] = false;
$TierColor[3] = "<f2>"; $TierTranslate[3] = false;
$TierColor[4] = "<f1>"; $TierTranslate[4] = true;
$TierColor[5] = "<f1>"; $TierTranslate[5] = false;
$TierColor[6] = "<f0>"; $TierTranslate[6] = false;
$TierColor[7] = "<f0>"; $TierTranslate[7] = true;
$TierColor[8] = "<f2>"; $TierTranslate[8] = true;

function WhatIs(%item,%id)
{
	%msg = %msg @ "<f2>";
	%translate = false;
	%baseitem = $BPItem[%item,$BPBaseItem];
	%sreq = $DynamicItem[%baseitem,$DReq];
	if ($BPItem[%item,$BPName] != "") {
		//========================================================================================================
		%qual = String::GetSubStr(%item,0,3);
		%qual = %qual * 1;
		if (%qual == 999)
			%qual = "Special";
		//========================================================================================================
		%typedisp = "";
		if ((%itemtype = $BPItem[%item,$BPItemType]) != "") {
			%tier = getWord(%itemtype,0);
			%color = $TierColor[%tier];
			%msg = %msg @ %color;
			%translate = $TierTranslate[%tier];
			if (%translate == "") %translate = false;
			%v = "";
			if (getWord(%itemtype,1) != -1) %v = %v @ getWord(%itemtype,1) @ " ";
			if (getWord(%itemtype,2) != -1) %v = %v @ getWord(%itemtype,2) @ " ";
			if (getWord(%itemtype,3) != -1) %v = %v @ getWord(%itemtype,3) @ " ";
			if ($TierItemTypeDisp[%tier] != "")
				%typedisp = $TierItemTypeDisp[%tier] @ " " @ %v;
			else
				%typedisp = getWord(%itemtype,0) @ " " @ getword(%itemtype,1);
			%typedisp = string::translate(%typedisp,%translate);
		}
		if ($NoDropItem[%item])
			%msg = %msg @ %typedisp @ string::translate(", No Drop Item",%translate) @ "\n\n\n";
		else
			%msg = %msg @ %typedisp @ "\n\n\n";
		//========================================================================================================
		if ($BPItem[%item,$BPIco] != "") {
			%msg = %msg @ "<b" @ $BPItem[%item,$BPIco] @ ">\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPWeaponTwoHand] == 0)
			%msg = %msg @ string::translate($BPItem[%item,$BPName],%translate) @ "\n";
		else
			%msg = %msg @ string::translate($BPItem[%item,$BPName] @ " (2 Hand)",%translate) @ "\n";
		//========================================================================================================
		%msg = %msg @ string::translate("Quality: " @ %qual,%translate);
		if ($BPItem[%item,$BPIntegrity] != "" && $BPItem[%item,$BPIntegrity] > 0)
			%msg = %msg @ string::translate("\nIntegrity: +" @ $BPItem[%item,$BPIntegrity] @ "%",%translate);
		if ($BPItem[%item,$BPTierPerc] > 0 && $BPItem[%item,$BPTierPerc] != "") {
			%msg = %msg @ string::translate("\nModifiers: " @ $BPItem[%item,$BPTierPerc],%translate) @ "\n\n\n"; 
		}
		else {
			%msg = %msg @ "\n\n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPImplicit] != "") {
			%msg = %msg @ " " @ string::translate(BPFormat($BPItem[%item,$BPImplicit]),%translate) @ "\n\n"; 
		}
		//========================================================================================================
		if ($BPItem[%item,$BPMapMagic] != "") {
			%msg = %msg @ string::translate("Magic Find, Gold Find, Add Exp " @ $BPItem[%item,$BPMapMagic] @ "%",%translate) @ "\n\n"; 
		}
		//========================================================================================================
		if ($BPItem[%item,$BPWeaponMagDamage] != "") {
			%msg = %msg @ string::translate(" Spell Base Damage: " @ $BPItem[%item,$BPWeaponMagDamage],%translate) @ "\n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPDamage] != "") {
			%msg = %msg @ string::translate(" Damage: " @ $BPItem[%item,$BPDamage],%translate) @ "\n";
                        %damage = $BPItem[%item,$BPDamage];
			%dmgmin = getWord(%damage,0);
			%dmgmax = getWord(%damage,2);
			%delay = $BPItem[%item,$BPWeaponDelay];
			%dps = round(((%dmgmin + %dmgmax) / 2) / %delay);
			%msg = %msg @ string::translate(" DPS: " @ %dps,%translate) @ "\n";

		}
		if ($BPItem[%item,$BPDamageType] != "") {
			%msg = %msg @ string::translate(" DamageType: " @ $BPItem[%item,$BPDamageType],%translate) @ "\n";
			%delay = $BPItem[%item,$BPWeaponDelay];
			%msg = %msg @ string::translate(" Delay: " @ %delay @ " seconds",%translate) @ "\n\n";
			//%ret = CompareDPS(%id,%item);
			//%msg = %msg @ "		" @ %ret @ "\n\n";
		}	
		//========================================================================================================
		if ($BPItem[%item,$BPWield] != "") {
			%msg = %msg @ string::translate("Requirements:\n " @ BPFormat($BPItem[%item,$BPWield]),%translate) @ "\n\n";
			if ($BPItem[%item,$BPWieldBonus] != "")
				%msg = %msg @ string::translate("Wield Bonus:\n " @ BPFormat($BPItem[%item,$BPWieldBonus]),%translate) @ "\n\n";
			%loc = getWord($BPItem[%item,$BPWield],1);
		}
		//========================================================================================================
		if ($BPItem[%item,$BPMapMods] != "") {
			%msg = %msg @ string::translate(" Map Modifications:\n" @ FormatMapMods($BPItem[%item,$BPMapMods]),%translate) @ "\n\n";
		}
		//========================================================================================================
		if ((%sockets = $BPItem[%item,$BPNumSockets]) != "") {
			%msg = %msg @ string::translate("Sockets: " @ %sockets,%translate) @ " \n\n";
			for (%i = 1; %i <= %sockets; %i++)
				%msg = %msg @ "<bico_socket.bmp>";
			%msg = %msg @ "\n\n";
		}
		//========================================================================================================
		if ((%pockets = $BPItem[%item,$BPPockets]) != "") {
			%msg = %msg @ string::translate("Pockets: " @ %pockets,%translate) @ " \n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPTierProp] != "") {
			%itemtype = $BPItem[%item,$BPItemType];
			%truetype = getWord(%itemtype,1);
			if ((%hard = $BPItem[%item,$BPTierHard]) != "") {
				%perc = $BPItem[%item,$BPTierPerc];
				%hmsg = TierItem::GetHardDisp(%truetype,%hard,%qual,%perc);
				%msg = %msg @ string::translate("Wield Bonus:\n" @ %hmsg @ " +" @ $BPItem[%item,$BPTierProp] @ " Random Properties",%translate) @ "\n";
			}
			else {
				%msg = %msg @ string::translate("Wield Bonus:\n +" @ $BPItem[%item,$BPTierProp] @ " Random Properties",%translate) @ "\n";
			}
			%msg = %msg @ "\n";
		}	
		//========================================================================================================
		if ($BPItem[%item,$BPUse] != "") {
			%msg = %msg @ string::translate("Use:\n " @ BPFormat($BPItem[%item,$BPUse]),%translate) @ "\n";
			%msg = %msg @ string::translate("Use Bonus:\n " @ BPFormat($BPItem[%item,$BPUseBonus]),%translate) @ "\n\n";
		}
		//========================================================================================================
		//%nw = $BPItem[%item,$BPWeight];
		//========================================================================================================
		//%msg = %msg @ string::translate("Weight: " @ %nw,%translate) @ "\n";
		%msg = %msg @ string::translate("Price: $" @ $BPItem[%item,$BPPrice],%translate) @ "\n\n";
		//========================================================================================================
		if ($BPItem[%item,$BPSet] != "") {
			%set = $BPItem[%item,$BPSet];
			%msg = %msg @ string::translate(TierItem::SetBonusDisp(%set),%translate);
		}
		//========================================================================================================
		if ($BPItem[%item,$BPRune] != "") {
			%runebonus = $BPItem[%item,$BPRuneBonus];
			%mod = getWord(%runebonus,0);
			%msg = %msg @ string::translate("Rune Bonus:\n " @ BPFormat(%runebonus),%translate) @ "\n\n";
			%msg = %msg @ string::translate("Requirement: " @ BPReqDisplay($BPItem[%item,$BPRuneReq]),%translate) @ "\n";
			%msg = %msg @ string::translate("Location: " @ $BPItem[%item,$BPRuneLoc],%translate) @ "\n";
		}
		//========================================================================================================
		%msg = %msg @ string::translate($BPItem[%item,$BPDesc],%translate) @ "\n";
		//========================================================================================================
		if (%loc != "" && %id != -1) 
			%msg = %msg @ "<f2>You are wearing:\n"@WhatIsCompare(%id,%loc);
		//========================================================================================================
		if (string::findSubStr(%typedisp,"Spellcrystal") != -1) {
			%spell = GetWord($BPItem[%item,$BPUseBonus],1);
			%msg = %msg @ "\n\n" @ WhatIsCruSpell(0,%spell,True);
		}
		//========================================================================================================
		return %msg;
				
	}
	else {
		return "Item not found. (" @ %item @ ")";
	}
}

function WhatIsCompare(%id,%loc)
{
	//echo(" WHATISCOMPARE " @ %id @ " " @ %loc);
	if (%loc == "study")
		return "";
	%p = $BPLocationToNumeric[%loc];
	%wear = GetCurrentWearFull(%id,%p);
	%msg = "none";
	if (%wear != "none") {
		%msg = "";
		%item = %wear;
		if ((%name = $BPItem[%item,$BPName]) != "") {
			// ==================================================================================
			// QUALITY
			%qual = String::GetSubStr(%item,0,3);
			%qual = %qual * 1;
			if (%qual == 999)
				%qual = "Special";
			// ==================================================================================
			%translate = false;
			if ((%itemtype = $BPItem[%item,$BPItemType]) != "") {
				%tier = getWord(%itemtype,0);
				%color = $TierColor[%tier];
				%msg = %msg @ %color;
				%translate = $TierTranslate[%tier];
			}
			//==================================================================================
			// NAME
			%msg = %msg @ string::translate(%name,%translate) @ string::translate(", ",%translate) @ string::translate(CompareFormatType($BPItem[%item,$BPItemType]),%translate) @ string::translate(", ",%translate) @ string::translate("Quality: " @ %qual,%translate) @ string::translate(", ",%translate) @ string::translate(BPFormat($BPItem[%item,$BPImplicit]),%translate) @ "\n";
			// ==================================================================================
			// DAMAGE
			if ($BPItem[%item,$BPDamage] != "") {
				%msg = %msg @ string::translate("Damage: ",%translate) @ string::translate($BPItem[%item,$BPDamage],%translate) @ string::translate(", ",%translate);
                        	%damage = $BPItem[%item,$BPDamage];
				%dmgmin = getWord(%damage,0);
				%dmgmax = getWord(%damage,2);
				%delay = $BPItem[%item,$BPWeaponDelay];
				%dps = round(((%dmgmin + %dmgmax) / 2) / %delay);
				%msg = %msg @ string::translate("DPS: " @ %dps @ ", ",%translate);
			}
			if ($BPItem[%item,$BPDamageType] != "") {
				%msg = %msg @ string::translate("DamageType: " @ $BPItem[%item,$BPDamageType] @ ", ",%translate);
				%delay = $BPItem[%item,$BPWeaponDelay];
				%msg = %msg @ string::translate("Delay: " @ %delay @ " seconds",%translate) @ "\n";
			}
			if ($BPItem[%item,$BPWeaponMagDamage] != "") {
				%msg = %msg @ string::translate("Spell Base Damage: " @ $BPItem[%item,$BPWeaponMagDamage],%translate) @ "\n";
			}	
			//========================================================================================================
			// BONUSES
			%msg = %msg @ " " @ string::translate(BPFormat($BPItem[%item,$BPWieldBonus]),%translate);
		}
	}
	return %msg;
}

function CompareFormatType(%type)
{
	%t = getWord(%type,0);
	%i = getWord(%type,1);
	return $TierItemTypeDisp[%t] @ " " @ %i;
}

function FixDecimals(%c)
{
	dbecho($dbechoMode, "FixDecimals(" @ %c @ ")");

	%d = round(%c * 10);
	%m = (%d / 10) * 1.000001;

	return %m;
}

function AddToCommaList(%list, %item)
{
	dbecho($dbechoMode, "AddToCommaList(" @ %list @ ", " @ %item @ ")");

	%list = %list @ %item @ $sepchar;

	return %list;
}
function RemoveFromCommaList(%list, %item)
{
	dbecho($dbechoMode, "RemoveFromCommaList(" @ %list @ ", " @ %item @ ")");

	%a = $sepchar @ %list;
	%a = String::replace(%a, $sepchar @ %item @ $sepchar, ",");
	%list = String::NEWgetSubStr(%a, 1, 99999);

	return %list;
}
function IsInCommaList(%list, %item)
{
	dbecho($dbechoMode, "IsInCommaList(" @ %list @ ", " @ %item @ ")");

	%a = $sepchar @ %list;
	if(String::findSubStr(%a, "," @ %item @ ",") != -1)
		return True;
	else
		return False;
}
function CountObjInCommaList(%list)
{
	dbecho($dbechoMode, "CountObjInCommaList(" @ %list @ ")");

	for(%i = String::findSubStr(%list, ","); (%p = String::findSubStr(%list, ",")) != -1; %list = String::NEWgetSubStr(%list, %p+1, 99999))
		%cnt++;
	return %cnt;
}

function CountObjInList(%list)
{
	dbecho($dbechoMode, "CountObjInList(" @ %list @ ")");

	for(%i = 0; GetWord(%list, %i) != -1; %i++){}

	return %i;
}

function AddBounty(%clientId, %amt)
{
	dbecho($dbechoMode, "AddBounty(" @ %clientId @ ", " @ %amt @ ")");

	%b = fetchData(%clientId, "bounty") + %amt;
	storeData(%clientId, "bounty", Cap(%b, 0, 65000));

	return fetchData(%clientId, "bounty");
}

function PostSteal(%clientId, %success, %type)
{
	dbecho($dbechoMode, "PostSteal(" @ %clientId @ ", " @ %success @ ", " @ %type @ ")");

	if(%type == 0)
	{
		//regular steal
		if(%success)
			AddBounty(%clientId, 10);
		else
			AddBounty(%clientId, 100);
	}
	else if(%type == 1)
	{
		//pickpocket
		if(%success)
			AddBounty(%clientId, 40);
		else
			AddBounty(%clientId, 150);
	}
	else if(%type == 2)
	{
		//mug
		if(%success)
			AddBounty(%clientId, 80);
		else
			AddBounty(%clientId, 200);
	}

	if(%success)
		UpdateBonusState(%clientId, "Theft 1", 20 / 2);
	else
		UpdateBonusState(%clientId, "Theft 1", 120 / 2);
}

function GetTypicalTossStrength(%clientId)
{
	dbecho($dbechoMode, "GetTypicalTossStrength(" @ %clientId @ ")");

	if(fetchData(%clientId, "RACE") == "DeathKnight")
	{
		%toss = 10;
	}
	else
	{
		%a = Player::getArmor(%clientId);
		%b = String::getSubStr(%a, String::len(%a)-1, 1);
		%toss = Cap($speed[fetchData(%clientId, "RACE"), %b]-2, 3, 10);
	}

	return %toss;
}

function AllowedToSteal(%clientId)
{
	dbecho($dbechoMode, "AllowedToSteal(" @ %clientId @ ")");

	if(fetchData(%clientId, "InSleepZone") != "")
		return "You can't steal inside a sleeping area.";
	//else if(Zone::getType(fetchData(%clientId, "zone")) == "PROTECTED")
	//	return "You can't steal from someone in protected territory.";

	return "True";
}

function PerhapsPlayStealSound(%clientId, %type)
{
	dbecho($dbechoMode, "PerhapsPlayStealSound(" @ %clientId @ ", " @ %type @ ")");

	if(%type == 0)
		%snd = SoundMoney1;
	else if(%type == 1)
		%snd = SoundPickupItem;
	else if(%type == 2)
		%snd = SoundPickupItem;

	%r = getRandom() * 1000;
	%n = 1000 - $PlayerSkill[%clientId, $SkillStealing];
	if(%r <= %n)
	{
		playSound(%snd, GameBase::getPosition(%clientId));
		return True;
	}
	else
		return False;
}

function GetLCKcost(%clientId)
{
	dbecho($dbechoMode, "GetLCKcost(" @ %clientId @ ")");

	%a = floor( pow(2, Cap(fetchData(%clientId, "LCK"), 0, 26)) * 15 ) + 100;

	return Cap(%a, 0, "inf");
}

function GetEventCommandIndex(%object, %type)
{
	dbecho($dbechoMode, "GetEventCommandIndex(" @ %object @ ", " @ %type @ ")");

	%list = "";

	//5 event commands max. per object
	for(%i = 1; %i <= $maxEvents; %i++)
	{
		%t = GetWord($EventCommand[%object, %i], 1);
		if(String::ICompare(%t, %type) == 0)
			%list = %list @ %i @ " ";
	}

	if(%list != "")
		return String::getSubStr(%list, 0, String::len(%list)-1);
	else
		return -1;
}

function AddEventCommand(%object, %senderName, %type, %cmd)
{
	dbecho($dbechoMode, "AddEventCommand(" @ %object @ ", " @ %senderName @ ", " @ %type @ ", " @ %cmd @ ")");

	for(%i = 1; %i <= $maxEvents; %i++)
	{
		if($EventCommand[%object, %i] == "" || String::ICompare(GetWord($EventCommand[%object, %i], 1), %type) == 0)
		{
			$EventCommand[%object, %i] = %senderName @ " " @ %type @ " " @ %cmd;
			return %i;
		}
	}
	return -1;
}

function ClearEvents(%id)
{
	dbecho($dbechoMode, "ClearEvents(" @ %id @ ")");

	for(%i = 1; %i <= $maxEvents; %i++)
	{
		$EventCommand[%id, %i] = "";
		if(%id.tag != False)
			$EventCommand[%id.tag, %i] = "";
	}
}

function msprintf(%in, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8)
{
	dbecho($dbechoMode, "msprintf(" @ %in @ ", " @ %a1 @ ", " @ %a2 @ ", " @ %a3 @ ", " @ %a4 @ ", " @ %a5 @ ", " @ %a6 @ ", " @ %a7 @ ", " @ %a8 @ ")");

	%final = "";

	%cnt = 0;
	%list = %in;
	for(%p = String::findSubStr(%list, "%"); (%p = String::findSubStr(%list, "%")) != -1; %p = String::findSubStr(%list, "%"))
	{
		%crash++;
		if(%crash > 30)
		{
			echo("FATAL CRASH BUG...contact JeremyIrons and tell him his msprintf is fucking up");
			break;
		}

		%list = String::NEWgetSubStr(%list, %p+1, 99999);
		%cnt = String::getSubStr(%list, 0, 1);

		%check = String::findSubStr(%list, "%");
		if(%check == -1) %check = 99999;
		%endsign = String::findSubStr(%list, ";");

		if(%endsign != -1 && %endsign < %check)
		{
			%ev = String::NEWgetSubStr(%list, 1, %endsign);
			%a[%cnt] = eval("%x = " @ %a[%cnt] @ %ev);

			%in = String::replace(%in, %ev, "");
		}
	}

	return sprintf(%in, %a[1], %a[2], %a[3], %a[4], %a[5], %a[6], %a[7], %a[8]);
}

function nsprintf(%in, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8)
{
	dbecho($dbechoMode, "nsprintf(" @ %in @ ", " @ %a1 @ ", " @ %a2 @ ", " @ %a3 @ ", " @ %a4 @ ", " @ %a5 @ ", " @ %a6 @ ", " @ %a7 @ ", " @ %a8 @ ")");

	%list = %in;
	for(%p = String::findSubStr(%list, "%"); (%p = String::findSubStr(%list, "%")) != -1; %p = String::findSubStr(%list, "%"))
	{
		%list = String::NEWgetSubStr(%list, %p+1, 99999);
		%w = String::getSubStr(%list, 0, 1);
		if(!IsInCommaList("1,2,3,4,5,6,7,8,", %w))
			return "Error in syntax";
	}

	return msprintf(%in, %a[1], %a[2], %a[3], %a[4], %a[5], %a[6], %a[7], %a[8]);
}

function UnequipMountedStuff(%clientId)
{
	dbecho($dbechoMode, "UnequipMountedStuff(" @ %clientId @ ")");

	%max = getNumItems();
	for(%i = 0; %i < %max; %i++)
	{
		%a = getItemData(%i);
		%itemcount = Player::getItemCount(%clientId, %a);

		if(%itemcount)
		{
			if(%a.className == "Equipped")
			{
				%b = String::getSubStr(%a, 0, String::len(%a)-1);
				Player::decItemCount(%clientId, %a, 1);
				Player::incItemCount(%clientId, %b, 1);
			}
			else if(Player::getMountedItem(%clientId, $WeaponSlot) == %a)
			{
				Player::unMountItem(%clientId, $WeaponSlot);
			}
		}
	}

	UnequipBackpackWear(%clientId);
}

function LTrim(%s)
{
	dbecho($dbechoMode, "LTrim(" @ %s @ ")");

	%a = GetWord(%s, 0);
	%p1 = String::findSubStr(%s, %a);
	%s = String::NEWgetSubStr(%s, %p1, 99999);

	return %s;
}

function InitObjectives()
{
	%i = 1;
	Team::setObjective(0, %i, "<jc><f8>Welcome To Crucible RPG!");
	Team::setObjective(0, %i+=2, "<f6>Default Keys:");
	Team::setObjective(0, %i+=2, "<f5>I<f3> Toggle your Backpack (inventory)");
	Team::setObjective(0, %i+=2, "<f5>H<f3> Use Health potion");
	Team::setObjective(0, %i+=2, "<f5>J<f3> Use Energy Vial");
	Team::setObjective(0, %i+=2, "<f5>M<f3> Meditate (#meditate)");
	Team::setObjective(0, %i+=2, "<f5>N<f3> Wake (#wake)");
	Team::setObjective(0, %i+=2, "<f5>R<f3> Use key, Interact with NPC's when standing near them");
	Team::setObjective(0, %i+=2, "<f5>G<f3> Gear (#gear)");
	Team::setObjective(0, %i+=2, "<f6>Useful Commands:");
	Team::setObjective(0, %i+=2, "<f5>#set (key) (command)<f3> Used to bind a key to a command. Example: #set 1 #cast fireball");
	Team::setObjective(0, %i+=2, "<f5>#addfav (spell)<f3>You can bind a spell to your favorites list for quick casting. <f5>#fav<f3> to access this list. <f5>#rfav<f3> to remove from this list");
	Team::setObjective(0, %i+=2, "<f5>#sellall<f3> This will sell everything on your nosale list <f5>#nosale<f3> to remove items. Add items to your nosale by selecting the option in <f5>TAB");
	Team::setObjective(0, %i+=2, "<f5>#salvageall<f3> WARNING! This will salvage everything on your nosale list in your current backpack. Non reversable.");
	Team::setObjective(0, %i+=2, "<f0>TIP: Using a portal scroll will take you back to town. You can then go back to your portal location with the blue spinning portal in town");
	Team::setObjective(0, %i+=2, "<f0>TIP: Health potions and Energy Vials are double the regain when you are meditating");
}

function InitObjectives_old()
{
	dbecho($dbechoMode, "InitObjectives()");

	Team::setObjective(0, 1, "<jc><f8>Welcome To Tribes RPG!");
	Team::setObjective(0, 3, "<f5>Important Links:");
	Team::setObjective(0, 4, "<f0>http://www.planettribes.com/rpg <f2>-TRPG's Homepage");
	Team::setObjective(0, 5, "<f0>http://dynamic.gamespy.com/~rpg <f2>-TRPG Forum");
	Team::setObjective(0, 6, "<f0>http://www.mp3.com/theoryoftrance <f2>-Your key to earning Trancephyte");
	Team::setObjective(0, 8, "<f5>Getting Started:");
	Team::setObjective(0, 9, "<jc><f4>IT IS HIGHLY RECOMMENDED THAT YOU VISIT THE TRPG HOMEPAGE AND READ THE NEWBIE GUIDE EXTENSIVELY BEFORE ATTEMPTING TO PLAY!");
	Team::setObjective(0, 13, "<f1>Use the TAB key to access your skills and assign your SP (skill points) to them.");
	Team::setObjective(0, 14, "<f1>To find the maximum SP capability for your level, take your level #, multiply it by 10 and add 20 to the result and add another 1 for each time you've remorted.");
	Team::setObjective(0, 15, "<f1>Once you reach level 101, you stop gaining EXP by killing bots or players, and you can then cast the remort spell which resets your skills and sets you back to level 1 but as a stronger class with a +.1 skill multiplier.");
	Team::setObjective(0, 16, "<f1>To talk to an NPC, just say 'hello' while standing right next to one.  Their response will have keywords that you can type to trigger different things such as BUY, DEPOSIT, WITHDRAW, etc.");
	Team::setObjective(0, 17, "<f1>It is a good idea to download the UltimaRPGPack Script from the TRPG Homepage.  It utilizes the 'V' chat menu for quicker access to commands and spells.");
	Team::setObjective(0, 18, "<f1>If you ever become lost, just stand still and type '#recall'.  This command will require that you wait 5 minutes for it to work.  Just be patient.");
	Team::setObjective(0, 19, "<f1>If you ever fall off of the map, or through it, use the same '#recall' command.  Before you do, however, disconnect from the server and reconnect so that your character isn't moving in any direction other than down while falling.");
	Team::setObjective(0, 20, "<f1>If your LCK is set to DEATH or if you have 0 LCK, you are able to be killed.  When killed, you automatically drop all of your items in a pack.  If you had at least 1 LCK at the time of death, then your pack will be protected.");
	Team::setObjective(0, 21, "<f1>Only you can pick up or #sharepack one of your protected packs.  If you had 0 LCK at the time of death, your pack will be unprotected and bots or other players could take it.");
	Team::setObjective(0, 22, "<f1>If your LCK is set to MISS, each hit that would normally kill you instead subtracts from your LCK each time you are 'hit'.");
	Team::setObjective(0, 23, "<f1>Pay attention to the skills that each class specializes in.  If you're interested in spell-casting, then you won't have much luck training your spell-casting as a Fighter, because your spellcasting multipliers are too low.");
	Team::setObjective(0, 24, "<f1>You can always find info on items, weapons, spells, and armour with the #w command.  If you wanted to find info on Cheetaurs Paws, just type in '#w cheetaurspaws'.  Notice not to use any spaces in the name of the item/spell.");
	Team::setObjective(0, 26, "<jc><f4>If you ever encounter a bug or glitch of any sort in the game, make sure you can duplicate it and then send an e-mail to matbouchard@home.com with all of the information on the bug and instructions on how to duplicate it.");
	Team::setObjective(0, 27, "<jc><f4>JI will try his best to reward you appropriately depending on how severe the bug/glitch is.");
	Team::setObjective(0, 28, "<jc><f3>This objectives page is brought to you courtesy of Blitz Deg'al");

	for(%i = 1; %i < getNumTeams(); %i++)
	{
		Team::setObjective(%i, 1, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 2, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 3, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 4, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 5, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 6, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 7, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 8, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 9, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 10, "<f7><jc>KILL ALL HUMAN PLAYERS");
		Team::setObjective(%i, 11, "<f7><jc>KILL ALL HUMAN PLAYERS");
	}
}