// SPAWNSYSTEM MOBS

// LOUDOUTS
$LoadoutSlashing = 	"SLASHING 1.0 PRIMALMAGIC 0.5 ENDURANCE 0.7 ARMOR 0.7 EVADEMELEE 0.3 MAXHP 0.5 DODGING 0.3 PHYSBASE 0.5 PHYSICALDAMAGE 0.7 PERCEPTION 0.25 ARMORPEN 0.7 SPELLRESISTANCE 0.1";
$LoadoutPiercing = 	"PIERCING 1.0 DARKMAGIC 0.5 CRITDAMAGE 0.7 CRITCHANCE 0.7 EVASION 1.0 DODGING 0.7 EVADEMELEE 0.7 ENDURANCE 0.5 MAXHP 0.3 PHYSBASE 0.5 PHYSICALDAMAGE 0.7 ARMOR 0.1 PERCEPTION 0.5 SPELLRESISTANCE 0.25";
$LoadoutBludgeoning = 	"BLUDGEONING 1.0 PRIMALMAGIC 0.5 ENDURANCE 0.7 ARMOR 1.0 EVADEMELEE 0.5 MAXHP 0.8 DODGING 0.5 PHYSBASE 0.4 PHYSICALDAMAGE 0.4 PERCEPTION 0.25 SPELLRESISTANCE 0.1";
$LoadoutArchery = 	"ARCHERY 1.0 DARKMAGIC 0.5 EVASION 0.5 DODGING 0.5 EVADEMELEE 0.5 ENDURANCE 0.5 MAXHP 0.3 RANGEDBASE 0.5 PHYSICALDAMAGE 0.5 ARMOR 0.3 PERCEPTION 0.25 ARMORPEN 0.7 SPELLRESISTANCE 0.1";
$LoadoutCrossbow = 	"ARCHERY 1.0 DARKMAGIC 0.5 EVASION 0.5 DODGING 0.5 EVADEMELEE 0.5 ENDURANCE 0.5 MAXHP 0.3 RANGEDBASE 0.5 PHYSICALDAMAGE 0.5 ARMOR 0.3 PERCEPTION 0.5 CRITCHANCE 0.7 CRITDAMAGE 0.7 SPELLREISTANCE 0.1";
$LoadoutSorcery = 	"SORCERY 1.0 ALLRESIST 0.5 ENDURANCE 0.5 DODGING 0.1 ENERGY 1.0 SPELLBASE 0.5 MAGICDAMAGE 0.7 EVADEMELEE 0.1 PERCEPTION 0.1 CASTINIT 0.25 COOLDOWN 0.25 MAGICPEN 0.7 SPELLRESISTANCE 1.0";
$LoadoutWand = 		"SORCERY 1.0 ALLRESIST 0.5 ENDURANCE 0.5 DODGING 0.1 ENERGY 1.0 SPELLBASE 0.5 MAGICDAMAGE 0.7 EVADEMELEE 0.1 PERCEPTION 0.1 CASTINIT 0.25 COOLDOWN 0.25 SPCRITCHANCE 0.5 SPCRITDAMAGE 0.5 SPELLRESISTANCE 1.0";
$LoadoutDark =		"DARKMAGIC 1.0 ALLRESIST 0.5 ENDURANCE 0.5 DODGING 0.5 ENERGY 1.0 SPELLBASE 0.5 MAGICDAMAGE 0.7 EVADEMELEE 0.5 PERCEPTION 0.5 CASTINIT 0.75 COOLDOWN 0.75 SPCRITCHANCE 0.75 SPCRITDAMAGE 0.75 SPELLRESISTANCE 0.5";

// MOBS
//=====================================================================
// GOBLIN
$CRUMONSTER["Goblin",$CEMobs] = "Berserker Thief Sniper Wizard Basher";
$CRUMONSTER["Goblin",$CERace] = "Beast";
$CRUMONSTER["Goblin",$CEArmor] = "GoblinArmor";
$CRUMONSTER["Goblin",$CERaceSub] = "Goblin";

$CRUMONSTER["GoblinBerserker",$CELoadout] 	= $LoadoutSlashing;
$CRUMONSTER["GoblinBerserker",$CEElite] 	= "Eltor GoblinArmor NA";
$CRUMONSTER["GoblinBerserker",$CEBoss]		= "Kingen OgreArmor rpgorc";
$CRUMONSTER["GoblinBerserker",$CEWeapon]	= "EnemySword";
$CRUMONSTER["GoblinBerserker",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["GoblinBasher",$CELoadout] 		= $LoadoutBludgeoning;
$CRUMONSTER["GoblinBasher",$CEElite] 		= "Kutag GoblinArmor NA";
$CRUMONSTER["GoblinBasher",$CEBoss]		= "Kelkal OgreArmor rpgorc";
$CRUMONSTER["GoblinBasher",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["GoblinThief",$CELoadout] 		= $LoadoutPiercing;
$CRUMONSTER["GoblinThief",$CEElite] 		= "Xan GoblinArmor NA";
$CRUMONSTER["GoblinThief",$CEBoss]		= "Dub OgreArmor rpgorc";
$CRUMONSTER["GoblinThief",$CEWeapon]		= "EnemyKnife";
$CRUMONSTER["GoblinThief",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["GoblinSniper",$CELoadout] 		= $LoadoutArchery;
$CRUMONSTER["GoblinSniper",$CEElite] 		= "Sundossa GoblinArmor NA";
$CRUMONSTER["GoblinSniper",$CEBoss]		= "Boldossa OgreArmor rpgorc";
$CRUMONSTER["GoblinSniper",$CERanged]		= 1;
$CRUMONSTER["GoblinSniper",$CEWeapon]		= "EnemyCrossbow";
$CRUMONSTER["GoblinSniper",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["GoblinWizard",$CELoadout] 		= $LoadoutSorcery;
$CRUMONSTER["GoblinWizard",$CEElite] 		= "Dreymang GoblinArmor NA";
$CRUMONSTER["GoblinWizard",$CEBoss]		= "Dyngarad OgreArmor rpgorc";
$CRUMONSTER["GoblinWizard",$CEMage] 		= "FIRE 1";

//=====================================================================
// ORC
$CRUMONSTER["Orc",$CEMobs] = "Berserker Smasher Slayer Archer Warlock";
$CRUMONSTER["Orc",$CERace] = "Beast";
$CRUMONSTER["Orc",$CEArmor] = "TravellerArmor";
$CRUMONSTER["Orc",$CERaceSub] = "Orc";
$CRUMONSTER["Orc",$CESkin] = "rpgorc";

$CRUMONSTER["OrcBerserker",$CELoadout] 		= $LoadoutSlashing;
$CRUMONSTER["OrcBerserker",$CEElite] 		= "Orler OrcArmor rpgorc";
$CRUMONSTER["OrcBerserker",$CEBoss]		= "Swackon OgreArmor rpgorc";
$CRUMONSTER["OrcBerserker",$CEWeapon]		= "EnemySword";
$CRUMONSTER["OrcBerserker",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["OrcSmasher",$CELoadout] 		= $LoadoutBludgeoning;
$CRUMONSTER["OrcSmasher",$CEElite] 		= "Raztorn OrcArmor rpgorc";
$CRUMONSTER["OrcSmasher",$CEBoss]		= "Rakkas OgreArmor rpgorc";
$CRUMONSTER["OrcSmasher",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["OrcSlayer",$CELoadout] 		= $LoadoutPiercing;
$CRUMONSTER["OrcSlayer",$CEElite] 		= "Owaro OrcArmor rpgorc";
$CRUMONSTER["OrcSlayer",$CEBoss]		= "Qualusk OgreArmor rpgorc";
$CRUMONSTER["OrcSlayer",$CEWeapon]		= "EnemyKnife";
$CRUMONSTER["OrcSlayer",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["OrcArcher",$CELoadout] 		= $LoadoutArchery;
$CRUMONSTER["OrcArcher",$CEElite] 		= "Rodarum OrcArmor rpgorc";
$CRUMONSTER["OrcArcher",$CEBoss]		= "Rhabel OgreArmor rpgorc";
$CRUMONSTER["OrcArcher",$CERanged]		= 1;
$CRUMONSTER["OrcArcher",$CEWeapon]		= "EnemyBow";
$CRUMONSTER["OrcArcher",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["OrcWarlock",$CELoadout] 		= $LoadoutSorcery;
$CRUMONSTER["OrcWarlock",$CEElite] 		= "Semurod MaleHumanRobedArmor7 orcrobeblack";
$CRUMONSTER["OrcWarlock",$CEBoss]		= "Alkemiss OgreArmor rpgorc";
$CRUMONSTER["OrcWarlock",$CEMage] 		= "PROJECTILE 1";		

//=====================================================================
// GNOLL
$CRUMONSTER["Gnoll",$CEMobs] = "Pup Guardian Scavenger Hunter Shaman";
$CRUMONSTER["Gnoll",$CERace] = "Beast";
$CRUMONSTER["Gnoll",$CEArmor] = "GnollArmor";

$CRUMONSTER["GnollPup",$CELoadout] 		= $LoadoutSlashing;
$CRUMONSTER["GnollPup",$CEElite] 		= "Ghatwar GnollArmor NA";
$CRUMONSTER["GnollPup",$CEBoss]			= "Dyndar GnollRedArmor NA";
$CRUMONSTER["GnollPup",$CEWeapon]		= "EnemySword";
$CRUMONSTER["GnollPup",$CEMage]			= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["GnollGuardian",$CELoadout] 	= $LoadoutBludgeoning;
$CRUMONSTER["GnollGuardian",$CEElite] 		= "Enrod GnollArmor NA";
$CRUMONSTER["GnollGuardian",$CEBoss]		= "Ehchil GnollRedArmor NA";
$CRUMONSTER["GnollGuardian",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["GnollScavenger",$CELoadout] 	= $LoadoutPiercing;
$CRUMONSTER["GnollScavenger",$CEElite] 		= "Nos GnollArmor NA";
$CRUMONSTER["GnollScavenger",$CEBoss]		= "Rismor GnollRedArmor NA";
$CRUMONSTER["GnollScavenger",$CEWeapon]		= "EnemyKnife";
$CRUMONSTER["GnollScavenger",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["GnollHunter",$CELoadout] 		= $LoadoutArchery;
$CRUMONSTER["GnollHunter",$CEElite] 		= "Athdar GnollArmor NA";
$CRUMONSTER["GnollHunter",$CEBoss]		= "Honath GnollRedArmor NA";
$CRUMONSTER["GnollHunter",$CERanged]		= 1;
$CRUMONSTER["GnollHunter",$CEWeapon]		= "EnemyBow";
$CRUMONSTER["GnollHunter",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["GnollShaman",$CELoadout] 		= $LoadoutSorcery;
$CRUMONSTER["GnollShaman",$CEElite] 		= "Kaleld GnollArmor NA";
$CRUMONSTER["GnollShaman",$CEBoss]		= "Reis GnollRedArmor NA";
$CRUMONSTER["GnollShaman",$CEMage] 		= "ENERGY 1";

//=====================================================================
// CULTIST
$CRUMONSTER["Cultist",$CEMobs] = "Fiend Devotee Fanatic Crazy Insane";
$CRUMONSTER["Cultist",$CERace] = "Demon";
$CRUMONSTER["Cultist",$CEArmor] = "MaleHumanRobedArmor7";
$CRUMONSTER["Cultist",$CESkin] = "delfrobeblack";

$CRUMONSTER["CultistFiend",$CELoadout] 		= $LoadoutPiercing;
$CRUMONSTER["CultistFiend",$CEElite] 		= "Naus MaleHumanRobedArmor7 delfrobeblack";
$CRUMONSTER["CultistFiend",$CEBoss]		= "Nuis MaleHumanRobedArmor7 delfrobered";
$CRUMONSTER["CultistFiend",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["CultistDevotee",$CELoadout] 	= $LoadoutSorcery;
$CRUMONSTER["CultistDevotee",$CEElite] 		= "Tiad MaleHumanRobedArmor7 delfrobeblack";
$CRUMONSTER["CultistDevotee",$CEBoss]		= "Isad MaleHumanRobedArmor7 delfrobewhite";
$CRUMONSTER["CultistDevotee",$CEMage] 		= "FIRE 1";

$CRUMONSTER["CultistFanatic",$CELoadout] 	= $LoadoutArchery;
$CRUMONSTER["CultistFanatic",$CEElite] 		= "Thealt MaleHumanRobedArmor7 delfrobeblack";
$CRUMONSTER["CultistFanatic",$CEBoss]		= "Nosh MaleHumanRobedArmor7 delfrobered";
$CRUMONSTER["CultistFanatic",$CERanged]		= 1;
$CRUMONSTER["CultistFanatic",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["CultistCrazy",$CELoadout] 		= $LoadoutSlashing;
$CRUMONSTER["CultistCrazy",$CEElite] 		= "Warghai MaleHumanRobedArmor7 delfrobeblack";
$CRUMONSTER["CultistCrazy",$CEBoss]		= "Kelusk MaleHumanRobedArmor7 delfrobered";
$CRUMONSTER["CultistCrazy",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["CultistInsane",$CELoadout] 	= $LoadoutBludgeoning;
$CRUMONSTER["CultistInsane",$CEElite] 		= "Onum MaleHumanRobedArmor7 delfrobeblack";
$CRUMONSTER["CultistInsane",$CEBoss]		= "Omada MaleHumanRobedArmor7 delfrobered";
$CRUMONSTER["CultistInsane",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

//=====================================================================
// MINER
$CRUMONSTER["Miner",$CEMobs] 			= "Magus Cuthroat Criminal Thug Sharpshot";
$CRUMONSTER["Miner",$CERace] 			= "Beast";
$CRUMONSTER["Miner",$CEArmor] 			= "MaleHumanArmor7";
$CRUMONSTER["Miner",$CESkin] 			= "rpgvelvet";

$CRUMONSTER["MinerCriminal",$CELoadout] 	= $LoadoutSlashing;
$CRUMONSTER["MinerCriminal",$CEElite] 		= "Turkhal MaleHumanArmor7 rpgvelvet";
$CRUMONSTER["MinerCriminal",$CEBoss]		= "Cerwar MaleHumanArmor7 rpgsilk";
$CRUMONSTER["MinerCriminal",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["MinerThug",$CELoadout] 		= $LoadoutBludgeoning;
$CRUMONSTER["MinerThug",$CEElite] 		= "Woz MaleHumanArmor7 rpgvelvet";
$CRUMONSTER["MinerThug",$CEBoss]		= "Voziden MaleHumanArmor7 rpgsilk";
$CRUMONSTER["MinerThug",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["MinerSharpshot",$CELoadout] 	= $LoadoutCrossbow;
$CRUMONSTER["MinerSharpshot",$CEElite] 		= "Vunara FemalHumanArmor7 rpgvelvet";
$CRUMONSTER["MinerSharpshot",$CEBoss]		= "Gorebella FemaleHumanArmor7 rpgsilk";
$CRUMONSTER["MinerSharpshot",$CEWeapon]		= "EnemyCrossbow";
$CRUMONSTER["MinerSharpshot",$CERanged]		= 1;
$CRUMONSTER["MinerSharpshot",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["MinerCuthroat",$CELoadout] 	= $LoadoutPiercing;
$CRUMONSTER["MinerCuthroat",$CEElite] 		= "Izmag FemaleHumanArmor7 rpgvelvet";
$CRUMONSTER["MinerCuthroat",$CEBoss]		= "Mosia FemaleHumanArmor7 rpgsilk";
$CRUMONSTER["MinerCuthroat",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["MinerMagus",$CELoadout] 		= $LoadoutSorcery;
$CRUMONSTER["MinerMagus",$CEElite] 		= "Enthcera FemaleHumanRobedArmor7 robeblack";
$CRUMONSTER["MinerMagus",$CEBoss]		= "Loren FemaleHumanRobedArmor7 robewhite";
$CRUMONSTER["MinerMagus",$CEMage] 		= "FIRE 1";

//=====================================================================
// BANDIT
$CRUMONSTER["Bandit",$CEMobs] = "Spellthief Blackjack Sharpshot Raider Thug";
$CRUMONSTER["Bandit",$CERace] = "Beast";
$CRUMONSTER["Bandit",$CEArmor] = "MaleHumanArmor7";
$CRUMONSTER["Bandit",$CESkin] = "rpgpadded";

$CRUMONSTER["BanditBlackjack",$CELoadout] 	= $LoadoutPiercing;
$CRUMONSTER["BanditBlackjack",$CEElite] 	= "Eceri MaleHumanArmor7 orcrpgbandedmail";
$CRUMONSTER["BanditBlackjack",$CEBoss]		= "Erdix MaleHumanArmor7 orcrpgspirit";
$CRUMONSTER["BanditBlackjack",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["BanditSpellthief",$CELoadout] 	= $LoadoutDark;
$CRUMONSTER["BanditSpellthief",$CEElite] 	= "Elera FemaleHumanRobedArmor7 orcrobegray";
$CRUMONSTER["BanditSpellthief",$CEBoss]		= "Othera FemaleHumanRobedArmor7 orcrobeblack";
$CRUMONSTER["BanditSpellthief",$CEMage] 	= "MELEE 1";

$CRUMONSTER["BanditSharpshot",$CELoadout] 	= $LoadoutCrossbow;
$CRUMONSTER["BanditSharpshot",$CEElite] 	= "Archev FemaleHumanArmor7 orcrpgbandedmail";
$CRUMONSTER["BanditSharpshot",$CEBoss]		= "Ardxiss FemaleHumanArmor7 orcrpgspirit";
$CRUMONSTER["BanditSharpshot",$CERanged]	= 1;
$CRUMONSTER["BanditSharpshot",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["BanditRaider",$CELoadout] 		= $LoadoutSlashing;
$CRUMONSTER["BanditRaider",$CEElite] 		= "Craen MaleHumanArmor7 orcrpgbandedmail";
$CRUMONSTER["BanditRaider",$CEBoss]		= "Hytor MaleHumanArmor7 orcrpgspirit";
$CRUMONSTER["BanditRaider",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["BanditThug",$CELoadout] 		= $LoadoutBludgeoning;
$CRUMONSTER["BanditThug",$CEElite] 		= "Gurrat MaleHumanArmor7 orcrpgbandedmail";
$CRUMONSTER["BanditThug",$CEBoss]		= "Underkil MaleHumanArmor7 orcrpgspirit";
$CRUMONSTER["BanditThug",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

//=====================================================================
// ZOMBIE
$CRUMONSTER["Zombie",$CEMobs] = "Thrasher Crusher Slicer Ballista Shaman";
$CRUMONSTER["Zombie",$CERace] = "Undead";
$CRUMONSTER["Zombie",$CEArmor] = "ZombieArmor";

$CRUMONSTER["ZombieSlicer",$CELoadout] 		= $LoadoutPiercing;
$CRUMONSTER["ZombieSlicer",$CEElite] 		= "Crad ZombieArmor NA";
$CRUMONSTER["ZombieSlicer",$CEBoss]		= "Dulor ZombieArmor NA";
$CRUMONSTER["ZombieSlicer",$CEMage] 		= "";
$CRUMONSTER["ZombieSlicer",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["ZombieShaman",$CELoadout] 		= $LoadoutSorcery;
$CRUMONSTER["ZombieShaman",$CEElite] 		= "Eane ZombieArmor NA";
$CRUMONSTER["ZombieShaman",$CEBoss]		= "Lorther ZombieArmor NA";
$CRUMONSTER["ZombieShaman",$CEMage] 		= "COLD 1";

$CRUMONSTER["ZombieBallista",$CELoadout] 	= $LoadoutArchery;
$CRUMONSTER["ZombieBallista",$CEElite] 		= "Hunut ZombieArmor NA";
$CRUMONSTER["ZombieBallista",$CEBoss]		= "Onack ZombieArmor NA";
$CRUMONSTER["ZombieBallista",$CERanged]		= 1;
$CRUMONSTER["ZombieBallista",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["ZombieThrasher",$CELoadout] 	= $LoadoutSlashing;
$CRUMONSTER["ZombieThrasher",$CEElite] 		= "Belwar ZombieArmor NA";
$CRUMONSTER["ZombieThrasher",$CEBoss]		= "Warad ZombieArmor NA";
$CRUMONSTER["ZombieThrasher",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["ZombieCrusher",$CELoadout] 	= $LoadoutBludgeoning;
$CRUMONSTER["ZombieCrusher",$CEElite] 		= "Rakash ZombieArmor NA";
$CRUMONSTER["ZombieCrusher",$CEBoss]		= "Rakban ZombieArmor NA";
$CRUMONSTER["ZombieCrusher",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

//=====================================================================
// SKELETON
$CRUMONSTER["Skeleton",$CEMobs] = "Thrasher Mauler Slicer Archer Necromancer";
$CRUMONSTER["Skeleton",$CERace] = "Undead";
$CRUMONSTER["Skeleton",$CEArmor] = "UndeadArmor";

$CRUMONSTER["SkeletonSlicer",$CELoadout] 	= $LoadoutPiercing;
$CRUMONSTER["SkeletonSlicer",$CEElite] 		= "Rodel UndeadArmor NA";
$CRUMONSTER["SkeletonSlicer",$CEBoss]		= "Torakel UndeadRedArmor NA";
$CRUMONSTER["SkeletonSlicer",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["SkeletonNecromancer",$CELoadout] 	= $LoadoutDark;
$CRUMONSTER["SkeletonNecromancer",$CEElite] 	= "Belen UndeadArmor NA";
$CRUMONSTER["SkeletonNecromancer",$CEBoss]	= "Lelon UndeadRedArmor NA";
$CRUMONSTER["SkeletonNecromancer",$CEMage] 	= "POISON 1";
$CRUMONSTER["SkeletonNecromancer",$CEWeapon]	= "EnemyWand";

$CRUMONSTER["SkeletonArcher",$CELoadout] 	= $LoadoutArchery;
$CRUMONSTER["SkeletonArcher",$CEElite] 		= "Govad UndeadArmor NA";
$CRUMONSTER["SkeletonArcher",$CEBoss]		= "Taneron UndeadRedArmor NA";
$CRUMONSTER["SkeletonArcher",$CERanged]		= 1;
$CRUMONSTER["SkeletonArcher",$CEWeapon]		= "EnemyBow";
$CRUMONSTER["SkeletonArcher",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["SkeletonThrasher",$CELoadout] 	= $LoadoutSlashing;
$CRUMONSTER["SkeletonThrasher",$CEElite] 	= "Ruig UndeadArmor NA";
$CRUMONSTER["SkeletonThrasher",$CEBoss]		= "Draq UndeadRedArmor NA";
$CRUMONSTER["SkeletonThrasher",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["SkeletonMauler",$CELoadout] 	= $LoadoutBludgeoning;
$CRUMONSTER["SkeletonMauler",$CEElite] 		= "Gragar UndeadArmor NA";
$CRUMONSTER["SkeletonMauler",$CEBoss]		= "Hok UndeadRedArmor NA";
$CRUMONSTER["SkeletonMauler",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

//=====================================================================
// MINOTAUR
$CRUMONSTER["Minotaur",$CEMobs] = "Thrasher Mauler Slicer Archer Necromancer";
$CRUMONSTER["Minotaur",$CERace] = "Beast";
$CRUMONSTER["Minotaur",$CEArmor] = "MinotaurArmor";
$CRUMONSTER["Minotaur",$CESkin] = "min";

$CRUMONSTER["MinotaurSlicer",$CELoadout] 	= $LoadoutPiercing;
$CRUMONSTER["MinotaurSlicer",$CEElite] 		= "Deluran MinotaurArmor min";
$CRUMONSTER["MinotaurSlicer",$CEBoss]		= "Turrak MinotaurArmor minred";
$CRUMONSTER["MinotaurSlicer",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["MinotaurNecromancer",$CELoadout] 	= $LoadoutSorcery;
$CRUMONSTER["MinotaurNecromancer",$CEElite] 	= "Delage MinotaurArmor min";
$CRUMONSTER["MinotaurNecromancer",$CEBoss]	= "Vorcer MinotaurArmor minred";
$CRUMONSTER["MinotaurNecromancer",$CEMage] 	= "FIRE 1";

$CRUMONSTER["MinotaurArcher",$CELoadout] 	= $LoadoutArchery;
$CRUMONSTER["MinotaurArcher",$CEElite] 		= "Nisax MinotaurArmor min";
$CRUMONSTER["MinotaurArcher",$CEBoss]		= "Rothtin MinotaurArmor minred";
$CRUMONSTER["MinotaurArcher",$CERanged]		= 1;
$CRUMONSTER["MinotaurArcher",$CEWeapon]		= "EnemyBow";
$CRUMONSTER["MinotaurArcher",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["MinotaurThrasher",$CELoadout] 	= $LoadoutSlashing;
$CRUMONSTER["MinotaurThrasher",$CEElite] 	= "Cerang MinotaurArmor min";
$CRUMONSTER["MinotaurThrasher",$CEBoss]		= "Wormtom MinotaurArmor minred";
$CRUMONSTER["MinotaurThrasher",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["MinotaurMauler",$CELoadout] 	= $LoadoutBludgeoning;
$CRUMONSTER["MinotaurMauler",$CEElite] 		= "Haton MinotaurArmor min";
$CRUMONSTER["MinotaurMauler",$CEBoss]		= "Jolar MinotaurArmor minred";
$CRUMONSTER["MinotaurMauler",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

//=====================================================================
// DEMON
$CRUMONSTER["Demon",$CEMobs] = "Thrasher Mauler Slicer Archer Hexer";
$CRUMONSTER["Demon",$CERace] = "Demon";
$CRUMONSTER["Demon",$CEArmor] = "MinotaurArmor";
$CRUMONSTER["Demon",$CESkin] = "undead";

$CRUMONSTER["DemonSlicer",$CELoadout] 		= $LoadoutPiercing;
$CRUMONSTER["DemonSlicer",$CEElite] 		= "Oro MinotaurArmor undead";
$CRUMONSTER["DemonSlicer",$CEBoss]		= "Ciand MinotaurArmor bluedemon";
$CRUMONSTER["DemonSlicer",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["DemonHexer",$CELoadout] 		= $LoadoutSorcery;
$CRUMONSTER["DemonHexer",$CEElite] 		= "Undod MinotaurArmor undead";
$CRUMONSTER["DemonHexer",$CEBoss]		= "Lod MinotaurArmor bluedemon";
$CRUMONSTER["DemonHexer",$CEMage] 		= "FIRE 1";

$CRUMONSTER["DemonArcher",$CELoadout] 		= $LoadoutArchery;
$CRUMONSTER["DemonArcher",$CEElite] 		= "Dras MinotaurArmor undead";
$CRUMONSTER["DemonArcher",$CEBoss]		= "Eneg MinotaurArmor bluedemon";
$CRUMONSTER["DemonArcher",$CERanged]		= 1;
$CRUMONSTER["DemonArcher",$CEWeapon]		= "EnemyBow";
$CRUMONSTER["DemonArcher",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["DemonThrasher",$CELoadout] 	= $LoadoutSlashing;
$CRUMONSTER["DemonThrasher",$CEElite] 		= "Dalek MinotaurArmor undead";
$CRUMONSTER["DemonThrasher",$CEBoss]		= "Suldynran MinotaurArmor bluedemon";
$CRUMONSTER["DemonThrasher",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["DemonMauler",$CELoadout] 		= $LoadoutBludgeoning;
$CRUMONSTER["DemonMauler",$CEElite] 		= "Hattur MinotaurArmor undead";
$CRUMONSTER["DemonMauler",$CEBoss]		= "Pheradaw MinotaurArmor bluedemon";
$CRUMONSTER["DemonMauler",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

//=====================================================================
// YETI
$CRUMONSTER["Yeti",$CEMobs] = "Thrasher Mauler Slicer Frostbow Icewind";
$CRUMONSTER["Yeti",$CERace] = "Beast";
$CRUMONSTER["Yeti",$CEArmor] = "UberArmor";

$CRUMONSTER["YetiSlicer",$CELoadout] 		= $LoadoutPiercing;
$CRUMONSTER["YetiSlicer",$CEElite] 		= "Cerkin UberArmor NA";
$CRUMONSTER["YetiSlicer",$CEBoss]		= "Cintris UberArmor NA";
$CRUMONSTER["YetiSlicer",$CEMage] 		= "FLASHSTRIKE 10";

$CRUMONSTER["YetiIcewind",$CELoadout] 		= $LoadoutSorcery;
$CRUMONSTER["YetiIcewind",$CEElite] 		= "Moror UberArmor NA";
$CRUMONSTER["YetiIcewind",$CEBoss]		= "Kelendage UberArmor NA";
$CRUMONSTER["YetiIcewind",$CEMage] 		= "COLD 1";

$CRUMONSTER["YetiFrostbow",$CELoadout] 		= $LoadoutArchery;
$CRUMONSTER["YetiFrostbow",$CEElite] 		= "Acknorm UberArmor NA";
$CRUMONSTER["YetiFrostbow",$CEBoss]		= "Arxir UberArmor NA";
$CRUMONSTER["YetiFrostbow",$CERanged]		= 1;
$CRUMONSTER["YetiFrostbow",$CEWeapon]		= "EnemyBow";
$CRUMONSTER["YetiFrostbow",$CEMage]		= "KILLSHOT 20 SNAKEGRASP 20";

$CRUMONSTER["YetiThrasher",$CELoadout] 		= $LoadoutSlashing;
$CRUMONSTER["YetiThrasher",$CEElite] 		= "Drage UberArmor NA";
$CRUMONSTER["YetiThrasher",$CEBoss]		= "Waragar UberArmor NA";
$CRUMONSTER["YetiThrasher",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";

$CRUMONSTER["YetiMauler",$CELoadout] 		= $LoadoutBludgeoning;
$CRUMONSTER["YetiMauler",$CEElite] 		= "Ormad UberArmor NA";
$CRUMONSTER["YetiMauler",$CEBoss]		= "Randrad UberArmor NA";
$CRUMONSTER["YetiMauler",$CEMage]		= "KILLHOOK 20 ARCANETHROW 20";






echo("__SPAWNSYSTEM MOBS LOADED");