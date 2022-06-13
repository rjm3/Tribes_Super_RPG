// CRU QUEST

function CQI(%item,%ico,%desc)
{
	%new = "";
	for (%i = 0; (%g = getWord(%item,%i)) != -1; %i++)
		%new = %new @ %g;
	$DynamicItem[%new,$DName] = %item;
	$DynamicItem[%new,$DIco] = %ico;
	$DynamicItem[%new,$DMinMax] = "999 999";
	$DynamicItem[%new,$DWeight] = "1 0";
	$DynamicItem[%new,$DPrice] = "1 0";
	$DynamicItem[%new,$DDesc] = %desc;
	$DynamicItem[%new,$DItemType] = "0 Quest Item";
	DynamicItem::CheckItemCreate(%new,999);
}
// $PlayerBackpack[2051] = "999DarkTempleKey 99 ";
function TestQuestItems(%id)
{
	$PlayerBackpack[%id] = "999DarkTempleKey 99 ";
	$PlayerBackpack[%id] = $PlayerBackpack[2049] @ "999DarkGateKeyI 99 ";
	$PlayerBackpack[%id] = $PlayerBackpack[2049] @ "999DarkGateKeyII 99 ";
	$PlayerBackpack[%id] = $PlayerBackpack[2049] @ "999DarkGateKeyIII 99 ";
	$PlayerBackpack[%id] = $PlayerBackpack[2049] @ "999DarkGateKeyIV 99 ";
	$PlayerBackpack[%id] = $PlayerBackpack[2049] @ "999DarkGateKeyV 99 ";
}

CQI("Goblin Head","","This nasty severed goblin head is bleeding all over your gear.. Lets return it quick");
CQI("Forest Key Fragment","","A fragment to what looks like some sort of Key");
CQI("Dark Temple Key","ico_darkkey.bmp","A key to the Dark Temple");
CQI("Dark Gate Key I","ico_darkkey.bmp","This key opens the First gate in the Dark Temple");
CQI("Dark Gate Key II","ico_darkkey.bmp","This key opens the Second gate in the Dark Temple");
CQI("Dark Gate Key III","ico_darkkey.bmp","This key opens the Third gate in the Dark Temple");
CQI("Dark Gate Key IV","ico_darkkey.bmp","This key opens the Fourth gate in the Dark Temple");
CQI("Dark Gate Key V","ico_darkkey.bmp","This key opens the Fifth gate in the Dark Temple");

CQI("Mossy Tome Vol I","ico_mossytome.bmp","This Tome is covered in moss");
CQI("Mossy Tome Vol II","ico_mossytome.bmp","This Tome is covered in moss");
CQI("Mossy Tome Vol III","ico_mossytome.bmp","This Tome is covered in moss");
CQI("Mossy Tome Vol IV","ico_mossytome.bmp","This Tome is covered in moss");
CQI("Mossy Tome Vol V","ico_mossytome.bmp","This Tome is covered in moss");
CQI("Mossy Tome Vol VI","ico_mossytome.bmp","This Tome is covered in moss");

CQI("Dusty Tome Vol I","ico_dustytome.bmp","This Tome is covered in dust");
CQI("Dusty Tome Vol II","ico_dustytome.bmp","This Tome is covered in dust");
CQI("Dusty Tome Vol III","ico_dustytome.bmp","This Tome is covered in dust");
CQI("Dusty Tome Vol IV","ico_dustytome.bmp","This Tome is covered in dust");
CQI("Dusty Tome Vol V","ico_dustytome.bmp","This Tome is covered in dust");
CQI("Dusty Tome Vol VI","ico_dustytome.bmp","This Tome is covered in dust");
CQI("Dusty Tome Vol VII","ico_dustytome.bmp","This Tome is covered in dust");
CQI("Dusty Tome Vol VIII","ico_dustytome.bmp","This Tome is covered in dust");

CQI("Moldy Tome Vol I","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol II","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol III","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol IV","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol V","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol VI","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol VII","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol VIII","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol IX","ico_moldytome.bmp","This Tome is covered in mold");
CQI("Moldy Tome Vol X","ico_moldytome.bmp","This Tome is covered in mold");

CQI("Frosted Tome Vol I","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol II","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol III","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol IV","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol V","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol VI","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol VII","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol VIII","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol IX","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol X","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol XI","ico_frostedtome.bmp","This Tome is covered in frost");
CQI("Frosted Tome Vol XII","ico_frostedtome.bmp","This Tome is covered in frost");

CQI("Charred Tome Vol I","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol II","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol III","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol IV","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol V","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol VI","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol VII","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol VIII","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol IX","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol X","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol XI","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol XII","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol XIII","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol XIV","ico_charredtome.bmp","This Tome is charred and crispy");
CQI("Charred Tome Vol XV","ico_charredtome.bmp","This Tome is charred and crispy");

//=================================================================================================

$CRUQUEST["DEL",NAME] = "Cleaning The Cellar";
$CRUQUEST["DEL",0,INFO] = "Delina wants you to go down into the Old Cellar in town. Kill one of the goblin Leaders, and bring back his head";
$CRUQUEST["DEL",0,REQ] = "HASITEM 999GoblinHead LVL 5";

$CRUQUEST["TOM",NAME] = "The Tomes";
$CRUQUEST["TOM",0,INFO] = "Find a use for this ancient looking Tome Delina gave you";
$CRUQUEST["TOM",0,REQ] = "HASITEM 999MossyTomeVolI LVL 10";

$CRUQUEST["FKY",NAME] = "The Forest Key";
$CRUQUEST["FKY",0,INFO] = "Recover the missing key";

$CRUQUEST["SMT",NAME] = "Master Smith";
$CRUQUEST["SMT",0,INFO] = "Find the missing Mossy Tomes and deliver them to the Old Smith";
$CRUQUEST["SMT",0,REQ] = "HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL Literacy:300 HASSTUFF 999Dust:100";
$CRUQUEST["SMT",1,INFO] = "Find the missing Mossy Tomes and deliver them to the Old Smith";
$CRUQUEST["SMT",1,REQ] = "HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL Literacy:500 HASSTUFF 999Dust:200";
$CRUQUEST["SMT",2,INFO] = "Find the missing Dusty Tomes and deliver them to the Old Smith";
$CRUQUEST["SMT",2,REQ] = "HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL Literacy:800 HASSTUFF 999Dust:300";
$CRUQUEST["SMT",3,INFO] = "Find the missing Dusty Tomes and deliver them to the Old Smith";
$CRUQUEST["SMT",3,REQ] = "HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL Literacy:1000 HASSTUFF 999Dust:400";

$CRUQUEST["WOF",NAME] = "Warrior Master Offensive";
$CRUQUEST["WOF",0,INFO] = "Find the missing Mossy Tomes and deliver them to the Warrior Master";
$CRUQUEST["WOF",0,REQ] = "HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL Strength:149 SKILL Literacy:149";
$CRUQUEST["WOF",1,INFO] = "Find the missing Mossy Tomes and deliver them to the Warrior Master";
$CRUQUEST["WOF",1,REQ] = "HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL Strength:249 SKILL Literacy:249";
$CRUQUEST["WOF",2,INFO] = "Find the missing Dusty Tomes and deliver them to the Warrior Master";
$CRUQUEST["WOF",2,REQ] = "HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL Strength:399 SKILL Literacy:399";
$CRUQUEST["WOF",3,INFO] = "Find the missing Dusty Tomes and deliver them to the Warrior Master";
$CRUQUEST["WOF",3,REQ] = "HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL Strength:499 SKILL Literacy:499";

$CRUQUEST["WDF",NAME] = "Warrior Master Defensive";
$CRUQUEST["WDF",0,INFO] = "Find the missing Mossy Tomes and deliver them to the Warrior Master";
$CRUQUEST["WDF",0,REQ] = "HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL Strength:149 SKILL Literacy:149";
$CRUQUEST["WDF",1,INFO] = "Find the missing Mossy Tomes and deliver them to the Warrior Master";
$CRUQUEST["WDF",1,REQ] = "HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL Strength:249 SKILL Literacy:249";
$CRUQUEST["WDF",2,INFO] = "Find the missing Dusty Tomes and deliver them to the Warrior Master";
$CRUQUEST["WDF",2,REQ] = "HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL Strength:399 SKILL Literacy:399";
$CRUQUEST["WDF",3,INFO] = "Find the missing Dusty Tomes and deliver them to the Warrior Master";
$CRUQUEST["WDF",3,REQ] = "HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL Strength:499 SKILL Literacy:499";

$CRUQUEST["MOF",NAME] = "Mage Master Offensive";
$CRUQUEST["MOF",0,INFO] = "Find the missing Mossy Tomes and deliver them to the Mage Master";
$CRUQUEST["MOF",0,REQ] = "HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL Intelligence:149 SKILL Literacy:149";
$CRUQUEST["MOF",1,INFO] = "Find the missing Mossy Tomes and deliver them to the Mage Master";
$CRUQUEST["MOF",1,REQ] = "HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL Intelligence:249 SKILL Literacy:249";
$CRUQUEST["MOF",2,INFO] = "Find the missing Dusty Tomes and deliver them to the Mage Master";
$CRUQUEST["MOF",2,REQ] = "HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL Intelligence:399 SKILL Literacy:399";
$CRUQUEST["MOF",3,INFO] = "Find the missing Dusty Tomes and deliver them to the Mage Master";
$CRUQUEST["MOF",3,REQ] = "HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL Intelligence:499 SKILL Literacy:499";

$CRUQUEST["MDF",NAME] = "Mage Master Defensive";
$CRUQUEST["MDF",0,INFO] = "Find the missing Mossy Tomes and deliver them to the Mage Master";
$CRUQUEST["MDF",0,REQ] = "HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL INTELLIGENCE:149 SKILL Literacy:149";
$CRUQUEST["MDF",1,INFO] = "Find the missing Mossy Tomes and deliver them to the Mage Master";
$CRUQUEST["MDF",1,REQ] = "HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL Intelligence:249 SKILL Literacy:249";
$CRUQUEST["MDF",2,INFO] = "Find the missing Dusty Tomes and deliver them to the Mage Master";
$CRUQUEST["MDF",2,REQ] = "HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL Intelligence:399 SKILL Literacy:399";
$CRUQUEST["MDF",3,INFO] = "Find the missing Dusty Tomes and deliver them to the Mage Master";
$CRUQUEST["MDF",3,REQ] = "HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL Intelligence:499 SKILL Literacy:499";

$CRUQUEST["ROF",NAME] = "Rogue Master Offensive";
$CRUQUEST["ROF",0,INFO] = "Find the missing Mossy Tomes and deliver them to the Rogue Master";
$CRUQUEST["ROF",0,REQ] = "HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL Dexterity:149 SKILL Literacy:149";
$CRUQUEST["ROF",1,INFO] = "Find the missing Mossy Tomes and deliver them to the Rogue Master";
$CRUQUEST["ROF",1,REQ] = "HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL Dexterity:249 SKILL Literacy:249";
$CRUQUEST["ROF",2,INFO] = "Find the missing Dusty Tomes and deliver them to the Rogue Master";
$CRUQUEST["ROF",2,REQ] = "HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL Dexterity:399 SKILL Literacy:399";
$CRUQUEST["ROF",3,INFO] = "Find the missing Dusty Tomes and deliver them to the Rogue Master";
$CRUQUEST["ROF",3,REQ] = "HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL Intelligence:499 SKILL Literacy:499";

$CRUQUEST["RDF",NAME] = "Rogue Master Defensive";
$CRUQUEST["RDF",0,INFO] = "Find the missing Mossy Tomes and deliver them to the Rogue Master";
$CRUQUEST["RDF",0,REQ] = "HASITEM 999MossyTomeVolII HASITEM 999MossyTomeVolIII LVL 30 SKILL Dexterity:149 SKILL Literacy:149";
$CRUQUEST["RDF",1,INFO] = "Find the missing Mossy Tomes and deliver them to the Rogue Master";
$CRUQUEST["RDF",1,REQ] = "HASITEM 999MossyTomeVolIV HASITEM 999MossyTomeVolV HASITEM 999MossyTomeVolVI LVL 50 SKILL Dexterity:249 SKILL Literacy:249";
$CRUQUEST["RDF",2,INFO] = "Find the missing Dusty Tomes and deliver them to the Rogue Master";
$CRUQUEST["RDF",2,REQ] = "HASITEM 999DustyTomeVolI HASITEM 999DustyTomeVolII HASITEM 999DustyTomeVolIII HASITEM 999DustyTomeVolIV LVL 80 SKILL Dexterity:399 SKILL Literacy:399";
$CRUQUEST["RDF",3,INFO] = "Find the missing Dusty Tomes and deliver them to the Rogue Master";
$CRUQUEST["RDF",3,REQ] = "HASITEM 999DustyTomeVolV HASITEM 999DustyTomeVolVI HASITEM 999DustyTomeVolVII HASITEM 999DustyTomeVolVIII LVL 100 SKILL Dexterity:499 SKILL Literacy:499";

$CRUQUEST["MIT",NAME] = "Master Rewards";
$CRUQUEST["MIT",NOCANCEL] = 1;
$CRUQUEST["MIT",0,INFO] = "Return to the Master once you have reached level 20 to receive a reward";
$CRUQUEST["MIT",0,REQ] = "LVL 20";
$CRUQUEST["MIT",1,INFO] = "Return to the Master once you have reached level 40 to receive a reward";
$CRUQUEST["MIT",1,REQ] = "LVL 40";
$CRUQUEST["MIT",2,INFO] = "Return to the Master once you have reached level 60 to receive a reward";
$CRUQUEST["MIT",2,REQ] = "LVL 60";
$CRUQUEST["MIT",3,INFO] = "Return to the Master once you have reached level 70 to receive a reward";
$CRUQUEST["MIT",3,REQ] = "LVL 70";
$CRUQUEST["MIT",4,INFO] = "Return to the Master once you have reached level 90 to receive a reward";
$CRUQUEST["MIT",4,REQ] = "LVL 90";
$CRUQUEST["MIT",5,INFO] = "Return to the Master once you have reached level 110 to receive a reward";
$CRUQUEST["MIT",5,REQ] = "LVL 110";


//=================================================================================================

function QuestReqDisplay(%id,%str)
{
	echo(" QUESTREQDISPLAY " @ %id @ " " @ %str);
	%ret = "";
	for (%i = 0; (%g = getWord(%str,%i)) != -1; %i+=2) {
		%val = getWord(%str,%i+1);
		if (%g == "HASITEM") {
			if (BackpackHasItem(%id,%val,True) == False)
				%ret = %ret @ "<f2>" @ string::Translate("Have Item " @ GetBPData(%val,$BPNAME)) @ "\n";
			else
				%ret = %ret @ "<f0>" @ string::Translate("Have Item " @ GetBPData(%val,$BPNAME)) @ "\n";
		}
		if (%g == "LVL") {
			if (fetchData(%id,"LVL") < %val)
				%ret = %ret @ "<f2>" @ string::Translate("Level from " @ %val) @ "\n";
			else
				%ret = %ret @ "<f0>" @ string::Translate("Level from " @ %val) @ "\n";
		}
		if (%g == "SKILL") {
			%skill = String::getWord(%val,":",0);
			%v = String::getWord(%val,":",1);
			%rcrop = $BPSkillToNumeric[%skill];
			if (GetPlayerSkill(%id,%rcrop) < %v)
				%ret = %ret @ "<f2>" @ string::Translate(%skill @ " from " @ %v) @ "\n";
			else
				%ret = %ret @ "<f0>" @ string::Translate(%skill @ " from " @ %v) @ "\n";
		}
		if (%g == "HASSTUFF") {
			%item = String::getWord(%val,":",0);
			%v = String::getWord(%val,":",1);
			echo(" ITEM <" @ %item @ "> COUNT <" @ %v @ ">");
			if (HasBackpackCount(%id,%item,%v) == False)
				%ret = %ret @ "<f2>" @ string::Translate("Have Items " @ GetBPData(%item,$BPNAME) @ " " @ %v) @ "\n";
			else
				%ret = %ret @ "<f0>" @ string::Translate("Have Items " @ GetBPData(%item,$BPNAME) @ " " @ %v) @ "\n";
		}
	}
	return %ret;
}

function fetchQuestData(%quest,%data)
{
	return $CRUQUEST[%quest,%data];
}

function HasCruQuest(%id,%quest,%on)
{
	if (%on == "") %on = -1;
	%list = $PlayerQuests[%id];
	if (%list == "") return False;
	for (%i = 0; (%q = getWord(%list,%i)) != -1; %i+=2) {
		if (%q == %quest) {
			%v = getWord(%list,%i+1);
			if (%v == %on || %on == -1 || %on == "")
				return True;
		}
	}
	return False;
}

function OnCruQuest(%id,%quest)
{
	%list = $PlayerQuests[%id];
	if (%list == "") return -1;
	for (%i = 0; (%q = getWord(%list,%i)) != -1; %i+=2) {
		if (%q == %quest)
			return getWord(%list,%i+1);
	}
	return -1;
}

function CompleteCruQuest(%id,%quest,%on)
{
	if (%on == "") %on = -1;
	if (HasCruQuest(%id,%quest,%on) == True) {
		%new = "";
		%list = $PlayerQuests[%id];
		for (%i = 0; (%q = getWord(%list,%i)) != -1; %i+=2) {
			%v = getWord(%list,%i+1);
			if (%q != %quest)
			 	%new = %new @ %q @ " " @ %v @ " ";
		}
		$PlayerQuests[%id] = %new;
		$PlayerCruComplete[%id] = $PlayerCruComplete[%id] @ %quest @ " ";
		Client::SendMessage(%id,2,"You have completed quest: " @ fetchQuestData(%quest,NAME));
		CruQuestBonus(%id,%quest);
	}
}

function RemoveCruQuest(%id,%quest,%on)
{
	if ($CRUQUEST[%quest,NOCANCEL] == 1) {
		Client::SendMessage(%id,2,"You can not cancel this quest.");
		return;
	}
	if (%id.CantCancelQuest) {
		Client::SendMessage(%id,2,"You cant cancel a quest while talking to an NPC.");
		return;
	}
	if (%on == "") %on = -1;
	if (HasCruQuest(%id,%quest,%on) == True) {
		%new = "";
		%list = $PlayerQuests[%id];
		for (%i = 0; (%q = getWord(%list,%i)) != -1; %i+=2) {
			%v = getWord(%list,%i+1);
			if (%q != %quest)
			 	%new = %new @ %q @ " " @ %v @ " ";
		}
		$PlayerQuests[%id] = %new;
		Client::SendMessage(%id,1,"Canceled Quest: " @ fetchQuestData(%quest,NAME));
	}
}

function CruQuestBonus(%id,%quest)
{
	return;
}

function CruQuestCompleted(%id,%quest)
{
	%list = $PlayerCruComplete[%id];
	if (%list == "") return False;
	for (%i = 0; (%q = getWord(%list,%i)) != -1; %i++) {
		if (%q == %quest)
			return True;
	}
	return False;
}

function AddCruQuest(%id,%quest,%on,%set)
{
	if (%on == "") %on = -1;
	if (HasCruQuest(%id,%quest) == False) {
		IncCruQuest(%id,%quest,%on,%set);
		Client::SendMessage(%id,2,"You have recieved a new Quest: " @ fetchQuestData(%quest,NAME)); 
	}
	return False;
}

function IncCruQuest(%id,%quest,%set)
{
	%list = $PlayerQuests[%id];
	%new = "";
	if (%list == "") {
		if (%set == "")
			$PlayerQuests[%id] = %quest @ " 0 ";
		else
			$PlayerQuests[%id] = %quest @ " " @ %set @ " ";
		return;
	}
	%found = False;
	for (%i = 0; (%q = GetWord(%list,%i)) != -1; %i+=2) {
		%v = getWord(%list,%i+1);
		if (%q == %quest) {
			%found = True;
			if (%set == "")
				%new = %new @ %quest @ " " @ (%v + 1) @ " ";
			else
				%new = %new @ %quest @ " " @ %set @ " ";
		}
		else
			%new = %new @ %q @ " " @ %v @ " ";
	}
	if (%found == False) {
		if (%set == "")
			%new = %new @ %quest @ " 0 ";
		else
			%new = %new @ %quest @ " " @ %set @ " ";
	}
	Client::SendMessage(%id,2,"Quest " @ fetchQuestData(%quest,NAME) @ " has been updated.");
	$PlayerQuests[%id] = %new;
}

function Game::menuQuest(%id,%menu)
{
	%curItem = 0;
	if (%menu == "") %menu = 0;
	Client::buildMenu(%id, "Quest Log", "quest", true);
	%list = $PlayerQuests[%id];
	for (%i = %menu; %i <= (%menu + 60); %i+=2) {
		if ((%quest = GetWord(%list,%i)) != -1)
			Client::addMenuItem(%id, GetMenuNum(%curItem++) @ fetchQuestData(%quest,NAME),%quest @ " " @ %menu);
	}
	if (getWord(%list,%menu+61) != -1)
		Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Next >>","next " @ (%menu + 62));
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "<< Back","back " @ (%menu - 62));
}

function processMenuQuest(%id,%option)
{
	%quest = getWord(%option,0);
	%menu = getWord(%option,1);
	if (%quest == "next")
		Game::menuQuest(%id,%menu);
	else if (%quest == "back") {
		if (%menu < 0)
			Game::MenuRequest(%id);
		else
			Game::menuQuest(%id,%menu);	
	}
	else
		Game::MenuQuestSelect(%id,%quest,%menu);
}

function Game::MenuQuestSelect(%id,%quest,%menu)
{
	%curItem = 0;
	%name = fetchQuestData(%quest,NAME);
	if (%name == "") return;
	ShowCruQuestStatus(%id,%quest);
	Client::buildMenu(%id, %name, "questselect", true);
	Client::addmenuItem(%id,%curItem++ @ "Quest Info..","info " @ %quest @ " " @ %menu);
	Client::addmenuItem(%id,"xCancel Quest..","cancel " @ %quest @ " " @ %menu);
	Client::addMenuItem(%id,"b<< Back","back NA " @ %menu);
}

function processMenuQuestSelect(%id,%option)
{
	%type = getWord(%option,0);
	%quest = getWord(%option,1);
	%menu = getWord(%option,2);
	if (%type == "back")
		Game::menuQuest(%id,%menu);
	if (%type == "info") {
		//ShowCruQuestStatus(%id,%quest);
		Game::MenuQuestSelect(%id,%quest,%menu);
	}
	if (%type == "cancel") {
		RemoveCruQuest(%id,%quest);
		Game::menuQuest(%id,%menu);
	}		
}

function ShowCruQuestStatus(%id,%quest)
{
	%on = OnCruQuest(%id,%quest);
	if (%on == -1) return;
	%msg = " <jc>\n<f0>Quest: " @ fetchQuestData(%quest,NAME) @ "\n\n";
	%msg = %msg @ "<f1>" @ $CRUQUEST[%quest,%on,INFO] @ "\n\n";
	%msg = %msg @ "<f0>Turn In Requirements: \n" @ QuestReqDisplay(%id,$CRUQUEST[%quest,%on,REQ]) @ "\n";
	SendBufferBP(%id, %msg, 30);
}

exec("backpack_masters.cs");

echo("__CRU QUEST LOADED");