// SORCERY ANIMATION TEMP

//===================================================================================================================================

ExplosionData ICICLE_EXP
{
   shapeName = "SPL_ICICLE.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0, 1.0, 1.0 };
   colors[1]  = { 0, 1.0, 1.0 };
   colors[2]  = { 0, 1.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_ICICLE
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = ICICLE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_ICICLE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData FROST_EXP
{
   shapeName = "SPL_FROST.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0, 1.0, 1.0 };
   colors[1]  = { 0, 1.0, 1.0 };
   colors[2]  = { 0, 1.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_FROST
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = FROST_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_FROST::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData HAIL_EXP
{
   shapeName = "SPL_HAIL.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0, 1.0, 1.0 };
   colors[1]  = { 0, 1.0, 1.0 };
   colors[2]  = { 0, 1.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_HAIL
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = HAIL_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_HAIL::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData SNOWSTORM_EXP
{
   shapeName = "SPL_SNOWSTORM.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0, 1.0, 1.0 };
   colors[1]  = { 0, 1.0, 1.0 };
   colors[2]  = { 0, 1.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_SNOWSTORM
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = SNOWSTORM_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SNOWSTORM::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData AVALANCHE_EXP
{
   shapeName = "SPL_AVALANCHE.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0, 1.0, 1.0 };
   colors[1]  = { 0, 1.0, 1.0 };
   colors[2]  = { 0, 1.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_AVALANCHE
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = AVALANCHE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_AVALANCHE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData ICETWISTER_EXP
{
   shapeName = "SPL_ICETWISTER2.dts";
   soundId   = NoSound;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0, 1.0, 1.0 };
   colors[1]  = { 0, 1.0, 1.0 };
   colors[2]  = { 0, 1.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_ICETWISTER
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = ICETWISTER_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_ICETWISTER::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData FIREBALL_EXP
{
   shapeName = "SPL_FIREBALL.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.5, 0.0 };
   colors[1]  = { 1.0, 0.5, 0.0 };
   colors[2]  = { 1.0, 0.5, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_FIREBALL
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = FIREBALL_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_FIREBALL::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData SMOKE_EXP
{
   shapeName = "SPL_SMOKE.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.5, 0.0 };
   colors[1]  = { 1.0, 0.5, 0.0 };
   colors[2]  = { 1.0, 0.5, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_SMOKE
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = SMOKE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SMOKE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData MELT_EXP
{
   shapeName = "SPL_MELT.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.5, 0.0 };
   colors[1]  = { 1.0, 0.5, 0.0 };
   colors[2]  = { 1.0, 0.5, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_MELT
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = MELT_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_MELT::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData MAGMA_EXP
{
   shapeName = "SPL_MAGMA.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.5, 0.0 };
   colors[1]  = { 1.0, 0.5, 0.0 };
   colors[2]  = { 1.0, 0.5, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_MAGMA
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = MAGMA_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_MAGMA::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData FIRESTORM_EXP
{
   shapeName = "SPL_FIRESTORM2.dts";
   soundId   = NoSound;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.5, 0.0 };
   colors[1]  = { 1.0, 0.5, 0.0 };
   colors[2]  = { 1.0, 0.5, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_FIRESTORM
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = FIRESTORM_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_FIRESTORM::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData HELLFIRE_EXP
{
   shapeName = "SPL_HELLFIRE.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.5, 0.0 };
   colors[1]  = { 1.0, 0.5, 0.0 };
   colors[2]  = { 1.0, 0.5, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_HELLFIRE
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = HELLFIRE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_HELLFIRE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData SPARK_EXP
{
   shapeName = "SPL_SPARK.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 0.5, 1.0 };
   colors[1]  = { 0.0, 0.5, 1.0 };
   colors[2]  = { 0.0, 0.5, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_SPARK
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = SPARK_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SPARK::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData SHOCK_EXP
{
   shapeName = "SPL_SHOCK.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 0.5, 1.0 };
   colors[1]  = { 0.0, 0.5, 1.0 };
   colors[2]  = { 0.0, 0.5, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_SHOCK
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = SHOCK_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SHOCK::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData BOLT_EXP
{
   shapeName = "SPL_BOLT.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 0.5, 1.0 };
   colors[1]  = { 0.0, 0.5, 1.0 };
   colors[2]  = { 0.0, 0.5, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_BOLT
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = BOLT_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_BOLT::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData LIGHTNING_EXP
{
   shapeName = "SPL_LIGHTNING.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 0.5, 1.0 };
   colors[1]  = { 0.0, 0.5, 1.0 };
   colors[2]  = { 0.0, 0.5, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_LIGHTNING
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = LIGHTNING_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_LIGHTNING::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData SUPERNOVA_EXP
{
   shapeName = "SPL_SUPERNOVA.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 0.5, 1.0 };
   colors[1]  = { 0.0, 0.5, 1.0 };
   colors[2]  = { 0.0, 0.5, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_SUPERNOVA
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = SUPERNOVA_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SUPERNOVA::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData RIFT_EXP
{
   shapeName = "SPL_RIFT.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 0.5, 1.0 };
   colors[1]  = { 0.0, 0.5, 1.0 };
   colors[2]  = { 0.0, 0.5, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_RIFT
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = RIFT_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_RIFT::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

$CRUBOMBOFFSET["ANIM_THORN"] = 0.7;
ExplosionData THORN_EXP
{
   shapeName = "SPL_THORN.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 1.0, 0.5 };
   colors[1]  = { 0.0, 1.0, 0.5 };
   colors[2]  = { 0.0, 1.0, 0.5 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_THORN
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = THORN_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_THORN::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData FANGS_EXP
{
   shapeName = "SPL_FANGS.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 1.0, 0.5 };
   colors[1]  = { 0.0, 1.0, 0.5 };
   colors[2]  = { 0.0, 1.0, 0.5 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_FANGS
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = FANGS_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_FANGS::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData PLAGUE_EXP
{
   shapeName = "SPL_PLAUGE.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 1.0, 0.5 };
   colors[1]  = { 0.0, 1.0, 0.5 };
   colors[2]  = { 0.0, 1.0, 0.5 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_PLAGUE
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = PLAGUE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_PLAGUE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData COBRA_EXP
{
   shapeName = "SPL_COBRA.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 1.0, 0.5 };
   colors[1]  = { 0.0, 1.0, 0.5 };
   colors[2]  = { 0.0, 1.0, 0.5 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_COBRA
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = COBRA_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_COBRA::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData SWARM_EXP
{
   shapeName = "SPL_SWARM.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 1.0, 0.5 };
   colors[1]  = { 0.0, 1.0, 0.5 };
   colors[2]  = { 0.0, 1.0, 0.5 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_SWARM
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = SWARM_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SWARM::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData BLACKDEATH_EXP
{
   shapeName = "SPL_BLACKDEATH.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.0, 1.0, 0.5 };
   colors[1]  = { 0.0, 1.0, 0.5 };
   colors[2]  = { 0.0, 1.0, 0.5 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_BLACKDEATH
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = BLACKDEATH_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_BLACKDEATH::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData IRONFIST_EXP
{
   shapeName = "SPL_IRONFIST.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.0, 0.0 };
   colors[1]  = { 1.0, 0.0, 0.0 };
   colors[2]  = { 1.0, 0.0, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_IRONFIST
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = IRONFIST_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_IRONFIST::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData CHAOSSLASH_EXP
{
   shapeName = "SPL_CHAOSSLASH.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.0, 0.0 };
   colors[1]  = { 1.0, 0.0, 0.0 };
   colors[2]  = { 1.0, 0.0, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_CHAOSSLASH
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CHAOSSLASH_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_CHAOSSLASH::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData POWERPUNCH_EXP
{
   shapeName = "SPL_POWERPUNCH.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.0, 0.0 };
   colors[1]  = { 1.0, 0.0, 0.0 };
   colors[2]  = { 1.0, 0.0, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_POWERPUNCH
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = POWERPUNCH_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_POWERPUNCH::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData CHAOSCLAWS_EXP
{
   shapeName = "SPL_CHAOSCLAWS.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.0, 0.0 };
   colors[1]  = { 1.0, 0.0, 0.0 };
   colors[2]  = { 1.0, 0.0, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_CHAOSCLAWS
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CHAOSCLAWS_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_CHAOSCLAWS::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData THORSHAMMER_EXP
{
   shapeName = "SPL_THORSHAMMER.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.0, 0.0 };
   colors[1]  = { 1.0, 0.0, 0.0 };
   colors[2]  = { 1.0, 0.0, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_THORSHAMMER
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = THORSHAMMER_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_THORSHAMMER::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData SWORDSTORM_EXP
{
   shapeName = "SPL_SWORDSTORM.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.0, 0.0 };
   colors[1]  = { 1.0, 0.0, 0.0 };
   colors[2]  = { 1.0, 0.0, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_SWORDSTORM
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = SWORDSTORM_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SWORDSTORM::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData ROCK_EXP
{
   shapeName = "SPL_ROCK.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.5, 0.0, 1.0 };
   colors[1]  = { 0.5, 0.0, 1.0 };
   colors[2]  = { 0.5, 0.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_ROCK
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = ROCK_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_ROCK::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData CHAOSKNIFE_EXP
{
   shapeName = "SPL_CHAOSKNIFE.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.5, 0.0, 1.0 };
   colors[1]  = { 0.5, 0.0, 1.0 };
   colors[2]  = { 0.5, 0.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_CHAOSKNIFE
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CHAOSKNIFE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_CHAOSKNIFE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData VOLLEY_EXP
{
   shapeName = "SPL_VOLLEY.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.5, 0.0, 1.0 };
   colors[1]  = { 0.5, 0.0, 1.0 };
   colors[2]  = { 0.5, 0.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_VOLLEY
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = VOLLEY_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_VOLLEY::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData TORNADO_EXP
{
   shapeName = "SPL_TORNADO.dts";
   soundId   = NoSound;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.5, 0.0, 1.0 };
   colors[1]  = { 0.5, 0.0, 1.0 };
   colors[2]  = { 0.5, 0.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_TORNADO
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = TORNADO_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_TORNADO::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData CHAOSARROW_EXP
{
   shapeName = "SPL_CHAOSARROW.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.5, 0.0, 1.0 };
   colors[1]  = { 0.5, 0.0, 1.0 };
   colors[2]  = { 0.5, 0.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_CHAOSARROW
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = CHAOSARROW_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_CHAOSARROW::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData METEOR_EXP
{
   shapeName = "SPL_METEOR.dts";
   soundId   = NoSound;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0.5, 0.0, 1.0 };
   colors[1]  = { 0.5, 0.0, 1.0 };
   colors[2]  = { 0.5, 0.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_METEOR
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = METEOR_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_METEOR::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData HELLCHAIN_EXP
{
   shapeName = "SPL_HELLCHAIN.dts";
   soundId   = NoSound;
   faceCamera = false;
   randomSpin = false;
   hasLight   = false;
   lightRange = 3.0;
   timeZero = 0.0;
   timeOne  = 0.0;
   colors[0]  = { 0.25, 0.25, 1.0 };
   colors[1]  = { 0.25, 0.25, 1.0 };
   colors[2]  = { 1.0,  1.0,  1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_HELLCHAIN
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = HELLCHAIN_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_HELLCHAIN::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData DISCHARGE_EXP
{
   shapeName = "SPL_DISCHARGE.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = false;
   lightRange = 3.0;
   timeZero = 0.0;
   timeOne  = 0.0;
   colors[0]  = { 0.25, 0.25, 1.0 };
   colors[1]  = { 0.25, 0.25, 1.0 };
   colors[2]  = { 1.0,  1.0,  1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_DISCHARGE
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = DISCHARGE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_DISCHARGE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//===================================================================================================================================

ExplosionData HLIGHTNING_EXP
{
   shapeName = "SPL_HLIGHTNING.dts";
   soundId   = Spell23;
   faceCamera = true;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0.3, 0.0 };
   colors[1]  = { 1.0, 0.3, 0.0 };
   colors[2]  = { 1.0, 0.3, 0.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_HLIGHTNING
{
	mass = 0.3;
	drag = 1.0;
	density = 2.0;
	elasticity = 0.15;
	friction = 1.0;
	className = "Handgrenade";
	description = "Handgrenade";
	shapeFile = "smoke";
	shadowDetailMask = 4;
	explosionId = HLIGHTNING_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_HLIGHTNING::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}
