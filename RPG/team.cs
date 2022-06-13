// TEAM 1

$ServerTeamIdOn = 0;
$MaxTeam = 6;

function PlayerIsInTeam(%id)
{
	if ($PlayerTeam[%id] != "") 
		return $PlayerTeam[%id];
	else
		return -1;
}

function SameTeam(%id,%target)
{
	if ((%idteam = PlayerIsInTeam(%id)) == -1)
		return False;
	if ((%targteam = PlayerIsInTeam(%target)) == -1)
		return False;
	if (%idteam == %targteam)
		return True;
	else
		return False;			
}

function IsTeamLeader(%id)
{
	if ((%team = PlayerIsInTeam(%id)) != -1) {
		if ($TeamLeader[%team] == %id)
			return True;
		else
			return False;
	}
}

function CreateTeam(%id)
{
	if (PlayerIsInTeam(%id) == -1) {
		%teamNum = "TEAM" @ $ServerTeamIdOn;
		$TeamLeader[%teamNum] = %id;
		$ServerTeamIdOn++;
		Client::SendMessage(%id,0,"You have created a new team.");
		JoinTeam(%id,%teamNum,True);
		EnableTeamHud(%id);
	}
	else
		Client::SendMessage(%id,0,"You are already in a team.");
}

function TeamGetCount(%teamId)
{
	%n = 0;
	%team = $TeamList[%teamId];
	for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
		if (getWord(%team,%i) != -1) {
			%n++;
		}
	}
	return %n;
}

function CanJoinTeam(%id,%teamId,%bootcheck,%manual)
{
	%maxlvl = 0;
	%plvl = fetchData(%id,"LVL");
	%req = "";
	%team = $TeamList[%teamId];

	if (getWord(%team,0) == -1 && !%manual)
		return "True";
	if (PlayerIsInTeam(%id) != -1 && !%manual) {
		Client::SendMessage(%id,0,"You must leave your current team.");
		return "False";
	}

	for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
		%m = getWord(%team,%i);
		if (%m != -1) {
			%lvl = fetchData(%m,"LVL");
			if (%lvl > %maxlvl)
				%maxlvl = %lvl;
		}
	}

	if (%manual) {
		%maxlvl = %manual;
	}

	if (%maxlvl <= 15)
		%minlvl = %maxlvl - floor(%maxlvl * 0.7);
	else if (%maxlvl > 15 && %maxlvl <= 25)
		%minlvl = %maxlvl - floor(%maxlvl * 0.6);
	else if (%maxlvl > 25 && %maxlvl <= 35)
		%minlvl = %maxlvl - floor(%maxlvl * 0.5);
	else
		%minlvl = %maxlvl - floor(%maxlvl * 0.4);
	%req = %req @ "Level: " @ %minlvl;
	if (%bootcheck == True) {
		for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
			%m = getWord(%team,%i);
			%flag = False;
			if (%m != -1) {
				%lvl = fetchData(%m,"LVL");
				%rl = fetchData(%m,"RemortStep");
				if (%lvl < %minlevel)
					%flag = True;
			}
			if (%flag == True) {
				RemoveFromTeam(%m,%teamId,%req);
			}
		}
	}

	else {
		if (%plvl >= %minlvl) {
			return "True";
		}
		else {
			return %req;
		}
	}
}

function DisbandTeam(%id,%teamId)
{
	Client::SendMessage(%id,0,"You disbanded your team.");
	$TeamList[%teamId] = "";
	$TeamLeader[%teamId] = "";
	$PlayerTeam[%id] = "";
	$PlayerTeamId[%id] = "";
	DisableTeamHud(%id);
}

function LeaveTeam(%id)
{
	echo(" LEAVE TEAM " @ %id);
	if ((%team = PlayerIsInTeam(%id)) != -1)
		RemoveFromTeam(%id,%team);
	else
		Client::SendMessage(%id,0,"You are not in a team.");	
}

function InviteToTeam(%id,%target)
{
	if (PlayerIsInTeam(%id) == -1) {
		Client::SendMessage(%id,0,"You are not in a team.");
		return;
	}
	if (PlayerIsInTeam(%target) != -1) {
		Client::SendMessage(%id,0,"Player is already in a team.");
		return;
	}
	%team = PlayerIsInTeam(%id);
	$PlayerInvited[%target] = %team;
	Client::SendMessage(%id,2,"You invited " @ Client::GetName(%target) @ " to join your team.");
	Client::SendMessage(%target,2,"You have been invited to join " @ Client::GetName(%id) @ "'s team.");
}

function AcceptTeamInvite(%id)
{
	if ((%team = $PlayerInvited[%id]) != "") {
		JoinTeam(%id,%team,False);
		$PlayerInvited[%id] = "";
	}
}

function DebugTeams()
{
	for (%i = 0; %i <= 50; %i++) {
		$TeamList[%i] = "";
		$ServerOnTeamId = 0;
	}
}

function RemoveFromTeam(%id,%teamId)
{
	%new = "";
	%team = $TeamList[%teamId];
	for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
		%m = getWord(%team,%i);
		if (%m != %id && %m != -1)
			%new = %new @ %m @ " ";
	}
	if (getWord(%new,0) == -1) {
		DisbandTeam(%id,%teamId);
		return;
	}
	$TeamList[%teamId] = %new;
	$PlayerTeam[%id] = "";
	$PlayerTeamId[%id] = "";
	if ($TeamLeader[%teamId] == %id) {
		%newlead = getWord(%new,0);
		$TeamLeader[%teamId] = %newlead;
		CruTeamMessage(%teamId,Client::GetName(%newlead) @ " was made team leader.",True);
	}
	Client::SendMessage(%id,2,"You have left the team.");
	CruTeamMessage(%teamId,Client::GetName(%id) @ " has left the team.",True);
	DisableTeamHud(%id);
	%team = $TeamList[%teamId];
	for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
		%m = getWord(%team,%i);
		if (%m != -1)
			InitialTeamHud(%m);
	}
}

function GetTeamLeader(%team)
{
	return $TeamLeader[%team];
}

function JoinTeam(%id,%teamId,%new)
{
	if (PlayerIsInTeam(%id) == -1 || %new == True) {
		if ((%teamnum = TeamGetCount(%teamId)) < 6) {
			if ((%req = CanJoinTeam(%id,%teamId,False)) == "True") {
				$TeamList[%teamId] = $TeamList[%teamId] @ %id @ " ";
				$PlayerTeam[%id] = %teamId;
				$PlayerTeamId[%id] = %teamnum;
				%leader = $TeamLeader[%teamId];
				if (%new != True)
					Client::SendMessage(%id,2,"You have joined " @ Client::GetName(%leader) @ "'s team.");
				CruTeamMessage(%teamId,Client::GetName(%id) @ " joined the team.",True);
				EnableTeamHud(%id);
				RefreshTeamHud(%id);
				CanJoinTeam(0,%teamId,True);
			}
			else
				Client::SendMessage(%id,2,"You do not meet the requirements to join this team. (" @ %req @ ")");	
		}
		else
			Client::SendMessage(%id,2,"Team is full.");	
	}
	else
		Client::SendMessage(%id,2,"You are already in a team.");
}

function EnableTeamHud(%id)
{
	remoteEval(%id,"RPGGui::EnableTeam");
	InitialTeamHud(%id);
}

function DisableTeamHud(%id)
{
	remoteEval(%id,"RPGGui::DisableTeam");
}

function CruTeamMessage(%team,%msg,%system)
{
	%list = $TeamList[%team];
	for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
		%m = getWord(%list,%i);
		if (%m != -1) {
			if (%system != True)
				Client::SendMessage(%m,3,"[TEAM] " @ %msg);
			else
				Client::SendMessage(%m,2,%msg);	
		}
	}
}

function RefreshTeamHud(%id)
{
	//echo(" REFRESH TEAM HUD -------------->" @ %id);
	%teamid = $PlayerTeam[%id];
	if (%teamid == "")
		return;
	%team = $TeamList[%teamid];
	%n = $PlayerTeamId[%id];
	for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
		%tid = getWord(%team,%i);
		if (%tid != -1) {
			%name = Client::GetName(%tid);
			%hb = fetchData(%tid,"HP") / fetchdata(%tid,"MaxHP");
			%mb = fetchData(%tid,"MANA") / fetchdata(%tid,"MaxMANA");
			remoteEval(%id,"RPGGui::UpdateTeamName",%i,"<f1>"@%name);
			remoteEval(%id,"RPGGui::UpdateTeamHealth",%i,%hb);
			remoteEval(%id,"RPGGui::UpdateTeamMana",%i,%mb);
		}
	}	
}

function InitialTeamHud(%id)
{
	echo(" INITIAL TEAM HUD " @ %id);
	%team = PlayerIsInTeam(%id);
	if (%team == -1)
		return;
	%team = $TeamList[%team];
	echo(" TEAM LIST <" @ %team @ ">");
	for (%i = 0; %i <= ($MaxTeam - 1); %i++) {
		%tid = getWord(%team,%i);
		if (%tid == "-1") {
			echo(%i @ " Setting blank ");
			remoteEval(%id,"RPGGui::UpdateTeamName",%i,"");
			remoteEval(%id,"RPGGui::UpdateTeamHealth",%i,0);
			remoteEval(%id,"RPGGui::UpdateTeamMana",%i,0);
		}
		else {
			echo(%i @ " ADDING name ");
			%name = Client::GetName(%tid);
			remoteEval(%id,"RPGGui::UpdateTeamName",%i,"<f1>"@%name);
			%hb = fetchData(%tid,"HP") / fetchdata(%tid,"MaxHP");
			remoteEval(%id,"RPGGui::UpdateTeamHealth",%i,%hb);
			%mb = fetchData(%tid,"MANA") / fetchdata(%tid,"MaxMANA");
			remoteEval(%id,"RPGGui::UpdateTeamMana",%i,%mb);
		}
	}
}

function Game::MenuTeam(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Team options", "options", true);
	if (PlayerIsInTeam(%id) == -1) {
		Client::addMenuItem(%id, "c" @ "Create team","createteam");
		if ((%join = $PlayerInvited[%id]) != "") {
			%leader = Client::GetName(GetTeamLeader(%join));
			Client::addMenuItem(%id, "a" @ "Accept Invite: " @ %leader ,"acceptteaminvite");
		}
	}
	if ((%team = PlayerIsInTeam(%id)) != -1) {
		%curItem = 0;
		%list = $TeamList[%team];
		Client::addMenuItem(%id, %curItem @ "Leave team","leaveteam");
		for (%i = 0; %i <= 5; %i++) {
			if ((%m = getWord(%list,%i)) != -1) {
				if (IsTeamLeader(%m))
					Client::addMenuItem(%id,%curItem++ @ Client::GetName(%m) @ " (Leader)","teammemberoption " @ %team @ " " @ %m);
				else
					Client::addMenuItem(%id,%curItem++ @ Client::GetName(%m),"teammemberoption " @ %team @ " " @ %m);
			}
		}
	}
}

echo("__ TEAM LOADED");