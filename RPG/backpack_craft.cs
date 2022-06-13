// BACKPACK CRAFT

$BPCombine 		= 1;
$BPCombineReq 		= 2;
$BPCombineRes 		= 3;
$BPCombineResBonus 	= 4;
$BPComineRangeRule	= 5;

function Game::MenuCraft(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Crafting Table", "craft", true);
	if (%id.CraftBase != "") 
		Client::addMenuItem(%id, %curItem++ @ GetBPData(%id.CraftBase,$BPName),%id.CraftBase);
	if (%id.CraftAdditions != "") 
		Client::addMenuItem(%id, %curItem++ @ GetBPData(%id.CraftAdditions,$BPName),%id.CraftAdditions);
	if (%id.CraftAdditions != "" && %id.CraftBase != "")
		Client::addMenuItem(%id, %curItem++ @ "Complete...","complete");
	if (%id.CraftAdditions != "" || %id.CraftBase != "")
		Client::addMenuItem(%id, %curItem++ @ "Clear...","clear");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function processMenucraft(%id, %option)
{
	if (%option == "back") {
		Game::MenuRequest(%id);
		return;
	}
	if (%option == "clear") {
		ClearCraftTable(%id);
		Game::MenuRequest(%id);
		return;
	}
	if (%option == "complete") {
		BPCraft(%id);
		return;
	}
	else {
		%msg = WhatIs(%option);
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
		Game::MenuCraft(%id);
	}
}

function BPCraftEssence(%id,%base,%qlbase,%mix,%qlmix)
{
	// REMOVED
	return true;
}

function BPAutoBuildEssence(%full,%type,%insert,%slot0,%slot1,%slot2,%ql,%new,%id)
{
	// REMOVED
	return true;
}

function BPCraft(%id)
{
	%base = %id.CraftBase;
	%mix = %id.CraftAdditions;
	if (%base == "" || %mix == "") return;
	// SPELLCRYSTAL
	else if ($BPItem[%base,$BPCraftType] == "SPELLBOOK") { BPCraft::SpellCrystal(%id,%base,%mix); return; }
	else if ($BPItem[%mix,$BPCraftType] == "SPELLBOOK") { BPCraft::SpellCrystal(%id,%mix,%base); return; }
	// INTEG
	else if ($BPItem[%base,$BPCraftType] == "ARMOURSCRAP") { BPCraft::IntegrityUpgrade(%id,%mix,"AMR"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "ARMOURSCRAP") { BPCraft::IntegrityUpgrade(%id,%base,"AMR"); return; }
	else if ($BPItem[%base,$BPCraftType] == "SPOOLOFTHREAD") { BPCraft::IntegrityUpgrade(%id,%mix,"EVA"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "SPOOLOFTHREAD") { BPCraft::IntegrityUpgrade(%id,%base,"EVA"); return; }
	else if ($BPItem[%base,$BPCraftType] == "PIECEOFCLOTH") { BPCraft::IntegrityUpgrade(%id,%mix,"RES"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "PIECEOFCLOTH") { BPCraft::IntegrityUpgrade(%id,%base,"RES"); return; }
	else if ($BPItem[%base,$BPCraftType] == "SHARPENINGSTONE") { BPCraft::IntegrityUpgrade(%id,%mix,"WPN"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "SHARPENINGSTONE") { BPCraft::IntegrityUpgrade(%id,%base,"WPN"); return; }
	else if ($BPItem[%base,$BPCraftType] == "MAGICSTONE") { BPCraft::IntegrityUpgrade(%id,%mix,"STF"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "MAGICSTONE") { BPCraft::IntegrityUpgrade(%id,%base,"STF"); return; }
	// RELIC RANDOMIZE
	else if ($BPItem[%base,$BPCraftType] == "ALTERING") { BPCraft::RelicRandomize(%id,%mix,"ALTERING"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "ALTERING") { BPCraft::RelicRandomize(%id,%base,"ALTERING"); return; }
	else if ($BPItem[%base,$BPCraftType] == "HAVOC") { BPCraft::RelicRandomize(%id,%mix,"HAVOC"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "HAVOC") { BPCraft::RelicRandomize(%id,%base,"HAVOC"); return; }
	else if ($BPItem[%base,$BPCraftType] == "CHAOS") { BPCraft::RelicRandomize(%id,%mix,"CHAOS"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "CHAOS") { BPCraft::RelicRandomize(%id,%base,"CHAOS"); return; }
	else if ($BPItem[%base,$BPCraftType] == "ANARCHY") { BPCraft::RelicRandomize(%id,%mix,"ANARCHY"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "ANARCHY") { BPCraft::RelicRandomize(%id,%base,"ANARCHY"); return; }
	// RELIC UPGRADE
	else if ($BPItem[%base,$BPCraftType] == "REGAL") { BPCraft::RelicUpgrade(%id,%mix,"REGAL"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "REGAL") { BPCraft::RelicUpgrade(%id,%base,"REGAL"); return; }
	else if ($BPItem[%base,$BPCraftType] == "COSMIC") { BPCraft::RelicUpgrade(%id,%mix,"COSMIC"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "COSMIC") { BPCraft::RelicUpgrade(%id,%base,"COSMIC"); return; }
	else if ($BPItem[%base,$BPCraftType] == "HEROIC") { BPCraft::RelicUpgrade(%id,%mix,"HEROIC"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "HEROIC") { BPCraft::RelicUpgrade(%id,%base,"HEROIC"); return; }
	// SCOURING
	else if ($BPItem[%base,$BPCraftType] == "SCOURING") { BPCraft::RelicScour(%id,%mix,"SCOURING"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "SCOURING") { BPCraft::RelicScour(%id,%base,"SCOURING"); return; }
	// BLESSED
	else if ($BPItem[%base,$BPCraftType] == "BLESSED") { BPCraft::RelicUpgrade(%id,%mix,"BLESSED"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "BLESSED") { BPCraft::RelicUpgrade(%id,%base,"BLESSED"); return; }
	// MYSTIC
	else if ($BPItem[%base,$BPCraftType] == "MYSTIC") { BPCraft::RelicMystic(%id,%mix); return; }
	else if ($BPItem[%mix,$BPCraftType] == "MYSTIC") { BPCraft::RelicMystic(%id,%base); return; }
	// RUNE
	else if ($BPItem[%base,$BPCraftType] == "RUNE") { BPCraft::Rune(%id,%base,%mix); return; }
	else if ($BPItem[%mix,$BPCraftType] == "RUNE") { BPCraft::Rune(%id,%mix,%base); return; }
	// PRISM
	else if ($BPItem[%base,$BPCraftType] == "PRISM") { BPCraft::RelicMystic(%id,%mix,1); return; }
	else if ($BPItem[%mix,$BPCraftType] == "PRISM") { BPCraft::RelicMystic(%id,%base,1); return; }
	// DIVINE
	else if ($BPItem[%base,$BPCraftType] == "DIVINE") { BPCraft::RelicRandomize(%id,%mix,"DIVINE"); return; }
	else if ($BPItem[%mix,$BPCraftType] == "DIVINE") { BPCraft::RelicRandomize(%id,%base,"DIVINE"); return; }
	// DAMAGESTONE
	else if ($BPItem[%base,$BPCraftType] == "DAMAGESTONE") { BPCraft::DamageStone(%id,%base,%mix); return; }
	else if ($BPItem[%mix,$BPCraftType] == "DAMAGESTONE") { BPCraft::DamageStone(%id,%mix,%base); return; }
	else {
		Client::SendMessage(%id,2,"These items will not work together. 0x");
		ClearCraftTable(%id,0);
		return;
	}
}

function GetMysticStat(%id,%i)
{
	if (%id.Mystic[%i] == "") return "none";
	else {
		%full = %id.Mystic[%i];
		%mod = string::getSubStr(%full,0,3);
		%val = string::getSubStr(%full,4,6);
		if (%mod == "SOK")
			return "Socket";
		else
			return BPFormat($BPMOD[%mod] @ " " @ BPStripPlus(%val));
	}
}

function Game::MenuMystic(%id)
{
	%curItem = 0;
	if (%id.RunePrism != 1) Client::buildMenu(%id, "Choose a modifier to roll:", "mystic", true);
	else Client::buildMenu(%id, "Choose a modifier to socket:", "mystic", true);
	for (%i = 0; %i <= 30; %i++) {
		if (%id.Mystic[%i] != "")
			Client::addMenuItem(%id,GetMenuNum(%curItem++) @ GetMysticStat(%id,%i),%i);
	}
	Client::addMenuItem(%id, "p" @ "<< Cancel","back");
}

function processMenumystic(%id, %option)
{
	if (%option == "back") {
		ClearCraftTable(%id);
		ClearMysticRelic(%id);
		Game::MenuRequest(%id);
		return;
	}
	else {
		%check = %id.Mystic[%option];
		if (%check == "") {
			Client::SendMessage(%id,1,"Not a valid option.");
			ClearCraftTable(%id,0);
			ClearMysticRelic(%id);
			Game::MenuBackpack(%id,0);
			return;
		}
		%mod = string::getSubStr(%check,0,3);
		if (%mod == "SOK" && %id.RunePrism == 1) {
			Client::SendMessage(%id,1,"This property is already a socket.");
			ClearCraftTable(%id,0);
			ClearMysticRelic(%id);
			Game::MenuBackpack(%id,0);
			return;
		}		
		MysticComplete(%id,%option);
	}
}

function BPValPlus(%val)
{
	if ((%l = string::findSubStr(%val,"+")) != -1) {
		%g = string::getSubStr(%val,(%l+1),6);
		return "+" @ %g;
	}
	else if ((%l = string::findSubStr(%val,"$")) != -1) {
		%g = string::getSubStr(%val,(%l+1),6);
		return "$" @ %g;
	}
	else 
		return %val + 0;
}

function MysticComplete(%id,%remove)
{
	%newlist = "";
	%n = 0;
	for (%i = 0; %i <= 30; %i++) {
		if (%id.Mystic[%i] != "") {
			%n++;
			%full = %id.Mystic[%i];
			%mod = string::getSubStr(%full,0,3);
			%val = string::getSubStr(%full,3,6);
			if (%i != %remove) {
				%newlist = %newlist @ $BPMOD[%mod] @ " " @ BPValPlus(%val) @ " ";
			}
		}
	}
	%newbase = %id.MysticName;
	%ql = %id.MysticQual;
	%tperc = %id.MysticPerc;
	%tier = %id.MysticTier;
	%main = %id.MysticMain;
	if (%id.RunePrism)
		%newlist = %newlist @ "SOCKET 1 ";
	%ret = TierItem::RandomItem(%newbase,%ql,%tperc,%newlist,%tier,%main,1,%n);
	Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearCraftTable(%id,1);
	ClearMysticRelic(%id);
}

function ClearMysticRelic(%id)
{
	for (%i = 0; %i <= 30; %i++)
		%id.Mystic[%i] = "";
	%id.MysticName = "";
	%id.MysticQual = "";
	%id.MysticPerc = "";
	%id.MysticTier = "";
	%id.MysticMain = "";
	%id.RunePrism = "";
}

function testperc(%new)
{
	%plus = 0;
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	if ((%l = string::findSubStr(%tperc,"+")) != -1) {
		%tperc = string::GetSubStr(%tperc,0,%l);
		%plus = 1;
	}
	echo("TPERC " @ %tperc @ " " @ %plus);
}

$RuneReqSL[Strength] 		= 0;
$RuneReqSL[Stamina] 		= 4;
$RuneReqSL[Agility] 		= 8;
$RuneReqSL[Sense] 		= 12;
$RuneReqSL[Psychic] 		= 16;
$RuneReqSL[Intelligence] 	= 20;

function BPFixDecimals(%n)
{
	if (%n == "1.0") return "1.0";
	if (string::findSubStr(%n,".") == -1)
		%n = %n @ ".0";
	%f = string::findSubStr(%n,".");
	%x = string::getSubStr(%n,0,%f);
	%d = string::getSubStr(%n,(%f+1),2);
	if (%d != 0) %d = %d + 1;
	else %d = "0";
	if (%x < 10) return %x @ "." @ string::getSubStr(%d,0,1);
	else return %x @ "." @ string::getSubStr(%d,0,1);
}

function BPCraft::DamageStone(%id,%rune,%new)
{
	echo("----------------------------------------------------------------------------------------------------------------------------");
	echo("BP CRAFT: DAMAGE STONE " @ %stone @ " " @ %new);
	Client::SendMessage(%id,2,"Attempting to insert the Damage Stone..");
	if ($BPItem[%new,$BPNumSockets] < 1) {
		Client::SendMessage(%id,1,"No unused sockets available.");
		ClearCraftTable(%id,0);
		return;
	}
	Client::SendMessage(%id,2,"Socket Found.");
	
	%location = $BPItem[%new,$BPItemType];
	%location = getWord(%location,1);
	if (%location != "Weapon") {
		Client::SendMessage(%id,1,"Damage Stones can only be used in physical Weapons.");
		ClearCraftTable(%id,0);
		return;
	}

	// BREAK NEW
	//==========================================================
	// MAIN
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),9);
	//==========================================================
	// NAME
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	//==========================================================
	// QL
	%qlhard = floor(string::GetSubStr(%new,0,3));
	%ql = %qlhard + 0;
	//==========================================================
	// TPERC
	%plus = "";
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	%plen = string::len(%tperc) + 1;
	if ((%l = string::findSubStr(%tperc,"+")) != -1) {
		%plen = string::len(%tperc) + 1;
		%plus = string::getSubStr(%tperc,(%l + 1),99);
		%tperc = string::GetSubStr(%tperc,0,%l);
	}
	//==========================================================
	// SREQ
	%sreq = $DynamicItem[%name,$DReq];
	//==========================================================
	// CROPPARTS
	%find = string::FindSubStr(%new,"^");
	%perc = (%tperc / 100) + 1;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));
	//==========================================================
	// TIER
	%x = $DynamicItem[%name,$DItemType];
	%tier = getWord(%x,0);
	%itemtype = getWord(%x,1);
	//==========================================================
	// BREAK DOWN VALS 
	%start = 0;
	for (%i = 1; %i <= 30; %i++) {
		%s[%i] = string::GetSubStr(%cropparts,%start,9);
		%start += 9;
	}
	//==========================================================

	%runemod = $BPItem[%rune,$BPDamageStone];
	echo("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~> RUNE MOD " @ %runemod);
	%runecode = $BPCODE[%runemod];
	%runeval = 1;
	%endrune = %runemod @ " +" @ %runeval;
	Client::sendMessage(%id,0,"Rune Insert: " @ %endrune);
	//==========================================================
	// CHECK FOR DAMAGE TYPE
	for (%i = 1; %i <= 30; %i++) {
		%g = %s[%i];
		%p = string::getSubStr(%g,0,3);
		if (%p == "DDF" || %p == "DDC" || %p == "DDP" || %p == "DDE" || %p == "DDA") {
			Client::SendMessage(%id,1,"This item already has a damage mod.");
			ClearCraftTable(%id,0);
			return;
		}
	}
	//==========================================================
	// BREAK LIST
	%sokfound = 0;
	%newlist = "";
	for (%i = 1; %i <= 30; %i++) {
		if (%s[%i] != "") {
			%g = %s[%i];
			%p = string::getSubStr(%g,0,3);
			if (%p == "SOK" && %sokfound == 0) {
				%newlist = %newlist @ %endrune @ " ";
				%sokfound = 1;
			}
			else {
				%g = %s[%i];
				%p = string::getSubStr(%g,0,3);
				%v = string::getSubStr(%g,3,6);
				%newlist = %newlist @ $BPMOD[%p] @ " " @ BPValPlus(%v) @ " ";
			}
		}
	}
	//==========================================================
	%ret = TierItem::RandomItem(%name,%ql,%tperc,%newlist,%tier,%main,0,%plus);
	Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearCraftTable(%id,1);
	echo("----------------------------------------------------------------------------------------------------------------------------");
}

function BPCraft::Rune(%id,%rune,%new)
{
	echo("BP CRAFT: RUNE " @ %rune @ " " @ %new);
	Client::SendMessage(%id,2,"Attempting to insert the rune..");
	if ($BPItem[%new,$BPNumSockets] < 1) {
		Client::SendMessage(%id,1,"No unused sockets available.");
		ClearCraftTable(%id,0);
		return;
	}
	Client::SendMessage(%id,2,"Socket Found.");

	%location = $BPItem[%new,$BPItemType];
	%location = getWord(%location,1);
	%runeloc = $BPItem[%rune,$BPRuneLoc];
	if (%runeloc != %location) {
		Client::SendMessage(%id,1,"This rune will not work with this item.");
		ClearCraftTable(%id,0);
		return;
	}

	// BREAK NEW
	//==========================================================
	// MAIN
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),9);
	//==========================================================
	// NAME
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	//==========================================================
	// QL
	%qlhard = floor(string::GetSubStr(%new,0,3));
	%ql = %qlhard + 0;
	//==========================================================
	// TPERC
	%plus = "";
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	%plen = string::len(%tperc) + 1;
	if ((%l = string::findSubStr(%tperc,"+")) != -1) {
		%plen = string::len(%tperc) + 1;
		%plus = string::getSubStr(%tperc,(%l + 1),99);
		%tperc = string::GetSubStr(%tperc,0,%l);
	}
	//==========================================================
	// SREQ
	%sreq = $DynamicItem[%name,$DReq];
	//==========================================================
	// CROPPARTS
	%find = string::FindSubStr(%new,"^");
	%perc = (%tperc / 100) + 1;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));
	//==========================================================
	// TIER
	%x = $DynamicItem[%name,$DItemType];
	%tier = getWord(%x,0);
	%itemtype = getWord(%x,1);
	//==========================================================
	// BREAK DOWN VALS 
	%start = 0;
	for (%i = 1; %i <= 30; %i++) {
		%s[%i] = string::GetSubStr(%cropparts,%start,9);
		%start += 9;
	}
	//==========================================================
	// BREAK RUNE
	%runeql = floor(string::GetSubStr(%rune,0,3));
	%runeql = %runeql + 0;
	if ((%runeql * 0.8) > %ql) {
		Client::SendMessage(%id,1,"The rune is of too high quality level for this item.");
		ClearCraftTable(%id,0);
		return;
	}
	if (%runeql < (%ql * 0.8)) {
		Client::SendMessage(%id,1,"This rune is not high enough quality to socket into this item.");
		ClearCraftTable(%id,0);
		return;
	}
	%runebonus = $BPItem[%rune,$BPRuneBonus];
	%runemod = getWord(%runebonus,0);
	%runecode = $BPCODE[%runemod];
	%runeval = getWord(%runebonus,1);
	%endrune = %runemod @ " +" @ %runeval;
	Client::sendMessage(%id,0,"Rune Insert: " @ %endrune);
	//==========================================================
	// CHECK FOR DUPLICATE
	for (%i = 1; %i <= 30; %i++) {
		%g = %s[%i];
		%p = string::getSubStr(%g,0,3);
		if (%p == %runecode) {
			Client::SendMessage(%id,1,"This item already has this mod.");
			ClearCraftTable(%id,0);
			return;
		}
	}
	//==========================================================
	// BREAK LIST
	%sokfound = 0;
	%newlist = "";
	for (%i = 1; %i <= 30; %i++) {
		if (%s[%i] != "") {
			%g = %s[%i];
			%p = string::getSubStr(%g,0,3);
			if (%p == "SOK" && %sokfound == 0) {
				%newlist = %newlist @ %endrune @ " ";
				%sokfound = 1;
			}
			else {
				%g = %s[%i];
				%p = string::getSubStr(%g,0,3);
				%v = string::getSubStr(%g,3,6);
				%newlist = %newlist @ $BPMOD[%p] @ " " @ BPValPlus(%v) @ " ";
			}
		}
	}
	// Client::SendMessage(%id,2,"NEWLIST: <" @ %newlist @ "> NAME:" @ %name);
	//==========================================================
	%ret = TierItem::RandomItem(%name,%ql,%tperc,%newlist,%tier,%main,0,%plus,%runecode);
	//Client::sendMessage(%id,1,%ret);
	Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearCraftTable(%id,1);
}

function BPCraft::RelicMystic(%id,%new,%prism)
{
	echo(" BP CRAFT: RELIC MYSTIC " @ %new);
	//==========================================================
	// MAIN
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),9);
	//==========================================================
	// NAME
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	//==========================================================
	// QL
	%qlhard = floor(string::GetSubStr(%new,0,3));
	%ql = %qlhard + 0;
	//==========================================================
	// TPERC
	%plus = 0;
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	if ((%l = string::findSubStr(%tperc,"+")) != -1) {
		%tperc = string::GetSubStr(%tperc,0,%l);
		%plus = 1;
	}
	//==========================================================
	// SREQ
	%sreq = $DynamicItem[%name,$DReq];
	//==========================================================
	// CROPPARTS
	%find = string::FindSubStr(%new,"^");
	%plen = (string::len(%tperc) + 1);
	%perc = (%tperc / 100) + 1;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));
	//==========================================================
	// TIER
	%x = $DynamicItem[%name,$DItemType];
	%tier = getWord(%x,0);
	%itemtype = getWord(%x,1);
	//==========================================================
	echo(" MAIN:" @ %main @ " NAME:" @ %name @ " QL:" @ %ql @ " TPERC:" @ %tperc @ " SREQ:" @ %sreq @ " CROPPARTS:" @ %cropparts @ " TIER:" @ %tier);
	//==========================================================
	// CHECK FOR CORRECT RELIC
	if (%tier < 1 || %tier > 6) {
		Client::SendMessage(%id,1,"These items will not work together. 1x");
		ClearCraftTable(%id,0);
		return;
	}
	//==========================================================
	// BREAK DOWN VALS 
	%start = 0;
	for (%i = 1; %i <= 30; %i++) {
		%s[%i] = string::GetSubStr(%cropparts,%start,9);
		%start += 9;
	}
	// BREAK LIST
	%newlist = "";
	for (%i = 1; %i <= 30; %i++) {
		if (%s[%i] != "") {
			%id.Mystic[%i] = %s[%i];
		}
	}
	%id.MysticName = %name;
	%id.MysticQual = %ql;
	%id.MysticPerc = %tperc;
	%id.MysticTier = %tier;
	%id.MysticMain = %main;
	if (%prism == 1) %id.RunePrism = 1;
	//==========================================================
	// BRING UP THE MYSTIC MENU
	Game::MenuMystic(%id);
}

function BPCraft::RelicScour(%id,%new)
{
	echo(" BP CRAFT: RELIC SCOUR " @ %new);
	//==========================================================
	// MAIN
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),9);
	//==========================================================
	// NAME
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	//==========================================================
	// QL
	%qlhard = floor(string::GetSubStr(%new,0,3));
	%ql = %qlhard + 0;
	//==========================================================
	// TPERC
	%plus = 0;
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	if ((%l = string::findSubStr(%tperc,"+")) != -1) {
		%tperc = string::GetSubStr(%tperc,0,%l);
		%plus = 1;
	}
	//==========================================================
	// SREQ
	%sreq = $DynamicItem[%name,$DReq];
	//==========================================================
	// TIER
	%x = $DynamicItem[%name,$DItemType];
	%tier = getWord(%x,0);
	%itemtype = getWord(%x,1);
	//==========================================================
	echo(" MAIN:" @ %main @ " NAME:" @ %name @ " QL:" @ %ql @ " TPERC:" @ %tperc @ " SREQ:" @ %sreq @ " TIER:" @ %tier);
	//==========================================================
	if (%tier < 1) {
		Client::SendMessage(%id,1,"These items will not work together.");
		ClearCraftTable(%id,0);
		return;
	}
	//==========================================================
	// UPGRADE NAME
	%base = $DynamicItem[%name,$DBaseItem];
	//==========================================================
	%ret = TierItem::RandomItem(%base,%ql,%tperc,"",%tier,%main);
	Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearCraftTable(%id,1);
}

function BPCraft::RelicUpgrade(%id,%new,%relic)
{
	echo(" BP CRAFT: RELIC UPGRADGE " @ %new);
	if (string::findSubStr(%new,"!") != -1) {
		BPCraft::MapUpgrade(%id,%new,%relic);
		return;
	}
	if (GetBPData(%new,$BPIsBelt) == 1) {
		Client::SendMessage(%id,0,"Belts cannot be altered.");
		ClearCraftTable(%id,0);
		return;
	}
	//==========================================================
	// MAIN
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),9);
	//==========================================================
	// NAME
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	//==========================================================
	// QL
	%qlhard = floor(string::GetSubStr(%new,0,3));
	%ql = %qlhard + 0;
	//==========================================================
	// TPERC
	%plus = 0;
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	if ((%l = string::findSubStr(%tperc,"+")) != -1) {
		%tperc = string::GetSubStr(%tperc,0,%l);
		%plus = 1;
	}
	//==========================================================
	// SREQ
	%sreq = $DynamicItem[%name,$DReq];
	//==========================================================
	// CROPPARTS
	%find = string::FindSubStr(%new,"^");
	%plen = (string::len(%tperc) + 1);
	%perc = (%tperc / 100) + 1;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));
	//==========================================================
	// TIER
	%x = $DynamicItem[%name,$DItemType];
	%tier = getWord(%x,0);
	%itemtype = getWord(%x,1);
	//==========================================================
	echo(" MAIN:" @ %main @ " NAME:" @ %name @ " QL:" @ %ql @ " TPERC:" @ %tperc @ " SREQ:" @ %sreq @ " CROPPARTS:" @ %cropparts @ " TIER:" @ %tier);
	//==========================================================
	// CHECK FOR CORRECT RELIC
	if (%relic == "REGAL") { %mintier = 0; %maxtier = 3; %target = 4;}
	if (%relic == "COSMIC") { %mintier = 4; %maxtier = 4; %target = 5;}
	if (%relic == "HEROIC") { %mintier = 5; %maxtier = 5; %target = 6;}
	if (%tier > %maxtier || %tier < %mintier) {
		if (%relic != "BLESSED") {
			Client::SendMessage(%id,1,"These items will not work together.");
			ClearCraftTable(%id,0);
			return;
		}
	}
	//==========================================================
	// BREAK DOWN VALS 
	%start = 0;
	for (%i = 1; %i <= 20; %i++) {
		%s[%i] = string::GetSubStr(%cropparts,%start,9);
		%start += 9;
	}
	// BREAK LIST
	%newlist = "";
	for (%i = 1; %i <= 20; %i++) {
		if ((%crop = %s[%i]) != "") {
			%code = string::getSubStr(%crop,0,3);
			%v = string::getSubStr(%crop,3,9);
			%newlist = %newlist @ $BPMOD[%code] @ " " @ BPValPlus(%v) @ " ";
		}
	}
	echo(" HARDVALS:" @ %newlist);
	//==========================================================
	// BLESSED
	if (%relic == "BLESSED") {
		if (%main == "NON000000") {
			Client::SendMessage(%id,1,"This item type has no implicit value.");
			ClearCraftTable(%id,0);
			return;
		}
		%ret = TierItem::RandomItem(%name,%ql,%tperc,%newlist,%tier,"");
		Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
		AddToBackpack(%id,%ret,1);
		%msg = WhatIs(%ret);
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
		Game::MenuBackpack(%id,0);
		ClearCraftTable(%id,1);
		return;
	}
	//==========================================================
	// UPGRADE NAME
	%base = $DynamicItem[%name,$DBaseItem];
	if (%itemtype != "Weapon" && %itemtype != "MagicWeapon")
		%prefix = $TIERNAME[%itemtype,%target];
	else
		%prefix = $TIERNAME[%base,%target];
	if (%prefix == "")
		%prefix = $TIERNAME[%itemtype,%sreq,%target];
	%newbase = %prefix @ %base;
	//==========================================================
	// INPUT THE NEW ITEM
	
	%ret = TierItem::RandomItem(%newbase,%ql,%tperc,%newlist,%tier,%main);
	Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearCraftTable(%id,1);
}

function BPCraft::RelicRandomize(%id,%new,%relic)
{
	echo(" BP CRAFT: RANDPROP: " @ %new);
	if (string::findSubStr(%new,"!") != -1) {
		BPCraft::MapRandomize(%id,%new,%relic);
		return;
	}
	if (GetBPData(%new,$BPIsBelt) == 1) {
		Client::SendMessage(%id,0,"Belts cannot be altered.");
		ClearCraftTable(%id,0);
		return;
	}
	//==========================================================
	// MAIN
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),9);
	//==========================================================
	// NAME
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	//==========================================================
	// QL
	%qlhard = floor(string::GetSubStr(%new,0,3));
	%ql = %qlhard + 0;
	//==========================================================
	// TPERC
	%plus = 0;
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	if ((%l = string::findSubStr(%tperc,"+")) != -1) {
		%tperc = string::GetSubStr(%tperc,0,%l);
		%plus = 1;
	}
	//==========================================================
	// SREQ
	%sreq = $DynamicItem[%name,$DReq];
	//==========================================================
	// CROPPARTS
	%find = string::FindSubStr(%new,"^");
	%plen = (string::len(%tperc) + 1);
	%perc = (%tperc / 100) + 1;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));
	//==========================================================
	// TIER
	%x = $DynamicItem[%name,$DItemType];
	%tier = getWord(%x,0);
	%itemtype = getWord(%x,1);
	//==========================================================
	echo(" MAIN:" @ %main @ " NAME:" @ %name @ " QL:" @ %ql @ " TPERC:" @ %tperc @ " SREQ:" @ %sreq @ " CROPPARTS:" @ %cropparts @ " TIER:" @ %tier);
	//==========================================================
	// CHECK FOR CORRECT RELIC
	if (%relic == "ALTERING") { %mintier = 0; %maxtier = 3; }
	if (%relic == "HAVOC") { %mintier = 4; %maxtier = 4; }
	if (%relic == "CHAOS") { %mintier = 5; %maxtier = 5; }
	if (%relic == "ANARCHY") { %mintier = 6; %maxtier = 6; }
	if (%relic == "DIVINE") { %mintier = 1; %maxtier = 6; }
	if (%tier > %maxtier || %tier < %mintier) {
		Client::SendMessage(%id,1,"These items will not work together. 0x");
		ClearCraftTable(%id,0);
		return;
	}
	//==========================================================
	%newlist = "";
	// BREAK DOWN VALS
	if (%relic == "DIVINE") {
		%apply = 0;
		//==========================================================
		// BREAK DOWN VALS 
		%start = 0;
		for (%i = 1; %i <= 30; %i++) {
			%s[%i] = string::GetSubStr(%cropparts,%start,9);
			%start += 9;
		}
		//==========================================================
		// BREAK LIST
		for (%i = 1; %i <= 30; %i++) {
			if (%s[%i] != "") {
				%g = %s[%i];
				%p = string::getSubStr(%g,0,3);
				%v = string::getSubStr(%g,3,6);
				if (string::findSubStr(%v,"+") == -1) {
					%newlist = %newlist @ $BPMOD[%p] @ " R ";
					%apply = 1;
				}
				else 
					%newlist = %newlist @ $BPMOD[%p] @ " " @ BPValPlus(%v) @ " ";
			}
		}
		// Client::SendMessage(%id,0,"NEWLIST: " @ %newlist);
		if (%apply == 0) {
			Client::SendMessage(%id,1,"This item has no values that can be modified. 1x");
			ClearCraftTable(%id,0);
			return;
		}
	}
	//==========================================================
	// UPGRADE ALTERING
	if (%relic == "ALTERING") {
		ECHO(" ALTERING FIND ");
		%target = 3;
		%base = $DynamicItem[%name,$DBaseItem];
		if (%itemtype != "Weapon" && %itemtype != "MagicWeapon")
			%prefix = $TIERNAME[%itemtype,%target];
		else
			%prefix = $TIERNAME[%base,%target];
		if (%prefix == "")
			%prefix = $TIERNAME[%itemtype,%sreq,%target];
		%newbase = %prefix @ %base;
		echo(" NEWBASE " @ %newbase);
		%name = %newbase;
	}
	//==========================================================
	Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
	%ret = TierItem::RandomItem(%name,%qlhard,%tperc,%newlist,%tier,%main);
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearCraftTable(%id,1,%relic,%ret);
}

function BPCraft::IntegrityUpgrade(%id,%new,%set)
{
	echo(" BP CRAFT: INTEGRITY UPGRADE: " @ %new);
	//==========================================================
	// MAIN
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),9);
	//==========================================================
	// NAME
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	//==========================================================
	// QL
	%qlhard = floor(string::GetSubStr(%new,0,3));
	%ql = %qlhard + 0;
	//==========================================================
	// TPERC
	%plus = 0;
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	if ((%l = string::findSubStr(%tperc,"+")) != -1) {
		%tperc = string::GetSubStr(%tperc,0,%l);
		%plus = 1;
	}
	//==========================================================
	// SREQ
	%sreq = $DynamicItem[%name,$DReq];
	//==========================================================
	// CROPPARTS
	%find = string::FindSubStr(%new,"^");
	%plen = (string::len(%tperc) + 1);
	%perc = (%tperc / 100) + 1;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));
	//==========================================================
	echo(" MAIN:" @ %main @ " NAME:" @ %name @ " QL:" @ %ql @ " TPERC:" @ %tperc @ " SREQ:" @ %sreq @ " CROPPARTS:" @ %cropparts);
	//==========================================================

	if (%sreq != %set) {
		Client::SendMessage(%id,1,"These items will not work together.");
		ClearCraftTable(%id,0);
		return;
	}
	if ((%tperc + 1) > 30) {
		Client::SendMessage(%id,1,"This item can not be upgraded any further.");
		ClearCraftTable(%id,0);
		return;
	}
	%integ = %tperc + 1;
	%ret = FormatQL(%qlhard) @ %name @ "&" @ %main @ "^" @ %cropparts @ "%" @ %integ;
	Client::SendMessage(%id,3,"You successfully combine " @ GetBPData(%id.CraftBase,$BPName) @ " with " @ GetBPData(%id.CraftAdditions,$BPName) @ ".");
	TierItem::Create(%ret,-1);
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearCraftTable(%id,1,%set,%ret);
}

function CombineNeedFormat(%req) 
{
	%msg = "";
	for (%i = 0; (%r = getWord(%req,%i)) != -1; %i+=2) {
		%a = getWord(%req,%i + 1);
		if ($BPFormat[%r] != "")
			%r = $BPFormat[%r];
		if (getWord(%req,%i + 2) != -1)
			%msg = %msg @ %r @ ": " @ %a @ ", ";
		else
			%msg = %msg @ %r @ ": " @ %a;
	}
	if (%msg != "")
		return %msg;
	else
		return "None";
}

function ClearCraftTable(%id,%clear,%t,%ret)
{
	if (%clear != 1) {	

		%base = %id.CraftBase;
		if (%base != "")
			AddToBackpack(%id,%base,1);

		%add = %id.CraftAdditions;
		if (%add != "")
			AddToBackpack(%id,%add,1);
	}
	
	if (%t != "") {
		if (%t == "ALTERING") %nt = "999AlteringRelic";
		if (%t == "HAVOC") %nt = "999HavocRelic";
		if (%t == "CHAOS") %nt = "999ChaosRelic";
		if (%t == "ANARCHY") %nt = "999AnarchyRelic";
		if (%t == "DIVINE") %nt = "999DivineRelic";
	}
	
	%id.CraftBase = "";
	%id.CraftAdditions = "";
	
	Client::SendMessage(%id,2,"Your crafting table was cleared.");
}

function AddToCraft(%id,%item)
{
	if (%id.CraftBase == "") {
		RemoveFromBackpack(%id,%item,-1);
		%id.CraftBase = %item;
		Client::SendMessage(%id,2,"You added " @ GetBPData(%item,$BPName) @ " to your craft table.");
	}
	else {
		if ((%a = %id.CraftAdditions) != "") {
			Client::SendMessage(%id,1,"Your crafting table is full.");
			return;
		}
		else {
			RemoveFromBackpack(%id,%item,-1);
			%id.CraftAdditions = %item;
			Client::SendMessage(%id,2,"You added " @ GetBPData(%item,$BPName) @ " to your craft table.");
		}
	}
}

function BackpackCraft(%id) 
{
	if (%id.CraftBase == "" || %id.CraftAdditions == "") {
		Client::SendMessage(%id,0,"You have not selected items to craft correctly. You must choose a base and an addition to craft.");
		ClearCraftTable(%id);
		return;
	}
	%base = %id.CraftBase;
	%mix = %id.CraftAdditions;
	BPCombine(%id,%base,%mix);
}

function TestTier()
{
	echo("###################################################################################################################");
	echo(" TEST SINGLE TIER ");
	$playerbackpack[2049] = "";

	//%amulet = TierItem::RandomItem("RobustMithrilVest","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";

	//%amulet = TierItem::RandomItem("SleekDragonfleshGloves","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";

	//%amulet = TierItem::RandomItem("LuminantPhensHood","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";

	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999ArmourScrap 1000 ";
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999SpoolOfThread 1000 ";
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999PieceOfCloth 1000 ";

	//%amulet = TierItem::RandomItem("ReliableMithrilVest","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999AlteringRelic 1000 ";

	//%amulet = TierItem::RandomItem("CrackedStoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("ChippedStoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("FlawedStoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("SolidStoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("FlawlessStoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("ShiningStoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";


	//%amulet = TierItem::RandomItem("BrimstoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("CrackedBrimstoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("ChippedBrimstoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("FlawedBrimstoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("SolidBrimstoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	//%amulet = TierItem::RandomItem("ShiningBrimstoneAmulet","300");
	//$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";

	%amulet = TierItem::RandomItem("PoorMithrilVest","300");
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	%amulet = TierItem::RandomItem("WornMithrilVest","300");
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	%amulet = TierItem::RandomItem("ReliableMithrilVest","300");
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	%amulet = TierItem::RandomItem("DurableMithrilVest","300");
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	%amulet = TierItem::RandomItem("RobustMithrilVest","300");
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	%amulet = TierItem::RandomItem("SuperiorMithrilVest","300");
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	
	%rune = Rune::Random("BodyRuneOfSense",300);
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %rune @ " 1 ";
	%rune = Rune::Random("BodyRuneOfIntelligence",300);
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %rune @ " 1 ";
	%rune = Rune::Random("BodyRuneOfTitanium",300);
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %rune @ " 1 ";
	%amulet = TierItem::RandomItem("CrackedBrimstoneAmulet","30");
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %amulet @ " 1 ";
	%rune = Rune::Random("FetishRuneOfAgility",30);
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %rune @ " 1 ";

	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999RegalRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999CosmicRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999HeroicRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999AlteringRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999HavocRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999AnarchyRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999ScouringRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999BlessedRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999ChaosRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999MysticRelic 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999RunePrism 50 ";
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ "999DivineRelic 50 ";
	
	%rune = TierItem::RandomItem("WarriorsChestplate",300);
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %rune @ " 1 ";
	%rune = TierItem::RandomItem("WarriorsRing",300);
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %rune @ " 1 ";

}

echo("__BACKPACK CRAFT LOADED");
