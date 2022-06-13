// ZONE

//=========================================================================================================================================================================

echo("LOADING ZONE");

function InitZones()
{
	echo(" INIT ZONES " @ $CURRENTCRUMAP);
	if ($CURRENTCRUMAP == "FOREST") {
		$TOWNPORTALPOS = "78.5 25.96 163.3";
		$TOWNPORTALROT = "0 -0 -1.4";
		$MAPEXIT = "KTOWN";
		$MAPDEATH = "KTOWN";
		$MAPDEATHPOS = "69.642 47.502 165.26";
	}
	if ($CURRENTCRUMAP == "DESERT") {
		$TOWNPORTALPOS = "81 -110 75.1";
		$TOWNPORTALROT = "0 -0 -0.01";
		$MAPEXIT = "DESTOWN";
		$MAPDEATH = "DESTOWN";
		$MAPDEATHPOS = "183 -90 77";
	}
	if ($CURRENTCRUMAP == "JUNGLE") {
		$TOWNPORTALPOS = "-204.965 215.352 70.2453";
		$TOWNPORTALROT = "0 -0 -2.63997";
		$MAPEXIT = "JTOWN";
		$MAPDEATH = "JTOWN";
		$MAPDEATHPOS = "-180.823 177.375 71.9953";
	}
}
InitZones();

$ZoneEnter 	= 1;
$ZoneExit	= 2;
$ZoneDisp	= 3;
$ZoneDeath	= 4;
$ZoneDeathPos	= 5;
$ZoneIsMap	= 6;
$ZoneExitDist = 7;
$ZonePos = 8;

$ZoneInfo[DUNGEON,$ZoneEnter] = "DUNGEON";
$ZoneInfo[DUNGEON,$ZoneExit] = "UNKNOWN";
$ZoneInfo[DUNGEON,$ZoneDisp] = "Dungeon";

$ZoneInfo[UNKNOWN,$ZoneEnter] = "UNKNOWN";
$ZoneInfo[UNKNOWN,$ZoneExit] = "UNKOWN";
$ZoneInfo[UNKNOWN,$ZoneDisp] = "Wilderness";

$ZoneInfo[KTOWN,$ZoneEnter] = "KTOWN";
$ZoneInfo[KTOWN,$ZoneExit] = "UNKNOWN";
$ZoneInfo[KTOWN,$ZoneDisp] = "Keldrin Encampment";
$ZoneInfo[KTOWN,$ZoneExitDist] = 100;
$ZoneInfo[KTOWN,$ZonePos] = "107.75 31.625 150.75";

$ZoneInfo[OLDCELLAR,$ZoneEnter] = "OLDCELLAR";
$ZoneInfo[OLDCELLAR,$ZoneExit] = "KTOWN";
$ZoneInfo[OLDCELLAR,$ZoneDisp] = "Old Cellar";
$ZoneInfo[OLDCELLAR,$ZoneDeath] = "KTOWN";
$ZoneInfo[OLDCELLAR,$ZoneDeathPos] = "124 10.5 161.9";

$ZoneInfo[FORGOTTENMINE,$ZoneEnter] = "FORGOTTENMINE";
$ZoneInfo[FORGOTTENMINE,$ZoneExit] = "UNKNOWN";
$ZoneInfo[FORGOTTENMINE,$ZoneDisp] = "Forgotten Mine";
$ZoneInfo[FORGOTTENMINE,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[FORGOTTENMINE,$ZoneDeathPos] = "-95 -296 80";

$ZoneInfo[CULTISTHIDEOUT,$ZoneEnter] = "CULTISTHIDEOUT";
$ZoneInfo[CULTISTHIDEOUT,$ZoneExit] = "UNKNOWN";
$ZoneInfo[CULTISTHIDEOUT,$ZoneDisp] = "Cultist Hideout";
$ZoneInfo[CULTISTHIDEOUT,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[CULTISTHIDEOUT,$ZoneDeathPos] = "-647 533 146";

$ZoneInfo[OLDKELDRIN,$ZoneEnter] = "OLDKELDRIN";
$ZoneInfo[OLDKELDRIN,$ZoneExit] = "UNKNOWN";
$ZoneInfo[OLDKELDRIN,$ZoneDisp] = "Old Keldrin";
$ZoneInfo[OLDKELDRIN,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[OLDKELDRIN,$ZoneDeathPos] = "-1081 270.9 50.1";

$ZoneInfo[UNDERTOWER,$ZoneEnter] = "UNDERTOWER";
$ZoneInfo[UNDERTOWER,$ZoneExit] = "UNKNOWN";
$ZoneInfo[UNDERTOWER,$ZoneDisp] = "Undertower";
$ZoneInfo[UNDERTOWER,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[UNDERTOWER,$ZoneDeathPos] = "-1003 -340 210";

$ZoneInfo[UNDERPATH,$ZoneEnter] = "UNDERPATH";
$ZoneInfo[UNDERPATH,$ZoneExit] = "UNKNOWN";
$ZoneInfo[UNDERPATH,$ZoneDisp] = "Underpath";
$ZoneInfo[UNDERPATH,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[UNDERPATH,$ZoneDeathPos] = "904 -340 198";

$ZoneInfo[CATACOMBS,$ZoneEnter] = "CATACOMBS";
$ZoneInfo[CATACOMBS,$ZoneExit] = "UNKNOWN";
$ZoneInfo[CATACOMBS,$ZoneDisp] = "The Catacombs";
$ZoneInfo[CATACOMBS,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[CATACOMBS,$ZoneDeathPos] = "1414 -498 220.5";

$ZoneInfo[STRONGHOLD,$ZoneEnter] = "STRONGHOLD";
$ZoneInfo[STRONGHOLD,$ZoneExit] = "UNKNOWN";
$ZoneInfo[STRONGHOLD,$ZoneDisp] = "The Stronghold";

$ZoneInfo[TOWER,$ZoneEnter] = "TOWER";
$ZoneInfo[TOWER,$ZoneExit] = "UNKNOWN";
$ZoneInfo[TOWER,$ZoneDisp] = "The Tower";

$ZoneInfo[CAMP,$ZoneEnter] = "CAMP";
$ZoneInfo[CAMP,$ZoneExit] = "UNKNOWN";
$ZoneInfo[CAMP,$ZoneDisp] = "The Camp";

$ZoneInfo[OLDSMITH,$ZoneEnter] = "OLDSMITH";
$ZoneInfo[OLDSMITH,$ZoneExit] = "UNKNOWN";
$ZoneInfo[OLDSMITH,$ZoneDisp] = "Old Smith's House";
$ZoneInfo[OLDSMITH,$ZoneExitDist] = 20;
$ZoneInfo[OLDSMITH,$ZonePos] = "867.625 -67.8573 131.375";

$ZoneInfo[DESTOWN,$ZoneEnter] = "DESTOWN";
$ZoneInfo[DESTOWN,$ZoneExit] = "UNKNOWN";
$ZoneInfo[DESTOWN,$ZoneDisp] = "Rakhar";
$ZoneInfo[DESTOWN,$ZoneExitDist] = 150;
$ZoneInfo[DESTOWN,$ZonePos] = "114.991 -54.9017 104.788";

$ZoneInfo[SEWERS,$ZoneEnter] = "SEWERS";
$ZoneInfo[SEWERS,$ZoneExit] = "DESTOWN";
$ZoneInfo[SEWERS,$ZoneDisp] = "Rakhar Sewers";
$ZoneInfo[SEWERS,$ZoneDeath] = "DESTOWN";
$ZoneInfo[SEWERS,$ZoneDeathPos] = "32 -104 75.1";

$ZoneInfo[OASIS,$ZoneEnter] = "OASIS";
$ZoneInfo[OASIS,$ZoneExit] = "UNKNOWN";
$ZoneInfo[OASIS,$ZoneDisp] = "Oasis Ruins";
$ZoneInfo[OASIS,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[OASIS,$ZoneDeathPos] = "50 -188 75.1";

$ZoneInfo[DUSTYCAVE,$ZoneEnter] = "DUSTYCAVE";
$ZoneInfo[DUSTYCAVE,$ZoneExit] = "UNKNOWN";
$ZoneInfo[DUSTYCAVE,$ZoneDisp] = "Dusty Cave";
$ZoneInfo[DUSTYCAVE,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[DUSTYCAVE,$ZoneDeathPos] = "-632 -239 65.3";

$ZoneInfo[TEMPLE,$ZoneEnter] = "TEMPLE";
$ZoneInfo[TEMPLE,$ZoneExit] = "UNKNOWN";
$ZoneInfo[TEMPLE,$ZoneDisp] = "Temple Ruins";
$ZoneInfo[TEMPLE,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[TEMPLE,$ZoneDeathPos] = "-890 -645 113.5";

$ZoneInfo[LIBRARY,$ZoneEnter] = "LIBRARY";
$ZoneInfo[LIBRARY,$ZoneExit] = "UNKNOWN";
$ZoneInfo[LIBRARY,$ZoneDisp] = "Ancient Library";
$ZoneInfo[LIBRARY,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[LIBRARY,$ZoneDeathPos] = "623 -332 133.9";

$ZoneInfo[SUNPYRAMID,$ZoneEnter] = "SUNPYRAMID";
$ZoneInfo[SUNPYRAMID,$ZoneExit] = "UNKNOWN";
$ZoneInfo[SUNPYRAMID,$ZoneDisp] = "Sun Pyramid";
$ZoneInfo[SUNPYRAMID,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[SUNPYRAMID,$ZoneDeathPos] = "963 -760 134.5";

$ZoneInfo[JTOWN,$ZoneEnter] = "JTOWN";
$ZoneInfo[JTOWN,$ZoneExit] = "UNKNOWN";
$ZoneInfo[JTOWN,$ZoneDisp] = "Outpost";
$ZoneInfo[JTOWN,$ZoneExitDist] = 80;
$ZoneInfo[JTOWN,$ZonePos] = "-189.132 182.875 69.9946";

$ZoneInfo[UNDERWELL,$ZoneEnter] = "UNDERWELL";
$ZoneInfo[UNDERWELL,$ZoneExit] = "JTOWN";
$ZoneInfo[UNDERWELL,$ZoneDisp] = "Underwell";
$ZoneInfo[UNDERWELL,$ZoneDeath] = "JTOWN";
$ZoneInfo[UNDERWELL,$ZoneDeathPos] = "-184.228 224.968 72";

$ZoneInfo[FLOODCAV,$ZoneEnter] = "FLOODCAV";
$ZoneInfo[FLOODCAV,$ZoneExit] = "UNKNOWN";
$ZoneInfo[FLOODCAV,$ZoneDisp] = "Flooded Cavern";
$ZoneInfo[FLOODCAV,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[FLOODCAV,$ZoneDeathPos] = "-95.9933 -102.043 126.875";

$ZoneInfo[WATERWAY,$ZoneEnter] = "WATERWAY";
$ZoneInfo[WATERWAY,$ZoneExit] = "UNKNOWN";
$ZoneInfo[WATERWAY,$ZoneDisp] = "Waterway";
$ZoneInfo[WATERWAY,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[WATERWAY,$ZoneDeathPos] = "-359.226 -452.458 115.773";

$ZoneInfo[UNDERTREE,$ZoneEnter] = "UNDERTREE";
$ZoneInfo[UNDERTREE,$ZoneExit] = "UNKNOWN";
$ZoneInfo[UNDERTREE,$ZoneDisp] = "Undertree";
$ZoneInfo[UNDERTREE,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[UNDERTREE,$ZoneDeathPos] = "217.734 243.394 161.798";

$ZoneInfo[EMERALD,$ZoneEnter] = "EMERALD";
$ZoneInfo[EMERALD,$ZoneExit] = "UNKNOWN";
$ZoneInfo[EMERALD,$ZoneDisp] = "Emerald Mine";
$ZoneInfo[EMERALD,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[EMERALD,$ZoneDeathPos] = "686 -30.0938 154.853";

$ZoneInfo[DARK,$ZoneEnter] = "DARK";
$ZoneInfo[DARK,$ZoneExit] = "UNKNOWN";
$ZoneInfo[DARK,$ZoneDisp] = "Dark Temple";
$ZoneInfo[DARK,$ZoneDeath] = "UNKNOWN";
$ZoneInfo[DARK,$ZoneDeathPos] = "753.84 -762.38 154.779";

// MAPS
$ZoneInfo["FOREST1",$ZoneEnter] = "FOREST1";
$ZoneInfo["FOREST2",$ZoneEnter] = "FOREST2";
$ZoneInfo["FOREST3",$ZoneEnter] = "FOREST3";
$ZoneInfo["FOREST4",$ZoneEnter] = "FOREST4";
$ZoneInfo["DESERT1",$ZoneEnter] = "DESERT1";
$ZoneInfo["DESERT2",$ZoneEnter] = "DESERT2";
$ZoneInfo["DESERT3",$ZoneEnter] = "DESERT3";
$ZoneInfo["DESERT4",$ZoneEnter] = "DESERT4";
$ZoneInfo["JUNGLE1",$ZoneEnter] = "JUNGLE1";
$ZoneInfo["JUNGLE2",$ZoneEnter] = "JUNGLE2";
$ZoneInfo["JUNGLE3",$ZoneEnter] = "JUNGLE3";
$ZoneInfo["JUNGLE4",$ZoneEnter] = "JUNGLE4";
$ZoneInfo["FROZEN1",$ZoneEnter] = "FROZEN1";
$ZoneInfo["FROZEN2",$ZoneEnter] = "FROZEN2";
$ZoneInfo["FROZEN3",$ZoneEnter] = "FROZEN3";
$ZoneInfo["FROZEN4",$ZoneEnter] = "FROZEN4";
$ZoneInfo["FROZEN5",$ZoneEnter] = "FROZEN5";
$ZoneInfo["LAVA1",$ZoneEnter] = "LAVA1";
$ZoneInfo["LAVA2",$ZoneEnter] = "LAVA2";
$ZoneInfo["LAVA3",$ZoneEnter] = "LAVA3";
$ZoneInfo["LAVA4",$ZoneEnter] = "LAVA4";
$ZoneInfo["LAVA5",$ZoneEnter] = "LAVA5";
$ZoneInfo["ARCANE1",$ZoneEnter] = "ARCANE1";
$ZoneInfo["ARCANE2",$ZoneEnter] = "ARCANE2";
$ZoneInfo["ARCANE3",$ZoneEnter] = "ARCANE3";
$ZoneInfo["ARCANE4",$ZoneEnter] = "ARCANE4";
$ZoneInfo["ARCANE5",$ZoneEnter] = "ARCANE5";
$ZoneInfo["HELL1",$ZoneEnter] = "HELL1";
$ZoneInfo["HELL2",$ZoneEnter] = "HELL2";
$ZoneInfo["HELL3",$ZoneEnter] = "HELL3";
$ZoneInfo["HELL4",$ZoneEnter] = "HELL4";
$ZoneInfo["HELL5",$ZoneEnter] = "HELL5";

$ZoneInfo["FOREST1",$ZoneDisp] = "The Woods";
$ZoneInfo["FOREST2",$ZoneDisp] = "Graveyard";
$ZoneInfo["FOREST3",$ZoneDisp] = "The Sewers";
$ZoneInfo["FOREST4",$ZoneDisp] = "Druids Keep";
$ZoneInfo["DESERT1",$ZoneDisp] = "Ancient Halls";
$ZoneInfo["DESERT2",$ZoneDisp] = "Dusty Road";
$ZoneInfo["DESERT3",$ZoneDisp] = "Lone Pyramid";
$ZoneInfo["DESERT4",$ZoneDisp] = "Sunhenge";
$ZoneInfo["JUNGLE1",$ZoneDisp] = "Black Valley";
$ZoneInfo["JUNGLE2",$ZoneDisp] = "Cave Temple";
$ZoneInfo["JUNGLE3",$ZoneDisp] = "High Temple";
$ZoneInfo["JUNGLE4",$ZoneDisp] = "Mucky Waterway";
$ZoneInfo["FROZEN1",$ZoneDisp] = "Ice Cavern";
$ZoneInfo["FROZEN2",$ZoneDisp] = "Frostforth";
$ZoneInfo["FROZEN3",$ZoneDisp] = "Northern Outpost";
$ZoneInfo["FROZEN4",$ZoneDisp] = "Wintersun";
$ZoneInfo["FROZEN5",$ZoneDisp] = "Ice Tunnel";
$ZoneInfo["LAVA1",$ZoneDisp] = "Burnspire";
$ZoneInfo["LAVA2",$ZoneDisp] = "Lavaway";
$ZoneInfo["LAVA3",$ZoneDisp] = "Hotstones";
$ZoneInfo["LAVA4",$ZoneDisp] = "Burnkeep";
$ZoneInfo["LAVA5",$ZoneDisp] = "Magma Cave";
$ZoneInfo["ARCANE1",$ZoneDisp] = "Brokenbridge";
$ZoneInfo["ARCANE2",$ZoneDisp] = "Steps";
$ZoneInfo["ARCANE3",$ZoneDisp] = "Cube";
$ZoneInfo["ARCANE4",$ZoneDisp] = "Center";
$ZoneInfo["ARCANE5",$ZoneDisp] = "Masters Hall";
$ZoneInfo["HELL1",$ZoneDisp] = "Hellstar";
$ZoneInfo["HELL2",$ZoneDisp] = "Hellforge";
$ZoneInfo["HELL3",$ZoneDisp] = "Hellclaw";
$ZoneInfo["HELL4",$ZoneDisp] = "Hellpain";
$ZoneInfo["HELL5",$ZoneDisp] = "Hellspawn";

$ZoneInfo["FOREST1",$ZoneExit] = $MAPEXIT;
$ZoneInfo["FOREST2",$ZoneExit] = $MAPEXIT;
$ZoneInfo["FOREST3",$ZoneExit] = $MAPEXIT;
$ZoneInfo["FOREST4",$ZoneExit] = $MAPEXIT;
$ZoneInfo["DESERT1",$ZoneExit] = $MAPEXIT;
$ZoneInfo["DESERT2",$ZoneExit] = $MAPEXIT;
$ZoneInfo["DESERT3",$ZoneExit] = $MAPEXIT;
$ZoneInfo["DESERT4",$ZoneExit] = $MAPEXIT;
$ZoneInfo["JUNGLE1",$ZoneExit] = $MAPEXIT;
$ZoneInfo["JUNGLE2",$ZoneExit] = $MAPEXIT;
$ZoneInfo["JUNGLE3",$ZoneExit] = $MAPEXIT;
$ZoneInfo["JUNGLE4",$ZoneExit] = $MAPEXIT;
$ZoneInfo["FROZEN1",$ZoneExit] = $MAPEXIT;
$ZoneInfo["FROZEN2",$ZoneExit] = $MAPEXIT;
$ZoneInfo["FROZEN3",$ZoneExit] = $MAPEXIT;
$ZoneInfo["FROZEN4",$ZoneExit] = $MAPEXIT;
$ZoneInfo["FROZEN5",$ZoneExit] = $MAPEXIT;
$ZoneInfo["LAVA1",$ZoneExit] = $MAPEXIT;
$ZoneInfo["LAVA2",$ZoneExit] = $MAPEXIT;
$ZoneInfo["LAVA3",$ZoneExit] = $MAPEXIT;
$ZoneInfo["LAVA4",$ZoneExit] = $MAPEXIT;
$ZoneInfo["LAVA5",$ZoneExit] = $MAPEXIT;
$ZoneInfo["ARCANE1",$ZoneExit] = $MAPEXIT;
$ZoneInfo["ARCANE2",$ZoneExit] = $MAPEXIT;
$ZoneInfo["ARCANE3",$ZoneExit] = $MAPEXIT;
$ZoneInfo["ARCANE4",$ZoneExit] = $MAPEXIT;
$ZoneInfo["ARCANE5",$ZoneExit] = $MAPEXIT;
$ZoneInfo["HELL1",$ZoneExit] = $MAPEXIT;
$ZoneInfo["HELL2",$ZoneExit] = $MAPEXIT;
$ZoneInfo["HELL3",$ZoneExit] = $MAPEXIT;
$ZoneInfo["HELL4",$ZoneExit] = $MAPEXIT;
$ZoneInfo["HELL5",$ZoneExit] = $MAPEXIT;

$ZoneInfo["FOREST1",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["FOREST2",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["FOREST3",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["FOREST4",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["DESERT1",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["DESERT2",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["DESERT3",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["DESERT4",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["JUNGLE1",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["JUNGLE2",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["JUNGLE3",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["JUNGLE4",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["FROZEN1",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["FROZEN2",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["FROZEN3",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["FROZEN4",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["FROZEN5",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["LAVA1",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["LAVA2",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["LAVA3",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["LAVA4",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["LAVA5",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["ARCANE1",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["ARCANE2",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["ARCANE3",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["ARCANE4",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["ARCANE5",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["HELL1",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["HELL2",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["HELL3",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["HELL4",$ZoneDeath] = $MAPDEATH;
$ZoneInfo["HELL5",$ZoneDeath] = $MAPDEATH;

$ZoneInfo["FOREST1",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["FOREST2",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["FOREST3",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["FOREST4",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["DESERT1",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["DESERT2",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["DESERT3",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["DESERT4",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["JUNGLE1",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["JUNGLE2",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["JUNGLE3",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["JUNGLE4",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["FROZEN1",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["FROZEN2",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["FROZEN3",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["FROZEN4",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["FROZEN5",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["LAVA1",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["LAVA2",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["LAVA3",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["LAVA4",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["LAVA5",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["ARCANE1",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["ARCANE2",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["ARCANE3",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["ARCANE4",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["ARCANE5",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["HELL1",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["HELL2",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["HELL3",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["HELL4",$ZoneDeathPos] = $MAPDEATHPOS;
$ZoneInfo["HELL5",$ZoneDeathPos] = $MAPDEATHPOS;

$ZoneInfo["FOREST1",$ZoneIsMap] = 1;
$ZoneInfo["FOREST2",$ZoneIsMap] = 1;
$ZoneInfo["FOREST3",$ZoneIsMap] = 1;
$ZoneInfo["FOREST4",$ZoneIsMap] = 1;
$ZoneInfo["DESERT1",$ZoneIsMap] = 1;
$ZoneInfo["DESERT2",$ZoneIsMap] = 1;
$ZoneInfo["DESERT3",$ZoneIsMap] = 1;
$ZoneInfo["DESERT4",$ZoneIsMap] = 1;
$ZoneInfo["JUNGLE1",$ZoneIsMap] = 1;
$ZoneInfo["JUNGLE2",$ZoneIsMap] = 1;
$ZoneInfo["JUNGLE3",$ZoneIsMap] = 1;
$ZoneInfo["JUNGLE4",$ZoneIsMap] = 1;
$ZoneInfo["FROZEN1",$ZoneIsMap] = 1;
$ZoneInfo["FROZEN2",$ZoneIsMap] = 1;
$ZoneInfo["FROZEN3",$ZoneIsMap] = 1;
$ZoneInfo["FROZEN4",$ZoneIsMap] = 1;
$ZoneInfo["FROZEN5",$ZoneIsMap] = 1;
$ZoneInfo["LAVA1",$ZoneIsMap] = 1;
$ZoneInfo["LAVA2",$ZoneIsMap] = 1;
$ZoneInfo["LAVA3",$ZoneIsMap] = 1;
$ZoneInfo["LAVA4",$ZoneIsMap] = 1;
$ZoneInfo["LAVA5",$ZoneIsMap] = 1;
$ZoneInfo["ARCANE1",$ZoneIsMap] = 1;
$ZoneInfo["ARCANE2",$ZoneIsMap] = 1;
$ZoneInfo["ARCANE3",$ZoneIsMap] = 1;
$ZoneInfo["ARCANE4",$ZoneIsMap] = 1;
$ZoneInfo["ARCANE5",$ZoneIsMap] = 1;
$ZoneInfo["HELL1",$ZoneIsMap] = 1;
$ZoneInfo["HELL2",$ZoneIsMap] = 1;
$ZoneInfo["HELL3",$ZoneIsMap] = 1;
$ZoneInfo["HELL4",$ZoneIsMap] = 1;
$ZoneInfo["HELL5",$ZoneIsMap] = 1;

//=========================================================================================================================================================================

function GetZoneData(%zone,%data)
{
	return $ZoneInfo[%zone,%data];
}

function CruZoneUpdate(%id,%zone,%exit,%slient)
{
	%silent = True;
	if (!%exit) {
		if (!%silent)
			Client::SendMessage(%id,2,"You have entered " @ GetZoneData($ZoneInfo[%zone,$ZoneEnter],$ZoneDisp) @ ".");
		StoreData(%id,"zone",$ZoneInfo[%zone,$ZoneEnter]);
	}
	else {
		if (!%silent)
			Client::SendMessage(%id,2,"You have left " @ GetZoneData($ZoneInfo[%zone,$ZoneEnter],$ZoneDisp) @ ".");
		StoreData(%id,"zone",$ZoneInfo[%zone,$ZoneExit]);
	}
	if ($PassiveChange[%id] == 1)
		UpdatePassives(%id);
	Game::refreshClientScore(%id);
}

//=========================================================================================================================================================================

// OLD ZONE FUNCTIONS

function InitZones()
{
	return true;
}

function RecursiveZone(%delay)
{
	return true;
}

function DoZoneCheck(%w, %d)
{
	return true;
}

function setzoneflags(%object, %z)
{
	return true;
}

function UpdateZone(%object)
{
	return true;
}

function Zone::DoEnter(%z, %clientId)
{
	return true;
}

function Zone::DoExit(%z, %clientId)
{
	return true;
}

function Zone::getIndex(%z)
{
	return true;
}

function Zone::getMarker(%z)
{
	return true;
}
function Zone::getType(%z)
{
	return true;
}
function Zone::getDesc(%z)
{
	return true;
}

function Zone::getEnterSound(%z)
{
	return true;
}

function Zone::getAmbientSound(%z)
{
	return true;
}

function Zone::getAmbientSoundPerc(%z)
{
	return true;
}

function Zone::getExitSound(%z)
{
	return true;
}

function Zone::onEnter(%clientId, %oldZone, %newZone)
{
	return true;
}

function Zone::onExit(%clientId, %zoneLeft)
{
	return true;
}

function GetNearestZone(%clientId, %zonetype, %returnType)
{
	return true;
}

function GetZoneByKeywords(%clientId, %keywords, %returnType)
{
	return true;
}

function Zone::getNumPlayers(%z, %all)
{
	return true;
}

function ObjectInWhichZone(%object)
{
	return true;
}

function Zone::getPlayerList(%z, %type)
{
	return true;
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