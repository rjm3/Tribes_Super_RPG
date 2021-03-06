$CREATETIERNOFLUX["CRITDAMAGE"] = 1;
$CREATETIERNOFLUX["CRITCHANCE"] = 1;
$CREATETIERNOFLUX["SPELLCRIT"] = 1;

function CreateTierWeapons(%plan,%name,%material,%damage,%perc,%damageflux,%damagetype,%main,%implicit,%critchance,%critdamage,%req,%x,%atk,%def,%ico,%delay,%twohand,%desc,%loot,%cl)
{
	// Hardcoded the damage flux here?
	%damageflux = 0.049;
	for (%i = 0; %i <= 6; %i++) {
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
		echo("[CREATETIERWEAPON] " @ %i @ " " @ %tname);
		$DynamicItem[%tname,$DName] = %vname;
		$DynamicItem[%tname,$DBaseItem] = %nn;
		$DynamicItem[%tname,$DWeaponReq] = %req;
		//==========================================================
		// CREATE DAMAGE
		if (%magic == 0) {
			%dps = %damage * %perc;
			%flux = %damage * %damageflux;
			if (%delay == 1) { %mindmgx = 1; %maxdmgx = 5; }
			if (%delay == 2) { %mindmgx = 1; %maxdmgx = 10; }
			if (%delay == 3) { %mindmgx = 1; %maxdmgx = 15; }
			$DynamicItem[%tname,$DWeaponMaxDmg] = round((%dps + %flux) + %maxdmgx);
			$DynamicItem[%tname,$DWeaponMinDmg] = round((%dps - %flux) + %mindmgx);
		}
		else {
			%dps = %damage * %perc;
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
		$DynamicItem[%tname,$DPerc] = %perc;
		//==========================================================
		// CREATE VIS
		$DynamicItem[%tname,$DVis] = getWord($WEAPONVIS[%name],%i);
		$DynamicItem[%tname,$DVisSlot] = 0;
		//==========================================================
		$DynamicItem[%tname,$DWieldBonus] = "";
		if (%magic == 1) $DynamicItem[%tname,$DItemType] = %i @ " MagicWeapon";
		else $DynamicItem[%tname,$DItemType] = %i @ " Weapon";
		$DynamicItem[%tname,$DIco] = %ico;
		$DynamicItem[%tname,$DTier] = 1;
		$DynamicItem[%tname,$DTierProp] = %i;
		%max = round(130 * %perc);
		%min = round(65 * %perc);
		$DynamicItem[%tname,$DTierPerc] = %min @ " " @ %max;
		$DynamicItem[%tname,$DTierHard] = "";
		$DynamicItem[%tname,$DWeaponDelay] = %delay;
		%newtwohand = %twohand;
		if (%twohand == 2) {
			$DynamicItem[%tname,$DRanged] = 1;
			%newtwohand = 1;
		}
		$DynamicItem[%tname,$DWeaponTwoHand] = %newtwohand;
		$DynamicItem[%tname,$DWeaponPerc] = %perc;
		$DynamicItem[%tname,$DMaterial] = %material;
		$DynamicItem[%nn,$DMaterial] = %material;
		if (%loot != -1 && %loot != "NA" && %cl != "NA") {
			AddToWeaponLoot(%tname);
			if (%cl == "")
				Loot::AddWeaponLoot(%req,%loot,%i,%tname);
			else
				Loot::AddWeaponLoot(%cl,%loot,%i,%tname);
		}
	}
	// =====================================================================
	// CREATE PLAN
	if (%plan > 0)
		Plan::Add(%nn,%material,%x,1,%plan);
}

$WEAPONLOOT = 0;
function AddToWeaponLoot(%name)
{
	$WEAPONLOOT++;
	%x = $WEAPONLOOT;
	$WEAPONLOOTITEM[%x] = %name;
}

//##############################################################################################################################################
// STARTER WEAPONS
//=================================================================================================
// SLASHING
$WEAPONNAMES["Corroded Sword"] 	= "Broken Chipped Rusted Dull Sharp Master";
$WEAPONVIS["Corroded Sword"] 	= "Claymore Claymore Claymore Claymore Claymore Claymore";
CreateTierWeapons(0,"Corroded Sword","",800,0.2,0.05,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_enemysword.bmp",2,0,"NA",-1);
// PIERCING
$WEAPONNAMES["Corroded Spike"] 	= "Broken Chipped Rusted Dull Sharp Thief";
$WEAPONVIS["Corroded Spike"] 	= "EKNIFE EKNIFE EKNIFE EKNIFE EKNIFE EKNIFE";
CreateTierWeapons(0,"Corroded Spike","",484,0.2,0.05,"Melee","CRITCHANCE",100,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_enemyknife.bmp",1,0,"NA",-1);
// WAND
$WEAPONNAMES["Twig Wand"] 	= "Splintered Leafy Weak Cracked Hard Warlock";
$WEAPONVIS["Twig Wand"] 	= "RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND";
CreateTierWeapons(0,"Twig Wand","",544,0.4,0.5,"Spell","SPELLCRIT",100,10,15,"Focus","STF","Focus","SpellResist","ico_enemywand.bmp",2,0,"",3,"NA",-1);
// BLUDGEONING
$WEAPONNAMES["Driftwood Mace"] 	= "Splintered Knotted Junk Cracked Hard Dread";
$WEAPONVIS["Driftwood Mace"] 	= "Club Club Club Club Club Club";
CreateTierWeapons(0,"Driftwood Mace","",700,0.2,0.05,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_enemymace.bmp",2,0,"NA",-1);
// BOW
$WEAPONNAMES["Pine Bow"] 	= "Splintered Knotted Junk Cracked Hard Hunter";
$WEAPONVIS["Pine Bow"] 	= "EBOW EBOW EBOW EBOW EBOW EBOW";
CreateTierWeapons(0,"Pine Bow","",300,0.2,0.05,"Projectile","ARMORPEN",3500,5,5,"Archery","WPN","Archery","Dodging","ico_enemybow.bmp",1,2,"",2,"NA",-1);
// MA STAFF
$WEAPONNAMES["Oldwood Staff"] 	= "Splintered Knotted Junk Cracked Hard Blackbelt";
$WEAPONVIS["Oldwood Staff"] 	= "QuarterStaff QuarterStaff QuarterStaff QuarterStaff QuarterStaff QuarterStaff";
CreateTierWeapons(0,"Oldwood Staff","",242,0.2,0.05,"Melee","CRITDAMAGE",75,5,30,"MartialArts","WPN","MartialArts","EvadeMelee","ico_bostaff.bmp",0.5,2,"",2,"NA",-1);
//=================================================================================================
// ENEMY WEAPONS
// SLASHING
$WEAPONNAMES["Enemy Sword"] 	= "Basic Improved Fine Magic Rare Legendary";
$WEAPONVIS["Enemy Sword"] 	= "ESWORD ESWORD ESWORD ESWORD ESWORD ESWORD";
CreateTierWeapons(0,"Enemy Sword","",800,0.5,0.1,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_enemysword.bmp",2,0,"NA",-1);
// PIERCING
$WEAPONNAMES["Enemy Knife"] 	= "Basic Improved Fine Magic Rare Legendary";
$WEAPONVIS["Enemy Knife"] 	= "EKNIFE EKNIFE EKNIFE EKNIFE EKNIFE EKNIFE";
CreateTierWeapons(0,"Enemy Knife","",440,0.5,0.1,"Melee","CRITCHANCE",100,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_enemyknife.bmp",1,0,"NA",-1);
$WEAPONNAMES["Enemy Trident"] 	= "Basic Improved Fine Magic Rare Legendary";
$WEAPONVIS["Enemy Trident"] 	= "ETRIDENT ETRIDENT ETRIDENT ETRIDENT ETRIDENT ETRIDENT";
CreateTierWeapons(0,"Enemy Trident","",500,0.6,0.1,"Melee","CRITDAMAGE",100,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_enemytrident.bmp",1,0,"NA",-1);
// BLUDGEONING
$WEAPONNAMES["Enemy Mace"] 	= "Basic Improved Fine Magic Rare Legendary";
$WEAPONVIS["Enemy Mace"] 	= "EMACE EMACE EMACE EMACE EMACE EMACE";
CreateTierWeapons(0,"Enemy Mace","",680,0.5,0.1,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_enemymace.bmp",2,0,"NA",-1);
// CROSSBOW
$WEAPONNAMES["Enemy Crossbow"] 	= "Basic Improved Fine Magic Rare Legendary";
$WEAPONVIS["Enemy Crossbow"] 	= "ECROSSBOW ECROSSBOW ECROSSBOW ECROSSBOW ECROSSBOW ECROSSBOW";
CreateTierWeapons(0,"Enemy Crossbow","",600,0.5,0.1,"Projectile","CRITDAMAGE",100,10,15,"Archery","WPN","Archery","Dodging","ico_enemycrossbow.bmp",2,1,"",2,"NA",-1);
// BOW
$WEAPONNAMES["Enemy Bow"] 	= "Basic Improved Fine Magic Rare Legendary";
$WEAPONVIS["Enemy Bow"] 	= "EBOW EBOW EBOW EBOW EBOW EBOW";
CreateTierWeapons(0,"Enemy Bow","",300,0.5,0.1,"Projectile","ARMORPEN",3500,5,5,"Archery","WPN","Archery","Dodging","ico_enemybow.bmp",1,2,"",2,"NA",-1);
// STAFF
$WEAPONNAMES["Enemy Staff"] 	= "Basic Improved Fine Magic Rare Legendary";
$WEAPONVIS["Enemy Staff"] 	= "ESTAFF ESTAFF ESTAFF ESTAFF ESTAFF ESTAFF";
CreateTierWeapons(0,"Enemy Staff","",599,0.5,0.1,"Spell","MAGICPEN",3500,5,5,"Focus","STF","Focus","SpellResist","ico_enemystaff.bmp",1,1,"NA",-1);
// WAND
$WEAPONNAMES["Enemy Wand"] 	= "Basic Improved Fine Magic Rare Legendary";
$WEAPONVIS["Enemy Wand"] 	= "EWAND EWAND EWAND EWAND EWAND EWAND";
CreateTierWeapons(0,"Enemy Wand","",544,0.5,0.1,"Spell","SPELLCRIT",100,10,15,"Focus","STF","Focus","SpellResist","ico_enemywand.bmp",1,0,"",3,"NA",-1);
//##############################################################################################################################################
// 1 HAND SLASHING
$WEAPONNAMES["Hatchet"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Broad Sword"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["War Axe"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Long Sword"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Battle Axe"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Bastard Sword"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Halberd"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Claymore"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONVIS["Hatchet"] 		= "RHATCHET RHATCHET RHATCHET RHATCHET RHATCHET RHATCHET RHATCHET";
$WEAPONVIS["Broad Sword"] 	= "RBROADSWORD RBROADSWORD RBROADSWORD RBROADSWORD RBROADSWORD RBROADSWORD RBROADSWORD";
$WEAPONVIS["War Axe"] 		= "RWARAXE RWARAXE RWARAXE RWARAXE RWARAXE RWARAXE RWARAXE";
$WEAPONVIS["Long Sword"] 	= "RLONGSWORD RLONGSWORD RLONGSWORD RLONGSWORD RLONGSWORD RLONGSWORD RLONGSWORD";
$WEAPONVIS["Battle Axe"] 	= "RBATTLEAXE RBATTLEAXE RBATTLEAXE RBATTLEAXE RBATTLEAXE RBATTLEAXE RBATTLEAXE";
$WEAPONVIS["Bastard Sword"] 	= "RBASTARDSWORD RBASTARDSWORD RBASTARDSWORD RBASTARDSWORD RBASTARDSWORD RBASTARDSWORD RBASTARDSWORD";
$WEAPONVIS["Halberd"] 		= "RHALBERD RHALBERD RHALBERD RHALBERD RHALBERD RHALBERD RHALBERD";
$WEAPONVIS["Claymore"] 		= "RCLAYMORE RCLAYMORE RCLAYMORE RCLAYMORE RCLAYMORE RCLAYMORE RCLAYMORE";
CreateTierWeapons(1,"Hatchet","Smithing",800,0.3,0.2,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_hatchet.bmp",2,0,"",1);
CreateTierWeapons(1,"Broad Sword","Smithing",800,0.4,0.2,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_broadsword.bmp",2,0,"",2);
CreateTierWeapons(2,"War Axe","Smithing",800,0.5,0.2,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_waraxe.bmp",2,0,"",3);
CreateTierWeapons(2,"Long Sword","Smithing",800,0.6,0.2,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_longsword.bmp",2,0,"",4);
CreateTierWeapons(3,"Battle Axe","Smithing",800,0.7,0.2,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_battleaxe.bmp",2,0,"",5);
CreateTierWeapons(4,"Bastard Sword","Smithing",800,0.8,0.2,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_bastardsword.bmp",2,0,"",6);
CreateTierWeapons(5,"Halberd","Smithing",800,0.9,0.2,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_halberd.bmp",2,0,"",7);
CreateTierWeapons(6,"Claymore","Smithing",800,1.0,0.2,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_claymore.bmp",2,0,"",8);

//##############################################################################################################################################
// 2 HAND SLASHING
$WEAPONNAMES["Giant Sword"] 	= "Rusty Dull Jagged Sharp Great Massive";
$WEAPONNAMES["Flamberge"] 	= "Rusty Dull Jagged Sharp Great Massive";
$WEAPONNAMES["Crystal Sword"] 	= "Cracked Chipped Jagged Sharp Great Massive";
$WEAPONNAMES["War Sword"] 	= "Rusty Dull Jagged Sharp Great Massive";
$WEAPONNAMES["Great Sword"] 	= "Rusty Dull Jagged Sharp Great Massive";
$WEAPONVIS["Giant Sword"] 	= "RGIANTSWORD RGIANTSWORD RGIANTSWORD RGIANTSWORD RGIANTSWORD RGIANTSWORD RGIANTSWORD";
$WEAPONVIS["Flamberge"] 	= "RFLAMBERGE RFLAMBERGE RFLAMBERGE RFLAMBERGE RFLAMBERGE RFLAMBERGE RFLAMBERGE";
$WEAPONVIS["Crystal Sword"] 	= "RCRYSTALSWORD RCRYSTALSWORD RCRYSTALSWORD RCRYSTALSWORD RCRYSTALSWORD RCRYSTALSWORD RCRYSTALSWORD";
$WEAPONVIS["War Sword"] 	= "RWARSWORD RWARSWORD RWARSWORD RWARSWORD RWARSWORD RWARSWORD RWARSWORD";
$WEAPONVIS["Great Sword"] 	= "RGREATSWORD RGREATSWORD RGREATSWORD RGREATSWORD RGREATSWORD RGREATSWORD RGREATSWORD";
CreateTierWeapons(2,"Giant Sword","Smithing",1440,0.6,0.25,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_giantsword.bmp",3,1,"",1,"2HSlashing");
CreateTierWeapons(3,"Flamberge","Smithing",1440,0.7,0.25,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_flamberge.bmp",3,1,"",2,"2HSlashing");
CreateTierWeapons(4,"Crystal Sword","Smithing",1440,0.8,0.25,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_crystalsword.bmp",3,1,"",3,"2HSlashing");
CreateTierWeapons(5,"War Sword","Smithing",1440,0.9,0.25,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_warsword.bmp",3,1,"",4,"2HSlashing");
CreateTierWeapons(6,"Great Sword","Smithing",1440,1.0,0.25,"Melee","ARMORPEN",3500,5,5,"Slashing","WPN","Slashing","EvadeMelee","ico_greatsword.bmp",3,1,"",5,"2HSlashing");

//##############################################################################################################################################
// PIERCING
$WEAPONNAMES["Knife"] 		= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Dagger"] 		= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Short Sword"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Spear"] 		= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Gladius"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Trident"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Rapier"] 		= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONNAMES["Awl Pike"] 	= "Rusty Dull Jagged Sharp Keen Honed";
$WEAPONVIS["Knife"] 		= "RKNIFE RKNIFE RKNIFE RKNIFE RKNIFE RKNIFE RKNIFE";
$WEAPONVIS["Dagger"] 		= "RDAGGER RDAGGER RDAGGER RDAGGER RDAGGER RDAGGER RDAGGER";
$WEAPONVIS["Short Sword"] 	= "RSHORTSWORD RSHORTSWORD RSHORTSWORD RSHORTSWORD RSHORTSWORD RSHORTSWORD RSHORTSWORD";
$WEAPONVIS["Spear"] 		= "RSPEAR RSPEAR RSPEAR RSPEAR RSPEAR RSPEAR RSPEAR";
$WEAPONVIS["Gladius"] 		= "RGLADIUS RGLADIUS RGLADIUS RGLADIUS RGLADIUS RGLADIUS RGLADIUS";
$WEAPONVIS["Trident"] 		= "RTRIDENT RTRIDENT RTRIDENT RTRIDENT RTRIDENT RTRIDENT RTRIDENT";
$WEAPONVIS["Rapier"] 		= "RRAPIER RRAPIER RRAPIER RRAPIER RRAPIER RRAPIER RRAPIER";
$WEAPONVIS["Awl Pike"] 		= "RAWLPIKE RAWLPIKE RAWLPIKE RAWLPIKE RAWLPIKE RAWLPIKE RAWLPIKE";
CreateTierWeapons(1,"Knife","Smithing",484,0.3,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_knife.bmp",1,0,"",1);
CreateTierWeapons(1,"Dagger","Smithing",484,0.4,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_dagger.bmp",1,0,"",2);
CreateTierWeapons(2,"Short Sword","Smithing",484,0.5,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_shortsword.bmp",1,0,"",3);
CreateTierWeapons(2,"Spear","Smithing",484,0.6,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_spear.bmp",1,0,"",4);
CreateTierWeapons(3,"Gladius","Smithing",484,0.7,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_gladius.bmp",1,0,"",5);
CreateTierWeapons(4,"Trident","Smithing",484,0.8,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_trident.bmp",1,0,"",6);
CreateTierWeapons(5,"Rapier","Smithing",484,0.9,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_rapier.bmp",1,0,"",7);
CreateTierWeapons(6,"Awl Pike","Smithing",484,1.0,0.3,"Melee","CRITCHANCE",150,10,15,"Piercing","WPN","Piercing","EvadeMelee","ico_awlpike.bmp",1,0,"",8);

//##############################################################################################################################################
// BLUDGEONING
$WEAPONNAMES["Club"] 			= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Spiked Club"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Mace"] 			= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Hammer Pick"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Bone Club"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Long Staff"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["War Hammer"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["War Maul"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONVIS["Club"] 			= "RCLUB RCLUB RCLUB RCLUB RCLUB RCLUB";
$WEAPONVIS["Spiked Club"] 		= "RSPIKEDCLUB RSPIKEDCLUB RSPIKEDCLUB RSPIKEDCLUB RSPIKEDCLUB RSPIKEDCLUB RSPIKEDCLUB";
$WEAPONVIS["Mace"] 			= "RMACE RMACE RMACE RMACE RMACE RMACE RMACE";
$WEAPONVIS["Hammer Pick"] 		= "RHAMMERPICK RHAMMERPICK RHAMMERPICK RHAMMERPICK RHAMMERPICK RHAMMERPICK RHAMMERPICK";
$WEAPONVIS["Bone Club"] 		= "RBONECLUB RBONECLUB RBONECLUB RBONECLUB RBONECLUB RBONECLUB RBONECLUB";
$WEAPONVIS["Long Staff"] 		= "RLONGSTAFF RLONGSTAFF RLONGSTAFF RLONGSTAFF RLONGSTAFF RLONGSTAFF RLONGSTAFF";
$WEAPONVIS["War Hammer"] 		= "RWARHAMMER RWARHAMMER RWARHAMMER RWARHAMMER RWARHAMMER RWARHAMMER RWARHAMMER";
$WEAPONVIS["War Maul"] 			= "RWARMAUL RWARMAUL RWARMAUL RWARMAUL RWARMAUL RWARMAUL RWARMAUL";
CreateTierWeapons(1,"Club","Smithing",720,0.3,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_club.bmp",2,0,"",1);
CreateTierWeapons(1,"Spiked Club","Smithing",720,0.4,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_spikedclub.bmp",2,0,"",2);
CreateTierWeapons(2,"Mace","Smithing",720,0.4,0.5,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_mace.bmp",2,0,"",3);
CreateTierWeapons(2,"Hammer Pick","Smithing",720,0.6,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_hammerpick.bmp",2,0,"",4);
CreateTierWeapons(3,"Bone Club","Smithing",720,0.7,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_boneclub.bmp",2,0,"",5);
CreateTierWeapons(4,"Long Staff","Smithing",720,0.8,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_longstaff.bmp",2,0,"",6);
CreateTierWeapons(5,"War Hammer","Smithing",720,0.9,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_warhammer.bmp",2,0,"",7);
CreateTierWeapons(6,"War Maul","Smithing",720,1.0,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_warmaul.bmp",2,0,"",8);

//##############################################################################################################################################
// CROSSBOW
$WEAPONNAMES["Light Crossbow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Hand Crossbow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Heavy Crossbow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Elven Crossbow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Arbalest"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONVIS["Light Crossbow"] 		= "RLIGHTCROSSBOW RLIGHTCROSSBOW RLIGHTCROSSBOW RLIGHTCROSSBOW RLIGHTCROSSBOW RLIGHTCROSSBOW RLIGHTCROSSBOW";
$WEAPONVIS["Hand Crossbow"] 		= "RHANDCROSSBOW RHANDCROSSBOW RHANDCROSSBOW RHANDCROSSBOW RHANDCROSSBOW RHANDCROSSBOW RHANDCROSSBOW";
$WEAPONVIS["Heavy Crossbow"] 		= "RHEAVYCROSSBOW RHEAVYCROSSBOW RHEAVYCROSSBOW RHEAVYCROSSBOW RHEAVYCROSSBOW RHEAVYCROSSBOW RHEAVYCROSSBOW";
$WEAPONVIS["Elven Crossbow"] 		= "RELVENCROSSBOW RELVENCROSSBOW RELVENCROSSBOW RELVENCROSSBOW RELVENCROSSBOW RELVENCROSSBOW RELVENCROSSBOW";
$WEAPONVIS["Arbalest"] 			= "RARBALEST RARBALEST RARBALEST RARBALEST RARBALEST RARBALEST RARBALEST";
CreateTierWeapons(2,"Light Crossbow","Smithing",600,0.6,0.3,"Projectile","CRITDAMAGE",75,10,15,"Archery","WPN","Archery","Dodging","ico_lightcrossbow.bmp",2,2,"",1,"Crossbow");
CreateTierWeapons(3,"Hand Crossbow","Smithing",600,0.7,0.3,"Projectile","CRITDAMAGE",75,10,15,"Archery","WPN","Archery","Dodging","ico_handcrossbow.bmp",2,2,"",2,"Crossbow");
CreateTierWeapons(4,"Heavy Crossbow","Smithing",600,0.8,0.3,"Projectile","CRITDAMAGE",75,10,15,"Archery","WPN","Archery","Dodging","ico_heavycrossbow.bmp",2,2,"",3,"Crossbow");
CreateTierWeapons(5,"Elven Crossbow","Smithing",600,0.9,0.3,"Projectile","CRITDAMAGE",75,10,15,"Archery","WPN","Archery","Dodging","ico_elvencrossbow.bmp",2,2,"",4,"Crossbow");
CreateTierWeapons(6,"Arbalest","Smithing",600,1.0,0.3,"Projectile","CRITDAMAGE",75,10,15,"Archery","WPN","Archery","Dodging","ico_arbalest.bmp",2,2,"",5,"Crossbow");

//##############################################################################################################################################
// BOW
$WEAPONNAMES["Short Bow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Long Bow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Composite Bow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Elven Bow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Wing Bow"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONVIS["Short Bow"] 		= "RSHORTBOW RSHORTBOW RSHORTBOW RSHORTBOW RSHORTBOW RSHORTBOW RSHORTBOW";
$WEAPONVIS["Long Bow"] 			= "RLONGBOW RLONGBOW RLONGBOW RLONGBOW RLONGBOW RLONGBOW RLONGBOW";
$WEAPONVIS["Composite Bow"] 		= "RCOMPOSITEBOW RCOMPOSITEBOW RCOMPOSITEBOW RCOMPOSITEBOW RCOMPOSITEBOW RCOMPOSITEBOW RCOMPOSITEBOW";
$WEAPONVIS["Elven Bow"] 		= "RELVENBOW RELVENBOW RELVENBOW RELVENBOW RELVENBOW RELVENBOW RELVENBOW";
$WEAPONVIS["Wing Bow"] 			= "RWINGBOW RWINGBOW RWINGBOW RWINGBOW RWINGBOW RWINGBOW RWINGBOW";
CreateTierWeapons(2,"Short Bow","Smithing",300,0.6,0.3,"Projectile","ARMORPEN",1750,5,5,"Archery","WPN","Archery","Dodging","ico_shortbow.bmp",1,2,"",1,"Bow");
CreateTierWeapons(3,"Long Bow","Smithing",300,0.7,0.3,"Projectile","ARMORPEN",1750,5,5,"Archery","WPN","Archery","Dodging","ico_longbow.bmp",1,2,"",2,"Bow");
CreateTierWeapons(4,"Composite Bow","Smithing",300,0.8,0.3,"Projectile","ARMORPEN",1750,5,5,"Archery","WPN","Archery","Dodging","ico_compositebow.bmp",1,2,"",3,"Bow");
CreateTierWeapons(5,"Elven Bow","Smithing",300,0.9,0.3,"Projectile","ARMORPEN",1750,5,5,"Archery","WPN","Archery","Dodging","ico_elvenbow.bmp",1,2,"",4,"Bow");
CreateTierWeapons(6,"Wing Bow","Smithing",300,1,0.3,"Projectile","ARMORPEN",1750,5,5,"Archery","WPN","Archery","Dodging","ico_wingbow.bmp",1,2,"",5,"Bow");

//##############################################################################################################################################
// STAFF
$WEAPONNAMES["Gnarled Staff"] 		= "Dusty Splintered Split Fractured Hardwood Dense";
$WEAPONNAMES["Bone Staff"] 		= "Old Cracked Distorted Knotted Firm Polished";
$WEAPONNAMES["Oak Staff"] 		= "Dusty Splintered Split Solid Firm Dense";
$WEAPONNAMES["Mystic Staff"] 		= "Old Cracked Dented Rigid Shining Pristene";
$WEAPONNAMES["Crystal Staff"] 		= "Old Cracked Chipped Soild Shining Bright";
$WEAPONNAMES["Plated Staff"] 		= "Rusty Scratched Dented Strong Durable Shimmering";
$WEAPONVIS["Gnarled Staff"] 		= "RGNARLEDSTAFF RGNARLEDSTAFF RGNARLEDSTAFF RGNARLEDSTAFF RGNARLEDSTAFF RGNARLEDSTAFF RGNARLEDSTAFF";
$WEAPONVIS["Bone Staff"] 		= "RBONESTAFF RBONESTAFF RBONESTAFF RBONESTAFF RBONESTAFF RBONESTAFF RBONESTAFF";
$WEAPONVIS["Oak Staff"] 		= "ROAKSTAFF ROAKSTAFF ROAKSTAFF ROAKSTAFF ROAKSTAFF ROAKSTAFF ROAKSTAFF";
$WEAPONVIS["Mystic Staff"] 		= "RMYSTICSTAFF RMYSTICSTAFF RMYSTICSTAFF RMYSTICSTAFF RMYSTICSTAFF RMYSTICSTAFF RMYSTICSTAFF";
$WEAPONVIS["Crystal Staff"] 		= "RCRYSTALSTAFF RCRYSTALSTAFF RCRYSTALSTAFF RCRYSTALSTAFF RCRYSTALSTAFF RCRYSTALSTAFF RCRYSTALSTAFF";
$WEAPONVIS["Plated Staff"] 		= "RPLATEDSTAFF RPLATEDSTAFF RPLATEDSTAFF RPLATEDSTAFF RPLATEDSTAFF RPLATEDSTAFF RPLATEDSTAFF RPLATEDSTAFF";
CreateTierWeapons(1,"Gnarled Staff","Crafting",599,0.5,0.3,"Spell","MAGICPEN",3500,5,5,"Focus","STF","Focus","SpellResist","ico_gnarledstaff.bmp",1,1,"",1);
CreateTierWeapons(2,"Bone Staff","Crafting",599,0.6,0.3,"Spell","MAGICPEN",3500,5,5,"Focus","STF","Focus","SpellResist","ico_bonestaff.bmp",1,1,"",2);
CreateTierWeapons(3,"Oak Staff","Crafting",599,0.7,0.3,"Spell","MAGICPEN",3500,5,5,"Focus","STF","Focus","SpellResist","ico_oakstaff.bmp",1,1,"",3);
CreateTierWeapons(4,"Mystic Staff","Crafting",599,0.8,0.3,"Spell","MAGICPEN",3500,5,5,"Focus","STF","Focus","SpellResist","ico_mysticstaff.bmp",1,1,"",4);
CreateTierWeapons(5,"Crystal Staff","Crafting",599,0.9,0.3,"Spell","MAGICPEN",3500,5,5,"Focus","STF","Focus","SpellResist","ico_crystalstaff.bmp",1,1,"",5);
CreateTierWeapons(6,"Plated Staff","Crafting",599,1.0,0.3,"Spell","MAGICPEN",3500,5,5,"Focus","STF","Focus","SpellResist","ico_platedstaff.bmp",1,1,"",6);

//##############################################################################################################################################
// WAND
$WEAPONNAMES["Gnarled Wand"] 		= "Dusty Splintered Split Fractured Hardwood Dense";
$WEAPONNAMES["Bone Wand"] 		= "Old Splintered Chipped Fractured Firm Polished";
$WEAPONNAMES["Oak Wand"] 		= "Dusty Splintered Split Solid Firm Dense";
$WEAPONNAMES["Mystic Wand"] 		= "Old Splintered Chipped Fractured Firm Polished";
$WEAPONNAMES["Crystal Wand"] 		= "Old Cracked Chipped Soild Shining Bright";
$WEAPONNAMES["Plated Wand"] 		= "Rusty Scratched Dented Strong Durable Shimmering";
$WEAPONVIS["Gnarled Wand"] 		= "RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND RGNARLEDWAND";
$WEAPONVIS["Bone Wand"] 		= "RBONEWAND RBONEWAND RBONEWAND RBONEWAND RBONEWAND RBONEWAND RBONEWAND";
$WEAPONVIS["Oak Wand"] 			= "ROAKWAND ROAKWAND ROAKWAND ROAKWAND ROAKWAND ROAKWAND ROAKWAND";
$WEAPONVIS["Mystic Wand"] 		= "RMYSTICWAND RMYSTICWAND RMYSTICWAND RMYSTICWAND RMYSTICWAND RMYSTICWAND RMYSTICWAND";
$WEAPONVIS["Crystal Wand"] 		= "RCRYSTALWAND RCRYSTALWAND RCRYSTALWAND RCRYSTALWAND RCRYSTALWAND RCRYSTALWAND RCRYSTALWAND";
$WEAPONVIS["Plated Wand"] 		= "RPLATEDWAND RPLATEDWAND RPLATEDWAND RPLATEDWAND RPLATEDWAND RPLATEDWAND RPLATEDWAND";
CreateTierWeapons(1,"Gnarled Wand","Crafting",544,0.5,0.5,"Spell","SPELLCRIT",150,10,15,"Focus","STF","Focus","SpellResist","ico_gnarledwand.bmp",1,0,"",1,"Wand");
CreateTierWeapons(2,"Bone Wand","Crafting",544,0.6,0.5,"Spell","SPELLCRIT",150,10,15,"Focus","STF","Focus","SpellResist","ico_bonewand.bmp",1,0,"",2,"Wand");
CreateTierWeapons(3,"Oak Wand","Crafting",544,0.7,0.5,"Spell","SPELLCRIT",150,10,15,"Focus","STF","Focus","SpellResist","ico_oakwand.bmp",1,0,"",3,"Wand");
CreateTierWeapons(4,"Mystic Wand","Crafting",544,0.8,0.5,"Spell","SPELLCRIT",150,10,15,"Focus","STF","Focus","SpellResist","ico_mysticwand.bmp",1,0,"",4,"Wand");
CreateTierWeapons(5,"Crystal Wand","Crafting",544,0.9,0.5,"Spell","SPELLCRIT",150,10,15,"Focus","STF","Focus","SpellResist","ico_crystalwand.bmp",1,0,"",5,"Wand");
CreateTierWeapons(6,"Plated Wand","Crafting",544,1.0,0.5,"Spell","SPELLCRIT",150,10,15,"Focus","STF","Focus","SpellResist","ico_platedwand.bmp",1,0,"",6,"Wand");

//##############################################################################################################################################
// MA STAVES
$WEAPONNAMES["Bo Staff"]		= "Imbalanced Cracked Weighted Balanced Stabilized Agile";
$WEAPONNAMES["Capped Staff"]		= "Bent Splintered Hardwood Quick Equalized Deft";
$WEAPONNAMES["Cedar Staff"]		= "Uneven Cracked Varnished Lacquered Heavy Impactful";
$WEAPONNAMES["Ivory Staff"]		= "Chipped Dented Polished Reified Carved Engraved";
$WEAPONNAMES["Shadewood Staff"]		= "Split Cracked Varnished Sanded Darkened Blackened";
$WEAPONVIS["Bo Staff"] 		= "BOSTAFF BOSTAFF BOSTAFF BOSTAFF BOSTAFF BOSTAFF BOSTAFF";
$WEAPONVIS["Capped Staff"] 	= "CAPPEDSTAFF CAPPEDSTAFF CAPPEDSTAFF CAPPEDSTAFF CAPPEDSTAFF CAPPEDSTAFF CAPPEDSTAFF";
$WEAPONVIS["Cedar Staff"] 	= "CEDARSTAFF CEDARSTAFF CEDARSTAFF CEDARSTAFF CEDARSTAFF CEDARSTAFF CEDARSTAFF";
$WEAPONVIS["Ivory Staff"] 	= "IVORYSTAFF IVORYSTAFF IVORYSTAFF IVORYSTAFF IVORYSTAFF IVORYSTAFF IVORYSTAFF";
$WEAPONVIS["Shadewood Staff"] 	= "SHADEWOODSTAFF SHADEWOODSTAFF SHADEWOODSTAFF SHADEWOODSTAFF SHADEWOODSTAFF SHADEWOODSTAFF SHADEWOODSTAFF";
CreateTierWeapons(2,"Bo Staff","Smithing",242,0.6,0.3,"Melee","CRITDAMAGE",75,5,30,"MartialArts","WPN","MartialArts","EvadeMelee","ico_bostaff.bmp",0.5,1,"",1);
CreateTierWeapons(3,"Capped Staff","Smithing",242,0.7,0.3,"Melee","CRITDAMAGE",75,5,30,"MartialArts","WPN","MartialArts","EvadeMelee","ico_cappedstaff.bmp",0.5,1,"",2);
CreateTierWeapons(4,"Cedar Staff","Smithing",242,0.8,0.3,"Melee","CRITDAMAGE",75,5,30,"MartialArts","WPN","MartialArts","EvadeMelee","ico_cedarstaff.bmp",0.5,1,"",3);
CreateTierWeapons(5,"Ivory Staff","Smithing",242,0.9,0.3,"Melee","CRITDAMAGE",75,5,30,"MartialArts","WPN","MartialArts","EvadeMelee","ico_ivorystaff.bmp",0.5,1,"",4);
CreateTierWeapons(6,"Shadewood Staff","Smithing",242,1.0,0.3,"Melee","CRITDAMAGE",75,5,30,"MartialArts","WPN","MartialArts","EvadeMelee","ico_shadewoodstaff.bmp",0.5,1,"",5);


function FullTestWeapons()
{
	$PlayerBackpack[2049] = "";
	%num = $WEAPONLOOT;
	echo(" [FULLTESTWEAPONS] " @ %num);
	for (%i = 1; %i <= 20; %i++) {
		%x = floor(getRandom() * %num + 1);
		%ret = $WEAPONLOOTITEM[%x];
		%d = floor(getRandom() * 300 + 1);
		%d = 5;
		%get = TierItem::RandomItem(%ret,%d);
		$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %get @ " 1 ";
	}
}

function TestWeapons()
{
	$PlayerBackpack[2049] = "";
	%weapon = TierItem::RandomItem("KnottedGreatStaff",10);
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %weapon @ " 1 ";
}

echo("__TIER_BASICWEAPONS LOADED");