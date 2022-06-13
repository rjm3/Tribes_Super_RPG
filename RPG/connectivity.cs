function Game::initialMissionDrop(%clientId)
{
	dbecho($dbechoMode2, "Game::initialMissionDrop(" @ %clientId @ ")");

	Client::setGuiMode(%clientId, $GuiModePlay);
	%clientId.observerMode = "";

	centerprint(%clientId, "", 0);

	//===================================================
	// Look for invalid characters in the player's name.
	// If none are found, LoadCharacter
	//===================================================

	%name = Client::getName(%clientId);

	%retval = FindInvalidChar(%name);
	if(%retval != "")
	{
		%kickMsg = "You are using invalid characters in your name.  Use a simpler name.  Suggested clan tag characters are dashes and underscores.";
		%clientId.IsInvalid = True;
	}
	else
	{
		%rw = CheckForReservedWords(%name);
		if(%rw != "")
		{
			%kickMsg = "You are using a reserved word in your name (" @ %rw @ ").";
			%clientId.IsInvalid = True;
		}
		else
		{
			//==================================================
			// Check for duplicate names with players currently
			// on server. Also check for duplicate IP's
			//==================================================
			%flag = False;
			%list = GetPlayerIdList();
			%pip = Client::getTransportAddress(%clientId);
			for(%i = 0; (%id = GetWord(%list, %i)) != -1; %i++)
			{
				%n = Client::getName(%id);
				if(String::ICompare(%n, %name) == 0 && %id != %clientId)
				{
					%kickMsg = "This character name is currently in use.";
					%clientId.IsInvalid = True;
					%flag = True;
					break;
				}

				if(!$allowDuplicateIPs)
				{
					%ip = Client::getTransportAddress(%id);
					if(String::ICompare(TrimIP(%ip), TrimIP(%pip)) == 0 && %id != %clientId)
					{
						%kickMsg = "You are not allowed to run two clients on the same server.";
						%clientId.IsInvalid = True;
						%flag = True;
						break;
					}
				}
			}

			if(!%flag)
			{
				LoadCharacter(%clientId);

				if(String::Compare(fetchData(%clientId, "tmpname"), Client::getName(%clientId)) != 0)
				{
					%kickMsg = "This character name already exists. Please choose another.";
					%clientId.IsInvalid = True;
				}

				//==================================================
				// Now that the profile is loaded, we can verify
				// the password.
				//==================================================
	
				if ($Client::info[%clientId, 5] == "")
				{
					%kickMsg = "You have not entered a password to protect your character. Select a password in the \"Other info\" field in your profile.";
					%clientId.IsInvalid = True;
				}
				if (fetchData(%clientId, "password") != $Client::info[%clientId, 5] && fetchData(%clientId, "password") != "")
				{
					%kickMsg = "This character name has already been selected by someone else on this server, or you are using an incorrect profile password. Change your password in \"Other info\" in your profile.";
					%clientId.IsInvalid = True;
				}
				if (fetchData(%clientId,"CurrentMap") != $CURRENTCRUMAP) {
					%kickMsg = "Your character is not currently saved on this world, you must connect to " @ fetchData(%clientId,"CurrentMap");
					%clientId.IsInvalid = True;
				}
			}
		}
	}

	//==================================================
	// If there was invalid characters in the player's
	// name or the password was incorrect, then stick
	// the player in observer mode so he can be kicked
	// out soon after.
	//==================================================

	if(%clientId.IsInvalid)
	{
		schedule("Net::kick(" @ %clientId @ ", \"" @ %kickMsg @ "\");", 20);
		centerprint(%clientId, %kickMsg @ " You will automatically be kicked within 20 seconds.  If not, please disconnect manually.", 0);

		Client::setControlObject(%clientId, Client::getObserverCamera(%clientId));
		%camSpawn = Game::pickObserverSpawn(%clientId);
		Observer::setFlyMode(%clientId, GameBase::getPosition(%camSpawn), GameBase::getRotation(%camSpawn), false, false);
	}
	else
	{
		//==================================================
		// Everything went fine, spawn the player (or make
		// him/her choose stats if creating a new char)
		//==================================================

		schedule("remoteEval("@%clientId@",InitRPGMsgHud);",1.0);

		if (%clientId.choosingRace == "True") {
                  	StartStatSelection(%clientId);
		}
		else
			Game::playerSpawn(%clientId, false);
	}
}

function Server::onClientDisconnect(%clientId)
{
	dbecho($dbechoMode2, "Server::onClientDisconnect(" @ %clientId @ ")");

	$players--;
	setWindowTitle(MainWindow, $players@"/"@$server::maxplayers@" "@$Server::HostName);
	Client::setControlObject(%clientId, -1);

      	if(!%clientId.IsInvalid && fetchData(%clientId, "HasLoadedAndSpawned"))
	{
		//Arena stuff
		if(IsInRoster(%clientId))
		{
			RestorePreviousEquipment(%clientId);
            	RemoveFromRoster(%clientId);
		}
		if(IsInArenaDueler(%clientId))
		{
			RestorePreviousEquipment(%clientId);
	            RemoveFromArenaDueler(%clientId);
		}

		//Pet stuff
		%list = fetchData(%clientId, "PersonalPetList");
		for(%p = String::findSubStr(%list, ","); (%p = String::findSubStr(%list, ",")) != -1; %list = String::NEWgetSubStr(%list, %p+1, 99999))
		{
			%w = String::NEWgetSubStr(%list, 0, %p);
			FellOffMap(%w);
		}

		//Camp stuff
		%camp = nameToId("MissionCleanup\\Camp" @ %clientId);
		if(%camp != -1)
			DoCampSetup(%clientId, 5);

		SaveCharacter(%clientId,True,True);

		ClearEvents(%clientId);
	}

	for(%i = 0; %i < 10; %i++)
		$Client::info[%clientId, %i] = "";

	SetAllSkills(%clientId, 0);
	$PlayerBackpack[%clientId] = "";
	$BackpackStorage[%clientId] = "";
	$PlayerBelt[%clientId] = "";
	ClearAllBonuses(%clientId);
	DefaultTowerPlayer(%clientId);
	$PlayerPerks[%clientId] = "";
	$PerkPoints[%clientId] = 0;
	$PlayerCruComplete[%clientId] = "";
	$PlayerQuests[%clientId] = "";
	$PlayerQuestStatus[%clientId] = "";
	$PlayerSpells[%clientId,1] = "";
	$PlayerSpells[%clientId,2] = "";
	$PlayerSpells[%clientId,3] = "";
	$PlayerPerks[%clientId] = "";
	$PerkPoints[%clientId] = 0;
	$AutoStartFocus[%clientId] = "-1";
	$CurPlayerSpells[%clientId] = "";
	$TempATK[%clientId] = 0;
	$TempDEF[%clientId] = 0;
	$BackpackStorage[%clientId,1] = "";
	$BackpackStorage[%clientId,2] = "";
	$BackpackStorage[%clientId,3] = "";
	$BackpackStorage[%clientId,4] = "";
	$BackpackStorage[%clientId,5] = "";
	for (%i = 0; %i <= 30; %i++) $PlayerWear[%clientId,%i] = "";
	$MagicFindList[%clientId] = "";
	if (PlayerIsInTeam(%clientId) != -1) LeaveTeam(%clientId);
	$PlayerTeam[%clientId] = "";
	$PlayerTeamId[%clientId] = "";
	%clientId.CantDrop = 0;
	%clientId.CantCancelQuest = 0;
	%clientId.WeaponSpecial = "";
	%clientId.Portal = "";
	%clientId.PortalZone = "";
	CruAiDisconnectKill(%clientId);
	$MM[%clientId] = "";
	$DamageOverride[%clientId] = "";
	%clientId.Class = "";	
	$BLEEDING[%clientId] = 0;
	$IGNITED[%clientId] = 0;
	$BLEEDHIT[%clientId] = 0;
	$IGNITEHIT[%clientId] = 0;
	%clientId.ArmorWeight = 0;
	ClearMapBonus(%clientId);
	$Snared[%clientId] = 0;
	$DOSAVE[%clientId] = 0;
	$PlayerNoSale = "";
	$AIISDEAD[%clientId] = "";
	$ELITE[%clientid] = "";
	$BOSS[%clientId] = "";
	%clientId.CraftQL = "";
	%clientId.SmithQL = "";
	%clientId.ChangeWorlds = "";
	%clientId.CraftBase = "";
	%clientId.CraftAdditions = "";
	$PlayerFavList[%clientId] = "";
	$TARGETINGAREA[%clientId] = 0;
	%clientId.lastTargetingArea = 0;
	
	// CLEAR MYSTIC
	ClearMysticRelic(%clientId);

      	echo("GAME: clientdrop " @ %clientId);

	%set = nameToID("MissionCleanup/ObjectivesSet");
	for(%i = 0; (%obj = Group::getObject(%set, %i)) != -1; %i++)
      	GameBase::virtual(%obj, "clientDropped", %clientId);
		
	echo("DISCONNECT*" @ client::GetName(%clientId));
}

function Server::onClientConnect(%clientId)
{
	dbecho($dbechoMode2, "Server::onClientConnect(" @ %clientId @ ")");

	$players++;
	setWindowTitle(MainWindow, $players@"/"@$server::maxplayers@" "@$Server::HostName);
	if(!String::NCompare(Client::getTransportAddress(%clientId), "LOOPBACK", 8))
	{
		// force admin the loopback dude
		%clientId.adminLevel = 5;
	}
	echo("CONNECT: " @ %clientId @ " \"" @ escapeString(Client::getName(%clientId)) @ "\" " @ Client::getTransportAddress(%clientId));

	%clientId.noghost = true;
	%clientId.messageFilter = -1; // all messages

	remoteEval(%clientId, SVInfo, version(), $Server::Hostname, $modList, $Server::Info, $ItemFavoritesKey);
	remoteEval(%clientId, MODInfo, $MODInfo);
	remoteEval(%clientId, FileURL, $Server::FileURL);

	//===============================================================================================
	DefaultTowerPlayer(%clientId);
	$PlayerTeam[%clientId] = "";
	$PlayerTeamId[%clientId] = "";

	//===============================================================================================
	ClearVariables(%clientId);		//this needs to be done so the profile is as clean as possible...
	Game::refreshClientScore(%clientId);	//so the player appears in the score list right away

	//===============================================================================================
	checkRPGMenu(%clientid);

	//===============================================================================================
	// RESET ALL SIM TIMES FOR SPAM CHECK
	%clientId.RawSim = getSimTime();
	%clientId.MenuSim = getSimTime();
	%clientId.FriendSim = getSimTime();
	%clientId.EnemySim = getSimTime();

	$BackpackStorage[%clientId] = "";
	$BackpackStorage[%clientId,1] = "";
	$BackpackStorage[%clientId,2] = "";
	$BackpackStorage[%clientId,3] = "";
	$BackpackStorage[%clientId,4] = "";
	$BackpackStorage[%clientId,5] = "";
	for (%i = 0; %i <= 30; %i++) $PlayerWear[%clientId,%i] = "";
	%clientId.CantDrop = 0;
	%clientId.CantCancelQuest = 0;
	%clientId.WeaponSpecial = "";
	%clientId.Portal = "";
	%clientId.PortalZone = "";	
	$MUSICTICKER[%clientId] = 10;	
	$MagicFindList[%clientId] = "";
	$CruAI[%id,$AiPetList] = "";
	$MM[%clientId] = "";
	$DamageOverride[%clientId] = "";
	%clientId.Class = "";
	$RESTIMER[%clientId] = 0;
	$ResSick[%clientId] = 0;
	$DOSAVE[%clientId] = 0;
	$AIISDEAD[%clientId] = "";
	$ELITE[%clientid] = "";
	$BOSS[%clientId] = "";
	%clientId.CraftQL = "";
	%clientId.SmithQL = "";
	%clientId.ChangeWorlds = "";
	%clientId.CraftBase = "";
	%clientId.CraftAdditions = "";
	$PlayerFavList[%clientId] = "";
	%clientId.ArmorWeight = 0;
	$TARGETINGAREA[%clientId] = 0;
	%clientId.lastTargetingArea = 0;
	
        echo("CONNECT*" @ client::GetName(%clientId));
}

function Game::onPlayerConnected(%playerId)
{
}

function Client::leaveGame(%clientId)
{
}

function SimSpam(%check,%v)
{
	if ((getSimTime() - %check) <= %v)
		return True;
	else
		return False;
}
