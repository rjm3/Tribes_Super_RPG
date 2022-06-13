//rpg admin

$curVoteTopic = "";
$curVoteAction = "";
$curVoteOption = "";
$curVoteCount = 0;

function Admin::changeMissionMenu(%clientId)
{
	Client::buildMenu(%clientId, "Pick Mission Type", "cmtype", true);
	%index = 1;
	
	//DEMOBUILD - the demo build only has one "type" of missions
	if ($MList::TypeCount < 2) $TypeStart = 0;
	else $TypeStart = 1;

	for(%type = $TypeStart; %type < $MLIST::TypeCount; %type++)
	{
		if($MLIST::Type[%type] != "Training")
		{
			Client::addMenuItem(%clientId, %index @ $MLIST::Type[%type], %type @ " 0");
			%index++;
		}
	}
}

function processMenuCMType(%clientId, %options)
{
	%curItem = 0;
	%option = getWord(%options, 0);
	%first = getWord(%options, 1);
	Client::buildMenu(%clientId, "Pick Mission", "cmission", true);
   
   for(%i = 0; (%misIndex = getWord($MLIST::MissionList[%option], %first + %i)) != -1; %i++)
   {
      if(%i > 6)
      {
         Client::addMenuItem(%clientId, %i+1 @ "More missions...", "more " @ %first + %i @ " " @ %option);
         break;
      }
      Client::addMenuItem(%clientId, %i+1 @ $MLIST::EName[%misIndex], %misIndex @ " " @ %option);
   }
}

function processMenuCMission(%clientId, %option)
{
   if(getWord(%option, 0) == "more")
   {
      %first = getWord(%option, 1);
      %type = getWord(%option, 2);
      processMenuCMType(%clientId, %type @ " " @ %first);
      return;
   }
   %mi = getWord(%option, 0);
   %mt = getWord(%option, 1);

   %misName = $MLIST::EName[%mi];
   %misType = $MLIST::Type[%mt];

   // verify that this is a valid mission:
   if(%misType == "" || %misType == "Training")
      return;
   for(%i = 0; true; %i++)
   {
      %misIndex = getWord($MLIST::MissionList[%mt], %i);
      if(%misIndex == %mi)
         break;
      if(%misIndex == -1)
         return;
   }
   if(%clientId.adminLevel >= 4)
   {
      messageAll(0, Client::getName(%clientId) @ " changed the mission to " @ %misName @ " (" @ %misType @ ")");
		Vote::changeMission();
      Server::loadMission(%misName);
   }
   else
   {
      Admin::startVote(%clientId, "change the mission to " @ %misName @ " (" @ %misType @ ")", "cmission", %misName);
      Game::menuRequest(%clientId);
   }
}

function remoteAdminPassword(%clientId, %password)
{
	if($AdminPassword != "" && %password == $AdminPassword[4])
	{
		%clientId.adminLevel = 4;
	}
}


function remoteSetPassword(%clientId, %password)
{
	if(%clientId.adminLevel >= 5)
		$Server::Password = %password;
}

function remoteSetTimeLimit(%clientId, %time)
{
   %time = floor(%time);
   if(%time == $Server::timeLimit || (%time != 0 && %time < 1))
      return;
   if(%clientId.adminLevel >= 4)
   {
      $Server::timeLimit = %time;
      if(%time)
         messageAll(0, Client::getName(%clientId) @ " changed the time limit to " @ %time @ " minute(s).");
      else
         messageAll(0, Client::getName(%clientId) @ " disabled the time limit.");
         
   }
}

function remoteSetTeamInfo(%clientId, %team, %teamName, %skinBase)
{
   if(%team >= 0 && %team < 8 && %clientId.adminLevel >= 4)
   {
      $Server::teamName[%team] = %teamName;
      $Server::teamSkin[%team] = %skinBase;
      messageAll(0, "Team " @ %team @ " is now \"" @ %teamName @ "\" with skin: " 
         @ %skinBase @ " courtesy of " @ Client::getName(%clientId) @ ".  Changes will take effect next mission.");
   }
}

function remoteVoteYes(%clientId)
{
   %clientId.vote = "yes";
   centerprint(%clientId, "", 0);
}

function remoteVoteNo(%clientId)
{
   %clientId.vote = "no";
   centerprint(%clientId, "", 0);
}

function Admin::startMatch(%admin)
{
   if(%admin == -1 || %admin.adminLevel >= 4)
   {
      if(!$CountdownStarted && !$matchStarted)
      {
         if(%admin == -1)
            messageAll(0, "Match start countdown forced by vote.");
         else
            messageAll(0, "Match start countdown forced by " @ Client::getName(%admin));
      
         Game::ForceTourneyMatchStart();
      }
   }
}

function Admin::setTeamDamageEnable(%admin, %enabled)
{
   if(%admin == -1 || %admin.adminLevel >= 4)
   {
      if(%enabled)
      {
         $Server::TeamDamageScale = 1;
         if(%admin == -1)
            messageAll(0, "Team damage set to ENABLED by consensus.");
         else
            messageAll(0, Client::getName(%admin) @ " ENABLED team damage.");
      }
      else
      {
         $Server::TeamDamageScale = 0;
         if(%admin == -1)
            messageAll(0, "Team damage set to DISABLED by consensus.");
         else
            messageAll(0, Client::getName(%admin) @ " DISABLED team damage.");
      }
   }
}

function Admin::kick(%admin, %clientId, %ban)
{
   if(%admin == -1 || %admin.adminLevel >= 4)
   {
      if(%ban && %admin.adminLevel < 5)
         return;
         
      if(%ban)
      {
         %word = "banned";
         %cmd = "BAN: ";
      }
      else
      {
         %word = "kicked";
         %cmd = "KICK: ";
      }
      if(%clientId.adminLevel >= 5)
      {
         if(%admin == -1)
            messageAll(0, "A super admin cannot be " @ %word @ ".");
         else
            Client::sendMessage(%admin, 0, "A super admin cannot be " @ %word @ ".");
         return;
      }
      %ip = Client::getTransportAddress(%clientId);

      echo(%cmd @ %admin @ " " @ %clientId @ " " @ %ip);

      if(%ip == "")
         return;
      if(%ban)
         BanList::add(%ip, 1800);
      else
         BanList::add(%ip, 180);

      %name = Client::getName(%clientId);

      if(%admin == -1)
      {
         MessageAll(0, %name @ " was " @ %word @ " from vote.");
         Net::kick(%clientId, "You were " @ %word @ " by  consensus.");
      }
      else
      {
         MessageAll(0, %name @ " was " @ %word @ " by " @ Client::getName(%admin) @ ".");
         Net::kick(%clientId, "You were " @ %word @ " by " @ Client::getName(%admin));
      }
   }
}

function Admin::setModeFFA(%clientId)
{
	return;
}

function Admin::setModeTourney(%clientId)
{
	return;
}

function Admin::voteFailed()
{
	return;
}

function Admin::voteSucceded()
{
	return;
}

function Admin::countVotes(%curVote)
{
	return;
}

function Admin::startVote(%clientId, %topic, %action, %option)
{
	return;
}

function Game::menuRequest(%clientId)
{
	if(%clientId.IsInvalid)
		return;

	if (%clientId.choosingRace)
	{
		MenuRace(%clientId);
		return;
	}
	if(%clientId.ConfirmRace)
	{
		MenuConfirmRace(%clientId);
		return;
	}


	%curItem = 0;
	Client::buildMenu(%clientId, "The Crucible", "options", true);
	if($curVoteTopic != "" && %clientId.vote == "")
	{
		Client::addMenuItem(%clientId, %curItem++ @ "Vote YES to " @ $curVoteTopic, "voteYes " @ $curVoteCount);
		Client::addMenuItem(%clientId, %curItem++ @ "Vote NO to " @ $curVoteTopic, "voteNo " @ $curVoteCount);
	}
	else
	{
		if(%clientId.selClient)
		{
			%sel = %clientId.selClient;
			%selname = Client::getName(%sel);
	
			if(%clientId != %sel && fetchData(%sel, "HasLoadedAndSpawned"))
			{
                       	 	if(IsInCommaList(fetchData(%clientId, "grouplist"), %selname))
					Client::addMenuItem(%clientId, %curItem++ @ "Remove from group-list", "remgroup " @ %sel);
				else
					Client::addMenuItem(%clientId, %curItem++ @ "Add to group-list", "addgroup " @ %sel);

                        	if(IsInCommaList(fetchData(%clientId, "targetlist"), %selname))
					Client::addMenuItem(%clientId, %curItem++ @ "Remove from target-list", "remtarget " @ %sel);
				else
					Client::addMenuItem(%clientId, %curItem++ @ "Add to target-list", "addtarget " @ %sel);

				if ((%team = PlayerIsInTeam(%clientId)) != -1) {
					if (%clientId == GetTeamLeader(%team)) {
						Client::addMenuItem(%clientId, %curItem++ @ "Invite to your team", "addteam " @ %sel);
					}
				}

				if(%clientId.muted[%sel])
					Client::addMenuItem(%clientId, %curItem++ @ "Unmute", "unmute " @ %sel);
				else
					Client::addMenuItem(%clientId, %curItem++ @ "Mute", "mute " @ %sel);
			}
		}
		else
		{
			if(!IsDead(%clientId))
				Client::addMenuItem(%clientId, %curItem++ @ "View your stats" , "viewstats");
			
			Client::addMenuItem(%clientId, %curItem++ @ "Settings..." , "selsettings");
			Client::AddMenuItem(%clientId, GetMenuNum(%curItem++) @ "Skill Points...","sp");
			Client::AddMenuItem(%clientId, GetMenuNum(%curItem++) @ "Passives...","menupassives");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Team options..." , "teamoptions");		
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Quest Log..." , "quest");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Spells..." , "spells");
			//Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Favorites..." , "fav");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Memory..." , "memory");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Smithing & Crafting..." , "smithcraft");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Equipped Gear..." , "wear");
			Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Backpack..." , "backpack");

			if (%clientId.CraftBase != "" || %clientId.CraftAdditions != "")
				Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Crafting Table..." , "craft");						

			if ((%active = HasActiveMap(%clientId)) != -1)
				Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "View Current Map..." , "map " @ %active);

			%zone = fetchData(%clientId,"zone");
			if ($CRUZONE[%zone,$CZType] == $CZMap)
				Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Leave Map..." , "leavemap");	

			if (BackpackStorageArea(%clientId) == true) {
				Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Storage..." , "storage");
			}
		}
	}
}
function processMenuOptions(%clientId, %option)
{
	dbecho($dbechoMode, "processMenuOptions(" @ %clientId @ ", " @ %option @ ")");

	%opt = getWord(%option, 0);
	%cl = getWord(%option, 1);

	if(%opt == "Other") {
		Client::SendMessage(%clientId,1,"[EXPLOIT] Exploit attempt recorded. Admins are notified.");
		return;
	}

	//**RPG
	else if(%opt == "selspell")
	{
		Client::buildMenu(%clientId, "Select a spell", "selectspell", true);
		%curitem=1;
		%name = Client::getName(%clientId);

		for(%i=1; $spellShell[%i] != ""; %i++)
		{
			if(isInSpellList(%name, $spellShell[%i]) == 1)
			{
				Client::addMenuItem(%clientId, %curitem @ $spellName[%i], %i);
				%curitem++;
			}
		}

		return;
	}
	else if(%opt == "viewstats")
	{
		Game::MenuViewStats(%clientId);
	}
	
	else if (%opt == "selsettings") 
	{
		Game::MenuSettings(%clientId);
	}
	else if (%opt == "selsettingsback") 
	{
		Game::MenuRequest(%clientId);
	}

	else if(%opt == "defgroup")
	{
		storeData(%clientId, "defaultTalk", "#group");
		Game::MenuSettings(%clientId);
	}
	else if(%opt == "defsay")
	{
		storeData(%clientId, "defaultTalk", "#say");
		Game::MenuSettings(%clientId);
	}
	else if(%opt == "addgroup")
	{
		if(countObjInCommaList(fetchData(%clientId, "grouplist")) <= 30)
		{
			%name = Client::getName(%cl);
			storeData(%clientId, "grouplist", AddToCommaList(fetchData(%clientId, "grouplist"), %name));

			Client::sendMessage(%cl, $MsgBeige, Client::getName(%clientId) @ " has added you to his/her group-list.");
			Client::sendMessage(%clientId, $MsgBeige, %name @ " is now on your group-list.");
		}
		else
			Client::sendMessage(%clientId, $MsgRed, "You have too many people on your group-list.");
	}
	else if(%opt == "remgroup")
	{
		%name = Client::getName(%cl);
		storeData(%clientId, "grouplist", RemoveFromCommaList(fetchData(%clientId, "grouplist"), %name));

		Client::sendMessage(%cl, $MsgBeige, Client::getName(%clientId) @ " has removed you from his/her group-list.");
		Client::sendMessage(%clientId, $MsgBeige, %name @ " is no longer on your group-list.");
	}
	else if(%opt == "addtarget")
	{
		return;
		if(countObjInCommaList(fetchData(%clientId, "targetlist")) <= 30)
		{
			%delay = 20;
			%name = Client::getName(%cl);
			Client::sendMessage(%clientId, $MsgRed, %name @ " will be added to your target-list in " @ %delay @ " seconds.");
			Client::sendMessage(%cl, $MsgRed, Client::getName(%clientId) @ " is thinking about killing you.");

			schedule("AddToTargetList(" @ %clientId @ ", " @ %cl @ ");", %delay, %cl);
		}
		else
			Client::sendMessage(%clientId, $MsgRed, "You have too many people on your target-list.");
	}
	else if(%opt == "remtarget")
	{
		%name = Client::getName(%cl);
		storeData(%clientId, "targetlist", RemoveFromCommaList(fetchData(%clientId, "targetlist"), %name));

		Client::sendMessage(%cl, $MsgBeige, Client::getName(%clientId) @ " has declared a truce.");
		Client::sendMessage(%clientId, $MsgBeige, %name @ " is no longer on your target-list.");
	}
	else if (%opt == "addteam") {
		InviteToTeam(%clientId,%cl);
	}

	else if(%opt == "mute")
	      %clientId.muted[%cl] = True;
	else if(%opt == "unmute")
		%clientId.muted[%cl] = "";
	else if(%opt == "gignoreon")
	{
		storeData(%clientId, "ignoreGlobal", True);
		Game::MenuSettings(%clientId);
	}
	else if(%opt == "gignoreoff")
	{
		storeData(%clientId, "ignoreGlobal", "");
		Game::MenuSettings(%clientId);
	}
	else if(%opt == "sp")
	{
		//MenuSP(%clientId, 1);
		MenuCruSP(%clientId,1);
		return;
	}
	//============================================================================================
	if (%opt == "backpack") Game::MenuBackpack(%clientId,0);
	if (%opt == "storage") Game::MenuChooseStorage(%clientId);
	//============================================================================================
	else if (%opt == "teamoptions")
	{
		Game::MenuTeam(%clientId);
	}
	if (%opt == "selquest") {
		ShowCruQuestStatus(%clientId,%cl);
		//Game::MenuQuestSelect(%clientId,%cl);
	}
	if (%opt == "questinfo") {
		ShowCruQuestStatus(%clientId,%cl);
	}
	if (%opt == "delquest") {
		DelCruQuest(%clientId,%cl);
	}
	if (%opt == "quest") {
		Game::MenuQuest(%clientId,0);
	}
	//========================================================================================
	if (%opt == "wear") {
		Game::MenuWear(%clientId);
		//Game::MenuWearWindow(%clientId);
	}
	if (%opt == "selnextwear") {
		 Game::MenuWear2(%clientId);
	}
	if (%opt == "selnextwear2") {
		 Game::MenuWear3(%clientId);
	}
	if (%opt == "selbackwear1") {
		 Game::MenuRequest(%clientId);
	}
	if (%opt == "selbackwear2") {
		 Game::MenuWear(%clientId);
	}
	if (%opt == "selbackwear3") {
		 Game::MenuWear2(%clientId);
	}
	//========================================================================================
	// BELT
	if (%opt == "selbeltuse") {
		if (GetBeltCount(%clientId,%cl) > 0)
		 	BackpackUse(%clientId,%cl,True);
	}
	if (%opt == "seladdbelt") {
		AddToBelt(%clientId,%cl,getWord(%option,2));
	}
	//========================================================================================
	// TEAM
	if (%opt == "createteam") {
		CreateTeam(%clientId);
	}
	if (%opt == "leaveteam") {
		LeaveTeam(%clientId);
	}
	if (%opt == "viewteam") {
		ViewTeam(%clientId);
	}
	if (%opt == "kickteam") {
		Game::MenuKickTeam(%clientId);
	}
	if (%opt == "teammakeleader") {
		Game::MenuMakeLeader(%clientId);
	}
	if (%opt == "acceptteaminvite") {
		AcceptTeamInvite(%clientId);
	}
	//========================================================================================
	if (%opt == "menupassives") {
		 Game::MenuPassives(%clientId);
	}
	//========================================================================================
	if (%opt == "smithcraft") {
		Game::MenuSmithCraft(%clientId);
	}
	//========================================================================================
	if (%opt == "craft") {
		Game::MenuCraft(%clientId);
	}
	//========================================================================================
	if (%opt == "map") {
		if (IsNumeric(%cl) == true)
		ShowMap(%clientId,%cl);
	}
	//========================================================================================
	if (%opt == "leavemap") {
		LeaveMap(%clientId);
	}
	//========================================================================================
	if (%opt == "spells") {
		Game::MenuSpells(%clientId);
	}
	//========================================================================================
	if (%opt == "memory") {
		Game::MenuFocus(%clientId,0);
	}
	//========================================================================================
	if (%opt == "selbackpacksell") {
		BackpackSetSell(%clientId,%cl,getWord(%option,2),getWord(%option,3),getWord(%option,4));
	}
	if (%opt == "selbackpackbuy") {
		BackpackSetBuy(%clientId,%cl,getWord(%option,2));
	}
	if (%opt == "selselectwear") {
		Game::MenuSelectWear(%clientId,%cl);
	}
	if (%opt == "selbackwear0") {
		Game::MenuRequest(%clientId);
	}
	//**
}

function Game::MenuViewStats(%clientId)
{
	%curItem = 0;
	Client::buildMenu(%clientId, "Select Stats to View:", "viewstats", true);
	Client::addMenuItem(%clientId, %curItem++ @ "General Stats..." , "gen");
	Client::addMenuItem(%clientId, %curItem++ @ "Defensive Stats..." , "def");
	Client::addMenuItem(%clientId, %curItem++ @ "Offensive Stats..." , "wep");
	Client::addMenuItem(%clientId, %curItem++ @ "Magic Stats..." , "mag");
	Client::addMenuItem(%clientId, "p" @ "<< Prev","back");
}

function processMenuviewstats(%clientId,%option)
{
	if (%option == "gen") ViewStats(%clientId,1);
	if (%option == "def") ViewStats(%clientId,2);
	if (%option == "wep") ViewStats(%clientId,3);
	if (%option == "mag") ViewStats(%clientId,4);
	if (%option == "back") Game::MenuRequest(%clientId);
}

function Game::MenuSettings(%clientId)
{
	%curItem = 0;
	Client::buildMenu(%clientId, "Settings", "options", true);
	if(fetchData(%clientId, "defaultTalk") == "#say")
		Client::addMenuItem(%clientId, %curItem++ @ "Set default talk: #group" , "defgroup");
	else
		Client::addMenuItem(%clientId, %curItem++ @ "Set default talk: #say" , "defsay");
	if(fetchData(%clientId, "ignoreGlobal"))
		Client::addMenuItem(%clientId, %curItem++ @ "Turn ignore global OFF" , "gignoreoff");
	else
		Client::addMenuItem(%clientId, %curItem++ @ "Turn ignore global ON" , "gignoreon");
	Client::addMenuItem(%clientId, "p" @ "<< Prev","selsettingsback");
}

function processMenupartyopt(%clientId, %option)
{
	return;
}

function processMenuselectspell(%clientId, %option)
{
	return;
}
function processMenuselectrweapon(%clientId, %item)
{
	return;
}
function processMenuselectproj(%clientId, %itemandproj)
{
	return;
}

function processMenuOtheropt(%clientId, %option)
{
	return;
}

function remoteSelectClient(%clientId, %selId)
{
	dbecho($dbechoMode, "remoteSelectClient(" @ %clientId @ ", " @ %selId @ ")");

   	if(%clientId.selClient != %selId)
   	{
     		%clientId.selClient = %selId;
      		if(%clientId.menuMode == "options")
         		Game::menuRequest(%clientId);
      		remoteEval(%clientId, "setInfoLine", 1, "Player Info for " @ Client::getName(%selId) @ ":");
      		remoteEval(%clientId, "setInfoLine", 2, "Real Name: " @ $Client::info[%selId, 1]);
      		remoteEval(%clientId, "setInfoLine", 3, "Email Addr: " @ $Client::info[%selId, 2]);
      		remoteEval(%clientId, "setInfoLine", 4, "Tribe: " @ $Client::info[%selId, 3]);
     		remoteEval(%clientId, "setInfoLine", 5, "URL: " @ $Client::info[%selId, 4]);
   	}
}


function processMenuPickTeam(%clientId, %team, %adminClient)
{
	return;
}
