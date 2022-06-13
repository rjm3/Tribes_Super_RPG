// SPAWN SYSTEM

$CZType			= 1;
$CZDungeon		= 2;
$CZProtected	= 3;
$CZSpawn		= 4;
$CZNum			= 5;
$CZActive		= 6;
$CZMobs			= 7;
$CZPosition		= 8;
$CZLvls			= 9;
$CZMulti		= 10;
$CZZoneLoot		= 11;
$CZZoneLootElite= 12;
$CZZoneLootBoss	= 13;
$CZMapActive	= 14;
$CZMapMobs		= 15;
$CZMapSpawnPos	= 16;
$CZMapStart		= 17;
$CZMapLvl		= 18;
$CZMapWaves		= 19;
$CZMap			= 20;
$CZMapOwner		= 21;
$CZMapMods		= 22;
$CZMapMagic		= 23;
$CZPlayerMods	= 24;
$CZMonsterMods	= 25;
$CZAreaMods		= 26;
$CZXY			= 27;
$CZMaxSpawns	= 28;
$CZAllowUpperLoot	= 29;
$CZMobLoot		= 30;
$CZEliteLoot	= 31;
$CZBoosLoot		= 32;
$CZTargetingArea 	= 33;

$CEMobs		= 1;
$CELoadout	= 2;
$CERace		= 3;
$CEArmor	= 4;
$CESkin		= 5;
$CEWeapon	= 6;
$CENameOn	= 7;
$CESkin		= 8;
$CEMonsterType	= 9;
$CEMage		= 10;
$CEElite	= 11;
$CEBoss		= 12;
$CERanged	= 13;
$CELoot		= 14;
$CELootElite	= 15;
$CELootBoss	= 16;
$CERaceSub	= 17;
$CEUpperLoot = 18;

$CEEliteMods	= 0;
$CEBossMods	= 2;

$WorldLoot[FOREST] = "ForestKeyFragment 100 999";

function CZ::Loop()
{
	%s = 0;
	$CZSPAWNLIST = "";
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
		schedule("CZ::DetermineSpawn("@%cl@");",%s);
		%s = %s + 0.1;
	}
	%s = %s + 0.1;
	schedule("CZ::DoSpawnList();",%s);
}

function CZ::DetermineSpawn(%id)
{
	//echo(" CZ::DETERMINSPAWN " @ %id);
	%zone = fetchData(%id,"zone");
	if ($CRUZONE[%zone,$CZType] == $CZDungeon) {
		%pos = Gamebase::GetPosition(%id);
		%closest = 50000;
		%dospawn = -1;
		for (%i = 1; (%mobs = $CRUZONE[%zone,$CZSpawn,%i,$CZMobs]) != ""; %i++) {
			%spawnpos = $CRUZONE[%zone,$CZSpawn,%i,$CZPosition];
			%dist = Vector::getDistance(%pos,%spawnpos);
			if (%dist <= %closest && %dist <= 5000) {
				%dospawn = %i;
				%closest = %dist;
			}
		}
		if (%dospawn != -1)
			CZ::IncSpawnList(%zone,%dospawn);
	}
	if ($CRUZONE[%zone,$CZType] == $CZMap) {
		%waves = $CRUZONE[%zone,$CZMapWaves];
		if (%waves > 0) {
			if ($CRUZONE[%zone,$CZSpawn,0,$CZActive] == 0)
				CZ::IncSpawnList(%zone,0);
		}
	}
}

function CZ::IncSpawnList(%zone,%n)
{
	%spawn = $CZSPAWNLIST;
	if (%spawn == "") {
		$CZSPAWNLIST = %zone @ " " @ %n @ " 1 ";
		return;
	}
	%list = "";
	%found = 0;
	for (%i = 0; (%z = getWord(%spawn,%i)) != -1; %i+=3) {
		%x = getWord(%spawn,%i+1);
		%y = getWord(%spawn,%i+2);
		if (%z == %zone && %x == %n) {
			%list = %list @ %z @ " " @ %x @ " " @ (%y + 1) @ " ";
			%found = 1;
		}
		else {
			%list = %list @ %z @ " " @ %x @ " " @ %y @ " ";
		}
	}
	if (!%found) {
		%list = %list @ %zone @ " " @ %n @ " 1 ";
	}
	$CZSPAWNLIST = %list;
}

function CZ::DoSpawnList()
{
	//echo(" CZ::DOSPAWNLIST ");
	%s = 0;
	%spawn = $CZSPAWNLIST;
	//echo(" CZSPAWNLIST " @ $CZSPAWNLIST);
	if (%spawn == "") return;
	for (%i = 0; (%z = getWord(%spawn,%i)) != -1; %i+=3) {
		%x = getWord(%spawn,%i+1);
		%y = getWord(%spawn,%i+2);
		//schedule("echo(\"cz::setupspawn? "@%z@"/"@%x@"/"@%y@"\");",%s);
		//okay this doesn't seem to be the source of the error, although it seems like it's always going around the same time as the error
		schedule("CZ::SetupSpawn(\"" @ %z @ "\"," @ %x @ "," @ %y @ ");",%s);
		%s = %s + 0.1;
	}
}

function CZ::SetupSpawn(%zone,%dospawn,%num)
{
	//echo(" CZ::SETUPSPAWN ZONE:" @ %zone @ " DOSPAWN:" @ %dospawn @ " NUM:" @ %num);
	%active = $CRUZONE[%zone,$CZSpawn,%dospawn,$CZActive];
	%s = 0;
	%need = CZ::GetSpawnCount(%num,%zone,%dospawn);
	//*************************************************************
	// MAP DOUBLE MONSTER
	if ((%mapb = GetMapBonus(%zone,"DBM")) != -1) %need *= 2;
	//*************************************************************
	//*************************************************************
	// MAP DOUBLE FINAL BOSS
	if ((%mapb = GetMapBonus(%zone,"TUB")) != -1) {
		%waves = $CRUZONE[%zone,$CZMapWaves];
		if (%waves == 1)
			%need *= 2;
	}
	//*************************************************************		
	%remain = %need - %active;
	if (%remain > 0) {
		for (%i = 1; %i <= %remain; %i++) {
			//schedule("echo(\"CZ::Spawn(\"" @ %zone @ "\"," @ %dospawn @ ")\");",%s);//Also not the source
			schedule("CZ::Spawn(\"" @ %zone @ "\"," @ %dospawn @ ");",%s);
			%s = %s + 0.1;
		}
	}
}

$CheckSpawnCount[1] = 1;
$CheckSpawnCount[2] = 1;
$CheckSpawnCount[3] = 2;
$CheckSpawnCount[4] = 2;
$CheckSpawnCount[5] = 3;
$CheckSpawnCount[6] = 3;
$CheckSpawnCount[7] = 4;
$CheckSpawnCount[8] = 4;
$CheckSpawnCount[9] = 5;
$CheckSpawnCount[10] = 5;
$CheckSpawnCount[11] = 6;
$CheckSpawnCount[12] = 6;
$CheckSpawnCount[13] = 7;
$CheckSpawnCount[14] = 7;
$CheckSpawnCount[15] = 8;
$CheckSpawnCount[16] = 8;
$CheckSpawnCount[17] = 9;
$CheckSpawnCount[18] = 9;

function CZ::GetSpawnCount(%n,%zone,%dospawn)
{
	%max = $CRUZONE[%zone,$CZSpawn,%dospawn,$CZMaxSpawns];
	if (%max == "")
		%max = 6;
	
	if ($CRUZONE[%zone,$CZType] == $CZMap)
		return 6;
	else
		return MTRB(1,%max);

	// PLAYER COUNT REMOVED
	//if (%n >= 18)
	//	return 10;
	//else 
	//	return $CheckSpawnCount[%n];
}

function CZ::Spawn(%zone,%dospawn)
{
	//echo(" CZ::SPAWN ZONE:" @ %zone @ " DOSPAWN:" @ %dospawn);
	if ($CRUZONE[%zone,$CZType] == $CZMap)
		%lvl = $CRUZONE[%zone,$CZMapLvl];
	else {
		%lvl = $CRUZONE[%zone,$CZSpawn,%dospawn,$CZLvls];
		%lvl = RandBetween(getWord(%lvl,0),getWord(%lvl,1));
	}
	%crop = $CRUZONE[%zone,$CZSpawn,%dospawn,$CZMobs];
	for (%x = 0; (%m = getWord(%crop,%x)) != -1; %x++)
		%mob[%x] = %m;
	%select = floor(getRandom() * %x);
	%select = %mob[%select];
	CZ::RandomMob(%zone,%dospawn,%select,%lvl);
}

function CZ::GetMonsterWeapon(%wtype,%lvl)
{
	if (%wtype == "SLASHING") return TierItem::RandomItem("EnemySword",%lvl);
	else if (%wtype == "PIERCING") return TierItem::RandomItem("EnemyKnife",%lvl);
	else if (%wtype == "SORCERY") return TierItem::RandomItem("EnemyStaff",%lvl);
	else if (%wtype == "DARKMAGIC") return TierItem::RandomItem("EnemyWand",%lvl);
	else if (%wtype == "ARCHERY") return TierItem::RandomItem("EnemyCrossbow",%lvl);
	else if (%wtype == "BLUDGEONING") return TierItem::RandomItem("EnemyMace",%lvl);
 	else return TierItem::RandomItem(%wtype,%lvl);
}

function CZ::GetMonsterExLoot(%loot)
{
	//echo(" CZ::GETMONSTEREXLOOT " @ %loot);
	if (%loot == "") return;
	%newloot = "";
	for (%i = 0; (%l = getWord(%loot,%i)) != -1; %i+=3) {
		%r = getWord(%loot,%i+1);
		%q = getWord(%loot,%i+2);
		if (MTRB(1,%r) == 1)
			%newloot = %newloot @ %l @ " " @ %q @ " ";
	}
	return %newloot;
}

function CZ::CreateMonsterExLoot(%loot,%lvl)
{
	//echo("###############################################################################");
	//echo(" CZ::CREATEMONSTEREXLOOT--------------------------------> " @ %loot @ " " @ %lvl);
	%new = "";
	for (%i = 0; (%l = getWord(%loot,%i)) != -1; %i+=2) {
		%q = getWord(%loot,%i+1);
		if (%q == "999") {
			%item = "999" @ %l;
			%new = %new @ %item @ " 1 ";
			if ($BPItem[%item,$BPName] == "")
				DynamicItem::InitWear(%item);
		}
		if (%q == "TL") {
			%flux = %lvl * 0.1;
			%min = Cap((%lvl - %flux),1,300);
			%max = Cap((%lvl + %flux),1,300);
			%r = RandBetween(%min,%max);
			%item = TierItem::RandomItem(%l,%r);
			%new = %new @ %item @ " 1 ";
		}
	}
	return %new;
	//echo("###############################################################################");
}

function CZ::RandomMob(%zone,%spawn,%mob,%lvl)
{
	//echo(" CZ::RANDOMMOB " @ %zone @ " " @ %spawn @ " " @ %mob @ " " @ %lvl);
	%mobtypes = $CRUMONSTER[%mob,$CEMobs];
	for (%x = 0; (%m = getWord(%mobtypes,%x)) != -1; %x++)
		%mob[%x] = %m;
	%select = floor(getRandom() * %x);
	%select = %mob[%select];
	%select = %mob @ %select;
	//========================================================================
	if ($CRUZONE[%zone,$CZType] == $CZMap)
		%ismap = True;
	else
		%ismap = False;
	%mapwaves = $CRUZONE[%zone,$CZMapWaves];
	//========================================================================
	// ELITE & BOSS
	%elitespawn = 4;
	%bossspawn = 4;
	//*************************************************************
	// MAP ELITES BOSSES
	if ((%mapb = GetMapBonus(%zone,"MEM")) != -1) %elitespawn = 2;
	if ((%mapb = GetMapBonus(%zone,"MBM")) != -1) %bossspawn = 2;
	//*************************************************************	
	if (MTRB(1,%elitespawn) == 1) {
		%elite = True;
		if (MTRB(1,%bossspawn) == 1) {
			%elite = False;
			%boss = True;
		}
	}
	else {
		%elite = False;
		%boss = False;
	}
	if (%ismap && %mapwaves == 1) {
		%elite = False;
		%boss = True;
	}
	//========================================================================
	%race = $CRUMONSTER[%mob,$CERace];
	%armor = $CRUMONSTER[%mob,$CEArmor];
	%skin = $CRUMONSTER[%mob,$CESkin];
	%racesub = $CRUMONSTER[%mob,$CERaceSub];
	if (%ismap) {
		%zx = MTRB(1,4);
		%spawnPos = $CRUZONE[%zone,$CZMapSpawnPos,%zx];
	}
	else
		%spawnPos = $CRUZONE[%zone,$CZSpawn,%spawn,$CZPosition];
	%x = getWord(%spawnPos,0);
	%y = getWord(%spawnPos,1);
	%z = getWord(%spawnPos,2);
	//===================================================
	// NEW POSITION
	%czxy = $CRUZONE[%zone,$CZSpawn,%spawn,$CZXY];
	if ($CRUZONE[%zone,$CZType] == $CZMap)
		%czxy = 1.5;
	if (%czxy != "") {
		%movex = getWord(%czxy,0);
		%movey = getWord(%czxy,1);
	}
	else {
		%movex = 3;
		%movey = 3;
	}
	if (MTRB(0,1) == 1)
		%x += getRandom() * %movex;
	else
		%x -= getRandom() * %movex;
	if (MTRB(0,1) == 1)
		%y += getRandom() * %movey;
	else
		%y -= getRandom() * %movey;
	%spawnPos = %x @ " " @ %y @ " " @ %z;
	%spawnRot = "0 0 0";
	//===================================================
	if (%elite) {
		%armor = GetWord($CRUMONSTER[%select,$CEElite],1);
		%skin = GetWord($CRUMONSTER[%select,$CEElite],2);
		%selectname = GetWord($CRUMONSTER[%select,$CEElite],0);
		if (%skin == "NA") %skin = "";
	}
	else if (%boss) {
		%armor = GetWord($CRUMONSTER[%select,$CEBoss],1);
		%skin = GetWord($CRUMONSTER[%select,$CEBoss],2);
		%selectname = GetWord($CRUMONSTER[%select,$CEBoss],0);
		if (%skin == "NA") %skin = "";
	}
	else
		%selectname = %select;
	%nameon = $CRUMONSTER[%selectname,$CENameOn];
	if (%nameon == "" || %nameon == 0) %nameon = "";
	%name = %selectname @ %nameon;
	%aiName = %selectname @ %nameon;
	$CRUMONSTER[%selectname,$CENameOn]++;
	//========================================================================
	if (AI::spawn(%aiName,%armor,%spawnPos,%spawnRot,%name,"male2") != "false") {
		%aiId = AI::getId(%aiName);
		$AISpawnPos[%aiId] = %spawnPos;
		setConnectionId(%aiId);
		setLifeId(%aiId);
		//========================================================================
		if ($CRUZONE[%zone,$CZMulti] != "")
			$MONSTERMULTI[%aiId] = $CRUZONE[%zone,$CZMulti];
		else
			$MONSTERMULTI[%aiId] = 1.0;
		//========================================================================
		StoreData(%aiId,"LVL",%lvl);
		StoreData(%aiId,"EXP",0);
		clearallbonuses(%aiId);
		//========================================================================
		%mage = $CRUMONSTER[%select,$CEMage];
		if (%mage != "") $MAGE[%aiId,TYPE] = %mage;
		else $MAGE[%aiId,TYPE] = "";
		//========================================================================
		%ranged = $CRUMONSTER[%select,$CERanged];
		if (%ranged == "") $RANGED[%aiId] = "";
		else $RANGED[%aiId] = 1;
		//========================================================================
		// MONSTER MODS
		$MM[%aiId] = "";
		$MMDISP[%aiId] = "";
		if (%elite) { 
			$ELITE[%aiId] = 1;
			//if (%ismap)
			//	SelectMM(%aiId,2,%lvl);
			//else
				SelectMM(%aiId,$CEEliteMods,%lvl);
		}
		else {
			$ELITE[%aiId] = 0;
		}
		if (%boss) {
			$BOSS[%aiId] = 1;
			if (%ismap && %mapwaves == 1)
				SelectMM(%aiId,2,%lvl);
			else
				SelectMM(%aiId,$CEBossMods,%lvl);
		}
		else {
			$BOSS[%aiId] = 0;
		}
		//========================================================================
		ClearMapBonus(%aiId);
		AddMapBonus(%aiId,%zone,$MAPMONSTER);
		//========================================================================
		%loadout = $CRUMONSTER[%select,$CELoadout];
		%wtype = getWord(%loadout,0);
		if ($CRUMONSTER[%select,$CEWeapon] != "")
			%wtype = $CRUMONSTER[%select,$CEWeapon];
		%weapon = CZ::GetMonsterWeapon(%wtype,%lvl);
		$PlayerWear[%aiId,13] = %weapon;
		%string = %weapon @ " 1 " @ $CRUMONSTER[%select,$CELoadout];
		BackpackMonsterBonus(%aiId,%string);
		//========================================================================
		$MONSTEREXLOOT[%aiId] = "";
		// MOB TYPE LOOT ----------------------------------------------------
		if ((%loot = $CRUMONSTER[%select,$CELoot]) != "" && !%elite && !%boss)
			$MONSTEREXLOOT[%aiId] = CZ::GetMonsterExLoot(%loot);
		if (%elite) {
			if ((%loot = $CRUMONSTER[%select,$CELootElite]) != "")
				$MONSTEREXLOOT[%aiId] = CZ::GetMonsterExLoot(%loot);
		}
		if (%boss) {
			if ((%loot = $CRUMONSTER[%select,$CELootBoss]) != "")
				$MONSTEREXLOOT[%aiId] = CZ::GetMonsterExLoot(%loot);
		}
		// MOB SPAWN LOOT ----------------------------------------------------
		//echo("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
		//echo("MOB LOOT " @ $CRUZONE[%zone,$CZSpawn,%spawn,$CZMobLoot]);
		//echo("ELITE LOOT " @ $CRUZONE[%zone,$CZSpawn,%spawn,$CZEliteLoot]);
		//echo("BOSS LOOT " @ $CRUZONE[%zone,$CZSpawn,%spawn,$CZBossLoot]);
		if ((%loot = $CRUZONE[%zone,$CZSpawn,%spawn,$CZMobLoot]) != "" && !%elite && !%boss)
			$MONSTEREXLOOT[%aiId] = $MONSTEREXLOOT[%aiId] @ CZ::GetMonsterExLoot(%loot);
		if (%elite) {
			if ((%loot = $CRUZONE[%zone,$CZSpawn,%spawn,$CZEliteLoot]) != "")
				$MONSTEREXLOOT[%aiId] = $MONSTEREXLOOT[%aiId] @ CZ::GetMonsterExLoot(%loot);
		}
		if (%boss) {
			if ((%loot = $CRUZONE[%zone,$CZSpawn,%spawn,$CZBossLoot]) != "")
				$MONSTEREXLOOT[%aiId] = $MONSTEREXLOOT[%aiId] @ CZ::GetMonsterExLoot(%loot);
		}
		//echo("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
		// MOB ZONE LOOT ----------------------------------------------------
		if ((%loot = $CRUZONE[%zone,$CZZoneLoot]) != "" && !%elite && !%boss)
			$MONSTEREXLOOT[%aiId] = $MONSTEREXLOOT[%aiId] @ CZ::GetMonsterExLoot(%loot);
		if (%elite) {
			if ((%loot = $CRUZONE[%zone,$CZZoneLootElite]) != "")
				$MONSTEREXLOOT[%aiId] = $MONSTEREXLOOT[%aiId] @ CZ::GetMonsterExLoot(%loot);
		}
		if (%boss) {
			if ((%loot = $CRUZONE[%zone,$CZZoneLootBoss]) != "")
				$MONSTEREXLOOT[%aiId] = $MONSTEREXLOOT[%aiId] @ CZ::GetMonsterExLoot(%loot);
		}
		//========================================================================
		if ($CRUZONE[%zone,$CZAllowUpperLoot] == 1)
			$UPPERLOOT[%aiId] = 1;
		else
			$UPPERLOOT[%aiId] = 0;
		//========================================================================
		// TARGETING AREA
		if ((%tarea = $CRUZONE[%zone,$CZSpawn,%spawn,$CZTargetingArea]) != "") {
			//echo("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ SETTING TARGETING AREA " @ %tarea);
			$TARGETINGAREA[%aiId] = %tarea;
		}
		else
			$TARGETINGAREA[%aiId] = 0;
		//========================================================================
		storeData(%AiId, "RACE", %mob);
		storeData(%AiId, "CruRACE", %race);
		storeData(%AiId, "CLASS", "Monster");
		storeData(%AiId, "RACESUB", %racesub);
		storeData(%AiId, "ALVL", 0);
		//========================================================================
		AI::setVar(%aiName, iq, 1000 );
		GameBase::startFadeIn(%AiId);
		PlaySound(SoundSpawn2, %spawnPos);
		//========================================================================
		$HateList[%aiId] 	= "";
		$TargetCur[%aiId,0] 	= "";
		$TargetTemp[%aiId,0] 	= "";
		$TargetList[%aiId,0] 	= "";
		$TargetLast[%aiId,0] 	= "";
		$TargetCur[%aiId,1] 	= "";
		$TargetTemp[%aiId,1] 	= "";
		$TargetList[%aiId,1] 	= "";
		$TargetLast[%aiId,1] 	= "";
		$Stunned[%aiId] = 0;
		$Rooted[%aiId] 	= 0;
		$Calmed[%aiId] 	= 0;
		$MonsterMagic[%aiId] = 0;
		$MonsterGold[%aiId] = 0;
		$STATUSCOLD[%aiId] = 0;
		$STATUSMELEE[%aiId] = 0;
		$STATUSPROJ[%aiId] = 0;
		$STATUSENERGY[%aiId] = 0;
		$STATUSPOISON[%aiId] = 0;
		$POISONINIT[%aiId] = "";
		$POISONHIT[%aiId] = "";
		$BLEEDING[%aiId] = 0;
		$BLEEDHIT[%aiId] = "";
		$BLEEDINIT[%aiId] = "";
		$STATUSFIRE[%aiId] = 0;
		$IGNITED[%aiId] = 0;
		$IGNITEHIT[%aiId] = 0;
		$Snared[%aiId] = 0;
		$PlayerRecoverCS[%aiId] = "";
		$AIISDEAD[%aiId] = 0;
		if (%elite) $ELITE[%aiId] = 1;
		else $ELITE[%aiId] = 0;
		if (%boss) $BOSS[%aiId] = 1;
		else $BOSS[%aiId] = 0;
		$InCombat[%aiId] = 0;
		ClearDamagedByList(%aiId);
		$AIEMPTYCHECK[%aiId] = 0;
		$AIISEMPTY[%aiId] = 0;
		$NOLOOT[%aiId] = 0;
		//========================================================================
		$CRUSPAWNZONE[%aiId] = %zone;
		$CRUSPAWNID[%aiId] = %spawn;
		$CRUZONE[%zone,$CZSpawn,%spawn,$CZActive]++;
		$CRUMONSTERNAME[%aiId] = %selectname;
		//========================================================================
		if (%skin != "")
			Client::SetSkin(%aiId,%skin);
		//========================================================================
		RefreshATK(%aiId);
		ai::callbackPeriodic(%aiName, 1, AI::Periodic);
		//GameBase::SetTeam(%aiId,1);
		Game::refreshClientScore(%aiId);
	}
	else
		echo("CZ::RANDOMMOB AI::SPAWN ERROR");
	//========================================================================
}

$CRUMONSTERREGSTAT["SLASHING"] 		= 1;
$CRUMONSTERREGSTAT["PIERCING"] 		= 1;
$CRUMONSTERREGSTAT["ENDURANCE"] 	= 1;
$CRUMONSTERREGSTAT["EVADEMELEE"] 	= 1;
$CRUMONSTERREGSTAT["DODGING"] 		= 1;
$CRUMONSTERREGSTAT["BACKSTABBING"] 	= 1;
$CRUMONSTERREGSTAT["CLEAVE"] 		= 1;
$CRUMONSTERREGSTAT["HEALING"] 		= 1;
$CRUMONSTERREGSTAT["SORCERY"] 		= 1;
$CRUMONSTERREGSTAT["DARKMAGIC"] 	= 1;
$CRUMONSTERREGSTAT["PRIMALMAGIC"] 	= 1;
$CRUMONSTERREGSTAT["WISDOM"] 		= 1;
$CRUMONSTERREGSTAT["CASTINIT"] 		= 1;
$CRUMONSTERREGSTAT["SPELLCAPACITY"] 	= 1;
$CRUMONSTERREGSTAT["WEAPONHANDLING"] 	= 1;
$CRUMONSTERREGSTAT["SPELLRESISTANCE"] 	= 1;

function CZ::Max(%id,%stat,%lvl,%v)
{
	if (%v == "") %v = 1.0;
	//echo(" CZ::max " @ %id @ " " @ %stat @ " " @ %lvl @ " " @ %v);
	if ($ELITE[%id]) %v += 0.25;
	if ($BOSS[%id]) %v += 0.5;
	%v *= $MONSTERMULTI[%id];
	if ($BPSkillToNumeric[%stat] != "") return round((3000 * (%lvl / 300)) * %v);
	if (%stat == "ARMOR") return round((15000 * (%lvl / 300)) * %v);
	if (%stat == "EVASION") return round((15000 * (%lvl / 300)) * %v);
	if (%stat == "ALLRESIST") return round((15000 * (%lvl / 300)) * %v);
	if (%stat == "MAXHP") return round((5000 * (%lvl / 300)) * %v);
	if (%stat == "MAGICDAMAGE") return round(150 * %v);
	if (%stat == "PHYSICALDAMAGE") return round(100 * %v);
	if (%stat == "PERCEPTION") return round((3000 * (%lvl / 300)) * %v);
	if (%stat == "PHYSBASE") return round((166 * (%lvl / 300)) * %v);
	if (%stat == "SPELLBASE") return round((166 * (%lvl / 300)) * %v);
	if (%stat == "RANGEDBASE") return round((166 * (%lvl / 300)) * %v);
	if (%stat == "CRITCHANCE") return round(300 * %v);
	if (%stat == "CRITDAMAGE") return round(300 * %v);
	if (%stat == "SPELLCRIT") return round(300 * %v);
	if (%stat == "SPCRITDAMAGE") return round(300 * %v);
	if (%stat == "COOLDOWN") return round(30 * %v);
	if (%stat == "ARMORPEN") return round((15000 * (%lvl / 300)) * %v);
	if (%stat == "MAGICPEN") return round((15000 * (%lvl / 300)) * %v);
}

function CZ::MonsterRandom(%id,%skill,%v)
{	
	// echo(" CZ::MonsterRandom " @ %id @ " " @ %skill @ " " @ %v);
	%lvl = fetchData(%id,"LVL");
	%max = CZ::Max(%id,%skill,%lvl,%v);
	%min = %max * 0.5;
	return RandBetween(%min,%max);
}

function BackpackMonsterBonus(%id,%string)
{
	for (%i = 0; (%item = getWord(%string,%i)) != -1; %i+=2) {
		if ((%vistype = $BPItem[%item,$BPVisType]) != "") {
			if (%vistype == $BPVisItem) {
				%vslot = $BPItem[%item,$BPVisSlot];
				%vis = $BPItem[%item,$BPVis];
				if (%vis != "" && %vslot != "")
					Player::MountItem(%id,%vis,%vslot);
			}
			%wield = $BPItem[%item,$BPWieldBonus];
			if (%wield != "") {
				for (%x = 0; (%b = getWord(%wield,%x)) != -1; %x++) {
					%a = getWord(%wield,%x+1);
					if ((%num = $BPSkillToNumeric[%b]) == "") {
						%num = $BPBonusToNumeric[%b];
						$PlayerBonus[%id,%num] += %a;
					}
					else
						$SkillBonus[%id,%num] += %a;	
				}
			}
		}
		else {
			%v = GetWord(%string,%i+1);
			%a = CZ::MonsterRandom(%id,%item,%v);
			//echo(" CZ::A " @ %a @ " " @ %item @ " " @ %v);
			if ((%num = $BPSkillToNumeric[%item]) == "") {
				%num = $BPBonusToNumeric[%item];
				$PlayerBonus[%id,%num] += %a;
			}
			else
				$SkillBonus[%id,%num] += %a;	
		}
	}
}

// PLUGINS
exec("spawnsystem_zones.cs");
exec("spawnsystem_mobs.cs");





echo("__SPAWN SYSTEM LOADED");