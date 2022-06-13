exec("comchat-translate.cs");

// NON DED
//$CURRENTCRUMAP = "JUNGLE";

function ClearPlayerNPC(%id)
{
	%id.NPCTalking = "";
	%id.NPCLocation = "";
	%id.NPCSub = -1;
	%id.NPCDeposit = "";
	%id.NPCWithdraw = "";
	%id.CantDrop = "";
	%id.CantCancelQuest = "";
}

function CheckNPCZone(%id)
{
	%z = fetchData(%id,"zone");
	%l = GameBase::getPosition(Client::getOwnedObject(%id));
	%closest = "";
	if ((%c = $NPCCHECK[%z]) != "") {
		for (%i = 0; (%m = getWord(%c,%i)) != -1; %i++) {
			%s = $NPC[%m,LOCATION];
			%dist = Vector::getDistance(%l,%s);
			if (%dist < 10) {
				if (%closest == "")
					%closest = %m;
				else {
					if (%dist < %closest)
						%closest = %m;
				}
			}
		}
	}
	if (%closest != "")
		NPCTalk(%id,%closest);
}

function NPCTalk(%id,%npc,%sub)
{
	echo(" NPC TALK " @ %id @ " " @ %npc @ " " @ %sub);
	%r = -1;
	%foundr = -1;
	%id.NPCTalking = %npc;
	%id.NPCLocation = $NPC[%npc,LOCATION];
	%id.CantDrop = 1;
	%id.CantCancelQuest = 1;
	%msg = %msg @ $NPC[%npc,NAME] @ "\n<jc>";
	if (%sub == "") {
		for (%i = 0; (%n = $NPC[%npc,%i,NEED]) != ""; %i++) {
			if (%n == "NA")
				%r = %i;
			if (%n == "SUBONLY")
				%r = -1;
			else {
				%r = %i;
				//echo("------------------------------------------------------");
				%need = $NPC[%npc,%i,NEED];
				for (%x = 0; (%chk = getWord(%need,%x)) != -1; %x+=2) {
					%val = getWord(%need,%x+1);
					//echo(" CHK " @ %chk @ " VAL " @ %val);
					if (%chk == "NOTCOMPLETE") {
						if (CruQuestCompleted(%id,%val) == True)
							%r = -1;
					}
					if (%chk == "ISCOMPLETE") {
						if (CruQuestCompleted(%id,%val) == False)
							%r = -1;
					}
					if (%chk == "NOTHASQUEST") {
						if (HasCruQuest(%id,%val) == True)
							%r = -1;
					}
					if (%chk == "HASITEM") {
						if (BackpackHasItem(%id,%val,True) == False)
							%r = -1;
					}
					if (%chk == "HASSTUFF") {
						%item = String::getWord(%val,":",0);
						%v = String::getWord(%val,":",1);
						if (HasBackpackCount(%id,%item,%v) == False)
							%r = -1;
					}
					if (%chk == "HASQUEST") {
						if (HasCruQuest(%id,%val) == False)
							%r = -1;
					}
					if (%chk == "QUESTON") {
						%q = string::GetWord(%val,":",0);
						%on = string::GetWord(%val,":",1);
						if (HasCruQuest(%id,%q,%on) == False)
							%r = -1;
					}
					if (%chk == "LVL") {
						if (fetchData(%id,"LVL") < %val)
							%r = -1;
					}
					if (%chk == "SKILL") {
						%skill = String::getWord(%val,":",0);
						%v = String::getWord(%val,":",1);
						%rcrop = $BPSkillToNumeric[%skill];
						if (GetPlayerSkill(%id,%rcrop) < %v)
							%r = -1;
					}
					//echo(" R " @ %r);
				}
				//echo(" R FINAL " @ %r);
				if (%r != -1) {
					if (%foundr == -1)
						%foundr = %r;
				}
			}
		}
	}
	else
		%r = %sub;
	if (%r != -1 || %foundr != -1) {
		if (%foundr != -1)
			%r = %foundr;
		%id.NPCSub = %r;
		%msg = %msg @ "<f0><n>" @ NPCParse(%id,$NPC[%npc,%r,BOT]) @ "\n\n";
		for (%i = 1; (%n = $NPC[%npc,%r,%i,0]) != ""; %i++) {
			%msg = %msg @ "<f1>" @ %i @ ": " @ NPCParse(%id,%n) @ "\n";
		} 
	}
	else {
		if ($NPC[%npc,DENY,1] == "")
			%msg = %msg @ "<f0><n>" @ NPCRandomDeny() @ "\n\n";
		else {
			%x = 0;
			for (%i = 1; $NPC[%npc,DENY,%i] != ""; %i++) %x++;
			%x = RandBetween(1,%x);
			%msg = %msg @ "<f0><n>" @ NPCParse(%id,$NPC[%npc,DENY,%x]) @ "\n\n";
		}
	}
	%msg = %msg @ "\n\n<f1>";
	%msg = %msg @ "0: Close Menu\n";
	SendBufferBP(%id,%msg,99999);
}

$NPCDENY[1] = "Greetings Adventurer!";
$NPCDENY[2] = "I'm sorry, I cant be bothered right now.";
$NPCDENY[3] = "Shouldn't you be off slaying monsters?";
$NPCDENY[4] = "Hail!";

function NPCRandomDeny()
{
	%x = RandBetween(1,4);
	return $NPCDENY[%x];
}

function NPCSelect(%id,%key)
{
	if (%key == 0) {
		NPCEnd(%id);
	}
	else {
		%sub = %id.NPCSub;
		%npc = %id.NPCTalking;		
		if ((%res = $NPC[%npc,%sub,%key,1]) != "") {
			for (%i = 0; (%a = getWord(%res,%i)) != -1; %i+=2) {
				%val = getWord(%res,(%i+1));
				if (%a == "OPENSTORE") {
					%id.MerchantArea = %val;
					Game::menuBackpackMerchant(%id,0);
					NPCEnd(%id);
				}
				if (%a == "NPCEND")
					NPCEnd(%id);
				if (%a == "SUB")
					NPCTalk(%id,%npc,%val);
				if (%a == "CLIENTDEPOSIT")
					%id.NPCDeposit = 1;
				if (%a == "CLIENTWITHDRAW")
					%id.NPCWithdraw = 1;
				if (%a == "OPENBANK")
					 Game::MenuChooseStorage(%id);
				if (%a == "DEPOSIT")
					NPCDepositCoins(%id,%val);
				if (%a == "WITHDRAW")
					NPCWithdrawCoins(%id,%val);
				if (%a == "GIVEQUEST")
					AddCruQuest(%id,%val,0);
				if (%a == "COMPLETEQUEST")
					CompleteCruQuest(%id,%val);
				if (%a == "INCQUEST")
					IncCruQuest(%id,%val);
				if (%a == "TAKEITEM")
					RemoveFromBackpack(%id,%val,-1);
				if (%a == "TAKESTUFF") {
					%item = String::getWord(%val,":",0);
					%v = String::getWord(%val,":",1);
					RemoveFromBackpack(%id,%item,(%v*-1));
				}
				if (%a == "GIVEITEM") {
					%find = string::FindSubStr(%val,":");
					%item = string::GetSubStr(%val,0,%find);
					%quality = string::GetSubStr(%val,%find+1,999);
					if (%quality == "999")
						%newitem = "999" @ %item;
					else
						%newitem = TierItem::RandomItem(%item,%quality);
					AddToBackpack(%id,%newitem,1);
				}
				if (%a == "GIVECOINS") {
					GiveThisStuff(%id,"COINS " @ %val, True);
				}
				if (%a == "GIVEPASSIVE") {
					Client::SendMessage(%id,0,"You received " @ %val @ " Passive Points.");
					$PassivePoints[%id] += %val;
				}
				if (%a == "GIVERESPEC") {
					Client::SendMessage(%id,0,"You received " @ %val @ " Passive Reset Points.");
					$UnspecPoints[%id] += %val;
				}
			}
		}
	}
}

function NPCDepositCoins(%id,%coins)
{
	if (%coins == "ALL") {
		%coins = fetchData(%id,"COINS");
		%bank = fetchData(%id,"BANK") + %coins;
		StoreData(%id,"BANK",%bank);
		StoreData(%id,"COINS",0);
		Client::SendMessage(%id,0,"You store " @ %coins @ " coins at the bank.~wmoney.wav");
	}
	else {
		%curCoins = fetchData(%id,"COINS");
		if (%coins > %curCoins)
			%coins = %curCoins;
		if (%coins < 0) %coins = 0;
		%curCoins -= %coins;
		%curBank = fetchData(%id,"BANK");
		%curBank += %coins;
		storeData(%id,"COINS",%curCoins);
		storeData(%id,"BANK",%curBank);
		Client::SendMessage(%id,0,"You store " @ %coins @ " coins at the bank.~wmoney.wav");
		NPCEnd(%id);
	}
	ClearPlayerNPC(%id);
}

function NPCWithdrawCoins(%id,%coins)
{
	if (%coins == "ALL") {
		%bank = fetchData(%id,"BANK");
		%coins = fetchData(%id,"COINS") + %bank;
		StoreData(%id,"BANK",0);
		StoreData(%id,"COINS",%coins);
		Client::SendMessage(%id,0,"You withdraw " @ %bank @ " coins from the bank.~wmoney.wav");
	}
	else {
		%curBank = fetchData(%id,"BANK");
		if (%coins > %curBank)
			%coins = %curBank;
		if (%coins < 0) %coins = 0;
		%curBank -= %coins;
		%curCoins = fetchData(%id,"COINS");
		%curCoins += %coins;
		storeData(%id,"BANK",%curBank);
		storeData(%id,"COINS",%curCoins);
		Client::SendMessage(%id,0,"You withdraw " @ %coins @ " coins from the bank.~wmoney.wav");
		NPCEnd(%id);
	}
	ClearPlayerNPC(%id);
}

function NPCParse(%id,%n)
{
	if (%id.BulkNum > fetchdata(%id,"COINS")) %bulkDep = fetchdata(%id,"COINS");
	if (%id.BulkNum > fetchdata(%id,"BANK")) %bulkWith = fetchdata(%id,"BANK");
	%n = string::Replace(%n,"DATACOIN",fetchdata(%id,"COINS"));
	%n = string::Replace(%n,"DATAHALF",floor(fetchdata(%id,"COINS") / 2));
	%n = string::Replace(%n,"BULKNUMDEPOSIT",%bulkdep);
	%n = string::Replace(%n,"DATABANK",fetchdata(%id,"BANK"));
	return %n;
}

function NPCEnd(%id)
{
	SendBufferBP(%id,"",1);
	ClearPlayerNPC(%id);
}

//===============================================================================================================================

function SpawnAINPC(%aiName,%armor,%skin,%spawnPos,%spawnRot)
{
	%name = %aiName;
	if (AI::spawn(%aiName,%armor,%spawnPos,%spawnRot,%name,"male2") != "false") {
		%aiId = AI::getId(%aiName);
		AI::setVar(%aiName, iq, 1000 );
		GameBase::startFadeIn(%AiId);
		if (%skin != "")
			Client::SetSkin(%aiId,%skin);
	}
	else
		echo("SpawnAINPC ERROR");
}

function SpawnNPC(%npc,%item,%pos,%rot,%team)
{
	%townbot = newObject("","Item",%item,1,false);
	addToSet("MissionCleanup",%townbot);
	GameBase::setMapName(%townbot,%npc);
	GameBase::playSequence(%townbot,0,"root");
	%townbotclient = Player::GetClient(%townbot);
	GameBase::setPosition(%townbot,%pos);
	GameBase::setRotation(%townbot,%rot);
	GameBase::setTeam(%townbot,%team);
}

function InitNPC()
{
	if ($CURRENTCRUMAP == "FOREST") {
		SpawnNPC("Traveling Merchant","MaleHumanTownBot","136.328 65.3219 151.498","0 -0 2.92319",0);
		SpawnNPC("Weapons Merchant","MaleHumanTownBot","175.5 46.5 147.5","0 -0 2",0);
		SpawnNPC("Armor Merchant","FemaleHumanTownBot","161.2 65.6 148.8","0 -0 2.7",2);
		SpawnNPC("Mystic Merchant","FemaleHumanTownBotRobed","90.5 56.4 159.7","0 -0 -2.5",6);
		SpawnNPC("Banker","FemaleHumanTownBot","73.7 1.7 165","0 0 0.43",0);
		SpawnNPC("Delina","FemaleHumanTownBot","136 2.2 162.55","0 0 1.43",0);
		SpawnNPC("Warrior","MaleHumanTownBot","-192.808 281.314 222.382","0 -0 3.117",2);
		SpawnNPC("Rogue","FemaleHumanTownBotRobed","583.265 -62.436 105.65","0 -0 1.1485",5);
		SpawnNPC("Mage","MaleHumanTownBotRobed","572.12 -669.655 -1330.74","0 -0 0.99454",7);
		SpawnNPC("Old Smith","MaleHumanTownBot","867 -67 134.094","0 -0 -2.8",0);
		$TOWNPORTALPOS = "78.5 25.96 163.3";
		$TOWNPORTALROT = "0 -0 -1.4";
		$MAPEXIT = "KTOWN";
		$MAPDEATH = "KTOWN";
		$MAPDEATHPOS = "69.642 47.502 165.26";
	}
	if ($CURRENTCRUMAP == "DESERT") {
		SpawnNPC("Traveling Merchant","MaleHumanTownBot","26.5 -43.5 75","0 -0 -1.44",0);
		SpawnNPC("Weapons Merchant","MaleHumanTownBot","44.8 -53 75.3","0 -0 1.4",0);
		SpawnNPC("Armor Merchant","FemaleHumanTownBot","67.9 -76 75.3","0 -0 2.7",2);
		SpawnNPC("Mystic Merchant","FemaleHumanTownBotRobed","94.2 -19.5 75.3","0 -0 2.5",6);
		SpawnNPC("Banker","FemaleHumanTownBot","54.4 -114.8 75.8","0 0 0.0",0);
		SpawnNPC("Warrior","MaleHumanTownBot","-285.606 -665.044 21.3042","0 -0 -0.119998",2);
		SpawnNPC("Rogue","FemaleHumanTownBotRobed","693.051 148.912 87.9208","0 -0 1.72319",5);
		SpawnNPC("Mage","MaleHumanTownBotRobed","202.864 -795.589 -1128.5","0 -0 1.89998",7);
		$TOWNPORTALPOS = "81 -110 75.1";
		$TOWNPORTALROT = "0 -0 -0.01";
		$MAPEXIT = "DESTOWN";
		$MAPDEATH = "DESTOWN";
		$MAPDEATHPOS = "183 -90 77";
	}
	if ($CURRENTCRUMAP == "JUNGLE") {
		SpawnNPC("Traveling Merchant","MaleHumanTownBot","-159.125 149.641 70.2447","0 -0 0.979983",0);
		SpawnNPC("Weapons Merchant","MaleHumanTownBot","-178.086 133.625 72.125","0 -0 0.399985",0);
		SpawnNPC("Armor Merchant","FemaleHumanTownBot","-200.329 138.297 72.125","0 -0 -0.699984",2);
		SpawnNPC("Mystic Merchant","FemaleHumanTownBotRobed","-148.289 208.799 73","0 -0 2.89987",6);
		SpawnNPC("Banker","FemaleHumanTownBot","-228.597 159.162 70.4448","0 0 0",0);
		//SpawnNPC("Warrior","MaleHumanTownBot","-285.606 -665.044 21.3042","0 -0 -0.119998",2);
		//SpawnNPC("Rogue","FemaleHumanTownBotRobed","693.051 148.912 87.9208","0 -0 1.72319",5);
		//SpawnNPC("Mage","MaleHumanTownBotRobed","202.864 -795.589 -1128.5","0 -0 1.89998",7);
		$TOWNPORTALPOS = "-204.965 215.352 70.2453";
		$TOWNPORTALROT = "0 -0 -2.63997";
		$MAPEXIT = "JTOWN";
		$MAPDEATH = "JTOWN";
		$MAPDEATHPOS = "-180.823 177.375 71.9953";
	}
	LoadMerchantShops();
}

//===============================================================================================================================

function LoadMerchantShops()
{
	if ($CURRENTCRUMAP == "FOREST") {
		$BPMerchants = 5;
		//---------------------------------------------------
		// SPECIAL
		$BPMerchantArea[1] = "136.328 65.3219 151.498";
		$BPMerchantShop[1] = "";
		//---------------------------------------------------
		// WEAPONS
		$BPMerchantArea[2] = "175.5 46.5 147.5";
		$BPMerchantShop[2] = "";
		//---------------------------------------------------
		// ARMOR
		$BPMerchantArea[3] = "161.2 65.6 148.8 ";
		$BPMerchantShop[3] = "";
		//---------------------------------------------------
		// SPELLS
		$BPMerchantArea[4] = "90.5 56.4 159.6";
		$BPMerchantShop[4] = "";
		//---------------------------------------------------
		// STORAGE
		$BPStorages = 1;
		$BPStorageArea[1] = "73.7 1.7 165";
		//=================================================================
		$NPC["MERCHANT1",LOCATION] = "136.328 65.3219 151.498";
		$NPC["WEAPONSMERCHANT",LOCATION] = "175.5 46.5 147.5";
		$NPC["ARMORMERCHANT",LOCATION] = "161.2 65.6 148.8";
		$NPC["MAGICMERCHANT",LOCATION] = "90.5 56.4 159.6";
		$NPC["BANKER1",LOCATION] = "73.7 1.7 165";
		$NPC["WARRIOR",LOCATION] = "-192.808 281.314 222.382";
		$NPC["MAGE",LOCATION] = "572.12 -669.655 -1330.74";
		$NPC["ROGUE",LOCATION] = "583.265 -62.436 105.65";
	}
	if ($CURRENTCRUMAP == "DESERT") {
		$BPMerchants = 5;
		//---------------------------------------------------
		// SPECIAL
		$BPMerchantArea[1] = "26.5 -43.5 75";
		$BPMerchantShop[1] = "";
		//---------------------------------------------------
		// WEAPONS
		$BPMerchantArea[2] = "44.8 -53 75.3";
		$BPMerchantShop[2] = "";
		//---------------------------------------------------
		// ARMOR
		$BPMerchantArea[3] = "67.9 -76 75.3";
		$BPMerchantShop[3] = "";
		//---------------------------------------------------
		// SPELLS
		$BPMerchantArea[4] = "94.2 -19.5 75.3";
		$BPMerchantShop[4] = "";
		//---------------------------------------------------
		// STORAGE
		$BPStorages = 1;
		$BPStorageArea[1] = "54.4 -114.8 75.8";
		//=================================================================
		$NPC["MERCHANT1",LOCATION] = "26.5 -43.5 75";
		$NPC["WEAPONSMERCHANT",LOCATION] = "44.8 -53 75.3";
		$NPC["ARMORMERCHANT",LOCATION] = "67.9 -76 75.3";
		$NPC["MAGICMERCHANT",LOCATION] = "94.2 -19.5 75.3";
		$NPC["BANKER1",LOCATION] = "54.4 -114.8 75.8";
		$NPC["WARRIOR",LOCATION] = "-285.606 -665.044 21.3042";
		$NPC["MAGE",LOCATION] = "202.864 -795.589 -1128.5";
		$NPC["ROGUE",LOCATION] = "693.051 148.912 87.9208";
	}
	if ($CURRENTCRUMAP == "JUNGLE") {
		$BPMerchants = 5;
		//---------------------------------------------------
		// SPECIAL
		$BPMerchantArea[1] = "-159.125 149.641 70.2447";
		$BPMerchantShop[1] = "";
		//---------------------------------------------------
		// WEAPONS
		$BPMerchantArea[2] = "-178.086 133.625 72.125";
		$BPMerchantShop[2] = "";
		//---------------------------------------------------
		// ARMOR
		$BPMerchantArea[3] = "-200.329 138.297 72.125";
		$BPMerchantShop[3] = "";
		//---------------------------------------------------
		// SPELLS
		$BPMerchantArea[4] = "-148.289 208.799 73";
		$BPMerchantShop[4] = "";
		//---------------------------------------------------
		// STORAGE
		$BPStorages = 1;
		$BPStorageArea[1] = "-228.597 159.162 70.4448";
		//=================================================================
		$NPC["MERCHANT1",LOCATION] = "-159.125 149.641 70.2447";
		$NPC["WEAPONSMERCHANT",LOCATION] = "-178.086 133.625 72.125";
		$NPC["ARMORMERCHANT",LOCATION] = "-200.329 138.297 72.125";
		$NPC["MAGICMERCHANT",LOCATION] = "-148.289 208.799 73";
		$NPC["BANKER1",LOCATION] = "-228.597 159.162 70.4448";
		//$NPC["WARRIOR",LOCATION] = "-285.606 -665.044 21.3042";
		//$NPC["MAGE",LOCATION] = "202.864 -795.589 -1128.5";
		//$NPC["ROGUE",LOCATION] = "693.051 148.912 87.9208";
	}
}

//---------------------------------------------------------------------------
// FORMATING
// CreateLoot(%id,%mf,%n,%lvl,%f,%merchant)
// CreateMerchantLoot(%merchant,%type,%count,%mf,%min,%max)
//---------------------------------------------------------------------------

function RestockMerchants()
{
	if ($CURRENTCRUMAP == "FOREST") {
		//=================================================================
		// MERCHANT1
		CreateLoot(0,300,10,75,1,1);
		//=================================================================
		// MERCHANT WEAPONS
		%r = RandBetween(14,28);
		CreateMerchantLoot(2,"weapon",%r,150,1,75);
		//=================================================================
		// MERCHANT ARMOR
		%r = RandBetween(14,28);
		CreateMerchantLoot(3,"armor",%r,150,1,75);
		//=================================================================
		// MERCHANT SPELL
		%r = RandBetween(14,28);
		CreateMerchantLoot(4,"spell",%r,150,1,75);
		//------------------------------------------------------------------------------------------
	}
	if ($CURRENTCRUMAP == "DESERT") {
		//=================================================================
		// MERCHANT1
		CreateLoot(0,300,10,150,1,1);
		//=================================================================
		// MERCHANT WEAPONS
		%r = RandBetween(14,28);
		CreateMerchantLoot(2,"weapon",%r,150,75,300);
		//=================================================================
		// MERCHANT ARMOR
		%r = RandBetween(14,28);
		CreateMerchantLoot(3,"armor",%r,150,75,300);
		//=================================================================
		// MERCHANT SPELL
		%r = RandBetween(14,28);
		CreateMerchantLoot(4,"spell",%r,150,75,300);
		//------------------------------------------------------------------------------------------
	}
	if ($CURRENTCRUMAP == "JUNGLE") {
		//=================================================================
		// MERCHANT1
		CreateLoot(0,300,10,150,1,1);
		//=================================================================
		// MERCHANT WEAPONS
		%r = RandBetween(14,28);
		CreateMerchantLoot(2,"weapon",%r,150,150,300);
		//=================================================================
		// MERCHANT ARMOR
		%r = RandBetween(14,28);
		CreateMerchantLoot(3,"armor",%r,150,150,300);
		//=================================================================
		// MERCHANT SPELL
		%r = RandBetween(14,28);
		CreateMerchantLoot(4,"spell",%r,150,150,300);
		//------------------------------------------------------------------------------------------
	}
	MessageAll(2,"The merchants have restocked their shops..");
}

//===============================================================================================================================

//FOREST
$NPCCHECK["KTOWN"] = "MERCHANT1 BANKER1 DELINA WEAPONSMERCHANT ARMORMERCHANT MAGICMERCHANT";
$NPCCHECK["STRONGHOLD"] = "WARRIOR";
$NPCCHECK["TOWER"] = "MAGE";
$NPCCHECK["CAMP"] = "ROGUE";
$NPCCHECK["OLDSMITH"] = "OLDSMITH";

//DESERT
$NPCCHECK["DESTOWN"] = "MERCHANT1 BANKER1 WEAPONSMERCHANT ARMORMERCHANT MAGICMERCHANT";

// JUNGLE
$NPCCHECK["JTOWN"] = "MERCHANT1 BANKER1 WEAPONSMERCHANT ARMORMERCHANT MAGICMERCHANT";

//===============================================================================================================================

$OPT = 0;
$CMD = 1;

$NPC["MERCHANT1",NAME] = "Traveling Specialty Merchant";
$NPC["MERCHANT1",0,NEED] = "NA"; 
$NPC["MERCHANT1",0,BOT] = "I get my hands on a lot of fine items.\nWould you like to buy something?";
$NPC["MERCHANT1",0,1,0] = "Sure, what do you have?";
$NPC["MERCHANT1",0,2,0] = "Not today.";
$NPC["MERCHANT1",0,1,1] = "OPENSTORE 1 NPCEND 1";
$NPC["MERCHANT1",0,2,1] = "SUB 1";
$NPC["MERCHANT1",1,NEED] = "SUBONLY";
$NPC["MERCHANT1",1,BOT] = "Ok, but I wont be in town long!";
//$NPC["MERCHANT1",2,NEED] = "LVL 50";
//$NPC["MERCHANT1",2,BOT] = "Ah I see you are getting stronger!\nAre you ready to travel to new worlds?\n I also have some goods for sale!";
//$NPC["MERCHANT1",2,1,0] = "Just show me the items you have.";
//$NPC["MERCHANT1",2,2,0] = "Not today.";
//$NPC["MERCHANT1",2,3,0] = "Yeah, I'm looking to travel to Keldrin.";
//$NPC["MERCHANT1",2,4,0] = "Yes, I need to travel east to Rakhar.";
//$NPC["MERCHANT1",2,1,1] = "OPENSTORE 1 NPCEND 1";
//$NPC["MERCHANT1",2,2,1] = "SUB 1";
//$NPC["MERCHANT1",2,3,1] = "TRAVEL FOREST";
//$NPC["MERCHANT1",2,4,1] = "TRAVEL DESERT";

$NPC["WEAPONSMERCHANT",NAME] = "Weapons Merchant";
$NPC["WEAPONSMERCHANT",0,NEED] = "NA"; 
$NPC["WEAPONSMERCHANT",0,BOT] = "Would you like to see the Weapons I have for sale?";
$NPC["WEAPONSMERCHANT",0,1,0] = "Yes, what do you have?";
$NPC["WEAPONSMERCHANT",0,2,0] = "No thanks.";
$NPC["WEAPONSMERCHANT",0,1,1] = "OPENSTORE 2 NPCEND 1";
$NPC["WEAPONSMERCHANT",0,2,1] = "SUB 1";
$NPC["WEAPONSMERCHANT",1,BOT] = "Ok, but check back soon!";

$NPC["ARMORMERCHANT",NAME] = "Armor Merchant";
$NPC["ARMORMERCHANT",0,NEED] = "NA"; 
$NPC["ARMORMERCHANT",0,BOT] = "Would you like to see the Armors I have for sale?";
$NPC["ARMORMERCHANT",0,1,0] = "Yes, what do you have?";
$NPC["ARMORMERCHANT",0,2,0] = "No thanks.";
$NPC["ARMORMERCHANT",0,1,1] = "OPENSTORE 3 NPCEND 1";
$NPC["ARMORMERCHANT",0,2,1] = "SUB 1";
$NPC["ARMORMERCHANT",1,BOT] = "Ok, but check back soon!";

$NPC["MAGICMERCHANT",NAME] = "Mystic Merchant";
$NPC["MAGICMERCHANT",0,NEED] = "NA"; 
$NPC["MAGICMERCHANT",0,BOT] = "I have some spells for sale. What do you need?";
$NPC["MAGICMERCHANT",0,1,0] = "Let me see what you have.";
$NPC["MAGICMERCHANT",0,2,0] = "Nothing, thanks.";
$NPC["MAGICMERCHANT",0,1,1] = "OPENSTORE 4 NPCEND 1";
$NPC["MAGICMERCHANT",0,2,1] = "SUB 1";
$NPC["MAGICMERCHANT",1,BOT] = "Travel carefully, Adventurer..";

$NPC["BANKER1",NAME] = "Banker";
$NPC["BANKER1",ISBANKER] = 1;
$NPC["BANKER1",0,NEED] = "NA"; 
$NPC["BANKER1",0,BOT] = "Hail! What can I do for you today?";
$NPC["BANKER1",0,1,0] = "I would like to deposit coins.";
$NPC["BANKER1",0,2,0] = "I would like to withdraw coins.";
$NPC["BANKER1",0,3,0] = "I would like to check my storage.";
$NPC["BANKER1",0,1,1] = "SUB 1 CLIENTDEPOSIT 1";
$NPC["BANKER1",0,2,1] = "SUB 2 CLIENTWITHDRAW 1";
$NPC["BANKER1",0,3,1] = "OPENBANK 1 NPCEND 1";
$NPC["BANKER1",1,BOT] = "You are carrying <f1>DATACOIN<f0> coins and I have <f1>DATABANK<f0> of yours.\nHow much would you like to deposit? You can also <f1>#say <f0>an amount.";
$NPC["BANKER1",1,1,0] = "All";
$NPC["BANKER1",1,1,1] = "DEPOSIT ALL NPCEND 1";
$NPC["BANKER1",2,BOT] = "I have <f1>DATABANK<f0> of yours.\nHow much would you like to withdraw? You can also <f1>SAY <f0>an amount.";
$NPC["BANKER1",2,1,0] = "All";
$NPC["BANKER1",2,1,1] = "WITHDRAW ALL NPCEND 1";


$NPC["DELINA",LOCATION] = "136 2.2 162.55";
$NPC["DELINA",NAME] = "Delina";
$NPC["DELINA",0,NEED] = "NOTCOMPLETE DEL NOTHASQUEST DEL"; 
$NPC["DELINA",0,BOT] = "Hello adventurer! I know this seems sudden, but I could use your help with a nasty problem we have been having.\n There is a group of goblins that have seemed to have tunneled their way underground and have destroyed our cellar walls.\n Food has gone missing, and people are afraid to go down there.\n I know it's asking a lot, but if you can bring me the head of one of the goblin leaders, I will be sure to reward you well.";
$NPC["DELINA",0,1,0] = "Yeah, this should be no problem at all!";
$NPC["DELINA",0,2,0] = "This sounds too scary for me.";
$NPC["DELINA",0,1,1] = "GIVEQUEST DEL SUB 1";
$NPC["DELINA",0,2,1] = "SUB 2";
$NPC["DELINA",1,NEED] = "SUBONLY";
$NPC["DELINA",1,BOT] = "Thank you kind sir! Good luck!";
$NPC["DELINA",2,NEED] = "SUBONLY";
$NPC["DELINA",2,BOT] = "Oh dear! Well, hopefully someone can help us..";
$NPC["DELINA",3,NEED] = "HASITEM 999GoblinHead HASQUEST DEL LVL 5";
$NPC["DELINA",3,BOT] = "I see you have returned with the head! Will you give it to me?";
$NPC["DELINA",3,1,0] = "It's all yours, Here you go";
$NPC["DELINA",3,2,0] = "Nah, I think I'll keep it for awhile";
$NPC["DELINA",3,1,1] = "COMPLETEQUEST DEL TAKEITEM 999GoblinHead SUB 4 GIVEITEM MossyTomeVolI:999 GIVEQUEST TOM";
$NPC["DELINA",3,2,1] = "SUB 5";
$NPC["DELINA",4,NEED] = "SUBONLY";
$NPC["DELINA",4,BOT] = "Ahh Thank you very much!\nHere, take this old tome I found!\nIt looks like it might be important.\nI also have this stash of items im not using, Maybe you can find a use for something.";
$NPC["DELINA",4,1,0] = "I'll take a Slashing Weapon";
$NPC["DELINA",4,2,0] = "Give me a Piercing Weapon";
$NPC["DELINA",4,3,0] = "That Bludgeoninging weapon looks Great";
$NPC["DELINA",4,4,0] = "Give me the Crossbow";
$NPC["DELINA",4,5,0] = "I'm a magic caster, give me the Wand";
$NPC["DELINA",4,6,0] = "I'll take the Martial Arts Staff";
$NPC["DELINA",4,1,1] = "GIVEITEM JaggedLongSword:7 SUB 6";
$NPC["DELINA",4,2,1] = "GIVEITEM JaggedSpear:7 SUB 6";
$NPC["DELINA",4,3,1] = "GIVEITEM ChippedMace:7 SUB 6";
$NPC["DELINA",4,4,1] = "GIVEITEM ChippedHandCrossbow:7 SUB 6";
$NPC["DELINA",4,5,1] = "GIVEITEM SplitOakWand:7 SUB 6";
$NPC["DELINA",4,6,1] = "GIVEITEM VarnishedCedarStaff:7 SUB 6";
$NPC["DELINA",5,NEED] = "SUBONLY";
$NPC["DELINA",5,BOT] = "Very well.. If you change your mind, come see me.";
$NPC["DELINA",6,NEED] = "SUBONLY";
$NPC["DELINA",6,BOT] = "Here you go! Put it to good use friend!";
$NPC["DELINA",7,NEED] = "HASITEM 999GoblinHead ISCOMPLETE DEL";
$NPC["DELINA",7,BOT] = "Ahh, I see you have been slaying more Goblins!";
$NPC["DELINA",7,1,0] = "Yep! Here is another head for your collection!";
$NPC["DELINA",7,1,1] = "GIVECOINS 15 TAKEITEM 999GoblinHead GIVEITEM MossyTomeVolI:999 GIVEQUEST TOM NPCEND 1";
$NPC["DELINA",DENY,1] = "";

$NPC["OLDSMITH",LOCATION] = "867 -67 134.094";
$NPC["OLDSMITH",NAME] = "Old Smith";
$NPC["OLDSMITH",0,NEED] = "LVL 10 HASITEM 999MossyTomeVolI HASQUEST TOM";
$NPC["OLDSMITH",0,BOT] = "" @ string::translate("*The old man mumbles something you cant understand*") @ "\n\nWhat do you want?";
$NPC["OLDSMITH",0,1,$OPT] = "The woman in town said I should seek you for advise about this tome.";
$NPC["OLDSMITH",0,2,$OPT] = "Nothing, sorry to bother you."; 
$NPC["OLDSMITH",0,1,$CMD] = "SUB 1";
$NPC["OLDSMITH",0,2,$CMD] = "SUB 2";
$NPC["OLDSMITH",1,NEED] = "SUBONLY";
$NPC["OLDSMITH",1,BOT] = "Ah yes let me see that.\nAhh, one of the missing Smith tomes!\nSo you want to become a Master Crafter?";
$NPC["OLDSMITH",1,1,$OPT] = "Yeah...";
$NPC["OLDSMITH",1,2,$OPT] = "No, this is not for me.";
$NPC["OLDSMITH",1,1,$CMD] = "SUB 3";
$NPC["OLDSMITH",1,2,$CMD] = "SUB 2";
$NPC["OLDSMITH",2,NEED] = "SUBONLY";
$NPC["OLDSMITH",2,BOT] = "Ok, get out of my sight!";
$NPC["OLDSMITH",3,NEED] = "SUBONLY";
$NPC["OLDSMITH",3,BOT] = "" @ string::translate("*The old man glares at you with one eye*") @ "\n\nIt takes much time to learn the ways of the crafter.";
$NPC["OLDSMITH",3,1,$OPT] = "I am willing to learn.";
$NPC["OLDSMITH",3,2,$OPT] = "On second thought, I'd rather not.";
$NPC["OLDSMITH",3,1,$CMD] = "TAKEITEM 999MossyTomeVolI GIVEITEM LaborerTome:10 COMPLETEQUEST TOM GIVEQUEST SMT SUB 4";
$NPC["OLDSMITH",3,3,$CMD] = "SUB 2";
$NPC["OLDSMITH",4,NEED] = "SUBONLY";
$NPC["OLDSMITH",4,BOT] = "Ok Return to me when you find more tomes";
// LVL 30 =================================================================
$NPC["OLDSMITH",5,NEED] = "QUESTON SMT:0 HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL LITERACY:300 HASSTUFF 999Dust:100";
$NPC["OLDSMITH",5,BOT] = "Ah you have found more tomes! Hand them to me.";
$NPC["OLDSMITH",5,1,$OPT] = "Here You go!";
$NPC["OLDSMITH",5,1,$CMD] = "INCQUEST SMT TAKEITEM 999MossyTomeVolII TAKEITEM 999MossyTomeVolIII TAKESTUFF 999Dust:100 GIVEITEM MasonTome:30 SUB 4";
// LVL 50 =================================================================
$NPC["OLDSMITH",6,NEED] = "QUESTON SMT:1 HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL LITERACY:500 HASSTUFF 999Dust:200";
$NPC["OLDSMITH",6,BOT] = "Ah you have found more tomes! Hand them to me.";
$NPC["OLDSMITH",6,1,$OPT] = "Here You go!";
$NPC["OLDSMITH",6,1,$CMD] = "INCQUEST SMT TAKEITEM 999MossyTomeVolIV TAKEITEM 999MossyTomeVolV TAKEITEM 999MossyTomeVoVI TAKESTUFF 999Dust:200 GIVEITEM BuilderTome:50 SUB 4";
// LVL 80 =================================================================
$NPC["OLDSMITH",7,NEED] = "QUESTON SMT:2 HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL LITERACY:800 HASSTUFF 999Dust:300";
$NPC["OLDSMITH",7,BOT] = "Ah you have found more tomes! Hand them to me.";
$NPC["OLDSMITH",7,1,$OPT] = "Here You go!";
$NPC["OLDSMITH",7,1,$CMD] = "INCQUEST SMT TAKEITEM 999DustyTomeVolI TAKEITEM 999DustyTomeVolII TAKEITEM 999DustyTomeVolIII TAKEITEM 999DustyTomeVolIV TAKESTUFF 999Dust:300 GIVEITEM CarpenterTome:80 SUB 4";
// LVL 100 =================================================================
$NPC["OLDSMITH",8,NEED] = "QUESTON SMT:3 HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL LITERACY:1000 HASSTUFF 999Dust:400";
$NPC["OLDSMITH",8,BOT] = "Ah you have found more tomes! Hand them to me.";
$NPC["OLDSMITH",8,1,$OPT] = "Here You go!";
$NPC["OLDSMITH",8,1,$CMD] = "INCQUEST SMT TAKEITEM 999DustyTomeVolV TAKEITEM 999DustyTomeVolVI TAKEITEM 999DustyTomeVolVII TAKEITEM 999DustyTomeVolVIII TAKESTUFF 999Dust:400 GIVEITEM CraftsmanTome:100 SUB 4";


$NPC["WARRIOR",NAME] = "Warrior Master Warrak";
$NPC["WARRIOR",0,NEED] = "LVL 10 HASITEM 999MossyTomeVolI HASQUEST TOM";
$NPC["WARRIOR",0,BOT] = "" @ string::translate("*The old warrior Orc grunts and looks up at you*") @ "\n\nWhat do you want?";
$NPC["WARRIOR",0,1,$OPT] = "The woman in town said I should seek you for advise about this tome.";
$NPC["WARRIOR",0,2,$OPT] = "Nothing, sorry to bother you."; 
$NPC["WARRIOR",0,1,$CMD] = "SUB 1";
$NPC["WARRIOR",0,2,$CMD] = "SUB 2";
$NPC["WARRIOR",1,NEED] = "SUBONLY";
$NPC["WARRIOR",1,BOT] = "Ah yes let me see that.\nAhh, one of the missing Warrior tomes!\nSo you want to become a warrior?";
$NPC["WARRIOR",1,1,$OPT] = "Yeah, I guess so...";
$NPC["WARRIOR",1,2,$OPT] = "No, this is not for me.";
$NPC["WARRIOR",1,1,$CMD] = "SUB 3";
$NPC["WARRIOR",1,2,$CMD] = "SUB 2";
$NPC["WARRIOR",2,NEED] = "SUBONLY";
$NPC["WARRIOR",2,BOT] = "Ok, get out of my sight!";
$NPC["WARRIOR",3,NEED] = "SUBONLY";
$NPC["WARRIOR",3,BOT] = "" @ string::translate("*The Master shakes his head in disgust*") @ "\n\nYou guess so?\nYou are going to need more spirit than that!\nNow, do you want to start your training or not, soldier!";
$NPC["WARRIOR",3,1,$OPT] = "Yes! Offensive Warrior training!";
$NPC["WARRIOR",3,2,$OPT] = "Yes! Defensive Warrior training!";
$NPC["WARRIOR",3,3,$OPT] = "On second thought, I'd rather not.";
$NPC["WARRIOR",3,1,$CMD] = "TAKEITEM 999MossyTomeVolI GIVEITEM BrawlerTome:10 COMPLETEQUEST TOM GIVEQUEST WOF GIVEQUEST MIT SUB 4";
$NPC["WARRIOR",3,2,$CMD] = "TAKEITEM 999MossyTomeVolI GIVEITEM DefenderTome:10 COMPLETEQUEST TOM GIVEQUEST WDF GIVEQUEST MIT SUB 4";
$NPC["WARRIOR",3,3,$CMD] = "SUB 2";
$NPC["WARRIOR",4,NEED] = "SUBONLY";
$NPC["WARRIOR",4,BOT] = "Ok Return to me when you are stronger and have more tomes!";
//=============================================================================================================================================
// OFFENSIVE LINE
//=== LEVEL 20 ==============================================================================
$NPC["WARRIOR",5,NEED] = "HASQUEST WOF QUESTON MIT:0 LVL 20";
$NPC["WARRIOR",5,BOT] = "I see you are getting stronger, Good!\nI have an item here for you, choose one.";
$NPC["WARRIOR",5,1,$OPT] = "Give me the Sword.";
$NPC["WARRIOR",5,2,$OPT] = "Give me the Knife.";
$NPC["WARRIOR",5,3,$OPT] = "Give me the Hammer.";
$NPC["WARRIOR",5,4,$OPT] = "Give me the Bow.";
$NPC["WARRIOR",5,5,$OPT] = "Give me the Martial Arts Staff.";
$NPC["WARRIOR",5,1,$CMD] = "GIVEITEM KeenHalberd:26 INCQUEST MIT SUB 4";
$NPC["WARRIOR",5,2,$CMD] = "GIVEITEM KeenRapier:26 INCQUEST MIT SUB 4";
$NPC["WARRIOR",5,3,$CMD] = "GIVEITEM HardwoodWarhammer:26 INCQUEST MIT SUB 4";
$NPC["WARRIOR",5,4,$CMD] = "GIVEITEM HardwoodElvenbow:26 INCQUEST MIT SUB 4";
$NPC["WARRIOR",5,5,$CMD] = "GIVEITEM CarvedIvoryStaff:26 INCQUEST MIT SUB 4";
//=== LEVEL 30 ==============================================================================
$NPC["WARRIOR",6,NEED] = "QUESTON WOF:0 HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL STRENGTH:149 SKILL LITERACY:149";
$NPC["WARRIOR",6,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["WARRIOR",6,1,$OPT] = "Here You go!";
$NPC["WARRIOR",6,1,$CMD] = "INCQUEST WOF TAKEITEM 999MossyTomeVolII TAKEITEM 999MossyTomeVolIII GIVEITEM FighterTome:30 SUB 4";
//=== LEVEL 40 ==============================================================================
$NPC["WARRIOR",7,NEED] = "HASQUEST WOF QUESTON MIT:1 LVL 40";
$NPC["WARRIOR",7,BOT] = "I see you are getting stronger, Good!\n";
$NPC["WARRIOR",7,1,$OPT] = "Yes, I am learning.";
$NPC["WARRIOR",7,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 1 SUB 4";
//=== LEVEL 50 ==============================================================================
$NPC["WARRIOR",8,NEED] = "QUESTON WOF:1 HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL STRENGTH:249 SKILL LITERACY:249";
$NPC["WARRIOR",8,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["WARRIOR",8,1,$OPT] = "Here You go!";
$NPC["WARRIOR",8,1,$CMD] = "INCQUEST WOF TAKEITEM 999MossyTomeVolIV TAKEITEM 999MossyTomeVolV TAKEITEM 999MossyTomeVolVI GIVEITEM CompanionTome:50 SUB 4";
//=== LEVEL 60 ==============================================================================
$NPC["WARRIOR",9,NEED] = "HASQUEST WOF QUESTON MIT:2 LVL 60";
$NPC["WARRIOR",9,BOT] = "I see you are getting stronger, Good!\nI have an item here for you, choose one.";
$NPC["WARRIOR",9,1,$OPT] = "Give me the Sword.";
$NPC["WARRIOR",9,2,$OPT] = "Give me the Knife.";
$NPC["WARRIOR",9,3,$OPT] = "Give me the Hammer.";
$NPC["WARRIOR",9,4,$OPT] = "Give me the Bow.";
$NPC["WARRIOR",9,5,$OPT] = "Give me the Martial Arts Staff.";
$NPC["WARRIOR",9,1,$CMD] = "GIVEITEM KeenHalberd:78 INCQUEST MIT SUB 4";
$NPC["WARRIOR",9,2,$CMD] = "GIVEITEM KeenRapier:78 INCQUEST MIT SUB 4";
$NPC["WARRIOR",9,3,$CMD] = "GIVEITEM HardwoodWarhammer:78 INCQUEST MIT SUB 4";
$NPC["WARRIOR",9,4,$CMD] = "GIVEITEM HardwoodElvenbow:78 INCQUEST MIT SUB 4";
$NPC["WARRIOR",9,5,$CMD] = "GIVEITEM CarvedIvoryStaff:78 INCQUEST MIT SUB 4";
//=== LEVEL 70 ==============================================================================
$NPC["WARRIOR",10,NEED] = "HASQUEST WOF QUESTON MIT:3 LVL 70";
$NPC["WARRIOR",10,BOT] = "I see you are getting stronger, Good!\n";
$NPC["WARRIOR",10,1,$OPT] = "Yes, I am learning.";
$NPC["WARRIOR",10,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 2 SUB 4";
//=== LEVEL 80 ==============================================================================
$NPC["WARRIOR",11,NEED] = "QUESTON WOF:2 HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL STRENGTH:399 SKILL LITERACY:399";
$NPC["WARRIOR",11,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["WARRIOR",11,1,$OPT] = "Here You go!";
$NPC["WARRIOR",11,1,$CMD] = "INCQUEST WOF TAKEITEM 999DustyTomeVolI TAKEITEM 999DustyTomeVolII TAKEITEM 999DustyTomeVolIII TAKEITEM 999DustyTomeVolIV GIVEITEM GruntTome:80 SUB 4";
//=== LEVEL 90 ==============================================================================
$NPC["WARRIOR",12,NEED] = "HASQUEST WOF QUESTON MIT:4 LVL 90";
$NPC["WARRIOR",12,BOT] = "I see you are getting stronger, Good!\nI have an item here for you, choose one.";
$NPC["WARRIOR",12,1,$OPT] = "Give me the Mystic Relic.";
$NPC["WARRIOR",12,2,$OPT] = "Give me the Rune Prism.";
$NPC["WARRIOR",12,3,$OPT] = "Give me the Regret Relic.";
$NPC["WARRIOR",12,3,$OPT] = "Give me the Anarchy Relic.";
$NPC["WARRIOR",12,1,$CMD] = "GIVEITEM MysticRelic:999 INCQUEST MIT SUB 4";
$NPC["WARRIOR",12,2,$CMD] = "GIVEITEM RunePrism:999 INCQUEST MIT SUB 4";
$NPC["WARRIOR",12,3,$CMD] = "GIVEITEM RegretRelic:999 INCQUEST MIT SUB 4";
$NPC["WARRIOR",12,3,$CMD] = "GIVEITEM AnarchyRelic:999 INCQUEST MIT SUB 4";
//=== LEVEL 100 ==============================================================================
$NPC["WARRIOR",13,NEED] = "QUESTON WOF:3 HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL STRENGTH:499 SKILL LITERACY:499";
$NPC["WARRIOR",13,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["WARRIOR",13,1,$OPT] = "Here You go!";
$NPC["WARRIOR",13,1,$CMD] = "INCQUEST WOF TAKEITEM 999DustyTomeVolV TAKEITEM 999DustyTomeVolVI TAKEITEM 999DustyTomeVolVII TAKEITEM 999DustyTomeVolVIII GIVEITEM SquireTome:100 SUB 4";
//=============================================================================================================================================
// DEFENSIVE LINE
//=== LEVEL 20 ==============================================================================
$NPC["WARRIOR",14,NEED] = "HASQUEST WDF QUESTON MIT:0 LVL 20";
$NPC["WARRIOR",14,BOT] = "I see you are getting stronger, Good!\nI have an item here for you, choose one.";
$NPC["WARRIOR",14,1,$OPT] = "Give me the Shield.";
$NPC["WARRIOR",14,2,$OPT] = "Give me the Armor.";
$NPC["WARRIOR",14,3,$OPT] = "Give me the Talisman.";
$NPC["WARRIOR",14,1,$CMD] = "GIVEITEM RobustTitaniumKiteShield:26 INCQUEST MIT SUB 4";
$NPC["WARRIOR",14,2,$CMD] = "GIVEITEM RobustTitaniumArmor:26 INCQUEST MIT SUB 4";
$NPC["WARRIOR",14,3,$CMD] = "GIVEITEM StainlessDiamondTalisman:26 INCQUEST MIT SUB 4";
//=== LEVEL 30 ==============================================================================
$NPC["WARRIOR",15,NEED] = "QUESTON WDF:0 HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL STRENGTH:149 SKILL LITERACY:149";
$NPC["WARRIOR",15,BOT] = "Ah you have found more tomes! Hand them over to continue your Defensive Training!";
$NPC["WARRIOR",15,1,$OPT] = "Here You go!";
$NPC["WARRIOR",15,1,$CMD] = "INCQUEST WDF TAKEITEM 999MossyTomeVolII TAKEITEM 999MossyTomeVolIII GIVEITEM LaymanTome:30 SUB 4";
//=== LEVEL 40 ==============================================================================
$NPC["WARRIOR",16,NEED] = "HASQUEST WDF QUESTON MIT:1 LVL 40";
$NPC["WARRIOR",16,BOT] = "I see you are getting stronger, Good!\n";
$NPC["WARRIOR",16,1,$OPT] = "Yes, I am learning.";
$NPC["WARRIOR",16,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 1 SUB 4";
//=== LEVEL 50 ==============================================================================
$NPC["WARRIOR",17,NEED] = "QUESTON WDF:1 HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL STRENGTH:249 SKILL LITERACY:249";
$NPC["WARRIOR",17,BOT] = "Ah you have found more tomes! Hand them over to continue your Defensive Training!";
$NPC["WARRIOR",17,1,$OPT] = "Here You go!";
$NPC["WARRIOR",17,1,$CMD] = "INCQUEST WDF TAKEITEM 999MossyTomeVolIV TAKEITEM 999MossyTomeVolV TAKEITEM 999MossyTomeVolVI GIVEITEM AcolyteTome:50 SUB 4";
//=== LEVEL 60 ==============================================================================
$NPC["WARRIOR",18,NEED] = "HASQUEST WDF QUESTON MIT:2 LVL 60";
$NPC["WARRIOR",18,BOT] = "I see you are getting stronger, Good!\nI have an item here for you, choose one.";
$NPC["WARRIOR",18,1,$OPT] = "Give me the Shield.";
$NPC["WARRIOR",18,2,$OPT] = "Give me the Armor.";
$NPC["WARRIOR",18,3,$OPT] = "Give me the Talisman.";
$NPC["WARRIOR",18,1,$CMD] = "GIVEITEM RobustTitaniumKiteShield:78 INCQUEST MIT SUB 4";
$NPC["WARRIOR",18,2,$CMD] = "GIVEITEM RobustTitaniumArmor:78 INCQUEST MIT SUB 4";
$NPC["WARRIOR",18,3,$CMD] = "GIVEITEM StainlessDiamondTalisman:78 INCQUEST MIT SUB 4";
//=== LEVEL 70 ==============================================================================
$NPC["WARRIOR",19,NEED] = "HASQUEST WDF QUESTON MIT:3 LVL 70";
$NPC["WARRIOR",19,BOT] = "I see you are getting stronger, Good!\n";
$NPC["WARRIOR",19,1,$OPT] = "Yes, I am learning.";
$NPC["WARRIOR",19,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 2 SUB 4";
//=== LEVEL 80 ==============================================================================
$NPC["WARRIOR",20,NEED] = "QUESTON WDF:2 HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL STRENGTH:399 SKILL LITERACY:399";
$NPC["WARRIOR",20,BOT] = "Ah you have found more tomes! Hand them over to continue your Defensive Training!";
$NPC["WARRIOR",20,1,$OPT] = "Here You go!";
$NPC["WARRIOR",20,1,$CMD] = "INCQUEST WDF TAKEITEM 999DustyTomeVolI TAKEITEM 999DustyTomeVolII TAKEITEM 999DustyTomeVolIII TAKEITEM 999DustyTomeVolIV GIVEITEM CurateTome:80 SUB 4";
//=== LEVEL 90 ==============================================================================
$NPC["WARRIOR",21,NEED] = "HASQUEST WDF QUESTON MIT:4 LVL 90";
$NPC["WARRIOR",21,BOT] = "I see you are getting stronger, Good!\nI have an item here for you, choose one.";
$NPC["WARRIOR",21,1,$OPT] = "Give me the Mystic Relic.";
$NPC["WARRIOR",21,2,$OPT] = "Give me the Rune Prism.";
$NPC["WARRIOR",21,3,$OPT] = "Give me the Regret Relic.";
$NPC["WARRIOR",21,3,$OPT] = "Give me the Anarchy Relic.";
$NPC["WARRIOR",21,1,$CMD] = "GIVEITEM MysticRelic:999 INCQUEST MIT SUB 4";
$NPC["WARRIOR",21,2,$CMD] = "GIVEITEM RunePrism:999 INCQUEST MIT SUB 4";
$NPC["WARRIOR",21,3,$CMD] = "GIVEITEM RegretRelic:999 INCQUEST MIT SUB 4";
$NPC["WARRIOR",21,3,$CMD] = "GIVEITEM AnarchyRelic:999 INCQUEST MIT SUB 4";
//=== LEVEL 100 ==============================================================================
$NPC["WARRIOR",22,NEED] = "QUESTON WDF:3 HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL STRENGTH:499 SKILL LITERACY:499";
$NPC["WARRIOR",22,BOT] = "Ah you have found more tomes! Hand them over to continue your Defensive Training!";
$NPC["WARRIOR",22,1,$OPT] = "Here You go!";
$NPC["WARRIOR",22,1,$CMD] = "INCQUEST WDF TAKEITEM 999DustyTomeVolV TAKEITEM 999DustyTomeVolVI TAKEITEM 999DustyTomeVolVII TAKEITEM 999DustyTomeVolVIII GIVEITEM PriestTome:100 SUB 4";

$NPC["MAGE",NAME] = "Mage Master Oldoch";
$NPC["MAGE",0,NEED] = "LVL 10 HASITEM 999MossyTomeVolI HASQUEST TOM";
$NPC["MAGE",0,BOT] = "" @ string::translate("*You see the old mage looking deeply into the crystal ball*") @ "\n\nAh, I sensed you coming.";
$NPC["MAGE",0,1,$OPT] = "The woman in town said I should seek you for advise about this tome.";
$NPC["MAGE",0,2,$OPT] = "Nothing, sorry to bother you."; 
$NPC["MAGE",0,1,$CMD] = "SUB 1";
$NPC["MAGE",0,2,$CMD] = "SUB 2";
$NPC["MAGE",1,NEED] = "SUBONLY";
$NPC["MAGE",1,BOT] = "Ah yes let me see that.\nAhh, one of the missing Mage tomes!\nSo you want to become a Mage?";
$NPC["MAGE",1,1,$OPT] = "Yeah, I want to learn the ways of the Source.";
$NPC["MAGE",1,2,$OPT] = "No, this is not for me.";
$NPC["MAGE",1,1,$CMD] = "SUB 3";
$NPC["MAGE",1,2,$CMD] = "SUB 2";
$NPC["MAGE",2,NEED] = "SUBONLY";
$NPC["MAGE",2,BOT] = "Ok then you must leave me.";
$NPC["MAGE",3,NEED] = "SUBONLY";
$NPC["MAGE",3,BOT] = "" @ string::translate("*The master smiles*") @ "\n\nThere is much you must learn. What path do you seek?";
$NPC["MAGE",3,1,$OPT] = "I want to learn offensive Magic.";
$NPC["MAGE",3,2,$OPT] = "I want to learn the ways of Defensive Magic.";
$NPC["MAGE",3,3,$OPT] = "Maybe this isn't for me...";
$NPC["MAGE",3,1,$CMD] = "TAKEITEM 999MossyTomeVolI GIVEITEM PupilTome:10 COMPLETEQUEST TOM GIVEQUEST MOF GIVEQUEST MIT SUB 4";
$NPC["MAGE",3,2,$CMD] = "TAKEITEM 999MossyTomeVolI GIVEITEM StudentTome:10 COMPLETEQUEST TOM GIVEQUEST MDF GIVEQUEST MIT SUB 4";
$NPC["MAGE",3,3,$CMD] = "SUB 2";
$NPC["MAGE",4,NEED] = "SUBONLY";
$NPC["MAGE",4,BOT] = "Ok Return to me when you have gained more wisdom and have more tomes!";
//=============================================================================================================================================
// OFFENSIVE LINE
//=== LEVEL 20 ==============================================================================
$NPC["MAGE",5,NEED] = "HASQUEST MOF QUESTON MIT:0 LVL 20";
$NPC["MAGE",5,BOT] = "I see you are becoming more wise, Good!\nI have an item here for you, choose one.";
$NPC["MAGE",5,1,$OPT] = "Give me the Wand.";
$NPC["MAGE",5,2,$OPT] = "Give me the Staff.";
$NPC["MAGE",5,3,$OPT] = "Give me the Orb.";
$NPC["MAGE",5,4,$OPT] = "Give me the Hood.";
$NPC["MAGE",5,1,$CMD] = "GIVEITEM ShiningCrystalWand:26 INCQUEST MIT SUB 4";
$NPC["MAGE",5,2,$CMD] = "GIVEITEM ShiningCrystalStaff:26 INCQUEST MIT SUB 4";
$NPC["MAGE",5,3,$CMD] = "GIVEITEM PristineDiamondOrb:26 INCQUEST MIT SUB 4";
$NPC["MAGE",5,4,$CMD] = "GIVEITEM StainlessForestHood:26 INCQUEST MIT SUB 4";
//=== LEVEL 30 ==============================================================================
$NPC["MAGE",6,NEED] = "QUESTON MOF:0 HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL INTELLIGENCE:149 SKILL LITERACY:149";
$NPC["MAGE",6,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["MAGE",6,1,$OPT] = "Here You go!";
$NPC["MAGE",6,1,$CMD] = "INCQUEST MOF TAKEITEM 999MossyTomeVolII TAKEITEM 999MossyTomeVolIII GIVEITEM AssociateTome:30 SUB 4";
//=== LEVEL 40 ==============================================================================
$NPC["MAGE",7,NEED] = "HASQUEST MOF QUESTON MIT:1 LVL 40";
$NPC["MAGE",7,BOT] = "I see you are gaining wisdom, Good!\n";
$NPC["MAGE",7,1,$OPT] = "Yes, I am learning.";
$NPC["MAGE",7,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 1 SUB 4";
//=== LEVEL 50 ==============================================================================
$NPC["MAGE",8,NEED] = "QUESTON MOF:1 HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL INTELLIGENCE:249 SKILL LITERACY:249";
$NPC["MAGE",8,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["MAGE",8,1,$OPT] = "Here You go!";
$NPC["MAGE",8,1,$CMD] = "INCQUEST MOF TAKEITEM 999MossyTomeVolIV TAKEITEM 999MossyTomeVolV TAKEITEM 999MossyTomeVolVI GIVEITEM AdeptTome:50 SUB 4";
//=== LEVEL 60 ==============================================================================
$NPC["MAGE",9,NEED] = "HASQUEST MOF QUESTON MIT:2 LVL 60";
$NPC["MAGE",9,BOT] = "I see you are becoming more wise, Good!\nI have an item here for you, choose one.";
$NPC["MAGE",9,1,$OPT] = "Give me the Wand.";
$NPC["MAGE",9,2,$OPT] = "Give me the Staff.";
$NPC["MAGE",9,3,$OPT] = "Give me the Orb.";
$NPC["MAGE",9,4,$OPT] = "Give me the Hood.";
$NPC["MAGE",9,1,$CMD] = "GIVEITEM ShiningCrystalWand:78 INCQUEST MIT SUB 4";
$NPC["MAGE",9,2,$CMD] = "GIVEITEM ShiningCrystalStaff:78 INCQUEST MIT SUB 4";
$NPC["MAGE",9,3,$CMD] = "GIVEITEM PristineDiamondOrb:78 INCQUEST MIT SUB 4";
$NPC["MAGE",9,4,$CMD] = "GIVEITEM StainlessForestHood:78 INCQUEST MIT SUB 4";
//=== LEVEL 70 ==============================================================================
$NPC["MAGE",10,NEED] = "HASQUEST MOF QUESTON MIT:3 LVL 70";
$NPC["MAGE",10,BOT] = "I see you are gaining wisdom, Good!\n";
$NPC["MAGE",10,1,$OPT] = "Yes, I am learning.";
$NPC["MAGE",10,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 2 SUB 4";
//=== LEVEL 80 ==============================================================================
$NPC["MAGE",11,NEED] = "QUESTON MOF:2 HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL INTELLIGENCE:399 SKILL LITERACY:399";
$NPC["MAGE",11,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["MAGE",11,1,$OPT] = "Here You go!";
$NPC["MAGE",11,1,$CMD] = "INCQUEST MOF TAKEITEM 999DustyTomeVolI TAKEITEM 999DustyTomeVolII TAKEITEM 999DustyTomeVolIII TAKEITEM 999DustyTomeVolIV GIVEITEM SpellslingerTome:80 SUB 4";
//=== LEVEL 90 ==============================================================================
$NPC["MAGE",12,NEED] = "HASQUEST MOF QUESTON MIT:4 LVL 90";
$NPC["MAGE",12,BOT] = "I see you are becoming more wise, Good!\nI have an item here for you, choose one.";
$NPC["MAGE",12,1,$OPT] = "Give me the Mystic Relic.";
$NPC["MAGE",12,2,$OPT] = "Give me the Rune Prism.";
$NPC["MAGE",12,3,$OPT] = "Give me the Regret Relic.";
$NPC["MAGE",12,3,$OPT] = "Give me the Anarchy Relic.";
$NPC["MAGE",12,1,$CMD] = "GIVEITEM MysticRelic:999 INCQUEST MIT SUB 4";
$NPC["MAGE",12,2,$CMD] = "GIVEITEM RunePrism:999 INCQUEST MIT SUB 4";
$NPC["MAGE",12,3,$CMD] = "GIVEITEM RegretRelic:999 INCQUEST MIT SUB 4";
$NPC["MAGE",12,3,$CMD] = "GIVEITEM AnarchyRelic:999 INCQUEST MIT SUB 4";
//=== LEVEL 100 ==============================================================================
$NPC["MAGE",13,NEED] = "QUESTON MOF:3 HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL INTELLIGENCE:499 SKILL LITERACY:499";
$NPC["MAGE",13,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["MAGE",13,1,$OPT] = "Here You go!";
$NPC["MAGE",13,1,$CMD] = "INCQUEST MOF TAKEITEM 999DustyTomeVolV TAKEITEM 999DustyTomeVolVI TAKEITEM 999DustyTomeVolVII TAKEITEM 999DustyTomeVolVIII GIVEITEM SquadMageTome:100 SUB 4";
//=============================================================================================================================================
// DEFENSIVE LINE
//=== LEVEL 20 ==============================================================================
$NPC["MAGE",14,NEED] = "HASQUEST MDF QUESTON MIT:0 LVL 20";
$NPC["MAGE",14,BOT] = "I see you are becoming more wise, Good!\nI have an item here for you, choose one.";
$NPC["MAGE",14,1,$OPT] = "Give me the Spirit Shield.";
$NPC["MAGE",14,2,$OPT] = "Give me the Robe.";
$NPC["MAGE",14,3,$OPT] = "Give me the Talisman.";
$NPC["MAGE",14,1,$CMD] = "GIVEITEM BrightForestSpiritShield:26 SUB 4 INCQUEST MIT";
$NPC["MAGE",14,2,$CMD] = "GIVEITEM BrightForestRobe:26 SUB 4 INCQUEST MIT";
$NPC["MAGE",14,3,$CMD] = "GIVEITEM StainlessDiamondTalisman:26 SUB 4 INCQUEST MIT";
//=== LEVEL 30 ==============================================================================
$NPC["MAGE",15,NEED] = "QUESTON MDF:0 HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL INTELLIGENCE:149 SKILL LITERACY:149";
$NPC["MAGE",15,BOT] = "Ah you have found more tomes! Hand them over to continue your Defensive Training!";
$NPC["MAGE",15,1,$OPT] = "Here You go!";
$NPC["MAGE",15,1,$CMD] = "INCQUEST MDF TAKEITEM 999MossyTomeVolII TAKEITEM 999MossyTomeVolIII GIVEITEM ApprenticeTome:30 SUB 4";
//=== LEVEL 40 ==============================================================================
$NPC["MAGE",16,NEED] = "HASQUEST MDF QUESTON MIT:1 LVL 40";
$NPC["MAGE",16,BOT] = "I see you are gaining wisdom, Good!\n";
$NPC["MAGE",16,1,$OPT] = "Yes, I am learning.";
$NPC["MAGE",16,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 1 SUB 4";
//=== LEVEL 50 ==============================================================================
$NPC["MAGE",17,NEED] = "QUESTON MDF:1 HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL INTELLIGENCE:249 SKILL LITERACY:249";
$NPC["MAGE",17,BOT] = "Ah you have found more tomes! Hand them over to continue your Defensive Training!";
$NPC["MAGE",17,1,$OPT] = "Here You go!";
$NPC["MAGE",17,1,$CMD] = "INCQUEST MDF TAKEITEM 999MossyTomeVolIV TAKEITEM 999MossyTomeVolV TAKEITEM 999MossyTomeVolVI GIVEITEM UnderstudyTome:50 SUB 4";
//=== LEVEL 60 ==============================================================================
$NPC["MAGE",18,NEED] = "HASQUEST MDF QUESTON MIT:2 LVL 60";
$NPC["MAGE",18,BOT] = "I see you are becoming more wise, Good!\nI have an item here for you, choose one.";
$NPC["MAGE",18,1,$OPT] = "Give me the Spirit Shield.";
$NPC["MAGE",18,2,$OPT] = "Give me the Robe.";
$NPC["MAGE",18,3,$OPT] = "Give me the Talisman.";
$NPC["MAGE",18,1,$CMD] = "GIVEITEM BrightForestSpiritShield:78 SUB 4 INCQUEST MIT";
$NPC["MAGE",18,2,$CMD] = "GIVEITEM BrightForestRobe:78 SUB 4 INCQUEST MIT";
$NPC["MAGE",18,3,$CMD] = "GIVEITEM StainlessDiamondTalisman:78 SUB 4 INCQUEST MIT";
//=== LEVEL 70 ==============================================================================
$NPC["MAGE",19,NEED] = "HASQUEST MDF QUESTON MIT:3 LVL 70";
$NPC["MAGE",19,BOT] = "I see you are gaining wisdom, Good!\n";
$NPC["MAGE",19,1,$OPT] = "Yes, I am learning.";
$NPC["MAGE",19,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 2 SUB 4";
//=== LEVEL 80 ==============================================================================
$NPC["MAGE",20,NEED] = "QUESTON MDF:2 HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL INTELLIGENCE:399 SKILL LITERACY:399";
$NPC["MAGE",20,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["MAGE",20,1,$OPT] = "Here You go!";
$NPC["MAGE",20,1,$CMD] = "INCQUEST MDF TAKEITEM 999DustyTomeVolI TAKEITEM 999DustyTomeVolII TAKEITEM 999DustyTomeVolIII TAKEITEM 999DustyTomeVolIV GIVEITEM ScholarTome:80 SUB 4";
//=== LEVEL 90 ==============================================================================
$NPC["MAGE",21,NEED] = "HASQUEST MDF QUESTON MIT:4 LVL 90";
$NPC["MAGE",21,BOT] = "I see you are becoming more wise, Good!\nI have an item here for you, choose one.";
$NPC["MAGE",21,1,$OPT] = "Give me the Mystic Relic.";
$NPC["MAGE",21,2,$OPT] = "Give me the Rune Prism.";
$NPC["MAGE",21,3,$OPT] = "Give me the Regret Relic.";
$NPC["MAGE",21,3,$OPT] = "Give me the Anarchy Relic.";
$NPC["MAGE",21,1,$CMD] = "GIVEITEM MysticRelic:999 INCQUEST MIT SUB 4";
$NPC["MAGE",21,2,$CMD] = "GIVEITEM RunePrism:999 INCQUEST MIT SUB 4";
$NPC["MAGE",21,3,$CMD] = "GIVEITEM RegretRelic:999 INCQUEST MIT SUB 4";
$NPC["MAGE",21,3,$CMD] = "GIVEITEM AnarchyRelic:999 INCQUEST MIT SUB 4";
//=== LEVEL 100 ==============================================================================
$NPC["MAGE",22,NEED] = "QUESTON MDF:3 HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL INTELLIGENCE:499 SKILL LITERACY:499";
$NPC["MAGE",22,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["MAGE",22,1,$OPT] = "Here You go!";
$NPC["MAGE",22,1,$CMD] = "INCQUEST MDF TAKEITEM 999DustyTomeVolV TAKEITEM 999DustyTomeVolVI TAKEITEM 999DustyTomeVolVII TAKEITEM 999DustyTomeVolVIII GIVEITEM SageTome:100 SUB 4";


$NPC["ROGUE",NAME] = "Rogue Master Haidexe";
$NPC["ROGUE",0,NEED] = "LVL 10 HASITEM 999MossyTomeVolI HASQUEST TOM";
$NPC["ROGUE",0,BOT] = "" @ string::translate("*You pause as you feel a cold blade against your throat*") @ "\n\nSo you think you can sneak up on me?";
$NPC["ROGUE",0,1,$OPT] = "The woman in town said I should seek you for advise about this tome.";
$NPC["ROGUE",0,2,$OPT] = "You are that criminal I've heard about, I should turn you in!"; 
$NPC["ROGUE",0,1,$CMD] = "SUB 1";
$NPC["ROGUE",0,2,$CMD] = "SUB 2";
$NPC["ROGUE",1,NEED] = "SUBONLY";
$NPC["ROGUE",1,BOT] = "Ah yes give me that.\nOne of the missing Rogue tomes.\nSo you think you have what it takes?";
$NPC["ROGUE",1,1,$OPT] = "Teach me and I can repay you in gold!";
$NPC["ROGUE",1,2,$OPT] = "I'd rather not live my life as a thief!";
$NPC["ROGUE",1,1,$CMD] = "SUB 3";
$NPC["ROGUE",1,2,$CMD] = "SUB 2";
$NPC["ROGUE",2,NEED] = "SUBONLY";
$NPC["ROGUE",2,BOT] = "Leave now before I kill you where you stand!";
$NPC["ROGUE",3,NEED] = "SUBONLY";
$NPC["ROGUE",3,BOT] = "" @ string::translate("*The master puts down her dagger*") @ "\n\nI will teach you, but it will come at a price\nIn wich do you want to specialize?";
$NPC["ROGUE",3,1,$OPT] = "I want to assassinate evil, teach me the ways of the offensive Rogue.";
$NPC["ROGUE",3,2,$OPT] = "I need to be quick and stealthy, teach me how to be defensive.";
$NPC["ROGUE",3,3,$OPT] = "On second thought, I think I will turn you in!";
$NPC["ROGUE",3,1,$CMD] = "TAKEITEM 999MossyTomeVolI GIVEITEM RecruitTome:10 COMPLETEQUEST TOM GIVEQUEST MIT GIVEQUEST ROF SUB 4";
$NPC["ROGUE",3,2,$CMD] = "TAKEITEM 999MossyTomeVolI GIVEITEM TraineeTome:10 COMPLETEQUEST TOM GIVEQUEST MIT GIVEQUEST RDF SUB 4";
$NPC["ROGUE",3,3,$CMD] = "SUB 2";
$NPC["ROGUE",4,NEED] = "SUBONLY";
$NPC["ROGUE",4,BOT] = "Ok Return to me when you are more agile and have more tomes!";
//=============================================================================================================================================
// OFFENSIVE LINE
//=== LEVEL 20 ==============================================================================
$NPC["ROGUE",5,NEED] = "HASQUEST ROF QUESTON MIT:0 LVL 20";
$NPC["ROGUE",5,BOT] = "I see you are becoming more agile, Good!\nI have an item here for you, choose one.";
$NPC["ROGUE",5,1,$OPT] = "Give me the Wand.";
$NPC["ROGUE",5,2,$OPT] = "Give me the Knife.";
$NPC["ROGUE",5,3,$OPT] = "Give me the Crossbow.";
$NPC["ROGUE",5,4,$OPT] = "Give me the Martial Arts Staff.";
$NPC["ROGUE",5,1,$CMD] = "GIVEITEM ShiningCrystalWand:26 INCQUEST MIT SUB 4";
$NPC["ROGUE",5,2,$CMD] = "GIVEITEM KeenRapier:26 INCQUEST MIT SUB 4";
$NPC["ROGUE",5,3,$CMD] = "GIVEITEM HardwoodElvenCrossbow:26 INCQUEST MIT SUB 4";
$NPC["ROGUE",5,4,$CMD] = "GIVEITEM CarvedIvoryStaff:26 INCQUEST MIT SUB 4";
//=== LEVEL 30 ==============================================================================
$NPC["ROGUE",6,NEED] = "QUESTON ROF:0 HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL DEXTERITY:149 SKILL LITERACY:149";
$NPC["ROGUE",6,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["ROGUE",6,1,$OPT] = "Here You go!";
$NPC["ROGUE",6,1,$CMD] = "INCQUEST ROF TAKEITEM 999MossyTomeVolII TAKEITEM 999MossyTomeVolIII GIVEITEM MurdererTome:30 SUB 4";
//=== LEVEL 40 ==============================================================================
$NPC["ROGUE",7,NEED] = "HASQUEST ROF QUESTON MIT:1 LVL 40";
$NPC["ROGUE",7,BOT] = "I see you are becoming more agile, Good!\n";
$NPC["ROGUE",7,1,$OPT] = "Yes, I am learning.";
$NPC["ROGUE",7,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 1 SUB 4";
//=== LEVEL 50 ==============================================================================
$NPC["ROGUE",8,NEED] = "QUESTON ROF:1 HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL DEXTERITY:249 SKILL LITERACY:249";
$NPC["ROGUE",8,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["ROGUE",8,1,$OPT] = "Here You go!";
$NPC["ROGUE",8,1,$CMD] = "INCQUEST ROF TAKEITEM 999MossyTomeVolIV TAKEITEM 999MossyTomeVolV TAKEITEM 999MossyTomeVolVI GIVEITEM AssistantTome:50 SUB 4";
//=== LEVEL 60 ==============================================================================
$NPC["ROGUE",9,NEED] = "HASQUEST ROF QUESTON MIT:2 LVL 60";
$NPC["ROGUE",9,BOT] = "I see you are becoming more agile, Good!\nI have an item here for you, choose one.";
$NPC["ROGUE",9,1,$OPT] = "Give me the Wand.";
$NPC["ROGUE",9,2,$OPT] = "Give me the Knife.";
$NPC["ROGUE",9,3,$OPT] = "Give me the Crossbow.";
$NPC["ROGUE",9,4,$OPT] = "Give me the Martial Arts Staff.";
$NPC["ROGUE",9,1,$CMD] = "GIVEITEM ShiningCrystalWand:78 INCQUEST MIT SUB 4";
$NPC["ROGUE",9,2,$CMD] = "GIVEITEM KeenRapier:78 INCQUEST MIT SUB 4";
$NPC["ROGUE",9,3,$CMD] = "GIVEITEM HardwoodElvenCrossbow:78 INCQUEST MIT SUB 4";
$NPC["ROGUE",9,4,$CMD] = "GIVEITEM CarvedIvoryStaff:78 INCQUEST MIT SUB 4";
//=== LEVEL 70 ==============================================================================
$NPC["ROGUE",10,NEED] = "HASQUEST ROF QUESTON MIT:3 LVL 70";
$NPC["ROGUE",10,BOT] = "I see you are becoming more agile, Good!\n";
$NPC["ROGUE",10,1,$OPT] = "Yes, I am learning.";
$NPC["ROGUE",10,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 2 SUB 4";
//=== LEVEL 80 ==============================================================================
$NPC["ROGUE",11,NEED] = "QUESTON ROF:2 HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL DEXTERITY:399 SKILL LITERACY:399";
$NPC["ROGUE",11,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["ROGUE",11,1,$OPT] = "Here You go!";
$NPC["ROGUE",11,1,$CMD] = "INCQUEST ROF TAKEITEM 999DustyTomeVolI TAKEITEM 999DustyTomeVolII TAKEITEM 999DustyTomeVolIII TAKEITEM 999DustyTomeVolIV GIVEITEM ServantTome:80 SUB 4";
//=== LEVEL 90 ==============================================================================
$NPC["ROGUE",12,NEED] = "HASQUEST ROF QUESTON MIT:4 LVL 90";
$NPC["ROGUE",12,BOT] = "I see you are becoming more agile, Good!\nI have an item here for you, choose one.";
$NPC["ROGUE",12,1,$OPT] = "Give me the Mystic Relic.";
$NPC["ROGUE",12,2,$OPT] = "Give me the Rune Prism.";
$NPC["ROGUE",12,3,$OPT] = "Give me the Regret Relic.";
$NPC["ROGUE",12,3,$OPT] = "Give me the Anarchy Relic.";
$NPC["ROGUE",12,1,$CMD] = "GIVEITEM MysticRelic:999 INCQUEST MIT SUB 4";
$NPC["ROGUE",12,2,$CMD] = "GIVEITEM RunePrism:999 INCQUEST MIT SUB 4";
$NPC["ROGUE",12,3,$CMD] = "GIVEITEM RegretRelic:999 INCQUEST MIT SUB 4";
$NPC["ROGUE",12,3,$CMD] = "GIVEITEM AnarchyRelic:999 INCQUEST MIT SUB 4";
//=== LEVEL 100 ==============================================================================
$NPC["ROGUE",13,NEED] = "QUESTON ROF:3 HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL DEXTERITY:499 SKILL LITERACY:499";
$NPC["ROGUE",13,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["ROGUE",13,1,$OPT] = "Here You go!";
$NPC["ROGUE",13,1,$CMD] = "INCQUEST ROF TAKEITEM 999DustyTomeVolV TAKEITEM 999DustyTomeVolVI TAKEITEM 999DustyTomeVolVII TAKEITEM 999DustyTomeVolVIII GIVEITEM FootpadTome:100 SUB 4";
//=============================================================================================================================================
// DEFENSIVE LINE
//=== LEVEL 20 ==============================================================================
$NPC["ROGUE",14,NEED] = "HASQUEST RDF QUESTON MIT:0 LVL 20";
$NPC["ROGUE",14,BOT] = "I see you are becoming more agile, Good!\nI have an item here for you, choose one.";
$NPC["ROGUE",14,1,$OPT] = "Give me the Armor.";
$NPC["ROGUE",14,2,$OPT] = "Give me the Boots.";
$NPC["ROGUE",14,3,$OPT] = "Give me the Talisman.";
$NPC["ROGUE",14,1,$CMD] = "GIVEITEM RefinedDrakescaleArmor:26 SUB 4 INCQUEST MIT";
$NPC["ROGUE",14,2,$CMD] = "GIVEITEM TrustyDrakescaleBoots:26 SUB 4 INCQUEST MIT";
$NPC["ROGUE",14,3,$CMD] = "GIVEITEM StainlessDiamondTalisman:26 SUB 4 INCQUEST MIT";
//=== LEVEL 30 ==============================================================================
$NPC["ROGUE",15,NEED] = "QUESTON RDF:0 HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL DEXTERITY:149 SKILL LITERACY:149";
$NPC["ROGUE",15,BOT] = "Ah you have found more tomes! Hand them over to continue your Defensive Training!";
$NPC["ROGUE",15,1,$OPT] = "Here You go!";
$NPC["ROGUE",15,1,$CMD] = "INCQUEST RDF TAKEITEM 999MossyTomeVolII TAKEITEM 999MossyTomeVolIII GIVEITEM InitiateTome:30 SUB 4";
//=== LEVEL 40 ==============================================================================
$NPC["ROGUE",16,NEED] = "HASQUEST RDF QUESTON MIT:1 LVL 40";
$NPC["ROGUE",16,BOT] = "I see you are becoming more agile, Good!\n";
$NPC["ROGUE",16,1,$OPT] = "Yes, I am learning.";
$NPC["ROGUE",16,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 1 SUB 4";
//=== LEVEL 50 ==============================================================================
$NPC["ROGUE",17,NEED] = "QUESTON RDF:1 HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL DEXTERITY:249 SKILL LITERACY:249";
$NPC["ROGUE",17,BOT] = "Ah you have found more tomes! Hand them over to continue your Defensive Training!";
$NPC["ROGUE",17,1,$OPT] = "Here You go!";
$NPC["ROGUE",17,1,$CMD] = "INCQUEST RDF TAKEITEM 999MossyTomeVolIV TAKEITEM 999MossyTomeVolV TAKEITEM 999MossyTomeVolVI GIVEITEM ScoundrelTome:50 SUB 4";
//=== LEVEL 60 ==============================================================================
$NPC["ROGUE",18,NEED] = "HASQUEST RDF QUESTON MIT:2 LVL 60";
$NPC["ROGUE",18,BOT] = "I see you are becoming more agile, Good!\nI have an item here for you, choose one.";
$NPC["ROGUE",18,1,$OPT] = "Give me the Wand.";
$NPC["ROGUE",18,2,$OPT] = "Give me the Knife.";
$NPC["ROGUE",18,3,$OPT] = "Give me the Crossbow.";
$NPC["ROGUE",18,4,$OPT] = "Give me the Martial Arts Staff.";
$NPC["ROGUE",18,1,$CMD] = "GIVEITEM ShiningCrystalWand:78 INCQUEST MIT SUB 4";
$NPC["ROGUE",18,2,$CMD] = "GIVEITEM KeenRapier:78 INCQUEST MIT SUB 4";
$NPC["ROGUE",18,3,$CMD] = "GIVEITEM HardwoodElvenCrossbow:78 INCQUEST MIT SUB 4";
$NPC["ROGUE",18,4,$CMD] = "GIVEITEM CarvedIvoryStaff:78 INCQUEST MIT SUB 4";
//=== LEVEL 70 ==============================================================================
$NPC["ROGUE",19,NEED] = "HASQUEST RDF QUESTON MIT:3 LVL 70";
$NPC["ROGUE",19,BOT] = "I see you are becoming more agile, Good!\n";
$NPC["ROGUE",19,1,$OPT] = "Yes, I am learning.";
$NPC["ROGUE",19,1,$CMD] = "INCQUEST MIT GIVEPASSIVE 1 GIVERESPEC 2 SUB 4";
//=== LEVEL 80 ==============================================================================
$NPC["ROGUE",20,NEED] = "QUESTON RDF:2 HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL DEXTERITY:399 SKILL LITERACY:399";
$NPC["ROGUE",20,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["ROGUE",20,1,$OPT] = "Here You go!";
$NPC["ROGUE",20,1,$CMD] = "INCQUEST RDF TAKEITEM 999DustyTomeVolI TAKEITEM 999DustyTomeVolII TAKEITEM 999DustyTomeVolIII TAKEITEM 999DustyTomeVolIV GIVEITEM PickpocketTome:80 SUB 4";
//=== LEVEL 90 ==============================================================================
$NPC["ROGUE",21,NEED] = "HASQUEST RDF QUESTON MIT:4 LVL 90";
$NPC["ROGUE",21,BOT] = "I see you are becoming more agile, Good!\nI have an item here for you, choose one.";
$NPC["ROGUE",21,1,$OPT] = "Give me the Mystic Relic.";
$NPC["ROGUE",21,2,$OPT] = "Give me the Rune Prism.";
$NPC["ROGUE",21,3,$OPT] = "Give me the Regret Relic.";
$NPC["ROGUE",21,3,$OPT] = "Give me the Anarchy Relic.";
$NPC["ROGUE",21,1,$CMD] = "GIVEITEM MysticRelic:999 INCQUEST MIT SUB 4";
$NPC["ROGUE",21,2,$CMD] = "GIVEITEM RunePrism:999 INCQUEST MIT SUB 4";
$NPC["ROGUE",21,3,$CMD] = "GIVEITEM RegretRelic:999 INCQUEST MIT SUB 4";
$NPC["ROGUE",21,3,$CMD] = "GIVEITEM AnarchyRelic:999 INCQUEST MIT SUB 4";
//=== LEVEL 100 ==============================================================================
$NPC["ROGUE",22,NEED] = "QUESTON RDF:3 HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL DEXTERITY:499 SKILL LITERACY:499";
$NPC["ROGUE",22,BOT] = "Ah you have found more tomes! Hand them over to continue your Offensive Training!";
$NPC["ROGUE",22,1,$OPT] = "Here You go!";
$NPC["ROGUE",22,1,$CMD] = "INCQUEST RDF TAKEITEM 999DustyTomeVolV TAKEITEM 999DustyTomeVolVI TAKEITEM 999DustyTomeVolVII TAKEITEM 999DustyTomeVolVIII GIVEITEM BanditTome:100 SUB 4";

function TestMasters(%id)
{
	if (%id == "") %id = 2049;

	$PlayerBackpack[%id] = "";

	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999MossyTomeVolI 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999MossyTomeVolII 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999MossyTomeVolIII 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999MossyTomeVolIV 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999MossyTomeVolV 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999MossyTomeVolVI 1 ";

	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999DustyTomeVolI 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999DustyTomeVolII 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999DustyTomeVolIII 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999DustyTomeVolIV 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999DustyTomeVolV 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999DustyTomeVolVI 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999DustyTomeVolVII 1 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999DustyTomeVolVIII 1 ";

	$PlayerQuests[%id] = "TOM 0 ";
}