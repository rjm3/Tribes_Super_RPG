$TIERNAME["Shield","MES",1] = "Poor";
$TIERNAME["Shield","MES",2] = "Worn";
$TIERNAME["Shield","MES",3] = "Reliable";
$TIERNAME["Shield","MES",4] = "Durable";
$TIERNAME["Shield","MES",5] = "Robust";
$TIERNAME["Shield","MES",6] = "Superior";

$TIERNAME["Shield","SPS",1] = "Shabby";
$TIERNAME["Shield","SPS",2] = "Stitched";
$TIERNAME["Shield","SPS",3] = "Ragged";
$TIERNAME["Shield","SPS",4] = "Eroded";
$TIERNAME["Shield","SPS",5] = "Bright";
$TIERNAME["Shield","SPS",6] = "Pure";

$TIERNAME["Quiver","QUV",1] = "Flimsy";
$TIERNAME["Quiver","QUV",2] = "Patched";
$TIERNAME["Quiver","QUV",3] = "Tattered";
$TIERNAME["Quiver","QUV",4] = "Durable";
$TIERNAME["Quiver","QUV",5] = "Stable";
$TIERNAME["Quiver","QUV",6] = "Sleek";

$TIERNAME["Shield","QUV",1] = "Flimsy";
$TIERNAME["Shield","QUV",2] = "Patched";
$TIERNAME["Shield","QUV",3] = "Tattered";
$TIERNAME["Shield","QUV",4] = "Durable";
$TIERNAME["Shield","QUV",5] = "Stable";
$TIERNAME["Shield","QUV",6] = "Sleek";

$DynamicItem["MemoryStone",$DName] = "Memory Stone";
$DynamicItem["MemoryStone",$DMinMax] = "1 300";
$DynamicItem["MemoryStone",$DWeight] = "1 0";
$DynamicItem["MemoryStone",$DPrice] = "1500";
$DynamicItem["MemoryStone",$DWield] = "LOCATION pocket" @ " NA";
$DynamicItem["MemoryStone",$DDesc] = "A memory stone";
$DynamicItem["MemoryStone",$DItemType] = "0 Pocket";
$DynamicItem["MemoryStone",$DTier] = 0;
$DynamicItem["MemoryStone",$DTierHard] = "";
$DynamicItem["MemoryStone",$DTierProp] = 0;
$DynamicItem["MemoryStone",$DTierPerc] = "100 100";
$DynamicItem["MemoryStone",$DIco] = "ico_memorystone.bmp";
$DynamicItem["MemoryStone",$DMain] = "MAM 50 100";
$DynamicItem["MemoryStone",$DReq] = "MEMWIS";
$DynamicItem["MemoryStone",$DReqName] = "MEMWIS";
$DynamicItem["MemoryStone",$DBaseItem] = "MemoryStone";
$DynamicItem["MemoryStone",$DMaterial] = "Crafting";
$DynamicItem["MemoryStone",$DQLFluxImplicit] = 1;
$DynamicItem["MemoryStone",$DIsMemStone] = 1;
$DynamicItem["MemoryStone",$DShowQLInName] = 1;

$BELTLOOT = "";
$BELTLOOTCOUNT = 0;
function CreateBelt(%name,%main,%v,%flux,%req,%materialx,%ico,%desc)
{
	%vtname = "";
	for (%i = 0; (%g = getWord(%name,%i)) != -1; %i++)
		%vtname = %vtname @ %g;
	$DynamicItem[%vtname,$DName] = %name;
	$DynamicItem[%vtname,$DMinMax] = "1 300";
	$DynamicItem[%vtname,$DWeight] = "1 0";
	$DynamicItem[%vtname,$DPrice] = "3000";
	$DynamicItem[%vtname,$DWield] = "LOCATION belt" @ " NA";
	$DynamicItem[%vtname,$DDesc] = %desc;
	$DynamicItem[%vtname,$DItemType] = "0 Belt";
	$DynamicItem[%vtname,$DTier] = 0;
	$DynamicItem[%vtname,$DTierHard] = "";
	$DynamicItem[%vtname,$DTierProp] = 0;
	$DynamicItem[%vtname,$DTierPerc] = "100 100";
	$DynamicItem[%vtname,$DIco] = %ico;
	$DynamicItem[%vtname,$DMain] = %main @ " " @ %v;
	$DynamicItem[%vtname,$DReq] = %req;
	$DynamicItem[%vtname,$DReqName] = %req;
	$DynamicItem[%vtname,$DBaseItem] = %vtname;
	$DynamicItem[%vtname,$DMaterial] = %materialx;
	$DynamicItem[%vtname,$DQLFluxImplicit] = %flux;
	$DynamicItem[%vtname,$DIsBelt] = 1;
	$DynamicItem[%vtname,$DShowQLInName] = 1;
	$BELTLOOT = $BELTLOOT @ %vtname @ " ";
	$BELTLOOTCOUNT++;
}

CreateBelt("Leather Belt","MXH","500 1000",1,"AMR","Smithing","ico_leatherbelt.bmp","Leather Belt");
CreateBelt("Chain Belt","MXM","500 1000",1,"RES","Crafting","ico_chainbelt.bmp","Chain Belt");
CreateBelt("Rustic Sash","PBD","42 85",1,"AMR","Smithing","ico_rusticsash.bmp","Rustic Sash");
CreateBelt("Verdant Sash","RRB","38 75",1,"EVA","Smithing","ico_verdantsash.bmp","Verdant Sash");
CreateBelt("Simple Sash","SPP","53 105",1,"RES","Crafting","ico_simplesash.bmp","Simple Sash");
CreateBelt("Heavy Belt","ARM","500 1000",1,"AMR","Smithing","ico_heavybelt.bmp","Heavy Belt");
CreateBelt("Light Belt","EVV","500 1000",1,"EVA","Smithing","ico_lightbelt.bmp","Light Belt");
CreateBelt("Cloth Belt","ARS","500 1000",1,"RES","Crafting","ico_clothbelt.bmp","Cloth Belt");
CreateBelt("Holy Belt","HEL","230 460",1,"AMR","Smithing","ico_holybelt.bmp","Holy Belt");

function CreateTierShield(%materialx,%type,%tname,%name,%loc,%price,%perc,%main,%req,%ico,%desc,%material,%skin,%bc,%ba,%bt)
{
	for (%i = 0; %i <= 6; %i++) {
		if (%req == "DYN" || %req == "LDYN") {
			%typereq = 1;
			if (%i != 0) {
				%vtname = $TIERNAME[%type,%i] @ %tname;
				%vname = $TIERNAME[%type,%i] @ " " @ %name;
			}
			else {
				%vtname = %tname;
				%vname = %name;
			}
		}
		else {
			%typereq = 2;
			if (%i != 0) {
				if (%req == "LAMR") %reqname = "AMR";
				else if (%req == "LEVA") %reqname = "EVA";
				else if (%req == "LARS") %reqname = "RES";
				else %reqname = %req;
				%vtname = $TIERNAME[%type,%reqname,%i] @ %tname;
				%vname = $TIERNAME[%type,%reqname,%i] @ " " @ %name;
			}
			else {
				%vtname = %tname;
				%vname = %name;
			}
		}
		AddToTestLoot(%vtname);
		$DynamicItem[%vtname,$DName] = %vname;
		$DynamicItem[%vtname,$DMinMax] = "1 300";
		$DynamicItem[%vtname,$DWeight] = "1 0";
		$DynamicItem[%vtname,$DPrice] = %price @ " " @ %price;
		$DynamicItem[%vtname,$DWield] = "LOCATION " @ %loc @ " NA";
		$DynamicItem[%vtname,$DDesc] = %desc;
		%vtype = %i @ " Shield";
		$DynamicItem[%vtname,$DItemType] = %vtype;
		$DynamicItem[%vtname,$DTier] = 1;
		$DynamicItem[%vtname,$DTierHard] = "";
		$DynamicItem[%vtname,$DTierProp] = %i;
		$DynamicItem[%vtname,$DTierPerc] = %perc;
		$DynamicItem[%vtname,$DIco] = %ico;
		$DynamicItem[%vtname,$DMain] = %main;
		$DynamicItem[%vtname,$DReq] = %req;
		$DynamicItem[%vtname,$DReqName] = %req;
		$DynamicItem[%vtname,$DBaseItem] = %tname;
		$DynamicItem[%vtname,$DMaterial] = %material;
		$DynamicItem[%vtname,$DVisType] = $BPVisItem;
		$DynamicItem[%vtname,$DVisSlot] = 2;
		$DynamicItem[%vtname,$DVis] = %skin;
		$DynamicItem[%vtname,$DMaterial] = %materialx;
		if (%type == "shield") {
			$DynamicItem[%vtname,$DBlockChance] = %bc;
			%spread = floor(%ba * 0.5);
			$DynamicItem[%vtname,$DBlockAmount] = %ba - %spread @ " " @ %ba + %spread;
			$DynamicItem[%vtname,$DBlockType] = %bt;
		}
		else if (%type == "quiver") {
			$DynamicItem[%vtname,$DIsQuiver] = 1;
			$DynamicItem[%vtname,$DQuiverDamage] = %bc;
		}
	}
	// =====================================================================
	// CREATE LOOT TABLE
	Loot::AddToLoot(%type,%req,%perc,%tname,1);
	//  =====================================================================
	// CREATE PLAN
	%conv = $SHIELDPLANCOVN[%perc];
	Plan::Add(%tname,%materialx,%req,%typereq,%conv);
}

$SHIELDPLANCOVN["1 50"] 	= 1;
$SHIELDPLANCOVN["10 60"] 	= 1;
$SHIELDPLANCOVN["20 70"] 	= 2;
$SHIELDPLANCOVN["30 80"] 	= 2;
$SHIELDPLANCOVN["40 90"] 	= 3;
$SHIELDPLANCOVN["50 100"] 	= 4;
$SHIELDPLANCOVN["60 110"] 	= 5;
$SHIELDPLANCOVN["70 120"] 	= 6;

//-----------------------------------------------------------------------------------------------------------------------

// ARMOR SHIELDS
CreateTierShield("Smithing","shield","LeatherBuckler","Leather Buckler","shield",10,"1 50","ARMOR","MES","ico_sleather.bmp","Leather Buckler","Shield","SHIELD_LEATHER","5 10",600,"PHYSICAL");
CreateTierShield("Smithing","shield","PineRoundShield","Pine Round Shield","shield",20,"10 60","ARMOR","MES","ico_spine.bmp","Pine Round Shield","Shield","SHIELD_PINE","6 11",800,"PHYSICAL");
CreateTierShield("Smithing","shield","OakKiteShield","Oak Kite Shield","shield",40,"20 70","ARMOR","MES","ico_soak.bmp","Oak Kite Shield","Shield","SHIELD_OAK","7 12",1000,"PHYSICAL");
CreateTierShield("Smithing","shield","BronzeTowerShield","Bronze Tower Shield","shield",80,"30 80","ARMOR","MES","ico_sbronze.bmp","Bronze Tower Shield","Shield","SHIELD_BRONZE","8 13",1200,"PHYSICAL");
CreateTierShield("Smithing","shield","IronBuckler","Iron Buckler","shield",160,"40 90","ARMOR","MES","ico_siron.bmp","Iron Buckler","Shield","SHIELD_IRON","9 14",1400,"PHYSICAL");
CreateTierShield("Smithing","shield","SteelRoundShield","Steel Round Shield","shield",320,"50 100","ARMOR","MES","ico_ssteel.bmp","Steel Round Shield","Shield","SHIELD_STEEL","10 15",1600,"PHYSICAL");
CreateTierShield("Smithing","shield","TitaniumKiteShield","Titanium Kite Shield","shield",640,"60 110","ARMOR","MES","ico_stitanium.bmp","Titanium Kite Shield","Shield","SHIELD_TITANIUM","11 16",1800,"PHYSICAL");
CreateTierShield("Smithing","shield","MithrilTowerShield","Mithril Tower Shield","shield",1280,"70 120","ARMOR","MES","ico_smithril.bmp","Mithril Tower Shield","Shield","SHIELD_MITHRIL","12 17",2000,"PHYSICAL");

// SPELL SHIELDS
CreateTierShield("Crafting","shield","LightSpiritShield","Light Spirit Shield","shield",10,"1 50","ALLRESIST","SPS","ico_slight.bmp","Light Spirit Shield","SpiritShield","SHIELD_LIGHT","5 10",600,"MAGICAL");
CreateTierShield("Crafting","shield","BloodSpiritShield","Blood Spirit Shield","shield",20,"10 60","ALLRESIST","SPS","ico_sblood.bmp","Blood Spirit Shield","SpiritShield","SHIELD_BLOOD","6 11",800,"MAGICAL");
CreateTierShield("Crafting","shield","ElvenSpiritShield","Elven Spirit Shield","shield",40,"20 70","ALLRESIST","SPS","ico_selven.bmp","Elven Spirit Shield","SpiritShield","SHIELD_ELVEN","7 12",1000,"MAGICAL");
CreateTierShield("Crafting","shield","EarthSpiritShield","Earth Spirit Shield","shield",80,"30 80","ALLRESIST","SPS","ico_searth.bmp","Earth Spirit Shield","SpiritShield","SHIELD_EARTH","8 13",1200,"MAGICAL");
CreateTierShield("Crafting","shield","DarkSpiritShield","Dark Spirit Shield","shield",160,"40 90","ALLRESIST","SPS","ico_sdark.bmp","Dark Spirit Shield","SpiritShield","SHIELD_DARK","9 14",1400,"MAGICAL");
CreateTierShield("Crafting","shield","MoonSpiritShield","Moon Spirit Shield","shield",320,"50 100","ALLRESIST","SPS","ico_smoon.bmp","Moon Spirit Shield","SpiritShield","SHIELD_MOON","10 15",1600,"MAGICAL");
CreateTierShield("Crafting","shield","ForestSpiritShield","Forest Spirit Shield","shield",640,"60 110","ALLRESIST","SPS","ico_sforest.bmp","Forest Spirit Shield","SpiritShield","SHIELD_FOREST","11 16",1800,"MAGICAL");
CreateTierShield("Crafting","shield","PhensSpiritShield","Phens Spirit Shield","shield",1280,"70 120","ALLRESIST","SPS","ico_sphens.bmp","Phens Spirit Shield","SpiritShield","SHIELD_PHENS","12 17",2000,"MAGICAL");

// QUIVERS
CreateTierShield("Smithing","quiver","DeerskinQuiver","Deerskin Quiver","shield",10,"1 50","ARMOR","QUV","ico_deerskinquiver","Deerskin Quiver","Quiver","QUIV_DEERSKIN",60);
CreateTierShield("Smithing","quiver","SharkskinQuiver","Sharkskin Quiver","shield",10,"10 60","ARMOR","QUV","ico_Sharkskinquiver","Sharkskin Quiver","Quiver","QUIV_SHARKSKIN",80);
CreateTierShield("Smithing","quiver","SilkQuiver","Silk Quiver","shield",10,"20 70","ARMOR","QUV","ico_Silkquiver","Silk Quiver","Quiver","QUIV_SILK",100);
CreateTierShield("Smithing","quiver","HempQuiver","Hemp Quiver","shield",10,"30 80","ARMOR","QUV","ico_Hempquiver","Hemp Quiver","Quiver","QUIV_DEERSKIN",120);
CreateTierShield("Smithing","quiver","AluminiumQuiver","Aluminium Quiver","shield",10,"40 90","ARMOR","QUV","ico_Aluminiumquiver","Aluminium Quiver","Quiver","QUIV_DEERSKIN",140);
CreateTierShield("Smithing","quiver","DrakefleshQuiver","Drakeflesh Quiver","shield",10,"50 100","ARMOR","QUV","ico_Drakefleshquiver","Drakeflesh Quiver","Quiver","QUIV_DEERSKIN",160);
CreateTierShield("Smithing","quiver","DragonfleshQuiver","Dragonflesh Quiver","shield",10,"60 110","ARMOR","QUV","ico_Dragonfleshquiver","Dragonflesh Quiver","Quiver","QUIV_DEERSKIN",180);
CreateTierShield("Smithing","quiver","SpiritQuiver","Spirit Quiver","shield",10,"70 120","ARMOR","QUV","ico_spiritquiver","Spirit Quiver","Quiver","QUIV_DEERSKIN",200);

//-----------------------------------------------------------------------------------------------------------------------

echo("__TIER_SHIELDS LOADED");