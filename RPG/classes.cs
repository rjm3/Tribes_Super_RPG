//There are FOUR hard-coded groups:
//-Priest
//-Rogue
//-Warrior
//-Wizard

//Each of these has classes.  They are specified in here.
//Anything that does NOT have to do with visuals when it comes to classes should ALWAYS use the 0 offset in $ClassName.

$initcoins[Priest] = "3d6x10";
$initcoins[Rogue] = "2d6x10";
$initcoins[Warrior] = "5d4x10";
$initcoins[Wizard] = "1d4+1x10";

$MinHP[MaleHuman] = 12;
$MinHP[FemaleHuman] = 12;
$MinHP[Traveller] = 12;
$MinHP[Goblin] = 0;
$MinHP[Orc] = 7;
$MinHP[Ogre] = 10;
$MinHP[Gnoll] = 3;
$MinHP[Undead] = 11;
$MinHP[Elf] = 10;
$MinHP[Minotaur] = 15;
$MinHP[Uber] = 25;
$MinHP[DeathKnight] = 5000;

$ClassName[1, 0] = "Cleric";
$ClassName[2, 0] = "Druid";
$ClassName[3, 0] = "Thief";
$ClassName[4, 0] = "Bard";
$ClassName[5, 0] = "Fighter";
$ClassName[6, 0] = "Paladin";
$ClassName[7, 0] = "Ranger";
$ClassName[8, 0] = "Mage";
$ClassName[9, 0] = "MartialArtist";

$ClassGroup[Cleric] = "Priest";
$ClassGroup[Druid] = "Priest";
$ClassGroup[Thief] = "Rogue";
$ClassGroup[Bard] = "Rogue";
$ClassGroup[Fighter] = "Warrior";
$ClassGroup[Paladin] = "Warrior";
$ClassGroup[Ranger] = "Warrior";
$ClassGroup[Mage] = "Wizard";
$ClassGroup[MartialArtist] = "Warrior";

function getFinalCLASS(%clientId)
{
	dbecho($dbechoMode, "getFinalCLASS(" @ %clientId @ ")");
	if ((%c = fetchData(%clientId,"CustomClass")) != "")
		return %c;
	if (%clientId.Class != "" && %clientId.Class != -1)
		return %clientId.Class;
	return fetchData(%clientId, "CLASS");
}

function IsAClass(%class)
{
	dbecho($dbechoMode, "IsAClass(" @ %class @ ")");

	for(%i = 1; $ClassName[%i, 0] != ""; %i++)
	{
		if(String::ICompare(%class, $ClassName[%i, 0]) == 0)
			return True;
	}

	return False;
}