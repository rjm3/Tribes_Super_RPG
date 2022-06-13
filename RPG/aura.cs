// AURA

ItemImageData AURA_FIREImage
{
	shapeFile = "AURA_FIRE_2";
	mountPoint = 1;
	mountOffset = {0, 0, 0};
	mountRotation = {0, 0, 0};
	firstPerson = false;
};
ItemData AURA_FIRE
{
	description = "AURA_FIRE_2";
	className = "Accessory";
	shapeFile = "AURA_FIRE_2";
	imageType = AURA_FIREImage;
	heading = "eMiscellany";
	price = 0;
};

ItemImageData AURA_LIGHTNINGImage
{
	shapeFile = "AURA_ENERGY";
	mountPoint = 1;
	mountOffset = {0, 0, 0};
	mountRotation = {0, 0, 0};
	firstPerson = false;
};
ItemData AURA_LIGHTNING
{
	description = "AURA_ENERGY";
	className = "Accessory";
	shapeFile = "AURA_ENERGY";
	imageType = AURA_LIGHTNINGImage;
	heading = "eMiscellany";
	price = 0;
};

ItemImageData AURA_COLDImage
{
	shapeFile = "AURA_COLD_2";
	mountPoint = 1;
	mountOffset = {0, 0, 0};
	mountRotation = {0, 0, 0};
	firstPerson = false;
};
ItemData AURA_COLD
{
	description = "AURA_COLD_2";
	className = "Accessory";
	shapeFile = "AURA_COLD_2";
	imageType = AURA_COLDImage;
	heading = "eMiscellany";
	price = 0;
};

ItemImageData TRANS_ARCANEImage
{
	shapeFile = "TRANS_ARCANE";
	mountPoint = 1;
	mountOffset = {0, 0, 0};
	mountRotation = {0, 0, 0};
	firstPerson = false;
};
ItemData TRANS_ARCANE
{
	description = "TRANS_ARCANE";
	className = "Accessory";
	shapeFile = "TRANS_ARCANE";
	imageType = TRANS_ARCANEImage;
	heading = "eMiscellany";
	price = 0;
};

ItemImageData AURA_ABSORBImage
{
	shapeFile = "AURA_ABSORB";
	mountPoint = 1;
	mountOffset = {0, 0, 0};
	mountRotation = {0, 0, 0};
	firstPerson = false;
};
ItemData AURA_ABSORB
{
	description = "AURA_ABSORB";
	className = "Accessory";
	shapeFile = "AURA_ABSORB";
	imageType = AURA_ABSORBImage;
	heading = "eMiscellany";
	price = 0;
};

ExplosionData AIL_SHOCK_EXP
{
   shapeName = "AIL_SHOCK.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 3.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0, 1.0, 1.0 };
   colors[1]  = { 0, 0.5, 1.0 };
   colors[2]  = { 0, 0.25, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData AIL_SHOCK
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
	explosionId = AIL_SHOCK_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function AIL_SHOCK::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData AIL_CHILL_EXP
{
   shapeName = "AIL_CHILL.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 3.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 1.0, 1.0 };
   colors[1]  = { 0, 1.0, 1.0 };
   colors[2]  = { 0, 0.5, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData AIL_CHILL
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
	explosionId = AIL_CHILL_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function AIL_CHILL::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData AIL_POISON_EXP
{
   shapeName = "AIL_POISON.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 3.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 0, 1.0, 0 };
   colors[1]  = { 0, 0.5, 0 };
   colors[2]  = { 0, 0.25, 0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData AIL_POISON
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
	explosionId = AIL_POISON_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function AIL_POISON::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData AIL_BLEED_EXP
{
   shapeName = "AIL_BLEED.dts";
   soundId   = Sound0326;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 3.0;
   timeZero = 1.0;
   timeOne  = 1.0;
   colors[0]  = { 1.0, 0, 0 };
   colors[1]  = { 1.0, 0, 0.25 };
   colors[2]  = { 1.0, 0, 0.5 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData AIL_BLEED
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
	explosionId = AIL_BLEED_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function AIL_BLEED::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData AIL_BURN_EXP
{
   shapeName = "VOLCANIC.dts";
   soundId   = ActivateAB;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 12.0;
   timeZero = 0.0;
   timeOne  = 0.5;
   colors[0]  = { 1.0, 0.6, 0.2 };
   colors[1]  = { 1.0, 0.6, 0.2 };
   colors[2]  = { 1.0, 0.6, 0.2 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData AIL_BURN
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
	explosionId = AIL_BURN_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function AIL_BURN::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData ANIM_FREEZE_EXP
{
   shapeName = "AURA_FREEZE.dts";
   soundId   = SoundFreeze;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeScale = 3.0;
   timeZero = 0.0;
   timeOne  = 0.500;
   colors[0]  = { 0, 1.0, 1.0 };
   colors[1]  = { 0, 1.0, 1.0 };
   colors[2]  = { 0, 1.0, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_FREEZE
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
	explosionId = ANIM_FREEZE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_FREEZE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData ANIM_CHARGE_EXP
{
   shapeName = "AURA_CHARGE.dts";
   soundId   = Spell23;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 12.0;
   timeScale = 1.0;
   timeZero = 0.0;
   timeOne  = 0.5;
   colors[0]  = { 1.0, 1.0, 1.0 };
   colors[1]  = { 0, 0.5, 1.0 };
   colors[2]  = { 0, 0.5, 1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_CHARGE
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
	explosionId = ANIM_CHARGE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_CHARGE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData ANIM_IGNITE_EXP
{
   shapeName = "AURA_IGNITE.dts";
   soundId   = Spell18;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeScale = 1.0;
   timeZero = 0.0;
   timeOne  = 0.5;
   colors[0]  = { 1.0, 0.5, 0 };
   colors[1]  = { 1.0, 0.5, 0 };
   colors[2]  = { 1.0, 0.5, 0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_IGNITE
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
	explosionId = ANIM_IGNITE_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_IGNITE::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData ANIM_PROJ_EXP
{
   shapeName = "AIL_PROJ.dts";
   soundId   = NoSound;
   faceCamera = false;
   randomSpin = false;
   hasLight   = true;
   lightRange = 6.0;
   timeScale = 0.5;
   timeZero = 0.0;
   timeOne  = 0.5;
   colors[0]  = { 1.0, 0.0, 0 };
   colors[1]  = { 1.0, 0.0, 0 };
   colors[2]  = { 1.0, 0.0, 0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_PROJ
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
	explosionId = ANIM_PROJ_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_PROJ::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

echo("__AURA LOADED");