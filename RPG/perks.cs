// PERKS

function DefaultPlayerPerks(%id)
{
	$PlayerPerks[%id] = "";
}

function PlayerHasPerk(%id,%this)
{
	%perks = $PlayerPerks[%id];
	for (%i = 0; (%p = getWord(%perks,%i)) != -1; %i++) {
		if (String::ICompare(%this,%p) == 0)
			return True;
	}
	return False;
}

function PlayerHasTempPerk(%id,%this) 
{
	%perks = $TempPerks[%id];
	for (%i = 0; (%p = getWord(%perks,%i)) != -1; %i++) {
		if (String::ICompare(%this,%p) == 0)
			return True;
	}
	return False;
}

function AddPlayerPerk(%id,%this)
{
	$PlayerPerks[%id] = $PlayerPerks[%id] @ %this @ " ";
}

function RemovePlayerPerk(%id,%this)
{
	%perks = $PlayerPerks[%id];
	%new = "";
	for (%i = 0; (%p = getWord(%perks,%i)) != -1; %i++) {
		if (String::ICompare(%this,%p) != 0)
			%new = %new @ %this @ " ";
	}
	$PlayerPerks[%id] = %new;
}

function AddPerk(%id,%perk)
{
	if (PlayerHasPerk(%id,%perk)) {
		Client::SendMessage(%id,0,"You already have perk: " @ $CruPerk[%perk,$CPName] @ ".");
		return;
	}
	if (CanAddPerk(%id,%perk)) {
		Client::SendMessage(%id,0,"You added perk: " @ $CruPerk[%perk,$CPName] @ ".");
		AddPlayerPerk(%id,%perk);
		PerkBonus(%id,%perk,1);
	}
	else
		Client::SendMessage(%id,0,"You don't meet the requirements to use perk: " @ $CruPerk[%perk,$CPName] @ ".");
}

function IsHighestPerkInLine(%id,%perk)
{
	%class = fetchData(%id,"CLASS");
	%name = $CruPerkToList[%perk];
	%line = $CruPerkLine[%name];
	%mode = $CruPerk[%perk,$CPMode];
	%top = -1;
	%perkis = -1;
	for (%i = 1; %i <= 10; %i++) {
		%this = $CruPerkList[%class,%mode,%line,%i];
		if (PlayerHasPerk(%id,%this))
			%top = %i;
		if (String::ICompare(%this,%perk) == 0)
			%perkis = %i;
	}
	if (%perkis != -1 && %top <= %perkis) {
		return True;
	}
	else {
		return False;
	}
}

function RemovePerk(%id,%perk)
{
	if (PlayerHasPerk(%id,%perk)) {
		if (IsHighestPerkInLine(%id,%perk) == True) {
			RemovePlayerPerk(%id,%this);
			Client::SendMessage(%id,0,"You removed perk: " @ $CruPerk[%perk,$CPName] @ ".");
			PerkCoolDown(%id);
			PerkBonus(%id,%perk,0);
		}
		else
			Client::SendMessage(%id,0,"Perks must be removed in order from highest first.");
	}
	else
		Client::SendMessage(%id,0,"You do not have perk: " @ $CruPerk[%perk,$CPName] @ ".");
}

function JoinTeamAddPerks(%id,%team,%v)
{
	%perks = $PlayerPerks[%id];
	if (%perks == "")
		return;
	for (%i = 0; (%p = getWord(%perks,%i)) != -1; %i++) {
		%mode = $CruPerk[%p,$CPMode];
		if (%mode == $GroupPerk) {
			%teamlist = $TeamList[%team];
			for (%i = 0; (%m = getWord(%teamlist,%i)) != -1; %i++) {
				if (%v == 1) {
					if (PlayerHasTempPerk(%m,%p) == False) {
						if (PlayerHasTempPerk(%m,%p) == False)
							PerkBonus(%m,%p,%v);
						$TempPerks[%m] = $TempPerks[%m] @ %p @ " ";
					}
				}
				if (%v == 0) {
					if (PlayerHasTempPerk(%m,%p) == False) {
						$TempPerks[%m] = String::DelTok($TempPerks[%m],%p,True);
						if (PlayerHasTempPerk(%m,%p) == False)
							PerkBonus(%m,%p,%v);
					}
				}
			}
		}
	}
}

function TeamJoinAddPerks(%id,%team,%v)
{
	%teamlist = $TeamList[%team];
	for (%i = 0; (%m = getWord(%teamlist,%i)) != -1; %i++) {
		%perks = $PlayerPerks[%m];
		for (%i = 0; (%p = getWord(%perks,%i)) != -1; %i++) {
			%mode = $CruPerk[%p,$CPMode];
			if (%mode == $GroupPerk) {
				if (%v == 1) {
					if (PlayerHasPerk(%id,%p) == False) {
						if (PlayerHasTempPerk(%id,%p) == False)
							PerkBonus(%id,%p,%v);
						$TempPerks[%id] = $TempPerks[%id] @ %p @ " ";
					}
				}
				if (%v == 0) {
					if (PlayerHasPerk(%id,%p) == False) {
						$TempPerks[%id] = String::DelTok($TempPerks[%id],%p,True);
						if (PlayerHasTempPerk(%id,%p) == False)
							PerkBonus(%id,%p,%v);
					}
				}
			}
		}
	}
}

function CanAddPerk(%id,%perk,%use) 
{
	%req = $CruPerk[%perk,$CPReqs];
	%text = $AreaText[%perk];
	if (%req == "")
		return False;
	for (%i = 0; (%r = getWord(%req,%i)) != -1; %i += 2) {
		%a = getWord(%req,%i + 1);
		if (%r == "HASPERK") {
			if (PlayerHasPerk(%id,%a) != True)
				return False;
		}
		if (%r == "RLG") {
			if (fetchData(%id,"RemortStep") < %a)
				return False;
		}
		if (%r == "GROUP") {
			if (fetchData(%id,"Group") != %a)
				return False;
		}
		if (%r == "CLASS") {
			if (fetchData(%id,"Class") != %a)
				return False;
		}
		if (%r == "LVLG") {
			if (fetchData(%id,"LVL") < %a)
				return False;
		}
	}
	return True;
}

function PerkBonus(%id,%perk,%v)
{
	%bonus = $CruPerk[%perk,$CPBonus];
	%text = $AreaText[%perk];
	if (%text != "" && %v == 1)
		FloatText(%id,%text);
	if (%bonus == "")
		return;
	for (%i = 0; (%b = getWord(%bonus,%i)) != -1; %i += 2) {
		%a = getWord(%bonus,%i + 1);
		if ((%num = $BPSkillToNumeric[%b]) == "") {
			if (%b == "HEAL") {
				if (%v) {
					%hp = fetchData(%id, "HP");
					refreshHP(%id, ((%a / 100) * -1));
					refreshAll(%id);
				}
			}
			else if (%b == "HEALMP") {
				if (%v) {
					%mana = fetchData(%id, "MANA");
					refreshMANA(%id, (%a * -1));
					refreshAll(%id);
				}
			}
			else {
				%num = $BPBonusToNumeric[%b];
				if (%num != "") {
					if (%v != 0)
						$PlayerBonus[%id,%num] += %a;
					else
						$PlayerBonus[%id,%num] -= %a;
				}
			}
		}
		else {
			if (%v != 0)
				$SkillBonus[%id,%num] += %a;
			else
				$SkillBonus[%id,%num] -= %a;
		}
	}
	refreshHPREGEN(%id);
	refreshMANAREGEN(%id);
}

function PerkPointMsg(%id)
{
	if ($PerkPoints[%id] == 0 || $PerkPoints[%id] == "")
		return "You have 0 Perk points";
	else if ($PerkPoints[%id] = 1)
		return "You have 1 Perk point";
	else
		return "You have " @ $PerkPoints[%id] @ " Perk points";
}

function GetPerkLine(%perk)
{
	%list = $CruPerkToList[%perk];
	%line = $CruPerkLine[%list];
}

function Game::MenuPerks(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, PerkPointMsg(%id), "options", true);
	Client::addMenuItem(%id, %curItem++ @ "Class...","perks 1 class");
	Client::addMenuItem(%id, %curItem++ @ "Group...","perks 1 group");
	Client::addMenuItem(%id, %curItem++ @ "General...","perks 1 general");
}

function Game::MenuPerkList(%id,%list,%type)
{
	%curItem = 0;
	Client::buildMenu(%id, PerkPointMsg(%id), "options", true);
	%class = fetchData(%id,"CLASS");
	for (%i = %list; %i <= (%list + 6); %i++) {
		
		if (%type == "class")
			%this = $CruPerkList[%class,$ClassPerk,%i,0];
		if (%type == "group")
			%this = $CruPerkList[%class,$GroupPerk,%i,0];
		if (%type == "general")
			%this = $CruPerkList[$GeneralPerk,%i,0];

		if (%this != "")
			Client::addMenuItem(%id, %curItem++ @ %this,"perksel " @ %i @ " " @ %list @ " " @ %type);
	}
	Client::addMenuItem(%id,"p" @ "<< Prev","menuperk");
}

function Game::MenuShowPerk(%id,%perk,%list,%type)
{

	%group = False;
	%general = False;
	if (%type == "group")
		%group = True;
	if (%type == "general")
		%general = True;
	%curItem = 0;

	Client::buildMenu(%id, PerkPointMsg(%id), "options", true);
	%class = fetchData(%id,"CLASS");
	for (%i = %list; %i <= (%list + 5); %i++) {

		%getperk = $CruPerkList[%class,$ClassPerk,%perk,%i];
		if (%group == True)
			%getperk = $CruPerkList[%class,$GroupPerk,%perk,%i];
		if (%general == True)
			%getperk = $CruPerkList[$GeneralPerk,%perk,%i];
		echo("GET PERK " @ %getperk);
		if (%getperk != "") {
			%this = $CruPerkList[%class,$ClassPerk,%perk,%i];
			if (%group == True)
				%this = $CruPerkList[%class,$GroupPerk,%perk,%i];
			if (%general == True)
				%this = $CruPerkList[$GeneralPerk,%perk,%i];

			%name = $CruPerk[%this,$CPName];

			if (PlayerHasPerk(%id,%this) == True)
				Client::addMenuItem(%id, %curItem++ @ "[x] " @ %name,"perkconfig " @ %this @ " " @ %perk @ " " @ %list @ " " @ %type);
			else
				Client::addMenuItem(%id, %curItem++ @ "[ ] " @ %name,"perkconfig " @ %this @ " " @ %perk @ " " @ %list @ " " @ %type);
		}
	}
	%this = $CruPerkList[%class,$ClassPerk,%perk,7];
	if (%group == True) 
		%this = $CruPerkList[%class,$GroupPerk,%perk,7];
	if (%general == True)
		%this = $CruPerkList[$GeneralPerk,%perk,7];
	if (%this != "") {
		if (%list == 1)
			Client::addMenuItem(%id,"n" @ "Next >>","menunextperk " @ GetPerkLine(%this) @ " " @ (%list + 6) @ " " @ %type);
	}
	if (%list == 7) {
		%this = $CruPerkList[%class,$ClassPerk,%perk,7];
		if (%group == True) 
			%this = $CruPerkList[%class,$GroupPerk,%perk,7];
		if (%general == True)
			%this = $CruPerkList[$GeneralPerk,%perk,7];
		Client::addMenuItem(%id,"p" @ "<< Prev","menuperkselback " @ GetPerkLine(%this) @ " 1 " @ %type);
	}
	else {
		Client::addMenuItem(%id,"p" @ "<< Prev","menubackperk " @ %list @ " " @ %type);
	}
}

function Game::MenuConfigPerk(%id,%perk,%var,%list,%type)
{
	%curItem = 0;
	Client::buildMenu(%id, $CruPerk[%perk,$CPName], "options", true);
	Client::addMenuItem(%id, %curItem++ @ "Perk Information...","perkinfo " @ %perk @ " " @ %var @ " " @ %list @ " " @ %type);
	if (IsHighestPerkInLine(%id,%perk) && PlayerHasPerk(%id,%perk))
		Client::addMenuItem(%id, %curItem++ @ "Remove Perk","remperk " @ %perk @ " " @ %var @ " " @ %list @ " " @ %type);
	else
		Client::addMenuItem(%id, %curItem++ @ "Add Perk","addperk " @ %perk @ " " @ %var @ " " @ %list @ " " @ %type);
	echo("TYPE>>> " @ %type);
	Client::addMenuItem(%id,"p" @ "<< Prev","perksel " @ %var @ " " @ %list @ " " @ %type);
}

function ShowPerkInfo(%id,%perk) 
{
	%msg = "";
	%msg = %msg @ "<f0>Perk - " @ $CruPerk[%perk,$CPName] @ "\n";
	%msg = %msg @ "<f1>Requirements: " @ BPFormat($CruPerk[%perk,$CPReqs]) @ "\n";
	%msg = %msg @ "Bonus: " @ BPFormat($CruPerk[%perk,$CPBonus]) @ "\n";
	%msg = %msg @ "<f0>" @ $CruPerk[%perk,$CPInfo];
	bottomPrint(%id,%msg,10);
}

$CPName = 1;
$CPMode = 2;
$CPBonus = 3;
$CPInfo = 4;
$CPReqs = 5;

$ClassPerk = 1;
$GroupPerk = 2;
$GeneralPerk = 3;


// CLERIC PERKS
$CruPerkLine[Minister] = 1;
$CruPerkToList[MinisterI] = "Minister";
$CruPerkToList[MinisterII] = "Minister";
$CruPerkList[Cleric,$ClassPerk,1,0] = "Minister";
$CruPerkList[Cleric,$ClassPerk,1,1] = "MinisterI";
$CruPerkList[Cleric,$ClassPerk,1,2] = "MinisterII";
// MINSTER 1
$CruPerk[MinisterI,$CPName] = "Minister I";
$CruPerk[MinisterI,$CPMode] = $ClassPerk;
$CruPerk[MinisterI,$CPReqs] = "CLASS Cleric";
$CruPerk[MinisterI,$CPBonus] = "Healing 5 DefensiveCasting 5";
$CruPerk[MinisterI,$CPInfo] = "Increases the Cleric's healing and defensive casting";
// MINISTER 2
$CruPerk[MinisterII,$CPName] = "Minister II";
$CruPerk[MinisterII,$CPMode] = $ClassPerk;
$CruPerk[MinisterII,$CPReqs] = "CLASS Cleric HASPERK MinisterI LVLG 2";
$CruPerk[MinisterII,$CPBonus] = "Healing 6 DefensiveCasting 6";
$CruPerk[MinisterII,$CPInfo] = "Increases the Cleric's healing and defensive casting";

$CruPerkLine[DivineArmor] = 2;
$CruPerkToList[DivineArmorI] = "DivineArmor";
$CruPerkToList[DivineArmorII] = "DivineArmor";
$CruPerkList[Cleric,$ClassPerk,2,0] = "DivineArmor";
$CruPerkList[Cleric,$ClassPerk,2,1] = "DivineArmorI";
$CruPerkList[Cleric,$ClassPerk,2,2] = "DivineArmorII";
// DivineArmor 1
$CruPerk[DivineArmorI,$CPName] = "Divine Armor I";
$CruPerk[DivineArmorI,$CPMode] = $ClassPerk;
$CruPerk[DivineArmorI,$CPReqs] = "CLASS Cleric";
$CruPerk[DivineArmorI,$CPBonus] = "DEF 5 MDEF 5";
$CruPerk[DivineArmorI,$CPInfo] = "Adds to the Cleric's defensive armor";
// DivineArmor 2
$CruPerk[DivineArmorII,$CPName] = "Divine Armor II";
$CruPerk[DivineArmorII,$CPMode] = $ClassPerk;
$CruPerk[DivineArmorII,$CPReqs] = "CLASS Cleric HASPERK DivineArmorI LVLG 2";
$CruPerk[DivineArmorII,$CPBonus] = "DEF 5 MDEF 5";
$CruPerk[DivineArmorII,$CPInfo] = "Adds to the Cleric's defensive armor";


// PALADIN PERKS
$CruPerkLine[Warriors] = 1;
$CruPerkToList[WarriorsI] = "Warriors";
$CruPerkList[Paladin,$GroupPerk,1,0] = "Warriors";
$CruPerkList[Paladin,$GroupPerk,1,1] = "WarriorsI";
// Warriors 1
$CruPerk[WarriorsI,$CPName] = "Warriors I";
$CruPerk[WarriorsI,$CPMode] = $GroupPerk;
$CruPerk[WarriorsI,$CPReqs] = "CLASS Paladin";
$CruPerk[WarriorsI,$CPBonus] = "Slashing 5 ATK 1";
$CruPerk[WarriorsI,$CPInfo] = "Increases your group's Attack rating and Slashing";


// Crusade
$CruPerkLine[Crusade] = 1;
$CruPerkToList[CrusadeI] 		= "Crusade";
$CruPerkToList[CrusadeII] 		= "Crusade";
$CruPerkToList[CrusadeIII] 		= "Crusade";
$CruPerkToList[CrusadeIV] 		= "Crusade";
$CruPerkToList[CrusadeV] 		= "Crusade";
$CruPerkToList[CrusadeVI] 		= "Crusade";
$CruPerkToList[CrusadeVII] 		= "Crusade";
$CruPerkToList[CrusadeVIII] 		= "Crusade";
$CruPerkToList[CrusadeIX] 		= "Crusade";
$CruPerkToList[CrusadeX] 		= "Crusade";
$CruPerkList[Paladin,$ClassPerk,1,0] 		= "Crusade";
$CruPerkList[Paladin,$ClassPerk,1,1]		= "CrusadeI";
$CruPerkList[Paladin,$ClassPerk,1,2] 		= "CrusadeII";
$CruPerkList[Paladin,$ClassPerk,1,3] 		= "CrusadeIII";
$CruPerkList[Paladin,$ClassPerk,1,4] 		= "CrusadeIV";
$CruPerkList[Paladin,$ClassPerk,1,5] 		= "CrusadeV";
$CruPerkList[Paladin,$ClassPerk,1,6] 		= "CrusadeVI";
$CruPerkList[Paladin,$ClassPerk,1,7] 		= "CrusadeVII";
$CruPerkList[Paladin,$ClassPerk,1,8] 		= "CrusadeVIII";
$CruPerkList[Paladin,$ClassPerk,1,9] 		= "CrusadeIX";
$CruPerkList[Paladin,$ClassPerk,1,10] 		= "CrusadeX";
// CRUSADE 1
$CruPerk[CrusadeI,$CPName] 		= "Crusade I";
$CruPerk[CrusadeI,$CPMode]		= $ClassPerk;
$CruPerk[CrusadeI,$CPReqs] 		= "CLASS Paladin";
$CruPerk[CrusadeI,$CPBonus] 		= "MaxHP 20";
$CruPerk[CrusadeI,$CPInfo] 		= "Increases your max health by 10";
// CRUSADE 2
$CruPerk[CrusadeII,$CPName] 		= "Crusade II";
$CruPerk[CrusadeII,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeII,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeI";
$CruPerk[CrusadeII,$CPBonus] 		= "MaxHP 30";
$CruPerk[CrusadeII,$CPInfo] 		= "Increases your max health by 20";
// CRUSADE 3
$CruPerk[CrusadeIII,$CPName] 		= "Crusade III";
$CruPerk[CrusadeIII,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeIII,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeII";
$CruPerk[CrusadeIII,$CPBonus] 		= "MaxHP 50 ENABLEACTION WarHammer";
$CruPerk[CrusadeIII,$CPInfo] 		= "Increases your max health by 50 and enables action: War Hammer";
// CRUSADE 4
$CruPerk[CrusadeIV,$CPName] 		= "Crusade IV";
$CruPerk[CrusadeIV,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeIV,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeIII";
$CruPerk[CrusadeIV,$CPBonus] 		= "MaxHP 100";
$CruPerk[CrusadeIV,$CPInfo] 		= "Increases your max health by 100";
// CRUSADE 5
$CruPerk[CrusadeV,$CPName] 		= "Crusade V";
$CruPerk[CrusadeV,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeV,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeIV";
$CruPerk[CrusadeV,$CPBonus] 		= "MaxHP 120 ENABLEACTION HolyMark";
$CruPerk[CrusadeV,$CPInfo] 		= "Increases your max health by 120 and enables action: Holy Mark";
// CRUSADE 6
$CruPerk[CrusadeVI,$CPName] 		= "Crusade VI";
$CruPerk[CrusadeVI,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeVI,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeV";
$CruPerk[CrusadeVI,$CPBonus] 		= "MaxHP 160";
$CruPerk[CrusadeVI,$CPInfo] 		= "Increases your max health by 160";
// CRUSADE 7
$CruPerk[CrusadeVII,$CPName] 		= "Crusade VII";
$CruPerk[CrusadeVII,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeVII,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeVI";
$CruPerk[CrusadeVII,$CPBonus] 		= "MaxHP 210";
$CruPerk[CrusadeVII,$CPInfo] 		= "Increases your max health by 230";
// CRUSADE 8
$CruPerk[CrusadeVIII,$CPName] 		= "Crusade VIII";
$CruPerk[CrusadeVIII,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeVIII,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeVII";
$CruPerk[CrusadeVIII,$CPBonus] 		= "MaxHP 430";
$CruPerk[CrusadeVIII,$CPInfo] 		= "Increases your max health by 430 and enables action: Promise";
// CRUSADE 9
$CruPerk[CrusadeIX,$CPName] 		= "Crusade IX";
$CruPerk[CrusadeIX,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeIX,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeVIII";
$CruPerk[CrusadeIX,$CPBonus] 		= "MaxHP 630";
$CruPerk[CrusadeIX,$CPInfo] 		= "Increases your max health by 600";
// CRUSADE 10
$CruPerk[CrusadeX,$CPName] 		= "Crusade X";
$CruPerk[CrusadeX,$CPMode] 		= $ClassPerk;
$CruPerk[CrusadeX,$CPReqs] 		= "CLASS Paladin HASPERK CrusadeIX";
$CruPerk[CrusadeX,$CPBonus] 		= "MaxHP 930";
$CruPerk[CrusadeX,$CPInfo] 		= "Increases your max health by 930 and enables action: Might";

// RAMPART
$CruPerkLine[Rampart] = 1;
$CruPerkToList[RampartI] = "Rampart";
$CruPerkToList[RampartII] = "Rampart";
$CruPerkToList[RampartIII] = "Rampart";
$CruPerkToList[RampartIV] = "Rampart";
$CruPerkToList[RampartV] = "Rampart";
$CruPerkList[Paladin,$ClassPerk,2,0] = "Rampart";
$CruPerkList[Paladin,$ClassPerk,2,1] = "RampartI";
$CruPerkList[Paladin,$ClassPerk,2,2] = "RampartII";
$CruPerkList[Paladin,$ClassPerk,2,3] = "RampartIII";
$CruPerkList[Paladin,$ClassPerk,2,4] = "RampartIV";
$CruPerkList[Paladin,$ClassPerk,2,5] = "RampartV";
$CruPerk[RampartI,$CPName] = "Rampart I";
$CruPerk[RampartI,$CPMode] = $ClassPerk;
$CruPerk[RampartI,$CPReqs] = "CLASS Paladin";
$CruPerk[RampartI,$CPBonus] = "DEF 5 MeleeAC 10 PoisonAC 10 ProjectileAC 10 ColdAC 10 FireAC 10";
$CruPerk[RampartI,$CPInfo] = "Increases the defense of the paladin";


echo("PERKS LOADED__");