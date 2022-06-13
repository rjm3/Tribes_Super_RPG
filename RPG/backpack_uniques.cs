// UNIQUES

function CreateUniqueShield(%materialx,%type,%vtname,%vname,%hard,%loc,%price,%perc,%main,%req,%ico,%desc,%material,%skin,%bc,%ba,%bt,%tprop)
{
	echo("[CREATEUNIQUESHIELD] " @ %vname);
	$DynamicItem[%vtname,$DName] = %vname;
	$DynamicItem[%vtname,$DMinMax] = "1 300";
	$DynamicItem[%vtname,$DWeight] = "1 0";
	$DynamicItem[%vtname,$DPrice] = %price @ " " @ %price;
	$DynamicItem[%vtname,$DWield] = "LOCATION " @ %loc @ " NA";
	$DynamicItem[%vtname,$DDesc] = %desc;
	$DynamicItem[%vtname,$DItemType] = "8 Shield";
	$DynamicItem[%vtname,$DTier] = 1;
	$DynamicItem[%vtname,$DTierHard] = %hard;
	$DynamicItem[%vtname,$DTierProp] = %tprop;
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

function CreateUniqueWeapon(%name,%hard,%material,%vis,%damage,%damageflux,%damagetype,%main,%implicit,%critchance,%critdamage,%req,%x,%atk,%def,%ico,%delay,%twohand,%desc)
{
	echo("[CREATEUNIQUEWEAPON] " @ %name);
	%magic = 0;
	%nn = "";
	for (%z = 0; (%g = getWord(%name,%z)) != -1; %z++)
		%nn = %nn @ %g;
	if (%i > 0) {
		%tname = getWord($WEAPONNAMES[%name],(%i-1)) @ %nn;
		%vname = getWord($WEAPONNAMES[%name],(%i-1)) @ " " @ %name;
		$TIERNAME[%nn,%i] = getWord($WEAPONNAMES[%name],(%i-1));
	}
	else {
		%tname = %nn;
		%vname = %name;
		$TIERNAME[%name,0] = "";
	}
	if (%req == "Focus") {
		$DynamicItem[%tname,$DIsMagWeapon] = 1;
		%magic = 1;
	}
	else
		$DynamicItem[%tname,$DIsWeapon] = 1;
	$DynamicItem[%tname,$DName] = %vname;
	$DynamicItem[%tname,$DBaseItem] = %nn;
	$DynamicItem[%tname,$DWeaponReq] = %req;
	//==========================================================
	// CREATE DAMAGE
	if (%magic == 0) {
		%dps = %damage * 1.0;
		%flux = %damage * %damageflux;
		if (%delay == 1) { %mindmgx = 1; %maxdmgx = 5; }
		if (%delay == 2) { %mindmgx = 1; %maxdmgx = 10; }
		if (%delay == 3) { %mindmgx = 1; %maxdmgx = 15; }
		$DynamicItem[%tname,$DWeaponMaxDmg] = round((%dps + %flux) + %maxdmgx);
		$DynamicItem[%tname,$DWeaponMinDmg] = round((%dps - %flux) + %mindmgx);
	}
	else {
		%dps = %damage * 1.0;
		$DynamicItem[%tname,$DWeaponMagDmg] = round(%dps + 1);
	}
	//==========================================================
	// CREATE IMPLICIT
	$TierImplicit[%tname] = %implicit;
	if ($CREATETIERNOFLUX[%main] == 1)
		$TierImplicitNoFlux[%tname] = 1;
	//==========================================================
	$DynamicItem[%tname,$DDamageType] = %damagetype;
	$DynamicItem[%tname,$DWeaponCritChance] = %critchance;
	$DynamicItem[%tname,$DWeaponCritDamage] = %critdamage;
	$DynamicItem[%tname,$DMain] = %main;
	$DynamicItem[%tname,$DMinMax] = "1 300";
	$DynamicItem[%tname,$DWeight] = "1 0";
	$DynamicItem[%tname,$DPrice] = "100 0";
	$DynamicItem[%tname,$DDesc] = %desc;
	$DynamicItem[%tname,$DReq] = %x;
	$DynamicItem[%tname,$DVisType] = $BPVisItem;
	$DynamicItem[%tname,$DATKSkills] = %atk @ " 100";
	$DynamicItem[%tname,$DDEFSkills] = %def @ " 100";
	$DynamicItem[%tname,$DMBS] = %mbsmsg;
	$DynamicItem[%tname,$DPerc] = 1.0;
	//==========================================================
	// CREATE VIS
	$DynamicItem[%tname,$DVis] = %vis;
	$DynamicItem[%tname,$DVisSlot] = 0;
	//==========================================================
	$DynamicItem[%tname,$DWieldBonus] = "";
	if (%magic == 1) $DynamicItem[%tname,$DItemType] = "8 MagicWeapon";
	else $DynamicItem[%tname,$DItemType] = "8 Weapon";
	$DynamicItem[%tname,$DIco] = %ico;
	$DynamicItem[%tname,$DTier] = 1;
	$DynamicItem[%tname,$DTierProp] = 0;
	$DynamicItem[%tname,$DTierPerc] = "85 150";
	$DynamicItem[%tname,$DTierHard] = %hard;
	$DynamicItem[%tname,$DWeaponDelay] = %delay;
	%newtwohand = %twohand;
	if (%twohand == 2) {
		$DynamicItem[%tname,$DRanged] = 1;
		%newtwohand = 1;
	}
	$DynamicItem[%tname,$DWeaponTwoHand] = %newtwohand;
	$DynamicItem[%tname,$DWeaponPerc] = 1.0;
	$DynamicItem[%tname,$DMaterial] = %material;
	$DynamicItem[%nn,$DMaterial] = %material;
	$DynamicItem[%tname,$DNoInteg] = 1;
}

function CreateUniqueItem(%name,%type,%main,%req,%hard,%ico,%desc,%vis,%nointeg,%nodrop)
{
	echo("[CREATEUNIQUEITEM] " @ %name @ " " @ %type);
	%item = "";
	for (%i = 0; (%a = getWord(%name,%i)) != -1; %i++)
		%item = %item @ %a;
	//=================================================================================
	$DynamicItem[%item,$DName] = %name;
	$DynamicItem[%item,$DMinMax] = "1 300";
	$DynamicItem[%item,$DWeight] = "1 0";
	$DynamicItem[%item,$DPrice] = "100 100";
	$DynamicItem[%item,$DWield] = "LOCATION " @ %type @ " NA";
	$DynamicItem[%item,$DTierHard] = %hard;
	$DynamicItem[%item,$DIco] = %ico;
	$DynamicItem[%item,$DSet] = %set;
	$DynamicItem[%item,$DItemType] = "8 " @ %type;
	$DynamicItem[%item,$DDesc] = %desc;
	$DynamicItem[%item,$DTier] = 1;
	$DynamicItem[%item,$DMain] = %main;
	$DynamicItem[%item,$DReq] = %req;
	$DynamicItem[%item,$DTierProp] = 0;
	$DynamicItem[%item,$DTierPerc] = "100 150";
	$DynamicItem[%item,$DNoInteg] = 1;
	$DynamicItem[%item,$DNoDropFlag] = %nodrop;
	$DynamicItem[%item,$DPerc] = 1.0;
	if (%vis != "") {
		%vistype = GetWord(%vis,0);
		%visitem = GetWord(%vis,1);
		if (%vistype == "SKIN") {
			$DynamicItem[%item,$DVisType] = $BPVisSkin;
			$DynamicItem[%item,$DVis] = %visitem;
		}
	}
}
// ADMIN ITEMS
CreateUniqueWeapon("Admin Blade","INCDAMAGE% H:1000-1000 SLASHING H:20000","Smithing","RCLAYMORE",20000,0.1,"Melee","CRITCHANCE",150,10,15,"Slashing","WPN","Slashing","EvadeMelee","ico_.bmp",2,0,"Admin's Blade");
CreateUniqueItem("Admin Cloak","Armor","ALLRESIST","RES","ADDALLDEF H:20000 ADDALLOFF H:20000 MAXHP H:20000 HEALDELTA H:20000 MANADELTA H:20000 ENERGY H:20000 ARMOR H:20000 ALLRESIST H:20000 EVASION H:20000","ico_stormcloak","Admin Cloak","SKIN starwolf");

// SHIELDS
CreateUniqueShield("Smithing","shield","Meatshield","Meatshield","MAXHP L:600-1200 HEALDELTA L:50-100","shield",2560,"100 150","NON 0 0","MES","ico_.bmp","Brawn is its own type of armor","Shield","SHIELD_LEATHER","0 0",0,"PHYSICAL",0);

// WEAPONS
CreateUniqueWeapon("Model Makers Ballista","INCDAMAGE% H:50-100 ACCURACY L:450-900 ARMORPEN L:2500-5000","Smithing","RARBALEST",600,0.3,"Projectile","CRITDAMAGE",150,10,10,"Archery","WPN","Archery","Dodging","ico_.bmp",2,1,"Siege in miniature");
CreateUniqueWeapon("Crushing Mind","INTELLIGENCE L:115-230 PROJDAMAGE% H:25-50 MAGICBASICSTUN H:2-4","Crafting","UCRUSHINGMIND",544,0.0,"Spell","MAGICPEN",1000,5,5,"Focus","STF","Focus","SpellResist","ico_.bmp",0.5,0,"Sometimes it's better to be closed-minded");
CreateUniqueWeapon("From The Dark","INCDAMAGE% H:75-150 SNEAKDOUBLE H:1 MORESNEAK H:25-50 ADDDAMAGE L:100-200","Smithing","UFROMTHEDARK",572,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_.bmp",1,0,"Hiding in the black");
CreateUniqueWeapon("Plague Vector","DDPOISON H:1 INCDAMAGE% H:75-150 INCPOISON H:30-60 POISONEFFECT H:25-50","Smithing","UPLAGUEVECTOR",421,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_.bmp",1,0,"Bringer of the black death");
CreateUniqueWeapon("Will Made Manifest","MAGICDAMAGE H:100-200 NOSPELLDAMAGE H:1","Crafting","UWILLMADE",800,0.0,"Spell","MAGICPEN",1000,5,5,"Focus","STF","Focus","SpellResist","ico_.bmp",0.5,0,"Spellspeech isn't always necessary");

// RING
CreateUniqueItem("Bloodring","Ring","NON","AMR","BLOODMAGIC H:100 BLEEDCHANCE H:5-10 HEALDELTA L:30-60 MAXHP L:150-300","ico_goblinbonehelm","From blood comes power");
CreateUniqueItem("Hellhold","Ring","NON","RES","ALLRESIST L:150-300 SPELLRESISTANCE L:57-114 MAXMANA L:150-300","ico_goblinbonehelm","The flames will have to wait");

// HEAD
CreateUniqueItem("Goblin Bone Helm","Head","ARMOR","AMR","ADDALLDEF H:15 MAXHP L:1500 ARMOR L:1000 GOBEXPLODE H:1","ico_goblinbonehelm","A hard plated goblin bone helm");
CreateUniqueItem("Thundercrown","Head","ALLRESIST","RES","MAGICDAMAGE R LIGHTNINGHIT L:150-300 ENERGYDAMAGE% H:5-10","ico_.bmp","From the mind comes the greatest storm");

// CHEST
CreateUniqueItem("Well Worn Chestplate","Chest","ARMOR","AMR","SOCKET H:1 SOCKET H:1 SOCKET H:1 SOCKET H:1 SOCKET H:1 SOCKET H:1 SOCKET H:1","ico_.bmp","Beauty in simplicity");

// HANDS
CreateUniqueItem("Conduit Cuffs","Hands","ALLRESIST","RES","TAKEMINDAMAGE H:3-5 MINIONDEATH H:30-35 MINIONLIFE L:3000 MINIONANGER L:15000 MINIONDEFENSE H:1","ico_","Leadership is a two-way street");

// BOOTS
CreateUniqueItem("Screaming Slippers","Boots","EVASION","EVA","ADDALLDEF L:37-75 EVADEMELEE L:300-600 DODGING L:300-600 SPELLRESISTANCE L:115-230","ico_","Surprisingly comfortable");

// ARMOR
CreateUniqueItem("Stormcloak","Armor","ALLRESIST","RES","ALLRESIST R ADDALLDEF R MAGICDAMAGE R LIGHTNINGHIT L:150-300","ico_stormcloak","The calm before the storm","SKIN robegray");

// ORB
CreateUniqueItem("Sparkling Familiar","Orb","NON","FOCUS","MAGICPEN L:750-1500 CASTINIT L:150-300 SPELLCAPACITY L:187-375 MAGICDAMAGE H:15-30 SPELLECHO H:8-16","ico_goblinbonehelm","Watching, learning, doing");

// ADMIN ITEMS
CreateUniqueItem("Blackthorns Ring","Ring","ARMOR","AMR","MAXHP H:30000 HEALDELTA H:30000 MAXMANA H:30000 MANADELTA H:30000 PRIMALMAGIC H:30000 HOLYMAGIC H:30000 EMPOWERMENT H:30000 DARKMAGIC H:30000 LIGHTMAGIC H:30000 RITUAL H:30000 SORCERY H:30000 PROTECTION H:30000 ENCHANTMENT H:30000 MAXMEMORY H:30000","ico_blackthornsring","Blackthorns Ring");

// STARTER CRYSTALS
$BPItem["001ShadowsInTheDark",$BPName] = "Shadows in the Dark";
$BPItem["001ShadowsInTheDark",$BPWeight] = 1;
$BPItem["001ShadowsInTheDark",$BPPrice] = "1000";
$BPItem["001ShadowsInTheDark",$BPUse] = "DarkMagic 200";
$BPItem["001ShadowsInTheDark",$BPUseBonus] = "LearnSpell BlinkStrike1 LearnSpell MultiMelee1 LearnSpell BlinkStrike2";
$BPItem["001ShadowsInTheDark",$BPDesc] = " Learn all starting Dark Spells ";
$BPItem["001ShadowsInTheDark",$BPDeleteOnUse] = 1;
$BPItem["001ShadowsInTheDark",$BPIco] = ".bmp";
$BPItem["001ShadowsInTheDark",$BPItemType] = "";
$BPItem["001ShadowsInTheDark",$BPMaterial] = "CrystalShard";
















echo("__UNIQUES LOADED");