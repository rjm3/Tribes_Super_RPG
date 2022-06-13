//---------------------------------------------------------------------------------
ItemImageData ESWORDImage
{
	shapeFile  = "ESWORD";
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
ItemData ESWORD
{
	heading = "bWeapons";
	description = "Bastard Sword";
	className = "Weapon";
	shapeFile  = "ESWORD";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = ESWORDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData ETRIDENTImage
{
	shapeFile  = "ETRIDENT";
	mountPoint = 0;

	weaponType = 0; 
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing3;
	sfxActivate = AxeSlash2;
};
ItemData ETRIDENT
{
	heading = "bWeapons";
	description = "ETRIDENT";
	className = "Weapon";
	shapeFile  = "trident";
	hudIcon = "trident";
	shadowDetailMask = 4;
	imageType = ETRIDENTImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData EKNIFEImage
{
	shapeFile  = "EKNIFE";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing1;
	sfxActivate = AxeSlash2;
};
ItemData EKNIFE
{
	heading = "bWeapons";
	description = "EKNIFE";
	className = "Weapon";
	shapeFile  = "EKNIFE";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = EKNIFEImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData EMACEImage
{
	shapeFile  = "EMACE";
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
ItemData EMACE
{
	heading = "bWeapons";
	description = "EMACE";
	className = "Weapon";
	shapeFile  = "EMACE";
	hudIcon = "mace";
	shadowDetailMask = 4;
	imageType = EMACEImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData EWANDImage
{
	shapeFile  = "EWAND";
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
ItemData EWAND
{
	heading = "bWeapons";
	description = "EWAND";
	className = "Weapon";
	shapeFile  = "EWAND";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = EWANDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData ESTAFFImage
{
	shapeFile  = "ESTAFF";
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
ItemData ESTAFF
{
	heading = "bWeapons";
	description = "ESTAFF";
	className = "Weapon";
	shapeFile  = "ESTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = ESTAFFImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData ECROSSBOWImage
{
	shapeFile = "ECROSSBOW";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 2;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 0;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData ECROSSBOW
{
	description = "ECROSSBOW";
	className = "Weapon";
	shapeFile = "ECROSSBOW";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = ECROSSBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData EBOWImage
{
	shapeFile = "EBOW";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	ammoType = "";
	projectileType = NoProjectile;
	accuFire = false;
	reloadTime = 0;
	fireTime = 1;

	lightType = 3;  // Weapon Fire
	lightRadius = 3;
	lightTime = 0;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData EBOW
{
	description = "EBOW";
	className = "Weapon";
	shapeFile = "EBOW";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = EBOWImage;
	price = 0;
	showWeaponBar = true;
};

//=====================================================================================================================================================================

function ESWORDImage::onFire(%player, %slot) { Player::WeaponAttack(Player::getClient(%player)); }
function ETRIDENTImage::onFire(%player, %slot) { Player::WeaponAttack(Player::getClient(%player)); }
function EKNIFEImage::onFire(%player, %slot) { Player::WeaponAttack(Player::getClient(%player)); }
function EMACEImage::onFire(%player, %slot) { Player::WeaponAttack(Player::getClient(%player)); }
function EWANDImage::onFire(%player, %slot) { Player::WeaponAttack(Player::getClient(%player)); }
function ESTAFFImage::onFire(%player, %slot) { Player::WeaponAttack(Player::getClient(%player)); }
function ECROSSBOWImage::onFire(%player, %slot) { Player::WeaponAttack(Player::getClient(%player),-1,True,Bolt); }
function EBOWImage::onFire(%player, %slot) { Player::WeaponAttack(Player::getClient(%player),-1,True,Arrow); }
