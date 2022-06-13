$MsgTypeSystem = 0;
$MsgTypeGame = 1;
$MsgTypeChat = 2;
$MsgTypeTeamChat = 3;
$MsgTypeCommand = 4;

exec("comchat-translate.cs");

$MsgWhite = 	0;
$MsgRed = 	1;
$MsgBeige = 	2;
$MsgYellow =	2;
$MsgGreen = 	3;
$MsgPink = 	4;
$MsgBlue =	5;
$MsgCyan = 	6;
$MsgOrange = 	7;

// rpg::sendmessage(%clientId, %colour, %msg, %hud)

function remoteSay(%clientId, %team, %message, %senderName)
{
	// echo("REMOTE SAY " @ %clientId @ " " @ %team @ " " @ %message @ " " @ %senderName);
	//==========================================================================================================================
	%clientToServerAdminLevel = floor(%clientId.adminLevel);
	%trueClientId = %clientId;
	%TCsenderName = Client::getName(%TrueClientId);	
	//==========================================================================================================================
	//%time = getIntegerTime(true) >> 5;
	//if(%time - %clientId.lastSayTime <= $sayDelay && !(%clientToServerAdminLevel >= 1))
	//	return;
	//%clientId.lastSayTime = %time;
	if($justChat[%clientId])
		return;
	$justChat[%clientId] = True;
	schedule("$justChat["@%clientId@"]=\"\";",$sayDelay);
	//==========================================================================================================================
	%msg = %clientId @ " \"" @ escapeString(%message) @ "\"";	
	//==========================================================================================================================
	// BULK NUM
	if (%message == floor(%message)) {
		if (%trueClientId.NPCDeposit == 1) {
			NPCDepositCoins(%trueClientId,%message);
			return;
		}
		if (%trueClientId.NPCWithdraw == 1) {
			NPCWithdrawCoins(%trueClientId,%message);
			return;
		}
		if(%clientId.currentShop != "" || %clientId.currentBank != "")
		{
			if(%message < 1)
				%message = 1;
			if(%message > 50000)
				%message = 50000;
		}
		%TrueClientId.bulkNum = %message;
	}
	//==========================================================================================================================
	%isCommand = False;
	if(String::getSubStr(%message, 0, 1) != "#")
	{
		if (%team)
			%message = "#zone " @ %message;
		else
			%message = fetchData(%TrueClientId, "defaultTalk") @ " " @ %message;

	}
	if (String::getSubStr(%message, 0, 1) == "#")
		%isCommand = True;
	else
		%isCommand = False;
	//==========================================================================================================================
	// EXPLOIT
	if (string::FindSubStr(%message,"\\") != -1) return;
	// if (string::FindSubStr(%message,"@") != -1) return;
	//==========================================================================================================================
	%w1 = GetWord(%message,0);
	%cropped = String::NEWgetSubStr(%message, (String::len(%w1)+1), 99999);
	//==========================================================================================================================
	if (%isCommand) {
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#remort") {
			DoRemort(%TrueClientId);
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#resetmyskills") {
			%naked = true;
			for (%x = 1; %x <= 30; %x++) {
				%wear = GetCurrentWear(%TrueClientId,%x);
				if (%wear != "none")
					%naked = false;
			}
			if (%naked == false) {
				Client::SendMessage(%TrueClientId,0,"You must have no gear equiped to reset your skills.");
				return;
			}
			for (%si = 1; %si <= 51; %si++)
				$PlayerSkill[%TrueClientId,%si] = 1;
			%race = fetchData(%TrueClientId,"CruRACE");
			$PlayerSkill[%TrueClientId,$SkillStrength] = $AbilityMultiplier[%race, $SkillStrength];
			$PlayerSkill[%TrueClientId,$SkillDexterity] = $AbilityMultiplier[%race, $SkillDexterity];
			$PlayerSkill[%TrueClientId,$SkillIntelligence] = $AbilityMultiplier[%race, $SkillIntelligence];
			%lvl = fetchData(%TrueClientId,"LVL");
			%sp = %lvl * 80;
			%sp -= 10;
			storeData(%TrueClientId, "SPcredits", %sp);
			Client::SendMessage(%TrueClientId,0,"You reset all your skills.");
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#showbonus") {
			%m = "";
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#travel") {
			SetupTravel(%TrueClientId);
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#calc") {
			return;
			%ret = %ret + %cropped + 0;
			Client::sendMessage(%TrueClientId,$msgwhite,"[Calc] " @ %ret);
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#shout") {
			for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl)) {
				%talkingPos = GameBase::getPosition(%TrueClientId);
				%receivingPos = GameBase::getPosition(%cl);
				%distVec = Vector::getDistance(%talkingPos, %receivingPos);
				if (%distVec <= $maxSAYdistVec) {
					%newmsg = %cropped;
					if(!%cl.muted[%TrueClientId] && %cl != %TrueClientId)
						Client::sendMessage(%cl, $MsgWhite, %TCsenderName @ " shouts, \"" @ %newmsg @ "\"");
									
				}
			}
			Client::sendMessage(%TrueClientId, $MsgWhite, "You shout, \"" @ %cropped @ "\"");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#shout") {
			for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl)) {
				%talkingPos = GameBase::getPosition(%TrueClientId);
				%receivingPos = GameBase::getPosition(%cl);
				%distVec = Vector::getDistance(%talkingPos, %receivingPos);
				if (%distVec <= $maxSHOUTdistVec) {
					%newmsg = %cropped;
					if(!%cl.muted[%TrueClientId] && %cl != %TrueClientId)
						Client::sendMessage(%cl, $MsgWhite, %TCsenderName @ " shouts, \"" @ %newmsg @ "\"");
									
				}
			}
			Client::sendMessage(%TrueClientId, $MsgWhite, "You shout, \"" @ %cropped @ "\"");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#whisper") {
			for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl)) {
				%talkingPos = GameBase::getPosition(%TrueClientId);
				%receivingPos = GameBase::getPosition(%cl);
				%distVec = Vector::getDistance(%talkingPos, %receivingPos);
				if (%distVec <= $maxWHISPERdistVec) {
					%newmsg = %cropped;
					if(!%cl.muted[%TrueClientId] && %cl != %TrueClientId)
						Client::sendMessage(%cl, $MsgWhite, %TCsenderName @ " whispers, \"" @ %newmsg @ "\"");
									
				}
			}
			Client::sendMessage(%TrueClientId, $MsgWhite, "You whisper, \"" @ %cropped @ "\"");
			return;
		}
		//==========================================================================================================================
		// JAIL CHECK
		if (IsJailed(%TrueClientId) && %clientToServerAdminLevel < 1)
			return;
		//==========================================================================================================================
		if (%w1 == "#global" || %w1 == "#g") {
			if (%cropped == "") return;
			if (!fetchData(%TrueClientId, "ignoreGlobal")) {
				for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl)) {
			        	if (!%cl.muted[%TrueClientId] && %cl != %TrueClientId && !fetchData(%cl, "ignoreGlobal"))
						rpg::sendMessage(%cl, $MsgHudGreen, "[G] " @ %TCsenderName @ ": " @ %cropped,true);
				}
				rpg::sendMessage(%TrueClientId, $MsgHudGreen, "[G] " @ %cropped,true);
				echo("GLOBALCHAT*" @ $CURRENTCRUMAP @ "*" @ %TCSenderName @ "*" @ %cropped);
				comm::SendAll("MSG [G] " @ %TCsenderName @ ": " @ %cropped);
			}
			else
				Client::sendMessage(%TrueClientId, $MsgRed, "You can't send a Global message when ignoring other Global messages.");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
 		if (%w1 == "#zone" || %w1 == "#z") {
			if (%cropped == "") return;
			for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl)) {
				if (!%cl.muted[%TrueClientId] && %cl != %TrueClientId && fetchData(%cl, "zone") == fetchData(%TrueClientId, "zone"))
			      		rpg::sendMessage(%cl, $MsgHudGreen, "[Z] " @ %TCsenderName @ ": " @ %cropped,true);
			}
			rpg::sendMessage(%TrueClientId, $MsgHudGreen, "[Z] " @ %cropped,true);
			return;
	      	}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#say" || %w1 == "#s") {
			for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl)) {
				%talkingPos = GameBase::getPosition(%TrueClientId);
				%receivingPos = GameBase::getPosition(%cl);
				%distVec = Vector::getDistance(%talkingPos, %receivingPos);
				if (%distVec <= $maxSAYdistVec) {
					%newmsg = %cropped;
					if(!%cl.muted[%TrueClientId] && %cl != %TrueClientId)
						Client::sendMessage(%cl, $MsgWhite, %TCsenderName @ " says, \"" @ %newmsg @ "\"");
									
				}
			}
			Client::sendMessage(%TrueClientId, $MsgWhite, "You say, \"" @ %cropped @ "\"");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#tell") {
			if (%cropped == "")
				Client::sendMessage(%TrueClientId, 0, "syntax: #tell whoever, message");
			else {
				%pos1 = 0;
				%pos2 = String::findSubStr(%cropped, ",");
				%name = String::getSubStr(%cropped, %pos1, %pos2-%pos1);
				%final = String::getSubStr(%cropped, %pos2 + 2, String::len(%cropped)-%pos2-2);
				%cl = NEWgetClientByName(%name);
				if (%cl != -1) {
					%n = Client::getName(%cl);
					if (!%cl.muted[%TrueClientId]) {
						Client::sendMessage(%cl, $MsgBeige, %TCsenderName @ " tells you, \"" @ %final @ "\"");
						if (%cl != %TrueClientId)
							Client::sendMessage(%TrueClientId, $MsgBeige, "You tell " @ %n @ ", \"" @ %final @ "\"");
						%cl.replyTo = %TCsenderName; 
					}
					else
						Client::sendMessage(%TrueClientId, $MsgRed, %n @ " has muted you.");
				}
				else
					Client::sendMessage(%TrueClientId, $MsgWhite, "Invalid player name.");
			}
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#r") {
			if (%cropped == "")
				Client::sendMessage(%TrueClientId, 0, "syntax: #r message");
			else {
				%name = %TrueClientId.replyTo;
				if(%name != "") {
					%cl = NEWgetClientByName(%name);
					if (%cl != -1) {
						if (!%cl.muted[%TrueClientId]) {
							Client::sendMessage(%cl, $MsgBeige, %TCsenderName @ " tells you, \"" @ %cropped @ "\"");
							if (%cl != %TrueClientId)
								Client::sendMessage(%TrueClientId, $MsgBeige, "You tell " @ %name @ ", \"" @ %cropped @ "\"");
							%cl.replyTo = %TCsenderName;
						}
					}
					else
						Client::sendMessage(%TrueClientId, $MsgWhite, "Invalid player name.");
				}
				else
					Client::sendMessage(%TrueClientId, $MsgWhite, "You haven't received a #tell to reply to yet.");
			}
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#group") {
			for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl)) {
				if(!%cl.muted[%TrueClientId] && %cl != %TrueClientId && IsInCommaList(fetchData(%TrueClientId, "grouplist"), Client::getName(%cl))) {
					if(IsInCommaList(fetchData(%cl, "grouplist"), %TCsenderName))
						Client::sendMessage(%cl, $MsgBeige, "[GRP] " @ %TCsenderName @ " \"" @ %cropped @ "\"");
					else
						Client::sendMessage(%TrueClientId, $MsgRed, Client::getName(%cl) @ " does not have you on his/her group-list.");
				}
			}
			Client::sendMessage(%TrueClientId, $MsgBeige, "[GRP] \"" @ %cropped @ "\"");
			return;
		}
		//==========================================================================================================================
		// DEAD CHECK
		if (IsDead(%TrueClientId) && %clientToServerAdminLevel < 1)
			return;
		//==========================================================================================================================
		if (%w1 == "#fav" || %w1 == "#favorites") {
			Game::MenuFavList(%TrueClientId);
			return;
		}
		if (%w1 == "#addfav") {
			if (%cropped == "")
				Client::sendMessage(%TrueClientId, 0, "Syntax: #addfav spell");
			else
				AddToFavList(%TrueClientId,%cropped);
			return;
		}
		if (%w1 == "#rfav" || %w1 == "#removefavorites") {
			Game::MenuRemoveFavList(%TrueClientId);
			return;
		} 
		//==========================================================================================================================
		if (%w1 == "#setql") {
			%action = GetWord(%message,1);
			if (IsNumeric(%action))
				SC::SetQL(%TrueClientId,%action);
			return;
		}
		//==========================================================================================================================
		if (%w1 == "#salvageall") {
			SalvageAll(%TrueClientId);
			return;
		}
		//==========================================================================================================================
		if (%w1 == "#sellall") {
			if (BackpackMerchantArea(%TrueClientId) != false)
				SellAll(%TrueClientId);
			else
				Client::SendMessage(%TrueClientId,0,"You are not near a merchant.");
			return;
		}
		//==========================================================================================================================
		if (%w1 == "#nosale") {
			Game::MenuNoSale(%TrueClientId);
			return;
		}	
		if (%w1 == "#clearnosale") {
			$PlayerNoSale[%TrueClientId] = "";
			Client::SendMessage(%TrueClientId,0,"You have cleared your no sale list.");
			return;
		}
		//==========================================================================================================================
		if (%w1 == "#bash") {
			SetupWeaponSpecial(%TrueClientId,"bashing");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#aim") {
			SetupWeaponSpecial(%TrueClientId,"aiming");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#cleave") {
			SetupWeaponSpecial(%TrueClientId,"cleave");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#brawl") {
			Brawl(%TrueClientId);
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#taunt") {
			DoTaunt(%TrueClientId);
			return;
		}
		if (%w1 == "#mongo") {
			AOETaunt(%TrueClientId);
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#merchant" || %w1 == "#merchants" || %w1 == "#restock") {
			%time = 3600 - $TICKER[RESTOCK];
			%time = CruTimeFormat(%time);
			Client::SendMessage(%TrueClientId,2,"Merchants restock their shops in " @ %time);
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#pet") {
			%action = GetWord(%message,1);
			if (%action == "follow" || %action == "attack" || %action == "wait" || %action == "hunt")
				CruAiSetMode(%TrueClientId,%action);
			else if (%action == "kill" || %action == "terminate")
				CruAiDisconnectKill(%TrueClientId);
			else if (%action == "help")
				Client::SendMessage(%TrueClientId,0,"Pet commands: follow, attack, hunt, guard, terminate/kill. (Example #pet follow)");
			else {
				Client::SendMessage(%TrueClientId,0,"Pet command not recognized.");
				return;	
			}
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#focus" || %w1 == "#mem" || %w1 == "#m" || %w1 == "#memory") {
			Game::MenuFocus(%TrueClientId,0);
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#up" || %w1 == "#updatepassives") {
			if ($PassiveChange[%TrueClientId]) {
				UpdatePassives(%TrueClientId);
				return;
			}
			else {
				Client::SendMessage(%TrueClientId,0,"Your passives have not changed recently.");
				return;
			}
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#gear" || %w1 == "#wear")
			Game::MenuWear(%TrueClientId);
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#action" || %w1 == "#a") {
			%action = GetWord(%message,1);
			if (%action == -1) {
				Client::SendMessage(%TrueClientId,0,"You must specify an action.");
				return;
			}
			if ($CruAction[%action,$CAName] != "")
				InitUseAction(%TrueClientId,%action);
			else
				Client::SendMessage(%TrueClientId,0,"Unknown action: " @ %action);
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#bind" || %w1 == "#set") {
			%key = getWord(%message,1);
			%v = getWord(%message,2);
			%x = getWord(%message,3);
			if (string::FindSubStr($BindList,%key) == -1) {
				Client::SendMessage(%TrueClientId,1,%key @ " is not a supported bind key.");
				return;
			}
			%type = False;
			if (%v == "cast" || %v == "#cast") %type = "CAST";
			if (%v == "#meditate" || %v == "#wake") %type = "MEDWAKE";
			if (%v == "#bash" || %v == "#aim" || %v == "#cleave" || %v == "#brawl") %type = "SPECIAL";
			if (%v == "#hide") %type = "HIDE";
			if (%v == "#taunt") %type = "TAUNT";
			if (%v == "#mongo") %type = "MONGO";
			if (%v == "#gear" || %v == "#wear") %type = "GEAR";
			if (%v == "#pet") %type = "PET";
			if (%v == "#fav" || %v == "#favorites") %type = "FAV";
			if (%v == "#salvageall") %type = "SALVAGE";
			if (%type == False) {
				Client::SendMessage(%TrueClientId,1,"Invalid request: use #bind (key) (#cast/#action) (name)");
				return;
			}
			if (%type == "CAST") {
				if ($CruSpell[%x,$CSName] == "") {
					Client::SendMessage(%TrueClientId,1,"Attempt to bind spell failed (unknown spell): " @ %x);
					return;
				}
				$numMessage[%TrueClientId,%key] = "CAST " @ %x;
				Client::SendMessage(%TrueClientId,0,"Spell " @ $CruSpell[%x,$CSName] @ " successfully bound to: " @ %key);
			}
			if (%type == "MEDWAKE") {
				$numMessage[%TrueClientId,%key] = %v;
				Client::SendMessage(%TrueClientId,0,%v @ " successfully bound to: " @ %key);
			}
			if (%type == "SPECIAL") {
				$numMessage[%TrueClientId,%key] = %v;
				Client::SendMessage(%TrueClientId,0,%v @ " successfully bound to: " @ %key);
			}
			if (%type == "HIDE") {
				$numMessage[%TrueClientId,%key] = %v;
				Client::SendMessage(%TrueClientId,0,%v @ " successfully bound to: " @ %key);
			}
			if (%type == "TAUNT") {
				$numMessage[%TrueClientId,%key] = %v;
				Client::SendMessage(%TrueClientId,0,%v @ " successfully bound to: " @ %key);
			}
			if (%type == "MONGO") {
				$numMessage[%TrueClientId,%key] = %v;
				Client::SendMessage(%TrueClientId,0,%v @ " successfully bound to: " @ %key);
			}
			if (%type == "GEAR") {
				$numMessage[%TrueClientId,%key] = %v;
				Client::SendMessage(%TrueClientId,0,%v @ " successfully bound to: " @ %key);
			}
			if (%type == "FAV") {
				%v = "#fav";
				$numMessage[%TrueClientId,%key] = %v;
				Client::SendMessage(%TrueClientId,0,%v @ " successfully bound to: " @ %key);
			}
			if (%type == "PET") {
				$numMessage[%TrueClientId,%key] = %v @ " " @ %x;
				Client::SendMessage(%TrueClientId,0,%v @ " " @ %x @ " successfully bound to: " @ %key);
			}
			if (%type == "SALVAGE") {
				%v = "#salvageall";
				$numMessage[%TrueClientId,%key] = %v;
				Client::SendMessage(%TrueClientId,0,%v @ " successfully bound to: " @ %key);
			}
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#quest") {
			Game::menuQuest(%TrueClientId,0);
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#steal") {
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#savecharacter") {
			if (%clientToServerAdminLevel >= 4) {
	                  	if(%cropped == "") {
	                        	%r = SaveCharacter(%TrueClientId);
	                        	Client::sendMessage(%TrueClientId, 0, "Saving self (" @ %TrueClientId @ "): success = " @ %r);
	                  	}
	                  	else {
					%id = NEWgetClientByName(%cropped);
					if (%id) {
						%r = SaveCharacter(%id);
						Client::sendMessage(%TrueClientId, 0, "Saving " @ Client::getName(%id) @ " (" @ %id @ "): success = " @ %r);
					}
	                        	else
	                              		Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
				}
			}
			else {
				if($recentsave[%TrueClientId]){
					//rpg::sendMessage(%TrueClientId, 0, "Your character was already just saved!");
					return;
				}
				$recentsave[%TrueClientId] = True;
				schedule("$recentsave["@%TrueClientId@"]=\"\";",10);
				//%time = getIntegerTime(true) >> 5;
				//if (%time - %TrueClientId.lastSaveCharTime > 10) {
				//	%TrueClientId.lastSaveCharTime = %time;
		                  	%r = SaveCharacter(%TrueClientId);
					Client::sendMessage(%TrueClientId, 0, "Saving self (" @ %TrueClientId @ "): success = " @ %r);
				//}
			}
			return;
	      	}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#dropcoins") {
			%cropped = GetWord(%cropped, 0);
	            	if (%cropped == "all")
	                  	%cropped = fetchData(%TrueClientId, "COINS");
	            	else
	                  	%cropped = floor(%cropped);
	
	            	if (fetchData(%TrueClientId, "COINS") >= %cropped || %clientToServerAdminLevel >= 4) {
				if(%cropped > 0) {
	                        	if (!(%clientToServerAdminLevel >= 4))
						storeData(%TrueClientId, "COINS", %cropped, "dec");
					%toss = GetTypicalTossStrength(%TrueClientId);
	                       	 	TossLootbag(%TrueClientId, "COINS " @ %cropped, %toss, "*", 0);
					//RefreshAll(%TrueClientId);
	                        	Client::sendMessage(%TrueClientId, 0, "You dropped " @ %cropped @ " coins.");
	                        	playSound(SoundMoney1, GameBase::getPosition(%TrueClientId));
				}
			}
	            	else
				Client::sendMessage(%TrueClientId, 0, "You don't even have that many coins!");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#w") {
			%item = getCroppedItem(%cropped);
			%skill = getWord(%message,1);
			if ($dependmsg[%skill,0] != "") {
				%msg = WhatIsDepend(%clientId,%skill);
				sendbufferbp(%TrueClientId, %msg, floor(String::len(%msg) / 10));
				return;
			}
			%spell = GetWord(%message,1);
			if ($CruSpell[%spell,$CSName] != "") {
				WhatIsCruSpell(%TrueClientId,%spell);
				return;
			}
			%action = GetWord(%message,1);
			if ($CruAction[%action,$CAName] != "") {
				WhatIsCruAction(%TrueClientId,%action);
				return;
			}
			%dot = GetWord(%message,1);
			if ($CruDOT[%dot,$CDOTInterval] != "") {
				%msg = "";
				%msg = %msg @ "<f0>" @ %dot @ "<f1>\n";
				%msg = %msg @ "Interval: " @ $CruDOT[%dot,$CDOTInterval] @ "\n";
				%msg = %msg @ "Hits: " @ $CruDOT[%dot,$CDOTHits] @ "\n";
				%msg = %msg @ "Bonus: " @ $CruDOT[%dot,$CDOTBonus];
				sendbufferbp(%TrueClientId, %msg, floor(String::len(%msg) / 20));
				return;
			}
			if ((%ql = getWord(%message,2)) != -1) {
				if (%ql < 100)
					%ql = "0" @ %ql;
				if (%ql < 10)
					%ql = "0" @ %ql;
				DynamicItem::CheckItemCreate(getWord(%message,1),%ql);
				%msg = WhatIs(%ql @ "" @ getWord(%message,1));
				sendbufferbp(%TrueClientId, %msg, floor(String::len(%msg) / 15));
				return;
			}
			else {
				%checkspecial = getWord(%message,1);
				if ($DynamicItem[%checkspecial,$DMinMax] == "999 999") {
					%ql = "999";
					DynamicItem::CheckItemCreate(getWord(%message,1),%ql);
					%msg = WhatIs(%ql @ "" @ getWord(%message,1));
					sendbufferbp(%TrueClientId, %msg, floor(String::len(%msg) / 15));
					return;
				}
				else {
					%ql = "001";
					DynamicItem::CheckItemCreate(getWord(%message,1),%ql);
					%msg = WhatIs(%ql @ "" @ getWord(%message,1));
					sendbufferbp(%TrueClientId, %msg, floor(String::len(%msg) / 15));
					return;
				}
			}
	            	if (%item == "")
				Client::sendMessage(%TrueClientId, 0, "Please specify an item (ex: Black Statue = BlackStatue).");
	            	else {
				%msg = WhatIs(%item);
				bottomprint(%TrueClientId, %msg, floor(String::len(%msg) / 20));
			}
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#spell" || %w1 == "#cast") {
			%spell = getWord(%message,1);
			if ($CruSpell[%spell,$CSName] != "") {
				if (%TrueClientId.sleepMode != "" && %TrueClientId.sleepMode != False) {
					Client::sendMessage(%TrueClientId, $MsgRed, "You can not cast a spell while sleeping or meditating.");
					return;
				}
				CastCruSpell(%TrueClientId,%spell);
				// UpdateHotbar(%TrueClientId);
				return;
			}	
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#recall") {
			%zvel = floor(getWord(Item::getVelocity(%TrueClientId), 2));
			Client::sendMessage(%TrueClientId, $MsgRed, "ATTEMPTING RECALL");
			if(%zvel <= -350 || %zvel >= 350) {
				FellOffMap(%TrueClientId);
				CheckAndBootFromArena(%TrueClientId);
				%zv = "PASS";
			}
			else
				%zv = "FAIL";
			Client::sendMessage(%TrueClientId, $MsgBeige, "Z-Velocity check: " @ %zv);
			if (%zv != "PASS" && !fetchData(%TrueClientId, "tmprecall")) {
				%seconds = $recallDelay;
				storeData(%TrueClientId, "tmprecall", True);
				Client::sendMessage(%TrueClientId, $MsgBeige, "Stay at your current position for the next " @ %seconds @ " seconds to recall.");
				schedule("storeData(" @ %TrueClientId @ ", \"tmprecall\", \"\");if(Vector::getDistance(\"" @ GameBase::getPosition(%TrueClientId) @ "\", GameBase::getPosition(" @ %TrueClientId @ ")) <= 1){FellOffMap(" @ %TrueClientId @ ");CheckAndBootFromArena(" @ %TrueClientId @ ");}", %seconds);
			}
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#mypassword") {
			%c1 = GetWord(%cropped, 0);
	            	if (%c1 != -1) {
				storeData(%TrueClientId, "password", %c1);
				Client::sendMessage(%TrueClientId, 0, "Changed personal password to " @ fetchData(%TrueClientId, "password") @ ".");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify a one-word password.");
	
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#sleep") {
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#meditate") {
			if(%TrueClientId.sleepMode == "" && !IsDead(%TrueClientId) && $possessedBy[%TrueClientId].possessId != %TrueClientId) {
				if ($InCombat[%TrueClientId] > 0) {
					Client::SendMessage(%TrueClientId,2,"You cant meditate while in combat!");
					return;
				}
				%TrueClientId.sleepMode = 2;
				Client::setControlObject(%TrueClientId, Client::getObserverCamera(%TrueClientId));
				Observer::setOrbitObject(%TrueClientId, Client::getOwnedObject(%TrueClientId), 30, 30, 30);
				Player::SetAnimation(%trueClientId,48);
				refreshHPREGEN(%TrueClientId);
				refreshMANAREGEN(%TrueClientId);
				Client::sendMessage(%TrueClientId, $MsgWhite, "You begin to meditate.  Use #wake to stop meditating.");
			}
			else
				Client::sendMessage(%TrueClientId, $MsgRed, "You can't seem to meditate.");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#wake") {
			if (%TrueClientId.TowerPause != "")
				return;
			if (%TrueClientId.sleepMode != "") {
				%TrueClientId.sleepMode = "";
				Client::setControlObject(%TrueClientId, %TrueClientId);
				refreshHPREGEN(%TrueClientId);
				refreshMANAREGEN(%TrueClientId);
				Client::sendMessage(%TrueClientId, $MsgWhite, "You awake.");
			}
			else
				Client::sendMessage(%TrueClientId, $MsgRed, "You are not sleeping or meditating.");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#hide") {
			if (fetchData(%TrueClientId, "invisible") == True) {
				Client::SendMessage(%TrueClientId,2,"You are no longer hiding..");
				UnHide(%TrueClientId);
				return;
			}
			if (BPSkillUnlocked(%TrueClientId,"hiding")) {
				if ($InCombat[%TrueClientId] > 0) {
					Client::SendMessage(%TrueClientId,2,"You cant hide while in combat!");
					return;
				}
				Client::SendMessage(%TrueClientId,2,"You hide in the shadows..");
				%locktime = 20;
				BPLockSkill(%TrueClientId,"hiding",%locktime,-1);
				GameBase::startFadeOut(%TrueClientId);
				storeData(%TrueClientId, "invisible", True);
				//schedule("Unhide("@%TrueClientId@");",5);
			}
			else
				BPDisplaySkillLockTime(%TrueClientId,"hiding");
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#defaulttalk") {
			if(%cropped != "") {
				storeData(%TrueClientId, "defaultTalk", %cropped);
				Client::sendMessage(%TrueClientId, 0, "Changed Default Talk to " @ fetchData(%TrueClientId, "defaultTalk") @ ".");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify what will be added to the beginning of each of your messages.");
			return;
	      	}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#admin") {
			for (%i = 1; %i <= 8; %i++) {
				if(%cropped == $AdminPassword[%i] && $AdminPassword[%i] != "") {
					%TrueClientId.adminLevel = %i;
					if (%TrueClientId.adminLevel >= 4)
						ChangeRace(%TrueClientId, "DeathKnight");
					Game::refreshClientScore(%TrueClientId);		
					Client::sendMessage(%TrueClientId, 0, "Password accepted for Admin Clearance Level " @ %TrueClientId.adminLevel @ ".");
					break;
				}
			}
			return;
		}
		//------------------------------------------------------------------------------------------------------------------
		if (%w1 == "#human") {
			if (%clientToServerAdminLevel >= 4)
				ChangeRace(%TrueClientId, "Human");
			return;
		}
		//==========================================================================================================================
		if (%clientToServerAdminLevel >= 1)
			CrucibleAdmin(%TrueClientId,%message);
		//==========================================================================================================================	
	}
	return;
}

function CrucibleAdmin(%TrueClientId,%message)
{
	//==========================================================================================================================
	%w1 = GetWord(%message,0);
	%w2 = GetWord(%message,1);
	%cropped = String::NEWgetSubStr(%message, (String::len(%w1)+1), 99999);
	%clientToServerAdminLevel = floor(%TrueClientId.adminLevel);
	%TCsenderName = Client::getName(%TrueClientId);
	%senderName = "INTERNAL";
	//==========================================================================================================================
	if (%w1 == "#restart") {
		if (%clientToServerAdminLevel >= 5) {
			if (%w2 == -1)
				%w2 = 10;
			MessageAll(2,"Restarting server in " @ %w2 @ " seconds.");
			schedule("quit();",%w2);
		}
		return;			
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#kill") {
		if (%clientToServerAdminLevel >= 2) {
			if (%cropped == "") {
				Client::sendMessage(%TrueClientId, 0, "Please specify player name.");
				return;
			}
			else
				%target = NEWgetClientByName(%cropped);
			%id = %TrueClientId;
			%val = 1000000;
			ManualAddDamagedList(%id,%target,%val);
			Client::SendMessage(%id,0,"You killed " @ Client::GetName(%target) @ "!");
			if ((%zone = $CRUSPAWNZONE[%target]) != "") {
				%spawn = $CRUSPAWNID[%target];
				$CRUSPAWNZONE[%target] = "";
				$CRUSPAWNID[%target] = "";
				%monstername = $CRUMONSTERNAME[%target];
				$CRUMONSTER[%monstername,$CENameOn]--;
				$CRUMONSTERNAME[%target] = "";
				schedule("DecreaseZoneActive("@%target@","@%zone@","@%spawn@");",10);
			}
			ActionKilled(%id,%target,99,%explode);
			$TargetCur[%id,0] = "";
			Targeting::Hud(%id,1);
		}
		return;		
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#getskill") {
		if (%clientToServerAdminLevel >= 2) {
			%name = GetWord(%cropped, 0);
	                %id = NEWgetClientByName(%name);
			if (%id != -1) {
				%sid = GetWord(%cropped, 1);
				if ($SkillDesc[%sid] != "")
					Client::sendMessage(%TrueClientId, 0, %name @ " (" @ %id @ ") " @ $SkillDesc[%sid] @ " is " @ $PlayerSkill[%id, %sid]);
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#resetskills") {
			if (%clientToServerAdminLevel >= 2) {
			%name = GetWord(%cropped, 0);
	                %id = NEWgetClientByName(%name);
			if (%id != -1) {
				for (%si = 1; %si <= 51; %si++) {
					$PlayerSkill[%id,%si] = 1;
				}
				%lvl = fetchData(%id,"LVL");
				%sp = %lvl * 80;
				%sp -= 10;
				storeData(%id, "SPcredits", %sp);
				Client::SendMessage(%TrueClientId,0,"Player skills RESET " @ %name @ " " @ %lvl @ " " @ %sp);
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#resetpassives") {
			if (%clientToServerAdminLevel >= 2) {
			%name = GetWord(%cropped, 0);
	                %id = NEWgetClientByName(%name);
			if (%id != -1) {
				ResetPassives(%id);
				Client::SendMessage(%TrueClientId,0,"Player passives RESET " @ %name);
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#setskill") {
		if (%clientToServerAdminLevel >= 2) {
			%name = GetWord(%cropped, 0);
	                %id = NEWgetClientByName(%name);
			if (%id != -1) {
				%sid = GetWord(%cropped, 1);
				%set = GetWord(%cropped, 2);
				if ($SkillDesc[%sid] != "")
					Client::SendMessage(%TrueClientId,0,"Setting Skill: " @ %name @ " " @ $SkillDesc[%sid] @ " " @ %set);
					$PlayerSkill[%id, %sid] = %set;
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#clearbackpack") {
		if (%clientToServerAdminLevel >= 1) {
			$PlayerBackpack[%TrueClientId] = "";
			Client::sendMessage(%TrueClientId, 0, "Backpack cleared.");
		}
		return;			
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#deadmin") {
		if (%clientToServerAdminLevel >= 1) {
			%TrueClientId.adminLevel = 0;
			Client::sendMessage(%TrueClientId, 0, "You have removed your admin status.");
		}
		return;			
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#displaymerchant") {
		if (%clientToServerAdminLevel >= 2) {
			DisplayMerchantMsg(%TrueClientId,%cropped);
		}
		return;			
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#restockshops") {
		if (%clientToServerAdminLevel >= 2) {
			RestockMerchants();
		}
		return;			
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#pr") {
		if (%clientToServerAdminLevel >= 2) {
			%pos = GameBase::getPosition(2049);
			%rot = GetWord(GameBase::getRotation(2049),2);
			Client::SendMessage(%TrueClientId,0,"PR " @ %pos @ " " @ %rot);
		}
		return;			
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#teleport") {
		if (%clientToServerAdminLevel >= 2) {
			if (%cropped == "")
				Client::sendMessage(%TrueClientId, 0, "Please specify player name.");
			else {
	                        %id = NEWgetClientByName(%cropped);
				if (floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
	                             	 %player = Client::getOwnedObject(%TrueClientId);
	                              	GameBase::getLOSinfo(%player, 50000);
	                              	GameBase::setPosition(%id, $los::position);
					Client::sendMessage(%TrueClientId, 0, "Teleporting " @ %cropped @ " (" @ %id @ ") to " @ $los::position @ ".");
				}
	                        else
	                              Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#teleport2") {
		if (%clientToServerAdminLevel >= 2) {
			%c1 = GetWord(%cropped, 0);
			%c2 = GetWord(%cropped, 1);
			if (%c1 != -1 && %c2 != -1) {
				%id1 = NEWgetClientByName(%c1);
	                        %id2 = NEWgetClientByName(%c2);
				if (floor(%id1.adminLevel) > floor(%clientToServerAdminLevel) && %id1 != %TrueClientId)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
	                        else if (%id1 != -1 && %id2 != -1) {
					Client::sendMessage(%TrueClientId, 0, "Teleporting " @ %c1 @ " (" @ %id1 @ ") to " @ %c2 @ " (" @ %id2 @ ").");
	                              	GameBase::setPosition(%id1, GameBase::getPosition(%id2));
	                        }
	                        else
	                              Client::sendMessage(%TrueClientId, 0, "Invalid player name(s).");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name & data.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#fell") {
		if (%clientToServerAdminLevel >= 2) {
			if (%cropped == "")
				Client::sendMessage(%TrueClientId, 0, "Please specify player name.");
			else {
				%id = NEWgetClientByName(%cropped);
				if(floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
					Client::sendMessage(%TrueClientId, 0, "Processing fell-off-map for " @ %cropped @ " (" @ %id @ ")");
					FellOffMap(%id);
				}
	                        else
	                              	Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#setlvl") {
		if (%clientToServerAdminLevel >= 5) {
			%c2 = Cap(GetWord(%cropped,1),1,230);
			%name = GetWord(%cropped,0);
			%id = NEWgetClientByName(%name);
			if (floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
				Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
			else if (%id != -1) {
	            StoreData(%id,"LVL",%c2);
				StoreData(%id,"EXP",0);
	            Client::sendMessage(%TrueClientId, 0, "Setting " @ Client::GetName(%id) @ " to Level: " @ %c2);
				refreshAll(%id);
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#addexp") {
		if (%clientToServerAdminLevel >= 5) {
			%c2 = Cap(GetWord(%cropped,1),0,999999);
			%name = GetWord(%cropped,0);
			%id = NEWgetClientByName(%name);
			if (floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
				Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
			else if (%id != -1) {
				%lvl = fetchData(%id,"LVL");
				if (%lvl < 230)
					storeData(%id,"EXP",%c2,"inc");
				else
					storeData(%id,"AEXP",%c2,"inc");
	            Client::sendMessage(%TrueClientId, 0, "Adding " @ %c2 @ " EXP to " @ Client::GetName(%id));
				refreshAll(%id);
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#addsp" || %w1 == "#setsp") {
		if (%clientToServerAdminLevel >= 5) {
			%c1 = GetWord(%cropped, 0);
			%c2 = GetWord(%cropped, 1);
			if (%c1 != -1 && %c2 != -1) {
	                        %id = NEWgetClientByName(%c1);
				if (floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
					if (%w1 == "#addsp") {
						storeData(%id, "SPcredits", %c2, "inc");
						Client::sendMessage(%TrueClientId, 0, "Setting " @ %c1 @ " (" @ %id @ ") SP credits to " @ fetchData(%id, "SPcredits") @ ".");
					}
					if (%w1 == "#setsp") {
						storeData(%id, "SPcredits", %c2);
						Client::sendMessage(%TrueClientId, 0, "Setting " @ %c1 @ " (" @ %id @ ") SP credits to " @ fetchData(%id, "SPcredits") @ ".");
					}
	                              	RefreshAll(%id);
	                        }
	                        else
	                              Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name & data.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#sethp") {
		if (%clientToServerAdminLevel >= 5) {
			%c1 = GetWord(%cropped, 0);
			%c2 = GetWord(%cropped, 1);
			if (%c1 != -1 && %c2 != -1) {
				%id = NEWgetClientByName(%c1);
				if (floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
					%max = fetchData(%id, "MaxHP");
					if (%c2 < 1)
						%c2 = 1;
					else if (%c2 > %max)
						%c2 = %max;
					setHP(%id, %c2);
					Client::sendMessage(%TrueClientId, 0, "Setting " @ %c1 @ " (" @ %id @ ") HP to " @ fetchData(%id, "HP") @ ".");
	                        }
	                        else
	                              Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name & data.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#setmana") {
		if (%clientToServerAdminLevel >= 5) {
			%c1 = GetWord(%cropped, 0);
			%c2 = GetWord(%cropped, 1);
			if (%c1 != -1 && %c2 != -1) {
				%id = NEWgetClientByName(%c1);
				if(floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
					%max = fetchData(%id, "MaxMANA");
					if(%c2 < 0)
						%c2 = 0;
	                              	else if(%c2 > %max)
	                                    	%c2 = %max;
	                              	setMANA(%id, %c2);
					Client::sendMessage(%TrueClientId, 0, "Setting " @ %c1 @ " (" @ %id @ ") MANA to " @ fetchData(%id, "MANA") @ ".");
	                        }
				else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name & data.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#addcoins") {
		if (%clientToServerAdminLevel >= 5) {
	                  %c1 = GetWord(%cropped, 0);
	                  %c2 = GetWord(%cropped, 1);
	                  if(%c1 != -1 && %c2 != -1) {
				%id = NEWgetClientByName(%c1);
				if(floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
					storeData(%id, "COINS", %c2, "inc");
					RefreshAll(%id);
					Client::sendMessage(%TrueClientId, 0, "Setting " @ %c1 @ " (" @ %id @ ") COINS to " @ fetchData(%id, "COINS") @ ".");
	                        }
	                        else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
	                  }
	                  else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name & data.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#setteam") {
		if (%clientToServerAdminLevel >= 5) {
			%c1 = GetWord(%cropped, 0);
			%c2 = GetWord(%cropped, 1);
			if (%c1 != -1 && %c2 != -1) {
				%id = NEWgetClientByName(%c1);
				if(floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
					GameBase::setTeam(%id, %c2);
					RefreshAll(%id);
					Client::sendMessage(%TrueClientId, 0, "Setting " @ %c1 @ " (" @ %id @ ") team to " @ GameBase::getTeam(%id) @ ".");
	                        }
	                        else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name & data.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#tt") {
		if (%clientToServerAdminLevel >= 5) {
			%c1 = GetWord(%cropped, 0);
			%c2 = GetWord(%cropped, 1);
			%c3 = GetWord(%cropped, 2);
			%id = NEWgetClientByName(%c1);
			if (%c1 != -1 && %c2 != -1 && %c3 != -1) {
				%id = NEWgetClientByName(%c1);
				if(floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
					TT(%c2,%c3,0,%id);
					client::SendMessage(%TrueClientId,2,%id @ " " @ %c2 @ " " @ %c3);
				}
				else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");	
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name & data.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#givepassive") {
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#getip") {
		if (%clientToServerAdminLevel >= 2) {
			if (%cropped != "") {
				%id = NEWgetClientByName(%cropped);
				if (floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1)
					Client::sendMessage(%TrueClientId, 0, %cropped @ " (" @ %id @ ") IP is " @ Client::getTransportAddress(%id));
	                        else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#gethp") {
		if (%clientToServerAdminLevel >= 1) {
			if (%cropped != "") {
				%id = NEWgetClientByName(%cropped);
				if (floor(%id.adminLevel) >= floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1)
					Client::sendMessage(%TrueClientId, 0, %cropped @ " (" @ %id @ ") HP is " @ fetchData(%id, "HP") @ ".");
				else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#getmana") {
		if (%clientToServerAdminLevel >= 1) {
			if (%cropped != "") {
				%id = NEWgetClientByName(%cropped);
				if (floor(%id.adminLevel) >= floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1)
					Client::sendMessage(%TrueClientId, 0, %cropped @ " (" @ %id @ ") MANA is " @ fetchData(%id, "MANA") @ ".");
				else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#getbonus" || %w1 == "#gb") {
		if (%clientToServerAdminLevel >= 2) {
			if (%cropped != "") {
				%c1 = getWord(%cropped,0);
				%c2 = getWord(%cropped,1);
				%id = NEWgetClientByName(%c1);
				if (%c2 == -1) {
					Client::sendMessage(%TrueClientId, 0, "Select a bonus to display.");
					return;
				}
				if (%id != -1) {
					%bonus = $BPBonusToNumeric[%c2];
					if (%bonus == "")
						 Client::SendMessage(%trueClientId,0,"Unknown bonus state: " @ %c2);
					else {
						%disp = GetBonus(%id,%bonus);
						%format = $BPFormat[%c2];
						Client::sendMessage(%TrueClientId, 0, %c1 @ " (" @ %id @ ") bonus <" @ %format @ "> is " @ %disp @ ".");
					}

				}
				else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	if (%w1 == "#jail") {
		if (%clientToServerAdminLevel >= 2) {
			%c1 = GetWord(%cropped, 0);
			%c2 = GetWord(%cropped, 1);
			%c3 = GetWord(%cropped, 2);
			if (%c1 != -1) {
				%id = NEWgetClientByName(%c1);
				if (floor(%id.adminLevel) > floor(%clientToServerAdminLevel) && Client::getName(%id) != %senderName)
					Client::sendMessage(%TrueClientId, 0, "Could not process command: Target admin clearance level too high.");
				else if (%id != -1) {
					%c1 = Client::getName(%id);
					if (%c2 == -1)
						%c2 = 300;
					if (%c3 == -1)
						%c3 = GetRandomJailNumber();
					%pos = GetPositionForJailNumber(%c3);
					if(%pos != -1) {
						Jail(%id, %c2, %c3);
						Client::sendMessage(%TrueClientId, 0, %c1 @ " has been jailed for " @ %c2 @ " seconds in Jail #" @ %c3 @ ".");
					}
					else
						Client::sendMessage(%TrueClientId, 0, "Invalid jail number.");
				}
	                        else
					Client::sendMessage(%TrueClientId, 0, "Invalid player name.");
			}
			else
				Client::sendMessage(%TrueClientId, 0, "Please specify player name, time, and jail number.");
		}
		return;
	}
	//------------------------------------------------------------------------------------------------------------------
	return;
}

function WorldMessage(%TCSenderName,%cropped)
{
	for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
		rpg::sendMessage(%cl, $MsgHudGreen, "[G] " @ %TCsenderName @ ": " @ %cropped,true);
}

function ircChat(%TCSenderName,%cropped)
{
	for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
		rpg::sendMessage(%cl, $MsgHudOrange, "[IRC] " @ %TCsenderName @ ": " @ %cropped,true);	
}

function messageAll(%mtype, %message, %filter)
{
	dbecho($dbechoMode, "messageAll(" @ %mtype @ ", " @ %message @ ", " @ %filter @ ")");

	if(%filter == "")
		for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
			Client::sendMessage(%cl, %mtype, %message);
	else
	{
		for(%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
		{
			if(%cl.messageFilter & %filter)
			Client::sendMessage(%cl, %mtype, %message);
		}
	}
}

