function GenerateAllShieldCosts()
{
	return true;
}

function GetAccessoryVar(%item, %type)
{
	return true;
}

function getCroppedItem(%item)
{
	return true;
}

function GetAccessoryList(%clientId, %type, %filter)
{
	return true;
}

function AddPoints(%clientId, %char)
{
	return true;
}

function AddItemSpecificPoints(%item, %char)
{
	return true;
}

function WhatSpecialVars(%thing)
{
	return true;
}

function NullItemList(%clientId, %type, %msgcolor, %msg)
{
	return true;
}

function GetCurrentlyWearingArmor(%clientId)
{
	return true;
}


//===============================================================================================================================

ItemData MaleHumanTownBot
{
	description = "Male Town Bot";
	className = "TownBot";
	shapeFile = "rpgmalehuman";

	visibleToSensor = true;	//thanks Adger!!
	mapFilter = 1;		//thanks Adger!!
};

ItemData MaleHumanTownBotRobed
{
	description = "Male Town Bot RObed";
	className = "TownBot";
	shapeFile = "magemale";

	visibleToSensor = true;	//thanks Adger!!
	mapFilter = 1;		//thanks Adger!!
};


ItemData FemaleHumanTownBot
{
	description = "Female Town Bot";
	className = "TownBot";
	shapeFile = "lfemalehuman";

	visibleToSensor = true;	//thanks Adger!!
	mapFilter = 1;		//thanks Adger!!
};

ItemData FemaleHumanTownBotRobed
{
	description = "Female Town Bot";
	className = "TownBot";
	shapeFile = "femalemage";

	visibleToSensor = true;	//thanks Adger!!
	mapFilter = 1;		//thanks Adger!!
};

//===============================================================================================================================

ItemData Lootbag
{
	description = "Backpack";
	className = "Lootbag";
	shapeFile = "ammo2";
	heading = "eMiscellany";
	shadowDetailMask = 4;
	price = 0;
};