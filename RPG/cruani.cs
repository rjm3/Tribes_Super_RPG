function CruAniLoop(%id,%type)
{
	Echo("SETTING ANI " @ %id @ " " @ %type);

	focusServer();

	if (%type == "widow") {
		player::SetItemCount(%id,"WidowPack",1);
		player::MountItem(%id,"WidowPack",1);
		$cruani[%id] = 1;
		LoopAni(%id,0);
	}
}

function LoopAni(%id,%type)
{
	echo("LoopAni " @ %id @ " " @ %type);

	if (%type == 0)
		%pack = "WidowPack";

	focusServer();


	if (gamebase::IsAtRest(client::getOwnedObject(%id)) != true) {
	
		player::mountItem(%id,%pack @ "S",1);

		schedule("player::mountItem("@%id@",\""@%pack@"\",1);",0.1);

	}

	if ($cruani[%id])
		schedule("LoopAni("@%id@","@%type@");",1.5);
}

ItemImageData WidowPackImage
{
	shapeFile = "WIDOW";
	weaponType = 2;  // Sustained
	mountPoint = 1;
	mountOffset = { 0, 0, 0 };
	mountRotation = { 0, 0, 0 };
	minEnergy = -1;
 	maxEnergy = -3;
	firstPerson = false;
};

ItemData WidowPack
{
	description = "WidowPack";
	shapeFile = "WIDOW";
	className = "Backpack";
   	heading = "cBackpacks";
	shadowDetailMask = 4;
	imageType = WidowPackImage;
	price = 150;
	hudIcon = "energypack";
	showWeaponBar = true;
	hiliteOnActive = true;
   	validateShape = true;
   	validateMaterials = true;
};


ItemImageData WidowPackImageS
{
	shapeFile = "WIDOW_S";
	weaponType = 2;  // Sustained
	mountPoint = 1;
	mountOffset = { 0, 0, 0 };
	mountRotation = { 0, 0, 0 };
	minEnergy = -1;
 	maxEnergy = -3;
	firstPerson = false;
};

ItemData WidowPackS
{
	description = "WidowPack";
	shapeFile = "WIDOW_S";
	className = "Backpack";
   	heading = "cBackpacks";
	shadowDetailMask = 4;
	imageType = WidowPackImage;
	price = 150;
	hudIcon = "energypack";
	showWeaponBar = true;
	hiliteOnActive = true;
   	validateShape = true;
   	validateMaterials = true;
};