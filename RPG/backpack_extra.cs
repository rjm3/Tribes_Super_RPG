$DynamicItem[TestItem,$DName] = "Test Item";
$DynamicItem[TestItem,$DMinMax] = "1 300";
$DynamicItem[TestItem,$DWeight] = "0 0";
$DynamicItem[TestItem,$DPrice] = "0 0";
$DynamicItem[TestItem,$DWield] = "LOCATION shield NA Endurance 5000 0 LVLG 300 0 NEARFIRE 1 0";
$DynamicItem[TestItem,$DWieldBonus] = "ATK 0 0";
$DynamicItem[TestItem,$DDesc] = "TEST ITEM";
$DynamicItem[TestItem,$DVisType] = $BPVisItem;
$DynamicItem[TestItem,$DVis] = "Buckler";
$DynamicItem[TestItem,$DVisSlot] = 2;

$NameRange[Gem] = "25 Chipped 50 Partial 75 Full 100 Perfect";

$NameRange[BasicWeapon] = "0 Rusty 20 Dull 50 Basic 150 Fine 200 Excellent";

$NameRange[BasicBludge] = "0 Cracked 25 Chipped 50 Basic 75 Sturdy 100 Strong";

$DynamicItem[Emerald,$DName] = "Emerald";
$DynamicItem[Emerald,$DMinMax] = "1 300";
$DynamicItem[Emerald,$DNameRange] = $NameRange[Gem];
$DynamicItem[Emerald,$DWeight] = "0.1 0";
$DynamicItem[Emerald,$DPrice] = "100 9";
$DynamicItem[Emerald,$DCraftBonus,$DWeapon] = "Posion 3 0";
$DynamicItem[Emerald,$DCraftBonus,$DArmor] = "PosionResist 3 1";
$DynamicItem[Emerald,$DDesc] = "Emerald, can be inserted into socketed weapons";

$DynamicItem[Diamond,$DName] = "Diamond";
$DynamicItem[Diamond,$DMinMax] = "1 300";
$DynamicItem[Diamond,$DNameRange] = $NameRange[Gem];
$DynamicItem[Diamond,$DWeight] = "0.1 0";
$DynamicItem[Diamond,$DPrice] = "100 9";
$DynamicItem[Diamond,$DCraftBonus,$DWeapon] = "ATK 1 0.1";
$DynamicItem[Diamond,$DCraftBonus,$DArmor] = "SpellResistance 10 1";
$DynamicItem[Diamond,$DDesc] = "Diamond, can be inserted into socketed weapons";
$DynamicItem[Diamond,$DIco] = "ico_diamond.bmp";

$DynamicItem[Knife3Socket,$DName] = "Knife (3)";
$DynamicItem[Knife3Socket,$DMinMax] = "1 50";
$DynamicItem[Knife3Socket,$DWeight] = "0.5 0";
$DynamicItem[Knife3Socket,$DPrice] = "100 9";
$DynamicItem[Knife3Socket,$DWield] = "LOCATION weapon NA Piercing 0 1";
$DynamicItem[Knife3Socket,$DWieldBonus] = "ATK 19 0.09";
$DynamicItem[Knife3Socket,$DDesc] = "A basic knife with 3 insert sockets";
$DynamicItem[Knife3Socket,$DVisType] = $BPVisItem;
$DynamicItem[Knife3Socket,$DVis] = "Knife";
$DynamicItem[Knife3Socket,$DVisSlot] = 0;

$DynamicItem[TitaniumHammer,$DName] = "Titanium Hammer";
$DynamicItem[TitaniumHammer,$DNameRange] = $NameRange[BasicBludge];
$DynamicItem[TitaniumHammer,$DMinMax] = "1 300";
$DynamicItem[TitaniumHammer,$DWeight] = "0.5 0";
$DynamicItem[TitaniumHammer,$DPrice] = "100 9";
$DynamicItem[TitaniumHammer,$DWield] = "LOCATION weapon NA Bludgeoning 10 6.7";
$DynamicItem[TitaniumHammer,$DDamage] = "3 0.1 7 0.1";
$DynamicItem[TitaniumHammer,$DDesc] = "Titanium Hammer";
$DynamicItem[TitaniumHammer,$DATKSkills] = "Bludgeoning 105";
$DynamicItem[TitaniumHammer,$DDEFSkills] = "Dodging 100";
$DynamicItem[TitaniumHammer,$DVisType] = $BPVisItem;
$DynamicItem[TitaniumHammer,$DVis] = "TitanHammer";
$DynamicItem[TitaniumHammer,$DVisSlot] = 0;

$DynamicItem[EagleStaff,$DName] = "Eagle Staff";
$DynamicItem[EagleStaff,$DNameRange] = $NameRange[BasicBludge];
$DynamicItem[EagleStaff,$DMinMax] = "1 300";
$DynamicItem[EagleStaff,$DWeight] = "0.5 0";
$DynamicItem[EagleStaff,$DPrice] = "513 15";
$DynamicItem[EagleStaff,$DWield] = "LOCATION weapon NA Bludgeoning 1 3.1 OffensiveCasting 1 3.1";
$DynamicItem[EagleStaff,$DDamage] = "325 2 355 2";
$DynamicItem[EagleStaff,$DWieldBonus] = "OffensiveCasting 1 0.2";
$DynamicItem[EagleStaff,$DDesc] = "Staff of the Great Eagle";
$DynamicItem[EagleStaff,$DATKSkills] = "Bludgeoning 50 OffensiveCasting 50";
$DynamicItem[EagleStaff,$DDEFSkills] = "SpellResistance 100";
$DynamicItem[EagleStaff,$DVisType] = $BPVisItem;
$DynamicItem[EagleStaff,$DVis] = "EagleStaff";
$DynamicItem[EagleStaff,$DVisSlot] = 0;


$DynamicItem[BloodOrb,$DName] = "Blood Orb";
$DynamicItem[BloodOrb,$DNameRange] = $NameRange[BasicBludge];
$DynamicItem[BloodOrb,$DMinMax] = "1 300";
$DynamicItem[BloodOrb,$DWeight] = "0.5 0";
$DynamicItem[BloodOrb,$DPrice] = "400 9";
$DynamicItem[BloodOrb,$DWield] = "LOCATION weapon NA Bludgeoning 1 6.7";
$DynamicItem[BloodOrb,$DDamage] = "1 0.1 8 0.1";
$DynamicItem[BloodOrb,$DWieldBonus] = "Healing 1 0.1 LEECH 1 0.1";
$DynamicItem[BloodOrb,$DDesc] = "Blood Orb";
$DynamicItem[BloodOrb,$DATKSkills] = "Bludgeoning 100";
$DynamicItem[BloodOrb,$DDEFSkills] = "Dodging 100";
$DynamicItem[BloodOrb,$DVisType] = $BPVisItem;
$DynamicItem[BloodOrb,$DVis] = "RedOrb";
$DynamicItem[BloodOrb,$DVisSlot] = 0;

$DynamicItem[CrystalSword,$DName] = "Crystal Sword";
$DynamicItem[CrystalSword,$DNameRange] = $NameRange[BasicBludge];
$DynamicItem[CrystalSword,$DMinMax] = "1 300";
$DynamicItem[CrystalSword,$DWeight] = "0.5 0";
$DynamicItem[CrystalSwordr,$DPrice] = "100 9";
$DynamicItem[CrystalSword,$DWield] = "LOCATION weapon NA Bludgeoning 10 6.7";
$DynamicItem[CrystalSword,$DDamage] = "3 0.1 7 0.1";
$DynamicItem[CrystalSword,$DDesc] = "Crystal Sword";
$DynamicItem[CrystalSword,$DATKSkills] = "Bludgeoning 105";
$DynamicItem[CrystalSword,$DDEFSkills] = "Dodging 100";
$DynamicItem[CrystalSword,$DVisType] = $BPVisItem;
$DynamicItem[CrystalSword,$DVis] = "CrystalSword";
$DynamicItem[CrystalSword,$DVisSlot] = 0;

$DynamicItem[Scythe,$DName] = "Scythe";
$DynamicItem[Scythe,$DNameRange] = $NameRange[Scythe];
$DynamicItem[Scythe,$DMinMax] = "1 300";
$DynamicItem[Scythe,$DWeight] = "0.5 0";
$DynamicItem[Scythe,$DPrice] = "100 9";
$DynamicItem[Scythe,$DWield] = "LOCATION weapon NA Slashing 10 6.7";
$DynamicItem[Scythe,$DDamage] = "3 0.1 7 0.1";
$DynamicItem[Scythe,$DDesc] = "Scythe";
$DynamicItem[Scythe,$DATKSkills] = "Slashing 100";
$DynamicItem[Scythe,$DDEFSkills] = "EvadeMelee 100";
$DynamicItem[Scythe,$DVisType] = $BPVisItem;
$DynamicItem[Scythe,$DVis] = "Scythe";
$DynamicItem[Scythe,$DVisSlot] = 0;

$DynamicItem[Sabre,$DName] = "Sabre";
$DynamicItem[Sabre,$DNameRange] = $NameRange[Scythe];
$DynamicItem[Sabre,$DMinMax] = "1 300";
$DynamicItem[Sabre,$DWeight] = "0.5 0";
$DynamicItem[Sabre,$DPrice] = "100 9";
$DynamicItem[Sabre,$DWield] = "LOCATION weapon NA Bludgeoning 10 6.7";
$DynamicItem[Sabre,$DDamage] = "3 0.1 7 0.1";
$DynamicItem[Sabre,$DDesc] = "Scythe";
$DynamicItem[Sabre,$DATKSkills] = "Slashing 150";
$DynamicItem[Sabre,$DDEFSkills] = "Dodging 100";
$DynamicItem[Sabre,$DVisType] = $BPVisItem;
$DynamicItem[Sabre,$DVis] = "Sabre";
$DynamicItem[Sabre,$DVisSlot] = 0;

$DynamicItem[Knife,$DName] = "Knife";
$DynamicItem[Knife,$DNameRange] = $NameRange[BasicWeapon];
$DynamicItem[Knife,$DMinMax] = "1 200";
$DynamicItem[Knife,$DWeight] = "0.5 0";
$DynamicItem[Knife,$DPrice] = "100 9";
$DynamicItem[Knife,$DWield] = "LOCATION weapon NA Piercing 0 9";
$DynamicItem[Knife,$DDamage] = "1 0.25 6 0.65";
$DynamicItem[Knife,$DDamageType] = "MeleeAC";
$DynamicItem[Knife,$DDesc] = "A basic knife";
$DynamicItem[Knife,$DVisType] = $BPVisItem;
$DynamicItem[Knife,$DATKSkills] = "Piercing 100";
$DynamicItem[Knife,$DDEFSkills] = "EvadeMelee 100";
$DynamicItem[Knife,$DMBS] = "100 1.5";
$DynamicItem[Knife,$DVis] = "Knife";
$DynamicItem[Knife,$DVisSlot] = 0;

$DynamicItem[ShortBow,$DName] = "Short Bow";
$DynamicItem[ShortBow,$DMinMax] = "1 50";
$DynamicItem[ShortBow,$DWeight] = "0.5 0";
$DynamicItem[ShortBow,$DPrice] = "100 9";
$DynamicItem[ShortBow,$DWield] = "LOCATION weapon NA Archery 0 1";
$DynamicItem[ShortBow,$DWieldBonus] = "ATK 12 0.09";
$DynamicItem[ShortBow,$DDesc] = "A basic shortbow";
$DynamicItem[ShortBow,$DVisType] = $BPVisItem;
$DynamicItem[ShortBow,$DVis] = "ShortBow";
$DynamicItem[ShortBow,$DVisSlot] = 0;
$DynamicItem[ShortBow,$DRanged] = $Bow;

$DynamicItem[WoodenBuckler,$DName] = "Wooden Buckler";
$DynamicItem[WoodenBuckler,$DMinMax] = "1 300";
$DynamicItem[WoodenBuckler,$DWeight] = "10 0";
$DynamicItem[WoodenBuckler,$DPrice] = "5000 250";
$DynamicItem[WoodenBuckler,$DWield] = "LOCATION shield NA Endurance 5 3";
$DynamicItem[WoodenBuckler,$DWieldBonus] = "DEF 10 1";
$DynamicItem[WoodenBuckler,$DDesc] = "A small shield made from wood";
$DynamicItem[WoodenBuckler,$DVisType] = $BPVisItem;
$DynamicItem[WoodenBuckler,$DVis] = "Buckler";
$DynamicItem[WoodenBuckler,$DVisSlot] = 2;

$DynamicItem[BasicArrow,$DName] = "Basic Arrow";
$DynamicItem[BasicArrow,$DMinMax] = "1 50";
$DynamicItem[BasicArrow,$DWeight] = "0.5 0";
$DynamicItem[BasicArrow,$DPrice] = "100 9";
$DynamicItem[BasicArrow,$DUse] = "LVLG 0 0";
$DynamicItem[BasicArrow,$DUseBonus] = "LOADPROJECTILE 1 NA";
$DynamicItem[BasicArrow,$DDesc] = "Basic arrow, very low ATK rating";
$DynamicItem[BasicArrow,$DProjectile] = $Bow;
$DynamicItem[BasicArrow,$DATK] = "7 0.09";

$DynamicItem[VialOfVenom,$DName] = "Vial Of Venom";
$DynamicItem[VialOfVenom,$DIco] = "ico_vial.bmp";
$DynamicItem[VialOfVenom,$DMinMax] = "1 1";
$DynamicItem[VialOfVenom,$DWeight] = "1 0";
$DynamicItem[VialOfVenom,$DPrice] = "500 0";
$DynamicItem[VialOfVenom,$DDesc] = "A vial of giant snake venom, maybe it can be used for something.";

$DynamicItem[SilverRing,$DName] = "Silver Ring";
$DynamicItem[SilverRing,$DMinMax] = "999 999";
$DynamicItem[SilverRing,$DIco] = "ico_silverring.bmp";
$DynamicItem[SilverRing,$DWeight] = "1 0";
$DynamicItem[SilverRing,$DPrice] = "750 0";
$DynamicItem[SilverRing,$DWield] = "LOCATION ring NA";
$DynamicItem[SilverRing,$DWieldBonus] = "MaxHP 5 0";
$DynamicItem[SilverRing,$DDesc] = "A silver ring, seems rare.";

$DynamicItem[EnchantedSilverRing,$DName] = "Enchanted Silver Ring";
$DynamicItem[EnchantedSilverRing,$DMinMax] = "999 999";
$DynamicItem[EnchantedSilverRing,$DIco] = "ico_silverring.bmp";
$DynamicItem[EnchantedSilverRing,$DWeight] = "1 0";
$DynamicItem[EnchantedSilverRing,$DPrice] = "9000 0";
$DynamicItem[EnchantedSilverRing,$DWield] = "LOCATION ring NA";
$DynamicItem[EnchantedSilverRing,$DWieldBonus] = "MaxHP 50 0 DEF 3 0";
$DynamicItem[EnchantedSilverRing,$DDesc] = "This is a great ring.";

$DynamicItem[EnchantmentScroll,$DName] = "Enchantment Scroll";
$DynamicItem[EnchantmentScroll,$DIco] = "ico_scroll.bmp";
$DynamicItem[EnchantmentScroll,$DMinMax] = "999 999";
$DynamicItem[EnchantmentScroll,$DWeight] = "1 0";
$DynamicItem[EnchantmentScroll,$DPrice] = "0 0";
$DynamicItem[EnchantmentScroll,$DDesc] = "Ancient text is written on this, it holds great power";

$DynamicItem[BluePotion,$DName] = "Blue Potion";
$DynamicItem[BluePotion,$DIco] = "ico_bluepot.bmp";
$DynamicItem[BluePotion,$DMinMax] = "1 300";
$DynamicItem[BluePotion,$DWeight] = "0.1 0";
$DynamicItem[BluePotion,$DPrice] = "10 1";
$DynamicItem[BluePotion,$DUse] = "SKILLUNLOCK Healing NA";
$DynamicItem[BluePotion,$DUseBonus] = "HEAL 10 2 DURATION 10 NA LOCKSKILL Healing NA";
$DynamicItem[BluePotion,$DDesc] = "A small blue potion that will restore your health";
$DynamicItem[BluePotion,$DDeleteOnUse] = 1;

$DynamicItem[EnergyVial,$DName] = "Energy Vial";
$DynamicItem[EnergyVial,$DIco] = "ico_envial.bmp";
$DynamicItem[EnergyVial,$DMinMax] = "1 300";
$DynamicItem[EnergyVial,$DWeight] = "0.1 0";
$DynamicItem[EnergyVial,$DPrice] = "10 1";
$DynamicItem[EnergyVial,$DUse] = "SKILLUNLOCK Energy NA";
$DynamicItem[EnergyVial,$DUseBonus] = "HEALMP 12 2 DURATION 15 NA LOCKSKILL Energy NA";
$DynamicItem[EnergyVial,$DDesc] = "A small energy vial that will restore some mana";
$DynamicItem[EnergyVial,$DDeleteOnUse] = 1;



//-----------------------------------------------------------------------

// TEST SPELL CRYSTAL

$BPItem["001SCAbilityBoost",$BPName] = "Crystal: Ability Boost";
$BPItem["001SCAbilityBoost",$BPWeight] = 1;
$BPItem["001SCAbilityBoost",$BPPrice] = 1600;
$BPItem["001SCAbilityBoost",$BPUse] = "NeutralCasting 5";
$BPItem["001SCAbilityBoost",$BPUseBonus] = "LearnSpell AbilityBoost";
$BPItem["001SCAbilityBoost",$BPDesc] = "Using this crystal will cause you to learn spell: Ability Boost";
$BPDeleteOnUse["001SCAbilityBoost"] = 1;
$BPItem["001SCAbilityBoost",$BPIco] = "sc_blue.bmp";

$BPItem["001SCPrayer1",$BPName] = "Crystal: Prayer (Minor)";
$BPItem["001SCPrayer1",$BPWeight] = 1;
$BPItem["001SCPrayer1",$BPPrice] = 1300;
$BPItem["001SCPrayer1",$BPUse] = "CLASS Cleric DefensiveCasting 5";
$BPItem["001SCPrayer1",$BPUseBonus] = "LearnSpell Prayer1";
$BPItem["001SCPrayer1",$BPDesc] = "Using this crystal will cause you to learn spell: Prayer 1";
$BPDeleteOnUse["001SCPrayer1"] = 1;
$BPItem["001SCPrayer1",$BPIco] = "sc_red.bmp";

//-----------------------------------------------------------------------

//----------------------------------------------------------------------

$BPItem[SealedQuiverBasic,$BPName] = "Sealed Quiver (Basic)";
$BPItem[SealedQuiverBasic,$BPWeight] = 52.5;
$BPItem[SealedQuiverBasic,$BPPrice] = 550;
$BPItem[SealedQuiverBasic,$BPUse] = "LVLG 0";
$BPItem[SealedQuiverBasic,$BPUseBonus] = "BasicArrow 500";
$BPItem[SealedQuiverBasic,$BPDesc] = "A sealed quiver of 500 Basic Arrows. Use to open.";
$BPDeleteOnUse[SealedQuiverBasic] = 1;
$AreaText[SealedQuiverBasic] = "* opens a quiver of arrows.";

$BPItem[SealedQuiverSheaf,$BPName] = "Sealed Quiver (Sheaf)";
$BPItem[SealedQuiverSheaf,$BPWeight] = 52.5;
$BPItem[SealedQuiverSheaf,$BPPrice] = 28550;
$BPItem[SealedQuiverSheaf,$BPUse] = "LVLG 0";
$BPItem[SealedQuiverSheaf,$BPUseBonus] = "SheafArrow 500";
$BPItem[SealedQuiverSheaf,$BPDesc] = "A sealed quiver of 500 Sheaf Arrows. Use to open.";
$BPDeleteOnUse[SealedQuiverSheaf] = 1;
$AreaText[SealedQuiverSheaf] = "* opens a quiver of arrows.";

$BPItem[SealedQuiverBladed,$BPName] = "Sealed Quiver (Bladed)";
$BPItem[SealedQuiverBladed,$BPWeight] = 52.5;
$BPItem[SealedQuiverBladed,$BPPrice] = 49550;
$BPItem[SealedQuiverBladed,$BPUse] = "LVLG 0";
$BPItem[SealedQuiverBladed,$BPUseBonus] = "BladedArrow 500";
$BPItem[SealedQuiverBladed,$BPDesc] = "A sealed quiver of 500 Bladed Arrows. Use to open.";
$BPDeleteOnUse[SealedQuiverBladed] = 1;
$AreaText[SealedQuiverBladed] = "* opens a quiver of arrows.";

//---------------------------------------------------------------------

$BPItem[StarOfPunishment,$BPName] = "Star of Punishment";
$BPItem[StarOfPunishment,$BPWeight] = 0.1;
$BPItem[StarOfPunishment,$BPPrice] = 50000;
$BPItem[StarOfPunishment,$BPWield] = "LOCATION orb";
$BPItem[StarOfPunishment,$BPWieldBonus] = "DEF 50";
$BPItem[StarOfPunishment,$BPDesc] = "Rise of Darkness";
$BPItem[StarOfPunishment,$BPVisType] = $BPVisItem;
$BPItem[StarOfPunishment,$BPVisSlot] = $MountPointVisual[Orb];
$BPItem[StarOfPunishment,$BPVis] = "StarOrbBlue";

//-----------------------------------------------------------------------

$LootGroup[starters,1] = "Leather";
$LootGroup[starters,2] = "SnakeSkin";
$LootGroup[starters,3] = "SteelPlate";
$LootGroup[starters,4] = "ChainMesh";

//-----------------------------------------------------------------------

$DynamicItem["DragonAmulet",$DName] = "Dragon Amulet";
$DynamicItem["DragonAmulet",$DMinMax] = "1 300";
$DynamicItem["DragonAmulet",$DWeight] = "1 0";
$DynamicItem["DragonAmulet",$DPrice] = "5 0.504";
$DynamicItem["DragonAmulet",$DWield] = "LOCATION amulet NA";
$DynamicItem["DragonAmulet",$DDesc] = "The Black Dragon will fly high!";
$DynamicItem["DragonAmulet",$DItemType] = "2 Amulet";
$DynamicItem["DragonAmulet",$DTier] = 1;
$DynamicItem["DragonAmulet",$DTierHard] = "";
$DynamicItem["DragonAmulet",$DTierProp] = 2;

//-----------------------------------------------------------------------

function TierItem::RandomItem_UNUSED(%item,%ql)
{
	%s = "";
	%n = $DynamicItem[%item,$DName];
	%h = $DynamicItem[%item,$DTierHard];
	%p = $DynamicItem[%item,$DTierProp];
	%x = $DynamicItem[%item,$DItemType];
	%x = getWord(%x,1);
	%numr = $TierRandom[%x];
	if (%h != "")
		%s = %h;
	for (%i = 1; %i <= %p; %i++) {
		%r = floor(getRandom() * %numr + 1);
		if (%r < 10) %s = %s @ "0" @ %r;
		else %s = %s @ %r;
	}
	%perc = $DynamicItem[%item,$DTierPerc];
	%min = getWord(%perc,0);
	%max = getWord(%perc,1);
	%ranp = floor((getRandom() * ((%max - %min)+ 1)) + %min);
	echo(" RANP " @ %ranp);
	echo("=================================");
	%full = %ql @ %item @ "^" @ %s @ "%" @ %ranp;
	echo(%ql @ %item @ "^" @ %s @ "%" @ %ranp);
	echo("=================================");
	TierItem::Create(%full,%x);
	return %full;
}

$BPSkillDisp[1] = "Slashing";
$BPSkillDisp[2] = "Piercing";
$BPSkillDisp[3] = "Bludgeoning";
$BPSkillDisp[4] = "DodgeRanged";
$BPSkillDisp[5] = "WeightCapacity";
$BPSkillDisp[6] = "Bashing";
$BPSkillDisp[7] = "Stealing";
$BPSkillDisp[8] = "Hiding";
$BPSkillDisp[9] = "SneakAttack";
$BPSkillDisp[10] = "OffensiveCasting";
$BPSkillDisp[11] = "DefensiveCasing";
$BPSkillDisp[12] = "SpellResistance";
$BPSkillDisp[13] = "Healing";
$BPSkillDisp[14] = "Archery";
$BPSkillDisp[15] = "Endurance";
$BPSkillDisp[16] = "MartialArts";
$BPSkillDisp[17] = "Mining";
$BPSkillDisp[18] = "Speech";
$BPSkillDisp[19] = "SenseHeading";
$BPSkillDisp[20] = "Energy";
$BPSkillDisp[21] = "Haggling";
$BPSkillDisp[22] = "NeutralCasting";
$BPSkillDisp[23] = "Strength";
$BPSkillDisp[24] = "Stamina";
$BPSkillDisp[25] = "Agility";
$BPSkillDisp[26] = "Intelligence";
$BPSkillDisp[27] = "Sense";
$BPSkillDisp[28] = "Psychic";
$BPSkillDisp[29] = "CastInit";
$BPSkillDisp[30] = "Literacy";
$BPSkillDisp[31] = "Smithing";
$BPSkillDisp[32] = "MagicCraft";
$BPSkillDisp[33] = "Alchemy";
$BPSkillDisp[34] = "Focus";
$BPSkillDisp[35] = "RunSpeed";
$BPSkillDisp[36] = "EvadeMelee";
$BPSkillDisp[37] = "Aiming";
$BPSkillDisp[38] = "Brawling";
$BPSkillDisp[39] = "Cleave";
$BPSkillDisp[40] = "DivineCasting";


$BPBonusDisp[1] = "Add EXP %";
$BPBonusDisp[2] = "Add Gold %";
$BPBonusDisp[3] = "Add Rank %";
$BPBonusDisp[4] = "Add SP %";
$BPBonusDisp[5] = "Add LCK %";
$BPBonusDisp[6] = "Add All Offense";
$BPBonusDisp[7] = "Add All Defense";
$BPBonusDisp[8] = "MDEF";
$BPBonusDisp[9] = "Max Health";
$BPBonusDisp[10] = "Max Mana";
$BPBonusDisp[11] = "Max Weight";
$BPBonusDisp[12] = "Heal Detla";
$BPBonusDisp[13] = "Mana Delta";
$BPBonusDisp[14] = "Shield %";
$BPBonusDisp[15] = "Reflect %";
$BPBonusDisp[16] = "Block Hit %";
$BPBonusDisp[17] = "Melee AC";
$BPBonusDisp[18] = "Projectile AC";
$BPBonusDisp[19] = "Fire AC";
$BPBonusDisp[20] = "Cold AC";
$BPBonusDisp[21] = "Energy AC";
$BPBonusDisp[22] = "Poison AC";
$BPBonusDisp[23] = "Add Critical %";
$BPBonusDisp[24] = "ATK Decrease %";
$BPBonusDisp[25] = "DEF Decrease %";
$BPBonusDisp[26] = "Add Mana Cost %";
$BPBonusDisp[27] = "Absorb Damage";

$ExpBonus 		= 1;
$GoldBonus 		= 2;
$RankBonus 		= 3;
$SpBonus 		= 4;
$LckBonus 		= 5;
$BPATKBonus		= 6;
$BPDEFBonus 		= 7;
$BPMDEFBonus 		= 8;
$BPMaxHPBonus 		= 9;
$BPMaxManaBonus 	= 10;
$BPMaxWeightBonus 	= 11;
$BPHealDeltaBonus 	= 12;
$BPManaDeltaBonus 	= 13;
$BPShieldBonus 		= 14;
$BPReflectBonus 	= 15;
$BPBlockBonus 		= 16;
$BPMeleeAC		= 17;
$BPProjectileAC 	= 18;
$BPFireAC 		= 19;
$BPColdAC 		= 20;
$BPEnergyAC 		= 21;
$BPPoisonAC 		= 22;
$BPCriticalChance	= 23;
$BPATKDecrease 		= 24;
$BPDEFDecrease 		= 25;
$BPManaCost		= 26;
$BPAbsorb		= 27;

$BPBonusToNumeric["EXP%"] 		= $ExpBonus;
$BPBonusToNumeric["Gold%"] 		= $GoldBonus;
$BPBonusToNumeric["Rank%"] 		= $RankBonus;
$BPBonusToNumeric["SP%"] 		= $SpBonus;
$BPBonusToNumeric["LCK%"] 		= $LckBonus;
$BPBonusToNumeric["ATK"] 		= $BPATKBonus;
$BPBonusToNumeric["DEF"] 		= $BPDEFBonus;
$BPBonusToNumeric["MDEF"] 		= $BPMDEFBonus;
$BPBonusToNumeric["MaxHP"] 		= $BPMaxHPBonus;
$BPBonusToNumeric["MaxMana"] 		= $BPMaxManaBonus;
$BPBonusToNumeric["MaxWeight"] 		= $BPMaxWeightBonus;
$BPBonusToNumeric["HealDelta"] 		= $BPHealDeltaBonus;
$BPBonusToNumeric["ManaDelta"] 		= $BPManaDeltaBonus;
$BPBonusToNumeric["SHIELD"] 		= $BPShieldBonus;
$BPBonusToNumeric["Reflect%"] 		= $BPReflectBonus;
$BPBonusToNumeric["Block%"] 		= $BPBlockBonus;
$BPBonusToNumeric["MeleeAC"] 		= $BPMeleeAC;
$BPBonusToNumeric["ProjectileAC"] 	= $BPProjectileAC;
$BPBonusToNumeric["FireAC"] 		= $BPFireAC;
$BPBonusToNumeric["ColdAC"] 		= $BPColdAC;
$BPBonusToNumeric["EnergyAC"] 		= $BPEnergyAC;
$BPBonusToNumeric["PoisonAC"] 		= $BPPoisonAC;
$BPBonusToNumeric["CRITICALCHANCE"] 	= $BPCriticalBonus;
$BPBonusToNumeric["ATKDEC"] 		= $BPATKDecrease;
$BPBonusToNumeric["DEFDEC"] 		= $BPDEFDecrease;
$BPBonusToNumeric["MANACOST"] 		= $BPManaCost;
$BPBonusToNumeric["ABSORB"] 		= $BPAbsorb;



$BPFormat["EXP%"] = "Add Exp";
$BPFormat["GOLD%"] = "Gold Find";
$BPFormat["RANK%"] = "Add Rank";
$BPFormat["SP%"] = "Add SP";
$BPFormat["LCK%"] = "Add LCK";
$BPFormat["MaxHP"] = "Max Health";
$BPFormat["MAXMANA"] = "Max Mana";
$BPFormat["HEALDELTA"] = "Heal Delta";
$BPFormat["MANADELTA"] = "Mana Delta";
$BPFormat["MAXWEIGHT"] = "Max Weight";
$BPFormat["GROUP"] = "Group";
$BPFormat["RACE"] = "Race";
$BPFormat["HEAL"] = "Heal";
$BPFormat["HEALMP"] = "Restore Mana";
$BPFormat["TRANSPORT"] = "Transport";
$BPFormat["AOE"] = "AOE";
$BPFormatPercent["EXP%"] = "%";
$BPFormatPercent["GOLD%"] = "%";
$BPFormatPercent["RANK%"] = "%";
$BPFormatPercent["SP%"] = "%";
$BPFormatPercent["LCK%"] = "%";
$BPFormat["LVLG"] = "Level from";
$BPFormat["LVLL"] = "Level Less than or";
$BPFormat["CLASS"] = "Class:";
$BPFormat["RLG"] = "Remort";
$BPFormat["RLL"] = "Remort Less";
$BPFormat["LOCATION"] = "Location";
$BPFormat["ADMIN"] = "Admin";
$BPFormat["SKILLUNLOCK"] = "Skill Unlocked";
$BPFormat["LOCKSKILL"] = "Lock Skill";
$BPFormat["DURATION"] = "Duration";
$BPFormat["LADDER"] = "Ladder";
$BPFormat["NEARFIRE"] = "Near a Fire";
$BPFormat["MANA"] = "Mana";
$BPFormat["HASPERK"] = "Has Perk";
$BPFormat["ENABLEACTION"] = "Special";
$BPFormat["SHIELD%"] = "Shield Damage";
$BPFormat["REFLECT%"] = "Reflect Damage";
$BPFormatPercent["SHIELD%"] = "%";
$BPFormatPercent["REFLECT%"] = "%";
$BPFormat["BLOCK%"] = "Block Hit";
$BPFormatPercent["BLOCK%"] = "%";
$BPFormat["LOADPROJECTILE"] = "Load Projectile";
$BPFormat["ATKDEC"] = "ATK Decrease";
$BPFormatPercent["ATKDEC"] = "%";
$BPFormat["DEFDEC"] = "DEF Decrease";
$BPFormatPercent["DEFDEC"] = "%";
$BPFormat["DEF"] = "Add All Defense";
$BPFormat["ATK"] = "Add All Offense";
$BPFormat["NOPET"] = "Must not have a Pet";
$BPFormatNoShowVar["NOPET"] = 1;
$BPFormat["MAGIC%"] = "Magic Find";
$BPFormatPercent["MAGIC%"] = "%";
$BPFormat["CRITICALDAMAGE"] = "Add Critical Damage";
$BPFormatPercent["CRITICALDAMAGE"] = "%";
$BPFormat["CRITICALCHANCE"] = "Critical Hit Chance";
$BPFormatPercent["CRITICALCHANCE"] = "%";
$BPFormat["MAGICPEN"] = "Magic Penetration";
$BPFormat["ARMORPEN"] = "Armor Penetration";
$BPFormat["ARMOR"] = "Armor";
$BPFormat["MELEEAC"] = "Melee AC";
$BPFormat["PROJECTILEAC"] = "Projectile AC";
$BPFormat["FIREAC"] = "Fire AC";
$BPFormat["POISONAC"] = "Poison AC";
$BPFormat["COLDAC"] = "Cold AC";
$BPFormat["ENERGYAC"] = "Energy AC";
$BPFormat["ALLRESIST"] = "Resist All Elements";
$BPFormat["MELEERESIST"] = "Melee Resist";
$BPFormat["PROJECTILERESIST"] = "Projectile Resist";
$BPFormat["FIRERESIST"] = "Fire Resist";
$BPFormat["POISONRESIST"] = "Poison Resist";
$BPFormat["COLDRESIST"] = "Cold Resist";
$BPFormat["GOLD%"] = "Gold Find";
$BPFormatPercent["GOLD%"] = "%";
$BPFormat["MAGIC%"] = "Magic Find";
$BPFormatPercent["MAGIC%"] = "%";
$BPFormat["HEALDELTA"] = "Heal Delta";
$BPFormat["MANADELTA"] = "Mana Delta";
$BPFormat["REFLECT%"] = "Reflect Damage";
$BPFormatPercent["REFLECT%"] = "%";
$BPFormat["ADDMANACOST"] = "Add Mana Cost";
$BPFormatPercent["ADDMANACOST"] = "%";
$BPFormatMinus["ADDMANACOST"] = "-";
$BPFormat["ADDDAMAGE"] = "Add Damage";
$BPFormat["MAGICDAMAGE"] = "Increase Magic Damage";
$BPFormatPercent["MAGICDAMAGE"] = "%";
$BPFormat["WEAPONHANDLING"] = "Weapon Handling";
$BPFormat["MAXHP"] = "Max Health";
$BPFormat["MAXMANA"] = "Max Mana";
$BPFormat["MAXWEIGHT"] = "Max Weight";
$BPFormat["LIFESTEAL"] = "Life Steal";
$BPFormatPercent["LIFESTEAL"] = "%";
$BPFormat["SpellCapacity"] = "Focus";
$BPFormat["Stealing"] = "Stealing";
$BPFormat["RunSpeed"] = "Run Speed";
$BPFormat["OffensiveCasting"] = "Offensive Casting";
$BPFormat["Intelligence"] = "Intelligence";
$BPFormat["Psychic"] = "Psychic";
$BPFormat["Sense"] = "Sense";
$BPFormat["Agility"] = "Agility";
$BPFormat["Strength"] = "Strength";
$BPFormat["Stamina"] = "Stamina";

$IntegDisp[0] = "Broken";
$IntegDisp[10] = "Junk";
$IntegDisp[20] = "Poor";
$IntegDisp[30] = "Inferior";
$IntegDisp[40] = "Common";
$IntegDisp[50] = "Mediocre";
$IntegDisp[60] = "Average";
$IntegDisp[70] = "Strong";
$IntegDisp[80] = "Well Made";
$IntegDisp[90] = "Mighty";
$IntegDisp[100] = "Perfect";
$IntegDisp[110] = "Adept";
$IntegDisp[120] = "Exceptional";
$IntegDisp[130] = "Ultimate";

function BPGetIntegDisp(%v)
{
	%d = "Mysterious";
	for (%i = 0; %i <= 130; %i+=10) {
		if (%v >= %i) {
			%d = $IntegDisp[%i];
		}
	}
	return %d;	
}

$TierReq["Slashing"] = $ReqStr;
$TierReq["Piercing"] = $ReqAgi;
$TierReq["Bludgeoning"] = $ReqStr;
$TierReq["Dodging"] = $ReqSen;
$TierReq["WeightCapacity"] = $ReqSta;
$TierReq["Bashing"] = $ReqStr;
$TierReq["Stealing"] = $ReqAgi;
$TierReq["Hiding"] = $ReqSen;
$TierReq["Backstabbing"] = $ReqAgi;
$TierReq["OffensiveCasting"] = $ReqInt;
$TierReq["DefensiveCasting"] = $ReqInt;
$TierReq["SpellResistance"] = $ReqPsy;
$TierReq["Healing"] = $ReqPsy;
$TierReq["Archery"] = $ReqStr;
$TierReq["Endurance"] = $ReqSta;
$TierReq["MartialArts"] = $ReqStr;
$TierReq["Mining"] = $ReqSen;
$TierReq["Speech"] = $ReqInt;
$TierReq["SenseHeading"] = $ReqSen;
$TierReq["Energy"] = $ReqPsy;
$TierReq["Haggling"] = $ReqSen;
$TierReq["NeutralCasting"] = $ReqInt;
$TierReq["Strength"] = $ReqStr;
$TierReq["Stamina"] = $ReqSta;
$TierReq["Agility"] = $ReqAgi;
$TierReq["Intelligence"] = $ReqInt;
$TierReq["Sense"] = $ReqSen;
$TierReq["Psychic"] = $ReqPsy;
$TierReq["CastInit"] = $ReqAgi;
$TierReq["Literacy"] = $ReqInt;
$TierReq["Smithing"] = $ReqStr;
$TierReq["MagicCraft"] = $ReqInt;
$TierReq["Alchemy"] = $ReqInt;
$TierReq["SpellCapacity"] = $ReqPsy;
$TierReq["RunSpeed"] = $ReqAgi;
$TierReq["EvadeMelee"] = $ReqAgi;
$TierReq["Aiming"] = $ReqStr;
$TierReq["Brawling"] = $ReqStr;
$TierReq["Cleave"] = $ReqStr;
$TierReq["DivineCasting"] = $ReqPsy;
$TierReq["CRITICALDAMAGE"] = $ReqStr;
$TierReq["CRITICALCHANCE"] = $ReqSen;
$TierReq["ATK"] = $ReqStr;
$TierReq["DEF"] = $ReqAgi;
$TierReq["MAGICPEN"] = $ReqInt;
$TierReq["ARMORPEN"] = $ReqStr;
$TierReq["EXP%"] = $ReqInt;
$TierReq["ARMOR"] = $ReqSta;
$TierReq["MELEEAC"] = $ReqSta;
$TierReq["PROJECTILEAC"] = $ReqSta;
$TierReq["FIREAC"] = $ReqSta;
$TierReq["POISONAC"] = $ReqSta;
$TierReq["COLDAC"] = $ReqSta;
$TierReq["ENERGYAC"] = $ReqSta;
$TierReq["ALLRESIST"] = $ReqInt;
$TierReq["MELEERESIST"] = $ReqInt;
$TierReq["PROJECTILERESIST"] = $ReqInt;
$TierReq["FIRERESIST"] = $ReqInt;
$TierReq["POISONRESIST"] = $ReqInt;
$TierReq["COLDRESIST"] = $ReqInt;
$TierReq["GOLD%"] = $ReqSen;
$TierReq["MAGIC%"] = $ReqPsy;
$TierReq["HEALDELTA"] = $ReqSta;
$TierReq["MANADELTA"] = $ReqPsy;
$TierReq["REFLECT%"] = $ReqAgi;
$TierReq["ADDMANACOST"] = $ReqPsy;
$TierReq["ADDDAMAGE"] = $ReqStr;
$TierReq["MAGICDAMAGE"] = $ReqInt;
$TierReq["WEAPONHANDLING"] = $ReqStr;
$TierReq["MAXHP"] = $ReqSta;
$TierReq["MAXMANA"] = $ReqPsy;
$TierReq["MAXWEIGHT"] = $ReqAgi;

$TierReqP["Slashing"] = 1.0;
$TierReqP["Piercing"] = 1.0;
$TierReqP["Bludgeoning"] = 1.0;
$TierReqP["Dodging"] = 0.9;
$TierReqP["WeightCapacity"] = 0.6;
$TierReqP["Bashing"] = 0.9;
$TierReqP["Stealing"] = 1.0;
$TierReqP["Hiding"] = 0.7;
$TierReqP["Backstabbing"] = 1.0;
$TierReqP["OffensiveCasting"] = 1.0;
$TierReqP["DefensiveCasting"] = 1.0;
$TierReqP["SpellResistance"] = 0.9;
$TierReqP["Healing"] = 0.6;
$TierReqP["Archery"] = 0.9;
$TierReqP["Endurance"] = 0.7;
$TierReqP["MartialArts"] = 0.6;
$TierReqP["Mining"] = 0.8;
$TierReqP["Speech"] = 0.6;
$TierReqP["SenseHeading"] = 0.3;
$TierReqP["Energy"] = 0.7;
$TierReqP["Haggling"] = 0.9;
$TierReqP["NeutralCasting"] = 1.0;
$TierReqP["Strength"] = 0.7;
$TierReqP["Stamina"] = 0.7;
$TierReqP["Agility"] = 0.7;
$TierReqP["Intelligence"] = 0.7;
$TierReqP["Sense"] = 0.7;
$TierReqP["Psychic"] = 0.7;
$TierReqP["CastInit"] = 0.6;
$TierReqP["Literacy"] = 0.6;
$TierReqP["Smithing"] = 0.8;
$TierReqP["MagicCraft"] = 0.8;
$TierReqP["Alchemy"] = 0.8;
$TierReqP["SpellCapacity"] = 0.8;
$TierReqP["RunSpeed"] = 0.6;
$TierReqP["EvadeMelee"] = 0.9;
$TierReqP["Aiming"] = 1.0;
$TierReqP["Brawling"] = 1.0;
$TierReqP["Cleave"] = 1.0;
$TierReqP["DivineCasting"] = 1.0;
$TierReqP["CRITICALDAMAGE"] = 1.0;
$TierReqP["CRITICALCHANCE"] = 1.0;
$TierReqP["ATK"] = 1.0;
$TierReqP["DEF"] = 1.0;
$TierReqP["MAGICPEN"] = 0.9;
$TierReqP["ARMORPEN"] = 0.9;
$TierReqP["EXP%"] = 0.5;
$TierReqP["ARMOR"] = 0.9;
$TierReqP["MELEEAC"] = 0.7;
$TierReqP["PROJECTILEAC"] = 0.7;
$TierReqP["FIREAC"] = 0.7;
$TierReqP["POISONAC"] = 0.7;
$TierReqP["COLDAC"] = 0.7;
$TierReqP["ENERGYAC"] = 0.7;
$TierReqP["ALLRESIST"] = 0.7;
$TierReqP["MELEERESIST"] = 0.7;
$TierReqP["PROJECTILERESIST"] = 0.7;
$TierReqP["FIRERESIST"] = 0.7;
$TierReqP["POISONRESIST"] = 0.7;
$TierReqP["COLDRESIST"] = 0.7;
$TierReqP["GOLD%"] = 0.5;
$TierReqP["MAGIC%"] = 0.5;
$TierReqP["HEALDELTA"] = 0.8;
$TierReqP["MANADELTA"] = 0.8;
$TierReqP["REFLECT%"] = 0.9;
$TierReqP["ADDMANACOST"] = 1.0;
$TierReqP["ADDDAMAGE"] = 1.0;
$TierReqP["MAGICDAMAGE"] = 1.0;
$TierReqP["WEAPONHANDLING"] = 1.0;
$TierReqP["MAXHP"] = 0.7;
$TierReqP["MAXMANA"] = 0.7;
$TierReqP["MAXWEIGHT"] = 0.7;

$TierWeight["Slashing"] = 100;
$TierWeight["Piercing"] = 90;
$TierWeight["Bludgeoning"] = 70;
$TierWeight["Dodging"] = 20;
$TierWeight["WeightCapacity"] = 30;
$TierWeight["Bashing"] = 100;
$TierWeight["Stealing"] = 30;
$TierWeight["Hiding"] = 30;
$TierWeight["Backstabbing"] = 70;
$TierWeight["OffensiveCasting"] = 1;
$TierWeight["DefensiveCasting"] = 1;
$TierWeight["SpellResistance"] = 1;
$TierWeight["Healing"] = 20;
$TierWeight["Archery"] = 100;
$TierWeight["Endurance"] = 50;
$TierWeight["MartialArts"] = 100;
$TierWeight["Mining"] = 10;
$TierWeight["Speech"] = 1;
$TierWeight["SenseHeading"] = 1;
$TierWeight["Energy"] = 1;
$TierWeight["Haggling"] = 1;
$TierWeight["NeutralCasting"] = 1;
$TierWeight["Strength"] = 10;
$TierWeight["Stamina"] = 10;
$TierWeight["Agility"] = 10;
$TierWeight["Intelligence"] = 1;
$TierWeight["Sense"] = 10;
$TierWeight["Psychic"] = 1;
$TierWeight["CastInit"] = 1;
$TierWeight["Literacy"] = 1;
$TierWeight["Smithing"] = 5;
$TierWeight["MagicCraft"] = 5;
$TierWeight["Alchemy"] = 5;
$TierWeight["SpellCapacity"] = 1;
$TierWeight["RunSpeed"] = 1;
$TierWeight["EvadeMelee"] = 30;
$TierWeight["Aiming"] = 100;
$TierWeight["Brawling"] = 100;
$TierWeight["Cleave"] = 100;
$TierWeight["DivineCasting"] = 1;
$TierWeight["CRITICALDAMAGE"] = 70;
$TierWeight["CRITICALCHANCE"] = 70;
$TierWeight["ATK"] = 30;
$TierWeight["DEF"] = 20;
$TierWeight["MAGICPEN"] = 1;
$TierWeight["ARMORPEN"] = 60;
$TierWeight["EXP%"] = 1;
$TierWeight["ARMOR"] = 10;
$TierWeight["MELEEAC"] = 10;
$TierWeight["PROJECTILEAC"] = 10;
$TierWeight["FIREAC"] = 10;
$TierWeight["POISONAC"] = 10;
$TierWeight["COLDAC"] = 10;
$TierWeight["ENERGYAC"] = 10;
$TierWeight["ALLRESIST"] = 1;
$TierWeight["MELEERESIST"] = 1;
$TierWeight["PROJECTILERESIST"] = 1;
$TierWeight["FIRERESIST"] = 1;
$TierWeight["POISONRESIST"] = 1;
$TierWeight["COLDRESIST"] = 1;
$TierWeight["GOLD%"] = 1;
$TierWeight["MAGIC%"] = 1;
$TierWeight["HEALDELTA"] = 10;
$TierWeight["MANADELTA"] = 1;
$TierWeight["REFLECT%"] = 50;
$TierWeight["ADDMANACOST"] = 1;
$TierWeight["ADDDAMAGE"] = 100;
$TierWeight["MAGICDAMAGE"] = 1;
$TierWeight["WEAPONHANDLING"] = 100;
$TierWeight["MAXHP"] = 20;
$TierWeight["MAXMANA"] = 1;
$TierWeight["MAXWEIGHT"] = 10;

	// %new = "219DiamondAmulet^6262626262612348";

	$funk::var["[\"" @ %name @ "\", 14, 0]"] = GetBackpackSave(%clientId,0);
	$funk::var["[\"" @ %name @ "\", 14, 1]"] = GetBackpackSave(%clientId,10);
	$funk::var["[\"" @ %name @ "\", 14, 2]"] = GetBackpackSave(%clientId,20);
	$funk::var["[\"" @ %name @ "\", 14, 3]"] = GetBackpackSave(%clientId,30);
	$funk::var["[\"" @ %name @ "\", 14, 4]"] = GetBackpackSave(%clientId,40);
	$funk::var["[\"" @ %name @ "\", 14, 5]"] = GetBackpackSave(%clientId,50);
	$funk::var["[\"" @ %name @ "\", 14, 0]"] = GetBackpackSave(%clientId,60);
	$funk::var["[\"" @ %name @ "\", 14, 1]"] = GetBackpackSave(%clientId,70);
	$funk::var["[\"" @ %name @ "\", 14, 2]"] = GetBackpackSave(%clientId,80);
	$funk::var["[\"" @ %name @ "\", 14, 3]"] = GetBackpackSave(%clientId,90);
	$funk::var["[\"" @ %name @ "\", 14, 4]"] = GetBackpackSave(%clientId,100);








// CLERIC
AutoSpell("Venom",30,"DOT","LOS",1,"OffensiveCasting","Cleric","DAMAGE poison 1500","MANA 3000",3,3,0,60,"ClericPoison","Poison Spells","VENOM","icos_venom","You inflict a lasting poison on your target.",99);
AutoSpell("Scorch",30,"DOT","LOS",1,"OffensiveCasting","Cleric","DAMAGE fire 1500","MANA 3000",3,3,0,60,"ClericBurn","Fire Spells","SCORCH","icos_scorch","You burn your target continuously.",99);
AutoSpell("Healing",30,"FRIEND","LOS",0,"DefensiveCasting","Cleric","HEAL 10000","MANA 3000",5,10,0,0,"ClericHeal","Single Heals","HEALING","icos_healing","You heal your target's hit points.",99);
AutoSpell("Remedy",30,"FRIEND","TEAM",0,"DefensiveCasting","Cleric","HEAL 3300","MANA 3000",5,10,0,0,"ClericHeal","Team Heals","REMEDY","icos_remedy","You heal yourself and your team.",99);
AutoSpell("Wish",20,"FRIEND","LOS",0,"NeutralCasting","Cleric","Focus 300","MANA 1500",3,3,50,3600,"ClericFocus","Buffing","WISH","icos_wish","You increase your target's Focus skill.",99);
AutoSpell("Life",30,"FRIEND","LOS",0,"NeutralCasting","Cleric","MAXHP 2200","MANA 2700",3,3,50,3600,"ClericMaxHP","Buffing","LIFE","icos_life","You increase your target's maximum hit points.",99);
AutoSpell("Confusion",30,"FOE","LOS",1,"DivineCasting","Cleric","Focus -450","MANA 3000",5,5,0,60,"Confusion","Debuffing","CONFUSION","icos_confusion","You confuse your target, lowering their Focus skill.",99);

// DRUID
AutoSpell("Summon",30,"SELF","SELF",0,"DivineCasting","Druid","SPAWNPET","MANA 3000 NOPET 1",30,30,0,0,"DriudSummon","Summoning Spells","SUMMON","icos_summon","You summon a spirit to bid your fighting.");
AutoSpell("Wolf",30,"FRIEND","LOS",0,"DivineCasting","Druid","FORM Wolf ADDDAMAGE 500 RunSpeed 500 ATK 100 EVASION 50","MANA 2700",10,10,60,3600,"DriudMorph","Morphing Spells","MORPH","icos_wolf","You transform your target into a wolf.",99);
AutoSpell("Bear",30,"FRIEND","LOS",0,"DivineCasting","Druid","FORM Bear ADDDAMAGE 250 RunSpeed 250 DEF 100 MAXHP 1000","MANA 2700",10,10,60,3600,"DriudMorph","Morphing Spells","MORPH","icos_bear","You transform your target into a bear.",99);
AutoSpell("Mesmerize",30,"FOE","LOS",0,"OffensiveCasting","Druid","CONTROL","MANA 3000 NOPET 1",30,30,0,1800,"DriudControl","Summoning Spells","MESMERIZE","icos_mesmerize","You mesmerize an enemy monster to take control of it.",99);
AutoSpell("Chaos",30,"FOE","LOS",1,"OffensiveCasting","Druid","MAGICDAMAGE -50","MANA 1600",5,5,0,30,"Chaos","Debuffing","CHAOS","icos_chaos","You instill chaotic visions in your target, ruducing their magic prowess.",99);
AutoSpell("Reform",30,"FRIEND","LOS",0,"DefensiveCasting","Druid","DEF 170","MANA 3600",5,5,60,3600,"Reform","Buffing","REFORM","icos_reform","You increase your targets defense greatly.",99);
AutoSpell("Concentrate",30,"FRIEND","LOS",0,"NeutralCasting","Druid","OffensiveCasting 250 DefensiveCasting 250 NeutralCasting 250 DivineCasting 250","MANA 1700",3,3,60,3600,"Concentrate","Buffing","CONCENTRATE","icos_concentrate","You increase the casting skills of your target.",99);
AutoSpell("Knowledge",20,"FRIEND","LOS",0,"NeutralCasting 2352","Druid","EXP% 20","MANA 1700",5,5,60,3600,"Knowledge","Buffing","KNOWLEDGE","icos_knowledge","You increase the learning capacity of your target.",99);
AutoSpell("Blessing",30,"FRIEND","LOS",0,"NeutralCasting","Druid","MANADELTA 70","MANA 3000",5,5,37,3600,"Blessing","Buffing","BLESSING","icos_blessing","You increase your targets mana regeneration.",99);

// THIEF
AutoSpell("Stabber",30,"FRIEND","LOS",0,"NeutralCasting","Thief","Piercing 170","MANA 2700",3,3,47,3600,"Stabber","Piercing Buff","STABBER","icos_stabber","Piercing skill of the target is increased greatly. Becomes self only at QL 150.",15);
AutoSpell("MimicCleric",5,"SELF","SELF",0,"DivineCasting","Thief","MIMIC Cleric OffensiveCasting -500 DefensiveCasting -500 NeutralCasting -500 DivineCasting -500 CastInit -1500 MAGICDAMAGE -50","MANA 4200 NOTMIMIC 1",30,30,50,3600,"ThiefMimic","Mimic Spells","SUMMON","icos_mimiccleric","You mimic a class, obtaining the ability to cast their spells.",0,1);
AutoSpell("MimicDruid",5,"SELF","SELF",0,"DivineCasting","Thief","MIMIC Druid OffensiveCasting -500 DefensiveCasting -500 NeutralCasting -500 DivineCasting -500 CastInit -1500 MAGICDAMAGE -50","MANA 4200 NOTMIMIC 1",30,30,50,3600,"ThiefMimic","Mimic Spells","SUMMON","icos_mimicdruid","You mimic a class, obtaining the ability to cast their spells.",0,1);
AutoSpell("MimicBard",5,"SELF","SELF",0,"DivineCasting","Thief","MIMIC Bard OffensiveCasting -500 DefensiveCasting -500 NeutralCasting -500 DivineCasting -500 CastInit -1500 MAGICDAMAGE -50","MANA 4200 NOTMIMIC 1",30,30,50,3600,"ThiefMimic","Mimic Spells","SUMMON","icos_mimibard","You mimic a class, obtaining the ability to cast their spells.",0,1);
AutoSpell("MimicFighter",5,"SELF","SELF",0,"DivineCasting","Thief","MIMIC Fighter OffensiveCasting -500 DefensiveCasting -500 NeutralCasting -500 DivineCasting -500 CastInit -1500 MAGICDAMAGE -50","MANA 4200 NOTMIMIC 1",30,30,50,3600,"ThiefMimic","Mimic Spells","SUMMON","icos_mimicfighter","You mimic a class, obtaining the ability to cast their spells.",0,1);
AutoSpell("MimicPaladin",5,"SELF","SELF",0,"DivineCasting","Thief","MIMIC Paladin OffensiveCasting -500 DefensiveCasting -500 NeutralCasting -500 DivineCasting -500 CastInit -1500 MAGICDAMAGE -50","MANA 4200 NOTMIMIC 1",30,30,50,3600,"ThiefMimic","Mimic Spells","SUMMON","icos_mimicpaladin","You mimic a class, obtaining the ability to cast their spells.",0,1);
AutoSpell("MimicRanger",5,"SELF","SELF",0,"DivineCasting","Thief","MIMIC Ranger OffensiveCasting -500 DefensiveCasting -500 NeutralCasting -500 DivineCasting -500 CastInit -1500 MAGICDAMAGE -50","MANA 4200 NOTMIMIC 1",30,30,50,3600,"ThiefMimic","Mimic Spells","SUMMON","icos_mimicranger","You mimic a class, obtaining the ability to cast their spells.",0,1);
AutoSpell("MimicMage",5,"SELF","SELF",0,"DivineCasting","Thief","MIMIC Mage OffensiveCasting -500 DefensiveCasting -500 NeutralCasting -500 DivineCasting -500 CastInit -1500 MAGICDAMAGE -50","MANA 4200 NOTMIMIC 1",30,30,50,3600,"ThiefMimic","Mimic Spells","SUMMON","icos_mimicmage","You mimic a class, obtaining the ability to cast their spells.",0,1);
AutoSpell("Revert",1,"SELF","SELF",0,"DivineCasting","Thief","KILLMIMIC 1 CASTSELF NoMimicAllowed","MANA 4200 NOTMIMIC 0",30,30,0,3600,"ThiefMimic","Mimic Spells","SUMMON","icos_revert","You revert back to the thief class.",0,0);
AutoSpell("Shadow",30,"FRIEND","LOS",0,"DefensiveCasting","Thief","Hiding 300","MANA 2700",3,3,40,1800,"Shadow","Hiding Buff","SHADOW","icos_shadow","Hiding skill of the target is increased greatly.",0);
AutoSpell("Inflict",30,"FRIEND","LOS",0,"OffensiveCasting","Thief","CRITICALCHANCE 30 CRITICALDAMAGE 60 Backstabbing 200","MANA 2700",3,3,55,3600,"Inflict","Critical Hit Buff","INFLICT","icos_inflict","Critical Hit chance, Crititcal Damage, and Sneak Attack is increased in the target. Becomes self only at QL 150.",15);
AutoSpell("Grace",20,"FRIEND","LOS",0,"NeutralCasting","Thief","Sense 50 Agility 50","MANA 1700",2,2,30,3600,"Grace","Ability Buff","GRACE","icos_grace","Sense and Agility is increased in the target.",99);
AutoSpell("Deceit",30,"FRIEND","LOS",0,"NeutralCasting","Thief","Stealing 300","MANA 2700",3,3,40,1800,"Deceit","Stealing Buff","DECEIT","icos_deceit","Stealing skill of the target is increased.",99);
AutoSpell("Dexterity",30,"SELF","SELF",0,"DefensiveCasting","Thief","EVASION 170","MANA 3100",3,3,50,1800,"Dexterity","Dexterity","DEXTERITY","icos_dexterity","The thief increases their evasion skill.",99);

// BARD
AutoSpell("Drain",30,"FOE","LOS",1,"OffensiveCasting","Bard","ALLSKILL -300 ATK -100 DEF -100 CASTSELF Returned","MANA 3100",5,5,0,120,"Drain","Debuffing","DRAIN","icos_drain","You drain your target of their skills, obtaining some in return.");
AutoSpell("Transfer",30,"FRIEND","LOS",0,"DivineCasting","Bard","ALLSKILL 130 CASTSELF Weakend","MANA 2200",10,10,60,120,"Transfer","Buffing","TRANSFER","icos_transfer","You transfer your skills to your target.");
AutoSpell("Calm",30,"FOE","LOS",1,"OffensiveCasting","Bard","AISLEEP 1 CastInit -500","MANA 1700",2,2,0,300,"Calm","Debuffing","CALM","icos_calm","You put your monster target into a deep slumber.");
AutoSpell("Melody",30,"FRIEND","TEAM",0,"DefensiveCasting","Bard","HEAL 1100","MANA 1100",5,10,0,0,"BardHeal","Team Heals","MELODY","icos_melody","You heal yourself and your team.");
AutoSpell("Artisan",30,"FRIEND","LOS",0,"NeutralCasting","Bard","Smithing 300 MagicCraft 300 Alchemy 300","MANA 1000",3,3,47,1800,"Artisan","Tradeskill Buff","ARTISAN","icos_artisan","The targets tradeskills are augmented. Becomes self only at QL 150.",15);
AutoSpell("Jabbing",30,"DOT","LOS",1,"OffensiveCasting","Bard","DAMAGE melee 2000","MANA 3000",3,3,0,60,"Jabbing","Damage over Time","JABBING","icos_jabbing","You send out a flurry of knifes to cut your target over time.");
AutoSpell("Needles",30,"DOT","LOS",1,"OffensiveCasting","Bard","DAMAGE projectile 2000","MANA 3000",3,3,0,60,"Needles","Damage over Time","NEEDLES","icos_needles","You send out a flurry of arrows to pierce your target over time.");

// FIGHTER
AutoSpell("Taunt",20,"FOE","LOS",1,"OffensiveCasting","Fighter","TAUNTTARGET 10000","MANA 600",1,3,0,3600,"Taunt","Taunt","TAUNT","icos_taunt","You taunt your target, making it more favorable to attack you instead.");
AutoSpell("Mastery",30,"FRIEND","LOS",0,"NeutralCasting","Fighter","Slashing 90 Piercing 90 Bludgeoning 90","MANA 2700",3,3,55,3600,"Mastery","Mastery","MASTERY","icos_mastery","You increase the melee skills of the target. Becomes self only at QL 150.",15);
AutoSpell("PainBringer",30,"SELF","SELF",0,"OffensiveCasting","Fighter","ADDDAMAGE 1000","MANA 2800",3,10,50,1800,"PainBringer","PainBringer","PAINBRINGER","icos_painbringer","The fighter increases his damage by a major amount.",0);
AutoSpell("Vigor",30,"SELF","SELF",0,"NeutralCasting","Fighter","MAXHP 3000","MANA 2700",3,10,50,3600,"Vigor","Vigor","VIGOR","icos_vigor","The fighter increases their maximum hit points.");
AutoSpell("Rage",20,"SELF","SELF",0,"OffensiveCasting","Fighter","ATK 300 DEF -300 RunSpeed 300 ADDDAMAGE 300","MANA 2700",2,10,50,3600,"Rage","Rage","RAGE","icos_rage","The fighter becomes enraged, increasing their Attack Rating by a huge amount, but at the same time lowering their defense.");
AutoSpell("Shell",20,"SELF","SELF",0,"DefensiveCasting","Fighter","ABSORB 800","MANA 3000",3,10,30,3600,"Shell","Shell","SHELL","icos_shell","The fighter encases themselves in a barrier to block incoming damage.");
AutoSpell("Guard",5,"SELF","SELF",0,"DivineCasting","Fighter","BLOCKHIT 5 ATK -150","MANA 3000",3,10,30,3600,"Guard","Guard","GUARD","icos_guard","The fighter puts themselves into a more defensive stance.");
AutoSpell("Behemoth",20,"FRIEND","LOS",0,"DivineCasting","Fighter","Strength 60 Stamina 60 MAXHP 300","MANA 1700",2,2,30,3600,"Behemoth","Behemoth","BEHEMOTH","icos_behemoth","Strength and Stamina is increased in the target.",0);
AutoSpell("Harden",30,"FRIEND","LOS",0,"DefensiveCasting","Fighter","ARMOR 1000","MANA 2700",3,3,55,3600,"Harden","Harden","HARDEN","icos_harden","Armor is increased in the target greatly. Becomes self only at QL 150.",15);

// PALADIN
AutoSpell("Excalibur",30,"FRIEND","LOS",0,"NeutralCasting","Paladin","Slashing 190","MANA 2700",3,3,47,3600,"Excalibur","Excalibur","EXCALIBUR","icos_excalibur","Slashing skill of the target is increased greatly. Becomes self only at QL 150.",15);
AutoSpell("Rampart",30,"TEAMDOT","TEAM",0,"DefensiveCasting","Paladin","TEAMCAST TeamRampart","MANA 3000",3,3,50,7200,"Rampart","Rampart","RAMPART","icos_rampart","You increase your teams defense with this powerful aura.",99,0,1,60);
AutoSpell("Warlord",30,"TEAMDOT","TEAM",0,"OffensiveCasting","Paladin","TEAMCAST TeamWarlord","MANA 3000",3,3,50,7200,"Warlord","Warlord","WARLORD","icos_warlord","You increase your teams offense with this powerful aura.",99,0,1,60);
AutoSpell("Blessing",30,"TEAMDOT","TEAM",0,"DefensiveCasting","Paladin","TEAMCAST TeamBlessing","MANA 3000",3,3,50,7200,"Blessing","Blessing","BLESSING","icos_blessing","You heal your team continuously with powerful aura.",99,0,1,60);
AutoSpell("Shielding",10,"TEAMDOT","TEAM",0,"DivineCasting","Paladin","TEAMCAST TeamShielding","MANA 3000",3,3,60,7200,"Shielding","Shielding","SHIELDING","icos_shielding","You provide great defense continuously with powerful aura.",99,0,1,60);
AutoSpell("Ward",30,"FRIEND","TEAM",0,"NeutralCasting","Paladin","MAXHP 1500","MANA 1500",3,3,50,900,"Ward","Ward","WARD","icos_ward","You increase your team's maximum hit points.");
AutoSpell("Berserker",30,"SELF","SELF",0,"OffensiveCasting","Paladin","ADDDAMAGE 500","MANA 2800",3,10,50,1800,"Berserker","Berserker","BERSERKER","icos_berserker","The paladin increases their damage by a moderate amount.",99);
AutoSpell("Virtue",10,"SELF","SELF",0,"DivineCasting","Paladin","Strength 30 Stamina 30 ARMOR 300","MANA 1700",2,2,30,3600,"Virtue","Virtue","VIRTUE","icos_virtue","Strength and Stamina is increased in the paladin.",99);

// RANGER
AutoSpell("Targeting",30,"FRIEND","LOS",0,"OffensiveCasting","Ranger","ATK 300","MANA 2800",3,10,48,1800,"Targeting","Targeting","TARGETING","icos_targeting","The ranger increases the targets Offense. Becomes self only at 150",15);
AutoSpell("Ballistics",30,"FRIEND","LOS",0,"NeutralCasting","Ranger","Archery 200","MANA 2800",3,10,48,1800,"Ballistics","Ballistics","BALLISTICS","icos_ballistics","Increases the Archery of the target. Becomes self only at 150",15);
AutoSpell("Entangle",30,"FOE","LOS",1,"DefensiveCasting","Ranger","ROOT 1","MANA 2800",3,3,48,1800,"Entangle","Entangle","ENTANGLE","icos_entangle","Entangles the target, holding them in place.",99,0,0,0,1);
AutoSpell("Sniper",10,"SELF","SELF",0,"OffensiveCasting","Ranger","CRITICALCHANCE 10 CRITICALDAMAGE 20 AimedShot 200","MANA 2800",3,10,55,1800,"Sniper","Sniper","SNIPER","icos_sniper","The ranger moderately increases their Critical hit Chance, Critical Damage, and Aimed Shot.",99);
AutoSpell("Quickness",30,"FRIEND","LOS",0,"DefensiveCasting","Ranger","RunSpeed 300","MANA 2800",3,10,50,1800,"Quickness","Quickness","QUICKNESS","icos_quickness","The targets run speed is greatly increased.",99);
AutoSpell("Mirror",30,"FRIEND","LOS",0,"DivineCasting","Ranger","REFLECT 30","MANA 3800",5,10,50,1800,"ReflectionLine","ReflectionLine","MIRROR","icos_mirror","The targets reflects a portion of all damage, returning some to the attacker.",99);
AutoSpell("Rally",30,"TEAMDOT","TEAM",0,"NeutralCasting","Ranger","TEAMCAST TeamRally","MANA 3000",3,3,50,7200,"Ralley","Rally","RALLY","icos_rally","You increase your teams damage with this powerful aura.",99,0,1,60);

// MAGE
// <create mage damage spells>







//######################################################################################
// Class multipliers
//######################################################################################

//***********************************
// GENERAL RULES FOR MULTIPLIERS:
//***********************************
//- Maximum multiplier should be 2.0
//- Minimum multiplier should be 0.1
//- A 0.1 should be VERY rare.  The normal minimum is 0.2.  If a class should not even
//  be near a certain skill, that's when the 0.1 comes in.

//******** SUMMARY ******************
//- Primary skills use a 2.0 multiplier
//- Secondary skills use a 1.5 multiplier
//- Normal skills use a ~1.0 multiplier
//- Weak skills use a ~0.5 multiplier
//- VERY weak skills use a 0.2
//- Unsuitable skills for a specific class use a 0.1

$SkillMultiplier[MartialArtist, $SkillSlashing] = 1.2;
$SkillMultiplier[MartialArtist, $SkillPiercing] = 1.0;
$SkillMultiplier[MartialArtist, $SkillBludgeoning] = 0.5;
$SkillMultiplier[MartialArtist, $SkillDodging] = 2.2;
$SkillMultiplier[MartialArtist, $SkillWeightCapacity] = 1.0;
$SkillMultiplier[MartialArtist, $SkillBashing] = 1.5;
$SkillMultiplier[MartialArtist, $SkillStealing] = 0.1;
$SkillMultiplier[MartialArtist, $SkillHiding] = 1.0;
$SkillMultiplier[MartialArtist, $SkillBackstabbing] = 0.5;
$SkillMultiplier[MartialArtist, $SkillOffensiveCasting] = 0.2;
$SkillMultiplier[MartialArtist, $SkillDefensiveCasting] = 0.2;
$SkillMultiplier[MartialArtist, $SkillMartialArts] = 2.2;
$SkillMultiplier[MartialArtist, $SkillNeutralCasting] = 1.0;
$SkillMultiplier[MartialArtist, $SkillSpellResistance] = 1.0;
$SkillMultiplier[MartialArtist, $SkillHealing] = 2.0;
$SkillMultiplier[MartialArtist, $SkillArchery] = 0.1;
$SkillMultiplier[MartialArtist, $SkillEndurance] = 2.0;
$SkillMultiplier[MartialArtist, $SkillMining] = 0.1;
$SkillMultiplier[MartialArtist, $SkillSpeech] = 2.0;
$SkillMultiplier[MartialArtist, $SkillSenseHeading] = 2.0;
$SkillMultiplier[MartialArtist, $SkillEnergy] = 1.5;
$SkillMultiplier[MartialArtist, $SkillHaggling] = 2.0;
$EXPmultiplier[MartialArtist] = 1.00;


//--------------
// Cleric
//--------------
// Clerics are good with Bludgeoning weapons but VERY good at healing spells.  They also
// know the basics behind offensive spells.

//Primary Skill: Defensive Casting
//Secondary Skills: Healing, Energy, Bludgeoning

$SkillMultiplier[Cleric, $SkillSlashing] = 1;
$SkillMultiplier[Cleric, $SkillPiercing] = 1;
$SkillMultiplier[Cleric, $SkillBludgeoning] = 2;
$SkillMultiplier[Cleric, $SkillDodging] = 1;
$SkillMultiplier[Cleric, $SkillWeightCapacity] = 2;
$SkillMultiplier[Cleric, $SkillBashing] = 2;
$SkillMultiplier[Cleric, $SkillStealing] = 1;
$SkillMultiplier[Cleric, $SkillHiding] = 1;
$SkillMultiplier[Cleric, $SkillBackstabbing] = 1;
$SkillMultiplier[Cleric, $SkillOffensiveCasting] = 2;
$SkillMultiplier[Cleric, $SkillDefensiveCasting] = 4;
$SkillMultiplier[Cleric, $SkillNeutralCasting] = 2;
$SkillMultiplier[Cleric, $SkillSpellResistance] = 2;
$SkillMultiplier[Cleric, $SkillHealing] = 4;
$SkillMultiplier[Cleric, $SkillArchery] = 1;
$SkillMultiplier[Cleric, $SkillEndurance] = 2;
$SkillMultiplier[Cleric, $SkillMining] = 2;
$SkillMultiplier[Cleric, $SkillSpeech] = 2;
$SkillMultiplier[Cleric, $SkillSenseHeading] = 1;
$SkillMultiplier[Cleric, $SkillEnergy] = 4;

$SkillMultiplier[Cleric, $SkillCastInit] = 2;
$SkillMultiplier[Cleric, $SkillLiteracy] = 4;
$SkillMultiplier[Cleric, $SkillSmithing] = 1;
$SkillMultiplier[Cleric, $SkillMagicCraft] = 2;
$SkillMultiplier[Cleric, $SkillAlchemy] = 3;
$SkillMultiplier[Cleric, $SkillSpellCapacity] = 4;
$SkillMultiplier[Cleric, $SkillRunSpeed] = 1;
$SkillMultiplier[Cleric, $SkillEvadeMelee] = 1;
$SkillMultiplier[Cleric, $SkillAiming] = 1;
$SkillMultiplier[Cleric, $SkillBrawling] = 1;
$SkillMultiplier[Cleric, $SkillCleave] = 1;
$SkillMultiplier[Cleric, $SkillDivineCasting] = 2;
$ClassHPMuli[Cleric] = 1.0;
$ClassManaMuli[Cleric] = 2.0;

$EXPmultiplier[Cleric] = 0.85;

//--------------
// Druid
//--------------
// Druids are good with Bludgeoning weapons and are somewhat familiar with spells.  They specialize in Neutral casting.
// However they are also able to easily hide.

//Primary Skill: Neutral Casting
//Secondary Skill: Hiding, Slashing, Spell Resistance

$SkillMultiplier[Druid, $SkillSlashing] = 1;
$SkillMultiplier[Druid, $SkillPiercing] = 1;
$SkillMultiplier[Druid, $SkillBludgeoning] = 2;
$SkillMultiplier[Druid, $SkillDodging] = 4;
$SkillMultiplier[Druid, $SkillWeightCapacity] = 4;
$SkillMultiplier[Druid, $SkillBashing] = 2;
$SkillMultiplier[Druid, $SkillStealing] = 1;
$SkillMultiplier[Druid, $SkillHiding] = 2;
$SkillMultiplier[Druid, $SkillBackstabbing] = 1;
$SkillMultiplier[Druid, $SkillOffensiveCasting] = 2;
$SkillMultiplier[Druid, $SkillDefensiveCasting] = 2;
$SkillMultiplier[Druid, $SkillNeutralCasting] = 4;
$SkillMultiplier[Druid, $SkillSpellResistance] = 2;
$SkillMultiplier[Druid, $SkillHealing] = 2;
$SkillMultiplier[Druid, $SkillArchery] = 1;
$SkillMultiplier[Druid, $SkillEndurance] = 2;
$SkillMultiplier[Druid, $SkillMining] = 4;
$SkillMultiplier[Druid, $SkillSpeech] = 1;
$SkillMultiplier[Druid, $SkillSenseHeading] = 3;
$SkillMultiplier[Druid, $SkillEnergy] = 2;
$SkillMultiplier[Druid, $SkillHaggling] = 2;

$SkillMultiplier[Druid, $SkillCastInit] = 2;
$SkillMultiplier[Druid, $SkillLiteracy] = 4;
$SkillMultiplier[Druid, $SkillSmithing] = 1;
$SkillMultiplier[Druid, $SkillMagicCraft] = 1;
$SkillMultiplier[Druid, $SkillAlchemy] = 2;
$SkillMultiplier[Druid, $SkillSpellCapacity] = 4;
$SkillMultiplier[Druid, $SkillRunSpeed] = 4;
$SkillMultiplier[Druid, $SkillEvadeMelee] = 4;
$SkillMultiplier[Druid, $SkillAiming] = 1;
$SkillMultiplier[Druid, $SkillBrawling] = 4;
$SkillMultiplier[Druid, $SkillCleave] = 1;
$SkillMultiplier[Druid, $SkillDivineCasting] = 4;
$ClassHPMuli[Druid] = 1.2;
$ClassManaMuli[Druid] = 0.8;

$EXPmultiplier[Druid] = 0.8;

//--------------
// Thief
//--------------
//Thieves handle piercing weapons well enough, and are very good at hiding and backstabbing.
//And of course, they are great at stealing.

//Primary Skill: Stealing
//Secondary Skill: Hiding, Backstabbing, Piercing, Archery

$SkillMultiplier[Thief, $SkillSlashing] = 1;
$SkillMultiplier[Thief, $SkillPiercing] = 4;
$SkillMultiplier[Thief, $SkillBludgeoning] = 1;
$SkillMultiplier[Thief, $SkillDodging] = 2;
$SkillMultiplier[Thief, $SkillWeightCapacity] = 1;
$SkillMultiplier[Thief, $SkillBashing] = 1;
$SkillMultiplier[Thief, $SkillStealing] = 4;
$SkillMultiplier[Thief, $SkillHiding] = 4;
$SkillMultiplier[Thief, $SkillBackstabbing] = 4;
$SkillMultiplier[Thief, $SkillOffensiveCasting] = 2;
$SkillMultiplier[Thief, $SkillDefensiveCasting] = 2;
$SkillMultiplier[Thief, $SkillNeutralCasting] = 2;
$SkillMultiplier[Thief, $SkillSpellResistance] = 1;
$SkillMultiplier[Thief, $SkillHealing] = 1;
$SkillMultiplier[Thief, $SkillArchery] = 3;
$SkillMultiplier[Thief, $SkillEndurance] = 2;
$SkillMultiplier[Thief, $SkillMining] = 2;
$SkillMultiplier[Thief, $SkillSpeech] = 2;
$SkillMultiplier[Thief, $SkillSenseHeading] = 2;
$SkillMultiplier[Thief, $SkillEnergy] = 1;
$SkillMultiplier[Thief, $SkillHaggling] = 3;

$SkillMultiplier[Thief, $SkillCastInit] = 1;
$SkillMultiplier[Thief, $SkillLiteracy] = 1;
$SkillMultiplier[Thief, $SkillSmithing] = 1;
$SkillMultiplier[Thief, $SkillMagicCraft] = 1;
$SkillMultiplier[Thief, $SkillAlchemy] = 1;
$SkillMultiplier[Thief, $SkillSpellCapacity] = 2;
$SkillMultiplier[Thief, $SkillRunSpeed] = 4;
$SkillMultiplier[Thief, $SkillEvadeMelee] = 3;
$SkillMultiplier[Thief, $SkillAiming] = 3;
$SkillMultiplier[Thief, $SkillBrawling] = 1;
$SkillMultiplier[Thief, $SkillCleave] = 1;
$SkillMultiplier[Thief, $SkillDivineCasting] = 1;
$ClassHPMuli[Thief] = 0.8;
$ClassManaMuli[Thief] = 0.8;

$EXPmultiplier[Thief] = 0.8;

//--------------
// Bard
//--------------
//Bards are much like thieves, except that they are a bit more evenly balanced.

//Primary Skill: Stealing
//Secondary Skill: Archery

$SkillMultiplier[Bard, $SkillSlashing] = 3;
$SkillMultiplier[Bard, $SkillPiercing] = 3;
$SkillMultiplier[Bard, $SkillBludgeoning] = 3;
$SkillMultiplier[Bard, $SkillDodging] = 3;
$SkillMultiplier[Bard, $SkillWeightCapacity] = 4;
$SkillMultiplier[Bard, $SkillBashing] = 2;
$SkillMultiplier[Bard, $SkillStealing] = 4;
$SkillMultiplier[Bard, $SkillHiding] = 4;
$SkillMultiplier[Bard, $SkillBackstabbing] = 4;
$SkillMultiplier[Bard, $SkillOffensiveCasting] = 2;
$SkillMultiplier[Bard, $SkillDefensiveCasting] = 2;
$SkillMultiplier[Bard, $SkillNeutralCasting] = 2;
$SkillMultiplier[Bard, $SkillSpellResistance] = 1;
$SkillMultiplier[Bard, $SkillHealing] = 4;
$SkillMultiplier[Bard, $SkillArchery] = 2;
$SkillMultiplier[Bard, $SkillEndurance] = 4;
$SkillMultiplier[Bard, $SkillMining] = 4;
$SkillMultiplier[Bard, $SkillSpeech] = 2;
$SkillMultiplier[Bard, $SkillSenseHeading] = 2;
$SkillMultiplier[Bard, $SkillEnergy] = 2;
$SkillMultiplier[Bard, $SkillHaggling] = 4;

$SkillMultiplier[Bard, $SkillCastInit] = 2;
$SkillMultiplier[Bard, $SkillLiteracy] = 4;
$SkillMultiplier[Bard, $SkillSmithing] = 3;
$SkillMultiplier[Bard, $SkillMagicCraft] = 3;
$SkillMultiplier[Bard, $SkillAlchemy] = 4;
$SkillMultiplier[Bard, $SkillSpellCapacity] = 3;
$SkillMultiplier[Bard, $SkillRunSpeed] = 3;
$SkillMultiplier[Bard, $SkillEvadeMelee] = 2;
$SkillMultiplier[Bard, $SkillAiming] = 3;
$SkillMultiplier[Bard, $SkillBrawling] = 3;
$SkillMultiplier[Bard, $SkillCleave] = 2;
$SkillMultiplier[Bard, $SkillDivineCasting] = 2;
$ClassHPMuli[Bard] = 1.8;
$ClassManaMuli[Bard] = 1.4;

$EXPmultiplier[Bard] = 0.8;

//--------------
// Fighter
//--------------
// Fighters are great with swords, namely slashing weapons.  They are strong, but dumb.
// They know nothing when it comes to spells.  However they can easily wear armor and
// wield all kinds of weapons.

//Primary Skill: Slashing
//Secondary Skill: Bludgeoning

$SkillMultiplier[Fighter, $SkillSlashing] = 4;
$SkillMultiplier[Fighter, $SkillPiercing] = 1;
$SkillMultiplier[Fighter, $SkillBludgeoning] = 4;
$SkillMultiplier[Fighter, $SkillDodging] = 2;
$SkillMultiplier[Fighter, $SkillWeightCapacity] = 3;
$SkillMultiplier[Fighter, $SkillBashing] = 4;
$SkillMultiplier[Fighter, $SkillStealing] = 1;
$SkillMultiplier[Fighter, $SkillHiding] = 1;
$SkillMultiplier[Fighter, $SkillBackstabbing] = 1;
$SkillMultiplier[Fighter, $SkillOffensiveCasting] = 1;
$SkillMultiplier[Fighter, $SkillDefensiveCasting] = 1;
$SkillMultiplier[Fighter, $SkillNeutralCasting] = 1;
$SkillMultiplier[Fighter, $SkillSpellResistance] = 1;
$SkillMultiplier[Fighter, $SkillHealing] = 2;
$SkillMultiplier[Fighter, $SkillArchery] = 1;
$SkillMultiplier[Fighter, $SkillEndurance] = 4;
$SkillMultiplier[Fighter, $SkillMining] = 2;
$SkillMultiplier[Fighter, $SkillSpeech] = 1;
$SkillMultiplier[Fighter, $SkillSenseHeading] = 1;
$SkillMultiplier[Fighter, $SkillEnergy] = 1;
$SkillMultiplier[Fighter, $SkillHaggling] = 2;

$SkillMultiplier[Fighter, $SkillCastInit] = 1;
$SkillMultiplier[Fighter, $SkillLiteracy] = 2;
$SkillMultiplier[Fighter, $SkillSmithing] = 3;
$SkillMultiplier[Fighter, $SkillMagicCraft] = 1;
$SkillMultiplier[Fighter, $SkillAlchemy] = 1;
$SkillMultiplier[Fighter, $SkillSpellCapacity] = 2;
$SkillMultiplier[Fighter, $SkillRunSpeed] = 2;
$SkillMultiplier[Fighter, $SkillEvadeMelee] = 2;
$SkillMultiplier[Fighter, $SkillAiming] = 1;
$SkillMultiplier[Fighter, $SkillBrawling] = 4;
$SkillMultiplier[Fighter, $SkillCleave] = 4;
$SkillMultiplier[Fighter, $SkillDivineCasting] = 1;
$ClassHPMuli[Fighter] = 3.0;
$ClassManaMuli[Fighter] = 0.3;

$EXPmultiplier[Fighter] = 1.0;

//--------------
// Paladin
//--------------
//Paladins are much like Fighters, except that they are a bit more evenly balanced.

//Primary Skill: Bludgeoning
//Secondary Skill: Healing

$SkillMultiplier[Paladin, $SkillSlashing] = 4;
$SkillMultiplier[Paladin, $SkillPiercing] = 1;
$SkillMultiplier[Paladin, $SkillBludgeoning] = 1;
$SkillMultiplier[Paladin, $SkillDodging] = 3;
$SkillMultiplier[Paladin, $SkillWeightCapacity] = 3;
$SkillMultiplier[Paladin, $SkillBashing] = 1;
$SkillMultiplier[Paladin, $SkillStealing] = 1;
$SkillMultiplier[Paladin, $SkillHiding] = 1;
$SkillMultiplier[Paladin, $SkillBackstabbing] = 1;
$SkillMultiplier[Paladin, $SkillOffensiveCasting] = 1;
$SkillMultiplier[Paladin, $SkillDefensiveCasting] = 3;
$SkillMultiplier[Paladin, $SkillNeutralCasting] = 1;
$SkillMultiplier[Paladin, $SkillSpellResistance] = 2;
$SkillMultiplier[Paladin, $SkillHealing] = 4;
$SkillMultiplier[Paladin, $SkillArchery] = 1;
$SkillMultiplier[Paladin, $SkillEndurance] = 4;
$SkillMultiplier[Paladin, $SkillMining] = 2;
$SkillMultiplier[Paladin, $SkillSpeech] = 2;
$SkillMultiplier[Paladin, $SkillSenseHeading] = 1;
$SkillMultiplier[Paladin, $SkillEnergy] = 2;
$SkillMultiplier[Paladin, $SkillHaggling] = 2;

$SkillMultiplier[Paladin, $SkillCastInit] = 1;
$SkillMultiplier[Paladin, $SkillLiteracy] = 4;
$SkillMultiplier[Paladin, $SkillSmithing] = 2;
$SkillMultiplier[Paladin, $SkillMagicCraft] = 1;
$SkillMultiplier[Paladin, $SkillAlchemy] = 1;
$SkillMultiplier[Paladin, $SkillSpellCapacity] = 3;
$SkillMultiplier[Paladin, $SkillRunSpeed] = 3;
$SkillMultiplier[Paladin, $SkillEvadeMelee] = 4;
$SkillMultiplier[Paladin, $SkillAiming] = 1;
$SkillMultiplier[Paladin, $SkillBrawling] = 4;
$SkillMultiplier[Paladin, $SkillCleave] = 4;
$SkillMultiplier[Paladin, $SkillDivineCasting] = 3;
$ClassHPMuli[Paladin] = 1.2;
$ClassManaMuli[Paladin] = 0.8;

$EXPmultiplier[Paladin] = 1.0;

//--------------
// Ranger
//--------------
// Rangers specialize in ranged weaponry.  They are also good at finding their way when lost.
// They can also wear armors and wield weapons easily enough.

//Primary Skill: Archery
//Secondary Skills: Slashing, Sense Heading

$SkillMultiplier[Ranger, $SkillSlashing] = 2;
$SkillMultiplier[Ranger, $SkillPiercing] = 1;
$SkillMultiplier[Ranger, $SkillBludgeoning] = 1;
$SkillMultiplier[Ranger, $SkillDodging] = 3;
$SkillMultiplier[Ranger, $SkillWeightCapacity] = 2;
$SkillMultiplier[Ranger, $SkillBashing] = 1;
$SkillMultiplier[Ranger, $SkillStealing] = 1;
$SkillMultiplier[Ranger, $SkillHiding] = 3;
$SkillMultiplier[Ranger, $SkillBackstabbing] = 1;
$SkillMultiplier[Ranger, $SkillOffensiveCasting] = 1;
$SkillMultiplier[Ranger, $SkillDefensiveCasting] = 1;
$SkillMultiplier[Ranger, $SkillNeutralCasting] = 1;
$SkillMultiplier[Ranger, $SkillSpellResistance] = 1;
$SkillMultiplier[Ranger, $SkillHealing] = 2;
$SkillMultiplier[Ranger, $SkillArchery] = 4;
$SkillMultiplier[Ranger, $SkillEndurance] = 2;
$SkillMultiplier[Ranger, $SkillMining] = 2;
$SkillMultiplier[Ranger, $SkillSpeech] = 2;
$SkillMultiplier[Ranger, $SkillSenseHeading] = 4;
$SkillMultiplier[Ranger, $SkillEnergy] = 2;
$SkillMultiplier[Ranger, $SkillHaggling] = 2;

$SkillMultiplier[Ranger, $SkillCastInit] = 1;
$SkillMultiplier[Ranger, $SkillLiteracy] = 2;
$SkillMultiplier[Ranger, $SkillSmithing] = 3;
$SkillMultiplier[Ranger, $SkillMagicCraft] = 2;
$SkillMultiplier[Ranger, $SkillAlchemy] = 1;
$SkillMultiplier[Ranger, $SkillSpellCapacity] = 2;
$SkillMultiplier[Ranger, $SkillRunSpeed] = 4;
$SkillMultiplier[Ranger, $SkillEvadeMelee] = 1;
$SkillMultiplier[Ranger, $SkillAiming] = 4;
$SkillMultiplier[Ranger, $SkillBrawling] = 1;
$SkillMultiplier[Ranger, $SkillCleave] = 1;
$SkillMultiplier[Ranger, $SkillDivineCasting] = 1;
$ClassHPMuli[Ranger] = 1.1;
$ClassManaMuli[Ranger] = 1.1;

$EXPmultiplier[Ranger] = 0.95;

//--------------
// Mage
//--------------
// Mages are horrible with weapons and armor, but excel in anything that
// relates to spells.

//Primary Skill: Offensive Casting
//Secondary Skills: Energy

$SkillMultiplier[Mage, $SkillSlashing] = 1;
$SkillMultiplier[Mage, $SkillPiercing] = 1;
$SkillMultiplier[Mage, $SkillBludgeoning] = 1;
$SkillMultiplier[Mage, $SkillDodging] = 1;
$SkillMultiplier[Mage, $SkillWeightCapacity] = 1;
$SkillMultiplier[Mage, $SkillBashing] = 1;
$SkillMultiplier[Mage, $SkillStealing] = 1;
$SkillMultiplier[Mage, $SkillHiding] = 2;
$SkillMultiplier[Mage, $SkillBackstabbing] = 1;
$SkillMultiplier[Mage, $SkillOffensiveCasting] = 4;
$SkillMultiplier[Mage, $SkillDefensiveCasting] = 4;
$SkillMultiplier[Mage, $SkillNeutralCasting] = 4;
$SkillMultiplier[Mage, $SkillSpellResistance] = 4;
$SkillMultiplier[Mage, $SkillHealing] = 2;
$SkillMultiplier[Mage, $SkillArchery] = 1;
$SkillMultiplier[Mage, $SkillEndurance] = 1;
$SkillMultiplier[Mage, $SkillMining] = 2;
$SkillMultiplier[Mage, $SkillSpeech] = 2;
$SkillMultiplier[Mage, $SkillSenseHeading] = 2;
$SkillMultiplier[Mage, $SkillEnergy] = 4;
$SkillMultiplier[Mage, $SkillHaggling] = 2;

$SkillMultiplier[Mage, $SkillCastInit] = 4;
$SkillMultiplier[Mage, $SkillLiteracy] = 4;
$SkillMultiplier[Mage, $SkillSmithing] = 1;
$SkillMultiplier[Mage, $SkillMagicCraft] = 4;
$SkillMultiplier[Mage, $SkillAlchemy] = 4;
$SkillMultiplier[Mage, $SkillSpellCapacity] = 4;
$SkillMultiplier[Mage, $SkillRunSpeed] = 1;
$SkillMultiplier[Mage, $SkillEvadeMelee] = 1;
$SkillMultiplier[Mage, $SkillAiming] = 1;
$SkillMultiplier[Mage, $SkillBrawling] = 1;
$SkillMultiplier[Mage, $SkillCleave] = 1;
$SkillMultiplier[Mage, $SkillDivineCasting] = 4;
$ClassHPMuli[Mage] = 0.8;
$ClassManaMuli[Mage] = 1.2;

$EXPmultiplier[Mage] = 1.0;

//######################################################################################
// Skill Restriction tables
//######################################################################################

//To determine skill restrictions, do the following:
//
//-Determine the following variables first:
//	(weapon):
//	a = ATK * 1.1 (archery is 0.75)
//	b = Delay = Cap((Weight / 3), 1, "inf")
//
//	(armor):
//	a = (DEF + MDEF) / 6
//	b = 1.0
//
//-To find out what the skill restriction number is, follow this formula, where s is the final skill restriction:
//	s = Cap((a / b) - 20), 0, "inf") * 10.0;
//

$SkillRestriction[BluePotion] = $SkillHealing @ " 0";
$SkillRestriction[CrystalBluePotion] = $SkillHealing @ " 0";
$SkillRestriction[ApprenticeRobe] = $SkillEndurance @ " 0 " @ $SkillEnergy @ " 8";
$SkillRestriction[LightRobe] = $SkillEndurance @ " 3 " @ $SkillEnergy @ " 80";
$SkillRestriction[FineRobe] = $SkillEndurance @ " 9 " @ $SkillEnergy @ " 175";
$SkillRestriction[BloodRobe] = $SkillEndurance @ " 8 " @ $SkillEnergy @ " 300";
$SkillRestriction[AdvisorRobe] = $SkillEndurance @ " 10 " @ $SkillEnergy @ " 450";
$SkillRestriction[ElvenRobe] = $SkillEndurance @ " 12 " @ $SkillEnergy @ " 620";
$SkillRestriction[RobeOfVenjance] = $SkillEndurance @ " 18 " @ $SkillEnergy @ " 800";
$SkillRestriction[PhensRobe] = $SkillEndurance @ " 20 " @ $SkillEnergy @ " 980";
$SkillRestriction[QuestMasterRobe] = $MinAdmin @ " 3";

$SkillRestriction[PaddedArmor] = $SkillEndurance @ " 5";
$SkillRestriction[LeatherArmor] = $SkillEndurance @ " 40";
$SkillRestriction[StuddedLeather] = $SkillEndurance @ " 95";
$SkillRestriction[SpikedLeather] = $SkillEndurance @ " 135";
$SkillRestriction[HideArmor] = $SkillEndurance @ " 180";
$SkillRestriction[ScaleMail] = $SkillEndurance @ " 240";
$SkillRestriction[BrigandineArmor] = $SkillEndurance @ " 300";
$SkillRestriction[ChainMail] = $SkillEndurance @ " 350";
$SkillRestriction[RingMail] = $SkillEndurance @ " 410";
$SkillRestriction[BandedMail] = $SkillEndurance @ " 490";
$SkillRestriction[SplintMail] = $SkillEndurance @ " 580";
$SkillRestriction[BronzePlateMail] = $SkillEndurance @ " 660";
$SkillRestriction[PlateMail] = $SkillEndurance @ " 775";
$SkillRestriction[FieldPlateArmor] = $SkillEndurance @ " 840";
$SkillRestriction[DragonMail] = $SkillEndurance @ " 950";
$SkillRestriction[FullPlateArmor] = $SkillEndurance @ " 1065";
$SkillRestriction[CheetaursPaws] = $MinLevel @ " 8";
$SkillRestriction[BootsOfGliding] = $MinLevel @ " 25";
$SkillRestriction[WindWalkers] = $MinLevel @ " 60";
$SkillRestriction[KeldrinArmor] = $SkillEndurance @ " 1305";

$SkillRestriction[KnightShield] = $SkillEndurance @ " 140";
$SkillRestriction[HeavenlyShield] = $SkillEndurance @ " 540 " @ $SkillEnergy @ " 850";
$SkillRestriction[DragonShield] = $SkillEndurance @ " 715";

$SkillRestriction[Hatchet] = $SkillSlashing @ " 0";
$SkillRestriction[BroadSword] = $SkillSlashing @ " 20";
$SkillRestriction[WarAxe] = $SkillSlashing @ " 60";
$SkillRestriction[LongSword] = $SkillSlashing @ " 140";
$SkillRestriction[BattleAxe] = $SkillSlashing @ " 300";
$SkillRestriction[BastardSword] = $SkillSlashing @ " 620";
$SkillRestriction[Halberd] = $SkillSlashing @ " 768";
$SkillRestriction[Claymore] = $SkillSlashing @ " 900";
$SkillRestriction[KeldriniteLS] = $SkillSlashing @ " 1120 " @ $MinRemort @ " 1";
//.................................................................................
$SkillRestriction[Club] = $SkillBludgeoning @ " 0";
$SkillRestriction[QuarterStaff] = $SkillBludgeoning @ " 20";
$SkillRestriction[BoneClub] = $SkillBludgeoning @ " 45";
$SkillRestriction[SpikedClub] = $SkillBludgeoning @ " 60";
$SkillRestriction[Mace] = $SkillBludgeoning @ " 140";
$SkillRestriction[HammerPick] = $SkillBludgeoning @ " 300";
$SkillRestriction[SpikedBoneClub] = $SkillBludgeoning @ " 450";
$SkillRestriction[LongStaff] = $SkillBludgeoning @ " 620";
$SkillRestriction[WarHammer] = $SkillBludgeoning @ " 768";
$SkillRestriction[JusticeStaff] = $SkillBludgeoning @ " 834";
$SkillRestriction[WarMaul] = $SkillBludgeoning @ " 900";
//.................................................................................
$SkillRestriction[PickAxe] = $SkillPiercing @ " 0";
$SkillRestriction[Knife] = $SkillPiercing @ " 0";
$SkillRestriction[Dagger] = $SkillPiercing @ " 60";
$SkillRestriction[ShortSword] = $SkillPiercing @ " 140";
$SkillRestriction[Spear] = $SkillPiercing @ " 280";
$SkillRestriction[Gladius] = $SkillPiercing @ " 450";
$SkillRestriction[Trident] = $SkillPiercing @ " 620";
$SkillRestriction[Rapier] = $SkillPiercing @ " 768";
$SkillRestriction[AwlPike] = $SkillPiercing @ " 900";
//.................................................................................
$SkillRestriction[Sling] = $SkillArchery @ " 0";
$SkillRestriction[ShortBow] = $SkillArchery @ " 25";
$SkillRestriction[LightCrossbow] = $SkillArchery @ " 160";
$SkillRestriction[LongBow] = $SkillArchery @ " 318";
$SkillRestriction[CompositeBow] = $SkillArchery @ " 438";
$SkillRestriction[RepeatingCrossbow] = $SkillArchery @ " 550";
$SkillRestriction[ElvenBow] = $SkillArchery @ " 685";
$SkillRestriction[AeolusWing] = $SkillArchery @ " 805";
$SkillRestriction[HeavyCrossbow] = $SkillArchery @ " 925";
//.................................................................................
$SkillRestriction[SmallRock] = $SkillArchery @ " 0";
$SkillRestriction[BasicArrow] = $SkillArchery @ " 0";
$SkillRestriction[ShortQuarrel] = $SkillArchery @ " 0";
$SkillRestriction[LightQuarrel] = $SkillArchery @ " 0";
$SkillRestriction[SheafArrow] = $SkillArchery @ " 0";
$SkillRestriction[StoneFeather] = $SkillArchery @ " 0";
$SkillRestriction[BladedArrow] = $SkillArchery @ " 0";
$SkillRestriction[HeavyQuarrel] = $SkillArchery @ " 0";
$SkillRestriction[MetalFeather] = $SkillArchery @ " 0";
$SkillRestriction[Talon] = $SkillArchery @ " 0";
$SkillRestriction[CeraphumsFeather] = $SkillArchery @ " 0";


$SkillRestriction[RHatchet] = $SkillRestriction[Hatchet];
$SkillRestriction[RBroadSword] = $SkillRestriction[BroadSword];
$SkillRestriction[RWarAxe] = $SkillRestriction[WarAxe];
$SkillRestriction[RLongSword] = $SkillRestriction[LongSword];
$SkillRestriction[RClub] = $SkillRestriction[Club];
$SkillRestriction[RSpikedClub] = $SkillRestriction[SpikedClub];
$SkillRestriction[RPickAxe] = $SkillRestriction[PickAxe];
$SkillRestriction[RKnife] = $SkillRestriction[Knife];
$SkillRestriction[RDagger] = $SkillRestriction[Dagger];
$SkillRestriction[RShortSword] = $SkillRestriction[ShortSword];
$SkillRestriction[RShortBow] = $SkillRestriction[ShortBow];
$SkillRestriction[RLightCrossbow] = $SkillRestriction[LightCrossbow];

// Spells
$SkillRestriction[thorn] = $SkillOffensiveCasting @ " 15";
$SkillRestriction[fireball] = $SkillOffensiveCasting @ " 20";
$SkillRestriction[firebomb] = $SkillOffensiveCasting @ " 35";
$SkillRestriction[icespike] = $SkillOffensiveCasting @ " 45";
$SkillRestriction[icestorm] = $SkillOffensiveCasting @ " 85";
$SkillRestriction[ironfist] = $SkillOffensiveCasting @ " 110";
$SkillRestriction[cloud] = $SkillOffensiveCasting @ " 145";
$SkillRestriction[melt] = $SkillOffensiveCasting @ " 220";
$SkillRestriction[powercloud] = $SkillOffensiveCasting @ " 340";
$SkillRestriction[hellstorm] = $SkillOffensiveCasting @ " 420";
$SkillRestriction[beam] = $SkillOffensiveCasting @ " 520";
$SkillRestriction[dimensionrift] = $SkillOffensiveCasting @ " 750";

$SkillRestriction[teleport] = $SkillNeutralCasting @ " 60";
$SkillRestriction[transport] = $SkillNeutralCasting @ " 200";
$SkillRestriction[advtransport] = $SkillNeutralCasting @ " 350";
$SkillRestriction[remort] = $SkillNeutralCasting @ " 0 " @ $MinLevel @ " 101";
$SkillRestriction[mimic] = $SkillNeutralCasting @ " 145 " @ $MinRemort @ " 2";
$SkillRestriction[masstransport] = $SkillNeutralCasting @ " 650 " @ $MinRemort @ " 1";

$SkillRestriction[heal] = $SkillDefensiveCasting @ " 10";
$SkillRestriction[advheal1] = $SkillDefensiveCasting @ " 80";
$SkillRestriction[advheal2] = $SkillDefensiveCasting @ " 110";
$SkillRestriction[advheal3] = $SkillDefensiveCasting @ " 200";
$SkillRestriction[advheal4] = $SkillDefensiveCasting @ " 320";
$SkillRestriction[advheal5] = $SkillDefensiveCasting @ " 400";
$SkillRestriction[advheal6] = $SkillDefensiveCasting @ " 500";
$SkillRestriction[godlyheal] = $SkillDefensiveCasting @ " 600";
$SkillRestriction[fullheal] = $SkillDefensiveCasting @ " 750";
$SkillRestriction[massheal] = $SkillDefensiveCasting @ " 850 " @ $MinRemort @ " 2";
$SkillRestriction[massfullheal] = $SkillDefensiveCasting @ " 950 " @ $MinRemort @ " 3";
$SkillRestriction[shield] = $SkillDefensiveCasting @ " 20";
$SkillRestriction[advshield1] = $SkillDefensiveCasting @ " 60";
$SkillRestriction[advshield2] = $SkillDefensiveCasting @ " 140";
$SkillRestriction[advshield3] = $SkillDefensiveCasting @ " 290";
$SkillRestriction[advshield4] = $SkillDefensiveCasting @ " 420";
$SkillRestriction[advshield5] = $SkillDefensiveCasting @ " 635";
$SkillRestriction[massshield] = $SkillDefensiveCasting @ " 680";


function MenuGroup(%clientId)
{
	dbecho($dbechoMode, "MenuGroup(" @ %clientId @ ")");

	Client::buildMenu(%clientId, "Pick a group:", "pickgroup", true);
	Client::addMenuItem(%clientId, "1Priest", 1);
	Client::addMenuItem(%clientId, "2Rogue", 2);
	Client::addMenuItem(%clientId, "3Warrior", 3);
	Client::addMenuItem(%clientId, "4Wizard", 4);

	Client::addMenuItem(%clientId, "x<-- BACK", "back");	

	return;
}
function processMenupickgroup(%clientId, %opt)
{
	dbecho($dbechoMode, "processMenupickgroup(" @ %clientId @ ", " @ %opt @ ")");

	if(%opt == "back")
	{
		%clientId.choosingGroup = "";
		%clientId.choosingRace = True;
		storeData(%clientId, "CruRACE", "Human");

		MenuRace(%clientId);
		return;
	}

	if(%opt == 1)
		storeData(%clientId, "GROUP", "Priest");
	else if(%opt == 2)
		storeData(%clientId, "GROUP", "Rogue");
	else if(%opt == 3)
		storeData(%clientId, "GROUP", "Warrior");
	else if(%opt == 4)
		storeData(%clientId, "GROUP", "Wizard");

	%clientId.choosingGroup = "";
	%clientId.choosingClass = True;

	MenuClass(%clientId);
}

function MenuClass(%clientId)
{
	dbecho($dbechoMode, "MenuClass(" @ %clientId @ ")");

	Client::buildMenu(%clientId, "Pick a class:", "pickclass", true);

	%op = 0;
	for(%i = 1; $ClassName[%i, 0] != ""; %i++)
	{
		if(String::ICompare(fetchData(%clientId, "GROUP"), $ClassGroup[$ClassName[%i, 0]]) == 0)
		{
			%op++;
			Client::addMenuItem(%clientId, %op @ $ClassName[%i, 0], %op);
		}
	}
	Client::addMenuItem(%clientId, "x<-- BACK", "back");


	return;
}
function processMenupickclass(%clientId, %opt)
{
	dbecho($dbechoMode, "processMenupickclass(" @ %clientId @ ", " @ %opt @ ")");

	if(%opt == "back")
	{
		%clientId.choosingClass = "";
		%clientId.choosingGroup = True;
		storeData(%clientId, "GROUP", "");

		MenuGroup(%clientId);
		return;
	}

	%op = 0;
	for(%i = 1; $ClassName[%i, 0] != ""; %i++)
	{
		if(String::ICompare(fetchData(%clientId, "GROUP"), $ClassGroup[$ClassName[%i, 0]]) == 0)
		{
			%op++;
			if(%op == %opt)
				storeData(%clientId, "CLASS", $ClassName[%i, 0]);
		}
	}

	//let the player enter the world
	%clientId.choosingClass = "";
	Game::playerSpawn(%clientId, false);

	//######### set a few start-up variables ########
	storeData(%clientId, "COINS", GetRoll($initcoins[fetchData(%clientId, "GROUP")]));

	//add $autoStartupSP for each skill
	for(%i = 1; %i <= getNumSkills(); %i++)
		AddSkillPoint(%clientId, %i, $autoStartupSP);
	//###############################################

	centerprint(%clientId, "<f1>Server powered by the RPG MOD version " @ $rpgver @ "<f0>\n\n" @ $loginMsg, 15);
}



function OldGetLevel(%ex, %clientId)
{
	dbecho($dbechoMode, "GetLevel(" @ %ex @ ", " @ %clientId @ ")");

	%m = GetEXPmultiplier(%clientId);

	if(%m != 0)
	{
		%a = (  (-500 * %m) + FixDecimals(sqrt( (250000 * %m * %m) + (2000 * %m * %ex) ))  ) / (1000 * %m);
		%b = floor(%a) + 1;
	}

	return %b;
}
function OldGetExp(%level, %clientId)
{
	dbecho($dbechoMode, "GetExp(" @ %level @ ", " @ %clientId @ ")");

	%m = GetEXPmultiplier(%clientId);

	%level--;
	%a = (500 * %level) + (500 * %level * %level);
	%b = floor( (%a * %m) + 0.2);

	return %b;
}

//-------------------------------------------------------------------------------------

// CRU LEVELING

// 1000


function GetLevel(%exp)
{
 	%l = (sqrt(625 + (5 * %exp)) / 50) - 0.5;
	echo(floor(%l + 1));
	return floor(%l + 1);
}

function GetExp(%lvl)
{
	%lvl = %lvl - 1;
	%e = ((%lvl * %lvl) * 500) + (%lvl * 500);
	// echo(%e);
	return %e;
}


// EXPTNL = LVL * (1000 + (RL * 55))
function REMOVED_GetLevel_2(%ex, %clientId)
{
	%rl = fetchData(%clientId,"RemortStep");
	%e = %ex;
	%l = 0;
	for (%i = 1; %e > 0; %i++) {
		//%n = (%i * (1000 + (%rl * 50)));
		%n = (%i * (1000 + (%i * 500)));
		if (%e >= %n)
			%l++;
		%e -= %n;
	}
	return (%l + 1);
}
function REMOVED_GetExp(%level, %clientId)
{
	%rl = fetchData(%clientId,"RemortStep");
	%e = 0;
	for (%i = 1; %i <= (%level - 1); %i++) {
		//%n = (%i * (1000 + (%rl * 50)));
		%n = (%i * (1000 + (%i * 500)));
		%e += %n;
	}
	return %e;
}

function GetExpRl(%level,%rl) 
{
	echo("LVLEXP " @ floor(%level * (1000 + (%rl * 50))));
	return floor(%level * (1000 + (%rl * 50)));
}

function GetMaxExpRl(%level,%rl)
{
	%exp = GetExpRl(%level,%rl);
	if (%level <= 2)
		return %exp;
	else
		return floor(%exp / (%level / 4));
}

	// REMOVED
	//if(%type == "LVL")
	//{
	//	%a = GetLevel(fetchData(%clientId, "EXP"), %clientId);
	//	return %a;
	//}

	//for(%i = 1; $ClassName[%i, 0] != ""; %i++)
	//{
	//	if(String::ICompare($ClassName[%i, 0], fetchData(%clientId, "CLASS")) == 0)
	//		return $ClassName[%i, fetchData(%clientId, "RemortStep")];
	//}
	//return -1;


function AddSkillPoint(%clientId,%skill,%delta)
{
	%error = "";
	%delta = 1;
	%cur = $PlayerSkill[%clientId,%skill];
	%multi = GetSkillMultiplier(%clientId, %skill);
	if (%multi == 4 || %multi == 3) {
		if (%cur >= (fetchData(%clientId,"LVL") * 12))
			%error = "max 12";
	}
	else {
		if (%cur >= (fetchData(%clientId,"LVL") * 10))
			%error = "max 10";
	}
	if (getWord(%error,0) == "max") {
		Client::SendMessage(%clientId,0,"Maximum skill increase for '" @ $SkillDesc[%skill] @ "' is " @ getWord(%error,1) @ " per level.");
		return False;
	}
	$PlayerSkill[%clientId,%skill] += %multi;
	return True;
}

function MenuCruSPSelect(%clientId,%select,%page)
{
	Client::buildMenu(%clientId, "You have " @ fetchData(%clientId, "SPcredits") @ " SP credits", "CruSPSelect", true);
	if (%select == "abilities") {
		if (%page == 1) {
			%cnt = 0;
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillStrength) @ ") Strength", "abilities 1 " @ $SkillStrength);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillStamina) @ ") Stamina", "abilities 1 " @ $SkillStamina);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillAgility) @ ") Agility", "abilities 1 " @ $SkillAgility);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSense) @ ") Sense", "abilities 1 " @ $SkillSense);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillIntelligence) @ ") Intelligence", "abilities 1 " @ $SkillIntelligence);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillPsychic) @ ") Psychic", "abilities 1 " @ $SkillPsychic);
			Client::addMenuItem(%clientId, "p<< Prev", "prev abilities");
			Client::addMenuItem(%clientId, "xDone", "done");
		}	
	}
	if (%select == "body") {
		if (%page == 1) {
			%cnt = 0;
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillEndurance) @ ") Endurance", "body 1 " @ $SkillEndurance);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillEnergy) @ ") Energy", "body 1 " @ $SkillEnergy);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillWeightCapacity) @ ") Weight Capacity", "body 1 " @ $SkillWeightCapacity);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillHiding) @ ") Hiding", "body 1 " @ $SkillHiding);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillHealing) @ ") Healing", "body 1 " @ $SkillHealing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSpellCapacity) @ ") Focus", "body 1 " @ $SkillSpellCapacity);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillMartialArts) @ ") Martial Arts", "body 1 " @ $SkillMartialArts);
			//Client::addMenuItem(%clientId, "nNext >>", "next body 2");
			Client::addMenuItem(%clientId, "p<< Prev", "prev abilities");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
		if (%page == 2) {
			%cnt = 0;
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSpellCapacity) @ ") Focus", "body 2 " @ $SkillSpellCapacity);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillMartialArts) @ ") Martial Arts", "body 2 " @ $SkillMartialArts);
			Client::addMenuItem(%clientId, "p<< Prev", "prev body 1");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
	if (%select == "weapon") {
		if (%page == 1) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSlashing) @ ") Slashing", "weapon 1 " @ $SkillSlashing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillPiercing) @ ") Piercing", "weapon 1 " @ $SkillPiercing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillBludgeoning) @ ") Bludgeoning", "weapon 1 " @ $SkillBludgeoning);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillArchery) @ ") Archery", "weapon 1 " @ $SkillArchery);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillBashing) @ ") Bashing", "weapon 1 " @ $SkillBashing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillAiming) @ ") Aiming", "weapon 1 " @ $SkillAiming);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillBrawling) @ ") Brawling", "weapon 1 " @ $SkillBrawling);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillBackstabbing) @ ") Sneak Attack", "weapon 1 " @ $SkillBackstabbing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillCleave) @ ") Cleave", "weapon 1 " @ $SkillCleave);
			Client::addMenuItem(%clientId, "0" @ "(" @ GetPlayerSkill(%clientId,$SkillWeaponHandling) @ ") Weapon Handling", "weapon 1 " @ $SkillWeaponHandling);
			//Client::addMenuItem(%clientId, "nNext >>", "next weapon 2");
			Client::addMenuItem(%clientId, "p<< Prev", "prev abilities");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
		if (%page == 2) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillAiming) @ ") Aiming", "weapon 2 " @ $SkillAiming);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillBrawling) @ ") Brawling", "weapon 2 " @ $SkillBrawling);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillBackstabbing) @ ") Sneak Attack", "weapon 2 " @ $SkillBackstabbing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillCleave) @ ") Cleave", "weapon 2 " @ $SkillCleave);
			Client::addMenuItem(%clientId, "p<< Prev", "prev weapon 1");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
	if (%select == "speed") {
		if (%page == 1) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillEvadeMelee) @ ") Evade Melee", "speed 1 " @ $SkillEvadeMelee);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillDodging) @ ") Dodge Ranged", "speed 1 " @ $SkillDodging);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSpellResistance) @ ") Spell Resistance", "speed 1 " @ $SkillSpellResistance);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillCastInit) @ ") Cast Initiative", "speed 1 " @ $SkillCastInit);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillStealing) @ ") Stealing", "speed 1 " @ $SkillStealing);
			Client::addMenuItem(%clientId, "p<< Prev", "prev abilities");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
	if (%select == "spells") {
		if (%page == 1) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillPrimalMagic) @ ") Primal Magic", "spells 1 " @ $SkillPrimalMagic);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillHolyMagic) @ ") Holy Magic", "spells 1 " @ $SkillHolyMagic);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillEmpowerment) @ ") Empowerment", "spells 1 " @ $SkillEmpowerment);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillDarkMagic) @ ") Dark Magic", "spells 1 " @ $SkillDarkMagic);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillLightMagic) @ ") Light Magic", "spells 1 " @ $SkillLightMagic);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillRitual) @ ") Ritual", "spells 1 " @ $SkillRitual);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSorcery) @ ") Sorcery", "spells 1 " @ $SkillSorcery);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillProtection) @ ") Protection", "spells 1 " @ $SkillProtection);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillEnchantment) @ ") Enchantment", "spells 1 " @ $SkillEnchantment);
			Client::addMenuItem(%clientId, "p<< Prev", "prev abilities");
		}
	}
	if (%select == "trade") {
		if (%page == 1) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillMining) @ ") Mining", "trade 1 " @ $SkillMining);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSpeech) @ ") Speech", "trade 1 " @ $SkillSpeech);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSenseHeading) @ ") Sense Heading", "trade 1 " @ $SkillSenseHeading);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillHaggling) @ ") Haggling", "trade 1 " @ $SkillHaggling);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillLiteracy) @ ") Literacy", "trade 1 " @ $SkillLiteracy);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSmithing) @ ") Smithing", "trade 1 " @ $SkillSmithing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillMagicCraft) @ ") Magic Crafting", "trade 1 " @ $SkillMagicCraft);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillAlchemy) @ ") Alchemy", "trade 1 " @ $SkillAlchemy);
			//Client::addMenuItem(%clientId, "nNext >>", "next trade 2");
			Client::addMenuItem(%clientId, "p<< Prev", "prev abilities");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
		if (%page == 2) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillSmithing) @ ") Smithing", "trade 2 " @ $SkillSmithing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillMagicCraft) @ ") Magic Crafting", "trade 2 " @ $SkillMagicCraft);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ GetPlayerSkill(%clientId,$SkillAlchemy) @ ") Alchemy", "trade 2 " @ $SkillAlchemy);
			Client::addMenuItem(%clientId, "p<< Prev", "prev trade 1");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
}


// MIND BODY SOUL SPIRIT GHOST

$BPWearLocation[16] = "mind";
$BPLocationToNumeric["mind"] = 16;

$BPWearLocation[17] = "body";
$BPLocationToNumeric["body"] = 17;

$BPWearLocation[18] = "soul";
$BPLocationToNumeric["soul"] = 18;

$BPWearLocation[19] = "spirit";
$BPLocationToNumeric["spirit"] = 19;

$BPWearLocation[20] = "ghost";
$BPLocationToNumeric["ghost"] = 20;

function TierItem::Create_UNUSED(%new,%slot)
{
	%find = string::FindSubStr(%new,"^");
	%name = string::GetSubStr(%new,3,(%find - 3));
	%ql = floor(string::GetSubStr(%new,0,3) + 0);
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	%plen = (string::len(%tperc) + 1);
	%perc = %tperc / 100;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));

	if (%slot == -1) {
		// INITIAL CREATE
		%slot = $DynamicItem[%name,$DItemType];
		%slot = getWord(%slot,1);
	}

	echo(%name @ " " @ %cropparts @ " " @ %perc @ " " @ %slot);
	%s[1] = string::GetSubStr(%cropparts,0,2);
	%s[2] = string::GetSubStr(%cropparts,2,2);
	%s[3] = string::GetSubStr(%cropparts,4,2);
	%s[4] = string::GetSubStr(%cropparts,6,2);
	%s[5] = string::GetSubStr(%cropparts,8,2);
	%s[6] = string::GetSubStr(%cropparts,10,2);
	%s[7] = string::GetSubStr(%cropparts,12,2);
	%s[8] = string::GetSubStr(%cropparts,14,2);
	%s[9] = string::GetSubStr(%cropparts,16,2);
	%s[10] = string::GetSubStr(%cropparts,18,2);
	// CLEAR ALL VARS
	%numr = $TierRandom[%slot];
	for (%i = 1; %i <= 99; %i++) %val[%i] = 0;
	// STACK VARS
	for (%i = 1; %i <= 10; %i++) {
		if ((%check = %s[%i]) != "") {
			%x = (%s[%i] + 0);
			%val[%x]++;
		}
	}
	// MODIFIERS
	%list = "";
	%weight = 0;
	for (%i = 1; %i <= 6; %i++) %r[%i] = 0;
	for (%i = 1; %i <= 6; %i++) %rh[%i] = 0;
	for (%i = 1; %i <= 99; %i++) {
		if (%val[%i] > 0) {
			%vi = %val[%i];
			if (%slot == "Amulet") %av = $AmuletVal[%i];
			if (%slot == "Chest") %av = $ChestVal[%i];
			if (%slot == "Head") %av = $HeadVal[%i];
			if (%slot == "Ring") %av = $RingVal[%i];
			if (%slot == "Hands") %av = $HandsVal[%i];
			if (%slot == "Legs") %av = $LegsVal[%i];
			if (%slot == "Boots") %av = $BootsVal[%i];
			if (%slot == "Talisman") %av = $TalismanVal[%i];
			if (%slot == "Study") %av = $StudyVal[%i];
			if (%slot == "Orb") %av = $OrbVal[%i];
			%stat = getWord(%av,0);
			%req = $TierReq[%stat];
			if (%r[%req] == 0) { 
				%r[%req] += $TierReqP[%stat];
				%rh[%req] = $TierReqP[%stat];
			}
			else {
				if (%rh[%req] < $TierReqP[%stat]) {
					%rh[%req] = $TierReqP[%stat];
					%r[%req] = $TierReqP[%stat];
				}
				else {
					%r[%req] = $TierReqP[%stat];
				}
			}
			%weight = %weight + floor(floor(floor($TierWeight[%stat] * %perc) + 1) * (%ql/300));
			%weight = %weight + 1;
			%max = getWord(%av,1);
			%t = round(floor((%max * %vi) * %perc) * (%ql / 300));
			if (%t < 1) %t = 1;
			%list = %list @ %stat @ " " @ %t @ " ";
		}
	}
	%rlist = "";
	%rmax = 3360;
	for (%i = 1; %i <= 6; %i++) {
		if (%r[%i] > 0) {
			%radd = floor(floor(floor((%rmax * %r[%i]) * %perc) * (%ql / 300)) + 1);
			%rlist = %rlist @ $reqdisp[%i] @ " " @ %radd @ " ";
		}
	}
	// PRICE
	%price = $DynamicItem[%name,$DPrice];
	%pmin = getWord(%price,0);
	%praise = getWord(%price,1);
	%price = floor((%praise * %ql) + %min);
	%price = floor(%price * %perc);
	
	 echo(%list);
	 echo(%rlist);
	 echo("WEIGHT " @ %weight);
	 echo("PRICE " @ %price);

	$BPItem[%new,$BPName] = $DynamicItem[%name,$DName];
	$BPItem[%new,$BPWeight] = %weight;
	$BPItem[%new,$BPPrice] = %price;
	$BPItem[%new,$BPWield] = "LOCATION " @ $TierLoc[%slot] @ " " @ %rlist;
	$BPItem[%new,$BPWieldBonus] = %list;
	$BPItem[%new,$BPDesc] = $DynamicItem[%name,$DDesc];
	$BPItem[%new,$BPItemType] = $DynamicItem[%name,$DItemType];
	$BPItem[%new,$BPTierPerc] = %tperc;
	if ($DynamicItem[%name,$DIco] != "")
		$BPItem[%new,$BPIco] = $DynamicItem[%name,$DIco];
	if ($DynamicItem[%name,$DSet] != "")
		$BPItem[%new,$BPSet] = $DynamicItem[%name,$DSet];
}

function AddToCommonTier(%mod,%vars,%types)
{
	echo("*** ADD TO COMMON TIER: " @ %mod @ " " @ %vars @ " " @ %types);
	//***********************************************************
	// 1      2    3    4     5      6    7     8        9   10   11     12     13     14    15   16
	// AMULET RING HEAD CHEST HANDS LEGS BOOTS TALISMAN ORB BELT POCKET WEAPON SHIELD STUDY BACK ARMOR
	//***********************************************************
	// AMULET ======================================
	%v = getWord(%vars,0);
	if (%v != 0) {
		if (string::findSubStr(%types,"LDYN") != -1 || string::findSubStr(%types,"DYN") != -1) {
			$COUNTAMULET[LDYN]++;
			%c = $COUNTAMULET[LDYN];
			$BPTIERVAR["Amulet","LDYN",%c] = $BPCODE[%mod];
			$BPTIERVAL["Amulet","LDYN",%c] = %v;
		} 
		if (string::findSubStr(%types,"DYN") != -1) {
			$COUNTAMULET[DYN]++;
			%c = $COUNTAMULET[DYN];
			$BPTIERVAR["Amulet","DYN",%c] = $BPCODE[%mod];
			$BPTIERVAL["Amulet","DYN",%c] = %v;
		}
		if (string::findSubStr(%types,"AMR") != -1) {
			$COUNTAMULET[AMR]++;
			%c = $COUNTAMULET[AMR];
			$BPTIERVAR["Amulet","AMR",%c] = $BPCODE[%mod];
			$BPTIERVAL["Amulet","AMR",%c] = %v;
		}
	}
	// RING  ======================================
	%v = getWord(%vars,1);
	if (%v != 0) { $COUNTRING++; %c = $COUNTRING; $VARRING[%c] = $BPCODE[%mod]; }
	// HEAD  ======================================
	%v = getWord(%vars,2);
	if (%v != 0) { $COUNTHEAD++; %c = $COUNTHEAD; $VARHEAD[%c] = $BPCODE[%mod]; }
	// CHEST  ======================================
	%v = getWord(%vars,3);
	if (%v != 0) { 
		if (string::findSubStr(%types,"DYN") != -1) {
			$COUNTCHEST[DYN]++;
			%c = $COUNTCHEST[DYN];
			$BPTIERVAR["Chest","DYN",%c] = $BPCODE[%mod];
			$BPTIERVAL["Chest","DYN",%c] = %v;
		}
		if (string::findSubStr(%types,"AMR") != -1) {
			$COUNTCHEST[AMR]++;
			%c = $COUNTCHEST[AMR];
			$BPTIERVAR["Chest","AMR",%c] = $BPCODE[%mod];
			$BPTIERVAL["Chest","AMR",%c] = %v;
		}
	}
	// HANDS  ======================================
	%v = getWord(%vars,4);
	if (%v != 0) { $COUNTHANDS++; %c = $COUNTHANDS; $VARHANDS[%c] = $BPCODE[%mod]; }
	// LEGS  ======================================
	%v = getWord(%vars,5);
	if (%v != 0) { $COUNTLEGS++; %c = $COUNTLEGS; $VARLEGS[%c] = $BPCODE[%mod]; }
	// BOOTS  ======================================
	%v = getWord(%vars,6);
	if (%v != 0) { $COUNTBOOTS++; %c = $COUNTBOOTS; $VARBOOTS[%c] = $BPCODE[%mod]; }
	// TALISMAN ======================================
	%v = getWord(%vars,7);
	if (%v != 0) { $COUNTTALISMAN++; %c = $COUNTTALISMAN; $VARTALISMAN[%c] = $BPCODE[%mod]; }
	// ORB ======================================
	%v = getWord(%vars,8);
	if (%v != 0) { $COUNTORB++; %c = $COUNTORB; $VARORB[%c] = $BPCODE[%mod]; }
	// BELT ======================================
	%v = getWord(%vars,9);
	if (%v != 0) { $COUNTBELT++; %c = $COUNTBELT; $VARBELT[%c] = $BPCODE[%mod]; }
	// POCKET ======================================
	%v = getWord(%vars,10);
	if (%v != 0) { $COUNTPOCKET++; %c = $COUNTPOCKET; $VARPOCKET[%c] = $BPCODE[%mod]; }
	// WEAPON ======================================
	%v = getWord(%vars,11);
	if (%v != 0) { $COUNTWEAPON++; %c = $COUNTWEAPON; $VARWEAPON[%c] = $BPCODE[%mod]; }
	// SHIELD ======================================
	%v = getWord(%vars,12);
	if (%v != 0) { $COUNTSHIELD++; %c = $COUNTSHIELD; $VARSHIELD[%c] = $BPCODE[%mod]; }
	// STUDY ======================================
	%v = getWord(%vars,13);
	if (%v != 0) { $COUNTSTUDY++; %c = $COUNTSTUDY; $VARSTUDY[%c] = $BPCODE[%mod]; }
	// BACK ======================================
	%v = getWord(%vars,14);
	if (%v != 0) { $COUNTBACK++; %c = $COUNTBACK; $VARBACK[%c] = $BPCODE[%mod]; }
	// ARMOR ======================================
	%v = getWord(%vars,15);
	if (%v != 0) { $COUNTARMOR++; %c = $COUNTARMOR; $VARARMOR[%c] = $BPCODE[%mod]; }

}

$Essence[SoulStone] = 1;
$Essence[BodyStone] = 1;
$Essence[MindStone] = 1;
$Essence[SpiritStone] = 1;
$Essence[GhostStone] = 1;

$EssToLocation[SoulStone] = "soul";
$EssToLocation[SpiritStone] = "spirit";
$EssToLocation[BodyStone] = "body";
$EssToLocation[MindStone] = "mind";
$EssToLocation[GhostStone] = "ghost";

function BPCraftEssence(%id,%base,%qlbase,%mix,%qlmix)
{
	echo(" BPCRAFTESSENCE Base " @ %base);

	%find = string::FindSubStr(%base,"-");
	
	%type = string::GetSubStr(%base,0,%find);

	echo(" BPCRAFTESSENCE Type " @ %type);
	
	%cropparts = string::GetSubStr(%base,(%find+1),999);

	echo(" BPCRAFTESSENCE Crop Parts " @ %cropparts);

	%part[0] = string::GetSubStr(%cropparts,0,2);
	%part[1] = string::GetSubStr(%cropparts,3,2);
	%part[2] = string::GetSubStr(%cropparts,6,2);

	echo(" BPCRAFTESSENCE " @ %part[0] @ " " @ %part[1] @ " " @ %part[2]);

	// CHECK FOR EMPTY SLOT

	%isvalid = False;
	for (%i = 0; %i <= 2; %i++) {
		%essmix = getWord($EssMix[%mix],%i);
		if (%essmix == %type) {
			%slot = %i;
			%isvalid = True;
		}
	}

	if (!%isvalid) {
		Client::SendMessage(%id,0,%mix @ " is an invalid type for " @ %type @ ".");
		ClearCraftTable(%id);
		return;
	}

	if (%part[%slot] != "00") {
		Client::SendMessage(%id,0,%type @ " slot " @ %slot @ " is not empty.");
		ClearCraftTable(%id);
		return;
	}

	%valid = floor(%qlbase * 0.8);

	if (%qlmix < %valid) {
		Client::SendMessage(%id,0,%mix @ " must be at least Quality Level " @ %valid @ ".");
		ClearCraftTable(%id);
		return;
	}

	%part[%slot] = $EssToSkillNum[%mix];

	%full = %qlbase @ %type @ "-" @ %part[0] @ "," @ %part[1] @ "," @ %part[2];

	echo(" BPCRAFTESSENCE--> " @ %full);

	BPAutoBuildEssence(%full,%type,%insert,%part[0],%part[1],%part[2],%qlbase,"-1",%id);

}

$EssReqNum[1] = "Stamina";
$EssReqNum[2] = "Strength";
$EssReqNum[3] = "Agility";
$EssReqNum[4] = "Sense";
$EssReqNum[5] = "Intelligence";
$EssReqNum[6] = "Psychic";

function BPAutoBuildEssence(%full,%type,%insert,%slot0,%slot1,%slot2,%ql,%new,%id)
{

	echo(" FULL " @ %full);

	if (%new != -1) {
		
		echo(" IS NEW  ");

		// BREAK DOWN PARTS (AUTO CREATE INIT)

		%find = string::FindSubStr(%new,"-");
		%type = string::GetSubStr(%new,3,(%find-3));
		%cropparts = string::GetSubStr(%new,(%find+1),999);
		%slot0 = string::GetSubStr(%cropparts,0,2);
		%slot1 = string::GetSubStr(%cropparts,3,2);
		%slot2 = string::GetSubStr(%cropparts,6,2);
		%full = %new;
		%ql = String::GetSubStr(%new,0,3);

	}

	echo(" TYPE " @ %type);

	if (string::ICompare(%type,"SoulStone") == 0) {
		echo(" SETTING TYPE SOUL STONE ");
		%name = "Soul Stone";
		%location = "soul";
		%iconame = "ico_soulstone";
	}

	if (string::ICompare(%type,"BodyStone") == 0) {
		echo(" SETTING TYPE BODY STONE ");
		%name = "Body Stone";
		%location = "body";
		%iconame = "ico_bodystone";
	}

	if (string::ICompare(%type,"MindStone") == 0) {
		echo(" SETTING TYPE MIND STONE ");
		%name = "Mind Stone";
		%location = "mind";
		%iconame = "ico_mindstone";
	}

	if (string::ICompare(%type,"SpiritStone") == 0) {
		echo(" SETTING TYPE SPIRIT STONE ");
		%name = "Spirit Stone";
		%location = "spirit";
		%iconame = "ico_spiritstone";
	}

	if (string::ICompare(%type,"GhostStone") == 0) {
		echo(" SETTING TYPE GHOST STONE ");
		%name = "Ghost Stone";
		%location = "ghost";
		%iconame = "ico_ghoststone";
	}
	
	%num = 0;
	
	%mods = "";
	for (%i = 0; %i <= 2; %i++) {
		%getslot = %slot[%i];
		echo(" GET SLOT " @ %getslot);
		if (%getslot != "00") {
			%num++;
			if (%i == 0) {
				%multi = floor(%ql * 1.3);
			}
			if (%i == 1) {
				%multi = floor(%ql * 0.9);
			}
			if (%i == 2) {
				%multi = floor(%ql * 0.6);
			}
			%mods = %mods @ $SkillNumToEss[%getslot] @ " " @ %multi @ " ";
		}
	}

	echo(" mods '" @ %mods @ "'");

	%reqs = "";
	%isreq[1] = 0; // stamina
	%isreq[2] = 0; // strength
	%isreq[3] = 0; // agility
	%isreq[4] = 0; // sense
	%isreq[5] = 0; // intelligence
	%isreq[6] = 0; // psychic

	for (%i = 0; %i <= 2; %i++) {
		%getslot = %slot[%i];
		if (%getslot != "00") {
			%numess = $SkillNumToEss[%getslot];
			%essreq = $EssReq[%numess];
			if (%essreq == "Stamina")
				%isreq[1]++;
			else if (%essreq == "Strength")
				%isreq[2]++;
			else if (%essreq == "Agility")
				%isreq[3]++;
			else if (%essreq == "Sense")
				%isreq[4]++;
			else if (%essreq == "Intelligence")
				%isreq[5]++;
			else if (%essreq == "Psychic")
				%isreq[6]++;
		}
	}

	%highreq = 0;
	%thereq = 1;
	for (%i = 6; %i >= 1; %i--) {
		if (%isreq[%i] >= %highreq) {
			%thereq = %i;
			%highreq = %isreq[%i];
		}
	}
	
	%req = "LOCATION " @ %location @ " ";

	%req = %req @ $EssReqNum[%thereq] @ " " @ floor(%ql * 3.5);

	%req = %req @ " Focus " @ floor(%ql * 5.5);

	echo(" req " @ %req);

	%show = "";
	
	%custom = "";

	if (%slot2 != "00") {
		%show = $SkillNumToEss[%slot2];
		%custom = %custom @ %show @ " ";
	}
	else
		%custom = "Empty ";
	if (%slot1 != "00") {
		%show = $SkillNumToEss[%slot1];
		%custom = %custom @ %show @ " ";
	}
	else
		%custom = %custom @ "Empty ";
	if (%slot0 != "00") {
		%show = $SkillNumToEss[%slot0];
		%custom = %custom @ %show @ " ";
	}
	else
		%custom = %custom @ "Empty ";

	//$BPItem[%full,$BPName] = %name @ " (" @ %show @ ") (" @ %num @ "/3)";
	$BPItem[%full,$BPName] = %name @ " (" @ %show @ ")";
	$BPItem[%full,$BPPrice] = (%ql * 1.0);
	$BPItem[%full,$BPWeight] = 1;
	$BPItem[%full,$BPWield] = %req;
	$BPItem[%full,$BPWieldBonus] = %mods;
	$BPItem[%full,$BPEssence] = %custom;
	$BPItem[%full,$BPIco] = %iconame @ ".bmp";

	//if (%new != -1) {

		AddToBackpack(%id,%full,1);

		ClearCraftTable(%id,1);
	//}
}


function BPCombine(%id,%base,%mix)
{
	focusServer();
	echo("BASE: " @ %base);
	echo("MIX: " @ %mix);
	
	%qlbase = string::GetSubStr(%base,0,3);
	%qlmix = string::getSubStr(%mix,0,3);

	%basecrop = string::getSubStr(%base,3,999);
	%mixcrop = string::getSubStr(%mix,3,999);
	
	echo(%qlbase @ " " @ %qlmix @ " " @ %basecrop @ " " @ %mixcrop);

	if (string::findSubStr(%basecrop,"SoulStone") == 0 || string::findSubStr(%basecrop,"SpiritStone") == 0 || string::findSubStr(%basecrop,"MindStone") == 0 || string::findSubStr(%basecrop,"BodyStone") == 0 || string::findSubStr(%basecrop,"GhostStone") == 0) {

		BPCraftEssence(%id,%basecrop,%qlbase,%mixcrop,%qlmix);

		return;
	}
		
	return;

	%found = 0;
	for (%i = 1; (%comb = $BPCombine[%base,$BPCombine,%i]) != ""; %i++) {
		if ($BPItem[%comb,$BPName] == $BPItem[%mix,$BPName]) {
			%found = 1;
			%req = $BPCombine[%base,$BPCombineReq,%i];
			%res = $BPCombine[%base,$BPCombineRes,%i];
			%bonus = $BPCombine[%base,$BPCombineBonus,%i];
		}
	}
	if (%found) {
		if (HasThisStuff(%id,%base @ " 1 " @ %mix @ " 1", 1) == False) {
			Client::SendMessage(%id,0,"You need 1 " @ $BPItem[%base,$BPName] @ " and 1 " @ $BPItem[%mix,$BPName] @ " to do this craft.");
			ClearCraftTable(%id);
			return;
		}
		if (CanBackpackWield(%id,1,1,%req)) {
			Client::SendMessage(%id,2,"Craft successful.");
			if (%bonus != "")
				GiveThisStuff(%id,%bonus,1,0);
			BackpackWieldBonus(%id,0,1,0,0,%res);
			if ($DeleteOnCombine[%base])
				RemoveFromBackpack(%id,%base,-1,0,0,0);
			if ($DeleteOnCombine[%mix])
				RemoveFromBackpack(%id,%mix,-1,0,0,0);
			ClearCraftTable(%id);
			return;
		}
		else {
			Client::SendMessage(%id,0,"You dont meet the requirements to combine these. Need: " @ CombineNeedFormat(%req));
			ClearCraftTable(%id);
			return;
		}
	}
	else {
		Client::SendMessage(%id,0,"No combination found. Maybe try using " @ $BPItem[%mix,$BPName] @ " as the base instead.");
		ClearCraftTable(%id);
		return;
	}
}

function AddToCraft(%id,%item) 
{
	if (%id.CraftBase == "") {
		%id.CraftBase = %item;
		Client::SendMessage(%id,0,"You added " @ GetBPData(%item,$BPName) @ " as your crafting base.");
	}
	else {
		if ((%a = %id.CraftAdditions) != "") {
			Client::SendMessage(%id,0,"You already have " @ GetBPData(%a,$BPName) @ " as your crafting addition.");
			return;
		}
		else { 
			%id.CraftAdditions = %item;
			Client::SendMessage(%id,0,"You added " @ GetBPData(%item,$BPName) @ " as your crafting addition.");
		}
	}
}

function BPCombine(%id,%base,%mix)
{
	focusServer();
	echo("BASE: " @ %base);
	echo("MIX: " @ %mix);
	
	%qlbase = string::GetSubStr(%base,0,3);
	%qlmix = string::getSubStr(%mix,0,3);

	%basecrop = string::getSubStr(%base,3,999);
	%mixcrop = string::getSubStr(%mix,3,999);
	
	echo(%qlbase @ " " @ %qlmix @ " " @ %basecrop @ " " @ %mixcrop);

	if (string::findSubStr(%basecrop,"SoulStone") == 0 || string::findSubStr(%basecrop,"SpiritStone") == 0 || string::findSubStr(%basecrop,"MindStone") == 0 || string::findSubStr(%basecrop,"BodyStone") == 0 || string::findSubStr(%basecrop,"GhostStone") == 0) {

		BPCraftEssence(%id,%basecrop,%qlbase,%mixcrop,%qlmix);

		return;
	}
		
	return;

	%found = 0;
	for (%i = 1; (%comb = $BPCombine[%base,$BPCombine,%i]) != ""; %i++) {
		if ($BPItem[%comb,$BPName] == $BPItem[%mix,$BPName]) {
			%found = 1;
			%req = $BPCombine[%base,$BPCombineReq,%i];
			%res = $BPCombine[%base,$BPCombineRes,%i];
			%bonus = $BPCombine[%base,$BPCombineBonus,%i];
		}
	}
	if (%found) {
		if (HasThisStuff(%id,%base @ " 1 " @ %mix @ " 1", 1) == False) {
			Client::SendMessage(%id,0,"You need 1 " @ $BPItem[%base,$BPName] @ " and 1 " @ $BPItem[%mix,$BPName] @ " to do this craft.");
			ClearCraftTable(%id);
			return;
		}
		if (CanBackpackWield(%id,1,1,%req)) {
			Client::SendMessage(%id,2,"Craft successful.");
			if (%bonus != "")
				GiveThisStuff(%id,%bonus,1,0);
			BackpackWieldBonus(%id,0,1,0,0,%res);
			if ($DeleteOnCombine[%base])
				RemoveFromBackpack(%id,%base,-1,0,0,0);
			if ($DeleteOnCombine[%mix])
				RemoveFromBackpack(%id,%mix,-1,0,0,0);
			ClearCraftTable(%id);
			return;
		}
		else {
			Client::SendMessage(%id,0,"You dont meet the requirements to combine these. Need: " @ CombineNeedFormat(%req));
			ClearCraftTable(%id);
			return;
		}
	}
	else {
		Client::SendMessage(%id,0,"No combination found. Maybe try using " @ $BPItem[%mix,$BPName] @ " as the base instead.");
		ClearCraftTable(%id);
		return;
	}
}





//###############################################################################################################################################

function TierItem::RandomWeapon(%item,%ql)
{
	%s = "";
	%n = $DynamicItem[%item,$DName];
	%h = $DynamicItem[%item,$DTierHard];
	%p = $DynamicItem[%item,$DTierProp];
	%numr = $TierRandom["Weapon"];
	if (%h != "")
		%s = %h;
	for (%i = 1; %i <= %p; %i++) {
		%r = floor(getRandom() * %numr + 1);
		if (%r < 10) %s = %s @ "0" @ %r;
		else %s = %s @ %r;
	}
	%perc = $DynamicItem[%item,$DTierPerc];
	%min = getWord(%perc,0);
	%max = getWord(%perc,1);
	%ranp = floor((getRandom() * ((%max - %min)+ 1)) + %min);
	echo(" RANP " @ %ranp);
	echo("=================================");
	%full = %ql @ %item @ "&" @ %s @ "%" @ %ranp;
	echo(%ql @ %item @ "&" @ %s @ "%" @ %ranp);
	echo("=================================");
	TierItem::CreateWeapon(%full);
	
	$PlayerBackpack[2049] = %full @ " 1 ";

	return %full;
	
}

function TierItem::CreateWeapon(%new)
{
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	%ql = floor(string::GetSubStr(%new,0,3) + 0);
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	%plen = (string::len(%tperc) + 1);
	%perc = %tperc / 100;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));

	echo(%name @ " " @ %cropparts @ " " @ %perc);

	// GRAB THE HARD VALUES
	%weaponperc = $DynamicItem[%name,$DWeaponPerc];
	%weapondamage = $DynamicItem[%name,$DWeaponDamage];
	%weapondamagef = $DynamicItem[%name,$DWeaponDamageF];
	%weaponprice = $DynamicItem[%name,$DWeaponPrice];
	%weaponreq = $DynamicItem[%name,$DWeaponReq];

	%s[1] = string::GetSubStr(%cropparts,0,2);
	%s[2] = string::GetSubStr(%cropparts,2,2);
	%s[3] = string::GetSubStr(%cropparts,4,2);
	%s[4] = string::GetSubStr(%cropparts,6,2);
	%s[5] = string::GetSubStr(%cropparts,8,2);
	%s[6] = string::GetSubStr(%cropparts,10,2);
	%s[7] = string::GetSubStr(%cropparts,12,2);
	%s[8] = string::GetSubStr(%cropparts,14,2);
	%s[9] = string::GetSubStr(%cropparts,16,2);
	%s[10] = string::GetSubStr(%cropparts,18,2);

	// CLEAR ALL VARS
	%numr = $TierRandom["Weapon"];
	for (%i = 1; %i <= 99; %i++) %val[%i] = 0;
	// STACK VARS
	for (%i = 1; %i <= 10; %i++) {
		if ((%check = %s[%i]) != "") {
			%x = (%s[%i] + 0);
			%val[%x]++;
		}
	}
	// MODIFIERS
	%list = "";
	%weight = round((150 * %weaponperc) * %perc);
	for (%i = 1; %i <= 99; %i++) {
		if (%val[%i] > 0) {
			%vi = %val[%i];
			%av = $WeaponVal[%i];
			%stat = getWord(%av,0);
			%weight = %weight + floor(floor(floor($TierWeight[%stat] * %perc) + 1) * (%ql/300));
			%weight = %weight + 1;
			%max = getWord(%av,1);
			%t = round(floor((%max * %vi) * %perc) * (%ql / 300));
			if (%t < 1) %t = 1;
			%list = %list @ %stat @ " " @ %t @ " ";
		}
	}

	// REQUIREMENTS
	%rlist = "";
	%rmax = 3360;
	%req = round(((%rmax * %weaponperc) * %perc) * (%ql / 300));
	%rlist = "LOCATION weapon " @ %weaponreq @ " " @ %req;
	
	// PRICE
	%price = round(((%weaponprice * %weaponperc) * %perc) * (%ql / 300));
	
	echo(" PRICE " @ %price);
	
	// DAMAGE
	%damage = %weapondamage * %weaponperc;
	%damage = %damage * %perc;
	%damage = %damage * (%ql / 300);
	%damagef = %damage * %weapondamagef;
	%damagemin = %damage - %damagef;
	%damagemax = %damage + %damagef;
	%damagemsg = round(%damagemin) @ " - " @ round(%damagemax);
	$BPItem[%new,$BPDamage] = %damagemsg;
	
	// MBS
	%mbs = ((5000 * %weaponperc) * %perc) * (%ql / 300);
	%mbsmsg = round(100 + %mbs);
	$BPItem[%new,$BPMBS] = %mbsmsg;

	// SET THE VARIABLES
	$BPItem[%new,$BPName] = $DynamicItem[%name,$DName];
	$BPItem[%new,$BPWeight] = %weight;
	$BPItem[%new,$BPPrice] = %price;
	$BPItem[%new,$BPWield] = %rlist;
	$BPItem[%new,$BPWieldBonus] = %list;
	$BPItem[%new,$BPDesc] = $DynamicItem[%name,$DDesc];
	$BPItem[%new,$BPItemType] = $DynamicItem[%name,$DItemType];
	$BPItem[%new,$BPTierPerc] = %tperc;
	if ($DynamicItem[%name,$DIco] != "")
		$BPItem[%new,$BPIco] = $DynamicItem[%name,$DIco];
	if ($DynamicItem[%name,$DSet] != "")
		$BPItem[%new,$BPSet] = $DynamicItem[%name,$DSet];
	$BPItem[%new,$BPVisType] = $BPVisItem;
	$BPItem[%new,$BPATKSkills] = $DynamicItem[%name,$DATKSkills];
	$BPItem[%new,$BPDEFSkills] = $DynamicItem[%name,$DDEFSkills];
	$BPItem[%new,$BPVis] = $DynamicItem[%name,$DVis];	
	$BPItem[%new,$BPVisSlot] = 0;
}



	if (string::findSubStr(%item,"SoulStone") != -1 || string::findSubStr(%item,"SpiritStone") != -1 || string::findSubStr(%item,"MindStone") != -1 || string::findSubStr(%item,"BodyStone") != -1 || string::findSubStr(%item,"GhostStone") != -1) {
		echo(" SETTING AUTO BUILD ESSENCE " @ %item);
		//schedule("BPAutoBuildEssence(0,0,0,0,0,0,0,\""@%item@"\",0);",0.01);
		// COMMENTED OUT DUE TO BUG IN TEXTURE PALETTE(?) DURING NON DED HOSTING
		// UNCOMMENT DURING ACTUAL HOSTING
		//BPAutoBuildEssence(0,0,0,0,0,0,0,%item,0);
		return;
	}






function BPInsertRuneReq(%t,%a,%s)
{
	echo("BPINSERTRUNE: T:" @ %t @ " A:" @ %a @ " S:" @ %s);
	if (%s == "") %s = "00.000.000.000.000.000.0";
	%new = "";
	for (%i = 0; %i <= 20; %i += 4) {
		%x = string::getSubStr(%s,%i,4);
		if ($RuneReqSL[%t] == %i) {
			if (%a > BPFixDecimals(%x)) {
				%new = %new @ BPFixDecimals(%a);
			}
			else %new = %new @ %x;
		}
		else %new = %new @ %x;
	}
	return %new;
}


	//==========================================================
	// INSERT PLUS
	%t = $TierReq[%runemod];
	%t = $ReqDisp[%t]; 
	%a = $TierReqP[%runemod];
	%plus = BPInsertRuneReq(%t,%a,%plus);
	Client::SendMessage(%id,0," INSERT>> " @ %t @ " " @ %a @ " " @ %plus);



function testRandomBig(%a)
{
	%lowest = 100;
	%highest = 0;
	for (%i = 1; %i <= %a; %i++) {
		%r = getRandom() * 100;
		echo(" R " @ %r);
		if (%r < %lowest)
			%lowest = %r;
		if (%r > %highest)
			%highest = %r;
	}
	echo(" LOWEST " @ %lowest @ " HIGHEST " @ %highest);
}


AddToCommonTier("SLASHING","34 23 12 46 12 23 12 34 12 12 0 0 0 12 0 0","DYN AMR EVA ","Slashing",4);
AddToCommonTier("PIERCING","23 23 12 23 34 34 23 23 12 12 0 0 0 12 0 0","DYN AMR EVA ","Piercing",4);
AddToCommonTier("BLUDGEONING","23 12 12 46 23 34 23 12 12 23 0 0 0 12 0 0","DYN AMR ","Bludgeoning",4);
AddToCommonTier("DODGING","12 12 12 12 23 46 46 34 12 12 0 0 0 12 0 0","DYN EVA ","Dodging",4);
AddToCommonTier("WEIGHTCAPACITY","12 23 23 23 12 46 34 12 12 23 0 0 0 12 0 0","DYN AMR EVA RES ","Capacity",4);
AddToCommonTier("BASHING","23 23 12 23 34 23 23 23 23 12 0 0 0 12 0 0","DYN AMR EVA ","Bashing",4);
AddToCommonTier("STEALING","12 23 23 23 34 23 12 34 23 0 0 0 0 23 0 0","DYN EVA ","Thievery",4);
AddToCommonTier("HIDING","12 23 12 12 34 46 23 34 0 12 0 0 0 23 0 0","DYN EVA ","Shadow",4);
AddToCommonTier("BACKSTABBING","12 12 12 23 23 23 12 46 12 12 0 0 0 23 0 0","DYN AMR EVA ","Sneaking",4);
AddToCommonTier("SPELLRESISTANCE","23 23 46 12 12 12 12 12 34 12 0 0 0 34 0 0","DYN ","Resistance",4);
AddToCommonTier("HEALING","23 23 23 34 12 23 12 12 23 23 0 0 0 23 0 0","DYN AMR EVA RES ","Healing",4);
AddToCommonTier("ARCHERY","23 12 23 23 46 23 12 34 12 12 0 0 0 12 0 0","DYN EVA ","Archery",4);
AddToCommonTier("ENDURANCE","23 23 12 46 12 23 23 12 12 23 0 0 0 23 0 0","DYN AMR ","Endurance",4);
AddToCommonTier("MARTIALARTS","23 12 12 34 34 34 46 23 0 0 0 0 0 23 0 0","DYN AMR EVA ","Balance",4);
AddToCommonTier("MINING","12 34 12 23 34 12 12 23 34 12 0 0 0 34 0 0","DYN AMR EVA RES ","Mining",4);
AddToCommonTier("SPEECH","23 23 23 12 12 12 12 12 34 12 0 0 0 58 0 0","DYN AMR EVA RES ","Speech",4);
AddToCommonTier("SENSEHEADING","23 23 46 12 12 12 12 23 46 12 0 0 0 23 0 0","DYN AMR EVA RES ","Heading",4);
AddToCommonTier("ENERGY","12 23 46 12 23 12 12 23 34 12 0 0 0 23 0 0","DYN RES ","Energy",4);
AddToCommonTier("HAGGLING","12 23 46 12 12 12 12 23 34 12 0 0 0 34 0 0","DYN AMR EVA RES ","Haggling",4);
AddToCommonTier("STRENGTH","34 23 12 46 12 12 23 12 12 23 0 0 0 12 0 0","DYN AMR EVA RES ","Strength",4);
AddToCommonTier("STAMINA","34 23 12 34 12 34 23 12 12 23 0 0 0 12 0 0","DYN AMR EVA RES ","Stamina",4);
AddToCommonTier("AGILITY","12 23 12 12 34 34 46 23 12 12 0 0 0 12 0 0","DYN AMR EVA RES ","Agility",4);
AddToCommonTier("INTELLIGENCE","12 34 34 12 12 12 12 23 34 12 0 0 0 34 0 0","DYN AMR EVA RES ","Intelligence",4);
AddToCommonTier("SENSE","12 34 23 12 34 34 12 34 12 12 0 0 0 12 0 0","DYN AMR EVA RES ","Sense",4);
AddToCommonTier("PSYCHIC","12 34 46 12 12 12 12 12 34 12 0 0 0 34 0 0","DYN AMR EVA RES ","Psychic",4);
AddToCommonTier("CASTINIT","12 23 34 23 34 12 12 12 34 12 0 0 0 23 0 0","DYN RES ","Initation",4);
AddToCommonTier("LITERACY","12 34 23 12 12 12 12 12 34 12 0 0 0 58 0 0","DYN AMR EVA RES ","Reading",4);
AddToCommonTier("SMITHING","23 12 12 23 34 12 12 12 12 12 0 0 0 69 0 0","DYN AMR EVA RES ","Smithing",4);
AddToCommonTier("MAGICCRAFT","12 23 34 12 12 12 12 12 23 12 0 0 0 69 0 0","DYN AMR EVA RES ","Crafting",4);
AddToCommonTier("ALCHEMY","12 23 23 12 12 12 12 12 34 12 0 0 0 69 0 0","DYN AMR EVA RES ","Mixing",4);
AddToCommonTier("SPELLCAPACITY","23 23 23 12 12 23 12 23 23 12 12 0 0 34 0 0","DYN RES ","Memory",4);
AddToCommonTier("WEAPONHANDLING","12 12 12 23 46 34 23 23 12 12 0 0 0 23 0 0","DYN AMR EVA ","Handling",4);
AddToCommonTier("EVADEMELEE","12 23 12 12 23 46 46 23 12 12 0 0 0 12 0 0","DYN EVA ","Evading",4);
AddToCommonTier("AIMING","23 12 23 23 46 23 12 34 12 12 0 0 0 12 0 0","DYN AMR EVA ","Sniping",4);
AddToCommonTier("BRAWLING","23 23 12 34 23 23 23 23 12 23 0 0 0 12 0 0","DYN AMR EVA ","Brawling",4);
AddToCommonTier("CLEAVE","34 23 12 34 23 23 12 23 12 23 0 0 0 12 0 0","DYN AMR ","Cleaving",4);
AddToCommonTier("PRIMALMAGIC","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Instinct",4);
AddToCommonTier("HOLYMAGIC","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Divinity",4);
AddToCommonTier("EMPOWERMENT","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Empowerment",4);
AddToCommonTier("DARKMAGIC","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Darkness",4);
AddToCommonTier("LIGHTMAGIC","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Light",4);
AddToCommonTier("RITUAL","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Rituals",4);
AddToCommonTier("SORCERY","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Sorcery",4);
AddToCommonTier("PROTECTION","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Protection",4);
AddToCommonTier("ENCHANTMENT","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Enchanting",4);
AddToCommonTier("WISDOM","23 23 23 12 12 23 12 23 23 12 12 0 0 34 0 0","DYN RES ","Wisdom",4);



function CreateTierWeapon_UNUSED(%type,%tname,%name,%perc,%prop,%integ,%damagef,%price,%req,%damage,%damagetype,%atk,%def,%vis,%ico,%desc)
{
	// echo(" CREATE TIER WEAPON " @ %type @ " " @ %tname @ " " @ %name @ " " @ %perc @ " " @ %damagef @ " " @ %price @ " " @ %req @ " " @ %damage @ " " @ %damagetype @ " " @ %atk @ " " @ %def @ " " @ %vis @ " " @ %ico @ " " @ %desc);
	echo(" CREATE TIER WEAPON " @ %type @ " " @ %tname @ " " @ %name);
	
	$DynamicItem[%tname,$DWeaponPerc] = %perc;
	$DynamicItem[%tname,$DWeaponDamage] = %damage;
	$DynamicItem[%tname,$DWeaponDamageF] = %damagef;
	$DynamicItem[%tname,$DWeaponPrice] = %price;
	$DynamicItem[%tname,$DWeaponReq] = %req;

	%prophigh = getWord(%integ,1);
	%prophigh = %prophigh / 100;
	// CREATE PRICE
	%price = round((%price * %perc) / 300);
	%price = %price @ " " @ %price;
	// CREATE REQ
	%reqperc = 3360 * %perc;
	%reqmin = round(%reqperc / 300);
	%reqadd = %reqperc / 300;
	// CREATE DAMAGE
	%damage = %damage * %perc;
	%damagef = %damage * %damagef;
	%damagemin = %damage - %damagef;
	%damagemax = %damage + %damagef;
	%dminadd = %damagemin / 300;
	%dmaxadd = %damagemax / 300;
	%dmin = %dminadd;
	%dmax = %dmaxadd;
	if (%dmin < 1) %dmin = 1;
	if (%dmax < 5) %dmax = 5;
	%damagemsg = %dmin @ " " @ %dminadd @ " " @ %dmax @ " " @ %dmaxadd;
	// echo(" DAMAGE MSG " @ %damagemsg);
	// CREATE MBS
	%mbs = (5000 * %perc);
	%mbs = %mbs / 300;
	%mbsmsg = round(100 + %mbs) @ " " @ %mbs;
	$DynamicItem[%tname,$DName] = %name;
	$DynamicItem[%tname,$DMinMax] = "1 300";
	$DynamicItem[%tname,$DWeight] = "1 0";
	$DynamicItem[%tname,$DPrice] = %price;
	$DynamicItem[%tname,$DWield] = "LOCATION weapon NA " @ %req @ " " @ %reqmin @ " " @ %reqadd;
	$DynamicItem[%tname,$DDamage] = %damagemsg;
	$DynamicItem[%tname,$DDamageType] = %damagetype;
	$DynamicItem[%tname,$DDesc] = %desc;
	$DynamicItem[%tname,$DVisType] = $BPVisItem;
	$DynamicItem[%tname,$DATKSkills] = %atk;
	$DynamicItem[%tname,$DDEFSkills] = %def;
	$DynamicItem[%tname,$DMBS] = %mbsmsg;
	$DynamicItem[%tname,$DVis] = %vis;
	$DynamicItem[%tname,$DVisSlot] = 0;
	$DynamicItem[%tname,$DWieldBonus] = "";
	$DynamicItem[%tname,$DItemType] = %type;
	$DynamicItem[%tname,$DIco] = %ico;
	$DynamicItem[%tname,$DTier] = 1;
	$DynamicItem[%tname,$DTierProp] = %prop;
	$DynamicItem[%tname,$DTierPerc] = %integ;
	$DynamicItem[%tname,$DTierHard] = "";
}

//===================================================================================================================================================================================================================

// 1H SLASHING
// TIER 1: RUSTY
CreateTierWeapon("1 Hatchet","RustyHatchet","Rusty Hatchet",0.3,1,"1 100",0.3,2000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Hatchet","ico_b_hatchet.bmp","A basic hatchet");
CreateTierWeapon("1 Broad Sword","RustyBroadSword","Rusty Broad Sword",0.4,1,"30 70",0.3,2000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BroadSword","ico_b_broadsword.bmp","A basic broad sword");
CreateTierWeapon("1 War Axe","RustyWarAxe","Rusty War Axe",0.5,1,"30 70",0.3,2000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","WarAxe","ico_b_waraxe.bmp","A basic war axe");
CreateTierWeapon("1 Long Sword","RustyLongSword","Rusty Long Sword",0.6,1,"30 70",0.3,2000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","LongSword","ico_b_longsword.bmp","A basic long sword");
CreateTierWeapon("1 Battle Axe","RustyBattleAxe","Rusty Battle Axe",0.7,1,"30 70",0.3,2000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BattleAxe","ico_b_battleaxe.bmp","A basic battle axe");
CreateTierWeapon("1 Bastard Sword","RustyBastardSword","Rusty Bastard Sword",0.8,1,"30 70",0.3,2000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BastardSword","ico_b_bastardsword.bmp","A basic bastard sword");
CreateTierWeapon("1 Halberd","RustyHalberd","Rusty Halberd",0.9,1,"30 70",0.3,2000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Halberd","ico_b_halberd.bmp","A basic halberd");
CreateTierWeapon("1 Claymore","RustyClaymore","Rusty Claymore",1.0,1,"30 70",0.3,2000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Claymore","ico_b_claymore.bmp","A basic claymore");
// TIER 2: DULL
CreateTierWeapon("2 Hatchet","DullHatchet","Dull Hatchet",0.3,2,"1 100",0.3,4000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Hatchet","ico_i_hatchet.bmp","An improved hatchet");
CreateTierWeapon("2 Broad Sword","DullBroadSword","Dull Broad Sword",0.4,2,"40 80",0.3,4000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BroadSword","ico_i_broadsword.bmp","An improved broad sword");
CreateTierWeapon("2 War Axe","DullWarAxe","Dull War Axe",0.5,2,"40 80",0.3,4000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","WarAxe","ico_i_waraxe.bmp","An improved war axe");
CreateTierWeapon("2 Long Sword","DullLongSword","Dull Long Sword",0.6,2,"40 80",0.3,4000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","LongSword","ico_i_longsword.bmp","An improved long sword");
CreateTierWeapon("2 Battle Axe","DullBattleAxe","Dull Battle Axe",0.7,2,"40 80",0.3,4000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BattleAxe","ico_i_battleaxe.bmp","An improved battle axe");
CreateTierWeapon("2 Bastard Sword","DullBastardSword","Dull Bastard Sword",0.8,2,"40 80",0.3,4000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BastardSword","ico_i_bastardsword.bmp","An improved bastard sword");
CreateTierWeapon("2 Halberd","DullHalberd","Dull Halberd",0.9,2,"40 80",0.3,4000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Halberd","ico_i_halberd.bmp","An improved halberd");
CreateTierWeapon("2 Claymore","DullClaymore","Dull Claymore",1.0,2,"40 80",0.3,4000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Claymore","ico_i_claymore.bmp","An improved claymore");
// TIER 3: JAGGED
CreateTierWeapon("3 Hatchet","JaggedHatchet","Jagged Hatchet",0.3,3,"1 100",0.3,8000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Hatchet","ico_f_hatchet.bmp","A fine hatchet");
CreateTierWeapon("3 Broad Sword","JaggedBroadSword","Jagged Broad Sword",0.4,3,"50 90",0.3,8000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BroadSword","ico_f_broadsword.bmp","A fine broad sword");
CreateTierWeapon("3 War Axe","JaggedWarAxe","Jagged War Axe",0.5,3,"50 90",0.3,8000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","WarAxe","ico_f_waraxe.bmp","A fine war axe");
CreateTierWeapon("3 Long Sword","JaggedLongSword","Jagged Long Sword",0.6,3,"50 90",0.3,8000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","LongSword","ico_f_longsword.bmp","A fine long sword");
CreateTierWeapon("3 Battle Axe","JaggedBattleAxe","Jagged Battle Axe",0.7,3,"50 90",0.3,8000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BattleAxe","ico_f_battleaxe.bmp","A fine battle axe");
CreateTierWeapon("3 Bastard Sword","JaggedBastardSword","Jagged Bastard Sword",0.8,3,"50 90",0.3,8000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BastardSword","ico_f_bastardsword.bmp","A fine bastard sword");
CreateTierWeapon("3 Halberd","JaggedHalberd","Jagged Halberd",0.9,3,"50 90",0.3,8000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Halberd","ico_f_halberd.bmp","A fine halberd");
CreateTierWeapon("3 Claymore","JaggedClaymore","Jagged Claymore",1.0,3,"50 90",0.3,8000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Claymore","ico_f_claymore.bmp","A fine claymore");
// TIER 4: SHARP
CreateTierWeapon("4 Hatchet","SharpHatchet","Sharp Hatchet",0.3,4,"1 100",0.3,16000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Hatchet","ico_m_hatchet.bmp","A magic hatchet");
CreateTierWeapon("4 Broad Sword","SharpBroadSword","Sharp Broad Sword",0.4,4,"60 100",0.3,16000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BroadSword","ico_m_broadsword.bmp","A magic broad sword");
CreateTierWeapon("4 War Axe","SharpWarAxe","Sharp War Axe",0.5,4,"60 100",0.3,16000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","WarAxe","ico_m_waraxe.bmp","A magic war axe");
CreateTierWeapon("4 Long Sword","SharpLongSword","Sharp Long Sword",0.6,4,"60 100",0.3,16000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","LongSword","ico_m_longsword.bmp","A magic long sword");
CreateTierWeapon("4 Battle Axe","SharpBattleAxe","Sharp Battle Axe",0.7,4,"60 100",0.3,16000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BattleAxe","ico_m_battleaxe.bmp","A magic battle axe");
CreateTierWeapon("4 Bastard Sword","SharpBastardSword","Sharp Bastard Sword",0.8,4,"60 100",0.3,16000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BastardSword","ico_m_bastardsword.bmp","A magic bastard sword");
CreateTierWeapon("4 Halberd","SharpHalberd","Sharp Halberd",0.9,4,"60 100",0.3,16000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Halberd","ico_m_halberd.bmp","A magic halberd");
CreateTierWeapon("4 Claymore","SharpClaymore","Sharp Claymore",1.0,4,"60 100",0.3,16000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Claymore","ico_m_claymore.bmp","A magic claymore");
// TIER 5: KEEN
CreateTierWeapon("5 Hatchet","KeenHatchet","Keen Hatchet",0.3,5,"1 110",0.3,32000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Hatchet","ico_r_hatchet.bmp","An rare hatchet");
CreateTierWeapon("5 Broad Sword","KeenBroadSword","Keen Broad Sword",0.4,5,"70 110",0.3,32000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BroadSword","ico_r_broadsword.bmp","A rare broad sword");
CreateTierWeapon("5 War Axe","KeenWarAxe","Keen War Axe",0.5,5,"70 110",0.3,32000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","WarAxe","ico_r_waraxe.bmp","A rare war axe");
CreateTierWeapon("5 Long Sword","KeenLongSword","Keen Long Sword",0.6,5,"70 110",0.3,32000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","LongSword","ico_r_longsword.bmp","A rare long sword");
CreateTierWeapon("5 Battle Axe","KeenBattleAxe","Keen Battle Axe",0.7,5,"70 110",0.3,32000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BattleAxe","ico_r_battleaxe.bmp","A rare battle axe");
CreateTierWeapon("5 Bastard Sword","KeenBastardSword","Keen Bastard Sword",0.8,5,"70 110",0.3,32000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BastardSword","ico_r_bastardsword.bmp","A rare bastard sword");
CreateTierWeapon("5 Halberd","KeenHalberd","Keen Halberd",0.9,5,"70 110",0.3,32000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Halberd","ico_r_halberd.bmp","A rare halberd");
CreateTierWeapon("5 Claymore","KeenClaymore","Keen Claymore",1.0,5,"70 110",0.3,32000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Claymore","ico_r_claymore.bmp","A rare claymore");
// TIER 6: HONED
CreateTierWeapon("6 Hatchet","HonedHatchet","Honed Hatchet",0.3,6,"1 130",0.3,64000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Hatchet","ico_l_hatchet.bmp","A legendary hatchet");
CreateTierWeapon("6 Broad Sword","HonedBroadSword","Honed Broad Sword",0.4,6,"80 130",0.3,64000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BroadSword","ico_l_broadsword.bmp","A legendary broad sword");
CreateTierWeapon("6 War Axe","HonedWarAxe","Honed War Axe",0.5,6,"80 130",0.3,64000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","WarAxe","ico_l_waraxe.bmp","A legendary war axe");
CreateTierWeapon("6 Long Sword","HonedLongSword","Honed Long Sword",0.6,6,"80 130",0.3,64000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","LongSword","ico_l_longsword.bmp","A legendary long sword");
CreateTierWeapon("6 Battle Axe","HonedBattleAxe","Honed Battle Axe",0.7,6,"80 130",0.3,64000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BattleAxe","ico_l_battleaxe.bmp","A legendary battle axe");
CreateTierWeapon("6 Bastard Sword","HonedBastardSword","Honed Bastard Sword",0.8,6,"80 130",0.3,64000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","BastardSword","ico_l_bastardsword.bmp","A legendary bastard sword");
CreateTierWeapon("6 Halberd","HonedHalberd","Honed Halberd",0.9,6,"80 130",0.3,64000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Halberd","ico_l_halberd.bmp","A legendary halberd");
CreateTierWeapon("6 Claymore","HonedClaymore","Honed Claymore",1.0,6,"80 130",0.3,64000,"Slashing",4500,"MeleeAC","Slashing 100","EvadeMelee 100","Claymore","ico_l_claymore.bmp","A legendary claymore");

//===================================================================================================================================================================================================================


$DynamicItem[TestWeapon,$DName] = "Test Weapon";
$DynamicItem[TestWeapon,$DMinMax] = "1 300";
$DynamicItem[TestWeapon,$DWeight] = "1 0";
$DynamicItem[TestWeapon,$DPrice] = "1 1";
$DynamicItem[TestWeapon,$DWield] = "LOCATION weapon NA Bludgeoning 0 0";
$DynamicItem[TestWeapon,$DDamage] = "3 1 6 1";
$DynamicItem[TestWeapon,$DDesc] = "The ultimate Test Weapon";
$DynamicItem[TestWeapon,$DATKSkills] = "Slashing 500";
$DynamicItem[TestWeapon,$DDEFSkills] = "Dodging 100";
$DynamicItem[TestWeapon,$DVisType] = $BPVisItem;
$DynamicItem[TestWeapon,$DVis] = "Claymore2";
$DynamicItem[TestWeapon,$DVisSlot] = 0;

		if ($BPItem[%item,$BPWeaponCritChance] != "") {
			%msg = %msg @ " <f1>Critcal Hit Chance: <f0>" @ BPFixDecimals($BPItem[%item,$BPWeaponCritChance]) @ "%\n";
		}
		if ($BPItem[%item,$BPWeaponCritDamage] != "") {
			%msg = %msg @ " <f1>Critcal Damage: <f0>" @ BPFixDecimals($BPItem[%item,$BPWeaponCritDamage]) @ "%<f1>\n\n";
		}


		// REMOVED *****************************************************
		//if (%vistype == $BPVisSkin) {
		//	%vis = $BPItem[%item,$BPVis];
		//	if (%vis != "") {
		//		if (%v) 
		//			Client::SetSkin(%id,%vis);
		//		else {
		//			// DO NOTHING
		//		}
		//	}
		//}


function GetNewDamageRoll(%id,%weapon)
{
	%roll = 0;
	%minroll = 0;
	%min = 0;
	%max = 0;
	%atk = GetTempATK(%id);

	%mbs = $BPItem[%weapon,$BPMBS];
	if (%mbs == "")
		%mbs = 2750;

	// %atk = 3000;

	if (%atk > %mbs)
		%atk = %mbs;

	echo(" ATK " @ %atk);

	%damage = $BPItem[%weapon,$BPDamage];
	if (%damage != "") {
		%min = getWord(%damage,0);
		%max = getWord(%damage,2);
		%minroll = floor(%min * (%atk / $AttackDamageMultiply));
		%max += floor(%max * (%atk / $AttackDamageMultiply));
		%min += floor(%min * (%atk / $AttackDamageMultiply));
		%roll = floor(getRandom() * (%max - %min) + %min);
	}
	%roll += GetBonus(%id,$BPAddDamage);
	%minroll += GetBonus(%id,$BPAddDamage);
	if (%minroll == 0)
		%minroll = 1;
	// echo(" ROLL MINROLL >>> " @ %roll @ " " @ %minroll);
	return %roll @ " " @ %minroll;
}



function Targeting::Hud(%id,%kill)
{
	%cur = $TargetCur[%id];
	%hp = fetchData(%cur,"HP");
	%mhp = fetchdata(%cur,"MaxHP");
	%hb = floor((%hp / %mhp) * 100);
	%name = client::GetName(%cur);
	%ftarg = Client::getName($TargetCur[%cur]);
	if (%ftarg == "")
		%ftarg = False;
	remoteEval(%id,"RPGGui::EnableTarget");
	if (%kill == True)
		remoteEval(%id,"UpdateEnemyTarget",0,%name,%ftarg);
	else
		remoteEval(%id,"UpdateEnemyTarget",%hb,%name,%ftarg);
	remoteeval(%id,"RPGGui::OppFightingNames","<f0><jc>"@%name,"<f1><jc>["@%ftarg@"]");
}

//Archery (ALL 2H) 100% 5000 (Wood)
//Short Bow 30
//Light Crossbow 40
//Long Bow 50
//Composite Bow 60
//Repeating Crossbow 70
//Heavy Crossbow (Elven Bow removed) 80
//Wing Bow 90
//Arbalest (Heavy Crossbow replaced) 100

function Target::LookAt(%id)
{
	// DO NOT USE THIS FUNCTION, CURRENT DOES NOT WORK PROPERLY
	focusserver();
	%target = $TargetCur[%id];
	%clpos = GameBase::getPosition(%id);
	%gupos = GameBase::getPosition(%target);
	%v1 = Vector::sub(%clpos, %gupos);
	%norm = Vector::normalize(%v1);
	%rot = Vector::getRotation(%norm);
	GameBase::setRotation(client::getOwnedObject(%id),%rot);
}


function remoteToggleAttack(%id)
{
	Targeting::ToggleAttack(%id);
}


function Targeting::ToggleAttack(%id)
{
	// UNUSED FUNCTION
	%cur = $TargetCur[%id];
	if (%cur == "") {
		Client::SendMessage(%id,0,"You have no current target.");
		%id.Attack = 0;
		player::trigger(%id,0);
	}
	if (%id.Attack == 0) {
		player::Trigger(%id,0);
		Client::SendMessage(%id,0,"You attack " @ Client::GetName(%cur) @ "!");
		%id.Attack = 1;
	}
	else {
		%id.Attack = 0;
		Client::SendMessage(%id,0,"You are No longer attacking " @ Client::GetName(%cur) @ ".");
		player::Trigger(%id,0);
	}
}

function ManualAddDamagedList(%shooterClient,%damagedClient,%backupValue)
{		
	%newmaxdamage = 32;
	if ((%dteam = PlayerIsInTeam(%shooterClient)) != -1)
		%sname = %dteam;
	else
		%sname = Client::GetName(%shooterClient);
	%dname = Client::getName(%damagedClient);
	%damagefound = -1;
	%emptyfound = -1;
	for (%i = 1; %i <= %newmaxdamage; %i++) {
		%name = getWord($damagedBy[%dname,%i],0);
		if (%name == %sname)
			%damagefound = %i;
		if (%name == -1) {
			if (%emptyfound == -1)
				%emptyfound = %i;
		}
	}
	if (%damagefound != -1) {
		%dval = getWord($damagedBy[%dname,%damagefound],1);
		$damagedBy[%dname,%damagefound] = %sname @ " " @ (%dval + %backupValue);
	}
	else if (%damagefound == -1 && %emptyfound != -1) {
		$damagedBy[%dname,%emptyfound] = %sname @ " " @ %backupValue;
	}
	else {
		echo("Manual: No more room on the damage list.");
	}
}


//###################################################################################################################################

function CalcExpGainPercent(%slvl,%srl,%dlvl,%drl) 
{
	%lvlp = 0;
	%rlp = 0;
	if (%drl == 0)
		%drl = 1;
	%optlvl = %slvl + (%slvl * 0.75);
	echo("OPT LEVEL " @ %optlvl);
	%optrl = %srl + (%srl * 0.66);
	echo("OPT RL " @ %optrl);
	%lvlp = (%dlvl / %optlvl) * 100;
	if (%lvlp > 100)
		%lvlp = 100;
	%rlp = %drl / %optrl;
	if (%rlp > 1)
		%rlp = 1;
	return (%lvlp * %rlp) / 100;
}

function DistributeExpForKilling(%damagedClient)
{
	%dname = Client::getName(%damagedClient);
	%dlvl = fetchData(%damagedClient,"LVL");
	%drl = fetchData(%damagedClient,"RemortStep");
	%totalhit = 0;
	for (%i = 1; %i <= 32; %i++) {
		if ($damagedBy[%dname,%i] != "") {
			%totalhit += getWord($damagedBy[%dname,%i],1);
		}
	}
	for (%i = 1; %i <= 32; %i++) {
		if ((%sname = getWord($damagedBy[%dname,%i],0)) != -1) {
			%sval = getWord($damagedBy[%dname,%i],1);
			if (String::GetSubStr(%sname,0,4) == "TEAM") {
				%tlist = $TeamList[%sname];
				%dperc = (%sval / %totalhit);
				for (%i = 0; (%tid = getWord(%tlist,%i)) != -1; %i++) {
					if (PlayerIsInTeam(%tid) == %sname) {
						%lvl = fetchData(%tid,"LVL");
						%rl = fetchData(%tid,"RemortStep");
						%perc = CalcExpGainPercent(%lvl,%rl,%dlvl,%drl);
						%exp = GetMaxExpRl(%lvl,%rl);
						%exp = floor(%exp * %perc);
						%exp = floor(%exp * %dperc);
						%finalbonus = 0;
						%finalrank = 0;
						%expbonus = $PlayerBonus[%tid,$ExpBonus];
						if (fetchData(%tid, "MyHouse") != "") {
							%rank = fetchData(%tid,"RankPoints");
							%finalrank = floor(%exp * (%rank / 1000));
						}
						if (%expbonus > 0 && %expbonus != "")
							%finalbonus = floor(%exp * (%expbonus / 100));
						DistributeGiveExpGain(%tid,%exp,%finalrank,%finalbonus,%dname);
						if (%dperc >= 0.5) {
							%GiveKillInc[%tid] = 1;
						}
					}
				}
			}
			else {
				if ((%tid = GetClientByName(%sname)) != 0) {
					%dperc = (%sval / %totalhit);
					%lvl = fetchData(%tid,"LVL");
					%rl = fetchData(%tid,"RemortStep");
					%perc = CalcExpGainPercent(%lvl,%rl,%dlvl,%drl);
					%exp = GetMaxExpRl(%lvl,%rl);
					%exp = floor(%exp * %perc);
					%exp = floor(%exp * %dperc);
					if (%lvl >= %dlvl) {
						%diff = %lvl - %dlvl;
						if (%diff >= 10)
							%exp = 1;
						else 
							%exp = floor(%exp - (%exp * (%diff / 10)));
					}
					%finalbonus = 0;
					%finalrank = 0;
					%expbonus = $PlayerBonus[%tid,$ExpBonus];
					if (fetchData(%tid, "MyHouse") != "") {
						%rank = fetchData(%tid,"RankPoints");
						%finalrank = floor(%exp * (%rank / 1000));
					}
					if (%expbonus > 0 && %expbonus != "")
						%finalbonus = floor(%exp * (%expbonus / 100));
						DistributeGiveExpGain(%tid,%exp,%finalrank,%finalbonus,%dname);
					if (%dperc >= 0.5) {
						%GiveKillInc[%tid] = 1;
					}
				}
			}
		}
	}
	if ((%quest = $QuestInc[%damagedClient,KILL]) != "") {
		for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
			if (%GiveKillInc[%cl] == 1) {
				IncCruQuest(%cl,%quest);
			}
		}
		$QuestInc[%damagedClient,KILL] = "";
	}
	//clear $damagedBy
	for(%i = 1; %i <= 32; %i++)
		$damagedBy[%dname,%i] = "";
}

function DistributeGiveExpGain(%id,%exp,%rank,%bonus,%dname)
{
	%final = %exp + %rank;
	if (%final > 0)
		Client::sendMessage(%id,0,%dname @ " has died and you gained " @ %final @ " experience!");
	else if (%final < 0)
		Client::sendMessage(%id,0,%dname @ " has died and you lost " @ -%final @ " experience.");
	else if (%final == 0)
		Client::sendMessage(%id,0,%dname @ " has died.");
	if (%bonus != 0)
		Client::sendMessage(%id,2,"You gained " @ %bonus @ " experience as a side bonus.");
	storeData(%id,"EXP",(%final + %bonus),"inc");
	Game::refreshClientScore(%id);
}

//###################################################################################################################################




function TestLoot(%id)
{
	for (%i = 1; %i <= 40; %i++) {
		%t = floor(getRandom() * 6 + 1);
		%type = floor(getRandom() * 9 + 1);
		%select = floor(getRandom() * 3 + 1);
		%ql = AddZeros(floor(getRandom() * 300 + 1));
		%loot = $LootTable[%type,%t,%select];
		%f = TierItem::RandomItem(%loot,%ql);
		AddToBackpack(%id,%f,1);
	}
}

function TestRandomLoot()
{
	%set = floor(getRandom() * 2 + 1);
	if (%set == 1) {
		%get = floor(getRandom() * 572 + 1);
		%loot = $SetLootTable[%get];
		%ql = AddZeros(floor(getRandom() * 300 + 1));
		%f = TierItem::RandomItem(%loot,%ql);
		return %f;
	}

	%t = floor(getRandom() * 6 + 1);
	%type = floor(getRandom() * 9 + 1);
	%select = floor(getRandom() * 3 + 1);
	%ql = AddZeros(floor(getRandom() * 300 + 1));
	%loot = $LootTable[%type,%t,%select];
	%f = TierItem::RandomItem(%loot,%ql);
	return %f;
}

function AddZeros(%quality)
{
	%q = %quality;
	if (%q < 100)
		%q = "0" @ %quality;
	if (%q < 10)
		%q = "00" @ %quality;
	return %q;
}

function RandomTierLoot(%id,%mf)
{
	echo(" START LOOT ");
	if (%mf == "") %mf = 1.0;
	%found = 0;
	%loot = "";

	%r = floor(getRandom() * floor(5 / %mf) + 1);
	if (%r == 1) %found++;
	%r = floor(getRandom() * floor(10 / %mf) + 1);
	if (%r == 1) %found++;
	%r = floor(getRandom() * floor(20 / %mf) + 1);
	if (%r == 1) %found++;
	%r = floor(getRandom() * floor(40 / %mf) + 1);
	if (%r == 1) %found++;
	%r = floor(getRandom() * floor(80 / %mf) + 1);
	if (%r == 1) %found++;
	%r = floor(getRandom() * floor(160 / %mf) + 1);
	if (%r == 1) %found++;
	%r = floor(getRandom() * floor(320 / %mf) + 1);
	if (%r == 1) %found++;

	if (%found > 0) {
		echo(" FOUND ITEMS " @ %found);
		for (%i = 1; %i <= %found; %i++) {

			%t = 0;
			%set = 0;

			// ROLL THE ITEM
			%ran = floor(getRandom() * floor(100 / %mf) + 1);
			if (%ran == 1) %t = 1;

			%ran = floor(getRandom() * floor(200 / %mf) + 1);
			if (%ran == 1) %t = 2;

			%ran = floor(getRandom() * floor(400 / %mf) + 1);
			if (%ran == 1) %t = 3;

			%ran = floor(getRandom() * floor(800 / %mf) + 1);
			if (%ran == 1) %t = 4;
			
			%ran = floor(getRandom() * floor(1000 / %mf) + 1);
			if (%ran == 1) { %t = 2; %set = 1; }

			%ran = floor(getRandom() * floor(1600 / %mf) + 1);
			if (%ran == 1) %t = 5;

			%ran = floor(getRandom() * floor(2000 / %mf) + 1);
			if (%ran == 1) { %t = 3; %set = 1; }

			%ran = floor(getRandom() * floor(3200 / %mf) + 1);
			if (%ran == 1) %t = 6;
			
			%ran = floor(getRandom() * floor(4000 / %mf) + 1);
			if (%ran == 1) { %t = 4; %set = 1; }

			%ran = floor(getRandom() * floor(8000 / %mf) + 1);
			if (%ran == 1) { %t = 5; %set = 1; }

			%ran = floor(getRandom() * floor(16000 / %mf) + 1);
			if (%ran == 1) { %t = 6; %set = 1; }
			
			echo(" T " @ %t);
			echo(" SET " @ %set);

			if (%t > 0) {
				%type = floor(getRandom() * 9 + 1);
				%select = floor(getRandom() * 3 + 1);
				echo(" TYPE " @ %type @ " SELECT " @ %select);
				%loot = %loot @ $LootTable[%type,%t,%select] @ " ";
			}
		}
	}
	echo(" LOOT: " @ %loot);
	echo(" END LOOT ");
}

// 1: AMULET
$LootTable[1,1,1] = "StoneAmulet";
$LootTable[1,1,2] = "QuartzAmulet";
$LootTable[1,1,3] = "GraniteAmulet";
$LootTable[1,2,1] = "OpalAmulet";
$LootTable[1,2,2] = "JadeAmulet";
$LootTable[1,2,3] = "TurquoiseAmulet";
$LootTable[1,3,1] = "RubyAmulet";
$LootTable[1,3,2] = "TopazAmulet";
$LootTable[1,3,3] = "SapphireAmulet";
$LootTable[1,4,1] = "ObsidianAmulet";
$LootTable[1,4,2] = "BloodStoneAmulet";
$LootTable[1,4,3] = "GarnetAmulet";
$LootTable[1,5,1] = "SilverAmulet";
$LootTable[1,5,2] = "GoldAmulet";
$LootTable[1,5,3] = "EmeraldAmulet";
$LootTable[1,6,1] = "DiamondAmulet";
$LootTable[1,6,2] = "KeldriniteAmulet";
$LootTable[1,6,3] = "BrimstoneAmulet";

// 2: RING
$LootTable[2,1,1] = "StoneRing";
$LootTable[2,1,2] = "QuartzRing";
$LootTable[2,1,3] = "GraniteRing";
$LootTable[2,2,1] = "OpalRing";
$LootTable[2,2,2] = "JadeRing";
$LootTable[2,2,3] = "TurquoiseRing";
$LootTable[2,3,1] = "RubyRing";
$LootTable[2,3,2] = "TopazRing";
$LootTable[2,3,3] = "SapphireRing";
$LootTable[2,4,1] = "ObsidianRing";
$LootTable[2,4,2] = "BloodStoneRing";
$LootTable[2,4,3] = "GarnetRing";
$LootTable[2,5,1] = "SilverRing";
$LootTable[2,5,2] = "GoldRing";
$LootTable[2,5,3] = "EmeraldRing";
$LootTable[2,6,1] = "DiamondRing";
$LootTable[2,6,2] = "KeldriniteRing";
$LootTable[2,6,3] = "BrimstoneRing";

// 3: TALISMAN
$LootTable[3,1,1] = "StoneTalisman";
$LootTable[3,1,2] = "QuartzTalisman";
$LootTable[3,1,3] = "GraniteTalisman";
$LootTable[3,2,1] = "OpalTalisman";
$LootTable[3,2,2] = "JadeTalisman";
$LootTable[3,2,3] = "TurquoiseTalisman";
$LootTable[3,3,1] = "RubyTalisman";
$LootTable[3,3,2] = "TopazTalisman";
$LootTable[3,3,3] = "SapphireTalisman";
$LootTable[3,4,1] = "ObsidianTalisman";
$LootTable[3,4,2] = "BloodStoneTalisman";
$LootTable[3,4,3] = "GarnetTalisman";
$LootTable[3,5,1] = "SilverTalisman";
$LootTable[3,5,2] = "GoldTalisman";
$LootTable[3,5,3] = "EmeraldTalisman";
$LootTable[3,6,1] = "DiamondTalisman";
$LootTable[3,6,2] = "KeldriniteTalisman";
$LootTable[3,6,3] = "BrimstoneTalisman";

// 4: ORB
$LootTable[4,1,1] = "StoneOrb";
$LootTable[4,1,2] = "QuartzOrb";
$LootTable[4,1,3] = "GraniteOrb";
$LootTable[4,2,1] = "OpalOrb";
$LootTable[4,2,2] = "JadeOrb";
$LootTable[4,2,3] = "TurquoiseOrb";
$LootTable[4,3,1] = "RubyOrb";
$LootTable[4,3,2] = "TopazOrb";
$LootTable[4,3,3] = "SapphireOrb";
$LootTable[4,4,1] = "ObsidianOrb";
$LootTable[4,4,2] = "BloodStoneOrb";
$LootTable[4,4,3] = "GarnetOrb";
$LootTable[4,5,1] = "SilverOrb";
$LootTable[4,5,2] = "GoldOrb";
$LootTable[4,5,3] = "EmeraldOrb";
$LootTable[4,6,1] = "DiamondOrb";
$LootTable[4,6,2] = "KeldriniteOrb";
$LootTable[4,6,3] = "BrimstoneOrb";

// 5: CHEST
$LootTable[5,1,1] = "PaddedShirt";
$LootTable[5,1,2] = "LeatherCovering";
$LootTable[5,1,3] = "HideCovering";
$LootTable[5,2,1] = "ScaleCovering";
$LootTable[5,2,2] = "ChainShirt";
$LootTable[5,2,3] = "BoneChestplate";
$LootTable[5,3,1] = "RingShirt";
$LootTable[5,3,2] = "BandedShirt";
$LootTable[5,3,3] = "SplintChestplate";
$LootTable[5,4,1] = "BronzeChestplate";
$LootTable[5,4,2] = "PlateCovering";
$LootTable[5,4,3] = "IronChestplate";
$LootTable[5,5,1] = "SteelChestplate";
$LootTable[5,5,2] = "AdamantBreastplate";
$LootTable[5,5,3] = "CrystalChestplate";
$LootTable[5,6,1] = "RuniteChestplate";
$LootTable[5,6,2] = "TitaniumChestplate";
$LootTable[5,6,3] = "MithrilShirt";

// 6: HEAD
$LootTable[6,1,1] = "PaddedCoif";
$LootTable[6,1,2] = "LeatherCoif";
$LootTable[6,1,3] = "HideCoif";
$LootTable[6,2,1] = "ScaleHelm";
$LootTable[6,2,2] = "ChainHelm";
$LootTable[6,2,3] = "BoneHelm";
$LootTable[6,3,1] = "RingCoif";
$LootTable[6,3,2] = "BandedCoif";
$LootTable[6,3,3] = "SplintHelm";
$LootTable[6,4,1] = "BronzeHelm";
$LootTable[6,4,2] = "PlateHelm";
$LootTable[6,4,3] = "IronHelm";
$LootTable[6,5,1] = "SteelHelm";
$LootTable[6,5,2] = "AdamantHelm";
$LootTable[6,5,3] = "CrystalHelm";
$LootTable[6,6,1] = "RuniteHelm";
$LootTable[6,6,2] = "TitaniumHelm";
$LootTable[6,6,3] = "MithrilCoif";

// 7: HANDS
$LootTable[7,1,1] = "PaddedGloves";
$LootTable[7,1,2] = "LeatherGloves";
$LootTable[7,1,3] = "HideGloves";
$LootTable[7,2,1] = "ScaleGloves";
$LootTable[7,2,2] = "ChainGloves";
$LootTable[7,2,3] = "BoneGauntlets";
$LootTable[7,3,1] = "RingGloves";
$LootTable[7,3,2] = "BandedGloves";
$LootTable[7,3,3] = "SplintGauntlets";
$LootTable[7,4,1] = "BronzeGauntlets";
$LootTable[7,4,2] = "PlateGloves";
$LootTable[7,4,3] = "IronGauntlets";
$LootTable[7,5,1] = "SteelGauntlets";
$LootTable[7,5,2] = "AdamantGauntlets";
$LootTable[7,5,3] = "CrystalGauntlets";
$LootTable[7,6,1] = "RuniteGloves";
$LootTable[7,6,2] = "TitaniumGauntlets";
$LootTable[7,6,3] = "MithrilGloves";

// 8: LEGS
$LootTable[8,1,1] = "PaddedPants";
$LootTable[8,1,2] = "LeatherGuards";
$LootTable[8,1,3] = "HideGuards";
$LootTable[8,2,1] = "ScaleGuards";
$LootTable[8,2,2] = "ChainLeggings";
$LootTable[8,2,3] = "BoneGreaves";
$LootTable[8,3,1] = "RingLeggings";
$LootTable[8,3,2] = "BandedGuards";
$LootTable[8,3,3] = "SplintGreaves";
$LootTable[8,4,1] = "BronzeLeggings";
$LootTable[8,4,2] = "PlateGuards";
$LootTable[8,4,3] = "IronGreaves";
$LootTable[8,5,1] = "SteelGuards";
$LootTable[8,5,2] = "AdamantLeggings";
$LootTable[8,5,3] = "CrystalGreaves";
$LootTable[8,6,1] = "RuniteGuards";
$LootTable[8,6,2] = "TitaniumGreaves";
$LootTable[8,6,3] = "MithrilPants";

// 9: BOOTS
$LootTable[9,1,1] = "PaddedShoes";
$LootTable[9,1,2] = "LeatherShoes";
$LootTable[9,1,3] = "HideBoots";
$LootTable[9,2,1] = "ScaleBoots";
$LootTable[9,2,2] = "ChainBoots";
$LootTable[9,2,3] = "BoneSabatons";
$LootTable[9,3,1] = "RingBoots";
$LootTable[9,3,2] = "BandedBoots";
$LootTable[9,3,3] = "SplintBoots";
$LootTable[9,4,1] = "BronzeBoots";
$LootTable[9,4,2] = "PlateBoots";
$LootTable[9,4,3] = "IronSabatons";
$LootTable[9,5,1] = "SteelBoots";
$LootTable[9,5,2] = "AdamantSabatons";
$LootTable[9,5,3] = "CrystalBoots";
$LootTable[9,6,1] = "RuniteBoots";
$LootTable[9,6,2] = "TitaniumSabatons";
$LootTable[9,6,3] = "MithrilShoes";


function Game::menuRequest(%clientId)
{
	if(%clientId.IsInvalid)
		return;

	if (%clientId.choosingRace)
	{
		MenuRace(%clientId);
		return;
	}
	if(%clientId.ConfirmRace)
	{
		MenuConfirmRace(%clientId);
		return;
	}


	%curItem = 0;
	Client::buildMenu(%clientId, "The Crucible:", "options", true);
	if($curVoteTopic != "" && %clientId.vote == "")
	{
		Client::addMenuItem(%clientId, %curItem++ @ "Vote YES to " @ $curVoteTopic, "voteYes " @ $curVoteCount);
		Client::addMenuItem(%clientId, %curItem++ @ "Vote NO to " @ $curVoteTopic, "voteNo " @ $curVoteCount);
	}
	else
	{
		if(%clientId.selClient)
		{
			%sel = %clientId.selClient;
			%selname = Client::getName(%sel);
	
			if(%clientId != %sel && fetchData(%sel, "HasLoadedAndSpawned"))
			{
                        if(IsInCommaList(fetchData(%clientId, "grouplist"), %selname))
					Client::addMenuItem(%clientId, %curItem++ @ "Remove from group-list", "remgroup " @ %sel);
				else
					Client::addMenuItem(%clientId, %curItem++ @ "Add to group-list", "addgroup " @ %sel);

                        if(IsInCommaList(fetchData(%clientId, "targetlist"), %selname))
					Client::addMenuItem(%clientId, %curItem++ @ "Remove from target-list", "remtarget " @ %sel);
				else
					Client::addMenuItem(%clientId, %curItem++ @ "Add to target-list", "addtarget " @ %sel);

				if(fetchData(%clientId, "partyOwned"))
				{
					if(IsInCommaList(fetchData(%clientId, "partylist"), %selname))
						Client::addMenuItem(%clientId, %curItem++ @ "Remove from your party", "remparty " @ %sel);
					else
					{
						if(CountObjInCommaList(fetchData(%clientId, "partylist")) < $maxpartymembers)
						{
							%p = IsInWhichParty(Client::getName(%sel));
							if(%p == -1)
								Client::addMenuItem(%clientId, %curItem++ @ "Invite to your party", "addparty " @ %sel);
							else if(GetWord(%p, 1) == "i")
								Client::addMenuItem(%clientId, %curItem++ @ "Cancel invitation", "cancelinv " @ %sel);
							else
								Client::addMenuItem(%clientId, %curItem++ @ "(Can't invite, already in a party)", "");
						}
						else
							Client::addMenuItem(%clientId, %curItem++ @ "(Can't invite, too many members)", "");
					}
				}

				if ((%team = PlayerIsInTeam(%clientId)) != -1) {
					if (%clientId == GetTeamLeader(%team)) {
						Client::addMenuItem(%clientId, %curItem++ @ "Invite to your team", "addteam " @ %sel);
					}
				}

				if(%clientId.muted[%sel])
					Client::addMenuItem(%clientId, %curItem++ @ "Unmute", "unmute " @ %sel);
				else
					Client::addMenuItem(%clientId, %curItem++ @ "Mute", "mute " @ %sel);

			}
		}
		else
		{
			if(!IsDead(%clientId))
				Client::addMenuItem(%clientId, %curItem++ @ "View your stats" , "viewstats");
			
			Client::addMenuItem(%clientId, %curItem++ @ "Settings..." , "selsettings");

			//if(fetchData(%clientId, "defaultTalk") == "#say")
			//	Client::addMenuItem(%clientId, %curItem++ @ "Set default talk: #group" , "defgroup");
			//else
			//	Client::addMenuItem(%clientId, %curItem++ @ "Set default talk: #say" , "defsay");

			//if(GetAccessoryList(%clientId, 9, -1) != "")
			//	Client::addMenuItem(%clientId, %curItem++ @ "Ranged weapons..." , "rweapons");

			if(!IsDead(%clientId))
				Client::addMenuItem(%clientId, %curItem++ @ "Skill points..." , "sp");

			//if(fetchData(%clientId, "ignoreGlobal"))
			//	Client::addMenuItem(%clientId, %curItem++ @ "Turn ignore global OFF" , "gignoreoff");
			//else
			//	Client::addMenuItem(%clientId, %curItem++ @ "Turn ignore global ON" , "gignoreon");

			//if(fetchData(%clientId, "LCKconsequence") == "miss")
			//	Client::addMenuItem(%clientId, %curItem++ @ "Set LCK mode = death" , "lckdeath");
			//else if(fetchData(%clientId, "LCKconsequence") == "death")
			//	Client::addMenuItem(%clientId, %curItem++ @ "Set LCK mode = miss" , "lckmiss");

			//Client::addMenuItem(%clientId, %curItem++ @ "Party options..." , "partyoptions");
			//Client::AddMenuItem(%clientId,%curItem++ @ "Perks...","menutoperks");

			Client::AddMenuItem(%clientId, GetMenuNum(%curItem++) @ "Passives...","menupassives");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Team options..." , "teamoptions");		
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Quest Log..." , "quest");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Spells..." , "spells");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Equipped Gear..." , "wear");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Backpack..." , "backpack");

			if (%clientId.CraftBase != "" || %clientId.CraftAdditions != "")
				Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Crafting Table..." , "craft");						

			//if (BackpackStorageArea(%clientId) == true) {
			//	Client::addMenuItem(%clientId, %curItem++ @ "Backpack Storage..." , "storage");
			//}
		}

		//Client::addMenuItem(%clientId, %curItem++ @ "other...", "Other");
	}
}


			%cat = $CruSpell[%a,$CSCategory];
						if (%cat == "") {
							Client::SendMessage(%id,1,"INTERNAL ERROR: NO CATEGORY");
							return;
						}
						else {
							%tmp = $PlayerSpells[%id,%cat];
							if (%tmp == "") {
								$PlayerSpells[%id,%cat] = %a @ " ";
								Client::SendMessage(%id,0,"You successfully learned spell: " @ $CruSpell[%a,$CSName]);
							}
							else {
								%spellfound = False;
								for (%search = 0; (%cs = GetWord(%tmp,%search)) != -1; %search++) {
									if (%cs == %a)
										%spellfound = True;
								}
								if (%spellfound == True) {
									Client::SendMessage(%id,0,"You have already learned this spell.");
								}
								else {
									$PlayerSpells[%id,%cat] = $PlayerSpells[%id,%cat] @ %a @ " ";
									Client::SendMessage(%id,0,"You successfully learned spell: " @ $CruSpell[%a,$CSName]);
								}
							}
						}






function CanBackpackWield(%id,%item,%use,%combine)
{
	if (%use == 1)
		%req = $BPItem[%item,$BPUse];
	else
		%req = $BPItem[%item,$BPWield];
	if (%req == "" && %combine == "")
		return false;
	if (%combine != "")
		%req = %combine;

	%m = 1;
	%loc = "";
	%lock = "";
	%deny = "";
	for (%i = 0; (%r = getWord(%req,%i)) != -1; %i += 2) {

		echo(" LOOPING ");		

		%a = getWord(%req,%i+1);
		if (%a <= 0 && %r != "LOCATION" && %r != "SKILLUNLOCK" && %r != "CLASS" && %r != "HOUSE" && %r != "GROUP" && %r != "RACE")
			%a = 0;

		if (%r == "LVLG") {
			if (fetchData(%id,"LVL") < %a) {
				%m = 0;
				echo(" MESS UP DENY LVL ");
				%deny = %deny @ "lvlg:" @ %a @ " ";
			}
		}
		else if (%r == "LVLL") {
			if (fetchData(%id,"LVL") > %a)
				%m = 0;
		}
		else if (%r == "CLASS") {
			if (fetchData(%id,"CLASS") != %a) {
				%m = 0;
				%deny = %deny @ "class:" @ %a @ " ";
			}
		}
		else if (%r == "GROUP") {
			if (fetchData(%id,"GROUP") != %a)
				%m = 0;
		}
		else if (%r == "RACE") {
			if (fetchData(%id,"RACE") != %a)
				%m = 0;
		}
		else if (%r == "RLG") {
			if (fetchData(%id,"RemortStep") < %a)
				%m = 0;
		}
		else if (%r == "RLL") {
			if (fetchData(%id,"RemortStep") > %a)
				%m = 0;
		}
		else if (%r == "ADMIN") {
			if (%id.adminLevel < %a)
				%m = 0;
		}
		else if (%r == "HOUSE") {
			if (fetchData(%id,"MyHouse") != %a)
				%m = 0;
		}
		else if (%r == "LOCATION") {
			%loc = %loc @ %a;
		}
		else if (%r == "SKILLUNLOCK") {
			%deny = %deny @ "skilllocked:" @ %a @ " ";
			%lock = %lock @ %a;
		}
		else if (%r == "LADDER") {
			%ladder = IsLadderPlayer(%id);
			if (%ladder != %a)
				%m = 0;
		}
		else if (%r == "FISHINGLVL") {
			if (GetTradeSkill(%id,$TradeSkillFishing) < %a)
				%m = 0;
		}
		else if (%r == "FARMINGLVL") {
			if (GetTradeSkill(%id,$TradeSkillFarming) < %a)
				%m = 0;
		}
		else if (%r == "PHYSCRAFTLVL") {
			if (GetTradeSkill(%id,$TradeSkillPhysCraft) < %a)
				%m = 0;
		}
		else if (%r == "MAGICCRAFTLVL") {
			if (GetTradeSkill(%id,$TradeSkillMagicCraft) < %a)
				%m = 0;
		}
		else if (%r == "ALCHEMYLVL") {
			if (GetTradeSkill(%id,$TradeSkillAlchemy) < %a)
				%m = 0;
		}
		else if (%r == "NEARFIRE") {
			if (NearFire(%id) == False) {
				%m = 0;
				%deny = %deny @ "nearfire:" @ %a @ " ";
			}
		}
		else if (%r == "MANA") {
			if (fetchData(%id,"MANA") < %a)
				%deny = %deny @ "MANA:" @ %a @ " ";
				%m = 0;
		}
		else {
			%rcrop = $BPSkillToNumeric[%r];

			echo(" RCROP " @ %rcrop);

			if (GetPlayerSkill(%id,%rcrop) < %a) {
				%deny = %deny @ %r @ ":" @ %a @ " ";
				%m = 0;
			}
		}
	}
	if (!%m) {
		echo("DENY " @ %deny);
		WeildDenyMessage(%id,%deny);
		return false;
	}

	if (%use != 1) {
		if (%loc == "") {
			echo(" NO LOCATION FOUND ");
			return false;

		}
		if (%loc == "ring") {
			if ($PlayerWear[%id,5] == "")
				return 5;
			if ($PlayerWear[%id,6] == "")
				return 6;
			else {
				%deny = %deny @ "location:" @ %loc @ " ";
				WeildDenyMessage(%id,%deny);
				return false;
			}
		}

		%locnum = $BPLocationToNumeric[%loc];
		if (%locnum == "")
			return false;
		%ml = 0;
		if ($PlayerWear[%id,%locnum] == "")
			%ml = 1;
		if (!%ml) {
			%deny = %deny @ "location:" @ %loc @ " ";
			WeildDenyMessage(%id,%deny);
			return false;
		}
		else
			return %locnum;
	}
	else {
		if (BPSkillUnlocked(%id,%lock) == true)
			return true;
		else {
			BPDisplaySkillLockTime(%id,%lock);
			return false;
		}
	}
}

//----------------------------------------------------------------------------
// MINE DYNAMIC DATA

MineData AntipersonelMine
{
	className = "Mine";
   description = "Antipersonel Mine";
   shapeFile = "mine";
   shadowDetailMask = 4;
   explosionId = mineExp;
	explosionRadius = 10.0;
	damageValue = 2.0;
	damageType = $MineDamageType;
	kickBackStrength = 150;
	triggerRadius = 2.5;
	maxDamage = 0.5;
	shadowDetailMask = 0;
	destroyDamage = 1.0;
	damageLevel = {1.0, 1.0};
};

function AntipersonelMine::onAdd(%this)
{
	%this.damage = 0;
	AntipersonelMine::deployCheck(%this);
}

function AntipersonelMine::onCollision(%this,%object)
{
	%type = getObjectType(%object);
	%data = GameBase::getDataName(%this);
	if ((%type == "Player" || %data == AntipersonelMine || %data == Vehicle || %type == "Moveable") &&
			GameBase::isActive(%this)) 
		GameBase::setDamageLevel(%this, %data.maxDamage);
}

function AntipersonelMine::deployCheck(%this)
{
	if (GameBase::isAtRest(%this)) {
		GameBase::playSequence(%this,1,"deploy");
	 	GameBase::setActive(%this,true);
		%set = newObject("set",SimSet);
		if(1 != containerBoxFillSet(%set,$MineObjectType,GameBase::getPosition(%this),1,1,1,0)) {
			%data = GameBase::getDataName(%this);
			GameBase::setDamageLevel(%this, %data.maxDamage);
		}
		deleteObject(%set);
	}
	else 
		schedule("AntipersonelMine::deployCheck(" @ %this @ ");", 3, %this);
}	

function AntipersonelMine::onDestroyed(%this)
{
	$TeamItemCount[GameBase::getTeam(%this) @ "mineammo"]--;
}

function AntipersonelMine::onDamage(%this,%type,%value,%pos,%vec,%mom,%object)
{
   if (%type == $MineDamageType)
      %value = %value * 0.25;

	%data = GameBase::getDataName(%this);
	if((%data.maxDamage/1.5) < %this.damage+%value) 
		GameBase::setDamageLevel(%this, %data.maxDamage);
	else 
		%this.damage += %value;
}

//----------------------------------------------------------------------------

MineData Bomb1
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = mortarExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb1::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb2
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = mineExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb2::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb3
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = grenadeExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb3::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb4
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = Shockwave;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb4::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb5
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = LargeShockwave;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb5::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb6
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = rocketExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb6::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb7
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = energyExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb7::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb8
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = blasterExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb8::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb9
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = plasmaExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb9::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb10
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = turretExp;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb10::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb11
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = bulletExp0;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb11::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}


MineData Bomb12
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = debrisExpSmall;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb12::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb13
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = debrisExpMedium;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb13::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb14
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = debrisExpLarge;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb14::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb15
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = flashExpSmall;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb15::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb16
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = flashExpMedium;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb16::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

MineData Bomb17
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = flashExpLarge;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function Bomb17::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}



// BLUSTREXP
// EXP_REDSTAR
// EXP_BURN

// EX_VOLCANIC - RS TRUE
// EX_TORNADO
// EX_PLAUGE
// EX_SNOWSTORM

//-------------------------------------------------------------
ExplosionData CruSpellExp1
{
   shapeName = "EX_SNOWSTORM.dts";
   soundId   = NoSound;

   faceCamera = false;
   randomSpin = false;
   hasLight   = false;
   lightRange = 3.0;

   timeZero = 6.05;
   timeOne  = 0.05;

   colors[0]  = { 0.25, 0.25, 1.0 };
   colors[1]  = { 0.25, 0.25, 1.0 };
   colors[2]  = { 1.0,  1.0,  1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData CruSpellBomb1
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CruSpellExp1;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function CruSpellBomb1::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}
SoundData ActivateDE
{
   wavFileName = "ActivateDE.wav";
   profile     = Profile3dNear;
};

ExplosionData CruSpellExp2
{
   shapeName = "shotgunex.dts";
   soundId   = NoSound;

   faceCamera = true;
   randomSpin = true;
   hasLight   = false;
   lightRange = 3.0;

   timeZero = 1.450;
   timeOne  = 0.05;

   colors[0]  = { 1.0, 0.25, 0.25 };
   colors[1]  = { 1.0, 0.25, 0.25 };
   colors[2]  = { 1.0, 0.25, 0.25 };
   radFactors = { 1.0, 1.0, 1.0 };

   shiftPosition = True;
};
MineData CruSpellBomb2
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CruSpellExp2;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function CruSpellBomb2::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}
SoundData SpellPower1
{
   	wavFileName = "ImpactTR.wav";
   	profile     = Profile3dNear;
};



ExplosionData CruSpellExp3
{
   shapeName = "BLUORBEXP.dts";
   soundId   = NoSound;

   faceCamera = false;
   randomSpin = false;
   hasLight   = false;
   lightRange = 3.0;

   timeZero = 6.05;
   timeOne  = 0.05;

   colors[0]  = { 0.25, 0.25, 1.0 };
   colors[1]  = { 0.25, 0.25, 1.0 };
   colors[2]  = { 1.0,  1.0,  1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData CruSpellBomb3
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CruSpellExp3;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};

ExplosionData CruSpellExp4
{
   shapeName = "GRNNUKE.dts";
   soundId   = NoSound;

   faceCamera = false;
   randomSpin = false;
   hasLight   = false;
   lightRange = 3.0;

   timeZero = 6.05;
   timeOne  = 0.05;

   colors[0]  = { 0.25, 0.25, 1.0 };
   colors[1]  = { 0.25, 0.25, 1.0 };
   colors[2]  = { 1.0,  1.0,  1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData CruSpellBomb4
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CruSpellExp4;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};

ExplosionData CruSpellExp5
{
   shapeName = "EXP_BURN.dts";
   soundId   = NoSound;

   faceCamera = false;
   randomSpin = false;
   hasLight   = false;
   lightRange = 3.0;

   timeZero = 0.0;
   timeOne  = 0.0;

   colors[0]  = { 0.25, 0.25, 1.0 };
   colors[1]  = { 0.25, 0.25, 1.0 };
   colors[2]  = { 1.0,  1.0,  1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData CruSpellBomb5
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CruSpellExp5;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};

//--------------------------------------------------------------




MineData Handgrenade
{
   mass = 0.3;
   drag = 1.0;
   density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
   description = "Handgrenade";
   shapeFile = "grenade";
   shadowDetailMask = 4;
   explosionId = grenadeExp;
	explosionRadius = 10.0;
	damageValue = 0.5;
	damageType = $ShrapnelDamageType;
	kickBackStrength = 100;
	triggerRadius = 0.5;
	maxDamage = 2;
};

function Handgrenade::onAdd(%this)
{
	%data = GameBase::getDataName(%this);
	schedule("Mine::Detonate(" @ %this @ ");",2.0,%this);
}

function Mine::onDamage(%this,%type,%value,%pos,%vec,%mom,%object)
{
   if (%type == $MineDamageType)
      %value = %value * 0.25;

	%damageLevel = GameBase::getDamageLevel(%this);
	GameBase::setDamageLevel(%this,%damageLevel + %value);
}

function Mine::Detonate(%this)
{
	%data = GameBase::getDataName(%this);
	GameBase::setDamageLevel(%this, %data.maxDamage);
}

//

//function UpdateAppearance(%clientId)
//{
//	dbecho($dbechoMode, "UpdateAppearance(" @ %clientId @ ")");
//
//	//Determine armor from shields
//	%armor = -1;
//	%shield = -1;
//	%list = GetAccessoryList(%clientId, 2, "3 7");
//	for(%i = 0; (%w = getCroppedItem(GetWord(%list, %i))) != -1; %i++)
//	{
//		if($AccessoryVar[%w, $AccessoryType] == $BodyAccessoryType)
//			%armor = %w;
//		else if($AccessoryVar[%w, $AccessoryType] == $ShieldAccessoryType)
//			%shield = %w;
//	}
//	%player = Client::getOwnedObject(%clientId);
//	%race = fetchData(%clientId, "RACE");
//	%model = Player::getArmor(%clientId);
//	%cw = String::getSubStr(%model, String::findSubStr(%model, "Armor"), 99999);
//	%skinbase = Client::getSkinBase(%clientId);
//	%apm = $ArmorPlayerModel[%armor];
//
//	//=================================
//	// Update skin
//	//=================================
//	if(%race == "MaleHuman" || %race == "FemaleHuman")
//	{
//		%skinbase = "rpgbase";
//
//		if(%armor != -1)
//			%skinbase = $ArmorSkin[%armor];
//	}
//	else if(%race == "DeathKnight")
//	{
//		%skinbase = "cphoenix";
//		%apm = "";
//		%cw = "Armor22";
//		%armor = 0;
//	}
//	else
//	{
//		%p = $RaceToArmorType[%race];
//		%armor = -1;
//	}
//
//	if(Client::getSkinBase(%clientId) != %skinbase)
//		Client::setSkin(%clientId, %skinbase);
//
//	//=================================
//	// Update player model
//	//=================================
//	if(%armor != -1)
//		%p = %race @ %apm @ %cw;
//
//	%ae = GameBase::getEnergy(%player);
//
//	if(Player::getArmor(%clientId) != %p && %p != "")
//	{
//		Player::setArmor(%clientId, %p);
//		GameBase::setEnergy(%player, %ae);
//	}
//
//	//=================================
//	// Update shields and Orb
//	//=================================
//	if(%shield != -1)
//	{
//		if(Player::getMountedItem(%clientId, 2) != %shield)
//		{
//			Player::unmountItem(%clientId, 2);
//			Player::mountItem(%clientId, %shield, 2);
//		}
//	}
//	else
//	{
//		if(Player::getMountedItem(%clientId, 2) != -1)
//			Player::unmountItem(%clientId, 2);
//
//		for(%i = 1; $ItemList[Orb, %i] != ""; %i++)
//		{
//			if(Player::getItemCount(%clientId, $ItemList[Orb, %i] @ "0"))
//				Player::mountItem(%clientId, $ItemList[Orb, %i] @ "0", 2);
//		}
//	}
//}



	// PERKS


	
	if (%opt == "menutoperks") {
		Game::MenuPerks(%clientId);
	}

	if (%opt == "perks") {
		Game::MenuPerkList(%clientId,%cl,getWord(%option,2));
	}
	if (%opt == "menuperk") {
		Game::MenuPerks(%clientId);
	}
	if (%opt == "menubackperk") {
		Game::MenuPerkList(%clientId,%cl,getWord(%option,2));
	}
	if (%opt == "perksel") {
		Game::MenuShowPerk(%clientId,%cl,getWord(%option,2),getWord(%option,3));
	}
	if (%opt == "perkconfig") {
		Game::MenuConfigPerk(%clientId,%cl,getWord(%option,2),getWord(%option,3),getWord(%option,4));
	}
	if (%opt == "perkinfo") {
		ShowPerkInfo(%clientId,%cl);
		Game::MenuConfigPerk(%clientId,%cl,getWord(%option,2),getWord(%option,3),getWord(%option,4));
	}
	if (%opt == "menunextperk") {
		Game::MenuShowPerk(%clientId,%cl,getWord(%option,2),getWord(%option,3));
	}
	if (%opt == "menuperkselback") {
		Game::MenuShowPerk(%clientId,%cl,getWord(%option,2),getWord(%option,3));
	}
	if (%opt == "addperk") {
		AddPerk(%clientId,%cl);
		Game::MenuShowPerk(%clientId,getWord(%option,2),getWord(%option,3),getWord(%option,4));
	}
	if (%opt == "remperk") {
		RemovePerk(%clientId,%cl);
		Game::MenuShowPerk(%clientId,getWord(%option,2),getWord(%option,3),getWord(%option,4));
	}





		// return "(" @ DynamicItem::GetQualityDisp(getWord(%bp,%slot)) @ ") " @ GetBPData(getWord(%bp,%slot),$BPName) @ " " @ getWord(%bp,%slot+1);
		// if (getWord(%bp,%slot+1) > 1) return GetBPData(getWord(%bp,%slot),$BPName) @ " " @ getWord(%bp,%slot+1);


	//echo("GET BACKPACK SLOT " @ %id @ " " @ %slot);


//=========================================================================================================================

function InitZones()
{
	dbecho($dbechoMode, "InitZones()");

	$numZones = 0;
	%zcnt = 0;
	%umusiccnt = 0;

	%group = nameToId("MissionGroup\\Zones");

	if(%group != -1)
	{
		%count = Group::objectCount(%group);
		for(%i = 0; %i <= %count-1; %i++)
		{
			%object = Group::getObject(%group, %i);
			%system = Object::getName(%object);
			%type = GetWord(%system, 0);
			%desc = String::getSubStr(%system, String::len(%type)+1, 9999);

			//---------------------------------------------------------------
			//THIS PART GATHERS SOUNDS FOR THE GENERIC UNKNOWN ZONE
			// there is no EXIT sound for the unknown zone.
			//---------------------------------------------------------------
			if(GetWord(%system, 0) == "ENTERSOUND")
			{	
				$Zone::EnterSound[0] = GetWord(%system, 1);
			}
			else if(GetWord(%system, 0) == "AMBIENTSOUND")
			{
				$Zone::AmbientSound[0] = GetWord(%system, 1);
				$Zone::AmbientSoundPerc[0] = GetWord(%system, 2);
			}
			else if(GetWord(%system, 0) == "MUSIC")
			{
				$Zone::Music[0, %umusiccnt++] = GetWord(%system, 1);
				$Zone::MusicTicks[0, %umusiccnt] = GetWord(%system, 2);
			}
			//---------------------------------------------------------------
			else
			{
				%zcnt++;

				%tmpgroup = nameToId("MissionGroup\\Zones\\" @ %system);
				%tmpcount = Group::objectCount(%tmpgroup);
				%marker = "";
				%musiccnt = 0;

				for(%z = 0; %z <= %tmpcount-1; %z++)
				{
					%tmpobject = Group::getObject(%tmpgroup, %z);
	
					if(getObjectType(%tmpobject) == "Marker")
					{
						if(%marker == "")
						{
							%marker = %tmpobject;
							$numZones++;
						}
					}
					else if(getObjectType(%tmpobject) == "SimGroup")
					{
						%n = Object::getName(%tmpobject);
						
						if(GetWord(%n, 0) == "ENTERSOUND")
						{	
							$Zone::EnterSound[%zcnt] = GetWord(%n, 1);
						}
						else if(GetWord(%n, 0) == "AMBIENTSOUND")
						{
							$Zone::AmbientSound[%zcnt] = GetWord(%n, 1);
							$Zone::AmbientSoundPerc[%zcnt] = GetWord(%n, 2);
						}
						else if(GetWord(%n, 0) == "EXITSOUND")
						{
							$Zone::ExitSound[%zcnt] = GetWord(%n, 1);
						}
						else if(GetWord(%n, 0) == "MUSIC")
						{
							$Zone::Music[%zcnt, %musiccnt++] = GetWord(%n, 1);
							$Zone::MusicTicks[%zcnt, %musiccnt] = GetWord(%n, 2);
						}
					}
				}
				
				%mname = Object::getName(%marker);
				$Zone::Marker[%zcnt] = GameBase::getPosition(%marker);
				$Zone::Length[%zcnt] = GetWord(%mname, 0);
				$Zone::Width[%zcnt] = GetWord(%mname, 1);
				$Zone::Height[%zcnt] = GetWord(%mname, 2);
				$Zone::SHeight[%zcnt] = GetWord(%mname, 3);
				$Zone::Type[%zcnt] = %type;
				$Zone::Desc[%zcnt] = %desc;
				$Zone::FolderID[%zcnt] = %tmpgroup;
			}
		}
		echo($numZones @ " zones initialized.");
	}
}

function RecursiveZone(%delay)
{
	dbecho($dbechoMode, "RecursiveZone(" @ %delay @ ")");

	//increment by 1 every $zoneCheckDelay seconds
	$zoneTicker[1]++;
	$zoneTicker[2]++;

	if($zoneTicker[1] >= 1)		//check zone every 2 seconds for players
	{
		DoZoneCheck(2, %delay);
		$zoneTicker[1] = "";
	}
//	if($zoneTicker[2] >= 15)	//check zone every 30 seconds for bots
//	{
//		DoZoneCheck(1, %delay);
//		$zoneTicker[2] = "";
//	}

	schedule("RecursiveZone(" @ %delay @ ");", %delay);
}

function DoZoneCheck(%w, %d)
{
	dbecho($dbechoMode, "DoZoneCheck(" @ %w @ ", " @ %d @ ")");

	//Massive zone check for entire world
	%mset = newObject("set", SimSet);
	%n = containerBoxFillSet(%mset, $SimPlayerObjectType, "0 0 0", 9999, 9999, 9999, 0);

	for(%z = 1; %z <= $numZones; %z++)
	{
		%set = newObject("set", SimSet);
		%n = containerBoxFillSet(%set, $SimPlayerObjectType, $Zone::Marker[%z], $Zone::Length[%z], $Zone::Width[%z], $Zone::Height[%z], $Zone::SHeight[%z]);
		Group::iterateRecursive(%set, setzoneflags, %z);
		deleteObject(%set);
	}
	
	Group::iterateRecursive(%mset, UpdateZone);
	deleteObject(%mset);
}
function setzoneflags(%object, %z)
{
	dbecho($dbechoMode, "setzoneflags(" @ %object @ ", " @ %z @ ")");

	%clientId = Player::getClient(%object);
	storeData(%clientId, "tmpzone", %z);
}

function UpdateZone(%object)
{
	dbecho($dbechoMode, "UpdateZone(" @ %object @ ")");

	%clientId = Player::getClient(%object);
	%zoneflag = fetchData(%clientId, "tmpzone");

	//check if the player was found inside a zone
	if(%zoneflag != "")
	{
		//the player is inside a zone!
	
		//check if the player's current zone matches the one he's detected in
		if(fetchData(%clientId, "zone") != $Zone::FolderID[%zoneflag])
		{
			//the client's current zone does not match the one he really is in, so boot the player out of his
			//current zone (if any)
			if(fetchData(%clientId, "zone") != "")
				Zone::DoExit(Zone::getIndex(fetchData(%clientId, "zone")), %clientId);
	
			//throw the player inside this new zone
			Zone::DoEnter(%zoneflag, %clientId);
		}
		else
		{
			//the client is in the same zone as he was since the last zonecheck
			if($Zone::AmbientSound[%zoneflag] != "")
			{
				%m = $Zone::AmbientSoundPerc[%zoneflag];
				if(%m == "") %m = 100;
	
				%r = floor(getRandom() * 100)+1;
				if(%r <= %m)
					Client::sendMessage(%clientId, 0, "~w" @ $Zone::AmbientSound[%zoneflag]);
			}
			if($Zone::Music[%zoneflag, 1] != "")
			{
				if(%clientId.MusicTicksLeft < 1)
				{
					for(%m = 1; $Zone::Music[%zoneflag, %m] != ""; %m++){}
					%m--;
					%clientId.currentMusic = floor(getRandom() * %m) + 1;

					Client::sendMessage(%clientId, 0, "~w" @ $Zone::Music[%zoneflag, %clientId.currentMusic]);
					%clientId.MusicTicksLeft = $Zone::MusicTicks[%zoneflag, %clientId.currentMusic]+2;
				}
			}
			if($Zone::Type[%zoneflag] == "WATER")
			{
				if(!IsDead(%clientId))
				{
					%noDrown = "";
					for(%i = 1; (%orb = $ItemList[Orb, %i]) != ""; %i++)
					{
						if($ProtectFromWater[%orb])
						{
							if(Player::getItemCount(%clientId, %orb @ "0"))
							{
								storeData(%clientId, "drownCounter", 0);
								%noDrown = True;
								break;
							}
						}
					}

					if(!%noDrown)
					{
						%dn = 10;

						storeData(%clientId, "drownCounter", 1, "inc");
						if((%dc = fetchData(%clientId, "drownCounter")) > %dn)
						{
							%dmg = Cap(floor(pow((%dc - %dn) / 1.2, 2)), 1.0, 1000) * "0.01";
							GameBase::virtual(%clientId, "onDamage", 0, %dmg, "0 0 0", "0 0 0", "0 0 0", "torso", "front_right", %clientId);
							%snd = radnomItems(3, SoundDrown1, SoundDrown2, SoundDrown3);
							playSound(%snd, GameBase::getPosition(%clientId));
						}
					}
				}
			}
		}

		//this simulates underwater
		if($Zone::Type[%zoneflag] == "WATER")
			if($underwaterEffects)
				gravWorkaround(%clientId, 1);
	}
	else
	{
		//the player is not inside any zone.
		//if the player has a current zone, then we need to kick him out of it
		if(fetchData(%clientId, "zone") != "")
			Zone::DoExit(Zone::getIndex(fetchData(%clientId, "zone")), %clientId);
	
		//start playing the ambient sound for the unknown zone
		if($Zone::AmbientSound[0] != "")
		{
			%m = $Zone::AmbientSoundPerc[0];
			if(%m == "") %m = 100;
			
			%r = floor(getRandom() * 100)+1;
			if(%r <= %m)
				Client::sendMessage(%clientId, 0, "~w" @ $Zone::AmbientSound[0]);
		}
	
		//play the enter sound for the unknown zone
		if($Zone::EnterSound[0] != "")
			Client::sendMessage(%clientId, 0, "~w" @ $Zone::EnterSound[0]);

		//play unknown zone music
		if($Zone::Music[0, 1] != "")
		{
			if(%clientId.MusicTicksLeft < 1)
			{
				for(%m = 1; $Zone::Music[0, %m] != ""; %m++){}
				%m--;
				%clientId.currentMusic = floor(getRandom() * %m) + 1;

				Client::sendMessage(%clientId, 0, "~w" @ $Zone::Music[0, %clientId.currentMusic]);
				%clientId.MusicTicksLeft = $Zone::MusicTicks[0, %clientId.currentMusic]+2;
			}
		}
	}

	//-----------------------------------------------------------
	// Decrease music ticks
	//-----------------------------------------------------------
	if(%clientId.MusicTicksLeft > 0)
		%clientId.MusicTicksLeft--;

	//-----------------------------------------------------------
	// Decrease bonus state ticks
	//-----------------------------------------------------------
	DecreaseBonusStateTicks(%clientId);

	//-----------------------------------------------------------
	// Check if the player has moved since last ZoneCheck
	//-----------------------------------------------------------
	%pos = GameBase::getPosition(%clientId);
	if(%pos != %clientId.zoneLastPos && !IsDead(%clientId))
	{
		//train Weight Capacity
		if(OddsAre(8))
			UseSkill(%clientId, $SkillWeightCapacity, True, True, "", True);

		//cycle thru orbs
		for(%i = 1; (%orb = $ItemList[Orb, %i]) != ""; %i++)
		{
			if(OddsAre($BurnOut[%orb]))
			{
				if(Player::getItemCount(%clientId, %orb @ "0"))
				{
					Client::sendMessage(%clientId, $MsgRed, "Your " @ %orb.description @ " has burned out.");
					Player::decItemCount(%clientId, %orb @ "0", 1);
					RefreshAll(%clientId);
				}
			}
			if($BurnOutInRain[%orb] > 0)
			{
				if(fetchData(%clientId, "zone") == "" && $isRaining)
				{
					if(OddsAre($BurnOutInRain[%orb]))
					{
						if(Player::getItemCount(%clientId, %orb @ "0"))
						{
							Client::sendMessage(%clientId, $MsgRed, "The rain has burned out your " @ %orb.description @ ".");
							Player::decItemCount(%clientId, %orb @ "0", 1);
							RefreshAll(%clientId);
						}
					}
				}
			}
		}

		//hard-coded list to save on CPU
		for(%z = 1; $ItemList[Badge, %z] != ""; %z++)
		{
			if(Player::getItemCount(%clientId, $ItemList[Badge, %z]))
			{
				%a = GetWord($BonusItem[$ItemList[Badge, %z]], 0);
				%b = GetWord($BonusItem[$ItemList[Badge, %z]], 1);
				%c = GetWord($BonusItem[$ItemList[Badge, %z]], 2);

				if(OddsAre(%c))
					GiveThisStuff(%clientId, %a @ " " @ %b, True);
			}
		}

		//perhaps leave scent
		if(!fetchData(%clientId, "invisible"))
		{
			if(OddsAre(floor($PlayerSkill[%clientId, $SkillSenseHeading] / 100)+1))
			{
				storeData(%clientId, "lastScent", GameBase::getPosition(%clientId));
			}
		}
	}
	%clientId.zoneLastPos = %pos;

	storeData(%clientId, "tmpzone", "");
}

function gravWorkaround(%clientId, %method)
{
	dbecho($dbechoMode, "gravWorkaround(" @ %clientId @ ", " @ %method @ ")");

	if(%method == 1)
	{
		%rzdelay = 2;
		%steps = 24;

		for(%i = 0; %i < %steps; %i++)
		{
			%d = %i / (%steps / %rzdelay);
			schedule("Player::applyImpulse(" @ %clientId @ ", \"0 0 13\");", %d, %clientId);
		}
	}
	else if(%method == 2)
	{
		if($xyvel == "") $xyvel = 0.8;
		if($nzvel == "") $nzvel = 0.2;
		if($pzvel == "") $pzvel = 1.0;
		if($impulse == "") $impulse = 4;

		Player::applyImpulse(%clientId, "0 0 " @ $impulse);

		%vel = Item::getVelocity(%clientId);
		
		%xvel = GetWord(%vel, 0) * $xyvel;
		%yvel = GetWord(%vel, 1) * $xyvel;
		%zvel = GetWord(%vel, 2);

		if(%zvel < 0)
			%zvel *= $nzvel;
		else
			%zvel *= $pzvel;

		%nvel = %xvel @ " " @ %yvel @ " " @ %zvel;

		Item::setVelocity(%clientId, %nvel);
	}
}

function Zone::DoEnter(%z, %clientId)
{
	dbecho($dbechoMode, "Zone::DoEnter(" @ %z @ ", " @ %clientId @ ")");

	%oldZone = fetchData(%clientId, "zone");
	%newZone = $Zone::FolderID[%z];

	storeData(%clientId, "zone", $Zone::FolderID[%z]);

	if($Zone::Type[%z] == "PROTECTED")
	{
		%msg = "You have entered " @ $Zone::Desc[%z] @ ".  This is protected territory.";
		%color = $MsgBeige;
	}
	else if($Zone::Type[%z] == "DUNGEON")
	{
		%msg = "You have entered " @ $Zone::Desc[%z] @ ".  Beware of enemies!";
		%color = $MsgRed;
	}
	else if($Zone::Type[%z] == "WATER")
	{
		%msg = "";
	}
	else if($Zone::Type[%z] == "FREEFORALL")
	{
		%msg = "You have entered " @ $Zone::Desc[%z] @ ".";
		%color = $MsgRed;
	}

	if($Zone::EnterSound[%z] != "")
		%msg = %msg @ "~w" @ $Zone::EnterSound[%z];

	if(%msg != "")
		Client::sendMessage(%clientId, %color, %msg);

	if(!Player::isAiControlled(%clientId))
		Game::refreshClientScore(%clientId);	//this is so players can see which zone this client is in

	Zone::onEnter(%clientId, %oldZone, %newZone);
}

function Zone::DoExit(%z, %clientId)
{
	dbecho($dbechoMode, "Zone::DoExit(" @ %z @ ", " @ %clientId @ ")");

	%zoneLeft = fetchData(%clientId, "zone");

	storeData(%clientId, "zone", "");

	if($Zone::Type[%z] == "PROTECTED")
	{
		%msg = "You have left " @ $Zone::Desc[%z] @ ".";
		%color = $MsgRed;
	}
	else if($Zone::Type[%z] == "DUNGEON")
	{
		%msg = "You have left " @ $Zone::Desc[%z] @ ".";
		%color = $MsgBeige;
	}
	else if($Zone::Type[%z] == "WATER")
	{
		%msg = "";
	}
	else if($Zone::Type[%z] == "FREEFORALL")
	{
		%msg = "You have left " @ $Zone::Desc[%z] @ ".";
		%color = $MsgBeige;
	}

	if($Zone::ExitSound[%z] != "")
		%msg = %msg @ "~w" @ $Zone::ExitSound[%z];

	if(%msg != "")
	      Client::sendMessage(%clientId, %color, %msg);

	if(!Player::isAiControlled(%clientId))
		Game::refreshClientScore(%clientId);	//this is so players can see which zone this client is in

	Zone::onExit(%clientId, %zoneLeft);
}

function IsInBetween(%x, %r1, %r2)
{
	dbecho($dbechoMode, "IsInBetween(" @ %x @ ", " @ %r1 @ ", " @ %r2 @ ")");

	if(%r1 > %r2)
	{
		%tmp = %r1;
		%r1 = %r2;
		%r2 = %tmp;
	}
	if(%x >= %r1 && %x <= %r2)
		return True;
	else
		return False;
}

function Zone::getIndex(%z)
{
	dbecho($dbechoMode, "Zone::getIndex(" @ %z @ ")");

	if(%z != "")
	{
		for(%i = 1; %i <= $numZones; %i++)
		{
			if($Zone::FolderID[%i] == %z)
			{
				return %i;
			}
		}
	}
	return -1;
}
function Zone::getMarker(%z)
{
	dbecho($dbechoMode, "Zone::getMarker(" @ %z @ ")");

	if(%z != "")
	{
		for(%i = 1; %i <= $numZones; %i++)
		{
			if($Zone::FolderID[%i] == %z)
			{
				return $Zone::Marker[%i];
			}
		}
	}
	return -1;
}
function Zone::getType(%z)
{
	dbecho($dbechoMode, "Zone::getType(" @ %z @ ")");

	if(%z != "")
	{
		for(%i = 1; %i <= $numZones; %i++)
		{
			if($Zone::FolderID[%i] == %z)
			{
				return $Zone::Type[%i];
			}
		}
	}
	return -1;
}
function Zone::getDesc(%z)
{
	dbecho($dbechoMode, "Zone::getDesc(" @ %z @ ")");

	if(%z != "")
	{
		for(%i = 1; %i <= $numZones; %i++)
		{
			if($Zone::FolderID[%i] == %z)
			{
				return $Zone::Desc[%i];
			}
		}
	}
	return -1;
}
function Zone::getEnterSound(%z)
{
	dbecho($dbechoMode, "Zone::getEnterSound(" @ %z @ ")");

	if(%z != "")
	{
		for(%i = 1; %i <= $numZones; %i++)
		{
			if($Zone::FolderID[%i] == %z)
			{
				return $Zone::EnterSound[%i];
			}
		}
	}
	return -1;
}
function Zone::getAmbientSound(%z)
{
	dbecho($dbechoMode, "Zone::getAmbientSound(" @ %z @ ")");

	if(%z != "")
	{
		for(%i = 1; %i <= $numZones; %i++)
		{
			if($Zone::FolderID[%i] == %z)
			{
				return $Zone::AmbientSound[%i];
			}
		}
	}
	return -1;
}
function Zone::getAmbientSoundPerc(%z)
{
	dbecho($dbechoMode, "Zone::getAmbientSoundPerc(" @ %z @ ")");

	if(%z != "")
	{
		for(%i = 1; %i <= $numZones; %i++)
		{
			if($Zone::FolderID[%i] == %z)
			{
				return $Zone::AmbientSoundPerc[%i];
			}
		}
	}
	return -1;
}
function Zone::getExitSound(%z)
{
	dbecho($dbechoMode, "Zone::getExitSound(" @ %z @ ")");

	if(%z != "")
	{
		for(%i = 1; %i <= $numZones; %i++)
		{
			if($Zone::FolderID[%i] == %z)
			{
				return $Zone::ExitSound[%i];
			}
		}
	}
	return -1;
}

function Zone::onEnter(%clientId, %oldZone, %newZone)
{
	dbecho($dbechoMode, "Zone::onEnter(" @ %clientId @ ", " @ %oldZone @ ", " @ %newZone @ ")");

	refreshHPREGEN(%clientId);	//this is because you regen faster or slower depending on the zone you are in

	if(Zone::getType(%newZone) == "WATER")
	{
		//Client::sendMessage(%clientId, $MsgBeige, "You have entered water!");
		storeData(%clientId, "drownCounter", "");
	}
	if(Zone::getType(%newZone) == "PROTECTED")
	{
		if(fetchData(%clientId, "isMimic"))
		{
			storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
			storeData(%clientId, "isMimic", "");
			UpdateTeam(%clientId);
			RefreshAll(%clientId);

			playSound(AbsorbABS, GameBase::getPosition(%clientId));
		}
	}
}

function Zone::onExit(%clientId, %zoneLeft)
{
	dbecho($dbechoMode, "Zone::onExit(" @ %clientId @ ", " @ %zoneLeft @ ")");

	refreshHPREGEN(%clientId);	//this is because you regen faster or slower depending on the zone you are in

	if(Zone::getType(%zoneLeft) == "WATER")
	{
		//Client::sendMessage(%clientId, $MsgBeige, "You have left water!");
		storeData(%clientId, "drownCounter", "");
	}
}

function GetNearestZone(%clientId, %zonetype, %returnType)
{
	dbecho($dbechoMode, "GetNearestZone(" @ %clientId @ ", " @ %zonetype @ ", " @ %returnType @ ")");

	//%zonetype can be "town", "dungeon" or "freeforall"

	%closestDist = 500000;
	%closestZone = "";
	%mpos = "";
	%clpos = GameBase::getPosition(%clientId);

	for(%i = 1; %i <= $numZones; %i++)
	{
		%type = $Zone::Type[%i];
		if(%type == "PROTECTED" && String::ICompare(%zonetype, "town") == 0 || %type == "DUNGEON" && String::ICompare(%zonetype, "dungeon") == 0 || %type == "FREEFORALL" && String::ICompare(%zonetype, "freeforall") == 0 || %zonetype == -1)
		{
			%finalpos = $Zone::Marker[%i];
	
			%dist = Vector::getDistance(%finalpos, %clpos);
			if(%dist < %closestDist)
			{
				%closestDist = %dist;
				%closestZoneDesc = $Zone::Desc[%i];
				%closestZone = $Zone::FolderID[%i];
				%mpos = %finalpos;
			}
		}
	}

	if(%mpos == "")		//no zones were found (this means there are NO zones in the map...)
		return False;
	
	//%returnType:
	//1 = returns the distance from the client to the nearest zone
	//2 = returns the description of the zone nearest to the client
	//3 = returns the zone id of the zone nearest to the client
	//4 = returns the position of the middle of the zone nearest to the client

	if(%returnType == 1)
		return %closestDist;
	else if(%returnType == 2)
		return %closestZoneDesc;
	else if(%returnType == 3)
		return %closestZone;
	else if(%returnType == 4)
		return %mpos;
}

function GetZoneByKeywords(%clientId, %keywords, %returnType)
{
	dbecho($dbechoMode, "GetZoneByKeywords(" @ %clientId @ ", " @ %keywords @ ", " @ %returnType @ ")");

	%mpos = "";

	%group = nameToId("MissionGroup\\Zones");

	if(%group != -1)
	{
		//IMPORTANT: zone markers must be objects 0 and 1 in the zone's folder

		%count = Group::objectCount(%group);
		for(%i = 0; %i <= %count-1; %i++)
		{
			%object = Group::getObject(%group, %i);
			%system = Object::getName(%object);
			%type = GetWord(%system, 0);
			%desc = String::getSubStr(%system, String::len(%type)+1, 9999);
			if(%type == "PROTECTED" || %type == "DUNGEON" || %type == "FREEFORALL")
			{
				if(String::findSubStr(%desc, %keywords) != -1)
				{
					//get the two markers
					%tmpgroup = nameToId("MissionGroup\\Zones\\" @ %system);

					%m1pos = GameBase::getPosition(Group::getObject(%tmpgroup, 0));
					%m2pos = GameBase::getPosition(Group::getObject(%tmpgroup, 1));

					%mx = (((GetWord(%m2pos, 0) - GetWord(%m1pos, 0)) / 2) + GetWord(%m1pos, 0));
					%my = (((GetWord(%m2pos, 1) - GetWord(%m1pos, 1)) / 2) + GetWord(%m1pos, 1));
					%mz = (((GetWord(%m2pos, 2) - GetWord(%m1pos, 2)) / 2) + GetWord(%m1pos, 2));

					%mpos = %mx @ " " @ %my @ " " @ %mz;
					%dist = Vector::getDistance(%mpos, GameBase::getPosition(%clientId));

					//%returnType:
					//1 = returns the distance from the client to the zone
					//2 = returns the description of the zone
					//3 = returns the zone id
					//4 = returns the position of the middle of the zone

					if(%returnType == 1)
						return %dist;
					else if(%returnType == 2)
						return %desc;
					else if(%returnType == 3)
						return %object;
					else if(%returnType == 4)
						return %mpos;
				}
			}
		}
		return False;	
	}
	else
		return False;
}

function Zone::getNumPlayers(%z, %all)
{
	dbecho($dbechoMode, "Zone::getNumPlayers(" @ %z @ ", " @ %all @ ")");

	if(%all)
		%list = GetEveryoneIdList();
	else
		%list = GetPlayerIdList();

	%n = 0;
	for(%i = 0; GetWord(%list, %i) != -1; %i++)
	{
		%id = GetWord(%list, %i);

		if(fetchData(%id, "zone") == %z)
			%n++;
	}

	return %n;
}

function ObjectInWhichZone(%object)
{
	dbecho($dbechoMode, "ObjectInWhichZone(" @ %object @ ")");

	//not perfect but good enough

	%fid = "";
	%closest = 99999;
	%objpos = GameBase::getPosition(%object);
	for(%z = 1; %z <= $numZones; %z++)
	{
		%rad = ($Zone::Length[%z] + $Zone::Width[%z] + $Zone::Height[%z]) / 3;
		%dist = Vector::getDistance(%objpos, $Zone::Marker[%z]);
		if(%dist <= %rad)
		{
			if(%dist < %closest)
			{
				%closest = %dist;
				%fid = $Zone::FolderID[%z];
			}
		}
	}
	return %fid;
}

function Zone::getPlayerList(%z, %type)
{
	dbecho($dbechoMode, "Zone::getPlayerList(" @ %z @ ", " @ %type @ ")");

	if(%type == 1)
		%list = GetEveryoneIdList();
	else if(%type == 2)
		%list = GetPlayerIdList();
	else if(%type == 3)
		%list = GetBotIdList();

	%n = 0;
	%aa = "";
	for(%i = 0; GetWord(%list, %i) != -1; %i++)
	{
		%id = GetWord(%list, %i);

		if(fetchData(%id, "zone") == %z)
			%aa = %aa @ %id @ " ";
	}

	return %aa;
}

//============================================================================================================================================





function Loot::Body(%tier,%mf)
{
	%mf = 1 + (%mf / 100);
	%max = floor(640 / %mf);
	%r = floor(getRandom() * %max + 1);
	%t = 1;
	// 24 ----------------------
	if (%r <= 216) %t = 2;
	if (%r <= 192) %t = 3;
	if (%r <= 168) %t = 3;
	if (%r <= 144) %t = 4;
	if (%r <= 120) %t = 5;
	// 12 ----------------------
	if (%r <= 96) %t = 6;
	if (%r <= 84) %t = 7;
	if (%r <= 72) %t = 8;
	if (%r <= 60) %t = 10;
	if (%r <= 48) %t = 11;
	if (%r <= 36) %t = 12;
	// 6 ----------------------
	if (%r <= 24) %t = 13;
	if (%r <= 18) %t = 14;
	if (%r <= 12) %t = 15;
	if (%r <= 6) %t = 16;
	if (%r <= 3) %t = 17;
	if (%r == 1) %t = 18;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 3 + 1);
	if (%r == 1) %x = "AMR";
	else if (%r == 2) %x = "EVA";
	else if (%r == 3) %x = "RES";
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 5 + 1);
	if (%r == 1) %l = "Head";
	else if (%r == 2) %l = "Chest";
	else if (%r == 3) %l = "Hands";
	else if (%r == 4) %l = "Legs";
	else if (%r == 5) %l = "Boots";
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,%x,%t];
	if (%tier == 0)
		return %baseloot;
	else {
		%tiername = $TIERNAME[%l,%x,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Body(%tier,%mf)
{
	%mf = 1 + (%mf / 100);
	%max = floor(655360 / %mf);
	%r = floor(getRandom() * %max + 1);
	%t = 1;
	if (%r <= 327680) %t = 2;
	if (%r <= 163840) %t = 3;
	if (%r <= 81920) %t = 4;
	if (%r <= 40960) %t = 5;
	if (%r <= 20480) %t = 6;
	if (%r <= 10240) %t = 7;
	if (%r <= 5120) %t = 8;
	if (%r <= 2560) %t = 9;
	if (%r <= 1280) %t = 10;
	if (%r <= 640) %t = 11;
	if (%r <= 320) %t = 12;
	if (%r <= 160) %t = 13;
	if (%r <= 80) %t = 14;
	if (%r <= 40) %t = 15;
	if (%r <= 20) %t = 16;
	if (%r <= 10) %t = 17;
	if (%r <= 5) %t = 18;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 3 + 1);
	if (%r == 1) %x = "AMR";
	else if (%r == 2) %x = "EVA";
	else if (%r == 3) %x = "RES";
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 5 + 1);
	if (%r == 1) %l = "Head";
	else if (%r == 2) %l = "Chest";
	else if (%r == 3) %l = "Hands";
	else if (%r == 4) %l = "Legs";
	else if (%r == 5) %l = "Boots";
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,%x,%t];
	if (%tier == 0)
		return %baseloot;
	else {
		%tiername = $TIERNAME[%l,%x,%tier];
		return %tiername @ %baseloot;
	}
}

//==================================================================================================================================================

// MERCHANT STUFF

function MerchantFull(%merchant)
{
	%bp = $BPMerchantShop[%merchant];
	if (getWord(%bp,($MaxMerchantStorage + ($MaxMerchantStorage - 2))) != -1 || $BPNoMerchantStorage[%merchant] == 1)
		return true;
	else
		return false;
}

function GetBackpackMerchant(%id,%slot)
{
	%area = %id.MerchantArea;
	%storage = $BPMerchantShop[%id];
	if (getWord(%storage,%slot) != -1)
		return GetBPData(getWord(%storage,%slot),$BPName) @ " " @ getWord(%storage,%slot+1);
	else
		return false;
}

function GetTrueBackpackMerchant(%id,%slot)
{
	%area = %id.MerchantArea;
	%storage = $BPMerchantShop[%id];
	if (getWord(%storage,%slot) != -1)
		return getWord(%storage,%slot) @ " " @ getWord(%storage,%slot+1);
	else
		return false;
}

function Game::MenuSelectMerchant(%id,%i,%page)
{
	//echo("MENU SELECT STORE " @ %id @ " " @ %i);
	%area = %id.MerchantArea;
	%s = GetTrueBackpackMerchant(%area,%i);
	%item = getWord(%s,0);
	%count = getWord(%s,1);
	%curItem = 0;
	if (%count != -1)
		Client::buildMenu(%id, GetBPData(%item,$BPName) @ " " @ %count , "options", true);
	else
		Client::buildMenu(%id, GetBPData(%item,$BPName), "options", true);
	%bulk = %id.bulkNum;
	if (%bulk <= 0) 
		%bulk = 1;
	if (%bulk > %count) {
		if (%count != -1) {
			if (%bulk > %count) {
				%bulk = 1;
			}
   		}
	}
	if (%bulk > 500)
		%bulk = 500;
	Client::addMenuItem(%id, %curItem++ @ "Examine..","selbackpackexamineb " @ %item @ " " @ %i);
	Client::addMenuItem(%id, %curItem++ @ "Buy " @ %bulk,"selbackpackbuy " @ %item @ " " @ %bulk);
	Client::addMenuItem(%id, "p<< Prev ","selbackpackmerchantback " @ %i);
}

$BPMerchants = 1;
// $BPMerchantArea[1] = "675.8 -480.4 200.275"; // KELDRIN ENCAMPMENT WEAPONS/ARMOR
// $BPMerchantArea[1] = "-2402 -292 65"; // KELDRIN TOWN
$BPMerchantArea[1] = "-121 55 3";

function RestockShops()
{
	for (%i = 1; %i <= $BPMerchants; %i++)
		RandStockShop(%i);
}

function InitLoadMerchants()
{
	// KELDRIN ENCAMPMENT WEAPONS/ARMOR
	$BPMerchantShop[1] = "";
}

function RandStockShop(%merchant)
{	
	for (%i = 0; (%v = getWord($StockDefault[%merchant],%i)) != -1; %i+=2)
		 DynamicItem::InitWear(%v);

	%new = "";
	// %new = %new @ $StockDefault[%merchant];

	//for (%i = 1; (%s = $StockTable[%merchant,%i]) != ""; %i++) {
	//	%p = getWord(%s,0);
	//	%v = getWord(%s,1);
	//	%m = getWord(%s,2);
	//	%x = getWord(%s,3);
	//	%yes = GetRandom() * 101;
	//	if (%yes <= %p) {
	//		%ql = RandBetween(%m,%x);
	//		DynamicItem::CheckItemCreate(%v,%ql);
	//		%new = %new @ FormatQL(%ql) @ %v @ " -1 ";
	//	}
	//}

	// TEMP RAND LOOT SHOP
	
	for (%i = 1; %i <= 50; %i++) {
		%loot = TestRandomLoot();
		%a = floor(getRandom() * 5 + 1);
		%new = %new @ %loot @ " 1 ";
	}

	$BPMerchantShop[%merchant] = %new; 
}


// KELDRIN ENCAMPMENT WEAPONS/ARMOR
//$StockDefault[1] = "001BasicArrow -1 ";
//$StockTable[1,1] = "75 PaddedArmor 1 50";
//$StockTable[1,2] = "75 PaddedGloves 1 50";
//$StockTable[1,3] = "101 SCAbilityBoost 1 1";
//$StockTable[1,4] = "101 BluePotion 1 1";
//$StockTable[1,5] = "101 EnergyVial 1 1";
//$StockTable[1,6] = "101 BluePotion 25 25";
//$StockTable[1,7] = "101 EnergyVial 25 25";

function LoadMerchants()
{
	exec(MERCHANTSAVE);
	for (%i = 1; %i <= $BPMerchants; %i++) {
		$BPMerchantShop[%i] = $merchantsave[%i]; 
	}
}

LoadMerchants();

function SaveMerchants(%id)
{
	if (!$MerchantSaving) {
		SaveCharacter(%id);
		for (%i = 1; %i <= $BPMerchants; %i++) {
			$merchantsave[%i] = $BPMerchantShop[%i];
		}
		File::delete("config\\MERCHANTSAVE.cs");
		export("$merchantsave*", "config\\MERCHANTSAVE.cs", false);
		$MerchantSaving = 1;
		schedule("UnlockMerchantSave();",5);
	}
}

function ManualSaveMerchants()
{
	for (%i = 1; %i <= $BPMerchants; %i++) {
		$merchantsave[%i] = $BPMerchantShop[%i];
	}
	File::delete("config\\MERCHANTSAVE.cs");
	export("$merchantsave*", "config\\MERCHANTSAVE.cs", false);
	$MerchantSaving = 1;
}

function UnlockMerchantSave()
{
	$MerchantSaving = 0;
}

UnlockMerchantSave();

$BPBlacksmiths = 1;
$BPBlacksmithArea[1] = "-2393 -283 65"; // KTOWN
function BackpackSmithArea(%id)
{
	%l = GameBase::getPosition(Client::getOwnedObject(%id));
	%gdist = $maxAIdistVec + (GetPlayerSkill(%id,$SkillSpeech) / 50);
	for (%i = 1; %i <= $BPStorages; %i++) {
		%s = $BPBlacksmithArea[%i];
		%dist = Vector::getDistance(%l,%s);
		if (%dist <= %gdist) {
			return true;
		}
	}
	return false;
}

$BPStorages = 5;
$BPStorageArea[1] = "-2410 -302 65"; 		// KTOWN
$BPStorageArea[2] = "-402.5 1763 65"; 		// JATEN
$BPStorageArea[3] = "-2373.7 9657.6 52.5"; 	// NEW KELDRIN
$BPStorageArea[4] = "-2409.3 8065.8 79"; 	// ATHSERO HARBOR
$BPStorageArea[5] = "-2437.2 -2296 85.8"; 	// ETHREN

function BackpackStorageArea(%id)
{
	%l = GameBase::getPosition(Client::getOwnedObject(%id));
	%gdist = $maxAIdistVec + (GetPlayerSkill(%id,$SkillSpeech) / 50);
	for (%i = 1; %i <= $BPStorages; %i++) {
		%s = $BPStorageArea[%i];
		%dist = Vector::getDistance(%l,%s);
		if (%dist <= %gdist) {
			return true;
		}
	}
	return false;
}

function AddBackpackStorage(%id,%item,%d)
{
	//echo("ADD BACKPACK STORAGE " @ %id @ " " @ %item @ " " @ %d);
	if (HasBackpackCount(%id,%item,%d)) {
		if (BackpackHasItem(%id,%item,False,True,False) == false) {
			if (BackpackFull(%id,1) == false) {
				RemoveFromBackpack(%id,%item,(%d * -1),0);
				AddToBackpack(%id,%item,%d,1);
			}
			else {
				Client::SendMessage(%id,1,"You can not store any more item types.");
			}
		}
		else {
			RemoveFromBackpack(%id,%item,(%d * -1),0);
			AddToBackpack(%id,%item,%d,1);
		}
	}
}

function WithdrawBackpackStorage(%id,%item,%d)
{
	//echo("WITHDRAW BP STORAGE " @ %id @ " " @ %item @ " " @ %d);
	if (HasStorageCount(%id,%item,%d)) {
		if (BackpackFull(%id,0) == false) {
			AddToBackpack(%id,%item,%d,0);
			RemoveFromBackpack(%id,%item,(%d * -1),1);
		}
		else 
			Client::SendMessage(%id,1,"Your backpack is full!");
	}
}

function BackpackMerchantArea(%id)
{
	%l = GameBase::getPosition(Client::getOwnedObject(%id));
	%in = 0;
	%gdist = $maxAIdistVec + (GetPlayerSkill(%id,$SkillSpeech) / 50);
	%ldist = 0;
	for (%i = 1; %i <= $BPMerchants; %i++) {
		%s = $BPMerchantArea[%i];
		%dist = Vector::getDistance(%l,%s);
		if (%dist <= %gdist) {
			if (%dist < %ldist || %ldist == 0) {
				%ldist = %dist;
				%ldisti = %i;
				%in = 1;
			}
		}
	}
	if (%in) {
		%id.MerchantArea = %ldisti;
		return %ldisti;
	}
	else
		return false;
}

function SetupBackpackMerchant(%id)
{
	BackpackSetBuy(%id,%item,%count);
}

function BackpackBuy(%id) 
{
	%price = %id.BBuyPrice;
	%delta = %id.BBuyCount;
	%item = %id.BBuyItem;
	%area = %id.MerchantArea;
	if (BackpackMerchantArea(%id) == %area) {
		if (HasThisStuff(%id,"COINS " @ %price,%count) == true) {
			%cnt = GetMerchantCount(%area,%item,%delta);
			if (%cnt == -1) {
				Client::SendMessage(%id,0,"You bought " @ %delta @ " " @ $BPItem[%item,$BPName] @ " for " @ %price @ " coins.");
				AddToBackpack(%id,%item,%delta);
				TakeThisStuff(%id,"COINS " @ %price,1);
			}
			else {
				if (%cnt >= %delta) {
					Client::SendMessage(%id,0,"You bought " @ %delta @ " " @ $BPItem[%item,$BPName] @ " for " @ %price @ " coins.");
					AddToBackpack(%id,%item,%delta);
					TakeThisStuff(%id,"COINS " @ %price,1);
					RemoveFromBackpack(%area,%item,(%delta * -1),0,%area);
					ManualSaveMerchants();
				}
				else
					Client::SendMessage(%id,1,"The merchant does not have this.");		
			}
		}
		else 
			Client::SendMessage(%id,1,"You dont have enough coins to buy this.");
	}
	else
		Client::SendMessage(%id,1,"You are not near a merchant.");
}

$BPSellMaxHaggle = 5000;

function BackpackSetBuy(%id,%item,%count)
{
	//echo("BLACKPACK BUY " @ %id @ " " @ %item @ " " @ %count);
	%price = $BPItem[%item,$BPPrice];
	if (%price <= 0)
		%price = 0;
	%hagskill = GetPlayerSkill(%id,$SkillHaggling);
	if (%hagskill > $BPSellMaxHaggle)
		%hagskill = $BPSellMaxHaggle;
	%sellprice = floor(%price - (%price * ((%hagskill / $BPSellMaxHaggle) / 3)));
	%sellprice = (%sellprice * %count);
	%id.BBuyPrice = %sellprice;
	%id.BBuyCount = %count;
	%id.BBuyItem = %item;
	%id.BuyingBackpack = 1;
	%id.SmithingBackpack = "";
	%id.SellingBackpack = "";
	Client::SendMessage(%id,0,"The merchant will sell you " @ %count @ " " @ GetBPData(%item,$BPName) @ " for " @ %sellprice @ " coins.");
}


function BackpackSetSell(%id,%item,%count,%i,%page)
{
	//echo("BLACKPACK SELL " @ %id @ " " @ %item @ " " @ %count);
	if ($NoDropItem[%item] == 1) {
		Client::SendMessage(%clientId,0,$BPItem[%cl,$BPName] @ " is a NODROP item.");
		return;
	}
	%price = $BPItem[%item,$BPPrice];
	if (%price <= 0)
		%price = 0;
	%hagskill = GetPlayerSkill(%id,$SkillHaggling);
	if (%hagskill > $BPSellMaxHaggle)
		%hagskill = $BPSellMaxHaggle;
	%sellprice = floor(%price / (10 - (%hagskill / ($BPSellMaxHaggle / 8))));
	%sellprice = (%sellprice * %count);
	%id.BSellPrice = %sellprice;
	%id.BSellCount = %count;
	%id.BSellItem = %item;
	%id.SellingBackpack = 1;
	%id.SmithingBackpack = "";
	%id.BuyingBackpack = "";
	Client::SendMessage(%id,0,"The merchant will give you " @ %sellprice @ " coins for " @ %count @ " " @ $BPItem[%item,$BPName] @ ".");
	%area = %id.MerchantArea;
	Game::MenuSellBackpack(%id,%menu,%page,%i);
	//****************************************
	// REMOVED
	//if (MerchantFull(%area) == true) {
	//	Client::SendMessage(%id,0,"The merchant has no room to store any more types of backpack items here.");
	//}
}

function Game::MenuSellBackpack(%id,%menu,%page,%i)
{
	%sellprice = %id.BSellPrice;
	%count = %id.BSellCount;
	%item = %id.BSellItem;
	%curItem = 0;
	%name = GetBPData(%item,$BPName);
	if (string::getSubStr(%name,24,1) != "")
		%name = string::GetSubStr(%name,0,24) @ "..";
	Client::buildMenu(%id, "Sell " @ %name @ "?", "optionssellbp", true);
	Client::addMenuItem(%id, "aSell " @ %count @ " for $" @ %sellprice,"selbackpacksellaccept " @ %item @ " " @ %page);
	Client::addMenuItem(%id, "xCancel","selbackpacksellcancel " @ %i @ " " @ %page);
}

function processMenuOptionsSellBP(%id, %option)
{
	%opt = getWord(%option, 0);
	%cl = getWord(%option, 1);
	%page = getWord(%option,2);
	
	if (%opt == "selbackpacksellaccept") {
		BackpackSell(%id);
		Game::MenuBackpack(%id,(%page - 8));
	}

	if (%opt == "selbackpacksellcancel") {
		%id.BSellPrice = "";
		%id.BSellCount = "";
		%id.BSellItem = "";
		%id.SellingBackpack = "";
		%id.SmithingBackpack = "";
		%id.BuyingBackpack = "";
		Game::MenuBackpack(%id,(%page - 8));
	}
}

function BackpackSell(%id)
{
	%item = %id.BSellItem;
	%delta = %id.BSellCount;
	%price = %id.BSellPrice;
	if (BackpackMerchantArea(%id) != false) {
		%area = %id.MerchantArea;
		// echo("AREA " @ %area);
		// echo($BPMerchantShop[%area]);
		if (HasBackpackCount(%id,%item,%delta) == true) {
			Client::SendMessage(%id,0,"You sold " @ %delta @ " " @ $BPItem[%item,$BPName] @ ".");
			RemoveFromBackpack(%id,%item,%delta * -1);
			GiveThisStuff(%id, "COINS " @ %price, True, 1, 1);
			//****************************************
			// REMOVED
			//if (MerchantFull(%area) == false) {
			//	if (GetMerchantCount(%area,%item,1) != -1)
			//		AddToBackpack(%id,%item,%delta,0,%area);
			//	//SaveMerchants();
			//	ManualSaveMerchants();
			//}
		}
	}
	else {
		Client::SendMessage(%id,0,"You have left the shop area.");
	}
	%id.BSellPrice = "";
	%id.BSellCount = "";
	%id.BSellItem = "";
	%id.SellingBackpack = "";
	%id.SmithingBackpack = "";
	%id.BuyingBackpack = "";
}

function BackpackSmith(%id)
{
	%item = %id.BSmithItem;
	%count = %id.BSmithCount;
	%price = %id.BSmithPrice;
	%combo = $BPSmith[%item,$BPSmithCombo];
	if (BackpackSmithArea(%id) != false) {
		if (HasThisStuff(%id,%combo,%count) == True) {
			if (HasThisStuff(%id,"COINS " @ %price,1)) {
				//echo("TEST " @ %combo @ " " @ %id @ " " @ %count);
				TakeThisStuff(%id,%combo,%count);
				TakeThisStuff(%id,"COINS " @ %price);
				%desc = "False";
				if (isBackpackItem(%item)) {
					%desc = GetBPData(%item,$BPName);
				}
				if (%count == 1) {
					Client::SendMessage(%id,0,"Here is your " @ %desc @ "...");
				}
				else {
					Client::SendMessage(%id,0,"Here are your " @ %count @ " " @ %desc @ "...");
				}
				GiveThisStuff(%id,%item @ " " @ %count);
			}
			else {
				Client::SendMessage(%id,1,"You dont have enough coins to build these.");
			}
		}
		else
			Client::SendMessage(%id,1,"You don't have the materials needed.");
	}
	else
		Client::SendMessage(%id,1,"You are not near a blacksmith.");
}

function BackpackSetSmith(%id,%item,%count)
{
	%combo = $BPSmith[%item,$BPSmithCombo];
	%price = $BPSmith[%item,$BPSmithPrice];
	if (BackpackSmithArea(%id) == false) {
		Client::SendMessage(%id,1,"You are not near a blacksmith.");
		return;	
	}
	if (%combo == "") {
		Client::SendMessage(%id,1,"Unknown smithing combination: " @ %item);
		return;
	}
	if (HasThisStuff(%id,%combo,%count) == True) {
		if (%price <= 0)
			%price = 0;
		%hagskill = GetPlayerSkill(%id,$SkillHaggling);
		if (%hagskill > $BPSellMaxHaggle)
			%hagskill = $BPSellMaxHaggle;
		%sellprice = floor(%price / (10 - (%hagskill / ($BPSellMaxHaggle / 8))));
		%sellprice = (%sellprice * %count);
		%id.BSmithPrice = %sellprice;
		%id.BSmithCount = %count;
		%id.BSmithItem = %item;
		%id.SmithingBackpack = 1;
		%id.SellingBackpack = "";
		Client::SendMessage(%id,0,"The blacksmith will make you " @ %count @ " " @ GetBPData(%item,$BPName) @ " for $" @ %sellprice @ ". (#accept)");
	}
	else {
		Client::SendMessage(%id,1,"You don't have the materials needed.");
	}
}







AddToCommonTier("SLASHING","34 23 12 46 12 23 12 34 12 12 0 0 0 12 0 0","DYN AMR EVA ","Slashing",4);
AddToCommonTier("PIERCING","23 23 12 23 34 34 23 23 12 12 0 0 0 12 0 0","DYN AMR EVA ","Piercing",4);
AddToCommonTier("BLUDGEONING","23 12 12 46 23 34 23 12 12 23 0 0 0 12 0 0","DYN AMR ","Bludgeoning",4);
AddToCommonTier("DODGING","12 12 12 12 23 46 46 34 12 12 0 0 0 12 0 0","DYN EVA ","Dodging",4);
AddToCommonTier("WEIGHTCAPACITY","12 23 23 23 12 46 34 12 12 23 0 0 0 12 0 0","DYN AMR EVA RES ","Travels",4);
AddToCommonTier("BASHING","23 23 12 23 34 23 23 23 23 12 0 0 0 12 0 0","DYN AMR EVA ","Bashing",4);
AddToCommonTier("STEALING","12 23 23 23 34 23 12 34 23 0 0 0 0 23 0 0","DYN EVA ","Thievery",4);
AddToCommonTier("HIDING","12 23 12 12 34 46 23 34 0 12 0 0 0 23 0 0","DYN EVA ","Shadow",4);
AddToCommonTier("BACKSTABBING","12 12 12 23 23 23 12 46 12 12 0 0 0 23 0 0","DYN EVA ","Sneaking",4);
AddToCommonTier("SPELLRESISTANCE","23 23 46 12 12 12 12 12 34 12 0 0 0 34 0 0","DYN ","Resistance",4);
AddToCommonTier("HEALING","23 23 23 34 12 23 12 12 23 23 0 0 0 23 0 0","DYN AMR EVA RES ","Healing",4);
AddToCommonTier("ARCHERY","23 12 23 23 46 23 12 34 12 12 0 0 0 12 0 0","DYN EVA ","Archery",4);
AddToCommonTier("ENDURANCE","23 23 12 46 12 23 23 12 12 23 0 0 0 23 0 0","DYN AMR ","Endurance",4);
AddToCommonTier("MARTIALARTS","23 12 12 34 34 34 46 23 0 0 0 0 0 23 0 0","DYN AMR EVA ","Balance",4);
AddToCommonTier("MINING","12 34 12 23 34 12 12 23 34 12 0 0 0 34 0 0","DYN ","Mining",4);
AddToCommonTier("SPEECH","23 23 23 12 12 12 12 12 34 12 0 0 0 58 0 0","DYN RES ","Speech",4);
AddToCommonTier("SENSEHEADING","23 23 46 12 12 12 12 23 46 12 0 0 0 23 0 0","DYN AMR EVA RES ","Heading",4);
AddToCommonTier("ENERGY","12 23 46 12 23 12 12 23 34 12 0 0 0 23 0 0","DYN RES ","Energy",4);
AddToCommonTier("HAGGLING","12 23 46 12 12 12 12 23 34 12 0 0 0 34 0 0","DYN AMR EVA RES ","Haggling",4);
AddToCommonTier("STRENGTH","34 23 12 46 12 12 23 12 12 23 0 0 0 12 0 0","DYN AMR EVA RES ","Strength",4);
AddToCommonTier("STAMINA","34 23 12 34 12 34 23 12 12 23 0 0 0 12 0 0","DYN AMR EVA RES ","Stamina",4);
AddToCommonTier("AGILITY","12 23 12 12 34 34 46 23 12 12 0 0 0 12 0 0","DYN AMR EVA RES ","Agility",4);
AddToCommonTier("INTELLIGENCE","12 34 34 12 12 12 12 23 34 12 0 0 0 34 0 0","DYN AMR EVA RES ","Intelligence",4);
AddToCommonTier("SENSE","12 34 23 12 34 34 12 34 12 12 0 0 0 12 0 0","DYN AMR EVA RES ","Sense",4);
AddToCommonTier("PSYCHIC","12 34 46 12 12 12 12 12 34 12 0 0 0 34 0 0","DYN AMR EVA RES ","Psychic",4);
AddToCommonTier("CASTINIT","12 23 34 23 34 12 12 12 34 12 0 0 0 23 0 0","DYN RES ","Initation",4);
AddToCommonTier("LITERACY","12 34 23 12 12 12 12 12 34 12 0 0 0 58 0 0","DYN ","Reading",4);
AddToCommonTier("SMITHING","23 12 12 23 34 12 12 12 12 12 0 0 0 69 0 0","DYN AMR ","Smithing",4);
AddToCommonTier("MAGICCRAFT","12 23 34 12 12 12 12 12 23 12 0 0 0 69 0 0","DYN RES ","Crafting",4);
AddToCommonTier("ALCHEMY","12 23 23 12 12 12 12 12 34 12 0 0 0 69 0 0","DYN RES ","Mixing",4);
AddToCommonTier("SPELLCAPACITY","23 23 23 12 12 23 12 23 23 12 12 0 0 34 0 0","DYN RES ","Memory",4);
AddToCommonTier("WEAPONHANDLING","12 12 12 23 46 34 23 23 12 12 0 0 0 23 0 0","DYN AMR EVA ","Handling",4);
AddToCommonTier("EVADEMELEE","12 23 12 12 23 46 46 23 12 12 0 0 0 12 0 0","DYN EVA ","Evading",4);
AddToCommonTier("AIMING","23 12 23 23 46 23 12 34 12 12 0 0 0 12 0 0","DYN EVA ","Sniping",4);
AddToCommonTier("BRAWLING","23 23 12 34 23 23 23 23 12 23 0 0 0 12 0 0","DYN AMR EVA ","Brawling",4);
AddToCommonTier("CLEAVE","34 23 12 34 23 23 12 23 12 23 0 0 0 12 0 0","DYN AMR ","Cleaving",4);
AddToCommonTier("PRIMALMAGIC","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Instinct",4);
AddToCommonTier("HOLYMAGIC","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Divinity",4);
AddToCommonTier("EMPOWERMENT","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Empowerment",4);
AddToCommonTier("DARKMAGIC","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Darkness",4);
AddToCommonTier("LIGHTMAGIC","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Light",4);
AddToCommonTier("RITUAL","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Rituals",4);
AddToCommonTier("SORCERY","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Sorcery",4);
AddToCommonTier("PROTECTION","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Protection",4);
AddToCommonTier("ENCHANTMENT","23 23 34 12 12 23 23 23 34 0 0 0 0 23 0 0","DYN RES ","Enchanting",4);
AddToCommonTier("WISDOM","23 23 23 12 12 23 12 23 23 12 12 0 0 34 0 0","DYN RES ","Wisdom",4);


function Player::onDamage(%this,%type,%value,%pos,%vec,%mom,%vertPos,%rweapon,%object,%weapon,%preCalcMiss)
{
	dbecho($dbechoMode2, "Player::onDamage(" @ %this @ ", " @ %type @ ", " @ %value @ ", " @ %pos @ ", " @ %vec @ ", " @ %mom @ ", " @ %vertPos @ ", " @ %rweapon @ ", " @ %object @ ", " @ %weapon @ ", " @ %preCalcMiss @ ")");

	%skilltype = $SkillType[%weapon];

	if(Player::isExposed(%this) && %object != -1 && %type != $NullDamageType && !Player::IsDead(%this))
	{
		%damagedClient = Player::getClient(%this);
		%shooterClient = %object;

		%damagedClientPos = GameBase::getPosition(%damagedClient);
		%shooterClientPos = GameBase::getPosition(%shooterClient);

		%damagedCurrentArmor = GetCurrentlyWearingArmor(%damagedClient);

		//==============
		//PROCESS STATS
		//==============
		%isMiss = False;
		%Backstab = False;
		%Bash = False;
		%arenaNull = False;
		%sameTeamNull = False;

		%attackerweapon = GetCurrentWearFull(%shooterClient,13);
		
		//------------- DETERMINE MISS OR HIT -------------
		if(%preCalcMiss == "")
		{
			if (%type != $LandingDamageType && %shooterClient != %damagedClient && %shooterClient != 0)
			{
				if (%type == $SpellDamageType) {
					// do stuff
				}
				else {
					%newatk = NewATKSuccessfull(%shooterClient,%damagedClient,%attackerweapon);
					if (%newatk == False)
						%isMiss = True;
				}			
			}
		}

		//------------- CREATE DAMAGE VALUE -------------
		if(%type == $SpellDamageType)
		{
			//For the case of SPELLS, the initial damage has already been determined before calling this function

			%dmg = %value;
			//%value = round(((%dmg / 1000) * $PlayerSkill[%shooterClient, %skilltype]));
			%value = round(((%dmg / 1000) * GetPlayerSkill(%shooterClient,%skilltype)));

			%ab = (getRandom() * (fetchData(%damagedClient, "MDEF") / 10)) + 1;
			%value = Cap(%value - %ab, 0, "inf");

			%value = (%value / $TribesDamageToNumericDamage);
		}
		else if(%type != $LandingDamageType)
		{
			%multi = 1;

			if (fetchData(%shooterClient, "invisible"))
			{
				// BACKSTAB
			}
			if (fetchData(%damagedClient, "invisible") && %damagedClient.adminLevel < 5)
			{
				UnHide(%damagedClient);
			}

			if(fetchData(%shooterClient, "NextHitBash"))
			{
				// BASH
				storeData(%shooterClient, "NextHitBash", "");
			}

			if ((%loaded = GetLoadedProjectile(%id)) != -1)
				%hardatk = $BPItem[%loaded,$BPATK];
			else
				%hardatk = 0;

			if(%Bash)	//i'm doing this condition here because %mom is dependant on %value
			{
				%c1 = ( %c / 15 * %value );
				%c2 = %c2 / 10;
				%mom = Vector::getFromRot( %b, %c1, %c2 );
			}
				
			%roll = GetNewDamageRoll(%shooterClient,%attackerweapon);
			
			// echo(" ROLL >>>>>>>>> " @ %roll);

			%rollHit = getWord(%roll,0);
			%rollMin = getWord(%roll,1);
			
			// %armorClass = GetNewArmorClass(%damagedClient,"physical");

			

			%weaponac = $BPItem[%attackerweapon,$BPDamageType];
			
			echo(" WEAPON AC " @ %weaponac);
			
			%armorClass = getPlayerAc(%damagedClient,%weaponac);

			echo(" ARMOR CLASS " @ %armorclass);

			%rollHit -= %armorClass;
		
			if (%rollHit <= %rollMin)
				%value = %rollMin;
			else
				%value = %rollHit;

			%value = (%value / $TribesDamageToNumericDamage);			
		}

		//------------- DETERMINE SHIELD BLOCK -------------

		%isBlock = False;
		if(%preCalcMiss == "" && %isMiss != True && %shooterClient != %damagedClient)
		{
			//%chance = GetBonus(%shooterClient,$BPBlockBonus);	
			%chance = 0;
			%block = floor(getRandom() * 100 + 1);
			if (%block <= %chance) {
				%isBlock = True;
				%value = 0;
			}
		}

		//------------- DETERMINE CRITICAL -------------
		%isCrit = False;
		if(%preCalcMiss == "" && %isMiss != True && %isBlock != True && %shooterClient != %damagedClient)
		{
			//%chance = GetBonus(%shooterClient,$BPCriticalBonus);
			%chance = 3;
			%crit = floor(getRandom() * 100 + 1);
			if (%crit <= %chance) {
				%isCrit = True;
				%add = getRandom() * 1 + 2.5;
				%value *= getRandom() * 1 + 2.5;
			}
		}

		//=======================================|WATER CHECKS|=========================================
		//------------------------------------
		// CHECK IF PLAYER LANDED ON WATER
		//------------------------------------
		if(%damagedClient == %shooterClient && %type == $LandingDamageType)
		{
			%object = "";
			for(%i = 0; %i >= -3.15; %i -= 1.57)
			{
				if(GameBase::getLOSInfo(Client::getOwnedObject(%damagedClient), 5, %i @ " 0 0"))
				{
					if(getObjectType($los::object) == "InteriorShape" && String::getSubStr(Object::getName($los::object), 0, 5) == "water")
					{
						%object = $los::object;
						break;
					}
				}
			}
			
			if(%object != "")
			{
				%value *= $waterDamageAmp;
				playSound(SoundSplash1, %damagedClientPos);
			}
		}

		//---------------------------------------
		// CHECK IF PLAYER LANDED WHILE IN WATER
		//---------------------------------------
		if(%damagedClient == %shooterClient && %type == $LandingDamageType)
		{
			if(Zone::getType(fetchData(%damagedClient, "zone")) == "WATER")
				%value *= $waterDamageAmp;
		}
		//============================================================================================

		//-------------------------------------------------
		// IF PLAYER IS ADMIN, NULLIFY LANDING DAMAGE
		// IF PLAYER IS SUPERADMIN, NULLIFY ALL DAMAGE
		//-------------------------------------------------
		//if(%damagedClient.adminLevel >= 4 && %type == $LandingDamageType)
		//	%value = 0;
		//if(%damagedClient.adminLevel >= 5)
		//	%value = 0;

		
		//===================================================
		// LADDER & FACTION BATTLE
		if (IsLadderPlayer(%shooterClient) != IsLadderPlayer(%damagedClient))
			if (!IsAiControlled(%damagedClient)) 
				%value = 0;
		if (GetPlayerFaction(%shooterClient) == GetPlayerFaction(%damagedClient)) {
			if ($Battling[%shooterClient] == 1 || $Battling[%damagedClient] == 1) {
				%value = 0;
			}
		}
		//===================================================


		//------------------------------------------------
		// SAME TEAM CHECKS
		//------------------------------------------------
		if(Client::getTeam(%damagedClient) == Client::getTeam(%shooterClient) && %shooterClient != %damagedClient)
		{
			if(!HasTheftFlag(%damagedClient))
			{
				if(Zone::getType(fetchData(%damagedClient, "zone")) == "PROTECTED" && Zone::getType(fetchData(%shooterClient, "zone")) != "PROTECTED")
				{
					//echo("guy inside gets hit by guy outside, or vice-versa, no damage");
					%value = 0;
					%isMiss = False;
					%noImpulse = True;
					%sameTeamNull = True;
				}
				else if(Zone::getType(fetchData(%damagedClient, "zone")) != "PROTECTED" && Zone::getType(fetchData(%shooterClient, "zone")) != "PROTECTED")
				{
					//echo("both guys outside, do damage");
				}
				else if(Zone::getType(fetchData(%damagedClient, "zone")) == "PROTECTED" && Zone::getType(fetchData(%shooterClient, "zone")) == "PROTECTED" && %shooterClient != %damagedClient)
				{
					//echo("both inside, so no damage");
					%value = 0;
					%isMiss = False;
					%noImpulse = True;
					%sameTeamNull = True;
				}

				//not in the same house
				if(!(IsInCommaList(fetchData(%damagedClient, "targetlist"), Client::getName(%shooterClient)) || IsInCommaList(fetchData(%shooterClient, "targetlist"), Client::getName(%damagedClient))) )
				{
					//no target-list involved
		
					%dhn = GetHouseNumber(fetchData(%damagedClient, "MyHouse"));
					%shn = GetHouseNumber(fetchData(%shooterClient, "MyHouse"));
					if(%dhn == %shn)
					{
						%value = 0;
						%isMiss = False;
						%noImpulse = True;
						%sameTeamNull = True;
					}
					else
					{
						if(%dhn == "" || %shn == "")
						{
							//one of the people involved is not in a house, so no damage occurs
							%value = 0;
							%isMiss = False;
							%noImpulse = True;
							%sameTeamNull = True;
						}
					}
				}
				else
				{
					//one of the people involved has the other one on his/her target-list.
					//so let damage go thru
				}
	
				//AI same team check
				//if(Player::isAiControlled(%damagedClient))
				//{
				//	%value = 0;
				//	%isMiss = False;
				//	%noImpulse = True;
				//}
			}
		}
		//-------------------------------------------------
		// SAME PLAYER CHECKS
		//-------------------------------------------------
		if(%damagedClient == %shooterClient)
		{
			if(%type == $SpellDamageType)
				%value = %value / 3;
		}

		//-------------------------------------------------
		//
		//	ACTION / SPELL BREAK CHECK
		//
		//-------------------------------------------------
		if (%value > 0 && !%isMiss) {
			CheckBreakSpellDamage(%damagedClient);
			//CheckBreakActionDamage(%damagedClient);
		}

		//-------------------------------------------------
		// ARENA DAMAGE CHECKS
		//-------------------------------------------------
		if(IsStillArenaFighting(%damagedClient) != IsStillArenaFighting(%shooterClient))
		{
			%value = 0;						//example: spectator shooting in arena
			%arenaNull = True;
		}
		if(IsInRoster(%damagedClient) != IsInRoster(%shooterClient))
		{
			%value = 0;						//example: roster shooting in arena
			%arenaNull = True;
		}
		if(IsInRoster(%damagedClient))
		{
			%value = 0;						//example: arena shooting in roster
			%arenaNull = True;
		}

		if(!IsDead(%this))
		{
			%armor = Player::getArmor(%this);
			storeData(%damagedClient, "tmpkillerid", %shooterClient);

			%hitby = Client::getName(%shooterClient);
			%msgcolor = "";

			if(%isMiss)
			{
				%msgcolor = $MsgRed;
				%value = 0;
			}

			if (%isBlock)
			{
				%msgcolor = 3;
				%value = 0;
			}
			
			else if(!%isMiss && %value == 0 && %shooterClient != %damagedClient)
			{
				%msgcolor = $MsgWhite;
			}

			if(%msgcolor != "")
			{
				if(%type != $SpellDamageType)
				{

					Client::sendMessage(%shooterClient, 0, "You try to hit " @ Client::getName(%damagedClient) @ ", but miss!");

					%time = getIntegerTime(true) >> 5;
					if(%time - %damagedClient.lastMissMessage > 2)
					{
						%damagedClient.lastMissMessage = %time;
						if (%isBlock == True)
							Client::sendMessage(%damagedClient, %msgcolor, "Your shield blocked an attack from " @ %hitby @ "!");
						else
							Client::sendMessage(%damagedClient, %msgcolor, %hitby @ " tries to hit you, but misses!");
					}
				}
				else
				{
					Client::sendMessage(%shooterClient, %msgcolor, Client::getName(%damagedClient) @ " resists your spell!");
					Client::sendMessage(%damagedClient, %msgcolor, "You resist " @ %hitby @ "'s spell!");
				}
			}

			//-------------------------------------------------
			// SKILLS
			//-------------------------------------------------
			if(%skilltype >= 1 && !%arenaNull && !%sameTeamNull && %shooterClient != %damagedClient)
			{
				%base1 = Cap(35 + (fetchData(%shooterClient, "LVL") - fetchData(%damagedClient, "LVL")), 1, "inf");
				%base2 = Cap(35 + (fetchData(%damagedClient, "LVL") - fetchData(%shooterClient, "LVL")), 1, "inf");
				if(%isMiss)
				{
					UseSkill(%shooterClient, %skilltype, False, True);
					UseSkill(%damagedClient, $SkillEndurance, True, True, 60);
					if(%type == $SpellDamageType)
						UseSkill(%damagedClient, $SkillSpellResistance, True, True, %base2);
					else
						UseSkill(%damagedClient, $SkillDodging, True, True, %base2 * (3/5));
				}
				else if(!%isMiss && %value == 0)
				{
					UseSkill(%shooterClient, %skilltype, False, True);
					UseSkill(%damagedClient, $SkillEndurance, True, True, 60);
					if(%type == $SpellDamageType)
						UseSkill(%damagedClient, $SkillSpellResistance, True, True, %base2);
					else
						UseSkill(%damagedClient, $SkillDodging, True, True, %base2 * (3/5));
				}
				else
				{
					UseSkill(%shooterClient, %skilltype, True, True, %base1);
					if(%type == $SpellDamageType)
						UseSkill(%damagedClient, $SkillSpellResistance, True, True, %base2);
				}

				if(%Backstab)
					UseSkill(%shooterClient, $SkillBackstabbing, True, True);
				if(%Bash)
					UseSkill(%shooterClient, $SkillBashing, True, True);
			}

			if(%value)
			{
				if(%value < 0)
					%value = 0;
				%backupValue = %value;

				%rhp = refreshHP(%damagedClient, %value);

				if(%rhp == -1)
					%value = -1;	//There was an LCK miss
				else
				{
					if(!%noImpulse) Player::applyImpulse(%this,%mom);
					%noImpulse = "";

					if(%damagedCurrentArmor != "")
						%ahs = $ArmorHitSound[%damagedCurrentArmor];
					else
						%ahs = SoundHitFlesh;
					if(%skilltype == $SkillSlashing)
						PlaySound(%ahs, %damagedClientPos);
					else if(%skilltype == $SkillBludgeoning)
						PlaySound(%ahs, %damagedClientPos);
					else if(%skilltype == $SkillPiercing)
						PlaySound(%ahs, %damagedClientPos);
					else if(%skilltype == $SkillArchery)
						PlaySound(SoundArrowHit2, %damagedClientPos);
				}

				if(Player::isAiControlled(%damagedClient) && fetchData(%damagedClient, "SpawnBotInfo") != "")
				{
					if(!IsDead(%damagedClient))
					{
						if(AI::getTarget(fetchData(%damagedClient, "BotInfoAiName")) != %shooterClient)
							AI::SelectMovement(fetchData(%damagedClient, "BotInfoAiName"));
					}

					PlaySound(RandomRaceSound(fetchData(%damagedClient, "RACE"), Hit), %damagedClientPos);
				}

				//display amount of damage caused
				%convValue = round(%value * $TribesDamageToNumericDamage);

				if(%convValue > 0)
				{
					if(%shooterClient == %damagedClient)
					{
						if(%type == $CrushDamageType)
							%hitby = "moving object";
						else if(%type == $DebrisDamageType)
							%hitby = "debris";
						else
							%hitby = "yourself";
					}
					else if(%shooterClient == 0)
						%hitby = "an NPC";
					else
					{
						if(fetchData(%shooterClient, "invisible"))
							%hitby = "an unknown assailant";
						else
							%hitby = Client::getName(%shooterClient);
					}

					if(%Backstab)
					{
						%daction = "backstabbed";
						%saction = "backstabbed";
					}
					else if(%Bash)
					{
						%daction = "bashed";
						%saction = "bashed";
					}
					else
					{
						%daction = "damaged";
						%saction = "damaged";
					}

					//--------------------
					//display to involved
					//--------------------
					if(%shooterClient != %damagedClient) {
						if (%isCrit == False)
							Client::sendMessage(%shooterClient, 0, "You " @ %saction @ " " @ Client::getName(%damagedClient) @ " for " @ %convValue @ " points of damage!");
						else
							Client::sendMessage(%shooterClient, 0, "You " @ %saction @ " " @ Client::getName(%damagedClient) @ " for " @ %convValue @ " points of damage! Critical Hit!");
					}
					if (%isCrit)
						Client::sendMessage(%damagedClient, $MsgRed, "You were " @ %daction @ " by " @ %hitby @ " for " @ %convValue @ " points of damage! Critical Hit!");
					else
						Client::sendMessage(%damagedClient, $MsgRed, "You were " @ %daction @ " by " @ %hitby @ " for " @ %convValue @ " points of damage!");

					//--------------------
					//display to radius
					//--------------------
					if(%shooterClient == 0)
					{
						%sname = "An NPC";
						%dname = Client::getName(%damagedClient);
					}
					else if(%shooterClient == %damagedClient)
					{
						%sname = Client::getName(%shooterClient);
						if(String::ICompare(Client::getGender(%damagedClient), "Male") == 0)
							%dname = "himself";
						else if(String::ICompare(Client::getGender(%damagedClient), "Female") == 0)
							%dname = "herself";
						else
							%dname = "itself";
					}
					else
					{
						if(fetchData(%shooterClient, "invisible"))
							%sname = "An unknown assailant";
						else
							%sname = Client::getName(%shooterClient);
						%dname = Client::getName(%damagedClient);
					}

					radiusAllExcept(%damagedClient, %shooterClient, %sname @ " hits " @ %dname @ " for " @ %convValue @ " points of damage!");
				}
				else if(%convValue < 0)
				{
					//this happens when there's a LCK consequence as miss

					%hitby = Client::getName(%shooterClient);

					Client::sendMessage(%shooterClient, $MsgRed, "You try to hit " @ Client::getName(%damagedClient) @ ", but miss! (LCK)");
					Client::sendMessage(%damagedClient, $MsgRed, %hitby @ " tries to hit you, but misses! (LCK)");
				}

				//====================================================================
				//-------------------------------------------
				//add entry to damagedClient's damagedBy list
				//-------------------------------------------

				%newmaxdamage = 32;

				echo("Shooter Client: " @ %shooterClient);

				

				if (%shooterClient != 0 && !isMiss) {
					if (%shooterClient == 0)
						%sname = "NPC";
					else {
						if (Player::IsAiControlled(%shooterClient)) {
							if ($CruAI[%shooterClient,$AiOwner] != "") {
								%sname = Client::GetName($CruAI[%shooterClient,$AiOwner]);
							}
						}
						else {
							%sname = Client::GetName(%shooterClient);
						}
					}
					if ((%dteam = PlayerIsInTeam(%shooterClient)) != -1)
						%sname = %dteam;
					%dname = Client::getName(%damagedClient);
					%damagefound = -1;
					%emptyfound = -1;
					for (%i = 1; %i <= %newmaxdamage; %i++) {
						%name = getWord($damagedBy[%dname,%i],0);
						if (%name == %sname)
							%damagefound = %i;
						if (%name == -1) {
							if (%emptyfound == -1)
								%emptyfound = %i;
						}
					}
					if (%damagefound != -1) {
						%dval = getWord($damagedBy[%dname,%damagefound],1);
						$damagedBy[%dname,%damagefound] = %sname @ " " @ (%dval + %backupValue);
					}
					else if (%damagefound == -1 && %emptyfound != -1) {
						$damagedBy[%dname,%emptyfound] = %sname @ " " @ %backupValue;
					}
					else {
						echo("No more room on the damage list.");
					}
				}

				//====================================================================

				%flash = Player::getDamageFlash(%this) + %value * 2;
				if(%flash > 0.75)
					%flash = 0.75;
				Player::setDamageFlash(%this,%flash);

				//slow the player down for a bit
				//if(!Player::isAiControlled(%damagedClient))
				//{
				//	storeData(%damagedClient, "SlowdownHitFlag", True);
				//	RefreshWeight(%damagedClient);
				//	schedule("storeData(" @ %damagedClient @ ", \"SlowdownHitFlag\", False);", $SlowdownHitDelay);
				//	schedule("RefreshWeight(" @ %damagedClient @ ");", $SlowdownHitDelay, Client::getOwnedObject(%damagedClient));
				//}

				//If player not dead then play a random hurt sound
				if(!Player::IsDead(%this))
				{
					if(%damagedClient.lastDamage < getSimTime())
					{
						%sound = radnomItems(3,injure1,injure2,injure3);
						playVoice(%damagedClient,%sound);
						%damagedClient.lastdamage = getSimTime() + 1.5;
					}
				}
				else		//player died
				{
					if(Player::isAiControlled(%shooterClient))
					{
						RemotePlayAnim(%shooterClient, 8);
						PlaySound(RandomRaceSound(fetchData(%shooterClient, "RACE"), Taunt), %shooterClientPos);
					}

					if( Player::isCrouching(%this) )
						%curDie = $PlayerAnim::Crouching;
					else
						%curDie = radnomItems(3, $PlayerAnim::DieLeftSide, $PlayerAnim::DieChest, $PlayerAnim::DieForwardKneel);

					Player::setAnimation(%this, %curDie);

					if(%type == $ImpactDamageType && %object.clLastMount != "")
						%shooterClient = %object.clLastMount;

					Client::onKilled(%damagedClient, %shooterClient, %type);

					if ($CruAI[%shooterClient,$AiTargetGet] != "") {
						%o = $CruAi[%shooterClient,$AiOwner];
						CruAiSetMode(%o,"follow");
					}
					
				}
			}

			if(%isMiss)
			{
				if(fetchData(%damagedClient, "isBonused"))
				{
					GameBase::activateShield(%this, "0 0 1.57", 1.47);
					PlaySound(SoundHitShield, %damagedClientPos);
				}
			}
		}
	}










PassiveCreate("Brute","CRITDAMAGE 80",1,30,"O"); 
PassiveCreate("Puncture","CRITCHANCE 25",1,25,"O");
PassiveCreate("Bloodlust","LIFESTEAL 10",1,20,"O");
PassiveCreate("Onslaught","ADDALLOFF 200",0,30,"O");
PassiveCreate("Careful","ADDALLDEF 100",0,30,"D");
PassiveCreate("Manawell","MAXMANA 2000",0,30,"N");
PassiveCreate("Lifeblood","MAXHP 2000",0,30,"N");
PassiveCreate("Acuity","ARMORPEN 1500",0,30,"O");
PassiveCreate("Void","MAGICPEN 1500",0,30,"M");
PassiveCreate("Iron Skin","ARMOR 2000",0,30,"D");
PassiveCreate("Heavy Armor","MELEEAC 2000 PROJAC 2000",0,30,"D");
PassiveCreate("Elemental Armor","POISONAC 2000 FIREAC 2000 COLDAC 2000 ENERGYAC 2000",0,30,"D");
PassiveCreate("Diamond Skin","ALLRESIST 2000",0,30,"D");
PassiveCreate("Heavy Refusal","MELEERES 2000 PROJRES 2000",0,30,"D");
PassiveCreate("Elemental Refusal","FIRERES 2000 COLDRES 2000 ENERGYRES 2000 POISONRES 2000",0,30,"D");
PassiveCreate("Learning","ADDEXP 40",1,30,"N");
PassiveCreate("Luck","GOLDFIND 100",1,30,"N");
PassiveCreate("Treasure Hunter","MAGICFIND 100",1,30,"N");
PassiveCreate("Lifting","MAXWEIGHT 2000",0,30,"N");
PassiveCreate("Regeneration","HEALDELTA 300",0,30,"N");
PassiveCreate("Energetic","MANADELTA 300",0,30,"M");
PassiveCreate("Thornmail","REFLECT 10",1,20,"D");
PassiveCreate("Effecient","MANACOST 10",0,20,"M");
PassiveCreate("Savage","ADDDAMAGE 200",0,30,"O");
PassiveCreate("Archwizard","MAGICDAMAGE 150",1,30,"M");
PassiveCreate("Master Of Arms","PHYSICALDAMAGE 200",1,30,"O");
PassiveCreate("Swordsman","SLASHING 230 CLEAVE 230 ADDDAMAGE 50 SLASHINGDAMAGE 100",0,30,"O");
PassiveCreate("Lancer","PIERCING 230 PIERCINGDAMAGE 100",0,30,"O");
PassiveCreate("Warhammer","BLUDGEONING 230 BASHING 230 BLUDGEDAMAGE 100",0,30,"O");
PassiveCreate("Sidestep","DODGING 230 ADDALLDEF 50",0,30,"D");
PassiveCreate("Caravan","WEIGHTCAPACITY 230 MAXWEIGHT 100",0,30,"N");
PassiveCreate("Thief","STEALING 230 HIDING 230 BACKSTABBING 230",0,30,"O");
PassiveCreate("Repulsing","SPELLRESISTANCE 230 ALLRESIST 100",0,30,"D");
PassiveCreate("Survivalist","HEALING 230 HEALDELTA 30 ENDURANCE 230",0,30,"D");
PassiveCreate("Archer","ARCHERY 230 AIMING 230 ARCHERYDAMAGE 100",0,30,"O");
PassiveCreate("Samurai","MARTIALARTS 230 ADDALLDEF 30 ADDALLOFF 30",0,30,"O");
PassiveCreate("Prospector","MINING 230",0,30,"N");
PassiveCreate("Knowledge","LITERACY 230 SPEECH 230",0,30,"N");
PassiveCreate("Tracker","SENSEHEADING 230",0,30,"N");
PassiveCreate("Spirited","ENERGY 230 MANADELTA 30",0,30,"M");
PassiveCreate("Merchant","HAGGLING 230",0,30,"N");
PassiveCreate("Warrior","STRENGTH 575 STAMINA 575",0,30,"N");
PassiveCreate("Rogue","AGILITY 230 SENSE 230",0,30,"N");
PassiveCreate("Mage","INTELLIGENCE 230 PSYCHIC 230",0,30,"N");
PassiveCreate("Blacksmith","SMITHING 230 SMITHREQ 25",0,30,"N");
PassiveCreate("Workmanship","MAGICCRAFT 230 MAGICCRAFTREQ 25",0,30,"N");
PassiveCreate("Alchemist","ALCHEMY 230 ALCHEMYREQ 25",0,30,"N");
PassiveCreate("Wise","WISDOM 230",0,30,"M");
PassiveCreate("Heavy Weapons","WEAPONHANDLING 230",0,30,"O");
PassiveCreate("Quickstep","EVADEMELEE 230 ADDALLOFF 30",0,30,"D");
PassiveCreate("Fighter","BRAWLING 230 MINDAMAGE 50 MAXDAMAGE 200",0,30,"O");
PassiveCreate("Voodoo","SPELLCAPACITY 230",0,30,"M");
PassiveCreate("Redguard","BLOCKHIT% 10",0,30,"D");
PassiveCreate("Whiteguard","BLOCKSPELL% 10",0,30,"D");
PassiveCreate("Massive","HEALTH% 100",1,30,"N");
PassiveCreate("Overpower","MANA% 100",1,30,"M");
PassiveCreate("Prayer","DAMAGEDEMON 30 DEMONPROT 10",1,30,"O");
PassiveCreate("Living","DAMAGEUNDEAD 30 UNDEADPROT 10",1,30,"O");
PassiveCreate("Hunter","DAMAGEBEAST 30 BEASTPROT 10",1,30,"O");
PassiveCreate("Mana Meshing","MANAHEALTH 10",1,20,"M");
PassiveCreate("Health Meshing","HEALTHMANA 10",1,20,"M");
PassiveCreate("Necromancer","MINIONHEALTH 100 MINIONDAMAGE 100",1,30,"M");
PassiveCreate("Thinker","MAXMEMORY 100",0,30,"M");
PassiveCreate("Devistator","PROJDAMAGE% 10 MELEEDAMAGE% 10",1,20,"O");
PassiveCreate("Mayhem","FIREDAMAGE% 10 COLDDAMAGE% 10 ENERGYDAMAGE% 10",1,20,"O");
PassiveCreate("Snakemaster","POISONDAMAGE% 15",1,20,"O");
PassiveCreate("Heavy Skull","AVOIDSTUN 20",1,20,"D");
PassiveCreate("Uprooting","AVOIDROOT 20",1,20,"D");
PassiveCreate("Thick Coat","AVOIDCHILL 20",1,20,"D");
PassiveCreate("Liquid","AVOIDBURN 20",1,20,"D");
PassiveCreate("Antiviral","AVOIDPOISON 20",1,20,"D");
PassiveCreate("Grounded","AVOIDSHOCK 20",1,20,"D");
PassiveCreate("Missing","AVOIDCRIT 20",1,20,"D");
PassiveCreate("Reach","WEAPONRANGE 50",1,30,"O");
PassiveCreate("Flux","CASTRANGE 50",1,30,"M");
PassiveCreate("Doctor","HEALING% 30",1,30,"N");
PassiveCreate("Heavy Hitter","INCSTUN 10",1,30,"O");
PassiveCreate("Dirt","INCROOT 10",1,20,"O");
PassiveCreate("Frostbite","INCCHILL 10 COLDDAMAGE% 5",1,20,"O");
PassiveCreate("Explosive","INCBURN 10 FIREDAMAGE% 5",1,20,"O");
PassiveCreate("Venomious","INCPOISON 10 POISONDAMAGE% 5",1,20,"O");
PassiveCreate("Electric","INCSHOCK 10 ENERGYDAMAGE% 5",1,20,"O");
PassiveCreate("Bowman","RANGEDDAMAGE 100",1,30,"O");
PassiveCreate("Duelist","MELEEDAMAGE 100",1,30,"O");
PassiveCreate("Arcane","STAFFMAGIC 100",1,30,"M");
PassiveCreate("Mystic","WANDMAGIC 100",1,30,"M");
PassiveCreate("Hostile","BERSERK 100",1,30,"O");
PassiveCreate("Elixir","HEALTHPOTION 40 MANAPOTION 40",1,30,"N");
PassiveCreate("Vision","PERCEPTION 1000",0,30,"N");
PassiveCreate("Fencing","RIPOSTE 1000",0,30,"D");
PassiveCreate("Surgeon","BANDAGE 3000",0,30,"N");
PassiveCreate("Safeguard","INCARMOR 100",1,30,"D");
PassiveCreate("Rejection","INCRESIST 100",1,30,"D");
PassiveCreate("Avoidance","INCEVASION 100",1,30,"D");
PassiveCreate("Woodsman","FORESTDAMAGE 15 FORESTPROT 15",1,15,"N");
PassiveCreate("Nomad","DESERTDAMAGE 15 DESERTPROT 15",1,15,"N");
PassiveCreate("Tribesman","JUNGLEDAMAGE 15 JUNGLEPROT 15",1,15,"N");
PassiveCreate("Vagabond","SNOWDAMAGE 15 SNOWPROT 15",1,15,"N");
PassiveCreate("Wanderer","LAVADAMAGE 15 LAVAPROT 15",1,15,"N");
PassiveCreate("Transient","ARCANEDAMAGE 15 ARCANCEPROT 15",1,15,"N");
PassiveCreate("Ignore","SPELLINTURUPT 50",1,20,"M");
PassiveCreate("Blackguard","SHIELDBONUS 30",1,30,"D");

// ###################################################################
// SPELL PASSIVES
PassiveCreate("Primalistic","PRIMALMAGIC 230",0,30,"M");
PassiveCreate("Divine","HOLYMAGIC 230",0,30,"M");
PassiveCreate("Empowered","EMPOWERMENT 230",0,30,"M");
PassiveCreate("Blackend","DARKMAGIC 230",0,30,"M");
PassiveCreate("Lightbringer","LIGHTMAGIC 230",0,30,"M");
PassiveCreate("Ritualistic","RITUAL 230",0,30,"M");
PassiveCreate("All Seeing Orb","SORCERY 230",0,30,"M");
PassiveCreate("Protective","PROTECTION 230",0,30,"M");
PassiveCreate("Encharmed","ENCHANTMENT 230",0,30,"M");


			for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
				%target = -1;
				if (%hostle == 1)
					%target = GetActionLosTarget(%id,"",%cl,%action);
				else
					%target = %target = GetActionLosTarget(%id,True,%cl,%action);
				if (%target != -1) {
					if (%hostle == 1) {
						if (SuccessHitAction(%id,%target,%action) == True) {
							Client::SendMessage(%id,2,"You successfully perform " @ $CruAction[%action,$CAName] @ " on " @ Client::GetName(%target) @ "!");
							ActionBonus(%target,%action,1,%id);
							SetupRunningAction(%target,%action);
						}
						else 
							Client::SendMessage(%id,2,Client::GetName(%target) @ " evaded your " @ $CruAction[%action,$CAName] @ ".");
					}
					else {
						Client::SendMessage(%id,2,"You successfully perform " @ $CruAction[%action,$CAName] @ " on " @ Client::GetName(%target) @ "!");
						ActionBonus(%target,%action,1,%id);
						SetupRunningAction(%target,%action);
					}
					%lockaction = 1;
				}
			}

function Action::PlayersAreHostle(%id,%target)
{
	%hostile = True;
	if (Client::getTeam(%id) == Client::getTeam(%target) && %id != %target) {
		if (!HasTheftFlag(%target)) {
			if (Zone::getType(fetchData(%target, "zone")) == "PROTECTED" && Zone::getType(fetchData(%id, "zone")) != "PROTECTED")
				return False;
			if (Zone::getType(fetchData(%id, "zone")) == "PROTECTED" && Zone::getType(fetchData(%target, "zone")) != "PROTECTED")
				return False;
			else if (Zone::getType(fetchData(%damagedClient, "zone")) == "PROTECTED" && Zone::getType(fetchData(%id, "zone")) == "PROTECTED" && %id != %target)
				return False;
			if (!(IsInCommaList(fetchData(%target, "targetlist"), Client::getName(%id)) || IsInCommaList(fetchData(%id, "targetlist"), Client::getName(%target)))) {
				%dhn = GetHouseNumber(fetchData(%target, "MyHouse"));
				%shn = GetHouseNumber(fetchData(%id, "MyHouse"));
				if(%dhn == %shn)
					return False;
				else {
					if (%dhn == "" || %shn == "")
						return False;
				}
			}
		}
	}
	return %hostile;
}









function Player::onKilled(%this)
{
	dbecho($dbechoMode, "Player::onKilled(" @ %this @ ")");

	echo(" PLAYER KILLED " @ %this);

	%this.NoLadderPickup = 0;

	//At this point, the client can still be queried for getItemCounts, and is also still an object
	//Player::Kill calls this function

	%clientId = Player::getClient(%this);
	%killerId = fetchData(%clientId, "tmpkillerid");
	storeData(%clientId, "tmpkillerid", "");

	//revert
	Client::setControlObject(%clientId.possessId, %clientId.possessId);
	Client::setControlObject(%clientId, %clientId);
	storeData(%clientId.possessId, "dumbAIflag", "");
	$possessedBy[%clientId.possessId] = "";

	if(IsStillArenaFighting(%clientId))
	{
		//player's dueling flag is still at ALIVE, make him DEAD

		%a = GetArenaDuelerIndex(%clientId);
		$ArenaDueler[%a] = GetWord($ArenaDueler[%a], 0) @ " DEAD";

		if(!Player::IsAiControlled(%clientId))
			%clientId.RespawnMeInArena = True;
	}
	else if(IsInRoster(%clientId))
	{
		//player was in the waiting room
		//the only way someone could have died in there is if a player was added
		//to the roster, and an AI was killed to make way for this player.
		//so don't drop lootbag

		if(Player::isAiControlled(%clientId)) //if it was an AI, remove him right away, the same AI never spawns back
			RemoveFromRoster(%clientId);
	}
	else if(fetchData(%clientId, "noDropLootbagFlag"))
	{
		//do nothing
	}
	else
	{
		//player died when not dueling

		//drop lootbag
		%tmploot = "";

		if(fetchData(%clientId, "COINS") > 0)
			%tmploot = %tmploot @ "COINS " @ floor(fetchData(%clientId, "COINS")) @ " ";
		storeData(%clientId, "COINS", 0);

		%max = getNumItems();
		for (%i = 0; %i < %max; %i++)
		{
			%a = getItemData(%i);
			%itemcount = Player::getItemCount(%clientId, %a);

			if(%itemcount)
			{
				%flag = False;

				if(fetchData(%clientId, "LCK") >= 0)
				{
					//currently mounted weapon and all equipped stuff + lore items are thrown into lootbag.
					if(Player::getMountedItem(%clientId, $WeaponSlot) == %a || %a.className == "Equipped" || $LoreItem[%a] == True)
						%flag = True;
				}
				else
					%flag = True;

				if(fetchData(%clientId, "LCK") < 0 && Player::isAiControlled(%clientId))
					%flag = True;

				if(%a == CastingBlade)
					%flag = False;		//HARDCODED because we DONT want any players to have this item.
				
				if($StealProtectedItem[%a])
					%flag = False;

				if(%flag)
				{
					%b = %a;
					if(%b.className == "Equipped")
						%b = String::getSubStr(%b, 0, String::len(%b)-1);

					if(Player::getMountedItem(%clientId, $WeaponSlot) == %a)
					{
						//special handling for currently held weapon
						%tmploot = %tmploot @ %b @ " 1 ";
						Player::decItemCount(%clientId, %a);
					}
					else
					{
						%tmploot = %tmploot @ %b @ " " @ Player::getItemCount(%clientId, %a) @ " ";
						Player::setItemCount(%clientId, %a, 0);
					}
				}
			}
		}

		if (Player::isAiControlled(%clientId)) {
			echo(" PLAYERBACKPACK " @ $PlayerBackpack[%clientId]);
			%tmploot = %tmploot @ " " @ $PlayerBackpack[%clientId];
			$PlayerBackpack[%clientId] = "";
			clearallbonuses(%clientId);
		}

		if(%tmploot != "")
		{
			if(Player::isAiControlled(%clientId))
				TossLootbag(%clientId, %tmploot, 1, "*", 300);
			else
			{
				%namelist = Client::getName(%clientId) @ ",";
				if(fetchData(%clientId, "LCK") >= 0)
				{
					TossLootbag(%clientId, %tmploot, 5, %namelist, Cap(fetchData(%clientId, "LVL") * 300, 300, 3600));
				}
				else
					TossLootbag(%clientId, %tmploot, 5, %namelist, Cap(fetchData(%clientId, "LVL") * 0.2, 5, "inf"));
			}
		}

		updateSpawnStuff(%clientId);

		//house stuff
		%victimH = fetchData(%clientId, "MyHouse");
		%killerH = fetchData(%killerId, "MyHouse");
		%vhn = GetHouseNumber(%victimH);
		%khn = GetHouseNumber(%killerH);
		if(%vhn != "")
		{
			//a house member is killed

			if(fetchData(%clientId, "LCK") < 0)
			{
				//this house member had no LCK at time of death

				if(fetchData(%clientId, "RankPoints") <= 0)
				{
					//no LCK and no Rank Points! you're booted!
					BootFromCurrentHouse(%clientId, True);
				}
				else
					Client::sendMessage(%clientId, $MsgRed, "You have lost all your Rank Points because you died with 0 LCK!");

				storeData(%clientId, "RankPoints", 0);
			}

			//victim loses two rank points
			Client::sendMessage(%clientId, $MsgWhite, "You lost 2 Rank Points.");
			storeData(%clientId, "RankPoints", 2, "dec");

			if(%khn != "")
			{
				if(%khn != %vhn)
				{
					//both contenders are in a house, different from each other
					Client::sendMessage(%killerId, $MsgWhite, "You gained 1 Rank Point!");
					storeData(%killerId, "RankPoints", 1, "inc");
					SideBonus(%killerId,$RankBonus,1,0,1);
				}
				else
				{
					//both contenders are in the same house, happens if one target-lists the other.
					Client::sendMessage(%killerId, $MsgWhite, "You lost 1 Rank Point.");
					storeData(%killerId, "RankPoints", 1, "dec");
				}
			}
		}
		else if(%vhn == "" && %khn != "")
		{
			//a house member killed a non-house member. no bonuses or punishments
		}

		//CLEAR!!!!
		if(!IsInArenaDueler(%clientId) && !Player::isAiControlled(%clientId) && fetchData(%clientId, "LCK") < 0)
		{
			//HARDCORE player reset (must turn on $hardcore switch)
			if($hardcore)
			{
				if(fetchData(%clientId, "LVL") > 8 && fetchData(%clientId, "RemortStep") > 0)
				{
					if(!Player::isAiControlled(%killerId))
						ResetPlayer(%clientId);
				}
			}

			storeData(%clientId, "zone", "");	//so the player spawns back at start points
		}
	}

	if(fetchData(%clientId, "deathmsg") != "")
	{
		%kitem = Player::getMountedItem(%killerId, $WeaponSlot);
		%msg = nsprintf(fetchData(%clientId, "deathmsg"), Client::getName(%killerId), Client::getName(%clientId), %kitem.description);
		remoteSay(%clientId, 0, %msg);
	}

	if(Player::isAiControlled(%clientId))
	{
		//event stuff
		%i = GetEventCommandIndex(%clientId, "onkill");
		if(%i != -1)
		{
			%name = GetWord($EventCommand[%clientId, %i], 0);
			%type = GetWord($EventCommand[%clientId, %i], 1);
			%cl = NEWgetClientByName(%name);
			if(%cl == -1)
				%cl = 2048;

			%cmd = String::NEWgetSubStr($EventCommand[%clientId, %i], String::findSubStr($EventCommand[%clientId, %i], ">")+1, 99999);
			%pcmd = ParseBlockData(%cmd, %clientId, %killerid);
			$EventCommand[%clientId, %i] = "";
			schedule("remoteSay(" @ %cl @ ", 0, \"" @ %pcmd @ "\", \"" @ %name @ "\");", 2);
		}
		ClearEvents(%clientId);
	}

	storeData(%clientId, "noDropLootbagFlag", "");

	storeData(%clientId, "SpellCastStep", "");
	%clientId.sleepMode = "";
	refreshHPREGEN(%clientId);
	refreshMANAREGEN(%clientId);

	Client::setControlObject(%clientId, %clientId);
	storeData(%clientId, "dumbAIflag", "");

	//remember the last zone the player was in.
	//storeData(%clientId, "lastzone", fetchData(%clientId, "zone"));
	storeData(%clientId, "lastzone", "");

	PlaySound(RandomRaceSound(fetchData(%clientId, "RACE"), Death), GameBase::getPosition(%clientId));

	//========================================================================================================================

	%clientId.dead = 1;
	if($AutoRespawn > 0)
		schedule("Game::autoRespawn(" @ %clientId @ ");",$AutoRespawn,%clientId);

	Player::setDamageFlash(%this,0.75);

	if(%clientId != -1)
	{
		if(%this.vehicle != "")
		{
			if(%this.driver != "")
			{
				%this.driver = "";
				Client::setControlObject(Player::getClient(%this), %this);
				Player::setMountObject(%this, -1, 0);
			}
			else
			{
				%this.vehicle.Seat[%this.vehicleSlot-2] = "";
			%this.vehicleSlot = "";
			}
			%this.vehicle = "";
		}
		schedule("GameBase::startFadeOut(" @ %this @ ");", $CorpseTimeoutValue, %this);
		Client::setOwnedObject(%clientId, -1);
		Client::setControlObject(%clientId, Client::getObserverCamera(%clientId));
		Observer::setOrbitObject(%clientId, %this, 15, 15, 15);
		schedule("deleteObject(" @ %this @ ");", $CorpseTimeoutValue + 2.5, %this);
		%clientId.observerMode = "dead";
		%clientId.dieTime = getSimTime();
	}
}


function CruSpellAnimation_UNUSED(%clientId,%spell,%manualPos)
{
	if (%manualPos == "")
		%pos = gamebase::GetPosition(%clientId);
	else
		%pos = %manualPos;
	%posx = getWord(%pos,0);
	%posy = getWord(%pos,1);
	%posz = getWord(%pos,2);
	
	%anim = $CruSpell[%spell,$CSAnimation];	

	if (%anim == "ENERGY1") {
		%castpos = %posx @ " " @ %posy @ " " @ (%posz + 1);
		PlaySound("ActivateDE",%pos);
		CruSpellBomb(%clientId,%castpos,"CruSpellBomb1");
	}
	if (%anim == "POWER1") {
		PlaySound("SpellPower1",%pos);
		%castpos = (%posx + 1) @ " " @ %posy @ " " @ (%posz - 0.5);
		CruSpellBomb(%clientId,%castpos,"CruSpellBomb2");
		%castpos = (%posx - 1) @ " " @ %posy @ " " @ (%posz - 0.5);
		CruSpellBomb(%clientId,%castpos,"CruSpellBomb2");
		%castpos = %posx @ " " @ (%posy + 1) @ " " @ (%posz - 0.5);
		CruSpellBomb(%clientId,%castpos,"CruSpellBomb2");
	}
	if (%anim == "GRNNUKE") {
		%castpos = %posx @ " " @ %posy @ " " @ (%posz + 1);
		PlaySound("ActivateDE",%pos);
		CruSpellBomb(%clientId,%castpos,"CruSpellBomb4");
	}
	if (%anim == "BURN") {
		%castpos = %posx @ " " @ %posy @ " " @ (%posz + 1);
		PlaySound("ActivateDE",%pos);
		CruSpellBomb(%clientId,%castpos,"CruSpellBomb5");
	}
	if (%anim == "BLUORB") {
		%castpos = %posx @ " " @ %posy @ " " @ (%posz + 1);
		PlaySound("ActivateDE",%pos);
		CruSpellBomb(%clientId,%castpos,"CruSpellBomb3");
	}
}

$CruSpell[Icicle,$CSName] 		= "Icicle";
$CruSpell[Icicle,$CSCategory] 		= "SORCERY";
$CruSpell[Icicle,$CSMustLearn] 		= 0;
$CruSpell[Icicle,$CSReqs] 		= "Sorcery 5 MANA 10";
$CruSpell[Icicle,$CSHostile] 		= 1;
$CruSpell[Icicle,$CSMode] 		= "LOS";
$CruSpell[Icicle,$CSTree] 		= "Icicle 1";
$CruSpell[Icicle,$CSCastTime] 		= 3;
$CruSpell[Icicle,$CSRecovery] 		= 3;
$CruSpell[Icicle,$CSDur] 		= 0;
$CruSpell[Icicle,$CSHaveReqs] 		= "LVLG 0";
$CruSpell[Icicle,$CSTake] 		= "MANA 10";
$CruSpell[Icicle,$CSBonus] 		= "Damage:Cold 50..150";
$CruSpell[Icicle,$CSInfo] 		= "A shard of ice";
$CruSpell[Icicle,$CSAnimation] 		= "ENERGY1";
$CruSpell[Icicle,$CSOffense] 		= "Sorcery 100";
$CruSpell[Icicle,$CSDefense] 		= "SpellResistance 100";
$CruSpell[Icicle,$CSSC] 		= 0;


//##############################################################################################################################################
// BLUDGEONING
$WEAPONNAMES["Club"] 			= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Quarter Staff"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Bone Club"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Spiked Club"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Mace"] 			= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Hammer Pick"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Spiked Bone Club"] 	= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Long Staff"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["War Hammer"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["Great Staff"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONNAMES["War Maul"] 		= "Old Cracked Chipped Knotted Hardwood Pristene";
$WEAPONVIS["Club"] 			= "Club1 Club1 Club1 Club2 Club2 Club3 Club3";
$WEAPONVIS["Quarter Staff"] 		= "QuarterStaff QuarterStaff QuarterStaff QuarterStaff2 QuarterStaff2 QuarterStaff3 QuarterStaff3";
$WEAPONVIS["Bone Club"] 		= "BoneClub1 BoneClub1 BoneClub1 BoneClub2 BoneClub2 BoneClub3 BoneClub3";
$WEAPONVIS["Spiked Club"] 		= "SpikedClub1 SpikedClub1 SpikedClub1 SpikedClub2 SpikedClub2 SpikedClub3 SpikedClub3";
$WEAPONVIS["Mace"] 			= "Mace Mace Mace Mace2 Mace2 Mace3 Mace3";
$WEAPONVIS["Hammer Pick"] 		= "HammerPick1 HammerPick1 HammerPick1 HammerPick2 HammerPick2 HammerPick3 HammerPick3";
$WEAPONVIS["Spiked Bone Club"] 		= "SpikedBoneClub1 SpikedBoneClub1 SpikedBoneClub1 SpikedBoneClub2 SpikedBoneClub2 SpikedBoneClub3 SpikedBoneClub3";
$WEAPONVIS["Long Staff"] 		= "LongStaff LongStaff LongStaff LongStaff2 LongStaff2 LongStaff3 LongStaff3";
$WEAPONVIS["War Hammer"] 		= "WarHammer WarHammer WarHammer WarHammer2 WarHammer2 WarHammer3 WarHammer3";
$WEAPONVIS["Great Staff"] 		= "GreatStaff1 GreatStaff1 GreatStaff1 GreatStaff2 GreatStaff2 GreatStaff2 GreatStaff2";
$WEAPONVIS["War Maul"] 			= "WarHammer WarHammer WarHammer WarHammer2 WarHammer2 WarHammer3 WarHammer3";
CreateTierWeapons("Club",800,0.1,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_club.bmp",2,0,"",1);
CreateTierWeapons("Quarter Staff",800,0.15,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_quarterstaff.bmp",2,0,"",2);
CreateTierWeapons("Bone Club",800,0.2,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_boneclub.bmp",2,0,"",3);
CreateTierWeapons("Spiked Club",800,0.3,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_spikedclub.bmp",2,0,"",4);
CreateTierWeapons("Mace",800,0.4,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_mace.bmp",2,0,"",5);
CreateTierWeapons("Hammer Pick",800,0.5,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_hammerpick.bmp",2,0,"",6);
CreateTierWeapons("Spiked Bone Club",800,0.6,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_spikedboneclub.bmp",2,0,"",7);
CreateTierWeapons("Long Staff",800,0.7,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_longstaff.bmp",2,0,"",8);
CreateTierWeapons("War Hammer",800,0.8,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_warhammer.bmp",2,0,"",9);
CreateTierWeapons("Great Staff",800,0.9,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_greatstaff.bmp",2,0,"",10);
CreateTierWeapons("War Maul",800,1.0,0.3,"Melee","MAXHP",1500,5,5,"Bludgeoning","WPN","Bludgeoning","EvadeMelee","ico_warmaul.bmp",2,0,"",11);




	// CALC REDUCTION ==================================================
	//%reduction = round(30000 * (fetchData(%target,"LVL") / 230));
	//%reduction = round(50 * (%ac / %reduction));
	//if (%reduction > 50) %reduction = 50;
	//%reduction += (GetBonus(%target,$BPADDALLDEF) / 150);
	//%reduction = round(%value * (%reduction / 100));
	//if (%reduction < 0) %reduction = 0;
	//%value -= %reduction;




// ADDED STRING FUNCTIONS

function String::DelTok(%list,%token,%once) 
{
	%new = "";
	%rem = False;
	for (%i = 0; (%t = getWord(%list,%i)) != -1; %i++) {
		if (String::ICompare(%t,%token) != 0 || %rem == True)
			%new = %new @ %t @ " ";
		if (String::ICompare(%t,%token) == 0) {
			if (%once)
				%rem = True;
		}
	}
	return %new;
}

// MAIN QUEST FUNCTIONS

function HasCruQuest(%id,%quest) 
{
	%current = $PlayerQuests[%id];
	for (%hasqloop = 0; (%q = getWord(%current,%hasqloop)) != -1; %hasqloop++) {
		if (%q == %quest)
			return True;
	}
	return False;
}

function HasCruQuestComplete(%id,%quest)
{
	%complete = $PlayerCruComplete[%id];
	for (%i = 0; (%q = getWord(%complete,%i)) != -1; %i++) {
		if (%q == %quest)
			return True;
	}
	return False;
}


function GetCruQuestPos(%id,%quest)
{
	%current = $PlayerQuests[%id];
	for (%i = 0; (%q = getWord(%current,%i)) != -1; %i++) {
		if (%q == %quest)
			return %i;
	}
	return -1;
}

function GetCruQuestStatus(%id,%quest,%quick)
{
	%status = $PlayerQuestStatus[%id];
	if (%quick == "") {
		if ((%p = GetCruQuestPos(%id,%quest)) != -1) {
			return getWord(%status,%p);
		}
	}
	else {
		return getWord(%status,%quick);
	}
	return False;
}

function AddCruQuest(%id,%quest)
{
	if ((%p = GetCruQuestPos(%id,%quest)) == -1) {
		$PlayerQuests[%id] = $PlayerQuests[%id] @ %quest @ " ";
		$PlayerQuestStatus[%id] = $PlayerQuestStatus[%id] @ "0 ";
		Client::SendMessage(%id,2,"A new entry '" @ GetCQInfo(%quest,NAME) @ "' was added to your quest log. (#quest)");
	}
	else {
		Client::SendMessage(%id,0,"You already have this quest.");
	}
}

function DelCruQuest(%id,%quest)
{
	if ((%p = GetCruQuestPos(%id,%quest)) != -1) {
		%status = $PlayerQuestStatus[%id];
		$PlayerQuestStatus[%id] = String::DelTok(%status,%p);
		%current = $PlayerQuests[%id];
		$PlayerQuests[%id] = String::DelTok(%current,%p);
	}
}

function IncCruQuest(%id,%quest)
{
	if ((%p = GetCruQuestPos(%id,%quest)) != -1) {
		%s = GetCruQuestStatus(%id,%quest,%p);
		%s += 1;
		%done = $CruQuest[%quest,COMPLETE];
		if (%s >= %done) {
			CruQuestComplete(%id,%quest);
			return;
		}
		else {
			%status = $PlayerQuestStatus[%id];
			%new = "";
			for (%i = 0; (%cur = getWord(%status,%i)) != -1; %i++) {
				if (%i == %p)
					%new = %new @ %s @ " ";
				else
					%new = %new @ %cur @ " ";
			}
			$PlayerQuestStatus[%id] = %new;
		}	
	}
	else 
		echo("NOT FOUND");
}

function CruAddCompletedQuest(%id,%quest)
{
	$PlayerCruComplete[%id] = $PlayerCruComplete[%id] @ %quest @ " ";
}

function CruQuestComplete(%id,%quest)
{
	DelCruQuest(%id,%quest);
	CruAddCompletedQuest(%id,%quest);
	Client::SendMessage(%id,3,"You have completed quest '" @ GetCQInfo(%quest,NAME) @ "'");
	PlaySound(SoundCompleteQuest,Gamebase::getPosition(%id));
	%bonus = $CruQuest[%quest,BONUS,DEFAULT];
	if (%bonus != "")
		GiveThisStuff(%id,%bonus,1,1,0);
	else {
		%class = fetchData(%id,"CLASS");
		%b = $CruQuest[%quest,BONUS,%class];
		if (%b != "")
			GiveThisStuff(%id,%b,1,1,0);
	}
	%take = $CruQuest[%quest,TAKE];
	if (%take != "")
		TakeThisStuff(%id,%take,1);
}

function GetCQInfo(%quest,%info)
{
	return $CruQuest[%quest,%info];
}

function InitCruQuests(%id)
{
	$PlayerCruComplete[%id] = "";
	$PlayerQuests[%id] = "";
	$PlayerQuestStatus[%id] = "";
}

function RandomCQDeny()
{
	%r = floor(getRandom() * 5 + 1);
	if (%r == 1)
		return "Hail!";
	else if (%r == 2)
		return "Good day traveller!";
	else if (%r == 3)
		return "I can't be bothered right now!";
	else if (%r == 4)
		return "Hi.";
	else if (%r == 5)
		return "I'm rather busy, Gordon.";
}

function GetCruQuestSlot(%id,%slot)
{
	%cur = $PlayerQuests[%id];
	if ((%q = getWord(%cur,%slot)) != -1)
		return %q;
	else
		return false;
}

function Game::menuQuest(%id,%menu)
{
	%curItem = 0;
	Client::buildMenu(%id, "Quest Log", "options", true);
	for (%i = 1; %i <= 6; %i++) {
		%slot = GetCruQuestSlot(%id,%menu);
		if (%slot != false) {
			Client::addMenuItem(%id, %curItem++ @ GetCQInfo(%slot,NAME),"selquest " @ %menu);
		}
		%menu += 1;
	}
	if (GetCruQuestSlot(%id,%menu) != false)
		Client::addMenuItem(%id,"n Next >>","selbackpacknext " @ %menu);
	//Client::addMenuItem(%id,"p << Prev","selbackpackback " @ %menu);
}

function Game::MenuQuestSelect(%id,%menu)
{
	
}

function ShowCruQuestStatus(%id,%slot)
{
	echo(%slot);
	%quest = $PlayerQuests[%id];
	%status = $PlayerQuestStatus[%id];
	%q = getWord(%quest,%slot);
	%s = getWord(%status,%slot);
	echo(%q @ " " @ %s);
	if (%q != -1 && %s != -1) {
		%msg = "<f1>";
		%msg = %msg @ " Quest - " @ GetCQInfo(%q,NAME) @ ":<n> <n>";
		%msg = %msg @ " Objective: " @ GetCQInfo(%q,INFO) @ "<n> <n>";
		%msg = %msg @ " <f0>Status: " @ %s @ "/" @ GetCQInfo(%q,COMPLETE);
		BottomPrint(%id,%msg,10);
	}
}

//------------------------------------------------------------------------------------------------

// CRU QUESTS

$CruQuest[KILLGOB,NAME] = "Goblin Hunting";
$CruQuest[KILLGOB,CHAT,1] = "Greetings traveller! I need your help!";
$CruQuest[KILLGOB,CHAT,2] = "Will you help me? [yes]";
$CruQuest[KILLGOB,CUE] = "yes";
$CruQuest[KILLGOB,CONFIRM,1] = "Excellent!";
$CruQuest[KILLGOB,CONFIRM,2] = "Travel to the cavern just west of here and kill at least 3 Goblin Runts. Then return to me!";
$CruQuest[KILLGOB,INFO] = "Kill 10 Goblin Runts in the Caverns to the west of keldrin Encampment.";
$CruQuest[KILLGOB,COMPLETE] = 10;
$CruQuest[KILLGOB,BONUS,DEFAULT] = "GQUEST RETMAV1 CQUEST KILLGOB";

$CruQuest[RETMAV1,NAME] = "Return to Mav";
$CruQuest[RETMAV1,CHAT,1] = "I see you have proven worthy! [yes]";
$CruQuest[RETMAV1,CUE] = "yes";
$CruQuest[RETMAV1,CONFIRM,1] = "Thank you, I may have more work for you soon.";
$CruQuest[RETMAV1,INFO] = "Return to Mav for a reward.";
$CruQuest[RETMAV1,COMPLETE] = 1;
$CruQuest[RETMAV1,BONUS,MAGE] = "EXP 2000 COINS 1000 001SCAbilityBoost 1 CQUEST RETMAV1";
$CruQuest[RETMAV1,BONUS,PALADIN] = "EXP 2000 COINS 1000 001SCAbilityBoost 1 CQUEST RETMAV1";
$CruQuest[RETMAV1,BONUS,FIGHTER] = "EXP 2000 COINS 1000 001SCAbilityBoost 1 CQUEST RETMAV1";
$CruQuest[RETMAV1,BONUS,BARD] = "EXP 2000 COINS 1000 001SCAbilityBoost 1 CQUEST RETMAV1";
$CruQuest[RETMAV1,BONUS,THIEF] = "EXP 2000 COINS 1000 001SCAbilityBoost 1 CQUEST RETMAV1";
$CruQuest[RETMAV1,BONUS,DRUID] = "EXP 2000 COINS 1000 001SCAbilityBoost 1 CQUEST RETMAV1";
$CruQuest[RETMAV1,BONUS,RANGER] = "EXP 2000 COINS 1000 001SCAbilityBoost 1 CQUEST RETMAV1";
$CruQuest[RETMAV1,BONUS,CLERIC] = "EXP 2000 COINS 1000 001SCAbilityBoost 1 CQUEST RETMAV1";

$CruQuest[STONES,NAME] = "Stones";
$CruQuest[STONES,CHAT,1] = "I see you found some rocks. Will you hand them to me? [yes]";
$CruQuest[STONES,CUE] = "yes";
$CruQuest[STONES,CONFIRM,1] = "These are just what I need.";
$CruQuest[STONES,INFO] = "Bring 3 Enchanted Stones to Mav";
$CruQuest[STONES,COMPLETE] = 1;
$CruQuest[STONES,BONUS,DEFAULT] = "COINS 3000";

$Server::teamName[0] = "Citizen";
$Server::teamSkin[0] = "rpgbase";
$Server::teamName[1] = "Enemy";
$Server::teamSkin[1] = "rpgbase";
$Server::teamName[2] = "Greenskins";
$Server::teamSkin[2] = "rpgorc";
$Server::teamName[3] = "Gnoll";
$Server::teamSkin[3] = "rpggnoll";
$Server::teamName[4] = "Undead";
$Server::teamSkin[4] = "undead";
$Server::teamName[5] = "Elf";
$Server::teamSkin[5] = "rpgelf";
$Server::teamName[6] = "Minotaur";
$Server::teamSkin[6] = "min";
$Server::teamName[7] = "Uber";
$Server::teamSkin[7] = "fedmonster";


// bashing
// cleave
// sneakattack
// brawling
// aiming

// COLD		-25% ATK -25% DAMAGE
// FIRE		50% AOE DAMAGE
// ENERGY	-10% ATK -10% DAMAGE -10% DEF -10% PROTECT , 3 HIT STUN
// POISON	2% HEALTH / SEC
// MELEE	-25% DEF -25% PROTECT 
// PROJ		-25% DEF -25% PROTECT


function BackpackPerformSalvage(%id,%item)
{

	echo("================================================================");

	%material = $BPItem[%item,$BPMaterial];
	
	echo("MATERIAL " @ %material);

	%salvage = $MaterialSalvage[%material];

	echo("SALVAGE " @ %salvage);
	
	%n = getWord(%salvage,0) + 0;
	%e = getWord(%salvage,1) + 0;
	%p = getWord(%salvage,2) + 0;
	%t = getWord(%salvage,4);

	// 100 0 0
	// 20 70 0
	// 50 50 0
	// 0 50 50
	// 0 0 100

	%ret = "Common";
	%check = 0;

	echo(%n @ " " @ %e @ " " @ %p @ " " @ %t);

	if (%e == 0 && %p == 0) { %ret = "Common"; %check = 1; }
	if (%n == 0 && %p == 0) { %ret = "Excellent"; %check = 1; }
	if (%n == 0 && %e == 0) { %ret = "Pristine"; %check = 1; }

	if (!%check) {
		if (%p == 0) {
			%f = floor(getRandom() * 100 + 1);
			echo(" F " @ %f);
			if (%f <= %n) %ret = "Common";
			else %ret = "Excellent";
		}
		if (%n == 0) {
			%f = floor(getRandom() * 100 + 1);
			echo(" F " @ %f);
			if (%f <= %e) %ret = "Excellent";
			else %ret = "Pristine";
		}
	}

	%m = "999" @ %ret @ %t;
	
	%tier = GetBPData(%item,$BPItemType);
	%source = getWord(%tier,0);

	echo(%tier);
	
	if (%source > 0)
		AddToBackpack(%id,"999SourceEssence",%source);
	AddToBackpack(%id,%m,1);
	RemoveFromBackpack(%id,%item,-1);

	echo(%m);

	Game::menuBackpack(%id,0);

}

function CreateTierTradeskill(%tname,%name,%ico,%price,%desc)
{
	echo(" CREATETIERTRADESKILL " @ %tname @ " " @ %name @ " " @ %ico @ " " @ %desc);

	if (%desc == "") { %desc = "This item can be used in the crafting and smithing of new items."; }

	$DynamicItem[%tname,$DName] = %name;
	$DynamicItem[%tname,$DMinMax] = "999 999";
	$DynamicItem[%tname,$DWeight] = "1 0";
	$DynamicItem[%tname,$DPrice] = %price @ " NA";
	$DynamicItem[%tname,$DDesc] = %desc;
	$DynamicItem[%tname,$DItemType] = "1 Tradeskill";
	$DynamicItem[%tname,$DTier] = 1;
	$DynamicItem[%tname,$DIco] = "ico_" @ %ico @ ".bmp";

	DynamicItem::Create(%tname,999);
}

CreateTierTradeskill("SourceEssence","Source Essence","SourceEssence",50,"");

CreateTierTradeskill("CommonGemstone","Common Gemstone","Gemstone",100,"");
CreateTierTradeskill("ExcellentGemstone","Excellent Gemstone","Gemstone",200,"");
CreateTierTradeskill("PristineGemstone","Pristine Gemstone","Gemstone",300,"");

CreateTierTradeskill("CommonHeavyMaterial","Common Heavy Material","HeavyMaterial",100,"");
CreateTierTradeskill("ExcellentHeavyMaterial","Excellent Heavy Material","HeavyMaterial",200,"");
CreateTierTradeskill("PristineHeavyMaterial","Pristine Heavy Material","HeavyMaterial",300,"");

CreateTierTradeskill("CommonLightMaterial","Common Light Material","Light Material",100,"");
CreateTierTradeskill("ExcellentLightMaterial","Excellent Light Material","Light Material",200,"");
CreateTierTradeskill("PristineLightMaterial","Pristine Light Material","Light Material",300,"");

CreateTierTradeskill("CommonSpiritMaterial","Common Spirit Material","Spirit Material",100,"");
CreateTierTradeskill("ExcellentSpiritMaterial","Excellent Spirit Material","Spirit Material",200,"");
CreateTierTradeskill("PristineSpiritMaterial","Pristine Spirit Material","Spirit Material",300,"");

CreateTierTradeskill("CommonLongBlade","Common Long Blade","LongBlade",100,"");
CreateTierTradeskill("ExcellentLongBlade","Excellent Long Blade","LongBlade",200,"");
CreateTierTradeskill("PristineLongBlade","Pristine Long Blade","LongBlade",300,"");

CreateTierTradeskill("CommonGiantBlade","Common Giant Blade","GiantBlade",100,"");
CreateTierTradeskill("ExcellentGiantBlade","Excellent Giant Blade","GiantBlade",200,"");
CreateTierTradeskill("PristineGiantBlade","Pristine Giant Blade","GiantBlade",300,"");

CreateTierTradeskill("CommonShortBlade","Common Short Blade","ShortBlade",100,"");
CreateTierTradeskill("ExcellentShortBlade","Excellent Short Blade","ShortBlade",200,"");
CreateTierTradeskill("PristineShortBlade","Pristine Short Blade","ShortBlade",300,"");

CreateTierTradeskill("CommonCrossbowMaterial","Common Crossbow Material","CrossbowMaterial",100,"");
CreateTierTradeskill("ExcellentCrossbowMaterial","Excellent Crossbow Material","CrossbowMaterial",200,"");
CreateTierTradeskill("PristineCrossbowMaterial","Pristine Crossbow Material","CrossbowMaterial",300,"");

CreateTierTradeskill("CommonBowMaterial","Common Bow Material","BowMaterial",100,"");
CreateTierTradeskill("ExcellentBowMaterial","Excellent Bow Material","BowMaterial",200,"");
CreateTierTradeskill("PristineBowMaterial","Pristine Bow Material","BowMaterial",300,"");

CreateTierTradeskill("CommonHammerMaterial","Common Hammer Material","HammerMaterial",100,"");
CreateTierTradeskill("ExcellentHammerMaterial","Excellent Hammer Material","HammerMaterial",200,"");
CreateTierTradeskill("PristineHammerMaterial","Pristine Hammer Material","HammerMaterial",300,"");

CreateTierTradeskill("CommonMagiMaterial","Common Magi Material","MagiMaterial",100,"");
CreateTierTradeskill("ExcellentMagiMaterial","Excellent Magi Material","MagiMaterial",200,"");
CreateTierTradeskill("PristineMagiMaterial","Pristine Magi Material","MagiMaterial",300,"");

CreateTierTradeskill("CommonWarlockMaterial","Common Warlock Material","WarlockMaterial",100,"");
CreateTierTradeskill("ExcellentWarlockMaterial","Excellent Warlock Material","WarlockMaterial",200,"");
CreateTierTradeskill("PristineWarlockMaterial","Pristine Warlock Material","WarlockMaterial",300,"");

//===============================================================================================================================================

$MaterialSalvage[Stone] 	= "100 0 0 N Gemstone";
$MaterialSalvage[Quartz] 	= "95 05 0 N Gemstone";
$MaterialSalvage[Granite] 	= "90 10 0 N Gemstone";
$MaterialSalvage[Opal] 		= "85 15 0 N Gemstone";
$MaterialSalvage[Jade] 		= "80 20 0 N Gemstone";
$MaterialSalvage[Turquoise] 	= "75 25 0 N Gemstone";
$MaterialSalvage[Ruby] 		= "30 70 0 E Gemstone";
$MaterialSalvage[Topaz] 	= "20 80 0 E Gemstone";
$MaterialSalvage[Sapphire] 	= "10 90 0 E Gemstone";
$MaterialSalvage[Obsidian] 	= "0 100 0 E Gemstone";
$MaterialSalvage[Bloodstone] 	= "0 90 10 E Gemstone";
$MaterialSalvage[Garnet] 	= "0 80 20 E Gemstone";
$MaterialSalvage[Silver] 	= "0 25 75 P Gemstone";
$MaterialSalvage[Gold] 		= "0 20 80 P Gemstone";
$MaterialSalvage[Emerald] 	= "0 15 85 P Gemstone";
$MaterialSalvage[Diamond] 	= "0 10 90 P Gemstone";
$MaterialSalvage[Keldrinite] 	= "0 05 95 P Gemstone";
$MaterialSalvage[Brimstone] 	= "0 0 100 P Gemstone";

$MaterialSalvage[Pads] 		= "100 0 0 N HeavyMaterial";
$MaterialSalvage[Leather] 	= "95 05 0 N HeavyMaterial";
$MaterialSalvage[Hide] 		= "90 10 0 N HeavyMaterial";
$MaterialSalvage[Scales] 	= "85 15 0 N HeavyMaterial";
$MaterialSalvage[Chains] 	= "80 20 0 N HeavyMaterial";
$MaterialSalvage[Bones] 	= "75 25 0 N HeavyMaterial";
$MaterialSalvage[Rings] 	= "30 70 0 E HeavyMaterial";
$MaterialSalvage[Bands] 	= "20 80 0 E HeavyMaterial";
$MaterialSalvage[Splints] 	= "10 90 0 E HeavyMaterial";
$MaterialSalvage[Bronze] 	= "0 100 0 E HeavyMaterial";
$MaterialSalvage[Plate] 	= "0 90 10 E HeavyMaterial";
$MaterialSalvage[Iron] 		= "0 80 20 E HeavyMaterial";
$MaterialSalvage[Steel] 	= "0 25 75 P HeavyMaterial";
$MaterialSalvage[Adamant] 	= "0 20 80 P HeavyMaterial";
$MaterialSalvage[Crystal] 	= "0 15 85 P HeavyMaterial";
$MaterialSalvage[Runite] 	= "0 10 90 P HeavyMaterial";
$MaterialSalvage[Titanium] 	= "0 05 95 P HeavyMaterial";
$MaterialSalvage[Mithril] 	= "0 0 100 P HeavyMaterial";

$MaterialSalvage[Cotton] 	= "100 0 0 N LightMaterial";
$MaterialSalvage[Wool] 		= "95 05 0 N LightMaterial";
$MaterialSalvage[Fur] 		= "90 10 0 N LightMaterial";
$MaterialSalvage[Fishscale] 	= "85 15 0 N LightMaterial";
$MaterialSalvage[Deerskin] 	= "80 20 0 N LightMaterial";
$MaterialSalvage[Bearskin] 	= "75 25 0 N LightMaterial";
$MaterialSalvage[Wolfpelt] 	= "30 70 0 E LightMaterial";
$MaterialSalvage[Sharkskin] 	= "20 80 0 E LightMaterial";
$MaterialSalvage[Velvet] 	= "10 90 0 E LightMaterial";
$MaterialSalvage[Silk] 		= "0 100 0 E LightMaterial";
$MaterialSalvage[Bamboo] 	= "0 90 10 E LightMaterial";
$MaterialSalvage[Hemp] 		= "0 80 20 E LightMaterial";
$MaterialSalvage[Copper] 	= "0 25 75 P LightMaterial";
$MaterialSalvage[Aluminium] 	= "0 20 80 P LightMaterial";
$MaterialSalvage[Drakeflesh] 	= "0 15 85 P LightMaterial";
$MaterialSalvage[Drakescale] 	= "0 10 90 P LightMaterial";
$MaterialSalvage[Dragonflesh] 	= "0 05 95 P LightMaterial";
$MaterialSalvage[Spirit] 	= "0 0 100 P LightMaterial";

$MaterialSalvage[Apprentice] 	= "100 0 0 N SpiritMaterial";
$MaterialSalvage[Light] 	= "95 05 0 N SpiritMaterial";
$MaterialSalvage[Advisor] 	= "90 10 0 N SpiritMaterial";
$MaterialSalvage[Blood] 	= "85 15 0 N SpiritMaterial";
$MaterialSalvage[Fine] 		= "80 20 0 N SpiritMaterial";
$MaterialSalvage[Elven] 	= "75 25 0 N SpiritMaterial";
$MaterialSalvage[Earth] 	= "30 70 0 E SpiritMaterial";
$MaterialSalvage[Old] 		= "20 80 0 E SpiritMaterial";
$MaterialSalvage[Dark] 		= "10 90 0 E SpiritMaterial";
$MaterialSalvage[Golden] 	= "0 100 0 E SpiritMaterial";
$MaterialSalvage[Ghost] 	= "0 90 10 E SpiritMaterial";
$MaterialSalvage[Gray] 		= "0 80 20 E SpiritMaterial";
$MaterialSalvage[White] 	= "0 25 75 P SpiritMaterial";
$MaterialSalvage[Sun] 		= "0 20 80 P SpiritMaterial";
$MaterialSalvage[Moon] 		= "0 15 85 P SpiritMaterial";
$MaterialSalvage[Forest] 	= "0 10 90 P SpiritMaterial";
$MaterialSalvage[Vengeance] 	= "0 05 95 P SpiritMaterial";
$MaterialSalvage[Phens] 	= "0 0 100 P SpiritMaterial";

$MaterialSalvage[Hatchet] 	= "100 0 0 N LongBlade";
$MaterialSalvage[BroadSword] 	= "90 10 0 N LongBlade";
$MaterialSalvage[WarAxe] 	= "80 20 0 N LongBlade";
$MaterialSalvage[LongSword] 	= "20 80 0 E LongBlade";
$MaterialSalvage[BattleAxe] 	= "0 100 0 E LongBlade";
$MaterialSalvage[BastardSword] 	= "0 80 20 E LongBlade";
$MaterialSalvage[Halberd] 	= "0 25 75 P LongBlade";
$MaterialSalvage[Claymore] 	= "0 0 100 P LongBlade";

$MaterialSalvage[GiantSword] 	= "50 50 0 N GiantBlade";
$MaterialSalvage[Flamberge] 	= "0 50 50 E GiantBlade";
$MaterialSalvage[CrystalSword] 	= "0 0 100 P GiantBlade";

$MaterialSalvage[Knife] 	= "100 0 0 N ShortBlade";
$MaterialSalvage[Dagger] 	= "75 25 0 N ShortBlade";
$MaterialSalvage[ShortSword] 	= "25 75 0 E ShortBlade";
$MaterialSalvage[Spear] 	= "0 100 0 E ShortBlade";
$MaterialSalvage[Gladius] 	= "0 75 25 E ShortBlade";
$MaterialSalvage[Trident] 	= "0 40 60 P ShortBlade";
$MaterialSalvage[Rapier] 	= "0 20 80 P ShortBlade";
$MaterialSalvage[AwlPike] 	= "0 0 100 P ShortBlade";

$MaterialSalvage[LightCrossbow] 	= "90 10 0 N CrossbowMaterial";
$MaterialSalvage[RepeatingCrossbow] 	= "80 20 0 N CrossbowMaterial";
$MaterialSalvage[HeavyCrossbow] 	= "0 80 20 E CrossbowMaterial";
$MaterialSalvage[ElvenCrossbow] 	= "0 70 30 E CrossbowMaterial";
$MaterialSalvage[Arbalest] 		= "0 10 90 P CrossbowMaterial";

$MaterialSalvage[ShortBow] 	= "90 10 0 N BowMaterial";
$MaterialSalvage[LongBow] 	= "80 20 0 E BowMaterial";
$MaterialSalvage[CompositeBow] 	= "0 80 20 E BowMaterial";
$MaterialSalvage[ElvenBow] 	= "0 70 30 P BowMaterial";
$MaterialSalvage[WingBow] 	= "0 10 90 P BowMaterial";

$MaterialSalvage[Club] 			= "100 0 0 N HammerMaterial";
$MaterialSalvage[QuarterStaff] 		= "90 10 0 N HammerMaterial";
$MaterialSalvage[BoneClub] 		= "80 20 0 N HammerMaterial";
$MaterialSalvage[SpikedClub] 		= "70 30 0 N HammerMaterial";
$MaterialSalvage[Mace] 			= "20 80 0 E HammerMaterial";
$MaterialSalvage[HammerPick] 		= "10 90 0 E HammerMaterial";
$MaterialSalvage[SpikedBoneClub] 	= "0 100 0 E HammerMaterial";
$MaterialSalvage[LongStaff] 		= "0 80 20 E HammerMaterial";
$MaterialSalvage[WarHammer] 		= "0 20 80 P HammerMaterial";
$MaterialSalvage[GreatStaff] 		= "0 10 90 P HammerMaterial";
$MaterialSalvage[WarMaul] 		= "0 0 100 P HammerMaterial";

$MaterialSalvage[GnarledWand] 	= "90 10 0 N MagiMaterial";
$MaterialSalvage[BoneWand] 	= "80 20 0 N MagiMaterial";
$MaterialSalvage[BranchWand] 	= "25 75 0 E MagiMaterial";
$MaterialSalvage[IvoryWand] 	= "0 75 25 E MagiMaterial";
$MaterialSalvage[CrystalWand] 	= "0 20 80 P MagiMaterial";
$MaterialSalvage[PlatedWand] 	= "0 10 90 P MagiMaterial";

$MaterialSalvage[GranledStaff] 	= "90 10 0 N WarlockMaterial";
$MaterialSalvage[OakStaff] 	= "80 20 0 N WarlockMaterial";
$MaterialSalvage[TwistedStaff] 	= "25 75 0 E WarlockMaterial";
$MaterialSalvage[MysticStaff] 	= "0 75 25 E WarlockMaterial";
$MaterialSalvage[CrystalStaff] 	= "0 20 80 P WarlockMaterial";
$MaterialSalvage[PlatedStaff] 	= "0 10 90 P WarlockMaterial";

echo("__TIER_TRADEITEMS LOADED");




	if ((fetchData(%target,"HP") - %value) <= 0) {		
		ManualAddDamagedList(%id,%target,%value);
		Client::SendMessage(%id,0,"You killed " @ Client::GetName(%target) @ "!");
		if ((%zone = $CRUSPAWNZONE[%target]) != "") {
			%spawn = $CRUSPAWNID[%target];
			$CRUZONE[%zone,$CZSpawn,%spawn,$CZActive] -= 1;
			schedule("DecreaseZoneActive("@%target@","@%zone@","@%spawn@");",10);
			$CRUSPAWNZONE[%target] = "";
			$CRUSPAWNID[%target] = "";
			%monstername = $CRUMONSTERNAME[%target];
			$CRUMONSTER[%monstername,$CENameOn]--;
			$CRUMONSTERNAME[%target] = "";
		}
		ActionKilled(%id,%target,99);
		refreshHP(%target,((%value / 100) * 1));
		$TargetCur[%id,0] = "";
		Targeting::Hud(%id,1);
	}



	echo(" WHATISCOMPARE " @ %id @ " " @ %loc);
	%p = $BPLocationToNumeric[%loc];
	%wear = GetCurrentWearFull(%id,%p);
	
	if (%wear != "none") {
	
	%item = %wear;

	retrun;

	if ($BPItem[%item,$BPName] != "") {
		
		//========================================================================================================
		%qual = String::GetSubStr(%item,0,3);
		%qual = %qual * 1;
		if (%qual == 999)
			%qual = "Special";
		//========================================================================================================
		%typedisp = "";
		if ((%itemtype = $BPItem[%item,$BPItemType]) != "") {
			if ($TierPlate[%itemtype] != "") {
				%typedisp = "<b" @ $TierPlate[%itemtype] @ ">";
			}		
			else {
				%tier = getWord(%itemtype,0);
				%v = "";
				if (getWord(%itemtype,1) != -1) %v = %v @ getWord(%itemtype,1) @ " ";
				if (getWord(%itemtype,2) != -1) %v = %v @ getWord(%itemtype,2) @ " ";
				if (getWord(%itemtype,3) != -1) %v = %v @ getWord(%itemtype,3) @ " ";
				%typedisp = $TierItemTypeDisp[%tier] @ " " @ %v;
			}
		}
		%msg = %msg @ "<f0>" @ %typedisp @ "\n\n\n<f1>";
		//========================================================================================================
		if ($BPItem[%item,$BPIco] != "") {
			%msg = %msg @ "<b" @ $BPItem[%item,$BPIco] @ ">\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPWeaponTwoHand] == 0)
			%msg = %msg @ "<f1>" @ $BPItem[%item,$BPName] @ "\n";
		else
			%msg = %msg @ "<f1>" @ $BPItem[%item,$BPName] @ " <f0>(2 Hand) \n";
		//========================================================================================================
		if ($NoDropItem[%item])
			%msg = %msg @ "NODROP";
		//========================================================================================================
		%msg = %msg @ "<f1>";
		%msg = %msg @ "Quality: <f0>" @ %qual;
		if ($BPItem[%item,$BPIntegrity] != "" && $BPItem[%item,$BPIntegrity] > 0)
			%msg = %msg @ "\n<f1>Integrity:<f0> +" @ $BPItem[%item,$BPIntegrity] @ "%";
		if ($BPItem[%item,$BPTierPerc] > 0 && $BPItem[%item,$BPTierPerc] != "") {
			%msg = %msg @ "\n<f1>Modifiers: <f0>" @ $BPItem[%item,$BPTierPerc] @ "\n\n\n<f1>"; 
		}
		else {
			%msg = %msg @ "\n\n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPImplicit] != "") {
			%msg = %msg @ " <f1>" @ BPFormat($BPItem[%item,$BPImplicit]) @ "\n\n<f1>"; 
		}
		//========================================================================================================
		if ($BPItem[%item,$BPMapMagic] != "") {
			%msg = %msg @ "<f1>Magic Find " @ $BPItem[%item,$BPMapMagic] @ "%\n\n<f1>"; 
		}
		//========================================================================================================
		if ($BPItem[%item,$BPWeaponMagDamage] != "") {
			%msg = %msg @ "\n";
			%msg = %msg @ " Spell Base Damage: <f0>" @ $BPItem[%item,$BPWeaponMagDamage] @ "<f1>\n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPDamage] != "") {
                        %msg = %msg @ "\n";
			%msg = %msg @ " Damage: <f0>" @ $BPItem[%item,$BPDamage] @ "<f1>\n";
                        %damage = $BPItem[%item,$BPDamage];
			%dmgmin = getWord(%damage,0);
			%dmgmax = getWord(%damage,2);
			%delay = $BPItem[%item,$BPWeaponDelay];
			%dps = round(((%dmgmin + %dmgmax) / 2) / %delay);
			%msg = %msg @ " DPS: <f0>" @ %dps @ "<f1>\n";
		}
		if ($BPItem[%item,$BPDamageType] != "") {
			%msg = %msg @ " <f1>DamageType: <f0>" @ $BPItem[%item,$BPDamageType] @ "\n";
			%delay = $BPItem[%item,$BPWeaponDelay];
			%msg = %msg @ " <f1>Delay: <f0>" @ %delay @ " seconds<f1>\n\n";
		}	
		//========================================================================================================
		if ($BPItem[%item,$BPWield] != "") {
			%msg = %msg @ "<f1>Requirements:\n<f0> " @ BPFormat($BPItem[%item,$BPWield]) @ "\n<f1>\n";
			if ($BPItem[%item,$BPWieldBonus] != "")
				%msg = %msg @ "<f1>Wield Bonus:\n<f0> " @ BPFormat($BPItem[%item,$BPWieldBonus]) @ "\n<f1>\n";
			%loc = getWord($BPItem[%item,$BPWield],1);
		}
		//========================================================================================================
		if ($BPItem[%item,$BPMapMods] != "") {
			%msg = %msg @ "<f1>Map Modifications:\n<f0>" @ FormatMapMods($BPItem[%item,$BPMapMods]) @ "\n<f1>\n";
		}
		//========================================================================================================
		if ((%sockets = $BPItem[%item,$BPNumSockets]) != "") {
			%msg = %msg @ "Sockets: <f0>" @ %sockets @" \n\n";
			for (%i = 1; %i <= %sockets; %i++)
				%msg = %msg @ "<bico_socket.bmp>";
			%msg = %msg @ "\n<f1>\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPTierProp] != "") {
			%itemtype = $BPItem[%item,$BPItemType];
			%truetype = getWord(%itemtype,1);
			if ((%hard = $BPItem[%item,$BPTierHard]) != "") {
				%perc = $BPItem[%item,$BPTierPerc];
				%hmsg = TierItem::GetHardDisp(%truetype,%hard,%qual,%perc);
				%msg = %msg @ "Wield Bonus: " @ BPFormat(%hmsg,True) @ ", +" @ $BPItem[%item,$BPTierProp] @ " Random Properties.\n";
			}
			else {
				%msg = %msg @ "Wield Bonus: +" @ $BPItem[%item,$BPTierProp] @ " Random Properties.\n";
			}
		}		
		//========================================================================================================
		if ($BPItem[%item,$BPUse] != "") {
			%msg = %msg @ "<f1>Use:\n<f0> " @ BPFormat($BPItem[%item,$BPUse]) @ "\n";
			%msg = %msg @ "<f1>Use Bonus:<f0> \n " @ BPFormat($BPItem[%item,$BPUseBonus]) @ "\n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPMBS] != "") {
			%msg = %msg @ "Max Beneficial Skill: " @ $BPItem[%item,$BPMBS] @ "\n";
		}
		//========================================================================================================
		%nw = $BPItem[%item,$BPWeight];
		//========================================================================================================
		%msg = %msg @ "<f1>Weight: " @ %nw @ "\n";
		%msg = %msg @ "<f1>Price: $" @ $BPItem[%item,$BPPrice] @ "\n\n";
		//========================================================================================================
		if ($BPItem[%item,$BPATK] != "") {
			%msg = %msg @ "<f1>ATK: <f0>" @ $BPItem[%item,$BPATK] @ "\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPSet] != "") {
			%set = $BPItem[%item,$BPSet];
			%msg = %msg @ TierItem::SetBonusDisp(%set);
		}
		//========================================================================================================
		if ($BPItem[%item,$BPRune] != "") {
			%runebonus = $BPItem[%item,$BPRuneBonus];
			%mod = getWord(%runebonus,0);
			%msg = %msg @ "Rune Bonus:\n<f0> " @ BPFormat(%runebonus) @ "\n<f1>\n";
			//%msg = %msg @ "Requirement:\n<f0> " @ BPReqDisplay($BPItem[%item,$BPRuneReq]) @ " " @ BPRuneReqVal($TierReqP[%mod],%qual) @ "\n<f1>\n";
			%msg = %msg @ "Requirement:<f0> " @ BPReqDisplay($BPItem[%item,$BPRuneReq]) @ "\n<f1>";
			%msg = %msg @ "Location:<f0> " @ $BPItem[%item,$BPRuneLoc] @ "\n<f1>\n";
		}
		//========================================================================================================
		%msg = %msg @ "<f0>" @ $BPItem[%item,$BPDesc];
		//========================================================================================================
		if (%loc != "")
			%msg = %msg @ "\n\n You are wearing:\n" @ WhatIsCompare(%id,%loc);
		//========================================================================================================
		return %msg;		
	}
	
	}







function RandomSeed()
{
	return;
	echo(" >>>>>>>>> RESEEDING RANDOM ");
	exec(randomseed);
	%seed = $randomseed;
	for (%i = 0; %i <= %seed; %i++) %r = floor(getRandom() * 1000);
	%newseed = floor(getRandom() * 50000 + 10000);
	$randomseed = %newseed;
	%name = "randomseed";
	File::delete("temp\\" @ %name @ ".cs");
	export("$randomseed","temp\\" @ %name @ ".cs", false);
}

RandomSeed();



function round(%n)
{
//	dbecho($dbechoMode, "round(" @ %n @ ")");

	if(%n < 0)
	{
		%t = -1;
		%n = -%n;
	}	
	else if(%n >= 0)
		%t = 1;

	%f = floor(%n);
	%a = %n - %f;
	if(%a < 0.5)
		%b = 0;
	else if(%a >= 0.5)
		%b = 1;

	return (%f + %b) * %t;
}

function Loot::Ratio(%n,%x,%mf)
{
	if (%mf<1) %mf = 1;
	%x = floor(%x/%mf);
	if (%x<1) %x = 1;
	//%r = RandBetween(1,%x);
	%r = MTRB(1,%x);
	if (%r == 1)
		return True;
	else
		return False;
}


// PRIMAL MAGIC ==============================================================================================================================================
AutoSpell("Bloodthirst","Bloodthirst",10,"FRIEND","LOS",0,"PrimalMagic","NA","LIFESTEAL 10","MANA 0.8",2,2,1.1,3600,"Bloodthirst","Bloodthirst","ANIM_BODY_OFF","icos_Bloodthirst"," You thirst for blood, stealing some from your opponent",0,0,0,0,0,-1,-1,0);
AutoSpell("Havoc","Havoc",10,"FRIEND","LOS",0,"PrimalMagic","NA","ADDALLOFF 100","MANA 0.9",4,4,1.0,3600,"Havoc","Havoc","ANIM_BODY_OFF","icos_Havoc"," Raising havoc all around you",0,0,0,0,0,-1,-1,0);
AutoSpell("Shred","Shred",10,"FRIEND","LOS",0,"PrimalMagic","NA","ARMORPEN 1000","MANA 1.1",5,5,1.3,1800,"Shred","Shred","ANIM_WEAPON_OFF","icos_Shred"," You shred some of your targets armor",5,0,0,0,0,-1,-1,0.7);
AutoSpell("Carnage","Carnage",10,"FRIEND","LOS",0,"PrimalMagic","NA","ADDDAMAGE 100","MANA 1.1",5,5,0.84,1800,"Carnage","Carnage","ANIM_WEAPON_OFF","icos_Carnage"," desc",5,0,0,0,0,-1,-1,0.6);
AutoSpell("Brutal","Brutal",10,"FRIEND","LOS",0,"PrimalMagic","NA","PHYSICALDAMAGE 20","MANA 1.3",10,10,0.7,3600,"Brutal","Brutal","ANIM_ABILITY_OFF","icos_Brutal"," Pure devistation",0,0,0,0,0,1,250,0);
AutoSpell("Master","Master",10,"FRIEND","LOS",0,"PrimalMagic","NA","WEAPONHANDLING 287","MANA 0.8",5,5,0.78,3600,"Master","Master","ANIM_WEAPON_OFF","icos_Master"," Master of the arena",0,0,0,0,0,-1,-1,0.9);
AutoSpell("RefineWeapon","Refine Weapon",10,"FRIEND","LOS",0,"PrimalMagic","NA","MINDAMAGE 50 MAXDAMAGE 100","MANA 1.3",10,10,1.45,3600,"RefineWeapon","RefineWeapon","ANIM_WEAPON_OFF","icos_RefineWeapon"," You sharpen your blade",0,0,0,0,0,-1,-1,0.9);
AutoSpell("Talon","Talon",10,"FRIEND","LOS",0,"PrimalMagic","NA","RANGEDDAMAGE 10","MANA 0.8",3,3,0.89,3600,"Talon","Talon","ANIM_ABILITY_OFF","icos_Talon"," Description",0,0,0,0,0,-1,200,0);
AutoSpell("Crush","Crush",10,"FRIEND","LOS",0,"PrimalMagic","NA","INCSTUN 10","MANA 0.8",3,3,1.23,3600,"Crush","Crush","ANIM_BODY_OFF","icos_Crush"," Description",0,0,0,0,0,-1,200,0);
AutoSpell("Rage","Rage",10,"FRIEND","SELF",0,"PrimalMagic","NA","BERSERK 100","HEALTH 1.2",10,10,1.5,300,"Rage","Rage","ANIM_BODY_OFF","icos_Rage"," Description",0,0,0,0,0,-1,-1,0.5);
AutoSpell("OnGuard","On Guard",10,"FRIEND","LOS",0,"PrimalMagic","NA","RIPOSTE 1000","MANA 1.0",3,3,1.0,3600,"OnGuard","OnGuard","ANIM_ABILITY_OFF","icos_Onguard"," Description",5,0,0,0,0,-1,-1,0.8);
AutoSpell("Skirmish","Skirmish",10,"FRIEND","LOS",0,"PrimalMagic","NA","MELEEDAMAGE 10","MANA 0.8",3,3,0.89,3600,"Skirmish","Skirmish","ANIM_WEAPON_OFF","icos_Skirmish"," Description",0,0,0,0,0,-1,200,0);
AutoSpell("Excalibur","Excalibur",15,"FRIEND","SELF",0,"PrimalMagic","NA","SLASHING 400","MANA 0.9",10,10,1.1,3600,"Excalibur","Excalibur","ANIM_WEAPON_OFF","icos_Excalibur"," The allmighty sword",0,0,0,0,0,-1,-1,0.5);
AutoSpell("HeavyHitter","Heavy Hitter",10,"FRIEND","SELF",0,"PrimalMagic","NA","BLUDGEONING 400","MANA 0.9",10,10,1.1,3600,"HeavyHitter","HeavyHitter","ANIM_WEAPON_OFF","icos_HeavyHitter"," You will crush your opponents",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Artillery","Artillery",10,"FRIEND","SELF",0,"PrimalMagic","NA","ARCHERY 175","MANA 0.9",5,5,0.8,3600,"Artillery","Artillery","ANIM_WEAPON_OFF","icos_Artillery"," You have skilled yourself in the art of bow",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Deadeye","Deadeye",10,"FRIEND","SELF",0,"PrimalMagic","NA","AIMING 175","MANA 0.9",5,5,0.8,3600,"Deadeye","Deadeye","ANIM_WEAPON_OFF","icos_Deadeye"," Description",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Slasher","Slasher",15,"FRIEND","SELF",0,"PrimalMagic","NA","CLEAVE 400","MANA 0.9",7,7,1.1,3600,"Slasher","Slasher","ANIM_WEAPON_OFF","icos_Slasher"," Description",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Mallet","Mallet",10,"FRIEND","SELF",0,"PrimalMagic","NA","BASHING 400","MANA 0.9",7,7,1.1,3600,"Mallet","Mallet","ANIM_WEAPON_OFF","icos_Mallet"," Description",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Native","Native",10,"FRIEND","SELF",0,"PrimalMagic","NA","PRIMALMAGIC 287","MANA 0.9",8,8,1.0,3600,"Native","Native","ANIM_SPELL_OFF","icos_Native"," Description",0,0,0,0,0,-1,-1,0.5);
//***************************************************************************************************
AutoSpell("Rage","Rage",30,"FRIEND","SELF",0,"PrimalMagic","NA","MINDAMAGE 100 MAXDAMAGE 300 SELFCAST RageCooldown","HEALTH 5.0",5,5,1.0,60,"Rage","Rage","anim_","icos_Rage","You are filled with rage",0,0,0,0,0,-1,-1,0.5,"HEAL 600",1,60,"PHYSICALDAMAGE 100");

// HOlY MAGIC ==============================================================================================================================================
AutoSpell("DivineArmor","Divine Armor",15,"FRIEND","SELF",0,"HolyMagic","NA","ARMOR 1000","MANA 1.0",4,4,1.0,3600,"DivineArmor","DivineArmor","anim_","icos_divinearmor"," Calls apon the light to give you all added armor protection",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Harden","Harden",15,"FRIEND","LOS",0,"HolyMagic","NA","MELEEAC 1000 PROJAC 1000","MANA 0.8",3,3,0.7,3600,"Harden","Harden","anim_","icos_harden"," Hardens your armor",0,0,0,0,0,-1,-1,0.2);
AutoSpell("ChargedArmor","Charged Armor",15,"FRIEND","LOS",0,"HolyMagic","NA","FIREAC 700 COLDAC 700 POISONAC 700 ENERGYAC 700","MANA 0.8",3,3,0.75,3600,"ChargedArmor","ChargedArmor","anim_","icos_chargedarmor"," Your armor is charged",0,0,0,0,0,-1,-1,0.2);
AutoSpell("Spikemail","Spikemail",10,"FRIEND","LOS",0,"HolyMagic","NA","REFLECT 10","MANA 0.9",6,6,0.9,1800,"Spikemail","Spikemail","anim_","icos_spikemail"," Description",0,0,0,0,0,-1,-1,0.1);
AutoSpell("Medicine","Medicine",10,"FRIEND","LOS",0,"HolyMagic","NA","HEALING 575","MANA 1.1",8,8,1.1,3600,"Medicine","Medicine","anim_","icos_Medicine"," Description",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Dragonguard","Dragonguard",10,"FRIEND","LOS",0,"HolyMagic","NA","BLOCKHIT% 10 BLOCKAMMOUNT 300 BLOCKRECOVERY 30","MANA 1.0",6,6,1.0,3600,"Dragonguard","Dragonguard","anim_","icos_Dragonguard"," Description",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Saint","Saint",10,"FRIEND","LOS",0,"HolyMagic","NA","HEALING% 30","MANA 1.1",8,8,1.1,3600,"Saint","Saint","anim_","icos_Saint"," Description",0,0,0,0,0,-1,-1,0);
AutoSpell("Slayer","Slayer",10,"FRIEND","LOS",0,"HolyMagic","NA","DEMONPROT 10","MANA 0.8",3,3,0.8,3600,"Slayer","Slayer","anim_","icos_Slayer"," Demons shall not harm you",0,0,0,0,0,-1,-1,0);
AutoSpell("Rend","Rend",10,"FRIEND","LOS",0,"HolyMagic","NA","BANDAGE 1000","MANA 1.1",8,8,1.1,3600,"Rend","Rend","anim_","icos_Rend"," You bandage yourself",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Centurian","Centurian",10,"FRIEND","LOS",0,"HolyMagic","NA","INCARMOR 100","MANA 1.1",8,8,1.1,3600,"Centurian","Centurian","anim_","icos_Centurian"," Blessing of the mighty Knight",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Recovery","Recovery",10,"FRIEND","LOS",0,"HolyMagic","NA","STUNRECOVER 30","MANA 0.8",7,7,0.8,1800,"Recovery","Recovery","anim_","icos_Recovery"," You come to your senses",0,0,0,0,0,-1,-1,0.3);
AutoSpell("Faithful","Faithful",10,"FRIEND","SELF",0,"HolyMagic","NA","HOLYMAGIC 287","MANA 0.9",8,8,1.0,3600,"Faithful","Faithful","anim_","icos_Faithful"," You are faithful",0,0,0,0,0,1,300,0.5);
//***************************************************************************************************
AutoSpell("Heal","Heal",30,"FRIEND","LOS",0,"HolyMagic","NA","HEAL 7000","MANA 2.5",4,4,0,0,"Heal","Heal","anim_","icos_Heal"," Heal yourself or your ally",0,0,0,0,0,1,300,0);
AutoSpell("Rend","Rend",30,"FRIEND","LOS",0,"HolyMagic","NA","TEAMHEAL 3500","MANA 2.5",4,4,0,0,"Rend","Rend","anim_","icos_Rend"," Heal you and your team",0,0,0,0,0,1,300,0);
AutoSpell("Ironblood","Ironblood",3,"FRIEND","SELF",0,"HolyMagic","NA","INCARMOR 300 MAXHP 1000 SELFCAST IronbloodCooldown","MANA 1.0",4,4,0,30,"Ironblood","Ironblood","anim_","icos_Ironblood"," Increase your armor",0,0,0,0,0,1,300,0);


// EMPOWERMENT ==============================================================================================================================================
AutoSpell("Rejuvinate","Rejuvinate",10,"FRIEND","LOS",0,"Empowerment","NA","HEALDELTA 300","MANA 1.1",8,8,1.1,3600,"Rejuvinate","Rejuvinate","anim_","icos_Rejuvinate"," Rejuvination of the blood",5,0,0,0,0,-1,-1,0.5);
AutoSpell("Behemoth","Behemoth",15,"FRIEND","LOS",0,"Empowerment","NA","MAXHP 1000 STRENGTH 575 STAMINA 575","MANA 1.0",6,6,1.0,3600,"Behemoth","Behemoth","anim_","icos_Behemoth"," The mighty behemoth",10,0,0,0,0,-1,-1,0.5);
AutoSpell("Roaming","Roaming",15,"FRIEND","LOS",0,"Empowerment","NA","MAXWEIGHT 1000 WEIGHTCAPACITY 575","MANA 0.7",3,3,0.7,3600,"Roaming","Roaming","anim_","icos_Roaming"," You roam the lands",0,0,0,0,0,-1,-1,0);
AutoSpell("Hearty","Hearty",15,"FRIEND","LOS",0,"Empowerment","NA","ENDURANCE 575","MANA 1.0",6,6,1.0,3600,"Hearty","Hearty","anim_","icos_Hearty"," Hearty",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Blacksmith","Blacksmith",15,"FRIEND","LOS",0,"Empowerment","NA","SMITHING 575","MANA 0.8",6,6,0.8,3600,"Blacksmith","Blacksmith","anim_","icos_Blacksmith"," Blacksmith",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Extension","Extension",10,"FRIEND","LOS",0,"Empowerment","NA","WEAPONRANGE 20","MANA 0.8",4,4,1.0,3600,"Extension","Extension","anim_","icos_Extension"," Extends your weapon range",0,0,0,0,0,-1,-1,0);
AutoSpell("Keeper","Keeper",10,"FRIEND","LOS",0,"Empowerment","NA","SLASHING 175","MANA 0.9",6,8,1.0,3600,"Keeper","Keeper","anim_","icos_Keeper"," Keeper",0,0,0,0,0,-1,-1,0.2);
AutoSpell("Reaver","Reaver",10,"FRIEND","LOS",0,"Empowerment","NA","CLEAVE 175","MANA 0.8",6,8,0.9,3600,"Reaver","Reaver","anim_","icos_Reaver"," Reaver",0,0,0,0,0,-1,-1,0.2);
AutoSpell("Enforcer","Enforcer",10,"FRIEND","LOS",0,"Empowerment","NA","BLUDGEONING 175","MANA 0.8",6,8,0.9,3600,"Enforcer","Enforcer","anim_","icos_Enforcer"," Enforcer",0,0,0,0,0,-1,-1,0.3);
AutoSpell("Thug","Thug",10,"FRIEND","LOS",0,"Empowerment","NA","BASHING 175","MANA 0.8",6,8,0.9,3600,"Thug","Thug","anim_","icos_Thug"," Thug",0,0,0,0,0,-1,-1,0.2);
AutoSpell("Authority","Authority",10,"FRIEND","SELF",0,"Empowerment","NA","EMPOWERMENT 287","MANA 1.0",8,8,1.1,3600,"Authority","Authority","anim_","icos_Authority"," Authority",0,0,0,0,0,-1,-1,0.5);

// DARK MAGIC ==============================================================================================================================================
AutoSpell("Rigid","Rigid",10,"FRIEND","LOS",0,"DarkMagic","NA","CRITDAMAGE 50","MANA 0.8",2,2,1.0,3600,"Rigid","Rigid","anim_","icos_rigid"," Fine tune yourself to increase damage",5,0,0,0,0,-1,-1,0);
AutoSpell("Precision","Precision",10,"FRIEND","LOS",0,"DarkMagic","NA","CRITCHANCE 30","MANA 0.8",2,2,1.0,3600,"Precision","Precision","anim_","icos_Precision"," Precision",5,0,0,0,0,-1,-1,0);
AutoSpell("Calamaty","Calamaty",10,"FRIEND","LOS",0,"DarkMagic","NA","ADDALLOFF 100","MANA 1.0",4,4,1.1,1800,"Calamaty","Calamaty","anim_","icos_Calamaty"," Calamaty",0,0,0,0,0,-1,-1,0.3);
AutoSpell("Butcher","Butcher",10,"FRIEND","LOS",0,"DarkMagic","NA","ARMORPEN 500","MANA 1.0",8,8,1.0,3600,"Butcher","Butcher","anim_","icos_Butcher"," Butcher",5,0,0,0,0,-1,-1,0.5);
AutoSpell("Devastator","Devastator",10,"FRIEND","LOS",0,"DarkMagic","NA","ADDDAMAGE 60","MANA 1.1",8,8,1.1,1800,"Devastator","Devastator","anim_","icos_Devastator"," Devastator",5,0,0,0,0,-1,-1,0.6);
AutoSpell("Combative","Combative",10,"FRIEND","LOS",0,"DarkMagic","NA","PHYSICALDAMAGE 10","MANA 1.0",8,8,1.0,3600,"Combative","Combative","anim_","icos_Combative"," Combative",0,0,0,0,0,-1,-1,0);
AutoSpell("Slice","Slice",15,"FRIEND","LOS",0,"DarkMagic","NA","PIERCING 400","MANA 0.7",2,2,1.0,3600,"Slice","Slice","anim_","icos_Slice"," Slice",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Klepto","Klepto",15,"FRIEND","LOS",0,"DarkMagic","NA","STEALING 575","MANA 0.7",2,2,1.0,3600,"Klepto","Klepto","anim_","icos_Klepto"," Klepto",7,0,0,0,0,-1,-1,0.1);
AutoSpell("Shadowstep","Shadowstep",15,"FRIEND","LOS",0,"DarkMagic","NA","HIDING 575","MANA 0.7",2,2,1.0,3600,"Shadowstep","Shadowstep","anim_","icos_Klepto"," Shadowstep",7,0,0,0,0,-1,-1,0.3);
AutoSpell("Assassin","Assassin",15,"FRIEND","LOS",0,"DarkMagic","NA","BACKSTABBING 575","MANA 0.9",2,2,1.0,3600,"Assassin","Assassin","anim_","icos_Assassin"," Assassin",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Hook","Hook",10,"FRIEND","LOS",0,"DarkMagic","NA","WEAPONRANGE 10","MANA 0.9",3,3,0.9,3600,"Hook","Hook","anim_","icos_Hook"," Hook",0,0,0,0,0,-1,-1,0);
AutoSpell("Malice","Malice",10,"FRIEND","LOS",0,"DarkMagic","NA","INCPOISON 10","MANA 0.9",3,3,0.9,3600,"Malice","Malice","anim_","icos_Malice"," Malice",0,0,0,0,0,1,200,0);
AutoSpell("Cutthroat","Cutthroat",10,"FRIEND","LOS",0,"DarkMagic","NA","AGGDEF 30","MANA 0.9",3,3,0.9,3600,"Cutthroat","Cutthroat","anim_","icos_Cutthroat"," Cutthroat",0,0,0,0,0,1,100,0);
AutoSpell("Bowman","Bowman",15,"FRIEND","SELF",0,"DarkMagic","NA","ARCHERY 400","MANA 1.0",3,3,1.0,3600,"Bowman","Bowman","anim_","icos_Bowman"," Bowman",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Sharpshooter","Sharpshooter",15,"FRIEND","LOS",0,"DarkMagic","NA","AIMING 400","MANA 1.0",3,3,1.0,3600,"Sharpshooter","Sharpshooter","anim_","icos_Sharpshooter"," Sharpshooter",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Armament","Armament",10,"FRIEND","LOS",0,"DarkMagic","NA","WEAPONHANDLING 287","MANA 1.0",3,3,1.0,3600,"Armament","Armament","anim_","icos_Armament"," Armament",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Murk","Murk",10,"FRIEND","SELF",0,"DarkMagic","NA","DARKMAGIC 287","MANA 1.1",6,6,1.1,3600,"Murk","Murk","anim_","icos_Murk"," Murk",0,0,0,0,0,-1,-1,0.5);

// LIGHT MAGIC ==============================================================================================================================================
AutoSpell("Hoplite","Hoplite",10,"FRIEND","LOS",0,"LightMagic","NA","ADDALLDEF 100","MANA 1.1",6,6,1.1,3600,"Hoplite","Hoplite","anim_","icos_Hoplite"," Hoplite",5,0,0,0,0,-1,-1,0.2);
AutoSpell("Sustain","Sustain",10,"FRIEND","LOS",0,"LightMagic","NA","MELEEAC 300 PROJAC 300","MANA 0.7",6,6,0.6,3600,"Sustain","Sustain","anim_","icos_Sustain"," Sustain",0,0,0,0,0,-1,-1,0.3);
AutoSpell("Enviromental","Enviromental",10,"FRIEND","LOS",0,"LightMagic","NA","POISONAC 300 FIREAC 300 COLDAC 300 ENERGYAC 300","MANA 0.7",6,6,0.6,3600,"Enviromental","Enviromental","anim_","icos_Enviromental"," Enviromental",0,0,0,0,0,-1,-1,0.3);
AutoSpell("Affirm","Affirm",10,"FRIEND","LOS",0,"LightMagic","NA","MELEERES 300 PROJRES 300","MANA 0.7",6,6,0.6,3600,"Affirm","Affirm","anim_","icos_Affirm"," Affirm",0,0,0,0,0,-1,-1,0.3);
AutoSpell("Organic","Organic",10,"FRIEND","LOS",0,"LightMagic","NA","POISONRES 300 FIRERES 300 COLDRES 300 ENERGYRES 300","MANA 0.7",6,6,0.6,3600,"Organic","Organic","anim_","icos_Organic"," Organic",0,0,0,0,0,-1,-1,0.3);
AutoSpell("Nimble","Nimble",15,"FRIEND","LOS",0,"LightMagic","NA","DODGING 575 EVADEMELEE 575","MANA 1.0",8,8,1.0,3600,"Nimble","Nimble","anim_","icos_Nimble"," Nimble",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Ninja","Ninja",15,"FRIEND","LOS",0,"LightMagic","NA","MARTIALARTS 575","MANA 1.0",8,8,1.0,3600,"Ninja","Ninja","anim_","icos_Ninja"," Ninja",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Elude","Elude",10,"FRIEND","LOS",0,"LightMagic","NA","AVOIDSTUN 20","MANA 0.9",5,5,0.9,3600,"Elude","Elude","anim_","icos_Elude"," Elude",0,0,0,0,0,1,100,0.1);
AutoSpell("Maneuver","Maneuver",10,"FRIEND","LOS",0,"LightMagic","NA","AVOIDCRIT 20","MANA 0.9",5,5,0.9,3600,"Maneuver","Maneuver","anim_","icos_Maneuver"," Maneuver",0,0,0,0,0,1,100,0.1);
AutoSpell("Immortal","Immortal",10,"FRIEND","LOS",0,"LightMagic","NA","UNDEADPROT 10","MANA 0.9",5,5,0.9,3600,"Immortal","Immortal","anim_","icos_Immortal"," Immortal",0,0,0,0,0,1,100,0.1);
AutoSpell("Elude","Elude",15,"FRIEND","LOS",0,"LightMagic","NA","INCEVASION 100","MANA 1.1",6,6,1.1,3600,"Elude","Elude","anim_","icos_Elude"," Elude",10,0,0,0,0,-1,-1,0.5);
AutoSpell("Avoidance","Avoidance",15,"FRIEND","LOS",0,"LightMagic","NA","EVASION 1000","MANA 1.1",6,6,1.1,3600,"Avoidance","Avoidance","anim_","icos_Avoidance"," Avoidance",10,0,0,0,0,-1,-1,0.5);
AutoSpell("Illuminate","Illuminate",10,"FRIEND","SELF",0,"LightMagic","NA","LIGHTMAGIC 287","MANA 1.1",8,8,1.1,3600,"Illuminate","Illuminate","anim_","icos_Illuminate"," Illuminate",0,0,0,0,0,-1,-1,0.5);

// RITUAL ==============================================================================================================================================
AutoSpell("Foresee","Foresee",10,"FRIEND","LOS",0,"Ritual","NA","ADDEXP 30","MANA 0.8",3,3,0.8,1800,"Foresee","Foresee","anim_","icos_Foresee"," Foresee",0,0,0,0,0,1,100,0);
AutoSpell("Robbery","Robbery",10,"FRIEND","LOS",0,"Ritual","NA","GOLDFIND 50","MANA 0.8",3,3,0.8,1800,"Robbery","Robbery","anim_","icos_Robbery"," Robbery",5,0,0,0,0,1,100,0);
AutoSpell("Lightstep","Lightstep",10,"FRIEND","LOS",0,"Ritual","NA","MAXWEIGHT 1000","MANA 0.8",5,5,0.8,3600,"Lightstep","Lightstep","anim_","icos_Lightstep"," Lightstep",5,0,0,0,0,-1,-1,0.4);
AutoSpell("Barter","Barter",15,"FRIEND","LOS",0,"Ritual","NA","HAGGLING 575","MANA 0.8",3,3,0.8,3600,"Barter","Barter","anim_","icos_Barter"," Barter",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Grace","Grace",15,"FRIEND","LOS",0,"Ritual","NA","AGILITY 575 SENSE 575","MANA 1.0",7,7,1.0,3600,"Grace","Grace","anim_","icos_Grace"," Grace",10,0,0,0,0,-1,-1,0.5);
AutoSpell("Witchdoctor","Witchdoctor",10,"FRIEND","LOS",0,"Ritual","NA","MINIONHEALTH 50 MINIONDAMAGE 50","MANA 1.2",8,8,1.2,3600,"Witchdoctor","Witchdoctor","anim_","icos_Witchdoctor"," Witchdoctor",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Magnify","Magnify",10,"FRIEND","LOS",0,"Ritual","NA","HEALTHPOTION 20 MANAPOTION 20","MANA 1.0",7,7,1.0,3600,"Magnify","Magnify","anim_","icos_Magnify"," Magnify",0,0,0,0,0,1,100,0);
AutoSpell("Keen","Keen",15,"FRIEND","LOS",0,"Ritual","NA","PERCEPTION 3000","MANA 1.0",3,3,1.0,3600,"Keen","Keen","anim_","icos_Keen"," Keen",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Dice","Dice",10,"FRIEND","LOS",0,"Ritual","NA","PIERCING 172","MANA 1.0",3,3,1.0,3600,"Dice","Dice","anim_","icos_Dice"," Dice",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Discovery","Discovery",10,"FRIEND","LOS",0,"Ritual","NA","MAGICFIND 20","MANA 1.1",6,6,1.1,1800,"Discovery","Discovery","anim_","icos_Discovery"," Discovery",0,0,0,0,0,1,100,0);
AutoSpell("Order","Order",10,"FRIEND","SELF",0,"Ritual","NA","RITUAL 287","MANA 1.1",8,8,1.1,3600,"Order","Order","anim_","icos_Order"," Order",0,0,0,0,0,-1,-1,0.5);

// SORCERY ==============================================================================================================================================
// FIRE ELEMENTAL
// COLD ELEMENTAL
// ENERGY ELEMENTAL
// POISON CASTING
// MELEE CASTING
// PROJECTILE CASTING
AutoSpell("Warlock","Warlock",15,"FRIEND","LOS",0,"Sorcery","NA","MAGICPEN 1500","MANA 1.1",5,5,1.1,1800,"Warlock","Warlock","anim_","icos_Warlock"," Warlock",7,0,0,0,0,-1,-1,0.7);
AutoSpell("Magus","Magus",15,"FRIEND","LOS",0,"Sorcery","NA","MAGICDAMAGE 60","MANA 1.1",7,7,1.1,1800,"Magus","Magus","anim_","icos_Magus"," Magus",7,0,0,0,0,-1,-1,0.3);
AutoSpell("Conjuring","Conjuring",15,"FRIEND","LOS",0,"Sorcery","NA","CASTINIT 575","MANA 0.9",3,3,0.9,3600,"Conjuring","Conjuring","anim_","icos_Conjuring"," Conjuring",0,0,0,0,0,-1,-1,0.3);
AutoSpell("Concentration","Concentration",15,"FRIEND","LOS",0,"Sorcery","NA","SPELLCAPACITY 575","MANA 1.1",8,8,1.1,3600,"Concentration","Concentration","anim_","icos_Magus"," Concentration",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Pyro","Pyro",10,"FRIEND","LOS",0,"Sorcery","NA","FIREDAMAGE% 10 INCBURN 10","MANA 0.9",5,5,0.5,3600,"Pyro","Pyro","anim_","icos_Pyro"," Pyro",0,0,0,0,0,1,100,0.1);
AutoSpell("Iceborn","Iceborn",10,"FRIEND","LOS",0,"Sorcery","NA","COLDDAMAGE% 10 INCCHILL 10","MANA 0.9",5,5,0.5,3600,"Iceborn","Iceborn","anim_","icos_Iceborn"," Iceborn",0,0,0,0,0,1,100,0.1);
AutoSpell("Voltage","Voltage",10,"FRIEND","LOS",0,"Sorcery","NA","ENERGYDAMAGE% 10 INCSHOCK 10","MANA 0.9",5,5,0.5,3600,"Voltage","Voltage","anim_","icos_Voltage"," Voltage",0,0,0,0,0,1,100,0.1);
AutoSpell("Span","Span",15,"FRIEND","LOS",0,"Sorcery","NA","CASTRANGE 50","MANA 1.0",6,6,1.0,3600,"Span","Span","anim_","icos_Span"," Span",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Entangle","Entangle",10,"FRIEND","LOS",0,"Sorcery","NA","INCROOT 10","MANA 0.9",5,5,0.5,3600,"Entangle","Entangle","anim_","icos_Entangle"," Entangle",0,0,0,0,0,1,100,0.1);
AutoSpell("Magi","Magi",10,"FRIEND","LOS",0,"Sorcery","NA","STAFFMAGIC 100","MANA 1.1",7,7,1.1,3600,"Magi","Magi","anim_","icos_Magi"," Magi",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Battlemage","Battlemage",10,"FRIEND","LOS",0,"Sorcery","NA","WANDMAGIC 100","MANA 1.1",7,7,1.1,3600,"Battlemage","Battlemage","anim_","icos_Battlemage"," Battlemage",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Exaction","Exaction",10,"FRIEND","LOS",0,"Sorcery","NA","SPELLCRIT 30","MANA 1.1",6,6,1.1,3600,"Exaction","Exaction","anim_","icos_Exaction"," Exaction",5,0,0,0,0,1,100,0.1);
AutoSpell("Siphon","Siphon",10,"FRIEND","LOS",0,"Sorcery","NA","SPELLVAMP 10","MANA 1.1",6,6,1.1,3600,"Siphon","Siphon","anim_","icos_Siphon"," Siphon",5,0,0,0,0,1,100,0.1);
AutoSpell("Meditation","Meditation",15,"FRIEND","LOS",0,"Sorcery","NA","SPCRITDAMAGE 100","MANA 1.1",7,7,1.1,3600,"Meditation","Meditation","anim_","icos_Meditation"," Meditation",15,0,0,0,0,-1,-1,0.3);
AutoSpell("CrystalBall","Crystal Ball",15,"FRIEND","SELF",0,"Sorcery","NA","SORCERY 287","MANA 1.0",5,5,1.0,3600,"CrystalBall","CrystalBall","anim_","icos_CrystalBall"," CrystalBall",0,0,0,0,0,-1,-1,0.5);
//***************************************************************************************************
AutoSpell("Harvester","Harvester",30,"FRIEND","SELF",0,"Sorcery","NA","","MANA 1.0",5,5,1.0,3600,"Harvester","Harvester","anim_","icos_Harvester","You harvest mana from your surroundings",10,0,0,0,0,-1,-1,0.5,"HEALMANA 1500",10,600);
AutoSpell("Snare","Snare",10,"FOE","LOS",1,"Sorcery","NA","","MANA 0.5",0,1,0.0,5,"Snare","Snare","ANIM_EVADE_NEU","icos_snare","You snare your enemy holding them in place",0,0,0,0,0,1,100,0.0,"","","","ROOT 1");

// AutoSpell(%spell,%dispname,%num,%type,%mode,%hostile,%req,%class,%effect,%take,%cast,%recover,%sc,%dur,%tree,%category,%anim,%ico,%desc,%conv,%rev,%silent,%ticks,%durstep,%start,%max,%lvlreq,%dot,%dotint,%dotticks)

// PROTECTION ==============================================================================================================================================
AutoSpell("Commanding","Commanding",10,"FRIEND","LOS",0,"Protection","NA","ADDALLDEF 100","MANA 1.1",5,5,1.1,3600,"Commanding","Commanding","anim_","icos_Commanding"," Commanding",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Sourcevoid","Sourcevoid",10,"FRIEND","LOS",0,"Protection","NA","ALLRESIST 700","MANA 0.9",6,6,0.9,3600,"Sourcevoid","Sourcevoid","anim_","icos_Sourcevoid"," Sourcevoid",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Resonance","Resonance",10,"FRIEND","LOS",0,"Protection","NA","MELEERES 700 PROJRES 700","MANA 0.9",6,6,0.9,3600,"Resonance","Resonance","anim_","icos_Resonance"," Resonance",21,0,0,0,0,-1,-1,0.5);
AutoSpell("Diffraction","Diffraction",10,"FRIEND","LOS",0,"Protection","NA","FIRERES 700 COLDRES 700 POISONRES 700 ENERGYRES 700","MANA 0.9",6,6,0.9,3600,"Diffraction","Diffraction","anim_","icos_Diffraction"," Diffraction",21,0,0,0,0,-1,-1,0.5);
AutoSpell("Isolation","Isolation",10,"FRIEND","LOS",0,"Protection","NA","SPELLRESISTANCE 575","MANA 1.25",8,8,1.25,3600,"Isolation","Isolation","anim_","icos_Isolation"," Isolation",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Lightguard","Lightguard",10,"FRIEND","LOS",0,"Protection","NA","BLOCKSPELL% 10 SPLBLOCKAMM 300 SPLBLOCKREC 30","MANA 1.1",8,8,1.1,3600,"Lightguard","Lightguard","anim_","icos_Lightguard"," Lightguard",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Responsive","Responsive",10,"FRIEND","LOS",0,"Protection","NA","AVOIDROOT 20","MANA 0.8",4,4,0.4,1800,"Responsive","Responsive","anim_","icos_Responsive"," Responsive",15,0,0,0,0,1,200,0.2);
AutoSpell("Overheat","Overheat",10,"FRIEND","LOS",0,"Protection","NA","AVOIDCHILL 20","MANA 0.8",4,4,0.4,1800,"Overheat","Overheat","anim_","icos_Overheat"," Overheat",15,0,0,0,0,1,200,0.2);
AutoSpell("Frostbite","Frostbite",10,"FRIEND","LOS",0,"Protection","NA","AVOIDBURN 20","MANA 0.8",4,4,0.4,1800,"Frostbite","Frostbite","anim_","icos_Frostbite"," Frostbite",15,0,0,0,0,1,200,0.2);
AutoSpell("Widowbite","Widowbite",10,"FRIEND","LOS",0,"Protection","NA","AVOIDPOISON 20","MANA 0.8",4,4,0.4,1800,"Widowbite","Widowbite","anim_","icos_Widowbite"," Widowbite",15,0,0,0,0,1,200,0.2);
AutoSpell("Anchored","Anchored",10,"FRIEND","LOS",0,"Protection","NA","AVOIDSHOCK 20","MANA 0.8",4,4,0.4,1800,"Anchored","Anchored","anim_","icos_Anchored"," Anchored",15,0,0,0,0,1,200,0.2);
AutoSpell("Barrier","Barrier",10,"FRIEND","LOS",0,"Protection","NA","ABSORB 1000","MANA 1.1",5,5,0.5,300,"Barrier","Barrier","anim_","icos_Barrier"," Barrier",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Beastmaster","Beastmaster",10,"FRIEND","LOS",0,"Protection","NA","BEASTPROT 10","MANA 0.7",3,3,0.3,1800,"Beastmaster","Beastmaster","anim_","icos_Beastmaster"," You gain some protection from beasts",0,0,0,0,0,1,100,0.1);
AutoSpell("Voidling","Voidling",15,"FRIEND","LOS",0,"Protection","NA","INCRESIST 100","MANA 1.1",8,8,1.1,3600,"Voidling","Voidling","anim_","icos_Voidling"," Voidling",15,0,0,0,0,-1,-1,0.3);
AutoSpell("Deny","Deny",10,"FRIEND","LOS",0,"Protection","NA","SPELLINTURUPT 20","MANA 1.0",6,6,0.8,3600,"Deny","Deny","anim_","icos_Deny"," Deny",15,0,0,0,0,1,200,0.3);
AutoSpell("Drakeguard","Drakeguard",10,"FRIEND","LOS",0,"Protection","NA","SHIELDBONUS 30","MANA 1.0",7,7,0.8,3600,"Drakeguard","Drakeguard","anim_","icos_Drakeguard"," Drakeguard",20,0,0,0,0,-1,-1,0.3);
AutoSpell("Restriction","Restriction",10,"FRIEND","LOS",0,"Protection","NA","AVOIDSPCRIT 10","MANA 1.0",6,6,0.6,1800,"Restriction","Restriction","anim_","icos_Restriction"," Restriction",0,0,0,0,0,1,100,0.2);
AutoSpell("Preservation","Preservation",10,"FRIEND","SELF",0,"Protection","NA","PROTECTION 287","MANA 1.0",7,7,1.0,3600,"Preservation","Preservation","anim_","icos_Preservation"," Preservation",0,0,0,0,0,-1,-1,0.5);

// ENCHANTMENT ==============================================================================================================================================
AutoSpell("Sourcetap","Sourcetap",15,"FRIEND","LOS",0,"Enchantment","NA","MAXMANA 1000","MANA 1.0",6,6,1.0,3600,"Sourcetap","Sourcetap","anim_","icos_Sourcetap"," Sourcetap",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Thoughtful","Thoughtful",5,"FRIEND","LOS",0,"Enchantment","NA","ADDEXP 15","MANA 0.7",6,6,0.5,1800,"Thoughtful","Thoughtful","anim_","icos_Thoughtful"," Thoughtful",0,0,0,0,0,1,150,0.1);
AutoSpell("Charm","Charm",10,"FRIEND","LOS",0,"Enchantment","NA","MAGICFIND 30","MANA 0.8",6,6,0.6,1800,"Charm","Charm","anim_","icos_Charm"," Charm",0,0,0,0,0,1,200,0.1);
AutoSpell("Sourceforge","Sourceforge",10,"FRIEND","LOS",0,"Enchantment","NA","MANADELTA 200","MANA 1.0",7,7,1.0,3600,"Sourceforge","Sourceforge","anim_","icos_Sourceforge"," Sourceforge",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Compression","Compression",10,"FRIEND","LOS",0,"Enchantment","NA","MANACOST 20","MANA 1.0",6,6,0.5,3600,"Compression","Compression","anim_","icos_Compression"," Compression",0,0,0,0,0,1,200,0.1);
AutoSpell("Dredge","Dredge",10,"FRIEND","LOS",0,"Enchantment","NA","MINING 575","MANA 0.8",5,5,0.6,3600,"Dredge","Dredge","anim_","icos_Dredge"," Dredge",0,0,0,0,0,-1,-1,0.4);
AutoSpell("Professor","Professor",10,"FRIEND","LOS",0,"Enchantment","NA","SPEECH 575 LITERACY 575","MANA 0.8",6,6,0.6,1800,"Professor","Professor","anim_","icos_Professor"," Professor",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Transit","Transit",10,"FRIEND","LOS",0,"Enchantment","NA","SENSEHEADING 575","MANA 0.8",6,6,0.6,1800,"Transit","Transit","anim_","icos_Transit"," Transit",0,0,0,0,0,-1,-1,0.4);
AutoSpell("Charisma","Charisma",10,"FRIEND","LOS",0,"Enchantment","NA","ENERGY 575","MANA 1.0",8,8,1.0,3600,"Charisma","Charisma","anim_","icos_Charisma"," Charisma",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Stimulator","Stimulator",10,"FRIEND","LOS",0,"Enchantment","NA","MAXMANA 500 INTELLIGENCE 575 PSYCHIC 575","MANA 1.0",7,7,1.0,3600,"Stimulator","Stimulator","anim_","icos_Stimulator"," Stimulator",21,0,0,0,0,-1,-1,0.5);
AutoSpell("Binding","Binding",10,"FRIEND","LOS",0,"Enchantment","NA","MAGICCRAFT 575","MANA 0.7",6,6,0.6,3600,"Binding","Binding","anim_","icos_Binding"," Binding",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Mixing","Mixing",10,"FRIEND","LOS",0,"Enchantment","NA","ALCHEMY 575","MANA 0.7",6,6,0.6,3600,"Mixing","Mixing","anim_","icos_Mixing"," Mixing",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Remembrance","Remembrance",15,"FRIEND","LOS",0,"Enchantment","NA","SPELLCAPACITY 575","MANA 0.9",7,7,0.9,3600,"Remembrance","Remembrance","anim_","icos_Remembrance"," Remembrance",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Instinct","Instinct",10,"FRIEND","LOS",0,"Enchantment","NA","PRIMALMAGIC 287","MANA 1.0",7,7,1.0,3600,"Instinct","Instinct","anim_","icos_Instinct"," Instinct",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Darkness","Darkness",10,"FRIEND","LOS",0,"Enchantment","NA","DARKMAGIC 287","MANA 1.0",7,7,1.0,3600,"Darkness","Darkness","anim_","icos_Darkness"," Darkness",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Illusionist","Illusionist",10,"FRIEND","LOS",0,"Enchantment","NA","SORCERY 287","MANA 1.0",7,7,1.0,3600,"Illusionist","Illusionist","anim_","icos_Illusionist"," Illusionist",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Blessed","Blessed",10,"FRIEND","LOS",0,"Enchantment","NA","HOLYMAGIC 287","MANA 1.0",7,7,1.0,3600,"Blessed","Blessed","anim_","icos_Blessed"," You feel Blessed",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Brighten","Brighten",10,"FRIEND","LOS",0,"Enchantment","NA","LIGHTMAGIC 287","MANA 1.0",7,7,1.0,3600,"Brighten","Brighten","anim_","icos_Brighten"," Brighten",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Conservation","Conservation",10,"FRIEND","LOS",0,"Enchantment","NA","PROTECTION 287","MANA 1.0",7,7,1.0,3600,"Conservation","Conservation","anim_","icos_Conservation"," Conservation",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Powerful","Powerful",10,"FRIEND","LOS",0,"Enchantment","NA","EMPOWERMENT 287","MANA 1.0",7,7,1.0,3600,"Powerful","Powerful","anim_","icos_Powerful"," Powerful",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Ceremony","Ceremony",10,"FRIEND","LOS",0,"Enchantment","NA","RITUAL 287","MANA 1.0",7,7,1.0,3600,"Ceremony","Ceremony","anim_","icos_Ceremony"," Ceremony",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Mystic","Mystic",10,"FRIEND","LOS",0,"Enchantment","NA","ENCHANTMENT 575","MANA 1.0",7,7,1.0,3600,"Mystic","Mystic","anim_","icos_Mystic"," Mystic",15,0,0,0,0,-1,-1,0.5);
AutoSpell("Genius","Genius",10,"FRIEND","LOS",0,"Enchantment","NA","MAXMEMORY 100","MANA 1.0",8,8,1.0,3600,"Genius","Genius","anim_","icos_Genius"," Mystic",0,0,0,0,0,1,100,0.3);
AutoSpell("MagicFlask","Magic Flask",10,"FRIEND","LOS",0,"Enchantment","NA","HEALTHPOTION 20 MANAPOTION 20","MANA 0.7",6,6,0.6,3600,"MagicFlask","MagicFlask","anim_","icos_MagicFlask"," MagicFlask",0,0,0,0,0,1,200,0.2);

//====================================================================================================================================================================



function BetterRunningSpell_Unused(%target,%spell)
{
	%line = GetWord($CruSpell[%spell,$CSTree],0);
	%stack = GetWord($CruSpell[%spell,$CSTree],1);
	%curspells = $CurPlayerSpells[%target];
	if (%curspells == "")
		return False;
	%ok = False;
	for (%i = 0; (%cspell = getWord(%curspells,%i)) != -1; %i += 2) {
		%gcastid = GetWord(%curspells,%i + 1);
		%gline = getWord($CruSpell[%cspell,$CSTree],0);
		%gstack = getWord($CruSpell[%cspell,$CSTree],1);
		if (%gline == %line) {
			if (%stack >= %gstack)
				%ok = True;
		}
	}
	return %ok;
}






	for (%i = 1; %i <= 10; %i++) %r[%i] = 0;
	%item = GetCurrentWearFull(%id,13);
	%lvl = fetchData(%id, "LVL");
	%mag = $BPItem[%item,$BPWeaponMagDamage];
	if (%mag == "") {
		%delay = $BPItem[%item,$BPWeaponDelay];
		%damage = $BPItem[%item,$BPDamage];
		%dmgmin = getWord(%damage,0);
		%dmgmax = getWord(%damage,2);
		%dps = round(((%dmgmin + %dmgmax) / 2) / %delay);
		%r[1] = round((%dps / (1500 * (%lvl / 230))) * 1000);
	}
	%r[2] = round((GetBonus(%id,$BPPHYSICALDAMAGE) / (200 * (Cap(%lvl,1,50) / 50))) * 1000);
	%r[3] = round((GetBonus(%id,$BPPHYSBASE) / (1200 * (%lvl / 230))) * 1000);
	%r[4] = round((GetBonus(%id,$BPCRITCHANCE) / (1000 * (%lvl / 230))) * 1000);
	%r[5] = round((GetBonus(%id,$BPCRITDAMAGE) / (1000 * (%lvl / 230))) * 1000);
	%r[6] = (GetBonus(%id,$BPDAMAGEBEAST) + GetBonus(%id,$BPDAMAGEDEMON) + GetBonus(%id,$BPDAMAGEUNDEAD));
	%r[6] = (%r[6] + (GetBonus(%id,$BPDAMAGEELITE) + GetBonus(%id,$BPDAMAGEBOSS))); 
	%r[6] = round((%r[6] / 150) * 1000);
	%r[7] = round((GetBonus(%id,$BPLIFESTEAL) / 30) * 500);
	%r[8] = round((GetBonus(%id,$BPARMORPEN) / (15000 * (%lvl / 230))) * 1000);


function PhysicalRating(%id)
{
	for (%i = 1; %i <= 10; %i++) %r[%i] = 0;
	%item = GetCurrentWearFull(%id,13);
	%lvl = fetchData(%id, "LVL");
	%mag = $BPItem[%item,$BPWeaponMagDamage];
	if (%mag == "") {
		%delay = $BPItem[%item,$BPWeaponDelay];
		%damage = $BPItem[%item,$BPDamage];
		%dmgmin = getWord(%damage,0);
		%dmgmax = getWord(%damage,2);
		%dps = round(((%dmgmin + %dmgmax) / 2) / %delay);
		%r[1] = round((%dps / 1500) * 1000);
	}
	%r[2] = round((GetBonus(%id,$BPPHYSICALDAMAGE) / 200) * 1000);
	%r[3] = round((GetBonus(%id,$BPPHYSBASE) / 1200) * 1000);
	%r[4] = round((GetBonus(%id,$BPCRITCHANCE) / 1000) * 1000);
	%r[5] = round((GetBonus(%id,$BPCRITDAMAGE) / 1000) * 1000);
	%r[6] = round((GetBonus(%id,$BPLIFESTEAL) / 30) * 1000);
	%r[7] = round((GetBonus(%id,$BPARMORPEN) / 30000) * 1000);
	return round((%r[1] + %r[2] + %r[3] + %r[4] + %r[5] + %r[6] + %r[7]) / 7);
}


// LOOT 

$HARDMF = 0;

function TestMT(%i)
{
	%lowest = 1;
	%highest = 0;
	for (%v = 0; %v <= %i; %v++) {
		%r = GetRandomMT() * 1.0;
		if (%r < %lowest) %lowest = %r;
		if (%r > %highest) %highest = %r;
	}
	echo(" LOWEST " @ %lowest);
	echo(" HIGHEST " @ %highest);			
}

function GetMagicFind(%id)
{
	if ((%aiowner = $CruAI[%id,$AiOwner]) != "")
		%id = %aiowner;
	return $MagicFind[%id];
}

function GetGoldFind(%id)
{
	if ((%aiowner = $CruAI[%id,$AiOwner]) != "")
		%id = %aiowner;
	return $GoldFind[%id];
}

function RefreshMagicFind(%id,%gold)
{
	if (%gold != True)
		%list = $MagicFindList[%id];
	else
		%list = $GoldFindList[%id];
	if (%list == "") {
		if (%gold != True)
			$MagicFindList[%id] = "0 0 0 0 0 0 0 0 0 0";
		else
			$GoldFindList[%id] = "0 0 0 0 0 0 0 0 0 0";
	}
	%t = 0;
	for (%i = 0; %i <= 9; %i++)
		%t += getWord(%list,%i);
	if (%gold != True)
		$MagicFind[%id] = Cap(round(%t/10),0,1000);
	else
		$GoldFind[%id] = Cap(round(%t/10),0,1000);
}

function UpdateMagicFind(%id,%gold)
{
	if (%gold != True)
		%list = $MagicFindList[%id];
	else
		%list = $GoldFindList[%id];
	%newlist = "";
	if (%gold != True)
		%mf = GetBonus(%id,$BPMAGICFIND);
	else
		%mf = GetBonus(%id,$BPGOLDFIND);
	for (%i = 1; %i <= 9; %i++)
		%newlist = %newlist @ getWord(%list,%i) @ " ";
	%newlist = %newlist @ %mf;
	if (%gold != True)
		$MagicFindList[%id] = %newlist;
	else
		$GoldFindList[%id] = %newlist;
	RefreshMagicFind(%id,%gold);
}

function UpdateMonsterFind(%aiId,%id,%damage)
{
	%ailvl = fetchData(%aiId,"LVL");
	%idlvl = fetchData(%id,"LVL");
	%mod = %ailvl / %idlvl;
	if (%mod > 1.5) %mod = 1.5;
	if (%mod < 0.5) %mod = 0.5;
	%maxhp = fetchData(%aiId,"MaxHP");
	%p = Cap((%damage / %maxhp),0,1);
	%mf = GetMagicFind(%id);
	if ($ELITE[%aiId]) %mf += 100;
	if ($BOSS[%aiId]) %mf += 300;
	$MonsterMagic[%aiId] += round((%mf * %mod) * %p);
	%gf = GetGoldFind(%id);
	if ($ELITE[%aiId]) %gf += 100;
	if ($BOSS[%aiId]) %gf += 300;
	$MonsterGold[%aiId] += round((%gf * %mod) * %p);	
}

function Loot::Overall(%n,%mf,%lvl)
{
	echo("=============================================================");
	echo(" LOOT::OVERALL " @ %n @ " " @ %mf);
	%mf = 1 + (%mf / 100);
	%looton = 0;
	if (%lvl == "" || %lvl < 1) %lvl = 1;
	for (%i = 0; %i <= %n; %i++)
		%loot[%i] = Loot::DetermineLoot(0,%mf,%lvl);
	for (%i = 0; %i <= %n; %i++)
		if (%loot[%i] != "") echo(%loot[%i]);
	echo("=============================================================");
}

function Loot::DetermineLoot(%id,%mf,%lvl,%f)
{
	%loot = "";
	%count = Loot::GrabLootCount(%mf);
	if (%count > 0) {
		for (%i = 1; %i <= %count; %i++) {
			%add = Loot::GrabLoot(%mf,%lvl,%f);
			if (%add != "-1")
				%loot = %loot @ %add @ " 1 ";
		}
	}
	return %loot;
}

function Loot::Ratio(%n,%x,%mf,%m)
{
	if (%mf<1) %mf = 1;
	%x = floor(%x/%mf);
	if (%x<1) %x = 1;
	if (%m && %x<%m) %x = %m;
	%r = MTRB(1,%x);
	if (%r == 1)
		return True;
	else
		return False;
}

function GetLootCoins(%lvl,%id)
{
	%m = round(100 * (%lvl / 300));
	%gold = $MonsterGold[%id];
	if (%gold < 0) %gold = 0;
	%m = round(%m * (1 + MaxCap(%gold,1000) / 100));
	return RandBetween(1,%m);
}

function CreateMerchantLoot(%merchant,%type,%count,%mf,%min,%max)
{
	%loot = "";
	%mf = 1 + (%mf / 100);
	for (%i = 1; %i <= %count; %i++) {
		%lvl = RandBetween(%min,%max);
		%r = MTRB(1,320);
		if (%r <= 320) %tier = 0;
		if (%r <= 160) %tier = 1;
		if (%r <= 80) %tier = 2;
		if (%r <= 40) %tier = 3;
		if (%r <= 20) %tier = 4;
		if (%r <= 10) %tier = 5;
		if (%r == 1) %tier = 6;
		if (%type == "weapon")
			%loot = %loot @ Loot::Weapon(%tier,%mf,%lvl) @ " 1 ";
		if (%type == "spell")
			%loot = %loot @ Loot::Spell(%lvl) @ " 1 ";
		if (%type == "armor") {
			%armor = Loot::Armor(%tier,%mf);
			%armor = TierItem::RandomItem(%armor,%lvl);
			%loot = %loot @ %armor @ " 1 ";
		}
		if (%type == "plan") {
			if (%tier < 1) %tier = 1;
			%plan = Loot::Plan(%tier,%lvl);
			%loot = %loot @ %plan @ " 1 ";
		} 
	}
	//echo(" LOOT " @ %loot);
	$BPMerchantShop[%merchant] = %loot;
}

function CreateLoot(%id,%mf,%n,%lvl,%f,%merchant)
{
	if (%lvl == "") %lvl = 100;
	if (%f == "") %f = 0.1;
	%loot = "";
	%mf = ((1 + $HARDMF) + (%mf / 100));
	if (%n == "") %n = 0;
	for (%i = 0; %i <= %n; %i++)
		%loot = %loot @ Loot::DetermineLoot(0,%mf,%lvl,%f);
	if (%merchant == "")
		$PlayerBackpack[%id] = %loot;
	else {
		if ($BPItem["999HealthPotion",$BPName] == "") {
			DynamicItem::InitWear("999HealthPotion");
			DynamicItem::InitWear("999EnergyVial");
		}
		%loot = "999HealthPotion 1 999EnergyVial 1 " @ %loot;
		$BPMerchantShop[%merchant] = %loot;
	}
}

function Loot::GrabLootCount(%mf)
{
	%count = 0;
	if (Loot::Ratio(1,3,%mf) == True) %count = 1;
	if (Loot::Ratio(1,6,%mf) == True) %count = 2;
	if (Loot::Ratio(1,12,%mf) == True) %count = 3;
	if (Loot::Ratio(1,24,%mf) == True) %count = 4;
	if (Loot::Ratio(1,48,%mf) == True) %count = 5;
	return MTRB(0,%count);
}

function Loot::GrabLoot(%mf,%lvl,%f,%hard)
{
	%tier = Loot::GrabTier(%mf);
	%type = Loot::GrabType(%mf);
	%ql = Loot::GrabQL(%lvl,%f);
	if (%hard != "") {
		%ql = %hard;
		%lvl = %ql;
	}
	if (%type == "BODY") {
		if (%tier >= 0 && %tier <= 6) {
			%i = Loot::Body(%tier,%mf);
			//echo(" LOOT BODY " @ %i);
			return TierItem::RandomItem(%i,%ql);
		}
	}
	if (%type == "MAGIC") {
		if (%tier >= 0 && %tier <= 6) {
			%i = Loot::Magic(%tier,%mf);
			//echo(" LOOT MAGIC " @ %i);
			return TierItem::RandomItem(%i,%ql);
		}
	}
	if (%type == "SPELL") {
		return Loot::Spell(%lvl);
	}
	if (%type == "WEAPON") {
		if (%tier >= 0 && %tier <= 6) {
			//echo(" LOOT WEAPON " @ %i);
			return Loot::Weapon(%tier,%mf,%ql);
		}
	}
	if (%type == "EXTRA") {
		%d = RandBetween(1,3);
		if (%d == 1) {
			if (%tier >= 0 && %tier <= 6) {
				%i = Loot::Armor(%tier,%mf);
				//echo(" LOOT ARMOR " @ %i);
				return TierItem::RandomItem(%i,%ql);
			}
		}
		else if (%d == 2) {
			if (%tier >= 0 && %tier <= 6) {
				%i = Loot::Shield(%tier,%mf);
				//echo(" LOOT SHIELD " @ %i);
				return TierItem::RandomItem(%i,%ql);
			}
		}
		if (%d == 3) {
			%v = Loot::Integrity();
			DynamicItem::InitWear(%v);
			return %v;
		}
	}
	if (%type == "RUNE") {
		return Loot::Rune(%mf,%ql);
	}
	if (%type == "MAP") {
		return Loot::Map(%tier,%ql);
	}
	if (%type == "RELIC") {
		return Loot::Relic(%tier);
	}
	if (%type == "PLAN") {
		return Loot::Plan(%tier,%ql);
	}
	return "-1";
	return %tier @ %type;
}

$GrabTypeSet[0] = "BODY";
$GrabTypeSet[1] = "BODY EXTRA";
$GrabTypeSet[2] = "BODY EXTRA MAGIC";
$GrabTypeSet[3] = "BODY EXTRA MAGIC SPELL";
$GrabTypeSet[4] = "BODY EXTRA MAGIC SPELL WEAPON PLAN";
$GrabTypeSet[5] = "BODY EXTRA MAGIC SPELL WEAPON PLAN RELIC";
$GrabTypeSet[6] = "BODY EXTRA MAGIC SPELL WEAPON PLAN RELIC RUNE";
$GrabTypeSet[7] = "BODY EXTRA MAGIC SPELL WEAPON PLAN RELIC RUNE MAP";

function TestLootGrab(%i,%mf)
{
	%MAP = 0;
	%RUNE = 0;
	%RELIC = 0;
	%PLAN = 0;
	%WEAPON = 0;
	%SPELL = 0;
	%EXTRA = 0;
	%MAGIC = 0;
	%BODY = 0;
	for (%v = 0; %v <= %i; %v++) {
		%COUNT = Loot::GrabLootCount(%mf);
		if (%COUNT) {
			for (%x = 1; %x <= %COUNT; %x++) {
				%ret = Loot::GrabType(%mf);
				if (%ret == "MAP") %MAP++;
				if (%ret == "RUNE") %RUNE++;
				if (%ret == "RELIC") %RELIC++;
				if (%ret == "PLAN") %PLAN++;
				if (%ret == "WEAPON") %WEAPON++;
				if (%ret == "SPELL") %SPELL++;
				if (%ret == "EXTRA") %EXTRA++;
				if (%ret == "MAGIC") %MAGIC++;
				if (%ret == "BODY") %BODY++;
			}
		}
	}
	echo("MAP " @ %map);
	echo("RUNE " @ %rune);
	echo("RELIC " @ %relic);
	echo("PLAN " @ %plan);
	echo("WEAPON " @ %weapon);
	echo("SPELL " @ %spell);
	echo("EXTRA " @ %extra);
	echo("MAGIC " @ %magic);
	echo("BODY " @ %body);
}

function Loot::GrabType7(%mf)
{
	%x = MTRB(1,1000);
	%RET = "BODY";
	if (%x <= 500) {
		if (MTRB(1,2) == 1) %RET = "MAGIC";
		else %RET = "EXTRA";
	}
	if (%x <= 300) {
		if (MTRB(1,2) == 1) %RET = "WEAPON";
		else %RET = "SPELL";
	}
	if (%x <= 50) %RET = "PLAN";
	if (%x <= 30) %RET = "RELIC";
	if (%x <= 15) %RET = "RUNE";
	if (%x <= 5) %RET = "MAP";
	return %RET;
}

function Loot::GrabType(%mf)
{	
	%x = MTRB(1,1000);
	if (%x <= 5) return "MAP";
	if (%x <= 30) return "RUNE";
	if (%x <= 80) return "RELIC";
	if (%x <= 130) return "PLAN";
	if (%x <= 330) {
		if (MTRB(1,2) == 1) return "WEAPON";
		else return "SPELL";
	}
	if (%x <= 630) {
		if (MTRB(1,2) == 1) return "MAGIC";
		else return "EXTRA";
	}
	return "BODY";
}

function Loot::GrabType6(%mf)
{
	%x = MTRB(1,100);
	if (%x >= 1 && %x <= 25) return "BODY";
	if (%x >= 26 && %x <= 51) {
		if (MTRB(1,2) == 1) return "EXTRA";
		else return "MAGIC";
	}
	if (%x >= 52 && %x <= 72) {
		if (MTRB(1,2) == 1) return "WEAPON";
		else return "SPELL";
	}
	if (%x >= 73 && %x <= 83) return "PLAN";
	if (%x >= 84 && %x <= 92) return "RELIC";
	if (%x >= 93 && %x <= 97) return "RUNE";
	if (%x >= 98 && %x <= 100) return "MAP";
}

function Loot::GrabType5(%mf)
{
	%x = GetRandomMT() * 1.0;
	if (%mf > 4.5) %mf = 4.5;
	if (%x <= (0.0066 * %mf)) return "MAP";
	if (%x <= (0.0100 * %mf)) return "RUNE";
	if (%x <= (0.0200 * %mf)) return "RELIC";
	if (%x <= (0.0333 * %mf)) return "PLAN";
	if (%x <= (0.1000 * %mf)) {
		if (MTRB(1,2) == 1) return "WEAPON";
		else return "SPELL";
	}
	if (%x <= (0.2000 * %mf)) {
		if (MTRB(1,2) == 1) return "EXTRA";
		else return "MAGIC";
	}
	return "BODY";
}

function Loot::GrabType4(%mf)
{
	%max = 512;
	%x = MTRB(1,%max);
	if (%mf > 3.5) %mf = 3.5;
	if (%x <= round(%max * (0.00195 * %mf))) return "MAP";
	if (%x <= round(%max * (0.00390 * %mf))) return "RUNE";
	if (%x <= round(%max * (0.00781 * %mf))) return "RELIC";
	if (%x <= round(%max * (0.01562 * %mf))) return "PLAN";
	if (%x <= round(%max * (0.03125 * %mf))) return "WEAPON";
	if (%x <= round(%max * (0.06250 * %mf))) return "SPELL";
	if (%x <= round(%max * (0.12500 * %mf))) return "MAGIC";
	if (%x <= round(%max * (0.25000 * %mf))) return "EXTRA";
	return "BODY";
}

function Loot::GrabType3(%mf)
{
	%v = "BODY";
	if (Loot::Ratio(1,4,%mf,2) == True) { %v = "EXTRA"; }
	if (Loot::Ratio(1,8,%mf,4) == True) { %v = "MAGIC"; }
	if (Loot::Ratio(1,16,%mf,8) == True) { %v = "SPELL"; }
	if (Loot::Ratio(1,32,%mf,16) == True) { %v = "WEAPON"; }
	if (Loot::Ratio(1,64,%mf,32) == True) { %v = "PLAN"; }
	if (Loot::Ratio(1,128,%mf,64) == True) { %v = "RELIC"; }
	if (Loot::Ratio(1,256,%mf,128) == True) { %v = "RUNE"; }
	if (Loot::Ratio(1,512,%mf,256) == True) { %v = "MAP"; }
	return(%v);
}

function Loot::GrabType2(%mf)
{
	%t = 0;
	%v = "BODY ";
	if (Loot::Ratio(1,5,%mf) == True) { %v = %v @ "EXTRA "; %t++; }
	if (Loot::Ratio(1,10,%mf) == True) { %v = %v @ "MAGIC "; %t++; }
	if (Loot::Ratio(1,20,%mf) == True) { %v = %v @ "SPELL "; %t++; }
	if (Loot::Ratio(1,38,%mf) == True) { %v = %v @ "WEAPON PLAN "; %t+=2; }
	if (Loot::Ratio(1,80,%mf) == True) { %v = %v @ "RELIC "; %t++; }
	if (Loot::Ratio(1,160,%mf) == True) { %v = %v @ "RUNE "; %t++; }
	if (Loot::Ratio(1,320,%mf) == True) { %v = %v @ "MAP "; %t++; }
	%x = MTRB(0,%t);
	echo(" V " @ %v);
	return getWord(%v,%x);
}

function Loot::GrabTier(%mf)
{
	%t = 0;
	if (Loot::Ratio(1,5,%mf) == True) %t = 1;
	if (Loot::Ratio(1,10,%mf) == True) %t = 2;
	if (Loot::Ratio(1,20,%mf) == True) %t = 3;
	if (Loot::Ratio(1,40,%mf) == True) %t = 4;
	if (Loot::Ratio(1,120,%mf) == True) %t = 5;
	if (Loot::Ratio(1,360,%mf) == True) %t = 6;
	if (Loot::Ratio(1,1080,%mf) == True) %t = 7;
	if (Loot::Ratio(1,3240,%mf) == True) %t = 8;
	////////////////////////////////////////////////
	if (%t > 6) %t = 6;
	////////////////////////////////////////////////
	return %t;
}

function Loot::Integrity()
{
	%set = "ArmourScrap SpoolOfThread PieceOfCloth";
	%r = RandBetween(0,2);
	return "999" @ getWord(%set,%r);
}

function Loot::Relic(%tier)
{
	if (%tier <= 2) { %set = "AlteringRelic RegalRelic"; %n = 1; }
	if (%tier == 3) { %set = "HavocRelic ScouringRelic"; %n = 1; }
	if (%tier == 4) { %set = "ChaosRelic CosmicRelic BlessedRelic"; %n = 3; }
	if (%tier == 5) { %set = "AnarchyRelic HeroicRelic DivineRelic"; %n = 2; }
	if (%tier >= 6) { %set = "MysticRelic RunePrism"; %n = 1; }
	%r = MTRB(0,%n);
	return "999" @ getWord(%set,%r);
}

function Loot::Rune(%mf,%ql)
{
	%r = floor(getRandom() * $CRURUNELOOTCOUNT + 1);
	%rune = $CRURUNELOOT[%r];
	return Rune::Random(%rune,%ql);
}

function Loot::Map(%tier,%ql)
{
	return TierItem::RandomMap(%tier,%ql);
}

function Loot::Plan(%tier,%ql)
{
	if (%tier < 1) %tier = 1;
	%n = $PlanLootOn[%tier];
	%r = MTRB(1,%n);
	%ret = $PLANLOOT[%tier,%r];
	return Plan::Create(%ret,%ql);
}

function Loot::Weapon(%tier,%mf,%lvl)
{
	%r = floor(getRandom() * 8 + 1);
	if (%r == 1)
		return Loot::Slashing(%tier,%mf,%lvl);
	else if (%r == 2)
		return Loot::Piercing(%tier,%mf,%lvl);
	else if (%r == 3)
		return Loot::Bludgeoning(%tier,%mf,%lvl);
	else if (%r == 4)
		return Loot::Bow(%tier,%mf,%lvl);
	else if (%r == 5)
		return Loot::Crossbow(%tier,%mf,%lvl);
	else if (%r == 6)
		return Loot::Wand(%tier,%mf,%lvl);
	else if (%r == 7)
		return Loot::Focus(%tier,%mf,%lvl);
	else if (%r == 8)
		return Loot::TwoHandSlash(%tier,%mf,%lvl);
}

function Loot::Slashing(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,5,%mf) == True) %t = 2;
	if (Loot::Ratio(1,10,%mf) == True) %t = 3;
	if (Loot::Ratio(1,20,%mf) == True) %t = 4;
	if (Loot::Ratio(1,40,%mf) == True) %t = 5;
	if (Loot::Ratio(1,80,%mf) == True) %t = 6;
	if (Loot::Ratio(1,160,%mf) == True) %t = 7;
	if (Loot::Ratio(1,320,%mf) == True) %t = 8;
	%ret = $WeaponLootTable[Slashing,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Piercing(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,5,%mf) == True) %t = 2;
	if (Loot::Ratio(1,10,%mf) == True) %t = 3;
	if (Loot::Ratio(1,20,%mf) == True) %t = 4;
	if (Loot::Ratio(1,40,%mf) == True) %t = 5;
	if (Loot::Ratio(1,80,%mf) == True) %t = 6;
	if (Loot::Ratio(1,160,%mf) == True) %t = 7;
	if (Loot::Ratio(1,320,%mf) == True) %t = 8;
	%ret = $WeaponLootTable[Piercing,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Bludgeoning(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,5,%mf) == True) %t = 2;
	if (Loot::Ratio(1,10,%mf) == True) %t = 3;
	if (Loot::Ratio(1,20,%mf) == True) %t = 4;
	if (Loot::Ratio(1,40,%mf) == True) %t = 5;
	if (Loot::Ratio(1,80,%mf) == True) %t = 6;
	if (Loot::Ratio(1,160,%mf) == True) %t = 7;
	if (Loot::Ratio(1,320,%mf) == True) %t = 8;
	%ret = $WeaponLootTable[Bludgeoning,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Bow(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,30,%mf) == True) %t = 2;
	if (Loot::Ratio(1,60,%mf) == True) %t = 3;
	if (Loot::Ratio(1,120,%mf) == True) %t = 4;
	if (Loot::Ratio(1,240,%mf) == True) %t = 5;
	%ret = $WeaponLootTable[Bow,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Crossbow(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,30,%mf) == True) %t = 2;
	if (Loot::Ratio(1,60,%mf) == True) %t = 3;
	if (Loot::Ratio(1,120,%mf) == True) %t = 4;
	if (Loot::Ratio(1,240,%mf) == True) %t = 5;
	%ret = $WeaponLootTable[Crossbow,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Wand(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,30,%mf) == True) %t = 2;
	if (Loot::Ratio(1,60,%mf) == True) %t = 3;
	if (Loot::Ratio(1,120,%mf) == True) %t = 4;
	if (Loot::Ratio(1,240,%mf) == True) %t = 5;
	if (Loot::Ratio(1,480,%mf) == True) %t = 6;
	%ret = $WeaponLootTable[Wand,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Focus(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,30,%mf) == True) %t = 2;
	if (Loot::Ratio(1,60,%mf) == True) %t = 3;
	if (Loot::Ratio(1,120,%mf) == True) %t = 4;
	if (Loot::Ratio(1,240,%mf) == True) %t = 5;
	if (Loot::Ratio(1,480,%mf) == True) %t = 6;
	%ret = $WeaponLootTable[Focus,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::TwoHandSlash(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,30,%mf) == True) %t = 2;
	if (Loot::Ratio(1,60,%mf) == True) %t = 3;
	if (Loot::Ratio(1,120,%mf) == True) %t = 4;
	if (Loot::Ratio(1,240,%mf) == True) %t = 5;
	%ret = $WeaponLootTable["2HSlashing",%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Magic(%tier,%mf)
{
	%t = 1;
	if (Loot::Ratio(1,5,%mf) == True) %t = 2;
	if (Loot::Ratio(1,10,%mf) == True) %t = 3;
	if (Loot::Ratio(1,20,%mf) == True) %t = 4;
	if (Loot::Ratio(1,40,%mf) == True) %t = 5;
	if (Loot::Ratio(1,60,%mf) == True) %t = 6;
	if (Loot::Ratio(1,80,%mf) == True) %t = 7;
	if (Loot::Ratio(1,100,%mf) == True) %t = 8;
	if (Loot::Ratio(1,120,%mf) == True) %t = 9;
	if (Loot::Ratio(1,140,%mf) == True) %t = 10;
	if (Loot::Ratio(1,160,%mf) == True) %t = 11;
	if (Loot::Ratio(1,180,%mf) == True) %t = 12;
	if (Loot::Ratio(1,200,%mf) == True) %t = 13;
	if (Loot::Ratio(1,220,%mf) == True) %t = 14;
	if (Loot::Ratio(1,240,%mf) == True) %t = 15;
	if (Loot::Ratio(1,260,%mf) == True) %t = 16;
	if (Loot::Ratio(1,280,%mf) == True) %t = 17;
	if (Loot::Ratio(1,300,%mf) == True) %t = 18;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 4 + 1);
	if (%r == 1) %l = "Amulet";
	else if (%r == 2) %l = "Talisman";
	else if (%r == 3) %l = "Ring";
	else if (%r == 4) %l = "Orb";
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,DYN,%t];
	if (%tier == 0) {
		return %baseloot;
	}
	else {
		%tiername = $TIERNAME[%l,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Body(%tier,%mf)
{
	%t = 1;
	if (Loot::Ratio(1,30,%mf) == True) %t = 2;
	if (Loot::Ratio(1,40,%mf) == True) %t = 3;
	if (Loot::Ratio(1,50,%mf) == True) %t = 4;
	if (Loot::Ratio(1,60,%mf) == True) %t = 5;
	if (Loot::Ratio(1,70,%mf) == True) %t = 6;
	if (Loot::Ratio(1,80,%mf) == True) %t = 7;
	if (Loot::Ratio(1,90,%mf) == True) %t = 8;
	if (Loot::Ratio(1,100,%mf) == True) %t = 9;
	if (Loot::Ratio(1,200,%mf) == True) %t = 10;
	if (Loot::Ratio(1,300,%mf) == True) %t = 11;
	if (Loot::Ratio(1,400,%mf) == True) %t = 12;
	if (Loot::Ratio(1,500,%mf) == True) %t = 13;
	if (Loot::Ratio(1,600,%mf) == True) %t = 14;
	if (Loot::Ratio(1,700,%mf) == True) %t = 15;
	if (Loot::Ratio(1,800,%mf) == True) %t = 16;
	if (Loot::Ratio(1,900,%mf) == True) %t = 17;
	if (Loot::Ratio(1,1000,%mf) == True) %t = 18;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 3 + 1);
	if (%r == 1) %x = "AMR";
	else if (%r == 2) %x = "EVA";
	else if (%r == 3) %x = "RES";
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 5 + 1);
	if (%r == 1) %l = "Head";
	else if (%r == 2) %l = "Chest";
	else if (%r == 3) %l = "Hands";
	else if (%r == 4) %l = "Legs";
	else if (%r == 5) %l = "Boots";
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,%x,%t];
	if (%tier == 0)
		return %baseloot;
	else {
		%tiername = $TIERNAME[%l,%x,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Armor(%tier,%mf)
{
	%t = 1;
	if (Loot::Ratio(1,30,%mf) == True) %t = 2;
	if (Loot::Ratio(1,40,%mf) == True) %t = 3;
	if (Loot::Ratio(1,50,%mf) == True) %t = 4;
	if (Loot::Ratio(1,60,%mf) == True) %t = 5;
	if (Loot::Ratio(1,70,%mf) == True) %t = 6;
	if (Loot::Ratio(1,80,%mf) == True) %t = 7;
	if (Loot::Ratio(1,90,%mf) == True) %t = 8;
	if (Loot::Ratio(1,100,%mf) == True) %t = 9;
	if (Loot::Ratio(1,200,%mf) == True) %t = 10;
	if (Loot::Ratio(1,300,%mf) == True) %t = 11;
	if (Loot::Ratio(1,400,%mf) == True) %t = 12;
	if (Loot::Ratio(1,500,%mf) == True) %t = 13;
	if (Loot::Ratio(1,600,%mf) == True) %t = 14;
	if (Loot::Ratio(1,700,%mf) == True) %t = 15;
	if (Loot::Ratio(1,800,%mf) == True) %t = 16;
	if (Loot::Ratio(1,900,%mf) == True) %t = 17;
	if (Loot::Ratio(1,1000,%mf) == True) %t = 18;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 3 + 1);
	if (%r == 1) %x = "AMR";
	else if (%r == 2) %x = "EVA";
	else if (%r == 3) %x = "RES";
	//------------------------------------------------------------------------
	%l = "Armor";
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,%x,%t];
	if (%tier == 0)
		return %baseloot;
	else {
		%tiername = $TIERNAME[%l,%x,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Shield(%tier,%mf)
{
	%t = 1;
	if (Loot::Ratio(1,10,%mf) == True) %t = 2;
	if (Loot::Ratio(1,20,%mf) == True) %t = 3;
	if (Loot::Ratio(1,40,%mf) == True) %t = 4;
	if (Loot::Ratio(1,80,%mf) == True) %t = 5;
	if (Loot::Ratio(1,160,%mf) == True) %t = 6;
	if (Loot::Ratio(1,320,%mf) == True) %t = 7;
	if (Loot::Ratio(1,640,%mf) == True) %t = 8;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 2 + 1);
	if (%r == 1) %x = "MES";
	else if (%r == 2) %x = "SPS";
	//------------------------------------------------------------------------
	%l = "Shield";
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,%x,%t];
	if (%tier == 0)
		return %baseloot;
	else {
		%tiername = $TIERNAME[%l,%x,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Spell(%lvl)
{
	%ql = Loot::GrabQL(%lvl,0.2);
	%ql = Loot::Round(%ql);
	%x = MTRB(1,3);
	if (%x == 1)
		%ret = Loot::GrabCrystal(%ql);
	if (%x == 2)
		%ret = Loot::GrabSpellBook(%ql);
	if (%x == 3) {
		%ret = DynamicItem::Create("EmptySpellcrystal",%ql);
	}
	return %ret;
}

function Loot::AddWeaponLoot(%req,%loot,%i,%tname)
{
	echo(" LOOT::ADDWEAPONLOOT " @ %req @ " " @ %loot @ " " @ %i @ " " @ %tname);
	$WeaponLootTable[%req,%loot,%i] = %tname;
}

$LootPercConversion["1 50",0] 		= 1;
$LootPercConversion["5 55",0] 		= 2;
$LootPercConversion["10 60",0] 		= 3;
$LootPercConversion["15 65",0] 		= 4;
$LootPercConversion["20 70",0] 		= 5;
$LootPercConversion["25 75",0] 		= 6;
$LootPercConversion["30 80",0] 		= 7;
$LootPercConversion["35 85",0] 		= 8;
$LootPercConversion["40 90",0] 		= 9;
$LootPercConversion["45 95",0] 		= 10;
$LootPercConversion["50 100",0] 	= 11;
$LootPercConversion["55 105",0] 	= 12;
$LootPercConversion["60 110",0] 	= 13;
$LootPercConversion["65 115",0] 	= 14;
$LootPercConversion["70 120",0] 	= 15;
$LootPercConversion["75 125",0] 	= 16;
$LootPercConversion["80 130",0] 	= 17;
$LootPercConversion["85 135",0] 	= 18;

$LootPercConversion["1 50",1] 		= 1;
$LootPercConversion["10 60",1] 		= 2;
$LootPercConversion["20 70",1] 		= 3;
$LootPercConversion["30 80",1] 		= 4;
$LootPercConversion["40 90",1] 		= 5;
$LootPercConversion["50 100",1] 	= 6;
$LootPercConversion["60 110",1] 	= 7;
$LootPercConversion["70 120",1] 	= 8;

function Loot::AddToLoot(%type,%req,%perc,%item,%set,%plan)
{
	echo(" LOOT::ADDTOLOOT " @ %type @ " " @ %req @ " " @ %perc @ " " @ %item @ " " @ %set);
	if (%set == "") %set = 0;
	if (%plan == "") %plan = 0;
	%perc = $LootPercConversion[%perc,%set];
	$LootTable[%type,%req,%perc] = %item;
	if (%plan)
		$LootTable[%type,%req,%perc,%plan] = %item;
}

function Loot::Round(%n)
{
	if (%n < 10) return 10;
	if (%n > 10 && %n < 100)
		return string::getSubStr(%n,0,1) @ "0";
	if (%n > 100)
		return string::getSubStr(%n,0,2) @ "0";
}

function Loot::GrabQL(%lvl,%v)
{
	if (%v == "" || %v < 0) %v = 0.10;
	%f = round(%lvl * %v);
	%r = RandBetween((%lvl-%f),(%lvl+%f));
	if (%r < 1) %r = 1;
	if (%r > 300) %r = 300;
	return %r;
}

function Loot::ResetCrystalLoot()
{
	for (%i = 0; %i <= 300; %i+=10)
		$SpellCrystalLootNum[%i] = 0;
}

function Loot::AddSpellCrystal(%v,%crystal)
{
	echo(" LOOT::ADDSPELLCRYSTAL " @ %v @ " " @ %crystal);
	%n = $SpellCrystalLootNum[%v]++;
	$SpellCrystalLoot[%v,%n] = %crystal;
}

function Loot::GrabCrystal(%l)
{
	%n = $SpellCrystalLootNum[%l];
	%r = RandBetween(1,%n);
	return $SpellCrystalLoot[%l,%r];
}

function Loot::AddSpellBook(%v,%book)
{
	echo(" LOOT::ADDSPELLBOOK " @ %v @ " " @ %book);
	%n = $SpellBookLootNum[%v]++;
	$SpellBookLoot[%v,%n] = %book;
}

function Loot::GrabSpellbook(%l)
{
	%n = $SpellBookLootNum[%l];
	%r = RandBetween(1,%n);
	return $SpellBookLoot[%l,%r];
}

echo("__LOOT LOADED");


echo(" >> TREASURE INIT FOREST ");
$TPOSMAX = 136;
$TREASUREMIN = 1;
$TREASUREMAX = 50;
$TPOS1 = "114.942 3.14929 164.983 -0.786342";
$TPOS10 = "61.7142 37.416 192.25 2.43505";
$TPOS100 = "568.942 -679.983 109.001 1.29649";
$TPOS101 = "599.882 -693.171 109.002 -1.93736";
$TPOS102 = "574.188 -56.4175 105.675 0.0714191";
$TPOS103 = "538.049 -68.1088 101.675 2.4214";
$TPOS104 = "625.706 -20.6914 98.2566 -0.855386";
$TPOS105 = "680.793 197.634 289.7 -0.48533";
$TPOS106 = "461.517 -137.769 123.895 -1.80896";
$TPOS107 = "729.036 -382.271 178.968 0.978936";
$TPOS108 = "870.249 -63.0058 134.104 0.159601";
$TPOS109 = "872.732 -65.127 134.101 -1.46671";
$TPOS11 = "61.1219 48.3912 192.25 0.740691";
$TPOS110 = "861.614 -70.1613 134.101 1.72577";
$TPOS111 = "935.857 -18.6022 -1491.99 -3.11722";
$TPOS112 = "950.245 -18.2511 -1491.99 -3.11722";
$TPOS113 = "974.699 -42.5225 -1499.99 2.5566";
$TPOS114 = "975.114 -24.3539 -1499.99 0.855191";
$TPOS115 = "1051.62 -5.96194 -1491.99 -0.00140458";
$TPOS116 = "1384.6 -484.35 220 2.36736";
$TPOS117 = "1420.45 -555.203 220.267 2.32977";
$TPOS118 = "1445.03 -556.643 220.265 -2.29659";
$TPOS119 = "1433.59 -543.903 220.263 3.09948";
$TPOS12 = "71.1662 17.3123 165 -0.322435";
$TPOS120 = "1462.38 -572.232 220.002 -2.51665";
$TPOS121 = "1409.82 -576.749 220.003 2.97475";
$TPOS122 = "1655.79 -615.468 -1462.99 0.0439755";
$TPOS123 = "1817.79 -614.891 -1484.49 -0.0185807";
$TPOS124 = "1838.09 -617.125 -1484.49 3.12695";
$TPOS125 = "1814.33 -633.924 -1484.99 3.09173";
$TPOS126 = "1777.7 -567.644 -1484.99 -2.3082";
$TPOS127 = "1762.19 -552.254 -1484.99 0.806832";
$TPOS128 = "1758.11 -636.368 -1473.99 2.37767";
$TPOS129 = "1832.12 -704.637 -1495.99 0.013545";
$TPOS13 = "73.1184 -6.99367 165 2.92636";
$TPOS130 = "1838.99 -715.817 -1495.99 2.38907";
$TPOS131 = "1692.52 -723.897 -1506.99 -1.50747";
$TPOS132 = "1655.36 -730.62 -1506.99 -3.10564";
$TPOS133 = "1664.46 -689.283 -1506.99 -0.772086";
$TPOS134 = "1767.45 -715.909 -1484.98 3.13144";
$TPOS135 = "676.567 -736.859 112.409 0.667594";
$TPOS136 = "306.606 -621.916 83.6858 1.05948";
$TPOS14 = "80.801 -3.54697 165 -1.85724";
$TPOS15 = "71.6676 -0.471972 165 1.24545";
$TPOS16 = "87.84 54.711 168.866 1.1304";
$TPOS17 = "158.393 71.3525 147.333 2.56044";
$TPOS18 = "175.893 50.4821 145.633 2.09811";
$TPOS19 = "135.818 -3.31171 161.297 0.675956";
$TPOS2 = "114.433 -1.99573 164.983 -2.36102";
$TPOS20 = "105.684 -5.66189 164.001 -0.0210421";
$TPOS21 = "66.3158 -4.84843 163.828 -0.307361";
$TPOS22 = "76.3435 41.7983 161.193 1.516";
$TPOS23 = "90.6074 45.5962 -1500.99 0.906852";
$TPOS24 = "90.5952 17.8107 -1500.99 2.51437";
$TPOS25 = "118.787 17.1095 -1500.99 -2.23403";
$TPOS26 = "129.642 4.02409 -1500.99 0.962231";
$TPOS27 = "156.928 8.28544 -1500.99 -1.25549";
$TPOS28 = "100.17 -3.35631 -1500.99 1.65772";
$TPOS29 = "96.8978 -12.7554 -1507.99 -0.336164";
$TPOS3 = "109.934 -1.87776 164.983 2.34277";
$TPOS30 = "93.13 -15.0314 -1507.99 0.661209";
$TPOS31 = "72.124 -29.114 -1507.99 2.43535";
$TPOS32 = "73.399 -15.8772 -1507.99 0.0721489";
$TPOS33 = "161.67 -33.0338 160.608 -0.891841";
$TPOS34 = "2.45101 -356.654 74.0398 -1.31206";
$TPOS35 = "-2.53942 -363.86 74.0398 -3.04163";
$TPOS36 = "-3.93613 -352.097 74.0398 0.164936";
$TPOS37 = "-88.6614 -292.469 63.0337 2.45885";
$TPOS38 = "-82.9631 -283.107 63.7635 -0.665244";
$TPOS39 = "61.2237 -279.488 -1514.49 -1.5325";
$TPOS4 = "114.121 2.93535 169.847 -0.000209633";
$TPOS40 = "87.0828 -216.228 -1538.49 -1.52551";
$TPOS41 = "86.9632 -213.59 -1538.49 -1.52551";
$TPOS42 = "30.0622 -234.711 -1534.49 1.47126";
$TPOS43 = "65.8805 -245.009 -1536.49 -1.62418";
$TPOS44 = "107.176 -232.8 -1522.48 -3.13555";
$TPOS45 = "131.023 -211.597 -1522.49 1.17397";
$TPOS46 = "141.335 -272.545 -1524.49 -3.11918";
$TPOS47 = "168.714 -200.328 -1544.49 -2.19552";
$TPOS48 = "118.649 -158.515 -1544.49 -0.338364";
$TPOS49 = "65.1589 -173.725 -1544.49 1.55718";
$TPOS5 = "99.4968 -1.18861 169.847 3.13036";
$TPOS50 = "-161.724 282.427 229.407 2.39082";
$TPOS51 = "-187.628 276.548 222.406 -1.57434";
$TPOS52 = "-198.244 275.963 222.406 1.55477";
$TPOS53 = "-197.142 287.941 229.41 1.53833";
$TPOS54 = "-567.833 484.928 151.043 -0.294743";
$TPOS55 = "-653.076 619.199 -1505.99 -1.49531";
$TPOS56 = "-652.693 614.169 -1505.99 -1.49531";
$TPOS57 = "-657.45 600.08 -1505.99 3.12635";
$TPOS58 = "-667.029 535.947 -1512.17 2.24863";
$TPOS59 = "-621.223 568.089 -1513.99 -0.858506";
$TPOS6 = "99.5042 56.0754 159.67 -1.58286";
$TPOS60 = "-614.684 542.891 -1521.99 2.66014";
$TPOS61 = "-601.483 554.515 -1521.99 -3.06833";
$TPOS62 = "-615.177 577.451 -1521.99 1.53836";
$TPOS63 = "-594.942 583.349 -1521.99 -1.57815";
$TPOS64 = "-676.995 559.353 -1505.99 2.63044";
$TPOS65 = "-1487.49 484.617 136.393 0.34527";
$TPOS66 = "-1550.27 447.078 147.217 -0.278991";
$TPOS67 = "-1561.7 424.357 139.47 -0.925832";
$TPOS68 = "-1561.21 421.046 139.47 -2.24941";
$TPOS69 = "-1571.56 426.196 139.47 0.773831";
$TPOS7 = "61.6177 48.0697 165.25 0.851606";
$TPOS70 = "-1648.92 97.1923 101.709 1.71955";
$TPOS71 = "-1244.46 201.887 58.8983 -1.742";
$TPOS72 = "-1257.27 194.868 58.8983 2.96883";
$TPOS73 = "-1213.61 270.895 50.8974 -1.77662";
$TPOS74 = "-1167.05 184.458 58.8983 -2.42585";
$TPOS75 = "-1201.37 198.69 50.8983 2.93034";
$TPOS76 = "-1219.62 211.376 50.8975 1.31811";
$TPOS77 = "-1157.32 229.471 50.8986 -2.51975";
$TPOS78 = "-1165.96 210.565 50.8983 -0.189441";
$TPOS79 = "-1174.45 185.207 50.9017 2.9394";
$TPOS8 = "72.3849 49.0035 165.25 -0.662068";
$TPOS80 = "-1190.59 247.667 50.8983 -0.199174";
$TPOS81 = "-1191.12 220.65 50.8983 -1.81376";
$TPOS82 = "-1090.83 -16.2669 106.341 -0.972169";
$TPOS83 = "-982.74 -383.204 217.49 -2.0744";
$TPOS84 = "-984.791 -335.974 209.159 -0.532615";
$TPOS85 = "-1015.28 -305.722 -1505.8 -0.444222";
$TPOS86 = "-1015.71 -332.788 -1505.8 -3.11106";
$TPOS87 = "-1030.43 -367.299 -1505.79 0.0438679";
$TPOS88 = "-1008.77 -395.383 -1505.8 -2.25366";
$TPOS89 = "-981.663 -378.514 -1505.8 0.027363";
$TPOS9 = "61.6917 37.453 165.25 2.50929";
$TPOS90 = "-998.586 -362.412 -1513.54 -3.10179";
$TPOS91 = "-979.761 -337.87 -1513.54 -0.740981";
$TPOS92 = "-990.209 -338.784 -1514.02 -0.289526";
$TPOS93 = "-968.18 -368.066 -1505.8 0.576404";
$TPOS94 = "-968.362 -304.796 -1505.79 0.0325247";
$TPOS95 = "-595.761 -353.016 191.934 -0.0127599";
$TPOS96 = "-103.656 -784.135 125.439 3.01769";
$TPOS97 = "64.2667 -518.532 28.9973 -1.49135";
$TPOS98 = "317.613 -628.673 86.0136 -0.167831";
$TPOS99 = "592.149 -704.473 94.222 0.465753";

function RecursiveWorld(%seconds)
{
	dbecho($dbechoMode, "RecursiveWorld(" @ %seconds @ ")");

	//This function is a substitute for a few recursive schedule calls.  By having all schedule calls replaced by
	//this huge one, there should be less cause for lag.  As a standard, the RecursiveWorld should be called every
	//5 seconds.

	//(note, spawn crystal loop is not in this function, because I judge it causes less lag when used separately)

	$ticker[1] = floor($ticker[1]+1);
	$ticker[2] = floor($ticker[2]+1);
	$ticker[3] = floor($ticker[3]+1);
	$ticker[4] = floor($ticker[4]+1);
	$ticker[5] = floor($ticker[5]+1);
	$ticker[6] = floor($ticker[6]+1);
	$ticker[7] = floor($ticker[7]+1);

	if($ticker[1] >= (($SaveWorldFreq-60) / %seconds) && !$tmpNoticeSaveWorld)
	{
		messageAll(2, "Notice: SaveWorld will occur in 60 seconds.");
		$tmpNoticeSaveWorld = True;
	}
	if($ticker[1] >= ($SaveWorldFreq / %seconds))
	{
		//check velocity of all the bots and kill off the bots that are falling too fast (ie, ran off the map)
		//also check for BonusItems
		%list = GetEveryoneIdList();
		for(%i = 0; GetWord(%list, %i) != -1; %i++)
		{
			%id = GetWord(%list, %i);
			%vel = Item::getVelocity(%id);
			if(getWord(%vel, 2) <= -500)
			{
				FellOffMap(%id);
			}

			//bonus items

		}

		//Save World call
		SaveWorld();

		%list = GetPlayerIdList();
		for(%i = 0; GetWord(%list, %i) != -1; %i++)
		{
			%id = GetWord(%list, %i);

			schedule("ScheduleSave(" @ %id @ ");", %delay += 2, %id);
		}

		$tmpNoticeSaveWorld = "";

		$ticker[1] = 0;
	}
	if($ticker[2] >= ($ChangeWeatherFreq / %seconds))
	{
		//change weather call
		ChangeWeather();

		$ticker[2] = 0;
	}
	if($ticker[3] >= 1 && $nightDayCycle)
	{
		%a = (($initHaze * 2) / $fullCycleTime) * %seconds;

		$currentHaze -= %a;

		if($currentHaze < 0)
			%h = -$currentHaze;
		else
			%h = $currentHaze;

		if($currentHaze < -$initHaze)
			$currentHaze = $initHaze;

		setTerrainVisibility(8, 800, %h);

		//-------

		for(%i = 1; %i <= 5; %i++)
		{
			if($currentHaze >= $dayCycleHaze[%i] && $currentHaze <= $dayCycleHaze[%i-1])
			{
				if($currentSky != $dayCycleSky[%i])
				{
					$currentSky = $dayCycleSky[%i];
					ChangeSky($currentSky);
					break;
				}
			}
		}

		$ticker[3] = 0;
	}

	//arena schedules
	if($DoCheckMatchWin)
	{
		$ticker[4]++;
		if($ticker[4] >= 1)
		{
			//this part is if the match is only bots, then there is a time limit for the fight
			if($IsABotMatch)
			{
				$ArenaBotMatchTicker++;
				if($ArenaBotMatchTicker >= $ArenaBotMatchLengthInTicks)
				{
					//bots have been fighting for too long, kill em all off so the next match can take place.
					for(%i = 1; %i <= $maxroster; %i++)
					{
						%c = GetWord($ArenaDueler[%i], 0);
						%s = GetWord($ArenaDueler[%i], 1);
						if(%s == "ALIVE")
						{
							storeData(%c, "noDropLootbagFlag", True);
							playNextAnim(%c);
							Player::Kill(%c);
						}
					}
					$ArenaBotMatchTicker = 0;
					$IsABotMatch = False;

					StringArenaTextBox("Bot match was cut short.");
				}
			}

			if(CheckMatchWin())
			{
				$DoCheckMatchWin = False;
				$ArenaBotMatchTicker = 0;
				ClearArenaDueler();
				ScheduleArenaMatch();
			}

			$ticker[4] = 0;
		}
	}

	if($ticker[5] >= ($RecalcEconomyDelay) / %seconds)
	{
		//re-evaluate economy

		%list = GetBotIdList();
		for(%i = 0; GetWord(%list, %i) != -1; %i++)
		{
			%id = GetWord(%list, %i);
			%aiName = fetchData(%id, "BotInfoAiName");

			if($BotInfo[%aiName, SHOP] != "")
			{
				%max = getNumItems();
				for(%z = 0; %z < %max; %z++)
				{
					%checkItem = getItemData(%z);

					%p = GetItemCost(%checkItem);
					%q = GetItemCost(%checkItem) * ($resalePercentage/100);

					%b = $MerchantCounterB[%aiName, %checkItem];
					%s = $MerchantCounterS[%aiName, %checkItem];

					%constantB = 100;
					%constantS = 75;

					%x = round( %p - (%p * (%b/%constantB)) );
					%y = round( %q - (%q * (%s/%constantS)) );

					if(%x < 1) %x = 1;
					if(%y >= %p) %y = %p-1;

					$NewItemBuyCost[%aiName, %checkItem] = %x;
					$NewItemSellCost[%aiName, %checkItem] = %y;

					//reset counter
					$MerchantCounterB[%aiName, %checkItem] = "";
					$MerchantCounterS[%aiName, %checkItem] = "";
				}
			}
		}
		//messageAll($MsgBeige, "The merchants have revised their prices.");

		$ticker[5] = 0;
	}
	if($ticker[6] >= (300 / %seconds))
	{
		$ConsoleWorld::DefaultSearchPath = $ConsoleWorld::DefaultSearchPath;	//thanks Presto

		//check for tmpPrize.cs, execute, and delete it.
		if(isFile("config\\tmpPrize.cs"))
		{
			$pAcnt = "";
			$pBcnt = "";

			//Make sure the stupid exec file gets exec'd...
			//Note: still doesn't work.  exec sucks.
			%goFlag = "";
			for(%i = 1; %i <= 2; %i++)
			{
				if(exec("tmpPrize.cs"))
				{
					%goFlag = True;
					break;
				}
				else
					$ConsoleWorld::DefaultSearchPath = $ConsoleWorld::DefaultSearchPath;	//thanks Presto
			}

			if(%goFlag)
			{
				File::delete("config\\tmpPrize.cs");

				for(%i = 1; $PrizeA[%i] != ""; %i++)
				{
					OnOrOfflineGive($PrizeA[%i], "Trancephyte 1");
					$PrizeA[%i] = "";
				}
				for(%i = 1; $PrizeB[%i] != ""; %i++)
				{
					OnOrOfflineGive($PrizeB[%i], "Trancephyte 1 MagicDust 1");
					$PrizeB[%i] = "";
				}
				$pAcnt = "";
				$pBcnt = "";
			}
		}

		if($dedicated)
		{
			//rpgserv check
			%badFlag = "";
			if(isFile("config\\tmpData.cs"))
			{
				$tmpdata = "";
				if(exec("tmpData.cs"))
				{
					File::delete("config\\tmpData.cs");

					if($tmpdata != "160")
						%badFlag = True;

					$tmpdata = "";
				}
				else
					%badFlag = True;
			}
			else
				%badFlag = True;

			if(!%badFlag)
				$isRpgserv = True;
			else
				$isRpgserv = "";
		}

		//exec external file on server
		//useful for changing many variables while the server is running without having to type them at the console.
		if(isFile("temp\\[exec].cs"))
			exec("[exec].cs");

		$ticker[6] = 0;
	}
	if($ticker[7] >= (20 / %seconds))
	{
		//re-init the sound points.
		InitSoundPoints();

		$ticker[7] = 0;
	}

	//Call itself again, %seconds later.
	schedule("RecursiveWorld(" @ %seconds @ ");", %seconds);
}


//################################################################################################################

AddToCommonTier("CRITDAMAGE","34 17 0 26 0 0 0 0 0 0 0 94 0 0 0 0","DYN AMR EVA WPN ","Force");
AddToCommonTier("CRITCHANCE","0 30 0 0 30 0 0 0 0 0 0 40 0 0 0 0","DYN EVA WPN ","Puncturing");
AddToCommonTier("LIFESTEAL","1 0 0 1 1 0 0 2 0 0 0 5 0 0 0 0","DYN AMR EVA WPN ","Bloodshed");
AddToCommonTier("ADDALLOFF","10 10 30 10 10 0 30 20 10 0 0 0 30 10 30 30","DYN AMR EVA RES WPN QUV ","Ravaging",5);
AddToCommonTier("ADDALLDEF","23 12 12 23 0 12 12 12 12 23 0 0 46 0 23 23","DYN AMR EVA RES WPN ","Rampart",5);
AddToCommonTier("MAXMANA","0 200 200 0 200 100 0 300 300 0 0 400 0 200 0 100","DYN EVA RES STF ","Mana");
AddToCommonTier("MAXHP","100 100 100 500 100 100 0 100 0 300 0 300 100 100 100 200","DYN AMR WPN MES QUV ","Health");
//=============================================================================================================================
// AddToCommonTier("ARMORPEN","225 150 150 75 150 75 0 150 75 0 0 300 0 75 75 0","DYN AMR EVA WPN ","Precision");
AddToCommonTier("ARMORPEN","900 450 0 0 900 0 0 0 0 0 0 2250 100 0 0 0","DYN AMR EVA WPN QUV ","Precision");
// AddToCommonTier("MAGICPEN","75 150 150 75 75 75 75 75 150 75 0 300 0 225 0 0","DYN RES STF ","Emptiness");
AddToCommonTier("MAGICPEN","0 450 900 0 0 0 0 0 900 0 0 2250 0 0 0 0","DYN EVA RES STF ","Emptiness");
//=============================================================================================================================
AddToCommonTier("ARMOR","200 200 100 200 100 100 100 0 100 100 0 0 200 100 300 300","DYN AMR EVA MES ","Armor");
AddToCommonTier("MELEEAC","200 100 100 200 200 200 100 200 100 200 0 0 200 100 200 200","DYN AMR EVA MES ","Plating");
AddToCommonTier("PROJAC","200 100 100 200 200 200 100 200 100 200 0 0 200 100 200 200","DYN AMR EVA MES ","Proof");
AddToCommonTier("POISONAC","200 100 100 200 200 200 100 200 100 200 0 0 200 100 200 200","DYN AMR EVA MES ","Snakes");
AddToCommonTier("FIREAC","200 100 100 200 200 200 100 200 100 200 0 0 200 100 200 200","DYN AMR EVA MES ","Flames");
AddToCommonTier("COLDAC","200 100 100 200 200 200 100 200 100 200 0 0 200 100 200 200","DYN AMR EVA MES ","Ice");
AddToCommonTier("ENERGYAC","200 100 100 200 200 200 100 200 100 200 0 0 200 100 200 200","DYN AMR EVA MES ","Thunder");
AddToCommonTier("ALLRESIST","100 100 200 100 100 100 100 100 200 100 0 0 200 200 200 200","DYN RES SPS ","Defiance");
AddToCommonTier("MELEERES","100 100 200 100 100 100 100 100 200 100 0 0 200 200 200 200","DYN RES SPS ","Steel");
AddToCommonTier("PROJRES","100 100 200 100 100 100 100 100 200 100 0 0 200 200 200 200","DYN RES SPS ","Iron");
AddToCommonTier("FIRERES","100 100 200 100 100 100 100 100 200 100 0 0 200 200 200 200","DYN RES SPS ","Heat");
AddToCommonTier("COLDRES","100 100 200 100 100 100 100 100 200 100 0 0 200 200 200 200","DYN RES SPS ","Snow");
AddToCommonTier("ENERGYRES","100 100 200 100 100 100 100 100 200 100 0 0 200 200 200 200","DYN RES SPS ","Bolts");
AddToCommonTier("POISONRES","100 100 200 100 100 100 100 100 200 100 0 0 200 200 200 200","DYN RES SPS ","Reptiles");
AddToCommonTier("ADDEXP","3 6 3 2 2 2 2 2 4 2 0 0 5 4 0 0","DYN AMR EVA RES QUV ","Experience",3);
AddToCommonTier("GOLDFIND","15 30 8 8 8 15 15 15 15 8 0 0 5 15 0 0","DYN AMR EVA RES QUV ","Luck");
AddToCommonTier("MAGICFIND","15 30 8 8 8 15 15 15 15 8 0 0 5 15 0 0","DYN AMR EVA RES QUV ","Fiding");
AddToCommonTier("MAXWEIGHT","100 100 300 0 300 200 500 200 0 100 0 0 100 100 0 0","DYN AMR EVA RES ","Lifting");
AddToCommonTier("HEALDELTA","20 20 10 40 20 20 0 0 30 20 0 0 0 10 0 10","DYN AMR ","Regeneration");
AddToCommonTier("MANADELTA","10 20 20 10 0 0 10 20 30 10 0 30 0 20 0 20","DYN RES STF ","Energizing");
AddToCommonTier("REFLECT","2 0 0 0 0 0 0 2 0 0 0 0 3 0 0 2","DYN AMR MES SPS ","Thorns");
//##############################################################################################################################
// ADDMANACOST
AddToCommonTier("MANACOST","0 2 2 0 0 0 0 0 0 0 0 2 0 4 0 0","DYN RES STF ",Effeciency);
//##############################################################################################################################
AddToCommonTier("ADDDAMAGE","30 30 0 0 10 0 0 30 10 0 0 70 30 10 0 0","DYN AMR EVA WPN QUV ","Damage");
//AddToCommonTier("MAGICDAMAGE","0 0 20 0 0 0 0 0 20 0 0 80 0 20 30 30","DYN RES STF ","Casting");
//AddToCommonTier("MAGICDAMAGE","0 6 25 0 0 0 0 0 25 0 0 50 0 0 25 0","DYN RES STF ","Casting");
AddToCommonTier("MAGICDAMAGE","0 6 25 0 0 0 0 0 25 0 0 50 0 0 0 25","DYN RES STF ","Casting");
AddToCommonTier("PHYSICALDAMAGE","5 0 0 0 5 0 0 0 0 5 0 35 0 0 0 0","DYN AMR EVA ","Berserking");
//##############################################################################################################################
AddToCommonTier("SLASHING","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Slashing",3);
AddToCommonTier("PIERCING","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Piercing",3);
AddToCommonTier("BLUDGEONING","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Bludgeoning",3);
AddToCommonTier("DODGING","0 38 0 0 0 134 134 77 0 0 0 0 0 0 0 0","DYN AMR EVA ","Dodging",3);
AddToCommonTier("WEIGHTCAPACITY","0 38 0 77 0 134 134 0 0 0 0 0 0 0 0 0","DYN AMR EVA RES ","Travels",3);
AddToCommonTier("BASHING","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Bashing",3);
AddToCommonTier("STEALING","0 38 0 57 96 57 0 134 0 0 0 0 0 0 0 0","DYN EVA ","Thievery",3);
AddToCommonTier("HIDING","0 38 0 57 0 57 96 134 0 0 0 0 0 0 0 0","DYN EVA ","Shadows",3);
AddToCommonTier("BACKSTABBING","77 38 0 0 192 77 0 0 0 0 0 0 0 0 0 0","DYN EVA ","Sneaking",3);
AddToCommonTier("SPELLRESISTANCE","0 153 77 77 0 0 0 0 77 0 0 0 0 0 0 0","DYN RES ","Resistance",3);
AddToCommonTier("HEALING","0 57 0 57 0 0 0 134 134 0 0 0 0 0 0 0","DYN AMR EVA RES ","Healing",3);
AddToCommonTier("ARCHERY","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Archery",3);
AddToCommonTier("ENDURANCE","0 0 0 153 0 77 77 77 0 0 0 0 0 0 0 0","DYN AMR EVA ","Endurance",3);
AddToCommonTier("MARTIALARTS","38 0 0 57 57 115 115 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Balance",3);
AddToCommonTier("MINING","0 96 192 96 0 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA RES ","Mining",3);
AddToCommonTier("SPEECH","0 96 192 96 0 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA RES ","Speech",3);
AddToCommonTier("SENSEHEADING","0 96 192 96 0 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA RES ","Heading",3);
AddToCommonTier("ENERGY","0 38 115 115 0 0 0 0 115 0 0 0 0 0 0 0","DYN EVA RES ","Energy",3);
AddToCommonTier("HAGGLING","0 96 192 96 0 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA RES ","Haggling",3);
AddToCommonTier("STRENGTH","96 0 0 192 96 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Strength",3);
AddToCommonTier("STAMINA","0 0 0 192 0 96 0 96 0 0 0 0 0 0 0 0","DYN AMR EVA ","Stamina",3);
AddToCommonTier("AGILITY","77 0 0 0 0 153 153 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Agility",3);
AddToCommonTier("SENSE","0 0 153 153 0 0 0 77 0 0 0 0 0 0 0 0","DYN AMR EVA RES ","Sense",3);
AddToCommonTier("INTELLIGENCE","0 0 192 0 0 0 0 0 192 0 0 0 0 0 0 0","DYN EVA RES ","Intelligence",3);
AddToCommonTier("PSYCHIC","0 0 192 0 0 0 0 0 192 0 0 0 0 0 0 0","DYN EVA RES ","Psychic",3);
AddToCommonTier("CASTINIT","0 0 192 0 77 0 0 0 115 0 0 0 0 0 0 0","DYN EVA RES ","Initiation",3);
AddToCommonTier("LITERACY","0 96 192 96 0 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA RES ","Reading",3);
AddToCommonTier("SMITHING","0 57 57 115 153 0 0 0 0 0 0 0 0 0 0 0","DYN AMR ","Smithing",3);
AddToCommonTier("MAGICCRAFT","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Crafting",3);
AddToCommonTier("ALCHEMY","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Mixing",3);
AddToCommonTier("SPELLCAPACITY","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Focus",3);
AddToCommonTier("WEAPONHANDLING","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Handling",3);
AddToCommonTier("EVADEMELEE","0 38 0 0 0 134 134 77 0 0 0 0 0 0 0 0","DYN AMR EVA ","Evading",3);
AddToCommonTier("AIMING","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Sniping",3);
AddToCommonTier("BRAWLING","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Brawling",3);
AddToCommonTier("CLEAVE","115 38 0 38 192 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA ","Cleaving",3);
AddToCommonTier("PRIMALMAGIC","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Instinct",3);
AddToCommonTier("HOLYMAGIC","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Divinity",3);
AddToCommonTier("EMPOWERMENT","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Empowerment",3);
AddToCommonTier("DARKMAGIC","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Darkness",3);
AddToCommonTier("LIGHTMAGIC","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Light",3);
AddToCommonTier("RITUAL","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Rituals",3);
AddToCommonTier("SORCERY","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Sorcery",3);
AddToCommonTier("PROTECTION","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Protection",3);
AddToCommonTier("ENCHANTMENT","0 77 153 0 0 0 0 0 153 0 0 0 0 0 0 0","DYN RES ","Enchantment",3);
AddToCommonTier("WISDOM","0 96 192 96 0 0 0 0 0 0 0 0 0 0 0 0","DYN AMR EVA RES ","Wisdom",3);
//##############################################################################################################################
AddToCommonTier("BLOCKHIT%","0 0 0 0 0 0 0 0 0 0 0 0 10 0 0 0","MES ","Blocking");
AddToCommonTier("BLOCKSPELL%","0 0 0 0 0 0 0 0 0 0 0 0 10 0 0 0","SPS ","Inhibiting");
// SHIELD%
AddToCommonTier("HEALTH%","3 2 0 5 0 0 0 0 0 5 0 0 5 0 0 0","LDYN LAMR LMES ","Goliaths");
AddToCommonTier("MANA%","0 5 5 0 0 0 0 0 5 0 0 0 0 5 0 0","LDYN LRES ","Leaves");
AddToCommonTier("DAMAGEDEMON","5 5 5 5 5 5 5 5 5 5 0 13 5 5 0 0","LDYN LAMR LEVA LRES WPN STF QUV ","Angels");
AddToCommonTier("DAMAGEUNDEAD","5 5 5 5 5 5 5 5 5 5 0 13 5 5 0 0","LDYN LAMR LEVA LRES WPN STF QUV ","Living");
AddToCommonTier("DAMAGEBEAST","5 5 5 5 5 5 5 5 5 5 0 13 5 5 0 0","LDYN LAMR LEVA LRES WPN STF QUV ","Hunting");
AddToCommonTier("DAMAGEELITE","5 5 5 5 5 5 5 5 5 5 0 13 5 5 0 0","LDYN LAMR LEVA LRES WPN STF QUV ","Captians");
AddToCommonTier("DAMAGEBOSS","5 5 5 5 5 5 5 5 5 5 0 13 5 5 0 0","LDYN LAMR LEVA LRES WPN STF QUV ","Guardians");
// ABSORB
AddToCommonTier("MANAHEALTH","1 1 5 1 0 0 0 1 5 1 0 0 0 5 0 0","LDYN LRES ","Meshing");
AddToCommonTier("HEALTHMANA","1 1 5 5 0 0 0 1 4 0 0 0 0 3 0 0","LDYN LRES ","Transforming");
AddToCommonTier("INCDAMAGE%","0 0 0 0 0 0 0 0 0 0 0 100 0 0 0 0","WPN ","Sharpening");
AddToCommonTier("MINDAMAGE","5 10 0 0 10 0 0 0 0 0 0 50 0 0 0 0","DYN AMR EVA WPN ","Edges");
AddToCommonTier("MAXDAMAGE","5 15 0 0 15 0 0 0 0 0 0 100 0 0 0 0","DYN AMR EVA WPN ","Honing");
// MINIONHEALH
// MINIONDAMAGE
AddToCommonTier("MAXMEMORY","0 50 0 0 0 0 0 0 100 0 160 0 0 0 0 0","DYN AMR EVA RES ","Cognizance");
// ATKBLOCK
AddToCommonTier("PROJDAMAGE%","0 0 0 0 0 0 0 0 0 0 0 0 10 0 0 0","QUV ","Poke");
AddToCommonTier("FIREDAMAGE%","0 0 0 0 0 0 0 0 0 0 0 0 10 0 0 0","QUV ","Heat");
AddToCommonTier("COLDDAMAGE%","0 0 0 0 0 0 0 0 0 0 0 0 10 0 0 0","QUV ","Freezing");
AddToCommonTier("POISONDAMAGE%","0 0 0 0 0 0 0 0 0 0 0 0 10 0 0 0","QUV ","Venom");
AddToCommonTier("ENERGYDAMAGE%","0 0 0 0 0 0 0 0 0 0 0 0 10 0 0 0","QUV ","Zapping");
// PROJDAMAGE%	
// FIREDAMAGE%	
// COLDDAMAGE%	
// POISONDAMAGE%	
// ENERGYDAMAGE%
// AVOIDSTUN
// AVOIDROOT
// AVOIDCHILL
// AVOIDBURN
// AVOIDPOISON
// AVOIDSHOCK
// AVOIDCRIT
// WEAPONRANGE
// CASTRANGE
AddToCommonTier("RANGEDDAMAGE","0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0","QUV ","Arrows");
// MELEEDAMAGE
AddToCommonTier("SLASHINGDAMAGE","5 5 0 5 3 0 0 2 0 0 0 0 0 0 0 0","LDYN LAMR LEVA ","Swords");
AddToCommonTier("PIERCINGDAMAGE","2 3 0 0 5 5 0 5 0 0 0 0 0 0 0 0","LDYN LAMR LEVA ","Knives");
AddToCommonTier("BLUDGEDAMAGE","5 5 0 5 3 0 0 2 0 0 0 0 0 0 0 0","LDYN LAMR LEVA ","Clubs");
AddToCommonTier("ARCHERYDAMAGE","5 5 0 5 3 0 0 2 0 0 0 0 50 0 0 0","LDYN LAMR LEVA QUV ","Missles");
// STAFFMAGIC
// WANDMAGIC
AddToCommonTier("UNDEADPROT","0 0 0 0 0 0 0 0 0 0 0 0 5 0 5 5","LDYN LAMR LEVA LRES MES SPS ","Zombies");
AddToCommonTier("DEMONPROT","0 0 0 0 0 0 0 0 0 0 0 0 5 0 5 5","LDYN LAMR LEVA LRES MES SPS ","Demons");
AddToCommonTier("BEASTPROT","0 0 0 0 0 0 0 0 0 0 0 0 5 0 5 5","LDYN LAMR LEVA LRES MES SPS ","Animals");
AddToCommonTier("BERSERK","15 10 0 30 5 5 5 5 5 15 0 0 0 5 0 0","LDYN LAMR ","Insanity");
AddToCommonTier("HEALTHPOTION","4 4 4 4 4 4 4 4 4 0 0 0 0 4 0 0","LDYN LAMR LEVA LRES ","Drinks");
AddToCommonTier("MANAPOTION","4 4 4 4 4 4 4 4 4 0 0 0 0 4 0 0","LDYN LAMR LEVA LRES ","Refreshment");
AddToCommonTier("PERCEPTION","50 100 150 50 150 100 50 200 50 50 0 0 0 50 0 0","DYN EVA ","Sight");
AddToCommonTier("RIPOSTE","100 100 50 100 150 150 100 100 50 50 0 0 0 50 0 0","LDYN LAMR LEVA ","Parry");
AddToCommonTier("BANDAGE","50 100 100 50 100 100 50 50 100 100 0 0 0 200 0 0","DYN AMR EVA RES ","Patching");
AddToCommonTier("INCARMOR","0 0 100 100 100 100 100 0 0 100 0 0 100 0 100 100","DYN AMR MES ","Titanium");
AddToCommonTier("INCRESIST","0 0 100 100 100 100 100 0 0 100 0 0 100 0 100 100","DYN RES SPS ","Refusal");
AddToCommonTier("INCEVASION","0 0 100 100 100 100 100 0 0 100 0 0 100 0 100 100","DYN EVA MES ","Dexterity");
// SMITHREQ
// ALCHEMYREQ
// MAGICCRAFTREQ
AddToCommonTier("FORESTDAMAGE","0 15 0 0 0 0 0 0 0 0 0 0 0 0 0 0","LDYN ","Rangers");
AddToCommonTier("DESERTDAMAGE","0 15 0 0 0 0 0 0 0 0 0 0 0 0 0 0","LDYN ","Nomads");
AddToCommonTier("JUNGLEDAMAGE","0 15 0 0 0 0 0 0 0 0 0 0 0 0 0 0","LDYN ","Tribes");
AddToCommonTier("SNOWDAMAGE","0 15 0 0 0 0 0 0 0 0 0 0 0 0 0 0","LDYN ","Wastelands");
AddToCommonTier("LAVADAMAGE","0 15 0 0 0 0 0 0 0 0 0 0 0 0 0 0","LDYN ","Volcanos");
AddToCommonTier("ARCANEDAMAGE","0 15 0 0 0 0 0 0 0 0 0 0 0 0 0 0","LDYN ","Stars");
AddToCommonTier("SPELLINTURUPT","0 1 5 1 1 0 0 1 5 1 0 0 0 5 0 0","DYN RES ","Concentration");
// AGGDEF
// AGRESSIVE
// SHIELDBONUS
// SPELLVUL
// PHYSVUL
// HEALTHDAMAGE
// MANAMAGIC
// DAMAGEMANA
// BLOODMAGIC
AddToCommonTier("SPELLCRIT","0 0 0 0 0 0 0 0 0 0 0 20 0 0 0 0","DYN STF ","Warlocks");
AddToCommonTier("AVOIDSPCRIT","0 2 5 0 0 1 1 1 5 0 0 0 0 5 0 0","LDYN LRES ","Avoidance");
AddToCommonTier("EVASION","50 50 50 50 50 100 100 100 50 50 0 0 0 50 200 200","DYN EVA ","Evasion");
// INCEVASION%
AddToCommonTier("SPELLVAMP","0 0 0 0 0 0 0 0 0 0 0 10 0 0 0 0","DYN STF ","Vampires");
AddToCommonTier("BLOCKAMMOUNT","0 0 0 0 0 0 0 0 0 0 0 0 3000 0 0 0","MES","Guarding");
AddToCommonTier("BLOCKRECOVERY","4 4 0 6 0 6 3 3 0 3 0 0 20 0 0 0","DYN AMR EVA MES SPS ","Recovery");
AddToCommonTier("SPLBLOCKAMM","0 0 0 0 0 0 0 0 0 0 0 0 3000 0 0 0","SPS","Walls");
AddToCommonTier("STUNRECOVER","2 2 2 2 2 2 2 2 2 2 0 0 2 2 3 3","DYN AMR EVA RES ","Dizziness");
AddToCommonTier("SPCRITDAMAGE","0 5 15 0 0 0 0 0 5 0 0 75 0 5 0 0","LDYN LRES STF ","Criticals");

AddToCommonTier("COOLDOWN","0 2 5 0 0 0 0 0 4 0 0 10 0 0 0 0","DYN EVA RES STF ","Refreshment");

AddToCommonTier("SPELLBASE","0 5 35 0 0 0 0 0 35 0 0 0 0 0 0 35","DYN RES ","Hexing");

// GOBLINEXPLODE
//################################################################################################################


function Item::giveItem(%player, %item, %delta, %showmsg)
{
	dbecho($dbechoMode, "Item::giveItem(" @ %player @ ", " @ %item @ ", " @ %delta @ ", " @ %showmsg @ ")");

	%clientId = Player::getClient(%player);

	//i used to restrict what you could pick up here, but that sucks, so i made
	//it so you can pick up anything, but you can't EQUIP anything. (see Item::onUse)

	//also, the only reason you'd be getting a giveItem of an Equipped type is
	//by giving the client an item and pre-equipping it.

	if(%showmsg)
		Client::sendMessage(%clientId, 0, "You received " @ %delta @ " " @ %item.description @ ".");

	if (isBackpackItem(%item)) {
		if (%delta >= 0)
			AddToBackpack(%clientId,%item,%delta);
		else
			RemoveFromBackpack(%clientId,%item,%delta);
	}
	else
		Player::incItemCount(%clientId, %item, %delta);

	return %delta;
}

function Item::onCollision(%this,%object)
{
	dbecho($dbechoMode, "Item::onCollision(" @ %this @ ", " @ %object @ ")");

	%clientId = Player::getClient(%object);
	%armor = Player::getArmor(%clientId);
	
	//========================================================================================================
	// RESTRICT LADDER
	%ladder = IsLadderPlayer(%clientId);
	if (%ladder) {
		if (%this.Ladder != 1 && !%this.AiDropped) {
			return;
		}
	}
	if (%this.AiDropped && %ladder) {
		if (%this.NoLadderPickup == 1) {
			echo("NO LADDER PICKUP");
			return;
		}
	}
	if (%this.Ladder) {
		if (!IsLadderPlayer(%clientId)) {
			return;
		}
	}
	if (!%this.Ladder) {
		if (Player::IsAiControlled(%clientId)) {
			%object.NoLadderPickup = 1;
		}
	}
	//========================================================================================================

	if (%this.NoBonus)
		%object.NoDropBonus = 1;

	if(getObjectType(%object) == "Player" && !IsDead(%clientId))
        {
		%time = getIntegerTime(true) >> 5;
		if(%time - %clientId.lastItemPickupTime <= 0.1)
			return 0;

		%clientId.lastItemPickupTime = %time;

		%item = Item::getItemData(%this);

            if(%item == "Lootbag" || %item == "Lootrock")
            {
			%nobonus = 0;
			
			%msg = "";

			if (Player::isAiControlled(%object))
				return;

			if (%this.Ladder) {
				if (!IsLadderPlayer(%clientId))
					return;
			}

			%ownerName = GetWord($loot[%this], 0);
			%namelist = GetWord($loot[%this], 1);
			if($loot[%this] == "")
				%msg = "You found an empty backpack.";
			else
			{
				if(IsInCommaList(%namelist, Client::getName(%clientId)) || %namelist == "*")
				{
					if(String::ICompare(%ownerName, Client::getName(%clientId)) == 0) {
						%msg = "You found one of your backpacks.";
						//%nobonus = 1;
					}
					else if(%ownerName == "*")
						%msg = "You found a backpack.";
					else
						%msg = "You found one of " @ %ownerName @ "'s backpacks.";
				}
			}

			if (%this.NoBonus)
				%nobonus = 1;

			if(%msg != "")
			{
				%newloot = String::getSubStr($loot[%this], String::len(%ownerName)+String::len(%namelist)+2, 99999);

				Client::sendMessage(%clientId, 0, %msg);
	
				if (LootHasBackpackItem(%newloot) == true) {
					if (BackpackFull(%clientId) == true) {
						Client::SendMessage(%clientId,1,"You can not pick up this pack, your backpack is full!");
						return;
					}
				}

				GiveThisStuff(%clientId, %newloot, True, 1, %nobonus);

				if(%this.tag != "")
				{
					$tagToObjectId[%this.tag] = "";
					$SpawnPackList = RemoveFromCommaList($SpawnPackList, %this.tag);
				}
				Item::playPickupSound(%this);
				$loot[%this] = "";

				if(%ownerName != "*")
				{
					%ownerId = NEWgetClientByName(%ownerName);
					storeData(%ownerId, "lootbaglist", RemoveFromCommaList(fetchData(%ownerId, "lootbaglist"), %this));
				}

				//event stuff
				%i = GetEventCommandIndex(%this, "onpickup");
				if(%i != -1)
				{
					%name = GetWord($EventCommand[%this, %i], 0);
					%type = GetWord($EventCommand[%this, %i], 1);
					%cl = NEWgetClientByName(%name);
					if(%cl == -1)
						%cl = 2048;

					%cmd = String::NEWgetSubStr($EventCommand[%this, %i], String::findSubStr($EventCommand[%this, %i], ">")+1, 99999);
					%pcmd = ParseBlockData(%cmd, %clientId, "");
					$EventCommand[%this, %i] = "";
					remoteSay(%cl, 0, %pcmd, %name);
				}
				deleteObject(%this);
				ClearEvents(%this);
			}
			else
			{
				if(%ownerName == "*")
					Client::sendMessage(%clientId, $MsgRed, "You do not have the right to take this backpack.");
				else
					Client::sendMessage(%clientId, $MsgRed, "You do not have the right to take " @ %ownerName @ "'s backpack.");
			}
            }
            else if (%item.className == "Projectile")
            {
			%damagedClient = %clientId;
			%shooterClient = %this.owner;
			if(%shooterClient != "")
			{
				%vec = Vector::getDistance("0 0 0", Item::getVelocity(%this));
				if(%vec == 0 && $ProjectileDoubleCheck[%this])
					%vec = 3.0;
			}
			else
				%vec = 0;	//don't let thrown projectiles damage!

			$ProjectileDoubleCheck[%this] = "";

			if(%vec >= 2.5)
			{
				GameBase::virtual(%object, "onDamage", $DamageType[%item], 1.0, "0 0 0", "0 0 0", "0 0 0", "torso", %this.weapon, %shooterClient, %item);
			}
			else
			{
				if(Item::giveItem(%clientId, %item, %this.delta, True))
				{
					Item::playPickupSound(%this);
					RefreshAll(%clientId);
				}
			}

			deleteObject(%this);
		}
            else if(%item.className == "Accessory" || $LoreItem[%item] == True)
            {
			if(Item::giveItem(%clientId, %item, 1, True))
			{
				Item::playPickupSound(%this);
				RefreshAll(%clientId);
				deleteObject(%this);
			}
		}
		else if(%item.className == "TownBot")
		{
			//do nothing.
		}
            else
            {
            	//%count = Player::getItemCount(%object,%item);
            	if(Item::giveItem(%object, %item, %this.delta, True))
                  {
                  	Item::playPickupSound(%this);
				RefreshAll(%clientId);
                        Item::respawn(%this);
			}
		}
	}
}

function Item::onMount(%player,%item)
{
}

function Item::onUnmount(%player,%item)
{
}

function Item::onUse(%player,%item)
{
	dbecho($dbechoMode, "Item::onUse(" @ %player @ ", " @ %item @ ")");

	%clientId = Player::getClient(%player);

	if(!IsDead(%clientId))
	{
		//this is how you toggle back and forth from equipped to carrying.
		if(%item.className == Accessory)
		{
			%cnt = 0;
			%max = getNumItems();
			for(%i = 0; %i < %max; %i++)
			{
				%checkItem = getItemData(%i);
				if(%checkItem.className == Equipped && GetAccessoryVar(%checkItem, $AccessoryType) == GetAccessoryVar(%item, $AccessoryType))
					%cnt += Player::getItemCount(%player, %checkItem);
			}

			if(SkillCanUse(%clientId, %item))
			{
				if(%cnt < $maxAccessory[GetAccessoryVar(%item, $AccessoryType)])
				{
					Client::sendMessage(%clientId, $MsgBeige, "You equipped " @ %item.description @ ".");
					Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
					Player::setItemCount(%player, %item @ "0", Player::getItemCount(%player, %item @ "0")+1);
				}
				else
					Client::sendMessage(%clientId, $MsgRed, "You can't equip this item because you have too many already equipped.~wC_BuySell.wav");
			}
			else
				Client::sendMessage(%clientId, $MsgRed, "You can't equip this item because you lack the necessary skills.~wC_BuySell.wav");

			if($OverrideMountPoint[%item] == "")
				Player::mountItem(%player, %item @ "0", 1, 0);
		}
		else if(%item.className == Equipped)
		{
			%o = String::getSubStr(%item, 0, String::len(%item)-1);	//remove the 0
			Client::sendMessage(%clientId, $MsgBeige, "You unequipped " @ %item.description @ ".");
			Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
			Player::setItemCount(%player, %o, Player::getItemCount(%player, %o)+1);

			if($OverrideMountPoint[%item] == "")
				Player::unMountItem(%player, 1);
		}
		else
		{
			RPGmountItem(%player, %item, $DefaultSlot);
		}

		refreshHP(%clientId, 0);
		refreshMANA(%clientId, 0);
		RefreshAll(%clientId);
	}
}

function Item::onDrop(%player,%item)
{
	dbecho($dbechoMode, "Item::onDrop(" @ %player @ ", " @ %item @ ")");

	//-----------------------------------------------
	// RESTRICT LADDER
	%clientId = Player::GetClient(%player);
	%ladder = IsLadderPlayer(%clientId);
	%ai = Player::IsAiControlled(%clientId);
	//-----------------------------------------------

	if($matchStarted)
	{
		if(%item.className != Armor)
		{
			if(%item.className == Projectile)
				%delta = 20;
			else
				%delta = 1;

			if(Player::getItemCount(%player, %item) < %delta)
				%delta = Player::getItemCount(%player, %item);

			echo(" ============================================> ITEM ON DROP ");

			if(%delta > 0)
			{
				%obj = newObject("","Item",%item,1,false);
				%obj.delta = %delta;
				//-----------------------------------------------
				// RESTRICT LADDER
				if (%ladder) {
					%obj.Ladder = 1;
				}
				if (%ai == True) {
					%obj.AiDropped = 1;
				}
				//-----------------------------------------------
				echo(" ============================> SETTING ITEM POP");
	 	 	  	schedule("Item::Pop(" @ %obj @ ");", $ItemPopTime, %obj);
	 	 	 	addToSet("MissionCleanup", %obj);

				if(IsDead(%player)) 
					GameBase::throw(%obj, %player, 10, true);
				else {
					GameBase::throw(%obj, %player, 15, false);
					Item::playPickupSound(%obj);
				}

				Player::decItemCount(%player,%item,%delta);
				RefreshAll(Player::getClient(%player));

				return %obj;
			}
		}
	}
}

function Ammo::onDrop(%player,%item)
{
	dbecho($dbechoMode, "Ammo::onDrop(" @ %player @ ", " @ %item @ ")");

	if($matchStarted)
	{
		if(%item.className == Ammo)
			%delta = 20;
		else
			%delta = 1;

		if(Player::getItemCount(%player, %item) < %delta)
			%delta = Player::getItemCount(%player, %item);

		if(%delta > 0)
		{
			%obj = newObject("","Item",%item,%delta,false);
			%obj.delta = %delta;
	      	schedule("Item::Pop(" @ %obj @ ");", $ItemPopTime, %obj);

      		addToSet("MissionCleanup", %obj);
			GameBase::throw(%obj,%player,20,false);
			Item::playPickupSound(%obj);
			Player::decItemCount(%player,%item,%delta);

			RefreshAll(Player::getClient(%player));
		}
	}
}	

function Item::onDeploy(%player,%item,%pos)
{
}


function AddWeight(%id,%w)
{
	$PlayerWeight[%id]+=%w;	
}

function SubWeight(%id,%w)
{
	$PlayerWeight[%id]-=%w;
}

function GetWeight(%clientId)
{
	dbecho($dbechoMode, "GetWeight(" @ %clientId @ ")");

	if(IsDead(%clientId) || !fetchData(%clientId, "HasLoadedAndSpawned") || %clientId.IsInvalid)
		return 0;

	//== HELPS REDUCE LAG WHEN THERE ARE SIMULTANEOUS CALLS ======
	%time = getIntegerTime(true);
	if(%time - %clientId.lastGetWeight <= 1 && fetchData(%clientId, "tmpWeight") != "")
		return fetchData(%clientId, "tmpWeight");
	%clientId.lastGetWeight = %time;
	//============================================================

	$GetWeight::ArmorMod = "";
	%total = 0;

	//add up items
	%max = getNumItems();
	for(%i = 0; %i < %max; %i++)
	{
		%checkItem = getItemData(%i);
		%itemcount = Player::getItemCount(%clientId, %checkItem);

		if(%itemcount)
		{
			%weight = GetAccessoryVar(%checkItem, $Weight);
			if(%weight != "" && %weight != False)
				%total += %weight * %itemcount;

			//Replaces the laggy AddPoints(%clientId, 8) in RefreshWeight (the real lag comes from GetAccessoryList however)
			%specialvar = GetAccessoryVar(%checkItem, $SpecialVar);
			if(GetWord(%specialvar, 0) == 8 && %checkItem.className == Equipped)
				$GetWeight::ArmorMod = GetWord(%specialvar, 1);
		}
	}
	
	//echo("WEIGHT CHECK");
	%total = %total + GetBackpackWeight(%clientId);

	//add up coins
	%total += fetchData(%clientId, "COINS") * $coinweight;

	storeData(%clientId, "tmpWeight", %total);
	return %total;
}



function RefreshWeight(%clientId)
{
	dbecho($dbechoMode2, "RefreshWeight(" @ %clientId @ ")");

	%player = Client::getOwnedObject(%clientId);

	if(!fetchData(%clientId, "SlowdownHitFlag"))
	{
		%weight = fetchData(%clientId, "Weight");
		
		%changeweightstep = 5;

		//determine the new armor to use
		%newarmor = $ArmorForSpeed[fetchData(%clientId, "RACE"), 0];
		%spill = %weight - fetchData(%clientId, "MaxWeight");

		%num = floor(%spill / %changeweightstep);

		if(%num > 0)
		{
			//overweight, select appropriate armor
			for(%i = -1; %i >= -%num; %i--)
			{
				if($ArmorForSpeed[fetchData(%clientId, "RACE"), %i] != "")
					%newarmor = $ArmorForSpeed[fetchData(%clientId, "RACE"), %i];
				else
					break;
			}
		}
		else
		{
			//when not overweight, the special armor-modifying items come in
			%x = $GetWeight::ArmorMod;
			if(%x > 0)
				%newarmor = $ArmorForSpeed[fetchData(%clientId, "RACE"), %x];
		}
	}
	else
	{
		%newarmor = $ArmorForSpeed[fetchData(%clientId, "RACE"), -5];
	}

	%a = Player::getArmor(%clientId);
	%ae = GameBase::getEnergy(%player);

	if(%a != %newarmor && %newarmor != "")
	{
		//set the new armor
		Player::setArmor(%clientId, %newarmor);
		GameBase::setEnergy(%player, %ae);
		//------------------------------------------------------------------
		// CHECK FOR VISUAL
		
		%weararmor = $PlayerWear[%clientId,12];
		if (%weararmor != -1) {
			%vis = $BPItem[%weararmor,$BPVis];
			if (%vis != "")
				Client::SetSkin(%clientId,%vis);
		}

		//------------------------------------------------------------------
		//UseSkill(%clientId, $SkillWeightCapacity, True, True, 25);
	}

	//save the %num in a global variable for use on stats (in order to give penalties to other stats for being overweight)
	storeData(%clientId, "OverweightStep", %num);
}

	// --------------------------------------------------------------------------------
	// APPLY DAMAGE
	if ((fetchData(%target,"HP") - %value) <= 0) {
		// KILLED ===================================================================
		ManualAddDamagedList(%id,%target,%value);
		Client::SendMessage(%id,0,"You killed " @ Client::GetName(%target) @ "!");
		// --------------------------------------------------------------------------------
		if ((%zone = $CRUSPAWNZONE[%target]) != "") {
			%spawn = $CRUSPAWNID[%target];
			$CRUSPAWNZONE[%target] = "";
			$CRUSPAWNID[%target] = "";
			%monstername = $CRUMONSTERNAME[%target];
			$CRUMONSTER[%monstername,$CENameOn]--;
			$CRUMONSTERNAME[%target] = "";
			schedule("DecreaseZoneActive("@%target@","@%zone@","@%spawn@");",10);
		}
		// --------------------------------------------------------------------------------
		ActionKilled(%id,%target,99,%explode);
		DamageTarget(%target,%value);
		$TargetCur[%id,0] = "";
		Targeting::Hud(%id,1);
	}
	else {
		// NOT KILLED ===================================================================
		if (Player::isAiControlled(Client::GetOwnedObject(%target)))
			AI::AddHate(%target,%id,%value);
		ManualAddDamagedList(%id,%target,%value);
		DamageTarget(%target,%value);
	}


	//%atk = $BPItem[%weapon,$BPATKSkills];
	//%atk = getWord(%atk,0);
	//if (%atk == "Focus") {
	//	echo(" FOCUS CHECK ");
	//	%chance = $BPItem[%weapon,$BPWeaponCritChance];
	//	echo(" CHANCE " @ %chance);
	//	%critdamage = $BPItem[%weapon,$BPWeaponCritDamage];
	//	echo(" CRITDAMAGE " @ %critdamage);
	//	%chance = (%chance * (1 + (GetBonus(%id,$BPSPELLCRIT) / 100)));
	//	%critdamage = (%critdamage * (1 + (GetBonus(%id,$BPSPCRITDAMAGE) / 100)));
	//	%chance += GetBonus(%id,$BPADDALLOFF) / 100;
	//	%critdamage += GetBonus(%id,$BPADDALLOFF) / 100;
	//	if (%chance > 95) %chance = 95;
	//	%crit = getRandom() * 100;
	//	if (%crit <= %chance && %nocrit != True) {
	//		%hitcrit = 1;
	//		%sanction = "criticaly hit";
	//		%value = round(%value * (1 + (%critdamage / 100)));
	//	}
	//}'




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
	%rune = Rune::Random("BodyRuneOfAgility",300);
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

function RandomTestLoot()
{
	%grab = floor(getRandom() * $TestLootList + 1);
	%loot = $TestLoot[%grab];
	return %loot;
}

function FullTestTier(%a)
{
	testfulltier(%a);
}

function TestFullTier(%a)
{
	echo("###################################################################################################################");
	echo(" TEST FULL TIER ");
	if (%a <= 0) %a = 50;
	$Playerbackpack[2049] = "";
	for (%i = 1; %i <= %a; %i++) {
		%ql = floor(getRandom() * 300 + 1);
		//%ql = 150;
		%loot = RandomTestLoot();
		%new = TierItem::RandomItem(%loot,%ql);
		$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %new @ " 1 ";
	}
}

function TestSingleTier(%i,%q)
{
	echo("###################################################################################################################");
	echo(" TEST SINGLE TIER ");
	if (%q < 0) %q = 1;
	$Playerbackpack[2049] = "";
	%new = TierItem::RandomItem(%i,%q);
	$PlayerBackpack[2049] = $PlayerBackpack[2049] @ %new @ " 1 ";
}


function BackpackPerformSalvage(%id,%item)
{
	%material = $BPItem[%item,$BPMaterial];
	%salvage = "";
	if ($MaterialSalvage[%material] != "")
		%salvage = $MaterialSalvage[%material];
	else
		%salvage = %material;
	//==========================================================================================
	// QL
	%ql = string::getSubStr(%item,0,3);
	//==========================================================================================
	// MATERIAL
	if (%salvage != "") {
		%m = %ql @ %salvage;
		if ($BPItem[%m,$BPName] == "")
			DynamicItem::InitWear(%m);
		AddToBackpack(%id,%m,1);
	}	
	//==========================================================================================
	// SOURCE
	%tier = GetBPData(%item,$BPItemType);
	%source = getWord(%tier,0);
	%ret = "";
	if (%source == 1) {
		if (RandBetween(1,9) == 1) %ret = "CommonSource";
		if (RandBetween(1,80) == 1) %ret = "MagicSource";
	}
	if (%source == 2) {
		if (RandBetween(1,6) == 1) %ret = "CommonSource";
		if (RandBetween(1,40) == 1) %ret = "MagicSource";
	}
	if (%source == 3) {
		if (RandBetween(1,3) == 1) %ret = "CommonSource";
		if (RandBetween(1,20) == 1) %ret = "MagicSource";
	}
	if (%source == 4) {
		%ret = "MagicSource";
		if (RandBetween(1,10) == 1) %ret = "RareSource";
	}
	if (%source == 5) {
		%ret = "RareSource";
		if (RandBetween(1,20) == 1) %ret = "LegendarySource";
	}
	if (%source == 6 || %source == 7)
		%ret = "LegendarySource";
	if (%ret != "") {
		%m = %ql @ %ret;
		if ($BPItem[%m,$BPName] == "")
			DynamicItem::InitWear(%m);
		AddToBackpack(%id,%m,1);
	}
	//==========================================================================================
	//AddToBackpack(%id,%m,1);
	RemoveFromBackpack(%id,%item,-1);
	Game::menuBackpack(%id,0);
}






$PlanLootOn[1] = 0;
$PlanLootOn[2] = 0;
$PlanLootOn[3] = 0;
$PlanLootOn[4] = 0;
$PlanLootOn[5] = 0;
$PlanLootOn[6] = 0;

function Plan::Add(%plan,%material,%req,%typereq,%plantier)
{
	echo("[PLAN ADD] " @ %plan @ " " @ %material);
	if ($MaterialSalvage[%material] != "")
		%material = $MaterialSalvage[%material];
	%name = "Plan*" @ %plan;
	$DynamicItem[%name,$DName] = "Plan: " @ %plan;
	$DynamicItem[%name,$DMaterial] = %material;
	$DynamicItem[%name,$DDesc] = "This plan can be used to create: " @ %plan;
	$DynamicItem[%name,$DPlanReqs] = %req;
	$DynamicItem[%name,$DPlanTypeReq] = %typereq;
	%on = $PlanLootOn[%plantier]++;
	$PLANLOOT[%plantier,%on] = %name;
}

function Plan::Create(%new,%ql,%init)
{
	echo("[PLAN CREATE] " @ %new @ " " @ %ql @ " " @ %init);
	%orig = %new;
	%find = string::FindSubStr(%new,"*");
	%name = string::GetSubStr(%new,(%find+1),999);
	if (!%init)
		%new = FormatQL(%ql) @ "Plan*" @ %name;
	else {
		%ql = string::getSubStr(%new,0,3);
		%orig = string::GetSubStr(%new,3,999);
	}
	//===============================================================================
	%price = $DynamicItem[%name,$DPrice];
	%price = getWord(%price,0);
	%price = round((%price * 10) * (%ql / 300));
	//===============================================================================
	$BPItem[%new,$BPPlan] = 1;
	$BPItem[%new,$BPName] = "Plan: " @ $DynamicItem[%name,$DName] @ " [" @ (%ql + 0) @ "]";
	$BPItem[%new,$BPWeight] = 1;
	$BPItem[%new,$BPPrice] = %price;
	$BPItem[%new,$BPDesc] = $DynamicItem[%orig,$DDesc];
	$BPItem[%new,$BPItemType] = "99 Plan";
	$BPItem[%new,$BPIco] = "planico.bmp";
	$BPItem[%new,$BPPlanTypeReq] = $DynamicItem[%orig,$DPlanTypeReq];
	//===============================================================================
	%req = $DynamicItem[%orig,$DPlanReqs];
	%v = round(3000 * (%ql / 300));
	if (%req == "AMR") %req = "SMITHING " @ %v;
	else if (%req == "DYN") %req = "MAGICCRAFT " @ %v;
	else if (%req == "EVA") %req = "SMITHING " @ %v;
	else if (%req == "RES") %req = "MAGICCRAFT " @ %v;
	else if (%req == "WPN") %req = "SMITHING " @ %v;
	else if (%req == "STF") %req = "MAGICCRAFT " @ %v;
	else if (%req == "MES") %req = "SMITHING " @ %v;
	else if (%req == "SPS") %req = "MAGICCRAFT " @ %v;
	else if (%req == "QUV") %req = "SMITHING " @ %v;
	//echo(" REQ " @ %req);
	$BPItem[%new,$BPPlanReqs] = %req;
	//===============================================================================
	%material = $DynamicItem[%orig,$DMaterial];
	%mats = %material @ " 1 ";
	$BPItem[%new,$BPPlanMats] = %mats;
	//===============================================================================
	$BPItem[%new,$BPCraftType] = "PLAN";
	return %new;
}

function Plan::IsPlanItem(%item)
{
	for (%i = 0; (%w = getWord($PLANITEMCHECK,%i)) != -1; %i++) {
		if (string::FindSubStr(%item,%w) != -1)
			return True;
	}
	return False;
}


function AddToPlanCraft(%id,%item)
{
	echo(" ADDTOPLANCRAFT " @ %id @ " " @ %item);
	%ok = 0;
	if (%id.PlanCraft[1] == "") { %id.PlanCraft[1] = %item; %ok = 1; }
	if (%id.PlanCraft[2] == "" && !%ok) { %id.PlanCraft[2] = %item; %ok = 1; }
	if (%id.PlanCraft[3] == "" && !%ok) { %id.PlanCraft[3] = %item; %ok = 1; }
	if (%id.PlanCraft[4] == "" && !%ok) { %id.PlanCraft[4] = %item; %ok = 1; }
	if (%ok)
		Client::SendMessage(%id,2,"You added " @ GetBPData(%item,$BPName) @ " to your Plan Craft table.");
	else
		Client::SendMessage(%id,1,"Your Plan Crafting table is full.");
}

function ClearPlanCraftTable(%id,%clear)
{
	if (%clear != 1) {	
		%a = %id.PlanCraft[1];
		if (%a != "")
			AddToBackpack(%id,%a,1);
		%b = %id.PlanCraft[2];
		if (%b != "")
			AddToBackpack(%id,%b,1);
		%c = %id.PlanCraft[3];
		if (%c != "")
			AddToBackpack(%id,%c,1);
		%c = %id.PlanCraft[4];
		if (%c != "")
			AddToBackpack(%id,%c,1);
	}
	%id.PlanCraft[1] = "";
	%id.PlanCraft[2] = "";
	%id.PlanCraft[3] = "";
	%id.PlanCraft[4] = "";
	Client::SendMessage(%id,2,"Your Plan Crafting table was cleared.");
}

function Game::MenuPlanCraft(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Plan Crafting Table", "plancraft", true);
	if (%id.PlanCraft[1] != "") 
		Client::addMenuItem(%id, %curItem++ @ GetBPData(%id.PlanCraft[1],$BPName),%id.PlanCraft[1]);
	if (%id.PlanCraft[2] != "") 
		Client::addMenuItem(%id, %curItem++ @ GetBPData(%id.PlanCraft[2],$BPName),%id.PlanCraft[2]);
	if (%id.PlanCraft[3] != "") 
		Client::addMenuItem(%id, %curItem++ @ GetBPData(%id.PlanCraft[3],$BPName),%id.PlanCraft[3]);
	if (%id.PlanCraft[4] != "") 
		Client::addMenuItem(%id, %curItem++ @ GetBPData(%id.PlanCraft[4],$BPName),%id.PlanCraft[4]);
	if (%id.PlanCraft[1] != "" && %id.PlanCraft[2] != "" && %id.PlanCraft[3] != "" && %id.PlanCraft[4] != "")
		Client::addMenuItem(%id, %curItem++ @ "Complete...","complete");
	if (%id.PlanCraft[1] != "" || %id.PlanCraft[2] != "" || %id.PlanCraft[3] != "" || %id.PlanCraft[4] != "")
		Client::addMenuItem(%id, %curItem++ @ "Clear...","clear");
	Client::addMenuItem(%id, "p" @ "<< Prev","back");
}

function processMenuplancraft(%id, %option)
{
	if (%option == "back") {
		Game::MenuRequest(%id);
		return;
	}
	if (%option == "clear") {
		ClearPlanCraftTable(%id);
		Game::MenuRequest(%id);
		return;
	}
	if (%option == "complete") {
		BPPlanCraft(%id);
		return;
	}
	else {
		%msg = WhatIs(%option);
		SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
		Game::MenuPlanCraft(%id);
	}
}

$SOURCETIER[CommonSource] 	= 0;
$SOURCETIER[MagicSource]	= 4;
$SOURCETIER[RareSource]		= 5;
$SOURCETIER[LegendarySource]	= 6;

function BPPlanCraft(%id)
{
	%plan = "";
	%material = "";
	%source = "";
	//===================================================================================================
	// CHECK FOR PLAN
	if (string::FindSubStr(%id.PlanCraft[1],"Plan*") != -1) %plan = %id.PlanCraft[1];
	if (string::FindSubStr(%id.PlanCraft[2],"Plan*") != -1) %plan = %id.PlanCraft[2];
	if (string::FindSubStr(%id.PlanCraft[3],"Plan*") != -1) %plan = %id.PlanCraft[3];
	if (string::FindSubStr(%id.PlanCraft[4],"Plan*") != -1) %plan = %id.PlanCraft[4];
	if (%plan == "") {
		Client::SendMessage(%id,2,"You do not have a valid plan to craft from!");
		ClearPlanCraftTable(%id);
		return;
	}
	//===================================================================================================
	// BREAK DOWN PLAN
	%planql = string::getSubStr(%plan,0,3);
	%planql = %planql + 0;
	%find = string::FindSubStr(%plan,"*");
	%name = string::GetSubStr(%plan,(%find+1),999);
	%req = $BPItem[%plan,$BPPlanReqs];
	%mat = GetWord($BPItem[%plan,$BPPlanMats],0);
	if (%req == "" || %mat == "" || %name == "") {
		Client::SendMessage(%id,1,"INTERNAL ERROR x0. Please contact an administrator.");
		return;
	}
	echo(" PLAN REQ " @ %req @ " " @ %mat @ " " @ %name);
	//===================================================================================================
	// CHECK FOR MATERIAL
	if (string::FindSubStr(%id.PlanCraft[1],%mat) != -1) %material = %id.PlanCraft[1];
	if (string::FindSubStr(%id.PlanCraft[2],%mat) != -1) %material = %id.PlanCraft[2];
	if (string::FindSubStr(%id.PlanCraft[3],%mat) != -1) %material = %id.PlanCraft[3];
	if (string::FindSubStr(%id.PlanCraft[4],%mat) != -1) %material = %id.PlanCraft[4];
	// BREAK DOWN MATERIAL
	if (%material == "") {
		Client::SendMessage(%id,2,"You do not have this Plan's required material: " @ %mat);
		ClearPlanCraftTable(%id);
		return;
	}
	%materialql = string::getSubStr(%material,0,3);
	%materialql = %materialql + 0;
	if ((%materialql / %planql) < 0.8) {
		Client::SendMessage(%id,2,"Your " @ %mat @ " Quality Level is too low for this Plan!");
		ClearPlanCraftTable(%id);
		return;
	}
	%materialName = string::GetSubStr(%material,3,999);
	echo("MATERIAL NAME " @ %materialName);
	//===================================================================================================
	// CHECK FOR SOURCE
	%source = "";
	if (string::FindSubStr(%id.PlanCraft[1],"Source") != -1) %source = %source @ %id.PlanCraft[1] @ " ";
	if (string::FindSubStr(%id.PlanCraft[2],"Source") != -1) %source = %source @ %id.PlanCraft[2] @ " ";
	if (string::FindSubStr(%id.PlanCraft[3],"Source") != -1) %source = %source @ %id.PlanCraft[3] @ " ";
	if (string::FindSubStr(%id.PlanCraft[4],"Source") != -1) %source = %source @ %id.PlanCraft[4] @ " ";
	// BREAK DOWN SOURCE
	if (getWord(%source,1) == -1) {
		Client::SendMessage(%id,2,"You need 2 Sources to complete this craft!");
		ClearPlanCraftTable(%id);
		return;
	}
	// CHECK FOR SAME SOURCE	
	%sourcecheck = getWord(%source,0);
	%sourceql[0] = string::getSubStr(%sourcecheck,0,3);
	%sourceql[0] = %sourceql[0] + 0;
	%sourceName[0] = string::GetSubStr(%sourcecheck,3,999);
	%sourcecheck = getWord(%source,1);
	%sourceql[1] = string::getSubStr(%sourcecheck,0,3);
	%sourceql[1] = %sourceql[1] + 0;
	%sourceName[1] = string::GetSubStr(%sourcecheck,3,999);
	if (%sourceName[0] != %sourceName[1]) {
		Client::SendMessage(%id,2,"You must have 2 matching Source types to craft a plan!");
		ClearPlanCraftTable(%id);
		return;
	}
	if ((%sourceql[0] / %planql) < 0.8 || (%sourceql[1] / %planql) < 0.8) {
		Client::SendMessage(%id,2,"Your Quality Level of your Sources is too low!");
		ClearPlanCraftTable(%id);
		return;
	}
	%sourceName = %sourceName[0];
	//===================================================================================================
	// CHECK FOR SKILL
	%skill = $BPItem[%plan,$BPPlanReqs];
	if (%skill == "") {
		Client::SendMessage(%id,1,"INTERNAL ERROR x1. Please contact an administrator.");
		return;
	}
	if (CanBackpackWield(%id,"",1,%skill) == False) {
		Client::SendMessage(%id,2,"You do not have the skills to use this plan!");
		return;
	}
	//===================================================================================================
	// BUILD THE NEW ITEM
	%tier = $SOURCETIER[%sourceName];
	if (%tier == 0)
		%tier = RandBetween(0,3);
	%typereq = $BPItem[%plan,$BPPlanTypeReq];
	%vtype = $DynamicItem[%name,$DItemType];
	%reqname = $DynamicItem[%name,$DReqName];
	echo(" TIER " @ %tier);	
	echo(" VTYPE " @ %vtype);
	echo(" NAME " @ %name);
	echo(" REQNAME " @ %reqname);
	echo(" TYPEREQ " @ %typereq);
	if (%tier == "" || %typereq == "" || %vtype == "") {
		Client::SendMessage(%id,1,"INTERNAL ERROR x2. Please contact an administrator.");
		return;
	}
	if (%typereq == "") {
		Client::SendMessage(%id,1,"INTERNAL ERROR x3. Please contact an administrator.");
		return;
	}
	if (%typereq == 2) {
		%vtype = getWord(%vtype,1);
		%vtname = $TIERNAME[%vtype,%reqname,%tier] @ %name;
	}
	else if (%typereq == 1) {
		%vtype = getWord(%vtype,1);
		%check = $TIERNAME[%vtype,%tier];
		if (%check != "") %vtname = %check @ %name;
		%check = $TIERNAME[%name,%tier];
		if (%check != "") %vtname = %check @ %name;
	}
	echo(" VTNAME " @ %vtname);
	%ret = TierItem::RandomItem(%vtname,%planql);
	Client::SendMessage(%id,3,"You successfully craft " @ GetBPData(%plan,$BPName));
	AddToBackpack(%id,%ret,1);
	%msg = WhatIs(%ret);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));
	Game::MenuBackpack(%id,0);
	ClearPlanCraftTable(%id,1);
}






function Loot::GrabType6(%mf)
{
	%x = MTRB(1,100);
	if (%x >= 1 && %x <= 25) return "BODY";
	if (%x >= 26 && %x <= 51) {
		if (MTRB(1,2) == 1) return "EXTRA";
		else return "MAGIC";
	}
	if (%x >= 52 && %x <= 72) {
		if (MTRB(1,2) == 1) return "WEAPON";
		else return "SPELL";
	}
	if (%x >= 73 && %x <= 83) return "PLAN";
	if (%x >= 84 && %x <= 92) return "RELIC";
	if (%x >= 93 && %x <= 97) return "RUNE";
	if (%x >= 98 && %x <= 100) return "MAP";
}

function Loot::GrabType5(%mf)
{
	%x = GetRandomMT() * 1.0;
	if (%mf > 4.5) %mf = 4.5;
	if (%x <= (0.0066 * %mf)) return "MAP";
	if (%x <= (0.0100 * %mf)) return "RUNE";
	if (%x <= (0.0200 * %mf)) return "RELIC";
	if (%x <= (0.0333 * %mf)) return "PLAN";
	if (%x <= (0.1000 * %mf)) {
		if (MTRB(1,2) == 1) return "WEAPON";
		else return "SPELL";
	}
	if (%x <= (0.2000 * %mf)) {
		if (MTRB(1,2) == 1) return "EXTRA";
		else return "MAGIC";
	}
	return "BODY";
}

function Loot::GrabType4(%mf)
{
	%max = 512;
	%x = MTRB(1,%max);
	if (%mf > 3.5) %mf = 3.5;
	if (%x <= round(%max * (0.00195 * %mf))) return "MAP";
	if (%x <= round(%max * (0.00390 * %mf))) return "RUNE";
	if (%x <= round(%max * (0.00781 * %mf))) return "RELIC";
	if (%x <= round(%max * (0.01562 * %mf))) return "PLAN";
	if (%x <= round(%max * (0.03125 * %mf))) return "WEAPON";
	if (%x <= round(%max * (0.06250 * %mf))) return "SPELL";
	if (%x <= round(%max * (0.12500 * %mf))) return "MAGIC";
	if (%x <= round(%max * (0.25000 * %mf))) return "EXTRA";
	return "BODY";
}

function Loot::GrabType3(%mf)
{
	%v = "BODY";
	if (Loot::Ratio(1,4,%mf,2) == True) { %v = "EXTRA"; }
	if (Loot::Ratio(1,8,%mf,4) == True) { %v = "MAGIC"; }
	if (Loot::Ratio(1,16,%mf,8) == True) { %v = "SPELL"; }
	if (Loot::Ratio(1,32,%mf,16) == True) { %v = "WEAPON"; }
	if (Loot::Ratio(1,64,%mf,32) == True) { %v = "PLAN"; }
	if (Loot::Ratio(1,128,%mf,64) == True) { %v = "RELIC"; }
	if (Loot::Ratio(1,256,%mf,128) == True) { %v = "RUNE"; }
	if (Loot::Ratio(1,512,%mf,256) == True) { %v = "MAP"; }
	return(%v);
}

function Loot::GrabType2(%mf)
{
	%t = 0;
	%v = "BODY ";
	if (Loot::Ratio(1,5,%mf) == True) { %v = %v @ "EXTRA "; %t++; }
	if (Loot::Ratio(1,10,%mf) == True) { %v = %v @ "MAGIC "; %t++; }
	if (Loot::Ratio(1,20,%mf) == True) { %v = %v @ "SPELL "; %t++; }
	if (Loot::Ratio(1,38,%mf) == True) { %v = %v @ "WEAPON PLAN "; %t+=2; }
	if (Loot::Ratio(1,80,%mf) == True) { %v = %v @ "RELIC "; %t++; }
	if (Loot::Ratio(1,160,%mf) == True) { %v = %v @ "RUNE "; %t++; }
	if (Loot::Ratio(1,320,%mf) == True) { %v = %v @ "MAP "; %t++; }
	%x = MTRB(0,%t);
	echo(" V " @ %v);
	return getWord(%v,%x);
}



	// ROLL
	for (%i = 1; %i <= %p; %i++) {
		%r = floor(getRandomMT() * %numr + 1);
		%s = %s @ $BPTIERVAR[%x,%greq,%r];
		%echo = $BPTIERVAR[%x,%greq,%r];
		%val = $BPTIERVAL[%x,%greq,%r];
		%m = $BPMOD[%echo];
		if ($BPNoFlux[%m] != 1) %val = round(%val * (%ql / 300));
		if ($BPNoFlux[%m] == 1) { %newmin = 1; %newmax = 100; }
		else { %newmin = %min; %newmax = %max; }
		%minval = floor((%val * (%newmin / 100)) * %tiermulti);
		%maxval = floor((%val * (%newmax / 100)) * %tiermulti);
		if (%minval < 1) %minval = 1;
		if (%maxval < 1) %maxval = 1;
		%roll = MTRB(%minval,%maxval);
		//%roll = round(getRandom() * (%maxval - %minval) + %minval);
		%roll = TierFormatValue(%roll);
		%s = %s @ %roll;
	}

	// if (%p == 6) %p = RandBetween(6,10);
	if (%p == 6) %p = MTRB(6,10);
	if (%plus != "") %p = %plus;
	//echo(" P: " @ %p);

$PLANITEMCHECK = $PLANITEMCHECK @ "Plan* ";



function TierItem::RandomItem(%item,%ql,%overridep,%hardvals,%oldtier,%prevmain,%sockchance,%plus)
{
	echo("[TIERITEM::RANDOMITEM] ITEM:" @ %item @ " QL:" @ %ql @ " OVERRIDEP:" @ %overridep @ " HARDVALS:" @ %hardvals @ " OLDTIER:" @ %oldtier @ " PREVMAIN:" @ %prevmain @ " SOCKCHANCE:" @ %sockchance @ " PLUS:" @ %plus);
	if (%item == "") {
		echo(" ================================================================================= ");
		echo(" WARNING : BLANK ITEM INPUT ");
		echo(" ABORTING ITEM BUILD ");
		echo(" ================================================================================= ");
		return;
	}
	if (string::FindSubStr(%item,"Plan*") != -1) {
		Plan::Create(%item,%ql);
		return;
	}
	%s = "";
	%n = $DynamicItem[%item,$DName];
	%h = $DynamicItem[%item,$DTierHard];
	%p = $DynamicItem[%item,$DTierProp];
	%x = $DynamicItem[%item,$DItemType];
	%greq = $DynamicItem[%item,$DReq];
	%main = $DynamicItem[%item,$DMain];
	%tier = getWord(%x,0);
	%x = getWord(%x,1);
	%magic = 0;
	if (%x == "MagicWeapon") { %x = "Weapon"; %magic = 1; }
	%tiermulti = $BPTIERBONUS[%tier];
	%numr = $TierRandom[%x,%greq];
	%perc = $DynamicItem[%item,$DTierPerc];
	%min = getWord(%perc,0);
	%max = getWord(%perc,1);
	%dperc = $DynmicItem[%item,$DPerc];
	if (%dperc == "") %dperc = 1.0;
	//===============================================================================
	if (%plus != "") %p = %plus;
	//===============================================================================
	// COUNT HARD PROPS
	%hardcount = 0;
	%newmulti = "";
	%hardinit = 0;
	%damageset = 0;
	if (%oldtier != "")
		%newmulti = ($BPTIERBONUS[%tier] - $BPTIERBONUS[%oldtier]) + 1;
	if (%h != "" && %hardvals == "") {
		%hardvals = %h;
		%hardinit = 1;
	}
	if (%hardvals != "") {
		echo(" HARDVALS " @ %hardvals);
		for (%i = 0; (%mod = getWord(%hardvals,%i)) != -1; %i+=2) {
			if ($DamageSetCheck[%mod] == 1) %damageset = 1;
			%p = %p - 1;
			%val = getWord(%hardvals,%i+1);
			if (%val == "R") {
				%r = $BPTIERNUM[%x,%greq,%mod];
				%s = %s @ $BPCODE[%mod];
				%val = $BPTIERVAL[%x,%greq,%r];
				if ($BPNoFlux[%mod] != 1) %val = round(%val * (%ql / 300));
				if ($BPNoFlux[%mod] == 1) { %newmin = 1; %newmax = 100; }
				else { %newmin = %min; %newmax = %max; }
				%minval = floor((%val * (%newmin / 100)) * %tiermulti);
				%maxval = floor((%val * (%newmax / 100)) * %tiermulti);
				//echo(" [MINVALMAXVAL] " @ %minval @ " " @ %maxval);
				if (%minval < 1) %minval = 1;
				if (%maxval < 1) %maxval = 1;
				%roll = MTRB(%minval,%maxval);
				//%roll = round(getRandom() * (%maxval - %minval) + %minval);
				if (%hardinit)
					%roll = TierFormatValue(%roll,2);
				else
					%roll = TierFormatValue(%roll,0);
				%s = %s @ %roll;
			}
			else if (string::FindSubStr(%val,"H:") != -1) {
				%newval = String::GetSubStr(%val,2,99);
				%s = %s @ $BPCODE[%mod] @ TierFormatValue(%newval,2);
			}
			else if (string::FindSubStr(%val,"L:") != -1) {
				%newval = String::GetSubStr(%val,2,99);
				%newval = round(%newval * (%ql/300));
				%s = %s @ $BPCODE[%mod] @ TierFormatValue(%newval,2);
			}
			else {
				if (string::findSubStr(%val,"+") == -1 && string::findSubStr(%val,"$") == -1) {
					%val = round(%val * %newmulti);
					%s = %s @ $BPCODE[%mod] @ TierFormatValue(%val,0);
				}
				else {
					if (string::findSubStr(%val,"+") != -1) %char = 1;
					if (string::findSubStr(%val,"$") != -1) %char = 2;
					%val = BPStripPlus(%val);
					%val = round(%val * %newmulti);
					%s = %s @ $BPCODE[%mod] @ TierFormatValue(%val,%char);
				}
			}
		}
	}
	//===============================================================================
	// SOCKETS
	%sockets = $BPSOCKETS[%x];
	if (%sockchance != "") 
		%sockets = %sockchance;
	if (%p > 0) {
		for (%i = 1; %i <= %sockets; %i++) {
			%sok = MTRB(1,%numr);
			if (%sok == 1 && %p > 0) {
				%s = %s @ "SOK000001";
				%p = %p - 1;
			}
		}
	}
	//===============================================================================
	// DAMAGE TYPE
	if (%x == "Weapon" && %magic != 1) {
		if (%damageset == 0) {
			if (%p > 0) {
				%t = MTRB(1,%numr);
				if (%t <= %p) {
					%c = MTRB(1,4);
					%s = %s @ $BPRANDOMDAMAGE[%c] @ "000001";
					%p = %p - 1;
				}
			}
		}
	}
	//===============================================================================
	// ROLL
	%list = $BPTIERLST[%x,%greq];
	%list = String::Shuffle(%list);			
	for (%i = 1; %i <= %p; %i++) {
		%mod = getWord(%list,%i-1);
		%s = %s @ %mod;
		%m = $BPMOD[%mod];
		%num = $BPTIERNUM[%x,%greq,%m];
		%val = $BPTIERVAL[%x,%greq,%num];
		if ($BPNoFlux[%m] != 1) %val = round(%val * (%ql / 300));
		echo(" TIER MULTI " @ %tiermulti);
		echo(" MIN " @ %min);
		echo(" MAX " @ %max);
		%minval = floor((%val * (%min / 100)) * %tiermulti);
		%maxval = floor((%val * (%max / 100)) * %tiermulti);
		if (%minval < 1) %minval = 1;
		if (%maxval < 1) %maxval = 1;
		%roll = MTRB(%minval,%maxval);
		%roll = TierFormatValue(%roll);
		%s = %s @ %roll;
	}
	//===============================================================================
	// RANP
	%test = floor(getRandom() * 200 + 1);
	%ranp = 0;
	if (%test <= 6) { %ranp = floor(getRandomMT() * 5 + 1); }
	if (%test <= 3) { %ranp = floor(getRandomMT() * 10 + 10); }
	if (%test <= 1) { %ranp = floor(getRandomMT() * 10 + 20); }
	//===============================================================================
	// MAIN
	if (%main == "NON 0 0") {
		%m = "NON000000";
	}
	else {
		if (%main == "ARMOR") {
			%roll = TierItem::getImplictRoll(%x,%greq,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "ARM" @ TierFormatValue(%roll);
		}
		else if (%main == "EVASION") {
			%roll = TierItem::getImplictRoll(%x,%greq,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "EVV" @ TierFormatValue(%roll);
		}
		else if (%main == "ALLRESIST") {
			%roll = TierItem::getImplictRoll(%x,%greq,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "ARS" @ TierFormatValue(%roll);
		}
		else if (%main == "ARMORPEN") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			%m = "ARP" @ TierFormatValue(%roll);
		}
		else if (%main == "CRITDAMAGE") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			%m = "CRD" @ TierFormatValue(%roll);
		}
		else if (%main == "CRITCHANCE") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			%m = "CRC" @ TierFormatValue(%roll);
		}
		else if (%main == "MAXHP") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			%m = "MXH" @ TierFormatValue(%roll);
		}
		else if (%main == "MAGICPEN") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			%m = "MGP" @ TierFormatValue(%roll);
		}
		else if (%main == "SPELLCRITDAMAGE") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			%m = "SPD" @ TierFormatValue(%roll);
		}
		else {
			%minval = getWord(%main,1);
			%maxval = getWord(%main,2);
			%roll = MTRB(%minval,%maxval);
			//%roll = round(getRandom() * (%maxval - %minval) + %minval);
			%m = getWord(%main,0) @ TierFormatValue(%roll);
		}
	}
	//===============================================================================
	// SHIELDS
	%blocktype = $DynamicItem[%item,$DBlockType];
	if (%blocktype != "") {
		%blockchance = $DynamicItem[%item,$DBlockChance];
		%minval = getWord(%blockchance,0);
		%maxval = getWord(%blockchance,1);
		%roll = MTRB(%minval,%maxval);
		//%roll = round(getRandom() * (%maxval - %minval) + %minval);
		if (%blocktype == "PHYSICAL")
			%m = %m @ "BLK" @ TierFormatValue(round(%roll * %tiermulti));
		else
			%m = %m @ "BLS" @ TierFormatValue(round(%roll * %tiermulti));
		%blockamount = $DynamicItem[%item,$DBlockAmount];
		%minval = round(getWord(%blockamount,0) * (%ql / 300)) + 1;
		%maxval = round(getWord(%blockamount,1) * (%ql / 300)) + 5;
		%roll = MTRB(%minval,%maxval);
		//%roll = round(getRandom() * (%maxval - %minval) + %minval);
		if (%blocktype == "PHYSICAL")
			%m = %m @ "BLA" @ TierFormatValue(round(%roll * %tiermulti));
		else
			%m = %m @ "SBA" @ TierFormatValue(round(%roll * %tiermulti));
	}
	//===============================================================================
	// QUIVERS
	if ($DynamicItem[%item,$DIsQuiver]) {
		%qd = $DynamicItem[%item,$DQuiverDamage];
		%qdmax = round((%qd * 1.3) * (%ql / 300));
		%qdmin = round((%qd * 0.7) * (%ql / 300));
		%qd = MTRB(%qdmax,%qdmin);
		if (%qd < 1) %qd = 1;
		%m = "RRB" @ TierFormatValue(%qd);
	}
	//===============================================================================
	// PREVMAIN
	if (%prevmain != "") {
		if (%oldtier > %tier) {
			%t = string::getSubStr(%prevmain,0,3);
			%v = string::getSubStr(%prevmain,4,6);
			%v = (%v + 0);
			%oldbonus = $BPTIERBONUS[%oldtier];
			%newbonus = $BPTIERBONUS[%tier];
			%d = (%oldbonus - %newbonus);
			%d = 1.05 - %d;
			%m = %t @ TierFormatValue(round(%v * %d));
		}
		else {
			if (%newmulti != "") {
				%t = string::getSubStr(%prevmain,0,3);
				%v = string::getSubStr(%prevmain,4,6);
				%v = (%v + 0);
				%m = %t @ TierFormatValue(floor(%v * %newmulti));
			}
			else 
				%m = %prevmain;
		}
	}
	//===============================================================================
	// QUALITY
	if (%ql < 100) { %ql = "0" @ %ql; }
	if (%ql < 10) { %ql = "0" @ %ql; }
	if (%overridep != "") %ranp = %overridep;
	//===============================================================================
	%full = %ql @ %item @ "&" @ %m @ "^" @ %s @ "%" @ %ranp;
	//echo(%full);
	TierItem::Create(%full,%x);
	return %full;
}

function TierItem::Create(%new,%slot)
{
	echo("[TIERITEM::CREATE] " @ %new @ " " @ %slot);
	//===============================================================================
	// BREAK STRING
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),999);
	%find = string::FindSubStr(%main,"^");
	%main = string::getSubStr(%main,0,%find);
	//------------------------------------------------------
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	%ql = floor(string::GetSubStr(%new,0,3) + 0);
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	%plen = string::len(%tperc) + 1;
	%sreq = $DynamicItem[%name,$DReq];
	%find = string::FindSubStr(%new,"^");
	%perc = (%tperc / 100) + 1;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));
	//echo(" CROPPARTS " @ %cropparts);
	//===============================================================================
	// INITIAL CREATE
	if (%slot == -1) {
		%slot = $DynamicItem[%name,$DItemType];
		%slot = getWord(%slot,1);
	}
	//===============================================================================
	// BREAK LIST
	%start = 0;
	for (%i = 1; %i <= 30; %i++) {
		%s[%i] = string::GetSubStr(%cropparts,%start,9);
		%start += 9;
	}
	//===============================================================================
	// SOCKETS & RUNE & DAMAGETYPE
	%sockets = 0;
	%newlist = "";
	%runelist = "";
	%dd = "";
	for (%i = 1; %i <= 30; %i++) {
		if ((%crop = %s[%i]) != "") {
			%code = string::getSubStr(%crop,0,3);
			if (%code == "SOK") %sockets++;
			if ($BPCODEDAMAGE[%code] != "") %dd = $BPCODEDAMAGE[%code];
			%v = string::getSubStr(%crop,3,9);
			if ((%l = string::findSubStr(%v,"+")) != -1) {
				%v = string::getSubStr(%v,(%l+1),9);
				%val[%code] += (%v + 0);
				%runelist = %runelist @ %code @ " ";
			}
			else {
				if ((%l = string::findSubStr(%v,"$")) != -1)
					%v = string::getSubStr(%v,(%l+1),9);
				%val[%code] += (%v + 0);
				%full[%code] = 1;
			}
			if (string::findSubStr(%newlist,%code) == -1)
				%newlist = %newlist @ %code @ " ";
		}
	}
	//===============================================================================
	// MODS AND REQ
	%AMRBASE = 0;
	%RESBASE = 0;
	%EVABASE = 0;
	%AMRINC = 0;
	%EVAINC = 0;
	%RESINC = 0;
 	%DMGINC = 0;
 	%MINDMG = 0;
	%MAXDMG = 0;
	%BLKADD = 0;
	%BLSADD = 0;
	%BLAADD = 0;
	%SPAADD = 0;
	// ----------------------------------------------------
	%list = "";
	%weight = 0;
	for (%i = 1; %i <= 6; %i++) %r[%i] = 0;
	for (%i = 1; %i <= 6; %i++) %rh[%i] = 0;
	for (%i = 0; %i <= 30; %i++) {
		if ((%newcode = getWord(%newlist,%i)) != -1) {
			%multi = round(%val[%newcode] * %perc);
			%mod = $BPMOD[%newcode];
			%req = $TierReq[%mod];
			%isfull = 0;
			if (%full[%newcode] == 1) {
				%rf[%req] = 1;
				%isfull = 1;
			}
			if (%req == "") %req = 1;
			if (%r[%req] == 0) {
				if (%mod != "SOCKET") {
					if (%isfull == 1) {
						%r[%req] += $TierReqP[%mod];
						%rh[%req] = $TierReqP[%mod];
					}
					else {
						%r[%req] += ($TierReqP[%mod] / 2);
						%rh[%req] = ($TierReqP[%mod] / 2);
					}
				}
			}
			else {
				%reqp = $TierReqP[%mod];
				if (%isfull == 0) 
					%reqp = (%reqp / 2);
				if (%rh[%req] < %reqp) {
					if (%mod != "SOCKET") {
						%rh[%req] = %reqp;
						%r[%req] = %reqp;
					}
				}
				else {
					if (%mod != "SOCKET")
						%r[%req] = %reqp;
				}
			}
			%weight = %weight + floor(floor(floor($TierWeight[%stat] * %perc) + 1) * (%ql/300));
			%weight = %weight + 1;
			if (%mod != "SOCKET")
				%list = %list @ %mod @ " " @ %multi @ " ";
			// ----------------------------------------------------
			// ARMORS
			if (%newcode == "ARM") %AMRBASE += %multi;
			if (%newcode == "EVV") %EVABASE += %multi;
			if (%newcode == "ARS") %RESBASE += %multi;
			if (%newcode == "INA") %AMRINC += %multi;
			if (%newcode == "INE") %EVAINC += %multi;
			if (%newcode == "IRR") %RESINC += %multi;
			// ----------------------------------------------------
			// WEAPONS
			if (%newcode == "IND") %DMGINC += %multi;
			if (%newcode == "MND") %MINDMG += %multi;
			if (%newcode == "MXD") %MAXDMG += %multi;
			// ----------------------------------------------------
			// SHIELDS
			if (%newcode == "BLK") %BLKADD += %multi;
			if (%newcode == "BLS") %BLSADD += %multi;
			if (%newcode == "BLA") %BLAADD += %multi;
			if (%newcode == "SPA") %SPAADD += %multi;
			// ----------------------------------------------------
			// MAGIC WEAPONS
		}
	}
	%rlist = "";
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	%rmax = 1500;
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	for (%i = 1; %i <= 3; %i++) {
		if (%r[%i] > 0) {
			%radd = floor(floor(floor((%rmax * %r[%i]) * %perc) * (%ql / 300)) + 0);
			%rlist = %rlist @ $reqdisp[%i] @ " " @ %radd @ " ";
		}
	}
	if (%slot == "Mod")
		%rlist = "";
	//===============================================================================
	// MAIN REQ
	%fixedreq = "";
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	%rmax = 3000;
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	if (%sreq == "AMR" || %sreq == "LAMR") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[1] @ " " @ %radd @ " ";
		%fixedreq = "1";
	}
	if (%sreq == "MES" || %sreq == "LMES") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[1] @ " " @ %radd @ " ";
		%fixedreq = "1";
	}
	if (%sreq == "EVA" || %sreq == "LEVA") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[2] @ " " @ %radd @ " ";
		%fixedreq = "2";
	}
	if (%sreq == "RES" || %sreq == "LRES") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[3] @ " " @ %radd @ " ";
		%fixedreq = "2";
	}
	if (%sreq == "SPS" || %sreq == "LSPS") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[3] @ " " @ %radd @ " ";
		%fixedreq = "3";
	}
	if (%sreq == "WPN") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DWeaponPerc];
		%wreq = $DynamicItem[%name,$DWeaponReq];
		if (%perc < 1.0) %perc = %perc * 1.2;
		if (%perc > 1.0) %perc = 1.0;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ %wreq @ " " @ %radd @ " ";
	}
	if (%sreq == "STF") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DWeaponPerc];
		%wreq = $DynamicItem[%name,$DWeaponReq];
		if (%perc < 1.0) %perc = %perc * 1.2;
		if (%perc > 1.0) %perc = 1.0;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ %wreq @ " " @ %radd @ " ";
	}
	if (%sreq == "QUV") {
		%rlist = "";
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ "Archery" @ " " @ %radd @ " ";
	}
	if (%sreq == "LIT") {
		%rlist = "";
		%radd = floor((%rmax * 0.5) * (%ql / 300));
		%rlist = %rlist @ "Literacy" @ " " @ %radd @ " ";
	}
	if (%fixedreq != "" && %runelist != "") {
		for (%i = 1; %i <= 3; %i++) %rr[%i] = 0;
		for (%i = 1; %i <= 3; %i++) %rrh[%i] = 0;
		for(%i = 0; (%rune = getWord(%runelist,%i)) != -1; %i++) {
			%mod = $BPMOD[%rune];
			%trp = ($TierReqP[%mod] / 2);
			%treq = $TierReq[%mod];
			if (%trp > %rrh[%treq]) {
				%rr[%treq] = %trp;
				%rrh[%treq] = %trp;
			}
		}
		for (%i = 1; %i <= 3; %i++) {
			if (string::findSubStr(%fixedreq,%i) == -1) {
				if (%rr[%i] > 0) {
					%radd = floor(floor(floor((2300 * %rr[%i]) * %perc) * (%ql / 300)) + 0);
					%rlist = %rlist @ $reqdisp[%i] @ " " @ %radd @ " ";
				}
			}
		}
	}
	//===============================================================================
	// LEVEL REQ
	%lreq = floor(%ql / 2);
	if (%slot != "Mod")
		%rlist = %rlist @ "LVLG " @ %lreq;
	//===============================================================================
	// PRICE
	%price = $DynamicItem[%name,$DPrice];
	%pmin = getWord(%price,0);
	%praise = getWord(%price,1);
	%x = $DynamicItem[%name,$DItemType];
	%rare = getWord(%x,0);
	%price = floor((%pmin / 300) * %ql) + 1;
	%price = floor(%price * getRarityPriceIncrease(%rare));
	//===============================================================================
	// WEAPON
	if (%sreq == "WPN") {
		// DAMAGE
		%wperc = (%ql / 300);
		%min = ($DynamicItem[%name,$DWeaponMinDmg] * %wperc);
		%max = ($DynamicItem[%name,$DWeaponMaxDmg] * %wperc);
		%min += %MINDMG;
		%max += %MAXDMG;
		%ranged = $DynamicItem[%name,$DRanged];
		if (%ranged) %maxcap = MaxCap(%DMGINC,200);
		else %maxcap = MaxCap(%DMGINC,300);
		%min = round(%min * (1 + (%maxcap / 100)));
		%max = round(%max * (1 + (%maxcap / 100)));
		%delay = $DynamicItem[%name,$DWeaponDelay];
		if (%delay == 1) { %mindmgx = 1; %maxdmgx = 5; }
		if (%delay == 2) { %mindmgx = 2; %maxdmgx = 10; }
		if (%delay == 3) { %mindmgx = 3; %maxdmgx = 15; }
		%min = %min + %mindmgx;
		%max = %max + %maxdmgx;
		if (%min < 1) %min = 1;
		if (%max < 5) %max = 5;
		if (%min > %max)
			%max = %min;
		$BPItem[%new,$BPDamage] = %min @ " - " @ %max;
		$BPItem[%new,$BPWeaponCritChance] = $DynamicItem[%name,$DWeaponCritChance];
		$BPItem[%new,$BPWeaponCritDamage] = $DynamicItem[%name,$DWeaponCritDamage];
		if (%dd != "")
			$BPItem[%new,$BPDamageType] = %dd;
		else
			$BPItem[%new,$BPDamageType] = $DynamicItem[%name,$DDamageType];
		$BPItem[%new,$BPATKSkills] = $DynamicItem[%name,$DATKSkills];
		$BPItem[%new,$BPDEFSkills] = $DynamicItem[%name,$DDEFSkills];
		$BPItem[%new,$BPWeaponDelay] = $DynamicItem[%name,$DWeaponDelay];
		$BPItem[%new,$BPWeaponTwoHand] = $DynamicItem[%name,$DWeaponTwoHand];
	}
	//===============================================================================
	// MAGICWEAPON
	if (%sreq == "STF") {
		%wperc = (%ql / 300);
		%mag = round($DynamicItem[%name,$DWeaponMagDmg] * %wperc);
		$BPItem[%new,$BPWeaponMagDamage] = %mag;
		$BPItem[%new,$BPWeaponCritChance] = $DynamicItem[%name,$DWeaponCritChance];
		$BPItem[%new,$BPWeaponCritDamage] = $DynamicItem[%name,$DWeaponCritDamage];
		$BPItem[%new,$BPATKSkills] = $DynamicItem[%name,$DATKSkills];
		$BPItem[%new,$BPDEFSkills] = $DynamicItem[%name,$DDEFSkills];
		$BPItem[%new,$BPWeaponTwoHand] = $DynamicItem[%name,$DWeaponTwoHand];
	}
	//===============================================================================
	// IMPLICIT
	%implicit = "";
	%crop = %main;
	if (string::getSubStr(%crop,9,3) == "") {
		%mod = string::getSubStr(%crop,0,3);
		%val = string::getSubStr(%crop,3,6);
		if (%mod != "NON") {
			%val = %val + 0;
			if (%mod == "ARM") %val = round((%val + %AMRBASE) * (1 + (MaxCap(%AMRINC,300) / 100)));
			if (%mod == "EVV") %val = round((%val + %EVABASE) * (1 + (MaxCap(%EVAINC,300) / 100)));
			if (%mod == "ARS") %val = round((%val + %RESBASE) * (1 + (MaxCap(%RESINC,300) / 100)));
			%val = floor(%val * (1 + (%tperc / 100)));
			%mod = $BPMOD[%mod];
			%implicit = %mod @ " " @ %val;
		}
	}
	else {
		%start = 0;
		for (%i = 1; %i <= 30; %i++) {
			%s[%i] = string::GetSubStr(%crop,%start,9);
			%start += 9;
		}
		for (%i = 1; %i <= 30; %i++) {
			if ((%crop = %s[%i]) != "") {
				%mod = string::getSubStr(%crop,0,3);
				%val = string::getSubStr(%crop,3,6);
				%val = %val + 0;
				if (%mod == "ARM") %val = round((%val + %AMRBASE) * (1 + (MaxCap(%AMRINC,300) / 100)));
				if (%mod == "ARS") %val = round((%val + %RESBASE) * (1 + (MaxCap(%RESINC,300) / 100)));
				if (%mod == "BLK") %val = round(%val + %BLKADD);
				if (%mod == "BLS") %val = round(%val + %BLSADD);
				if (%mod == "BLA") %val = round(%val + %BLAADD);
				if (%mod == "SPA") %val = round(%val + %SPAADD);
				%implicit = %implicit @ $BPMOD[%mod] @ " " @ %val @ " ";
			}
		}
	}
	//===============================================================================
	// VISUAL
	if ((%vis = $DynamicItem[%name,$DVis]) != "") {
		$BPItem[%new,$BPVis] = %vis;
		%visslot = $DynamicItem[%name,$DVisSlot];
		//echo("NAME " @ %name @ " VIS:" @ %vis @ " VISSLOT:" @ %visslot @ " NEW:"@%new);
		$BPItem[%new,$BPVisSlot] = $DynamicItem[%name,$DVisSlot];
		$BPItem[%new,$BPVisType] = $DynamicItem[%name,$DVisType];
	}
	//===============================================================================
	$BPItem[%new,$BPName] = $DynamicItem[%name,$DName];
	$BPItem[%new,$BPWeight] = %weight;
	$BPItem[%new,$BPPrice] = %price;
	$BPItem[%new,$BPWield] = "LOCATION " @ $TierLoc[%slot] @ " " @ %rlist;
	$BPItem[%new,$BPWieldBonus] = %list;
	$BPItem[%new,$BPDesc] = $DynamicItem[%name,$DDesc];
	$BPItem[%new,$BPItemType] = $DynamicItem[%name,$DItemType];
	$BPItem[%new,$BPIntegrity] = %tperc;
	//$BPItem[%new,$BPTierPerc] = %tperc;
	$BPItem[%new,$BPBaseItem] = $DynamicItem[%name,$DBaseItem];
	$BPItem[%new,$BPArmorHitSound] = $DynamicItem[%name,$DAHS];
	$BPItem[%new,$BPRanged] = $DynamicItem[%name,$DRanged];
	$BPItem[%new,$BPIsMagWeapon] = $DynamicItem[%name,$DIsMagWeapon];
	$BPItem[%new,$BPBlockType] = $DynamicItem[%name,$DBlockType];
	if (%implicit != "")
		$BPItem[%new,$BPImplicit] = %implicit;
	if ($DynamicItem[%name,$DIco] != "")
		$BPItem[%new,$BPIco] = $DynamicItem[%name,$DIco];
	if ($DynamicItem[%name,$DSet] != "")
		$BPItem[%new,$BPSet] = $DynamicItem[%name,$DSet];
	if (%sockets > 0)
		$BPItem[%new,$BPNumSockets] = %sockets;
	//echo(" NAME " @ %name @ " MATERIAL " @ $DynamicItem[%name,$DMaterial]);
	if ($DynamicItem[%name,$DMaterial] != "")
		$BPItem[%new,$BPMaterial] = $DynamicItem[%name,$DMaterial];
	if ($DynamicItem[%name,$DIsQuiver] == 1)
		$BPItem[%new,$BPIsQuiver] = 1;
}


function Loot::GrabType7(%mf)
{
	%x = MTRB(1,1000);
	%RET = "BODY";
	if (%x <= 500) {
		if (MTRB(1,2) == 1) %RET = "MAGIC";
		else %RET = "EXTRA";
	}
	if (%x <= 300) {
		if (MTRB(1,2) == 1) %RET = "WEAPON";
		else %RET = "SPELL";
	}
	if (%x <= 30) %RET = "RELIC";
	if (%x <= 15) %RET = "RUNE";
	if (%x <= 5) %RET = "MAP";
	return %RET;
}

//$NPC["PLANMERCHANT",LOCATION] = "99.6 -1.6 164.99";
//$NPC["PLANMERCHANT",NAME] = "Plan Merchant";
//$NPC["PLANMERCHANT",0,NEED] = "NA"; 
//$NPC["PLANMERCHANT",0,BOT] = "Greetings Adventurer! I have some plans for sale. Would you like to take a look?";
//$NPC["PLANMERCHANT",0,1,0] = "Yes, what do you have?";
$NPC["PLANMERCHANT",0,2,0] = "No thanks.";
$NPC["PLANMERCHANT",0,1,1] = "OPENSTORE 5 NPCEND 1";
$NPC["PLANMERCHANT",0,2,1] = "SUB 1";
$NPC["PLANMERCHANT",1,BOT] = "Travel carefully, Adventurer..";

	//=================================================================
	// PLAN MERCHANT
	//%r = RandBetween(7,14);
	//CreateMerchantLoot(5,"plan",%r,0,1,50);

//---------------------------------------------------
// PLANS
$BPMerchantArea[5] = "99.6 -1.6 164.99";
$BPMerchantShop[5] = "";

		SpawnNPC("Plan Merchant","MaleHumanTownBot","99.6 -1.6 164.99","0 -0 -0.34",3);


function Loot::GrabType(%mf)
{	
	%x = MTRB(1,1000);
	if (%x <= 5) return "MAP";
	if (%x <= 30) return "RUNE";
	if (%x <= 80) return "RELIC";
	if (%x <= 330) {
		if (MTRB(1,2) == 1) return "WEAPON";
		else return "SPELL";
	}
	if (%x <= 630) {
		if (MTRB(1,2) == 1) return "MAGIC";
		else return "EXTRA";
	}
	return "BODY";
}



function WhatIs(%item,%id)
{
	if ($BPItem[%item,$BPName] != "") {
		//========================================================================================================
		%qual = String::GetSubStr(%item,0,3);
		%qual = %qual * 1;
		if (%qual == 999)
			%qual = "Special";
		//========================================================================================================
		%typedisp = "";
		if ((%itemtype = $BPItem[%item,$BPItemType]) != "") {
			if ($TierPlate[%itemtype] != "") {
				%typedisp = "<b" @ $TierPlate[%itemtype] @ ">";
			}		
			else {
				%tier = getWord(%itemtype,0);
				%v = "";
				if (getWord(%itemtype,1) != -1) %v = %v @ getWord(%itemtype,1) @ " ";
				if (getWord(%itemtype,2) != -1) %v = %v @ getWord(%itemtype,2) @ " ";
				if (getWord(%itemtype,3) != -1) %v = %v @ getWord(%itemtype,3) @ " ";
				//if ($TierItemTypeDisp[%tier] != "")
				//	%typedisp = $TierItemTypeDisp[%tier] @ " " @ %v;
				//else
					%typedisp = getWord(%itemtype,0) @ " " @ getword(%itemtype,1);
			}
		}
		%msg = %msg @ "<f0>" @ %typedisp @ "\n\n\n<f1>";
		//========================================================================================================
		if ($BPItem[%item,$BPIco] != "") {
			%msg = %msg @ "<b" @ $BPItem[%item,$BPIco] @ ">\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPWeaponTwoHand] == 0)
			%msg = %msg @ "<f1>" @ $BPItem[%item,$BPName] @ "\n";
		else
			%msg = %msg @ "<f1>" @ $BPItem[%item,$BPName] @ " <f0>(2 Hand) \n";
		//========================================================================================================
		if ($NoDropItem[%item])
			%msg = %msg @ "NODROP";
		//========================================================================================================
		%msg = %msg @ "<f1>";
		%msg = %msg @ "Quality: <f0>" @ %qual;
		if ($BPItem[%item,$BPIntegrity] != "" && $BPItem[%item,$BPIntegrity] > 0)
			%msg = %msg @ "\n<f1>Integrity:<f0> +" @ $BPItem[%item,$BPIntegrity] @ "%";
		if ($BPItem[%item,$BPTierPerc] > 0 && $BPItem[%item,$BPTierPerc] != "") {
			%msg = %msg @ "\n<f1>Modifiers: <f0>" @ $BPItem[%item,$BPTierPerc] @ "\n\n\n<f1>"; 
		}
		else {
			%msg = %msg @ "\n\n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPPlanMats] != "") {
			%msg = %msg @ "<f1>Material Needed: <f0>" @ BPFormat($BPItem[%item,$BPPlanMats]) @ "\n\n<f1>"; 
		}
		if ($BPItem[%item,$BPPlanReqs] != "") {
			%msg = %msg @ "<f1>Requirements: <f0>" @ BPFormat($BPItem[%item,$BPPlanReqs]) @ "\n\n<f1>"; 
		}
		//========================================================================================================
		if ($BPItem[%item,$BPImplicit] != "") {
			%msg = %msg @ " <f1>" @ BPFormat($BPItem[%item,$BPImplicit]) @ "\n\n<f1>"; 
		}
		//========================================================================================================
		if ($BPItem[%item,$BPMapMagic] != "") {
			%msg = %msg @ "<f1>Magic Find " @ $BPItem[%item,$BPMapMagic] @ "%\n\n<f1>"; 
		}
		//========================================================================================================
		if ($BPItem[%item,$BPWeaponMagDamage] != "") {
			%msg = %msg @ "\n";
			%msg = %msg @ " Spell Base Damage: <f0>" @ $BPItem[%item,$BPWeaponMagDamage] @ "<f1>\n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPDamage] != "") {
                        %msg = %msg @ "\n";
			%msg = %msg @ " Damage: <f0>" @ $BPItem[%item,$BPDamage] @ "<f1>\n";
                        %damage = $BPItem[%item,$BPDamage];
			%dmgmin = getWord(%damage,0);
			%dmgmax = getWord(%damage,2);
			%delay = $BPItem[%item,$BPWeaponDelay];
			%dps = round(((%dmgmin + %dmgmax) / 2) / %delay);
			%msg = %msg @ " DPS: <f0>" @ %dps @ "<f1>\n";

		}
		if ($BPItem[%item,$BPDamageType] != "") {
			%msg = %msg @ " <f1>DamageType: <f0>" @ $BPItem[%item,$BPDamageType] @ "\n";
			%delay = $BPItem[%item,$BPWeaponDelay];
			%msg = %msg @ " <f1>Delay: <f0>" @ %delay @ " seconds<f1>\n\n";
			%ret = CompareDPS(%id,%item);
			%msg = %msg @ "		" @ %ret @ "\n\n";
		}	
		//========================================================================================================
		if ($BPItem[%item,$BPWield] != "") {
			%msg = %msg @ "<f1>Requirements:\n<f0> " @ BPFormat($BPItem[%item,$BPWield]) @ "\n<f1>\n";
			if ($BPItem[%item,$BPWieldBonus] != "")
				%msg = %msg @ "<f1>Wield Bonus:\n<f0> " @ BPFormat($BPItem[%item,$BPWieldBonus]) @ "\n<f1>\n";
			%loc = getWord($BPItem[%item,$BPWield],1);
		}
		//========================================================================================================
		if ($BPItem[%item,$BPMapMods] != "") {
			%msg = %msg @ "<f1>Map Modifications:\n<f0>" @ FormatMapMods($BPItem[%item,$BPMapMods]) @ "\n<f1>\n";
		}
		//========================================================================================================
		if ((%sockets = $BPItem[%item,$BPNumSockets]) != "") {
			%msg = %msg @ "Sockets: <f0>" @ %sockets @" \n\n";
			for (%i = 1; %i <= %sockets; %i++)
				%msg = %msg @ "<bico_socket.bmp>";
			%msg = %msg @ "\n<f1>\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPTierProp] != "") {
			%itemtype = $BPItem[%item,$BPItemType];
			%truetype = getWord(%itemtype,1);
			if ((%hard = $BPItem[%item,$BPTierHard]) != "") {
				%perc = $BPItem[%item,$BPTierPerc];
				%hmsg = TierItem::GetHardDisp(%truetype,%hard,%qual,%perc);
				%msg = %msg @ "Wield Bonus: " @ BPFormat(%hmsg,True) @ ", +" @ $BPItem[%item,$BPTierProp] @ " Random Properties.\n";
			}
			else {
				%msg = %msg @ "Wield Bonus: +" @ $BPItem[%item,$BPTierProp] @ " Random Properties.\n";
			}
		}		
		//========================================================================================================
		if ($BPItem[%item,$BPUse] != "") {
			%msg = %msg @ "<f1>Use:\n<f0> " @ BPFormat($BPItem[%item,$BPUse]) @ "\n";
			%msg = %msg @ "<f1>Use Bonus:<f0> \n " @ BPFormat($BPItem[%item,$BPUseBonus]) @ "\n\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPMBS] != "") {
			%msg = %msg @ "Max Beneficial Skill: " @ $BPItem[%item,$BPMBS] @ "\n";
		}
		//========================================================================================================
		%nw = $BPItem[%item,$BPWeight];
		//========================================================================================================
		%msg = %msg @ "<f1>Weight: " @ %nw @ "\n";
		%msg = %msg @ "<f1>Price: $" @ $BPItem[%item,$BPPrice] @ "\n\n";
		//========================================================================================================
		if ($BPItem[%item,$BPATK] != "") {
			%msg = %msg @ "<f1>ATK: <f0>" @ $BPItem[%item,$BPATK] @ "\n";
		}
		//========================================================================================================
		if ($BPItem[%item,$BPSet] != "") {
			%set = $BPItem[%item,$BPSet];
			%msg = %msg @ TierItem::SetBonusDisp(%set);
		}
		//========================================================================================================
		if ($BPItem[%item,$BPRune] != "") {
			%runebonus = $BPItem[%item,$BPRuneBonus];
			%mod = getWord(%runebonus,0);
			%msg = %msg @ "Rune Bonus:\n<f0> " @ BPFormat(%runebonus) @ "\n<f1>\n";
			//%msg = %msg @ "Requirement:\n<f0> " @ BPReqDisplay($BPItem[%item,$BPRuneReq]) @ " " @ BPRuneReqVal($TierReqP[%mod],%qual) @ "\n<f1>\n";
			%msg = %msg @ "Requirement:<f0> " @ BPReqDisplay($BPItem[%item,$BPRuneReq]) @ "\n<f1>";
			%msg = %msg @ "Location:<f0> " @ $BPItem[%item,$BPRuneLoc] @ "\n<f1>\n";
		}
		//========================================================================================================
		%msg = %msg @ "<f0>" @ $BPItem[%item,$BPDesc] @ "\n\n";
		//========================================================================================================
		//if (%loc != "" && %id != -1)
		//	%msg = %msg @ "You are wearing:\n" @ WhatIsCompare(%id,%loc);
		//========================================================================================================
		if (string::findSubStr(%typedisp,"Spellcrystal") != -1) {
			%spell = GetWord($BPItem[%item,$BPUseBonus],1);
			%msg = %msg @ "\n\n" @ WhatIsCruSpell(0,%spell,True);
		}
		//========================================================================================================
		return %msg;
				
	}
	else {
		return "Unknown Item";
	}
}

function AddWeight(%id,%w)
{
	$PlayerWeight[%id]+=%w;	
}

function SubWeight(%id,%w)
{
	$PlayerWeight[%id]-=%w;
}

function GetWeight(%clientId)
{
	dbecho($dbechoMode, "GetWeight(" @ %clientId @ ")");

	if(IsDead(%clientId) || !fetchData(%clientId, "HasLoadedAndSpawned") || %clientId.IsInvalid)
		return 0;

	//== HELPS REDUCE LAG WHEN THERE ARE SIMULTANEOUS CALLS ======
	%time = getIntegerTime(true);
	if(%time - %clientId.lastGetWeight <= 1 && fetchData(%clientId, "tmpWeight") != "")
		return fetchData(%clientId, "tmpWeight");
	%clientId.lastGetWeight = %time;
	//============================================================

	$GetWeight::ArmorMod = "";
	%total = 0;

	//add up items
	%max = getNumItems();
	for(%i = 0; %i < %max; %i++)
	{
		%checkItem = getItemData(%i);
		%itemcount = Player::getItemCount(%clientId, %checkItem);

		if(%itemcount)
		{
			%weight = GetAccessoryVar(%checkItem, $Weight);
			if(%weight != "" && %weight != False)
				%total += %weight * %itemcount;

			//Replaces the laggy AddPoints(%clientId, 8) in RefreshWeight (the real lag comes from GetAccessoryList however)
			%specialvar = GetAccessoryVar(%checkItem, $SpecialVar);
			if(GetWord(%specialvar, 0) == 8 && %checkItem.className == Equipped)
				$GetWeight::ArmorMod = GetWord(%specialvar, 1);
		}
	}
	
	//echo("WEIGHT CHECK");
	%total = %total + GetBackpackWeight(%clientId);

	//add up coins
	%total += fetchData(%clientId, "COINS") * $coinweight;

	storeData(%clientId, "tmpWeight", %total);
	return %total;
}



function RefreshWeight(%clientId)
{
	return;

	dbecho($dbechoMode2, "RefreshWeight(" @ %clientId @ ")");

	%player = Client::getOwnedObject(%clientId);

	if(!fetchData(%clientId, "SlowdownHitFlag"))
	{
		%weight = fetchData(%clientId, "Weight");
		
		%changeweightstep = 5;

		//determine the new armor to use
		%newarmor = $ArmorForSpeed[fetchData(%clientId, "RACE"), 0];
		%spill = %weight - fetchData(%clientId, "MaxWeight");

		%num = floor(%spill / %changeweightstep);

		if(%num > 0)
		{
			//overweight, select appropriate armor
			for(%i = -1; %i >= -%num; %i--)
			{
				if($ArmorForSpeed[fetchData(%clientId, "RACE"), %i] != "")
					%newarmor = $ArmorForSpeed[fetchData(%clientId, "RACE"), %i];
				else
					break;
			}
		}
		else
		{
			//when not overweight, the special armor-modifying items come in
			%x = $GetWeight::ArmorMod;
			if(%x > 0)
				%newarmor = $ArmorForSpeed[fetchData(%clientId, "RACE"), %x];
		}
	}
	else
	{
		%newarmor = $ArmorForSpeed[fetchData(%clientId, "RACE"), -5];
	}

	%a = Player::getArmor(%clientId);
	%ae = GameBase::getEnergy(%player);

	if(%a != %newarmor && %newarmor != "")
	{
		//set the new armor
		Player::setArmor(%clientId, %newarmor);
		GameBase::setEnergy(%player, %ae);
		//------------------------------------------------------------------
		// CHECK FOR VISUAL
		
		%weararmor = $PlayerWear[%clientId,12];
		if (%weararmor != -1) {
			%vis = $BPItem[%weararmor,$BPVis];
			if (%vis != "")
				Client::SetSkin(%clientId,%vis);
		}

		//------------------------------------------------------------------
		//UseSkill(%clientId, $SkillWeightCapacity, True, True, 25);
	}

	//save the %num in a global variable for use on stats (in order to give penalties to other stats for being overweight)
	storeData(%clientId, "OverweightStep", %num);
}









$NPC["WARRIOR",LOCATION] = "-192.808 281.314 222.382";
$NPC["WARRIOR",NAME] = "Warrior Master Warrak";
$NPC["WARRIOR",0,NEED] = "NOTHASQUEST WOF NOTHASQUEST WDF LVL 10 HASITEM 999MossyTomeVolI";
$NPC["WARRIOR",0,BOT] = "" @ string::translate("*The old warrior Orc grunts and looks up at you*") @ "\n\nWhat do you want?";
$NPC["WARRIOR",0,1,$OPT] = "The woman in town said I should seek you for advise about this tome.";
$NPC["WARRIOR",0,2,$OPT] = "Nothing, sorry to bother you."; 
$NPC["WARRIOR",0,1,$CMD] = "SUB 1";
$NPC["WARRIOR",0,2,$CMD] = "SUB 2";
$NPC["WARRIOR",1,NEED] = "SUBONLY";
$NPC["WARRIOR",1,BOT] = "Ah yes let me see that.\nAhh, one of the missing Warrior tomes!\nSo you want to become a warrior?";
$NPC["WARRIOR",1,1,$OPT] = "Yeah, I guess so...";
$NPC["WARRIOR",1,2,$OPT] = "No, this is not for me.";
$NPC["WARRIOR",1,1,$CMD] = "SUB 3";
$NPC["WARRIOR",1,2,$CMD] = "SUB 2";
$NPC["WARRIOR",2,NEED] = "SUBONLY";
$NPC["WARRIOR",2,BOT] = "Ok, get out of my sight!";
$NPC["WARRIOR",3,NEED] = "SUBONLY";
$NPC["WARRIOR",3,BOT] = "" @ string::translate("*The Master shakes his head in disgust*") @ "\n\nYou guess so?\nYou are going to need more spirit than that!\nNow, do you want to start your training or not, soldier!";
$NPC["WARRIOR",3,1,$OPT] = "Yes! Offensive Warrior training!";
$NPC["WARRIOR",3,2,$OPT] = "Yes! Defensive Warrior training!";
$NPC["WARRIOR",3,3,$OPT] = "On second thought, I'd rather not.";
$NPC["WARRIOR",3,1,$CMD] = "GIVEQUEST WOF GIVEQUEST MIT TAKEITEM 999MossyTomeVolI GIVEITEM BrawlerTome:10 SUB 4";
$NPC["WARRIOR",3,2,$CMD] = "GIVEQUEST WDF GIVEQUEST MIT TAKEITEM 999MossyTomeVolI GIVEITEM DefenderTome:10 SUB 4";
$NPC["WARRIOR",3,3,$CMD] = "SUB 2";
$NPC["WARRIOR",4,NEED] = "SUBONLY";
$NPC["WARRIOR",4,BOT] = "Ok Return to me when you are stronger and have more tomes!";
//-------------------------------------------------------------------------------------------------------------------------------------
// OFFENSIVE LINE
//=== LEVEL 20 ==============================================================================
$NPC["WARRIOR",5,NEED] = "HASQUEST WOF QUESTON MIT:0 LVL 20";
$NPC["WARRIOR",5,BOT] = "I see you are getting stronger, Good!\nI have an item here for you, choose one.";
$NPC["WARRIOR",5,1,$OPT] = "Give me the Sword.";
$NPC["WARRIOR",5,2,$OPT] = "Give me the Knife.";
$NPC["WARRIOR",5,3,$OPT] = "Give me the Bow.";
$NPC["WARRIOR",5,4,$OPT] = "Give me the Hammer.";
$NPC["WARRIOR",5,1,$CMD] = "GIVEITEM KeenHalberd:20 SUB 4 INCQUEST MIT";
$NPC["WARRIOR",5,2,$CMD] = "GIVEITEM KeenRapier:20 SUB 4 INCQUEST MIT";
$NPC["WARRIOR",5,3,$CMD] = "GIVEITEM HardwoodWarhammer:20 SUB 4 INCQUEST MIT";
$NPC["WARRIOR",5,4,$CMD] = "GIVEITEM HardwoodElvenbow:20 SUB 4 INCQUEST MIT";
//=== LEVEL 30 ==============================================================================
$NPC["WARRIOR",6,NEED] = "QUESTON WOF:0 HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII";
$NPC["WARRIOR",6,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["WARRIOR",6,1,$OPT] = "Here You go!";
$NPC["WARRIOR",6,1,$CMD] = "INCQUEST WOF INCQUEST MIT TAKEITEM 999MossyTomeVolII TAKEITEM 999MossyTomeVolIII GIVEITEM BrawlerTome:10 SUB 4";











//MissionRegObject(CRUCIBLE, "PINE1", MissionCreateObject, PINE1, StaticShape, PINE1 );
//MissionRegObject(CRUCIBLE, "PINE2", MissionCreateObject, PINE2, StaticShape, PINE2 );
//MissionRegObject(CRUCIBLE, "PINE3", MissionCreateObject, PINE3, StaticShape, PINE3 );
//MissionRegObject(CRUCIBLE, "PINE4", MissionCreateObject, PINE4, StaticShape, PINE4 );
//MissionRegObject(CRUCIBLE, "FENCE1", MissionCreateObject, FENCE1, StaticShape, FENCE1 );
//MissionRegObject(CRUCIBLE, "DTREE1", MissionCreateObject, DTREE1, StaticShape, DTREE1 );
//MissionRegObject(CRUCIBLE, "WRACK1", MissionCreateObject, WRACK1, StaticShape, WRACK1 );
//MissionRegObject(CRUCIBLE, "KFLAG", MissionCreateObject, KFLAG, StaticShape, KFLAG );
//MissionRegObject(CRUCIBLE, "INVISWALL", MissionCreateObject, INVISWALL, StaticShape, INVISWALL );
//MissionRegObject(CRUCIBLE, "DESSPIRE1", MissionCreateObject, DESSPIRE1, StaticShape, DESSPIRE1 );
//MissionRegObject(CRUCIBLE, "PALACETOP1", MissionCreateObject, PALACETOP1, StaticShape, PALACETOP1 );
//MissionRegObject(CRUCIBLE, "PALACETOP2", MissionCreateObject, PALACETOP2, StaticShape, PALACETOP2 );
//MissionRegObject(CRUCIBLE, "PALM3", MissionCreateObject, PALM3, StaticShape, PALM3 );
//MissionRegObject(CRUCIBLE, "PALM4", MissionCreateObject, PALM4, StaticShape, PALM4 );
//MissionRegObject(CRUCIBLE, "SWEWTR1", MissionCreateObject, SWEWTR1, StaticShape, SWEWTR1 );
//MissionRegObject(CRUCIBLE, "SWEWTR2", MissionCreateObject, SWEWTR2, StaticShape, SWEWTR2 );
//MissionRegObject(CRUCIBLE, "SWEWTR3", MissionCreateObject, SWEWTR3, StaticShape, SWEWTR3 );
//MissionRegObject(CRUCIBLE, "FIRE", MissionCreateObject, FIRE, StaticShape, FIRE );
//MissionRegObject(CRUCIBLE, "CFIRE1", MissionCreateObject, CFIRE1, StaticShape, CFIRE1 );
//MissionRegObject(CRUCIBLE, "BEAM2", MissionCreateObject, BEAM2, StaticShape, BEAM2 );
//MissionRegObject(CRUCIBLE, "CCRYSTAL", MissionCreateObject, CCRYSTAL, StaticShape, CCRYSTAL );
//MissionRegObject(CRUCIBLE, "LAKE1", MissionCreateObject, LAKE1, StaticShape, LAKE1 );
//MissionRegObject(CRUCIBLE, "CPALM", MissionCreateObject, CPALM, StaticShape, CPALM );
//MissionRegObject(CRUCIBLE, "CPALM2", MissionCreateObject, CPALM2, StaticShape, CPALM2 );
//MissionRegObject(CRUCIBLE, "WALL", MissionCreateObject, WALL, StaticShape, WALL );
//MissionRegObject(CRUCIBLE, "WALL2", MissionCreateObject, WALL2, StaticShape, WALL2 );
//MissionRegObject(CRUCIBLE, "FORWATER", MissionCreateObject, FORWATER, StaticShape, FORWATER );


			if (%clientId.PlanCraft[1] != "" || %clientId.PlanCraft[2] != "" || %clientId.PlanCraft[3] != "")
				Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Plan Crafting..." , "plancraft");


function UsingMap(%id)
{
	return $PlayerMap[%id,0];
}

function MapWave(%id)
{
	return $PlayerMap[%id,1];
}

function UseMapPortal(%id)
{
	if ((%team = PlayerIsInTeam(%id)) != -1)
		%lid = GetTeamLeader(%team);
	else
		%lid = %id;
	%map = $PlayerMap[%lid,0];
	%zone = $PlayerMap[%lid,2];
	%wave = $PlayerMap[%lid,1];
	if (%map == "") {
		Client::SendMessage(%id,0,"You currently do not have an activated map.");
		return;
	}
	if ($MAPINUSE[%zone] == 1 && %id.UsingMap != %zone) {
		Client::SendMessage(%id,0,"This map is currently in use, you must wait.");
		return;
	}
	%id.UsingMap = %zone;
	StoreData(%id,"zone",%zone);
	Client::SendMessage(%id,2,"You have entered " @ GetZoneData($ZoneInfo[%zone,$ZoneEnter],$ZoneDisp) @ ".");
	GameBase::SetPosition(%id,$CRUZONE[%zone,$CZMapStart]);
	Game::refreshClientScore(%id);
	SetupMap(%lid);
}

function SetupMap(%id)
{
	%map = $PlayerMap[%id,0];
	%lvl = String::GetSubStr(%map,0,3);
	%lvl = %lvl + 0;
	%zone = $PlayerMap[%id,2];
	%waves = $PlayerMap[%id,1];
	$CRUZONE[%zone,$CZMapLvl] = %lvl;
	$CRUZONE[%zone,$CZMapWaves] = %waves;
	$CRUZONE[%zone,$CZMapOwner] = %id;
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
}

function ClearMap(%id)
{
	$PlayerMap[%id,0] = "";
	$PlayerMap[%id,1] = "";
	$PlayerMap[%id,2] = "";
	$PlayerMap[%id,3] = "";
	Client::SendMessage(%id,0,"Your map has been cleared.");
}

function ActivateMap(%id,%map)
{
	if ($BPItem[%map,$BPIsMap] == 1) {
		if (HasActiveMap(%id) == False) {
			
			

			$PlayerMap[%id,0] = %map;
			$PlayerMap[%id,1] = $MaxMapWaves;
			$ALLMAPS = string::Shuffle($ALLMAPS);
			$PlayerMap[%id,2] = getWord($ALLMAPS,0);
			$PlayerMap[%id,2] = "FOREST1";
			Client::SendMessage(%id,2,"You have activated " @ $BPItem[%map,$BPName] @ ".");
		}
		else
			Client::SendMessage(%id,0,"You already have an activated map. You must complete or leave this map empty for 2 minutes to activate another map.");	
	}
	else
		Client::SendMessage(%id,0,"This item is not a map.");	
}



function Game::MenuMap(%clientId)
{
	%active = HasActiveMap(%clientId);
	if (%active == -1)
		return;
	%v = $CRUMAP[%active];
	%map = GetWord(%v,0);
	%waves = GetWord(%v,1);
	%owner = GetWord(%v,2);
	%zone = GetWord(%v,3);
	%msg = WhatIs(%map,%clientId);
	%msg = %msg @ "\n";
	%msg = %msg @ "Zone: " @ $ZoneInfo[%zone,$ZoneDisp] @ "\n";
	%msg = %msg @ "Waves Remaining: " @ %waves @ " of " @ $MaxMapWaves @ "\n";
	%msg = %msg @ "Owner: " @ %owner;
	SendBufferBP(%clientId, %msg, floor(String::len(%msg) / 15));
	Client::buildMenu(%clientId,GetBPData($PlayerMap[%clientId,0],$BPName), "map", true);
	Client::addMenuItem(%clientId, %curItem++ @ "Examine Map..","examine");
	Client::addMenuItem(%clientId, %curItem++ @ "Break Map..","break");
	Client::addMenuItem(%clientId, "p<< Prev","back");
}

function processMenuMap(%clientId, %option)
{
	if (%option == "examine") Game::MenuMap(%clientId);
	if (%option == "break") ClearMap(%clientId);
	if (%option == "back") Game::MenuRequest(%clientId);
}


function Item::onCollision(%this,%object)
{
	dbecho($dbechoMode, "Item::onCollision(" @ %this @ ", " @ %object @ ")");

	%clientId = Player::getClient(%object);
	%armor = Player::getArmor(%clientId);
	
	//========================================================================================================
	// RESTRICT LADDER
	%ladder = IsLadderPlayer(%clientId);
	if (%ladder) {
		if (%this.Ladder != 1 && !%this.AiDropped) {
			return;
		}
	}
	if (%this.AiDropped && %ladder) {
		if (%this.NoLadderPickup == 1) {
			return;
		}
	}
	if (%this.Ladder) {
		if (!IsLadderPlayer(%clientId)) {
			return;
		}
	}
	if (!%this.Ladder) {
		if (Player::IsAiControlled(%clientId)) {
			%object.NoLadderPickup = 1;
		}
	}
	//========================================================================================================

	if (%this.NoBonus)
		%object.NoDropBonus = 1;

	if(getObjectType(%object) == "Player" && !IsDead(%clientId))
        {
		%time = getIntegerTime(true) >> 5;
		if(%time - %clientId.lastItemPickupTime <= 0.1)
			return 0;

		%clientId.lastItemPickupTime = %time;

		%item = Item::getItemData(%this);

            if(%item == "Lootbag" || %item == "Lootrock")
            {
			%nobonus = 0;
			
			%msg = "";

			if (Player::isAiControlled(%object))
				return;

			if (%this.Ladder) {
				if (!IsLadderPlayer(%clientId))
					return;
			}

			%ownerName = GetWord($loot[%this], 0);
			%namelist = GetWord($loot[%this], 1);
			if($loot[%this] == "")
				%msg = "You found an empty backpack.";
			else
			{
				if(IsInCommaList(%namelist, Client::getName(%clientId)) || %namelist == "*")
				{
					if(String::ICompare(%ownerName, Client::getName(%clientId)) == 0) {
						%msg = "You found one of your backpacks.";
						//%nobonus = 1;
					}
					else if(%ownerName == "*")
						%msg = "You found a backpack.";
					else
						%msg = "You found one of " @ %ownerName @ "'s backpacks.";
				}
			}

			if (%this.NoBonus)
				%nobonus = 1;

			if(%msg != "")
			{
				%newloot = String::getSubStr($loot[%this], String::len(%ownerName)+String::len(%namelist)+2, 99999);

				Client::sendMessage(%clientId, 0, %msg);
	
				if (LootHasBackpackItem(%newloot) == true) {
					if (BackpackFull(%clientId) == true) {
						Client::SendMessage(%clientId,1,"You can not pick up this pack, your backpack is full!");
						return;
					}
				}

				echo(" NEW LOOT " @ %newloot);

				GiveThisStuff(%clientId, %newloot, True, 1, %nobonus);

				if(%this.tag != "")
				{
					$tagToObjectId[%this.tag] = "";
					$SpawnPackList = RemoveFromCommaList($SpawnPackList, %this.tag);
				}
				Item::playPickupSound(%this);
				$loot[%this] = "";

				if(%ownerName != "*")
				{
					%ownerId = NEWgetClientByName(%ownerName);
					storeData(%ownerId, "lootbaglist", RemoveFromCommaList(fetchData(%ownerId, "lootbaglist"), %this));
				}

				//event stuff
				%i = GetEventCommandIndex(%this, "onpickup");
				if(%i != -1)
				{
					%name = GetWord($EventCommand[%this, %i], 0);
					%type = GetWord($EventCommand[%this, %i], 1);
					%cl = NEWgetClientByName(%name);
					if(%cl == -1)
						%cl = 2048;

					%cmd = String::NEWgetSubStr($EventCommand[%this, %i], String::findSubStr($EventCommand[%this, %i], ">")+1, 99999);
					%pcmd = ParseBlockData(%cmd, %clientId, "");
					$EventCommand[%this, %i] = "";
					remoteSay(%cl, 0, %pcmd, %name);
				}
				deleteObject(%this);
				ClearEvents(%this);
			}
			else
			{
				if(%ownerName == "*")
					Client::sendMessage(%clientId, $MsgRed, "You do not have the right to take this backpack.");
				else
					Client::sendMessage(%clientId, $MsgRed, "You do not have the right to take " @ %ownerName @ "'s backpack.");
			}
            }
            else if (%item.className == "Projectile")
            {
			%damagedClient = %clientId;
			%shooterClient = %this.owner;
			if(%shooterClient != "")
			{
				%vec = Vector::getDistance("0 0 0", Item::getVelocity(%this));
				if(%vec == 0 && $ProjectileDoubleCheck[%this])
					%vec = 3.0;
			}
			else
				%vec = 0;	//don't let thrown projectiles damage!

			$ProjectileDoubleCheck[%this] = "";

			if(%vec >= 2.5)
			{
				GameBase::virtual(%object, "onDamage", $DamageType[%item], 1.0, "0 0 0", "0 0 0", "0 0 0", "torso", %this.weapon, %shooterClient, %item);
			}
			else
			{
				if(Item::giveItem(%clientId, %item, %this.delta, True))
				{
					Item::playPickupSound(%this);
					RefreshAll(%clientId);
				}
			}

			deleteObject(%this);
		}
            else if(%item.className == "Accessory" || $LoreItem[%item] == True)
            {
			if(Item::giveItem(%clientId, %item, 1, True))
			{
				Item::playPickupSound(%this);
				RefreshAll(%clientId);
				deleteObject(%this);
			}
		}
		else if(%item.className == "TownBot")
		{
			//do nothing.
		}
            else
            {
            	//%count = Player::getItemCount(%object,%item);
            	if(Item::giveItem(%object, %item, %this.delta, True))
                  {
                  	Item::playPickupSound(%this);
				RefreshAll(%clientId);
                        Item::respawn(%this);
			}
		}
	}
}


function Item::onUse(%player,%item)
{
	dbecho($dbechoMode, "Item::onUse(" @ %player @ ", " @ %item @ ")");

	%clientId = Player::getClient(%player);

	if(!IsDead(%clientId))
	{
		//this is how you toggle back and forth from equipped to carrying.
		if(%item.className == Accessory)
		{
			%cnt = 0;
			%max = getNumItems();
			for(%i = 0; %i < %max; %i++)
			{
				%checkItem = getItemData(%i);
				if(%checkItem.className == Equipped && GetAccessoryVar(%checkItem, $AccessoryType) == GetAccessoryVar(%item, $AccessoryType))
					%cnt += Player::getItemCount(%player, %checkItem);
			}

			if(SkillCanUse(%clientId, %item))
			{
				if(%cnt < $maxAccessory[GetAccessoryVar(%item, $AccessoryType)])
				{
					Client::sendMessage(%clientId, $MsgBeige, "You equipped " @ %item.description @ ".");
					Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
					Player::setItemCount(%player, %item @ "0", Player::getItemCount(%player, %item @ "0")+1);
				}
				else
					Client::sendMessage(%clientId, $MsgRed, "You can't equip this item because you have too many already equipped.~wC_BuySell.wav");
			}
			else
				Client::sendMessage(%clientId, $MsgRed, "You can't equip this item because you lack the necessary skills.~wC_BuySell.wav");

			if($OverrideMountPoint[%item] == "")
				Player::mountItem(%player, %item @ "0", 1, 0);
		}
		else if(%item.className == Equipped)
		{
			%o = String::getSubStr(%item, 0, String::len(%item)-1);	//remove the 0
			Client::sendMessage(%clientId, $MsgBeige, "You unequipped " @ %item.description @ ".");
			Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
			Player::setItemCount(%player, %o, Player::getItemCount(%player, %o)+1);

			if($OverrideMountPoint[%item] == "")
				Player::unMountItem(%player, 1);
		}
		else
		{
			RPGmountItem(%player, %item, $DefaultSlot);
		}

		refreshHP(%clientId, 0);
		refreshMANA(%clientId, 0);
		RefreshAll(%clientId);
	}
}

function Item::onDrop(%player,%item)
{
	dbecho($dbechoMode, "Item::onDrop(" @ %player @ ", " @ %item @ ")");

	//-----------------------------------------------
	// RESTRICT LADDER
	%clientId = Player::GetClient(%player);
	%ladder = IsLadderPlayer(%clientId);
	%ai = Player::IsAiControlled(%clientId);
	//-----------------------------------------------

	if($matchStarted)
	{
		if(%item.className != Armor)
		{
			if(%item.className == Projectile)
				%delta = 20;
			else
				%delta = 1;

			if(Player::getItemCount(%player, %item) < %delta)
				%delta = Player::getItemCount(%player, %item);

			echo(" ============================================> ITEM ON DROP ");

			if(%delta > 0)
			{
				%obj = newObject("","Item",%item,1,false);
				%obj.delta = %delta;
				//-----------------------------------------------
				// RESTRICT LADDER
				if (%ladder) {
					%obj.Ladder = 1;
				}
				if (%ai == True) {
					%obj.AiDropped = 1;
				}
				//-----------------------------------------------
				echo(" ============================> SETTING ITEM POP");
	 	 	  	schedule("Item::Pop(" @ %obj @ ");", $ItemPopTime, %obj);
	 	 	 	addToSet("MissionCleanup", %obj);

				if(IsDead(%player)) 
					GameBase::throw(%obj, %player, 10, true);
				else {
					GameBase::throw(%obj, %player, 15, false);
					Item::playPickupSound(%obj);
				}

				Player::decItemCount(%player,%item,%delta);
				RefreshAll(Player::getClient(%player));

				return %obj;
			}
		}
	}
}

function Ammo::onDrop(%player,%item)
{
	dbecho($dbechoMode, "Ammo::onDrop(" @ %player @ ", " @ %item @ ")");

	if($matchStarted)
	{
		if(%item.className == Ammo)
			%delta = 20;
		else
			%delta = 1;

		if(Player::getItemCount(%player, %item) < %delta)
			%delta = Player::getItemCount(%player, %item);

		if(%delta > 0)
		{
			%obj = newObject("","Item",%item,%delta,false);
			%obj.delta = %delta;
	      	schedule("Item::Pop(" @ %obj @ ");", $ItemPopTime, %obj);

      		addToSet("MissionCleanup", %obj);
			GameBase::throw(%obj,%player,20,false);
			Item::playPickupSound(%obj);
			Player::decItemCount(%player,%item,%delta);

			RefreshAll(Player::getClient(%player));
		}
	}
}

function Item::onUse(%player,%item)
{
	dbecho($dbechoMode, "Item::onUse(" @ %player @ ", " @ %item @ ")");

	%clientId = Player::getClient(%player);

	if(!IsDead(%clientId))
	{
		//this is how you toggle back and forth from equipped to carrying.
		if(%item.className == Accessory)
		{
			%cnt = 0;
			%max = getNumItems();
			for(%i = 0; %i < %max; %i++)
			{
				%checkItem = getItemData(%i);
				if(%checkItem.className == Equipped && GetAccessoryVar(%checkItem, $AccessoryType) == GetAccessoryVar(%item, $AccessoryType))
					%cnt += Player::getItemCount(%player, %checkItem);
			}

			if(SkillCanUse(%clientId, %item))
			{
				if(%cnt < $maxAccessory[GetAccessoryVar(%item, $AccessoryType)])
				{
					Client::sendMessage(%clientId, $MsgBeige, "You equipped " @ %item.description @ ".");
					Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
					Player::setItemCount(%player, %item @ "0", Player::getItemCount(%player, %item @ "0")+1);
				}
				else
					Client::sendMessage(%clientId, $MsgRed, "You can't equip this item because you have too many already equipped.~wC_BuySell.wav");
			}
			else
				Client::sendMessage(%clientId, $MsgRed, "You can't equip this item because you lack the necessary skills.~wC_BuySell.wav");

			if($OverrideMountPoint[%item] == "")
				Player::mountItem(%player, %item @ "0", 1, 0);
		}
		else if(%item.className == Equipped)
		{
			%o = String::getSubStr(%item, 0, String::len(%item)-1);	//remove the 0
			Client::sendMessage(%clientId, $MsgBeige, "You unequipped " @ %item.description @ ".");
			Player::setItemCount(%player, %item, Player::getItemCount(%player, %item)-1);
			Player::setItemCount(%player, %o, Player::getItemCount(%player, %o)+1);

			if($OverrideMountPoint[%item] == "")
				Player::unMountItem(%player, 1);
		}
		else
		{
			RPGmountItem(%player, %item, $DefaultSlot);
		}

		refreshHP(%clientId, 0);
		refreshMANA(%clientId, 0);
		RefreshAll(%clientId);
	}
}

function AiEmptyZoneCheck(%target)
{
	$AIISEMPTY[%target] = 1;
	%set = newObject("set", SimSet);
	%spotdist = 500;
	%pos = GameBase::GetPosition(%target);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,AiEmptyCheck,%target);
	deleteObject(%set);
	if ($AIISEMPTY[%target]) {
		KillStrayAI(%target);
	}	
}

function AiEmptyCheck(%object,%target)
{
	if (!Player::isAiControlled(%object))
		$AIISEMPTY[%target] = 0;
}	



function SellAll(%id)
{
	%backpack = $PlayerBackpack[%id];
	%hagskill = GetPlayerSkill(%id,$SkillHaggling);
	%coins = 0;
	%healpot = 0;
	%energyvial = 0;
	%portalscroll = 0;
	%key = 0;
	%new = "";
	if (%hagskill > $BPSellMaxHaggle)
		%hagskill = $BPSellMaxHaggle;
	for (%i = 0; (%item = getWord(%backpack,%i)) != -1; %i+=2) {
		%name = GetBPData(%item,$BPName);
		if ($HARDNOSELL[%name] == 1) {
			%new = %new @ %item @ " " @ getWord(%backpack,%i+1) @ " ";
		}
		else {
			%price = $BPItem[%item,$BPPrice];
			%price *= getWord(%backpack,%i+1);
			%sellprice = floor(%price / (10 - (%hagskill / ($BPSellMaxHaggle / 8))));
			if (%sellprice < 1) %sellprice = 1;
			%coins += %sellprice;

		}

		if (%item == "999HealthPotion")
			%healpot = getWord(%backpack,%i+1);
		else if (%item == "999EnergyVial")
			%energyvial = getWord(%backpack,%i+1);
		else if (%item == "999PortalScroll")
			%portalscroll = getWord(%backpack,%i+1);
		else if (%item == "999TreasureKey")
			%key = getWord(%backpack,%i+1);
		else {
			%price = $BPItem[%item,$BPPrice];
			%price *= getWord(%backpack,%i+1);
			%sellprice = floor(%price / (10 - (%hagskill / ($BPSellMaxHaggle / 8))));
			if (%sellprice < 1) %sellprice = 1;
			%coins += %sellprice;
		}
	}
	if (!%coins) {
		Client::SendMessage(%id,2,"You don't have any items to sell.");
		return;
	}
	%new = "";
	if (%healpot)
		%new = %new @ "999HealthPotion " @ %healpot @ " ";
	if (%energyvial)
		%new = %new @ "999EnergyVial " @ %energyvial @ " ";
	if (%portalscroll)
		%new = %new @ "999PortalScroll " @ %portalscroll @ " ";
	if (%key)
		%new = %new @ "999TreasureKey " @ %key @ " ";
	Client::SendMessage(%id,2,"You sold all your items for " @  %coins @ " coins.");
	GiveThisStuff(%id, "COINS " @ %coins, True, 1, 1);
	MoneySound(%id);
	$PlayerBackpack[%id] = %new;
	saveCharacter(%id);
}

function String::Remove(%string,%rem)
{
	for (%i = 0; (%g = getWord(%rem,%i)) != -1; %i++)
		%r[%g] = 1;
	for (%i = 0; (%g = getWord(%string,%i)) != -1; %i++) {
		if (%r[%g] != 1)
			%s = %s @ %g @ " ";
	}
	return %s;
}

//function String::Shuffle(%string)
//{
//	%t = 0;
//	for (%i = 0; (%g = getWord(%string,%i)) != -1; %i++) {
//		%w[%i] = %g;
//		%t++;
//	}
//	for (%i = 0; %i < %t; %i++) {
//		%r = MTRB(0,(%t - 1));
//		%v = %w[%i];
//		%w[%i] = %w[%r];
//		%w[%r] = %v;
//	}
//	for (%i = 0; %i < %t; %i++)
//		%new = %new @ %w[%i] @ " ";
//	return %new;
//}

		if (%race == "Demon")			{ %value = round(%value * (1 + (GetBonus(%id,$BPDAMAGEDEMON) / 100))); }
		if (%race == "Beast")			{ %value = round(%value * (1 + (GetBonus(%id,$BPDAMAGEBEAST) / 100))); }
		if (%race == "Undead")			{ %value = round(%value * (1 + (GetBonus(%id,$BPDAMAGEUNDEAD) / 100))); }
		if ($ELITE[%target] == 1)		{ %value = round(%value * (1 + (GetBonus(%id,$BPDAMAGEELITE) / 100))); }
		if ($BOSS[%target] == 1)		{ %value = round(%value * (1 + (GetBonus(%id,$BPDAMAGEBOSS) / 100))); }



// --------------------------------------------------------------------------------
	// RANGED CHECK FOR MOVING
	if (%ranged == 1) {
		if (gamebase::isAtRest(%id) == False) {
			if (%idai == False)
				return;
		}
		//%vel = Item::GetVelocity(%id);
		//if (getWord(%vel,0) != "0" || getWord(%vel,1) != "0" || getWord(%vel,2) != "0") {
		//	if (%idai == False)
		//		return;
		//}
		//if ($MoveCheck[%id] != 0) {
		//	rpg::SendMessage(%id,0,"You must be standing still to fire this weapon.");
		//	return;
		//}
		if (%proj != "") {
			//if (%proj == "Bolt") %proj = "CrossbowBoltDefault";
			//if (%proj == "Arrow") %proj = "BowArrowFire";
			%proj = $BOWPROJECTILE[%damageType];
			FireAutoProjectile(%id,%target,%proj);
		}
	}
// --------------------------------------------------------------------------------


%value = floor(%value * (1 + (GetBonus(%id,$BPTWOHANDDMG) / 100)));


//$CRUMONSTER["GoblinBerserker",$CELootBoss]	= "GoblinHead 1 999";
//$CRUMONSTER["GoblinBerserker",$CELootElite]	= "GoblinHead 1 999";



		//if ($STATUSPOISON[%cl] > 0) {
		//	schedule("CruSpellBomb("@%cl@",\""@%pos@"\",\"AIL_POISON\");",0.1);
		//	%init = $POISONINIT[%cl];
		//	%value = round($POISONHIT[%cl] / 5);
		//	if (%value < 1) %value = 1;
		//	Player::ManualDamage(%init,%cl,%value,False,True,"Poison",True);
		//	$STATUSPOISON[%cl]--;
		//}

	if ($STATUSPOISON[%aiId] > 0) {
		schedule("CruSpellBomb("@%aiId@",\""@%pos@"\",\"AIL_POISON\");",0.1);
		%init = $POISONINIT[%aiId];
		%value = round($POISONHIT[%aiId] / 5);
		if (%value < 1) %value = 1;						
		Player::ManualDamage(%init,%aiId,%value,False,True,"Poison",True);
		$STATUSPOISON[%aiId]--;
	}



$BPNOEFFECT[$BPINCDAMAGE,13,"WPN"] = 1;
$BPNOEFFECT[$BPMINDAMAGE,13,"WPN"] = 1;
$BPNOEFFECT[$BPMAXDAMAGE,13,"WPN"] = 1;

$BPNOEFFECT[$BPDDFIRE,13,"WPN"] = 1;
$BPNOEFFECT[$BPDDCOLD,13,"WPN"] = 1;
$BPNOEFFECT[$BPDDENERGY,13,"WPN"] = 1;
$BPNOEFFECT[$BPDDARCANE,13,"WPN"] = 1;
$BPNOEFFECT[$BPDDPOISON,13,"WPN"] = 1;

$BPNOEFFECT[$BPINCARMOR,2,"AMR"] = 1;
$BPNOEFFECT[$BPINCARMOR,3,"AMR"] = 1;
$BPNOEFFECT[$BPINCARMOR,4,"AMR"] = 1;
$BPNOEFFECT[$BPINCARMOR,7,"AMR"] = 1;
$BPNOEFFECT[$BPINCARMOR,8,"AMR"] = 1;
$BPNOEFFECT[$BPINCARMOR,9,"AMR"] = 1;
$BPNOEFFECT[$BPINCARMOR,12,"AMR"] = 1;
$BPNOEFFECT[$BPINCARMOR,15,"AMR"] = 1;

$BPNOEFFECT[$BPARMOR,2,"AMR"] = 1;
$BPNOEFFECT[$BPARMOR,3,"AMR"] = 1;
$BPNOEFFECT[$BPARMOR,4,"AMR"] = 1;
$BPNOEFFECT[$BPARMOR,7,"AMR"] = 1;
$BPNOEFFECT[$BPARMOR,8,"AMR"] = 1;
$BPNOEFFECT[$BPARMOR,9,"AMR"] = 1;
$BPNOEFFECT[$BPARMOR,12,"AMR"] = 1;
$BPNOEFFECT[$BPARMOR,15,"AMR"] = 1;

$BPNOEFFECT[$BPINCRESIST,2,"RES"] = 1;
$BPNOEFFECT[$BPINCRESIST,3,"RES"] = 1;
$BPNOEFFECT[$BPINCRESIST,4,"RES"] = 1;
$BPNOEFFECT[$BPINCRESIST,7,"RES"] = 1;
$BPNOEFFECT[$BPINCRESIST,8,"RES"] = 1;
$BPNOEFFECT[$BPINCRESIST,9,"RES"] = 1;
$BPNOEFFECT[$BPINCRESIST,12,"RES"] = 1;
$BPNOEFFECT[$BPINCRESIST,15,"RES"] = 1;

$BPNOEFFECT[$BPALLRESIST,2,"RES"] = 1;
$BPNOEFFECT[$BPALLRESIST,3,"RES"] = 1;
$BPNOEFFECT[$BPALLRESIST,4,"RES"] = 1;
$BPNOEFFECT[$BPALLRESIST,7,"RES"] = 1;
$BPNOEFFECT[$BPALLRESIST,8,"RES"] = 1;
$BPNOEFFECT[$BPALLRESIST,9,"RES"] = 1;
$BPNOEFFECT[$BPALLRESIST,12,"RES"] = 1;
$BPNOEFFECT[$BPALLRESIST,15,"RES"] = 1;

$BPNOEFFECT[$BPINCEVASION,2,"EVA"] = 1;
$BPNOEFFECT[$BPINCEVASION,3,"EVA"] = 1;
$BPNOEFFECT[$BPINCEVASION,4,"EVA"] = 1;
$BPNOEFFECT[$BPINCEVASION,7,"EVA"] = 1;
$BPNOEFFECT[$BPINCEVASION,8,"EVA"] = 1;
$BPNOEFFECT[$BPINCEVASION,9,"EVA"] = 1;
$BPNOEFFECT[$BPINCEVASION,12,"EVA"] = 1;

$BPNOEFFECT[$BPEVASION,2,"EVA"] = 1;
$BPNOEFFECT[$BPEVASION,3,"EVA"] = 1;
$BPNOEFFECT[$BPEVASION,4,"EVA"] = 1;
$BPNOEFFECT[$BPEVASION,7,"EVA"] = 1;
$BPNOEFFECT[$BPEVASION,8,"EVA"] = 1;
$BPNOEFFECT[$BPEVASION,9,"EVA"] = 1;
$BPNOEFFECT[$BPEVASION,12,"EVA"] = 1;
$BPNOEFFECT[$BPEVASION,15,"EVA"] = 1;



$jumpSurfaceMinDot = 0.2;		//0.92 prevents skiing
$damageScale = 0.030;			//used to be 0.055

//================================================================================================
//      NORMAL (not robed)
//================================================================================================

//----------------//
//      MALE      //
//----------------//

$TeamForRace[MaleHuman] = 0;

$RaceToArmorType[MaleHuman] = MaleHumanArmor7;
$RaceToArmorType[MaleBigHuman] = MaleBigArmor7;

$ArmorTypeToRace[MaleHumanArmor7] = MaleHuman;

$ArmorForSpeed[MaleHuman, -7] = MaleHumanArmor0;
$ArmorForSpeed[MaleHuman, -6] = MaleHumanArmor1;
$ArmorForSpeed[MaleHuman, -5] = MaleHumanArmor2;
$ArmorForSpeed[MaleHuman, -4] = MaleHumanArmor3;
$ArmorForSpeed[MaleHuman, -3] = MaleHumanArmor4;
$ArmorForSpeed[MaleHuman, -2] = MaleHumanArmor5;
$ArmorForSpeed[MaleHuman, -1] = MaleHumanArmor6;

$ArmorForSpeed[MaleHuman, 0] = MaleHumanArmor7;

$ArmorForSpeed[MaleBigHuman, 0] = MaleBigArmor7;
$ArmorForSpeed[MaleBigHuman, -7] = MaleBigArmor0;
$ArmorForSpeed[MaleBigHuman, -4] = MaleBigArmor3;

$ArmorForSpeed[MaleHuman, 1] = MaleHumanArmor8;		//increased speed
$ArmorForSpeed[MaleHuman, 2] = MaleHumanArmor9;		//can glide
$ArmorForSpeed[MaleHuman, 3] = MaleHumanArmor10;	//has jetpack

//-----------------------------------------

$mass[MaleHuman, 0] = 19.5;
$mass[MaleHuman, 1] = 18.0;
$mass[MaleHuman, 2] = 16.5;
$mass[MaleHuman, 3] = 15.0;
$mass[MaleHuman, 4] = 13.5;
$mass[MaleHuman, 5] = 12.0;
$mass[MaleHuman, 6] = 10.5;

$mass[MaleHuman, 7] = 9.0;

$mass[MaleHuman, 8] = 9.0;
$mass[MaleHuman, 9] = 9.0;
$mass[MaleHuman, 10] = 9.0;

//----------------------------

$speed[MaleHuman, 0] = 0.2;
$speed[MaleHuman, 1] = 1;
$speed[MaleHuman, 2] = 2;
$speed[MaleHuman, 3] = 3;
$speed[MaleHuman, 4] = 4;
$speed[MaleHuman, 5] = 6;
$speed[MaleHuman, 6] = 8;

$speed[MaleHuman, 7] = 10;

$speed[MaleHuman, 8] = 14;
$speed[MaleHuman, 9] = 10;
$speed[MaleHuman, 10] = 10;

//----------------------------

$jump[MaleHuman, 0] = 55;
$jump[MaleHuman, 1] = 55;
$jump[MaleHuman, 2] = 55;
$jump[MaleHuman, 3] = 55;
$jump[MaleHuman, 4] = 55;
$jump[MaleHuman, 5] = 55;
$jump[MaleHuman, 6] = 55;

$jump[MaleHuman, 7] = 55;

$jump[MaleHuman, 8] = 80;
$jump[MaleHuman, 9] = 55;
$jump[MaleHuman, 10] = 55;

//====================================================================================

//----------------//
//     FEMALE     //
//----------------//

$TeamForRace[FemaleHuman] = 0;

$RaceToArmorType[FemaleHuman] = FemaleHumanArmor7;
$RaceToArmorType[FemaleBigHuman] = FemaleBigArmor7;
$ArmorTypeToRace[FemaleHumanArmor7] = FemaleHuman;

$ArmorForSpeed[FemaleHuman, -7] = FemaleHumanArmor0;
$ArmorForSpeed[FemaleHuman, -6] = FemaleHumanArmor1;
$ArmorForSpeed[FemaleHuman, -5] = FemaleHumanArmor2;
$ArmorForSpeed[FemaleHuman, -4] = FemaleHumanArmor3;
$ArmorForSpeed[FemaleHuman, -3] = FemaleHumanArmor4;
$ArmorForSpeed[FemaleHuman, -2] = FemaleHumanArmor5;
$ArmorForSpeed[FemaleHuman, -1] = FemaleHumanArmor6;

$ArmorForSpeed[FemaleHuman, 0] = FemaleHumanArmor7;

$ArmorForSpeed[FemaleBigHuman, 0] = FemaleBigArmor7;
$ArmorForSpeed[FemaleBigHuman, -7] = FemaleBigArmor0;
$ArmorForSpeed[FemaleBigHuman, -4] = FemaleBigArmor3;

$ArmorForSpeed[FemaleHuman, 1] = FemaleHumanArmor8;
$ArmorForSpeed[FemaleHuman, 2] = FemaleHumanArmor9;
$ArmorForSpeed[FemaleHuman, 3] = FemaleHumanArmor10;

//-----------------------------------------

$mass[FemaleHuman, 0] = 19.5;
$mass[FemaleHuman, 1] = 18.0;
$mass[FemaleHuman, 2] = 16.5;
$mass[FemaleHuman, 3] = 15.0;
$mass[FemaleHuman, 4] = 13.5;
$mass[FemaleHuman, 5] = 12.0;
$mass[FemaleHuman, 6] = 10.5;

$mass[FemaleHuman, 7] = 9.0;

$mass[FemaleHuman, 8] = 9.0;
$mass[FemaleHuman, 9] = 9.0;
$mass[FemaleHuman, 10] = 9.0;

//----------------------------

$speed[FemaleHuman, 0] = 0.2;
$speed[FemaleHuman, 1] = 1;
$speed[FemaleHuman, 2] = 2;
$speed[FemaleHuman, 3] = 3;
$speed[FemaleHuman, 4] = 4;
$speed[FemaleHuman, 5] = 6;
$speed[FemaleHuman, 6] = 8;

$speed[FemaleHuman, 7] = 10;

$speed[FemaleHuman, 8] = 14;
$speed[FemaleHuman, 9] = 10;
$speed[FemaleHuman, 10] = 10;

//----------------------------

$jump[FemaleHuman, 0] = 55;
$jump[FemaleHuman, 1] = 55;
$jump[FemaleHuman, 2] = 55;
$jump[FemaleHuman, 3] = 55;
$jump[FemaleHuman, 4] = 55;
$jump[FemaleHuman, 5] = 55;
$jump[FemaleHuman, 6] = 55;

$jump[FemaleHuman, 7] = 55;

$jump[FemaleHuman, 8] = 80;
$jump[FemaleHuman, 9] = 55;
$jump[FemaleHuman, 10] = 55;

//====================================================================================
// The long part ...
//====================================================================================

//----------------//
//      MALE      //
//----------------//

PlayerData MaleHumanArmor0
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 0];
   maxBackwardSpeed = $speed[MaleHuman, 0];
   maxSideSpeed = $speed[MaleHuman, 0];

   groundForce = 50.00 * $mass[MaleHuman, 0];
   mass = $mass[MaleHuman, 0];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 0];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor1
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 1];
   maxBackwardSpeed = $speed[MaleHuman, 1] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 1] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 1];
   mass = $mass[MaleHuman, 1];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 1];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor2
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 2];
   maxBackwardSpeed = $speed[MaleHuman, 2] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 2] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 2];
   mass = $mass[MaleHuman, 2];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 2];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor3
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 3];
   maxBackwardSpeed = $speed[MaleHuman, 3] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 3] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 3];
   mass = $mass[MaleHuman, 3];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 25;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 3];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.36;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor4
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 4];
   maxBackwardSpeed = $speed[MaleHuman, 4] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 4] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 4];
   mass = $mass[MaleHuman, 4];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 4];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.46;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor5
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 5];
   maxBackwardSpeed = $speed[MaleHuman, 5] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 5] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 5];
   mass = $mass[MaleHuman, 5];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 5];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.56;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor6
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 6];
   maxBackwardSpeed = $speed[MaleHuman, 6] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 6] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 6];
   mass = $mass[MaleHuman, 6];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 6];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.66;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor7
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 7];
   maxBackwardSpeed = $speed[MaleHuman, 7] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 7] * 0.75;

	groundForce = 40.0 * $mass[MaleHuman, 7];
	mass = $mass[MaleHuman, 7];
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 7];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
	}; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;
   //boxWidth = 0.1;
   //boxDepth = 0.1;
   //boxNormalHeight = 0.1;
   //boxCrouchHeight = 0.1;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.76;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor8
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = False;
	mapFilter = 0;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 8];
   maxBackwardSpeed = $speed[MaleHuman, 8] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 8] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 8];
   mass = $mass[MaleHuman, 8];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 20;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 8];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor9
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 0.01;
   maxJetForwardVelocity = 0.01;
   minJetEnergy = 0.01;
   jetForce = 160;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 9];
   maxBackwardSpeed = $speed[MaleHuman, 9] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 9] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 9];
   mass = $mass[MaleHuman, 9];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 9];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "run", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = SoundGliders;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanArmor10
{
   className = "Armor";
   shapeFile = "rpgmalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 0.8;
   maxJetForwardVelocity = 15;
   minJetEnergy = 2.5;
   jetForce = 200;
   jetEnergyDrain = 0.07;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 10];
   maxBackwardSpeed = $speed[MaleHuman, 10] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 10] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 10];
   mass = $mass[MaleHuman, 10];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 10];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "jet", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = SoundWindWalkers;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.36;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

//----------------//
//     FEMALE     //
//----------------//

PlayerData FemaleHumanArmor0
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 0];
   maxBackwardSpeed = $speed[FemaleHuman, 0];
   maxSideSpeed = $speed[FemaleHuman, 0];

   groundForce = 50.00 * $mass[FemaleHuman, 0];
   mass = $mass[FemaleHuman, 0];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 0];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor1
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 1];
   maxBackwardSpeed = $speed[FemaleHuman, 1] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 1] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 1];
   mass = $mass[FemaleHuman, 1];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 1];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor2
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 2];
   maxBackwardSpeed = $speed[FemaleHuman, 2] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 2] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 2];
   mass = $mass[FemaleHuman, 2];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 2];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor3
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 3];
   maxBackwardSpeed = $speed[FemaleHuman, 3] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 3] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 3];
   mass = $mass[FemaleHuman, 3];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 3];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor4
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 4];
   maxBackwardSpeed = $speed[FemaleHuman, 4] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 4] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 4];
   mass = $mass[FemaleHuman, 4];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 4];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor5
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 5];
   maxBackwardSpeed = $speed[FemaleHuman, 5] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 5] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 5];
   mass = $mass[FemaleHuman, 5];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 5];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor6
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 6];
   maxBackwardSpeed = $speed[FemaleHuman, 6] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 6] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 6];
   mass = $mass[FemaleHuman, 6];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 6];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor7
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 7];
   maxBackwardSpeed = $speed[FemaleHuman, 7] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 7] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 7];
   mass = $mass[FemaleHuman, 7];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 7];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor8
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = False;
	mapFilter = 0;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 8];
   maxBackwardSpeed = $speed[FemaleHuman, 8] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 8] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 8];
   mass = $mass[FemaleHuman, 8];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 20;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 8];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor9
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 0.01;
   maxJetForwardVelocity = 0.01;
   minJetEnergy = 0.01;
   jetForce = 160;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 9];
   maxBackwardSpeed = $speed[FemaleHuman, 9] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 9] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 9];
   mass = $mass[FemaleHuman, 9];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 9];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "run", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = SoundGliders;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanArmor10
{
   className = "Armor";
   shapeFile = "lfemalehuman";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 0.8;
   maxJetForwardVelocity = 15;
   minJetEnergy = 2.5;
   jetForce = 200;
   jetEnergyDrain = 0.07;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 10];
   maxBackwardSpeed = $speed[FemaleHuman, 10] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 10] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 10];
   mass = $mass[FemaleHuman, 10];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 10];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "jet", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = SoundWindWalkers;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

//================================================================================================
//      ROBED
//================================================================================================

//----------------//
//      MALE      //
//----------------//

$RaceToArmorType[MaleHumanRobed] = MaleHumanRobedArmor7;
$RaceToArmorType[MaleBigHumanRobed] = MaleBigRobedArmor7;

$ArmorTypeToRace[MaleHumanRobedArmor7] = MaleHumanRobed;

$ArmorForSpeed[MaleHumanRobed, -7] = MaleHumanRobedArmor0;
$ArmorForSpeed[MaleHumanRobed, -6] = MaleHumanRobedArmor1;
$ArmorForSpeed[MaleHumanRobed, -5] = MaleHumanRobedArmor2;
$ArmorForSpeed[MaleHumanRobed, -4] = MaleHumanRobedArmor3;
$ArmorForSpeed[MaleHumanRobed, -3] = MaleHumanRobedArmor4;
$ArmorForSpeed[MaleHumanRobed, -2] = MaleHumanRobedArmor5;
$ArmorForSpeed[MaleHumanRobed, -1] = MaleHumanRobedArmor6;

$ArmorForSpeed[MaleHumanRobed, 0] = MaleHumanRobedArmor7;

$ArmorForSpeed[MaleHumanRobed, 1] = MaleHumanRobedArmor8;		//increased speed
$ArmorForSpeed[MaleHumanRobed, 2] = MaleHumanRobedArmor9;		//can glide
$ArmorForSpeed[MaleHumanRobed, 3] = MaleHumanRobedArmor10;	//has jetpack

//-----------------------------------------

$mass[MaleHumanRobed, 0] = 19.5;
$mass[MaleHumanRobed, 1] = 18.0;
$mass[MaleHumanRobed, 2] = 16.5;
$mass[MaleHumanRobed, 3] = 15.0;
$mass[MaleHumanRobed, 4] = 13.5;
$mass[MaleHumanRobed, 5] = 12.0;
$mass[MaleHumanRobed, 6] = 10.5;

$mass[MaleHumanRobed, 7] = 9.0;

$mass[MaleHumanRobed, 8] = 9.0;
$mass[MaleHumanRobed, 9] = 9.0;
$mass[MaleHumanRobed, 10] = 9.0;

//----------------------------

$speed[MaleHumanRobed, 0] = 0.2;
$speed[MaleHumanRobed, 1] = 1;
$speed[MaleHumanRobed, 2] = 2;
$speed[MaleHumanRobed, 3] = 3;
$speed[MaleHumanRobed, 4] = 4;
$speed[MaleHumanRobed, 5] = 6;
$speed[MaleHumanRobed, 6] = 8;

$speed[MaleHumanRobed, 7] = 10;

$speed[MaleHumanRobed, 8] = 14;
$speed[MaleHumanRobed, 9] = 10;
$speed[MaleHumanRobed, 10] = 10;

//----------------------------

$jump[MaleHumanRobed, 0] = 55;
$jump[MaleHumanRobed, 1] = 55;
$jump[MaleHumanRobed, 2] = 55;
$jump[MaleHumanRobed, 3] = 55;
$jump[MaleHumanRobed, 4] = 55;
$jump[MaleHumanRobed, 5] = 55;
$jump[MaleHumanRobed, 6] = 55;

$jump[MaleHumanRobed, 7] = 55;

$jump[MaleHumanRobed, 8] = 80;
$jump[MaleHumanRobed, 9] = 55;
$jump[MaleHumanRobed, 10] = 55;

//====================================================================================

//----------------//
//     FEMALE     //
//----------------//

$TeamForRace[FemaleHumanRobed] = 0;

$RaceToArmorType[FemaleHumanRobed] = FemaleHumanRobedArmor7;
$RaceToArmorType[FemaleBigHumanRobed] = FemaleBigRobedArmor7;
$ArmorTypeToRace[FemaleHumanRobedArmor7] = FemaleHumanRobed;

$ArmorForSpeed[FemaleHumanRobed, -7] = FemaleHumanRobedArmor0;
$ArmorForSpeed[FemaleHumanRobed, -6] = FemaleHumanRobedArmor1;
$ArmorForSpeed[FemaleHumanRobed, -5] = FemaleHumanRobedArmor2;
$ArmorForSpeed[FemaleHumanRobed, -4] = FemaleHumanRobedArmor3;
$ArmorForSpeed[FemaleHumanRobed, -3] = FemaleHumanRobedArmor4;
$ArmorForSpeed[FemaleHumanRobed, -2] = FemaleHumanRobedArmor5;
$ArmorForSpeed[FemaleHumanRobed, -1] = FemaleHumanRobedArmor6;

$ArmorForSpeed[FemaleHumanRobed, 0] = FemaleHumanRobedArmor7;

$ArmorForSpeed[FemaleHumanRobed, 1] = FemaleHumanRobedArmor8;
$ArmorForSpeed[FemaleHumanRobed, 2] = FemaleHumanRobedArmor9;
$ArmorForSpeed[FemaleHumanRobed, 3] = FemaleHumanRobedArmor10;

//-----------------------------------------

$mass[FemaleHumanRobed, 0] = 19.5;
$mass[FemaleHumanRobed, 1] = 18.0;
$mass[FemaleHumanRobed, 2] = 16.5;
$mass[FemaleHumanRobed, 3] = 15.0;
$mass[FemaleHumanRobed, 4] = 13.5;
$mass[FemaleHumanRobed, 5] = 12.0;
$mass[FemaleHumanRobed, 6] = 10.5;

$mass[FemaleHumanRobed, 7] = 9.0;

$mass[FemaleHumanRobed, 8] = 9.0;
$mass[FemaleHumanRobed, 9] = 9.0;
$mass[FemaleHumanRobed, 10] = 9.0;

//----------------------------

$speed[FemaleHumanRobed, 0] = 0.2;
$speed[FemaleHumanRobed, 1] = 1;
$speed[FemaleHumanRobed, 2] = 2;
$speed[FemaleHumanRobed, 3] = 3;
$speed[FemaleHumanRobed, 4] = 4;
$speed[FemaleHumanRobed, 5] = 6;
$speed[FemaleHumanRobed, 6] = 8;

$speed[FemaleHumanRobed, 7] = 10;

$speed[FemaleHumanRobed, 8] = 14;
$speed[FemaleHumanRobed, 9] = 10;
$speed[FemaleHumanRobed, 10] = 10;

//----------------------------

$jump[FemaleHumanRobed, 0] = 55;
$jump[FemaleHumanRobed, 1] = 55;
$jump[FemaleHumanRobed, 2] = 55;
$jump[FemaleHumanRobed, 3] = 55;
$jump[FemaleHumanRobed, 4] = 55;
$jump[FemaleHumanRobed, 5] = 55;
$jump[FemaleHumanRobed, 6] = 55;

$jump[FemaleHumanRobed, 7] = 55;

$jump[FemaleHumanRobed, 8] = 80;
$jump[FemaleHumanRobed, 9] = 55;
$jump[FemaleHumanRobed, 10] = 55;


//====================================================================================
// The long part ...
//====================================================================================

//----------------//
//      MALE      //
//----------------//

PlayerData MaleHumanRobedArmor0
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 0];
   maxBackwardSpeed = $speed[MaleHumanRobed, 0];
   maxSideSpeed = $speed[MaleHumanRobed, 0];

   groundForce = 50.00 * $mass[MaleHumanRobed, 0];
   mass = $mass[MaleHumanRobed, 0];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 0];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor1
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 1];
   maxBackwardSpeed = $speed[MaleHumanRobed, 1] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 1] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 1];
   mass = $mass[MaleHumanRobed, 1];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 1];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor2
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 2];
   maxBackwardSpeed = $speed[MaleHumanRobed, 2] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 2] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 2];
   mass = $mass[MaleHumanRobed, 2];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 2];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor3
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 3];
   maxBackwardSpeed = $speed[MaleHumanRobed, 3] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 3] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 3];
   mass = $mass[MaleHumanRobed, 3];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 3];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.36;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor4
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 4];
   maxBackwardSpeed = $speed[MaleHumanRobed, 4] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 4] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 4];
   mass = $mass[MaleHumanRobed, 4];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 4];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.46;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor5
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 5];
   maxBackwardSpeed = $speed[MaleHumanRobed, 5] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 5] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 5];
   mass = $mass[MaleHumanRobed, 5];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 5];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.56;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor6
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 6];
   maxBackwardSpeed = $speed[MaleHumanRobed, 6] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 6] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 6];
   mass = $mass[MaleHumanRobed, 6];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 6];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.66;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor7
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 7];
   maxBackwardSpeed = $speed[MaleHumanRobed, 7] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 7] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 7];
   mass = $mass[MaleHumanRobed, 7];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 7];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
	}; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.76;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor8
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = False;
	mapFilter = 0;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 8];
   maxBackwardSpeed = $speed[MaleHumanRobed, 8] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 8] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 8];
   mass = $mass[MaleHumanRobed, 8];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 20;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 8];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor9
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 0.01;
   maxJetForwardVelocity = 0.01;
   minJetEnergy = 0.01;
   jetForce = 160;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 9];
   maxBackwardSpeed = $speed[MaleHumanRobed, 9] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 9] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 9];
   mass = $mass[MaleHumanRobed, 9];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 9];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "run", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = SoundGliders;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData MaleHumanRobedArmor10
{
   className = "Armor";
   shapeFile = "magemale";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 0.8;
   maxJetForwardVelocity = 15;
   minJetEnergy = 2.5;
   jetForce = 200;
   jetEnergyDrain = 0.07;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHumanRobed, 10];
   maxBackwardSpeed = $speed[MaleHumanRobed, 10] * 0.8;
   maxSideSpeed = $speed[MaleHumanRobed, 10] * 0.75;

   groundForce = 50.00 * $mass[MaleHumanRobed, 10];
   mass = $mass[MaleHumanRobed, 10];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHumanRobed, 10];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "jet", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = SoundWindWalkers;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.36;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

//----------------//
//     FEMALE     //
//----------------//

PlayerData FemaleHumanRobedArmor0
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 0];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 0];
   maxSideSpeed = $speed[FemaleHumanRobed, 0];

   groundForce = 50.00 * $mass[FemaleHumanRobed, 0];
   mass = $mass[FemaleHumanRobed, 0];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 0];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor1
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 1];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 1] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 1] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 1];
   mass = $mass[FemaleHumanRobed, 1];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 1];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor2
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 2];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 2] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 2] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 2];
   mass = $mass[FemaleHumanRobed, 2];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 2];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor3
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 3];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 3] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 3] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 3];
   mass = $mass[FemaleHumanRobed, 3];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 3];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor4
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 4];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 4] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 4] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 4];
   mass = $mass[FemaleHumanRobed, 4];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 4];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor5
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 5];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 5] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 5] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 5];
   mass = $mass[FemaleHumanRobed, 5];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 5];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor6
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 6];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 6] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 6] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 6];
   mass = $mass[FemaleHumanRobed, 6];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 6];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor7
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 7];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 7] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 7] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 7];
   mass = $mass[FemaleHumanRobed, 7];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 7];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor8
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = False;
	mapFilter = 0;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 8];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 8] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 8] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 8];
   mass = $mass[FemaleHumanRobed, 8];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 20;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 8];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor9
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 0.01;
   maxJetForwardVelocity = 0.01;
   minJetEnergy = 0.01;
   jetForce = 160;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 9];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 9] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 9] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 9];
   mass = $mass[FemaleHumanRobed, 9];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 9];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "run", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = SoundGliders;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleHumanRobedArmor10
{
   className = "Armor";
   shapeFile = "femalemage";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 0.8;
   maxJetForwardVelocity = 15;
   minJetEnergy = 2.5;
   jetForce = 200;
   jetEnergyDrain = 0.07;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHumanRobed, 10];
   maxBackwardSpeed = $speed[FemaleHumanRobed, 10] * 0.8;
   maxSideSpeed = $speed[FemaleHumanRobed, 10] * 0.75;

   groundForce = 50.00 * $mass[FemaleHumanRobed, 10];
   mass = $mass[FemaleHumanRobed, 10];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHumanRobed, 10];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "run", none, -1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "jet", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = SoundWindWalkers;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};



















PlayerData DwelfArmor
{
   className = "Armor";
   shapeFile = "dwelf";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 7];
   maxBackwardSpeed = $speed[MaleHuman, 7] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 7] * 0.75;

	groundForce = 40.0 * $mass[MaleHuman, 7];
	mass = $mass[MaleHuman, 7];
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 7];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "run", none, -1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
	}; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;
   //boxWidth = 0.1;
   //boxDepth = 0.1;
   //boxNormalHeight = 0.1;
   //boxCrouchHeight = 0.1;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.76;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};


PlayerData DwelfRobedArmor
{
   className = "Armor";
   shapeFile = "dwelfrobed";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 7];
   maxBackwardSpeed = $speed[MaleHuman, 7] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 7] * 0.75;

	groundForce = 40.0 * $mass[MaleHuman, 7];
	mass = $mass[MaleHuman, 7];
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 7];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
	}; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;
   //boxWidth = 0.1;
   //boxDepth = 0.1;
   //boxNormalHeight = 0.1;
   //boxCrouchHeight = 0.1;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.76;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

//===================================================================================================================================================

// REGULAR
PlayerData MaleBigArmor7
{
   className = "Armor";
   shapeFile = "nephilim";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 7];
   maxBackwardSpeed = $speed[MaleHuman, 7] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 7] * 0.75;

	groundForce = 40.0 * $mass[MaleHuman, 7];
	mass = $mass[MaleHuman, 7];
	groundTraction = 3.0;
	maxEnergy = 60;
	drag = 1.0;
	density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 7];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
	}; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;
   //boxWidth = 0.1;
   //boxDepth = 0.1;
   //boxNormalHeight = 0.1;
   //boxCrouchHeight = 0.1;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.76;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

// SNARED
PlayerData MaleBigHumanArmor3
{
   className = "Armor";
   shapeFile = "nephilim";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 3];
   maxBackwardSpeed = $speed[MaleHuman, 3] * 0.8;
   maxSideSpeed = $speed[MaleHuman, 3] * 0.75;

   groundForce = 50.00 * $mass[MaleHuman, 3];
   mass = $mass[MaleHuman, 3];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 25;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 3];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.36;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

// ROOTED
PlayerData MaleBigHumanArmor0
{
   className = "Armor";
   shapeFile = "nephilim";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[MaleHuman, 0];
   maxBackwardSpeed = $speed[MaleHuman, 0];
   maxSideSpeed = $speed[MaleHuman, 0];

   groundForce = 50.00 * $mass[MaleHuman, 0];
   mass = $mass[MaleHuman, 0];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[MaleHuman, 0];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 

    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.83;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.26;
   boxCrouchTorsoPercentage = 0.3333;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};


//==========================================================================================================================================

PlayerData FemaleBigArmor7
{
   className = "Armor";
   shapeFile = "nephilim_f";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 7];
   maxBackwardSpeed = $speed[FemaleHuman, 7] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 7] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 7];
   mass = $mass[FemaleHuman, 7];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 7];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleBigArmor3
{
   className = "Armor";
   shapeFile = "nephilim_f";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 3];
   maxBackwardSpeed = $speed[FemaleHuman, 3] * 0.8;
   maxSideSpeed = $speed[FemaleHuman, 3] * 0.75;

   groundForce = 50.00 * $mass[FemaleHuman, 3];
   mass = $mass[FemaleHuman, 3];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 3];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};

PlayerData FemaleBigArmor0
{
   className = "Armor";
   shapeFile = "nephilim_f";
   damageSkinData = "armorDamageSkins";
	debrisId = playerDebris;
   flameShapeName = "lflame";
   shieldShapeName = "shield";
   shadowDetailMask = 1;

   visibleToSensor = True;
	mapFilter = 1;
	mapIcon = "M_player";
   canCrouch = false;

   maxJetSideForceFactor = 1;
   maxJetForwardVelocity = 1.0;
   minJetEnergy = 60;
   jetForce = 1;
   jetEnergyDrain = 0.0;

	maxDamage = 1.0;
   maxForwardSpeed = $speed[FemaleHuman, 0];
   maxBackwardSpeed = $speed[FemaleHuman, 0];
   maxSideSpeed = $speed[FemaleHuman, 0];

   groundForce = 50.00 * $mass[FemaleHuman, 0];
   mass = $mass[FemaleHuman, 0];
   groundTraction = 3.0;
	maxEnergy = 60;
   drag = 1.0;
   density = 1.2;

	minDamageSpeed = 16;
	damageScale = $damageScale;

   jumpImpulse = $jump[FemaleHuman, 0];
   jumpSurfaceMinDot = $jumpSurfaceMinDot;

   // animation data:
   // animation name, one shot, direction
	// firstPerson, chaseCam, thirdPerson, signalThread
   // movement animations:
   animData[0]  = { "root", none, 1, true, true, true, false, 0 };
   animData[1]  = { "run", none, 1, true, false, true, false, 3 };
   animData[2]  = { "runback", none, 1, true, false, true, false, 3 };
   animData[3]  = { "side left", none, 1, true, false, true, false, 3 };
   animData[4]  = { "side left", none, -1, true, false, true, false, 3 };
   animData[5] = { "jump stand", none, 1, true, false, true, false, 3 };
   animData[6] = { "jump run", none, 1, true, false, true, false, 3 };
   animData[7] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[8] = { "crouch root", none, 1, true, true, true, false, 3 };
   animData[9] = { "crouch root", none, -1, true, true, true, false, 3 };
   animData[10] = { "crouch forward", none, 1, true, false, true, false, 3 };
   animData[11] = { "crouch forward", none, -1, true, false, true, false, 3 };
   animData[12] = { "crouch side left", none, 1, true, false, true, false, 3 };
   animData[13] = { "crouch side left", none, -1, true, false, true, false, 3 };
   animData[14]  = { "fall", none, 1, true, true, true, false, 3 };
   animData[15]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[16]  = { "landing", SoundLandOnGround, 1, true, false, false, false, 3 };
   animData[17]  = { "tumble loop", none, 1, true, false, false, false, 3 };
   animData[18]  = { "tumble end", none, 1, true, false, false, false, 3 };
   animData[19] = { "root", none, 1, true, true, true, false, 3 };

   // misc. animations:
   animData[20] = { "die back", none, 1, true, false, false, false, 0 };
   animData[21] = { "throw", none, 1, true, false, false, false, 3 };
   animData[22] = { "flyer root", none, 1, false, false, false, false, 3 };
   animData[23] = { "apc root", none, 1, true, true, true, false, 3 };
   animData[24] = { "apc pilot", none, 1, false, false, false, false, 3 };
   
   // death animations:
   animData[25] = { "crouch die", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[26] = { "die chest", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[27] = { "die head", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[28] = { "die grab back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[29] = { "die right side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[30] = { "die left side", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[31] = { "die leg left", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[32] = { "die leg right", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[33] = { "die blown back", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[34] = { "die spin", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[35] = { "die forward", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[36] = { "die forward kneel", SoundPlayerDeath, 1, false, false, false, false, 4 };
   animData[37] = { "die back", SoundPlayerDeath, 1, false, false, false, false, 4 };

   // signal moves:
	animData[38] = { "sign over here",  none, 1, true, false, false, false, 2 };
   animData[39] = { "sign point", none, 1, true, false, false, false, 1 };
   animData[40] = { "sign retreat",none, 1, true, false, false, false, 2 };
   animData[41] = { "sign stop", none, 1, true, false, false, true, 1 };
   animData[42] = { "sign salut", none, 1, true, false, false, true, 1 }; 


    // celebration animations:
   animData[43] = { "celebration 1",none, 1, true, false, false, false, 2 };
   animData[44] = { "celebration 2", none, 1, true, false, false, false, 2 };
   animData[45] = { "celebration 3", none, 1, true, false, false, false, 2 };
 
    // taunt animations:
	animData[46] = { "taunt 1", none, 1, true, false, false, false, 2 };
	animData[47] = { "taunt 2", none, 1, true, false, false, false, 2 };
 
    // poses:
	animData[48] = { "pose kneel", none, 1, true, false, false, true, 1 };
	animData[49] = { "pose stand", none, 1, true, false, false, true, 1 };

	// Bonus wave
   animData[50] = { "wave", none, 1, true, false, false, true, 1 };

   jetSound = NoSound;
   rFootSounds = 
   {
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRHard,
     SoundLFootRSnow,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft,
     SoundLFootRSoft
  }; 
   lFootSounds =
   {
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLHard,
      SoundLFootLSnow,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft,
      SoundLFootLSoft
   };

   footPrints = { 0, 1 };

   boxWidth = 0.5;
   boxDepth = 0.5;
   boxNormalHeight = 2.3;
   boxCrouchHeight = 1.8;

   boxNormalHeadPercentage  = 0.85;
   boxNormalTorsoPercentage = 0.53;
   boxCrouchHeadPercentage  = 0.88;
   boxCrouchTorsoPercentage = 0.35;

   boxHeadLeftPercentage  = 0;
   boxHeadRightPercentage = 1;
   boxHeadBackPercentage  = 0;
   boxHeadFrontPercentage = 1;
};



function Loot::Curve_Unused(%t,%m)
{
	%savm = %m;
	%start = %m * 0.005;
	for (%i = 0; %i <= %m; %i++) {
		for (%z = 0; %z <= %t; %z++) {
			%sub = ((%z / %t) * (%m / %t));
			%sub = %sub * %z;
			%b[%z] += %sub;
		}
		%m = %m - %sub;
	}
	%z = 1;
	for (%i = %t; %i > 0; %i--) {
		%n = %i - 1;
		//echo("BB " @ %b[%i] @ " " @ %b[%n]);
		%p = (((%b[%i] - %b[%n]) / %b[%n]) * 100);
		if (%p < 0) %p = 0;
		//echo("I " @ %i @ " P " @ %p);
		%k[%z] = %p;
		%z++;
	}
	%k[%t] = %savm;
	%f[0] = 0;
	%f[1] = %start;
	for (%i = 2; %i <= %t; %i++) {
		%l = %i - 1;
		//echo(" K " @ %k[%i]);
		//echo(" FL " @ %f[%l]);
		%f[%i] = (%f[%l] * (1 + (%k[%i] / 100)));
	}
	
	for (%i = 0; %i <= %t; %i++)
		echo("F:" @ %i @ " " @ round(%f[%i]));
}