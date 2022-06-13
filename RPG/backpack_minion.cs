// BACKPACK MINION

//==================================================================================================

$aipeton = 1;

$AiOwner 	= 1;
$AiMode 	= 2;
$AiFollow 	= 3;
$AiMoveTo 	= 4;
$AiHunt 	= 5;
$AIGoPos 	= 6;
$AiTarget 	= 7;
$AiPetId 	= 8;
$AiPetName	= 9;
$AiWait		= 10;
$AiPetList	= 11;
$AiPrev		= 12;

function AIisMinion(%aiId)
{
	if ((%id = $CruAI[%aiId,$AiOwner]) != "")
		return %id;
	else
		return False;
}

function CruAiMaxMinions(%id)
{
	%ret = False;
	%max = 1;
	%max += GetBonus(%id,$BPMAXMINIONS);
	%count = 0;
	%list = $CruAI[%id,$AiPetList];
	if (getWord(%list,0) == -1)
		return False;
	for (%i = 0; getWord(%list,%i) != -1; %i++)
		%count++;
	if (%count >= %max)
		return True;
	else
		return False;
}

function CruAiAddToPetList(%id,%aiid)
{
	$CruAI[%id,$AiPetList] = $CruAI[%id,$AiPetList] @ %aiid @ " ";
}

function CruAiRemoveFromPetList(%id,%aiid)
{
	%newlist = "";
	%list = $CruAI[%id,$AiPetList];
	for (%i = 0; (%gid = getWord(%list,%i)) != -1; %i++) {
		if (%gid != %aiid)
			%newlist = %newlist @ %gid @ " ";	
	}
	$CruAI[%id,$AiPetList] = %newlist;
}

function CruAiDisconnectKill(%id)
{
	echo(" ------------------> CRUAIDISCONNECTKILL " @ %Id);
	%list = $CruAI[%id,$AiPetList];
	if (getWord(%list,0) == -1)
		return;
	for (%i = 0; (%gid = getWord(%list,%i)) != -1; %i++) {
		//CruAiTerminatePet(%id,%gid,False);
		ActionKilled(%id,%gid);
	}
}

function CruAiSpawnPet(%id,%type,%lvl)
{
	%ainame = "PET" @ $aipeton;
	%armor = "UndeadArmor";
	%spawnpos = gameBase::GetPosition(%id);
	%spawnrot = "0 0 0";
	%name = "Minion" @ $AiNameOn;
	$aipeton += 1;
	$AiNameOn++;
	//===========================================================================
	if (AI::spawn(%aiName,%armor,%spawnPos,%spawnRot,%name,"male2") != "false") {
		%aiId = AI::getId(%aiName);
		AI::setVar( %aiName, iq,  1000 );
		setConnectionId(%aiId);
		GameBase::SetTeam(%aiId,0);
		storeData(%AiId, "RACE", "Undead");
		storeData(%AiId, "CruRACE", "Human");
		storeData(%AiId, "EXP", 0);
		storeData(%AiId, "LVL", %lvl);
		GameBase::startFadeIn(%AiId);
		PlaySound(SoundSpawn2, %spawnPos);
		$CruAI[%aiId,$AiOwner] = %id;
		$CruAI[%aiId,$AiMode] = $AiFollow;
		$CruAI[%aiId,$GoPos] = %pos;
		$CruAI[%aiId,$AiTargetGet] = "";
		CruAiAddToPetList(%id,%aiId);
		$AIISDEAD[%aiId] = 0;
		$MONSTERMULTI[%aiId] = 1.0;
		$BOSS[%aiId] = "";
		$ELITE[%aiId] = "";
		$NOLOOT[%aiId] = 1;
		//=====================================================================
		%weapon = TierItem::RandomItem("EnemySword",%lvl);
		$PlayerWear[%aiId,13] = %weapon;
		%maxhp = 0.5;
		%damage = 0.5;
		%end = 0.5;
	 	%maxhp = %maxhp * (1 + (GetBonus(%id,$BPMINIONHEALTH) / 100));
		%damage = %damage * (1 + (GetBonus(%id,$BPMINIONDAMAGE) / 100));
		%end = %end * (1 + (GetBonus(%id,$BPMINIONHEALTH) / 100));
		%loadout = "SLASHING 1.0 ENDURANCE "@%end@" ARMOR 1.0 EVADEMELEE 0.5 MAXHP "@%maxhp@" DODGING 0.5 PHYSICALDAMAGE "@%damage@" WISDOM 0.5";
		%string = %weapon @ " 1 " @ %loadout;
		BackpackMonsterBonus(%aiId,%string);
		//----------------------------------------------------------
		// MINION BONUSES
		$PlayerBonus[%aiId,$BPMAXHP] += GetBonus(%id,$BPMINIONLIFE);
		$PlayerBonus[%aiId,$BPANGER] += GetBonus(%id,$BPMINIONANGER);
		if (GetBonus(%id,$BPMINIONDEFENSE)) {
			$PlayerBonus[%aiId,$BPARMOR] += GetBonus(%id,$BPARMOR);
			$PlayerBonus[%aiId,$BPINCARMOR] += GetBonus(%id,$BPINCARMOR);
			$PlayerBonus[%aiId,$BPALLRESIST] += GetBonus(%id,$BPALLRESIST);
			$PlayerBonus[%aiId,$BPINCRESIST] += GetBonus(%id,$BPINCRESIST);
			$PlayerBonus[%aiId,$BPEVASION] += GetBonus(%id,$BPEVASION);
			$PlayerBonus[%aiId,$BPINCEVASION] += GetBonus(%id,$BPINCEVASION);
		}
		//=====================================================================
		ai::callbackPeriodic(%aiName,1,CruAiPeriodic);
	}
	else {
		echo("MINION SPAWN ERROR");
	}
}

function CruAiSetPetTarget(%id,%aiId)
{
	%target = $TargetCur[%id,0];
	if (%target == "" || %target == -1) {
		Client::SendMesage(%id,0,"You dont have a target!");
		return;
	}
	$TargetCur[%aiId,0] = %target;
	$CruAI[%aiId,$AiMode] = $AiTarget;
	$CruAI[%aiId,$AiTargetGet] = %target;
	Client::SendMessage(%id,2,client::GetName(%aiId) @ " is now attacking " @ client::GetName(%target) @ "!");
}

function CruAiPeriodic(%ainame)
{
	%aiId = AI::getId(%aiName);
	%mode = $CruAI[%aiId,$AiMode];
	%owner = $CruAI[%aiId,$AiOwner];
	if (%mode == $AiFollow) {
		%pos = gameBase::GetPosition(%owner);
		AI::DirectiveWaypoint(%aiName,%pos,99);
		if (Vector::getDistance(%pos,gameBase::GetPosition(%aiId)) > 20) {
			GameBase::SetPosition(%aiId,%pos);
		}
	}
	if (%mode == $AiHunt) {
		if ($CruAI[%aiId,$AiTargetGet] == "") {
			player::trigger(%aiId,0,0);
			Targeting::Obtain(%aiId,50,True,0);
			%targets = $TargetTemp[%aiId,0];
			if ((%t = GetWord(%targets,0)) != -1) {
				$CruAI[%aiId,$AiTargetGet] = %t;
				$TargetCur[%aiId,0] = %t;
				$CruAI[%aiId,$AiPrev] = $AiHunt;
				$CruAI[%aiId,$AiMode] = $AiTarget;
			}	
		}
	}
	if (%mode == $AiTarget) {
		%target = $CruAI[%aiId,$AiTargetGet];
		if ($AIISDEAD[%target]) {
			$CruAI[%aiId,$AiTargetGet] = "";
			$TargetCur[%aiId,0] = "";
			player::trigger(%aiId,0,0);
			$CruAI[%aiId,$AiMode] = $CruAI[%aiId,$AiPrev];
			return;
		}
		%pos = gameBase::GetPosition(%target);
		AI::DirectiveWaypoint(%aiName,%pos,99);
		player::Trigger(%aiId,0,1);
		if (OddsAre(5))
			ai::impulse(%aiId);
	}
	if (%mode == $AiWait) {
		%pos = gameBase::GetPosition(%aiId);
		AI::DirectiveWaypoint(%aiName,%pos,99);
	}
}

function AiAreaTalk(%id,%message)
{
	%owner = $CruAI[%id,$AiOwner];
	%oname = Client::GetName(%owner);
	if (%message == "wait") {
		%r = floor(getRandom() * 6) + 1;
		if (%r == 1) %message = "I will wait here, Master!";
		else if (%r == 2) %message = "I shall wait here untill you say!";
		else if (%r == 3) %message = "Yes Master, I will remain in this area!";
		else %message = "null";
	}
	if (%message == "follow") {
		%r = floor(getRandom() * 6) + 1;
		if (%r == 1) %message = "I am where you are, Great One!";
		else if (%r == 2) %message = "Follow your steps, I will!";
		else if (%r == 3) %message = "Right behind you Master!";
		else %message = "null";
	}
	if (%message == "null") return;
	%name = Client::GetName(%id);
	%pos = GameBase::getPosition(%id);
	for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
	{
		%clpos = GameBase::getPosition(%cl);
		%dist1 = Vector::getDistance(%clpos,%pos);
		if(%dist1 <= $AreaTextDist)
			if (!IsDead(%cl))
				Client::sendMessage(%cl,2,%oname @ "'s " @ %name @ " says, \"" @ %message @ "\"");
	}
}

function CruAiSetMode(%id,%mode)
{
	%list = $CruAI[%id,$AiPetList];
	if (getWord(%list,0) == -1) {
		Client::SendMessage(%id,0,"You have no minions.");
		return;
	}
	for (%i = 0; (%aiId = getWord(%list,%i)) != -1; %i++) {
		%msg = "";
		$CruAI[%aiId,$AiPrev] = $CruAI[%aiId,$AiMode];
		if (%mode == "follow") {
			Player::Trigger(%aiId,0,0);
			%msg = "Your minions will now follow you.";
			$CruAI[%aiId,$AiMode] = $AiFollow;
			AiAreaTalk(%aiId,"follow");
		}
		if (%mode == "attack") {
			CruAiSetPetTarget(%id,%aiId);
		}
		if (%mode == "wait") {
			Player::Trigger(%aiId,0,0);
			%msg = "Your minions will wait here.";
			$CruAI[%aiId,$AiMode] = $AiWait;
			AiAreaTalk(%aiId,"wait");
		}
		if (%mode == "hunt") {
			$CruAI[%aiId,$AiTargetGet] = "";
			%msg = "Your minions will now Hunt.";
			$CruAI[%aiId,$AiMode] = $AiHunt;
		}
	}
	if (%msg != "") Client::SendMessage(%id,0,%msg);
}

function CruAiTerminatePet(%id,%manual,%clean)
{
	echo("-------------------> CRUAITERMINATEPET " @ %id @ " " @ %manual @ " " @ %clean);
	%aiId = %manual;
	CruAiRemoveFromPetList(%id,%aiId);
	%name = Client::GetName(%aiId);
	Client::SendMessage(%id,2,%name @ " has died.");
	if ((%take = GetBonus(%id,$BPMINIONDEATH)) > 0) {
		%maxhp = fetchData(%id,"MaxHP");
		%tval = round((%maxhp * (%take / 100)) + 1);
		client::SendMessage(%id,1,"Your minion has died and you take " @ %tval @ " damage!");
		DamageTarget(%id,%tval,%id);
	}
	//if (%clean != True)
	//	ActionKilled(%id,%aiId);
	$AiNameOn--;
	$CruAI[%aiId,$AiOwner] = "";
	$CruAI[%aiId,$AiMode] = "";
	$CruAI[%aiId,$GoPos] = "";
	$CruAI[%aiId,$AiTargetGet] = "";
	$CruAI[%aiId,$AiPrev] = "";
}


echo("__BACKPACK MINION LOADED");