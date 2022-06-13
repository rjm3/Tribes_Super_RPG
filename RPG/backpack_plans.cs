// PLANS

function Game::MenuSmithCraft(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Smithing & Crafting", "smithcraft", true);
	Client::addMenuItem(%id, %curItem++ @ "Smithing Tome...","smith");
	Client::addMenuItem(%id, %curItem++ @ "Crafting Tome...","craft");
	Client::addMenuItem(%id, %curItem++ @ "Crystal Crafting...","crystal");
	Client::addMenuItem(%id, %curItem++ @ "Rune Crafting...","rune");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function processMenusmithcraft(%id, %option)
{
	if (%option == "back") {
		Game::MenuRequest(%id);
		return;
	}
	if (%option == "smith") {
		Game::MenuSmith(%id);
		return;
	}
	if (%option == "craft") {
		Game::MenuCrafting(%id);
		return;
	}
	if (%option == "crystal") {
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "rune") {
		Game::MenuRune(%id);
		return;
	}
}

function Game::MenuSmith(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Smithing Tome", "smith", true);
	Client::addMenuItem(%id, %curItem++ @ "Armor Based...","armor");
	Client::addMenuItem(%id, %curItem++ @ "Evasion Based...","evasion");
	Client::addMenuItem(%id, %curItem++ @ "Off-Hand...","offhand");
	Client::addMenuItem(%id, %curItem++ @ "Weapons...","weapons");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuCrafting(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Crafting Tome", "crafting", true);
	Client::addMenuItem(%id, %curItem++ @ "Resistance Based...","resist");
	Client::addMenuItem(%id, %curItem++ @ "Accessories...","accessories");
	Client::addMenuItem(%id, %curItem++ @ "Off-Hand...","offhand");
	Client::addMenuItem(%id, %curItem++ @ "Staves & Wands...","weapons");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuCrystal(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Crystal Crafting", "crystal", true);
	Client::addMenuItem(%id, %curItem++ @ "Primal Magic","primal");
	Client::addMenuItem(%id, %curItem++ @ "Holy Magic","holy");
	Client::addMenuItem(%id, %curItem++ @ "Empowerment","empowerment");
	Client::addMenuItem(%id, %curItem++ @ "Dark Magic","dark");
	Client::addMenuItem(%id, %curItem++ @ "Light","light");
	Client::addMenuItem(%id, %curItem++ @ "Ritual","ritual");
	Client::addMenuItem(%id, %curItem++ @ "Sorcery","sorcery");
	Client::addMenuItem(%id, %curItem++ @ "Protection","protection");
	Client::addMenuItem(%id, %curItem++ @ "Enchantment","enchantment");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuRune(%clientId)
{
	%curItem = 0;
	Client::buildMenu(%clientId, "Rune Crafting", "rune", true);
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Amulet" , "amulet");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Ring" , "ring");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Head" , "head");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Chest" , "chest");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Hands" , "hands");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Legs" , "legs");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Boots" , "boots");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Talisman" , "talisman");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Orb" , "orb");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Weapon" , "weapon");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Magic Weapon" , "magicweapon");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Shield" , "shield");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Magic Shield" , "magicshield");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Armor & Robe" , "armor");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "<< Prev","back");
}

$ValidRuneCraftSelect["amulet"] = 1;
$ValidRuneCraftSelect["ring"] = 1;
$ValidRuneCraftSelect["head"] = 1;
$ValidRuneCraftSelect["chest"] = 1;
$ValidRuneCraftSelect["hands"] = 1;
$ValidRuneCraftSelect["legs"] = 1;
$ValidRuneCraftSelect["boots"] = 1;
$ValidRuneCraftSelect["talisman"] = 1;
$ValidRuneCraftSelect["orb"] = 1;
$ValidRuneCraftSelect["weapon"] = 1;
$ValidRuneCraftSelect["magicweapon"] = 1;
$ValidRuneCraftSelect["shield"] = 1;
$ValidRuneCraftSelect["magicshield"] = 1;
$ValidRuneCraftSelect["armor"] = 1;

function processMenusmith(%id, %option)
{
	if (%option == "back") {
		Game::MenuSmithCraft(%id);
		return;
	}
	if (%option == "armor") {
		Game::MenuSmithArmor(%id);
		return;
	}
	if (%option == "evasion") {
		Game::MenuSmithEvasion(%id);
		return;
	}
	if (%option == "offhand") {
		Game::MenuSmithOffhand(%id);
		return;
	}
	if (%option == "weapons") {
		Game::MenuSmithWeapons(%id);
		return;
	}
}

function processMenucrafting(%id, %option)
{
	if (%option == "back") {
		Game::MenuSmithCraft(%id);
		return;
	}
	if (%option == "resist") {
		Game::MenuCraftResist(%id);
		return;
	}
	if (%option == "accessories") {
		Game::MenuCraftAccessories(%id);
		return;
	}
	if (%option == "offhand") {
		Game::MenuCraftOffhand(%id);
		return;
	}
	if (%option == "weapons") {
		Game::MenuCraftWeapons(%id);
		return;
	}
}

function Game::MenuSmithArmor(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Armor Smithing", "smitharmor", true);
	Client::addMenuItem(%id, %curItem++ @ "Armor","Armor");
	Client::addMenuItem(%id, %curItem++ @ "Head","Head");
	Client::addMenuItem(%id, %curItem++ @ "Chest","Chest");
	Client::addMenuItem(%id, %curItem++ @ "Hands","Hands");
	Client::addMenuItem(%id, %curItem++ @ "Legs","Legs");
	Client::addMenuItem(%id, %curItem++ @ "Boots","Boots");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuSmithEvasion(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Evasion Smithing", "smithevasion", true);
	Client::addMenuItem(%id, %curItem++ @ "Armor","Armor");
	Client::addMenuItem(%id, %curItem++ @ "Head","Head");
	Client::addMenuItem(%id, %curItem++ @ "Chest","Chest");
	Client::addMenuItem(%id, %curItem++ @ "Hands","Hands");
	Client::addMenuItem(%id, %curItem++ @ "Legs","Legs");
	Client::addMenuItem(%id, %curItem++ @ "Boots","Boots");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuCraftResist(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Resistance Crafting", "craftresist", true);
	Client::addMenuItem(%id, %curItem++ @ "Armor (Robe)","Armor");
	Client::addMenuItem(%id, %curItem++ @ "Head","Head");
	Client::addMenuItem(%id, %curItem++ @ "Chest","Chest");
	Client::addMenuItem(%id, %curItem++ @ "Hands","Hands");
	Client::addMenuItem(%id, %curItem++ @ "Legs","Legs");
	Client::addMenuItem(%id, %curItem++ @ "Boots","Boots");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuCraftAccessories(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Accessory Crafting", "craftaccessories", true);
	Client::addMenuItem(%id, %curItem++ @ "Amulet","Amulet");
	Client::addMenuItem(%id, %curItem++ @ "Ring","Ring");
	Client::addMenuItem(%id, %curItem++ @ "Talisman","Talisman");
	Client::addMenuItem(%id, %curItem++ @ "Orb","Orb");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuSmithOffhand(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Off-Hand Smithing", "smithoffhand", true);
	Client::addMenuItem(%id, %curItem++ @ "Armor Shield","Shield");
	Client::addMenuItem(%id, %curItem++ @ "Quiver","Quiver");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuCraftOffhand(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Off-Hand Crafting", "craftoffhand", true);
	Client::addMenuItem(%id, %curItem++ @ "Spell Shield","Shield");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuSmithWeapons(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Weapon Smithing", "smithweapon", true);
	Client::addMenuItem(%id, %curItem++ @ "Slashing","Slashing");
	Client::addMenuItem(%id, %curItem++ @ "Two Hand Slashing","2HSlashing");
	Client::addMenuItem(%id, %curItem++ @ "Piercing","Piercing");
	Client::addMenuItem(%id, %curItem++ @ "Bludgenoing","Bludgeoning");
	Client::addMenuItem(%id, %curItem++ @ "Bow","Bow");
	Client::addMenuItem(%id, %curItem++ @ "Crossbow","Crossbow");
	Client::addMenuItem(%id, %curItem++ @ "Martial Arts","MartialArts");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function Game::MenuCraftWeapons(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Magic Weapon Crafting", "craftweapon", true);
	Client::addMenuItem(%id, %curItem++ @ "Staff","Staff");
	Client::addMenuItem(%id, %curItem++ @ "Wand","Wand");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function processMenurune(%id,%option)
{
	if ($ValidRuneCraftSelect[%option]) {
		RC::StartCraftRune(%id,%option);
		Game::MenuRune(%id);
		return;
	}
	if (%option == "back") {
		Game::MenuSmithCraft(%id);
		return;
	}
}

function processMenucrystal(%id, %option)
{
	if (%option == "back") {
		Game::MenuSmithCraft(%id);
		return;
	}
	if (%option == "primal") {
		CC::StartCraftCrystal(%id,"PrimalMagic");
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "holy") {
		CC::StartCraftCrystal(%id,"HolyMagic");
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "empowerment") {
		CC::StartCraftCrystal(%id,"Empowerment");
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "dark") {
		CC::StartCraftCrystal(%id,"DarkMagic");
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "light") {
		CC::StartCraftCrystal(%id,"LightMagic");
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "ritual") {
		CC::StartCraftCrystal(%id,"Ritual");
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "sorcery") {
		CC::StartCraftCrystal(%id,"Sorcery");
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "protection") {
		CC::StartCraftCrystal(%id,"Protection");
		Game::MenuCrystal(%id);
		return;
	}
	if (%option == "enchantment") {
		CC::StartCraftCrystal(%id,"Enchantment");
		Game::MenuCrystal(%id);
		return;
	}
}

function processMenusmitharmor(%id, %option)
{
	if (%option == "back") {
		Game::MenuSmith(%id);
		return;
	}
	if (%option == "Armor") {
		SC::StartSmithArmor(%id,"AMR",%option);
		Game::MenuSmithArmor(%id);
		return;
	}
	if (%option == "Head" || %option == "Chest" || %option == "Hands" || %option == "Legs" || %option == "Boots") {
		SC::StartSmithBody(%id,"AMR",%option);
		Game::MenuSmithArmor(%id);
		return;
	}
}

function processMenusmithevasion(%id, %option)
{
	if (%option == "back") {
		Game::MenuSmith(%id);
		return;
	}
	if (%option == "Armor") {
		SC::StartSmithArmor(%id,"EVA",%option);
		Game::MenuSmithEvasion(%id);
		return;
	}
	if (%option == "Head" || %option == "Chest" || %option == "Hands" || %option == "Legs" || %option == "Boots") {
		SC::StartSmithBody(%id,"EVA",%option);
		Game::MenuSmithEvasion(%id);
		return;
	}
}

function processMenucraftresist(%id, %option)
{
	if (%option == "back") {
		Game::MenuCrafting(%id);
		return;
	}
	if (%option == "Armor") {
		SC::StartSmithArmor(%id,"RES",%option);
		Game::MenuCraftResist(%id);
		return;
	}
	if (%option == "Head" || %option == "Chest" || %option == "Hands" || %option == "Legs" || %option == "Boots") {
		SC::StartSmithBody(%id,"RES",%option);
		Game::MenuCraftResist(%id);
		return;
	}
}

function processMenucraftaccessories(%id, %option)
{
	if (%option == "back") {
		Game::MenuCrafting(%id);
		return;
	}
	if (%option == "Amulet" || %option == "Ring" || %option == "Talisman" || %option == "Orb") {
		SC::StartCraftMagic(%id,%option);
		Game::MenuCraftAccessories(%id);
		return;
	}
}

function processMenusmithoffhand(%id, %option)
{
	if (%option == "back") {
		Game::MenuSmith(%id);
		return;
	}
	if (%option == "Shield") {
		SC::StartSmithShield(%id,"MES",%option);
		Game::MenuSmithOffhand(%id);
		return;
	}
	if (%option == "Quiver") {
		SC::StartSmithShield(%id,"QUV",%option);
		Game::MenuSmithOffhand(%id);
		return;
	}
}

function processMenucraftoffhand(%id, %option)
{
	if (%option == "back") {
		Game::MenuCrafting(%id);
		return;
	}
	if (%option == "Shield") {
		SC::StartSmithShield(%id,"SPS",%option);
		Game::MenuCraftOffhand(%id);
		return;
	}
}

function processMenusmithweapon(%id, %option)
{
	if (%option == "back") {
		Game::MenuSmith(%id);
		return;
	}
	if (%option == "Slashing" || %option == "2HSlashing" || %option == "Piercing" || %option == "Bludgeoning" || %option == "Bow" || %option == "Crossbow" || %option == "MartialArts") {
		SC::StartSmithWeapon(%id,%option);
		Game::MenuSmithWeapons(%id);
		return;
	}
}

function processMenucraftweapon(%id, %option)
{
	if (%option == "back") {
		Game::MenuCrafting(%id);
		return;
	}
	if (%option == "Staff" || %option == "Wand") {
		SC::StartSmithWeapon(%id,%option);
		Game::MenuCraftWeapons(%id);
		return;
	}
}

function RC::StartCraftRune(%id,%type)
{
	if (%id.Smithing != "")
		return;
	if (RC::HasRuneMats(%id,%type) == False)
		return;
	%id.Smithing = True;
	%c = GetConnectionId(%id);
	%select = false;
	client::SendMessage(%id,$msggreen,"Starting Rune Craft Type: " @ %type @ "...");
	remoteeval(%id,"RPGGui::ActionRefresh",2.5,1,"Rune Crafting");
	PlaySound("SoundSmith", Gamebase::getPosition(%id));
	schedule("RC::CraftRune("@%id@","@%c@",\""@%type@"\",\""@%select@"\");",2.5);
}

function RC::MatCount(%id,%ql)
{
	%need = floor(%ql * 2.5);
	if (%need < 3) %need = 3;
	return %need;
}

function RC::HasRuneMats(%id,%type)
{
	if (BackpackFull(%id)) {
		Client::sendMessage(%id,$msgwhite,"Your backpack is full.");
		return False;
	}
	%ql = RC::GetQL(%id);
	if (%id.RuneQL != "") %ql = %id.RuneQL;
	%countn = RC::MatCount(%id,%ql);
	%powder = GetBackpackCount(%id,"999Powder");
	if (%powder > %countn)
		return True;
	Client::SendMessage(%id,$msgwhite,"You dont have the " @ %countn @ " Rune Powder needed to craft at Quality Level " @ %ql @ ".");
	return False;
}

function CC::StartCraftCrystal(%id,%type)
{
	if (%id.Smithing != "")
		return;
	if (CC::HasCrystalMats(%id,%type) == False)
		return;
	%id.Smithing = True;
	%c = GetConnectionId(%id);
	%select = false;
	client::SendMessage(%id,$msggreen,"Starting Crystal Craft Type: " @ %type @ "...");
	remoteeval(%id,"RPGGui::ActionRefresh",2.5,1,"Crystal Crafting");
	PlaySound("SoundSmith", Gamebase::getPosition(%id));
	schedule("CC::CraftCrystal("@%id@","@%c@",\""@%type@"\",\""@%select@"\");",2.5);
}

function CC::MatCount(%id,%ql)
{
	%need[1] = floor(%ql * 2.5);
	if (%need[1] < 2) %need[1] = 2;
	%need[2] = floor(%ql * 1.25);
	if (%need[2] < 1) %need[2] = 1;
	%ret = %need[1] @ " " @ %need[2];
	return %ret;
}

function CC::HasCrystalMats(%id,%type)
{
	if (BackpackFull(%id)) {
		Client::sendMessage(%id,$msgwhite,"Your backpack is full.");
		return False;
	}
	%ql = CC::GetQL(%id);
	if (%id.CrystalQL != "") %ql = %id.CrystalQL;
	%n = $SpellCrystalCraftNum[%ql,%type];
	if (%n == "") {
		Client::SendMessage(%id,$msgwhite,"There are no crystals in school " @ %type @ " at Quality Level " @ %ql @ ".");
		return False;
	}
	%countn = CC::MatCount(%id,%ql);
	%n[1] = getWord(%countn,0);
	%n[2] = getWord(%countn,1);
	%shard = GetBackpackCount(%id,"999CrystalShard");
	%page = GetBackpackCount(%id,"999Page");
	if (%shard > %n[1] && %page > %n[2])
		return True;
	Client::SendMessage(%id,$msgwhite,"You dont have the " @ %n[1] @ " Crystal Shards and " @ %n[2] @ "	Ancient Pages needed to craft at Quality Level " @ %ql @ ".");
	return False;
}

function SC::HasSmithMats(%id,%type)
{
	if (BackpackFull(%id)) {
		Client::sendMessage(%id,$msgwhite,"Your backpack is full.");
		return False;
	}
	if (%type == "RES" || %type == "SPS" || %type == "Staff" || %type == "Wand" || %type == "Amulet" || %type == "Ring" || %type == "Talisman" || %type == "Orb")
		%skill = GetPlayerSkill(%id,$SkillMagicCraft);
	else
		%skill = GetPlayerSkill(%id,$SkillSmithing);
	%ql = SC::QL(%id,%skill);
	%countn = SC::MatCount(%id,%ql);
	if (%type == "RES" || %type == "SPS" || %type == "Staff" || %type == "Wand" || %type == "Amulet" || %type == "Ring" || %type == "Talisman" || %type == "Orb") {
		%mat = GetBackpackCount(%id,"999CraftingMaterial");
		%pri = GetBackpackCount(%id,"999PristineCrafting");
	}
	else {
		%mat = GetBackpackCount(%id,"999SmithingMaterial");
		%pri = GetBackpackCount(%id,"999PristineSmithing");
	}
	if ((%mat + %pri) >= %countn)
		return True;
	Client::SendMessage(%id,$msgwhite,"You dont have the " @ %countn @ " Material(s) needed to smith at Quality Level " @ %ql @ ".");
	return False;
}

function SC::StartSmithBody(%id,%type,%select)
{
	if (%id.Smithing != "")
		return;
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	%id.Smithing = True;
	%c = GetConnectionId(%id);
	client::SendMessage(%id,$msggreen,"Starting Smith Type:" @ %type @ " Slot:" @ %select @ "...");
	remoteeval(%id,"RPGGui::ActionRefresh",2.5,1,"Smith & Craft");
	PlaySound("SoundSmith", Gamebase::getPosition(%id));
	schedule("SC::SmithBody("@%id@","@%c@",\""@%type@"\",\""@%select@"\");",2.5);
}

function SC::StartSmithArmor(%id,%type)
{
	if (%id.Smithing != "")
		return;
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	%id.Smithing = True;
	%c = GetConnectionId(%id);
	client::SendMessage(%id,$msggreen,"Starting Smith Armor Type:" @ %type);
	remoteeval(%id,"RPGGui::ActionRefresh",2.5,1,"Smith & Craft");
	PlaySound("SoundSmith", Gamebase::getPosition(%id));
	schedule("SC::SmithArmor("@%id@","@%c@",\""@%type@"\");",2.5);
}

function SC::StartSmithShield(%id,%type,%select)
{
	if (%id.Smithing != "")
		return;
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	%id.Smithing = True;
	%c = GetConnectionId(%id);
	client::SendMessage(%id,$msggreen,"Starting Smith Shield Type:" @ %type @ " Slot:" @ %select @ "...");
	remoteeval(%id,"RPGGui::ActionRefresh",2.5,1,"Smith & Craft");
	PlaySound("SoundSmith", Gamebase::getPosition(%id));
	schedule("SC::SmithBody("@%id@","@%c@",\""@%type@"\",\""@%select@"\");",2.5);
}

function SC::StartSmithWeapon(%id,%type)
{
	if (%id.Smithing != "")
		return;
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	%id.Smithing = True;
	%c = GetConnectionId(%id);
	client::SendMessage(%id,$msggreen,"Starting Smith Weapon Type:" @ %type);
	remoteeval(%id,"RPGGui::ActionRefresh",2.5,1,"Smith & Craft");
	PlaySound("SoundSmith", Gamebase::getPosition(%id));
	schedule("SC::SmithWeapon("@%id@","@%c@",\""@%type@"\");",2.5);
}

function SC::StartCraftMagic(%id,%type)
{
	if (%id.Smithing != "")
		return;
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	%id.Smithing = True;
	%c = GetConnectionId(%id);
	client::SendMessage(%id,$msggreen,"Starting Craft Type:" @ %type);
	remoteeval(%id,"RPGGui::ActionRefresh",2.5,1,"Smith & Craft");
	PlaySound("SoundSmith", Gamebase::getPosition(%id));
	schedule("SC::CraftMagic("@%id@","@%c@",\""@%type@"\");",2.5);
}

function SC::SetQL(%id,%set)
{
	if (%set == 0)
		return;
	Client::sendMessage(%id,0,"================================");
	Client::sendMessage(%id,0,"Attempting to set QL to " @ %set);
	//====================================================
	%skill = GetPlayerSkill(%id,$SkillSmithing);
	%b = GetBonus(%id,$BPSMITHREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100));
	%ql = 300 * (%skill / %max);
	%ql = round(%ql);
	if (%ql < 1) %ql = 1;
	if (%set > %ql)
		%new = %ql;
	else
		%new = %set;
	%msg = string::translate("Smithing") @ " QL set to: " @ %new;
	Client::sendMessage(%id,0,%msg);
	%id.SmithQL = %new;
	//====================================================
	%skill = GetPlayerSkill(%id,$SkillMagicCraft);
	%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100));
	%ql = 300 * (%skill / %max);
	%ql = round(%ql);
	if (%ql < 1) %ql = 1;
	if (%set > %ql)
		%new = %ql;
	else
		%new = %set;
	%msg = string::translate("Crafting") @ " QL set to: " @ %new;
	Client::sendMessage(%id,0,%msg);
	%id.CraftQL = %new;
	//====================================================
	// SPELL CRAFTING
	%nset = CC::Round(%set);
	%skill = GetPlayerSkill(%id,$SkillMagicCraft);
	%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[1] = 300 * (%skill / %max);
	%skill = GetPlayerSkill(%id,$SkillLiteracy);
	%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[2] = 300 * (%skill / %max);
	%fql = floor((%ql[1] + %ql[2]) / 2);
	%fql = CC::Round(%fql);
	if (%nset > %fql)
		%new = %fql;
	else
		%new = %nset;
	%msg = string::translate("Crystal") @ " QL set to: " @ %new;
	Client::sendMessage(%id,0,%msg);
	%id.CrystalQL = %new;
	//====================================================
	// RUNE CRAFTING
	%skill = GetPlayerSkill(%id,$SkillMagicCraft);
	%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[1] = 300 * (%skill / %max);
	%skill = GetPlayerSkill(%id,$SkillSmithing);
	%b = GetBonus(%id,$BPSMITHREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[2] = 300 * (%skill / %max);
	%skill = GetPlayerSkill(%id,$SkillAlchemy);
	%b = GetBonus(%id,$BPALCHEMYREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[3] = 300 * (%skill / %max);
	%fql = floor((%ql[1] + %ql[2] + %ql[3]) / 3);
	if (%set > %fql)
		%new = %fql;
	else
		%new = %set;
	%msg = string::translate("Rune") @ " QL set to: " @ %new;
	Client::sendMessage(%id,0,%msg);
	%id.RuneQL = %new;
	//====================================================
	Client::sendMessage(%id,0,"================================");
}

function RC::GetQL(%id)
{
	%skill = GetPlayerSkill(%id,$SkillMagicCraft);
	%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[1] = 300 * (%skill / %max);
	%skill = GetPlayerSkill(%id,$SkillSmithing);
	%b = GetBonus(%id,$BPSMITHREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[2] = 300 * (%skill / %max);
	%skill = GetPlayerSkill(%id,$SkillAlchemy);
	%b = GetBonus(%id,$BPALCHEMYREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[3] = 300 * (%skill / %max);
	%fql = floor((%ql[1] + %ql[2] + %ql[3]) / 3);
	return %fql;
}

function CC::GetQL(%id)
{
	%skill = GetPlayerSkill(%id,$SkillMagicCraft);
	%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[1] = 300 * (%skill / %max);
	%skill = GetPlayerSkill(%id,$SkillLiteracy);
	%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100)); 
	%ql[2] = 300 * (%skill / %max);
	%fql = floor((%ql[1] + %ql[2]) / 2);
	%fql = CC::Round(%fql);
	return %fql;
}

function CC::Round(%n)
{
	if (%n < 10) return 1;
	if (%n > 10 && %n < 100)
		return string::getSubStr(%n,0,1) @ "0";
	if (%n > 100)
		return string::getSubStr(%n,0,2) @ "0";
}

function CC::AddSpellCrystal(%v,%crystal,%req)
{
	//echo(" CC::ADDSPELLCRYSTAL " @ %v @ " " @ %crystal @ " " @ %req);
	%n = $SpellCrystalCraftNum[%v,%req]++;
	//echo(" N " @ %n);
	$SpellCrystalCraft[%v,%n,%req] = %crystal;
}

function CC::Test()
{
	for (%i = 10; %i <= 300; %i+=10) {
		echo(%i @ " " @ $SpellCrystalCraftNum[%i,"Sorcery"]);
	}
}

function CC::GrabCrystal(%l,%req)
{
	//echo(" CC::GRABCRYSTAL " @ %l @ " " @ %req);
	%n = $SpellCrystalCraftNum[%l,%req];
	%r = MTRB(1,%n);
	return $SpellCrystalCraft[%l,%r,%req];
}

function RC::GrabRune(%type)
{
	//echo(" RC::GRABRUNE " @ %l @ " " @ %req);
	%n = $RuneCraftCount[%type];
	%r = MTRB(1,%n);
	return $RuneCraft[%type,%r];
}

function SC::QL(%id,%skill,%smith)
{
	%b = 0;
	if (%smith == true || %smith == "")
		%b = GetBonus(%id,$BPSMITHREQ);
	else
		%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%b = Cap(%b,0,50);
	%max = 4600 * (1 - (%b/100));
	%ql = 300 * (%skill / %max);
	if (%ql < 1) %ql = 1;
	return round(%ql);
}

function SC::MatCount(%id,%ql)
{
	%n = (%ql / 2);
	if (%n < 2) %n = 2;
	return floor(%n);
}

function RC::CraftRune(%id,%c,%type)
{
	//echo("RC::CRAFTRUNE " @ %id @ " " @ %c @ " " @ %type);
	//client::sendmessage(%id,0,"CraftRune " @ %id @ " " @ %c @ " " @ %type);
	if (GetConnectionId(%id) != %c)
		return;
	//client::sendmessage(%id,0,"Connection ID OK");
	if (RC::HasRuneMats(%id,%type) == False)
		return;
	//client::sendmessage(%id,0,"Has Mats OK");
	if (BackpackFull(%id))
		return;
	//client::sendmessage(%id,0,"Backpack full OK");
	%ql = RC::GetQL(%id);
	if (%id.RuneQL != "") %ql = %id.RuneQL;
	%countn = RC::MatCount(%id,%ql);
	%shard = GetBackpackCount(%id,"999Powder");
	if (%shard < %countn)
		return;
	//client::sendmessage(%id,0,"Has Mats 2 OK");
	Client::SendMessage(%id,%msgwhite,"Using Rune Powder: (" @ %countn @ "/" @ %shard @ ")");
	%rune = RC::GrabRune(%type);
	%i = Rune::Random(%rune,%ql);
	RemoveFromBackpack(%id,"999Powder",(%countn * -1),0);
	AddToBackpack(%id,%i,1);
	%msg = WhatIs(%i,%id);
	if (%msg != "Unknown Item")
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
	SaveCharacter(%id,False);
	%id.Smithing = "";	
}

function CC::CraftCrystal(%id,%c,%type)
{
	//echo(" CC::CRAFTCRYSTAL " @ %id @ " " @ %c @ " " @ %type);
	//client::sendmessage(%id,0,"CraftCrystal " @ %id @ " " @ %c @ " " @ %type);
	if (GetConnectionId(%id) != %c)
		return;
	//client::sendmessage(%id,0,"Connection ID OK");
	if (CC::HasCrystalMats(%id,%type) == False)
		return;
	//client::sendmessage(%id,0,"Has Mats OK");
	if (BackpackFull(%id))
		return;
	//client::sendmessage(%id,0,"Backpack full OK");
	%ql = CC::GetQL(%id);
	if (%id.CrystalQL != "") %ql = %id.CrystalQL;
	%n = $SpellCrystalCraftNum[%ql,%type];
	if (%n == "")
		return;
	//client::sendmessage(%id,0,"Category OK");
	%countn = CC::MatCount(%id,%ql);
	%n[1] = getWord(%countn,0);
	%n[2] = getWord(%countn,1);
	%shard = GetBackpackCount(%id,"999CrystalShard");
	%page = GetBackpackCount(%id,"999Page");
	if (%shard < %n[1] || %page < %n[2])
		return;
	//client::sendmessage(%id,0,"Has Mats 2 OK");
	Client::SendMessage(%id,%msgwhite,"Using Crystal Shards: (" @ %n[1] @ "/" @ %shard @ ")");
	Client::SendMessage(%id,%msgwhite,"Using Ancient Pages: (" @ %n[2] @ "/" @ %page @ ")");
	%i = CC::GrabCrystal(%ql,%type);
	RemoveFromBackpack(%id,"999CrystalShard",(%n[1] * -1),0);
	RemoveFromBackpack(%id,"999Page",(%n[2] * -1),0);
	AddToBackpack(%id,%i,1);
	%msg = WhatIs(%i,%id);
	if (%msg != "Unknown Item")
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
	SaveCharacter(%id,False);
	%id.Smithing = "";	
}

function SC::SmithBody(%id,%c,%type,%select)
{
	if (GetConnectionId(%id) != %c)
		return;
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	if (BackpackFull(%id)) {
		Client::sendMessage(%id,$msgwhite,"Your backpack is full.");
		return;
	}
	if (%type == "RES" || %type == "SPS") {
		%skill = GetPlayerSkill(%id,$SkillMagicCraft);
		%smith = false;
	}
	else {
		%skill = GetPlayerSkill(%id,$SkillSmithing);
		%smith = true;
	}
	%ql = SC::QL(%id,%skill,%smith);
	if (%smith == false) {
		if (%id.CraftQL != "") %ql = %id.CraftQL;
	}
	else
		if (%id.SmithQL != "") %ql = %id.SmithQL;
	%countn = SC::MatCount(%id,%ql);
	if (%type == "RES" || %type == "SPS") {
		%m = GetBackpackCount(%id,"999CraftingMaterial");
		%p = GetBackpackCount(%id,"999PristineCrafting");
	}
	else {
		%m = GetBackpackCount(%id,"999SmithingMaterial");
		%p = GetBackpackCount(%id,"999PristineSmithing");
	}
	%tp = 0;
	%tm = 0;
	if (%p >= %countn)
		%tp = %countn;
	else if (%p < %countn) {
		%newcount = %countn;
		if (%p > 0) {
			%tp = %p;
			%tm = %countn - %p;
		}
		else
			%tm = %countn;
	}
	Client::SendMessage(%id,%msgwhite,"Using Pristine Materials: (" @ %tp @ "/" @ %p @ ")");
	Client::SendMessage(%id,%msgwhite,"Using Regular Materials: (" @ %tm @ "/" @ %m @ ")");
	%rate = %tp / %countn;
	%tier = SC::GrabTier(%rate);
	%mf = 2 + (3 * %rate);
	if (%type == "MES" || %type == "QUV" || %type == "SPS")
		%item = Loot::Shield(%tier,%mf,%type,%select);
	else
		%item = Loot::Body(%tier,%mf,%type,%select);
	client::SendMessage(%id,$msgwhite,"Creating Item " @ %item);
	%i = TierItem::RandomItem(%item,%ql);
	if (%type == "RES" || %type == "SPS") {
		if (%tp > 0)
			RemoveFromBackpack(%id,"999PristineCrafting",(%tp * -1),0);
		if (%tm > 0)
			RemoveFromBackpack(%id,"999CraftingMaterial",(%tm * -1),0);
	}
	else { 
		if (%tp > 0)
			RemoveFromBackpack(%id,"999PristineSmithing",(%tp * -1),0);
		if (%tm > 0)
			RemoveFromBackpack(%id,"999SmithingMaterial",(%tm * -1),0);
	}
	AddToBackpack(%id,%i,1);
	%msg = WhatIs(%i,%id);
	if (%msg != "Unknown Item")
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
	SaveCharacter(%id,False);
	%id.Smithing = "";	
}

function SC::SmithArmor(%id,%c,%type)
{
	if (GetConnectionId(%id) != %c)
		return;
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	if (BackpackFull(%id)) {
		Client::sendMessage(%id,$msgwhite,"Your backpack is full.");
		return;
	}
	if (%type == "RES" || %type == "SPS") {
		%skill = GetPlayerSkill(%id,$SkillMagicCraft);
		%smith = false;
	}
	else {
		%skill = GetPlayerSkill(%id,$SkillSmithing);
		%smith = true;
	}
	%ql = SC::QL(%id,%skill,%smith);
	if (%smith == false) {
		if (%id.CraftQL != "") %ql = %id.CraftQL;
	}
	else
		if (%id.SmithQL != "") %ql = %id.SmithQL;
	%countn = SC::MatCount(%id,%ql);
	if (%type == "RES" || %type == "SPS") {
		%m = GetBackpackCount(%id,"999CraftingMaterial");
		%p = GetBackpackCount(%id,"999PristineCrafting");
	}
	else {
		%m = GetBackpackCount(%id,"999SmithingMaterial");
		%p = GetBackpackCount(%id,"999PristineSmithing");
	}
	%tp = 0;
	%tm = 0;
	if (%p >= %countn)
		%tp = %countn;
	else if (%p < %countn) {
		%newcount = %countn;
		if (%p > 0) {
			%tp = %p;
			%tm = %countn - %p;
		}
		else
			%tm = %countn;
	}
	Client::SendMessage(%id,%msgwhite,"Using Pristine Materials: (" @ %tp @ "/" @ %p @ ")");
	Client::SendMessage(%id,%msgwhite,"Using Regular Materials: (" @ %tm @ "/" @ %m @ ")");
	%rate = %tp / %countn;
	%tier = SC::GrabTier(%rate);
	%mf = 2 + (3 * %rate);
	%item = Loot::Armor(%tier,%mf,%type);
	client::SendMessage(%id,$msgwhite,"Creating Item " @ %item);
	%i = TierItem::RandomItem(%item,%ql);
	if (%type == "RES" || %type == "SPS") {
		if (%tp > 0)
			RemoveFromBackpack(%id,"999PristineCrafting",(%tp * -1),0);
		if (%tm > 0)
			RemoveFromBackpack(%id,"999CraftingMaterial",(%tm * -1),0);
	}
	else { 
		if (%tp > 0)
			RemoveFromBackpack(%id,"999PristineSmithing",(%tp * -1),0);
		if (%tm > 0)
			RemoveFromBackpack(%id,"999SmithingMaterial",(%tm * -1),0);
	}
	AddToBackpack(%id,%i,1);
	%msg = WhatIs(%i,%id);
	if (%msg != "Unknown Item")
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
	SaveCharacter(%id,False);
	%id.Smithing = "";	
}

function SC::SmithWeapon(%id,%c,%type)
{
	if (GetConnectionId(%id) != %c) {
		return;
	}
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	if (BackpackFull(%id)) {
		Client::sendMessage(%id,$msgwhite,"Your backpack is full.");
		return;
	}
	if (%type == "Staff" || %type == "Wand") {
		%skill = GetPlayerSkill(%id,$SkillMagicCraft);
		%smith = false;
	}
	else {
		%smith = true;
		%skill = GetPlayerSkill(%id,$SkillSmithing);
	}
	%ql = SC::QL(%id,%skill);
	if (%smith == false) {
		if (%id.CraftQL != "") %ql = %id.CraftQL;
	}
	else
		if (%id.SmithQL != "") %ql = %id.SmithQL;
	%countn = SC::MatCount(%id,%ql);
	if (%type == "Staff" || %type == "Wand") {
		%m = GetBackpackCount(%id,"999CraftingMaterial");
		%p = GetBackpackCount(%id,"999PristineCrafting");
	}
	else {
		%m = GetBackpackCount(%id,"999SmithingMaterial");
		%p = GetBackpackCount(%id,"999PristineSmithing");
	}
	%tp = 0;
	%tm = 0;
	if (%p >= %countn)
		%tp = %countn;
	else if (%p < %countn) {
		%newcount = %countn;
		if (%p > 0) {
			%tp = %p;
			%tm = %countn - %p;
		}
		else
			%tm = %countn;
	}
	Client::SendMessage(%id,%msgwhite,"Using Pristine Materials: (" @ %tp @ "/" @ %p @ ")");
	Client::SendMessage(%id,%msgwhite,"Using Regular Materials: (" @ %tm @ "/" @ %m @ ")");
	%rate = %tp / %countn;
	%tier = SC::GrabTier(%rate);
	%mf = 2 + (3 * %rate);
	if (%type == "Slashing")
		%i = Loot::Slashing(%tier,%mf,%ql);
	if (%type == "2HSlashing")
		%i = Loot::TwoHandSlash(%tier,%mf,%ql);
	if (%type == "Piercing")
		%i = Loot::Piercing(%tier,%mf,%ql);
	if (%type == "Bludgeoning")
		%i = Loot::Bludgeoning(%tier,%mf,%ql);
	if (%type == "Bow")
		%i = Loot::Bow(%tier,%mf,%ql);
	if (%type == "Crossbow")
		%i = Loot::Crossbow(%tier,%mf,%ql);
	if (%type == "Staff")
		%i = Loot::Focus(%tier,%mf,%ql);
	if (%type == "Wand")
		%i = Loot::Wand(%tier,%mf,%ql);
	if (%type == "MartialArts")
		%i = Loot::MartialArts(%tier,%mf,%ql);
	client::SendMessage(%id,$msgwhite,"Creating Item " @ GetBPData(%i,$BPName));
	if (%type == "Staff" || %type == "Wand") {
		if (%tp > 0)
			RemoveFromBackpack(%id,"999PristineCrafting",(%tp * -1),0);
		if (%tm > 0)
			RemoveFromBackpack(%id,"999CraftingMaterial",(%tm * -1),0);
	}
	else { 
		if (%tp > 0)
			RemoveFromBackpack(%id,"999PristineSmithing",(%tp * -1),0);
		if (%tm > 0)
			RemoveFromBackpack(%id,"999SmithingMaterial",(%tm * -1),0);
	}
	AddToBackpack(%id,%i,1);
	%msg = WhatIs(%i,%id);
	if (%msg != "Unknown Item")
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
	SaveCharacter(%id,False);
	%id.Smithing = "";	
}

function SC::CraftMagic(%id,%c,%type)
{
	if (GetConnectionId(%id) != %c)
		return;
	if (SC::HasSmithMats(%id,%type) == False)
		return;
	if (BackpackFull(%id)) {
		Client::sendMessage(%id,$msgwhite,"Your backpack is full.");
		return;
	}
	%skill = GetPlayerSkill(%id,$SkillMagicCraft);
	%smith = false;
	%ql = SC::QL(%id,%skill,%smith);
	if (%smith == false) {
		if (%id.CraftQL != "") %ql = %id.CraftQL;
	}
	else
		if (%id.SmithQL != "") %ql = %id.SmithQL;
	%countn = SC::MatCount(%id,%ql);
	%m = GetBackpackCount(%id,"999CraftingMaterial");
	%p = GetBackpackCount(%id,"999PristineCrafting");
	%tp = 0;
	%tm = 0;
	if (%p >= %countn)
		%tp = %countn;
	else if (%p < %countn) {
		%newcount = %countn;
		if (%p > 0) {
			%tp = %p;
			%tm = %countn - %p;
		}
		else
			%tm = %countn;
	}
	Client::SendMessage(%id,%msgwhite,"Using Pristine Materials: (" @ %tp @ "/" @ %p @ ")");
	Client::SendMessage(%id,%msgwhite,"Using Regular Materials: (" @ %tm @ "/" @ %m @ ")");
	%rate = %tp / %countn;
	%tier = SC::GrabTier(%rate);
	%mf = 2 + (3 * %rate);
	%item = Loot::Magic(%tier,%mf,%type);
	client::SendMessage(%id,$msgwhite,"Creating Item " @ %item);
	%i = TierItem::RandomItem(%item,%ql);
	if (%tp > 0)
		RemoveFromBackpack(%id,"999PristineCrafting",(%tp * -1),0);
	if (%tm > 0)
		RemoveFromBackpack(%id,"999CraftingMaterial",(%tm * -1),0);
	AddToBackpack(%id,%i,1);
	%msg = WhatIs(%i,%id);
	if (%msg != "Unknown Item")
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
	SaveCharacter(%id,False);
	%id.Smithing = "";	
}

function testsc(%x,%y)
{
	$PlayerBackpack[2049] = "999CraftingMaterial " @ %x @ " 999PristineCrafting " @ %y;
}

function SC::GrabTier(%rate)
{
	%mf = 256 * %rate;
	%t = 0;
	if (Loot::Ratio(1,8,%mf) == True) %t = 1;
	if (Loot::Ratio(1,16,%mf) == True) %t = 2;
	if (Loot::Ratio(1,32,%mf) == True) %t = 3;
	if (Loot::Ratio(1,64,%mf) == True) %t = 4;
	if (Loot::Ratio(1,128,%mf) == True) %t = 5;
	if (Loot::Ratio(1,256,%mf) == True) %t = 6;
	return %t;
}

function SC::TestSC(%id)
{
	$PlayerBackpack[%id] = "999SmithingMaterial 5000 999CraftingMaterial 5000 ";
}

function Plan::Add(%plan,%material,%req,%typereq,%plantier)
{
	return;
}

function Plan::Create(%new,%ql,%init)
{
	return;
}

function Plan::IsPlanItem(%item)
{
	return;
}

function AddToPlanCraft(%id,%item)
{
	return;
}

function ClearPlanCraftTable(%id,%clear)
{
	return;
}

function Game::MenuPlanCraft(%id)
{
	return;
}

function processMenuplancraft(%id, %option)
{
	return;
}

function BPPlanCraft(%id)
{
	return;
}

function CC::Backpack(%id)
{
	$PlayerBackpack[%id] = "999Page 5000 999CrystalShard 5000 999Powder 5000";
	%id.Smithing = "";
}

echo("__BACKPACK PLANS LOADED");

