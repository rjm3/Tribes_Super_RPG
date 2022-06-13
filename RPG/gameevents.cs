function Mission::init()
{
	dbecho($dbechoMode, "Mission::init()");

	//if($displayPingAndPL)
	//	setClientScoreHeading("Name\t\x50Zone\t\xBFLVL\t\xDFPing\t\xFFPL");
	//else
	//	setClientScoreHeading("Name\t\x50Zone\t\xB2LVL\t\xD2Class\t\xFFPL");
	//setClientScoreHeading("Name\t\x50Zone\t\xB2LVL\t\xD2Class");
	setClientScoreHeading("Name\t\x50Zone\t\xD2LVL\t\xFFClass");

	if(!$NoSpawn)
		AI::setupAI();

	//schedule("echo(\".--==< RecursiveWorld STARTED >==--.\");RecursiveWorld(1);", 60);

	echo(".--==< RecursiveWorld STARTED >==--.");
	RecursiveWorld(5);
	// RecursiveZone(2);

	$BlockOwnerAdminLevel[Server] = 5;
	for(%i = 1; $ServerQuest[%i] != ""; %i++)
		remoteSay(2048, 0, $ServerQuest[%i], "Server");

	RecursiveStatus();

	
	Treasure::Init();

	schedule("RestockMerchants();",5);
	schedule("RandomTreasure("@$TREASURESHUFFLE@");",10);
}

$TICKER[SPAWN] 		= 0;
$TICKER[MAGICGOLD]	= 0;
$TICKER[RESTOCK] 	= 0;
$TICKER[TREASURE] 	= 0;

function RecursiveStatus()
{
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
		%zone = fetchData(%cl,"zone");
		%z[%zone] = True;
		//========================================================================================================
		// ZONE EXIT
		if ((%ext = $ZoneInfo[%zone,$ZoneExitDist]) != "") {
			//echo(" EXT " @ %ext @ " DIST " @ Vector::getDistance(Gamebase::GetPosition(%cl),$ZoneInfo[%zone,$ZonePos]));
			if (Vector::getDistance(Gamebase::GetPosition(%cl),$ZoneInfo[%zone,$ZonePos]) >= %ext) {
				CruZoneUpdate(%cl,%zone,True,False);
			}
		}
		//========================================================================================================
		// AUTOSAVE
		if ($DOSAVE[%cl]) {
			SaveCharacter(%cl,True);
			$DOSAVE[%cl] = 0;
		}
		//========================================================================================================
		// RES SICKNESS
		if ($RESTIMER[%cl] > 0) {
			$RESTIMER[%cl]--;
			if ($RESTIMER[%cl] == 1)
				Client::SendMessage(%cl,0,"You are fully resurrected.");
		}
		//========================================================================================================
		// NPC CHECK
		if ((%loc = %cl.NPCLocation) != "") {
			if (Vector::getDistance(Gamebase::GetPosition(%cl),%loc) > 10) {
				Client::SendMessage(%cl,0,"You are too far away to continue the conversation.");
				NPCEnd(%cl);
			}
		}
		//========================================================================================================
		// MOVING CHECK
		%vel = Item::GetVelocity(%cl);
		if (getWord(%vel,0) == "0" && getWord(%vel,1) == "0" && getWord(%vel,2) == "0") {
			if ($MoveCheck[%cl] != 0) $MoveCheck[%cl]--;
		}
		else
			$MoveCheck[%cl] = 1;
		//========================================================================================================
		// STATUS UPDATE
		%pos = GameBase::GetPosition(%cl);
		//*************************************************************
		// MAP CHILL
		if ((%mapb = GetMapBonus(%cl,"ALC")) != -1) $STATUSCOLD[%cl] = 5;
		//*************************************************************
		if ($STATUSCOLD[%cl] > 0) {
			CruSpellBomb(%cl,%pos,"AIL_CHILL");
			$STATUSCOLD[%cl]--;
		}
		if ($STATUSMELEE[%cl] > 0)
			$STATUSMELEE[%cl]--;
		if ($STATUSPROJ[%cl] > 0)
			$STATUSPROJ[%cl]--;
		if ($BLEEDING[%cl] > 0) {
			schedule("CruSpellBomb("@%cl@",\""@%pos@"\",\"AIL_BLEED\");",0.1);
			%init = $BLEEDINIT[%cl];
			%value = round($BLEEDHIT[%cl] / 5);
			if (gamebase::isAtRest(%cl) == False)
				%value *= 2.0;
			if (%value < 1) %value = 1;
			Player::ManualDamage(%init,%cl,%value,False,True,"Melee",True);
			$BLEEDING[%cl]--;
		}
		if ($IGNITED[%cl] > 0) {
			schedule("CruSpellBomb("@%cl@",\""@%pos@"\",\"ANIM_IGNITE\");",0.2);
			%init = $IGNITEINIT[%cl];
			%value = round($IGNITEHIT[%cl] / 5);
			if (%value < 1) %value = 1;
			Player::ManualDamage(%init,%cl,%value,False,True,"Fire",True);
			$IGNITED[%cl]--;
		}
		if ($STATUSFIRE[%cl] > 0)
			$STATUSFIRE[%cl]--;
		if ($STATUSENERGY[%cl] > 0) {
			schedule("CruSpellBomb("@%cl@",\""@%pos@"\",\"AIL_SHOCK\");",0.3);
			$STATUSENERGY[%cl]--;
		}
		if ($STATUSCOLD[%cl] < 0) $STATUSCOLD[%cl] = 0;
		if ($STATUSMELEE[%cl] < 0) $STATUSMELEE[%cl] = 0;
		if ($STATUSPROJ[%cl] < 0) $STATUSPROJ[%cl] = 0;
		if ($STATUSPOISON[%cl] < 0) $STATUSPOISON[%cl] = 0;
		if ($STATUSENERGY[%cl] < 0) $STATUSENERGY[%cl] = 0;
		//========================================================================================================
		// COMBAT CHECK
		if ($InCombat[%cl] > 0)
			$InCombat[%cl]--;
		//========================================================================================================
		// HEAL & MANA DELTA
		if (!IsDead(%cl)) {
			$HealDeltaTick[%cl]--;
			$ManaDeltaTick[%cl]--;
			if ($HealDeltaTick[%cl] <= 0) {
				%healskill = GetPlayerSkill(%cl,$SkillEndurance);
				%delta = floor(%healskill / 60);
				%delta += 1;
				%delta += GetBonus(%cl,$BPHEALDELTA);
				%hp = fetchData(%cl,"HP");
				%maxhp = fetchData(%cl,"MaxHP");
				//*************************************************************
				// MAP REGEN
				if ((%mapb = GetMapBonus(%cl,"NHD")) != -1) %delta = 0;
				//*************************************************************
				if ($HealPotion[%cl] > 0) {
					//*************************************************************
					// MAP POTION
					if ((%mapb = GetMapBonus(%cl,"NHP")) != -1) %delta += 0;
					else %delta += Round(%maxhp * 0.05);
					//*************************************************************
					if ((%bonus = GetBonus(%cl,$BPHEALTHPOTION)) > 0) {
						%bonus = %bonus / 100;
						%delta *= (1 + %bonus);
						%delta = round(%delta);
					}
					$HealPotion[%cl]--;
					if ($HealPotion[%cl] == 0)
						$HealDelta[%cl] = 4;
				}
				if (%cl.sleepMode == 2) {
					%delta = round(%delta * 1.3);
					%delta += 1;
				}
				if (%hp < %maxhp && %delta > 0) {
					//Client::SendMessage(%cl,0,"You were healed for " @ %delta @ " points.");
					refreshHP(%cl,((%delta / 100) * -1));
				}
				$HealDeltaTick[%cl] = $HealDelta[%cl];
			}
			if ($ManaDeltaTick[%cl] <= 0) {
				%energy = GetPlayerSkill(%cl,$SkillEnergy);
				%delta = floor(%energy / 30);
				%delta += 1;
				%delta += GetBonus(%cl,$BPMANADELTA);
				%maxmana = fetchData(%cl,"MaxMANA");
				//*************************************************************
				// MAP REGEN
				if ((%mapb = GetMapBonus(%cl,"NMD")) != -1) %delta = 0;
				//*************************************************************
				if ($EnergyVial[%cl] > 0) {
					//*************************************************************
					// MAP POTION
					if ((%mapb = GetMapBonus(%cl,"NMP")) != -1) %delta += 0;
					else %delta += Round(%maxmana * 0.05);
					//*************************************************************
					if ((%bonus = GetBonus(%cl,$BPMANAPOTION)) > 0) {
						%bonus = %bonus / 100;
						%delta *= (1 + %bonus);
						%delta = round(%delta);
					}
					$EnergyVial[%cl]--;
					if ($EnergyVial[%cl] == 0)
						$ManaDelta[%cl] = 4;
				}
				if (%cl.sleepMode == 2) {
					%delta = floor(%delta * 1.6);
					%delta += 1;
				}
				%mana = fetchData(%cl,"MANA");
				if (%mana < %maxmana) {
					refreshMANA(%cl,(%delta * -1));
				}
				$ManaDeltaTick[%cl] = $ManaDelta[%cl];
			}
		}
		//========================================================================================================
		// MUSIC 
		if ($MUSICTICKER[%cl] > 0) $MUSICTICKER[%cl]--;
		if ($MUSICTICKER[%cl] == 0)
			PlayCrucibleMusic(%cl);
		//========================================================================================================
		// LOW LIFE CHECK
		// NEED TO REWRITE THIS INTO DAMAGE ON CHANGE
		//if ((fetchData(%cl,"HP") / fetchData(%cl,"MaxHP")) <= 0.25) {
		//	if (GetBonus(%cl,$BPLOWSTORM) == 1)
		//		StormCloak(%cl);
		//}
		//========================================================================================================
		//*************************************************************
		// MAP PLAGUED
		if ((%mapb = GetMapBonus(%cl,"ALP")) != -1) {
			%maxhp = fetchData(%cl,"MaxHP");
			%value = round(%maxhp * 0.01);
			if (!IsDead(%cl))
				DamageTarget(%cl,%value,%cl);
		}
		//*************************************************************
		//========================================================================================================
		//*************************************************************
		// MAP HELLISH LIGHTNING
		if ((%mapb = GetMapBonus(%cl,"LIG")) != -1) {
			if (MTRB(1,10) == 1) {
				if (!IsDead(%cl)) {
					%maxhp = fetchData(%cl,"MaxHP");
					%value = round(%maxhp * 0.2);
					%pos = gamebase::GetPosition(%cl);
					CruSpellBomb(%cl,%pos,"ANIM_HLIGHTNING");
					DamageTarget(%cl,%value,%cl);
				}
			}
		}
		//*************************************************************
		//========================================================================================================
	}
	//======================================================================================================================================
	$TICKER[SPAWN]++;
	if ($TICKER[SPAWN] >= 30) {
		CZ::Loop();
		$TICKER[SPAWN] = 0;
	}
	$TICKER[MAGICGOLD]++;
	if ($TICKER[MAGICGOLD] >= 70) {
		%s = 0;
		for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
			schedule("UpdateMagicFind("@%cl@",False);",%s);
			schedule("UpdateMagicFind("@%cl@",True);",%s+0.1);
			%s = %s + 0.2;
		}
		$TICKER[MAGICGOLD] = 0;
	}
	//======================================================================================================================================
	$TICKER[RESTOCK]++;
	if ($TICKER[RESTOCK] >= 3600) {
		RestockMerchants();
		$TICKER[RESTOCK] = 0;
	}
	//======================================================================================================================================
	$TICKER[TREASURE]++;
	if ($TICKER[TREASURE] >= 3605) {
		$TICKER[TREASURE] = 0;
		CycleTreasure();
	}
	//======================================================================================================================================
	if ($ACTIVEMAPS > 0) {
		for (%i = 1; %i <= $ACTIVEMAPS; %i++) {
			%active = $CRUMAP[%i];
			%gz = GetWord(%active,3);
			if (%z[%gz] != true)
				$MAPTIMER[%i]--;
			else
				$MAPTIMER[%i] = 120;
			if ($MAPTIMER[%i] <= 0) {
				ClearMap(%i);
			}
		}
	}	
	schedule("RecursiveStatus();",1);
}

function Game::startMatch()
{
	dbecho($dbechoMode, "Game::startMatch()");

	$matchStarted = true;
	$missionStartTime = getSimTime();

	//for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
	//	Game::refreshClientScore(%cl);
}

function Player::enterMissionArea(%player)
{
}

function Player::leaveMissionArea(%player)
{
}

function RecursiveWorld(%seconds)
{
	dbecho($dbechoMode, "RecursiveWorld(" @ %seconds @ ")");
	$ticker[1] = floor($ticker[1]+1);
	$ticker[2] = floor($ticker[2]+1);
	$ticker[3] = floor($ticker[3]+1);
	$ticker[7] = floor($ticker[7]+1);
	if ($ticker[1] >= (($SaveWorldFreq-60) / %seconds) && !$tmpNoticeSaveWorld) {
		messageAll(2, "Notice: SaveWorld will occur in 60 seconds.");
		$tmpNoticeSaveWorld = True;
	}
	if ($ticker[1] >= ($SaveWorldFreq / %seconds)) {
		SaveWorld();
		%list = GetPlayerIdList();
		for(%i = 0; GetWord(%list, %i) != -1; %i++)
		{
			%id = GetWord(%list, %i);

			schedule("ScheduleSave(" @ %id @ ");", %delay += 2, %id);
		}
		$tmpNoticeSaveWorld = "";
		$ticker[1] = 0;
	}
	if ($ticker[2] >= ($ChangeWeatherFreq / %seconds)){
		ChangeWeather();
		$ticker[2] = 0;
	}
	if ($ticker[3] >= 1 && $nightDayCycle) {
		%a = (($initHaze * 2) / $fullCycleTime) * %seconds;
		$currentHaze -= %a;
		if($currentHaze < 0)
			%h = -$currentHaze;
		else
			%h = $currentHaze;
		if($currentHaze < -$initHaze)
			$currentHaze = $initHaze;
		setTerrainVisibility(8, 800, %h);
		for (%i = 1; %i <= 5; %i++) {
			if ($currentHaze >= $dayCycleHaze[%i] && $currentHaze <= $dayCycleHaze[%i-1]) {
				if ($currentSky != $dayCycleSky[%i]) {
					$currentSky = $dayCycleSky[%i];
					ChangeSky($currentSky);
					break;
				}
			}
		}
		$ticker[3] = 0;
	}
	if ($ticker[7] >= (20 / %seconds)) {
		InitSoundPoints();
		$ticker[7] = 0;
	}

	%gst = floor(getsimtime());
		if(%gst == 261085){
			if(canQuickRestart())
				down(0.5, true);
			else
				down(5, true);
			//pecho("Closing server.");
		}
		if(%gst == 220000){//61.1111 hours
			if(canQuickRestart())
				down(0.5, true);
		}
		if(%gst == 180000){//exactly 50 hours
			if(canQuickRestart())
				down(0.5, true);
		}
		if(%gst == 140000){//38.8888 hours
			if(canQuickRestart())
				down(0.5, true);
		}
		if(%gst == 100000){//27.7777 hours
			if(canQuickRestart())
				down(0.5, true);
		}
	schedule("RecursiveWorld(" @ %seconds @ ");", %seconds);
}

function ScheduleSave(%clientId)
{
	if(SaveCharacter(%clientId,True))
		Client::sendMessage(%clientId, $MsgBeige, Client::getName(%clientId) @ " saved.");
}

function TrimIP(%ip)
{
	%a = String::getSubStr(%ip, 3, 99999);
	%p = String::findSubStr(%a, ":");
	%z = String::getSubStr(%a, 0, %p);

	return %z;
}