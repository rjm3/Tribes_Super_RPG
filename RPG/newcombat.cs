// NEWCOMBAT

$HitMultiply = 1.0;
$AttackDamageMultiply = 200;
$HardDefensiveMulti = 100;

function AiIsDead(%id)
{
	if (!Player::isAiControlled(Client::GetOwnedObject(%id)))
		return False;
	if ($AIISDEAD[%id])
		return True;
	return False;
}

//###################################################################################################################################

// NEW ATK RATING

function RefreshATK(%id)
{
	$TempATK[%id] = GetNewATK(%id,-1,-1);
}

function GetTempATK(%id)
{
	GetNewATK(%id,-1,-1);
}

function GetTempDEF(%id)
{
	return $TempDEF[%id];
}

function GetNewATK(%id,%weapon,%override)
{
	//echo("GETNEWATK OVERRIDE " @ %override);
	%atk = 0;
	//=======================================================================================
	if (%weapon == -1)
		%weapon = GetCurrentWearFull(%id,13);
	if (%weapon != "none") {
		%atkskills = $BPItem[%weapon,$BPATKSkills];
		if (%override != -1)
			%atkskills = %override @ " 100";
		%ma = False;
		if (%atkskills != "") {
			for (%i = 0; (%skill = getWord(%atkskills,%i)) != -1; %i += 2) {
				if (%skill == "MartialArts") %ma = True;
				%var = getWord(%atkskills,%i+1);
				%atk += (GetPlayerSkill(%id,$BPSkillToNumeric[%skill]) * (%var / 100));
			}
		}
	}
	//=======================================================================================
	%atk += GetBonus(%id,$BPADDALLOFF);
	%atk += GetBonus(%id,$BPACCURACY);
	if (%ma) %atk += GetBonus(%id,$BPMAACCURACY);
	return floor(%atk + 1.001);
}

function GetNewDEF(%id,%weapon)
{
	%def = 0;
	//=======================================================================================
	%defskills = $BPItem[%weapon,$BPDEFSkills];
	if (%defskills != "") {
		for (%i = 0; (%skill = getWord(%defskills,%i)) != -1; %i += 2) {
			%var = getWord(%defskills,%i+1);
			if (%skill == "Level") {
				%lvl = GetLevel(fetchData(%id,"EXP"),%id);
				%def += (%lvl * (%var / 100));
			}
			else {
				%def += (GetPlayerSkill(%id,$BPSkillToNumeric[%skill]) * (%var / $HardDefensiveMulti));
			}
		}
	}
	//=======================================================================================
	%def += GetBonus(%id,$BPADDALLDEF);
	return floor(%def + 1.001);
}

function NewATKSuccessfull(%attacker,%defender,%weapon,%special,%offensivemod,%defensivemod)
{
	//echo("NEW ATK SUCCESSFULL ATK:" @ %attacker @ " DEF:" @ %defender @ " WEAPON:" @ %weapon @ " SPECIAL:" @ %special @ " O:" @ %offensivemod @ " D:" @ %defensivemod);
	//=======================================================================================
	%atk = GetTempATK(%attacker);
	%def = GetNewDEF(%defender,%weapon);
	if (%special != -1) 
		%atk = GetNewATK(%attacker,%weapon,%special);
	//=======================================================================================
	%atk *= %offensiveMod;
	%def *= %defensiveMod;
	//echo(" ATK " @ %atk @ " DEF " @ %def);
	//=======================================================================================
	%rollatk = (getRandom() * (%atk * 5) + 1);
	%rolldef = (getRandom() * (%def * 5) + 1);
	//=======================================================================================
	%rollatk = %rollatk * $HitMultiply;
	//=======================================================================================
	//echo(%rollatk @ " " @ %rolldef);
	//*************************************************************
	// MAP DODGE EVADE
	if ((%mapb = GetMapBonus(%defender,"NOE")) != -1) return True;
	//*************************************************************	
	if (%rollatk >= %rolldef)
		return True;
	else
		return False;
}

function GetNewDamageRoll(%id,%weapon)
{
	%damage = $BPItem[%weapon,$BPDamage];
	%min = getWord(%damage,0);
	%max = getWord(%damage,2);
	%roll = RandBetween(%min,%max);
	if (%roll < 1 || %roll == "")
		%roll = 1;
	return %roll @ " " @ %minroll;
}

function StunPlayer(%id,%dur)
{
	//*************************************************************
	// MAP STUN
	if ((%mapb = GetMapBonus(%id,"MNS")) != -1) return;
	//*************************************************************	
	rpg::SendMessage(%id,$msgred,"You are stunned!");
	Item::setVelocity(client::GetOwnedObject(%id),"0 0 0");
	Player::Trigger(%id,0,0);
	Client::setControlObject(%id, -1);
	Player::SetAnimation(%id,49);
	$Stunned[%id] = 1;
	%stunid = $StunID[%id]++;
	schedule("AutoUnstunPlayer("@%id@","@%stunid@");",%dur);
}

function DeathStun(%id)
{
	if (!$Stunned[%id])
		return;
	%stunid = $StunID[%id]++;
	AutoUnstunPlayer(%id,%stunid);
}

function AutoUnstunPlayer(%id,%stunid)
{
	if ($StunID[%id] != %stunid)
		return;
	rpg::SendMessage(%id,$msgyellow,"You come to your senses..");
	Client::setControlObject(%id,%id);
	if (Player::isAiControlled(Client::GetOwnedObject(%id))) {
		if ($TargetCur[%id,0] != "")
			Player::Trigger(%id,0,1);
	}
	$Stunned[%id] = 0;
}

function RootPlayer(%id)
{
	//*************************************************************
	// MAP ROOT
	if ((%mapb = GetMapBonus(%id,"NRR")) != -1) return;
	//*************************************************************
	rpg::SendMessage(%id,$msgyellow,"You are rooted!");
	Item::setVelocity(client::GetOwnedObject(%id),"0 0 0");
	$Rooted[%id] = 1;
	if (!Player::isAiControlled(Client::GetOwnedObject(%id))) {
		%race = fetchData(%id,"RACE");
		if (%race == "MaleHuman" || %race == "FemaleHuman" || %race == "FemaleBigHuman" || %race == "MaleBigHuman") {
			focusserver();
			//====================================================
			// ROBE CHECK
			%apm = "";
			%armor = $PlayerWear[%id,12];
			if (%armor != -1 && %armor != "") {
				%vis = $BPItem[%armor,$BPVis];
				if ($BPRobed[%vis])
					%apm = "Robed";
			}
			//====================================================
			%mana = fetchData(%id,"MANA");
			%armor = $ArmorForSpeed[fetchData(%id,"RACE") @ %apm, -7];
			Player::SetArmor(Client::GetOwnedObject(%id),%armor);
			setMANA(%id, %mana);
		}
		else {
			Client::SendMessage(%id,0,"Cannot be rooted!");
			return;
		}
	}
	else {
		%aiPos = GameBase::getPosition(%id);
		%aiName = Client::GetName(%id);
		AI::DirectiveWaypoint(%aiName,%aiPos,99);
	}
}

function UnRootPlayer(%id)
{
	$Rooted[%id] = 0;
	rpg::SendMessage(%id,$msgyellow,"You are no longer rooted.");
	if (!Player::isAiControlled(Client::GetOwnedObject(%id))) {
		//====================================================
		// ROBE CHECK
		%apm = "";
		%armor = $PlayerWear[%id,12];
		if (%armor != -1 && %armor != "") {
			%vis = $BPItem[%armor,$BPVis];
			if ($BPRobed[%vis])
				%apm = "Robed";
		}
		//====================================================
		if ($Snared[%id] == 1)
			%armor = $ArmorForSpeed[fetchData(%id,"RACE") @ %apm, -4];
		else
			%armor = $ArmorForSpeed[fetchData(%id,"RACE") @ %apm, 0];
		%mana = fetchData(%id,"MANA");
		Player::SetArmor(Client::GetOwnedObject(%id),%armor);
		setMANA(%id, %mana);
	}
}

function SnarePlayer(%id)
{
	rpg::SendMessage(%id,$msgyellow,"You are snared!");
	if (!Player::isAiControlled(Client::GetOwnedObject(%id))) {
		//====================================================
		// ROBE CHECK
		%apm = "";
		%armor = $PlayerWear[%id,12];
		if (%armor != -1 && %armor != "") {
			%vis = $BPItem[%armor,$BPVis];
			if ($BPRobed[%vis])
				%apm = "Robed";
		}
		//====================================================
		$Snared[%id] = 1;
		if ($Rooted[%id])
			%armor = $ArmorForSpeed[fetchData(%id,"RACE") @ %apm, -7];
		else
			%armor = $ArmorForSpeed[fetchData(%id,"RACE") @ %apm, -4];
		Player::SetArmor(Client::GetOwnedObject(%id),%armor);
	}
}

function UnSnarePlayer(%id)
{
	rpg::SendMessage(%id,$msgyellow,"You are no longer snared.");
	if (!Player::isAiControlled(Client::GetOwnedObject(%id))) {
		//====================================================
		// ROBE CHECK
		%apm = "";
		%armor = $PlayerWear[%id,12];
		if (%armor != -1 && %armor != "") {
			%vis = $BPItem[%armor,$BPVis];
			if ($BPRobed[%vis])
				%apm = "Robed";
		}
		//====================================================
		$Snared[%id] = 0;
		if ($Rooted[%id] == 1)
			%armor = $ArmorForSpeed[fetchData(%id,"RACE") @ %apm, -7];
		else
			%armor = $ArmorForSpeed[fetchData(%id,"RACE") @ %apm, 0];
		Player::SetArmor(Client::GetOwnedObject(%id),%armor);
	}
}

//###################################################################################################################################

$specialoffensivemod[bashing] = 1.5;
$specialdefensivemod[bashing] = 0.5;
$specialoffensivemod[cleave] = 2.0;
$specialdefensivemod[cleave] = 0.5;
$specialoffensivemod[sneakattack] = 2.0;
$specialdefensivemod[sneakattack] = 0.5;
$specialoffensivemod[aiming] = 5.0;
$specialdefensivemod[aiming] = 0.5;
$specialoffensivemod[brawl] = 1.5;
$specialdefensivemod[brawl] = 0.5;

function WeaponHasSpecial(%weapon,%special)
{
	%atk = GetWord($BPItem[%weapon,$BPATKSkills],0);
	if (%atk == "Slashing" && %special == "cleave") return True;
	if (%atk == "Bludgeoning" && %special == "bashing") return True;
	if (%atk == "Archery" && %special == "aiming") return True;
	if (%atk == "Piercing" && %special == "sneakattack") return True;
	return False;
}

function GetWeaponSpecialLock(%id,%weapon,%special)
{
	%delay = $BPItem[%weapon,$BPWeaponDelay];
	%delay = round(%delay * 14);
	%skill = GetPlayerSkill(%id,$BPSkillToNumeric[%special]);
	%skill = Cap(%skill,0,3000);
	%t = %delay - round((%delay / 2) * (%skill / 3000));
	%t = Cap(%t,round(%delay / 2),%delay);
	return %t;
}

function CoolDownBrawl(%id,%weapon)
{
	%delay = $BPItem[%weapon,$BPWeaponDelay];
	%delay = round(%delay * 14);
	%skill = GetPlayerSkill(%id,$SkillBrawling);
	%skill = Cap(%skill,0,3000);
	%t = %delay - round((%delay / 2) * (%skill / 3000));
	%t = Cap(%t,round(%delay / 2),%delay);
	BPLockSkill(%id,"Brawling",%t,-1);
}

$SpecialConv[bashing] = "Bash";
$SpecialConv[aiming] = "Aim Shot";
$SpecialConv[cleave] = "Cleave";
$SpecialConv[brawl] = "Brawl";

function Brawl(%id)
{
	//echo(" BRAWL " @ %id);
	%weapon = getCurrentWearFull(%id,13);
	if ($BPItem[%weapon,$BPRanged] == 1 || %weapon == -1 || %weapon == "none" || $BPItem[%weapon,$BPIsMagWeapon] == 1) {
		Client::SendMessage(%id,0,"You must be using a melee weapon.");
		return;
	}
	if (BPSkillUnlocked(%id,"Brawling"))
		Player::WeaponAttack(%id,"brawling","","","");
	else
		BPDisplaySkillLockTime(%id,"Brawling");
}

function SetupWeaponSpecial(%id,%special)
{
	//echo(" SETUPWEAPONSPECIAL " @ %id @ " " @ %special);
	%weapon = getCurrentWearFull(%id,13);
	%set = %id.WeaponSpecial;
	if (%set != "") {
		client::SendMessage(%id,0,"You are already set to " @ $SpecialConv[%set] @ ".");
		return;
	}
	if (BPSkillUnlocked(%id,%special)) {
		if (WeaponHasSpecial(%weapon,%special)) {
			%id.WeaponSpecial = %special;
			rpg::SendMessage(%id,$msgpink,"You are ready to " @ $SpecialConv[%special] @ "!");
		}
		else
			rpg::SendMessage(%id,0,%special @ " skill is unavailable with this weapon.");
	}
	else {
		BPDisplaySkillLockTime(%id,%special);
		return;
	}
}

function WeaponSpecialCooldown(%id,%weapon)
{
	%special = %id.WeaponSpecial;
	if (%special == "")
		return;
	%sanction = $specialsanction[%special];
	%locktime = GetWeaponSpecialLock(%id,%weapon,%special);
	BPLockSkill(%id,%special,%locktime,-1);
	%id.WeaponSpecial = "";
}

//###################################################################################################################################

function AOEAgg(%id,%target,%hate)
{
		%spotdist = 30;
		%pos = Gamebase::GetPosition(%target);
		%set = newObject("set", SimSet);
		%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
		Group::iterateRecursive(%set,AOEAgg::Do,%id,%hate);
		deleteObject(%set);
}

function AOEAgg::Do(%object,%id,%hate)
{
	%target = player::GetClient(%object);
	if (%target == %id)
		return;
	if (!Player::isAiControlled(Client::GetOwnedObject(%target)))
		return;
	if (GameBase::GetTeam(%id) == GameBase::GetTeam(%target))
		return;
	AI::AddHate(%target,%id,%hate);
}

function AOETaunt(%id)
{
	if (BPSkillUnlocked(%id,taunt)) {
		%message = Client::GetName(%id) @ " Mongo Rage!";
		AreaText(%id,%message,2,15);
		%skill = GetPlayerSkill(%id,$SkillSpeech);
		%hate = round(%skill * 5);
		%spotdist = 20;
		%pos = Gamebase::GetPosition(%id);
		%set = newObject("set", SimSet);
		%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
		Group::iterateRecursive(%set,AOETaunt::Do,%id,%hate);
		deleteObject(%set);
		%locktime = Cap((15 - (%skill / 500)),5,15);
		BPLockSkill(%id,taunt,%locktime,-1);
	}
	else {
		BPDisplaySkillLockTime(%id,taunt);
		return;
	}	
}

function AOETaunt::Do(%object,%id,%hate)
{
	%target = player::GetClient(%object);
	if (%target == %id)
		return;
	if (!Player::isAiControlled(Client::GetOwnedObject(%target)))
		return;
	rpg::SendMessage(%id,$msgyellow,"You taunt " @ Client::GetName(%target) @ "!");
	AI::AddHate(%target,%id,%hate);
	%r = RandBetween(1,6);
	if (%r == 1) %message = Client::GetName(%target) @ " shouts, I will kill you for that, " @ Client::GetName(%id) @ "!";
	else if (%r == 2) %message = Client::GetName(%target) @ " shouts, You will pay with your life, " @ Client::GetName(%id) @ "!";
	else if (%r == 3) %message = Client::GetName(%target) @ " shouts, Now I'm really angry, " @ Client::GetName(%id) @ "!";
	else if (%r == 4) %message = Client::GetName(%target) @ " shouts, Die Die Die, " @ Client::GetName(%id) @ "!";
	else if (%r == 5) %message = Client::GetName(%target) @ " shouts, Dinner comes early, " @ Client::GetName(%id) @ "!";
	else if (%r == 6) %message = Client::GetName(%target) @ " shouts, So you want a fight, " @ Client::GetName(%id) @ "!";
	AreaText(%target,%message,2,15);
}

function DoTaunt(%id)
{
	if (BPSkillUnlocked(%id,taunt)) {
		%target = $TargetCur[%id,0];
		if (%target == "" || %target == -1) {
			rpg::SendMessage(%id,0,"You do not have a current target to taunt!");
			return;
		}
		if (!Player::isAiControlled(Client::GetOwnedObject(%target))) {
			rpg::SendMessage(%id,0,"You cannot taunt human players!");
			return;
		}
		if ((fetchData(%id,"LVL") / fetchData(%target,"LVL")) > 1.5) {
			rpg::SendMessage(%id,0,"Your target is too low a level to taunt!");
			return;
		}
		%dist = Vector::GetDistance(Gamebase::GetPosition(%target),GameBase::GetPosition(%id));
		if (%dist <= 20) {
			rpg::SendMessage(%id,$msgyellow,"You taunt " @ Client::GetName(%target) @ "!");
			%skill = GetPlayerSkill(%id,$SkillSpeech);
			%hate = round(%skill * 10);
			%hate += round(fetchData(%id,"LVL") * 10);
			AI::AddHate(%target,%id,%hate);
			%r = RandBetween(1,6);
			if (%r == 1) %message = Client::GetName(%target) @ " shouts, I will kill you for that, " @ Client::GetName(%id) @ "!";
			else if (%r == 2) %message = Client::GetName(%target) @ " shouts, You will pay with your life, " @ Client::GetName(%id) @ "!";
			else if (%r == 3) %message = Client::GetName(%target) @ " shouts, Now I'm really angry, " @ Client::GetName(%id) @ "!";
			else if (%r == 4) %message = Client::GetName(%target) @ " shouts, Die Die Die, " @ Client::GetName(%id) @ "!";
			else if (%r == 5) %message = Client::GetName(%target) @ " shouts, Dinner comes early, " @ Client::GetName(%id) @ "!";
			else if (%r == 6) %message = Client::GetName(%target) @ " shouts, So you want a fight, " @ Client::GetName(%id) @ "!";
			AreaText(%target,%message,2,15);
			%locktime = Cap((15 - (%skill / 500)),5,15);
			BPLockSkill(%id,taunt,%locktime,-1);
		}
		else
			rpg::SendMessage(%id,0,"Target is too far away to taunt!");
	}
	else {
		BPDisplaySkillLockTime(%id,taunt);
		return;
	}
}	

//###################################################################################################################################	

// COLD		-20% ATK -20% DAMAGE -20% INIT, FREEZE
// FIRE		50% AOE DAMAGE, INIT HIT DAMAGE / SEC
// ENERGY	-10% ATK -10% INIT -10% DAMAGE -10% DEF -10% PROTECT, STUN, 50% AOE
// POISON	STACKING HIT +50% OVER 5 SECONDS
// MELEE	-20% DEF -20% PROTECT, BLEED INIT HIT DAMAGE / SEC 
// PROJ		-20% DEF -20% PROTECT, 50% AOE

function SetupPoison(%id,%init,%value)
{
	//echo(" SETUP POISON " @ %id @ " " @ %init @ " " @ %value);
	%life = GetLifeId(%id);
	%value = round((%value * 0.1) + 1);
	%value *= (GetBonus(%init,$BPPOISONEFFECT) / 100) + 1;
	%value = round(%value);
	%m = 0;
	for (%i = 0; %i <= 4; %i++) {
		schedule("Poison(" @ %id @ "," @ %init @ "," @ %value @ "," @ %life @ ");",%m);
		%m++;
	}	
}

function Poison(%id,%init,%value,%life)
{
	//echo(" POISON " @ %id @ " " @ %init @ " " @ %value @ " " @ %life);
	%newlife = GetLifeId(%id);
	%pos = GameBase::GetPosition(%id);
	if (%newlife != %life)
		return;
	if (IsDead(%id) || $AIISDEAD[%id] == 1)
		return;
	CruSpellBomb(%id,%pos,"AIL_POISON");
	Player::ManualDamage(%init,%id,%value,False,True,"Poison",True);
}

$Damagemsg[Melee] 	= "melee";
$Damagemsg[Projectile] 	= "projectile";
$Damagemsg[Fire] 	= "fire";
$Damagemsg[Cold] 	= "cold";
$Damagemsg[Poison] 	= "poison";
$Damagemsg[Energy] 	= "energy";
$Damagemsg[Arcane] 	= "arcane";

function RR(%a)
{
	return floor(getRandom() * %a + 1);
}

function GetCurrentTarget(%id)
{
	if ($TargetCur[%id] == "")
		return False;
	else
		return $TargetCur[%id];
}

function LowLife(%id)
{
	if (gamebase::GetDamageLevel(Client::getOwnedObject(%id)) > 0.64)
		return True;
	else
		return False;
}

$RaceSound[Skeleton, Acquired, 1] = SoundUndeadAcquired1;

function RaceAttackSound(%id)
{
	%race = fetchData(%id,"RACE");
	if (MTRB(1,5) == 1 && %race != "MaleHuman" && %race != "FemaleHuman") {
		%x = 0;
		for (%i = 1; (%g = $RaceSound[%race,Acquired,%i]) != ""; %i++) {
			%x++;
			%s = %s @ %g @ " ";
		}
		if (%x) {
			%r = MTRB(1,%x);
			%snd = getWord(%s,%r-1);
			playSound(%snd, GameBase::getPosition(%id));
		}
	}
}

function FastAttack(%id)
{
	player::trigger(%id,0);
	player::setArmor(%id,"MaleHumanArmor7");
}

$BOWPROJECTILE["Melee"] = "BowArrowDefault";
$BOWPROJECTILE["Projectile"] = "BowArrowDefault";
$BOWPROJECTILE["Arcane"] = "BowArrowArcane";
$BOWPROJECTILE["Energy"] = "BowArrowEnergy";
$BOWPROJECTILE["Cold"] = "BowArrowCold";
$BOWPROJECTILE["Fire"] = "BowArrowFire";
$BOWPROJECTILE["Poison"] = "BowArrowPoison";

function LockBasic(%id,%lock)
{
	//echo(" _________________________________ LOCKING BASIC " @ %id @ " " @ %lock);
	%id.BasicLocked = 1;
	schedule("UnlockBasic(" @ %id @ "," @ %lock @ ");",%lock - 0.1);
}

function UnlockBasic(%id,%lock)
{
	//echo(" _________________________________ UNLOCKING BASIC " @ %id @ " " @ %lock);
	%id.BasicLocked = 0;
}

function Player::SetupWeaponAttack(%lock,%id,%special,%ranged,%proj,%boost)
{
	if (%id.BasicLocked == 1)
		return;
	LockBasic(%id,%lock);

	//echo("UNLOCKED, CONTINUE...");	

	%strike = 1;
	if (fetchData(%id, "invisible")) {
		%weapon = getCurrentWearFull(%id,13);
		if (WeaponHasSpecial(%weapon,"sneakattack")) {
			if (GetBonus(%id,$BPSNEAKDOUBLE))
				%strike++;
		}
	}
	if ((%double = GetBonus(%id,$BPDOUBLESTRIKE)) > 0) {
		if (RR(100) <= %double)
			%strike++;
	}
	for (%i = 1; %i <= %strike; %i++)	
		Player::WeaponAttack(%id,%special,%ranged,%proj,%boost);
}

//=============================================================================================================================
// EVASION AND REDUCTIONS

$MaxChanceEvade = 50;
$MaxDamageReduction = 75;

function Combat::CreateLVLMultis()
{
	for (%i = 1; %i <= 150; %i++) {
		$LVLMULTI[%i] = 100 * (%i / 150);
	}
}
Combat::CreateLVLMultis();

function Combat::GrabMaxMulti(%lvl)
{
	if ((%m = $LVLMULTI[%lvl]) != "")
		return %m;
	else
		return 100;
}

function Combat::CalcChanceEvade(%id,%target,%evasion)
{
	//echo(" COMBAT : CALC CHANCE EVADE " @ %id @ " " @ %target @ " " @ %evasion);
	%lvl = 1;
	%idlvl = fetchData(%id,"LVL") + fetchData(%id,"ALVL");
	%targlvl = fetchData(%target,"LVL") + fetchData(%target,"ALVL");
	%lvl = %idlvl;
	%m = Combat::GrabMaxMulti(%lvl);
	%max = round(%lvl * %m);
	%evasion -= round(GetBonus(%id,$BPACCURACY) * 15);
	if (%evasion < 0) %evasion = 0;
	%p = MaxCap((%evasion / %max),1);
	%c = round($MaxChanceEvade * %p);
	%c += round(GetBonus(%target,$BPADDALLDEF) / 150);
	%c = MaxCap(%c,99);
	return %c;
}

function Combat::CalcReduction(%id,%target,%ac)
{
	//echo(" COMBAT : CALC REDUCTION " @ %id @ " " @ %target @ " " @ %ac);
	%lvl = 1;
	%idlvl = fetchData(%id,"LVL") + fetchData(%id,"ALVL");
	%targlvl = fetchData(%target,"LVL") + fetchData(%target,"ALVL");
	%lvl = %idlvl;
	%m = Combat::GrabMaxMulti(%lvl);
	%max = round(%lvl * %m);
	%p = MaxCap((%ac / %max),1);
	%r = round($MaxDamageReduction * %p);
	%r += round(GetBonus(%target,$BPADDALLDEF) / 150);
	%r = MaxCap(%r,99);
	return %r;
}

//=============================================================================================================================

function Player::WeaponAttack(%id,%special,%ranged,%proj,%boost)
{
	//echo("========================================================================================================================================================");
	//echo(" PLAYER : WEAPON ATTACK " @ %id @ " " @ %special @ " " @ %ranged @ " " @ %proj @ " " @ %boost);
	%more = 0;
	%totalinc = 0;
	// --------------------------------------------------------------------------------
	RaceAttackSound(%id);
	// --------------------------------------------------------------------------------
	// ATTACKER WEAPON
	%weapon = getCurrentWearFull(%id,13);
	%damageType = newGetWeaponDamageType(%weapon);
	%delay = $BPItem[%weapon,$BPWeaponDelay];
	%ma = False;
	%temp = $BPItem[%weapon,$BPATKSkills];
	if (getWord(%temp,0) == "MartialArts") %ma = True;
	//*************************************************************
	// MAP ARCANE DAMAGE
	if ((%mapb = GetMapBonus(%id,"MDA")) != -1) %damagetype = "Arcane";
	//*************************************************************
	// --------------------------------------------------------------------------------
	if ((%do = $DamageOverride[%id]) != "") {
		if (%do == "SPECTRAL") {
			%rdo = RandBetween(1,3);
			if (%rdo == 1) %damageType = "Fire";
			if (%rdo == 2) %damageType = "Cold";
			if (%rdo == 3) %damageType = "Energy";
		}
		else 
			%damageType = %do;
	}
	// --------------------------------------------------------------------------------
	//echo(" WEAPON " @ %weapon);
	// --------------------------------------------------------------------------------
	if (Player::isAiControlled(Client::GetOwnedObject(%id))) %idai = True;
	else %idai = False;
	// --------------------------------------------------------------------------------
	// DAMAGE TYPE
	if (%damageType == "")
		%damageType = "Melee";
	// --------------------------------------------------------------------------------
	if (%special == "" || %special == False)
		%special = -1;
	// --------------------------------------------------------------------------------
	%presanction = "";
	%sanction = " hit";
	%stun = False;
	%explode = False;
	// --------------------------------------------------------------------------------
	%offensivemod = 1;
	%defensivemod = 1;
	// --------------------------------------------------------------------------------
	// WEAPON SPECIAL
	%bash 		= False;
	%aim 		= False;
	%cleave 	= False;
	%sneakattack 	= False;
	%brawl 		= False;
	if (%id.WeaponSpecial != "" && !%idai) %special = %id.WeaponSpecial;
	if (%special == "bashing") { %bash = True; %sanction = " bash"; }
	if (%special == "cleave") { %cleave = True; %sanction = " cleave"; }
	if (%special == "aiming") { %aim = True; %sanction = " aim shot"; }
	if (%special == "brawling") { %brawl = True; %sanction = " brawl"; }
	// --------------------------------------------------------------------------------
	// HIDDEN
	%sneakattack = False;
	if (fetchData(%id, "invisible")) {
		if (WeaponHasSpecial(%weapon,"sneakattack")) {
			%sneakattack = True;
			%sanction = " sneak attack";
			if (%brawl) %sanction = " sneak brawl";
			%more += GetBonus(%id,$BPMORESNEAK);
		}
	}
	// --------------------------------------------------------------------------------
	if (%special != -1) {
		%offensivemod = $specialoffensivemod[%special];
		%defensivemod = $specialdefensivemod[%special];
	}
	// --------------------------------------------------------------------------------
	// CHECK FOR CURRENT TARGET
	%target = $TargetCur[%id,0];
	if (%target == "") {
		//Client::SendMessage(%id,0,"You don't have a fighting target.");
		return;
	}
	%targlvl = fetchData(%target,"LVL");
	// --------------------------------------------------------------------------------
	if (Player::isAiControlled(Client::GetOwnedObject(%target))) %targetai = True;
	else %targetai = False;
	// --------------------------------------------------------------------------------
	if (IsDead(%target) || IsDead(%id)) return;
	// --------------------------------------------------------------------------------
	// Z CHECK
	%idz = GetWord(GameBase::GetPosition(%id),2);
	%targz = GetWord(GameBase::GetPosition(%target),2);
	%zcheck = False;
	if ((%idz - %targz) > 3 || (%targz - %idz) > 3) {
		if (Player::isAiControlled(Client::GetOwnedObject(%target)))
			%zcheck = True;
		if (Player::isAiControlled(Client::GetOwnedObject(%id)))
			%zcheck = True;
	}
	if (%zcheck == True) {
		rpg::SendMessage(%id,0,"You cannot attack from here!");
		return;
	}
	// --------------------------------------------------------------------------------
	// CHECK FOR RANGE
	if (%ranged == "") %range = 5;
	else %range = 15;
	if ((%rangeinc = GetBonus(%id,$BPWEAPONRANGE)) > 0) 
		%range += (%range * (%rangeinc / 100));
	%targetPos = GameBase::getPosition(%target);
	%idPos = GameBase::getPosition(%id);
	if (Vector::GetDistance(%targetPos,%idPos) > %range) {
		rpg::SendMessage(%id,0,"Target is out of range.");
		return;
	}
	// --------------------------------------------------------------------------------
	// CHECK FOR LINE OF SIGHT
	if (Targeting::LosCheck(%id,%target) == True) {
		rpg::SendMessage(%id,0,"You have no line of sight to your target.");
		return;
	}
	// --------------------------------------------------------------------------------
	// RANGED CHECK FOR MOVING
	if (%ranged == 1) {
		if (gamebase::isAtRest(%id) == False) {
			if (%idai == False)
				return;
		}
		if (%proj != "") {
			%proj = $BOWPROJECTILE[%damageType];
			FireAutoProjectile(%id,%target,%proj);
		}
	}
	// --------------------------------------------------------------------------------
	AI::AddHate(%target,%id,1);
	// --------------------------------------------------------------------------------
	// UNHIDE THE PLAYER AFTER CHECKS
	Unhide(%id);
	UnHide(%target);
	// --------------------------------------------------------------------------------
	// COOLDOWN WEAPON SPECIAL
	WeaponSpecialCooldown(%id,%weapon);
	// --------------------------------------------------------------------------------
	// UPDATE COMBAT
	$InCombat[%id] = 5;
	$InCombat[%target] = 5;
	if (%id.sleepMode != "")
		BindWake(%id,True);
	if (%target.sleepMode != "")
		BindWake(%target,True);
	// --------------------------------------------------------------------------------
	// STATUS CHECKS
	%statuscoldtarget = False;
	%statusmeleetarget = False;
	%statusprojtarget = False;
	%statusenergytarget = False;
	%statuscoldid = False;
	%statusmeleeid = False;
	%statusprojid = False;
	%statusenergyid = False;
	if ($STATUSCOLD[%target] > 0) %statuscoldtarget = True;
	if ($STATUSMELEE[%target] > 0) %statusmeleetarget = True;
	if ($STATUSPROJ[%target] > 0) %statusprojtarget = True;
	if ($STATUSENERGY[%target] > 0) %statusenergytarget = True;
	if ($STATUSCOLD[%id] > 0) %statuscoldid = True;
	if ($STATUSMELEE[%id] > 0) %statusmeleeid = True;
	if ($STATUSPROJ[%id] > 0) %statusprojid = True;
	if ($STATUSENERGY[%id] > 0) %statusenergyid = True;
	// --------------------------------------------------------------------------------
	// DETERMINE HIT MISS
	if (%statuscoldid == True)
		%offensivemod = %offensivemod * 0.75;
	if (%statusenergyid == True)
		%offensivemod = %offensivemod * 0.9;
	if (%statusenergytarget == True)
		%defensivemod = %defensivemod * 0.9;
	if (%statusprojtarget == True && %damagetype == "Projectile")
		%defensivemod = %defensivemod * 0.75;
	if (%statusmeleetarget == True && %damagetype == "Melee")
		%defensivemod = %defensivemod * 0.75;
	%newatk = NewATKSuccessfull(%id,%target,%weapon,%special,%offensivemod,%defensivemod);
	if (%newatk == False) {
		rpg::SendMessage(%id,$msgorange,"You try to" @ %sanction @ " " @ Client::GetName(%target) @ ", but Miss!");
		rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ " tried to" @ %sanction @ " you, but missed!");
		if (%brawl)
			CoolDownBrawl(%id,%weapon);
		return;
	}
	// --------------------------------------------------------------------------------
	// EVASION
	%evasion = 0;
	%evasion += GetBonus(%target,$BPEVASION) + round(GetBonus(%target,$BPADDALLDEF) * 3);
	%evasion *= %defensivemod;
	//*************************************************************
	// MAP EVASION
	if ((%mapb = GetMapBonus(%target,"RPE")) != -1) %evasion -= (%evasion * (%mapb / 100));
	if ((%mapb = GetMapBonus(%target,"IME")) != -1) %evasion += (%evasion * (%mapb / 100));
	//*************************************************************
	// CALC CHANCE ==================================================
	%chance = Combat::CalcChanceEvade(%id,%target,%evasion);
	if (RR(100) <= %chance && %chance >= 1) {
		rpg::SendMessage(%id,$msgorange,"You try to" @ %sanction @ " " @ Client::GetName(%target) @ ", but Miss! Evaded.");
		rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ " tried to" @ %sanction @ " you, but missed! Evaded.");
		return;
	}
	// --------------------------------------------------------------------------------
	// STATUS CHANGE
	%chance = 25;
	%poison = false;
	%burn = false;
	%freeze = false;
	%ignite = false;
	%bleed = false;
	%volley = false;
	%surge = false;
	if (%damagetype == "Cold") {
		%chance += GetBonus(%id,$BPINCCHILL);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDCHILL);
			if (RR(100) >= Cap(%avoid,0,100)) {
				if ($STATUSCOLD[%target] > 0)
					%freeze = True;
				$STATUSCOLD[%target] = 5;
			}
		}
	}
	if (%damagetype == "Poison") {
		%chance += GetBonus(%id,$BPINCPOISON);
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDPOISON);
			if (RR(100) >= Cap(%avoid,0,100))
				%poison = true;
		}
	}
	if (%damagetype == "Energy") {
		%chance += GetBonus(%id,$BPINCSHOCK);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDSHOCK);
			if (RR(100) >= Cap(%avoid,0,100)) {
				if ($STATUSENERGY[%target] > 0)
					%surge = True;
				$STATUSENERGY[%target] = 5;
				%chance = 10;
				%chance += GetBonus(%id,$BPINCSTUN);
				if (RR(100) <= Cap(%chance,0,100)) {
					%avoid = GetBonus(%target,$BPAVOIDSTUN);
					if (RR(100) >= Cap(%avoid,0,100)) {
						%stun = True;
					}
				}
			}
		}
	}
	if (%damagetype == "Melee") {
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			if ($STATUSMELEE[%target] > 0)
				%bleed = True;
			$STATUSMELEE[%target] = 5;
		}
	}
	if (%damagetype == "Projectile") {
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			if ($STATUSPROJ[%target] > 0)
				%volley = True;
			$STATUSPROJ[%target] = 5;
		}
	}
	if (%damagetype == "Fire") {
		%chance += GetBonus(%id,$BPINCBURN);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDBURN);
			if (RR(100) >= Cap(%avoid,0,100)) {
				%burn = True;
				if ($STATUSFIRE[%target] > 0)
					%ignite = True;
				$STATUSFIRE[%target] = 5;
			}
		}
	}
	// --------------------------------------------------------------------------------
	// CHILL ON HIT
	if (GetBonus(%target,$BPCHILLONHIT) == 1)
		$STATUSCOLD[%id] = 5;
	// SHOCK ON HIT
	if (GetBonus(%target,$BPSHOCKONHIT) == 1)
		$STATUSENERGY[%id] = 5;
	// --------------------------------------------------------------------------------
	// DEFAULT BOOST SET TO 1
	if (%boost == "") %boost = 1;
	// --------------------------------------------------------------------------------
	// BASH
	if (%bash) {
		%boost = 1.5;
		%chance = 25;
		%chance += GetBonus(%id,$BPINCSTUN);
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDSTUN);
			if (RR(100) >= Cap(%avoid,0,75))
				%stun = True;
		}
	}
	// --------------------------------------------------------------------------------
	// CLEAVE
	%bleed = false;
	if (%cleave) {
		%boost = 2.0;
		%chance = 50;
		%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100))
			%bleed = True;
	}
	if ((%chance = GetBonus(%id,$BPBLEEDCHANCE)) > 0) {
		if (RR(100) <= Cap(%chance,0,100))
			%bleed = True;
	}
	// --------------------------------------------------------------------------------
	// SNEAK ATTACK
	if (%sneakattack)
		%boost = 3.0;
	// --------------------------------------------------------------------------------
	// AIM
	if (%aim)
		%boost = 1.5;
	// --------------------------------------------------------------------------------
	if (%brawl) {
		if (%ma) %boost = 2.0;
		else %boost = 1.0;
		if (%sneakattack) {
			%boost = 0.0;
			%chance = 100;
		}
		else
			%chance = 10;
		%chance += GetBonus(%id,$BPINCSTUN);
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDSTUN);
			if (RR(100) >= Cap(%avoid,0,100))
				%stun = True;
		}
		CoolDownBrawl(%id,%weapon);
	}
	// --------------------------------------------------------------------------------
	// STUN CHECK
	if (%stun) {
		rpg::SendMessage(%id,$msggreen,"You stun " @ Client::GetName(%target) @ "!");
		StunPlayer(%target,5);
	}
	// --------------------------------------------------------------------------------
	// DAMAGE ROLL
	%roll = GetNewDamageRoll(%id,%weapon);
	%rollHit = floor(getWord(%roll,0));
	%rollMin = floor(getWord(%roll,1));	
	%value = %rollhit;
	%value = %value + round(GetBonus(%id,$BPADDALLOFF) / 10);
	if (%ranged == 1)
		%physbase = GetBonus(%id,$BPRANGEDBASE);
	else
		%physbase = GetBonus(%id,$BPPHYSBASE);
	if ((%takephys = GetBonus(%target,$BPTAKEPHYSDAMAGE)) > 0)
		%physbase += %takephys;
	%value += (%physbase * (%delay / 2));
	%value = floor(%value * %boost);
	//=======================================================
	if (%statuscoldid == True)
		%value *= 0.75;
	if (%statusenergyid == True)
		%value *= 0.9;
	// --------------------------------------------------------------------------------
	// CRITICAL HIT
	%hitcrit = 0;
	%chance = $BPItem[%weapon,$BPWeaponCritChance];
	%critdamage = $BPItem[%weapon,$BPWeaponCritDamage];		
	%chance = %chance * (1 + (GetBonus(%id,$BPCRITCHANCE) / 100) + (GetBonus(%target,$BPTAKECRIT) / 100));
	%critdamage = %critdamage * (1 + (GetBonus(%id,$BPCRITDAMAGE) / 100) + (GetBonus(%target,$BPTAKECRITDAMAGE) / 100));
	%chance += GetBonus(%id,$BPADDALLOFF) / 100;
	%critdamage += GetBonus(%id,$BPADDALLOFF) / 100;
	if (%sneakattack) { %chance += 15; %critdamage += 30; }
	if (%ma) %chance = %chance * (1 + (GetBonus(%id,$BPCRITMA) / 100));
	if (%chance > 100) %chance = 100;
	//*************************************************************
	// MAP CRITICAL
	if ((%mapb = GetMapBonus(%id,"NCH")) != -1) %chance *= 0.5;
	if ((%mapb = GetMapBonus(%id,"MAC")) != -1) %chance *= 2.0;
	//*************************************************************
	%crit = getRandom() * 100;
	if (%crit <= %chance) {
		%avoid = False;
		%avoidcrit = GetBonus(%target,$BPAVOIDCRIT);
		if (%avoidcrit > 0) {
			%chkavoid = floor(getRandom() * 100 + 1);
			if (%chkavoid <= %avoidcrit)
				%avoid = True;
		}
		if (%avoid != True) {
			%hitcrit = 1;
			%presanction = " criticaly";
			%totalinc += %critdamage;
		}
	}
	//echo(" VALUE CRIT " @ %value);
	// --------------------------------------------------------------------------------
	// DAMAGE % INCREASE
	%atk = $BPItem[%weapon,$BPATKSkills];
	%atk = getWord(%atk,0);
	%inc = 0;
	if (%atk == "Slashing")
		%inc = GetBonus(%id,$BPSLASHINGDAMAGE);
	else if (%atk == "Piercing")
		%inc = GetBonus(%id,$BPPIERCINGDAMAGE);
	else if (%atk == "Bludgeoning")
		%inc = GetBonus(%id,$BPBLUDGEGDAMAGE);
	else if (%atk == "Archery")
		%inc = GetBonus(%id,$BPARCHERYDAMAGE);
	else if (%atk == "MartialArts")
		%inc = GetBonus(%id,$BPMADAMAGE);
	if (%inc < 0) %inc = 0;
	%totalinc += %inc;
	//echo(" VALUE DAMAGE INC " @ %value);
	//-------------------------------------------------------
	// TWOHAND
	if ($BPItem[%weapon,$BPWeaponTwoHand]) 
		%more += GetBonus(%id,$BPTWOHANDDMG);
	// --------------------------------------------------------------------------------
	// PHYSICAL DAMAGE
	%physdamage = GetBonus(%id,$BPPHYSICALDAMAGE);
	if (%physdamage == "" || %physdamage < 0) %physdamage = 0;
	%totalinc += %physdamage;
	//echo(" VALUE PHYSICAL DAMAGE " @ %value);
	// --------------------------------------------------------------------------------
	// ELEMENTAL INCREASE
	if (%damagetype == "Cold") 		{ %totalinc += GetBonus(%id,$BPCOLDDAMAGE); }
	if (%damagetype == "Fire") 		{ %totalinc += GetBonus(%id,$BPFIREDAMAGE); }
	if (%damagetype == "Energy") 		{ %totalinc += GetBonus(%id,$BPENERGYDAMAGE); }
	if (%damagetype == "Projectile") 	{ %totalinc += GetBonus(%id,$BPPROJDAMAGE); }
	if (%damagetype == "Melee") 		{ %totalinc += GetBonus(%id,$BPMELEETYPEDAMAGE); }
	if (%damagetype == "Poison") 		{ %totalinc += GetBonus(%id,$BPPOISONDAMAGE); }
	//echo(" VALUE ELEMENTAL INCREASE " @ %value);
	// --------------------------------------------------------------------------------
	// MONSTER TYPE INC
	if (Player::isAiControlled(Client::GetOwnedObject(%target))) {
		%race = fetchData(%target,"CruRACE");
		if (%race == "Demon")			{ %more += GetBonus(%id,$BPDAMAGEDEMON); }
		if (%race == "Beast")			{ %more += GetBonus(%id,$BPDAMAGEBEAST); }
		if (%race == "Undead")			{ %more += GetBonus(%id,$BPDAMAGEUNDEAD); }
		if ($ELITE[%target] == 1)		{ %more += GetBonus(%id,$BPDAMAGEELITE); }
		if ($BOSS[%target] == 1)		{ %more += GetBonus(%id,$BPDAMAGEBOSS); }
	}
	//echo(" VALUE MONSTER TYPE INC " @ %value);
	// --------------------------------------------------------------------------------
	// BERSERK
	if (LowLife(%id) == true) {
		%berserk = Cap(GetBonus(%id,$BPBERSERK),0,30);
		//*************************************************************
		// MAP BERSERK
		if ((%mapb = GetMapBonus(%id,"BEK")) != -1) %berserk += 30;
		//*************************************************************	
		%more += %berserk;
	}
	// echo(" VALUE BERSERK INCREASE " @ %value);
	// --------------------------------------------------------------------------------
	//*************************************************************
	// MAP PHYSICAL DAMAGE
	if ((%mapb = GetMapBonus(%id,"LPD")) != -1) %more -= %mapb;
	if ((%mapb = GetMapBonus(%id,"IMP")) != -1) %more += %mapb;
	//*************************************************************
	// --------------------------------------------------------------------------------
	// TOTAL INCREASE
	//echo(" VALUE TOTAL " @ %value @ " " @ %totalinc);
	%value *= (1+(%totalinc/100));
	%value = round(%value);
	//echo(" VALUE TOTAL 2 " @ %value @ " " @ %totalinc);
	// --------------------------------------------------------------------------------
	// MORE
	if (%more > 0)
		%value += round(%value * (%more / 100));
	if (%more < 0)
		%value -= round(%value * ((%more * -1) / 100));
	// --------------------------------------------------------------------------------
	// TARGET SHIELD
	%tshield = false;
	%tshieldarmor = 0;
	%tshieldblockc = 0;
	%tshieldblocka = 0;
	%isshield = getCurrentWearFull(%target,15);
	if (%isshield != -1 && %isshield != "") {
		if ($BPItem[%isshield,$BPBlockType] == "PHYSICAL") {
			%tshield = true;
			%implicit = $BPItem[%isshield,$BPImplicit];
			for (%tx = 0; (%gx = getWord(%implicit,%tx)) != -1; %tx+=2) {
				%vx = getWord(%implicit,%tx+1);
				if (%gx == "BLOCKHIT%")
					%tshieldblockc = %vx;
				if (%gx == "BLOCKAMMOUNT")
					%tshieldblocka = %vx;
				if (%gx == "ARMOR")
					%tshieldarmor = %vx;
			}
			%tshieldarmor = round(%tshieldarmor * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblockc = round(%tshieldblockc * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblocka = round(%tshieldblocka * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
		}
	}
	// --------------------------------------------------------------------------------
	// TARGET ARMOR
	%ac = 0;
	if (%damagetype == "Melee") 		%ac = GetBonus(%target,$BPMELEEAC);
	if (%damagetype == "Projectile") 	%ac = GetBonus(%target,$BPPROJAC);
	if (%damagetype == "Fire") 		%ac = GetBonus(%target,$BPFIREAC);
	if (%damagetype == "Cold") 		%ac = GetBonus(%target,$BPCOLDAC);
	if (%damagetype == "Poison") 		%ac = GetBonus(%target,$BPPOISONAC);
	if (%damagetype == "Energy") 		%ac = GetBonus(%target,$BPENERGYAC);
	if (%damagetype == "Arcane") 		%ac = GetBonus(%target,$BPARCANEAC);
	%ac += GetBonus(%target,$BPARMOR) + round(GetBonus(%target,$BPADDALLDEF) * 3);
	if (%tshield == True) %ac += %tshieldarmor;
	%ac = round(%ac * (1 + (GetBonus(%target,$BPINCARMOR) / 100)));
	if (%statusenergytarget == True && %damagetype == "Energy")
		%ac *= 0.9;
	if (%statusmeleetarget == True && %damagetype == "Melee")
		%ac *= 0.75;
	if (%statusprojtarget == True && %damagetype == "Projectile")
		%ac *= 0.75;
	//*************************************************************
	// MAP ARMOR
	if ((%mapb = GetMapBonus(%target,"RPA")) != -1) %ac -= (%ac * (%mapb / 100));
	if ((%mapb = GetMapBonus(%target,"IMA")) != -1) %ac += (%ac * (%mapb / 100));
	//*************************************************************
	// ARMOR PEN  ==================================================
	%pen = GetBonus(%id,$BPARMORPEN) + floor(GetBonus(%id,$BPADDALLOFF) * 3);
	if (%pen < 0 || %pen == "") %pen = 0;
	if ((%lvl=fetchData(%id,"LVL")) < 23) %pen *= (%lvl/23);
	%pen = round(%pen);
	%ac -= %pen;
	if (%ac < 0) %ac = 0;
	// CALC REDUCTION ==================================================
	%reduction = Combat::CalcReduction(%id,%target,%ac);
	%reduction = round(%value * (%reduction / 100));
	%value -= %reduction;
	// --------------------------------------------------------------------------------
	// DETERMINE SHIELD BLOCK
	%shieldhit = 0;
	if (%id != %target && %tshield == True) {
		%chance = GetBonus(%target,$BPBLOCKHIT);
		%chance += %tshieldblockc;
		if (RR(100) <= %chance) {
			%shieldhit = 1;
			%blockam = Cap(GetBonus(%target,$BPBLOCKAMMOUNT),1,50000);
			%blockam += %tshieldblocka;
			if ((%riposte = GetBonus(%target,$BPRIPOSTE)) > 0 && RR(100) <= 25)
				Player::ManualDamage(%target,%id,%riposte,True,True,%damageType,False);
			%value -= %blockam;
		}
	}
	//echo(" VALUE SHIELD BLOCK " @ %value);
	// --------------------------------------------------------------------------------
	// ABSORB
	if ((%absorb = $AbsorbTemp[%target]) > 0) {
		if (%value <= %absorb) { %absorb -= %value; %msg = %value; %value = 1; }
		else { %value -= %absorb; %msg = %absorb; %absorb = 0; SetAura(%target,"ABSORB",True); }
		rpg::SendMessage(%id,$msgorange,client::GetName(%target) @ " absorbs " @ %msg @ " points of your damage!");
		rpg::SendMessage(%target,$msgred,"You absorb " @ %msg @ " points of " @ client::GetName(%id) @ "'s damage!");
		$AbsorbTemp[%target] = %absorb;
	}
	//echo(" VALUE ABSORB " @ %value);	
	// --------------------------------------------------------------------------------
	if (%value < 1) %value = 1;
	// --------------------------------------------------------------------------------
	// ADD DAMAGE
	if (GetBonus(%id,$BPADDDAMAGE) > 0)
		%value += GetBonus(%id,$BPADDDAMAGE);
	//echo(" VALUE ADD DAMAGE " @ %value);
	// --------------------------------------------------------------------------------
	// BURN
	if (%burn == True || %volley == True || %surge == True) {
		%burnval = round(%value * 0.5);
		PlayerBurn(%target,%id,%burnval,True,%burn,%volley,%surge);
	}
	// --------------------------------------------------------------------------------
	// POISON
	if (%poison == True)
		SetupPoison(%target,%id,%value);
	// --------------------------------------------------------------------------------
	// BLEED
	if (%bleed == True) {
		$BLEEDINIT[%target] = %id;
		$BLEEDING[%target] = 5;
		$BLEEDHIT[%target] = round(%value/2);
	}
	// --------------------------------------------------------------------------------
	// IGNITE
	if (%ignite == True) {
		$IGNITEINIT[%target] = %id;
		$IGNITED[%target] = 5;
		$IGNITEHIT[%target] = round(%value/2);
	}
	// --------------------------------------------------------------------------------
	// FREEZE
	if (%freeze == True) {
		Item::SetVelocity(client::GetOwnedObject(%target),"0 0 0");
		TestCruBomb(%target,ANIM_FREEZE);
		StunPlayer(%target,5);
	}
	// --------------------------------------------------------------------------------
	// LIFE STEAL
	%lifesteal = GetBonus(%id,$BPLIFESTEAL) + (GetBonus(%id,$BPADDALLOFF) / 150);
	//*************************************************************
	// MAP LIFESTEAL
	if ((%mapb = GetMapBonus(%id,"MLS")) != -1) %lifesteal += %mapb;
	if ((%mapb = GetMapBonus(%id,"NLS")) != -1) %lifesteal = 0;
	//*************************************************************
	if (%lifesteal > 0) {
		%lifesteal = round(%value * (%lifesteal / 100));
		if (%lifesteal > 0)
			refreshHP(%id,(((%lifesteal / 100) * 1) * -1));
	}
	// --------------------------------------------------------------------------------
	// REFLECT
	%reflect = GetBonus(%target,$BPREFLECT);
	//*************************************************************
	// MAP REFLECT
	if ((%mapb = GetMapBonus(%target,"RFF")) != -1) %reflect += %mapb;
	//*************************************************************	
	if (%reflect > 0) {
		%reflect = round(%value * (%reflect / 100));
		if (%reflect > 0)
			Player::ManualDamage(%target,%id,%reflect,True,False,%damagetype,True);
	}
	// --------------------------------------------------------------------------------
	// ARMOR HIT SOUND
	if (%shieldhit) {
		%sound = "SoundHitWoodShield";
	}
	else {
		%armor = getCurrentWearFull(%target,12);
		if (%armor == "none" || %armor == "")
			%sound = "SoundHitFlesh";
		else {
			if ($BPItem[%armor,$BPArmorHitSound] != "")
				%sound = $BPItem[%armor,$BPArmorHitSound];
			else
				%sound = "SoundHitFlesh";
		}
	}
	PlaySound(%sound,%targetPos);
	// --------------------------------------------------------------------------------
	// MESSAGE
	if (!%shieldhit) {
		rpg::SendMessage(%id,$MsgOrange,"You" @ %presanction @ "" @ %sanction @ " " @ client::GetName(%target) @ " for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
		rpg::SendMessage(%target,1,Client::GetName(%id) @ %presanction @ "" @ %sanction @ " you for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
	}
	else {
		rpg::SendMessage(%id,$MsgOrange,"You" @ %presanction @ "" @ %sanction @ " " @ client::GetName(%target) @ "'s shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
		rpg::SendMessage(%target,$MsgRed,Client::GetName(%id) @ %presanction @ "" @ %sanction @ " your shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
	}
	// --------------------------------------------------------------------------------
	// MAGIC & GOLDFIND
	if (Player::isAiControlled(Client::GetOwnedObject(%target)))
		UpdateMonsterFind(%target,%id,%value);
	// --------------------------------------------------------------------------------
	if (fetchData(%target,"RACESUB") == "Goblin" && %targetai == True) {
		if (getBonus(%id,$BPGOBEXPLODE) == 1) {
			if ((fetchData(%target,"HP") / fetchData(%target,"MaxHP")) <= 0.25) {
				if (RR(100) <= 30) {
					%value = fetchData(%target,"HP") + 1;
					%explode = True;
				}
			}
		}
	}
	// --------------------------------------------------------------------------------
	// LIGHTNING HIT
	if (getBonus(%target,$BPLIGHTNINGHIT) > 0)
		LightningHit(%target,%id,%delay);
	// --------------------------------------------------------------------------------
	// APPLY DAMAGE
	DamageTarget(%target,%value,%id);
	if (%ranged) {
		if ((%r = GetBonus(%id,$BPMULTIARROW)) > 0) {
			MultiHit(%id,%target,%value,True,%offensivemod,%defensivemod,%damagetype,%r);
		}
	}
	else {
		if (GetBonus(%id,$BPMELEESPLASH) > 0) {
			MultiHit(%id,%target,%value,False,%offensivemod,%defensivemod,%damagetype,%r);
		}
	}
	//echo("========================================================================================================================================================");
}

function MultiHit(%id,%target,%value,%ranged,%offensivemod,%defensivemod,%damagetype,%r)
{
	%set = newObject("set", SimSet);
	if (%ranged)
		%spotdist = 15;
	else
		%spotdist = 7.5;
	%less = GetBonus(%id,$BPLESSMULTI);
	%value -= (%value * (%less / 100));
	%value = round(%value);
	if (%value < 1) %value = 1;
	%pos = GameBase::GetPosition(%target);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,MultiHit::DoAOE,%id,%value,%ranged,%offensivemod,%defensivemod,%damagetype,%target);
	deleteObject(%set);
}

function MultiHit::DoAOE(%object,%id,%value,%ranged,%offensivemod,%defensivemod,%damagetype,%target)
{
	//echo(" MULTIHIT::DOAOE OBJECT:" @ %object @ " ID:" @ %id @ " VALUE:" @ %value @ " RANGED:" @ %ranged @ " OMOD:" @ %offensivemod @ " DMOD:" @ %defensivemod @ " DAMAGETYPE:" @ %damagetype);
	%cl = player::GetClient(%object);
	if (%cl != %id && %cl != %target) {
		if (Client::GetTeam(%cl) != Client::GetTeam(%id)) {
			if (%ranged) {
				%proj = $BOWPROJECTILE[%damageType];
				FireAutoProjectile(%id,%cl,%proj);
				Player::ManualDamage(%id,%cl,%value,True,False,%damagetype,False,True,%offensivemod,%defensivemod);
			}
			else {
				Player::ManualDamage(%id,%cl,%value,True,False,%damagetype,False,True,%offensivemod,%defensivemod);
			}
		}
	}
}

function Player::MagicBasicAttack(%lock,%id,%hardsb)
{
	//echo(" PLAYER::MAGICBASICATTACK " @ %id @ " " @ %hardsb);

	if (%id.BasicLocked == 1)
		return;
	LockBasic(%id,%lock);

	//echo("UNLOCKED, CONTINUE...");	

	if (%hardsb == "") %hardsb = 0.1;
	//========================================================
	// TARGET
	%target = $TargetCur[%id,0];
	if (%target == "")
		return;
	//========================================================
	// MOVING
	%vel = Item::GetVelocity(%id);
	if (getWord(%vel,0) != "0" || getWord(%vel,1) != "0" || getWord(%vel,2) != "0")
		return;
	//========================================================
	if (IsDead(%target) || IsDead(%id)) return;
	//========================================================
	// Z CHECK
	%idz = GetWord(GameBase::GetPosition(%id),2);
	%targz = GetWord(GameBase::GetPosition(%target),2);
	%zcheck = False;
	if ((%idz - %targz) > 3 || (%targz - %idz) > 3) {
		if (Player::isAiControlled(Client::GetOwnedObject(%target)))
			%zcheck = True;
		if (Player::isAiControlled(Client::GetOwnedObject(%id)))
			%zcheck = True;
	}
	if (%zcheck == True) {
		rpg::SendMessage(%id,0,"You cannot attack from here!");
		return;
	}
	//========================================================
	// CHECK FOR RANGE
	%range = 30;
	if ((%rangeinc = GetBonus(%id,$BPWEAPONRANGE)) > 0) 
		%range += (%range * (%rangeinc / 100));
	%targetPos = GameBase::getPosition(%target);
	%idPos = GameBase::getPosition(%id);
	if (Vector::GetDistance(%targetPos,%idPos) > %range) {
		rpg::SendMessage(%id,0,"Target is out of range.");
		return;
	}
	//========================================================
	// CHECK FOR LINE OF SIGHT
	if (Targeting::LosCheck(%id,%target) == True) {
		rpg::SendMessage(%id,0,"You have no line of sight to your target.");
		return;
	}
	//========================================================
	FireAutoProjectile(%id,%target,"MagicAutoProjectile");
	%weapon = getCurrentWearFull(%id,13);
	%spellbase = $BPItem[%weapon,$BPWeaponMagDamage];
	//echo(" SPELLBASE " @ %spellbase);
	%sb = GetBonus(%id,$BPSPELLBASE) + %spellbase;
	//echo(" SB " @ %sb);
	%min = round((%sb * %hardsb) * 0.7) + 1;
	%max = round((%sb * %hardsb) * 1.3) + 2;
	//echo(" MIN " @ %min @ " MAX " @ %max);
	// --------------------------------------------------------------------------------
	if ((%stun = GetBonus(%id,$BPMAGICBASICSTUN)) > 0) {
		if (RR(100) <= %stun) {
			rpg::SendMessage(%id,$msggreen,"You stun " @ Client::GetName(%target) @ "!");
			StunPlayer(%target,5);
		}
	}
	// --------------------------------------------------------------------------------
	AI::AddHate(%target,%id,1);
	Player::SpellDamage(%target,%id,"Projectile",%min,%max,"",false,%hardsb,True);
}

function Player::SpellDamage(%target,%id,%damagetype,%min,%max,%spell,%nocrit,%hardsb,%auto)
{
	//echo("========================================================================================================================================================");
	//echo("SPELLDAMAGE " @ %target @ " " @ %id @ " " @ %damagetype @ " " @ %min @ " " @ %max @ " " @ %nocrit @ " " @ %hard @ " " @ %auto);
	if (%auto == "") %auto = False;
	%more = 0;
	%totalinc = 0;
	// --------------------------------------------------------------------------------
	if (IsDead(%target)) return;
	if (Player::isAiControlled(Client::GetOwnedObject(%target))) %targetai = True;
	else %targetai = False;
	if (Player::isAiControlled(Client::GetOwnedObject(%id))) %idai = True;
	else %idai = False;
	// --------------------------------------------------------------------------------
	RaceAttackSound(%id);
	// --------------------------------------------------------------------------------
	%weapon = getCurrentWearFull(%id,13);
	%sanction = "hit";
	%value = RandBetween(%min,%max);
	// --------------------------------------------------------------------------------
	//*************************************************************
	// MAP ARCANE DAMAGE
	if ((%mapb = GetMapBonus(%id,"MDA")) != -1) %damagetype = "Arcane";
	//*************************************************************
	if ((%do = $DamageOverride[%id]) != "") {
		if (%do == "SPECTRAL") {
			%rdo = RandBetween(1,3);
			if (%rdo == 1) %damageType = "Fire";
			if (%rdo == 2) %damageType = "Cold";
			if (%rdo == 3) %damageType = "Energy";
		}
		else 
			%damageType = %do;
	}
	// --------------------------------------------------------------------------------
	AI::AddHate(%target,%id,1);
	// --------------------------------------------------------------------------------
	// SPELLBASE
	%spellbase = $BPItem[%weapon,$BPWeaponMagDamage];
	//echo("SPELLBASE " @ %spellbase);
	%spellbase += GetBonus(%id,$BPSPELLBASE);
	//echo("SPELLBASE2 " @ %spellbase);
	if (%hardsb != "")
		%spellbase *= %hardsb;
	if (%auto == True)
		%spellbase = 0;
	if (%spellbase == "" || %spellbase < 0) %spellbase = 0;
	if (%spell != "") {
		%min = $CruSpell[%spell,$CSMinCast];
		%cooldown = $CruSpell[%spell,$CSMinCooldown];
		%spellbase *= ((%min + %cooldown) / 2);
		%delay = %min + %cooldown;
	}
	//echo("SPELLBASE3 " @ %value @ " " @ %spellbase);
	%value += %spellbase;
	//echo(" VALUE4 " @ %value);
	%value += round(GetBonus(%id,$BPADDALLOFF) / 10);
	%value = round(%value);
	//echo(" VALUE5 " @ %value);
	//-------------------------------------------------------
	// TWOHAND MULTI / STAFF&WAND
	if ($BPItem[%weapon,$BPIsMagWeapon] == 1) {
		if ($BPItem[%weapon,$BPWeaponTwoHand]) {
			%more += GetBonus(%id,$BPTWOHANDDMG);
			if ((%staff = GetBonus(%id,$BPSTAFFMAGIC)) > 0)
				%totalinc += %staff;
		}
		else {
			if ((%wand = GetBonus(%id,$BPWANDMAGIC)) > 0)
				%totalinc += %wand;
		}
	}
	// --------------------------------------------------------------------------------
	// STATUS CHECKS
	%statuscoldtarget = False;
	%statusmeleetarget = False;
	%statusprojtarget = False;
	%statusenergytarget = False;
	%statuscoldid = False;
	%statusmeleeid = False;
	%statusprojid = False;
	%statusenergyid = False;
	if ($STATUSCOLD[%target] > 0) %statuscoldtarget = True;
	if ($STATUSMELEE[%target] > 0) %statusmeleetarget = True;
	if ($STATUSPROJ[%target] > 0) %statusprojtarget = True;
	if ($STATUSENERGY[%target] > 0) %statusenergytarget = True;
	if ($STATUSCOLD[%id] > 0) %statuscoldid = True;
	if ($STATUSMELEE[%id] > 0) %statusmeleeid = True;
	if ($STATUSPROJ[%id] > 0) %statusprojid = True;
	if ($STATUSENERGY[%id] > 0) %statusenergyid = True;
	// --------------------------------------------------------------------------------
	// STATUS CHANGE
	%chance = 35;
	%poison = false;
	%burn = false;
	%freeze = false;
	%ignite = false;
	%bleed = false;
	%volley = false;
	%surge = false;	
	if (%damagetype == "Cold") {
		%chance += GetBonus(%id,$BPINCCHILL);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDCHILL);
			if (RR(100) >= Cap(%avoid,0,100)) {
				if ($STATUSCOLD[%target] > 0)
					%freeze = True;
				$STATUSCOLD[%target] = 5;
			}
		}
	}
	if (%damagetype == "Poison") {
		%chance += GetBonus(%id,$BPINCPOISON);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDPOISON);
			if (RR(100) >= Cap(%avoid,0,75))
				%poison = True;
		}
	}
	if (%damagetype == "Energy") {
		%chance += GetBonus(%id,$BPINCSHOCK);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDSHOCK);
			if (RR(100) >= Cap(%avoid,0,100)) {
				if ($STATUSENERGY[%target] > 0)
					%surge = True;
				$STATUSENERGY[%target] = 5;
				%chance = 10;
				%chance += GetBonus(%id,$BPINCSTUN);
				if (RR(100) <= Cap(%chance,0,100)) {
					%avoid = GetBonus(%target,$BPAVOIDSTUN);
					if (RR(100) >= Cap(%avoid,0,100)) {
						%stun = True;
					}
				}
			}
		}
	}
	if (%damagetype == "Melee") {
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			if ($STATUSMELEE[%target] > 0)
				%bleed = True;
			$STATUSMELEE[%target] = 5;
		}
	}
	if (%damagetype == "Projectile") {
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			if ($STATUSPROJ[%target] > 0)
				%volley = True;
			$STATUSPROJ[%target] = 5;
		}
	}
	if (%damagetype == "Fire") {
		%chance += GetBonus(%id,$BPINCBURN);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDBURN);
			if (RR(100) >= Cap(%avoid,0,100)) {
				%burn = True;
				if ($STATUSFIRE[%target] > 0)
					%ignite = True;
				$STATUSFIRE[%target] = 5;
			}
		}
	}
	// --------------------------------------------------------------------------------
	// CHILL ON HIT
	if (GetBonus(%target,$BPCHILLONHIT) == 1)
		$STATUSCOLD[%id] = 5;
	// SHOCK ON HIT
	if (GetBonus(%target,$BPSHOCKONHIT) == 1)
		$STATUSENERGY[%id] = 5;
	// --------------------------------------------------------------------------------
	if (%statuscoldid == True)
		%value *= 0.75;
	if (%statusenergyid == True)
		%value *= 0.9;
	// --------------------------------------------------------------------------------
	// SPELLCRIT
	%hitcrit = 0;
	%chance = $CruSpell[%spell,$CSCritChance];
	%critdamage = $CruSpell[%spell,$CSCritDamage];
	%chance = (%chance * (1 + (GetBonus(%id,$BPSPELLCRIT) / 100)));
	%critdamage = (%critdamage * (1 + (GetBonus(%id,$BPSPCRITDAMAGE) / 100)));
	%chance += GetBonus(%id,$BPADDALLOFF) / 100;
	%critdamage += GetBonus(%id,$BPADDALLOFF) / 100;
	if (%chance > 95) %chance = 95;
	//*************************************************************
	// MAP CRITICAL
	if ((%mapb = GetMapBonus(%id,"NSC")) != -1) %chance *= 0.5;
	if ((%mapb = GetMapBonus(%id,"MAS")) != -1) %chance *= 2.0;
	//*************************************************************
	%crit = getRandom() * 100;
	if (%crit <= %chance && %nocrit != True) {
		%hitcrit = 1;
		%sanction = "criticaly hit";
		%totalinc += %critdamage;
	}
	// --------------------------------------------------------------------------------
	// MAGIC DAMAGE
	%magicdamage = GetBonus(%id,$BPMAGICDAMAGE);
	if (%magicdamage == "" || %magicdamage < 0) %magicdamage = 0;
	%totalinc += %magicdamage;
	//echo(" VALUE MAGIC DAMAGE " @ %value);
	// --------------------------------------------------------------------------------
	// ELEMENTAL INCREASE
	if (%damagetype == "Cold") 		{ %totalinc += GetBonus(%id,$BPCOLDDAMAGE); }
	if (%damagetype == "Fire") 		{ %totalinc += GetBonus(%id,$BPFIREDAMAGE); }
	if (%damagetype == "Energy") 		{ %totalinc += GetBonus(%id,$BPENERGYDAMAGE); }
	if (%damagetype == "Projectile") 	{ %totalinc += GetBonus(%id,$BPPROJDAMAGE); }
	if (%damagetype == "Melee") 		{ %totalinc += GetBonus(%id,$BPMELEETYPEDAMAGE); }
	if (%damagetype == "Poison") 		{ %totalinc += GetBonus(%id,$BPPOISONDAMAGE); }
	//echo(" VALUE ELEMENTAL INC " @ %value);
	// --------------------------------------------------------------------------------
	// CALC TOTAL VALUE
	//echo(" TOTAL VALUE 1 " @ %value @ " TOTALINC " @ %totalinc);
	%value *= (1 + (%totalinc/100));
	%value = round(%value);
	//echo(" TOTAL VALUE 2 " @ %value);
	// --------------------------------------------------------------------------------
	// MONSTER TYPE INC
	if (Player::isAiControlled(Client::GetOwnedObject(%target))) {
		%race = fetchData(%target,"CruRACE");
		if (%race == "Demon")			{ %more += GetBonus(%id,$BPDAMAGEDEMON); }
		if (%race == "Beast")			{ %more += GetBonus(%id,$BPDAMAGEBEAST); }
		if (%race == "Undead")			{ %more += GetBonus(%id,$BPDAMAGEUNDEAD); }
		if ($ELITE[%target] == 1)		{ %more += GetBonus(%id,$BPDAMAGEELITE); }
		if ($BOSS[%target] == 1)		{ %more += GetBonus(%id,$BPDAMAGEBOSS); }
	}
	//echo(" VALUE MONSTER TYPE INC " @ %value);
	// --------------------------------------------------------------------------------
	// BERSERK
	if (LowLife(%id) == true) {
		%berserk = Cap(GetBonus(%id,$BPBERSERK),0,30);
		//*************************************************************
		// MAP BERSERK
		if ((%mapb = GetMapBonus(%id,"BEK")) != -1) %berserk += 30;
		//*************************************************************	
		%more += %berserk;
	}
	//echo(" VALUE BERSERK INCREASE " @ %value);
	// --------------------------------------------------------------------------------
	//*************************************************************
	// MAP MAGIC DAMAGE
	if ((%mapb = GetMapBonus(%id,"LMD")) != -1) %more -= %mapb;
	if ((%mapb = GetMapBonus(%id,"IMM")) != -1) %more += %mapb;
	//*************************************************************
	// --------------------------------------------------------------------------------
	// MORE
	if (%more > 0)
		%value += round(%value * (%more / 100));
	if (%more < 0)
		%value -= round(%value * ((%more * -1) / 100));
	//echo(" VALUE MORE " @ %value);
	// --------------------------------------------------------------------------------
	// TARGET SHIELD
	%tshield = false;
	%tshieldarmor = 0;
	%tshieldblockc = 0;
	%tshieldblocka = 0;
	%isshield = getCurrentWearFull(%target,15);
	if (%isshield != -1 && %isshield != "") {
		if ($BPItem[%isshield,$BPBlockType] == "MAGICAL") {
			%tshield = true;
			%implicit = $BPItem[%isshield,$BPImplicit];
			for (%tx = 0; (%gx = getWord(%implicit,%tx)) != -1; %tx+=2) {
				%vx = getWord(%implicit,%tx+1);
				if (%gx == "BLOCKSPELL%")
					%tshieldblockc = %vx;
				if (%gx == "SPLBLOCKAMM")
					%tshieldblocka = %vx;
				if (%gx == "ALLRESIST")
					%tshieldarmor = %vx;
			}
			%tshieldarmor = round(%tshieldarmor * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblockc = round(%tshieldblockc * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblocka = round(%tshieldblocka * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
		}
	}
	// --------------------------------------------------------------------------------
	// TARGET RESISTANCE
	%ac = 0;
	if (%damagetype == "Melee") 		%ac = GetBonus(%target,$BPMELEERES);
	if (%damagetype == "Projectile") 	%ac = GetBonus(%target,$BPPROJRES);
	if (%damagetype == "Fire") 		%ac = GetBonus(%target,$BPFIRERES);
	if (%damagetype == "Cold") 		%ac = GetBonus(%target,$BPCOLDRES);
	if (%damagetype == "Poison") 		%ac = GetBonus(%target,$BPPOISONRES);
	if (%damagetype == "Energy") 		%ac = GetBonus(%target,$BPENERGYRES);
	if (%damagetype == "Arcane") 		%ac = GetBonus(%target,$BPARCANERES);
	%ac += GetBonus(%target,$BPALLRESIST) +  round(GetBonus(%target,$BPADDALLDEF) * 3);
	if (%tshield == True) %ac += %tshieldarmor;
	%ac = round(%ac * (1 + (GetBonus(%target,$BPINCRESIST) / 100)));
	if (%statusenergytarget == True && %damagetype == "Energy")
		%ac *= 0.9;
	if (%statusmeleetarget == True && %damagetype == "Melee")
		%ac *= 0.75;
	if (%statusprojtarget == True && %damagetype == "Projectile")
		%ac *= 0.75;
	//*************************************************************
	// MAP RESIST
	if ((%mapb = GetMapBonus(%target,"RPR")) != -1) %ac -= (%ac * (%mapb / 100));
	if ((%mapb = GetMapBonus(%target,"IMR")) != -1) %ac += (%ac * (%mapb / 100));
	//*************************************************************
	// MAGICPEN  ==================================================
	%pen = GetBonus(%id,$BPMAGICPEN) + floor(GetBonus(%id,$BPADDALLOFF) * 3);
	if (%pen < 0 || %pen == "") %pen = 0;
	if ((%lvl=fetchData(%id,"LVL")) < 115) %pen *= (%lvl/115);
	%pen = round(%pen);
	%ac -= %pen;
	if (%ac < 0) %ac = 0;
	// CALC REDUCTION ==================================================
	%reduction = Combat::CalcReduction(%id,%target,%ac);
	%reduction = round(%value * (%reduction / 100));
	%value -= %reduction;
	// --------------------------------------------------------------------------------
	// DETERMINE SHIELD BLOCK
	%shieldhit = 0;
	if (%id != %target && %tshield == True) {
		%chance = GetBonus(%target,$BPBLOCKSPELL);
		%chance += %tshieldblockc;
		if (RR(100) <= %chance) {
			%shieldhit = 1;
			%blockam = Cap(GetBonus(%target,$BPSPLBLOCKAMM),1,50000);
			%blockam += %tshieldblocka;
			if ((%riposte = GetBonus(%target,$BPRIPOSTE)) > 0 && RR(100) <= 25)
				Player::ManualDamage(%target,%id,%riposte,False,True,%damageType,False);
			%value -= %blockam;
		}
	}
	//echo(" VALUE SHIELD BLOCK " @ %value);
	// --------------------------------------------------------------------------------
	// ABSORB
	if ((%absorb = $AbsorbTemp[%target]) > 0) {
		if (%value <= %absorb) { %absorb -= %value; %msg = %value; %value = 1; }
		else { %value -= %absorb; %msg = %absorb; %absorb = 0; SetAura(%target,"ABSORB",True); }
		rpg::SendMessage(%id,$msgblue,client::GetName(%target) @ " absorbs " @ %msg @ " points of your damage!");
		rpg::SendMessage(%target,$msgcyan,"You absorb " @ %msg @ " points of " @ client::GetName(%id) @ "'s damage!");
		$AbsorbTemp[%target] = %absorb;
	}
	//echo(" VALUE ABSORB " @ %value);
	// --------------------------------------------------------------------------------
	if (%value < 1) %value = 1;
	// --------------------------------------------------------------------------------
	// ADD DAMAGE
	if (GetBonus(%id,$BPADDDAMAGE) > 0)
		%value += GetBonus(%id,$BPADDDAMAGE);
	//echo(" VALUE ADD DAMAGE " @ %value);
	// --------------------------------------------------------------------------------
	// BURN
	if (%burn == True || %volley == True || %surge == True) {
		%burnval = round(%value * 0.5);
		PlayerBurn(%target,%id,%burnval,True,%burn,%volley,%surge);
	}
	// --------------------------------------------------------------------------------
	// POISON
	if (%poison == True)
		SetupPoison(%target,%id,%value);
	// --------------------------------------------------------------------------------
	// BLEED
	if ((%chance = GetBonus(%id,$BPBLEEDCHANCE)) > 0) {
		if (RR(100) <= Cap(%chance,1,95))
			%bleed = True;
	}
	if (%bleed == True) {
		$BLEEDINIT[%target] = %id;
		$BLEEDING[%target] = 5;
		$BLEEDHIT[%target] = round(%value/2);
	}
	// --------------------------------------------------------------------------------
	// IGNITE
	if (%ignite == True) {
		$IGNITEINIT[%target] = %id;
		$IGNITED[%target] = 5;
		$IGNITEHIT[%target] = round(%value/2);
	}
	// --------------------------------------------------------------------------------
	// FREEZE
	if (%freeze == True) {
		Item::SetVelocity(client::GetOwnedObject(%target),"0 0 0");
		TestCruBomb(%target,ANIM_FREEZE);
		StunPlayer(%target,5);
	}
	// --------------------------------------------------------------------------------
	// SPELL VAMP
	%lifesteal = GetBonus(%id,$BPSPELLVAMP) + (GetBonus(%id,$BPADDALLOFF) / 150);
	//*************************************************************
	// MAP SPELLVAMP
	if ((%mapb = GetMapBonus(%id,"MSV")) != -1) %lifesteal += %mapb;
	if ((%mapb = GetMapBonus(%id,"NSV")) != -1) %lifesteal = 0;
	//*************************************************************
	if (%lifesteal > 0) {
		%lifesteal = round(%value * (%lifesteal / 100));
		if (%lifesteal > 0)
			refreshHP(%id,(((%lifesteal / 100) * 1) * -1));
	}
	// --------------------------------------------------------------------------------
	// REFLECT
	%reflect = GetBonus(%target,$BPREFLECT);
	//*************************************************************
	// MAP REFLECT
	if ((%mapb = GetMapBonus(%target,"RFF")) != -1) %reflect += %mapb;
	//*************************************************************	
	if (%reflect > 0) {
		%reflect = round(%value * (%reflect / 100));
		if (%reflect > 0)
			Player::ManualDamage(%target,%id,%reflect,False,False,%damagetype,True);
	}
	// --------------------------------------------------------------------------------
	if (%id != "") {
		if (!%shieldhit) {
			rpg::SendMessage(%target,$Msgcyan,Client::GetName(%id) @ " " @ %sanction @ " you for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
			rpg::SendMessage(%id,$MsgBlue,"You " @ %sanction @ " " @ Client::GetName(%target) @ " for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
		}
		else {
			rpg::SendMessage(%target,$Msgcyan,Client::GetName(%id) @ " " @ %sanction @ " your shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
			rpg::SendMessage(%id,$MsgBlue,"You " @ %sanction @ " " @ Client::GetName(%target) @ "'s shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
		}
	}
	// --------------------------------------------------------------------------------
	// MAGIC & GOLDFIND
	if (Player::isAiControlled(Client::GetOwnedObject(%target)))
		UpdateMonsterFind(%target,%id,%value);
	// --------------------------------------------------------------------------------
	if (fetchData(%target,"RACESUB") == "Goblin" && %targetai == True) {
		if (getBonus(%id,$BPGOBEXPLODE) == 1) {
			if ((fetchData(%target,"HP") / fetchData(%target,"MaxHP")) <= 0.25) {
				if (RR(100) <= 30) {
					%value = fetchData(%target,"HP") + 1;
					%explode = True;
				}
			}
		}
	}
	// --------------------------------------------------------------------------------
	// LIGHTNING HIT
	if (getBonus(%target,$BPLIGHTNINGHIT) > 0)
		LightningHit(%target,%id,%delay);
	//=============================================================================================
	// APPLY DAMAGE
	DamageTarget(%target,%value,%id);
	if (GetBonus(%id,$BPMULTISPELL) > 0) {
		MultiSpell(%id,%target,%value,%offensivemod,%defensivemod,%damagetype,15);
	}
	//echo("========================================================================================================================================================");
}

function MultiSpell(%id,%target,%value,%offensivemod,%defensivemod,%damagetype,%spotdist)
{
	%set = newObject("set", SimSet);
	%less = GetBonus(%id,$BPLESSMULTI);
	echo(" VALUE " @ %value);
	echo(" LESS " @ %less);
	%value -= (%value * (%less / 100));
	%value = round(%value);
	if (%value < 1) %value = 1;
	%pos = GameBase::GetPosition(%target);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,MultiSpell::DoAOE,%id,%value,%offensivemod,%defensivemod,%damagetype,%target);
	deleteObject(%set);
}

function MultiSpell::DoAOE(%object,%id,%value,%offensivemod,%defensivemod,%damagetype,%target)
{
	echo(" MULTISPELL::DOAOE " @ %object @ " " @ %id @ " " @ %value @ " " @ %offensivemod @ " " @ %defensivemod @ " " @ %damagetype);
	%cl = player::GetClient(%object);
	if (%cl != %id && %cl != %target) {
		if (Client::GetTeam(%cl) != Client::GetTeam(%id)) {
			Player::ManualDamage(%id,%cl,%value,False,False,%damagetype,False,True,%offensivemod,%defensivemod);
		}
	}
}


function DecreaseZoneActive(%target,%zone,%spawn)
{
	//echo(" DECREASE ZONE ACTIVE " @ %target @ " " @ %zone @ " " @ %spawn);
	$CRUZONE[%zone,$CZSpawn,%spawn,$CZActive] -= 1;
	if ($CRUZONE[%zone,$CZSpawn,%spawn,$CZActive] <= 0) {
		if ($CRUZONE[%zone,$CZType] == $CZMap) {
			$CRUZONE[%zone,$CZMapWaves]--;
			RefreshActiveMap(%zone);
		}
		$CRUZONE[%zone,$CZSpawn,%spawn,$CZActive] = 0;
	}
}

function StormCloak(%target)
{
	%set = newObject("set", SimSet);
	%spotdist = 30;
	%pos = GameBase::GetPosition(%target);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,StormCloak::DoStorm,%target,%val);
	deleteObject(%set);	
}

function StormCloak::DoStorm(%object,%target)
{
	%cl = player::GetClient(%object);
	if (%cl != %target) {
		if (Client::GetTeam(%cl) != Client::GetTeam(%target)) {
			if (RR(100) > 5)
				return;
			%val = round(fetchData(%target,"MaxMANA") * 0.05);
			%f = %val * 0.2;
			%min = Cap((%val - %f),1,1000);
			%max = Cap((%val + %f),1,1000);
			%val = RandBetween(%min,%max);
			%castpos = GameBase::GetPosition(%cl);
			%b = "ANIM_LIGHTNING";
			CruSpellBomb(%target,%castPos,%b);
			Player::ManualDamage(%target,%cl,%val,False,False,"Energy",False);
		}
	}
}

function LightningHit(%id,%target,%delay)
{
	//echo(" LIGHTNINGHIT " @ %id @ " " @ %target @ " " @ %delay);
	%value = GetBonus(%id,$BPLIGHTNINGHIT);
	%value *= (%delay / 2);
	%castpos = GameBase::GetPosition(%target);
	CruSpellBomb(%target,%castPos,"ANIM_LIGHTNING");
	Player::SpellDamage(%target,%id,"Energy",(%value * 0.7),(%value * 1.3),"",True,0.25);
}

function PlayerBurn(%target,%id,%val,%armor,%burn,%volley,%surge)
{
	//echo(" PLAYER BURN " @ %target @ " " @ %id @ " " @ %val @ " " @ %armor @ " " @ %burn @ " " @ %volley @ " " @ %surge);
	if (%burn == True) {
		%anim = "AIL_BURN";
		%dtype = "Fire";
	}
	if (%volley == True) {
		%anim = "ANIM_PROJ";
		%dtype = "Projectile";
	}
	if (%surge == True) {
		%anim = "ANIM_CHARGE";
		%dtype = "Energy";
	}
	//*************************************************************
	// MAP BURN
	if ((%mapb = GetMapBonus(%id,"NIG")) != -1) return;
	//*************************************************************
	%set = newObject("set", SimSet);
	%spotdist = 30;
	%pos = GameBase::GetPosition(%target);
	CruSpellBomb(%target,%pos,%anim);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,PlayerBurn::DoBurn,%target,%id,%val,%armor,%dtype);
	deleteObject(%set);
}

function PlayerBurn::DoBurn(%object,%target,%id,%val,%armor,%dtype)
{
	// echo(" PLAYERBURN::DOBURN " @ %object @ " " @ %target @ " " @ %id @ " " @ %val @ " " @ %armor);
	%cl = player::GetClient(%object);
	if (%cl != %target) {
		if (Client::GetTeam(%cl) == Client::GetTeam(%target))
			Player::ManualDamage(%id,%cl,%val,%armor,False,%dtype,False);
	}
}

function AOEDamageSpell(%id,%caster,%min,%max,%damagetype,%hard)
{
	%set = newObject("set", SimSet);
	%spotdist = 15;
	%pos = GameBase::GetPosition(%caster);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,AOEDamageSpell::DoAOE,%id,%caster,%min,%max,%damagetype,%hard);
	deleteObject(%set);
}

function AOEDamageSpell::DoAOE(%object,%id,%caster,%min,%max,%damagetype,%hard)
{
	%cl = player::GetClient(%object);
	if (%cl != %caster) {
		if (Client::GetTeam(%cl) != Client::GetTeam(%caster))
			Player::SpellDamage(%cl,%caster,%damagetype,%min,%max,"",True,%hard);
	}
}

function Player::AutoWeapon(%id,%target,%boost,%magic)
{
	//echo(" PLAYER : AUTOWEAPON " @ %id @ " " @ %target @ " " @ %boost @ " " @ %magic);
	%more = 0;
	%totalinc = 0;
	// --------------------------------------------------------------------------------
	// ATTACKER WEAPON
	%weapon = getCurrentWearFull(%id,13);
	%damageType = newGetWeaponDamageType(%weapon);
	%delay = $BPItem[%weapon,$BPWeaponDelay];
	%ma = False;
	%temp = $BPItem[%weapon,$BPATKSkills];
	if (getWord(%temp,0) == "MartialArts") %ma = True;
	//*************************************************************
	// MAP ARCANE DAMAGE
	if ((%mapb = GetMapBonus(%id,"MDA")) != -1) %damagetype = "Arcane";
	//*************************************************************
	if ((%do = $DamageOverride[%id]) != "") {
		if (%do == "SPECTRAL") {
			%rdo = RandBetween(1,3);
			if (%rdo == 1) %damageType = "Fire";
			if (%rdo == 2) %damageType = "Cold";
			if (%rdo == 3) %damageType = "Energy";
		}
		else 
			%damageType = %do;
	}
	// --------------------------------------------------------------------------------
	if (Player::isAiControlled(Client::GetOwnedObject(%id))) %idai = True;
	else %idai = False;
	// --------------------------------------------------------------------------------
	// DAMAGE TYPE
	if (%damageType == "")
		%damageType = "Melee";
	// --------------------------------------------------------------------------------
	if (%special == "" || %special == False)
		%special = -1;
	// --------------------------------------------------------------------------------
	%presanction = "";
	%sanction = " hit";
	%stun = False;
	%explode = False;
	// --------------------------------------------------------------------------------
	%offensivemod = 1;
	%defensivemod = 1;
	// --------------------------------------------------------------------------------
	if (%special != -1) {
		%offensivemod = $specialoffensivemod[%special];
		%defensivemod = $specialdefensivemod[%special];
	}
	// --------------------------------------------------------------------------------
	%targlvl = fetchData(%target,"LVL");
	// --------------------------------------------------------------------------------
	if (Player::isAiControlled(Client::GetOwnedObject(%target))) %targetai = True;
	else %targetai = False;
	// --------------------------------------------------------------------------------
	if (IsDead(%target) || IsDead(%id)) return;
	// --------------------------------------------------------------------------------
	AI::AddHate(%target,%id,1);
	// --------------------------------------------------------------------------------
	// UPDATE COMBAT
	$InCombat[%id] = 5;
	$InCombat[%target] = 5;
	if (%id.sleepMode != "")
		BindWake(%id,True);
	if (%target.sleepMode != "")
		BindWake(%target,True);
	// --------------------------------------------------------------------------------
	// STATUS CHECKS
	%statuscoldtarget = False;
	%statusmeleetarget = False;
	%statusprojtarget = False;
	%statusenergytarget = False;
	%statuscoldid = False;
	%statusmeleeid = False;
	%statusprojid = False;
	%statusenergyid = False;
	if ($STATUSCOLD[%target] > 0) %statuscoldtarget = True;
	if ($STATUSMELEE[%target] > 0) %statusmeleetarget = True;
	if ($STATUSPROJ[%target] > 0) %statusprojtarget = True;
	if ($STATUSENERGY[%target] > 0) %statusenergytarget = True;
	if ($STATUSCOLD[%id] > 0) %statuscoldid = True;
	if ($STATUSMELEE[%id] > 0) %statusmeleeid = True;
	if ($STATUSPROJ[%id] > 0) %statusprojid = True;
	if ($STATUSENERGY[%id] > 0) %statusenergyid = True;
	// --------------------------------------------------------------------------------
	// EVASION
	%evasion = 0;
	%evasion += GetBonus(%target,$BPEVASION) + round(GetBonus(%target,$BPADDALLDEF) * 3);
	%evasion *= %defensivemod;
	//*************************************************************
	// MAP EVASION
	if ((%mapb = GetMapBonus(%target,"RPE")) != -1) %evasion -= (%evasion * (%mapb / 100));
	if ((%mapb = GetMapBonus(%target,"IME")) != -1) %evasion += (%evasion * (%mapb / 100));
	//*************************************************************
	// CALC CHANCE ==================================================
	%chance = Combat::CalcChanceEvade(%id,%target,%evasion);
	if (RR(100) <= %chance && %chance >= 1) {
		rpg::SendMessage(%id,$msgorange,"You try to" @ %sanction @ " " @ Client::GetName(%target) @ ", but Miss! Evaded.");
		rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ " tried to" @ %sanction @ " you, but missed! Evaded.");
		return;
	}
	// --------------------------------------------------------------------------------
	// STATUS CHANGE
	%chance = 25;
	%poison = false;
	%burn = false;
	%freeze = false;
	%ignite = false;
	%bleed = false;
	%volley = false;
	%surge = false;
	if (%damagetype == "Cold") {
		%chance += GetBonus(%id,$BPINCCHILL);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDCHILL);
			if (RR(100) >= Cap(%avoid,0,100)) {
				if ($STATUSCOLD[%target] > 0)
					%freeze = True;
				$STATUSCOLD[%target] = 5;
			}
		}
	}
	if (%damagetype == "Poison") {
		%chance += GetBonus(%id,$BPINCPOISON);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDPOISON);
			if (RR(100) >= Cap(%avoid,0,100))
				%poison = true;
		}
	}
	if (%damagetype == "Energy") {
		%chance += GetBonus(%id,$BPINCSHOCK);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDSHOCK);
			if (RR(100) >= Cap(%avoid,0,100)) {
				if ($STATUSENERGY[%target] > 0)
					%surge = True;
				$STATUSENERGY[%target] = 5;
				%chance = 10;
				%chance += GetBonus(%id,$BPINCSTUN);
				if (RR(100) <= Cap(%chance,0,100)) {
					%avoid = GetBonus(%target,$BPAVOIDSTUN);
					if (RR(100) >= Cap(%avoid,0,100)) {
						%stun = True;
					}
				}
			}
		}
	}
	if (%damagetype == "Melee") {
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			if ($STATUSMELEE[%target] > 0)
				%bleed = True;
			$STATUSMELEE[%target] = 5;
		}
	}
	if (%damagetype == "Projectile") {
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			if ($STATUSPROJ[%target] > 0)
				%volley = True;
			$STATUSPROJ[%target] = 5;
		}
	}
	if (%damagetype == "Fire") {
		%chance += GetBonus(%id,$BPINCBURN);
		//%chance = round(%chance * (%delay/2));
		if (RR(100) <= Cap(%chance,0,100)) {
			%avoid = GetBonus(%target,$BPAVOIDBURN);
			if (RR(100) >= Cap(%avoid,0,100)) {
				%burn = True;
				if ($STATUSFIRE[%target] > 0)
					%ignite = True;
				$STATUSFIRE[%target] = 5;
			}
		}
	}
	// --------------------------------------------------------------------------------
	// CHILL ON HIT
	if (GetBonus(%target,$BPCHILLONHIT) == 1)
		$STATUSCOLD[%id] = 5;
	// SHOCK ON HIT
	if (GetBonus(%target,$BPSHOCKONHIT) == 1)
		$STATUSENERGY[%id] = 5;
	// --------------------------------------------------------------------------------
	// DEFAULT BOOST SET TO 1
	if (%boost == "") %boost = 1;
	// --------------------------------------------------------------------------------
	// STUN CHECK
	if (%stun) {
		rpg::SendMessage(%id,$msggreen,"You stun " @ Client::GetName(%target) @ "!");
		StunPlayer(%target,5);
	}
	// --------------------------------------------------------------------------------
	// DAMAGE ROLL
	%roll = GetNewDamageRoll(%id,%weapon);
	%rollHit = floor(getWord(%roll,0));
	%rollMin = floor(getWord(%roll,1));
	%value = %rollhit;
	%value = %value + round(GetBonus(%id,$BPADDALLOFF) / 10);
	if (%ranged == 1)
		%physbase = GetBonus(%id,$BPRANGEDBASE);
	else
		%physbase = GetBonus(%id,$BPPHYSBASE);
	if ((%takephys = GetBonus(%target,$BPTAKEPHYSDAMAGE)) > 0)
		%physbase += %takephys;
	%value += (%physbase * (%delay / 2));
	%value = floor(%value * %boost);
	//-------------------------------------------------------
	// MAGIC DAMAGE INCREASE
	if (%magic == True) {
		%value += (GetBonus(%id,$BPSPELLBASE) * %boost);
		%totalinc += GetBonus(%id,$BPMAGICDAMAGE);
	}
	//-------------------------------------------------------
	// TWOHAND
	if ($BPItem[%weapon,$BPWeaponTwoHand]) 
		%more += GetBonus(%id,$BPTWOHANDDMG);	
	//=======================================================
	if (%statuscoldid == True)
		%value *= 0.75;
	if (%statusenergyid == True)
		%value *= 0.9;
	//echo(" VALUE DAMAGE ROLL " @ %value);
	// --------------------------------------------------------------------------------
	// CRITICAL HIT
	%hitcrit = 0;
	%chance = $BPItem[%weapon,$BPWeaponCritChance];
	%critdamage = $BPItem[%weapon,$BPWeaponCritDamage];
	%chance = %chance * (1 + (GetBonus(%id,$BPCRITCHANCE) / 100) + (GetBonus(%target,$BPTAKECRIT) / 100));
	%critdamage = %critdamage * (1 + (GetBonus(%id,$BPCRITDAMAGE) / 100) + (GetBonus(%target,$BPTAKECRITDAMAGE) / 100));
	if (%ma) %chance = %chance * (1 + (GetBonus(%id,$BPCRITMA) / 100));
	%chance += GetBonus(%id,$BPADDALLOFF) / 100;
	%critdamage += GetBonus(%id,$BPADDALLOFF) / 100;
	if (%sneakattack) { %chance += 15; %critdamage += 30; }
	if (%chance > 100) %chance = 100;
	//*************************************************************
	// MAP CRITICAL
	if ((%mapb = GetMapBonus(%id,"NCH")) != -1) %chance *= 0.5;
	if ((%mapb = GetMapBonus(%id,"MAC")) != -1) %chance *= 2.0;
	//*************************************************************
	%crit = getRandom() * 100;
	if (%crit <= %chance) {
		%avoid = False;
		%avoidcrit = GetBonus(%target,$BPAVOIDCRIT);
		if (%avoidcrit > 0) {
			%chkavoid = floor(getRandom() * 100 + 1);
			if (%chkavoid <= %avoidcrit)
				%avoid = True;
		}
		if (%avoid != True) {
			%hitcrit = 1;
			%presanction = " criticaly";
			%totalinc += %critdamage;
		}
	}
	//echo(" VALUE CRIT " @ %value);
	// --------------------------------------------------------------------------------
	// DAMAGE % INCREASE
	%atk = $BPItem[%weapon,$BPATKSkills];
	%atk = getWord(%atk,0);
	%inc = 0;
	if (%atk == "Slashing")
		%inc = GetBonus(%id,$BPSLASHINGDAMAGE);
	else if (%atk == "Piercing")
		%inc = GetBonus(%id,$BPPIERCINGDAMAGE);
	else if (%atk == "Bludgeoning")
		%inc = GetBonus(%id,$BPBLUDGEGDAMAGE);
	else if (%atk == "Archery")
		%inc = GetBonus(%id,$BPARCHERYDAMAGE);
	else if (%atk == "MartialArts")
		%inc = GetBonus(%id,$BPMADAMAGE);
	if (%inc < 0) %inc = 0;
	%totalinc += %inc;
	//echo(" VALUE DAMAGE INC " @ %value);
	// --------------------------------------------------------------------------------
	// PHYSICAL DAMAGE
	%physdamage = GetBonus(%id,$BPPHYSICALDAMAGE);
	if (%physdamage == "" || %physdamage < 0) %physdamage = 0;
	%totalinc += %physdamage;
	//echo(" VALUE PHYSICAL DAMAGE " @ %value);
	// --------------------------------------------------------------------------------
	// ELEMENTAL INCREASE
	if (%damagetype == "Cold") 		{ %totalinc += GetBonus(%id,$BPCOLDDAMAGE); }
	if (%damagetype == "Fire") 		{ %totalinc += GetBonus(%id,$BPFIREDAMAGE); }
	if (%damagetype == "Energy") 		{ %totalinc += GetBonus(%id,$BPENERGYDAMAGE); }
	if (%damagetype == "Projectile") 	{ %totalinc += GetBonus(%id,$BPPROJDAMAGE); }
	if (%damagetype == "Melee") 		{ %totalinc += GetBonus(%id,$BPMELEETYPEDAMAGE); }
	if (%damagetype == "Poison") 		{ %totalinc += GetBonus(%id,$BPPOISONDAMAGE); }
	//echo(" VALUE ELEMENTAL INCREASE " @ %value);
	// --------------------------------------------------------------------------------
	// MONSTER TYPE INC
	if (Player::isAiControlled(Client::GetOwnedObject(%target))) {
		%race = fetchData(%target,"CruRACE");
		if (%race == "Demon")			{ %more += GetBonus(%id,$BPDAMAGEDEMON); }
		if (%race == "Beast")			{ %more += GetBonus(%id,$BPDAMAGEBEAST); }
		if (%race == "Undead")			{ %more += GetBonus(%id,$BPDAMAGEUNDEAD); }
		if ($ELITE[%target] == 1)		{ %more += GetBonus(%id,$BPDAMAGEELITE); }
		if ($BOSS[%target] == 1)		{ %more += GetBonus(%id,$BPDAMAGEBOSS); }
	}
	//echo(" VALUE MONSTER TYPE INC " @ %value);
	// --------------------------------------------------------------------------------
	// BERSERK
	if (LowLife(%id) == true) {
		%berserk = Cap(GetBonus(%id,$BPBERSERK),0,30);
		//*************************************************************
		// MAP BERSERK
		if ((%mapb = GetMapBonus(%id,"BEK")) != -1) %berserk += 30;
		//*************************************************************	
		%more += %berserk;
	}
	// echo(" VALUE BERSERK INCREASE " @ %value);
	// --------------------------------------------------------------------------------
	//*************************************************************
	// MAP PHYSICAL DAMAGE
	if ((%mapb = GetMapBonus(%id,"LPD")) != -1) %more -= %mapb;
	if ((%mapb = GetMapBonus(%id,"IMP")) != -1) %more += %mapb;
	//*************************************************************
	// --------------------------------------------------------------------------------
	// TOTAL INCREASE
	%value *= (1+(%totalinc/100));
	%value = round(%value);
	// --------------------------------------------------------------------------------
	// MORE
	if (%more > 0)
		%value += round(%value * (%more / 100));
	if (%more < 0)
		%value -= round(%value * ((%more * -1) / 100));
	// --------------------------------------------------------------------------------
	// TARGET SHIELD
	%tshield = false;
	%tshieldarmor = 0;
	%tshieldblockc = 0;
	%tshieldblocka = 0;
	%isshield = getCurrentWearFull(%target,15);
	if (%isshield != -1 && %isshield != "") {
		if ($BPItem[%isshield,$BPBlockType] == "PHYSICAL") {
			%tshield = true;
			%implicit = $BPItem[%isshield,$BPImplicit];
			for (%tx = 0; (%gx = getWord(%implicit,%tx)) != -1; %tx+=2) {
				%vx = getWord(%implicit,%tx+1);
				if (%gx == "BLOCKHIT%")
					%tshieldblockc = %vx;
				if (%gx == "BLOCKAMMOUNT")
					%tshieldblocka = %vx;
				if (%gx == "ARMOR")
					%tshieldarmor = %vx;
			}
			%tshieldarmor = round(%tshieldarmor * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblockc = round(%tshieldblockc * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblocka = round(%tshieldblocka * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
		}
	}
	// --------------------------------------------------------------------------------
	// TARGET ARMOR
	%ac = 0;
	if (%damagetype == "Melee") 		%ac = GetBonus(%target,$BPMELEEAC);
	if (%damagetype == "Projectile") 	%ac = GetBonus(%target,$BPPROJAC);
	if (%damagetype == "Fire") 		%ac = GetBonus(%target,$BPFIREAC);
	if (%damagetype == "Cold") 		%ac = GetBonus(%target,$BPCOLDAC);
	if (%damagetype == "Poison") 		%ac = GetBonus(%target,$BPPOISONAC);
	if (%damagetype == "Energy") 		%ac = GetBonus(%target,$BPENERGYAC);
	if (%damagetype == "Arcane") 		%ac = GetBonus(%target,$BPARCANEAC);
	%ac += GetBonus(%target,$BPARMOR) + round(GetBonus(%target,$BPADDALLDEF) * 3);
	if (%tshield == True) %ac += %tshieldarmor;
	%ac = round(%ac * (1 + (GetBonus(%target,$BPINCARMOR) / 100)));
	if (%statusenergytarget == True && %damagetype == "Energy")
		%ac *= 0.9;
	if (%statusmeleetarget == True && %damagetype == "Melee")
		%ac *= 0.75;
	if (%statusprojtarget == True && %damagetype == "Projectile")
		%ac *= 0.75;
	//*************************************************************
	// MAP ARMOR
	if ((%mapb = GetMapBonus(%target,"RPA")) != -1) %ac -= (%ac * (%mapb / 100));
	if ((%mapb = GetMapBonus(%target,"IMA")) != -1) %ac += (%ac * (%mapb / 100));
	//*************************************************************
	// ARMOR PEN  ==================================================
	%pen = GetBonus(%id,$BPARMORPEN) + floor(GetBonus(%id,$BPADDALLOFF) * 3);
	if (%pen < 0 || %pen == "") %pen = 0;
	if ((%lvl=fetchData(%id,"LVL")) < 23) %pen *= (%lvl/23);
	%pen = round(%pen);
	%ac -= %pen;
	if (%ac < 0) %ac = 0;
	// CALC REDUCTION ==================================================
	%reduction = Combat::CalcReduction(%id,%target,%ac);
	%reduction = round(%value * (%reduction / 100));
	%value -= %reduction;
	// --------------------------------------------------------------------------------
	// DETERMINE SHIELD BLOCK
	%shieldhit = 0;
	if (%id != %target && %tshield == True) {
		%chance = GetBonus(%target,$BPBLOCKHIT);
		%chance += %tshieldblockc;
		if (RR(100) <= %chance) {
			%shieldhit = 1;
			%blockam = Cap(GetBonus(%target,$BPBLOCKAMMOUNT),1,50000);
			if ((%riposte = GetBonus(%target,$BPRIPOSTE)) > 0 && RR(100) <= 25)
				Player::ManualDamage(%target,%id,%riposte,True,True,%damageType,False);
			%blockam += %tshieldblocka;
			%value -= %blockam;
		}
	}
	//echo(" VALUE SHIELD BLOCK " @ %value);
	// --------------------------------------------------------------------------------
	// ABSORB
	if ((%absorb = $AbsorbTemp[%target]) > 0) {
		if (%value <= %absorb) { %absorb -= %value; %msg = %value; %value = 1; }
		else { %value -= %absorb; %msg = %absorb; %absorb = 0; SetAura(%target,"ABSORB",True); }
		rpg::SendMessage(%id,$msgorange,client::GetName(%target) @ " absorbs " @ %msg @ " points of your damage!");
		rpg::SendMessage(%target,$msgred,"You absorb " @ %msg @ " points of " @ client::GetName(%id) @ "'s damage!");
		$AbsorbTemp[%target] = %absorb;
	}
	//echo(" VALUE ABSORB " @ %value);	
	// --------------------------------------------------------------------------------
	if (%value < 1) %value = 1;
	// --------------------------------------------------------------------------------
	// ADD DAMAGE
	if (GetBonus(%id,$BPADDDAMAGE) > 0)
		%value += GetBonus(%id,$BPADDDAMAGE);
	//echo(" VALUE ADD DAMAGE " @ %value);
	// --------------------------------------------------------------------------------
	// BURN
	if (%burn == True || %volley == True || %surge == True) {
		%burnval = round(%value * 0.5);
		PlayerBurn(%target,%id,%burnval,True,%burn,%volley,%surge);
	}
	// --------------------------------------------------------------------------------
	// POISON
	if (%poison == True)
		SetupPoison(%target,%id,%value);
	// --------------------------------------------------------------------------------
	// BLEED
	if ((%chance = GetBonus(%id,$BPBLEEDCHANCE)) > 0) {
		if (RR(100) <= Cap(%chance,0,100))
			%bleed = True;
	}
	if (%bleed == True) {
		$BLEEDINIT[%target] = %id;
		$BLEEDING[%target] = 5;
		$BLEEDHIT[%target] = round(%value/2);
	}
	// --------------------------------------------------------------------------------
	// IGNITE
	if (%ignite == True) {
		$IGNITEINIT[%target] = %id;
		$IGNITED[%target] = 5;
		$IGNITEHIT[%target] = round(%value/2);
	}
	// --------------------------------------------------------------------------------
	// FREEZE
	if (%freeze == True) {
		Item::SetVelocity(client::GetOwnedObject(%target),"0 0 0");
		TestCruBomb(%target,ANIM_FREEZE);
		StunPlayer(%target,5);
	}
	// --------------------------------------------------------------------------------
	// LIFE STEAL
	%lifesteal = GetBonus(%id,$BPLIFESTEAL) + (GetBonus(%id,$BPADDALLOFF) / 150);
	//*************************************************************
	// MAP LIFESTEAL
	if ((%mapb = GetMapBonus(%id,"MLS")) != -1) %lifesteal += %mapb;
	if ((%mapb = GetMapBonus(%id,"NLS")) != -1) %lifesteal = 0;
	//*************************************************************
	if (%lifesteal > 0) {
		%lifesteal = round(%value * (%lifesteal / 100));
		if (%lifesteal > 0)
			refreshHP(%id,(((%lifesteal / 100) * 1) * -1));
	}
	// --------------------------------------------------------------------------------
	// REFLECT
	%reflect = GetBonus(%target,$BPREFLECT);
	//*************************************************************
	// MAP REFLECT
	if ((%mapb = GetMapBonus(%target,"RFF")) != -1) %reflect += %mapb;
	//*************************************************************	
	if (%reflect > 0) {
		%reflect = round(%value * (%reflect / 100));
		if (%reflect > 0)
			Player::ManualDamage(%target,%id,%reflect,True,False,%damagetype,True);
	}
	// --------------------------------------------------------------------------------
	// ARMOR HIT SOUND
	if (%shieldhit) {
		%sound = "SoundHitWoodShield";
	}
	else {
		%armor = getCurrentWearFull(%target,12);
		if (%armor == "none" || %armor == "")
			%sound = "SoundHitFlesh";
		else {
			if ($BPItem[%armor,$BPArmorHitSound] != "")
				%sound = $BPItem[%armor,$BPArmorHitSound];
			else
				%sound = "SoundHitFlesh";
		}
	}
	PlaySound(%sound,%targetPos);
	// --------------------------------------------------------------------------------
	// MESSAGE
	if (!%shieldhit) {
		rpg::SendMessage(%id,$msgorange,"You" @ %presanction @ "" @ %sanction @ " " @ client::GetName(%target) @ " for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
		rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ %presanction @ "" @ %sanction @ " you for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
	}
	else {
		rpg::SendMessage(%id,$msgorange,"You" @ %presanction @ "" @ %sanction @ " " @ client::GetName(%target) @ "'s shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
		rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ %presanction @ "" @ %sanction @ " your shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
	}
	// --------------------------------------------------------------------------------
	// MAGIC & GOLDFIND
	if (Player::isAiControlled(Client::GetOwnedObject(%target)))
		UpdateMonsterFind(%target,%id,%value);
	// --------------------------------------------------------------------------------
	if (fetchData(%target,"RACESUB") == "Goblin" && %targetai == True) {
		if (getBonus(%id,$BPGOBEXPLODE) == 1) {
			if ((fetchData(%target,"HP") / fetchData(%target,"MaxHP")) <= 0.25) {
				if (RR(100) <= 30) {
					%value = fetchData(%target,"HP") + 1;
					%explode = True;
				}
			}
		}
	}
	// --------------------------------------------------------------------------------
	// LIGHTNING HIT
	if (getBonus(%target,$BPLIGHTNINGHIT) > 0)
		LightningHit(%target,%id,%delay);
	// --------------------------------------------------------------------------------
	// APPLY DAMAGE
	DamageTarget(%target,%value,%id);
}

function Player::ManualDamage(%id,%target,%value,%armor,%bypass,%damagetype,%silent,%full,%offensivemod,%defensivemod)
{
	//echo("PLAYER::MANUALDAMAGE " @ %id @ " " @ %target @ " " @ %value @ " " @ %armor @ " " @ %bypass @ " " @ %damagetype);
	if (%armor == "") %armor = False;
	if (%bypass == "") %bypass = True;
	if (%damagetype == "") %damagetype = "unknown";
	if (%silent == "") %silent = False;
	if (%fullcheck == "") %fullcheck = False;
	//*************************************************************
	// MAP ARCANE DAMAGE
	if ((%mapb = GetMapBonus(%id,"MDA")) != -1) %damagetype = "Arcane";
	//*************************************************************
	// --------------------------------------------------------------------------------
	if (IsDead(%target)) return;
	if (Player::isAiControlled(Client::GetOwnedObject(%target))) %targetai = True;
	else %targetai = False;
	if (Player::isAiControlled(Client::GetOwnedObject(%id))) %idai = True;
	else %idai = False;
	// --------------------------------------------------------------------------------
	AI::AddHate(%target,%id,1);
	// --------------------------------------------------------------------------------
	// DODGE EVADEMELEE RESIST EVASION
	if (%full == True) {
		if (%armor) {
			%weapon = getCurrentWearFull(%id,13);
			%damageType = newGetWeaponDamageType(%weapon);
			%delay = $BPItem[%weapon,$BPWeaponDelay];
			%ma = False;
			%temp = $BPItem[%weapon,$BPATKSkills];
			%sanction = " hit";
			//-------------------------------------------------------------------
			// ATTACK HIT CHECK
			%newatk = NewATKSuccessfull(%id,%target,%weapon,-1,1.0,%defensivemod);
			if (%newatk == False) {
				rpg::SendMessage(%id,$msgorange,"You try to" @ %sanction @ " " @ Client::GetName(%target) @ ", but Miss!");
				rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ " tried to" @ %sanction @ " you, but missed!");
				return;
			}
			//-------------------------------------------------------------------
			// EVASION
			%evasion = 0;
			%evasion += GetBonus(%target,$BPEVASION) + round(GetBonus(%target,$BPADDALLDEF) * 3);
			%evasion *= %defensivemod;
			//*************************************************************
			// MAP EVASION
			if ((%mapb = GetMapBonus(%target,"RPE")) != -1) %evasion -= (%evasion * (%mapb / 100));
			if ((%mapb = GetMapBonus(%target,"IME")) != -1) %evasion += (%evasion * (%mapb / 100));
			//*************************************************************
			// CALC CHANCE ==================================================
			%chance = Combat::CalcChanceEvade(%id,%target,%evasion);
			if (RR(100) <= %chance && %chance >= 1) {
				rpg::SendMessage(%id,$msgorange,"You try to" @ %sanction @ " " @ Client::GetName(%target) @ ", but Miss! Evaded.");
				rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ " tried to" @ %sanction @ " you, but missed! Evaded.");
				return;
			}
		}
		// --------------------------------------------------------------------------------
		// STATUS CHANGE
		%chance = 25;
		%poison = false;
		%burn = false;
		%freeze = false;
		%ignite = false;
		%bleed = false;
		%volley = false;
		%surge = false;
		if (%damagetype == "Cold") {
			%chance += GetBonus(%id,$BPINCCHILL);
			if (RR(100) <= Cap(%chance,0,100)) {
				%avoid = GetBonus(%target,$BPAVOIDCHILL);
				if (RR(100) >= Cap(%avoid,0,100)) {
					if ($STATUSCOLD[%target] > 0)
						%freeze = True;
					$STATUSCOLD[%target] = 5;
				}
			}
		}
		if (%damagetype == "Poison") {
			%chance += GetBonus(%id,$BPINCPOISON);
			if (RR(100) <= Cap(%chance,0,100)) {
				%avoid = GetBonus(%target,$BPAVOIDPOISON);
				if (RR(100) >= Cap(%avoid,0,100))
					%poison = true;
			}
		}
		if (%damagetype == "Energy") {
			%chance += GetBonus(%id,$BPINCSHOCK);
			if (RR(100) <= Cap(%chance,0,100)) {
				%avoid = GetBonus(%target,$BPAVOIDSHOCK);
				if (RR(100) >= Cap(%avoid,0,100)) {
					if ($STATUSENERGY[%target] > 0) 
						%surge = True;
					$STATUSENERGY[%target] = 5;
					%chance = 10;
					%chance += GetBonus(%id,$BPINCSTUN);
					if (RR(100) <= Cap(%chance,0,100)) {
						%avoid = GetBonus(%target,$BPAVOIDSTUN);
						if (RR(100) >= Cap(%avoid,0,100))
							%stun = True;
					}
				}
			}
		}
		if (%damagetype == "Melee") {
			if (RR(100) <= Cap(%chance,0,100)) {
				if ($STATUSMELEE[%target] > 0)
					%bleed = True;
				$STATUSMELEE[%target] = 5;
			}
		}
		if (%damagetype == "Projectile") {
			if (RR(100) <= Cap(%chance,0,100)) {
				if ($STATUSPROJ[%target] > 0)
					%volley = True;
				$STATUSPROJ[%target] = 5;
			}
		}
		if (%damagetype == "Fire") {
			%chance += GetBonus(%id,$BPINCBURN);
			if (RR(100) <= Cap(%chance,0,100)) {
				%avoid = GetBonus(%target,$BPAVOIDBURN);
				if (RR(100) >= Cap(%avoid,0,100)) {
					%burn = True;
					if ($STATUSFIRE[%target] > 0)
						%ignite = True;
					$STATUSFIRE[%target] = 5;
				}
			}
		}
		// --------------------------------------------------------------------------------
		if (GetBonus(%target,$BPCHILLONHIT) == 1)
			$STATUSCOLD[%id] = 5;
		if (GetBonus(%target,$BPSHOCKONHIT) == 1)
			$STATUSENERGY[%id] = 5;
		// --------------------------------------------------------------------------------
	}
	// --------------------------------------------------------------------------------
	// TARGET SHIELD
	%tshield = false;
	%tshieldarmor = 0;
	%tshieldblockc = 0;
	%tshieldblocka = 0;
	%shieldhit = 0;
	%isshield = getCurrentWearFull(%target,15);
	if (%isshield != -1 && %isshield != "" && %armor == True && %bypass != True) {
		if ($BPItem[%isshield,$BPBlockType] == "PHYSICAL") {
			%tshield = true;
			%implicit = $BPItem[%isshield,$BPImplicit];
			for (%tx = 0; (%gx = getWord(%implicit,%tx)) != -1; %tx+=2) {
				%vx = getWord(%implicit,%tx+1);
				if (%gx == "BLOCKHIT%")
					%tshieldblockc = %vx;
				if (%gx == "BLOCKAMMOUNT")
					%tshieldblocka = %vx;
				if (%gx == "ARMOR")
					%tshieldarmor = %vx;
			}
			%tshieldarmor = round(%tshieldarmor * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblockc = round(%tshieldblockc * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblocka = round(%tshieldblocka * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
		}
	}
	if (%isshield != -1 && %isshield != "" && %armor == False && %bypass != True) {
		if ($BPItem[%isshield,$BPBlockType] == "MAGICAL") {
			%tshield = true;
			%implicit = $BPItem[%isshield,$BPImplicit];
			for (%tx = 0; (%gx = getWord(%implicit,%tx)) != -1; %tx+=2) {
				%vx = getWord(%implicit,%tx+1);
				if (%gx == "BLOCKSPELL%")
					%tshieldblockc = %vx;
				if (%gx == "SPLBLOCKAMM")
					%tshieldblocka = %vx;
				if (%gx == "ALLRESIST")
					%tshieldarmor = %vx;
			}
			%tshieldarmor = round(%tshieldarmor * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblockc = round(%tshieldblockc * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
			%tshieldblocka = round(%tshieldblocka * (0 + (GetBonus(%target,$BPSHIELDBONUS) / 100)));
		}
	}
	// --------------------------------------------------------------------------------
	// TARGET ARMOR
	if (%armor == True && %bypass != True && %damagetype != "unknown") {
		%ac = 0;
		if (%damagetype == "Melee") 		%ac = GetBonus(%target,$BPMELEEAC);
		if (%damagetype == "Projectile") 	%ac = GetBonus(%target,$BPPROJAC);
		if (%damagetype == "Fire") 		%ac = GetBonus(%target,$BPFIREAC);
		if (%damagetype == "Cold") 		%ac = GetBonus(%target,$BPCOLDAC);
		if (%damagetype == "Poison") 		%ac = GetBonus(%target,$BPPOISONAC);
		if (%damagetype == "Energy") 		%ac = GetBonus(%target,$BPENERGYAC);
		if (%damagetype == "Arcane") 		%ac = GetBonus(%target,$BPARCANEAC);
		%ac += GetBonus(%target,$BPARMOR) + round(GetBonus(%target,$BPADDALLDEF) * 3);
		if (%tshield == True) %ac += %tshieldarmor;
		%ac = round(%ac * (1 + (GetBonus(%target,$BPINCARMOR) / 100)));
		//*************************************************************
		// MAP ARMOR
		if ((%mapb = GetMapBonus(%target,"RPA")) != -1) %ac -= (%ac * (%mapb / 100));
		if ((%mapb = GetMapBonus(%target,"IMA")) != -1) %ac += (%ac * (%mapb / 100));
		//*************************************************************
		// ARMOR PEN  ==================================================
		%pen = GetBonus(%id,$BPARMORPEN) + floor(GetBonus(%id,$BPADDALLOFF) * 3);
		if (%pen < 0 || %pen == "") %pen = 0;
		if ((%lvl=fetchData(%id,"LVL")) < 23) %pen *= (%lvl/23);
		%pen = round(%pen);
		%ac -= %pen;
		if (%ac < 0) %ac = 0;
		// CALC REDUCTION ==================================================
		%reduction = Combat::CalcReduction(%id,%target,%ac);
		%reduction = round(%value * (%reduction / 100));
		%value -= %reduction;
	}
	// --------------------------------------------------------------------------------
	// TARGET RESISTANCE
	if (%armor == False && %bypass != True && %damagetype != "unknown") {
		%ac = 0;
		if (%damagetype == "Melee") 		%ac = GetBonus(%target,$BPMELEERES);
		if (%damagetype == "Projectile") 	%ac = GetBonus(%target,$BPPROJRES);
		if (%damagetype == "Fire") 		%ac = GetBonus(%target,$BPFIRERES);
		if (%damagetype == "Cold") 		%ac = GetBonus(%target,$BPCOLDRES);
		if (%damagetype == "Poison") 		%ac = GetBonus(%target,$BPPOISONRES);
		if (%damagetype == "Energy") 		%ac = GetBonus(%target,$BPENERGYRES);
		if (%damagetype == "Arcane") 		%ac = GetBonus(%target,$BPARCANERES);
		%ac += GetBonus(%target,$BPALLRESIST) +  round(GetBonus(%target,$BPADDALLDEF) * 3);
		if (%tshield == True) %ac += %tshieldarmor;
		%ac = round(%ac * (1 + (GetBonus(%target,$BPINCRESIST) / 100)));
		//*************************************************************
		// MAP RESIST
		if ((%mapb = GetMapBonus(%target,"RPR")) != -1) %ac -= (%ac * (%mapb / 100));
		if ((%mapb = GetMapBonus(%target,"IMR")) != -1) %ac += (%ac * (%mapb / 100));
		//*************************************************************
		// MAGICPEN  ==================================================
		%pen = GetBonus(%id,$BPMAGICPEN) + floor(GetBonus(%id,$BPADDALLOFF) * 3);
		if (%pen < 0 || %pen == "") %pen = 0;
		if ((%lvl=fetchData(%id,"LVL")) < 115) %pen *= (%lvl/115);
		%pen = round(%pen);
		%ac -= %pen;
		if (%ac < 0) %ac = 0;
		// CALC REDUCTION ==================================================
		%reduction = Combat::CalcReduction(%id,%target,%ac);
		%reduction = round(%value * (%reduction / 100));
		%value -= %reduction;
	}
	// --------------------------------------------------------------------------------
	// DETERMINE SHIELD BLOCK
	if (%armor == True && %bypass != True) {
		%shieldhit = 0;
		if (%id != %target && %tshield == True) {
			%chance = GetBonus(%target,$BPBLOCKHIT);
			%chance += %tshieldblockc;
			if (RR(100) <= %chance) {
				%shieldhit = 1;
				%blockam = Cap(GetBonus(%target,$BPBLOCKAMMOUNT),1,50000);
				%blockam += %tshieldblocka;
				if ((%riposte = GetBonus(%target,$BPRIPOSTE)) > 0 && RR(100) <= 25)
					Player::ManualDamage(%target,%id,%riposte,False,True,%damageType,False);
				%value -= %blockam;
			}
		}
	}
	if (%armor == False && %bypass != True) {
		%shieldhit = 0;
		if (%id != %target && %tshield == True) {
			%chance = GetBonus(%target,$BPBLOCKSPELL);
			%chance += %tshieldblockc;
			if (RR(100) <= %chance) {
				%shieldhit = 1;
				%blockam = Cap(GetBonus(%target,$BPSPLBLOCKAMM),1,50000);
				%blockam += %tshieldblocka;
				if ((%riposte = GetBonus(%target,$BPRIPOSTE)) > 0 && RR(100) <= 25)
					Player::ManualDamage(%target,%id,%riposte,True,True,%damageType,False);
				%value -= %blockam;
			}
		}
	}
	// --------------------------------------------------------------------------------
	// ABSORB
	if (%bypass != True) {
		if ((%absorb = $AbsorbTemp[%target]) > 0) {
			if (%value <= %absorb) { %absorb -= %value; %msg = %value; %value = 1; }
			else { %value -= %absorb; %msg = %absorb; %absorb = 0; SetAura(%target,"ABSORB",True); }
			rpg::SendMessage(%id,$msgorange,client::GetName(%target) @ " absorbs " @ %msg @ " points of your damage!");
			rpg::SendMessage(%target,$msgred,"You absorb " @ %msg @ " points of " @ client::GetName(%id) @ "'s damage!");
			$AbsorbTemp[%target] = %absorb;
		}
	}
	// --------------------------------------------------------------------------------
	if (%full == True) {
		if (%burn == True || %volley == True || %surge == True) {
			%burnval = round(%value * 0.5);
			PlayerBurn(%target,%id,%burnval,True,%burn,%volley,%surge);
		}
		if (%poison == True)
			SetupPoison(%target,%id,%value);
		if ((%chance = GetBonus(%id,$BPBLEEDCHANCE)) > 0) {
			if (RR(100) <= Cap(%chance,0,100))
				%bleed = True;
		}
		if (%bleed == True) {
			$BLEEDINIT[%target] = %id;
			$BLEEDING[%target] = 5;
			$BLEEDHIT[%target] = round(%value/2);
		}
		if (%ignite == True) {
			$IGNITEINIT[%target] = %id;
			$IGNITED[%target] = 5;
			$IGNITEHIT[%target] = round(%value/2);
		}
		if (%freeze == True) {
			Item::SetVelocity(client::GetOwnedObject(%target),"0 0 0");
			TestCruBomb(%target,ANIM_FREEZE);
			StunPlayer(%target,5);
		}
		%lifesteal = GetBonus(%id,$BPLIFESTEAL) + (GetBonus(%id,$BPADDALLOFF) / 150);
		//*************************************************************
		// MAP LIFESTEAL
		if ((%mapb = GetMapBonus(%id,"MLS")) != -1) %lifesteal += %mapb;
		if ((%mapb = GetMapBonus(%id,"NLS")) != -1) %lifesteal = 0;
		//*************************************************************
		if (%lifesteal > 0) {
			%lifesteal = round(%value * (%lifesteal / 100));
			if (%lifesteal > 0)
				refreshHP(%id,(((%lifesteal / 100) * 1) * -1));
		}
		%reflect = GetBonus(%target,$BPREFLECT);
		//*************************************************************
		// MAP REFLECT
		if ((%mapb = GetMapBonus(%target,"RFF")) != -1) %reflect += %mapb;
		//*************************************************************	
		if (%reflect > 0) {
			%reflect = round(%value * (%reflect / 100));
			if (%reflect > 0)
				Player::ManualDamage(%target,%id,%reflect,True,False,%damagetype,True);
		}
	}
	// --------------------------------------------------------------------------------
	if (%silent != True) {
		%presanction = " ";
		%sanction = "hit";
		if (%target != %id) {
			if (%armor == True) {
				if (!%shieldhit) {
					rpg::SendMessage(%id,$msgorange,"You" @ %presanction @ "" @ %sanction @ " " @ client::GetName(%target) @ " for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
					rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ %presanction @ "" @ %sanction @ " you for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
				}
				else {
					rpg::SendMessage(%id,$msgorange,"You" @ %presanction @ "" @ %sanction @ " " @ client::GetName(%target) @ "'s shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
					rpg::SendMessage(%target,$msgred,Client::GetName(%id) @ %presanction @ "" @ %sanction @ " your shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
				}
			}
			else {
				if (!%shieldhit) {
					rpg::SendMessage(%id,$msgblue,"You" @ %presanction @ "" @ %sanction @ " " @ client::GetName(%target) @ " for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
					rpg::SendMessage(%target,%msgcyan,Client::GetName(%id) @ %presanction @ "" @ %sanction @ " you for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
				}
				else {
					rpg::SendMessage(%id,$msgblue,"You" @ %presanction @ "" @ %sanction @ " " @ client::GetName(%target) @ "'s shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
					rpg::SendMessage(%target,%msgcyan,Client::GetName(%id) @ %presanction @ "" @ %sanction @ " your shield for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
				}				
			}
		}
		else {
			if (%armor == True)
				rpg::SendMessage(%target,$msgred,"You " @ %sanction @ " yourself for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");
			else
				rpg::SendMessage(%target,$msgcyan,"You " @ %sanction @ " yourself for " @ %value @ " points of " @ $Damagemsg[%damageType] @ " damage!");	
		}
	}
	//========================================================================================================
	// APPLY DAMAGE
	DamageTarget(%target,%value,%id);
}

function ActionKilled(%shooterClient,%damagedClient,%unknown,%explode)
{
	DeathEndSpells(%damagedClient);
	DeathStun(%damagedClient);
	%this = Client::GetOwnedObject(%damagedClient);
	if (player::isAiControlled(%this)) {
		Player::Trigger(%damagedClient,0,0);
		%dlvl = fetchData(%damagedClient,"LVL");
		storedata(%damagedClient,"COINS",GetLootCoins(%dlvl,%damagedClient));
		%magic = $MonsterMagic[%damagedClient];
		%upper = $UPPERLOOT[%damagedClient];
		if (%magic == "" || %magic < 0) %magic = 0;
		//echo(" CREATING MONSTER LOOT START ----------> UPPER" @ %upper @ " MAGIC" @ %magic);
		if ($CruAI[%damagedClient,$AiOwner] == "")
			CreateLoot(%damagedClient,%magic,0,%dlvl,0.1,"",%upper);
		//echo(" CREATING MONSTER LOOT END ----------> " @ %upper);
		%ainame = Client::GetName(%damagedClient);
		ai::callbackPeriodic(%aiName, 0, AI::Periodic);
		$AIISDEAD[%damagedClient] = 1;
	}
	Client::onKilled(%damagedClient, %shooterClient, %type, False);
	playNextAnim(%damagedClient);
	Player::Trigger(%damagedClient,0,0);
	if (%explode == True)
		Player::blowUp(%this);
	Player::Kill(%this);
}

function KillStrayAI(%target)
{
	%zone = $CRUSPAWNZONE[%target];
	$ConnectionId[%target] = -1;
	DeathStun(%target);
	if (%zone != "") {
		%spawn = $CRUSPAWNID[%target];
		schedule("DecreaseZoneActive("@%target@","@%zone@","@%spawn@");",10);
		$CRUSPAWNZONE[%target] = "";
		$CRUSPAWNID[%target] = "";
		%monstername = $CRUMONSTERNAME[%target];
		$CRUMONSTER[%monstername,$CENameOn]--;
		$CRUMONSTERNAME[%target] = "";
		%ainame = Client::GetName(%target);
		ai::callbackPeriodic(%aiName, 0, AI::Periodic);
		$AIISDEAD[%target] = 1;
	}
	storeData(%target, "noDropLootbagFlag", True);
	playNextAnim(%target);
	Player::Trigger(%damagedClient,0,0);
	Player::Kill(Client::GetOwnedObject(%target));
	%list = $HateList[%target];
	if (%list == "")
		return 0;
	for (%i = 0; (%cl = getWord(%list,%i)) != -1; %i+=2) {
		if ($TargetCur[%cl,0] == %target)
			Targeting::Hud(%cl,1);
	}
	$HateList[%target] = "";
}

//###################################################################################################################################

function ManualAddDamagedList(%shooterClient,%damagedClient,%value)
{	
	if ((%aiowner = $CruAI[%shooterClient,$AiOwner]) != "")
		%name = Client::GetName(%aiowner);
	else
		%name = Client::GetName(%shooterClient);	
	%list = $DamagedBy[%damagedClient];
	%found = 0;
	%newlist = "";
	for (%i = 0; (%g = getWord(%list,%i)) != -1; %i+=2) {
		%x = getWord(%list,%i+1);
		if (%name == %g) {
			%found = 1;
			%x += %value;
			%newlist = %newlist @ %g @ " " @ %x @ " ";
		}
		else 
			%newlist = %newlist @ %g @ " " @ %x @ " ";
	}	
	if (!%found)
		%newlist = %newlist @ %name @ " " @ %value @ " ";
	$DamagedBy[%damagedClient] = %newlist;
}

function ClearDamagedByList(%damagedClient)
{
	$DamagedBy[%damagedClient] = "";
	$DamagedByArea[%damagedClient] = "";
}

function GetMaxExpGain(%lvl)
{
	return floor((%lvl * 1000) / (%lvl / 2));
}

function CalcExpGain_test(%id,%slvl,%dlvl,%p,%boost)
{
	if (%boost == "") %boost = 1.0;
	
}

function CalcExpGain(%id,%slvl,%dlvl,%p,%boost) 
{
	//echo(" ----------------------------------------------------------------------- ");
	//echo(" CALCEXPGAIN ID:" @ %id @ " SLVL:" @ %slvl @ " DLVL:" @ %dlvl @ " P:" @ %p);
	if (%boost == "")
		%boost = 1.0;
	%maxxp = GetMaxExpGain(%slvl);
	%opt = round(%slvl * 1.5);
	if (%slvl > 0 && %slvl <= 10) %min = round(%slvl * 0.35);
	if (%slvl > 10 && %slvl <= 20) %min = round(%slvl * 0.55);
	if (%slvl > 20) %min = round(%slvl * 0.75);
	if (%min > %dlvl)
		return 0;
	%optp = %dlvl / %opt;
	%xp = round((%maxxp * %optp) * %p);
	if (%xp > %maxxp) %xp = %maxxp;
	%bonus = GetBonus(%id,$BPADDEXP);
	%zone = fetchData(%id,"zone");
	%mapmagic = $CRUZONE[%zone,$CZMapMagic];
	%bonus += %mapmagic;
	%xp = round(%xp * (1 + (%bonus / 100)));
	%xp *= %boost;
	%cap = 99;
	if ($CURRENTCRUMAP == "DESERT") %cap = 149;
	if ($CURRENTCRUMAP == "JUNGLE") %cap = 229;
	if (%slvl > %cap && %slvl < 230)
		%xp = 0;
	if (%xp < 0) return 0;
	%newmax = GetNewMaxEXPGain(%slvl,%boost);
	if (%xp > %newmax)
		return %newmax;
	else
		return round(%xp); 
	//if (%xp > %maxxp)
	//	return round(%maxxp);
	//else
	//	return round(%xp);
	//echo(" XP " @ %xp);
	//echo(" ----------------------------------------------------------------------- ");
	return round(%xp);
}

function GetNewMaxEXPGain(%lvl,%boost)
{
	%d = 0.1;
	if (%lvl <= 10) %d = 0.25;
	if (%lvl <= 5) %d = 0.5;
	if (%lvl <= 2) %d = 0.75;
	return round(((%lvl * 1000) * %d) * %boost);
}

function TestExp()
{
	if (-29938234333445522 < 0) return True;
	else return False;
}

function DistributeExpForKilling(%id)
{
	//echo(" DISTRIBUTEEXPFORKILLING " @ %id);
	$DamagedByArea[%id] = "";
	%pos = Gamebase::GetPosition(%id);
	%set = newObject("set", SimSet);
	%spotdist = 200;
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,DistributeExpForKilling::Add,%id);
	deleteObject(%set);
	DistributeExpForKilling::Final(%id);
}

function DistributeExpForKilling::Add(%object,%id)
{
	//echo(" DISTRIBUTEEXPFORKILLING::ADD " @ %id);
	%target = player::GetClient(%object);
	if (%target != %id) {
		if ($TARGETINGAREA[%id] != $TARGETINGAREA[%target])
			return;
		$DamagedByArea[%id] = $DamagedByArea[%id] @ Client::GetName(%target) @ " ";
	}
}

function DistributeExpForKilling::Final(%id)
{
	//echo(" DISTRIBUTEEXPFORKILLING::FINAL " @ %id);
	%area = $DamagedByArea[%id];
	%list = $DamagedBy[%id];
	%dlvl = fetchData(%id,"LVL");
	%dname = Client::GetName(%id);
	if ($ELITE[%id] == 1) %boost = 1.5;
	if ($BOSS[%id] == 1) %boost = 2.0;
	%totaldamage = 0;
	for (%i = 0; (%g = getWord(%list,%i)) != -1; %i++) {
		%z = getWord(%list,%i+1);
		if (%Checked[%g] != True) {
			%Damage[%g] = %z;
			%totaldamage += %z;
			%did = NewGetClientByName(%g);
			if ((%team = PlayerIsInTeam(%did)) != -1) {
				for (%u = 0; (%o = getWord(%area,%u)) != -1; %u++) {
					%uid = NewGetClientByName(%o);
					if (PlayerIsInTeam(%uid) == %team) {
						if (%o != %g) {
							%Checked[%o] = True;
							%Damage[%o] += %z;
						}
					}	
				}
			}
		}
	}
	//echo(" STARTING AREA DISTRIBUTE ==============================================");
	for (%i = 0; (%g = getWord(%area,%i)) != -1; %i++) {
		if ((%damage = %Damage[%g]) != "") {
			%damage = %damage / %totaldamage;
			if (%damage > 0.48999) {
				%did = NewGetClientByName(%g);
				%slvl = fetchData(%did,"LVL");
				%slvl += fetchData(%did,"ALVL");
				%exp = CalcExpGain(%did,%slvl,%dlvl,%damage,%boost);
				DistributeGiveExpGain(%did,%exp,0,0,%dname);
			}
		}
	}
}

function DistributeGiveExpGain(%id,%exp,%rank,%bonus,%dname)
{
	%final = %exp + %rank;
	if (%final > 0)
		Client::sendMessage(%id,0,%dname @ " has died and you gained " @ %final @ " experience!");
	else if (%final < 0)
		Client::sendMessage(%id,0,%dname @ " has died and you lost " @ -%final @ " experience.");
	else if (%final == 0)
		Client::sendMessage(%id,0,%dname @ " has died.");
	if (%bonus != 0)
		Client::sendMessage(%id,2,"You gained " @ %bonus @ " experience as a side bonus.");
	%lvl = fetchData(%id,"LVL");
	if (%lvl < 230)
		storeData(%id,"EXP",(%final + %bonus),"inc");
	else
		storeData(%id,"AEXP",(%final + %bonus),"inc");
	Game::refreshClientScore(%id);
}

//###################################################################################################################################

function TestCrit(%hits,%damage,%chance,%inc,%chancez,%incz)
{
	echo("===============================================================");
	echo(" HITS " @ %hits @ " DAMAGE " @ %damage @ " CHANCE " @ %chance @ " INC " @ %inc);
	%dd = 0;
	%crit = 0;
	%critdamage = floor(%damage * (1 + (%inc / 100)));
	echo(" CRITDAMAGE " @ %critdamage);
	for (%i = 1; %i <= %hits; %i++) {
		if (RR(100) <= %chance) {
			%crit++;
			%dd += %critdamage;
		}
		else {
			%dd += %damage;
		}
	}
	echo(" CRITS " @ %crit);
	echo(" DAMAGE " @ %dd);
	%x[1] = %dd;
	echo("---------------------------------------------------------------");
	echo(" CHANCEZ " @ %chancez @ " INCZ " @ %incz);
	%dd = 0;
	%crit = 0;
	%critdamage = floor(%damage * (1 + (%incz / 100)));
	echo(" CRITDAMAGEZ " @ %critdamage);
	for (%i = 1; %i <= %hits; %i++) {
		if (RR(100) <= %chancez) {
			%crit++;
			%dd += %critdamage;
		}
		else {
			%dd += %damage;
		}
	}
	echo(" CRITSZ " @ %crit);
	echo(" DAMAGEZ " @ %dd);
	%x[2] = %dd;
	echo("===============================================================");
	echo(" X1 " @ %x[1] @ " X2 " @ %x[2]);
	echo(" SUM " @ %x[2] / %x[1]);
	
}

echo("__TEST ");
echo("__NEW COMBAT LOADED");

