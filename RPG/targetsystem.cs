// TARGET SYSTEM

function remoteTargetLos(%id)
{
	Targeting::LosTarget(%id);
}

function Targeting::LosTarget(%id)
{
	//echo(" TARGETING::LosTarget " @ %id);
	%target = -1;
	%team = -1;
	if (GameBase::getLOSinfo(Client::getOwnedObject(%id),5000)) {
		%obj = getObjectType($los::object);
		if (%obj == "Player") {
			%target = $los::object;
			%target = Player::GetClient(%target);
			%team = client::GetTeam(%target);
		}
		else {
			%pos = $los::position;
		}
	}
	//echo(" TARGET " @ %target @ " POS " @ %pos @ " TEAM " @ %team);
	if (%target != -1) {
		if (%team == 0)
			%friend = 1;
		else
			%friend = 0;
		if ($TARGETINGAREA[%id] != $TARGETINGAREA[%target])
			return;
		Client::SendMessage(%id,0,"Target Selected: " @ client::GetName(%target) @ "");
		$TargetCur[%id,%friend] = %target;
		Targeting::Hud(%id,"",%friend);
	}
}

function Targeting::RefreshTargeters(%target)
{
	//echo(" TARGETING::REFRESHTARGETERS " @ %target);
	for (%cl = client::GetFirst(); %cl != -1; %cl = client::GetNext(%cl)) {
		if ($TargetCur[%cl,0] == %target)
			Targeting::Hud(%cl,0,0);
		if ($TargetCur[%cl,1] == %target)
			Targeting::Hud(%cl,0,1);
	}
}

function Targeting::Obtain(%id,%spotdist,%noselect,%friend)
{
	//echo(" TARGET::OBTAIN " @ %id @ " " @ %spotdist @ " " @ %noselect @ " " @ %friend);
	if (%friend == "")
		%friend = 0;
	if (%spotdist == "")
		%spotdist = 100;
	//$TargetTemp[%id,%friend] = "^ ";
	$TargetTemp[%id,%friend] = "";
	%pos = Gamebase::GetPosition(%id);
	%set = newObject("set", SimSet);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	if (%friend == 0)
		Group::iterateRecursive(%set,Targeting::Add,%id);
	else
		Group::iterateRecursive(%set,Targeting::AddFriend,%id);
	deleteObject(%set);
	$TargetTemp[%id,1] = $TargetTemp[%id,1] @ "0 ";
	if (%noselect == "")
		Targeting::Select(%id,%friend);
}

function Targeting::Add(%object,%id)
{
	%target = player::GetClient(%object);
	if (%target == %id)
		return;
	if (Targeting::LosCheck(%id,%target) == False) {
		if (gamebase::getTeam(%target) != gamebase::GetTeam(%id)) {
			if (fetchData(%target, "invisible") != True)
				$TargetTemp[%id,0] = $TargetTemp[%id,0] @ %target @ " ";
			else {
				if (GetBonus(%id,$BPPERCEPTION) >= GetPlayerSkill(%target,$SkillHiding)) {
					UnHide(%target);
					Client::SendMessage(%target,1,"You have been pulled out of hiding!");
					Client::SendMessage(%id,2,"You have pulled " @ Client::GetName(%target) @ " out of hiding!");
					$InCombat[%target] = 5;
					$TargetTemp[%id,0] = $TargetTemp[%id,0] @ %target @ " ";
				}
			}
		}
	}
}

function Targeting::AddFriend(%object,%id)
{
	%target = player::GetClient(%object);
	if (Targeting::LosCheck(%id,%target) == False) {
		if (gamebase::getTeam(%target) == gamebase::GetTeam(%id)) {
			$TargetTemp[%id,1] = $TargetTemp[%id,1] @ %target @ " ";
		}
	}
}

function Targeting::Select(%id,%friend)
{
	%cur = $TargetCur[%id,%friend];
	%list = $TargetList[%id,%friend];
	%targets = $TargetTemp[%id,%friend];
	%prev = $TargetPrev[%id,%friend];
	if (%targets == "") {
		// client::SendMessage(%id,0,"No targets found.");
		Targeting::Hud(%id,1);
		return;
	}
	else {
		if (%targets == %list) {
			%new = 0;
			for (%i = 0; (%t = getWord(%targets,%i)) != -1; %i++) {
				if (Target::InPrev(%id,%t,%friend) == False && %new == 0) {
					%new = %t;
					$TargetPrev[%id,%friend] = $TargetPrev[%id,%friend] @ %new @ " ";
				}
			}
			if (%new == 0) {
				%new = getWord(%targets,0);
				$TargetPrev[%id,%friend] = "";
				$TargetPrev[%id,%friend] = $TargetPrev[%id,%friend] @ %new @ " ";
			}
		}
		else {
			$TargetPrev[%id,%friend] = "";
			%new = getWord(%targets,0);
			$TargetPrev[%id,%friend] = $TargetPrev[%id,%friend] @ %new @ " ";
		}
	}
	if (%new == "^") {
		remoteEval(%id,"RPGGui::DisableFriend");
		$TargetCur[%id,0] = "";
		$TargetList[%id,%friend] = %targets;
		return;
	}
	Client::SendMessage(%id,0,"Target Selected: " @ client::GetName(%new) @ "");
	$TargetCur[%id,%friend] = %new;
	$TargetList[%id,%friend] = %targets;
	Targeting::Hud(%id,"",%friend);
}

function Targeting::Hud(%id,%kill,%friend)
{
	%cur = $TargetCur[%id,%friend];
	%hp = fetchData(%cur,"HP");
	%mhp = fetchdata(%cur,"MaxHP");
	%hb = %hp / %mhp;
	%name = client::GetName(%cur);
	if (%friend == 0)
		%ftarg = Client::getName($TargetCur[%cur,0]);
	if (%friend == 1)
		%ftarg = Client::getName($TargetCur[%cur,0]);
	if (%ftarg == "")
		%ftarg = "Not Fighting";
	if (%friend == 0)
		remoteEval(%id,"RPGGui::EnableTarget");
	else
		remoteEval(%id,"RPGGui::EnableFriend");
	if (%kill == True) {
		remoteEval(%id,"RPGGui::DisableTarget");
		$TargetCur[%id,0] = "";
	}
	else {
		%targlvl = fetchData(%cur,"LVL");
		%color = GetDangerColor(%id,%cur);
		if (%friend == 0) {
			if ($ELITE[%cur])
				remoteeval(%id,"RPGGui::OppFightingNames","<jc><f0>("@%targlvl@") <f1>"@string::translate(%name,true),"<f1><jc>["@%ftarg@"]",MMDisplay(%cur));
			else if ($BOSS[%cur])
				remoteeval(%id,"RPGGui::OppFightingNames","<jc><f0>("@%targlvl@") <f2>"@string::translate(%name,true),"<f1><jc>["@%ftarg@"]",MMDisplay(%cur));
			else
				remoteeval(%id,"RPGGui::OppFightingNames","<f0><jc> ("@%targlvl@") "@%name,"<f1><jc>["@%ftarg@"]","");
			remoteeval(%id,"RPGGui::OppFightingHealth",%color,%hb);
		}
		else {
			remoteeval(%id,"RPGGui::FndFightingNames","<f0><jc>("@%targlvl@") "@%name,"<f1><jc>["@%ftarg@"]");
			remoteeval(%id,"RPGGui::FndFightingHealth",%color,%hb);
		}
	}
}

function Target::InPrev(%id,%t,%friend)
{
	%prev = $TargetPrev[%id,%friend];
	for (%i = 0; (%n = getWord(%prev,%i)) != -1; %i++) {
		if (%n == %t) {
			return True;
		}
	}
	return False;
}

function Targeting::LosCheck(%id,%target)
{
	//echo(%id @ " YYY " @ %target);
	//echo($TARGETINGAREA[%id] @ " XXX " @ $TARGETINGAREA[%target]);
	if ($TARGETINGAREA[%id] != $TARGETINGAREA[%target])
		return True;
	%a = GameBase::getPosition(%id);
 	%b = GameBase::getPosition(%target);
	%c = getWord(%a,0) @ " " @ getWord(%a,1) @ " " @ (getWord(%a,2) + 1.359);
	%d = getWord(%b,0) @ " " @ getWord(%b,1) @ " " @ (getWord(%b,2) + 1.359);
	%test[1] = getlosinfo(%c,%d,1);
	return %test[1];
}

function remoteCycleEnemy(%id)
{
	Targeting::Obtain(%id);
}

function remoteCycleFriend(%id)
{
	Targeting::Obtain(%id,"","",1);
}

function GetDangerColor(%id,%target)
{
	%idlvl = fetchData(%id,"LVL");
	%targlvl = fetchData(%target,"LVL");
	if ($ELITE[%target]) %targlvl *= 1.5;
	if ($BOSS[%target]) %targlvl *= 2.0;
	%step = %idlvl / %targlvl;
	if (%idlvl > 0 && %idlvl <= 10) %min = 1.65;
	else if (%idlvl > 10 && %idlvl <= 20) %min = 1.45;
	else %min = 1.25;
	if (%step >= %min) return 0;
	else if (%step >= 1.1) return 1;
	if (%step <= 0.5) return 8;
	else if (%step <= 0.6) return 7;
	else if (%step <= 0.7) return 6;
	else if (%step <= 0.8) return 5;
	else if (%step <= 0.9) return 4;
	else if (%step <= 1.0) return 2;
}

//##################################################################################################################################################################
// AUTO PROJECTILE BY BOVIDI
//%cl - You need this to get a player object...you could rewrite this
//to probably use no player
//%pos1 - The launch point
//%pos2 - The final destination

function FireAutoProjectile(%id,%targ,%type)
{
	%ojb = Client::GetOwnedObject(%id);
	%tobj = Client::GetOwnedObject(%targ);
	%pos1 = Gamebase::GetPosition(%ojb);
	%add = getWord(%pos1,2) + 1.6;
	%pos1 = getWord(%pos1,0) @ " " @ getWord(%pos1,1) @ " " @ %add;
	%pos2 = GameBase::GetPosition(%tobj);
	%add2 = getWord(%pos2,2) + 1.6;
	%pos2 = getWord(%pos2,0) @ " " @ getWord(%pos2,1) @ " " @ %add2;
	fireBetweenPoints(%id,%pos1,%pos2,%type);
}

function fireBetweenPoints(%cl, %pos1, %pos2, %type) {
	%player = Client::getOwnedObject(%cl);
	%trans = getFalseMuzzle(%pos1, %pos2);
	%p = Projectile::spawnProjectile(%type, %trans, %player, "0 0 0", 1.0);
}

//Assumes firing from pos1 to pos 2
function getFalseMuzzle(%pos1, %pos2) {
	//first 3 numbers get direction the "character" is pointing
	%firstSet = Vector::sub(%pos2, %pos1);
	%secondSet = %firstSet;
	%firstSet = getWord(%firstSet, 0) @ " " @ getWord(%firstSet, 1) @ " 0.0";
	%firstSet = Vector::normalize(%firstSet);

	%secondSet = Vector::normalize(%secondSet);

	//middle up 0 0 1, full down mimic set 1 with 0
	//This is a trash value...I didn't figure this out probably the perpendicular plane
	//To the first two sets, but not worth the math as it isn't used
	%thirdSet = Vector::Mult(%firstSet, %secondSet);

	%trans = %firstSet @ " " @ %secondSet @ " " @ %thirdSet @ " " @ %pos1;

	return %trans;
}

function Vector::Mult(%vec1, %vec2) {
	return getWord(%vec1, 0) * getWord(%vec2, 0) @ " " @getWord(%vec1, 1) * getWord(%vec2, 1) @ " " @getWord(%vec1, 2) * getWord(%vec2, 2);
}

//##################################################################################################################################################################
// BOW PROJECTILES

RocketData BowArrowDefault
{
   	bulletShapeName = "ARROW_BASIC.dts";
  	explosionTag    = bulletExp0;
   	collisionRadius = 0.0;
   	mass            = 2.0;
  	damageClass      = 1;       // 0 impact, 1, radius
  	damageValue      = 0.5;
   	damageType       = $NullDamageType;
   	explosionRadius  = 7.5;
   	kickBackStrength = 150.0;
   	muzzleVelocity   = 30.0;
   	terminalVelocity = 30.0;
   	acceleration     = 0.0;
   	totalTime        = 5.0;
   	liveTime         = 5.0;
   	lightRange       = 5.0;
   	lightColor       = { 0.5, 0.5, 0.5 };
   	inheritedVelocityScale = 0.5;
 	trailType   = 0;                // smoke trail
   	trailString = "";
   	smokeDist   = 0.3;
   	soundId = SoundDiscSpin;
};

RocketData BowArrowEnergy
{
   	bulletShapeName = "ARROW_COLD.dts";
  	explosionTag    = bulletExp0;
   	collisionRadius = 0.0;
   	mass            = 2.0;
  	damageClass      = 1;       // 0 impact, 1, radius
  	damageValue      = 0.5;
   	damageType       = $NullDamageType;
   	explosionRadius  = 7.5;
   	kickBackStrength = 150.0;
   	muzzleVelocity   = 30.0;
   	terminalVelocity = 30.0;
   	acceleration     = 0.0;
   	totalTime        = 5.0;
   	liveTime         = 5.0;
   	lightRange       = 5.0;
	lightColor       = { 0.0, 0.25, 1.0 };
   	inheritedVelocityScale = 0.5;
 	trailType   = 2;                // smoke trail
   	trailString = "ENERGY_TRAIL.dts";
   	smokeDist   = 0.3;
   	soundId = SoundDiscSpin;
};

RocketData BowArrowArcane
{
   	bulletShapeName = "ARROW_ARCANE.dts";
  	explosionTag    = bulletExp0;
   	collisionRadius = 0.0;
   	mass            = 2.0;
  	damageClass      = 1;       // 0 impact, 1, radius
  	damageValue      = 0.5;
   	damageType       = $NullDamageType;
   	explosionRadius  = 7.5;
   	kickBackStrength = 150.0;
   	muzzleVelocity   = 30.0;
   	terminalVelocity = 30.0;
   	acceleration     = 0.0;
   	totalTime        = 5.0;
   	liveTime         = 5.0;
   	lightRange       = 5.0;
   	lightColor       = { 0.92, 0.0, 0.54 };
   	inheritedVelocityScale = 0.5;
 	trailType   = 2;                // smoke trail
   	trailString = "ARCANE_TRAIL.dts";
   	smokeDist   = 2.0;
   	soundId = SoundDiscSpin;
};

RocketData BowArrowPoison
{
   	bulletShapeName = "ARROW_BASIC.dts";
  	explosionTag    = bulletExp0;
   	collisionRadius = 0.0;
   	mass            = 2.0;
  	damageClass      = 1;       // 0 impact, 1, radius
  	damageValue      = 0.5;
   	damageType       = $NullDamageType;
   	explosionRadius  = 7.5;
   	kickBackStrength = 150.0;
   	muzzleVelocity   = 30.0;
   	terminalVelocity = 30.0;
   	acceleration     = 0.0;
   	totalTime        = 5.0;
   	liveTime         = 5.0;
   	lightRange       = 5.0;
   	lightColor       = { 0.0, 1.0, 0.5 };
   	inheritedVelocityScale = 0.5;
 	trailType   = 2;                // smoke trail
   	trailString = "POISON_TRAIL.dts";
   	smokeDist   = 0.5;
   	soundId = SoundDiscSpin;
};

RocketData BowArrowCold
{
   	bulletShapeName = "ARROW_COLD.dts";
  	explosionTag    = bulletExp0;
   	collisionRadius = 0.0;
   	mass            = 2.0;
  	damageClass      = 1;       // 0 impact, 1, radius
  	damageValue      = 0.5;
   	damageType       = $NullDamageType;
   	explosionRadius  = 7.5;
   	kickBackStrength = 150.0;
   	muzzleVelocity   = 30.0;
   	terminalVelocity = 30.0;
   	acceleration     = 0.0;
   	totalTime        = 5.0;
   	liveTime         = 5.0;
   	lightRange       = 5.0;
   	lightColor       = { 0.0, 0.5, 1.0 };
   	inheritedVelocityScale = 0.5;
 	trailType   = 2;                // smoke trail
   	trailString = "COLD_TRAIL.dts";
   	smokeDist   = 0.5;
   	soundId = SoundDiscSpin;
};

RocketData BowArrowFire
{
   	bulletShapeName = "ARROW_FIRE.dts";
  	explosionTag    = bulletExp0;
   	collisionRadius = 0.0;
   	mass            = 2.0;
  	damageClass      = 1;       // 0 impact, 1, radius
  	damageValue      = 0.5;
   	damageType       = $NullDamageType;
   	explosionRadius  = 7.5;
   	kickBackStrength = 150.0;
   	muzzleVelocity   = 30.0;
   	terminalVelocity = 30.0;
   	acceleration     = 0.0;
   	totalTime        = 5.0;
   	liveTime         = 5.0;
   	lightRange       = 5.0;
   	lightColor       = { 1.0, 0.5, 0.0 };
   	inheritedVelocityScale = 0.5;
 	trailType   = 2;                // smoke trail
   	trailString = "rsmoke.dts";
   	smokeDist   = 1.8;
   	soundId = SoundDiscSpin;
};

RocketData MagicAutoProjectile
{
   	bulletShapeName = "AUTO_MAGIC.dts";
  	explosionTag    = energyExp;
   	collisionRadius = 0.0;
   	mass            = 2.0;
  	damageClass      = 1;       // 0 impact, 1, radius
  	damageValue      = 0.5;
   	damageType       = $NullDamageType;
   	explosionRadius  = 7.5;
   	kickBackStrength = 150.0;
   	muzzleVelocity   = 30.0;
   	terminalVelocity = 30.0;
   	acceleration     = 0.0;
   	totalTime        = 5.0;
   	liveTime         = 5.0;
   	lightRange       = 5.0;
   	lightColor       = { 0.5, 0.0, 1.0 };
   	inheritedVelocityScale = 0.5;
 	trailType   = 0;                // smoke trail
   	trailString = "rsmoke.dts";
   	smokeDist   = 1.8;
   	soundId = SoundDiscSpin;
};

//##################################################################################################################################################################
// MELEE PROJECTILES
BulletData SpectralSword
{
   bulletShapeName    = "SPEC_SWORD.dts";
   validateShape      = true;
   explosionTag       = bulletExp0;
   expRandCycle       = 0;
   mass               = 0.05;
   bulletHoleIndex    = 0;

   damageClass        = 0;       // 0 impact, 1, radius
   damageValue        = 0.11;
   damageType         = $NullDamageType;

   aimDeflection      = 0.0;
   muzzleVelocity     = 20.0;
   totalTime          = 3.0;
   inheritedVelocityScale = 1.0;
   isVisible          = true;

   tracerPercentage   = 0.0;
   tracerLength       = 0;
};

BulletData SpectralKnife
{
   bulletShapeName    = "SPEC_KNIFE.dts";
   validateShape      = true;
   explosionTag       = bulletExp0;
   expRandCycle       = 0;
   mass               = 0.05;
   bulletHoleIndex    = 0;

   damageClass        = 0;       // 0 impact, 1, radius
   damageValue        = 0.11;
   damageType         = $NullDamageType;

   aimDeflection      = 0.0;
   muzzleVelocity     = 20.0;
   totalTime          = 3.0;
   inheritedVelocityScale = 1.0;
   isVisible          = true;

   tracerPercentage   = 0.0;
   tracerLength       = 0;
};

BulletData SpectralHammer
{
   bulletShapeName    = "SPEC_HAMMER.dts";
   validateShape      = true;
   explosionTag       = bulletExp0;
   expRandCycle       = 0;
   mass               = 0.05;
   bulletHoleIndex    = 0;

   damageClass        = 0;       // 0 impact, 1, radius
   damageValue        = 0.11;
   damageType         = $NullDamageType;

   aimDeflection      = 0.0;
   muzzleVelocity     = 20.0;
   totalTime          = 3.0;
   inheritedVelocityScale = 1.0;
   isVisible          = true;

   tracerPercentage   = 0.0;
   tracerLength       = 0;
};

echo("_TARGET SYSTEM LOADED");