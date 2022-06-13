// ACTIONS
//

$CAName 	= 1;
$CAMode 	= 2;
$CAHostile 	= 3;
$CAReqs 	= 4;
$CAHostileRun 	= 5;
$CAUseTime 	= 6;
$CALockTime 	= 7;
$CABonus 	= 8;
$CAOffense 	= 9;
$CADefense 	= 10;
$CARunTime 	= 11;
$CAInfo 	= 12;
$CARange 	= 13;
$CABreakOnDmg	= 14;
$CABreakOnDo	= 15;
$CALockFail	= 16;
$CARecovery 	= 17;
$CAChargeSound 	= 18;
$CAFinishSound	= 19;

$CADamage 	= 1;
$CABuff 	= 2;
$CALOS 		= 3;
$CAArea 	= 4;
$CASelf 	= 5;
$CATeam 	= 6;
$CAGeneral	= 7;

//========================================================================================================================================================

$CruAction[WarHammer,$CAName] 		= "War Hammer";
$CruAction[WarHammer,$CAMode] 		= $CALOS;
$CruAction[WarHammer,$CAHostile] 	= 1;
$CruAction[WarHammer,$CAReqs] 		= "LVLG 0";
$CruAction[WarHammer,$CATargetRun] 	= "LVLG 0";
$CruAction[WarHammer,$CAUseTime] 	= 1;
$CruAction[WarHammer,$CALockTime]	= 60;
$CruAction[WarHammer,$CALockFail]	= 40;
$CruAction[WarHammer,$CARunTime] 	= 30;
$CruAction[WarHammer,$CARange] 		= 10;
$CruAction[WarHammer,$CAOffense] 	= $SkillSlashing @ " 100";
$CruAction[WarHammer,$CADefense] 	= $SkillEvadeMelee @ " 110";
$CruAction[WarHammer,$CABonus] 		= "FireAC -70 DAMAGE Fire..25-50 EvadeMelee -50";
$CruAction[WarHammer,$CAInfo] 		= "This is a direct fire damage and evade de-buff action";

$CruAction[SpinningSlash,$CAName] 	= "Spinning Slash";
$CruAction[SpinningSlash,$CAMode] 	= $CAArea;
$CruAction[SpinningSlash,$CAHostile] 	= 1;
$CruAction[SpinningSlash,$CAReqs] 	= "SLASHINGWEAPON 1";
$CruAction[SpinningSlash,$CATargetRun] 	= "LVLG 0";
$CruAction[SpinningSlash,$CAUseTime] 	= 1;
$CruAction[SpinningSlash,$CALockTime]	= 10;
$CruAction[SpinningSlash,$CALockFail]	= 10;
$CruAction[SpinningSlash,$CARunTime] 	= 0;
$CruAction[SpinningSlash,$CARange] 	= 10;
$CruAction[SpinningSlash,$CAOffense] 	= $SkillSlashing @ " 100";
$CruAction[SpinningSlash,$CADefense] 	= $SkillEvadeMelee @ " 50";
$CruAction[SpinningSlash,$CABonus] 	= "DAMAGEWEAPON 150";
$CruAction[SpinningSlash,$CAInfo] 	= "Swing your weapon in a massive circle around you, hitting all enemies for 150% weapon damage.";

$CruAction[TownPortal,$CAName] 		= "Create Town Portal";
$CruAction[TownPortal,$CAMode] 		= $CAGeneral;
$CruAction[TownPortal,$CAHostile] 	= 0;
$CruAction[TownPortal,$CATargetRun] 	= "";
$CruAction[TownPortal,$CAReqs] 		= "";
$CruAction[TownPortal,$CAUseTime] 	= 5;
$CruAction[TownPortal,$CALockTime]	= 20;
$CruAction[TownPortal,$CALockFail]	= 0;
$CruAction[TownPortal,$CARunTime] 	= 0;
$CruAction[TownPortal,$CARange] 	= 0;
$CruAction[TownPortal,$CABonus] 	= "TOWNPORTAL 0";
$CruAction[TownPortal,$CAInfo] 		= "Create A Town Portal";
$CruAction[TownPortal,$CAChargeSound] 	= "RespawnB";
$CruAction[TownPortal,$CAFinishSound] 	= "ActivateCH";

//========================================================================================================================================================

function WhatIsCruAction(%id,%action,%r)
{
	%msg = "";
	%msg = %msg @ " <f1>" @ $CruAction[%action,$CAName] @ "\n\n";
	%msg = %msg @ " <f1>Requirements:\n <f0>" @ BPFormat($CruAction[%action,$CAReqs]) @ "\n\n";
	%msg = %msg @ " <f1>Target Requirements:\n <f0>" @ BPFormat($CruAction[%action,$CATargetRun]) @ "\n\n";
	%msg = %msg @ " <f1>Mode: <f0>" @ $CruAction[%action,$CAMode] @ "\n";
	%msg = %msg @ " <f1>Attack Time: <f0>" @ $CruAction[%action,$CAUseTime] @ "\n";
	%msg = %msg @ " <f1>Duration: <f0>" @ $CruAction[%action,$CARunTime] @ "\n";
	%msg = %msg @ " <f1>Lock: <f0>" @ $CruAction[%action,$CALockTime] @ "\n";
	%msg = %msg @ " <f1>Range: <f0>" @ $CruAction[%action,$CARange] @ "\n";
	%msg = %msg @ " <f1>Offense: <f0>" @ BPFormat($CruAction[%action,$CAOffense]) @ "%\n";
	%msg = %msg @ " <f1>Defense: <f0>" @ BPFormat($CruAction[%action,$CADefense]) @ "%\n\n";
	%msg = %msg @ " <f1>Bonus: <f0>\n " @ BPFormat($CruAction[%action,$CABonus]) @ "\n\n";
	%msg = %msg @ " <f1>" @ $CruAction[%action,$CAInfo];
	if (!%r)
		SendBufferBP(%id,%msg,20);
	else
		return %msg;
}

function ActionUnlocked(%id,%action)
{
	echo(" ACTION UNLOCKED " @ %id @ " " @ %action);
	%locked = $LockedActions[%id];
	for (%i = 0; (%a = getWord(%locked,%i)) != -1; %i++) {
		if (%a == %action)
			return False;
	}
	return True;
}

function PlayerActionId(%id)
{
	return $PlayerActionId[%id];
}

function SetupRunningAction(%id,%action)
{
	%run = $CruAction[%action,$CARunTime];
	if (%run == "")
		%run = 0.00;
	AddRunningAction(%id,%action,%run);
}

function AddRunningAction(%id,%action,%dur)
{
	echo("ADDRUNNINGACTION " @ %id @ " " @ %action @ " " @ %dur);
	%connectId = GetConnectionId(%id);
	$RunningActions[%id] = $RunningActions[%id] @ %action;
	//----------------------------------------------------------
	%id.SpellTimer[%action,START] = GetSimTime();
	%id.SpellTimer[%action,DUR] = %dur;
	//----------------------------------------------------------
	schedule("AutoDelRunningAction(" @ %id @ "," @ %connectId @ ",\"" @ %action @ "\");",%dur);
}

function AutoDelRunningAction(%id,%connectId,%action)
{
	echo("AUTODELRUNNINGACTION " @ %id @ " " @ %connectId @ " " @ %action);
	if (GetConnectionId(%id) == %connectId) {
		ActionBonus(%id,%action,0);
		%found = 0;
		%running = $RunningActions[%id];
		%new = "";
		for (%i = 0; (%a = getWord(%running,%i)) != -1; %i++) {
			if (%a == %action) {
				if (%found)
					%new = %new @ %a @ " ";
			}
			else if (%a != %action) {
				%new = %new @ %a @ " ";
			}
		}
		$RunningActions[%id] = %new;
		if ($CruAction[%action,$CARunTime] > 0)
			Client::SendMessage(%id,2,$CruAction[%action,$CAName] @ " dissipates..");
	}
}

function LockAction(%id,%action)
{
	echo(" LOCK ACTION " @ %id @ " " @ %action);
	%connectId = GetConnectionId(%id);
	%dur = $CruAction[%action,$CALockTime];
	$LockedActions[%id] = $LockedActions[%id] @ %action @ " ";
	schedule("AutoUnlockAction(" @ %id @ "," @ %connectId @ ",\"" @ %action @ "\");",%dur);
}

function AutoUnlockAction(%id,%connectId,%action)
{
	if (%connectId == GetConnectionId(%id)) {
		%locked = $LockedActions[%id];
		%new = "";
		for (%i = 0; (%a = getWord(%locked,%i)) != -1; %i++) {
			if (%a != %action)
				%new = %new @ " ";
		}
		$LockedActions[%id] = %new;
		rpg::SendMessage(%id,$MsgPink,"Your " @ $CruAction[%action,$CAName] @ " action is available.");
	}
}

function JoinCheckLockedActions(%id)
{
	%locked = $LockedActions[%id];
	%connectId = GetConnectionId(%id);
	if (getWord(%locked,0) == -1)
		return;
	for (%i = 0; (%a = getWord(%locked,%i)) != -1; %i++) {
		if (%a != -1) {
			%dur = $CruAction[%a,$CALockTime];
			schedule("AutoUnlockAction(" @ %id @ "," @ %connectId @ ",\"" @ %action @ "\");",%dur);
		}
	}	
}

function CurrentlyInitAction(%id,%action)
{
	%init = $InitAction[%id];
	for (%i = 0; (%a = getWord(%init,%i)) != -1; %i++) {
		if (%a == %action)
			return True;
	}
	return False;
}

function DelInitAction(%id,%action)
{
	%new = "";
	%init = $InitAction[%id];
	for (%i = 0; (%a = getWord(%init,%i)) != -1; %i++) {
		if (%a != %action)
			%new = %new @ %action @ " ";
	}
	$InitAction[%id] = %new;
}

function InitActionTime(%id,%action)
{
	$InitAction[%id] = $InitAction[%id] @ %action @ " ";
}

function InitUseAction(%id,%action)
{
	//echo(" INIT USE ACTION " @ %id @ " " @ %action);
	if (CurrentlyInitAction(%id,%action) == True) {
		Client::SendMessage(%id,2,"You are already running this action.");
		return;
	}
	if (PlayerCanAction(%id,%action) == True && ActionUnlocked(%id,%action) == True) {
		Client::SendMessage(%id,2,"Using action " @ $CruAction[%action,$CAName] @ "...");
		%usetime = $CruAction[%action,$CAUseTime];
		InitActionTime(%id,%action);
		CruActionGui(%id,%action,%usetime);
		%sound = $CruAction[%action,$CAChargeSound];
		if (%sound != "")
			PlaySound(%sound, GameBase::getPosition(%id));
		schedule("UseAction(" @ %id @ ",\"" @ %action @ "\");",%usetime);
	}
	else
		Client::SendMessage(%id,2,$CruAction[%action,$CAName] @ " is unavailable.");
}

function CruActionGui(%id,%action,%time)
{
	%action = $CruAction[%action,$CAName];
	remoteeval(%id,"RPGGui::ActionRefresh",%time,1,%action);
	// schedule("CruSpellGuiCooldown(" @ %id @ "," @ %recovery @ ");",%time);
}

function UseAction(%id,%action)
{
		DelInitAction(%id,%action);
		%lockaction = 0;
		%mode = $CruAction[%action,$CAMode];
		%target = -1;
		%hostile = $CruAction[%action,$CAHostile];
		if (%mode == $CAGeneral) {
			%target = %id;
			if (PlayerCanAction(%target,%action,True)) {
				Client::SendMessage(%id,2,"You perform " @ $CruAction[%action,$CAName]);
				ActionBonus(%target,%action,1);
				SetupRunningAction(%target,%action,true);
				%lockaction = 1;
			}
			else
				Client::SendMessage(%id,0,"You do not meet the requirements to use " @ $CruAction[%action,$CAName]);
		}
		if (%mode == $CASelf) {
			%target = %id;
			if (PlayerCanAction(%target,%action,True)) {
				Client::SendMessage(%id,2,"You perform " @ $CruAction[%action,$CAName] @ " on yourself!");
				ActionBonus(%target,%action,1);
				SetupRunningAction(%target,%action);
				%lockaction = 1;
			}
			else
				Client::SendMessage(%id,0,"You do not meet the requirements to use " @ $CruAction[%action,$CAName] @ " on yourself.");
		}
		if (%mode == $CALOS) {
			if (%hostile)
				%target = GetActionLosTarget(%id,"","",%action);
			else
				%target = GetActionLosTarget(%id,True,"",%action);
			if (%target != -1) {
				%lockaction = 1;
				if (%hostile) {
					if (SuccessHitAction(%id,%target,%action) == True) {
						Client::SendMessage(%id,2,"You successfully perform " @ $CruAction[%action,$CAName] @ " on " @ Client::GetName(%target) @ "!");
						ActionBonus(%target,%action,1,%id);
						SetupRunningAction(%target,%action);
					}
					else
						Client::SendMessage(%id,2,Client::GetName(%target) @ " evaded your " @ $CruAction[%action,$CAName] @ ".");
				}
				else {
					Client::SendMessage(%id,2,"You successfully perform " @ $CruAction[%action,$CAName] @ " on " @ Client::GetName(%target) @ "!");
					ActionBonus(%target,%action,1);
					SetupRunningAction(%target,%action);
				}
			}
		}
		if (%mode == $CATeam) {
			if ((%team = PlayerIsInTeam(%id)) != -1) {
				%teamlist = $TeamList[%team];
				for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
					%member = GetWord(%teamlist,%i);
					%target = GetActionLosTarget(%id,True,%member,%action);
					if (%target != -1) {
						Client::SendMessage(%id,2,"You successfully perform " @ $CruAction[%action,$CAName] @ " on " @ Client::GetName(%target) @ "!");
						%lockaction = 1;
						ActionBonus(%target,%action,1);
						SetupRunningAction(%target,%action);
					}
				}
			}
		}
		if (%mode == $CAArea) {
			%spotdist = $CruAction[%action,$CARange];
			if (%spotdist == "") %spotdist = 10;
			%pos = Gamebase::GetPosition(%id);
			%set = newObject("set", SimSet);
			%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
			Group::iterateRecursive(%set,ActionAOE,%id,%action,%hostile);
			deleteObject(%set);
			%lockaction = 1;
		}
		if (%lockaction) {
			LockAction(%id,%action);
		}
}

function ActionAOE(%object,%id,%action,%hostile)
{
	%target = player::GetClient(%object);
	if (%hostile == 1) {
		if (%target == %id) return;
		if (Action::PlayersAreHostile(%id,%target) == False) return;
	}
	if (Targeting::LosCheck(%id,%target) == False || %target == %id) {
		if (%hostile == 1) {
			if (SuccessHitAction(%id,%target,%action) == True) {
				Client::SendMessage(%id,2,"You successfully perform " @ $CruAction[%action,$CAName] @ " on " @ Client::GetName(%target) @ "!");
				ActionBonus(%target,%action,1,%id);
				SetupRunningAction(%target,%action);
			}
			else
				Client::SendMessage(%id,2,Client::GetName(%target) @ " evaded your " @ $CruAction[%action,$CAName] @ ".");
		}
		else {
			Client::SendMessage(%id,2,"You successfully perform " @ $CruAction[%action,$CAName] @ " on " @ Client::GetName(%target) @ "!");
			ActionBonus(%target,%action,1,%id);
			SetupRunningAction(%target,%action);
		}
	}
}

function SuccessHitAction(%id,%target,%action,%spell)
{
	if (%spell == "") {
		%atk = $CruAction[%action,$CAOffense];
		%def = $CruAction[%action,$CADefense];
	}
	else {
		%atk = $CruSpell[%spell,$CSOffense];
		%def = $CruSpell[%spell,$CSDefense];
	}
	%totalatk = 0;
	%totaldef = 0;
	for (%i = 0; (%t = getWord(%atk,%i)) != -1; %i += 2) {
		%v = getWord(%atk,%i + 1);
		if (%t == "ATK")
			%totalatk += (fetchData(%id,"ATK") * (%v / 100));
		else
			%totalatk += (GetPlayerSkill(%id,%t) * (%v / 100));
	}
	for (%i = 0; (%t = getWord(%def,%i)) != -1; %i += 2) {
		%v = getWord(%def,%i + 1);
		if (%t == "DEF")
			%totaldef += (fetchData(%target,"DEF") * (%v / 100));
		else if (%t == "MDEF")
			%totaldef += (fetchData(%target,"MDEF") * (%v / 100));
		else
			%totaldef += (GetPlayerSkill(%target,%t) * (%v / 100));
	}
	%rand[1] = getRandom() * %totalatk;
	%rand[2] = getRandom() * %totaldef;
	echo(%rand[1]);
	echo(%rand[2]);
	if (%rand[1] > %rand[2])
		return True;
	else
		return False;
}

function Action::PlayersAreHostile(%id,%target)
{
	if (Client::getTeam(%id) == Client::getTeam(%target)) return False;
	return True;
}

function GetActionLosTarget(%id,%noHostile,%manual,%action)
{
	echo("GETACTIONLOSTARGET " @ %id @ " " @ %noHostile @ " " @ %manual @ " " @ %range);
	%range = $CruAction[%action,$CARange];
	%target = -1;
	if (%manual == "") {
		if (GameBase::getLOSinfo(Client::getOwnedObject(%id),%range)) {
			%obj = getObjectType($los::object);
			if (%obj == "Player") {
				%target = $los::object;
				%target = Player::GetClient(%target);
			}
		}
	}
	else {
		%pos = GameBase::GetPosition(%id);
		%targpos = GameBase::GetPosition(%manual);
		%dist = Vector::GetDistance(%pos,%targpos);
		if (%dist <= %range) {
			%target = %manual;
		}
	}
	if (%target == -1) {
		if (%manual == "") {
			if (%noHostile == True)
				Client::SendMessage(%id,2,"This action requires a target.");
			else
				Client::SendMessage(%id,2,"This action requires a fighting target to be applied on.");
		}
		return -1;
	}
	if (PlayerCanAction(%target,%action,True,%id) == True) {
		if (%noHostile == True)
			return %target;
		if (action::PlayersAreHostile(%id,%target)) {
			return %target;
		}
		else {
			Client::SendMessage(%id,2,"This action requires a fighting target to be applied on.");
			return -1;
		}
	}
	else {
		Client::SendMessage(%id,2,"The target did not meet requirements to run this action.");
		return -1;
	}
}

function PlayerCanAction(%id,%action,%targetrun,%id)
{
	echo(" PLAYER CAN ACTION " @ %id @ " " @ %action @ " " @ %targetrun @ " " @ %id);
	%req = $CruAction[%action,$CAReqs];
	if (%targetrun == True)
		%req = $CruAction[%action,$CATargetRun];
	if (%req == "") {
		echo(" REQ IS NOTHING ");
		return True;
		if (%targetrun == True)
			return True;
		else 
			return False;
	}
	for (%i = 0; (%r = getWord(%req,%i)) != -1; %i += 2) {
		%a = getWord(%req,%i + 1);
		if (%r == "HASPERK") {
			if (PlayerHasPerk(%id,%a) != True) {
				Client::SendMessage(%id,0,"Target must have perk: " @ %a);
				return False;
			}
		}
		if (%r == "RLG") {
			if (fetchData(%id,"RemortStep") < %a)
				return False;
		}
		if (%r == "GROUP") {
			if (fetchData(%id,"Group") != %a) {
				Client::SendMessage(%id,0,"Target Group must be: " @ %a);
				return False;
			}
		}
		if (%r == "CLASS") {
			if (fetchData(%id,"Class") != %a) {
				Client::SendMessage(%id,0,"Target Class must be: " @ %a);
				return False;
			}
		}
		if (%r == "RUNNINGACTION") {
			if (PlayerRunningAction(%id,%a) != True) {
				Client::SendMessage(%id,0,"Target must be running action: " @ %a);
				return False;
			}
		}
		if (%r == "LVLG") {
			if (fetchData(%id,"LVL") < %a) {
				Client::SendMessage(%id,0,"Target Level must be less than " @ %a);
				return False;
			}
		}
		if (%r == "RLG") {
			if (fetchData(%id,"RemortStep") < %a)
				return False;
		}
		if (%r == "SLASHINGWEAPON") {
			return True;
		}			

	}
	return True;
}

function ActionBonus(%id,%action,%v,%init)
{
	%bonus = $CruAction[%action,$CABonus];
	%text = $AreaText[%action];
	if (%text != "" && %v == 1)
		FloatText(%id,%text);
	if (%bonus == "")
		return;
	for (%i = 0; (%b = getWord(%bonus,%i)) != -1; %i += 2) {
		%a = getWord(%bonus,%i + 1);
		if ((%num = $BPSkillToNumeric[%b]) == "") {
			if (%b == "HEAL") {
				if (%v) {
					%hp = fetchData(%id, "HP");
					refreshHP(%id, ((%a / 100) * -1));
					refreshAll(%id);
					if(fetchData(%id, "HP") != %hp)
						UseSkill(%id, $SkillHealing, True, True);
				}
			}
			else if (%b == "HEALMP") {
				if (%v) {
					%mana = fetchData(%id, "MANA");
					refreshMANA(%id, (%a * -1));
					refreshAll(%id);
					if(fetchData(%id, "MANA") != %mana)
						UseSkill(%id, $SkillEnergy, True, True);
				}
			}
			if (%b == "DAMAGE") {
				if (%v) {
					if (%init != "") {
						Client::SendMessage(%id,1,Client::GetName(%init) @ " hit you for " @ %a @ " points of damage!");
						Client::SendMessage(%init,1,"You hit " @ Client::GetName(%id) @ " for " @ %a @ " points of damage!");
						ManualAddDamagedList(%init,%id,(%a / 100));
					}
					if ((fetchData(%id,"HP") - %a) <= 0)
						ActionKilled(%init,%id,99);
					refreshHP(%id,((%a / 100) * 1));
					refreshAll(%id);
				}
			}
			if (%b == "DAMAGEWEAPON") {
				if (%v) {
					%weapon = getCurrentWearFull(%init,13);
					%damageType = newGetWeaponDamageType(%weapon);
					%value = GetNewDamageRoll(%init,%weapon);
					%value = getWord(%value,0);
					%value *= (%a / 100);
					%value = round(%value);
					Player::ManualDamage(%init,%id,%value);
				}
			}
			if (%b == "TOWNPORTAL") {
				if (%v)
					BackpackTownPortal::Create(%id);
			}
			else {
				%num = $BPBonusToNumeric[%b];
				if (%num != "") {
					if (%v != 0)
						$PlayerBonus[%id,%num] += %a;
					else
						$PlayerBonus[%id,%num] -= %a;
				}
			}
		}
		else {
			if (%v != 0)
				$SkillBonus[%id,%num] += %a;
			else
				$SkillBonus[%id,%num] -= %a;
		}
	}
	%sound = $CruAction[%action,$CAFinishSound];
	if (%sound != "")
		schedule("PlaySound("@%sound@",\""@GameBase::getPosition(%id)@"\");",0.2);
}

echo("__ACTIONS LOADED");