function testweapon(%weapon)
{
	player::mountItem(2049,%weapon,0);
}
//==============================================================================================================================================================
ItemImageData RHATCHETImage
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
ItemData RHATCHET
{
	heading = "bWeapons";
	description = "Hatchet";
	className = "Weapon";
	shapeFile  = "hatchet";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = RHATCHETImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RBROADSWORDImage
{
	shapeFile  = "RBROADSWORD";
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
ItemData RBROADSWORD
{
	heading = "bWeapons";
	description = "Broad Sword";
	className = "Weapon";
	shapeFile  = "RBROADSWORD";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RBROADSWORDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RWARAXEImage
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
ItemData RWARAXE
{
	heading = "bWeapons";
	description = "War Axe";
	className = "Weapon";
	shapeFile  = "axe";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = RWARAXEImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RLONGSWORDImage
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
ItemData RLONGSWORD
{
	heading = "bWeapons";
	description = "Long Sword";
	className = "Weapon";
	shapeFile  = "long_sword";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RLONGSWORDImage;
	price = 0;
	showWeaponBar = true;
};

//---------------------------------------------------------------------------------
ItemImageData RBATTLEAXEImage
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
ItemData RBATTLEAXE
{
	heading = "bWeapons";
	description = "Battle Axe";
	className = "Weapon";
	shapeFile  = "BattleAxe";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = RBATTLEAXEImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RBASTARDSWORDImage
{
	shapeFile  = "RBASTARDSWORD";
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
ItemData RBASTARDSWORD
{
	heading = "bWeapons";
	description = "Bastard Sword";
	className = "Weapon";
	shapeFile  = "RBASTARDSWORD";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RBASTARDSWORDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RHALBERDImage
{
	shapeFile  = "RHALBERD";
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
ItemData RHALBERD
{
	heading = "bWeapons";
	description = "Halberd";
	className = "Weapon";
	shapeFile  = "RHALBERD";
	hudIcon = "axe";
	shadowDetailMask = 4;
	imageType = RHALBERDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RCLAYMOREImage
{
	shapeFile  = "RCLAYMORE";
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
ItemData RCLAYMORE
{
	heading = "bWeapons";
	description = "Claymore";
	className = "Weapon";
	shapeFile  = "RCLAYMORE";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RCLAYMOREImage;
	price = 0;
	showWeaponBar = true;
};
//==============================================================================================================================================================
ItemImageData RGIANTSWORDImage
{
	shapeFile  = "RGIANTSWORD";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 3;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData RGIANTSWORD
{
	heading = "bWeapons";
	description = "Giant Sword";
	className = "Weapon";
	shapeFile  = "RGIANTSWORD";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RGIANTSWORDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RFLAMBERGEImage
{
	shapeFile  = "RFLAMBERGE";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 3;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData RFLAMBERGE
{
	heading = "bWeapons";
	description = "Flamberge";
	className = "Weapon";
	shapeFile  = "RFLAMBERGE";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RFLAMBERGEImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RCRYSTALSWORDImage
{
	shapeFile  = "RCRYSTALSWORD";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 3;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData RCRYSTALSWORD
{
	heading = "bWeapons";
	description = "Crystal Sword";
	className = "Weapon";
	shapeFile  = "RCRYSTALSWORD";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RCRYSTALSWORDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RGREATSWORDImage
{
	shapeFile  = "RGREATSWORD";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 3;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData RGREATSWORD
{
	heading = "bWeapons";
	description = "Greatsword";
	className = "Weapon";
	shapeFile  = "RGREATSWORD";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RGREATSWORDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RWARSWORDImage
{
	shapeFile  = "RWARSWORD";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 3;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing6;
	sfxActivate = AxeSlash2;
};
ItemData RWARSWORD
{
	heading = "bWeapons";
	description = "Crystal Sword";
	className = "Weapon";
	shapeFile  = "RWARSWORD";
	hudIcon = "blaster";
	shadowDetailMask = 4;
	imageType = RWARSWORDImage;
	price = 0;
	showWeaponBar = true;
};
//==============================================================================================================================================================
ItemImageData RKNIFEImage
{
	shapeFile  = "dagger";
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
ItemData RKNIFE
{
	heading = "bWeapons";
	description = "Knife";
	className = "Weapon";
	shapeFile  = "dagger";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = RKNIFEImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RDAGGERImage
{
	shapeFile  = "RDAGGER";
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
ItemData RDAGGER
{
	heading = "bWeapons";
	description = "RDAGGER";
	className = "Weapon";
	shapeFile  = "RDAGGER";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = RDAGGERImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RSHORTSWORDImage
{
	shapeFile  = "short_sword";
	mountPoint = 0;

	weaponType = 0;
	reloadTime = 0;
	fireTime = 1;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing2;
	sfxActivate = AxeSlash2;
};
ItemData RSHORTSWORD
{
	heading = "bWeapons";
	description = "RSHORTSWORD";
	className = "Weapon";
	shapeFile  = "short_sword";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = RSHORTSWORDImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData RSPEARImage
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
ItemData RSPEAR
{
	heading = "bWeapons";
	description = "RSPEAR";
	className = "Weapon";
	shapeFile  = "spear";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = RSPEARImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData RGLADIUSImage
{
	shapeFile  = "RGLADIUS";
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
ItemData RGLADIUS
{
	heading = "bWeapons";
	description = "RGLADIUS";
	className = "Weapon";
	shapeFile  = "RGLADIUS";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = RGLADIUSImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData RTRIDENTImage
{
	shapeFile  = "trident";
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
ItemData RTRIDENT
{
	heading = "bWeapons";
	description = "RTRIDENT";
	className = "Weapon";
	shapeFile  = "trident";
	hudIcon = "trident";
	shadowDetailMask = 4;
	imageType = RTRIDENTImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData RRAPIERImage
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
ItemData RRAPIER
{
	heading = "bWeapons";
	description = "Rapier";
	className = "Weapon";
	shapeFile  = "katana";
	hudIcon = "katana";
	shadowDetailMask = 4;
	imageType = RRAPIERImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RAWLPIKEImage
{
	shapeFile  = "RAWLPIKE";
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
ItemData RAWLPIKE
{
	heading = "bWeapons";
	description = "RAWLPIKE";
	className = "Weapon";
	shapeFile  = "spear";
	hudIcon = "trident";
	shadowDetailMask = 4;
	imageType = RAWLPIKEImage;
	price = 0;
	showWeaponBar = false;
};
//==============================================================================================================================================================
ItemImageData RCLUBImage
{
	shapeFile  = "RCLUB";
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
ItemData RCLUB
{
	heading = "bWeapons";
	description = "RCLUB";
	className = "Weapon";
	shapeFile  = "RCLUB";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = RCLUBImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RSPIKEDCLUBImage
{
	shapeFile  = "RSPIKEDCLUB";
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
ItemData RSPIKEDCLUB
{
	heading = "bWeapons";
	description = "RSPIKEDCLUB";
	className = "Weapon";
	shapeFile  = "RSPIKEDCLUB";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = RSPIKEDCLUBImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RMACEImage
{
	shapeFile  = "RMACE";
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
ItemData RMACE
{
	heading = "bWeapons";
	description = "RMACE";
	className = "Weapon";
	shapeFile  = "RMACE";
	hudIcon = "mace";
	shadowDetailMask = 4;
	imageType = RMACEImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RHAMMERPICKImage
{
	shapeFile = "RHAMMERPICK";
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
ItemData RHAMMERPICK
{
	heading = "bWeapons";
	description = "RHAMMERPICK";
	className = "Weapon";
	shapeFile = "RHAMMERPICK";
	hudIcon = "pick";
	shadowDetailMask = 4;
	imageType = RHAMMERPICKImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RBONECLUBImage
{
	shapeFile  = "RBONECLUB";
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
ItemData RBONECLUB
{
	heading = "bWeapons";
	description = "RBONECLUB";
	className = "Weapon";
	shapeFile  = "RBONECLUB";
	hudIcon = "sclub";
	shadowDetailMask = 4;
	imageType = RBONECLUBImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RLONGSTAFFImage
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
ItemData RLONGSTAFF
{
	heading = "bWeapons";
	description = "RLONGSTAFF";
	className = "Weapon";
	shapeFile  = "longstaff";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = RLONGSTAFFImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RWARHAMMERImage
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
ItemData RWARHAMMER
{
	heading = "bWeapons";
	description = "RWARHAMMER";
	className = "Weapon";
	shapeFile  = "hammer";
	hudIcon = "hammer";
	shadowDetailMask = 4;
	imageType = RWARHAMMERImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RWARMAULImage
{
	shapeFile  = "RWARMAUL";
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
ItemData RWARMAUL
{
	heading = "bWeapons";
	description = "RWARMAUL";
	className = "Weapon";
	shapeFile  = "hammer";
	hudIcon = "hammer";
	shadowDetailMask = 4;
	imageType = RWARMAULImage;
	price = 0;
	showWeaponBar = true;
};
//==============================================================================================================================================================
ItemImageData RSHORTBOWImage
{
	shapeFile = "RSHORTBOW";
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
ItemData RSHORTBOW
{
	description = "RSHORTBOW";
	className = "Weapon";
	shapeFile = "RSHORTBOW";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RSHORTBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RLONGBOWImage
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
	lightTime = 0;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData RLONGBOW
{
	description = "RLONGBOW";
	className = "Weapon";
	shapeFile = "longbow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RLONGBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RCOMPOSITEBOWImage
{
	shapeFile = "RCOMPBOW";
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
ItemData RCOMPOSITEBOW
{
	description = "RCOMPBOW";
	className = "Weapon";
	shapeFile = "RCOMPBOW";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RCOMPOSITEBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RELVENBOWImage
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
	lightTime = 0;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData RELVENBOW
{
	description = "RELVENBOW";
	className = "Weapon";
	shapeFile = "comp_bow";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RELVENBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RWINGBOWImage
{
	shapeFile = "RWINGBOW";
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
ItemData RWINGBOW
{
	description = "RWINGBOW";
	className = "Weapon";
	shapeFile = "RWINGBOW";
	hudIcon = "bow";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RWINGBOWImage;
	price = 0;
	showWeaponBar = true;
};
//==============================================================================================================================================================
ItemImageData RLIGHTCROSSBOWImage
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
	lightTime = 0;
	lightColor = { 0.6, 1, 1.0 };

	sfxFire = CrossbowShoot1;
	sfxActivate = CrossbowSwitch1;
	sfxReload = NoSound;
};
ItemData RLIGHTCROSSBOW
{
	description = "RLIGHTCROSSBOW";
	className = "Weapon";
	shapeFile = "crossbow";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RLIGHTCROSSBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RHANDCROSSBOWImage
{
	shapeFile = "RHANDXBOW";
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
ItemData RHANDCROSSBOW
{
	description = "RLIGHTCROSSBOW";
	className = "Weapon";
	shapeFile = "RHANDXBOW";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RHANDCROSSBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RHEAVYCROSSBOWImage
{
	shapeFile = "RHEAVYXBOW";
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
ItemData RHEAVYCROSSBOW
{
	description = "RLIGHTCROSSBOW";
	className = "Weapon";
	shapeFile = "RHEAVYXBOW";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RHEAVYCROSSBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RELVENCROSSBOWImage
{
	shapeFile = "RELVENXBOW";
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
ItemData RELVENCROSSBOW
{
	description = "RLIGHTCROSSBOW";
	className = "Weapon";
	shapeFile = "RELVENXBOW";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RELVENCROSSBOWImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RARBALESTImage
{
	shapeFile = "RARBALEST";
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
ItemData RARBALEST
{
	description = "RLIGHTCROSSBOW";
	className = "Weapon";
	shapeFile = "RARBALEST";
	hudIcon = "grenade";
	heading = "bWeapons";
	shadowDetailMask = 4;
	imageType = RARBALESTImage;
	price = 0;
	showWeaponBar = true;
};
//==============================================================================================================================================================
ItemImageData RGNARLEDWANDImage
{
	shapeFile  = "RGNARLEDWAND";
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
ItemData RGNARLEDWAND
{
	heading = "bWeapons";
	description = "RGNARLEDWAND";
	className = "Weapon";
	shapeFile  = "RGNARLEDWAND";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = RGNARLEDWANDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RBONEWANDImage
{
	shapeFile  = "RBONEWAND";
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
ItemData RBONEWAND
{
	heading = "bWeapons";
	description = "RBONEWAND";
	className = "Weapon";
	shapeFile  = "RBONEWAND";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = RBONEWANDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData ROAKWANDImage
{
	shapeFile  = "ROAKWAND";
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
ItemData ROAKWAND
{
	heading = "bWeapons";
	description = "ROAKWAND";
	className = "Weapon";
	shapeFile  = "ROAKWAND";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = ROAKWANDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RMYSTICWANDImage
{
	shapeFile  = "RMYSTICWAND";
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
ItemData RMYSTICWAND
{
	heading = "bWeapons";
	description = "RMYSTICWAND";
	className = "Weapon";
	shapeFile  = "RMYSTICWAND";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = RMYSTICWANDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RCRYSTALWANDImage
{
	shapeFile  = "RCRYSTALWAND";
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
ItemData RCRYSTALWAND
{
	heading = "bWeapons";
	description = "RCRYSTALWAND";
	className = "Weapon";
	shapeFile  = "RCRYSTALWAND";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = RCRYSTALWANDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData RPLATEDWANDImage
{
	shapeFile  = "RPLATEDWAND";
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
ItemData RPLATEDWAND
{
	heading = "bWeapons";
	description = "RPLATEDWAND";
	className = "Weapon";
	shapeFile  = "RPLATEDWAND";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = RPLATEDWANDImage;
	price = 0;
	showWeaponBar = true;
};
//==============================================================================================================================================================
ItemImageData RGNARLEDSTAFFImage
{
	shapeFile  = "RGNARLEDSTAFF";
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
ItemData RGNARLEDSTAFF
{
	heading = "bWeapons";
	description = "RGNARLEDSTAFF";
	className = "Weapon";
	shapeFile  = "RGNARLEDSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = RGNARLEDSTAFFImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData RBONESTAFFImage
{
	shapeFile  = "RBONESTAFF";
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
ItemData RBONESTAFF
{
	heading = "bWeapons";
	description = "RBONESTAFF";
	className = "Weapon";
	shapeFile  = "RBONESTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = RBONESTAFFImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData ROAKSTAFFImage
{
	shapeFile  = "ROAKSTAFF";
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
ItemData ROAKSTAFF
{
	heading = "bWeapons";
	description = "ROAKSTAFF";
	className = "Weapon";
	shapeFile  = "ROAKSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = ROAKSTAFFImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData RMYSTICSTAFFImage
{
	shapeFile  = "RMYSTICSTAFF";
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
ItemData RMYSTICSTAFF
{
	heading = "bWeapons";
	description = "RMYSTICSTAFF";
	className = "Weapon";
	shapeFile  = "RMYSTICSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = RMYSTICSTAFFImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData RCRYSTALSTAFFImage
{
	shapeFile  = "RCRYSTALSTAFF";
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
ItemData RCRYSTALSTAFF
{
	heading = "bWeapons";
	description = "RCRYSTALSTAFF";
	className = "Weapon";
	shapeFile  = "RCRYSTALSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = RCRYSTALSTAFFImage;
	price = 0;
	showWeaponBar = false;
};
//---------------------------------------------------------------------------------
ItemImageData RPLATEDSTAFFImage
{
	shapeFile  = "RPLATEDSTAFF";
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
ItemData RPLATEDSTAFF
{
	heading = "bWeapons";
	description = "RPLATEDSTAFF";
	className = "Weapon";
	shapeFile  = "RPLATEDSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = RPLATEDSTAFFImage;
	price = 0;
	showWeaponBar = false;
};

//==============================================================================================================================================================
ItemImageData BOSTAFFImage
{
	shapeFile  = "BoStaff";
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
ItemData BOSTAFF
{
	heading = "bWeapons";
	description = "BOSTAFF";
	className = "Weapon";
	shapeFile  = "BoStaff";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = BOSTAFFImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData CAPPEDSTAFFImage
{
	shapeFile  = "CAPPEDSTAFF";
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
ItemData CAPPEDSTAFF
{
	heading = "bWeapons";
	description = "CAPPEDSTAFF";
	className = "Weapon";
	shapeFile  = "CAPPEDSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = CAPPEDSTAFFImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData CEDARSTAFFImage
{
	shapeFile  = "CEDARSTAFF";
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
ItemData CEDARSTAFF
{
	heading = "bWeapons";
	description = "CEDARSTAFF";
	className = "Weapon";
	shapeFile  = "CEDARSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = CEDARSTAFFImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData IVORYSTAFFImage
{
	shapeFile  = "IVORYSTAFF";
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
ItemData IVORYSTAFF
{
	heading = "bWeapons";
	description = "IVORYSTAFF";
	className = "Weapon";
	shapeFile  = "IVORYSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = IVORYSTAFFImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData SHADEWOODSTAFFImage
{
	shapeFile  = "SHADEWOODSTAFF";
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
ItemData SHADEWOODSTAFF
{
	heading = "bWeapons";
	description = "SHADEWOODSTAFF";
	className = "Weapon";
	shapeFile  = "SHADEWOODSTAFF";
	hudIcon = "spear";
	shadowDetailMask = 4;
	imageType = SHADEWOODSTAFFImage;
	price = 0;
	showWeaponBar = true;
};

//==============================================================================================================================================================
ItemImageData UCRUSHINGMINDImage
{
	shapeFile  = "UCRUSHINGMIND";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 0.5;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData UCRUSHINGMIND
{
	heading = "bWeapons";
	description = "UCRUSHINGMIND";
	className = "Weapon";
	shapeFile  = "UCRUSHINGMIND";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = UCRUSHINGMINDImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData UFROMTHEDARKImage
{
	shapeFile  = "UFROMTHEDARK";
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
ItemData UFROMTHEDARK
{
	heading = "bWeapons";
	description = "UFROMTHEDARK";
	className = "Weapon";
	shapeFile  = "UFROMTHEDARK";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = UFROMTHEDARKImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData UPLAGUEVECTORImage
{
	shapeFile  = "UPLAGUEVECTOR";
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
ItemData UPLAGUEVECTOR
{
	heading = "bWeapons";
	description = "UPLAGUEVECTOR";
	className = "Weapon";
	shapeFile  = "UPLAGUEVECTOR";
	hudIcon = "dagger";
	shadowDetailMask = 4;
	imageType = UPLAGUEVECTORImage;
	price = 0;
	showWeaponBar = true;
};
//---------------------------------------------------------------------------------
ItemImageData UWILLMADEImage
{
	shapeFile  = "UWILLMADE";
	mountPoint = 0;

	weaponType = 0; // Single Shot
	reloadTime = 0;
	fireTime = 2.0;
	minEnergy = 0;
	maxEnergy = 0;

	accuFire = true;

	sfxFire = SoundSwing5;
	sfxActivate = AxeSlash2;
};
ItemData UWILLMADE
{
	heading = "bWeapons";
	description = "UWILLMADE";
	className = "Weapon";
	shapeFile  = "UWILLMADE";
	hudIcon = "club";
	shadowDetailMask = 4;
	imageType = UWILLMADEImage;
	price = 0;
	showWeaponBar = true;
};

//==============================================================================================================================================================

function RHATCHETImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }	
function RBROADSWORDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }	
function RWARAXEImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }		
function RLONGSWORDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }	
function RBATTLEAXEImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }	
function RBASTARDSWORDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
function RHALBERDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }	
function RCLAYMOREImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }	
//==================================================================================
function RGIANTSWORDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(3,Player::getClient(%player)); }	
function RFLAMBERGEImage::onFire(%player, %slot) { Player::SetupWeaponAttack(3,Player::getClient(%player)); }	
function RCRYSTALSWORDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(3,Player::getClient(%player)); }
function RGREATSWORDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(3,Player::getClient(%player)); }
function RWARSWORDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(3,Player::getClient(%player)); }		
//==================================================================================
function RKNIFEImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }		
function RDAGGERImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
function RSHORTSWORDImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
function RSPEARImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
function RGLADIUSImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
function RTRIDENTImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
function RRAPIERImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
function RAWLPIKEImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
//==================================================================================
function RCLUBImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
function RSPIKEDCLUBImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
function RMACEImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
function RHAMMERPICKImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
function RBONECLUBImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
function RLONGSTAFFImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
function RWARHAMMERImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
function RWARMAULImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player)); }
//==================================================================================
function RSHORTBOWImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player),-1,True,Arrow); }
function RLONGBOWImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player),-1,True,Arrow); }
function RCOMPBOWImage::onFire(%player, %slot) {Player::SetupWeaponAttack(1,Player::getClient(%player),-1,True,Arrow); }
function RELVENBOWImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player),-1,True,Arrow); }
function RWINGBOWImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player),-1,True,Arrow); }
//==================================================================================
function RLIGHTCROSSBOWImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player),-1,True,Bolt); }
function RHANDCROSSBOWImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player),-1,True,Bolt); }
function RHEAVYCROSSBOWImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player),-1,True,Bolt); }
function RELVENCROSSBOWImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player),-1,True,Bolt); }
function RARBALESTImage::onFire(%player, %slot) { Player::SetupWeaponAttack(2,Player::getClient(%player),-1,True,Bolt); }
//==================================================================================
function RGNARLEDWANDImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function RBONEWANDImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function ROAKWANDImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function RMYSTICWANDImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function RCRYSTALWANDImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function RPLATEDWANDImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
//==================================================================================
function RGNARLEDSTAFFImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function RBONESTAFFImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function ROAKSTAFFImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function RMYSTICSTAFFImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function RCRYSTALSTAFFImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
function RPLATEDSTAFFImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player)); }
//==================================================================================
function BOSTAFFImage::onFire(%player, %slot) { Player::SetupWeaponAttack(0.5,Player::getClient(%player)); }	
function CAPPEDSTAFFImage::onFire(%player, %slot) { Player::SetupWeaponAttack(0.5,Player::getClient(%player)); }	
function CEDARSTAFFImage::onFire(%player, %slot) { Player::SetupWeaponAttack(0.5,Player::getClient(%player)); }
function IVORYSTAFFImage::onFire(%player, %slot) { Player::SetupWeaponAttack(0.5,Player::getClient(%player)); }
function SHADEWOODSTAFFImage::onFire(%player, %slot) { Player::SetupWeaponAttack(0.5,Player::getClient(%player)); }
//==================================================================================
function UCRUSHINGMINDImage::onFire(%player, %slot) { Player::MagicBasicAttack(0.5,Player::getClient(%player)); }
function UFROMTHEDARKImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
function UPLAGUEVECTORImage::onFire(%player, %slot) { Player::SetupWeaponAttack(1,Player::getClient(%player)); }
function UWILLMADEImage::onFire(%player, %slot) { Player::MagicBasicAttack(2,Player::getClient(%player),1.0); }	
