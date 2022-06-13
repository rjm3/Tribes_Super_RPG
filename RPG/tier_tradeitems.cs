// TIER TRADE ITEMS

function SalvageFullCheck(%id)
{
	%bp = $PlayerBackpack[%id];
	if (getWord(%bp,($MaxBackpack + ($MaxBackpack - 2))) != -1)
		return true;
	else
		return false;
}

function SalvageAll(%id)
{
	%backpack = $PlayerBackpack[%id];
	%new = "";
	for (%i = 0; (%item = getWord(%backpack,%i)) != -1; %i+=2) {
		%v = getWord(%backpack,%i+1);
		if ($BPItem[%item,$BPMaterial] != "" && HasNoSale(%id,%item) == False && $HARDNOSELL[%item] != 1) {
			%salvage = BackpackPerformSalvage(%id,%item,true);
			%w = getWord(%salvage,0);
			%c[%w,p] += getWord(%salvage,1);
			%c[%w,m] += getWord(%salvage,2);
		}
		else
			%new = %new @ %item @ " " @ %v @ " ";
	}
	$PlayerBackpack[%id] = %new;
	Client::SendMessage(%id,0,"You salvage all your items.");
	if ((%count = %c[S,p]) > 0)
		AddToBackpack(%id,"999PristineSmithing",%count);
	if ((%count = %c[S,m]) > 0)
		AddToBackpack(%id,"999SmithingMaterial",%count);
	if ((%count = %c[C,p]) > 0)
		AddToBackpack(%id,"999PristineCrafting",%count);
	if ((%count = %c[C,m]) > 0)
		AddToBackpack(%id,"999CraftingMaterial",%count);
	//=============================================================
	if ((%count = %c[X,m]) > 0)
		AddToBackpack(%id,"999CrystalShard",%count);
	if ((%count = %c[Y,m]) > 0)
		AddToBackpack(%id,"999Page",%count);
	if ((%count = %c[Z,m]) > 0)
		AddToBackpack(%id,"999Powder",%count);
	if ((%count = %c[A,m]) > 0)
		AddToBackpack(%id,"999Dust",%count);
}

function BackpackSalvage(%id,%item)
{
	if (BackpackHasItem(%id,%item,True,False,False,False) == True) {
		if ($BPItem[%item,$BPMaterial] != "") {
			if (BackpackFull(%id,0) == False) {
				Client::SendMessage(%id,0,"You salvage " @ getBPData(%item,$BPName) @ "...");
				BackpackPerformSalvage(%id,%item);
				return;
			}
			else {
				Client::SendMessage(%id,0,"Your backpack is full.");
				return;
			}
		}
		else {
			Client::SendMessage(%id,0,"This item cannot be salvaged.");
			return;
		}
	}
	else {
		Client::SendMessage(%id,0,"You don't have this item.");
		return;
	}
}

function BackpackPerformSalvage(%id,%item,%return)
{
	%material = $BPItem[%item,$BPMaterial];
	%salvage = "";
	if ($MaterialSalvage[%material] != "")
		%salvage = $MaterialSalvage[%material];
	else
		%salvage = %material;
	%tier = GetBPData(%item,$BPItemType);
	if (%tier == "") %tier = 0;
	%ql = (string::getSubStr(%item,0,3) + 0);
	%a = round(%ql / 8);
	//==========================================================================================
	%p = 0;
	%m = 0;
	if (%tier >= 6) {
		%p = floor(%a * 0.5);
		%m = floor(%a * 0.5);
	}
	else if (%tier == 5) {
		%p = floor(%a * 0.25);
		%m = floor(%a * 0.75);
	}
	else if (%tier == 4) {
		%p = floor(%a * 0.125);
		%m = floor(%a * 0.875);
	}
	else
		%m = floor(%a * 1.0);
	//==========================================================================================
	// CRYSTALS
	if (%salvage == "CrystalShard") {
		if (!%return)
			AddToBackpack(%id,"999CrystalShard",%m);
		if (%return)
			%ret = "X 0 " @ %m;
		RemoveFromBackpack(%id,%item,-1);
	}
	// SPELLBOOKS
	if (%salvage == "Page") {
		if (!%return)
			AddToBackpack(%id,"999Page",%m);
		if (%return)
			%ret = "Y 0 " @ %m;
		RemoveFromBackpack(%id,%item,-1);
	}
	// RUNES
	if (%salvage == "Powder") {
		if (!%return)
			AddToBackpack(%id,"999Powder",%m);
		if (%return)
			%ret = "Z 0 " @ %m;
		RemoveFromBackpack(%id,%item,-1);
	}
	// MAPS
	if (%salvage == "Dust") {
		if (!%return)
			AddToBackpack(%id,"999Dust",%m);
		if (%return)
			%ret = "A 0 " @ %m;
		RemoveFromBackpack(%id,%item,-1);
	}
	//==========================================================================================
	if (%salvage == "Smithing") {
		if (%p > 0) {
			if (!%return)
				AddToBackpack(%id,"999PristineSmithing",%p);
		}
		if (%m > 0) {
			if (!%return)
				AddToBackpack(%id,"999SmithingMaterial",%m);
		}
		if (%return)
			%ret = "S " @ %p @ " " @ %m;
		RemoveFromBackpack(%id,%item,-1);
	}
	if (%salvage == "Crafting") {
		if (%p > 0) {
			if (!%return)
				AddToBackpack(%id,"999PristineCrafting",%p);
		}
		if (%m > 0) {
			if (!%return)
				AddToBackpack(%id,"999CraftingMaterial",%m);
		}
		if (%return)
			%ret = "C " @ %p @ " " @ %m;
		RemoveFromBackpack(%id,%item,-1);
	}
	//==========================================================================================
	if (!%return)
		Game::menuBackpack(%id,0);
	else
		return %ret;
}

function CreateTierTradeskill(%tname,%name,%ico,%price,%desc,%set,%single)
{
	echo(" CREATETIERTRADESKILL " @ %tname @ " " @ %name @ " " @ %ico @ " " @ %desc);

	if (%desc == "") { %desc = "This item can be used in the crafting and smithing of new items."; }

	$DynamicItem[%tname,$DName] = %name;
	if (%single != True)
		$DynamicItem[%tname,$DMinMax] = "1 300";
	else
		$DynamicItem[%tname,$DMinMax] = "999 999";
	$DynamicItem[%tname,$DWeight] = "1 0";
	$DynamicItem[%tname,$DPrice] = %price @ " 1";
	$DynamicItem[%tname,$DDesc] = %desc;
	$DynamicItem[%tname,$DItemType] = "1 Tradeskill";
	$DynamicItem[%tname,$DTier] = 1;
	$DynamicItem[%tname,$DIco] = "ico_" @ %ico @ ".bmp";
	if (%single != true)
		$DynamicItem[%tname,$DShowQLInName] = 1;

	DynamicItem::Create(%tname,999);

	if (%set == 1)
		$PLANITEMCHECK = $PLANITEMCHECK @ %tname @ " ";
}

CreateTierTradeskill("SmithingMaterial","Smithing Material","ico_smithingmaterial",1,"",1,True);
CreateTierTradeskill("PristineSmithing","Pristine Smithing","ico_smithingmaterial",1,"",1,True);
CreateTierTradeskill("CraftingMaterial","Crafting Material","ico_Craftingmaterial",1,"",1,True);
CreateTierTradeskill("PristineCrafting","Pristine Crafting","ico_Craftingmaterial",1,"",1,True);
CreateTierTradeskill("Page","Ancient Page","ico_page",1,"",1,True);
CreateTierTradeskill("CrystalShard","Crystal Shard","ico_crystalshard",1,"",1,True);
CreateTierTradeskill("Powder","Rune Powder","ico_powder",1,"",1,True);
CreateTierTradeskill("Dust","Arcane Dust","ico_dust",1,"",1,True);

CreateTierTradeskill("CommonSource","Common Source","ico_CommonSource",1,"",1);
CreateTierTradeskill("MagicSource","Magic Source","ico_MagicSource",1,"",1);
CreateTierTradeskill("RareSource","Rare Source","ico_RareSource",1,"",1);
CreateTierTradeskill("LegendarySource","Legendary Source","ico_LegendarySource",1,"",1);
CreateTierTradeskill("Gemstone","Gemstone","ico_Gemstone",1,"",1);
CreateTierTradeskill("HeavyMaterial","Heavy Material","ico_HeavyMaterial",1,"",1);
CreateTierTradeskill("LightMaterial","Light Material","ico_LightMaterial",1,"",1);
CreateTierTradeskill("SpiritMaterial","Spirit Material","ico_SpiritMaterial",1,"",1);
CreateTierTradeskill("LongBlade","Long Blade","ico_longblade",1,"",1);
CreateTierTradeskill("GiantBlade","Giant Blade","ico_giantblade",1,"",1);
CreateTierTradeskill("ShortBlade","Short Blade","ico_shortblade",1,"",1);
CreateTierTradeskill("Hammerhead","Hammerhead","ico_hammerhead",1,"",1);
CreateTierTradeskill("Bowstring","Bowstring","ico_bowstring",1,"",1);
CreateTierTradeskill("MagiStone","Magi Stone","ico_magistone",1,"",1);
CreateTierTradeskill("EmptyCrystal","Empty Crystal","ico_Emptycrystal",1,"",1);
CreateTierTradeskill("Shield","Shield","ico_shield",1,"",1);
CreateTierTradeskill("SpiritShield","SpiritShield","ico_shield",1,"",1);
CreateTierTradeskill("Quiver","Quiver","ico_quiver",1,"",1);

//===============================================================================================================================================

$MaterialSalvage[Stone] 	= "Gemstone";
$MaterialSalvage[Quartz] 	= "Gemstone";
$MaterialSalvage[Granite] 	= "Gemstone";
$MaterialSalvage[Opal] 		= "Gemstone";
$MaterialSalvage[Jade] 		= "Gemstone";
$MaterialSalvage[Turquoise] 	= "Gemstone";
$MaterialSalvage[Ruby] 		= "Gemstone";
$MaterialSalvage[Topaz] 	= "Gemstone";
$MaterialSalvage[Sapphire] 	= "Gemstone";
$MaterialSalvage[Obsidian] 	= "Gemstone";
$MaterialSalvage[Bloodstone] 	= "Gemstone";
$MaterialSalvage[Garnet] 	= "Gemstone";
$MaterialSalvage[Silver] 	= "Gemstone";
$MaterialSalvage[Gold] 		= "Gemstone";
$MaterialSalvage[Emerald] 	= "Gemstone";
$MaterialSalvage[Diamond] 	= "Gemstone";
$MaterialSalvage[Keldrinite] 	= "Gemstone";
$MaterialSalvage[Brimstone] 	= "Gemstone";

$MaterialSalvage[Pads] 		= "Smithing";
$MaterialSalvage[Leather] 	= "Smithing";
$MaterialSalvage[Hide] 		= "Smithing";
$MaterialSalvage[Scales] 	= "Smithing";
$MaterialSalvage[Chains] 	= "Smithing";
$MaterialSalvage[Bones] 	= "Smithing";
$MaterialSalvage[Rings] 	= "Smithing";
$MaterialSalvage[Bands] 	= "Smithing";
$MaterialSalvage[Splints] 	= "Smithing";
$MaterialSalvage[Bronze] 	= "Smithing";
$MaterialSalvage[Plate] 	= "Smithing";
$MaterialSalvage[Iron] 		= "Smithing";
$MaterialSalvage[Steel] 	= "Smithing";
$MaterialSalvage[Adamant] 	= "Smithing";
$MaterialSalvage[Crystal] 	= "Smithing";
$MaterialSalvage[Runite] 	= "Smithing";
$MaterialSalvage[Titanium] 	= "Smithing";
$MaterialSalvage[Mithril] 	= "Smithing";

$MaterialSalvage[Cotton] 	= "Smithing";
$MaterialSalvage[Wool] 		= "Smithing";
$MaterialSalvage[Fur] 		= "Smithing";
$MaterialSalvage[Fishscale] 	= "Smithing";
$MaterialSalvage[Deerskin] 	= "Smithing";
$MaterialSalvage[Bearskin] 	= "Smithing";
$MaterialSalvage[Wolfpelt] 	= "Smithing";
$MaterialSalvage[Sharkskin] 	= "Smithing";
$MaterialSalvage[Velvet] 	= "Smithing";
$MaterialSalvage[Silk] 		= "Smithing";
$MaterialSalvage[Bamboo] 	= "Smithing";
$MaterialSalvage[Hemp] 		= "Smithing";
$MaterialSalvage[Copper] 	= "Smithing";
$MaterialSalvage[Aluminium] 	= "Smithing";
$MaterialSalvage[Drakeflesh] 	= "Smithing";
$MaterialSalvage[Drakescale] 	= "Smithing";
$MaterialSalvage[Dragonflesh] 	= "Smithing";
$MaterialSalvage[Spirit] 	= "Smithing";

$MaterialSalvage[Apprentice] 	= "Crafting";
$MaterialSalvage[Light] 	= "Crafting";
$MaterialSalvage[Advisor] 	= "Crafting";
$MaterialSalvage[Blood] 	= "Crafting";
$MaterialSalvage[Fine] 		= "Crafting";
$MaterialSalvage[Elven] 	= "Crafting";
$MaterialSalvage[Earth] 	= "Crafting";
$MaterialSalvage[Old] 		= "Crafting";
$MaterialSalvage[Dark] 		= "Crafting";
$MaterialSalvage[Golden] 	= "Crafting";
$MaterialSalvage[Ghost] 	= "Crafting";
$MaterialSalvage[Gray] 		= "Crafting";
$MaterialSalvage[White] 	= "Crafting";
$MaterialSalvage[Sun] 		= "Crafting";
$MaterialSalvage[Moon] 		= "Crafting";
$MaterialSalvage[Forest] 	= "Crafting";
$MaterialSalvage[Vengeance] 	= "Crafting";
$MaterialSalvage[Phens] 	= "Crafting";

$MaterialSalvage[Hatchet] 	= "Smithing";
$MaterialSalvage[BroadSword] 	= "Smithing";
$MaterialSalvage[WarAxe] 	= "Smithing";
$MaterialSalvage[LongSword] 	= "Smithing";
$MaterialSalvage[BattleAxe] 	= "Smithing";
$MaterialSalvage[BastardSword] 	= "Smithing";
$MaterialSalvage[Halberd] 	= "Smithing";
$MaterialSalvage[Claymore] 	= "Smithing";

$MaterialSalvage[GiantSword] 	= "Smithing";
$MaterialSalvage[Flamberge] 	= "Smithing";
$MaterialSalvage[CrystalSword] 	= "Smithing";

$MaterialSalvage[Knife] 	= "Smithing";
$MaterialSalvage[Dagger] 	= "Smithing";
$MaterialSalvage[ShortSword] 	= "Smithing";
$MaterialSalvage[Spear] 	= "Smithing";
$MaterialSalvage[Gladius] 	= "Smithing";
$MaterialSalvage[Trident] 	= "Smithing";
$MaterialSalvage[Rapier] 	= "Smithing";
$MaterialSalvage[AwlPike] 	= "Smithing";

$MaterialSalvage[LightCrossbow] 	= "Smithing";
$MaterialSalvage[RepeatingCrossbow] 	= "Smithing";
$MaterialSalvage[HeavyCrossbow] 	= "Smithing";
$MaterialSalvage[ElvenCrossbow] 	= "Smithing";
$MaterialSalvage[Arbalest] 		= "Smithing";

$MaterialSalvage[ShortBow] 	= "Smithing";
$MaterialSalvage[LongBow] 	= "Smithing";
$MaterialSalvage[CompositeBow] 	= "Smithing";
$MaterialSalvage[ElvenBow] 	= "Smithing";
$MaterialSalvage[WingBow] 	= "Smithing";

$MaterialSalvage[Club] 			= "Smithing";
$MaterialSalvage[QuarterStaff] 		= "Smithing";
$MaterialSalvage[BoneClub] 		= "Smithing";
$MaterialSalvage[SpikedClub] 		= "Smithing";
$MaterialSalvage[Mace] 			= "Smithing";
$MaterialSalvage[HammerPick] 		= "Smithing";
$MaterialSalvage[SpikedBoneClub] 	= "Smithing";
$MaterialSalvage[LongStaff] 		= "Smithing";
$MaterialSalvage[WarHammer] 		= "Smithing";
$MaterialSalvage[GreatStaff] 		= "Smithing";
$MaterialSalvage[WarMaul] 		= "Smithing";

$MaterialSalvage[GnarledWand] 	= "Crafting";
$MaterialSalvage[BoneWand] 	= "Crafting";
$MaterialSalvage[BranchWand] 	= "Crafting";
$MaterialSalvage[IvoryWand] 	= "Crafting";
$MaterialSalvage[CrystalWand] 	= "Crafting";
$MaterialSalvage[PlatedWand] 	= "Crafting";

$MaterialSalvage[GranledStaff] 	= "Crafting";
$MaterialSalvage[OakStaff] 	= "Crafting";
$MaterialSalvage[TwistedStaff] 	= "Crafting";
$MaterialSalvage[MysticStaff] 	= "Crafting";
$MaterialSalvage[CrystalStaff] 	= "Crafting";
$MaterialSalvage[PlatedStaff] 	= "Crafting";

echo("__TIER_TRADEITEMS LOADED");