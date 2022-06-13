// RELICS

// PORTAL SCROLL
$DynamicItem[PortalScroll,$DName] = "Portal Scroll";
$DynamicItem[PortalScroll,$DIco] = "ico_portalscroll.bmp";
$DynamicItem[PortalScroll,$DMinMax] = "999 999";
$DynamicItem[PortalScroll,$DWeight] = "1 0";
$DynamicItem[PortalScroll,$DPrice] = "100 0";
$DynamicItem[PortalScroll,$DUse] = "ACTIONUNLOCKED TownPortal NA NOTINCOMBAT 1 NA";
$DynamicItem[PortalScroll,$DUseBonus] = "ACTION TownPortal NA";
$DynamicItem[PortalScroll,$DDesc] = "This portal scroll will take you back to town";
$DynamicItem[PortalScroll,$DItemType] = "0 Scroll";
$DynamicItem[PortalScroll,$DDeleteOnUse] = 1;
DynamicItem::CheckItemCreate("PortalScroll",999);

// INTEGRITY
$DynamicItem[ArmourScrap,$DName] = "Armour Scrap";
$DynamicItem[ArmourScrap,$DIco] = "ico_armourscrap.bmp";
$DynamicItem[ArmourScrap,$DMinMax] = "999 999";
$DynamicItem[ArmourScrap,$DWeight] = "1 0";
$DynamicItem[ArmourScrap,$DPrice] = "10 0";
$DynamicItem[ArmourScrap,$DDesc] = "An armour scrap, can be used to upgrade armor based items";
$DynamicItem[ArmourScrap,$DCraftType] = "ARMOURSCRAP";
$DynamicItem[ArmourScrap,$DItemType] = "1 Tradeskill";
DynamicItem::CheckItemCreate("ArmourScrap",999);

$DynamicItem[SpoolOfThread,$DName] = "Spool of Thread";
$DynamicItem[SpoolOfThread,$DIco] = "ico_spoolofthread.bmp";
$DynamicItem[SpoolOfThread,$DMinMax] = "999 999";
$DynamicItem[SpoolOfThread,$DWeight] = "1 0";
$DynamicItem[SpoolOfThread,$DPrice] = "10 0";
$DynamicItem[SpoolOfThread,$DDesc] = "A spool of strong thread, can be used to upgrade evasion based items";
$DynamicItem[SpoolOfThread,$DCraftType] = "SPOOLOFTHREAD";
$DynamicItem[SpoolOfThread,$DItemType] = "1 Tradeskill";
DynamicItem::CheckItemCreate("SpoolOfThread",999);

$DynamicItem[PieceOfCloth,$DName] = "Piece of Cloth";
$DynamicItem[PieceOfCloth,$DIco] = "ico_pieceofcloth.bmp";
$DynamicItem[PieceOfCloth,$DMinMax] = "999 999";
$DynamicItem[PieceOfCloth,$DWeight] = "1 0";
$DynamicItem[PieceOfCloth,$DPrice] = "10 0";
$DynamicItem[PieceOfCloth,$DDesc] = "A piece of enchanted cloth, can be used to upgrade resistance based items";
$DynamicItem[PieceOfCloth,$DCraftType] = "PIECEOFCLOTH";
$DynamicItem[PieceOfCloth,$DItemType] = "1 Tradeskill";
DynamicItem::CheckItemCreate("PieceOfCloth",999);

$DynamicItem[SharpeningStone,$DName] = "Sharpening Stone";
$DynamicItem[SharpeningStone,$DIco] = "ico_sharpeningstone.bmp";
$DynamicItem[SharpeningStone,$DMinMax] = "999 999";
$DynamicItem[SharpeningStone,$DWeight] = "1 0";
$DynamicItem[SharpeningStone,$DPrice] = "10 0";
$DynamicItem[SharpeningStone,$DDesc] = "A sharpening stone that can be used to upgrade physical weapons";
$DynamicItem[SharpeningStone,$DCraftType] = "SHARPENINGSTONE";
$DynamicItem[SharpeningStone,$DItemType] = "1 Tradeskill";
DynamicItem::CheckItemCreate("SharpeningStone",999);

$DynamicItem[MagicStone,$DName] = "Magic Stone";
$DynamicItem[MagicStone,$DIco] = "ico_magicstone.bmp";
$DynamicItem[MagicStone,$DMinMax] = "999 999";
$DynamicItem[MagicStone,$DWeight] = "1 0";
$DynamicItem[MagicStone,$DPrice] = "10 0";
$DynamicItem[MagicStone,$DDesc] = "A magic stone that can be used to upgrade magic weapons";
$DynamicItem[MagicStone,$DCraftType] = "MAGICSTONE";
$DynamicItem[MagicStone,$DItemType] = "1 Tradeskill";
DynamicItem::CheckItemCreate("MagicStone",999);

$DynamicItem[FireStone,$DName] = "Fire Stone";
$DynamicItem[FireStone,$DIco] = "ico_FireStone.bmp";
$DynamicItem[FireStone,$DMinMax] = "999 999";
$DynamicItem[FireStone,$DWeight] = "1 0";
$DynamicItem[FireStone,$DPrice] = "500 0";
$DynamicItem[FireStone,$DDesc] = "This stone sets a physical weapons damage type to Fire";
$DynamicItem[FireStone,$DCraftType] = "DAMAGESTONE";
$DynamicItem[FireStone,$DItemType] = "5 Tradeskill";
$DynamicItem[FireStone,$DDamageStone] = "DDFIRE";
DynamicItem::CheckItemCreate("FireStone",999);

$DynamicItem[ColdStone,$DName] = "Cold Stone";
$DynamicItem[ColdStone,$DIco] = "ico_ColdStone.bmp";
$DynamicItem[ColdStone,$DMinMax] = "999 999";
$DynamicItem[ColdStone,$DWeight] = "1 0";
$DynamicItem[ColdStone,$DPrice] = "500 0";
$DynamicItem[ColdStone,$DDesc] = "This stone sets a physical weapons damage type to Cold";
$DynamicItem[ColdStone,$DCraftType] = "DAMAGESTONE";
$DynamicItem[ColdStone,$DItemType] = "5 Tradeskill";
$DynamicItem[ColdStone,$DDamageStone] = "DDCOLD";
DynamicItem::CheckItemCreate("ColdStone",999);

$DynamicItem[EnergyStone,$DName] = "Energy Stone";
$DynamicItem[EnergyStone,$DIco] = "ico_EnergyStone.bmp";
$DynamicItem[EnergyStone,$DMinMax] = "999 999";
$DynamicItem[EnergyStone,$DWeight] = "1 0";
$DynamicItem[EnergyStone,$DPrice] = "500 0";
$DynamicItem[EnergyStone,$DDesc] = "This stone sets a physical weapons damage type to Energy";
$DynamicItem[EnergyStone,$DCraftType] = "DAMAGESTONE";
$DynamicItem[EnergyStone,$DItemType] = "5 Tradeskill";
$DynamicItem[EnergyStone,$DDamageStone] = "DDENERGY";
DynamicItem::CheckItemCreate("EnergyStone",999);

$DynamicItem[PoisonStone,$DName] = "Poison Stone";
$DynamicItem[PoisonStone,$DIco] = "ico_PoisonStone.bmp";
$DynamicItem[PoisonStone,$DMinMax] = "999 999";
$DynamicItem[PoisonStone,$DWeight] = "1 0";
$DynamicItem[PoisonStone,$DPrice] = "500 0";
$DynamicItem[PoisonStone,$DDesc] = "This stone sets a physical weapons damage type to Poison";
$DynamicItem[PoisonStone,$DCraftType] = "DAMAGESTONE";
$DynamicItem[PoisonStone,$DItemType] = "5 Tradeskill";
$DynamicItem[PoisonStone,$DDamageStone] = "DDPOISON";
DynamicItem::CheckItemCreate("PoisonStone",999);

// RELICS RANDOMIZE
$DynamicItem[AlteringRelic,$DName] = "Altering Relic";
$DynamicItem[AlteringRelic,$DIco] = "ico_alteringrelic.bmp";
$DynamicItem[AlteringRelic,$DMinMax] = "999 999";
$DynamicItem[AlteringRelic,$DWeight] = "1 0";
$DynamicItem[AlteringRelic,$DPrice] = "100 0";
$DynamicItem[AlteringRelic,$DDesc] = "Randomizes the random properties of a lesser item";
$DynamicItem[AlteringRelic,$DCraftType] = "ALTERING";
$DynamicItem[AlteringRelic,$DItemType] = "2 Relic";
DynamicItem::CheckItemCreate("AlteringRelic",999);

$DynamicItem[HavocRelic,$DName] = "Havoc Relic";
$DynamicItem[HavocRelic,$DIco] = "ico_havocrelic.bmp";
$DynamicItem[HavocRelic,$DMinMax] = "999 999";
$DynamicItem[HavocRelic,$DWeight] = "1 0";
$DynamicItem[HavocRelic,$DPrice] = "200 0";
$DynamicItem[HavocRelic,$DDesc] = "Randomizes the random properties of a Magic item";
$DynamicItem[HavocRelic,$DCraftType] = "HAVOC";
$DynamicItem[HavocRelic,$DItemType] = "3 Relic";
DynamicItem::CheckItemCreate("HavocRelic",999);

$DynamicItem[ChaosRelic,$DName] = "Chaos Relic";
$DynamicItem[ChaosRelic,$DIco] = "ico_chaosrelic.bmp";
$DynamicItem[ChaosRelic,$DMinMax] = "999 999";
$DynamicItem[ChaosRelic,$DWeight] = "1 0";
$DynamicItem[ChaosRelic,$DPrice] = "400 0";
$DynamicItem[ChaosRelic,$DDesc] = "Randomizes the random properties of a Rare item";
$DynamicItem[ChaosRelic,$DCraftType] = "CHAOS";
$DynamicItem[ChaosRelic,$DItemType] = "4 Relic";
DynamicItem::CheckItemCreate("ChaosRelic",999);

$DynamicItem[AnarchyRelic,$DName] = "Anarchy Relic";
$DynamicItem[AnarchyRelic,$DIco] = "ico_anarchyrelic.bmp";
$DynamicItem[AnarchyRelic,$DMinMax] = "999 999";
$DynamicItem[AnarchyRelic,$DWeight] = "1 0";
$DynamicItem[AnarchyRelic,$DPrice] = "800 0";
$DynamicItem[AnarchyRelic,$DDesc] = "Randomizes the random properties of a Legendary item";
$DynamicItem[AnarchyRelic,$DCraftType] = "ANARCHY";
$DynamicItem[AnarchyRelic,$DItemType] = "5 Relic";
DynamicItem::CheckItemCreate("AnarchyRelic",999);

// RELICS UPGRADE
$DynamicItem[RegalRelic,$DName] = "Regal Relic";
$DynamicItem[RegalRelic,$DIco] = "ico_regalrelic.bmp";
$DynamicItem[RegalRelic,$DMinMax] = "999 999";
$DynamicItem[RegalRelic,$DWeight] = "1 0";
$DynamicItem[RegalRelic,$DPrice] = "200 0";
$DynamicItem[RegalRelic,$DDesc] = "Upgrades a lesser item into a Magic item";
$DynamicItem[RegalRelic,$DCraftType] = "REGAL";
$DynamicItem[RegalRelic,$DItemType] = "3 Relic";
DynamicItem::CheckItemCreate("RegalRelic",999);

$DynamicItem[CosmicRelic,$DName] = "Cosmic Relic";
$DynamicItem[CosmicRelic,$DIco] = "ico_cosmicrelic.bmp";
$DynamicItem[CosmicRelic,$DMinMax] = "999 999";
$DynamicItem[CosmicRelic,$DWeight] = "1 0";
$DynamicItem[CosmicRelic,$DPrice] = "400 0";
$DynamicItem[CosmicRelic,$DDesc] = "Upgrades a Magic item into a Rare item";
$DynamicItem[CosmicRelic,$DCraftType] = "COSMIC";
$DynamicItem[CosmicRelic,$DItemType] = "4 Relic";
DynamicItem::CheckItemCreate("CosmicRelic",999);

$DynamicItem[HeroicRelic,$DName] = "Heroic Relic";
$DynamicItem[HeroicRelic,$DIco] = "ico_heroicrelic.bmp";
$DynamicItem[HeroicRelic,$DMinMax] = "999 999";
$DynamicItem[HeroicRelic,$DWeight] = "1 0";
$DynamicItem[HeroicRelic,$DPrice] = "800 0";
$DynamicItem[HeroicRelic,$DDesc] = "Upgrades a Rare item into a Legendary item";
$DynamicItem[HeroicRelic,$DCraftType] = "HEROIC";
$DynamicItem[HeroicRelic,$DItemType] = "5 Relic";
DynamicItem::CheckItemCreate("HeroicRelic",999);

// CLEARING
$DynamicItem[ScouringRelic,$DName] = "Scouring Relic";
$DynamicItem[ScouringRelic,$DIco] = "ico_scouringrelic.bmp";
$DynamicItem[ScouringRelic,$DMinMax] = "999 999";
$DynamicItem[ScouringRelic,$DWeight] = "1 0";
$DynamicItem[ScouringRelic,$DPrice] = "100 0";
$DynamicItem[ScouringRelic,$DDesc] = "Removes all random properties from an item";
$DynamicItem[ScouringRelic,$DCraftType] = "SCOURING";
$DynamicItem[ScouringRelic,$DItemType] = "3 Relic";
DynamicItem::CheckItemCreate("ScouringRelic",999);

// IMPLICIT
$DynamicItem[BlessedRelic,$DName] = "Blessed Relic";
$DynamicItem[BlessedRelic,$DIco] = "ico_blessedrelic.bmp";
$DynamicItem[BlessedRelic,$DMinMax] = "999 999";
$DynamicItem[BlessedRelic,$DWeight] = "1 0";
$DynamicItem[BlessedRelic,$DPrice] = "300 0";
$DynamicItem[BlessedRelic,$DDesc] = "Randomize the implicit modifier of an item";
$DynamicItem[BlessedRelic,$DCraftType] = "BLESSED";
$DynamicItem[BlessedRelic,$DItemType] = "4 Relic";
DynamicItem::CheckItemCreate("BlessedRelic",999);

// MYSTIC
$DynamicItem[MysticRelic,$DName] = "Mystic Relic";
$DynamicItem[MysticRelic,$DIco] = "ico_mysticrelic.bmp";
$DynamicItem[MysticRelic,$DMinMax] = "999 999";
$DynamicItem[MysticRelic,$DWeight] = "1 0";
$DynamicItem[MysticRelic,$DPrice] = "1000 0";
$DynamicItem[MysticRelic,$DDesc] = "This relic lets you randomize a specific property of an item";
$DynamicItem[MysticRelic,$DCraftType] = "MYSTIC";
$DynamicItem[MysticRelic,$DItemType] = "6 Relic";
DynamicItem::CheckItemCreate("MysticRelic",999);

// RUNE PRISM
$DynamicItem[RunePrism,$DName] = "Rune Prism";
$DynamicItem[RunePrism,$DIco] = "ico_runeprism.bmp";
$DynamicItem[RunePrism,$DMinMax] = "999 999";
$DynamicItem[RunePrism,$DWeight] = "1 0";
$DynamicItem[RunePrism,$DPrice] = "1000 0";
$DynamicItem[RunePrism,$DDesc] = "This relic replaces a modifier with a socket";
$DynamicItem[RunePrism,$DCraftType] = "PRISM";
$DynamicItem[RunePrism,$DItemType] = "6 Relic";
DynamicItem::CheckItemCreate("RunePrism",999);

// DIVINE RELIC
$DynamicItem[DivineRelic,$DName] = "Divine Relic";
$DynamicItem[DivineRelic,$DIco] = "ico_divinerelic.bmp";
$DynamicItem[DivineRelic,$DMinMax] = "999 999";
$DynamicItem[DivineRelic,$DWeight] = "1 0";
$DynamicItem[DivineRelic,$DPrice] = "1000 0";
$DynamicItem[DivineRelic,$DDesc] = "Randomizes the random properties values of an item";
$DynamicItem[DivineRelic,$DCraftType] = "DIVINE";
$DynamicItem[DivineRelic,$DItemType] = "5 Relic";
DynamicItem::CheckItemCreate("DivineRelic",999);

// REGRET RELIC
$DynamicItem[RegretRelic,$DName] = "Regret Relic";
$DynamicItem[RegretRelic,$DIco] = "ico_regretrelic.bmp";
$DynamicItem[RegretRelic,$DMinMax] = "999 999";
$DynamicItem[RegretRelic,$DWeight] = "1 0";
$DynamicItem[RegretRelic,$DPrice] = "1000 0";
$DynamicItem[RegretRelic,$DDesc] = "This relic lets you reset a skill or passive";
$DynamicItem[RegretRelic,$DCraftType] = "DIVINE";
$DynamicItem[RegretRelic,$DItemType] = "6 Relic";
DynamicItem::CheckItemCreate("RegretRelic",999);

function TestRelics(%id)
{
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999FireStone 10 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999ColdStone 10 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999EnergyStone 10 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999PoisonStone 10 ";
}

echo("__RELICS LOADED");