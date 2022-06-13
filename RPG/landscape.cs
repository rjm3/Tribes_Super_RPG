// LANDSCAPE

// 0.066 0.407 0.992 BRIGHT BLUE
// 0 0.368 1 BRIGHT BLUE 2
// 0.031 0.117 0.690 TRUE BLUE
// 0.956 0.643 0.376 SANDY DUSK
// 0.690 0.768 0.870 STEEL BLUE

function CruSetupSoundLoops()
{
	CruLoopSound("SoundFire2","457.194 -547.302 130","5.9");
}

function CruLoopSound(%sound,%pos,%loop)
{
	GameBase::playSound(%sound,%pos,0);
	schedule("cruloopsound(\""@%sound@"\",\""@%pos@"\",\""@%loop@"\");",%loop);
}


function CruSetupLandscape()
{
	// SETUP LIGHTS
	instant SimLight "klight1" {
		type = "2";
		range = "1";
		color = "1 0.299996 0";
		ambient = "0 0 0";
		position = "457.194 -547.302 130";
		aim = "-NAN -NAN -NAN";
		isStatic = "False";
	};
	//addToSet("MissionCleanup", "klight1");
}


function Landscape::Reset()
{
	focusserver();
	deleteObject("Ghost Group\\Sky");
	deleteObject("MissionGroup\\Landscape\\Sun");
	deleteObject("MissionGroup\\Landscape\\Sky");
	deleteObject("MissionGroup\\World\\Palette");
	deleteObject("MissionGroup\\Landscape\\stars1");
	deleteObject("MissionGroup\\Landscape\\rain1");
}

function Landscape::Change(%type,%time)
{
	focusServer();
	Landscape::Reset();
	if (%type == "RAIN") {
		if (%time == "DAY") Landscape::RainDay();
		if (%time == "NIGHT") Landscape::RainNight();
	}
	if (%type == "CLEAR") {
		if (%time == "DAY") Landscape::ClearDay();
	}
	if (%type == "BLUE") {
		if (%time == "NIGHT") Landscape::BlueNight();
	}
	focusClient();
}

function Landscape::ClearDay()
{
	focusServer();
	%skyname = "";
	instant Planet "Sun" {
		fileName = "";
		azimuth = "0";
		incidence = "60";
		castShadows = "True";
		useLensFlare = "False";
		intensity = "0.299685 0.299685 0.299685";
		ambient = "0.149685 0.149685 0.149685";
		size = "2000";
		distance = "11000";
	};
	instant Sky "Sky" {
		dmlName = %skyname;
		skyColor = "0.399999 0.399999 0.999999";
		hazeColor = "0 0 0";
		featurePosition = "0";
		size = "3200";
		textures[0] = "0";
		textures[1] = "1";
		textures[2] = "2";
		textures[3] = "3";
		textures[4] = "4";
		textures[5] = "5";
		textures[6] = "6";
		textures[7] = "7";
		textures[8] = "8";
		textures[9] = "9";
		textures[10] = "10";
		textures[11] = "11";
		textures[12] = "12";
		textures[13] = "13";
		textures[14] = "14";
		textures[15] = "15";
	};
	instant SimPalette "Palette" {
		fileName = "lush.day.ppl";
	};
	addToSet("MissionGroup\\Landscape", "Sun");
	addToSet("GhostGroup\\Landscape", "Sky");
	addToSet("MissionGroup\\World", "Palette");
}

function Landscape::BlueNight()
{
	focusServer();
	%skyname = "";
	instant Planet "Sun" {
		fileName = "";
		azimuth = "0";
		incidence = "60";
		castShadows = "True";
		useLensFlare = "False";
		intensity = "0.299685 0.299685 0.299685";
		ambient = "0.149685 0.149685 0.149685";
		size = "2000";
		distance = "11000";
	};
	instant Sky "Sky" {
		dmlName = %skyname;
		skyColor = "0 1 0";
		hazeColor = "0 0 0";
		featurePosition = "0";
		size = "3200";
		textures[0] = "0";
		textures[1] = "1";
		textures[2] = "2";
		textures[3] = "3";
		textures[4] = "4";
		textures[5] = "5";
		textures[6] = "6";
		textures[7] = "7";
		textures[8] = "8";
		textures[9] = "9";
		textures[10] = "10";
		textures[11] = "11";
		textures[12] = "12";
		textures[13] = "13";
		textures[14] = "14";
		textures[15] = "15";
	};
	instant SimPalette "Palette" {
		fileName = "lush.night.ppl";
	};
	addToSet("MissionGroup\\Landscape", "Sun");
	addToSet("GhostGroup\\Landscape", "Sky");
	addToSet("MissionGroup\\World", "Palette");
}


function Landscape::RainDay()
{
	%skyname = "";
	instant Planet "Sun" {
		fileName = "";
		azimuth = "0";
		incidence = "60";
		castShadows = "True";
		useLensFlare = "False";
		intensity = "0.299685 0.299685 0.299685";
		ambient = "0.149685 0.149685 0.149685";
		size = "2000";
		distance = "11000";
	};
	instant Sky "Sky" {
		dmlName = %skyname;
		skyColor = "0.399999 0.399999 0.399999";
		hazeColor = "0 0 0";
		featurePosition = "0";
		size = "3200";
		textures[0] = "0";
		textures[1] = "1";
		textures[2] = "2";
		textures[3] = "3";
		textures[4] = "4";
		textures[5] = "5";
		textures[6] = "6";
		textures[7] = "7";
		textures[8] = "8";
		textures[9] = "9";
		textures[10] = "10";
		textures[11] = "11";
		textures[12] = "12";
		textures[13] = "13";
		textures[14] = "14";
		textures[15] = "15";
	};
	instant SimPalette "Palette" {
		fileName = "lush.day.ppl";
	};
	addToSet("MissionGroup\\Landscape", "Sun");
	addToSet("GhostGroup\\Landscape", "Sky");
	addToSet("MissionGroup\\World", "Palette");
	instant Snowfall "rain1" {
		intensity = "1";
		wind = "-0.219999 0.149999 -75";
		suspendRendering = "False";
		rain = "True";
		locked = "true";
	};
	addToSet("MissionGroup\\Landscape", "rain1");
}


function TimeOfDay(%time)
{
	focusServer();

	if (%time == 0) {
		// CREATE DAY

		%skyname = "litesky.dml";

		deleteObject("MissionGroup\\Landscape\\Sun");
		deleteObject("MissionGroup\\Landscape\\Sky");
		deleteObject("MissionGroup\\World\\Palette");
		deleteObject("MissionGroup\\Landscape\\stars1");

		instant Planet "Sun" {
			fileName = "";
			azimuth = "0";
			incidence = "60";
			castShadows = "True";
			useLensFlare = "False";
			intensity = "0.299685 0.299685 0.299685";
			ambient = "0.149685 0.149685 0.149685";
			size = "2000";
			distance = "11000";
		};

		instant Sky "Sky" {
			dmlName = %skyname;
			skyColor = "0 0 0";
			hazeColor = "0 0 0";
			featurePosition = "0";
			size = "3200";
			textures[0] = "0";
			textures[1] = "1";
			textures[2] = "2";
			textures[3] = "3";
			textures[4] = "4";
			textures[5] = "5";
			textures[6] = "6";
			textures[7] = "7";
			textures[8] = "8";
			textures[9] = "9";
			textures[10] = "10";
			textures[11] = "11";
			textures[12] = "12";
			textures[13] = "13";
			textures[14] = "14";
			textures[15] = "15";
		};

		instant SimPalette "Palette" {
			fileName = "lush.day.ppl";
		};

		addToSet("MissionGroup\\Landscape", "Sun");
		addToSet("GhostGroup\\Landscape", "Sky");
		addToSet("MissionGroup\\World", "Palette");
	}
	else {
		// CREATE NIGHT

		%skyname = "lushsky_night.dml";

		deleteObject("MissionGroup\\Landscape\\Sun");
		deleteObject("MissionGroup\\Landscape\\Sky");
		deleteObject("MissionGroup\\World\\Palette");

		instant Planet "Sun" {
			fileName = "";
			azimuth = "0";
			incidence = "60";
			castShadows = "True";
			useLensFlare = "False";
			intensity = "0.299685 0.299685 0.299685";
			ambient = "0.149685 0.149685 0.149685";
			size = "2000";
			distance = "11000";
		};

		instant Sky "Sky" {
			dmlName = %skyname;
			skyColor = "0 0 0";
			hazeColor = "0 0 0";
			featurePosition = "0";
			size = "3200";
			textures[0] = "0";
			textures[1] = "1";
			textures[2] = "2";
			textures[3] = "3";
			textures[4] = "4";
			textures[5] = "5";
			textures[6] = "6";
			textures[7] = "7";
			textures[8] = "8";
			textures[9] = "9";
			textures[10] = "10";
			textures[11] = "11";
			textures[12] = "12";
			textures[13] = "13";
			textures[14] = "14";
			textures[15] = "15";
		};
		
		instant StarField "stars1" {
			inFrontOfSky = "False";
			colors[0] = "1 1 1";
			colors[1] = "0.5 0.5 0.5";
			colors[2] = "0.5 0.5 0.5";
		};

		instant SimPalette "Palette" {
			fileName = "lush.night.ppl";
		};

		addToSet("MissionGroup\\Landscape", "Sun");
		addToSet("GhostGroup\\Landscape", "Sky");
		addToSet("MissionGroup\\Landscape", "stars1");
		addToSet("MissionGroup\\World", "Palette");
	}

	focusClient();
}

function BlackSky()
{
	focusserver();
	deleteObject("MissionGroup\\Landscape\\Sky");
	deleteObject("MissionGroup\\Landscape\\stars1");
		instant Sky "Sky" {
			dmlName = "";
			skyColor = "0 0 0";
			hazeColor = "0 0 0";
			featurePosition = "0";
			size = "3200";
			textures[0] = "0";
			textures[1] = "1";
			textures[2] = "2";
			textures[3] = "3";
			textures[4] = "4";
			textures[5] = "5";
			textures[6] = "6";
			textures[7] = "7";
			textures[8] = "8";
			textures[9] = "9";
			textures[10] = "10";
			textures[11] = "11";
			textures[12] = "12";
			textures[13] = "13";
			textures[14] = "14";
			textures[15] = "15";
		};


}

function RainyDay()
{
		
		focusserver();
		%skyname = "";

		deleteObject("MissionGroup\\Landscape\\Sun");
		deleteObject("MissionGroup\\Landscape\\Sky");
		deleteObject("MissionGroup\\World\\Palette");
		deleteObject("MissionGroup\\Landscape\\stars1");

		instant Planet "Sun" {
			fileName = "";
			azimuth = "0";
			incidence = "60";
			castShadows = "True";
			useLensFlare = "False";
			intensity = "0.299685 0.299685 0.299685";
			ambient = "0.149685 0.149685 0.149685";
			size = "2000";
			distance = "11000";
		};

		instant Sky "Sky" {
			dmlName = %skyname;
			skyColor = "0.399999 0.399999 0.399999";
			hazeColor = "0 0 0";
			featurePosition = "0";
			size = "3200";
			textures[0] = "0";
			textures[1] = "1";
			textures[2] = "2";
			textures[3] = "3";
			textures[4] = "4";
			textures[5] = "5";
			textures[6] = "6";
			textures[7] = "7";
			textures[8] = "8";
			textures[9] = "9";
			textures[10] = "10";
			textures[11] = "11";
			textures[12] = "12";
			textures[13] = "13";
			textures[14] = "14";
			textures[15] = "15";
		};

		instant SimPalette "Palette" {
			fileName = "lush.day.ppl";
		};

		addToSet("MissionGroup\\Landscape", "Sun");
		addToSet("GhostGroup\\Landscape", "Sky");
		addToSet("MissionGroup\\World", "Palette");
}

function CruRain(%a)
{
	focusserver();
	if (%a == 1) {
		instant Snowfall "rain1" {
			intensity = "1";
			wind = "-0.219999 0.149999 -75";
			suspendRendering = "False";
			rain = "True";
			locked = "true";
		};
		addToSet("MissionGroup\\Landscape", "rain1");
	}
	else {
		deleteObject("MissionGroup\\Landscape\\rain1");
	}
}

deleteObject("Ghost Group\\Sky");