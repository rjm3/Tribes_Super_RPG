// PASSIVES 0

//===================================================================================================================================================

$PassiveMods 	= 1;
$PassiveNoLvl 	= 2;
$PassiveMax	= 3;
$PassiveType 	= 4;
$PassiveAction	= 5;

$TotalPassives[O] = 0;
$TotalPassives[D] = 0;
$TotalPassives[N] = 0;
$TotalPassives[M] = 0;

$OffPassives = 0;
$DefPassives = 0;
$NeuPassives = 0;
$MagPassives = 0;

$PassiveSave[O] = "OFF ";
$PassiveSave[D] = "DEF ";
$PassiveSave[N] = "NEU ";
$PassiveSave[M] = "MAG ";

//===================================================================================================================================================

function PassiveCreate(%name,%bonus,%nolvl,%num,%type,%action)
{
	//echo(" CREATEPASSIVE -> " @ %name @ " " @ %bonus @ " " @ %nolvl @ " " @ %num @ " " @ %type);
	$Passive[%name,$PassiveMods] = %bonus;
	$Passive[%name,$PassiveNoLvl] = %nolvl;
	$Passive[%name,$PassiveMax] = %num;
	$Passive[%name,$PassiveType] = %type;
	$Passive[%name,$PassiveAction] = %action;
	if (%type == "O") {
		$OffPassives++;
		$PassiveList[O,$OffPassives] = %name;
		$PassiveSave[O] = $PassiveSave[O] @ "0 ";
		$PassiveNum[%name] = $OffPassives;
	}
	if (%type == "D") {
		$DefPassives++;
		$PassiveList[D,$DefPassives] = %name;
		$PassiveSave[D] = $PassiveSave[D] @ "0 ";
		$PassiveNum[%name] = $DefPassives;
	}
	if (%type == "N") {
		$NeuPassives++;
		$PassiveList[N,$NeuPassives] = %name;
		$PassiveSave[N] = $PassiveSave[N] @ "0 ";
		$PassiveNum[%name] = $NeuPassives;
	}
	if (%type == "M") {
		$MagPassives++;
		$PassiveList[M,$MagPassives] = %name;
		$PassiveSave[M] = $PassiveSave[M] @ "0 ";
		$PassiveNum[%name] = $MagPassives;
	}
}

function fetchPassiveData(%passive,%data)
{
	if (%data == "max") return $Passive[%passive,$PassiveMax];
	if (%data == "mods") return $Passive[%passive,$PassiveMods];
	if (%data == "nolvl") return $Passive[%passive,$PassiveNoLvl];
	if (%data == "type") return $Passive[%passive,$PassiveType];
	if (%data == "num") return $PassiveNum[%passive];
	if (%data == "action") return $Passive[%passive,$PassiveAction];
}

function LoadAllPassives(%id)
{
	echo(" LOADING ALL PASSIVES " @ %clientId);
	LoadPlayerPassives(%id,"O");
	LoadPlayerPassives(%id,"D");
	LoadPlayerPassives(%id,"N");
	LoadPlayerPassives(%id,"M");
	UpdatePassives(%id);
}

function UpdatePassives(%id)
{
	echo(" UPDATE PASSIVES: " @ %id);
	if ($PassiveTemp[%id] != "") {
		%list = $PassiveTemp[%id];
		for (%i = 0; (%b = getWord(%list,%i)) != -1; %i += 2) {
			%a = getWord(%list,(%i+1));
			%num = $BPBonusToNumeric[%b];
			if ((%skill = $BPSkillToNumeric[%b]) == "") $PlayerBonus[%id,%num] -= %a;
			else  $SkillBonus[%id,%skill] -= %a;
		}
	}
	if ($PassiveTempNoLvl[%id] != "") {
		%list = $PassiveTempNoLvl[%id];
		for (%i = 0; (%b = getWord(%list,%i)) != -1; %i += 2) {
			%a = getWord(%list,(%i+1));
			%num = $BPBonusToNumeric[%b];
			if ((%skill = $BPSkillToNumeric[%b]) == "") $PlayerBonus[%id,%num] -= %a;
			else $SkillBonus[%id,%skill] -= %a;
		}
	}
	%new = "";
	%nolvl = "";
	// OFF ======================================================
	for (%i = 1; %i <= $OffPassives; %i++) {
		%var = $PlayerPassive[%id,"O",%i];
		if (%var > 0) {
			%pass = $PassiveList[O,%i];
			%val = CalcPassive(%id,%pass,False);
			if (%val != "")
				%new = %new @ %val;
			%val = CalcPassive(%id,%pass,True);
			if (%val != "")
				%nolvl = %nolvl @ %val;
		}
	}
	// DEF ======================================================
	for (%i = 1; %i <= $DefPassives; %i++) {
		%var = $PlayerPassive[%id,"D",%i];
		if (%var > 0) {
			%pass = $PassiveList[D,%i];
			%val = CalcPassive(%id,%pass,False);
			if (%val != "")
				%new = %new @ %val;
			%val = CalcPassive(%id,%pass,True);
			if (%val != "")
				%nolvl = %nolvl @ %val;
		}
	}
	// NEU ======================================================
	for (%i = 1; %i <= $NeuPassives; %i++) {
		%var = $PlayerPassive[%id,"N",%i];
		if (%var > 0) {
			%pass = $PassiveList[N,%i];
			%val = CalcPassive(%id,%pass,False);
			if (%val != "")
				%new = %new @ %val;
			%val = CalcPassive(%id,%pass,True);
			if (%val != "")
				%nolvl = %nolvl @ %val;
		}
	}
	// MAG ======================================================
	for (%i = 1; %i <= $MagPassives; %i++) {
		%var = $PlayerPassive[%id,"M",%i];
		if (%var > 0) {
			%pass = $PassiveList[M,%i];
			%val = CalcPassive(%id,%pass,False);
			if (%val != "")
				%new = %new @ %val;
			%val = CalcPassive(%id,%pass,True);
			if (%val != "")
				%nolvl = %nolvl @ %val;
		}
	}
	// ==========================================================
	// CREATE TEMP AND UPDATE
	if (%new != "") {
		for (%i = 0; (%b = getWord(%new,%i)) != -1; %i += 2) {
			%num = $BPBonusToNumeric[%b];
			%a = getWord(%new,(%i+1));
			if ((%skill = $BPSkillToNumeric[%b]) == "") $PlayerBonus[%id,%num] += %a;
			else $SkillBonus[%id,%skill] += %a;
		}
		$PassiveTemp[%id] = %new;
	}
	if (%nolvl != "") {
		for (%i = 0; (%b = getWord(%nolvl,%i)) != -1; %i += 2) {
			%num = $BPBonusToNumeric[%b];
			%a = getWord(%nolvl,(%i+1));
			if ((%skill = $BPSkillToNumeric[%b]) == "") $PlayerBonus[%id,%num] += %a;
			else $SkillBonus[%id,%skill] += %a;
		}
		$PassiveTempNoLvl[%id] = %nolvl;
	}
	$PassiveChange[%id] = 0;
	Client::SendMessage(%id,0,"Your passive modifiers have been updated.");
}

function DisplayAllPassiveBonus(%id)
{
	%mods = $PassiveTemp[%id];
	%mods = BPFormat(%mods);
	%nolvl = $PassiveTempNoLvl[%id];
	%nolvl = BPFormat(%nolvl);
	sendbufferbp(%id,"<f0>Current Passive Bonuses:<f1>\n\n " @ %mods @ "\n " @ %nolvl, 20);
}

function LoadPlayerPassives(%id,%t)
{
	%list = $PlayerPassiveSave[%id,%t];
	for (%i = 1; (%b = getWord(%list,%i)) != -1; %i++) {
		$PlayerPassive[%id,%t,%i] = %b;
	}
}

function PlayerPassveSaveList(%id,%t)
{
	if (%t == O) { %max = $OffPassives; %text = "OFF "; }
	if (%t == D) { %max = $DefPassives; %text = "DEF "; }
	if (%t == N) { %max = $NeuPassives; %text = "NEU "; }
	if (%t == M) { %max = $MagPassives; %text = "MAG "; }
	for (%i = 1; %i <= %max; %i++) {
		%var = $PlayerPassive[%id,%t,%i];
		if (%var <= 0) %var = 0;
		%text = %text @ %var @ " ";
	}
	return %text;
	$PlayerPassiveSave[%id,O] = %text;
}

function CurrentPassiveListForm(%id,%pass)
{
	%num = $PassiveNum[%pass];
	%type = $Passive[%pass,$PassiveType];
	%list = $PlayerPassiveSave[%id,%type];
	return getWord(%list,%num);
}

function CurrentPassive(%id,%pass)
{
	%type = $Passive[%pass,$PassiveType];
	%num = $PassiveNum[%pass];
	return $PlayerPassive[%id,%type,%num];
}

function MaxPassives(%id)
{
	%lvl = fetchData(%id,"LVL");
	if (%lvl <= 200) {
		return %lvl;
	}
	else if (%lvl > 200) {
		return 200 + ((%lvl - 200) * 3); 
	}
}

function CalcPassive(%id,%pass,%flag)
{
	//echo(" CALCPASSIVE " @ %id @ " " @ %pass @ " " @ %flag);
	%lvl = fetchData(%id,"LVL");
	%alvl = fetchData(%id,"ALVL");
	%cur = CurrentPassive(%id,%pass);
	%max = $Passive[%pass,$PassiveMax];
	%bonus = $Passive[%pass,$PassiveMods];
	%action = $Passive[%pass,$PassiveAction];
	if (%flag == True) %bonus = $Passive[%pass,$PassiveNoLvl];
	%ret = "";
	if (%bonus == "")
		return "";
	for (%i = 0; (%b = getWord(%bonus,%i)) != -1; %i += 2) {
		%val = getWord(%bonus,%i + 1);
		if (%flag) { %nv = round(%val * (%cur / %max)); }
		else { %nv = round((%val * (%cur / %max)) * ((%lvl + %alvl) / 230)); }
		%ret = %ret @ %b @ " " @ %nv @ " ";
	}
	if (%action != "") {
		if (%cur == %max)
			%ret = %ret @ %action @ " ";
	}
	return %ret;
}

function Game::MenuPassives(%id)
{
	%max = MaxPassives(%id);
	%cur = $UsedPassives[%id];
	%curItem = 0;
	Client::buildMenu(%id, "You have " @ $PassivePoints[%id] @ " passive points", "passives", true);
	Client::addMenuItem(%id, %curItem++ @ "Offensive...","O");
	Client::addMenuItem(%id, %curItem++ @ "Defensive...","D");
	Client::addMenuItem(%id, %curItem++ @ "Neutral...","N");
	Client::addMenuItem(%id, %curItem++ @ "Magic...","M");
	Client::addMenuItem(%id, %curItem++ @ "Display All Bonuses","display");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function processMenuPassives(%id, %option)
{
	if (%option == "back") Game::menuRequest(%id);
	else if (%option == "display") DisplayAllPassiveBonus(%id);
	else Game::MenuPassiveList(%id,%option,1);
}

$PassiveMenu[O] = "Offensive";
$PassiveMenu[D] = "Defensive";
$PassiveMenu[N] = "Neutral";
$PassiveMenu[M] = "Magic";

function Game::MenuPassiveList(%id,%t,%start)
{
	%max = MaxPassives(%id);
	%cur = $UsedPassives[%id];
	%curItem = 0;
	Client::buildMenu(%id, "You have " @ $PassivePoints[%id] @ " passive points", "passivelist", true);
	for (%i = %start; %i <= (%start + 30); %i++) {
		if ($PassiveList[%t,%i] != "") {
			%passive = $PassiveList[%t,%i];
			%selected = CurrentPassive(%id,%passive);
			if (%selected > 0) {
				Client::addMenuItem(%id,GetMenuNum(%curItem++) @ $PassiveList[%t,%i] @ " (" @ %selected @ ")", %t @ " " @ %start @ " " @ $PassiveList[%t,%i]);
			}
			else {
				Client::addMenuItem(%id,GetMenuNum(%curItem++) @ $PassiveList[%t,%i], %t @ " " @ %start @ " " @ $PassiveList[%t,%i]);
			}
		}
	}
	%check = %start + 31;
	if ($PassiveList[%t,%check] != "") {
		Client::addMenuItem(%id,GetMenuNum(%curItem++) @ "Next >>","UK");
	}
	Client::addMenuItem(%id,GetMenuNum(%curItem++) @ "<< Prev","back " @ %t @ " " @ %start);
}

function AddPassive(%id,%passive)
{
	%points = $PassivePoints[%id];
	if (%points < 1) { Client::SendMessage(%id,0,"You have no unused passive points."); return; }
	%current = CurrentPassive(%id,%passive);
	%max = fetchPassiveData(%passive,"max");
	if (%current == %max) { Client::SendMessage(%id,0,"You have reached the maximum amount of points for this passive."); return; }
	%num = fetchPassiveData(%passive,"num");
	%type = fetchPassiveData(%passive,"type");
	$PlayerPassive[%id,%type,%num]++;
	$PassivePoints[%id]--;
	$PassiveChange[%id] = 1;
}

function processMenuPassiveList(%id, %option)
{
	%a = getWord(%option,0);
	%b = getWord(%option,1);
	%c = getWord(%option,2);
	
	if (%a == "back") {
		if (%c == "1") {
			Game::MenuPassives(%id);
		}
	}
	else {
		Game::MenuPassiveSelect(%id,%option);
	}
}

function Game::MenuPassiveSelect(%id,%option)
{
	%t = getWord(%option,0);
	%start = getWord(%option,1);
	%passive = getWord(%option,2);
	if (getWord(%option,3) != -1) %passive = %passive @ " " @ getWord(%option,3);
	if (getWord(%option,4) != -1) %passive = %passive @ " " @ getWord(%option,4);
	
	%current = CurrentPassive(%id,%passive);
	%max = fetchPassiveData(%passive,"max");

	PassiveInfo(%id,%passive);

	%curItem = 0;
	// Client::buildMenu(%id, %passive @ " " @ %current @ "/" @ %max @ " | " @ $PassivePoints[%id] @ " available points", "passiveselect", true);
	Client::buildMenu(%id, %passive @ " " @ %current @ "/" @ %max, "passiveselect", true);
	Client::addMenuItem(%id,GetMenuNum(%curItem++) @ "Info", "info " @ %t @ " " @ %start @ " ^" @ %passive);
	Client::addMenuItem(%id,GetMenuNum(%curItem++) @ "Add Point (" @ $PassivePoints[%id] @ ")", "add " @ %t @ " " @ %start @ " ^" @ %passive);
	Client::addMenuItem(%id,GetMenuNum(%curItem++) @ "Remove Point (" @ $UnspecPoints[%id] @ ")", "rem " @ %t @ " " @ %start @ " ^" @ %passive);
	Client::addMenuItem(%id,GetMenuNum(%curItem++) @ "<< Prev","back " @ %t @ " " @ %start);
}

function processMenuPassiveSelect(%id,%option)
{
	%cmd = getWord(%option,0);
	if (%cmd == "back") {
		%t = getWord(%option,1);
		%start = getWord(%option,2);
		Game::MenuPassiveList(%id,%t,%start);
	}
	else {
		if (%cmd == "info") {
			%find = string::findSubStr(%option,"^");
			%passive = string::getSubStr(%option,(%find+1),99);
			%t = getWord(%option,1);
			%start = getWord(%option,2);
			%new = %t @ " " @ %start @ " " @ %passive;
			Game::MenuPassiveSelect(%id,%new);
			PassiveInfo(%id,%passive);
			
		}
		if (%cmd == "add") {
			%find = string::findSubStr(%option,"^");
			%passive = string::getSubStr(%option,(%find+1),99);
			%t = getWord(%option,1);
			%start = getWord(%option,2);
			%new = %t @ " " @ %start @ " " @ %passive;
			AddPassive(%id,%passive);
			PassiveInfo(%id,%passive);
			Game::MenuPassiveSelect(%id,%new);
		}
	}
}

function PassiveInfo(%id,%passive)
{
	%msg = "";
	%mods = fetchPassiveData(%passive,"mods");
	%nolvl = fetchPassiveData(%passive,"nolvl");
	%current = CurrentPassive(%id,%passive);
	%max = fetchPassiveData(%passive,"max");
	%action = fetchPassiveData(%passive,"action");
	//===================================================================================
	%msg = %msg @ "<bplate_passive.bmp>\n\n\n <f1>" @ %passive @ "\n\n\n";
	%msg = %msg @ "<f1> You currently have <f0>" @ %current @ "<f1> of <f0>" @ %max @ "<f1> maximum points used in this passive \n\n";
	//===================================================================================
	%msg = %msg @ "<f1> Maximum: \n";
	if (%mods != "") {
		%msg = %msg @ "<f1> Level Dependant Mods: \n";
		%msg = %msg @ "<f0> " @ BPFormat(%mods) @ "\n";
	}
	if (%nolvl != "") {
		%msg = %msg @ "<f1> Regular Mods: \n"; 
		%msg = %msg @ "<f0> " @ BPFormat(%nolvl) @ "\n";
	}
	%msg = %msg @ "\n";
	//===================================================================================
	if (%current > 0) {
		%msg = %msg @ "<f1> Current: \n";
		if (%mods != "") {
			%msg = %msg @ "<f1> Level Dependant Mods: \n";
			%calc = CalcPassive(%id,%passive,False);
			%msg = %msg @ "<f0> " @ BPFormat(%calc) @ "\n";
		}
		if (%nolvl != "") {
			%msg = %msg @ "<f1> Regular Mods: \n";
			%calc = CalcPassive(%id,%passive,True);
			%msg = %msg @ "<f0> " @ BPFormat(%calc) @ "\n";
		}
		%msg = %msg @ "\n\n";
	}
	if (%action != "") {
		%msg = %msg @ "<f1> Max Rank Bonus:<f0> \n";
		%msg = %msg @ " " @ BPFormat(%action) @ "\n ";
		%actiontest = getWord(%action,1);
		if ($CruAction[%actiontest,$CAName] != "")
			%msg = %msg @ "\n\n" @ WhatIsCruAction(%id,%actiontest,True);
	}
	sendbufferbp(%id, %msg, 30);
}

function ResetPassives(%clientId)
{
	$PlayerPassiveSave[%clientId,O] = $PassiveSave[O];
	$PlayerPassiveSave[%clientId,D] = $PassiveSave[D];
	$PlayerPassiveSave[%clientId,N] = $PassiveSave[N];
	$PlayerPassiveSave[%clientId,M] = $PassiveSave[M];
	%lvl = fetchData(%clientid,"LVL");
	LoadAllPassives(%clientId);
	$PassivePoints[%clientId] = %lvl;
	Client::SendMessage(%clientId,2,"Your passives have been reset. You have been refunded " @ %lvl @ " passive points.");
	UpdatePassives(%clientId);
}

//===================================================================================================================================================
// OFFENSIVE

PassiveCreate("Swordsman","SLASHING 575 CLEAVE 575","SLASHINGDAMAGE 100",20,"O");
PassiveCreate("Outlaw","PIERCING 575 BACKSTABBING 575","PIERCINGDAMAGE 100",20,"O");
PassiveCreate("Warhammer","BLUDGEONING 575 BASHING 575","BLUDGEDAMAGE 100",20,"O");
PassiveCreate("Archer","ARCHERY 575 AIMING 575","ARCHERYDAMAGE 75",20,"O");
PassiveCreate("Master of Arms","","PHYSICALDAMAGE 40",20,"O","PHYSICALDAMAGE 10");
PassiveCreate("Savage","PHYSBASE 100","",20,"O");
PassiveCreate("Fighter","PHYSBASE 50 BRAWLING 575","",20,"O");
PassiveCreate("Bowman","RANGEDBASE 100","",20,"O");
PassiveCreate("Puncture","","CRITDAMAGE 100 CRITCHANCE 100",20,"O","");
PassiveCreate("Bloodlust","","LIFESTEAL 20",20,"O");
PassiveCreate("Onslaught","ADDALLOFF 75","",20,"O");
PassiveCreate("Infiltration","ARMORPEN 3000","",20,"O");
PassiveCreate("Accurate","ACCURACY 500","",20,"O");
PassiveCreate("Thief","STEALING 575 HIDING 575","",20,"O");
PassiveCreate("Samurai","MARTIALARTS 575","MADAMAGE 100",20,"O","ADDALLDEF 50 ADDALLOFF 50");
PassiveCreate("Weapon Training","WEAPONHANDLING 575","WEAPONRANGE 50",20,"O");
PassiveCreate("Prayer","","DAMAGEDEMON 10 DEMONPROT 10",10,"O");
PassiveCreate("Living","","DAMAGEUNDEAD 10 UNDEADPROT 10",10,"O");
PassiveCreate("Hunter","","DAMAGEBEAST 10 BEASTPROT 10",10,"O");
PassiveCreate("Devastator","","PROJDAMAGE% 40 MELEETYPEDAMAGE 40",20,"O","PROJDAMAGE% 10 MELEETYPEDAMAGE 10");
PassiveCreate("Firestarter","","FIREDAMAGE% 40",20,"O","FIREDAMAGE% 10 INCBURN 10");
PassiveCreate("Frostbite","","COLDDAMAGE% 40",20,"O","COLDDAMAGE% 10 INCCHILL 10");
PassiveCreate("Electric","","ENERGYDAMAGE% 40",20,"O","ENERGYDAMAGE% 10 INCSHOCK 10");
PassiveCreate("Venomous","","POISONDAMAGE% 40",20,"O","POISONDAMAGE% 10 INCPOISON 10");
PassiveCreate("Heavy Hitter","","INCSTUN 10",10,"O");
PassiveCreate("Dirt","","INCROOT 10",10,"O");
PassiveCreate("Hostile","","BERSERK 10",10,"O");
PassiveCreate("Heavy Weapons","","TWOHANDDMG 20",20,"O");
PassiveCreate("Vulnerability Seeker","MAACCURACY 575","CRITMA 40",20,"O","CRITMA 10");

// DEFENSIVE
PassiveCreate("Careful","ADDALLDEF 75","",20,"D");
PassiveCreate("Iron Skin","ARMOR 2000","INCARMOR 100",20,"D");
PassiveCreate("Evasive","EVASION 2000","INCEVASION 100",20,"D");
PassiveCreate("Diamond Skin","ALLRESIST 2000","INCRESIST 100",20,"D");
PassiveCreate("Heavy Armor","MELEEAC 1000 PROJAC 1000","",10,"D");
PassiveCreate("Elemental Armor","POISONAC 1000 FIREAC 1000 COLDAC 1000 ENERGYAC 1000","",10,"D");
PassiveCreate("Heavy Refusal","MELEERES 1000 PROJRES 1000","",10,"D");
PassiveCreate("Elemental Refusal","FIRERES 1000 COLDRES 1000 ENERGYRES 1000 POISONRES 1000","",10,"D");
PassiveCreate("Regeneration","HEALDELTA 225","",20,"D","HEALDELTA 25");
PassiveCreate("Thornmail","","REFLECT 20",20,"D");
PassiveCreate("Sidestep","DODGING 575","",20,"D");
PassiveCreate("Quickstep","EVADEMELEE 575","",20,"D");
PassiveCreate("Repulsing","SPELLRESISTANCE 575","",20,"D");
PassiveCreate("Cleric","HEALING 575","HEALING% 20",20,"D");
PassiveCreate("Survivalist","ENDURANCE 575","",20,"D","HEALTH% 10");
PassiveCreate("Massive","MAXHP 650","HEALTH% 75",20,"D","MAXHP 100");
PassiveCreate("Redguard","BLOCKAMMOUNT 500","BLOCKHIT% 10 BLOCKRECOVERY 20",20,"D");
PassiveCreate("Whiteguard","SPLBLOCKAMM 500","BLOCKSPELL% 10 SPLBLOCKREC 20",20,"D");
PassiveCreate("Blackguard","","SHIELDBONUS 20",20,"D","SHIELDBONUS 10");
PassiveCreate("Heavy Skull","","AVOIDSTUN 20",10,"D");
PassiveCreate("Uprooting","","AVOIDROOT 20",10,"D");
PassiveCreate("Heavy Coat","","AVOIDCHILL 10",20,"D");
PassiveCreate("Liquid","","AVOIDBURN 20",10,"D");
PassiveCreate("Antiviral","","AVOIDPOISON 10",20,"D");
PassiveCreate("Grounded","","AVOIDSHOCK 20",10,"D");
PassiveCreate("Missing","","AVOIDCRIT 20",10,"D");
PassiveCreate("Fencing","RIPOSTE 1000","",20,"D");
PassiveCreate("Tourniquet","BANDAGE 1000","",20,"D");

// NEUTRAL
PassiveCreate("Learning","","ADDEXP 80",20,"N","ADDEXP 20");
PassiveCreate("Luck","","GOLDFIND 80",20,"N","GOLDFIND 20");
PassiveCreate("Treasure Hunter","","MAGICFIND 80",20,"N","MAGICFIND 20");
PassiveCreate("Lifting","MAXWEIGHT 1000 WEIGHTCAPACITY 575","",20,"N");
PassiveCreate("Prospector","MINING 575","",10,"N");
PassiveCreate("Knowledge","LITERACY 575 SPEECH 575","",10,"N");
PassiveCreate("Tracker","SENSEHEADING 575","",10,"N");
PassiveCreate("Merchant","HAGGLING 575","",10,"N");
PassiveCreate("Warrior","STRENGTH 575","",20,"N","");
PassiveCreate("Rogue","DEXTERITY 575","",20,"N","");
PassiveCreate("Mage","INTELLIGENCE 575","",20,"N","");
PassiveCreate("Blacksmith","SMITHING 575","SMITHREQ 20",20,"N");
PassiveCreate("Workmanship","MAGICCRAFT 575","MAGICCRAFTREQ 20",20,"N");
PassiveCreate("Alchemist","ALCHEMY 575","",20,"N","ALCHEMYREQ 20");
PassiveCreate("Elixir","","HEALTHPOTION 20 MANAPOTION 20",20,"N","HEALTHPOTION 10 MANAPOTION 10");
PassiveCreate("Vision","PERCEPTION 3000","",20,"N");
PassiveCreate("Woodsman","","FORESTDAMAGE 10 FORESTPROT 10",10,"N");
PassiveCreate("Nomad","","DESERTDAMAGE 10 DESERTPROT 10",10,"N");
PassiveCreate("Tribesman","","JUNGLEDAMAGE 10 JUNGLEPROT 10",10,"N");
PassiveCreate("Vagabond","","SNOWDAMAGE 10 SNOWPROT 10",10,"N");
PassiveCreate("Wanderer","","LAVADAMAGE 10 LAVAPROT 10",10,"N");
PassiveCreate("Transient","","ARCANEDAMAGE 10 ARCANEPROT 10",10,"N");

// MAGIC
PassiveCreate("Archwizard","SPELLCAPACITY 575","MAGICDAMAGE 40 CASTRANGE 50",20,"M");
PassiveCreate("Arcane","","STAFFMAGIC 40",20,"M","STAFFMAGIC 10");
PassiveCreate("Mystic","","WANDMAGIC 40",20,"M","WANDMAGIC 10");
PassiveCreate("Powerful","SPELLBASE 100","",20,"M");
PassiveCreate("Hex","","SPELLCRIT 100 SPCRITDAMAGE 100",20,"M");
PassiveCreate("Void","MAGICPEN 3000","",20,"M");
PassiveCreate("Spellstrike","SPELLACCURACY 500","",20,"M");
PassiveCreate("Spirited","MANADELTA 225","",20,"M","MANADELTA 25");
PassiveCreate("Efficient","","MANACOST 20",20,"M");
PassiveCreate("Vampire","","SPELLVAMP 20",20,"M");
PassiveCreate("Vigor","ENERGY 575","",20,"M");
PassiveCreate("Wise","WISDOM 575 MAXMEMORY 100","",20,"M");
PassiveCreate("Manawell","MAXMANA 1250","MANA% 75",20,"M","MAXMANA 250");
PassiveCreate("Mana Meshing","","MANAHEALTH 10",10,"M");
PassiveCreate("Health Meshing","","HEALTHMANA 10",10,"M");
PassiveCreate("Red Magic","","BLOODMAGIC 20",20,"M","BLOODMAGIC 10");
PassiveCreate("Blue Blood","","DAMAGEMANA 20",20,"M","DAMAGEMANA 10");
PassiveCreate("Necromancer","","MINIONHEALTH 40 MINIONDAMAGE 40",20,"M","MINIONHEALTH 10 MINIONDAMAGE 10");
PassiveCreate("Ignore","","SPELLINTURUPT 10",10,"M","SPELLINTURUPT 5");
PassiveCreate("Primalistic","PRIMALMAGIC 575","",20,"M");
PassiveCreate("Divine","HOLYMAGIC 575","",20,"M");
PassiveCreate("Empowered","EMPOWERMENT 575","",20,"M");
PassiveCreate("Blackened","DARKMAGIC 575","",20,"M");
PassiveCreate("Lightbringer","LIGHTMAGIC 575","",20,"M");
PassiveCreate("Ritualistic","RITUAL 575","",20,"M");
PassiveCreate("All Seeing Orb","SORCERY 575","",20,"M");
PassiveCreate("Protective","PROTECTION 575","",20,"M");
PassiveCreate("Encharmed","ENCHANTMENT 575","",20,"M");
PassiveCreate("Spellslinger","","COOLDOWN 20",20,"M");

//===================================================================================================================================================
// PASSIVE ACTIONS

























echo("__PASSIVES LOADED");