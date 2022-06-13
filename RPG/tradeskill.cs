// TRADESKILL

// FISHING FARMING CRAFT(PHYSICAL) CRAFT(MAGICICAL) ALCHEMY

//-----------------------------------------------------------------------------------

$TradeSkillFishing = 1;
$TradeSkillFarming = 2;
$TradeSkillPhysCraft = 3;
$TradeSkillMagicCraft = 4;
$TradeSkillAlchemy = 5;

$TradeSkillToNum[Fishing] = 1;
$TradeSkillToNum[Farming] = 2;
$TradeSkillToNum[PhysCraft] = 3;
$TradeSkillToNum[MagicCraft] = 4;
$TradeSkillToNum[Alchemy] = 5;

$TradeToDisp[$TradeSkillFishing] = "Fishing";

$TradeMuli[Paladin,$TradeSkillFishing] = 2.0;

function GetNumTradeSkills()
{
	return 5;
}


function DisplayTradeSkill(%id)
{
	echo("Doing Trade Skill");
	%msg = "";
	// FISH
	%lvl = GetTradeSkill(%id,$TradeSkillFishing);
	%msg = %msg @ " <f1>Fishing - Level: " @ %lvl @ "";
	%exp = GetTradeCounter(%id,$TradeSkillFishing);
	%nlvl = %lvl + 1;
	if (%lvl < $MaxTradeLevel) {
		%msg = %msg @ " (Exp: " @ %exp @ "/" @ $TradeExp[%nlvl] @ ")";
		//%prog = floor((%exp / $TradeExp[%nlvl]) * 100);
		//%msg = %msg @ " (" @ %prog @ "%)";
	}
	%msg = %msg @ "<n>";
	// Farming
	%lvl = GetTradeSkill(%id,$TradeSkillFarming);
	%msg = %msg @ " Farming - Level: " @ %lvl @ "";
	%exp = GetTradeCounter(%id,$TradeSkillFarming);
	%nlvl = %lvl + 1;
	if (%lvl < $MaxTradeLevel) {
		%msg = %msg @ " (Exp: " @ %exp @ "/" @ $TradeExp[%nlvl] @ ")";
		//%prog = floor((%exp / $TradeExp[%nlvl]) * 100);
		//%msg = %msg @ " (" @ %prog @ "%)";
	}
	%msg = %msg @ "<n>";
	// Physical Crafting
	%lvl = GetTradeSkill(%id,$TradeSkillPhysCraft);
	%msg = %msg @ " PhysCraft - Level: " @ %lvl @ "";
	%exp = GetTradeCounter(%id,$TradeSkillPhysCraft);
	%nlvl = %lvl + 1;
	if (%lvl < $MaxTradeLevel) {
		%msg = %msg @ " (Exp: " @ %exp @ "/" @ $TradeExp[%nlvl] @ ")";
		//%prog = floor((%exp / $TradeExp[%nlvl]) * 100);
		//%msg = %msg @ " (" @ %prog @ "%)";
	}
	%msg = %msg @ "<n>";
	// Magical Crafting
	%lvl = GetTradeSkill(%id,$TradeSkillMagicCraft);
	%msg = %msg @ " MagicCraft - Level: " @ %lvl @ "";
	%exp = GetTradeCounter(%id,$TradeSkillMagicCraft);
	%nlvl = %lvl + 1;
	if (%lvl < $MaxTradeLevel) {
		%msg = %msg @ " (Exp: " @ %exp @ "/" @ $TradeExp[%nlvl] @ ")";
		//%prog = floor((%exp / $TradeExp[%nlvl]) * 100);
		//%msg = %msg @ " (" @ %prog @ "%)";
	}
	%msg = %msg @ "<n>";
	// Alchemy
	%lvl = GetTradeSkill(%id,$TradeSkillAlchemy);
	%msg = %msg @ " Alchemy - Level: " @ %lvl @ "";
	%exp = GetTradeCounter(%id,$TradeSkillAlchemy);
	%nlvl = %lvl + 1;
	if (%lvl < $MaxTradeLevel) {
		%msg = %msg @ " (Exp: " @ %exp @ "/" @ $TradeExp[%nlvl] @ ")";
		//%prog = floor((%exp / $TradeExp[%nlvl]) * 100);
		//%msg = %msg @ " (" @ %prog @ "%)";
	}
	BottomPrint(%id,%msg,10);
}

function CreateTradeLevels()
{
	$TradeExp[0] = 500;
	%i = 1;
	for (%i = 1; %i <= 120; %i++) {
		%exp = %i * 1000;
		%add = (%exp * (%i / 100));
		$TradeExp[%i] = floor(%exp + %add);
	}
}

CreateTradeLevels();

$TradeSkillSpeed = 10000.0;
$TradeSkillMinPer = 10.0;
$MaxTradeLevel = 50;

function UseTradeSkill(%id,%skill,%v)
{
	%class = FetchData(%id,"Class");
	%multi = $TradeMuli[%class,%skill];
	%v = %v * %multi;
	%v = floor(%v * $TradeSkillSpeed);
	%curlvl = GetTradeSkill(%id,%skill);
	%nlvl = %curlvl + 1;
	%lvlup = $TradeExp[%nlvl];
	%max = floor(%lvlup / $TradeSkillMinPer);
	if (%v > %max)
		%v = %max;
	if (%curlvl == $MaxTradeLevel) {
		%v = 0;
	}
	if (%v > 0) {
		Client::SendMessage(%id,0,"You gained " @ %v @ " experience in " @ $TradeToDisp[%skill] @ ".");
		UpdateTradeLevel(%id,%skill,%v);
	}
}

function UpdateTradeLevel(%id,%skill,%v)
{
	%curlvl = GetTradeSkill(%id,%skill);
	%nlvl = %curlvl + 1;
	%lvlup = $TradeExp[%nlvl];
	%counter = GetTradeCounter(%id,%skill);
	%need = %lvlup - %counter;
	%counter = %counter + %v;
	if (%counter >= %lvlup) {
		if (%v > %need) {
			%spill = %v - %need;
			$PlayerTradeCounter[%id,%skill] = %spill;
		}
		else {
			$PlayerTradeCounter[%id,%skill] = 0;
		}
		Client::SendMessage(%id,2,"You have gained a level in " @ $TradeToDisp[%skill] @ ". You are now level " @ %nlvl @ ".");
		$PlayerTradeSkill[%id,%skill]++;
	}
	else {
		$PlayerTradeCounter[%id,%skill] += %v;
	}
}

function GetTradeSkill(%id,%skill)
{
	return $PlayerTradeSkill[%id,%skill];
}

function GetTradeCounter(%id,%skill)
{
	return $PlayerTradeCounter[%id,%skill];
}

//-----------------------------------------------------------------------------------

// FIRE

function NearFire(%id) 
{
	if (fetchData(%id, "InSleepZone") == "")
		return False;
	else
		return True;
}

//-----------------------------------------------------------------------------------


// FISHING

function IsInFishSpot(%id) 
{
	%pos = GameBase::GetPosition(%id);
	%z = GetWord(%pos,2);
	if (%z <= 47)
		return 1;
	else
		return 0;
}

function WhatFishingGear(%id)
{
	%cur = $PlayerWear[%id,7];
	if (%cur != "") {
		if ($FishingGear[%cur]) {
			return %cur;
		}
		else
			return 0;
	}
	else
		return 0;
}

function FishingGearBonus(%gear)
{
	if ($FishingBonus[%gear] != "")
		return $FishingBonus[%gear];
	else
		return 0;
}

function GetFish(%fish,%zone)
{
	if (%zone == 1) {
		if (%fish >= 1 && %fish <= 3)
			return "SmallTrout";
		if (%fish >= 4 && %fish <= 6)
			return "Trout";
	}
}

function Fish(%id) 
{
	if ((%zone = IsInFishSpot(%id)) != 0) {
		if ((%b = FishingGearBonus(WhatFishingGear(%id))) != 0) {
			%s = GetTradeSkill(%id,$TradeSkillFishing);
			if (%s <= 25)
				%catch = 25;
			else
				%catch = %s;
			if (%catch > 75)
				%catch = 75;
			%iscatch = floor(getRandom() * 100 + 1);
			if (%iscatch <= %catch) {
				%t = %s + %b;
				%f = floor(getRandom() * %t + 1);
				echo(%t @ " " @ %f);
				%fish = GetFish(%f,%zone);
				Client::SendMessage(%id,2,"You caught a " @ $BPItem[%fish,$BPName] @ "!");
				GiveThisStuff(%id,%fish @ " 1");
				UseTradeSkill(%id,$TradeSkillFishing,%f);
			}
			else {
				Client::SendMessage(%id,2,"You failed to catch anything.");
				UseTradeSkill(%id,$TradeSkillFishing,1);
				return;
			}
		}
		else
			Client::SendMessage(%id,0,"You do not have anything to fish with equiped!");
	}
	else
		Client::SendMessage(%id,0,"You arn't near any fishing spots.");
}

//-----------------------------------------------------------------------------------

// FARMING

function UpdateWorldPlants()
{
	for (%cl = client::GetFirst(); %cl != -1; %cl = client::GetNext(%cl)) {
		for (%i = 1; %i <= 10; %i++) {
			%s = $PlayerPlant[%id,%i];
			if (%s != "-1") {
				%plant = getWord(%s,0);
				%x = getWord(%s,1);
				%y = getWord(%s,2);
				%z = getWord(%s,3);
				%health = getWord(%s,4);
				%water = getWord(%s,5);
				%growth = getWord(%s,6);
			}
		}
	}
}

//-----------------------------------------------------------------------------------

echo("__TRADESKILL LOADED");