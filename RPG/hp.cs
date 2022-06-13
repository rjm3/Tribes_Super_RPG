function setHP(%clientId,%val)
{
	dbecho($dbechoMode, "setHP(" @ %clientId @ ", " @ %val @ ")");
	
	%armor = Player::getArmor(%clientId);

	if(%val < 0)
		%val = 0;
	if(%val == "")
		%val = fetchData(%clientId, "MaxHP");

	%a = %val * %armor.maxDamage;
	%b = %a / fetchData(%clientId, "MaxHP");
	%c = %armor.maxDamage - %b;

	if(%c < 0)
		%c = 0;
	else if(%c > %armor.maxDamage)
		%c = %armor.maxDamage;

	if(%c == %armor.maxDamage && !IsStillArenaFighting(%clientId))
	{
		DeathPenalty(%clientId);
		storeData(%clientId, "LCK", 1, "dec");
		if(fetchData(%clientId, "LCK") >= 0)
			Client::sendMessage(%clientId, 0, "You have lost an LCK point.");

	}
	GameBase::setDamageLevel(Client::getOwnedObject(%clientId), %c);

	Targeting::RefreshTargeters(%clientId);
	RefreshTeamHud(%clientId);

	return %val;
}

function DamageTarget(%target,%val,%id)
{
	if ((%owner = AIIsMinion(%target)) != false) {
		if ((%take = GetBonus(%owner,$BPTAKEMINDAMAGE)) > 0) {
			%tval = round((%val * (%take / 100)) + 1);
			client::SendMessage(%owner,1,"You take " @ %tval @ " damage from your minion!");
			DoDamageTarget(%owner,%tval,%owner);
		}
	}
	DoDamageTarget(%target,%val,%id);
}

function DoDamageTarget(%target,%val,%id)
{
	//echo("DAMAGE TARGET " @ %target @ " " @ %val @ " " @ %id);
	AOEAgg(%id,%target,%val);
	// --------------------------------------------------------------------------------
	// MANA BLOOD
	//*************************************************************
	// MAP MANACOST
	if ((%mapb = GetMapBonus(%target,"MAN")) != -1) %fullmb = True;
	else %fullmb = False;
	//*************************************************************
	if ((%dm = GetBonus(%target,$BPDAMAGEMANA)) > 0 || %fullmb == True) {
		if (%fullmb) %dm = 100;
		%take = %dm / 100;
		%nval = round(%val * %take);
		%mana = fetchData(%target,"MANA");
		if (%nval <= %mana) {			
			refreshMANA(%target,(%nval * 1));
			%val -= %nval;
		}
		if (%nval > %mana) {
			%nval = %mana;
			refreshMANA(%target,(%nval * 1));
			%val -= %nval;
		}
	}
	// --------------------------------------------------------------------------------
	if ((fetchData(%target,"HP") - %val) <= 0) {
		ManualAddDamagedList(%id,%target,%val);
		Client::SendMessage(%id,0,"You killed " @ Client::GetName(%target) @ "!");
		// --------------------------------------------------------------------------------
		// AI
		if ((%zone = $CRUSPAWNZONE[%target]) != "") {
			%spawn = $CRUSPAWNID[%target];
			$CRUSPAWNZONE[%target] = "";
			$CRUSPAWNID[%target] = "";
			%monstername = $CRUMONSTERNAME[%target];
			$CRUMONSTER[%monstername,$CENameOn]--;
			$CRUMONSTERNAME[%target] = "";
			schedule("DecreaseZoneActive("@%target@","@%zone@","@%spawn@");",10);
		}
		// --------------------------------------------------------------------------------
		ActionKilled(%id,%target,99,%explode);
		$TargetCur[%id,0] = "";
		Targeting::Hud(%id,1);
	}
	else {
		if (Player::isAiControlled(Client::GetOwnedObject(%target))) {
			%anger = GetBonus(%id,$BPANGER);
			%hate = %val + %anger;
			AI::AddHate(%target,%id,%hate);
		}
		ManualAddDamagedList(%id,%target,%val);
	}
	refreshHP(%target,((%val / 100) * 1));
}

function DeathPenalty(%id)
{
	if (!Player::isAiControlled(Client::GetOwnedObject(%id))) {
		%lvl = fetchData(%id,"LVL");
		if (%lvl < 50)
			return;
		if (%lvl >= 50) %m = 0.1;
		if (%lvl >= 100) %m = 0.15;
		if (%lvl >= 150) %m = 0.2;
		if (%lvl >= 200) %m = 0.25;
		%loss = round((%lvl * 1000) * 0.1);
		%xp = fetchData(%id,"EXP");
		%newxp = %xp - %loss;
		if (%newxp < 0) %newxp = 0;
		storeData(%id,"EXP",%newxp);
		if (%loss > %xp)
			%loss = %xp;
		if (%loss > 0)
			client::SendMessage(%id,0,"You have lost " @ %loss @ " experience.");
	}
}

function refreshHP(%clientId,%value,%trueval)
{
	dbecho($dbechoMode, "refreshHP(" @ %clientId @ ", " @ %value @ ")");
	return setHP(%clientId, fetchData(%clientId, "HP") - round(%value * $TribesDamageToNumericDamage));
}

function refreshHPREGEN(%clientId)
{
	// DO NOTHING
}
