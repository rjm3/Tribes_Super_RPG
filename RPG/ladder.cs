// LADDER AND FACTION
//$Adminpassword[5]="test";

function IsLadderChar(%id)
{
	if ($LadderPlayer[%id]) 
		return 1;
	else
		return 0;
}
function IsLadderPlayer(%id)
{
	if ($LadderPlayer[%id]) 
		return 1;
	else
		return 0;
}

function InitLadderPlayer(%id)
{
	//echo("INIT LADDER PLAYER " @ %id);
	$LadderPlayer[%id] = 1;
	if ((%faction = GetPlayerFaction(%id)) != 0) {
		$PlayerBonus[%id,$ExpBonus] += $FactionBonus[%faction,1];
		$PlayerBonus[%id,$GoldBonus] += $FactionBonus[%faction,2];
	}
}

function LoadLadderPlayers()
{
	exec(LADDERPLAYERS);
}

LoadLadderPlayers();

function GetPlayerFaction(%id)
{
	if (!IsLadderPlayer(%id))
		return 0;
	%house = fetchData(%id,"MyHouse");
	if (%house == "House Antiva" || %house == "House Fenyar")
		return 1;
	else if (%house == "House Temmin" || %house == "House Venk")
		return 2;
	else
		return 0;
}

exec(FACTIONSAVE);

function SaveFaction()
{
	File::delete("config\\FACTIONSAVE.cs");
	export("$FactionBonus*", "config\\FACTIONSAVE.cs", false);
}

function GetFactionBonus(%id,%type)
{
	// EXP 1 GOLD 2
	%faction = GetPlayerFaction(%id);
	if (%faction != 0)
		return $FactionBonus[%faction,%type];
	else
		return 0;
}

function FactionMessage(%faction,%msg,%id) {
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
		if ((%gfaction = GetPlayerFaction(%cl)) != 0) {
			if (%gfaction == %faction || %faction == 3) {
				if (%id != "") {
					if (%cl != %id)
						Client::SendMessage(%cl,3,"[FCTN] " @ Client::GetName(%id) @ " " @ %msg);
					else
						Client::SendMessage(%cl,3,"[FCTN] " @ %msg);
				}
				else
					Client::SendMessage(%cl,3,"[FCTN] " @ %msg);
			}
		}
	}
}

function FactionDefaults()
{
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
		$PlayerJoinBattle[%cl] = 0;
	}
	$AwaitBattle = 0;
	$FactionBattle = 0;
	$AwaitNextBattle = 0;
}

FactionDefaults();

$BattleIntermission = 60;
function SetWaitNextBattle()
{
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
		$PlayerJoinBattle[%cl] = 0;
	}
	$AwaitBattle = 0;
	$FactionBattle = 0;
	$AwaitNextBattle = 1;
	schedule("FactionDefaults();",$BattleIntermission);
}

$MinBattlePlayers = 1;
$MinBattleLevel = 1;

function FactionChallenge(%id)
{
	if ($AwaitBattle == 1 || $FactionBattle == 1) {
		Client::SendMessage(%id,1,"A battle has already been called..");
		return;
	}
	if ($AwaitNextBattle) {
		Client::SendMessage(%id,1,"You must wait some time before battling again.");
		return;
	}
	%cfaction = GetPlayerFaction(%id);
	if (%cfaction != 0) {
		%faction[%cfaction] = 1;
		for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
			if ((%gfaction = GetPlayerFaction(%cl)) != 0 && %cl != %id) {
				if (fetchData(%cl,"LVL") >= $MinBattleLevel) {
					%faction[%gfaction] += 1;
				}
			}
		}
	}
	if (%faction[1] >= $MinBattlePlayers && %faction[2] >= $MinBattlePlayers) {
		FactionMessage(3,"Your faction has been called to battle! (#joinbattle)");
		AwaitFactionBattle();
	}
	else {
		Client::SendMessage(%id,1,"Not enough players to battle.");
	}
}

function AwaitFactionBattle()
{
	$AwaitBattle = 1;
	$FactionJoin[1] = 0;
	$FactionJoin[2] = 0;
	schedule("BattleStartCheck();",20);
}

function EndAwaitBattle()
{
	$AwaitBattle = 0;
}

function JoinFactionBattle(%id) {
	if ($AwaitBattle) {
		if ((%gfaction = GetPlayerFaction(%id)) != 0) {
			if ($PlayerJoinBattle[%id] != 1 && IsLadderPlayer(%id)) {
				if (fetchData(%id,"LVL") < $MinBattleLevel) {
					Client::SendMessage(%id,1,"You need to be level " @ $MinBattleLevel @ "+ to join the battle!");
					return;
				}
				$FactionJoin[%gfaction] += 1;
				FactionMessage(%gfaction,Client::GetName(%id) @ " is ready to battle!");
				$PlayerJoinBattle[%id] = 1;
			}
		}
	}
	else if ($FactionBattle) {
		if ((%gfaction = GetPlayerFaction(%id)) != 0) {
			if ($PlayerJoinBattle[%id] != 1 && IsLadderPlayer(%id)) {
				FactionMessage(%gfaction,Client::GetName(%id) @ " joined the battle!");
				$BattleRespawn[%id] = 15;
				BattleReadyRoom(%id,%faction);
			}
		}
	}
	else {
		Client::SendMessage(%id,1,"There is no active faction battle currently.");
	}
}

function BattleStartCheck() 
{
	if ($FactionJoin[1] >= $MinBattlePlayers && $FactionJoin[2] >= $MinBattlePlayers) {
		for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
			if ($PlayerJoinBattle[%cl] == 1) {
				%faction = GetPlayerFaction(%cl);
				$Battling[%cl] = 1;
				BattleReadyRoom(%cl,%faction);
				$BattleRespawn[%cl] = -1;
			}
		}
		InitFactionBattle();
	}
	else {
		if ($FactionJoin[1] < $MinBattlePlayers && $FactionJoin[2] < $MinBattlePlayers) {
			FactionMessage(3,"Not enough players, the battle will not start.");
			FactionDefaults();
		}
		if ($FactionJoin[1] >= $MinBattlePlayers) {
			if ($FactionJoin[2] < $MinBattlePlayers) {
				FactionMessage(1,"Their team as forfeited the battle!");
				FactionMessage(2,"Your team forfeited the battle and lost bonuses!");
				BattleForfeit(2);
				SetWaitNextBattle();
				return;
			}
		}
		if ($FactionJoin[2] >= $MinBattlePlayers) {
			if ($FactionJoin[1] < $MinBattlePlayers) {
				FactionMessage(2,"Their team as forfeited the battle!");
				FactionMessage(1,"Your team forfeited the battle and lost bonuses!");
				BattleForfeit(1);
				SetWaitNextBattle();
				return;
			}
		}
	}
}

function InitFactionBattle()
{
	$BattleTickets[1] = 0;
	$BattleTickets[2] = 0;
	$BattleTimeFormat = "5:00";
	FactionMessage(3,"The battle will began in 30 seconds...");
	schedule("StartFactionBattle();",30);
}

$ReadyRoom[1] = "-4551.1 1564.7 -153.1";
$ReadyRoom[2] = "-4316.1 2036.5 -119.9";

function BattleReadyRoom(%id,%faction)
{
	StoreData(%id,"NoDropLootbagFlag",1);
	%pos = $ReadyRoom[%faction];
	Item::SetVelocity(Client::GetOwnedObject(%id),"0 0 0");
	GameBase::SetPosition(%id,%pos);
}

$FactionSpawn[1] = "-4391 1773 65.1";
$FactionSpawn[2] = "-4391 1776 65.1";
$FactionSpawn[3] = "-4391 1779 65.1";
$FactionSpawn[4] = "-4391 1781 65.1";
$FactionSpawn[5] = "-4391 1783 65.1";
$FactionSpawn[6] = "-4513 1803 65.1";
$FactionSpawn[7] = "-4513 1800 65.1";
$FactionSpawn[8] = "-4513 1797 65.1";
$FactionSpawn[9] = "-4513 1794 65.1";
$FactionSpawn[10] = "-4513 1791 65.1";

function RandomBattleSpawn(%id)
{
	%rand = floor(getRandom() * 10 + 1);
	Item::SetVelocity(Client::GetOwnedObject(%id),"0 0 0");
	GameBase::SetPosition(%id,$FactionSpawn[%rand]);
	Client::SendMessage(%id,0,"You were placed into the battle!");
}

$BattleLength = 300;

function StartFactionBattle()
{
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
		if ($Battling[%cl] == 1) {
			RandomBattleSpawn(%cl);
		}
	}
	$FactionBattle = 1;
	$BattleTimer = $BattleLength;
	FactionMessage(3,"Move to the capture area, capping will start in 15 seconds!");
	schedule("FactionBattleLoop();",15);
}

$GraceDistBattle = 300;
$GraceDistCap = 39;
$FactionBattleCenter = "-4448.7 1795.6 67.6";
$BattleTicketWin = 250;

function FactionBattleLoop()
{
	%factioninzone[1] = 0;
	%factioninzone[2] = 0;
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
		%faction = GetPlayerFaction(%cl);
		%dist = Vector::getDistance(GameBase::GetPosition(%cl),$FactionBattleCenter);
		if ($Battling[%cl] == 0 && %dist <= $GraceDistBattle) {
			FellOffMap(%cl);
			Client::SendMessage(%cl,1,"You are not battling. You must stay out of the faction battle zone.");
		}
		if (%faction == 1 || %faction == 2) {
			if (%dist > $GraceDistBattle) {
				if ($Battling[%cl] == 1 && $BattleRespawn[%cl] == -1 && IsDead(%cl) == false) {
					BattleOutOfBounds(%cl,%faction);
				}
			}
			if (%dist <= $GraceDistCap) {
				if ($Battling[%cl] == 1) {
					%capping[%cl] = 1;
					%factioninzone[%faction] = 1;
				}
			}
		}
	}
	//--------------------------------------
	if (%factioninzone[1] == 1)
		$BattleTickets[1] += 1;
	if (%factioninzone[2] == 1)
		$BattleTickets[2] += 1;
	//--------------------------------------
	if ($BattleTickets[1] >= $BattleTicketWin && $BattleTickets[2] >= $BattleTicketWin)
		FactionBattleWinner(3);
	else if ($BattleTickets[1] >= $BattleTicketWin && $BattleTickets[2] < $BattleTicketWin)
		FactionBattleWinner(1);
	else if ($BattleTickets[1] < $BattleTicketWin && $BattleTickets[2] >= $BattleTicketWin)
		FactionBattleWinner(2);
	else {
		for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
			if ($BattleRespawn[%cl] > 0) {
				$BattleRespawn[%cl] -= 1;
			}
			if ($BattleRespawn[%cl] == 0) {
				$BattleRespawn[%cl] = -1;
				RandomBattleSpawn(%cl);
			}
			if ($Battling[%cl] == 1) {
				if (%capping[%cl] == 1)
					BottomPrint(%cl,"<f0><jc>You are in the capture area.<f1><n><jl> Antiva-Fenyar: " @ $BattleTickets[1] @ "<n> Temmin-Venk: " @ $BattleTickets[2] @ "<n><jc><f0>" @ $BattleTimeFormat,2);
				else {
					if ($BattleRespawn[%cl] == -1)
						BottomPrint(%cl," <f1>Antiva-Fenyar: " @ $BattleTickets[1] @ "<n> Temmin-Venk: " @ $BattleTickets[2] @ "<n><jc><f0>" @ $BattleTimeFormat,2);
					else
						BottomPrint(%cl," <f1>Antiva-Fenyar: " @ $BattleTickets[1] @ "<n> Temmin-Venk: " @ $BattleTickets[2] @ "<n><jc><f0>" @ $BattleTimeFormat @ "<n><f0>Respawning in " @ $BattleRespawn[%cl] @ " seconds.",2);
				}
			}
		}
		$BattleTimer -= 1;
		if ($BattleTimer <= 0) {
			FactionMessage(3,"Battle time is up.");
			if ($BattleTickets[1] == $BattleTickets[2])
				FactionBattleWinner(3);
			else if ($BattleTickets[1] > $BattleTickets[2])
				FactionBattleWinner(1);
			else if ($BattleTickets[2] > $BattleTickets[1])
				FactionBattleWinner(2);
		}
		else {
			$BattleTimeFormat = BattleTimerFormat($BattleTimer);
			schedule("FactionBattleLoop();",1);
		}
	}
}

function BattleTimerFormat(%time)
{
	%min = 0;
	while (%time >= 60) {
		%min += 1;
		%time -= 60;
	}
	if (%time < 10)
		%time = "0" @ %time;
	return "0" @ %min @ ":" @ %time;
}

function BattleOutOfBounds(%id,%faction) 
{
	//echo("BATTLE OUT OF BOUNDS " @ %id);
	$BattleRespawn[%id] = 15;
	BattleReadyRoom(%id,%faction);
}

function BattleDied(%id)
{
	//echo(" BATTLE DIED " @ %id);
	%faction = GetPlayerFaction(%id);
	$BattleRespawn[%id] = 20;
	storeData(%id,"NoDropLootbagFlag",1);
	//BattleReadyRoom(%id,%faction);
}

function GetFactionName(%faction)
{
	if (%faction == 1)
		return "Antiva-Fenyar";
	else
		return "Temmin-Venk";
}

function FactionBattleWinner(%faction)
{
	if (%faction == 3)
		MessageAll(3,"[FACTION BATTLE] The battle between " @ GetFactionName(1) @ " and " @ GetFactionName(2) @ " ended in a draw!");
	else {
		MessageAll(3,"[FACTION BATTLE] The " @ GetFactionName(%faction) @ " faction is victorious!");
		$FactionBonus[%faction,1] += 2;
		$FactionBonus[%faction,2] += 4;
		
		for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
			if (GetPlayerFaction(%cl) == %faction) {
				$PlayerBonus[%cl,$ExpBonus] += 2;
				$PlayerBonus[%cl,$GoldBonus] += 4;
			}
			if ($Battling[%cl] == 1) {
				$Battling[%cl] = 0;
				FellOffMap(%cl);
			}
			$BattleRespawn[%cl] = -1;
		}

		if (%faction == 1)
			%faction = 2;
		else
			%faction = 1;

		%exp = $FactionBonus[%faction,1];
		if ((%exp - 2) <= 14)
			$FactionBonus[%faction,1] = 14;
		else
			$FactionBonus[%faction,1] -= 2;
		%gold = $FactionBonus[%faction,2];
		if ((%gold - 4) <= 14)
			$FactionBonus[%faction,2] = 14;
		else
			$FactionBonus[%faction,2] -= 4;

		for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
			if (GetPlayerFaction(%cl) == %faction) {
				%exp = $PlayerBonus[%cl,$ExpBonus];
				if ((%exp - 2) <= 14)
					$PlayerBonus[%cl,$ExpBonus] = 14;
				else
					$PlayerBonus[%cl,$ExpBonus] -= 2;
				%gold = $PlayerBonus[%cl,$GoldBonus];
				if ((%gold - 4) <= 14)
					$PlayerBonus[%cl,$GoldBonus] = 14;
				else
					$PlayerBonus[%cl,$GoldBonus] -= 4;
			}
		}
		SaveFaction();
	}
	SetWaitNextBattle();
}

echo("LADDER LOADED__");