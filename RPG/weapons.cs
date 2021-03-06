$fireTimeDelay = 0.1;

//****************************************************************************************************

function GenerateAllWeaponCosts()
{
	return true;
}

//****************************************************************************************************

function MeleeAttack(%player, %length, %weapon)
{
	return true;
}

function ProjectileAttack(%clientId, %weapon, %vel)
{
	return true;
}

function HatchetSwing(%player, %length, %weapon)
{
	return true;
}

function PickAxeSwing(%player, %length, %weapon)
{
	return true;
}

function PostAttack(%clientId, %weapon)
{
	return true;
}

function DoRandomMining(%clientId, %crystal)
{
	return true;
}

function GetRange(%weapon)
{
	return true;
}

function GetDelay(%weapon)
{
	return true;
}

function GenerateItemCost(%item)
{
	return true;
}

//==================================================================================================================
ItemData BasicArrow
{
	description = "Basic Arrow";
	className = "Projectile";
	shapeFile = "tracer";
	heading = "xAmmunition";
	shadowDetailMask = 4;
	price = 0;
};
ItemData BasicBolt
{
	description = "Basic Bolt";
	className = "Projectile";
	shapeFile = "bullet";
	heading = "xAmmunition";
	shadowDetailMask = 4;
	price = 0;
};

//==================================================================================================================
ItemImageData KnifeImage
{
	shapeFile  = "dagger";
	mountPoint = 0;
	mountRotation = {0, 0, 2};

	weaponType = 0;
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = AxeSlash2;
};
ItemData Knife
{
	heading = "bWeapons";
	description = "Knife";
	className = "Weapon";
	shapeFile  = "dagger";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = KnifeImage;
	price = 0;
	showWeaponBar = true;
};
function KnifeImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
//==================================================================================================================
ItemImageData DaggerImage
{
	shapeFile  = "dagger";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = AxeSlash2;
};
ItemData Dagger
{
	heading = "bWeapons";
	description = "Dagger";
	className = "Weapon";
	shapeFile  = "dagger";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = DaggerImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData GladiusImage
{
	shapeFile  = "sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData Gladius
{
	heading = "bWeapons";
	description = "Gladius";
	className = "Weapon";
	shapeFile  = "sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = GladiusImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData ShortswordImage
{
	shapeFile  = "short_sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing2;
	sfxActivate = AxeSlash2;
};
ItemData Shortsword
{
	heading = "bWeapons";
	description = "Short Sword";
	className = "Weapon";
	shapeFile  = "short_sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = ShortswordImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData BroadswordImage
{
	shapeFile  = "sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData Broadsword
{
	heading = "bWeapons";
	description = "Broad Sword";
	className = "Weapon";
	shapeFile  = "sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = BroadswordImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData LongswordImage
{
	shapeFile  = "long_sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData Longsword
{
	heading = "bWeapons";
	description = "Long Sword";
	className = "Weapon";
	shapeFile  = "long_sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = LongswordImage;
	price = 0;
	showWeaponBar = true;
};
function LongswordImage::onFire(%player, %slot)
{
	MeleeAttack(%player, GetRange(Longsword), Longsword);
}
//==================================================================================================================
ItemImageData BastardswordImage
{
	shapeFile  = "sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData Bastardsword
{
	heading = "bWeapons";
	description = "Bastard Sword";
	className = "Weapon";
	shapeFile  = "sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = BastardswordImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData RapierImage
{
	shapeFile  = "katana";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData Rapier
{
	heading = "bWeapons";
	description = "Rapier";
	className = "Weapon";
	shapeFile  = "katana";
	hudIcon = "katana";
	shadowDetailMask = 4;
	imageType = RapierImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData ClaymoreImage
{
	shapeFile  = "sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData Claymore
{
	heading = "bWeapons";
	description = "Claymore";
	className = "Weapon";
	shapeFile  = "sword";
	hudIcon = "katana";
	shadowDetailMask = 4;
	imageType = ClaymoreImage;
	price = 0;
	showWeaponBar = true;
};
function ClaymoreImage::onFire(%player, %slot) { Player::SetupWeaponAttack(0.5,Player::getClient(%player)); }
//==================================================================================================================
ItemImageData HatchetImage
{
	shapeFile  = "hatchet";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = AxeSlash2;
};
ItemData Hatchet
{
	heading = "bWeapons";
	description = "Hatchet";
	className = "Weapon";
	shapeFile  = "hatchet";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = HatchetImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData WarAxeImage
{
	shapeFile  = "axe";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData WarAxe
{
	heading = "bWeapons";
	description = "War Axe";
	className = "Weapon";
	shapeFile  = "axe";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = WarAxeImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData PickAxeImage
{
	shapeFile = "Pick";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = CrossbowSwitch1;
};
ItemData PickAxe
{
	heading = "bWeapons";
	description = "Pick Axe";
	className = "Weapon";
	shapeFile = "Pick";
	hudIcon = "pick";
	shadowDetailMask = 4;
	imageType = PickAxeImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData HammerPickImage
{
	shapeFile = "Pick";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = CrossbowSwitch1;
};
ItemData HammerPick
{
	heading = "bWeapons";
	description = "Hammer Pick";
	className = "Weapon";
	shapeFile = "Pick";
	hudIcon = "pick";
	shadowDetailMask = 4;
	imageType = HammerPickImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData BattleAxeImage
{
	shapeFile  = "BattleAxe";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing7;
	sfxActivate = AxeSlash2;
};
ItemData BattleAxe
{
	heading = "bWeapons";
	description = "Battle Axe";
	className = "Weapon";
	shapeFile  = "BattleAxe";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = BattleAxeImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData HalberdImage
{
	shapeFile  = "sword";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing7;
	sfxActivate = AxeSlash2;
};
ItemData Halberd
{
	heading = "bWeapons";
	description = "Halberd";
	className = "Weapon";
	shapeFile  = "sword";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = HalberdImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData SpearImage
{
	shapeFile  = "spear";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData Spear
{
	heading = "bWeapons";
	description = "Spear";
	className = "Weapon";
	shapeFile  = "spear";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = SpearImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData AwlPikeImage
{
	shapeFile  = "spear";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData AwlPike
{
	heading = "bWeapons";
	description = "Awl Pike";
	className = "Weapon";
	shapeFile  = "spear";
	hudIcon = "trident";
	shadowDetailMask = 4;
	imageType = AwlPikeImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData TridentImage
{
	shapeFile  = "trident";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData Trident
{
	heading = "bWeapons";
	description = "Trident";
	className = "Weapon";
	shapeFile  = "trident";
	hudIcon = "trident";
	shadowDetailMask = 4;
	imageType = TridentImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData ClubImage
{
	shapeFile  = "mace";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData Club
{
	heading = "bWeapons";
	description = "Club";
	className = "Weapon";
	shapeFile  = "mace";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = ClubImage;
	price = 0;
	showWeaponBar = true;
};
function ClubImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
//==================================================================================================================
ItemImageData SpikedClubImage
{
	shapeFile  = "mace";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData SpikedClub
{
	heading = "bWeapons";
	description = "Spiked Club";
	className = "Weapon";
	shapeFile  = "mace";
	hudIcon = "sclub";
	shadowDetailMask = 4;
	imageType = SpikedClubImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData MaceImage
{
	shapeFile  = "mace";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData Mace
{
	heading = "bWeapons";
	description = "Mace";
	className = "Weapon";
	shapeFile  = "mace";
	hudIcon = "mace";
	shadowDetailMask = 4;
	imageType = MaceImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData WarHammerImage
{
	shapeFile  = "hammer";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData WarHammer
{
	heading = "bWeapons";
	description = "War Hammer";
	className = "Weapon";
	shapeFile  = "hammer";
	hudIcon = "hammer";
	shadowDetailMask = 4;
	imageType = WarHammerImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData WarMaulImage
{
	shapeFile  = "hammer";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing7;
	sfxActivate = AxeSlash2;
};
ItemData WarMaul
{
	heading = "bWeapons";
	description = "War Maul";
	className = "Weapon";
	shapeFile  = "hammer";
	hudIcon = "hammer";
	shadowDetailMask = 4;
	imageType = WarMaulImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData QuarterStaffImage
{
	shapeFile  = "quarterstaff";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 0.5;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData QuarterStaff
{
	heading = "bWeapons";
	description = "Quarter Staff";
	className = "Weapon";
	shapeFile  = "quarterstaff";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = QuarterStaffImage;
	price = 0;
	showWeaponBar = true;
};
function QuarterStaffImage::onFire(%player, %slot) { Player::SetupWeaponAttack(0.5,Player::getClient(%player)); }
//==================================================================================================================
ItemImageData LongStaffImage
{
	shapeFile  = "longstaff";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData LongStaff
{
	heading = "bWeapons";
	description = "Long Staff";
	className = "Weapon";
	shapeFile  = "longstaff";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = LongStaffImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData JusticeStaffImage
{
	shapeFile  = "longstaff";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing4;
	sfxActivate = AxeSlash2;
};
ItemData JusticeStaff
{
	heading = "bWeapons";
	description = "Justice Staff";
	className = "Weapon";
	shapeFile  = "quarterstaff";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = JusticeStaffImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData BoneClubImage
{
	shapeFile  = "mace";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData BoneClub
{
	heading = "bWeapons";
	description = "Bone Club";
	className = "Weapon";
	shapeFile  = "mace";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = BoneClubImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData SpikedBoneClubImage
{
	shapeFile  = "mace";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData SpikedBoneClub
{
	heading = "bWeapons";
	description = "Spiked Bone Club";
	className = "Weapon";
	shapeFile  = "mace";
	hudIcon = "sclub";
	shadowDetailMask = 4;
	imageType = SpikedBoneClubImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData ShortBowImage
{
	shapeFile = "longbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 1;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData ShortBow
{
	description = "Short Bow";
	className = "Weapon";
	shapeFile = "longbow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = ShortBowImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData LongBowImage
{
	shapeFile = "longbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 1;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData LongBow
{
	description = "Long Bow";
	className = "Weapon";
	shapeFile = "longbow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = LongBowImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData ElvenBowImage
{
	shapeFile = "longbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 1;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData ElvenBow
{
	description = "Elven Bow";
	className = "Weapon";
	shapeFile = "longbow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = ElvenBowImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData CompositeBowImage
{
	shapeFile = "comp_bow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 1;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData CompositeBow
{
	description = "Composite Bow";
	className = "Weapon";
	shapeFile = "comp_bow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = CompositeBowImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData AeolusWingImage
{
	shapeFile = "comp_bow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 1;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData AeolusWing
{
	description = "Aeolus's Wing";
	className = "Weapon";
	shapeFile = "comp_bow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = AeolusWingImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData LightCrossbowImage
{
	shapeFile = "crossbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 2;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData LightCrossbow
{
	description = "Light Crossbow";
	className = "Weapon";
	shapeFile = "crossbow";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = LightCrossbowImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData HeavyCrossbowImage
{
	shapeFile = "crossbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 2;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData HeavyCrossbow
{
	description = "Heavy Crossbow";
	className = "Weapon";
	shapeFile = "crossbow";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = HeavyCrossbowImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData RepeatingCrossbowImage
{
	shapeFile = "crossbow";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 2;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 1;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData RepeatingCrossbow
{
	description = "Repeating Crossbow";
	className = "Weapon";
	shapeFile = "crossbow";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RepeatingCrossbowImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================
ItemImageData CastingBladeImage
{
	shapeFile  = "dagger";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = GetDelay(CastingBlade);
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = NoSound;
	sfxActivate = NoSound;
};
ItemData CastingBlade
{
	heading = "bWeapons";
	description = "Casting Blade";
	className = "Weapon";
	shapeFile  = "dagger";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = CastingBladeImage;
	price = 0;
	showWeaponBar = true;
};
//==================================================================================================================





exec(weapons_enemy);
exec(weapons_test);
exec(shields_test);
exec(aura);







