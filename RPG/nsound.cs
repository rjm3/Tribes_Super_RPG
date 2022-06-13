//----------------------------------------------------------------------------
// IMPORTANT: 3d voice profile must go first (if voices are allowed)
SoundProfileData Profile3dVoice
{
   baseVolume = 0;
   minDistance = 10.0;
   maxDistance = 70.0;
   flags = SFX_IS_HARDWARE_3D;
};
//----------------------------------------------------------------------------

SoundProfileData Profile2d
{
   baseVolume = 0.0;
};

SoundProfileData Profile2dLoop
{
   baseVolume = 0.0;
   flags = SFX_IS_LOOPING;
};

SoundProfileData Profile3dNear
{
   baseVolume = 0;
   minDistance = 5.0;
   maxDistance = 40.0;
   flags = SFX_IS_HARDWARE_3D;
};

SoundProfileData Profile3dMedium
{
   baseVolume = 0;
   minDistance = 8.0;
   maxDistance = 100.0;
   flags = SFX_IS_HARDWARE_3D;
};

SoundProfileData Profile3dFar
{
   baseVolume = 0;
   minDistance = 8.0;
   maxDistance = 500.0;
   flags = SFX_IS_HARDWARE_3D;
};

SoundProfileData Profile3dFarLoud
{
   baseVolume = 10.0;
   minDistance = 8.0;
   maxDistance = 500.0;
   flags = SFX_IS_HARDWARE_3D;
};

SoundProfileData Profile3dLudicrouslyFar
{
   baseVolume = 0;
   minDistance = 2.0;
   maxDistance = 700.0;
   flags = SFX_IS_HARDWARE_3D;
};

SoundProfileData Profile3dNearLoop
{
   baseVolume = 0;
   minDistance = 2.0;
   maxDistance = 40.0;
   flags = { SFX_IS_HARDWARE_3D, SFX_IS_LOOPING };
};

SoundProfileData Profile3dMediumLoop
{
   baseVolume = 0;
   minDistance = 2.0;
   maxDistance = 100.0;
   flags = { SFX_IS_HARDWARE_3D, SFX_IS_LOOPING };
};

SoundProfileData Profile3dFoot
{
   baseVolume = 0;
   minDistance = 2.0;
   maxDistance = 30.0;
   flags = SFX_IS_HARDWARE_3D;
};

//RPG
SoundProfileData Profile3dFarLoop
{
   baseVolume = 0;
   minDistance = 2.0;
   maxDistance = 500.0;
   flags = { SFX_IS_HARDWARE_3D, SFX_IS_LOOPING };
};
SoundProfileData Profile3dVeryFarLoop
{
   baseVolume = 0;
   minDistance = 2.0;
   maxDistance = 1000.0;
   flags = { SFX_IS_HARDWARE_3D, SFX_IS_LOOPING };
};
SoundProfileData Profile3dVeryVeryFarLoop
{
   baseVolume = 0;
   minDistance = 2.0;
   maxDistance = 2500.0;
   flags = { SFX_IS_HARDWARE_3D, SFX_IS_LOOPING };
};
SoundProfileData Profile3dFarLoudLoop
{
   baseVolume = 10.0;
   minDistance = 8.0;
   maxDistance = 500.0;
   flags = { SFX_IS_HARDWARE_3D, SFX_IS_LOOPING };
};


SoundData SoundFire1
{
	wavFileName = "fire1.wav";
	profile = Profile3dFarLoudLoop;
};

SoundData SoundFire2
{
	wavFileName = "fire2.wav";
	profile = Profile3dNearLoop;
};

SoundData SoundWaterDrop1
{
	wavFileName = "waterdrop1.wav";
	profile = Profile3dNearLoop;
};

function InitSoundPoints()
{
	focusServer();
	%group = nameToID("MissionGroup\\SoundPoints");
	if (%group != -1)
	{
		for(%i = 0; %i <= Group::objectCount(%group)-1; %i++)
		{
		      	%this = Group::getObject(%group,%i);
			%info = Object::getName(%this);
			if (%info != "")
				GameBase::playSound(%this, %info, 0);
		}
	}
	focusClient();
}

function SoundPointLoop()
{
	echo("SOUNDPOINTLOOP");
	InitSoundPoints();
	schedule("SoundPointLoop();",5);
}

function TestSound(%id) 
{
	%pos = Gamebase::GetPosition(%id);
	%x = getWord(%pos,0);
	%y = getWord(%pos,1);
	%z = getWord(%pos,2);
	%r = floor(getRandom() * 200);
	if (floor(getRandom() * 2) > 0)
		%randx = %x + %r;
	else
		%randx = %x - %r;
	%r = floor(getRandom() * 200);
	if (floor(getRandom() * 2) > 0)
		%randy = %y + %r;
	else
		%randy = %y - %r;
	%r = floor(getRandom() * 200);
	if (floor(getRandom() * 2) > 0)
		%randz = %z + %r;
	else
		%randz = %z - %r;
	%newpos = %randx @ " " @ %randy @ " " @ %randz;
	%i = floor(getRandom() * 9 + 1);
	playSound("SoundCruBird" @ %i,%newpos);
}

function CruSoundFxLoop()
{
	echo("FX LOOP");
	for (%cl = Client::GetFirst(); %cl != -1; %cl = client::GetNext(%cl)) {
		%r = floor(getRandom() * 100 + 1);
		if (%r <= 17) {
			TestSound(%cl);
		}
	}
	schedule("CruSoundFxLoop();",10);
}

//schedule("CruSoundFxLoop();",10);

//----------------------------------------------------------------------------

SoundData SoundLandOnGround
{
   wavFileName = "Land_On_Ground.wav";
   profile = Profile3dNear;
};

SoundData SoundPlayerDeath
{
   wavFileName = "player_death.wav";
   profile = Profile3dMedium;
};

SoundData SoundJetLight
{
   wavFileName = "thrust.wav";
   profile = Profile3dMediumLoop;
};

SoundData SoundJetHeavy
{
   wavFileName = "heavy_thrust.wav";
   profile = Profile3dMediumLoop;
};

SoundData SoundRain
{
   wavFileName = "rain.wav";
   profile = Profile2dLoop;
};

SoundData SoundSnow
{
   wavFileName = "snow.wav";
   profile = Profile2dLoop;
};

SoundData SoundWindAmbient
{
   wavFileName = "wind1.wav";
   profile = Profile2dLoop;
};

SoundData SoundWindGust
{
   wavFileName = "wind2.wav";
   profile = Profile3dNear;
};

SoundData SoundShellClick
{
   wavFileName = "shell_click.wav";
   profile = Profile2d;
};

SoundData SoundShellHilight
{
   wavFileName = "shell_hilite.wav";
   profile = Profile2d;
};

//----------------------------------------------------------------------------
// foot sounds

SoundData SoundLFootRSoft
{
   wavFileName = "footsoft1.wav";
   profile = Profile3dFoot;
};

SoundData SoundLFootRHard
{
   wavFileName = "foothard1.wav";
   profile = Profile3dFoot;
};

SoundData SoundLFootRSnow
{
   wavFileName = "lfootrsnow.wav";
   profile = Profile3dFoot;
};

SoundData SoundLFootLSoft
{
   wavFileName = "footsoft2.wav";
   profile = Profile3dFoot;
};

SoundData SoundLFootLHard
{
   wavFileName = "foothard2.wav";
   profile = Profile3dFoot;
};

SoundData SoundLFootLSnow
{
   wavFileName = "lfootlsnow.wav";
   profile = Profile3dFoot;
};


SoundData SoundMFootRSoft
{
   wavFileName = "mfootrsoft.wav";
   profile = Profile3dFoot;
};

SoundData SoundMFootRHard
{
   wavFileName = "mfootrhard.wav";
   profile = Profile3dFoot;
};

SoundData SoundMFootRSnow
{
   wavFileName = "mfootrsnow.wav";
   profile = Profile3dFoot;
};

SoundData SoundMFootLSoft
{
   wavFileName = "mfootlsoft.wav";
   profile = Profile3dFoot;
};

SoundData SoundMFootLHard
{
   wavFileName = "mfootlhard.wav";
   profile = Profile3dFoot;
};

SoundData SoundMFootLSnow
{
   wavFileName = "mfootlsnow.wav";
   profile = Profile3dFoot;
};


SoundData SoundHFootRSoft
{
   wavFileName = "hfootrsoft.wav";
   profile = Profile3dFoot;
};

SoundData SoundHFootRHard
{
   wavFileName = "hfootrhard.wav";
   profile = Profile3dFoot;
};

SoundData SoundHFootRSnow
{
   wavFileName = "hfootrsnow.wav";
   profile = Profile3dFoot;
};

SoundData SoundHFootLSoft
{
   wavFileName = "hfootlsoft.wav";
   profile = Profile3dFoot;
};

SoundData SoundHFootLHard
{
   wavFileName = "hfootlhard.wav";
   profile = Profile3dFoot;
};

SoundData SoundHFootLSnow
{
   wavFileName = "hfootlsnow.wav";
   profile = Profile3dFoot;
};

//----------------------------------------------------------------------------
// RPG sounds

SoundData NoSound
{
   wavFileName = "";
   profile     = Profile3dNear;
};

SoundData SoundSpawn2
{
   wavFileName = "spawn2.wav";
   profile = Profile3dMedium;
};

SoundData SoundGrunt1
{
   wavFileName = "grunt1a.wav";
   profile = Profile3dNear;
};

SoundData SoundGrunt2
{
   wavFileName = "grunt2a.wav";
   profile = Profile3dNear;
};

SoundData SoundGrunt3
{
   wavFileName = "grunt3a.wav";
   profile = Profile3dNear;
};

SoundData SoundHarvest1
{
   wavFileName = "harvest1.wav";
   profile = Profile3dNearLoop;
};

SoundData SoundSplash1
{
   wavFileName = "water3.wav";
   profile = Profile3dMedium;
};

SoundData SoundSwing1
{
   wavFileName = "swish.wav";
   profile = Profile3dNear;
};
SoundData SoundSwing2
{
   wavFileName = "swish2.wav";
   profile = Profile3dNear;
};
SoundData SoundSwing3
{
   wavFileName = "swish3.wav";
   profile = Profile3dNear;
};
SoundData SoundSwing4
{
   wavFileName = "swish4.wav";
   profile = Profile3dNear;
};
SoundData SoundSwing5
{
   wavFileName = "swish5.wav";
   profile = Profile3dNear;
};
SoundData SoundSwing6
{
   wavFileName = "swish6.wav";
   profile = Profile3dNear;
};
SoundData SoundSwing7
{
   wavFileName = "swish7.wav";
   profile = Profile3dNear;
};

SoundData SoundSwordHit1
{
   wavFileName = "hit1.wav";
   profile = Profile3dNear;
};
SoundData SoundArrowHit1
{
   wavFileName = "arrowhit.wav";
   profile = Profile3dNear;
};
SoundData SoundHitFlesh
{
   wavFileName = "Hit_Flesh.wav";
   profile = Profile3dNear;
};
SoundData SoundHitLeather
{
   wavFileName = "Hit_Leather.wav";
   profile = Profile3dNear;
};
SoundData SoundHitChain
{
   wavFileName = "Hit_Chain.wav";
   profile = Profile3dNear;
};
SoundData SoundHitPlate
{
   wavFileName = "Hit_Plate.wav";
   profile = Profile3dNear;
};
SoundData SoundHitShield
{
   wavFileName = "Hit_Shield.wav";
   profile = Profile3dNear;
};

SoundData SoundMoney1
{
   wavFileName = "money.wav";
   profile = Profile3dNear;
};

SoundData SoundSmith
{
   wavFileName = "smith.wav";
   profile = Profile3dMedium;
};

SoundData SoundDrown1
{
   wavFileName = "drown1.wav";
   profile = Profile3dNear;
};

SoundData SoundDrown2
{
   wavFileName = "drown2.wav";
   profile = Profile3dNear;
};

SoundData SoundDrown3
{
   wavFileName = "h2odeath.wav";
   profile = Profile3dNear;
};

SoundData SoundHitore
{
   wavFileName = "hitore.wav";
   profile = Profile3dNear;
};
SoundData SoundHitore2
{
   wavFileName = "hitore2.wav";
   profile = Profile3dNear;
};

//=== WOT SOUNDS ================================

//explosion with little rocks at the end
SoundData ExplodeLM
{
   wavFileName = "ExplodeLM.wav";
   profile     = Profile3dFar;
};

//Power-up like sound
SoundData ActivateBF
{
   wavFileName = "ActivateBF.wav";
   profile     = Profile3dNear;
};

//6.7 second loop
SoundData LoopWA
{
   wavFileName = "LoopWA.wav";
   profile     = Profile3dNear;
};

SoundData Portal11
{
   wavFileName = "Portal11.wav";
   profile     = Profile3dNear;
};

SoundData ActivateCH
{
   wavFileName = "ActivateCH.wav";
   profile     = Profile3dNear;
};

SoundData ActivateAR
{
   wavFileName = "ActivateAR.wav";
   profile     = Profile3dNear;
};

SoundData DeActivateWA
{
   wavFileName = "DeActivateWA.wav";
   profile     = Profile3dNear;
};

SoundData HitBF
{
   wavFileName = "HitBF.wav";
   profile     = Profile3dNear;
};

SoundData HitLevelDT
{
   wavFileName = "HitLevelDT.wav";
   profile     = Profile3dNear;
};

SoundData ActivateFK
{
   wavFileName = "ActivateFK.wav";
   profile     = Profile3dNear;
};

SoundData DeflectAS
{
   wavFileName = "DeflectAS.wav";
   profile     = Profile3dNear;
};

SoundData ActivateAB
{
   wavFileName = "ActivateAB.wav";
   profile     = Profile3dNear;
};

SoundData LaunchFB
{
   wavFileName = "LaunchFB.wav";
   profile     = Profile3dFar;
};

SoundData HitPawnDT
{
   wavFileName = "HitPawnDT.wav";
   profile     = Profile3dNear;
};

SoundData ImpactTR
{
   wavFileName = "ImpactTR.wav";
   profile     = Profile3dNear;
};

SoundData Reflected
{
   wavFileName = "Reflected.wav";
   profile     = Profile3dNear;
};

SoundData UnravelAM
{
   wavFileName = "UnravelAM.wav";
   profile     = Profile3dNear;
};

SoundData LaunchLS
{
   wavFileName = "LaunchLS.wav";
   profile     = Profile3dNear;
};

SoundData LaunchET
{
   wavFileName = "LaunchET.wav";
   profile     = Profile3dMedium;
};

SoundData LoopLS
{
   wavFileName = "LoopLS.wav";
   profile     = Profile3dNear;
};

SoundData Explode3FW
{
   wavFileName = "Explode3FW.wav";
   profile     = Profile3dFarLoud;
};

SoundData LoopLG
{
   wavFileName = "LoopLG.wav";
   profile = Profile3dNearLoop;
};

SoundData LoopLT
{
   wavFileName = "LoopLT.wav";
   profile = Profile3dNearLoop;
};

SoundData PortalLoop1
{
   wavFileName = "PortalLoop1.wav";
   profile = Profile3dNearLoop;
};

SoundData PortalLoop3
{
   wavFileName = "PortalLoop3.wav";
   profile = Profile3dNearLoop;
};

SoundData River
{
   wavFileName = "River.wav";
   profile = Profile3dVeryFarLoop;
};

SoundData Windy
{
   wavFileName = "Windy.wav";
   profile = Profile3dVeryFarLoop;
};

SoundData Windy2
{
   wavFileName = "Windy2.wav";
   profile = Profile3dVeryFarLoop;
};

SoundData Moutain
{
   wavFileName = "Mountain.wav";
   profile = Profile3dVeryVeryFarLoop;
};

SoundData LightWind
{
   wavFileName = "LightWind.wav";
   profile = Profile3dVeryVeryFarLoop;
};

SoundData RespawnA
{
   wavFileName = "RespawnA.wav";
   profile     = Profile3dNear;
};

SoundData RespawnB
{
   wavFileName = "RespawnB.wav";
   profile     = Profile3dNear;
};

SoundData RespawnC
{
   wavFileName = "RespawnC.wav";
   profile     = Profile3dNear;
};

SoundData DeActivateDG
{
   wavFileName = "DeActivateDG.wav";
   profile     = Profile3dNear;
};

SoundData Portal6
{
   wavFileName = "Portal6.wav";
   profile     = Profile3dNear;
};

SoundData LoopDT
{
   wavFileName = "LoopDT.wav";
   profile = Profile3dMediumLoop;
};

SoundData PlaceSeal
{
   wavFileName = "PlaceSeal.wav";
   profile     = Profile3dNear;
};

SoundData ActivateTR
{
   wavFileName = "ActivateTR.wav";
   profile     = Profile3dNear;
};

SoundData ActivateTD
{
   wavFileName = "ActivateTD.wav";
   profile     = Profile3dNear;
};

SoundData BonusStateExpire
{
   wavFileName = "DeActivateIC.wav";
   profile     = Profile3dNear;
};

SoundData AbsorbABS
{
   wavFileName = "AbsorbABS.wav";
   profile     = Profile3dNear;
};

SoundData LoopSP
{
   wavFileName = "LoopSP.wav";
   profile     = Profile3dNear;
};

SoundData ActivateAS
{
   wavFileName = "ActivateAS.wav";
   profile     = Profile3dNear;
};

//crossbow firing sound
SoundData CrossbowShoot1
{
   wavFileName = "Crossbow_Shoot1.wav";
   profile     = Profile3dNear;
};

//crossbow switching sound
SoundData CrossbowSwitch1
{
   wavFileName = "Crossbow_Switch1.wav";
   profile     = Profile3dNear;
};

//crossbow hitting sound
SoundData SoundArrowHit2
{
   wavFileName = "Crossbow_HitWall1.wav";
   profile = Profile3dNear;
};

//axe slashing
SoundData AxeSlash2
{
   wavFileName = "Axe_Slash2.wav";
   profile = Profile3dNear;
};

//high pitch ooooo loop
SoundData SoundGliders
{
   wavFileName = "Gliders.wav";
   profile = Profile3dMediumLoop;
};

//loud wind-like loop
SoundData SoundWindWalkers
{
   wavFileName = "WindWalkers.wav";
   profile = Profile3dMediumLoop;
};

//boat sound
SoundData SoundBoat
{
   wavFileName = "AmbBoat2m.wav";
   profile = Profile3dMediumLoop;
};

SoundData SoundFountain
{
   wavFileName = "fountain.wav";
   profile = Profile3dMediumLoop;
};
SoundData SoundFeast
{
   wavFileName = "feast.wav";
   profile = Profile3dFar;
};

SoundData SoundLevelUp
{
   wavFileName = "LevelUp.wav";
   profile = Profile3dNear;
};

//OGRE SOUNDS
SoundData SoundOgreDeath1
{
	wavFileName = "OgreDeath1.wav";
	profile = Profile3dNear;
};
SoundData SoundOgreAcquired1
{
	wavFileName = "OgreAcquired1.wav";
	profile = Profile3dNear;
};
SoundData SoundOgreAcquired2
{
	wavFileName = "OgreAcquired2.wav";
	profile = Profile3dNear;
};
SoundData SoundOgreHit1
{
	wavFileName = "OgreHit1.wav";
	profile = Profile3dNear;
};
SoundData SoundOgreHit2
{
	wavFileName = "OgreHit2.wav";
	profile = Profile3dNear;
};
SoundData SoundOgreTaunt1
{
	wavFileName = "OgreTaunt1.wav";
	profile = Profile3dNear;
};
SoundData SoundOgreTaunt2
{
	wavFileName = "OgreTaunt2.wav";
	profile = Profile3dNear;
};
SoundData SoundOgreRandom1
{
	wavFileName = "OgreRandom1.wav";
	profile = Profile3dNear;
};
SoundData SoundOgreRandom2
{
	wavFileName = "OgreRandom2.wav";
	profile = Profile3dNear;
};

//UNDEAD SOUNDS
SoundData SoundUndeadDeath1
{
	wavFileName = "UndeadDeath1.wav";
	profile = Profile3dNear;
};
SoundData SoundUndeadAcquired1
{
	wavFileName = "UndeadAcquired1.wav";
	profile = Profile3dNear;
};
SoundData SoundUndeadRandom1
{
	wavFileName = "UndeadRandom1.wav";
	profile = Profile3dNear;
};
SoundData SoundUndeadTaunt1
{
	wavFileName = "UndeadTaunt1.wav";
	profile = Profile3dNear;
};
SoundData SoundUndeadHit1
{
	wavFileName = "UndeadHit1.wav";
	profile = Profile3dNear;
};
SoundData SoundUndeadHit2
{
	wavFileName = "UndeadHit2.wav";
	profile = Profile3dNear;
};

//TRAVELLER SOUNDS
SoundData SoundTravellerDeath1
{
	wavFileName = "TravellerDeath1.wav";
	profile = Profile3dNear;
};
SoundData SoundTravellerAcquired1
{
	wavFileName = "TravellerAcquired1.wav";
	profile = Profile3dNear;
};
SoundData SoundTravellerAcquired2
{
	wavFileName = "TravellerAcquired2.wav";
	profile = Profile3dNear;
};
SoundData SoundTravellerAcquired3
{
	wavFileName = "TravellerAcquired3.wav";
	profile = Profile3dNear;
};
SoundData SoundTravellerHit1
{
	wavFileName = "TravellerHit1.wav";
	profile = Profile3dNear;
};
SoundData SoundTravellerHit2
{
	wavFileName = "TravellerHit2.wav";
	profile = Profile3dNear;
};
SoundData SoundTravellerHit3
{
	wavFileName = "TravellerHit3.wav";
	profile = Profile3dNear;
};

//UBER SOUNDS
SoundData SoundUberDeath1
{
	wavFileName = "UberDeath1.wav";
	profile = Profile3dNear;
};
SoundData SoundUberAcquired1
{
	wavFileName = "UberAcquired1.wav";
	profile = Profile3dNear;
};
SoundData SoundUberAcquired2
{
	wavFileName = "UberAcquired2.wav";
	profile = Profile3dNear;
};
SoundData SoundUberHit1
{
	wavFileName = "UberHit1.wav";
	profile = Profile3dNear;
};
SoundData SoundUberRandom1
{
	wavFileName = "UberRandom1.wav";
	profile = Profile3dNear;
};

//MINOTAUR SOUNDS
SoundData SoundMinotaurDeath1
{
	wavFileName = "MinotaurDeath1.wav";
	profile = Profile3dNear;
};
SoundData SoundMinotaurAcquired1
{
	wavFileName = "MinotaurAcquired1.wav";
	profile = Profile3dNear;
};
SoundData SoundMinotaurAcquired2
{
	wavFileName = "MinotaurAcquired2.wav";
	profile = Profile3dNear;
};
SoundData SoundMinotaurHit1
{
	wavFileName = "MinotaurHit1.wav";
	profile = Profile3dNear;
};

//GOBLIN SOUNDS
SoundData SoundGoblinDeath1
{
	wavFileName = "GoblinDeath1.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinDeath2
{
	wavFileName = "GoblinDeath2.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinAcquired1
{
	wavFileName = "GoblinAcquired1.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinAcquired2
{
	wavFileName = "GoblinAcquired2.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinAcquired3
{
	wavFileName = "GoblinAcquired3.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinTaunt1
{
	wavFileName = "GoblinTaunt1.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinRandom1
{
	wavFileName = "GoblinRandom1.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinHit1
{
	wavFileName = "GoblinHit1.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinHit2
{
	wavFileName = "GoblinHit2.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinHit3
{
	wavFileName = "GoblinHit3.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinHit4
{
	wavFileName = "GoblinHit4.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinHit5
{
	wavFileName = "GoblinHit5.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinHit6
{
	wavFileName = "GoblinHit6.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinHit7
{
	wavFileName = "GoblinHit7.wav";
	profile = Profile3dNear;
};
SoundData SoundGoblinHit8
{
	wavFileName = "GoblinHit8.wav";
	profile = Profile3dNear;
};

//GNOLL SOUNDS
SoundData SoundGnollDeath1
{
	wavFileName = "GnollDeath1.wav";
	profile = Profile3dNear;
};
SoundData SoundGnollDeath2
{
	wavFileName = "GnollDeath2.wav";
	profile = Profile3dNear;
};
SoundData SoundGnollAcquired1
{
	wavFileName = "GnollAcquired1.wav";
	profile = Profile3dNear;
};
SoundData SoundGnollTaunt1
{
	wavFileName = "GnollTaunt1.wav";
	profile = Profile3dNear;
};
SoundData SoundGnollRandom1
{
	wavFileName = "GnollRandom1.wav";
	profile = Profile3dNear;
};
SoundData SoundGnollRandom2
{
	wavFileName = "GnollRandom2.wav";
	profile = Profile3dNear;
};
SoundData SoundGnollHit1
{
	wavFileName = "GnollHit1.wav";
	profile = Profile3dNear;
};
SoundData SoundGnollHit2
{
	wavFileName = "GnollHit2.wav";
	profile = Profile3dNear;
};

SoundData SoundCanSmith
{
	wavFileName = "canSmith.wav";
	profile = Profile3dNear;
};

SoundData MClip5
{
	wavFileName = "mclip5.wav";
	profile = Profile3dNear;
};
SoundData MClip6
{
	wavFileName = "mclip6.wav";
	profile = Profile3dNear;
};
//================================================

function InitSoundPoints()
{
	dbecho($dbechoMode, "InitSoundPoints()");

	%group = nameToID("MissionGroup\\SoundPoints");

	if(%group != -1)
	{
		for(%i = 0; %i <= Group::objectCount(%group)-1; %i++)
		{
		      %this = Group::getObject(%group, %i);
			%info = Object::getName(%this);

			if(%info != "")
			{
				GameBase::playSound(%this, %info, 0);
				//echo("Playing sound " @ %info @ " for object " @ %this);
			}
		}
	}
}
function RandomRaceSound(%race, %type)
{
	for(%i = 1; $RaceSound[%race, %type, %i] != ""; %i++){}
	%i--;

	%r = floor(getRandom() * %i) + 1;
	%s = $RaceSound[%race, %type, %r];

	if(%s != "")
		return %s;
	else
		return "NoSound";
}

//================================================

SoundData SoundHitWoodShield
{
	wavFileName = "0303.wav";
	profile = Profile3dNear;
};

SoundData SoundHitMetalShield
{
	wavFileName = "0305.wav";
	profile = Profile3dNear;
};

//================================================

SoundData Spell1
{
   wavFileName = "Spell1.wav";
   profile     = Profile3dMedium;
};

SoundData Spell3
{
   wavFileName = "Spell3.wav";
   profile     = Profile3dMedium;
};

SoundData Spell4
{
   wavFileName = "Spell4.wav";
   profile     = Profile3dMedium;
};

SoundData Spell5
{
   wavFileName = "Spell5.wav";
   profile     = Profile3dMedium;
};

SoundData Spell6
{
   wavFileName = "Spell6.wav";
   profile     = Profile3dMedium;
};


SoundData Spell7
{
   wavFileName = "Spell7.wav";
   profile     = Profile3dMedium;
};

SoundData Spell8
{
   wavFileName = "Spell8.wav";
   profile     = Profile3dMedium;
};

SoundData Spell9
{
   wavFileName = "Spell9.wav";
   profile     = Profile3dMedium;
};

SoundData Spell10
{
   wavFileName = "Spell10.wav";
   profile     = Profile3dMedium;
};

SoundData Spell11
{
   wavFileName = "Spell11.wav";
   profile     = Profile3dMedium;
};

SoundData Spell15
{
   wavFileName = "Spell15.wav";
   profile     = Profile3dMedium;
};

SoundData Spell16
{
   wavFileName = "Spell16.wav";
   profile     = Profile3dMedium;
};

SoundData Spell17
{
   wavFileName = "Spell17.wav";
   profile     = Profile3dMedium;
};

SoundData Spell18
{
   wavFileName = "Spell18.wav";
   profile     = Profile3dMedium;
};

SoundData Spell19
{
   wavFileName = "Spell19.wav";
   profile     = Profile3dMedium;
};

SoundData Spell20
{
   wavFileName = "Spell20.wav";
   profile     = Profile3dMedium;
};

SoundData Spell21
{
   wavFileName = "Spell21.wav";
   profile     = Profile3dMedium;
};

SoundData Spell22
{
   wavFileName = "Spell22.wav";
   profile     = Profile3dMedium;
};

SoundData Spell23
{
   wavFileName = "Spell23.wav";
   profile     = Profile3dMedium;
};

SoundData Spell24
{
   wavFileName = "Spell24.wav";
   profile     = Profile3dMedium;
};

SoundData Spell25
{
   wavFileName = "Spell25.wav";
   profile     = Profile3dMedium;
};

SoundData Spell27
{
   wavFileName = "Spell27.wav";
   profile     = Profile3dMedium;
};

SoundData Spell28
{
   wavFileName = "Spell28.wav";
   profile     = Profile3dMedium;
};

SoundData Spell29
{
   wavFileName = "Spell29.wav";
   profile     = Profile3dMedium;
};


SoundData Spell30
{
   wavFileName = "Spell30.wav";
   profile     = Profile3dMedium;
};

SoundData Spell31
{
   wavFileName = "Spell31.wav";
   profile     = Profile3dMedium;
};

SoundData Spell32
{
   wavFileName = "Spell32.wav";
   profile     = Profile3dMedium;
};

SoundData Spell33
{
   wavFileName = "Spell33.wav";
   profile     = Profile3dMedium;
};

SoundData Spell35
{
   wavFileName = "Spell35.wav";
   profile     = Profile3dMedium;
};

SoundData Spell36
{
   wavFileName = "Spell36.wav";
   profile     = Profile3dMedium;
};

SoundData Spell37
{
   wavFileName = "Spell37.wav";
   profile     = Profile3dMedium;
};

SoundData Spell40
{
   wavFileName = "Spell40.wav";
   profile     = Profile3dMedium;
};

SoundData Spell41
{
   wavFileName = "Spell41.wav";
   profile     = Profile3dMedium;
};

SoundData Spell43
{
   wavFileName = "Spell43.wav";
   profile     = Profile3dMedium;
};

SoundData Spell44
{
   wavFileName = "Spell44.wav";
   profile     = Profile3dMedium;
};

SoundData FlickerWoosh
{
   wavFileName = "FlickerWoosh.wav";
   profile     = Profile3dMedium;
};

SoundData Spell45
{
   wavFileName = "Spell45.wav";
   profile     = Profile3dMedium;
};

SoundData Spell46
{
   wavFileName = "Spell46.wav";
   profile     = Profile3dMedium;
};

SoundData Spell47
{
   wavFileName = "Spell47.wav";
   profile     = Profile3dMedium;
};

SoundData Spell48
{
   wavFileName = "Spell48.wav";
   profile     = Profile3dMedium;
};

SoundData Spell49
{
   wavFileName = "Spell49.wav";
   profile     = Profile3dMedium;
};

SoundData Spell50
{
   wavFileName = "Spell50.wav";
   profile     = Profile3dMedium;
};

SoundData Spell51
{
   wavFileName = "Spell51.wav";
   profile     = Profile3dMedium;
};

SoundData Spell52
{
   wavFileName = "Spell52.wav";
   profile     = Profile3dMedium;
};

SoundData Spell53
{
   wavFileName = "Spell53.wav";
   profile     = Profile3dMedium;
};

SoundData Sound0301
{
   wavFileName = "0301.wav";
   profile     = Profile3dMedium;
};

SoundData Sound0201
{
   wavFileName = "0201.wav";
   profile     = Profile3dMedium;
};

SoundData Sound0300
{
   wavFileName = "0300.wav";
   profile     = Profile3dMedium;
};

SoundData Sound0326
{
   wavFileName = "0326.wav";
   profile     = Profile3dMedium;
};

SoundData SoundFreeze
{
   wavFileName = "SoundFreeze.wav";
   profile     = Profile3dMedium;
};

SoundData Sound0735
{
   wavFileName = "0735.wav";
   profile     = Profile3dMedium;
};
