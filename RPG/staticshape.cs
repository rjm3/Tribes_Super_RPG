//------------------------------------------------------------------------
// Generic static shapes
//------------------------------------------------------------------------


//------------------------------------------------------------------------
// Default power animation behavior for all static shapes

function StaticShape::onPower(%this,%power,%generator)
{
	if (%power) 
		GameBase::playSequence(%this,0,"power");
	else 
		GameBase::stopSequence(%this,0);
}

function StaticShape::onEnabled(%this)
{
	if (GameBase::isPowered(%this)) 
		GameBase::playSequence(%this,0,"power");
}

function StaticShape::onDisabled(%this)
{
	GameBase::stopSequence(%this,0);
}

function StaticShape::onDestroyed(%this)
{
	$owner[%this] = "";
	GameBase::stopSequence(%this,0);
	StaticShape::objectiveDestroyed(%this);
	calcRadiusDamage(%this, $DebrisDamageType, 2.5, 0.05, 25, 13, 2, 0.40, 0.1, 250, 100); 
}

function StaticShape::onDamage(%this,%type,%value,%pos,%vec,%mom,%object)
{
	%damageLevel = GameBase::getDamageLevel(%this);
	%dValue = %damageLevel + %value;
   %this.lastDamageObject = %object;
   %this.lastDamageTeam = GameBase::getTeam(%object);
	if(GameBase::getTeam(%this) == GameBase::getTeam(%object)) {
		%name = GameBase::getDataName(%this);
		if(%name.className == Generator || %name.className == Station) { 
			%TDS = $Server::TeamDamageScale;
			%dValue = %damageLevel + %value * %TDS;
			%disable = GameBase::getDisabledDamage(%this);
			if(!$Server::TourneyMode && %dValue > %disable - 0.05) {
            if(%damageLevel > %disable - 0.05)
               return;
            else
               %dValue = %disable - 0.05;
			}
		}
	}
	else
	{
		GameBase::setDamageLevel(%this,%dValue);
	}
}

function StaticShape::shieldDamage(%this,%type,%value,%pos,%vec,%mom,%object)
{
	%damageLevel = GameBase::getDamageLevel(%this);
   %this.lastDamageObject = %object;
   %this.lastDamageTeam = GameBase::getTeam(%object);
	if (%this.shieldStrength) {
		%energy = GameBase::getEnergy(%this);
		%strength = %this.shieldStrength;
		if (%type == $ShrapnelDamageType)
			%strength *= 0.5;
		else
			if (%type == $MortarDamageType)
				%strength *= 0.25;
			else
				if (%type == $BlasterDamageType)
					%strength *= 2.0;
		%absorb = %energy * %strength;
		if (%value < %absorb) {
			GameBase::setEnergy(%this,%energy - (%value / %strength));
			%centerPos = getBoxCenter(%this);
			%sphereVec = findPointOnSphere(getBoxCenter(%object),%centerPos,%vec,%this);
			%centerPosX = getWord(%centerPos,0);
			%centerPosY = getWord(%centerPos,1);
			%centerPosZ = getWord(%centerPos,2);

			%pointX = getWord(%pos,0);
			%pointY = getWord(%pos,1);
			%pointZ = getWord(%pos,2);

			%newVecX = %centerPosX - %pointX;
			%newVecY = %centerPosY - %pointY;
			%newVecZ = %centerPosZ - %pointZ;
			%norm = Vector::normalize(%newVecX @ " " @ %newVecY @ " " @ %newVecZ);
			%zOffset = 0;
			if(GameBase::getDataName(%this) == PulseSensor)
				%zOffset = (%pointZ-%centerPosZ) * 0.5;
			GameBase::activateShield(%this,%sphereVec,%zOffset);
		}
		else {
			GameBase::setEnergy(%this,0);
			StaticShape::onDamage(%this,%type,%value - %absorb,%pos,%vec,%mom,%object);
		}
	}
	else {
		StaticShape::onDamage(%this,%type,%value,%pos,%vec,%mom,%object);
	}
}

StaticShapeData FlagStand
{
   description = "Flag Stand";
	shapeFile = "flagstand";
	visibleToSensor = false;
};


function calcRadiusDamage(%this,%type,%radiusRatio,%damageRatio,%forceRatio,
	%rMax,%rMin,%dMax,%dMin,%fMax,%fMin) 
{
	%radius = GameBase::getRadius(%this);
	if(%radius) {
		%radius *= %radiusRatio;
		%damageValue = %radius * %damageRatio;
		%force = %radius * %forceRatio;
		if(%radius > %rMax)
			%radius = %rMax;
		else if(%radius < %rMin)
			%radius = %rMin;
		if(%damageValue > %dMax)
			%damageValue = %dMax; 
		else if(%damageValue < %dMin)
			%damageValue = %dMin;
		if(%force > %fMax)
			%force = %fMax; 
		else if(%force < %fMin)
			%force = %fMin;
		GameBase::applyRadiusDamage(%type,getBoxCenter(%this), %radius,
			%damageValue,%force,%this);
	}
}



function FlagStand::onDamage()
{
}

//------------------------------------------------------------------------
// Generators
//------------------------------------------------------------------------

function Generator::onEnabled(%this)
{
	GameBase::setActive(%this,true);
}

function Generator::onDisabled(%this)
{
	GameBase::stopSequence(%this,0);
 	GameBase::generatePower(%this, false);
}

function Generator::onDestroyed(%this)
{
	Generator::onDisabled(%this);
	StaticShape::objectiveDestroyed(%this);
	calcRadiusDamage(%this, $DebrisDamageType, 2.5, 0.05, 25, 13, 3, 0.55, 0.30, 250, 170); 
}

function Generator::onActivate(%this)
{
	GameBase::playSequence(%this,0,"power");
	GameBase::generatePower(%this, true);
}

function Generator::onDeactivate(%this)
{
	GameBase::stopSequence(%this,0);
 	GameBase::generatePower(%this, false);
}

//

StaticShapeData TowerSwitch
{
	description = "Tower Control Switch";
	className = "towerSwitch";
	shapeFile = "tower";
	showInventory = "false";
	visibleToSensor = true;
	mapFilter = 4;
	mapIcon = "M_generator";
};

StaticShapeData Generator
{
   description = "Generator";
   shapeFile = "generator";
	className = "Generator";
	debrisId = flashDebrisLarge;
	explosionId = flashExpLarge;
   maxDamage = 2.0;
	visibleToSensor = true;
	mapFilter = 4;
	mapIcon = "M_generator";
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
};

StaticShapeData SolarPanel
{
   description = "Solar Panel";
	shapeFile = "solar_med";
	className = "Generator";
	debrisId = flashDebrisMedium;
	maxDamage = 1.0;
	visibleToSensor = true;
	mapFilter = 4;
	mapIcon = "M_generator";
    damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = flashExpLarge;
};

StaticShapeData PortGenerator
{
   description = "Portable Generator";
   shapeFile = "generator_p";
	className = "Generator";
	debrisId = flashDebrisSmall;
   maxDamage = 1.6;
	mapIcon = "M_generator";
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = flashExpMedium;
	visibleToSensor = true;
	mapFilter = 4;
};


//------------------------------------------------------------------------
StaticShapeData SmallAntenna
{
	shapeFile = "anten_small";
	debrisId = defaultDebrisSmall;
	maxDamage = 1.0;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = flashExpMedium;
   description = "Small Antenna";
};

//------------------------------------------------------------------------
StaticShapeData MediumAntenna
{
	shapeFile = "anten_med";
	debrisId = flashDebrisSmall;
	maxDamage = 1.5;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = flashExpMedium;
   description = "Medium Antenna";
};

//------------------------------------------------------------------------
StaticShapeData LargeAntenna
{
	shapeFile = "anten_lrg";
	debrisId = defaultDebrisSmall;
	maxDamage = 1.5;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = debrisExpMedium;
   description = "Large Antenna";
};

//------------------------------------------------------------------------
StaticShapeData ArrayAntenna
{
	shapeFile = "anten_lava";
	debrisId = flashDebrisSmall;
	maxDamage = 1.5;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = flashExpMedium;
   description = "Array Antenna";
};

//------------------------------------------------------------------------
StaticShapeData RodAntenna
{
	shapeFile = "anten_rod";
	debrisId = defaultDebrisSmall;
	maxDamage = 1.5;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = debrisExpMedium;
   description = "Rod Antenna";
};

//------------------------------------------------------------------------
StaticShapeData ForceBeacon
{
	shapeFile = "force";
	debrisId = defaultDebrisSmall;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = debrisExpMedium;
   description = "Force Beacon";
};

//------------------------------------------------------------------------
StaticShapeData CargoCrate
{
	shapeFile = "magcargo";
	debrisId = flashDebrisSmall;
	maxDamage = 1.0;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = flashExpMedium;
	description = "CargoCrate";
};

//------------------------------------------------------------------------
StaticShapeData CargoBarrel
{
	shapeFile = "liqcyl";
	debrisId = defaultDebrisSmall;
	maxDamage = 1.0;
	damageSkinData = "objectDamageSkins";
	shadowDetailMask = 16;
	explosionId = debrisExpMedium;
   description = "Cargo Barrel";
};

//------------------------------------------------------------------------
StaticShapeData SquarePanel
{
	shapeFile = "teleport_square";
	debrisId = flashDebrisSmall;
	maxDamage = 0.3;
	damageSkinData = "objectDamageSkins";
	explosionId = flashExpMedium;
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData VerticalPanel
{
	shapeFile = "teleport_vertical";
	debrisId = defaultDebrisSmall;
	explosionId = debrisExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData BluePanel
{
	shapeFile = "panel_blue";
	debrisId = flashDebrisSmall;
	explosionId = flashExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData YellowPanel
{
	shapeFile = "panel_yellow";
	debrisId = defaultDebrisSmall;
	explosionId = debrisExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData SetPanel
{
	shapeFile = "panel_set";
	debrisId = flashDebrisSmall;
	explosionId = flashExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData VerticalPanelB
{
	shapeFile = "panel_vertical";
	debrisId = defaultDebrisSmall;
	explosionId = debrisExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData DisplayPanelOne
{
	shapeFile = "display_one";
	debrisId = flashDebrisSmall;
	explosionId = flashExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData DisplayPanelTwo
{
	shapeFile = "display_two";
	debrisId = defaultDebrisSmall;
	explosionId = debrisExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData DisplayPanelThree
{
	shapeFile = "display_three";
	debrisId = flashDebrisSmall;
	explosionId = flashExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData HOnePanel
{
	shapeFile = "dsply_h1";
	debrisId = defaultDebrisSmall;
	explosionId = debrisExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData HTwoPanel
{
	shapeFile = "dsply_h2";
	debrisId = flashDebrisSmall;
	explosionId = flashExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData SOnePanel
{
	shapeFile = "dsply_s1";
	debrisId = defaultDebrisSmall;
	explosionId = debrisExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData STwoPanel
{
	shapeFile = "dsply_s2";
	debrisId = flashDebrisSmall;
	explosionId = flashExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData VOnePanel
{
	shapeFile = "dsply_v1";
	debrisId = defaultDebrisSmall;
	explosionId = debrisExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData VTwoPanel
{
	shapeFile = "dsply_v2";
	debrisId = flashDebrisSmall;
	explosionId = flashExpMedium;
	maxDamage = 0.5;
	damageSkinData = "objectDamageSkins";
   description = "Panel";
};

//------------------------------------------------------------------------
StaticShapeData RForceField
{
	shapeFile = "forcefield";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
	isTranslucent = true;
	description = "Force Field";
};

//------------------------------------------------------------------------
StaticShapeData ElectricalBeam
{
	shapeFile = "zap";
	maxDamage = 10000.0;
	isTranslucent = true;
    description = "Electrical Beam";
   disableCollision = true;
};

StaticShapeData ElectricalBeamBig
{
	shapeFile = "zap_5";
	maxDamage = 10000.0;
	isTranslucent = true;
    description = "Electrical Beam";
   disableCollision = true;
};

StaticShapeData PoweredElectricalBeam
{
	shapeFile = "zap";
	maxDamage = 10000.0;
	isTranslucent = true;
    description = "Electrical Beam";
   disableCollision = true;
};

//function to fade in electrical beam based on base power.
function PoweredElectricalBeam::onPower(%this, %power, %generator)
{
   if(%power)
	  GameBase::startFadeIn(%this);
   else
      GameBase::startFadeOut(%this);
}
      
//-----------------------------------------------------------------------
StaticShapeData Cactus1
{
	shapeFile = "cactus1";
	debrisId = defaultDebrisSmall;
	maxDamage = 0.4;
   description = "Cactus";
};
//------------------------------------------------------------------------
StaticShapeData Cactus2
{
	shapeFile = "cactus2";
	debrisId = defaultDebrisSmall;
	maxDamage = 0.4;
   description = "Cactus";
};
//------------------------------------------------------------------------
StaticShapeData Cactus3
{
	shapeFile = "cactus3";
	debrisId = defaultDebrisSmall;
	maxDamage = 0.4;
   description = "Cactus";
};

//------------------------------------------------------------------------
StaticShapeData SteamOnGrass
{
	shapeFile = "steamvent_grass";
	maxDamage = 999.0;
	isTranslucent = "True";
   description = "Steam Vent";
};

//------------------------------------------------------------------------
StaticShapeData SteamOnMud
{
	shapeFile = "steamvent_mud";
	maxDamage = 999.0;
	isTranslucent = "True";
   description = "Steam Vent";
};

//------------------------------------------------------------------------

// CRUCIBLE

StaticShapeData PINE
{
	shapeFile = "PINE";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PINE";
	isTranslucent = true;
};

StaticShapeData PINEMED
{
	shapeFile = "PINEMED";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PINEMED";
	isTranslucent = true;
};

StaticShapeData CRUWATER1
{
	shapeFile = "CRUWATER1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CRU1WATER1";
	isTranslucent = true;
};
function CRUWATER1::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}


StaticShapeData CPITFIRE
{
	shapeFile = "CPITFIRE";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CPITFIRE";
	isTranslucent = true;
};


StaticShapeData ROUGEFLAG
{
	shapeFile = "ROUGEFLAG";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "ROUGEFLAG";
	isTranslucent = true;
};
function ROUGEFLAG::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData CPORTAL1
{
	shapeFile = "CPORTAL1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CPORTAL1";
	isTranslucent = true;
};
function CPORTAL1::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData CROCK1
{
	shapeFile = "CROCK1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CROCK1";
	isTranslucent = false;
};
StaticShapeData CROCK2
{
	shapeFile = "CROCK2";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CROCK2";
	isTranslucent = false;
};

StaticShapeData SHRUB1
{
	shapeFile = "SHRUB1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "SHRUB1";
	isTranslucent = true;
};
StaticShapeData ORANGEGLOW
{
	shapeFile = "OGLOW";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "OGLOW";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData IRONGATE
{
	shapeFile = "IRONGATE";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "IRONGATE";
	isTranslucent = true;
};

StaticShapeData WARP
{
	shapeFile = "WARP";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "WARP";
	isTranslucent = true;
};

function WARP::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData SBEAM1
{
	shapeFile = "SBEAM1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "SBEAM1";
	isTranslucent = true;
};
function SBEAM1::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData DFOUNTAIN1
{
	shapeFile = "DFOUNTAIN1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "DFOUNTAIN1";
	isTranslucent = true;
};

StaticShapeData DFOUNTAIN2
{
	shapeFile = "DFOUNTAIN2";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "DFOUNTAIN2";
	isTranslucent = true;
};

StaticShapeData LAVA1
{
	shapeFile = "LAVA1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "LAVA1";
	isTranslucent = true;
};

StaticShapeData LAVA2
{
	shapeFile = "LAVA2";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "LAVA2";
	isTranslucent = false;
};

StaticShapeData LAVA3
{
	shapeFile = "LAVA3";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "LAVA3";
	isTranslucent = true;
};



StaticShapeData ROOT1
{
	shapeFile = "ROOT1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "ROOT1";
	isTranslucent = true;
};

StaticShapeData CHAIN1
{
	shapeFile = "CHAIN1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CHAIN1";
	isTranslucent = true;
};

StaticShapeData OAKLARGE
{
	shapeFile = "OAKLARGE";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "OAKLARGE";
	isTranslucent = true;
};

StaticShapeData MUCKWATER1
{
	shapeFile = "MUCKWATER1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "MUCKWATER1";
	isTranslucent = true;
};
function MUCKWATER1::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData PHA_PORTAL
{
	shapeFile = "PHA_PORTAL";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PHA_PORTAL";
	isTranslucent = true;
};
function PHA_PORTAL::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData fire_small
{
	shapeFile = "fire_small";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "fire_small";
	isTranslucent = true;
	sfxAmbient = SoundFire2;
};

StaticShapeData fire_medium
{
	shapeFile = "fire_medium";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "fire_medium";
	isTranslucent = true;
	sfxAmbient = SoundFire2;
};

StaticShapeData fire_large
{
	shapeFile = "fire_large";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "fire_large";
	isTranslucent = true;
	sfxAmbient = SoundFire1;
};

StaticShapeData fire_omg
{
	shapeFile = "fire_omg";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "fire_omg";
	isTranslucent = true;
	sfxAmbient = SoundFire1;
};

StaticShapeData JUNGLEPLANT2
{
	shapeFile = "JUNGLEPLANT2";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JUNGLEPLANT2";
	isTranslucent = true;
};

StaticShapeData JUNGLEPLANT2_S
{
	shapeFile = "JUNGLEPLANT2_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JUNGLEPLANT2_S";
	isTranslucent = true;
};

StaticShapeData FERN
{
	shapeFile = "FERN";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FERN";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FERN_M
{
	shapeFile = "FERN_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FERN_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE_B
{
	shapeFile = "JTREE_B";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE_B";
	isTranslucent = true;
};

StaticShapeData JTREE_M
{
	shapeFile = "JTREE_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE_M";
	isTranslucent = true;
};

StaticShapeData JTREE_S
{
	shapeFile = "JTREE_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE_S";
	isTranslucent = true;
};

StaticShapeData JBUSH_B
{
	shapeFile = "JBUSH_B";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JBUSH_B";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JBUSH_M
{
	shapeFile = "JBUSH_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JBUSH_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JBUSH_S
{
	shapeFile = "JBUSH_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JBUSH_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JPALM_BIG
{
	shapeFile = "JPALM_BIG";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JPALM_BIG";
	isTranslucent = true;
};

StaticShapeData JPALM_M
{
	shapeFile = "JPALM_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JPALM_M";
	isTranslucent = true;
};

StaticShapeData JPALM_S
{
	shapeFile = "JPALM_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JPALM_S";
	isTranslucent = true;
};

StaticShapeData JOCEAN
{
	shapeFile = "JOCEAN";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JOCEAN";
	isTranslucent = false;
	disableCollision = false;
};

StaticShapeData JRIVER
{
	shapeFile = "JRIVER";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JRIVER";
	isTranslucent = false;
	disableCollision = false;
};
StaticShapeData GRASS_B
{
	shapeFile = "GRASS_B";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "GRASS_B";
	isTranslucent = true;
	disableCollision = true;
};
StaticShapeData GRASS_M
{
	shapeFile = "GRASS_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "GRASS_M";
	isTranslucent = true;
	disableCollision = true;
};
StaticShapeData GRASS_S
{
	shapeFile = "GRASS_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "GRASS_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData BLUE_RAY
{
	shapeFile = "BLUE_RAY";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "BLUE_RAY";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData CAVE_WATER
{
	shapeFile = "CAVE_WATER";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CAVE_WATER";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData TEMPLE_WATER
{
	shapeFile = "TEMPLE_WATER";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "TEMPLE_WATER";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData LAVARIVER1
{
	shapeFile = "LAVARIVER1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "LAVARIVER1";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData LAVARIVER2
{
	shapeFile = "LAVARIVER2";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "LAVARIVER2";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData INVISWALL_1
{
	shapeFile = "INVISWALL_1";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "INVISWALL_1";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData INVISWALL_2
{
	shapeFile = "INVISWALL_2";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "INVISWALL_2";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData PHA_PUMPKIN_L
{
	shapeFile = "PHA_PUMPKIN_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PHA_PUMPKIN_L";
};

StaticShapeData PHA_PUMPKIN_M
{
	shapeFile = "PHA_PUMPKIN_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PHA_PUMPKIN_M";
};

StaticShapeData PHA_PUMPKIN_S
{
	shapeFile = "PHA_PUMPKIN_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PHA_PUMPKIN_S";
};

StaticShapeData CRUBIGWALL
{
	shapeFile = "CRUBIGWALL";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CRUBIGWALL";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData CRUBIGGERWALL
{
	shapeFile = "CRUBIGGERWALL";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CRUBIGGERWALL";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData CRUHUGEWALL
{
	shapeFile = "CRUHUGEWALL";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CRUHUGEWALL";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData DBUSH_SMALL
{
	shapeFile = "DBUSH_SMALL";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "DBUSH_SMALL";
	isTranslucent = true;
};

StaticShapeData DBUSH_MED
{
	shapeFile = "DBUSH_MED";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "DBUSH_MED";
	isTranslucent = true;
};

StaticShapeData DTREE_S
{
	shapeFile = "DTREE_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "DTREE_S";
	isTranslucent = true;
};

StaticShapeData DTREE2_S
{
	shapeFile = "DTREE2_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "DTREE2_S";
	isTranslucent = true;
};

StaticShapeData DTREE3_S
{
	shapeFile = "DTREE3_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "DTREE3_S";
	isTranslucent = true;
};

StaticShapeData FTREE1_M
{
	shapeFile = "FTREE1_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE1_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE1_S
{
	shapeFile = "FTREE1_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE1_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE1_L
{
	shapeFile = "FTREE1_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE1_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE2_M
{
	shapeFile = "FTREE2_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE2_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE2_S
{
	shapeFile = "FTREE2_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE2_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE2_L
{
	shapeFile = "FTREE2_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE2_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE3_M
{
	shapeFile = "FTREE3_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE3_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE3_S
{
	shapeFile = "FTREE3_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE3_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE3_L
{
	shapeFile = "FTREE3_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE3_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE4_M
{
	shapeFile = "FTREE4_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE4_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE4_S
{
	shapeFile = "FTREE4_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE4_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FTREE4_L
{
	shapeFile = "FTREE4_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FTREE4_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FBUSH1_S
{
	shapeFile = "FBUSH1_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FBUSH1_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FBUSH1_M
{
	shapeFile = "FBUSH1_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FBUSH1_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FBUSH2_S
{
	shapeFile = "FBUSH2_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FBUSH2_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FBUSH2_M
{
	shapeFile = "FBUSH2_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FBUSH2_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData FROCK1_S
{
	shapeFile = "FROCK1_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FROCK1_S";
	isTranslucent = false;
	disableCollision = false;	
};

StaticShapeData FROCK1_M
{
	shapeFile = "FROCK1_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FROCK1_M";
	isTranslucent = false;
	disableCollision = false;
};

StaticShapeData FROCK1_L
{
	shapeFile = "FROCK1_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FROCK1_L";
	isTranslucent = false;
	disableCollision = false;
};

StaticShapeData FLAKE
{
	shapeFile = "FLAKE";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "FLAKE";
	isTranslucent = false;
	disableCollision = true;
};

StaticShapeData WINDOW3X3
{
	shapeFile = "WINDOW3X3";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "WINDOW3x3";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData WINDOW3X4
{
	shapeFile = "WINDOW3X4";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "WINDOW3x4";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData BLUEGLOW
{
	shapeFile = "BGLOW";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "BGLOW";
	isTranslucent = true;
};

StaticShapeData PHA_PUMPKIN2_S
{
	shapeFile = "PHA_PUMPKIN2_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PHA_PUMPKIN2_S";
};

StaticShapeData PHA_PUMPKIN2_M
{
	shapeFile = "PHA_PUMPKIN2_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PHA_PUMPKIN2_M";
};

StaticShapeData PHA_PUMPKIN2_L
{
	shapeFile = "PHA_PUMPKIN2_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PHA_PUMPKIN2_L";
};

StaticShapeData CRYSTALBALL
{
	shapeFile = "CRYSTALBALL";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CRYSTALBALL";
	isTranslucent = true;
};

function CRYSTALBALL::onAdd(%this)
{
	GameBase::playSequence(%this,0,"ambient");
}

StaticShapeData PURPBEAM
{
	shapeFile = "PURPBEAM";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "PURPBEAM";
	isTranslucent = true;
};

function PURPBEAM::onAdd(%this)
{
	GameBase::playSequence(%this,0,"ambient");
}

StaticShapeData ROGUECAMP
{
	shapeFile = "ROGUECAMP";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "ROGUECAMP";
	isTranslucent = false;
};

StaticShapeData TREASURE3
{
	shapeFile = "TREASURE4";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "TREASURE4";
	isTranslucent = false;
	disableCollision = false;
};

StaticShapeData SMOKE_FRAME
{
	shapeFile = "SMOKE_FRAME";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "SMOKE_FRAME";
	isTranslucent = true;
};
function SMOKE_FRAME::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData SWORDWINDOW
{
	shapeFile = "SWORDWINDOW";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "SWORDWINDOW";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData CRU_CRYSTAL_S
{
	shapeFile = "CRU_CRYSTAL_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CRU_CRYSTAL_S";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData CULTIST
{
	shapeFile = "CULTIST";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CULTIST";
	isTranslucent = true;
	disableCollision = true;
};
function CULTIST::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData CULTIST_CANDLE
{
	shapeFile = "CULTIST_CANDLE";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CULTIST_CANDLE";
	isTranslucent = true;
	disableCollision = true;
};
function CULTIST_CANDLE::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData CRU_PORTAL3
{
	shapeFile = "CRU_PORTAL3";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CRU_PORTAL3";
	isTranslucent = true;
	disableCollision = true;
	sfxAmbient = PortalLoop1;
};
function CRU_PORTAL3::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData MURKWATER
{
	shapeFile = "MURKWATER";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "MURKWATER";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData STREE_S
{
	shapeFile = "STREE_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "STREE_S";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData MAPPORTAL
{
	shapeFile = "MAPPORTAL";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "MAPPORTAL";
	isTranslucent = true;
	sfxAmbient = PortalLoop3;
};
function MAPPORTAL::onAdd(%this)
{
	GameBase::playSequence(%this,0,"power");
}

StaticShapeData CRUWATER3
{
	shapeFile = "CRUWATER3";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "CRUWATER3";
	isTranslucent = true;
	disableCollision = true;
};

//================================================

StaticShapeData JTREE1_L
{
	shapeFile = "JTREE1_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE1_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE2_L
{
	shapeFile = "JTREE2_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE2_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE3_L
{
	shapeFile = "JTREE3_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE3_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE4_L
{
	shapeFile = "JTREE4_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE4_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE5_L
{
	shapeFile = "JTREE5_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE5_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE6_L
{
	shapeFile = "JTREE6_L";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE6_L";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE1_M
{
	shapeFile = "JTREE1_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE1_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE1_S
{
	shapeFile = "JTREE1_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE1_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE2_S
{
	shapeFile = "JTREE2_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE2_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE3_S
{
	shapeFile = "JTREE3_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE3_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE4_S
{
	shapeFile = "JTREE4_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE4_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE5_S
{
	shapeFile = "JTREE5_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE5_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE6_S
{
	shapeFile = "JTREE6_S";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE6_S";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE2_M
{
	shapeFile = "JTREE2_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE2_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE3_M
{
	shapeFile = "JTREE3_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE3_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE4_M
{
	shapeFile = "JTREE4_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE4_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE5_M
{
	shapeFile = "JTREE5_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE5_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData JTREE6_M
{
	shapeFile = "JTREE6_M";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "JTREE6_M";
	isTranslucent = true;
	disableCollision = true;
};

StaticShapeData EMERALD
{
	shapeFile = "EMERALD";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "EMERALD";
	isTranslucent = true;
	disableCollision = false;
};

StaticShapeData SPIKEGATE
{
	shapeFile = "SPIKEGATE";
	debrisId = defaultDebrisSmall;
	maxDamage = 10000.0;
   	description = "SPIKEGATE";
	isTranslucent = true;
	disableCollision = false;
};

