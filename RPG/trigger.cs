//----------------------------------------------------------------------------

TriggerData GroupTrigger
{
	className = "Trigger";
	rate = 1.0;
};


function LaunchPoint(%client)
{
	%object = Client::GetOwnedObject(%client);
	if (%object.InLaunchPoint == 1) {
		if (GameBase::IsAtRest(%object) || %object.OverrideMoveCheck == 1) {
			Client::SendMessage(%client,1,"*PERFORMING LAUNCH* Please keep your hands inside during the ride!");
			Item::SetVelocity(%object,%object.LaunchVel);
		}
		else
			Client::SendMessage(%client,1,"*ERROR* Do not move while attempting to Launch!");
	}
	else {
		Client::SendMessage(%client,1,"You are not in a travel launch point.");
		return;
	}
}

function TriggerCanUse(%id,%req)
{
	%m = true;
	for (%i = 0; (%g = GetWord(%req,%i)) != -1; %i+=3) {
		%v = getWord(%req,(%i+1));
		%k = getWord(%req,(%i+2));
		echo(" G:" @ %g @ " V:" @ %v @ " K:" @ %k);
		if (%g == "QC") {
			if (CruQuestCompleted(%id,%v) == False) {
				Client::SendMessage(%id,2,"You must have completed the quest: " @ $CRUQUEST[%v,NAME]);
				%m = false;
			}
		}
		if (%g == "ITEM") {
			if (HasBackpackCount(%id,%v,%k) == false) {
				Client::SendMessage(%id,2,"You need " @ %k @ " " @ GetBPData(%v,$BPName) @ ".");
				%m = false;
			}
		}
		if (%g == "LVLG") {
			if (fetchData(%id,"LVL") < %v) {
				Client::SendMessage(%id,2,"Your level must be " @ %v @ " or greater.");
				%m = false;
			}
		}
	}
	return %m;
}

function TriggerTake(%id,%take)
{
	echo(" TRIGGER TAKE " @ %id @ " " @ %take);
	for (%i = 0; (%g = GetWord(%take,%i)) != -1; %i+=2) {
		%v = getWord(%take,%i+1);
		%k = getWord(%take,%i+2);
		echo(" V " @ %v @ " K " @ %k);
		if (%g == "ITEM")
			RemoveFromBackpack(%id,%v,%k * -1);
	}
}

function GroupTrigger::onEnter(%this,%object)
{
	%type = getObjectType(%object);
	
	if (%this.TrigType == "LaunchPoint" && %type == "Player") {
		%vel = %this.LaunchVel;
		if (%vel == "")
			return;
		%client = Player::GetClient(%object);
		Client::SendMessage(%client,0,"You are in the " @ %this.LaunchInfo @ " launch zone. Use #travel to continue."); // Uses launch description now
		Client::SendMessage(%client,1,"*WARNING* This will cause damage, travel at your own Risk!");
		Client::SendMessage(%client,1,"~wbeep.wav");
		%object.LaunchVel = %vel;
		%object.InLaunchPoint = 1;
		if (%this.OverrideMovement)
			%object.OverrideMoveCheck = 1;
	}

	if (%this.double == 1) {
		%client = player::GetClient(%object);
		%client.double = 1;
	}
	
	if (%this.TrigType == "WARP") {
		%clientId = Player::GetClient(%object);
		if (Player::IsAiControlled(%object))
			return;
		if (%object.WarpImmune == 1)
			return;
		if (%this.need != "") {
			if (TriggerCanUse(%clientId,%this.need) == False) {
				Client::SendMessage(Player::GetClient(%object),2,"You are unable to use this portal.");
				return;
			}
			else {
				if (%this.take != "")
					TriggerTake(%clientId,%this.take);
			}
		}
		if (%this.targetingArea != "") {
			echo(" -@_@_@_@_@_@_@_@_- SETTING TARGET AREA " @ %this.targetingArea);
			$TARGETINGAREA[%clientId] = %this.TargetingArea;
		}
		else
			$TARGETINGAREA[%clientId] = 0;
		%object.WarpImmune = 1;
		Item::SetVelocity(%object,"0 0 0");
		GameBase::SetPosition(%object,%this.OutPos);
		GameBase::SetRotation(%object,%this.OutRot);
		if (%this.Zone != "")
			CruZoneUpdate(player::GetClient(%object),%this.Zone,0,%this.silent);
		schedule("" @ %object @ ".WarpImmune = 0;",1);
		return;
	}

	if (%this.TrigType == "PORTAL") {
		if (Player::IsAiControlled(%object))
			return;
		if (%object.WarpImmune == 1)
			return;
		%object.WarpImmune = 1;
		%client = player::GetClient(%object);
		if (%client.Portal != "") {
			%client.double = 1;
			GameBase::SetPosition(%object,%client.Portal);
			%zone = %client.PortalZone;
			StoreData(%client,"ZONE",%zone);
			if ($PassiveChange[%id] == 1)
				UpdatePassives(%client);
			Game::refreshClientScore(%client);
			%client.Portal = "";
			%client.PortalZone = "";
			$TARGETINGAREA[%client] = %client.lastTargetingArea;
		}
		schedule("" @ %object @ ".WarpImmune = 0;",1);
	}

	if (%this.TrigType == "ZONE") {
		CruZoneUpdate(player::GetClient(%object),%this.Zone,0);
		return;
	}

	if(%type == "Player" || %type == "Vehicle") {
		%group = getGroup(%this); 
 		%count = Group::objectCount(%group);
 		for (%i = 0; %i < %count; %i++) 
 			GameBase::virtual(Group::getObject(%group,%i),"onTrigEnter",%object,%this);
	}
}	

function GroupTrigger::onLeave(%this,%object)
{
	%type = getObjectType(%object);

	if (%this.TrigType == "LaunchPoint" && %type == "Player") {
		%object.LaunchVel = "";
		%object.InLaunchPoint = 0;
		%object.OverrideMoveCheck = 0;
		Client::SendMessage(Player::GetClient(%object),0,"You have left the Launch Area.");
	}

	if (%this.TrigType == "ZONE" && %type == "Player") {
		%client = player::GetClient(%object);
		if (%client.double == 1) {
			%client.double = 0;
			return;
		}
		else {
			%client.Updatezone = %this.Zone;
			//CruZoneUpdate(%client,%this.Zone,1);
			return;
		}
	}

	if(%type == "Player" || %type == "Vehicle") {
		%group = getGroup(%this); 
		%count = Group::objectCount(%group);
		for (%i = 0; %i < %count; %i++) 
			GameBase::virtual(Group::getObject(%group,%i),"onTrigLeave",%object,%this);
	}
}

function GroupTrigger::onContact(%this,%object)
{
	%type = getObjectType(%object);
	if(%type == "Player" || %type == "Vehicle") {
		%group = getGroup(%this); 
		%count = Group::objectCount(%group);
		for (%i = 0; %i < %count; %i++) 
			GameBase::virtual(Group::getObject(%group,%i),"onTrigger",%object,%this);
	}
}

function GroupTrigger::onActivate(%this)
{
}

function GroupTrigger::onDeactivate(%this)
{
}
