

//
// AI support functions.
//

//
// This function creates an AI player using the supplied group of markers 
//    for locations.  The first marker in the group gives the starting location 
//    of the the AI, and the remaining markers specify the path to follow.  
//
// Example call:  
// 
//    createAI( guardNumberOne, "MissionGroup\\Teams\\team0\\guardPath", larmor );
//


//globals
//--------
// path type
// 0 = circular
// 1 = oneWay
$AI::defaultPathType = 2;

$AIattackMode = 1;

//---------------------------------
//createAI()
//---------------------------------
function createAI(%aiName, %markerGroup, %name)
{
	dbecho($dbechoMode, "createAI(" @ %aiName @ ", " @ %markerGroup @ ", " @ %name @ ")");

	%group = nameToID(%markerGroup);
   
	// bugged first if check for first id 2049
	if (%group == -1 || Group::objectCount(%group) == 0) {
	      %spawnPos = %markerGroup;
	      %spawnRot = "0 0 0";
	}
	else
	{
		for (%i = 0; %i < Group::objectCount(%group); %i++) {
			%obj = Group::getObject(%group, %i);
			if(getObjectType(%obj) != "SimGroup")
				break;
		}
	      	%spawnMarker = Group::getObject(%group, %i);
	      	%spawnPos = GameBase::getPosition(%spawnMarker);
	      	%spawnRot = GameBase::getRotation(%spawnMarker);
	}

	%guardtype = clipTrailingNumbers(%aiName);

	if($BotInfo[%aiName, RACE] != "")
		%armor = $RaceToArmorType[$BotInfo[%aiName, RACE]];		//bots in map will get this call
	else
		%armor = $RaceToArmorType[$NameForRace[%guardtype]];		//spawn bots will get this call

	if( AI::spawn( %aiName, %armor, %spawnPos, %spawnRot, %name, "male2" ) != "false" )
	{
		%AiId = AI::getId(%aiName);
		ClearVariables(%AiId);

		//----------------------------------------------------------------------
		SetConnectionId(%AiId);

		//----------------------------------------------------------------------

		storeData(%AiId, "BotInfoAiName", %aiName);

		storeData(%AiId, "RACE", $ArmorTypeToRace[%armor]);

		storeData(%AiId, "LCKconsequence", "miss");
		storeData(%AiId, "RemortStep", 0);
		storeData(%AiId, "HasLoadedAndSpawned", True);
		storeData(%AiId, "tmpbotdata", "");
		storeData(%AiId, "HP", fetchData(%AiId, "MaxHP"));
		storeData(%AiId, "MANA", 1000);

		if(%group != -1)
		{
			%orderNumber = 200;
			for(%i = 0; %i < Group::objectCount(%group); %i++) {
				%spawnMarker = Group::getObject(%group, %i);
				if (getObjectType(%spawnMarker) != "SimGroup") {
					%spawnPos = GameBase::getPosition(%spawnMarker);
					%orderNumber++;
				}
			}
		}

		GameBase::startFadeIn(%AiId);
		PlaySound(SoundSpawn2, %spawnPos);
	}
	else {
      		dbecho(1, "Failure spawning bot:");
		dbecho(1, "%aiName: " @ %aiName);
		dbecho(1, "%armor: " @ %armor);
		dbecho(1, "%guardtype: " @ %guardtype);
		dbecho(1, "%spawnPos: " @ %spawnPos);
		dbecho(1, "%spawnRot: " @ %spawnRot);
		dbecho(1, "%name: " @ %name);
		return -1;
      }
}

//----------------------------------
// AI::setupAI()
//
// Called from Mission::init() which is defined in Objectives.cs (or Dm.cs for
//    deathmatch missions).  
//----------------------------------   
function AI::setupAI(%key, %team)
{
	dbecho($dbechoMode, "AI::setupAI(" @ %key @ ", " @ %team @ ")");

	//if there is no key then they don't exist yet
	if(%key == "")
	{
		%aiFound = 0;
		for( %T = 0; %T < 8; %T++ )
		{
			%groupId = nameToID("MissionGroup\\Teams\\team" @ %T @ "\\AI" );
			if( %groupId != -1 )
			{
				%teamItemCount = Group::objectCount(%groupId);
				if( %teamItemCount > 0 )
				{
					AI::initDrones(%T, %teamItemCount);
					%aiFound += %teamItemCount;
				}
			}
		}
		if( %aiFound == 0 )
			dbecho(1, "No drones exist...");
		else
			dbecho(1, %aiFound @ " drones installed..." );

		$numAi = %aiFound;
	}
	else     //respawning dead AI with original name and path
	{
		%group = nameToID("MissionGroup\\Teams\\team" @ %team @ "\\AI\\" @ %key);
		%num = Group::objectCount(%group);
		createAI(%key, %group, $BotInfo[%key, NAME]);
		%aiId = AI::getId(%key);

		GameBase::setTeam(%aiId, %team);
		AI::setVar(%key, pathType, $AI::defaultPathType);
		AI::setWeapons(%key);

		//**RPG (added because AI::onDroneKilled doesn't conserve the AI's team)
		storeData(%AiId, "botTeam", %team);
		//**
	}		
}

function ai::impulse(%id)
{

	%rx = floor(getRandom() * 5 + 5);
	%r = floor(getRandom() * 2);
	if (%r)
		%do = %rx @ " ";
	else
		%do = "-" @ %rx @ " ";
	%ry = floor(getRandom() * 5 + 5);
	%r = floor(getRandom() * 2);
	if (%r)
		%do = %do @ %ry @ " ";
	else
		%do = %do @ "-" @ %ry @ " ";
	%do = %do @ floor(getRandom() * 4 + 3);
	Item::setvelocity(%id,%do);
}

function ai::jump(%id)
{
	%r = GameBase::GetRotation(%id);
	%impulse = Vector::getFromRot(Vector::add(%r, "0 0 1.57079"), 1);
	echo("IMPULSE " @ %impulse);
	%impulse[1] = getWord(%impulse,0);
	%impulse[2] = getWord(%impulse,1);
	%impulse[3] = getWord(%impulse,2);
	%new = %impulse[1] + 10 @ " " @ %impulse[2] + 10 @ " " @ %impulse[3] + 10;
	player::applyimpulse(%id,%new);
	echo(%impulse);
}

//==================================================================================================

function AI::setWeapons(%aiName, %loadout)
{
	%aiId = AI::getId(%aiName);
	Game::refreshClientScore(%aiId);
	//================================================================================================
	// DEFAULT AI TABLES
	$HateList[%aiId] = "";
	$TargetCur[%aiId,0] = "";
	$TargetTemp[%aiId,0] = "";
	$TargetList[%aiId,0] = "";
	$TargetLast[%aiId,0] = "";
	$TargetCur[%aiId,1] = "";
	$TargetTemp[%aiId,1] = "";
	$TargetList[%aiId,1] = "";
	$TargetLast[%aiId,1] = "";
	$Stunned[%aiId] = 0;
	$Rooted[%aiId] = 0;
	$Calmed[%aiId] = 0;
	//================================================================================================
	// ai::callbackPeriodic(%aiName, 2, AI::Periodic);
}

function AI::AreaAgg(%id)
{
	Targeting::Obtain(%id,30,True,0);
	%cur = $TargetCur[%id,0];
	%list = $TargetList[%id,0];
	%targets = $TargetTemp[%id,0];
	for (%i = 0; (%t = getWord(%targets,%i)) != -1; %i++) {
		
		AI::AddHate(%id,%t,1);
	}
}

function AI::AddHate(%id,%target,%hate)
{
	%list = $HateList[%id];
	if (%list == "") {
		$HateList[%id] = %target @ " " @ %hate;
		return;
	}
	%new = "";
	%found = 0;
	for (%i = 0; (%cl = getWord(%list,%i)) != -1; %i+=2) {
		%h = getWord(%list,%i+1);
		if (%cl == %target) {
			%add = %h + %hate;
			if (%add <= 0) 
				%add = 0;
			%new = %new @ %cl @ " " @ %add @ " ";
			%found = 1;
		}
		else
			%new = %new @ %cl @ " " @ %h @ " ";
	}
	if (%found == 0)
		%new = %new @ %target @ " " @ %h @ " ";
	$HateList[%id] = %new;
}

function AI::WipeHate(%id,%target)
{
	%list = $HateList[%id];
	if (%list == "")
		return;
	%new = "";
	for (%i = 0; (%cl = getWord(%list,%i)) != -1; %i+=2) {
		%h = getWord(%list,%i+1);
		if (%cl != %target)
			%new = %new @ %cl @ " " @ %h @ " ";
	}
	$HateList[%id] = %new;
}

function AI::MostWanted(%id)
{
	%list = $HateList[%id];
	if (%list == "")
		return 0;
	%top = 0;
	%topid = 0;
	for (%i = 0; (%cl = getWord(%list,%i)) != -1; %i+=2) {
		%h = getWord(%list,%i+1);
		if (%h >= %top) {
			%top = %h;
			%topid = %cl;
		}
	}
	return %topid;
}

function AI::LOS(%aiid,%id,%t)
{
	if ($TARGETINGAREA[%aiId] != $TARGETINGAREA[%id])
		return True;
	%a = GameBase::getPosition(%aiid);
 	%b = GameBase::getPosition(%id);
	%c = getWord(%a,0) @ " " @ getWord(%a,1) @ " " @ (getWord(%a,2) + 1.359);
	%d = getWord(%b,0) @ " " @ getWord(%b,1) @ " " @ (getWord(%b,2) + 1.359);
	%test = getlosinfo(%c,%d,%t);
	return %test;
}

function AI::BodyBlock(%aiId,%id)
{
	
	%test = getlosinfo(GameBase::GetPosition(%aiid),GameBase::GetPosition(%wanted),16);
	echo($los::object);
}

function AI::BlockedHeal(%aiId)
{
	$AiBlocked[%aiId]++;
	if ($AiBlocked[%aiId] >= 3) {
		$AiBlocked[%aiId] = 3;
		%val = round(fetchData(%aiId,"MaxHP") * 0.3);
		refreshHP(%aiId, ((%val / 100) * -1));
		$MonsterMagic[%aiId] = round($MonsterMagic[%aiId] * 0.1);
		$MonsterGold[%aiId] = round($MonsterGold[%aiId] * 0.1);
	}
}

function AI::NoTargetHeal(%aiId)
{
	%val = round(fetchData(%aiId,"MaxHP") * 1.0);
	refreshHP(%aiId, ((%val / 100) * -1));
	$MonsterMagic[%aiId] = 0;
	$MonsterGold[%aiId] = 0;
}

function AI::Periodic(%aiName)
{
	//echo(" AI PERIODIC " @ %aiName);
	%aiId = AI::getId(%aiName);
	if(fetchData(%aiId, "dumbAIflag") || fetchData(%aiId, "frozen"))
		return;
	%aiTeam = GameBase::getTeam(%aiId);
	%aiPos = GameBase::getPosition(%aiId);
	%pos = %aiPos;
	%spawnpos = $AISpawnPos[%aiId];
	if (Vector::getDistance(%aiPos,%spawnpos) > 100) {
		KillStrayAi(%aiId);
		return;
	}	
	%pos = gameBase::GetPosition(%aiId);
	//================================================================================================
	// AREA AGG
	if ($Calmed[%aiId] != 1)
		AI::AreaAgg(%aiId);
	//================================================================================================
	// DETERMINE HATE
	%wanted = AI::MostWanted(%aiId);
	if (%wanted != 0) { 
		$TargetCur[%aiid,0] = %wanted;
		// CHECK FOR LOS
		//if (AI::BodyBlock(%aiId,%wanted) == True)
		//	AI::BlockedHeal(%aiId);
		if (AI::LOS(%aiid,%wanted,1) == True) {
			AI::BlockedHeal(%aiId);
		}
		else {
			$AiBlocked[%aiId] = 0;
		}
	}
	else {
		AI::NoTargetHeal(%aiId);
		player::trigger(%aiId,0,0);
	}
	//================================================================================================
	// STATUS UPDATE
	//*************************************************************
	// MAP STATUS
	if ((%mapb = GetMapBonus(%aiId,"NOP")) != -1) $STATUSPOISON[%aiId] = 0;
	if ((%mapb = GetMapBonus(%aiId,"NOC")) != -1) $STATUSCOLD[%aiId] = 0;
	//*************************************************************
	if ($STATUSCOLD[%aiId] > 0) {
		CruSpellBomb(%aiId,%pos,"AIL_CHILL");
		$STATUSCOLD[%aiId]--;
	}
	if ($STATUSMELEE[%aiId] > 0)
		$STATUSMELEE[%aiId]--;
	if ($STATUSFIRE[%aiId] > 0)
		$STATUSFIRE[%aiId]--;
	if ($STATUSPROJ[%aiId] > 0)
		$STATUSPROJ[%aiId]--;
	if ($BLEEDING[%aiId] > 0) {
		schedule("CruSpellBomb("@%aiId@",\""@%pos@"\",\"AIL_BLEED\");",0.1);
		%init = $BLEEDINIT[%aiId];
		%value = round($BLEEDHIT[%aiId] / 5);
		if (gamebase::isAtRest(%aiId) == False)
			%value *= 2.0;
		if (%value < 1) %value = 1;
		Player::ManualDamage(%init,%aiId,%value,False,True,"Melee",True);
		$BLEEDING[%aiId]--;
	}
	if ($STATUSFIRE[%aiId] > 0)
		$STATUSFIRE[%aiId]--;
	if ($IGNITED[%aiId] > 0) {
		schedule("CruSpellBomb("@%aiId@",\""@%pos@"\",\"ANIM_IGNITE\");",0.2);
		%init = $IGNITEINIT[%aiId];
		%value = round($IGNITEHIT[%aiId] / 5);
		if (%value < 1) %value = 1;
		Player::ManualDamage(%init,%aiid,%value,False,True,"Fire",True);
		$IGNITED[%aiId]--;
	}
	if ($STATUSENERGY[%aiId] > 0) {
		schedule("CruSpellBomb("@%aiId@",\""@%pos@"\",\"AIL_SHOCK\");",0.3);
		$STATUSENERGY[%aiId]--;
	}
	if ($STATUSFIRE[%aiId] < 0) $STATUSFIRE[%aiId] = 0;
	if ($STATUSCOLD[%aiId] < 0) $STATUSCOLD[%aiId] = 0;
	if ($STATUSMELEE[%aiId] < 0) $STATUSMELEE[%aiId] = 0;
	if ($STATUSPROJ[%aiId] < 0) $STATUSPROJ[%aiId] = 0;
	if ($STATUSPOISON[%aiId] < 0) $STATUSPOISON[%aiId] = 0;
	if ($STATUSENERGY[%aiId] < 0) $STATUSENERGY[%aiId] = 0;
	//================================================================================================
	$AIEMPTYCHECK[%aiId]++;
	if ($AIEMPTYCHECK[%aiId] >= 20) {
		AiEmptyZoneCheck(%aiId);
		$AIEMPTYCHECK[%aiId] = 0;
	}
	//================================================================================================
	// DETERMINE ACTION
	%cur = $TargetCur[%aiId,0];
	if ($TargetCur[%aiId,0] == "") {
		AI::DirectiveWaypoint(%aiName,%pos,99);
		player::trigger(%aiId,0,0);
		return;
	}
	if ($InCombat[%aiId] > 0) $InCombat[%aiId]--;
	//================================================================================================
	%aiPos = GameBase::getPosition(%aiId);
	%pos = GameBase::GetPosition(%cur);
	%dist = Vector::GetDistance(%aiPos,%pos);
	if (%dist > 100 || IsDead(%cur))
		AI::WipeHate(%aiId,%cur);
	//================================================================================================
	else {
		if ($Stunned[%aiId] == 1 || $Rooted[%aiId] == 1 || $Calmed[%aiId] == 1) {
			// ROOTED CALMED STUNNED, DO NOT MOVE
			return;
		}
		else {
			if ($TargetLast[%aiId,0] != %cur)
				Client::SendMessage(%cur,1,"Attacked by " @ Client::GetName(%aiId) @ "!");
			$TargetLast[%aiId,0] = $TargetCur[%aiId,0];
			%mage = $MAGE[%aiId,TYPE];
			%ranged = $RANGED[%aiId];
			if (%mage == "" && %ranged == "") {
				%pos = GameBase::GetPosition(%cur);
				if (GetBonus(%aiId,$BPTELEPORTER) == 1) {
					if (RandBetween(1,5) == 1)
						Gamebase::SetPosition(%aiId,%pos);
					else
						AI::DirectiveWaypoint(%aiName,%pos,99);
				}
				else
					AI::DirectiveWaypoint(%aiName,%pos,99);
				player::trigger(%aiId,0,1);
				if (RandBetween(1,7) == 1)
					ai::impulse(%aiId);
			}
			else {
				%aiPos = GameBase::getPosition(%aiId);
				%pos = GameBase::GetPosition(%cur);
				%dist = Vector::GetDistance(%aiPos,%pos);
				%magedist = getWord(%mage,0);
				if (%mage != "") { %maxdist = $MAGEDISTANCEMAX[%magedist]; %mindist = $MAGEDISTANCEMIN[%magedist]; }
				if (%ranged != "") { %maxdist = 30; %mindist = 10; }
				if (%dist > %maxdist)
					AI::DirectiveWaypoint(%aiName,%pos,99);
				else if (%dist < %mindist && RandBetween(1,3) == 1) {
					if (GetBonus(%aiId,$BPTELEPORTER) == 1) {
						if (RandBetween(1,5) == 1)
							AI::Teleport(%aiId);
						else
							AI::DirectiveWaypoint(%aiName,GetRandomMageMovement(%aiPos),99);	
					}
					else
						AI::DirectiveWaypoint(%aiName,GetRandomMageMovement(%aiPos),99);
				}
				else
					if (GetBonus(%aiId,$BPTELEPORTER) == 1) {
						if (RandBetween(1,5) == 1)
							AI::Teleport(%aiId);
						else
							AI::DirectiveWaypoint(%aiName,%AiPos,99);	
					}
					else
						AI::DirectiveWaypoint(%aiName,%AiPos,99);
				if ($PlayerRecoverCS[%aiId] == "" && %mage != "") {
					%lvl = fetchData(%aiId,"LVL");
					%spell = Ai::SelectSpell(%mage,%lvl);
					if (%spell != "")
						StartCastCruSpell(%aiId,%spell);
				}
				%weapon = $PlayerWear[%aiId,13];
				if ($BPItem[%weapon,$BPIsMagWeapon] == 1)
					player::trigger(%aiId,0,0);
				else
					player::trigger(%aiId,0,1);
			}
		}
	}
}

function AiEmptyZoneCheck(%aiId)
{
	//echo(" AIEMPTYZONECHECK " @ %aiId);
	%check = $CRUSPAWNZONE[%aiId];
	%inzone = false;
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
		%zone = fetchData(%cl,"zone");
		if (%check == %zone) {
			if ($TARGETINGAREA[%cl] == $TARGETINGAREA[%aiId])
				%inzone = true;
		}
	}
	if (%inzone == false)
		KillStrayAI(%aiId);
}

function GetRandomMageMovement(%aiPos,%max)
{
	if (%max == "") %max = 10;
	%x = getWord(%aiPos,0);
	%y = getWord(%aiPos,1);
	%z = getWord(%aiPos,2);
	if (RandBetween(0,1) == 0) %x += RandBetween(5,%max);
	else %x -= RandBetween(5,%max);
	if (RandBetween(0,1) == 0) %y += RandBetween(5,%max);
	else %y -= RandBetween(5,%max);
	return %x @ " " @ %y @ " " @ %z; 
}

//==================================================================================================

function AI::NextWeapon(%aiId)
{
	return False;
}

function AI::SelectBestWeapon(%aiId)
{
	return False;
}

function AI::SetSpotDist(%aiId)
{
	return False;
}

function AI::activelyFollow(%aiName, %curTarget, %bypass)
{
	return False;
}

function AI::moveToAttackMarker(%name, %method)
{
	return False;
}

function AI::moveSomewhere(%aiName)
{
	return False;
}


function AI::moveToFurthest(%aiName)
{
	return False;
}

//==================================================================================================

function AI::initDrones(%team, %numAi)
{
	dbecho($dbechoMode, "AI::initDrones(" @ %team @ ", " @ %numAi @ ")");

	dbecho(1, "spawning team " @ %team @ " ai...");

	for(%guard = 0; %guard < %numAi; %guard++)
	{
		//check for internal data
		%tempSet = nameToID("MissionGroup\\Teams\\team" @ %team @ "\\AI");
		%tempItem = Group::getObject(%tempSet, %guard);
		%aiName = Object::getName(%tempItem);

		%set = nameToID("MissionGroup\\Teams\\team" @ %team @ "\\AI\\" @ %aiName);
		%numPts = Group::objectCount(%set);

		if(%numPts > 0)
		{
			GatherBotInfo(%set);

			createAI(%aiName, %set, $BotInfo[%aiName, NAME]);
			%aiId = AI::getId( %aiName );
			AI::setVar( %aiName, iq,  100 );
			AI::setVar( %aiName, attackMode, $AIattackMode);
			AI::setVar( %aiName, pathType, $AI::defaultPathType);
			AI::setWeapons(%aiName);

			UpdateTeam(%aiId);

			//**RPG (added because AI::onDroneKilled doesn't conserve the AI's team)
			storeData(%aiId, "botTeam", %team);
			//**
		}
		else
			dbecho(1, "no info to spawn ai...");
	}
}


//==================================================================================================

$numAI = 0;

function AI::helper(%aiName, %displayName, %commandIssuer, %loadout)
{
	dbecho($dbechoMode, "AI::helper(" @ %aiName @ ", " @ %displayName @ ", " @ %commandIssuer @ ")");

	if(GetWord(%commandIssuer, 0) == "TempSpawn")
	{
		//the %commandIssuer is a data string
		%spawnPos = GetWord(%commandIssuer, 1) @ " " @ GetWord(%commandIssuer, 2) @ " " @ GetWord(%commandIssuer, 3);
	}
	else if(GetWord(%commandIssuer, 0) == "MarkerSpawn")
	{
		//the %commandIssuer is a marker
		%spawnPos = GameBase::getPosition(GetWord(%commandIssuer, 1));
	}
	else if(GetWord(%commandIssuer, 0) == "SpawnPoint")
	{
		//the %commandIssuer is a Spawn Point
		//we must now figure out a position around this Spawn Point

		%spawnpoint = GetWord(%commandIssuer, 1);

		%info = Object::getName(%spawnpoint);

		%minrad = GetWord(%info, 1);
		%maxrad = GetWord(%info, 2);

		%spawnPointPos = GameBase::getPosition(%spawnpoint);
		%tempPos = RandomPositionXY(%minrad, %maxrad);
		%xPos = GetWord(%tempPos, 0) + GetWord(%spawnPointPos, 0);
		%yPos = GetWord(%tempPos, 1) + GetWord(%spawnPointPos, 1);
		%zPos = GetWord(%spawnPointPos, 2);

		%spawnPos = %xPos @ " " @ %yPos @ " " @ %zPos;
	}

	%n = getAInumber();

	%newName = %aiName @ %n;
	if(%aiName == %displayName)
		%displayName = $NameForRace[%aiName] @ %newName;
	$numAI++;
	SpawnAI(%newName, %displayName, %spawnPos, %commandIssuer, %loadout);

	setAInumber(%newName, %n);

	return %newName;
}

function SpawnAI(%newName, %displayName, %aiSpawnPos, %commandIssuer, %loadout)
{
	dbecho($dbechoMode, "SpawnAI(" @ %newName @ ", " @ %displayName @ ", " @ %aiSpawnPos @ ", " @ %commandIssuer @ ")");

	%retval = createAI(%newName, %aiSpawnPos, %displayName);

	if(%retval != -1)
	{
		%aiId = AI::getId( %newName );
		AI::setVar( %newName,  iq,  100 );
		// AI::setVar( %newName,  attackMode, $AIattackMode);
		// AI::setVar( %newName,  pathType, $AI::defaultPathType);
		// AI::SetVar( %newName,  seekOff, 1);
		// AI::setAutomaticTargets( %newName );

		if(GetWord(%commandIssuer, 0) == "TempSpawn")
		{
			//the %commandIssuer is a data string
			storeData(%aiId, "SpawnBotInfo", %commandIssuer);
			%team = GetWord(%commandIssuer, 4);
			GameBase::setTeam(%aiId, %team);

			AI::SetVar(%newName, spotDist, $AIspotDist);
		}
		else if(GetWord(%commandIssuer, 0) == "MarkerSpawn")
		{
			//the %commandIssuer is a marker
			storeData(%aiId, "SpawnBotInfo", %commandIssuer);
			%team = GameBase::getMapName(GetWord(%commandIssuer, 1));
			if(%team == "") %team = 0;
			GameBase::setTeam(%aiId, %team);

			AI::SetVar(%newName, spotDist, $AIspotDist);
		}
		else if(GetWord(%commandIssuer, 0) == "SpawnPoint")
		{
			//the %commandIssuer is a spawn crystal
			storeData(%aiId, "SpawnBotInfo", %commandIssuer);

			$numAIperSpawnPoint[GetWord(%commandIssuer, 1)]++;
			UpdateTeam(%aiId);

			AI::SetVar(%newName, spotDist, $AIspotDist);
		}

		AI::setWeapons(%newName, %loadout);

		return ( %newName );
	}
	else
	{
		return -1;
	}
}

function AI::moveToLOS(%aiName, %commandIssuer) 
{
	return False;
}

function AI::moveAhead(%aiName, %commandIssuer, %distance) 
{
	return False;
}  


function AI::onCommand ( %name, %commander, %command, %waypoint, %targetId, %cmdText, %cmdStatus, %cmdSequence)
{
	dbecho($dbechoMode, "AI::onCommand(" @ %name @ ", " @ %commander @ ", " @ %command @ ", " @ %waypoint @ ", " @ %targetId @ ", " @ %cmdText @ ", " @ %cmdStatus @ ", " @ %cmdSequence @ ")");

	%aiId = AI::getId( %name );
	%T = GameBase::getTeam( %aiId );
	%groupId = nameToID("MissionGroup\\Teams\\team" @ %T @ "\\AI\\" @ %name ); 
	%nodeCount = Group::objectCount( %groupId );
	dbecho(2, "checking drone information...." @ " number of nodes: " @ %nodeCount);
	dbecho(2, "AI id: " @ %aiId @ " groupId: " @ %groupId);
   
	if($SinglePlayer) // || %nodeCount == 1
	{
		if( %command == 2 || %command == 1 )
		{
			// must convert waypoint location into world location.  waypoint location
			//    is given in range [0-1023, 0-1023].  
			%worldLoc = WaypointToWorld ( %waypoint );
			AI::newDirectiveWaypoint( %name, %worldLoc, 99 );
			dbecho ( 2, %name @ " IS PROCEEDING TO LOCATION " @ %worldLoc );
		}
		dbecho( 2, "AI::OnCommand() issued to  " @ %name @ "  with parameters: " );
		dbecho( 3, "Cmdr:        " @ %commander );
		dbecho( 3, "Command:     " @ %command );
		dbecho( 3, "Waypoint:    " @ %waypoint );
		dbecho( 3, "TargetId:    " @ %targetId );
		dbecho( 3, "cmdText:     " @ %cmdText );
		dbecho( 3, "cmdStatus:   " @ %cmdStatus );
		dbecho( 3, "cmdSequence: " @ %cmdSequence );
	}
	else
		return;   
}

// Play the given wave file FROM %source to %DEST.  The wave name is JUST the basic wave
// name without voice base info (which it will grab for you from the source clientId).
// Basically does some string fiddling for you.
//
// Example:
//    Ai::soundHelper( 2051, 2049, cheer3 );
//
function Ai::soundHelper( %sourceId, %destId, %waveFileName )
{
	dbecho($dbechoMode, "Ai::soundHelper(" @ %sourceId @ ", " @ %destId @ ", " @ %waveFileName @ ")");

	%wName = strcat( "~w", Client::getVoiceBase( %sourceId ) );
	%wName = strcat( %wName, ".w" );
	%wName = strcat( %wName, %waveFileName );
	%wName = strcat( %wName, ".wav" );

	dbecho( 2, "Trying to play " @ %wName );

	Client::sendMessage( %destId, 0, %wName );
}


// Default periodic callback.  [Note by default it isn't called unless a frequency 
//    is set up using AI::CallbackPeriodic().  Type in that command to see how 
//    it works].  
function AI::onPeriodic( %aiName )
{
	dbecho($dbechoMode, "AI::onPeriodic(" @ %aiName @ ")");

	echo("onPeriodic() called with " @ %aiName);
}


function AI::onDroneKilled(%aiName)
{
	dbecho($dbechoMode, "AI::onDroneKilled(" @ %aiName @ ")");

	if(!$SinglePlayer )
	{
	      %aiId = AI::getId(%aiName);

      	%team = fetchData(%aiId, "botTeam");
		storeData(%aiId, "botTeam", "");
		$aiNumTable[$tmpbotn[%aiName]] = "";
		$tmpbotn[%aiName] = "";

		if(fetchData(%aiId, "SpawnBotInfo") != "")
		{
			if(GetWord(fetchData(%aiId, "SpawnBotInfo"), 0) == "SpawnPoint")
			{
				//this bot originally spawned from a crystal
				$numAIperSpawnPoint[GetWord(fetchData(%aiId, "SpawnBotInfo"), 1)]--;
			}
			storeData(%aiId, "SpawnBotInfo", "");
			storeData(%aiId, "AIattackMarker", "");

			//pet stuff
			$PetList = RemoveFromCommaList($PetList, %aiId);
			%petowner = fetchData(%aiId, "petowner");
			storeData(%petowner, "PersonalPetList", RemoveFromCommaList(fetchData(%petowner, "PersonalPetList"), %aiId));
			Client::sendMessage(%petowner, $MsgRed, Client::getName(%aiId) @ " was slain!");
			storeData(%aiId, "petowner", "");
			
			//botgroup stuff
			%b = AI::IsInWhichBotGroup(%aiId);
			if(%b != -1)
				AI::RemoveBotFromBotGroup(%aiId, %b);
		}
		//else
		//{
		//	//Confirmed this was causing the "Syntax error"
		//	//This wasn't supposed to be used in rpg mod, but since your SpawnBotInfo is missing it was being called
		//	//And since your team was blank, it was getting a blank 2nd parameter, which is invalid
		//	//pecho("AI::setupAI(" @ %aiName @ ", " @ %team @ ")");
		//	schedule("AI::setupAI(" @ %aiName @ ", " @ %team @ ");", 60);
		//}
	}
	else
	{
		// just in case:
		dbecho( 2, "Non training callback called from Training" );
	}
}

//These will only be invoked if the target is REALLY close to the bot (since the SpotDist is only the range of the
//weapon).  This means that if the bot ever gets close enough to engage in battle, he will try his best to continue
//the fight by following the target.  Once the target is lost or dies, directive 99 will be cancelled and directive
//99 will take over (regular walking, formations etc)
function AI::onTargetLOSAcquired(%aiName, %idNum)
{
	dbecho($dbechoMode, "AI::onTargetLOSAcquired(" @ %aiName @ ", " @ %idNum @ ")");

	%aiId = AI::getId(%aiName);

	if(fetchData(%aiId, "SpawnBotInfo") != "" && !fetchData(%aiId, "dumbAIflag"))
		AI::newDirectiveFollow(%aiName, %idNum, 0, 99);
}

function AI::onTargetLOSLost(%aiName, %idNum)
{
	dbecho($dbechoMode, "AI::onTargetLOSLost(" @ %aiName @ ", " @ %idNum @ ")");

	%aiId = AI::getId(%aiName);

	if(fetchData(%aiId, "SpawnBotInfo") != "" && !fetchData(%aiId, "dumbAIflag"))
		AI::newDirectiveRemove(%aiName, 99);
}

function AI::onTargetLOSRegained(%aiName, %idNum)
{
	dbecho($dbechoMode, "AI::onTargetLOSRegained(" @ %aiName @ ", " @ %idNum @ ")");

	%aiId = AI::getId(%aiName);

	if(fetchData(%aiId, "SpawnBotInfo") != "" && !fetchData(%aiId, "dumbAIflag"))
		AI::newDirectiveFollow(%aiName, %idNum, 0, 99);
}

function AI::onTargetDied(%aiName, %idNum)
{
	dbecho($dbechoMode, "AI::onTargetDied(" @ %aiName @ ", " @ %idNum @ ")");

	%aiId = AI::getId(%aiName);

	if(fetchData(%aiId, "SpawnBotInfo") != "" && !fetchData(%aiId, "dumbAIflag"))
		AI::newDirectiveRemove(%aiName, 99);
}                                 

function AI::sayLater(%clientId, %guardId, %message, %look)
{
	dbecho($dbechoMode, "AI::sayLater(" @ %clientId @ ", " @ %guardId @ ", " @ %message @ ", " @ %look @ ")");

	%name = Client::getName(%clientId);

	Client::sendMessage(%clientId, $MsgBeige, $BotInfo[%guardId.name, NAME] @ " tells you, \"" @ %message @ "\"");

//	if(%look)
//		AI::lookAtPlayer(%clientId, %guardId);
}
function AI::lookAtPlayer(%clientId, %guardId)
{
	dbecho($dbechoMode, "AI::lookAtPlayer(" @ %clientId @ ", " @ %guardId @ ")");

	%clpos = GameBase::getPosition(%clientId);
	%gupos = GameBase::getPosition(%guardId);

	%v1 = Vector::sub(%clpos, %gupos);

	%norm = Vector::normalize(%v1);
	%rot = Vector::getRotation(%norm);

	GameBase::setRotation(%guardId, %rot);

	%gurot = GameBase::getRotation(%guardId);
	%temp = Vector::sub(%rot, %gurot);
	%temp2 = GetWord(%temp, 2);

	if(floor(%temp2) != 0)
		%rot = GetWord(%rot, 0) @ " " @ GetWord(%rot, 1) @ " " @ (GetWord(%rot, 2) + 3.141592654);

	GameBase::setRotation(%townbot, %rot);

	//RotateTownBot(%guardId, %rot);
}

function getAInumber()
{
	dbecho($dbechoMode, "getAInumber()");

	for(%i = 0; %i <= 5000; %i++)
	{
		if($aiNumTable[%i] == "")
		{
			return %i;
		}
	}
}
function setAInumber(%aiName, %n)
{
	dbecho($dbechoMode, "setAInumber(" @ %aiName @ ", " @ %n @ ")");

	$aiNumTable[%n] = True;
	$tmpbotn[%aiName] = %n;
}

//=================================================
function AI::SelectMovement(%aiName)
{
	dbecho($dbechoMode, "AI::SelectMovement(" @ %aiName @ ")");

	%aiId = AI::getId(%aiName);

	if(fetchData(%aiId, "botAttackMode") == 1)
	{
		//Regular walk

		if(IsInArenaDueler(%aiId) || IsInRoster(%aiId))
			%r = OddsAre(1);
		else
			%r = OddsAre($AImoveChance);
		
		if(%r && !fetchData(%aiId, "frozen"))
		{
			%s = RandomRaceSound(fetchData(%aiId, "RACE"), RandomWait);
			if(%s == "NoSound")
				PlaySound(SoundGrunt1, GameBase::getPosition(%aiId));
			else
				PlaySound(%s, GameBase::getPosition(%aiId));
			AI::moveToFurthest(%aiName);
		}
	}
	else if(fetchData(%aiId, "botAttackMode") == 2)
	{
		//Follow a specific player target

		%followId = fetchData(%aiId, "tmpbotdata");
		if(%followId != %aiId)
			AI::newDirectiveFollow(%aiName, %followId, 0, 99);
	}
	else if(fetchData(%aiId, "botAttackMode") == 3)
	{
		//Attack at certain position
		AI::newDirectiveWaypoint(%aiName, fetchData(%aiId, "tmpbotdata"), 99);
	}
	else if(fetchData(%aiId, "botAttackMode") == 4)
	{
		//BotGroup formation

		%a = AI::IsInWhichBotGroup(%aiId);
		%g = $tmpBotGroup[%a];

		//NOTE: can't make the bots follow a random bot in the group because at one point or another,
		//the bots will pick a follow combination which will NOT involve the team leader, leaving the
		//team leader alone.
		//This new method involves a North East oriented line.

		for(%i = 1; (%b = GetWord(%g, %i)) != -1; %i++)
		{
			if(%b == %aiId)
				%n = %i-1;
		}

		%followId = GetWord(%g, %n);

		if(!fetchData(%aiId, "frozen"))
		{
			if(%followId != %aiId)
				AI::newDirectiveFollow(%aiName, %followId, 0, 99);
			else
				AI::moveToFurthest(%aiName);					//team leader gets to move.
		}

	}
}

function HardcodeAIskills(%aiId)
{
	return False;
}

//------ BotGroup stuff ---------------------------------

function AI::IsInWhichBotGroup(%aiId)
{
	dbecho($dbechoMode, "AI::IsInWhichBotGroup(" @ %aiId @ ")");

	for(%i = 0; (%a = GetWord($BotGroups, %i)) != -1; %i++)
	{
		for(%j = 0; (%b = GetWord($tmpBotGroup[%a], %j)) != -1; %j++)
		{
			if(%b == %aiId)
				return %a;
		}
	}
	return -1;
}

function AI::CreateBotGroup(%group)
{
	dbecho($dbechoMode, "AI::CreateBotGroup(" @ %group @ ")");

	$BotGroups = $BotGroups @ %group @ " ";
	$tmpBotGroup[%group] = "";
}

function AI::DiscardBotGroup(%group)
{
	dbecho($dbechoMode, "AI::DiscardBotGroup(" @ %group @ ")");

	for(%i = 0; (%a = GetWord($tmpBotGroup[%group], %i)) != -1; %i++)
		storeData(%a, "botAttackMode", 1);

	$BotGroups = FixStuffString($BotGroups);
	$BotGroups = String::replace($BotGroups, " " @ %group @ " ", " ");
	$tmpBotGroup[%group] = "";
}

function AI::CountBotGroupMembers(%group)
{
	dbecho($dbechoMode, "AI::CountBotGroupMembers(" @ %group @ ")");

	for(%i = 0; (%a = GetWord($tmpBotGroup[%group], %i)) != -1; %i++){}
	return %i;
}

function AI::IsInBotGroup(%aiId, %group)
{
	dbecho($dbechoMode, "AI::IsInBotGroup(" @ %aiId @ ", " @ %group @ ")");

	for(%i = 0; (%a = GetWord($tmpBotGroup[%group], %i)) != -1; %i++)
	{
		if(%aiId == %a)
			return True;
	}
	return False;
}

function AI::BotGroupExists(%group)
{
	dbecho($dbechoMode, "AI::BotGroupExists(" @ %group @ ")");

	for(%i = 0; (%a = GetWord($BotGroups, %i)) != -1; %i++)
	{
		if(%a == %group)
			return True;
	}
	return False;
}

function AI::RemoveBotFromBotGroup(%aiId, %group)
{
	dbecho($dbechoMode, "AI::RemoveBotFromGroup(" @ %aiId @ ", " @ %group @ ")");

	$tmpBotGroup[%group] = String::Replace($tmpBotGroup[%group], %aiId @ " ", "");
	storeData(%aiId, "botAttackMode", 1);
}

function AI::AddBotToBotGroup(%aiId, %group)
{
	dbecho($dbechoMode, "AI::AddBotToBotGroup(" @ %aiId @ ", " @ %group @ ")");

	$tmpBotGroup[%group] = $tmpBotGroup[%group] @ %aiId @ " ";
	storeData(%aiId, "botAttackMode", 4);
}

//------ remastered directives ------------------------------

function AI::newDirectiveFollow(%aiName, %idNum, %rad, %directive)
{
	dbecho($dbechoMode, "AI::newDirectiveFollow(" @ %aiName @ ", " @ %idNum @ ", " @ %rad @ ", " @ %directive @ ")");

	%aiId = AI::getId(%aiName);
	AI::newDirectiveRemove(%aiName, %directive);

	$aidirectiveTable[%aiId, %directive] = "follow";
	AI::directiveFollow(%aiName, %idNum, %rad, %directive);
}

function AI::newDirectiveWaypoint(%aiName, %pos, %directive)
{
	dbecho($dbechoMode, "AI::newDirectiveWaypoint(" @ %aiName @ ", " @ %pos @ ", " @ %directive @ ")");

	%aiId = AI::getId(%aiName);
	AI::newDirectiveRemove(%aiName, %directive);

	$aidirectiveTable[%aiId, %directive] = "waypoint";
	AI::directiveWaypoint(%aiName, %pos, %directive);
}

function AI::newDirectiveRemove(%aiName, %directive)
{
	dbecho($dbechoMode, "AI::newDirectiveRemove(" @ %aiName @ ", " @ %directive @ ")");

	%aiId = AI::getId(%aiName);
	if($aidirectiveTable[%aiId, %directive] != "")
	{
		AI::directiveRemove(%aiName, %directive);
		$aidirectiveTable[%aiId, %directive] = "";
	}
}

//------- TownBot stuff ----------------------------------------

//Toggle::SetSkin();

function TestTownBots()
{
	return false;
}

function InitTownBots()
{
	InitNPC();

	dbecho($dbechoMode, "InitTownBots()");

	$TownBotList = "";

	%group = nameToId("MissionGroup/TownBots");

	if(%group != -1)
	{
		%cnt = Group::objectCount(%group);
		for(%i = 0; %i <= %cnt - 1; %i++)
		{
			%object = Group::getObject(%group, %i);
			%name = Object::getName(%object);
			if(getObjectType(%object) == "SimGroup")
			{
				%marker = GatherBotInfo(%object);
			}
		
			echo(" TOWNBOT " @ %townbot);
		
			%townbot = newObject("", "Item", $BotInfo[%name, RACE] @ "TownBot", 1, false);

			addToSet("MissionCleanup", %townbot);
			GameBase::setMapName(%townbot, $BotInfo[%name, NAME]);
			%goblin = 0;
			if ($BotInfo[%name, NAME] == "Stray Alien") {
				ECHO(" >>>>>>>>>>>>DUDE GOBLIN ARMOR " @ %townbot);
				%townbotclient = Player::GetClient(%townbot);
				Player::SetArmor(%townbotclient,GoblinArmor);
				Client::SetSkin(%townbotclient,goblin);
				%goblin = 1;
			}
			GameBase::setPosition(%townbot, GameBase::getPosition(%marker));
			GameBase::setRotation(%townbot, GameBase::getRotation(%marker));
			GameBase::setTeam(%townbot, $BotInfo[%name, TEAM]);
			if (!%goblin)
				GameBase::playSequence(%townbot, 0, "root");	//thanks Adger!!
			%townbot.name = %name;

			$TownBotList = $TownBotList @ %townbot @ " ";
		}
	}
}
function RotateTownBot(%id, %rot)
{
	dbecho($dbechoMode, "RotateTownBot(" @ %id @ ", " @ %rot @ ")");

	%pos = GameBase::getPosition(%id);
	%name = %id.name;

	//delete the bot
	$TownBotList = String::replace($TownBotList, %id @ " ", "");
	deleteObject(%id);

	//re-create the bot
	%townbot = newObject("", "Item", $BotInfo[%name, RACE] @ "TownBot", 1, false);
	GameBase::setRotation(%townbot, %rot);

	addToSet("MissionCleanup", %townbot);
	GameBase::setMapName(%townbot, $BotInfo[%name, NAME]);
	GameBase::setPosition(%townbot, %pos);
	GameBase::setTeam(%townbot, $BotInfo[%name, TEAM]);
	GameBase::playSequence(%townbot, 0, "root");	//thanks Adger!!
	%townbot.name = %name;

	$TownBotList = $TownBotList @ %townbot @ " ";
}

function GatherBotInfo(%group)
{
	dbecho($dbechoMode, "GatherBotInfo(" @ %group @ ")");

	%biggestn = 0;
	%aiName = Object::getName(%group);

	%count = Group::objectCount(%group);
	for(%i = 0; %i <= %count-1; %i++)
	{
		%object = Group::getObject(%group, %i);
		if (getObjectType(%object) == "SimGroup")
		{
			// CRU CUSTOM QUEST
			if (string::FindSubStr(%aiName,"cru") != -1) {
				%system = Object::GetName(%object);
				%t = getWord(%system,0);
				%v = getWord(%system,1);
				if (%t == "NAME")
					$BotInfo[%aiName, NAME] = String::GetSubStr(%system,5,9999);
				else if (%t == "LVL")
					$BotInfo[%aiName, LVL] = String::GetSubStr(%system,4,9999);
				else if (%t == "RACE")
					$BotInfo[%aiName, RACE] = String::GetSubStr(%system,5,9999);
				else {
					%len = string::len(%t) + string::len(%v);
					%len += 2;
					$BotInfo[%aiName,%t,%v] = String::GetSubStr(%system,%len,9999);
				}
			}
			// END CRU CUSTOM QUEST

			else {
				%system = Object::getName(%object);
				%type = GetWord(%system, 0);
				%info = String::getSubStr(%system, String::len(%type)+1, 9999);

				%type2 = clipTrailingNumbers(%type);
				%n = floor(String::getSubStr(%type, String::len(%type2), 9999));

				if(%type == "NAME")
					$BotInfo[%aiName, NAME] = %info;
				else if(%type == "LVL" || %type == "LEVEL")
					$BotInfo[%aiName, LVL] = %info;
				else if(%type == "RACE")
					$BotInfo[%aiName, RACE] = %info;
				else if(%type == "NEED")
					$BotInfo[%aiName, NEED] = %info;
				else if(%type == "TAKE")
					$BotInfo[%aiName, TAKE] = %info;
				else if(%type == "GIVE")
					$BotInfo[%aiName, GIVE] = %info;
				else if(%type == "SHOP")
					$BotInfo[%aiName, SHOP] = %info;
				else if(%type == "ITEMS")
					$BotInfo[%aiName, ITEMS] = %info;
				else if(%type == "CSAY")
					$BotInfo[%aiName, CSAY] = %info;
				else if(%type == "LSAY")
					$BotInfo[%aiName, LSAY] = %info;
				else if(%type == "LCK")
					$BotInfo[%aiName, LCK] = %info;
				else if(%type == "SIMGROUP")
					$BotInfo[%aiName, SIMGROUP] = %info;
				
				if(%type2 == "SAY")
					$BotInfo[%aiName, SAY, %n] = %info;
				else if(%type2 == "CUE")
					$BotInfo[%aiName, CUE, %n] = %info;
				else if(%type2 == "NSAY")
					$BotInfo[%aiName, NSAY, %n] = %info;
				else if(%type2 == "NCUE")
					$BotInfo[%aiName, NCUE, %n] = %info;

				if(%n > %biggestn)
					%biggestn = %n;
			}	
		}
		else
			%marker = %object;
	}
	$BotInfo[%aiName, SAY, %biggestn+1] = "";
	$BotInfo[%aiName, NSAY, %biggestn+1] = "";
	$BotInfo[%aiName, CUE, %biggestn+1] = "";
	$BotInfo[%aiName, NCUE, %biggestn+1] = "";

	//==============================================
	//The following is generally BotMaker-only code
	//==============================================
	if($BotInfo[%aiName, SIMGROUP] != "")
	{
		%g = nameToId("MissionGroup\\" @ $BotInfo[%aiName, SIMGROUP]);

		%count = Group::objectCount(%g);
		for(%i = 0; %i <= %count-1; %i++)
		{
			%object = Group::getObject(%g, %i);
			if(getObjectType(%object) == "SimGroup")
			{
				%system = Object::getName(%object);
				%type = GetWord(%system, 0);
				%info = String::getSubStr(%system, String::len(%type)+1, 9999);

				if(%type == "NAMES")
					$BotInfo[%aiName, NAMES] = %info;
				else if(%type == "DEFAULTS")
				{
					%class = GetWord(%info, 0);
					%stuff = String::getSubStr(%info, String::len(%class)+1, 9999);

					$BotInfo[%aiName, DEFAULTS, %class] = %stuff;
				}
			}
			else if(getObjectType(%object) == "Marker")
			{
				$BotInfo[%aiName, DESTSPAWN] = %object;
			}
		}
	}
	//==============================================

	return %marker;
}

function RPG::isAiControlled(%clientId)
{
	dbecho($dbechoMode, "RPG::isAiControlled(" @ %clientId @ ")");

	if(fetchData(%clientId, "BotInfoAiName") != "" || fetchData(%clientId, "SpawnBotInfo") != "")
		return True;
	else
		return False;
}

//These are for the pets
function Pet::BeforeTurnEvil(%clientId)
{
	dbecho($dbechoMode, "Pet::BeforeTurnEvil(" @ %clientId @ ")");

	remoteSay(%clientId, 0, "#say I'm starting to get enough of this...");
}
function Pet::TurnEvil(%clientId)
{
	dbecho($dbechoMode, "Pet::TurnEvil(" @ %clientId @ ")");

	remoteSay(%clientId, 0, "#shout To hell with you all! Die!");

	storeData(%aiId, "botAttackMode", 1);
	AI::newDirectiveRemove(fetchData(%clientId, "BotInfoAiName"), 99);
	storeData(%aiId, "tmpbotdata", "");

	GameBase::setTeam(%clientId, 1);
}

exec(backpack_ai);
exec(backpack_minion);