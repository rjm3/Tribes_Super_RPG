// MAPS

$MAPMODS 	= "";
$MAPNUM		= 0;
$MaxMapWaves 	= 16;

$MAPAREA	= 1;
$MAPPLAYER	= 2;
$MAPMONSTER	= 3;

function AddMapMod(%mod,%a,%m,%code,%t)
{
	$MAPNUM++;
	$MapFormat[%code] 	= %mod;
	$MapRandom[%code] 	= %a;
	$MapMagic[%code] 	= %m;
	$MapModType[%code]	= %t;
	$MAPMODS = $MAPMODS @ %code @ " ";
}

// PLAYER MODS
AddMapMod("Reduced Player Resistance","20 30","10","RPR",$MAPPLAYER); 			// x
AddMapMod("Reduced Player Armor","20 30","10","RPA",$MAPPLAYER); 			// x
AddMapMod("Reduced Player Evasion","20 30","10","RPE",$MAPPLAYER); 			// x
AddMapMod("Reduced Player Health","10 20","15","RPH",$MAPPLAYER); 			// x
AddMapMod("Reduced Player Mana","10 20","15","RPM",$MAPPLAYER);				// x
AddMapMod("Players Have No Health Regeneration","NA","10","NHD",$MAPPLAYER);		// x
AddMapMod("Players Have No Mana Regeneration","NA","10","NMD",$MAPPLAYER);		// x
AddMapMod("Player Additional Mana Cost","20 30","15","IMC",$MAPPLAYER);			// x
AddMapMod("Players Can Not Life Steal","NA","10","NLS",$MAPPLAYER);			// x
AddMapMod("Players Can Not Spell Vamp","NA","10","NSV",$MAPPLAYER);			// x
AddMapMod("Player Additional Cooldown Time","20 30","15","ICD",$MAPPLAYER);		// x
AddMapMod("Players Deal Less Physical Damage","20 30","15","LPD",$MAPPLAYER);		// x
AddMapMod("Players Deal Less Magical Damage","20 30","15","LMD",$MAPPLAYER); 		// x
AddMapMod("Players Have Less Critical Hits","NA","20","NCH",$MAPPLAYER);		// x	
AddMapMod("Players Have Less Spell Critical Hits","NA","20","NSC",$MAPPLAYER);		// x
AddMapMod("Players Are Plagued","NA","30","ALP",$MAPPLAYER);				// x
AddMapMod("Players Are Chilled","NA","30","ALC",$MAPPLAYER);				// x
AddMapMod("Players Can Not Evade or Dodge Attacks","NA","30","NOE",$MAPPLAYER);		// x
AddMapMod("Players Can Not Resist Spells","NA","30","NOR",$MAPPLAYER);			// x
AddMapMod("Players Have Full Blood Magic","NA","30","BLD",$MAPPLAYER);			// x
AddMapMod("Players Have Full Mana Blood","NA","30","MAN",$MAPPLAYER);			// x
AddMapMod("Players Are Snared","NA","20","SNR",$MAPPLAYER);				// x
AddMapMod("Players Can Not Use Health Potions","NA","30","NHP",$MAPPLAYER);		// x
AddMapMod("Players Can Not Use Mana Potions","NA","30","NMP",$MAPPLAYER);		// x

// MONSTER MODS
AddMapMod("Additional Monster Resistance","20 30","10","IMR",$MAPMONSTER);		// x
AddMapMod("Additional Monster Armor","20 30","10","IMA",$MAPMONSTER);			// x
AddMapMod("Additional Monster Evasion","20 30","10","IME",$MAPMONSTER);			// x
AddMapMod("Additional Monster Health","20 30","15","IMH",$MAPMONSTER);			// x
AddMapMod("Monster Life Steal","20 30","15","MLS",$MAPMONSTER);				// x
AddMapMod("Monster Spell Vamp","20 30","15","MSV",$MAPMONSTER);				// x
AddMapMod("Additional Monster Cooldown Reduction","20 30","15","DMC",$MAPMONSTER);	// x
AddMapMod("Additional Monster Physical Damage","20 30","15","IMP",$MAPMONSTER);		// x
AddMapMod("Additional Monster Magical Damage","20 30","15","IMM",$MAPMONSTER);		// x
AddMapMod("Monsters Have More Critical Hits","NA","20","MAC",$MAPMONSTER);		// x	
AddMapMod("Monsters Have More Spell Critical Hits","NA","20","MAS",$MAPMONSTER);	// x
AddMapMod("Monsters Can Not Be Poisoned","NA","15","NOP",$MAPMONSTER);			// x
AddMapMod("Monsters Can Not Be Chilled","NA","15","NOC",$MAPMONSTER);			// x
AddMapMod("Monsters Can Not Be Rooted","NA","10","NRR",$MAPMONSTER);			// x
AddMapMod("Monsters Can Not Be Burned","NA","15","NIG",$MAPMONSTER);			// x
AddMapMod("Monsters Deal Arcane Damage","NA","30","MDA",$MAPMONSTER);			// x
AddMapMod("Monsters Teleport","NA","15","MTT",$MAPMONSTER);				// ???
AddMapMod("More Elite Monsters","NA","15","MEM",$MAPAREA);				// x				
AddMapMod("More Boss Monsters","NA","15","MBM",$MAPAREA);				// x
AddMapMod("Area Has Double Final Bosses","NA","20","TUB",$MAPAREA);			// x
AddMapMod("Monsters Can Not Be Stunned","NA","10","MNS",$MAPMONSTER);			// x
AddMapMod("Double Monsters","NA","20","DBM",$MAPAREA);					// x
AddMapMod("Monsters Reflect Damage","20 30","30","RFF",$MAPMONSTER);			// x
AddMapMod("Monsters Are Berserk","NA","30","BEK",$MAPMONSTER);				// x
AddMapMod("Monsters Have More Cast Speed","NA","30","MIS",$MAPMONSTER);			// x
AddMapMod("Area Has Hellish Lightning","NA","50","LIG",$MAPPLAYER);			// x

$MapTier[0] 	= "";
$MapTier[1] 	= "Cracked";
$MapTier[2] 	= "Chipped";
$MapTier[3] 	= "Flawed";
$MapTier[4] 	= "Flawless";
$MapTier[5] 	= "Glowing";
$MapTier[6] 	= "Radiant";

$MapName["MapStone"] 		= "Map Stone";
$MapName["CrackedMapStone"] 	= "Cracked Map Stone";
$MapName["ChippedMapStone"] 	= "Chipped Map Stone";
$MapName["FlawedMapStone"] 	= "Flawed Map Stone";
$MapName["FlawlessMapStone"]	= "Flawless Map Stone";
$MapName["GlowingMapStone"]	= "Glowing Map Stone";
$MapName["RadiantMapStone"]	= "Radiant Map Stone";

$MapNameToTier["MapStone"] 		= 0;
$MapNameToTier["CrackedMapStone"] 	= 1;
$MapNameToTier["ChippedMapStone"] 	= 2;
$MapNameToTier["FlawedMapStone"] 	= 3;
$MapNameToTier["FlawlessMapStone"]	= 4;
$MapNameToTier["GlowingMapStone"]	= 5;
$MapNameToTier["RadiantMapStone"]	= 6;

function BPCraft::MapUpgrade(%id,%map,%relic)
{
	%ql = string::getSubStr(%map,0,3);
	%crop = string::getSubStr(%map,3,999);
	%find = string::findSubStr(%crop,"!");
	%name = string::getSubStr(%crop,0,%find);
	%crop = string::getSubStr(%crop,%find+1,999);
	%find = string::findSubStr(%crop,"%");
	%mods = string::getSubStr(%crop,0,%find);
	%integ = string::getSubStr(%crop,%find+1,999);
	%tier = $MapNameToTier[%name];
	//echo(" NAME " @ %name);
	//echo(" MODS " @ %mods);
	//echo(" INTEG " @ %integ);
	//echo(" TIER " @ %tier);
	//==========================================================
	// CHECK FOR CORRECT RELIC
	if (%relic == "REGAL") { %mintier = 0; %maxtier = 3; %target = 4;}
	if (%relic == "COSMIC") { %mintier = 4; %maxtier = 4; %target = 5;}
	if (%relic == "HEROIC") { %mintier = 5; %maxtier = 5; %target = 6;}
	if (%tier > %maxtier || %tier < %mintier) {
		Client::SendMessage(%id,1,"These items will not work together.");
		ClearCraftTable(%id,0);
		return;
	}
	//==========================================================
}

function BPCraft::MapRandomize(%id,%map,%relic)
{
	//echo("BPCRAFT::MAPRANDOMIZE " @ %id @ " " @ %map @ " " @ %relic);
	%ql = string::getSubStr(%map,0,3);
	%crop = string::getSubStr(%map,3,999);
	%find = string::findSubStr(%crop,"!");
	%name = string::getSubStr(%crop,0,%find);
	%crop = string::getSubStr(%crop,%find+1,999);
	%find = string::findSubStr(%crop,"%");
	%mods = string::getSubStr(%crop,0,%find);
	%integ = string::getSubStr(%crop,%find+1,999);
	%tier = $MapNameToTier[%name];
	//echo(" NAME " @ %name);
	//echo(" MODS " @ %mods);
	//echo(" INTEG " @ %integ);
	//echo(" TIER " @ %tier);
	//==========================================================
	// CHECK FOR CORRECT RELIC
	if (%relic == "ALTERING") { %mintier = 0; %maxtier = 3; }
	if (%relic == "HAVOC") { %mintier = 4; %maxtier = 4; }
	if (%relic == "CHAOS") { %mintier = 5; %maxtier = 5; }
	if (%relic == "ANARCHY") { %mintier = 6; %maxtier = 6; }
	if (%tier > %maxtier || %tier < %mintier) {
		Client::SendMessage(%id,1,"These items will not work together.");
		ClearCraftTable(%id,0);
		return;
	}
	//==========================================================
	// UPGRADE ALTERING
	if (%relic == "ALTERING")
		%tier = 3;
	//==========================================================
	%ret = TierItem::RandomMap(%tier,floor(%ql));
	Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearCraftTable(%id,1); 
}

function TierItem::RandomMap(%t,%ql,%lt,%hard)
{
	//echo("TIERITEM::RANDOMMAP " @ %t @ " " @ %ql);
	if (%ql < 1 || %ql > 999) return;
	if (%t < 0 || %t > 6) return;
	if (%t == 6)
		%z = MTRB(6,8);
	else
		%z = %t;
	%mods = $MAPMODS;
	%n = $MAPNUM;
	%new = "";
	if (%t > 0) {
		for (%i = 1; %i <= %z; %i++) {
			%r = MTRB(1,%n);
			%g = getWord(%mods,%r - 1);
			%mapran = $MapRandom[%g];
			if (%mapran != "NA") {
				%x = getWord(%mapran,0);
				%y = getWord(%mapran,1);
				%mid = TierFormatValue(RandBetween(%x,%y));
			}
			else
				%mid = "000000";
			%new = %new @ %g @ %mid;
			%find = string::findSubStr(%mods,%g);
			%crop = string::getSubStr(%mods,0,%find);
			%end = string::getSubStr(%mods,(%find + 4),999);
			%mods = %crop @ %end;
			%n--;
		}
		%ret = FormatQL(%ql) @ $MapTier[%t] @ "MapStone" @ "!" @ %new @ "%10";
	}
	else {
		%ret = FormatQL(%ql) @ $MapTier[%t] @ "MapStone" @ "!" @ %new @ "%10";	
	}
	TierItem::CreateMap(%ret);
	return %ret;
}

function TierItem::CreateMap(%item)
{
	//echo("TIERITEM::CREATEMAP " @ %item);
	$BPItem[%item,$BPIsMap] = 1;
	//=============================================================
	// BREAK STRING
	%find = string::findSubStr(%item,"!");
	%main = string::getSubStr(%item,0,%find);
	%ql = string::getSubStr(%main,0,3);
	%name = string::GetSubStr(%main,3,999);
	%mods = string::getSubStr(%item,(%find + 1),999);
	%find = string::findSubStr(%mods,"%");
	%integ = string::getSubStr(%mods,(%find + 1),999);
	%mods = string::getSubStr(%mods,0,%find);
	%tier = $MapNameToTier[%name];
	//=============================================================
	// BREAK LIST
	%magic = 10;
	%newlist = "";
	%start = 0;
	for (%i = 1; %i <= 30; %i++) {
		%crop = string::GetSubStr(%mods,%start,9);
		if (%crop != "") {
			%code = string::getSubStr(%crop,0,3);
			%val = string::getSubStr(%crop,4,6) + 0;
			%newlist = %newlist @ %code @ " " @ %val @ " ";
			%magic += $MapMagic[%code];
		}
		%start += 9;
	}
	%magic += 50;
	$BPItem[%item,$BPItemType] = %tier @ " Map";
	$BPItem[%item,$BPName] = $MapName[%name];
	$BPItem[%item,$BPMapMods] = %newlist;
	$BPItem[%item,$BPMapMagic] = %magic;
	$BPItem[%item,$BPPrice] = round(%ql * (3 * (%tier + 1)));
	$BPItem[%item,$BPWeight] = 1;
	$BPItem[%item,$BPDesc] = "Using this stone will take you to a random area filled with deadly monsters";
	$BPItem[%item,$BPIsMap] = 1;
	$BPItem[%item,$BPCraftType] = "MAP";
	$BPItem[%item,$BPMaterial] = "Dust";
}

function FormatMapMods(%mods)
{
	%ret = "";
	for (%i = 0; (%n = getWord(%mods,%i)) != -1; %i+=2) {
		%v = getWord(%mods,%i+1);
		if (%v != 0)
			%ret = %ret @ " " @ $MapFormat[%n] @ " " @ %v @ "% \n";
		else
			%ret = %ret @ " " @ $MapFormat[%n] @ " \n";
	}
	return %ret;
}

function TestMap(%id,%tier,%lvl)
{
	if (%id == "") %id = 2049;
	if (%tier == "") %tier = 6;
	if (%lvl == "") %lvl = 1;
	%item = TierItem::RandomMap(%tier,%lvl);
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ %item @ " 1 ";
}

function InitMaps()
{
	$UNUSEDMAPS = "";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FOREST1 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FOREST2 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FOREST3 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FOREST4 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "DESERT1 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "DESERT2 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "DESERT3 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "DESERT4 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "JUNGLE1 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "JUNGLE2 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "JUNGLE3 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "JUNGLE4 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FROZEN1 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FROZEN2 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FROZEN3 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FROZEN4 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "FROZEN5 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "LAVA1 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "LAVA2 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "LAVA3 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "LAVA4 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "LAVA5 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "ARCANE1 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "ARCANE2 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "ARCANE3 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "ARCANE4 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "ARCANE5 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "HELL1 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "HELL2 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "HELL3 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "HELL4 ";
	$UNUSEDMAPS = $UNUSEDMAPS @ "HELL5 ";
	$ALLMAPS = $UNUSEDMAPS;
	$UNUSEDMAPS = String::Shuffle($UNUSEDMAPS);
	$ACTIVEMAPS = 0;
	for (%i = 1; %i <= 32; %i++)
		$CRUMAP[%i] = "";
	LoadMaps();
}

function ShowMap(%clientId,%active)
{
	if (%active == "") {
		%active = HasActiveMap(%clientId);
		if (%active == -1)
			return;
	}
	%v = $CRUMAP[%active];
	%map = GetWord(%v,0);
	%waves = GetWord(%v,1);
	%owner = GetWord(%v,2);
	%zone = GetWord(%v,3);
	%msg = WhatIs(%map,%clientId);
	%msg = %msg @ "\n";
	%msg = %msg @ "Zone: " @ $ZoneInfo[%zone,$ZoneDisp] @ "\n";
	%msg = %msg @ "Waves Remaining: " @ %waves @ " of " @ $MaxMapWaves @ "\n";
	%msg = %msg @ "Owner: " @ %owner @ "\n";
	%msg = %msg @ "Timer: " @ $MAPTIMER[%active];
	SendBufferBP(%clientId, %msg, floor(String::len(%msg) / 15));
	Game::MenuRequest(%clientId);
}

function UseMapPortal(%id)
{
	%active = HasActiveMap(%id);
	if (%active == -1) {
		Client::SendMessage(%id,0,"You do not have an active map.");
		return;
	}
	%v = $CRUMAP[%active];
	%zone = GetWord(%v,3);
	StoreData(%id,"zone",%zone);
	Client::SendMessage(%id,2,"You have entered " @ GetZoneData($ZoneInfo[%zone,$ZoneEnter],$ZoneDisp) @ ".");
	GameBase::SetPosition(%id,$CRUZONE[%zone,$CZMapStart]);
	Game::refreshClientScore(%id);
	AddMapBonus(%id,%zone,$MAPPLAYER);
}

function LeaveMap(%id)
{
	%zone = fetchData(%id,"zone");
	if ($CRUZONE[%zone,$CZType] != $CZMap)
		return;
	%exit = $MAPEXIT;
	StoreData(%id,"zone",%exit);
	Client::SendMessage(%id,0,"You leave the map.");
	Client::SendMessage(%id,2,"You have entered " @ $ZoneInfo[%exit,$ZoneDisp] @ ".");
	GameBase::SetPosition(%id,$MAPDEATHPOS);
	Game::refreshClientScore(%id);
	ClearMapBonus(%id);
}

function ClearMap(%rem)
{
	//echo(" CLEARMAP " @ %rem);
	%string = $CRUMAP[%rem];
	%m = GetWord(%string,0);
	%w = GetWord(%string,1);
	%o = GetWord(%string,2);
	%z = GetWord(%string,3);
	ClearMapBonus(%z);
	MessageAll(2,"Map #" @ %rem @ " has been Deactivated. Zone: " @ $ZoneInfo[%z,$ZoneDisp] @ ", Waves: " @ %w @ ", Owner: " @ %o);
	$UNUSEDMAPS = $UNUSEDMAPS @ %zone @ " ";
	%x = 0;
	for (%i = 1; %i <= $ACTIVEMAPS; %i++) {
		if (%rem != %i) {
			%x++;
			%n[%x] = $CRUMAP[%i];
		}
	}
	for (%i = 1; %n[%i] != ""; %i++) {
		%g = %n[%i];
		$CRUMAP[%i] = %g;
		%zone = getWord(%g,3);
		$CURRENTCRUMAP[%zone] = %i;
	}
	for (%i = 32; %i > %x; %i--)
		$CRUMAP[%i] = "";
	$ACTIVEMAPS--;
	savemaps();
}

function HasActiveMap(%id)
{
	if ($ACTIVEMAPS == 0)
		return -1;
	if ((%team = PlayerIsInTeam(%id)) != -1)
		%lid = GetTeamLeader(%team);
	else
		%lid = %id;
	for (%i = 1; %i <= $ACTIVEMAPS; %i++) {
		%o = getWord($CRUMAP[%i],2);
		if (client::GetName(%lid) == %o)
			return %i;
	}
	return -1;
}

function SaveMaps()
{
	File::delete("temp\\mapsave_" @ $CURRENTCRUMAP @ ".cs");
	if ($ACTIVEMAPS == 0)
		return;
	export("CRUMAP*", "temp\\mapsave_" @ $CURRENTCRUMAP @ ".cs", false);
}

function LoadMaps()
{
	exec("mapsave_" @ $CURRENTCRUMAP @ ".cs");
	for (%i = 1; (%v = $CRUMAP[%i]) != ""; %i++) {
		%map = GetWord(%v,0);
		DynamicItem::InitWear(%map);
		%waves = GetWord(%v,1);
		%owner = GetWord(%v,2);
		%zone = GetWord(%v,3);
		$ACTIVEMAPS++;
		$UNUSEDMAPS = String::Remove($UNUSEDMAPS,%zone);
		%lvl = String::GetSubStr(%map,0,3);
		%lvl = %lvl + 0;
		$CRUZONE[%zone,$CZMapLvl] = %lvl;
		$CRUZONE[%zone,$CZMapWaves] = %waves;
		$CRUZONE[%zone,$CZMapOwner] = %owner;
		$CRUZONE[%zone,$CZMapMagic] = $BPItem[%map,$BPMapMagic];
		$CRUZONE[%zone,$CZMap] = %map;
		%a = $ACTIVEMAPS;
		$CURRENTCRUMAP[%zone] = %a;
		$MAPTIMER[%a] = 120;
		CreateMapZoneMods(%zone,%map);
		AddMapBonus(%zone,%zone,$MAPAREA);
	}
}

function RefreshActiveMap(%zone)
{
	%a = $CURRENTCRUMAP[%zone];
	$CRUMAP[%a] = $CRUZONE[%zone,$CZMap] @ " " @ $CRUZONE[%zone,$CZMapWaves] @ " " @ $CRUZONE[%zone,$CZMapOwner] @ " " @ %zone;	
	SaveMaps();
}

function ActivateMap(%id,%map)
{
	if ($ACTIVEMAPS >= 31) {
		Client::SendMessage(%id,0,"There are too many active maps.");
		return;
	}	
	if ($BPItem[%map,$BPIsMap] == 1) {
		if (HasActiveMap(%id) == -1) {
			$ACTIVEMAPS++;
			%lvl = String::GetSubStr(%map,0,3);
			%lvl = %lvl + 0;
			%uu = String::Shuffle($UNUSEDMAPS);
			%zone = GetWord(%uu,0);
			$UNUSEDMAPS = String::Remove($UNUSEDMAPS,%zone);
			$CRUZONE[%zone,$CZMap] = %map;
			$CRUZONE[%zone,$CZMapLvl] = %lvl;
			$CRUZONE[%zone,$CZMapWaves] = $MaxMapWaves;
			$CRUZONE[%zone,$CZMapOwner] = Client::GetName(%id);
			$CRUZONE[%zone,$CZMapMagic] = $BPItem[%map,$BPMapMagic];
			CreateMapZoneMods(%zone,%map);
			%a = $ACTIVEMAPS;
			$CRUMAP[%a] = %map @ " " @ $MaxMapWaves @ " " @ client::GetName(%id) @ " " @ %zone;
			$CURRENTCRUMAP[%zone] = %a;
			$MAPTIMER[%a] = 120;
			Client::SendMessage(%id,2,"You have activated " @ $BPItem[%map,$BPName] @ ".");
			MessageAll(3,"Map #" @ %a @ " has been Activated. Zone: " @ $ZoneInfo[%zone,$ZoneDisp] @ ", Waves: " @ $MaxMapWaves @ ", Owner: " @ Client::GetName(%id));
			AddMapBonus(%zone,%zone,$MAPAREA);
			RemoveFromBackpack(%id,%map,-1);
			SaveMaps();
		}
		else
			Client::SendMessage(%id,0,"You already have an active map.");	
	}
	else
		Client::SendMessage(%id,0,"This item is not a map.");	
}

function CreateMapZoneMods(%zone,%map)
{
	$CRUZONE[%zone,$CZAreaMods] = "";
	$CRUZONE[%zone,$CZPlayerMods] = "";
	$CRUZONE[%zone,$CZMonsterMods] = "";
	%mods = string::getWord(%map,"!",1);
	%mods = string::getWord(%mods,"%",0);
	%start = 0;
	for (%i = 1; %i <= 30; %i++) {
		%s[%i] = string::GetSubStr(%mods,%start,9);
		%start += 9;
	}
	for (%i = 1; %i <= 30; %i++) {
		if ((%g = %s[%i]) != "") {
			%m = string::getSubStr(%g,0,3);
			%v = string::getSubStr(%g,4,6);
			%v = %v + 0;
			if ($MapModType[%m] == $MAPPLAYER)
				$CRUZONE[%zone,$CZPlayerMods] = $CRUZONE[%zone,$CZPlayerMods] @ %m @ " " @ %v @ " ";
			if ($MapModType[%m] == $MAPMONSTER)
				$CRUZONE[%zone,$CZMonsterMods] = $CRUZONE[%zone,$CZMonsterMods] @ %m @ " " @ %v @ " ";
			if ($MapModType[%m] == $MAPAREA)
				$CRUZONE[%zone,$CZAreaMods] = $CRUZONE[%zone,$CZAreaMods] @ %m @ " " @ %v @ " ";		
		}
	}
}

function AddMapBonus(%id,%zone,%t)
{
	if (%t == $MAPAREA) %s = $CRUZONE[%zone,$CZAreaMods];
	if (%t == $MAPPLAYER) %s = $CRUZONE[%zone,$CZPlayerMods];
	if (%t == $MAPMONSTER) %s = $CRUZONE[%zone,$CZMonsterMods];
	for (%i = 0; (%g = getWord(%s,%i)) != -1; %i+=2) {
		%v = getWord(%s,%i+1);
		if (%g == "SNR") SnarePlayer(%id);
		$MapBonus[%id,%g] = %v;
		//echo(" ADDMAPBONUS " @ %id @ " " @ %zone @ " " @ %t @ " " @ %g @ " " @ %v);	
	}	
}

function ClearMapBonus(%id)
{
	if ($MapBonus[%id,"SNR"] != "")
		UnSnarePlayer(%id);
	for (%i = 0; (%g = getWord($MAPMODS,%i)) != -1; %i++)
		$MapBonus[%id,%g] = "";
}

function GetMapBonus(%id,%bonus,%ai)
{
	if ((%b = $MapBonus[%id,%bonus]) != "")
		return %b;
	else
		return -1;
}

echo("__MAPS LOADED");