
//====================================================================================================================================

ExplosionData ABILITY_OFF_EXP
{
   shapeName = "SPL_ABILITY_OFF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_ABILITY_OFF
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
	explosionId = ABILITY_OFF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_ABILITY_OFF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData ABILITY_DEF_EXP
{
   shapeName = "SPL_ABILITY_DEF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_ABILITY_DEF
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
	explosionId = ABILITY_DEF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_ABILITY_DEF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData ABILITY_NEU_EXP
{
   shapeName = "SPL_ABILITY_NEU.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_ABILITY_NEU
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
	explosionId = ABILITY_NEU_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_ABILITY_NEU::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//====================================================================================================================================

ExplosionData BODY_OFF_EXP
{
   shapeName = "SPL_BODY_OFF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_BODY_OFF
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
	explosionId = BODY_OFF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_BODY_OFF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData BODY_DEF_EXP
{
   shapeName = "SPL_BODY_DEF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_BODY_DEF
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
	explosionId = BODY_DEF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_BODY_DEF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData BODY_NEU_EXP
{
   shapeName = "SPL_BODY_NEU.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_BODY_NEU
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
	explosionId = BODY_NEU_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_BODY_NEU::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//====================================================================================================================================

ExplosionData SPELL_OFF_EXP
{
   shapeName = "SPL_SPELL_OFF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_SPELL_OFF
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
	explosionId = SPELL_OFF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SPELL_OFF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData SPELL_DEF_EXP
{
   shapeName = "SPL_SPELL_DEF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_SPELL_DEF
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
	explosionId = SPELL_DEF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SPELL_DEF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData SPELL_NEU_EXP
{
   shapeName = "SPL_SPELL_NEU.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_SPELL_NEU
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
	explosionId = SPELL_NEU_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_SPELL_NEU::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//====================================================================================================================================

ExplosionData WEAPON_OFF_EXP
{
   shapeName = "SPL_WEAPON_OFF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_WEAPON_OFF
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
	explosionId = WEAPON_OFF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_WEAPON_OFF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData WEAPON_DEF_EXP
{
   shapeName = "SPL_WEAPON_DEF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_WEAPON_DEF
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
	explosionId = WEAPON_DEF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_WEAPON_DEF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData WEAPON_NEU_EXP
{
   shapeName = "SPL_WEAPON_NEU.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_WEAPON_NEU
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
	explosionId = WEAPON_NEU_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_WEAPON_NEU::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//====================================================================================================================================

ExplosionData EVADE_OFF_EXP
{
   shapeName = "SPL_EVADE_OFF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_EVADE_OFF
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
	explosionId = EVADE_OFF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_EVADE_OFF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData EVADE_DEF_EXP
{
   shapeName = "SPL_EVADE_DEF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_EVADE_DEF
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
	explosionId = EVADE_DEF_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_EVADE_DEF::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

ExplosionData EVADE_NEU_EXP
{
   shapeName = "SPL_EVADE_NEU.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_EVADE_NEU
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
	explosionId = EVADE_NEU_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_EVADE_NEU::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}


//====================================================================================================================================

ExplosionData HEAL_1_EXP
{
   shapeName = "SPL_HEAL_1.dts";
   soundId   = Spell37;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 3.0;
   timeZero = 2.0;
   timeOne  = 1.0;
   colors[0]  = { 1, 0.0, 0.0 };
   colors[1]  = { 1, 0.0, 0.0 };
   colors[2]  = { 1.0,  0.25,  0.25 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_HEAL_1
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
	explosionId = HEAL_1_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_HEAL_1::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//====================================================================================================================================

ExplosionData MANA_1_EXP
{
   shapeName = "SPL_MANA_1.dts";
   soundId   = NoSound;
   faceCamera = true;
   randomSpin = true;
   hasLight   = true;
   lightRange = 3.0;
   timeZero = 2.0;
   timeOne  = 1.0;
   colors[0]  = { 0.25, 0.25, 1.0 };
   colors[1]  = { 0.25, 0.25, 1.0 };
   colors[2]  = { 1.0,  1.0,  1.0 };
   radFactors = { 1.0, 1.0, 1.0 };
};
MineData ANIM_MANA_1
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
	explosionId = MANA_1_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_MANA_1::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//====================================================================================================================================

ExplosionData TRADE_1_EXP
{
   shapeName = "SPL_TRADE_1.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_TRADE_1
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
	explosionId = TRADE_1_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_TRADE_1::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

//====================================================================================================================================

ExplosionData FLICKER_EXP
{
   shapeName = "SPL_WEAPON_OFF.dts";
   soundId   = NoSound;
   faceCamera = true;
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
MineData ANIM_FLICKER
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
	explosionId = FLICKER_EXP;
	explosionRadius = 10.0;
	damageValue = 1.0;
	damageType = $NullDamageType;
	kickBackStrength = 0;
	triggerRadius = 0.5;
	maxDamage = 1.0;
};
function ANIM_FLICKER::onAdd(%this)
{
	schedule("Mine::Detonate(" @ %this @ ");", 0.2, %this);
}

