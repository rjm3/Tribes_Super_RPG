// CRUSPELL 

$CSQuality 	= 0;
$CSName 	= 1;
$CSTrigger 	= 2;
$CSMustLearn 	= 3;
$CSLearnReqs 	= 4;
$CSReqs 	= 5;
$CSMode 	= 6;
$CSTree 	= 7;
$CSCastTime 	= 8;
$CSRecovery 	= 9;
$CSDur 		= 10;
$CSHaveReqs 	= 11;
$CSTake 	= 12;
$CSBonus 	= 13;
$CSInfo 	= 14;
$CSDOT 		= 15;
$CSHostile 	= 16;
$CSFriendly	= 17;
$CSRange 	= 18;
$CSBreakOnDmg	= 19;
$CSBreakOnDo	= 20;
$CSAffects	= 21;
$CSOffense 	= 22;
$CSDefense	= 23;
$CSSCUCost	= 24;
$CSMana		= 25;
$CSCategory	= 26;
$CSSC		= 27;
$CSMinCast	= 28;
$CSRange	= 29;
$CSCritChance	= 30;
$CSCritDamage	= 31;
$CSMinCast	= 32;
$CSMinRecovery	= 33;
$CSDamageMod	= 34;
$CSIco		= 35;
$CSHostileBonus	= 36;
$CSEndOnNoMana	= 37;
$CSMinCooldown	= 38;
$CSSilent	= 39;
$CSUnCast	= 40;

$CDOTInterval 	= 1;
$CDOTHits 	= 2;
$CDOTBonus 	= 3;
$CDOTAnim	= 4;

$SpellOffensive	= 1;
$SpellDefensive = 2;
$SpellNeutral	= 3;
$SpellDivine	= 4;

function DurToSec(%hour,%min,%sec)
{
	return ((%hour * 3600) + (%min * 60) + %sec);
}

//======================================================================================================================================

$CruSpell[Newbie,$CSName] 		= "Newbie";
$CruSpell[Newbie,$CSCategory] 		= $SpellNeutral;
$CruSpell[Newbie,$CSMustLearn] 		= 999;
$CruSpell[Newbie,$CSReqs] 		= "Sorcery 0 MANA 0";
$CruSpell[Newbie,$CSMode] 		= "SELF";
$CruSpell[Newbie,$CSTree] 		= "Newbie 1";
$CruSpell[Newbie,$CSCastTime] 		= 5;
$CruSpell[Newbie,$CSRecovery] 		= 5;
$CruSpell[Newbie,$CSDur] 		= DurToSec(0,30,0);
$CruSpell[Newbie,$CSHaveReqs] 		= "LVLL 5";
$CruSpell[Newbie,$CSTake] 		= "MANA 0";
$CruSpell[Newbie,$CSBonus] 		= "MAXHP 500 MAXMANA 500 ADDALLDEF 150 ADDALLOFF 150";
$CruSpell[Newbie,$CSInfo] 		= "This spell was designed to help new players get a better head start";
$CruSpell[Newbie,$CSAnimation] 		= "ANIM_BODY_NEU";
$CruSpell[Newbie,$CSSC] 		= 0;

//======================================================================================================================================

function AddToFavList(%id,%spell)
{
	%str = $PlayerFavList[%id];
	if ((%name = $CruSpell[%spell,$CSName]) == "") {
		Client::SendMessage(%id,0,"Unknown spell: " @ %spell);
		return;
	}
	if (%str == "") {
		Client::SendMessage(%id,0,%name @ " added to Favorites List. #fav #rfav");
		$PlayerFavList[%id] = %spell @ " ";
		return;
	}
	if (word::FindWord(%str,%spell) != -1) {
		Client::SendMessage(%id,0,%name @ " is already on your Favorites List. #fav #rfav");
		return;
	}
	else {
		if (getWord(%str,29) != -1) {
			Client::SendMessage(%id,0,"Your Favorites List is full. #fav #rfav");
			return;
		}
		else {
			$PlayerFavList[%id] = $PlayerFavList[%id] @ %spell @ " ";
			Client::SendMessage(%id,0,%name @ " added to Favorites List. #fav #rfav");
		}
	}	
}

function RemoveFromFavList(%id,%spell)
{
	%str = $PlayerFavList[%id];
	%name = $CruSpell[%spell,$CSName];
	if (word::FindWord(%str,%spell) == -1) {
		Client::SendMessage(%id,0,%name @ " is not on your Favorites List. #fav #rfav");
		return;
	}
	%str = String::RemoveWords(%str,%spell);
	Client::SendMessage(%id,0,%name @ " was removed from your Favorites List. #fav #rfav");
	$PlayerFavList[%id] = %str;
}

function Game::MenuFavList(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Favorite Spells", "favlist", true);
	%list = $PlayerFavList[%id];
	for (%i = 0; %i <= 29; %i++) {
		if ((%item = GetWord(%list,%i)) != -1) {
			%name = $CruSpell[%item,$CSName];
			Client::addMenuItem(%id, GetMenuNum(%curItem++) @ %name,%i);
		}
	}
}

function processMenufavlist(%id,%option)
{	
	%list = $PlayerFavList[%id];
	%item = GetWord(%list,%option);
	if (%item != -1)
		CastCruSpell(%id,%item);
	Game::MenuFavList(%id);
}

function Game::MenuRemoveFavList(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Remove Favorite Spell", "remfavlist", true);
	%list = $PlayerFavList[%id];
	for (%i = 0; %i <= 29; %i++) {
		if ((%item = GetWord(%list,%i)) != -1) {
			%name = $CruSpell[%item,$CSName];
			Client::addMenuItem(%id, GetMenuNum(%curItem++) @ %name,%i);
		}
	}
}

function processMenuremfavlist(%id,%option)
{	
	%list = $PlayerFavList[%id];
	%item = GetWord(%list,%option);
	if (%item != -1)
		RemoveFromFavList(%id,%item);
	Game::MenuRemoveFavList(%id);
}

//======================================================================================================================================

function TestCruBomb(%id,%b)
{
	FocusServer();
	%pos = gamebase::GetPosition(%id);
	CruSpellBomb(%id,%pos,%b);
}

function TestFocusMenu(%v)
{
	if (%v == 1) {
		$CurPlayerSpells[2049] = "Test1 1 Test2 2 Test3 3 Test4 4 Test5 5 Test6 7 Test7 7 Test8 8 Test9 9 Test10 10 Test11 11 Test12 12 Test13 13 Test14 14 Test15 15 Test16 16 Test17 17 Test18 18 Test19 19 Test20 20 Test21 21 Test22 22 Test23 23 Test23 23 Test23 23 Test23 23 Test23 23 Test23 23 Test23 23 Test23 23 Test23 23 Test23 23";
	}
	else {
		$CurPlayerSpells[2049] = "";
	}
}

function Game::MenuFocus(%id,%list)
{
	%curItem = 0;
	Client::buildMenu(%id, "Current Memory (" @ fetchdata(%id,"CurSC") @ "/" @ fetchdata(%id,"MaxSC") @ ")", "focus", true);
	%cur = $CurPlayerSpells[%id] @ " " @ $RunningActions[%id];
	%flist = %list;
	for (%i = %flist; %i <= (%flist + 60); %i+= 2) {
		if ((%spell = getWord(%cur,%i)) != -1) {
			%time = DisplaySpellRemainTime(%id,%spell);
			if ($CruAction[%spell,$CAName] != "")
				Client::addMenuItem(%id, GetMenuNum(%curItem++) @ $CruAction[%spell,$CAName] @ " " @ %time,"focus " @ %spell @ " " @ %list);
			else
				Client::addMenuItem(%id, GetMenuNum(%curItem++) @ $CruSpell[%spell,$CSName] @ " " @ %time,"focus " @ %spell @ " " @ %list);
		}
	}
	if (getWord(%cur,(%list + 61)) != -1) {
		Client::addMenuItem(%id, %curItem++ @ "Next >>","next " @ (%list + 12));
	}
	Client::addMenuItem(%id, %curItem++ @ "<< Prev","back " @ %list);
}

function processMenuFocus(%id,%option)
{
	%v = getWord(%option,0);
	%s = getWord(%option,1);
	%p = getWord(%option,2);
	if (%v == "back") {
		if (%s == 0)
			Game::MenuRequest(%id);
		else
			Game::MenuFocus(%id,(%s - 12));
	}
	if (%v == "next") {
		Game::MenuFocus(%id,%s);
	}
	if (%v == "focus") {
		Game::MenuSelectFocus(%id,%s,%p);
	}
}

function Game::MenuSelectFocus(%id,%spell,%list)
{
	%curItem = 0;
	if ($CruAction[%spell,$CAName] != "")
		Client::buildMenu(%id, $CruAction[%spell,$CAName], "selectfocus", true);
	else
		Client::buildMenu(%id, $CruSpell[%spell,$CSName], "selectfocus", true);
	Client::addMenuItem(%id, %curItem++ @ "Info...","info " @ %spell @ " " @ %list);
	Client::addMenuItem(%id, %curItem++ @ "Remove...","rem " @ %spell);
	Client::addMenuItem(%id, %curItem++ @ "<< Prev","back " @ %list);
}

function processMenuSelectFocus(%id,%option)
{
	%v = getWord(%option,0);
	%s = getWord(%option,1);
	%p = getWord(%option,2);
	if (%v == "back")
		Game::MenuFocus(%id,%s);
	if (%v == "rem")
		ManualEndSpellAction(%id,%s);
	if (%v == "info") {
		if ($CruAction[%s,$CAName] != "")
			WhatIsCruAction(%id,%s);
		else
			WhatIsCruSpell(%id,%s);
		Game::MenuSelectFocus(%id,%s,%p);
	}
}

//======================================================================================================================================

function Game::MenuSpells(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Spells", "spells", true);
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Primal Magic","cat PrimalMagic 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Holy Magic","cat HolyMagic 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Empowerment","cat Empowerment 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Dark Magic","cat DarkMagic 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Light Magic","cat LightMagic 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Ritual","cat Ritual 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Sorcery","cat Sorcery 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Protection","cat Protection 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Enchantment","cat Enchantment 1");
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "<< Prev","back");
}

function processMenuSpells(%id,%option)
{
	%v = getWord(%option,0);
	%s = getWord(%option,1);
	%start = getWord(%option,2);
	if (%v == "cat")
		Game::MenuSelectSpellType(%id,%s,%start);
	if (%v == "back")
		Game::menuRequest(%id);
}

function Game::MenuSelectSpellType(%id,%t,%start)
{	
	%curItem = 0;
	%end = %start + 29;
	Client::buildMenu(%id, %t, "spelltype", true);
	for (%i = %start; %i <= %end; %i++)
		if ((%g = $SpellCatList[%t,%i]) != "") Client::addMenuItem(%id, GetMenuNum(%curItem++) @ %g,"cat " @ %g @ " " @ %start @ " " @ %t);
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "<< Prev","back");
}

function processMenuSpellType(%id,%option)
{
	%v = getWord(%option,0);
	%s = getWord(%option,1);
	%start = getWord(%option,2);
	%t = getWord(%option,3);
	if (%v == "cat")
		Game::MenuListCat(%id,%s,%start,%t);
	if (%v == "back")
		Game::MenuSpells(%id);
}

function Game::MenuListCat(%id,%cat,%start,%t)
{
	%curItem = 0;
	Client::buildMenu(%id, %cat, "listcat", true);
	%n = $CruSpellCategory[%cat,0];
	for (%i = %n; %i >= 1; %i--) {
		%spell = $CruSpellCategory[%cat,%i];
		if ((%spell = $CruSpellCategory[%cat,%i]) != "") {
			%name = $CruSpell[%spell,$CSName];
			if (HasLearnedSpell(%id,%spell) == true)
				Client::addMenuItem(%id, GetMenuNum(%curItem++) @ string::translate(%name),"sel " @ %spell @ " " @ %start @ " " @ %t @ " " @ %cat);
			else
				Client::addMenuItem(%id, GetMenuNum(%curItem++) @ %name,"sel " @ %spell @ " " @ %start @ " " @ %t @ " " @ %cat);	
		}
	}
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "<< Prev","back na " @ %start @ " " @ %t);
}

function processMenuListCat(%id,%option)
{
	%v = getWord(%option,0);
	%s = getWord(%option,1);
	%start = getWord(%option,2);
	%t = getWord(%option,3);
	%cat = getWord(%option,4);
	if (%v == "sel")
		Game::MenuSelCat(%id,%s,%start,%t,%cat);
	if (%v == "back")
		Game::MenuSelectSpellType(%id,%t,%start);
}

function Game::MenuSelCat(%id,%spell,%start,%t,%cat)
{
	WhatIsCruSpell(%id,%spell);
	%curItem = 0;
	Client::buildMenu(%id, %spell, "selcat", true);
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Cast...","cast " @ %spell @ " " @ %start @ " " @ %t @ " " @ %cat);
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Info...","info " @ %spell @ " " @ %start @ " " @ %t @ " " @ %cat);
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Add To Favorites...","fav " @ %spell @ " " @ %start @ " " @ %t @ " " @ %cat);
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "Bind To Key...","bind " @ %spell);
	Client::addMenuItem(%id, GetMenuNum(%curItem++) @ "<< Prev","back na " @ %start @ " " @ %t @ " " @ %cat);
}

function processMenuSelCat(%id,%option)
{
	%v = getWord(%option,0);
	%s = getWord(%option,1);
	%start = getWord(%option,2);
	%t = getWord(%option,3);
	%cat = getWord(%option,4);
	if (%v == "cast") {
		if ((%name = $CruSpell[%s,$CSName]) != "") {
			Client::SendMessage(%id,2,"Attempting to cast " @ %name @ "...");
			CastCruSpell(%id,%s);
		}
		Game::MenuSelCat(%id,%s,%start,%t,%cat);
	}
	if (%v == "fav") {
		if ((%name = $CruSpell[%s,$CSName]) != "") {
			Client::SendMessage(%id,2,"Adding " @ %name @ " to Favorites (#fav)...");
			AddToFavList(%id,%s);
		}
		Game::MenuSelCat(%id,%s,%start,%t,%cat);
	}
	if (%v == "info") {
		//if ((%name = $CruSpell[%s,$CSName]) != "")
			//WhatIsCruSpell(%id,%s);
		Game::MenuSelCat(%id,%s,%start,%t,%cat);
	}
	if (%v == "back")
		Game::MenuListCat(%id,%cat,%start,%t);
	if (%v == "bind") {
		if ((%name = $CruSpell[%s,$CSName]) != "") {
			%id.Bind = %s;
			%id.BindType = "SPELL";
			Game::MenuBind(%id);
		}
	}		
}

//======================================================================================================================================

function LearnSpell(%id,%spell)
{
	%req = $CruSpellNTR[%spell];
	%n = $CruSpellNTN[%spell];
	if (%n == "")
		return False;
	%list = $PlayerSpells[%id,%req];
	%s = string::GetSubStr(%list,0,(%n-1));
	%e = string::GetSubStr(%list,%n,9999);
	%new = %s @ "1" @ %e;
	$PlayerSpells[%id,%req] = %new;
	Client::SendMessage(%id,2,"You have learned spell: " @ $CruSpell[%spell,$CSName]);
}

function HasLearnedSpell(%id,%spell,%req)
{
	if (%req == "")
		%req = $CruSpellNTR[%spell];
	%n = $CruSpellNTN[%spell];
	if (%n == "")
		return False;
	%list = $PlayerSpells[%id,%req];
	%h = string::getSubStr(%list,(%n-1),1);
	//echo(" @@@ " @ $CruSpell[%spell,$CSMustLearn]);
	if (%h == 1 || $CruSpell[%spell,$CSMustLearn] == 999)
		return True;
	else
		return False;
}

function CreateSpellSaveList(%id,%req,%start,%end)
{
	%list = $PlayerSpells[%id,%req];
	return string::getSubStr(%list,%start,%end);
}

//======================================================================================================================================

// DO OVER TIME (DOT)

function StartDOT(%id,%dot,%spell,%spellid,%connectId,%caster,%casterconnect)
{
	%interval = $CruDOT[%dot,$CDOTInterval];
	%hits = $CruDOT[%dot,$CDOTHits];

	//echo(" INTERVAL " @ %interval @ " HITS " @ %hits @ " CASTER " @ %caster @ " CASTERCONNECT " @ %casterconnect);

	$DotInit[%id,%dot] = %caster;
	$DotInitConnect[%id,%dot] = %casterconnect;

	%n = 0.0;
	for (%i = 1; %i <= %hits; %i++) {
		schedule("DOT("@%id@",\""@%dot@"\",\""@%spell@"\","@%spellid@","@%connectid@","@%caster@","@%casterconnect@");",%n);
		%n += %interval;
	}
}

function DOT(%id,%dot,%spell,%spellid,%connectid,%caster,%casterconnect)
{
	//echo(" >> DOT >> " @ %id @ " " @ %dot @ " " @ %spell @ " " @ %spellid @ " " @ %connectid @ " " @ %caster @ " " @ %casterconnect);
	%curconnect = GetConnectionId(%id);
	if (%curconnect != %connectId)
		return False;
	%cur = $CurPlayerSpells[%id];
	for (%i = 0; (%get = getWord(%cur,%i)) != -1; %i += 2) {
		if (%get == %spell) {
			%sid =  getWord(%cur,%i + 1);
			if (%sid == %spellId) {
				if (IsDead(%id))
					return;
				HitDOT(%id,%dot,%caster,%casterconnect);
				if ((%b = $CruDOT[%dot,$CDOTAnim]) != "") {
					%castPos = Gamebase::GetPosition(%id);
					%player = Client::getOwnedObject(%id);
					%bomb = newObject("", "Mine", %b);
					addToSet("MissionCleanup", %bomb);
					GameBase::Throw(%bomb, %player, 0, false);
					GameBase::setPosition(%bomb, %castPos);
				}
			}
		}
	}
}

function DOTAnimation(%anim)
{
	return;
}

function HitDOT(%id,%dot,%caster,%casterconnect) 
{
	//echo(" HIT DOT >> " @ %id @ " " @ %dot @ " " @ %caster @ " " @ %casterconnect);
	if (isDead(%id) || aiIsDead(%id) == True)
		return;
	%b = $CruDOT[%dot,$CDOTBonus];
	for (%i = 0; (%hit = getWord(%b,%i)) != -1; %i+=2) {
		%t = getWord(%b,%i+1);
		if (%hit == "HEAL") {
			%mid = string::findSubStr(%t,"..");
			%min = string::getSubStr(%t,0,%mid);
			%max = string::getSubStr(%t,(%mid + 2),999);
			%roll = round(getRandom() * (%max - %min) + %min);
			%hp = fetchData(%id, "HP");
			%maxhp = fetchData(%id, "MaxHP");
			if (%hp < %maxhp) {
				refreshHP(%id, ((%roll / 100) * -1));
				Client::SendMessage(%id,0,"You were healed for " @ %roll @ " points.");
				//DOTAnimation(%id,"HEAL");
			}
		}
		if (%hit == "HEALMANA") {
			%mid = string::findSubStr(%t,"..");
			%min = string::getSubStr(%t,0,%mid);
			%max = string::getSubStr(%t,(%mid + 2),999);
			%roll = floor((getRandom() * ((%max + 1) - %min) + %min));
			%mp = fetchData(%id,"MANA");
			%maxmp = fetchData(%id,"MaxMANA");
			if (%mp < %maxmp) {
				refreshMANA(%id,(%roll * -1));
				Client::SendMessage(%id,0,"You recieved " @ %roll @ " points of mana.");
				//DOTAnimation(%id,"HEAL");
			}
		}
		if (%hit == "DRAINMANA") {
			%mid = string::findSubStr(%t,"..");
			%min = string::getSubStr(%t,0,%mid);
			%max = string::getSubStr(%t,(%mid + 2),999);
			%roll = floor((getRandom() * ((%max + 1) - %min) + %min));
			if ((%r = GetBonus(%id,$BPMANACOST)) > 0)
				%roll = (%roll - round(%roll * (%r / 100)));
			%mp = fetchData(%id,"MANA");
			%maxmp = fetchData(%id,"MaxMANA");
			if (%mp > 0) {
				refreshMANA(%id,(%roll * 1));
			}
		}
		if (%hit == "AOECAST") {
			AOECast(%id,%caster,%t,False);
		}
		if (%hit == "TEAMAOECAST") {
			AOECast(%id,%caster,%t,True);
		}
		
		if (string::findSubStr(%hit,"SelfDamage:") != -1) {
			%mid = string::findSubStr(%hit,":");
			%type = string::getSubStr(%hit,(%mid + 1),255);
			%mid = string::findSubStr(%t,"..");
			%min = string::getSubStr(%t,0,%mid);
			%max = string::getSubStr(%t,(%mid + 2),255);
			%value = RandBetween(%min,%max);
			Player::ManualDamage(%caster,%id,%value,False,True,%type,False);
		}
		if (string::findSubStr(%hit,"AOEDamageSpell:") != -1) {
			%mid = string::findSubStr(%hit,":");
			%damagetype = string::getSubStr(%hit,(%mid + 1),255);
			%hard = 1;
			if ((%dmid = string::findSubStr(%t,"%")) != -1) {
				%dtemp = %t;
				%dval = string::GetSubStr(%dtemp,0,%dmid);
				%hard = string::GetSubStr(%dtemp,(%dmid + 1),255);
				%hard = %hard / 100;
			}
			%mid = string::findSubStr(%dtemp,"..");
			%min = string::getSubStr(%dtemp,0,%mid);
			%max = string::getSubStr(%dtemp,(%mid + 2),255);
			AOEDamageSpell(%id,%caster,%min,%max,%damagetype,%hard);
		}
		if (string::findSubStr(%hit,"Damage:") != -1 && string::findSubStr(%hit,"SelfDamage:") == -1) {
			%mid = string::findSubStr(%hit,":");
			%damagetype = string::getSubStr(%hit,(%mid + 1),255);
			%mid = string::findSubStr(%t,"..");
			%min = string::getSubStr(%t,0,%mid);
			%max = string::getSubStr(%t,(%mid + 2),255);
			%value = RandBetween(%min,%max);
			Player::ManualDamage(%id,%caster,%value,False,True,%damagetype,False);
		}
		if (%hit == "TEAMDUMMY") {
			DoCastCruSpell(%caster,%t,%caster,0,0);
			if ((%t = PlayerIsInTeam(%caster)) != -1) {
				return;
			}
		}
	}
}

//======================================================================================================================================

function CastCruSpell(%id,%spell)
{
	//echo(" CASTCRUSPELL " @ %id @ " " @ %spell);
	if (CanCastCruSpell(%id,%spell,False,False) == True) {
		if (PlayerRecoverCS(%id) == False)
			StartCastCruSpell(%id,%spell);
		else
			Client::SendMessage(%id,0,"You are still recovering from your last spell.");
	}
	else
		Client::SendMessage(%id,0,"You do not meet the requirements to cast this spell.");
}

$SpellRangeInc = 99;

function BetterRunningSpell(%target,%spell)
{
	%better = False;
	%curspells = $CurPlayerSpells[%target];
	for (%i = 0; (%cspell = getWord(%curspells,%i)) != -1; %i += 2) {
		%gcastid = GetWord(%curspells,%i + 1);
		%targtree = $CruSpell[%cspell,$CSTree];
		for (%z = 0; (%gline = getWord(%targtree,%z)) != -1; %z+=2) {
			%nstack = getWord(%targtree,%z+1);
			%pstack = %stack[%gline];
			if (%pstack == "" || %nstack >= %pstack)
				%stack[%gline] = %nstack;
		}
	}
	%tree = $CruSpell[%spell,$CSTree];
	for (%z = 0; (%gline = getWord(%tree,%z)) != -1; %z+=2) {
		%gstack = GetWord(%tree,%z+1);
		if (%stack[%gline] > %gstack)
			%better = True;
	}
	return %better;
}

function StartCastCruSpell(%id,%spell)
{
	%Bomb = False;
	%pos = GameBase::GetPosition(%id);
	%range = $CruSpell[%spell,$CSRange];
	if (%range == "")
		%range = 100;
	if ((%rangeinc = GetBonus(%id,$BPCASTRANGE)) > 0) 
		%range += (%range * (%rangeinc / 100));
	%mode = $CruSpell[%spell,$CSMode];
	%hostile = $CruSpell[%spell,$CSHostile];
	%friendly = $CruSpell[%spell,$CSFriendly];
	%target = "";
	if (%hostile == "") %hostile = 0;
	if (%friendly == "") %friendly = 0;
	if (%mode == "LOS") {
		if (%hostile == 1) {
			%target = $TargetCur[%id,0];
			if (%target == "") {
				Client::SendMessage(%id,0,"You dont have a target for this spell.");
				return;
			}
		}
		if (%hostile == 0)  {
			%target = $TargetCur[%id,1];
			if (%target == "") {
				Client::SendMessage(%id,0,"You dont have a target for this spell.");
				return;
			}
		}
	}
	if (%mode == "TEAM")
		%target = %id;
	if (%mode == "SELF")
		%target = %id;

	if (%target == "") {
		Client::SendMessage(%id,0,"You dont have a target for this spell.");
		return;
	}	

	if (%mode == "BOMB") {
		%Bomb = True;
		if (GameBase::getLOSinfo(Client::getOwnedObject(%id),30)) {
			%lospos = $los::position;
		}
		else {
			Client::SendMessage(%id,0,"Target position is out of range.");
			return;
		}
	}
	if (%mode == "LOS") {
		%targetPos = GameBase::getPosition(%target);
		%idPos = GameBase::getPosition(%id);
		if (Vector::GetDistance(%targetPos,%idPos) > %range) {
			Client::SendMessage(%id,0,"Target is out of range.");
			return;
		}
		if (Targeting::LosCheck(%id,%target) == True) {
			Client::SendMessage(%id,0,"You have no line of sight to your target.");
			return;
		}
		// --------------------------------------------------------------------------------
		// Z CHECK
		%idz = GetWord(GameBase::GetPosition(%id),2);
		%targz = GetWord(GameBase::GetPosition(%target),2);
		%zcheck = False;
		if ((%idz - %targz) > 3 || (%targz - %idz) > 3) {
			if (Player::isAiControlled(Client::GetOwnedObject(%target)))
				%zcheck = True;
			if (Player::isAiControlled(Client::GetOwnedObject(%id)))
				%zcheck = True;
		}
		if (%zcheck == True && %hostile == 1) {
			Client::SendMessage(%id,0,"You cannot attack from here!");
			return;
		}
		// --------------------------------------------------------------------------------
		if (%hostile)
			Unhide(%id);
	}
	if (%mode == "TEAM") {
		%range = 50;
		%idPos = GameBase::getPosition(%id);
		%time = $CruSpell[%spell,$CSCastTime];
		for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
			if (PlayerIsInTeam(%cl) != -1 || %cl == %id) {
				if (PlayerIsInTeam(%cl) == PlayerIsInTeam(%id) || %cl == %id) {
					Schedule("DoCastCruSpell(" @ %id @ ",\"" @ %spell @ "\"," @ %cl @ ",\"" @ %pos @ "\");",%time);
				}
			}		
		}
	}

	if (BetterRunningSpell(%target,%spell) == True) {
		Client::SendMessage(%id,0,"Target is already harnessing a greater spell.");
		return;
	}

	CruSpellSound(%id,%spell);
	if (%target != %id)
		Client::SendMessage(%id,2,"Casting " @ GetCSData(%spell,$CSName) @ " on " @ Client::GetName(%target) @ "...");
	else
		Client::SendMessage(%id,2,"Casting " @ GetCSData(%spell,$CSName) @ "...");
	%time = $CruSpell[%spell,$CSCastTime];
	//------------------------------------------------------------------------------------------
	%castinit = GetPlayerSkill(%id,$SkillCastInit);
	%time -= %castinit/300;
	//*************************************************************
	// MAP CAST SPEED
	if ((%mapb = GetMapBonus(%id,"MIS")) != -1) %time *= 0.5;
	//*************************************************************	
	if (%time < $CruSpell[%spell,$CSMinCast])
		%time = $CruSpell[%spell,$CSMinCast];
	if (%time < 0)
		%time = 0;
	//------------------------------------------------------------------------------------------
	CruSpellGui(%id,%spell,%time);
	CoolDownCruCast(%id,%spell,%time);
	%take = $CruSpell[%spell,$CSTake];	
	TakeSpellStuff(%id,%take);
	if (%Bomb == True) {
		Schedule("DoCastCruSpellBomb(" @ %id @ ",\"" @ %spell @ "\",\"" @ %pos @ "\",\"" @ %lospos @ "\");",%time);
	}
	if (%Bomb != True && CanCastCruSpell(%target,%spell,False,True,%id) == True && %mode != "AREA" && %mode != "TEAM") {
		Schedule("DoCastCruSpell(" @ %id @ ",\"" @ %spell @ "\"," @ %target @ ",\"" @ %pos @ "\");",%time);
	}
	else {
		if (%bomb != True)
			Client::SendMessage(%id,0,"Cast failed on "  @ Client::GetName(%target) @ ". Target was unable to harness the spell.");
	}
}

function CruSpellGui(%id,%spell,%time)
{
	%recovery = $CruSpell[%spell,$CSRecovery];
	//------------------------------------------------------------------------------------------
	%maxcooldown = GetBonus(%id,$BPMAXCOOLDOWN);
	if (%maxcooldown < 50) %maxcooldown = 50;
	if (%maxcooldown > 90) %maxcooldown = 90;
	%cooldown = MaxCap(GetBonus(%id,$BPCOOLDOWN),%maxcooldown);
	%cooldown = 100 - %cooldown;
	%recovery *= (%cooldown / 100);
	//*************************************************************
	// MAP COOLDOWN
	if ((%mapb = GetMapBonus(%id,"ICD")) != -1) %recovery += (%recovery * (%mapb / 100));
	if ((%mapb = GetMapBonus(%id,"DMC")) != -1) %recovery -= (%recovery * (%mapb / 100));
	//*************************************************************
	if (%recovery < $CruSpell[%spell,$CSMinRecovery])
		%recovery = $CruSpell[%spell,$CSMinRecovery];
	//------------------------------------------------------------------------------------------
	%spell = $CruSpell[%spell,$CSName];
	remoteeval(%id,"RPGGui::SpellRefresh",%time,1,%spell);
	schedule("CruSpellGuiCooldown(" @ %id @ "," @ %recovery @ ");",%time);
}

function CruSpellGuiCooldown(%id,%recovery)
{
	remoteeval(%id,"RPGGui::SpellRefresh",%recovery,0,"Recovering..");
}

function DoCastCruSpellBomb(%id,%spell,%pos,%lospos)
{
	%curpos = GameBase::GetPosition(%id);
	if (Vector::GetDistance(%curpos,%pos) > 2) {
		if (!Player::isAiControlled(Client::GetOwnedObject(%id))) {
			Client::SendMessage(%id,2,"Your casting was interrupted.");
			return;
		}
	}
	//-------------------------------------------------------------
	// Create and det the animation bomb
	CruSpellAnimation(%id,%spell,%lospos);
	//-------------------------------------------------------------
	// Radius cast the bomb
	%b = 30;
	%set = newObject("set", SimSet);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%lospos,%b,%b,%b,0);
	Group::iterateRecursive(%set,DoCruSpellBomb,%id,%lospos,%spell);
	deleteObject(%set);
}

function DoCruSpellBomb(%object,%id,%pos,%spell)
{
	%hostile = 1;
	%target = player::GetClient(%object);
	if (CanCastCruSpell(%target,%spell,False,True) == True) {
		if (%hostile) {
			if (action::PlayersArehostile(%id,%target) == False || %target == %id) {
				Client::SendMessage(%id,0,"PVP Not allowed in this area.");
				return;
			}
		}
		DoCastCruSpell(%id,%spell,%target,-1,True);
	}
	else
		Client::SendMessage(%id,2,"Cast failed on "  @ Client::GetName(%target) @ ". Target was unable to harness the spell.");
}

function CoolDownCruCast(%id,%spell,%time)
{
	%recovery = $CruSpell[%spell,$CSRecovery];
	//------------------------------------------------------------------------------------------
	%maxcooldown = GetBonus(%id,$BPMAXCOOLDOWN);
	if (%maxcooldown < 50) %maxcooldown = 50;
	if (%maxcooldown > 90) %maxcooldown = 90;
	%cooldown = MaxCap(GetBonus(%id,$BPCOOLDOWN),%maxcooldown);
	%cooldown = 100 - %cooldown;
	%recovery *= (%cooldown / 100);
	//*************************************************************
	// MAP COOLDOWN
	if ((%mapb = GetMapBonus(%id,"ICD")) != -1) %recovery += (%recovery * (%mapb / 100));
	if ((%mapb = GetMapBonus(%id,"DMC")) != -1) %recovery -= (%recovery * (%mapb / 100));
	//*************************************************************
	if (%recovery < $CruSpell[%spell,$CSMinRecovery])
		%recovery = $CruSpell[%spell,$CSMinRecovery];
	//------------------------------------------------------------------------------------------
	$PlayerRecoverCS[%id] = %recovery;
	%connectId = GetConnectionId(%id);
	schedule("ReadyToCruCast(" @ %id @ "," @ %connectId @ ");",(%recovery + %time));
}

function ReadyToCruCast(%id,%connectId)
{
	%curconnect = GetConnectionId(%id);
	if (%curconnect == %connectId) {
		$PlayerRecoverCS[%id] = "";
		Client::SendMessage(%id,2,"You are ready to cast again.");
		return;
		UpdateHotbar(%id);
	}
}

function SuccessHitSpell(%id,%target,%spell)
{
	%atk = 5;
	%def = 5;
	%o = $CruSpell[%spell,$CSOffense];
	%d = $CruSpell[%spell,$CSDefense];
	for (%i = 0; (%g = getWord(%o,%i)) != -1; %i+=2) {
		if (%g == "WEAPONSKILL") {
			%tempatk = 0;
			%weapon = GetCurrentWearFull(%id,13);
			%atkskills = $BPItem[%weapon,$BPATKSkills];
			if (%atkskills != "") {
				for (%k = 0; (%skill = getWord(%atkskills,%k)) != -1; %k += 2) {
					%var = getWord(%atkskills,%i+1);
					%tempatk += (GetPlayerSkill(%id,$BPSkillToNumeric[%skill]) * (%var / 100));
				}
				%atk += %tempatk * (getWord(%o,%i+1) / 100);
			}
		}
		else {
			%g = $BPSkillToNumeric[%g];
			%atk += GetPlayerSkill(%id,%g) * (getWord(%o,%i+1) / 100);
		}
	}
	for (%i = 0; (%g = getWord(%d,%i)) != -1; %i+=2) {
		%g = $BPSkillToNumeric[%g];
		%def += GetPlayerSkill(%target,%g) * (getWord(%d,%i+1) / 100);
	}
	%atk += GetBonus(%id,$BPADDALLOFF);
	%def += GetBonus(%target,$BPADDALLDEF);
	//=============================================================================
	if ($STATUSCOLD[%id] > 0)	%atk *= 0.75;
	if ($STATUSENERGY[%id] > 0)	%atk *= 0.9;
	%check = $CruSpell[%spell,$CSBonus];
	if (getWord(%check,0) == "Damage:Melee") {
		if ($STATUSMELEE[%target] > 0)
			%def *= 0.75;
	}
	if (getWord(%check,0) == "Damage:Projectile") {
		if ($STATUSPROJ[%target] > 0)
			%def *= 0.75;
	}
	//=============================================================================	
	%r = getRandom() * %atk;
	%x = getRandom() * %def;
	//*************************************************************
	// MAP NO RESIST
	if ((%mapb = GetMapBonus(%target,"NOR")) != -1) return True;
	//*************************************************************
	if (%r >= %x)
		return True;
	else
		return False;
}

function DoCastCruSpell(%id,%spell,%target,%pos,%bomb,%bypass)
{
	if (%bypass == "") %bypass = False;
	if (%bomb != True) {
		%curpos = GameBase::GetPosition(%id);
		if (Vector::GetDistance(%curpos,%pos) > 2) {
			if (!Player::isAiControlled(Client::GetOwnedObject(%id))) {
				Client::SendMessage(%id,2,"Your casting was interrupted.");
				return;
			}
		}
	}
	%hostile = $CruSpell[%spell,$CShostile];
	if (%hostile == 1 && %bypass != True) {
		if (SuccessHitSpell(%id,%target,%spell) == False) {
			Client::SendMessage(%id,2,Client::GetName(%target) @ " resisted your " @ $CruSpell[%spell,$CSName] @ ".");
			Client::SendMessage(%target,2,"You resisted " @ Client::GetName(%id) @ "'s " @ $CruSpell[%spell,$CSName] @ ".");
			return;
		}
		// UPDATE COMBAT
		$InCombat[%id] = 5;
		$InCombat[%target] = 5;
		if (%id.sleepMode != "")
			BindWake(%id,True);
		if (%target.sleepMode != "")
			BindWake(%target,True);
	}
	//-----------------------------------------------------------------------------
	%ok = True;
	%tree = $CruSpell[%spell,$CSTree];
	for (%z = 0; (%gline = getWord(%tree,%z)) != -1; %z+=2)
		%stack[%gline] = GetWord(%tree,%z+1);
	%curspells = $CurPlayerSpells[%target];
	for (%i = 0; (%cspell = getWord(%curspells,%i)) != -1; %i += 2) {
		%gcastid = GetWord(%curspells,%i + 1);
		%targtree = $CruSpell[%cspell,$CSTree];
		for (%z = 0; (%gline = getWord(%targtree,%z)) != -1; %z+=2) {
			%gstack = GetWord(%targtree,%z+1);
			if (%gstack <= %stack[%gline] && %stack[%gline] != "")
				EndCruSpell(%target,%cspell);
		}
	}
	//-----------------------------------------------------------------------------
	%silent = $CruSpell[%spell,$CSSilent];
	//-----------------------------------------------------------------------------
	if (%ok == True) {
		if (%target != %id) {
			if (!%silent) {
				Client::SendMessage(%target,2,Client::GetName(%id) @ " casts " @ GetCSData(%spell,$CSName) @ " within you.");
				Client::SendMessage(%id,2,"You cast " @ GetCSData(%spell,$CSName) @ " within " @ Client::GetName(%target) @ ".");
			}
		}
		else {
			if (!%silent)
				Client::SendMessage(%id,2,"You cast " @ GetCSData(%spell,$CSName) @ " on yourself.");
		}
		if (%bomb != True) {
			if (!%silent)
				Player::SetAnimation(%id,39);
			%anim = $CruSpell[%spell,$CSAnimation];
			if (%anim == "ANIM_WEAPON_THROW")
				CruAnimationWeaponThrow(%id);
			else {
				if (%anim != "")
					CruSpellAnimation(%target,%spell,"",%id);
			}
		}
		%hostileBonus = $CruSpell[%spell,$CSHostileBonus];
		//==========================================================================================
		if (%hostileBonus != "")
			CruSpellBonus(%id,%spell,1,%id,True);
		CruSpellBonus(%target,%spell,1,%id);
		if (%hostileBonus != "")
			CruSpellBonus(%id,%spell,0,%id,True);
		//==========================================================================================
		$PlayerOnCruSpell[%target] += 1;
		%casterconnect = GetConnectionId(%id);
		%checkdur = $CruSpell[%spell,$CSDur];
		%uncast = $CruSpell[%spell,$CSUnCast];
		if (%checkdur || %uncast == 1)
			AddCruSpell(%target,%spell,%id,%casterconnect);
	}
	else {
		if (!%silent)
			Client::SendMessage(%id,2,"A greater spell is already running on " @ Client::GetName(%target) @ ".");
	}
}

function Discharge(%id)
{
	echo(" DISCHARGE " @ %id);
	%mana = fetchData(%id,"MANA");
	%damage = round(%mana * 0.16);
	//echo(" DAMAGE " @ %damage);
	%set = newObject("set", SimSet);
	%spotdist = 25;
	%pos = GameBase::GetPosition(%id);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,Discharge::DoAOE,%id,%damage);
	deleteObject(%set);
	setMANA(%id, 0);
}

function Discharge::DoAOE(%object,%id,%damage)
{
	//echo(" DISCHARGE::DOAOE " @ %object @ " " @ %id @ " " @ %damage);
	%target = player::GetClient(%object);
	if (%target != %id) {
		if (action::PlayersAreHostile(%id,%target)) {
			if (GetBonus(%id,$BPNOSPELLDAMAGE) < 1) {
				if ((%echo = GetBonus(%id,$BPSPELLECHO)) > 0) {
					if (RR(100) <= %echo)
						Player::SpellDamage(%target,%id,"Arcane",round(%damage*0.9),round(%damage*1.1),"",false,"");
				}
				Player::SpellDamage(%target,%id,"Arcane",round(%damage*0.9),round(%damage*1.1),"",false,"");
			}
		}
	}
}

function AOECast(%id,%caster,%spell,%team)
{
	%set = newObject("set", SimSet);
	%spotdist = 25;
	%pos = GameBase::GetPosition(%caster);
	%n = containerBoxFillSet(%set,$SimPlayerObjectType,%pos,%spotdist,%spotdist,%spotdist,0);
	Group::iterateRecursive(%set,AOECast::DoAOE,%id,%caster,%spell,%team);
	deleteObject(%set);
}

function AOECast::DoAOE(%object,%id,%caster,%spell,%team)
{
	%cl = player::GetClient(%object);
	if (%cl != %caster) {
		%hostile = $CruSpell[%spell,$CSHostile];
		if (!%hostile) {
			if (!%team) {
				if (Client::GetTeam(%cl) == Client::GetTeam(%caster)) {
					%pos = GameBase::GetPosition(%caster);
					DoCastCruSpell(%caster,%spell,%cl,%pos,False,True);
				}
			}
			else {
				if (SameTeam(%cl,%caster) == True) {
					%pos = GameBase::GetPosition(%caster);
					DoCastCruSpell(%caster,%spell,%cl,%pos,False,True);
				}	
			}	
		}
	}
}

function AOETeamCast::DoAOE(%object,%id,%caster,%spell)
{
	%cl = player::GetClient(%object);
	if (%cl != %caster) {
		if (PlayerIsInTeam(%cl) == PlayerIsInTeam(%caster)) {
			%pos = GameBase::GetPosition(%caster);
			DoCastCruSpell(%caster,%spell,%cl,%pos,False,True);
		}
	}
}


function CruSpellBomb(%clientId,%castPos,%b)
{
	%sound = GetWord($CruSpellSound[%b],1);
	%player = Client::getOwnedObject(%clientId);
	%bomb = newObject("", "Mine", %b);
	addToSet("MissionCleanup", %bomb);
	GameBase::Throw(%bomb, %player, 0, false);
	GameBase::setPosition(%bomb, %castPos);
	PlaySound(%sound,%castPos);
}

$CruSpellSound["ANIM_FLICKER"] = "ActivateFK FlickerWoosh";

$CruSpellSound["ANIM_FIREBALL"] = "ActivateAB LaunchFB";
$CruSpellSound["ANIM_SMOKE"] = "ActivateBF ExplodeLM";
$CruSpellSound["ANIM_MELT"] = "ActivateAB Spell17";
$CruSpellSound["ANIM_MAGMA"] = "ActivateAB LaunchFB";
$CruSpellSound["ANIM_FIRESTORM"] = "Spell19 Spell18";
$CruSpellSound["ANIM_HELLFIRE"] = "Spell30 Spell6";

$CruSpellSound["ANIM_ICICLE"] = "ImpactTR HitPawnDT";
$CruSpellSound["ANIM_FROST"] = "Spell43 Spell40";
$CruSpellSound["ANIM_HAIL"] = "Spell43 Spell3";
$CruSpellSound["ANIM_SNOWSTORM"] = "Spell43 Spell4";
$CruSpellSound["ANIM_AVALANCHE"] = "Spell43 Spell5";
$CruSpellSound["ANIM_ICETWISTER"] = "Spell27 Spell25";

$CruSpellSound["ANIM_SPARK"] = "Spell11 Spell44";
$CruSpellSound["ANIM_SHOCK"] = "Spell11 Spell44";
$CruSpellSound["ANIM_BOLT"] = "Spell28 HitBF";
$CruSpellSound["ANIM_LIGHTNING"] = "Spell28 Spell23";
$CruSpellSound["ANIM_SUPERNOVA"] = "Spell32 Spell33";
$CruSpellSound["ANIM_RIFT"] = "Spell28 Spell24";

$CruSpellSound["ANIM_THORN"] = "0 ActivateFK";
$CruSpellSound["ANIM_FANGS"] = "0 Spell46";
$CruSpellSound["ANIM_PLAGUE"] = "0 Spell50";
$CruSpellSound["ANIM_COBRA"] = "0 Spell46";
$CruSpellSound["ANIM_SWARM"] = "0 Spell45";
$CruSpellSound["ANIM_BLACKDEATH"] = "0 Spell45";

$CruSpellSound["ANIM_IRONFIST"] = "0 Sound0301";
$CruSpellSound["ANIM_CHAOSSLASH"] = "0 Sound0201";
$CruSpellSound["ANIM_POWERPUNCH"] = "0 Spell52";
$CruSpellSound["ANIM_CHAOSCLAWS"] = "0 Sound0201";
$CruSpellSound["ANIM_THORSHAMMER"] = "0 Spell48";
$CruSpellSound["ANIM_SWORDSTORM"] = "0 Spell53";

$CruSpellSound["ANIM_ROCK"] = "Spell49 Spell47";
$CruSpellSound["ANIM_CHAOSKNIFE"] = "Spell8 Sound0300";
$CruSpellSound["ANIM_VOLLEY"] = "Spell51 Spell20";
$CruSpellSound["ANIM_TORNADO"] = "Spell8 Spell25";
$CruSpellSound["ANIM_CHAOSARROW"] = "Spell51 Spell41";
$CruSpellSound["ANIM_METEOR"] = "Spell19 Spell4";

$CruSpellSound["ANIM_ABILITY_OFF"] = "0 Spell8";
$CruSpellSound["ANIM_ABILITY_DEF"] = "0 Spell9";
$CruSpellSound["ANIM_ABILITY_NEU"] = "0 Spell31";

$CruSpellSound["ANIM_BODY_OFF"] = "0 Spell7";
$CruSpellSound["ANIM_BODY_DEF"] = "0 Spell37";
$CruSpellSound["ANIM_BODY_NEU"] = "0 Spell36";

$CruSpellSound["ANIM_SPELL_OFF"] = "0 Spell29";
$CruSpellSound["ANIM_SPELL_DEF"] = "0 Spell35";
$CruSpellSound["ANIM_SPELL_NEU"] = "0 Spell1";

$CruSpellSound["ANIM_WEAPON_OFF"] = "0 Spell22";
$CruSpellSound["ANIM_WEAPON_DEF"] = "0 Spell21";
$CruSpellSound["ANIM_WEAPON_NEU"] = "0 Spell31";

$CruSpellSound["ANIM_EVADE_OFF"] = "0 Spell10";
$CruSpellSound["ANIM_EVADE_DEF"] = "0 Spell15";
$CruSpellSound["ANIM_EVADE_NEU"] = "0 Spell16";

$CruSpellSound["ANIM_DISCHARGE"] = "0 Explode3FW";

$CruSpellSound["ANIM_TRADE_1"] = "Spell8 SoundHitShield";

function CruSpellSound(%clientId,%spell)
{
	%anim = $CruSpell[%spell,$CSAnimation];
	%sound = getWord($CruSpellSound[%anim],0);
	PlaySound(%sound,Gamebase::GetPosition(%clientId));
}

function CruSpellAnimation(%clientId,%spell,%manualPos,%caster)
{
	if (%manualPos == "")
		%pos = gamebase::GetPosition(%clientId);
	else
		%pos = %manualPos;
	%anim = $CruSpell[%spell,$CSAnimation];
	if (%anim == "ANIM_WEAPON_THROW")
		return;
	else if (%anim == "ANIM_MULTISHOT") {
		%weapon = getCurrentWearFull(%caster,13);
		%damageType = newGetWeaponDamageType(%weapon);
		%proj = $BOWPROJECTILE[%damageType];
		%cpos = Gamebase::GetPosition(%caster);
		FireAutoProjectile(%caster,%clientId,%proj);
		PlaySound("CrossbowShoot1",%cpos);
		schedule("FireAutoProjectile("@%caster@","@%clientId@","@%proj@");",0.2);
		schedule("FireAutoProjectile("@%caster@","@%clientId@","@%proj@");",0.4);
	}
	else
		CruSpellBomb(%clientId,%pos,%anim);
}

function CruAnimationWeaponThrow(%id)
{
	%targ = $TargetCur[%id,0];
	%weapon = getCurrentWearFull(%id,13);
	%throw = "SpectralSword";
	%atkskills = $BPItem[%weapon,$BPATKSkills];
	if (%atkskills != "") {
		%skill = GetWord(%atkskills,0);
		if (%skill == "Slashing") %throw = "SpectralSword";
		else if (%skill == "Piercing") %throw = "SpectralKnife";
		else if (%skill == "Bludgeoning") %throw = "SpectralHammer";
	}	
	FireAutoProjectile(%id,%targ,%throw);
}

function getCruSpellId(%id)
{
	return $PlayerOnCruSpell[%id];
}

function CheckBreakSpellDamage(%id)
{
	%list = $CurPlayerSpells[%id];
	if (getWord(%list,0) == -1)
		return;
	for (%i = 0; (%spell = getWord(%list,%i)) != -1; %i += 2) {
		%chance = $CruSpell[%spell,$CABreakOnDmg];
		if (%chance != "" && %chance >= 1) {
			%rand = floor(getRandom() * 100 + 1);
			if (%chance <= %rand) {
				EndCruSpell(%id,%spell);
			}
		}
	}
}

function AddCruSpell(%id,%spell,%caster,%casterconnect,%manualdur)
{
	%connectId = GetConnectionId(%id);
	%spellId = GetCruSpellId(%id);
	if (%manualdur == "")
		%dur = $CruSpell[%spell,$CSDur];
	else
		%dur = %manualdur;
	// echo(" ADD CUR SPELL DUR " @ %dur);
	$CurPlayerSpells[%id] = $CurPlayerSpells[%id] @ %spell @ " " @ %spellId @ " ";
	%dot = $CruSpell[%spell,$CSDOT];
	//----------------------------------------------------------
	if (%dot != "") {
		//echo(" AUTOSTART DOT " @ %id @ " " @ %dot @ " " @ %spell @ " " @ %spellid);
		StartDOT(%id,%dot,%spell,%spellid,%connectid,%caster,%casterconnect);
	}
	//----------------------------------------------------------
	%id.SpellTimer[%spell,START] = GetSimTime();
	%id.SpellTimer[%spell,DUR] = %dur;
	//----------------------------------------------------------
	// echo(" AUTOEND CRU SPELL 1 " @ %id @ " " @ %connectId @ " " @ %spell @ " " @ %spellId);
	schedule("AutoEndCruSpell(" @ %id @ "," @ %connectId @ ",\"" @ %spell @ "\"," @ %spellId @ ");",%dur);
}

function GetSpellRemainTime(%id,%spell,%absolute)
{
	%start = %id.SpellTimer[%spell,START];
	%dur = %id.SpellTimer[%spell,DUR];
	if (%start == "")
		return;
	if (%absolute) {
		%s = (%start + %dur) - getSimTime();
		%d = string::FindSubStr(%s,".");
		return string::GetSubStr(%s,0,%d + 2);
	}
	else
		return floor((%start + %dur) - getSimTime());
}

function DisplaySpellRemainTime(%id,%spell)
{
	%r = GetSpellRemainTime(%id,%spell);
	return CruTimeFormat(%r);
}

function DisplayAllSpellRemains(%id)
{
	%cur = $CurPlayerSpells[%id];
	for (%i = 0; (%s = getWord(%cur,%i)) != -1; %i += 2) {
		%time = DisplaySpellRemainTime(%id,%s);
		Client::sendMessage(%id,0,%s @ " -> " @ %time);
	}
}

function DeathEndSpells(%id)
{
	%cur = $CurPlayerSpells[%id];
	for (%i = 0; (%s = getWord(%cur,%i)) != -1; %i += 2) {
		if ($CruSpell[%s,$NoClearFlag] != 1)
			EndCruSpell(%id,%s);
	}
}

function NoManaEndSpells(%id)
{
	%cur = $CurPlayerSpells[%id];
	for (%i = 0; (%s = getWord(%cur,%i)) != -1; %i += 2) {
		%tree = $CruSpell[%s,$CSTree];
		%tree = getWord(%tree,0);
		if ($SpellEndOnNoMana[%tree] == 1)
			EndCruSpell(%id,%s);
	}
}

function SaveCurrentFocus(%id)
{
	//echo(" SAVE CURRENT FOCUS " @ %id);
	%save = "";
	%cur = $CurPlayerSpells[%id];
	if (getWord(%cur,0) == 1)
		return "-1";
	for (%i = 0; (%s = getWord(%cur,%i)) != -1; %i += 2)
		%save = %save @ %s @ " " @ GetSpellRemainTime(%id,%s,1) @ " ";
	//echo(" SAVE " @ %save);
	return %save;
}

function AutoStartSavedFocus(%id,%cur)
{
	//echo(" DOING AUTO START SAVED FOCUS " @ %id);
	for (%i = 0; (%s = getWord(%cur,%i)) != -1; %i += 2) {
		%dur = getWord(%cur,%i+1);
		CruSpellBonus(%id,%s,1);
		$PlayerOnCruSpell[%id] += 1;
		AddCruSpell(%id,%s,0,0,%dur);
		Client::SendMessage(%id,2,%s @ " was cast within you.");
	}
	$AutoStartFocus[%id] = "";
}

function AutoEndCruSpell(%id,%connectId,%spell,%spellId)
{
	// echo(" AUTOEND CRU SPELL 2 " @ %id @ " " @ %connectId @ " " @ %spell @ " " @ %spellId);
	%curconnect = GetConnectionId(%id);
	if (%curconnect != %connectId)
		return False;
	%cur = $CurPlayerSpells[%id];
	for (%i = 0; (%get = getWord(%cur,%i)) != -1; %i += 2) {
		if (%get == %spell) {
			%sid =  getWord(%cur,%i + 1);
			if (%sid == %spellId) {
				 EndCruSpell(%id,%spell);
			}
		}
	}
}

function EndCruSpell(%id,%spell)
{
	%cur = $CurPlayerSpells[%id];
	if (%cur == "")
		return;
	%found = False;
	%new = "";
	for (%i = 0; (%get = getWord(%cur,%i)) != -1; %i += 2) {
		if (%get == %spell) {
			%found = True;
		}
		else
			%new = %new @ %get @ " " @ getWord(%cur,%i + 1) @ " ";
	}
	$CurPlayerSpells[%id] = %new;
	if (%found == True) {
		%name = $CruSpell[%spell,$CSName];
		%silent = $CruSpell[%spell,$CSSilent];
		if (!%silent)
			Client::SendMessage(%id,2,%name @ " dissapates..");
		CruSpellBonus(%id,%spell,0);
	}
}

function ManualEndSpellAction(%id,%spell,%o)
{
	%hostile = $CruSpell[%spell,$CShostile];
	if (!%hostile) {
		EndCruSpell(%id,%spell);
	}
	else {
		%name = $CruSpell[%spell,$CSName];
		Client::SendMessage(%id,2,%name @ " is a hostile spell, you cannot remove it!");
	}
}

function testroll(%v)
{
	%mid = string::findSubStr(%v,"..");
	%min = string::getSubStr(%v,0,%mid);
	%max = string::getSubStr(%v,(%mid + 2),999);
	echo(%min @ " " @ %max);
	%roll = floor((getRandom() * ((%max + 1) - %min) + %min));
	echo(%roll);
}

$SETAURADEC[COLD] = "AURA_COLD";
$SETAURADEC[ENERGY] = "AURA_LIGHTNING";
$SETAURADEC[FIRE] = "AURA_FIRE";
$SETAURADEC[ABSORB] = "AURA_ABSORB";

function SetAura(%id,%aura,%remove) 
{
	%mpv = $MountPointVisual[%aura];
	%sad = $SETAURADEC[%aura];
	if (%mpv == "" || %sad == "")
		return;
	if (%remove == False || %remove == "")
		Player::MountItem(%id,%sad,%mpv);
	else
		Player::UnmountItem(%id,%mpv);	
}

function CruSpellBonus(%id,%spell,%v,%init,%hostile)
{
	//echo(" CRUSPELLBONUS --------> ID " @ %id @ " SPELL " @ %spell @ " V " @ %v @ " INIT " @ %init @ " HOSTILE " @ %hostile);
	if (%hostile == True)
		%bonus = $CruSpell[%spell,$CSHostileBonus];
	else
		%bonus = $CruSpell[%spell,$CSBonus];
	%text = $AreaText[%spell];
	if (%text != "" && %v == 1)
		FloatText(%id,%text);
	if (%bonus == "")
		return;
	//echo(" SPELL BONUS " @ %id @ " " @ %spell @ " " @ %v @ " " @ %init @ " " @ %hostile @ " -----> " @ %bonus);
	for (%i = 0; (%b = getWord(%bonus,%i)) != -1; %i += 2) {
		%a = getWord(%bonus,%i + 1);
		if ((%num = $BPSkillToNumeric[%b]) == "") {
			if (%b == "HEAL") {
				if (%v) {
					%mid = string::findSubStr(%a,"..");
					%min = string::getSubStr(%a,0,%mid);
					%max = string::getSubStr(%a,(%mid + 2),999);
					%roll = RandBetween(%min,%max);
					%roll += GetPlayerSkill(%init,$BPHEALING);
					%bonus = GetBonus(%init,$BPHEALINGINC);
					%roll = round(%roll * (1 + (%bonus / 100)));
					if (%init != %id) Client::SendMessage(%init,$msggreen,"You healed " @ Client::GetName(%id) @ " for " @ %roll @ " points.");
					Client::SendMessage(%id,$msggreen,Client::GetName(%init) @ " healed you for " @ %roll @ " points.");
					%hp = fetchData(%id, "HP");
					refreshHP(%id, ((%roll / 100) * -1));
				}
			}
			else if (%b == "TEAMHEAL") {
				if (%v) {
					%mid = string::findSubStr(%a,"..");
					%min = string::getSubStr(%a,0,%mid);
					%max = string::getSubStr(%a,(%mid + 2),999);
					%roll = RandBetween(%min,%max);
					%roll += GetPlayerSkill(%init,$BPHEALING);
					%bonus = GetBonus(%init,$BPHEALINGINC);
					%roll = round(%roll * (1 + (%bonus / 100)));
					Client::SendMessage(%id,$msggreen,"You healed yourself for " @ %roll @ " points.");
					refreshHP(%id, ((%roll / 100) * -1));
					if ((%team = PlayerIsInTeam(%id)) != -1) {
						for (%cl = client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl)) {
							%clteam = PlayerIsInTeam(%cl);
							if (%clteam == %team) {
								if (%cl != %id) {
									Client::SendMessage(%cl,$msggreen,Client::GetName(%init) @ " healed you for " @ %roll @ " points.");
									refreshHP(%cl, ((%roll / 100) * -1));
								}
							}
						}
					}
				}
			}
			else if (%b == "HEALMP") {
				if (%v) {
					%mana = fetchData(%id, "MANA");
					refreshMANA(%id, (%a * -1));
				}
			}
			else if (string::findSubStr(%b,"Damage:") != -1 && string::findSubStr(%b,"SelfDamage") == -1) {
				%mid = string::findSubStr(%b,":");
				%type = string::getSubStr(%b,(%mid + 1),255);
				%mid = string::findSubStr(%a,"..");
				%min = string::getSubStr(%a,0,%mid);
				%max = string::getSubStr(%a,(%mid + 2),255);
				if (GetBonus(%init,$BPNOSPELLDAMAGE) < 1) {
					if ((%echo = GetBonus(%init,$BPSPELLECHO)) > 0) {
						if (RR(100) <= %echo)
							Player::SpellDamage(%id,%init,%type,%min,%max,%spell);
					}
					Player::SpellDamage(%id,%init,%type,%min,%max,%spell);
				}
			}
			else if (string::findSubStr(%b,"SelfDamage:") != -1) {
				%mid = string::findSubStr(%b,":");
				%type = string::getSubStr(%b,(%mid + 1),255);
				%mid = string::findSubStr(%a,"..");
				%min = string::getSubStr(%a,0,%mid);
				%max = string::getSubStr(%a,(%mid + 2),255);
				if (GetBonus(%init,$BPNOSPELLDAMAGE) < 1) {
					if ((%echo = GetBonus(%init,$BPSPELLECHO)) > 0) {
						if (RR(100) <= %echo)
							Player::SpellDamage(%init,%id,%type,%min,%max,%spell);
					}
					Player::SpellDamage(%init,%id,%type,%min,%max,%spell);
				}
			}
			else if (%b == "SHIELDHIT") {
				if (%v) {
					%value = Round(GetBonus(%init,$BPBLOCKAMMOUNT) * (%a/100)) + 1;
					%spellbase = GetBonus(%init,$BPSPELLBASE);
					%value += %spellbase;
					%bonus = (GetBonus(%init,$BPMELEETYPEDAMAGE) + GetBonus(%init,$BPMAGICDAMAGE));
					%value = Round(%value * ((%bonus/100) + 1));
					Player::ManualDamage(%init,%id,%value,True,True,"Melee",False);
				}
			}
			else if (%b == "SHIELDSTUN") {
				if (%v) {
					%value = GetBonus(%init,$BPBLOCKHIT) + 5;
					%value += GetBonus(%init,$BPINCSTUN);
					if (RR(100) <= %value) {
						Client::SendMessage(%init,$msggreen,"You stun " @ Client::GetName(%id) @ "!");
						StunPlayer(%id,5);
					}
				}
			}
			else if (%b == "AUTOWEAPON") {
				if (%v)
					Player::AutoWeapon(%init,%id,(%a/100),true);
			}
			else if (%b == "OVERRIDEDT") {
				if (%v) {
					$DamageOverride[%id] = %a;
				}
				else {
					$DamageOverride[%id] = "";
				}
			}
			else if (%b == "TELEPORTTOCASTER") {
				if (%v)
					Gamebase::SetPosition(%id,Gamebase::GetPosition(%init));
			}
			else if (%b == "CASTERTELEPORT") {
				if (%v)
					Gamebase::SetPosition(%init,Gamebase::GetPosition(%id));
			}
			else if (%b == "SUMMONUNDEAD") {
				if (%v)
					CruAiSpawnPet(%id,"",%a);
			}
			else if (%b == "SELFCAST") {
				if (%v) {
					%pos = Gamebase::GetPosition(%id);
					DoCastCruSpell(%id,%a,%id,%pos,False,True);
				}
			}
			else if (%b == "FRIENDAOECAST") {
				if (%v)
					DoAoeCast(%id,%a);
			}
			else if (%b == "TEAMAOECAST") {
				if (%v)
					AOECast(%id,%init,%a,True);
			}
			else if (%b == "CHANGERACE") {
				if (%v) {
					ChangeRace(%id,%a);
					if (%a == "Arcane")
						player::mountItem(%id,"TRANS_ARCANE",1);
				}
				else {
					ChangeRace(%id,"Human");
					if (%a == "Arcane")
						player::unMountItem(%id,1);
				}
			}
			else if (%b == "SETAURA") {
				if (%v)
					SetAura(%id,%a,False);
				else
					SetAura(%id,%a,True);
			}
			else if (%b == "ABSORB") {
				if (%v)
					$AbsorbTemp[%id] = %a;
				else
					$AbsorbTemp[%id] = 0;
			}
			else if (%b == "ROOT") {
			 	if (%v)
					RootPlayer(%id);
				else
					UnRootPlayer(%id);
			}
			else if (%b == "DISCHARGE") {
				if (%v)
					Discharge(%id);
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
}

function SpellChangeRace(%id,%race)
{
	if (%race == "Demon") {
		Player::setArmor(%id,"DemonArmor");
		Client::SetSkin(%id,swolf);
	}
	if (%race == "Human") {
		if (fetchData(%id,"Race") == "MaleHuman")
			Player::setArmor(%id,"MaleHumanArmor7");
		else
			Player::setArmor(%id,"FemaleHumanArmor7");
		UpdateAppearance(%id);
	}
}

function TakeSpellStuff(%id,%take)
{
	//echo(" TAKE SPELL STUFF " @ %id @ " " @ %take);	

	if (%take == "")
		return;

	if (Player::isAiControlled(Client::GetOwnedObject(%id)))
		return;

	for (%i = 0; (%this = getWord(%take,%i)) != -1; %i += 2) {
		%amm = getWord(%take,%i + 1);
		if (%this == "MANA") {
			if ((%r = GetBonus(%id,$BPMANACOST)) > 0)
				%amm = (%amm - round(%amm * (%r / 100)));
			if ((%r = GetBonus(%id,$BPADDMANACOST)) > 0)
				%amm = (%amm + round(%amm * (%r / 100)));
			//*************************************************************
			// MAP MANACOST
			if ((%mapb = GetMapBonus(%id,"IMC")) != -1) %amm += round(%a * (%mapb / 100));
			//*************************************************************
			%mana = %amm;
			%blood = 0;
			if ((%r = GetBonus(%id,$BPBLOODMAGIC)) > 0) {
				%blood = round(%amm * (%r / 100));
				%mana = %amm - %blood;
			}
			else
				%blood = 0;
			//*************************************************************
			// MAP BLOODMAGIC
			if ((%mapb = GetMapBonus(%id,"BLD")) != -1) {
				%blood = %amm;
				%mana = 0;
			}
			//*************************************************************
			if (%blood > 0)
				DamageTarget(%id,%blood,%id);
			if (%mana > 0)
				refreshMANA(%id,(%mana * 1));
		}
		else if (%this == "HEALTH") {
			if ((%r = GetBonus(%id,$BPMANACOST)) > 0)
				%amm = (%amm - round(%amm * (%r / 100)));
			if ((%r = GetBonus(%id,$BPADDMANACOST)) > 0)
				%amm = (%amm + round(%amm * (%r / 100)));
			//*************************************************************
			// MAP MANACOST
			if ((%mapb = GetMapBonus(%id,"IMC")) != -1) %amm += round(%a * (%mapb / 100));
			//*************************************************************
			DamageTarget(%id,%amm,%id);
		}
	}
}

function PlayerRecoverCS(%id)
{
	if ($PlayerRecoverCS[%id] != "")
		return True;
	else
		return False;
}

function GetCSData(%spell,%data)
{
	return $CruSpell[%spell,%data];
}

function CanCastCruSpell(%id,%spell,%learn,%have,%caster)
{
	//echo(" CANCASTCRUSPELL " @ %id @ " " @ %spell @ " " @ %learn @ " " @ %have);
	%reqs = $CruSpell[%spell,$CSReqs];
	if (%reqs == "")
		return True;
	if (%learn == True)
		%reqs = $CruSpell[%spell,$CSLearnReqs];
	if (%have == True)
		%reqs = $CruSpell[%spell,$CSHaveReqs];
	%m = 1;
	
	if (Player::isAiControlled(Client::GetOwnedObject(%id)) && $CruAI[%id,$AiOwner] == "")
		return True;

	if (HasLearnedSpell(%id,%spell) == false && %have != true) {
		if (%id.adminLevel < 5) {
			Client::SendMessage(%id,0,"You have not learned spell: " @ $CruSpell[%spell,$CSName]);
			return False;
		}
	}

	if ($Stunned[%id]) {
		Client::SendMessage(%id,0,"You cannot cast while stunned!");
		return False;
	}

	for (%i = 0; (%r = getWord(%reqs,%i)) != -1; %i += 2) {
		%a = getWord(%reqs,%i+1);
		%msg = "";
		if (%r == "LVLG") {
			if (fetchData(%id,"LVL") < %a) {
				%m = 0;
				%msg = "Your level must be at least " @ %a @ " to cast this spell.";
			}
		}
		else if (%r == "CLASS") {
			if (fetchData(%id,"CLASS") != %a) {
				%m = 0;
				%msg = "Your class must be " @ %a @ " to cast this spell.";
			}
		}
		else if (%r == "RLG") {
			if (fetchData(%id,"RemortStep") < %a)
				%m = 0;
		}
		else if (%r == "MANA") {
			if ((%r = GetBonus(%id,$BPMANACOST)) > 0)
				%a -= round(%a * (%r / 100));
			if ((%r = GetBonus(%id,$BPADDMANACOST)) > 0)
				%a += round(%a * (%r / 100));
			//*************************************************************
			// MAP MANACOST
			if ((%mapb = GetMapBonus(%id,"IMC")) != -1) %a += round(%a * (%mapb / 100));
			//*************************************************************
			%mana = %a;
			%blood = 0;
			if ((%r = GetBonus(%id,$BPBLOODMAGIC)) > 0) {
				%blood = round(%a * (%r / 100));
				%mana = %a - %blood;
			}
			else
				%blood = 0;
			//*************************************************************
			// MAP BLOODMAGIC
			if ((%mapb = GetMapBonus(%id,"BLD")) != -1) {
				%blood = %a;
				%mana = 0;
			}
			//*************************************************************
			if (%blood > 0) {
				if (fetchData(%id,"HP") < (%blood + 1)) {
					%m = 0;
					%msg = "You need at least " @ %blood @ " remaining hitpoints to cast this spell.";
				}
			}
			if (%mana > 0) {
				if (fetchData(%id,"MANA") < %mana) {
					%m = 0;
					%msg = "You need at least " @ %mana @ " remaining mana to cast this spell.";
				}
			}
		}
		else if (%r == "HEALTH") {
			if ((%r = GetBonus(%id,$BPMANACOST)) > 0)
				%a = round(%a * (%r / 100));
			//*************************************************************
			// MAP MANACOST
			if ((%mapb = GetMapBonus(%id,"IMC")) != -1) %a += round(%a * (%mapb / 100));
			//*************************************************************
			if (fetchData(%id,"HP") < %a) {
				%m = 0;
				%msg = "You need at least " @ %a @ " remaining hitpoints to cast this spell.";
			}
		}
		else if (%r == "MUSTBENORMAL") {
			%race = fetchData(%id,"Race");
			if (%race != "MaleHuman" && %race != "FemaleHuman" && %race != "FemaleBigHuman" && %race != "MaleBigHuman") {
				%m = 0;
				%msg = "You must be in normal form.";
			}
		}
		else if (%r == "USINGMELEE") {
			%weapon = getCurrentWearFull(%id,13);
			if ($BPItem[%weapon,$BPRanged] == 1 || %weapon == -1 || %weapon == "none" || $BPItem[%weapon,$BPIsMagWeapon] == 1) {
				%m = 0;
				%msg = "You must be using a melee weapon.";
			}
		}
		else if (%r == "USINGRANGED") {
			%weapon = getCurrentWearFull(%id,13);
			if ($BPItem[%weapon,$BPRanged] != 1 || %weapon == -1 || %weapon == "none" || $BPItem[%weapon,$BPIsMagWeapon] == 1) {
				%m = 0;
				%msg = "You must be using a ranged weapon.";
			}
		}
		else if (%r == "USINGSHIELD") {
			if (BPUsingShield(%id) == false) {
				%m = 0;
				%msg = "You must be using a shield.";
			}
		}
		else if (%r == "NOTMAXMINIONS") {
			if (CruAiMaxMinions(%id) == true) {
				%m = 0;
				%msg = "You already have your maximum allowed Minions.";
			}
		}
		else {
			%rcrop = $BPSkillToNumeric[%r];
			if (GetPlayerSkill(%id,%rcrop) < %a) {
				%msg = "You need at least " @ %a @ " in '" @ %r @ "' to cast this spell.";
				%m = 0;
			}
		}
		if (%msg != "")
			Client::SendMessage(%id,0,%msg);
	}

	%cost = $CruSpell[%spell,$CSSC];
	if (%have != True)
		%target = $TargetCur[%id,1];
	else
		%target = %id;

	if (%caster == "")
		%caster = %id;

	if (%cost != 0 && (fetchData(%target,"MaxSC") - fetchData(%target,"CurSC")) < %cost) {
		%found = 0;
		%cur = $CurPlayerSpells[%target];
		for (%i = 0; (%get = getWord(%cur,%i)) != -1; %i += 2) {
			if (%get == %spell) {
				%found = 1;
			}
		}
		if (!%found) {
			Client::SendMessage(%caster,0,"Target does not have enough remaining memory.");
			return False;
		}
	}

	if (!%m)
		return False;
	else
		return True;
}

function HasCruSpell(%id,%spell)
{
	if ($CruSpell[%spell,$CSMustLearn] == 0 || $CruSpell[%spell,$CSMustLearn] == "")
		return True;
	else
		%x = $CruSpell[%spell,$CSCategory];

	%s = $PlayerSpells[%id,%x];
	for (%i = 0; (%get = getWord(%s,%i)) != -1; %i++) {
		if (string::ICompare(%get,%spell) == 0)
			return True;
	}
	return False;
}

function CruTimeFormat(%t,%min)
{
	%m = 0;
	%h = 0;
	%s = 0;
	for (%i = %t; %t >= 3600; %t -= 3600)
		%h += 1;
	for (%i = %t; %t >= 60; %t -= 60)
		%m += 1;
	if (%h < 10)
		%h = "0" @ %h;
	if (%h <= 0)
		%h = "00";
	if (%m < 10)
		%m = "0" @ %m;
	if (%t < 10)
		%t = "0" @ %t;
	if (%min == 1)
		return %m @ ":" @ %t;
	else
		return %h @ ":" @ %m @ ":" @ %t;
}

function FormatDecimal(%n,%p)
{
	if (string::findSubStr(%n,".") == -1)
		return %n;
	else {
		%f = string::findSubStr(%n,".");
		%w = string::getSubStr(%n,0,%f);
		%x = string::getSubStr(%n,(%f+1),%p);
		return %w @ "." @ %x;
	}
}

function WhatIsCruSpell(%id,%spell,%grab)
{
	%msg = "";
	%msg = %msg @ "<f0>Spell - " @ $CruSpell[%spell,$CSName] @ "<f1>\n\n";
	
	%msg = %msg @ "Quality Level:<f0> " @ $CruSpell[%spell,$CSQuality] @ "<f1>\n";

	if ($CruSpell[%spell,$CSReqs] != "")
		%msg = %msg @ "Requirements: \n<f0> " @ BPFormat($CruSpell[%spell,$CSReqs]) @ "<f1>\n\n";
	if ($CruSpell[%spell,$CSHaveReqs] != "")
		%msg = %msg @ "Have:<f0> " @ BPFormat($CruSpell[%spell,$CSHaveReqs]) @ "<f1>\n";
	if ((%mode = $CruSpell[%spell,$CSMode]) != "") {

		if (%mode == "SELF") %msg = %msg @ "Mode:<f0> Self only <f1>\n";
		else if (%mode == "LOS") %msg = %msg @ "Mode:<f0> Target line of sight <f1>\n";
		else { %msg = %msg @ "Mode:<f0> Unknown Type <f1>\n"; }
	}
	if ($CruSpell[%spell,$CSTree] != "")
		%msg = %msg @ "Line:<f0> " @ $CruSpell[%spell,$CSTree] @ "<f1>\n";
	if ($CruSpell[%spell,$CSCastTime] != "")
		%msg = %msg @ "Cast:<f0> " @ FormatDecimal($CruSpell[%spell,$CSCastTime],2) @ "<f1>\n";
	if ($CruSpell[%spell,$CSRecovery] != "")
		%msg = %msg @ "Recovery:<f0> " @ FormatDecimal($CruSpell[%spell,$CSRecovery],2) @ "<f1>\n";
	if ($CruSpell[%spell,$CSSC] != "")
		%msg = %msg @ "Memory:<f0> " @ $CruSpell[%spell,$CSSC] @ "<f1>\n";
	%dur = CruTimeFormat($CruSpell[%spell,$CSDur]);
	if ($CruSpell[%spell,$CSDur] != "")
		%msg = %msg @ "Duration:<f0> " @ %dur @ "<f1>\n";
	if ($CruSpell[%spell,$CSTake] != "")
		%msg = %msg @ "Take:<f0> " @ BPFormat($CruSpell[%spell,$CSTake]) @ "<f1>\n";
	if ($CruSpell[%spell,$CSHostile] == 1) {
		%msg = %msg @ "Offense:<f0>\n " @ BPFormat($CruSpell[%spell,$CSOffense]) @ "<f1>\n";
		%msg = %msg @ "Defense:<f0>\n " @ BPFormat($CruSpell[%spell,$CSDefense]) @ "<f1>\n";
	}
	if ($CruSpell[%spell,$CSHostileBonus] != "") {
		%msg = %msg @ "Caster Bonus:\n<f0> " @ BPFormat($CruSpell[%spell,$CSHostileBonus]) @ "\n<f0>";
	}
	%msg = %msg @ "\n";
	if ($CruSpell[%spell,$CSBonus] != "")
		%msg = %msg @ "<f1>Bonus:\n<f0> " @ BPFormat($CruSpell[%spell,$CSBonus]) @ "\n\n<f0>";
	if ($CruSpell[%spell,$CSInfo] != "")
		%msg = %msg @ "<f1>" @ $CruSpell[%spell,$CSInfo] @ "<f1>\n\n";

	if ($CruSpell[%spell,$CSDOT] != "") {

		%dotname = $CruSpell[%spell,$CSDOT];
		%msg = %msg @ "<f1>DOT:<f0> " @ $CruSpell[%spell,$CSDOT] @ "\n";
		%msg = %msg @ "<f1>Interval:<f0> " @ $CruDOT[%dotname,$CDOTInterval] @ "\n";
		%msg = %msg @ "<f1>Hits:<f0> " @ $CruDOT[%dotname,$CDOTHits] @ "\n";
		%msg = %msg @ "<f1>Bonus:<f0>\n " @ BPFormat($CruDOT[%dotname,$CDOTBonus]) @ "\n";
	}

	if (%grab == True)
		return %msg;
	else
		SendBufferBP(%id,%msg,20);
}

//======================================================================================================================================

echo("LOADING PLUGINS__");

//exec("plugin_spells_generic.cs");
//exec("plugin_spells_cleric.cs");
//exec("plugin_spells_paladin.cs");
//exec("plugin_spells_druid.cs");
//exec("plugin_spells_mage.cs");

exec(autospells);

//======================================================================================================================================

echo("CRU SPELLS LOADED__");