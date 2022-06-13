function GetExpTnl(%clientId)
{
	%lvl = fetchData(%clientId,"LVL");
	%exp = fetchData(%clientId,"EXP");
	%t = %lvl * 1000;
	%n = %t - %exp;
	return %n;
}

function GetAExpTnl(%clientId)
{
	%lvl = fetchData(%clientId,"ALVL");
	%exp = fetchData(%clientId,"AEXP");
	%t = %lvl * 1000;
	%n = %t - %exp;
	return %n;
}

function fetchData(%clientId,%type)
{
	dbecho($dbechoMode, "fetchData(" @ %clientId @ ", " @ %type @ ")");
	%remort = $ClientData[%clientId,"RemortStep"];
	if(%type == "DEF")
	{
		%a = AddPoints(%clientId, 7);
		%b = AddBonusStatePoints(%clientId, "DEF");
		%c = (%a + %b);
		%d = (fetchData(%clientId, "OverweightStep") * 7.0) / 100;
		%e = Cap(%c - (%c * %d), 0, "inf");
		%e = %e + GetBonus(%clientId,$BPDEFBonus);

		return floor(%e);
	}
	else if(%type == "MDEF")
	{
		%a = AddPoints(%clientId, 3);
		%b = AddBonusStatePoints(%clientId, "MDEF");
		%c = (%a + %b);
		%d = (fetchData(%clientId, "OverweightStep") * 7.0) / 100;
		%e = Cap(%c - (%c * %d), 0, "inf");
		%e = %e + GetBonus(%clientId,$BPMDEFBonus);
		
		return floor(%e);
	}
	else if(%type == "ATK")
	{
		%atk = GetNewATK(%clientId,-1);
		return %atk;
	}
	else if(%type == "MaxHP")
	{
		%a = 10;
		%a += 1 + (GetPlayerSkill(%clientId,$SkillEndurance) * 4);
		%a *= $RaceHPMulti[fetchData(%clientId,"CruRACE")];
		%a += GetBonus(%clientId,$BPMAXHP);
		%a = %a * (1 + (GetBonus(%clientId,$BPHEALTH) / 100));
		%a += floor(%remort * 8);
		%val = 0;
		if ((%mh = GetBonus(%clientId,$BPMANAHEALTH)) > 0) {
			%x = 8;
			%x += GetPlayerSkill(%clientId,$SkillEnergy) * 4;
			%x *= $RaceManaMulti[fetchData(%clientId,"CruRACE")];
			%x += GetBonus(%clientId,$BPMAXMANA);
			%x = %x * (1 + (GetBonus(%clientId,$BPMANA) / 100));
			if (%x <= 8) %x = 8;
			%val = %x * %mh / 100;
		}
		%a += %val;
		//*************************************************************
		// MAP HEALTH
		if ((%mapb = GetMapBonus(%clientId,"RPH")) != -1) %a -= (%a * (%mapb / 100));
		if ((%mapb = GetMapBonus(%clientId,"IMH")) != -1) %a += (%a * (%mapb / 100));
		//*************************************************************
		if (%a <= 8)
			return 8;
		else
			return floor(%a);
	}
	else if(%type == "HP")
	{
		%armor = Player::getArmor(%clientId);
		%c = %armor.maxDamage - GameBase::getDamageLevel(Client::getOwnedObject(%clientId));
		%a = %c * fetchData(%clientId, "MaxHP");
		%b = %a / %armor.maxDamage;
		return round(%b);
	}
	else if (%type == "MaxSC") {
		%a = GetPlayerSkill(%clientId,$SkillWisdom) * 0.1488;
		%a += 8;
		%a += GetBonus(%clientId,$BPMAXMEMORY);
		%a += %remort;
		if (%a <= 8)
			return 8;
		else
			return round(%a);
	}
	else if (%type == "CurSC") {
		%sc = 0;
		%cur = $CurPlayerSpells[%clientId];
		for (%i = 0; (%get = getWord(%cur,%i)) != -1; %i += 2) {
			if ((%cost = $CruSpell[%get,$CSSC]) != "") {
				%sc += %cost;
			}
		}
		if (%sc <= 0)
			return 0;
		else
			return floor(%sc);
	}
	else if (%type == "MaxMANA")
	{
		%a = 10;
		%a += GetPlayerSkill(%clientId,$SkillEnergy) * 4;
		%a *= $RaceManaMulti[fetchData(%clientId,"CruRACE")];
		%a += GetBonus(%clientId,$BPMAXMANA);
		%a = %a * (1 + (GetBonus(%clientId,$BPMANA) / 100));
		%a += floor(%remort * 8);
		%val = 0;
		if ((%mh = GetBonus(%clientId,$BPHEALTHMANA)) > 0) {
			%x = 8;
			%x += 1 + (GetPlayerSkill(%clientId,$SkillEndurance) * 4);
			%x *= $RaceHPMulti[fetchData(%clientId,"CruRACE")];
			%x += GetBonus(%clientId,$BPMAXHP);
			%x = %x * (1 + (GetBonus(%clientId,$BPHEALTH) / 100));
			if (%x <= 8) %x = 8;
			%val = %x * %mh / 100;
		}
		%a += %val;
		//*************************************************************
		// MAP MANA
		if ((%mapb = GetMapBonus(%clientId,"RPM")) != -1) %a -= (%a * (%mapb / 100));
		//*************************************************************
		if (%a <= 8)
			return 8;
		else
			return floor(%a);
	}
	else if (%type == "MANA")
	{
		%armor = Player::getArmor(%clientId);
		%a = GameBase::getEnergy(Client::getOwnedObject(%clientId)) * fetchData(%clientId, "MaxMANA");
		%b = %a / %armor.maxEnergy;

		return round(%b);
	}
	else if (%type == "MaxWeight")
	{
		%a = GetPlayerSkill(%clientId,$SkillWeightCapacity);
		%a += GetBonus(%clientId,$BPMAXWEIGHT);
		%a += floor(GetBonus(%clientId,$BPADDALLOFF) * 3);
		return round(%a);
	}
	else if (%type == "Weight")
	{
		return GetWeight(%clientId);
	}
	else if (%type == "RankPoints")
	{
		return Cap(floor($ClientData[%clientId, %type]), 0, "inf");
	}
	else if (%type == "OverweightStep")
	{
		return Cap(floor($ClientData[%clientId, %type]), 0, "inf");
	}
	else if (%type == "SlowdownHitFlag")
	{
		if (Player::isAiControlled(%clientId))
			return False;
		else
			return $ClientData[%clientId, %type];
	}
	else
		return $ClientData[%clientId, %type];

	return False;
}
function remotefetchData(%clientId, %type)
{
	dbecho($dbechoMode, "remotefetchData(" @ %clientId @ ", " @ %type @ ")");

	//rpgfetchdata specific vartypes
	if(%type == "zonedesc")
	{
		%r = fetchData(%clientId, "zone");
		%data = Zone::getDesc(%r);
	}
	else if(%type == "password")
	{
		return;
	}
	else if(%type == "servername")
	{
		%data = $Server::HostName;
	}
	else if (GetWord(%type, 0) == "skill" && (%s = GetWord(%type, 1)) != -1)
	{
		%data = $PlayerSkill[%clientId, %s];
	}
	else if (GetWord(%type, 0) == "getbuycost" && (%s = GetWord(%type, 1)) != -1)
	{
		%data = getBuyCost(%clientId, %s);
	}
	else if (GetWord(%type, 0) == "getsellcost" && (%s = GetWord(%type, 1)) != -1)
	{
		%data = getSellCost(%clientId, %s);
	}
	else if(GetWord(%type, 0) == "skillcanuse" && (%s = GetWord(%type, 1)) != -1)
	{
		%data = SkillCanUse(%clientId, %s);
	}
	else if (GetWord(%type, 0) == "spellcancast" && (%s = GetWord(%type, 1)) != -1)
	{
		%data = SpellCanCast(%clientId, %s);
	}
	else if (GetWord(%type, 0) == "skillcancastnow" && (%s = GetWord(%type, 1)) != -1)
	{
		%data = SpellCanCastNow(%clientId, %s);
	}
	else
		%data = fetchData(%clientId, %type);

	remoteEval(%clientId, SetRPGdata, %data, %type);
}

function storeData(%clientId, %type, %amt, %special)
{
	dbecho($dbechoMode, "storeData(" @ %clientId @ ", " @ %type @ ", " @ %amt @ ", " @ %special @ ")");

	if(%type == "HP")
	{
		setHP(%clientId, %amt);
	}
	else if(%type == "MANA")
	{
		setMANA(%clientId, %amt);
	}
	else if(%type == "MaxHP" || %type == "MaxMANA" || %type == "MaxWeight" || %type == "Weight")
	{
		echo("Invalid call to storeData for " @ %type @ " : Can't manually set this variable.");
	}
	else
	{
		if(%special == "inc")
			$ClientData[%clientId, %type] += %amt;
		else if(%special == "dec")
			$ClientData[%clientId, %type] -= %amt;
		else if(%special == "strinc")
			$ClientData[%clientId, %type] = $ClientData[%clientId, %type] @ %amt;
		else
			$ClientData[%clientId, %type] = %amt;

		if(GetWord(%special, 1) == "cap")
			$ClientData[%clientId, %type] = Cap($ClientData[%clientId, %type], GetWord(%special, 2), GetWord(%special, 3));
	}
}

function MenuCruSP(%clientId, %page)
{
	Client::buildMenu(%clientId, "You have " @ fetchData(%clientId, "SPcredits") @ " SP credits", "CruSp", true);
	Client::addMenuItem(%clientId, "1Attributes...", "attributes");
	Client::addMenuItem(%clientId, "2Body...", "body");
	Client::addMenuItem(%clientId, "3Weapon...", "weapon");
	Client::addMenuItem(%clientId, "4Speed & Evades...", "speed");
	Client::addMenuItem(%clientId, "5Spells & Casting...", "spells");
	Client::addMenuItem(%clientId, "6Trade & Navigation...", "trade");
	Client::addMenuItem(%clientId, "p<< Prev", "spback");
}

function processMenuCruSp(%clientId,%opt)
{
	if (%opt != "spback")
		MenuCruSpSelect(%clientId,%opt,1);
	else
		Game::menuRequest(%clientId);
}

function GetMenuSkill(%clientId,%skill)
{
	return "2";
}

function MenuCruSPSelect(%clientId,%select,%page)
{
	Client::buildMenu(%clientId, "You have " @ fetchData(%clientId, "SPcredits") @ " SP credits", "CruSPSelect", true);
	if (%select == "attributes") {
		if (%page == 1) {
			%cnt = 0;
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillStrength] @ ") Strength " @ "[" @ GetPlayerSkill(%clientId,$SkillStrength) @ "]", "attributes 1 " @ $SkillStrength);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillDexterity] @ ") Dexterity " @ "[" @ GetPlayerSkill(%clientId,$SkillDexterity) @ "]", "attributes 1 " @ $SkillDexterity);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillIntelligence] @ ") Intelligence " @ "[" @ GetPlayerSkill(%clientId,$SkillIntelligence) @ "]", "attributes 1 " @ $SkillIntelligence);
			Client::addMenuItem(%clientId, "p<< Prev", "prev attributes");
			Client::addMenuItem(%clientId, "xDone", "done");
		}	
	}
	if (%select == "body") {
		if (%page == 1) {
			%cnt = 0;
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillEndurance] @ ") Endurance " @ "[" @ GetPlayerSkill(%clientId,$SkillEndurance) @ "]", "body 1 " @ $SkillEndurance);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillEnergy] @ ") Energy " @ "[" @ GetPlayerSkill(%clientId,$SkillEnergy) @ "]", "body 1 " @ $SkillEnergy);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillWeightCapacity] @ ") Weight Capacity " @ "[" @ GetPlayerSkill(%clientId,$SkillWeightCapacity) @ "]", "body 1 " @ $SkillWeightCapacity);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillHealing] @ ") Healing " @ "[" @ GetPlayerSkill(%clientId,$SkillHealing) @ "]", "body 1 " @ $SkillHealing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillWisdom] @ ") Wisdom " @ "[" @ GetPlayerSkill(%clientId,$SkillWisdom) @ "]", "body 1 " @ $SkillWisdom);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillMartialArts] @ ") Martial Arts " @ "[" @ GetPlayerSkill(%clientId,$SkillMartialArts) @ "]", "body 1 " @ $SkillMartialArts);
			Client::addMenuItem(%clientId, "p<< Prev", "prev attributes");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
	if (%select == "weapon") {
		if (%page == 1) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillSlashing] @ ") Slashing " @ "[" @ GetPlayerSkill(%clientId,$SkillSlashing) @ "]", "weapon 1 " @ $SkillSlashing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillPiercing] @ ") Piercing " @ "[" @ GetPlayerSkill(%clientId,$SkillPiercing) @ "]", "weapon 1 " @ $SkillPiercing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillBludgeoning] @ ") Bludgeoning " @ "[" @ GetPlayerSkill(%clientId,$SkillBludgeoning) @ "]", "weapon 1 " @ $SkillBludgeoning);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillArchery] @ ") Archery " @ "[" @ GetPlayerSkill(%clientId,$SkillArchery) @ "]", "weapon 1 " @ $SkillArchery);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillBashing] @ ") Bashing " @ "[" @ GetPlayerSkill(%clientId,$SkillBashing) @ "]", "weapon 1 " @ $SkillBashing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillAiming] @ ") Aiming " @ "[" @ GetPlayerSkill(%clientId,$SkillAiming) @ "]", "weapon 1 " @ $SkillAiming);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillBrawling] @ ") Brawling " @ "[" @ GetPlayerSkill(%clientId,$SkillBrawling) @ "]", "weapon 1 " @ $SkillBrawling);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillBackstabbing] @ ") Sneak Attack " @ "[" @ GetPlayerSkill(%clientId,$SkillBackstabbing) @ "]", "weapon 1 " @ $SkillBackstabbing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillCleave] @ ") Cleave " @ "[" @ GetPlayerSkill(%clientId,$SkillCleave) @ "]", "weapon 1 " @ $SkillCleave);
			Client::addMenuItem(%clientId, "0" @ "(" @ $PlayerSkill[%clientId,$SkillWeaponHandling] @ ") Weapon Handling " @ "[" @ GetPlayerSkill(%clientId,$SkillWeaponHandling) @ "]", "weapon 1 " @ $SkillWeaponHandling);
			Client::addMenuItem(%clientId, "p<< Prev", "prev attributes");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
	if (%select == "speed") {
		if (%page == 1) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillEvadeMelee] @ ") Evade Melee " @ "[" @ GetPlayerSkill(%clientId,$SkillEvadeMelee) @ "]", "speed 1 " @ $SkillEvadeMelee);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillDodging] @ ") Dodge Ranged " @ "[" @ GetPlayerSkill(%clientId,$SkillDodging) @ "]", "speed 1 " @ $SkillDodging);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillSpellResistance] @ ") Spell Resistance " @ "[" @ GetPlayerSkill(%clientId,$SkillSpellResistance) @ "]", "speed 1 " @ $SkillSpellResistance);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillCastInit] @ ") Cast Speed " @ "[" @ GetPlayerSkill(%clientId,$SkillCastInit) @ "]", "speed 1 " @ $SkillCastInit);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillStealing] @ ") Stealing " @ "[" @ GetPlayerSkill(%clientId,$SkillStealing) @ "]", "speed 1 " @ $SkillStealing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillHiding] @ ") Hiding " @ "[" @ GetPlayerSkill(%clientId,$SkillHiding) @ "]", "speed 1 " @ $SkillHiding);
			Client::addMenuItem(%clientId, "p<< Prev", "prev attributes");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
	if (%select == "spells") {
		if (%page == 1) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillPrimalMagic] @ ") Primal Magic " @ "[" @ GetPlayerSkill(%clientId,$SkillPrimalMagic) @ "]", "spells 1 " @ $SkillPrimalMagic);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillHolyMagic] @ ") Holy Magic " @ "[" @ GetPlayerSkill(%clientId,$SkillHolyMagic) @ "]", "spells 1 " @ $SkillHolyMagic);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillEmpowerment] @ ") Empowerment " @ "[" @ GetPlayerSkill(%clientId,$SkillEmpowerment) @ "]", "spells 1 " @ $SkillEmpowerment);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillDarkMagic] @ ") Dark Magic " @ "[" @ GetPlayerSkill(%clientId,$SkillDarkMagic) @ "]", "spells 1 " @ $SkillDarkMagic);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillLightMagic] @ ") Light Magic " @ "[" @ GetPlayerSkill(%clientId,$SkillLightMagic) @ "]", "spells 1 " @ $SkillLightMagic);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillRitual] @ ") Ritual " @ "[" @ GetPlayerSkill(%clientId,$SkillRitual) @ "]", "spells 1 " @ $SkillRitual);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillSorcery] @ ") Sorcery " @ "[" @ GetPlayerSkill(%clientId,$SkillSorcery) @ "]", "spells 1 " @ $SkillSorcery);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillProtection] @ ") Protection " @ "[" @ GetPlayerSkill(%clientId,$SkillProtection) @ "]", "spells 1 " @ $SkillProtection);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillEnchantment] @ ") Enchantment " @ "[" @ GetPlayerSkill(%clientId,$SkillEnchantment) @ "]", "spells 1 " @ $SkillEnchantment);
			Client::addMenuItem(%clientId, "0" @ "(" @ $PlayerSkill[%clientId,$SkillSpellCapacity] @ ") Focus " @ "[" @ GetPlayerSkill(%clientId,$SkillSpellCapacity) @ "]", "spells 1 " @ $SkillSpellCapacity);
			Client::addMenuItem(%clientId, "p<< Prev", "prev attributes");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
	if (%select == "trade") {
		if (%page == 1) {
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillMining] @ ") Mining " @ "[" @ GetPlayerSkill(%clientId,$SkillMining) @ "]", "trade 1 " @ $SkillMining);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillSpeech] @ ") Speech " @ "[" @ GetPlayerSkill(%clientId,$SkillSpeech) @ "]", "trade 1 " @ $SkillSpeech);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillSenseHeading] @ ") Sense Heading " @ "[" @ GetPlayerSkill(%clientId,$SkillSenseHeading) @ "]", "trade 1 " @ $SkillSenseHeading);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillHaggling] @ ") Haggling " @ "[" @ GetPlayerSkill(%clientId,$SkillHaggling) @ "]", "trade 1 " @ $SkillHaggling);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillLiteracy] @ ") Literacy " @ "[" @ GetPlayerSkill(%clientId,$SkillLiteracy) @ "]", "trade 1 " @ $SkillLiteracy);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillSmithing] @ ") Smithing " @ "[" @ GetPlayerSkill(%clientId,$SkillSmithing) @ "]", "trade 1 " @ $SkillSmithing);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillMagicCraft] @ ") Magic Crafting " @ "[" @ GetPlayerSkill(%clientId,$SkillMagicCraft) @ "]", "trade 1 " @ $SkillMagicCraft);
			Client::addMenuItem(%clientId, %cnt++ @ "(" @ $PlayerSkill[%clientId,$SkillAlchemy] @ ") Alchemy " @ "[" @ GetPlayerSkill(%clientId,$SkillAlchemy) @ "]", "trade 1 " @ $SkillAlchemy);
			Client::addMenuItem(%clientId, "p<< Prev", "prev attributes");
			Client::addMenuItem(%clientId, "xDone", "done");
		}
	}
}

function processMenuCruSPSelect(%clientId,%opt)
{
	%select = getWord(%opt,0);
	%page = getWord(%opt,1);
	%skill = getWord(%opt,2);
	if(fetchData(%clientId, "SPcredits") > 0 && %select != "done" && %select != "prev" && %select != "next")
	{
		if(%clientId.bulkNum < 1)
			%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 30 && !(%clientId.adminLevel >= 1) )
			%clientId.bulkNum = 30;
		for(%i = 1; %i <= %clientId.bulkNum; %i++)
		{
			if(fetchData(%clientId, "SPcredits") > 0)
			{
				if(AddSkillPoint(%clientId,%skill))
					storeData(%clientId, "SPcredits", 1, "dec");
				else
					break;
			}
			else
				break;
		}
		RefreshAll(%clientId,true);
	}
	if (%select == "prev") {
		if (%page == "attributes") {
			MenuCruSP(%clientId, 1);
		}
		else {
			MenuCruSPSelect(%clientId,%page,%skill);
		}
	}
	else if (%select == "next") {
		MenuCruSPSelect(%clientId,%page,%skill);
	}
	else {
		if (%select != "done")
			MenuCruSPSelect(%clientId,%select,%page);
	}
}

function MenuSP(%clientId, %page)
{
	dbecho($dbechoMode, "MenuSP(" @ %clientId @ ", " @ %page @ ")");

	Client::buildMenu(%clientId, "You have " @ fetchData(%clientId, "SPcredits") @ " SP credits", "sp", true);

	%clientId.bulkNum = "";

	%l = 6;
	%ns = GetNumSkills();
	%np = floor(%ns / %l);
	
	%lb = (%page * %l) - (%l-1);
	%ub = %lb + (%l-1);
	if(%ub > %ns)
		%ub = %ns;

	for(%i = %lb; %i <= %ub; %i++) {
		%skill = GetPlayerSkill(%clientId, %i);
		%dec = String::findSubStr(%skill,".");
		if (%dec != -1)
			%skill = String::getSubStr(%skill,0,%dec + 2);
		Client::addMenuItem(%clientId, %cnt++ @ "(" @ %skill @ ") " @ $SkillDesc[%i], %i @ " " @ %page);
	}
	if(%page == 1)
	{
		Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else if(%page == %np+1)
	{
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1);
		Client::addMenuItem(%clientId, "xDone", "done");
	}
	else
	{
		Client::addMenuItem(%clientId, "nNext >>", "page " @ %page+1);
		Client::addMenuItem(%clientId, "p<< Prev", "page " @ %page-1);
	}

	return;
}
function processMenusp(%clientId, %opt)
{
	dbecho($dbechoMode, "processMenusp(" @ %clientId @ ", " @ %opt @ ")");

	%o = GetWord(%opt, 0);
	%p = GetWord(%opt, 1);

	if(fetchData(%clientId, "SPcredits") > 0 && %o != "page" && %o != "done")
	{
		if(%clientId.bulkNum < 1)
			%clientId.bulkNum = 1;
		if(%clientId.bulkNum > 30 && !(%clientId.adminLevel >= 1) )
			%clientId.bulkNum = 30;

		for(%i = 1; %i <= %clientId.bulkNum; %i++)
		{
			if(fetchData(%clientId, "SPcredits") > 0)
			{
				if(AddSkillPoint(%clientId, %o))
					storeData(%clientId, "SPcredits", 1, "dec");
				else
					break;
			}
			else
				break;
		}
		RefreshAll(%clientId,true);
	}

	if(%o != "done")
		MenuSP(%clientId, %p);
}
function processMenunull(%clientId, %opt)
{
	return;
}

function MenuRace(%clientId)
{
	Client::buildMenu(%clientId, "Pick a Race:", "pickrace", true);
	Client::addMenuItem(%clientId, "1Human", 1);
	Client::addMenuItem(%clientId, "2Orc", 2);
	Client::addMenuItem(%clientId, "3Elf", 3);
	Client::addMenuItem(%clientId, "4Dark Elf", 4);
	Client::addMenuItem(%clientId, "5Shadow Orc", 5);
	Client::addMenuItem(%clientId, "6Nephilim", 6);
	Client::addMenuItem(%clientId, "7Cambion", 7);
}

function processMenupickrace(%clientId,%opt)
{
	if(%opt == 1) {
		storeData(%clientId, "CruRACE", "Human");
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
	}
	else if (%opt == 2) {
		storeData(%clientId, "CruRACE", "Orc");
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "BigHuman");
	}
	else if (%opt == 3) {
		storeData(%clientId, "CruRACE", "Elf");
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
	}
	else if (%opt == 4) {
		storeData(%clientId, "CruRACE", "DarkElf");
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
	}
	else if (%opt == 5) {
		storeData(%clientId, "CruRACE", "ShadowOrc");
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
	}
	else if (%opt == 6) {
		storeData(%clientId, "CruRACE", "Nephilim");
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "BigHuman");
	}
	else if (%opt == 7) {
		storeData(%clientId, "CruRACE", "Cambion");
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
	}
	else {
		storeData(%clientId, "CruRACE", "Human");
		storeData(%clientId, "RACE", Client::getGender(%clientId) @ "Human");
	}
	
	if (%opt == 1)
		bottomPrint(%clientId,"<jc><f1>Human<f0><n><n>Strength: Medium<n>Dexterity: Medium<n>Intelligence: Medium<n>",10);
	else if (%opt == 2)
		bottomPrint(%clientId,"<jc><f1>Orc<f0><n><n>Strength: High<n>Dexterity: Medium<n>Intelligence: Low<n>",10);
	else if (%opt == 3)
		bottomPrint(%clientId,"<jc><f1>Elf<f0><n><n>Strength: Low<n>Dexterity: Medium<n>Intelligence: High<n>",10);
	else if (%opt == 4)
		bottomPrint(%clientId,"<jc><f1>Dark Elf<f0><n><n>Strength: Low<n>Dexterity: High<n>Intelligence: Medium<n>",10);
	else if (%opt == 5)
		bottomPrint(%clientId,"<jc><f1>Shadow Orc<f0><n><n>Strength: Medium<n>Dexterity: High<n>Intelligence: Low<n>",10);
	else if (%opt == 6)
		bottomPrint(%clientId,"<jc><f1>Nephilim<f0><n><n>Strength: High<n>Dexterity: Low<n>Intelligence: Medium<n>",10);
	else if (%opt == 7)
		bottomPrint(%clientId,"<jc><f1>Cambion<f0><n><n>Strength: Medium<n>Dexterity: Low<n>Intelligence: High<n>",10);
	else
		bottomPrint(%clientId,"<jc><f1>Human<f0><n><n>Strength: Medium<n>Dexterity: Medium<n>Intelligence: Medium<n>",10);	

	%clientId.choosingRace = "";
	%clientId.ConfirmRace = True;
	
	MenuConfirmRace(%clientId);
}

function MenuConfirmRace(%clientid)
{
	Client::buildMenu(%clientId, "Confirm Race: " @ fetchData(%clientId,"CruRACE"), "confirmrace", true);
	Client::addMenuItem(%clientId, "1Confirm", 1);
	Client::addMenuItem(%clientId, "x<< Back", "back");
}

function processMenuconfirmrace(%clientId,%opt)
{
	if(%opt == "back") {
		%clientId.ConfirmRace = "";
		%clientId.choosingRace = True;
		storeData(%clientId, "CruRACE", "Human");
		MenuRace(%clientId);
		return;
	}
	else {
		storeData(%clientId, "CLASS", "Adventurer");
		%clientId.ConfirmRace = "";
		Game::playerSpawn(%clientId, false);
		storeData(%clientId, "COINS", 0);
		for(%i = 1; %i <= getNumSkills(); %i++)
			AddSkillPoint(%clientId, %i, 1);
		centerprint(%clientId, "<f1><n>Welcome to the Crucible", 10);
	}
}

function StartStatSelection(%clientId)
{
	dbecho($dbechoMode, "StartStatSelection(" @ %clientId @ ")");

	%group = nameToId("MissionGroup\\ObserverDropPoints");
	%observerMarker = Group::getObject(%group, 0);
	
	Client::setControlObject(%clientId, Client::getObserverCamera(%clientId));
	Observer::setFlyMode(%clientId, GameBase::getPosition(%observerMarker), GameBase::getRotation(%observerMarker), false, true);

	storeData(%clientId, "SPcredits", $initSPcredits);

	MenuRace(%clientId);
}

function GiveLevelUpSp(%id)
{
	%lvl = fetchData(%id,"LVL");
	if (%lvl >= 1 && %lvl <= 49) %n = 80;
	else if (%lvl >= 50 && %lvl <= 99) %n = 80;
	else if (%lvl >= 100 && %lvl <= 149) %n = 80;
	else if (%lvl >= 150 && %lvl <= 199) %n = 80;
	else if (%lvl >= 200 && %lvl <= 230) %n = 90;
	storeData(%id, "SPcredits", %n, "inc");
}

function Game::refreshClientScore(%clientId)
{
	dbecho($dbechoMode2, "Game::refreshClientScore(" @ %clientId @ ")");
	if (fetchData(%clientId, "HasLoadedAndSpawned"))
	{
		%lvl = fetchData(%clientId,"LVL");
		%tnl = GetExpTnl(%clientId);
		if (%tnl <= 0 && %lvl < 230) {
			%lvl++;
			storeData(%clientId,"LVL",%lvl);
			storeData(%clientId,"EXP",0);
			$PassivePoints[%clientId]++;
			GiveLevelUpSp(%clientId);
			Client::sendMessage(%clientId,0,"Welcome to level " @ fetchData(%clientId, "LVL"));
			PlaySound(SoundLevelUp, GameBase::getPosition(%clientId));
		}
		if (%lvl == 230) {
			%tnl = GetAExpTnl(%clientId);
			%alvl = fetchData(%clientId,"ALVL");
			if (%tnl <= 0) {
				%alvl++;
				storeData(%clientId,"ALVL",%alvl);
				storeData(%clientId,"AEXP",0);
				Client::sendMessage(%clientId,0,"Welcome to Arcane level " @ fetchData(%clientId, "ALVL"));
				PlaySound(SoundLevelUp, GameBase::getPosition(%clientId));
			}
		}
	}
	%z = GetZoneData(fetchData(%clientId, "zone"),$ZoneDisp);
	%lvl = fetchData(%clientId, "LVL");
	%alvl = fetchData(%clientId, "ALVL");
	%roman = %clientId.RemortRoman;
	if($displayPingAndPL) {
		if (%lvl < 230)
			Client::setScore(%clientId, "%n\t" @ %z @ "\t  " @ %lvl @ "\t%p\t%l", (%lvl + %alvl));
		else
			Client::setScore(%clientId, "%n\t" @ %z @ "\t  +" @ %alvl @ "\t%p\t%l", (%lvl + %alvl));
	}
	else {
		if (%lvl < 230)
			Client::setScore(%clientId, "%n\t" @ %z @ "\t " @ %lvl @ "\t" @ getFinalCLASS(%clientId) @ " " @ %roman, (%lvl + %alvl));
		else
			Client::setScore(%clientId, "%n\t" @ %z @ "\t +" @ %alvl @ "\t" @ getFinalCLASS(%clientId) @ " " @ %roman, (%lvl + %alvl));
	}
}

function dbecho() { }

function RemortRoman(%id)
{
	%ret = "";
	%remort = fetchData(%id,"RemortStep");
	if (%remort < 1) { %id.RemortRoman = ""; return; }
	if (%remort > 3999) { %id.RemortRoman = "Ascended"; return; }
	%number = %remort;
	while (%number >= 1000) { %ret = %ret @ "M"; %number -= 1000; }
    while (%number >= 900) { %ret = %ret @ "CM"; %number -= 900; }
    while (%number >= 500) { %ret = %ret @ "D"; %number -= 500; }
    while (%number >= 400) { %ret = %ret @ "CD"; %number -= 400; }
    while (%number >= 100) { %ret = %ret @ "C"; %number -= 100; }            
    while (%number >= 90) { %ret = %ret @ "XC"; %number -= 90; }
    while (%number >= 50) { %ret = %ret @ "L"; %number -= 50; }
    while (%number >= 40) { %ret = %ret @ "XL"; %number -= 40; }
    while (%number >= 10) { %ret = %ret @ "X"; %number -= 10; }
    while (%number >= 9) { %ret = %ret @ "IX"; %number -= 9; }
    while (%number >= 5) { %ret = %ret @ "V"; %number -= 5; }
    while (%number >= 4) { %ret = %ret @ "IV"; %number -= 4; }
    while (%number >= 1) { %ret = %ret @ "I"; %number -= 1; }
	%id.RemortRoman = %ret;
}

function DoRemort(%TrueClientId)
{
		%lvl = fetchData(%TrueClientId, "LVL");
		%lvl += fetchData(%TrueClientId, "ALVL");
		%remort = fetchData(%TrueClientId, "RemortStep");
		%need = 230 + %remort;
		if (%lvl < %need) {
			Client::SendMessage(%TrueClientId,0,"You must be LVL " @ %need @ " or higher to remort.");
			return;
		}
		%naked = true;
		for (%x = 1; %x <= 30; %x++) {
			%wear = GetCurrentWear(%TrueClientId,%x);
			if (%wear != "none")
				%naked = false;
		}
		if (%naked == false) {
			Client::SendMessage(%TrueClientId,0,"You must have no gear equiped to remort.");
			return;
		}
		if ($CURRENTCRUMAP != "FOREST") {
			Client::SendMessage(%TrueClientId,0,"You must be on the Forest World to remort.");
			return;
		}
		%remort++;
		DeathEndSpells(%TrueClientId);
		for (%si = 1; %si <= 51; %si++)
			$PlayerSkill[%TrueClientId,%si] = 1;
		%race = fetchData(%TrueClientId,"CruRACE");
		$PlayerSkill[%TrueClientId,$SkillStrength] = $AbilityMultiplier[%race, $SkillStrength];
		$PlayerSkill[%TrueClientId,$SkillDexterity] = $AbilityMultiplier[%race, $SkillDexterity];
		$PlayerSkill[%TrueClientId,$SkillIntelligence] = $AbilityMultiplier[%race, $SkillIntelligence];
		%sp = 70;
		%sp += floor(%remort * 10);
		storeData(%TrueClientId,"SPcredits",%sp);
		storeData(%TrueClientId,"LVL",1);
		storeData(%TrueClientId,"ALVL",0);
		storeData(%TrueClientId,"RemortStep",%remort);
		RemortRoman(%TrueClientId);
		Player::setDamageFlash(%TrueClientId, 1.0);
		%obj = client::GetOwnedObject(%TrueClientId);
		%pos = $TOWNPORTALPOS;
		%rot = $TOWNPORTALROT;
		Item::SetVelocity(%obj,"0 0 0");
		GameBase::SetPosition(%obj,%pos);
		GameBase::SetRotation(%obj,%rot);
		%sound = "RespawnB";
		schedule("PlaySound("@%sound@",\""@GameBase::getPosition(%TrueClientId)@"\");",0.1);
		%sound = "RespawnC";
		schedule("PlaySound("@%sound@",\""@GameBase::getPosition(%TrueClientId)@"\");",0.6);
		RefreshAll(%TrueClientId);
		Client::sendMessage(%TrueClientId,3,"Welcome to Remort Level " @ fetchData(%TrueClientId,"RemortStep") @ "!");
}

function GetRankBonus(%clientId)
{
	dbecho($dbechoMode, "GetRankBonus(" @ %clientId @ ")");

	return 1 + ( fetchData(%clientId, "RankPoints") / 100 );
}

function fetchEvasion(%id)
{
	%lvl = fetchData(%id,"LVL");
	%ac = round((GetBonus(%id,$BPEVASION) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCEVASION) / 100) + 1));
	%chance = round((30000 * (%lvl/300)) * Cap((%lvl/115),0,1)) + 1;
	%chance = Cap(round(50 * (%ac / %chance)),0,50);
	%chance += Round((GetBonus(%id,$BPADDALLDEF) / 150));
	return %chance;
}

function fetchReduction(%id,%type)
{
	%lvl = fetchData(%id,"LVL");
	if (%type == "ARMOR")  %ac = round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1));
	if (%type == "MELEEAC") %ac = round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPMELEEAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1));
	if (%type == "PROJAC") %ac = round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPPROJAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1));
	if (%type == "FIREAC") %ac = round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPFIREAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1));
	if (%type == "COLDAC") %ac = round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPCOLDAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1));
	if (%type == "POISONAC") %ac = round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPPOISONAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1));
	if (%type == "ENERGYAC") %ac = round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPENERGYAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1));
	if (%type == "ALLRESIST") %ac = round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1));
	if (%type == "MELEERES") %ac = round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPMELEERES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1));
	if (%type == "PROJRES") %ac = round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPPROJRES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1));
	if (%type == "FIRERES") %ac = round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPFIRERES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1));
	if (%type == "COLDRES") %ac = round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPCOLDRES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1));
	if (%type == "POISONRES") %ac = round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPPOISONRES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1));
	if (%type == "ENERGYRES") %ac = round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPENERGYRES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1));
	%reduction = round((30000 * (%lvl/300)) * Cap((%lvl/115),0,1)) + 1;
	%reduction = Cap(round(50 * (%ac / %reduction)),0,50);
	%reduction += Round((GetBonus(%id,$BPADDALLDEF) / 150));
	return %reduction;
}

function fetchStat(%id,%type)
{
	if (%type == "AAD") return GetBonus(%id,$BPADDALLDEF);
	//------------------------------------------------------------------------------------------------------------------
	if (%type == "EVADEMELEE") return round(GetPlayerSkill(%id,$SkillEvadeMelee) + GetBonus(%id,$BPADDALLDEF));
	if (%type == "DODGERANGED") return round(GetPlayerSkill(%id,$SkillDodging) + GetBonus(%id,$BPADDALLDEF));
	if (%type == "SPELLRESISTANCE") return round(GetPlayerSkill(%id,$SkillSpellResistance) + GetBonus(%id,$BPADDALLDEF));
	//------------------------------------------------------------------------------------------------------------------
	if (%type == "ARMOR") return GetBonus(%id,$BPARMOR);
	if (%type == "INCARMOR") return GetBonus(%id,$BPINCARMOR);
	if (%type == "ARMORFULL") { return round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1)); }
	if (%type == "MELEEAC") return GetBonus(%id,$BPMELEEAC);
	if (%type == "PROJAC") return GetBonus(%id,$BPPROJAC);
	if (%type == "FIREAC") return GetBonus(%id,$BPFIREAC);
	if (%type == "COLDAC") return GetBonus(%id,$BPCOLDAC);
	if (%type == "POISONAC") return GetBonus(%id,$BPPOISONAC);
	if (%type == "ENERGYAC") return GetBonus(%id,$BPENERGYAC);
	if (%type == "MELEEACFULL") { return round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPMELEEAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1)); }
	if (%type == "PROJACFULL") { return round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPPROJAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1)); }
	if (%type == "FIREACFULL") { return round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPFIREAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1)); }
	if (%type == "COLDACFULL") { return round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPCOLDAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1)); }
	if (%type == "POISONACFULL") { return round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPPOISONAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1)); }
	if (%type == "ENERGYACFULL") { return round((GetBonus(%id,$BPARMOR) + GetBonus(%id,$BPENERGYAC) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1)); }
	//------------------------------------------------------------------------------------------------------------------
	if (%type == "ALLRESIST") return GetBonus(%id,$BPALLRESIST);
	if (%type == "INCRESIST") return GetBonus(%id,$BPINCRESIST);
	if (%type == "ALLRESISTFULL") { return round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1)); }
	if (%type == "MELEERES") return GetBonus(%id,$BPMELEERES);
	if (%type == "PROJRES") return GetBonus(%id,$BPPROJRES);
	if (%type == "FIRERES") return GetBonus(%id,$BPFIRERES);
	if (%type == "COLDRES") return GetBonus(%id,$BPCOLDRES);
	if (%type == "POISONRES") return GetBonus(%id,$BPPOISONRES);
	if (%type == "ENERGYRES") return GetBonus(%id,$BPENERGYRES);
	if (%type == "MELEERESFULL") { return round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPMELEERES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1)); }
	if (%type == "PROJRESFULL") { return round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPPROJRES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1)); }
	if (%type == "FIRERESFULL") { return round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPFIRERES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1)); }
	if (%type == "COLDRESFULL") { return round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPCOLDRES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1)); }
	if (%type == "POISONRESFULL") { return round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPPOISONRES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1)); }
	if (%type == "ENERGYRESFULL") { return round((GetBonus(%id,$BPALLRESIST) + GetBonus(%id,$BPENERGYRES) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCRESIST) / 100) + 1)); }
	//------------------------------------------------------------------------------------------------------------------
	if (%type == "EVASION") return GetBonus(%id,$BPEVASION);
	if (%type == "INCEVASION") return GetBonus(%id,$BPINCEVASION);
	if (%type == "EVASIONFULL") { return round((GetBonus(%id,$BPEVASION) + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCEVASION) / 100) + 1)); }
	//------------------------------------------------------------------------------------------------------------------	
	if (%type == "HEALDELTA") { 				
		%healskill = GetPlayerSkill(%id,$SkillEndurance);
		%delta = floor(%healskill / 60);
		%delta += 1;
		%delta += GetBonus(%id,$BPHEALDELTA);
		return %delta;		
	}
	//------------------------------------------------------------------------------------------------------------------
}

function ViewStats(%clientId,%stats)
{
	//echo("VIEWSTATS " @ %clientId @ " " @ %stats);
	%lvl = fetchData(%clientId,"LVL");
	if (%stats == "") %stats = 1;
	%msg = "";
	if (%stats == 1) {
		%msg = %msg @ "<f1><jc>" @ Client::getName(%clientId) @ ", LEVEL " @ fetchData(%clientId, "LVL") @ " " @ fetchData(%clientId, "CruRACE") @ " " @ getFINALClass(%clientId) @  ", REMORT " @ fetchData(%clientId,"RemortStep") @ "<f0>\n\n";
		%msg = %msg @ "<b:ico_hud_str.bmp>\n\n\n\n\n<f2>"@string::translate(GetPlayerSkill(%clientId,$SKILLSTRENGTH),true)@"\n\<b:ico_hud_dex.bmp><b:ico_hud_int.bmp>\n\n\n\n\n<f0>"@string::translate(GetPlayerSkill(%clientId,$SKILLDEXTERITY),true)@"         <f1>"@string::translate(GetPlayerSkill(%clientId,$SKILLINTELLIGENCE),true)@"\n\n";
		%msg = %msg @ "<jl><f1>Attack Rating: <f0>" @ GetTempATK(%clientId) @ "\n";
		%msg = %msg @ "<f1>Health: <f0>" @ fetchData(%clientId, "HP") @ " / " @ fetchData(%clientId, "MaxHP") @ "\n";
		%msg = %msg @ "<f1>Mana: <f0>" @ fetchData(%clientId, "MANA") @ " / " @ fetchData(%clientId, "MaxMANA") @ "\n";
		//------------------------------------------------------------------------------------------------------------------
		if (%lvl < 230) {
			%msg = %msg @ "<f1>Experience: <f0>" @ fetchData(%clientId,"EXP") @ "\n";
			%msg = %msg @ "<f1>EXP Needed: <f0>" @ GetExpTnl(%clientId) @ "\n";
		}
		else {
			%msg = %msg @ "<f1>Arcane Experience: <f0>" @ fetchData(%clientId,"AEXP") @ "\n";
			%msg = %msg @ "<f1>Arcane EXP Needed: <f0>" @ GetAExpTnl(%clientId) @ "\n";
		}
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>Coins: <f0>" @ fetchData(%clientId, "COINS") @ "\n";
		%msg = %msg @ "<f1>Bank: <f0>" @ fetchData(%clientId, "BANK") @ "\n";
		%msg = %msg @ "<f1>Armor Weight: <f0>" @ GetWeight(%clientId) @ " / " @ fetchData(%clientId, "MaxWeight") @ " (" @ FormatDecimal(WeightPenalty(%clientId),2) @ "%) \n";
		%msg = %msg @ "<f1>Memory: <f0>" @ fetchData(%clientId,"CurSC") @ " / " @ fetchData(%clientId,"MaxSC") @ "\n";
		%msg = %msg @ "<f1>Magic Find: <f0>" @ GetBonus(%clientId,$BPMAGICFIND) @ "% (" @ GetMagicFind(%clientId) @ "%)\n";
		%msg = %msg @ "<f1>Gold Find: <f0>" @ GetBonus(%clientId,$BPGOLDFIND) @ "% (" @ GetGoldFind(%clientId) @ "%)\n";
		%msg = %msg @ "<f1>Add EXP: <f0>" @ GetBonus(%clientId,$BPADDEXP) @ "%\n";
		sendbufferbp(%clientId, %msg, floor(String::len(%msg) / 10));
		return;
	}
	if (%stats == 2) {
		%msg = %msg @ "<f1><jc>" @ Client::getName(%clientId) @ ", LEVEL " @ fetchData(%clientId, "LVL") @ " " @ fetchData(%clientId, "CruRACE") @ " " @ fetchData(%clientId, "CLASS") @ "<f0>\n";
		%msg = %msg @ "<jl><f1>Maximum Health: <f0>" @ fetchData(%clientId, "MaxHP") @ "\n";
		%msg = %msg @ "<f1> Heal Delta: <f0>" @ fetchStat(%clientId,"HEALDELTA") @ "";
		%msg = %msg @ "<f1> Bandage: <f0>" @ GetBonus(%clientId,$BPBANDAGE) @ "";
		%msg = %msg @ "<f1> Increase Healing: <f0>" @ GetBonus(%clientId,$BPHEALINGINC) @ "%\n\n";
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>Add All Defense: <f0>" @ fetchStat(%clientId,"AAD") @ "\n";
		%msg = %msg @ "<f1> Evade Melee: <f0>" @ GetPlayerSkill(%clientId,$SkillEvadeMelee) @ " (" @ fetchStat(%clientid,"EVADEMELEE") @ ") \n";
		%msg = %msg @ "<f1> Dodge Ranged: <f0>" @ GetPlayerSkill(%clientId,$SkillDodging) @ " (" @ fetchStat(%clientid,"DODGERANGED") @ ") \n";
		%msg = %msg @ "<f1> Spell Resistance: <f0>" @ GetPlayerSkill(%clientId,$SkillSpellResistance) @ " (" @ fetchStat(%clientid,"SPELLRESISTANCE") @ ")\n\n";
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>Armor: <f0>" @ fetchStat(%clientId,"ARMOR") @ " (" @ fetchStat(%clientId,"ARMORFULL") @ ") ";
		%msg = %msg @ "<f1>Increase Armor: <f0>" @ fetchStat(%clientId,"INCARMOR") @ "%\n";
		%msg = %msg @ "<f1>Estimated Physical Damage Reduction: <f0>" @ fetchReduction(%clientId,"ARMOR") @ "%\n";
		%msg = %msg @ "<f1>	Melee Armor: <f0>" @ fetchStat(%clientId,"MELEEAC") @ " (" @ fetchStat(%clientId,"MELEEACFULL") @ ") (" @ fetchReduction(%clientId,"MELEEAC") @ "%)\n";
		%msg = %msg @ "<f1> 	Projectile Armor: <f0>" @ fetchStat(%clientId,"PROJAC") @ " (" @ fetchStat(%clientId,"PROJACFULL") @ ") (" @ fetchReduction(%clientId,"PROJAC") @ "%)\n";
		%msg = %msg @ "<f1> 	Fire Armor: <f0>" @ fetchStat(%clientId,"FIREAC") @ " (" @ fetchStat(%clientId,"FIREACFULL") @ ") (" @ fetchReduction(%clientId,"FIREAC") @ "%)\n";
		%msg = %msg @ "<f1> 	Cold Armor: <f0>" @ fetchStat(%clientId,"COLDAC") @ " (" @ fetchStat(%clientId,"COLDACFULL") @ ") (" @ fetchReduction(%clientId,"COLDAC") @ "%)\n";
		%msg = %msg @ "<f1> 	Poison Armor: <f0>" @ fetchStat(%clientId,"POISONAC") @ " (" @ fetchStat(%clientId,"POISONACFULL") @ ") (" @ fetchReduction(%clientId,"POISONAC") @ "%)\n";
		%msg = %msg @ "<f1> 	Energy Armor: <f0>" @ fetchStat(%clientId,"ENERGYAC") @ " (" @ fetchStat(%clientId,"ENERGYACFULL") @ ") (" @ fetchReduction(%clientId,"ENERGYAC") @ "%)\n\n";
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>All Resist: <f0>" @ fetchStat(%clientId,"ALLRESIST") @ " (" @ fetchStat(%clientId,"ALLRESISTFULL") @ ") ";
		%msg = %msg @ "<f1>Increase Resist: <f0>" @ fetchStat(%clientId,"INCRESIST") @ "%\n";
		%msg = %msg @ "<f1>Estimated Magical Damage Reduction: <f0>" @ fetchReduction(%clientId,"ALLRESIST") @ "%\n";
		%msg = %msg @ "<f1> 	Melee Resist: <f0>" @ fetchStat(%clientId,"MELEERES") @ " (" @ fetchStat(%clientId,"MELEERESFULL") @ ") (" @ fetchReduction(%clientId,"MELEERES") @ "%)\n";
		%msg = %msg @ "<f1> 	Projectile Resist: <f0>" @ fetchStat(%clientId,"PROJRES") @ " (" @ fetchStat(%clientId,"PROJRESFULL") @ ") (" @ fetchReduction(%clientId,"PROJRES") @ "%)\n";
		%msg = %msg @ "<f1> 	Fire Resist: <f0>" @ fetchStat(%clientId,"FIRERES") @ " (" @ fetchStat(%clientId,"FIRERESFULL") @ ") (" @ fetchReduction(%clientId,"FIRERES") @ "%)\n";
		%msg = %msg @ "<f1> 	Cold Resist: <f0>" @ fetchStat(%clientId,"COLDRES") @ " (" @ fetchStat(%clientId,"COLDRESFULL") @ ") (" @ fetchReduction(%clientId,"COLDRES") @ "%)\n";
		%msg = %msg @ "<f1> 	Poison Resist: <f0>" @ fetchStat(%clientId,"POISONRES") @ " (" @ fetchStat(%clientId,"POISONRESFULL") @ ") (" @ fetchReduction(%clientId,"POISONRES") @ "%)\n";
		%msg = %msg @ "<f1> 	Energy Resist: <f0>" @ fetchStat(%clientId,"ENERGYRES") @ " (" @ fetchStat(%clientId,"ENERGYRESFULL") @ ") (" @ fetchReduction(%clientId,"ENERGYRES") @ "%)\n\n";
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>Evasion: <f0>" @ fetchStat(%clientId,"EVASION") @ " (" @ fetchStat(%clientId,"EVASIONFULL") @ ") ";
		%msg = %msg @ "<f1>Increase Evasion: <f0>" @ fetchStat(%clientId,"INCEVASION") @ "%\n";
		%msg = %msg @ "<f1>Estimated Chance to Evade: <f0>" @ fetchEvasion(%clientId) @ "%\n\n";
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>Block Chance: <f0>" @ GetBonus(%clientId,$BPBLOCKHIT) @ "% ";
		%msg = %msg @ "<f1>Block Amount: <f0>" @ GetBonus(%clientId,$BPBLOCKAMMOUNT) @ " ";
		%msg = %msg @ "<f1>Block Recovery: <f0>" @ GetBonus(%clientId,$BPBLOCKRECOVERY) @ "%\n";
		%msg = %msg @ "<f1>Spell Block Chance: <f0>" @ GetBonus(%clientId,$BPBLOCKSPELL) @ "% ";
		%msg = %msg @ "<f1>Spell Block Amount: <f0>" @ GetBonus(%clientId,$BPSPLBLOCKAMM) @ " ";
		%msg = %msg @ "<f1>Spell Block Recovery: <f0>" @ GetBonus(%clientId,$BPSPLBLOCKREC) @ "%\n\n";
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>Avoidances:\n";
		%msg = %msg @ "<f1> Stun: <f0>" @ GetBonus(%clientId,$BPAVOIDSTUN) @ "%";
		%msg = %msg @ "<f1> Root: <f0>" @ GetBonus(%clientId,$BPAVOIDROOT) @ "%";
		%msg = %msg @ "<f1> Chill: <f0>" @ GetBonus(%clientId,$BPAVOIDCHILL) @ "%";
		%msg = %msg @ "<f1> Burn: <f0>" @ GetBonus(%clientId,$BPAVOIDBURN) @ "%";
		%msg = %msg @ "<f1> Shock: <f0>" @ GetBonus(%clientId,$BPAVOIDSHOCK) @ "%";
		%msg = %msg @ "<f1> Poison: <f0>" @ GetBonus(%clientId,$BPAVOIDPOISON) @ "%";
		%msg = %msg @ "<f1> Crit: <f0>" @ GetBonus(%clientId,$BPAVOIDCRIT) @ "%";
		%msg = %msg @ "<f1> Spell Crit: <f0>" @ GetBonus(%clientId,$BPAVOIDSPCRIT) @ "%\n";
		%msg = %msg @ "<f1> Stun Recovery: <f0>" @ GetBonus(%clientId,$BPSTUNRECOVER) @ "%\n\n";
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>Monster Protections:\n";
		%msg = %msg @ "<f1> Beast: <f0>" @ GetBonus(%clientId,$BPBEASTPROT) @ "%";
		%msg = %msg @ "<f1> Undead: <f0>" @ GetBonus(%clientId,$BPUNDEADPROT) @ "%";
		%msg = %msg @ "<f1> Demon: <f0>" @ GetBonus(%clientId,$BPDEMONPROT) @ "%";
		//------------------------------------------------------------------------------------------------------------------
		sendbufferbp(%clientId, %msg, 30);
		return;
	}
	if (%stats == 3) {
		ViewOffensiveStats(%clientId);
		return;
	}
	if (%stats == 4) {
		ViewOffensiveStatsMag(%clientId);
		return;
	}
}


function fetchStat::DPS(%id,%item)
{
	if (%item == "")
		%item = GetCurrentWearFull(%id,13);
	%damageType = newGetWeaponDamageType(%item);
	%damage = $BPItem[%item,$BPDamage];
	%min = getWord(%damage,0);
	%max = getWord(%damage,2);
	%physbase = GetBonus(%id,$BPPHYSBASE);
	%delay = $BPItem[%item,$BPWeaponDelay];
	%physbase = (%physbase * (%delay / 2));
	%min += %physbase;
	%max += %physbase;
	%value = round(((%min + %max) / 2) / %delay);
	%chance = $BPItem[%item,$BPWeaponCritChance];
	%critdamage = $BPItem[%item,$BPWeaponCritDamage];
	%playerChance = GetBonus(%id,$BPCRITCHANCE);
	%playerCritDmg = GetBonus(%id,$BPCRITDAMAGE);
	%crit = (%chance * (1 + (%playerChance / 100)));
	%critdmg = (%critdamage * (1 + (%playerCritDmg / 100)));
	if (%crit > 95) %crit = 95;
	%critval = (%value + (%value * %critdmg / 100)) * (%crit / 100);
	%value += %critval;
	%atk = $BPItem[%item,$BPATKSkills];
	%atk = getWord(%atk,0);
	%typeinc = 0;
	if (%atk == "Slashing") 	%typeinc = GetBonus(%id,$BPSLASHINGDAMAGE);
	else if (%atk == "Piercing") 	%typeinc = GetBonus(%id,$BPPIERCINGDAMAGE);
	else if (%atk == "Bludgeoning")	%typeinc = GetBonus(%id,$BPBLUDGEGDAMAGE);
	else if (%atk == "Archery") 	%typeinc = GetBonus(%id,$BPARCHERYDAMAGE);
	%value *= (1 + (%typeinc / 100));
	%physdamage = GetBonus(%id,$BPPHYSICALDAMAGE);
	%value *= (1 + (%physdamage / 100));
	if (%damagetype == "Cold") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPCOLDDAMAGE) / 100))); }
	if (%damagetype == "Fire") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPFIREDAMAGE) / 100))); }
	if (%damagetype == "Energy") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPENERGYDAMAGE) / 100))); }
	if (%damagetype == "Projectile") 	{ %value = round(%value * (1 + (GetBonus(%id,$BPPROJDAMAGE) / 100))); }
	if (%damagetype == "Melee") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPMELEETYPEDAMAGE) / 100))); }
	if (%damagetype == "Poison") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPPOISONDAMAGE) / 100))); }
	return %value;			
}

function fetchStat::PhysValue(%id,%item,%value)
{
	if (%item == "")
		%item = GetCurrentWearFull(%id,13);
	%damageType = newGetWeaponDamageType(%item);
	%physbase = GetBonus(%id,$BPPHYSBASE);
	%delay = $BPItem[%item,$BPWeaponDelay];
	%physbase = (%physbase * (%delay / 2));
	%value += %physbase;
	%chance = $BPItem[%item,$BPWeaponCritChance];
	%critdamage = $BPItem[%item,$BPWeaponCritDamage];
	%playerChance = GetBonus(%id,$BPCRITCHANCE);
	%playerCritDmg = GetBonus(%id,$BPCRITDAMAGE);
	%crit = (%chance * (1 + (%playerChance / 100)));
	%critdmg = (%critdamage * (1 + (%playerCritDmg / 100)));
	if (%crit > 95) %crit = 95;
	%critval = (%value + (%value * %critdmg / 100)) * (%crit / 100);
	%value += %critval;
	%atk = $BPItem[%item,$BPATKSkills];
	%atk = getWord(%atk,0);
	%typeinc = 0;
	if (%atk == "Slashing") 	%typeinc = GetBonus(%id,$BPSLASHINGDAMAGE);
	else if (%atk == "Piercing") 	%typeinc = GetBonus(%id,$BPPIERCINGDAMAGE);
	else if (%atk == "Bludgeoning")	%typeinc = GetBonus(%id,$BPBLUDGEGDAMAGE);
	else if (%atk == "Archery") 	%typeinc = GetBonus(%id,$BPARCHERYDAMAGE);
	%value *= (1 + (%typeinc / 100));
	%physdamage = GetBonus(%id,$BPPHYSICALDAMAGE);
	%value *= (1 + (%physdamage / 100));
	if (%damagetype == "Cold") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPCOLDDAMAGE) / 100))); }
	if (%damagetype == "Fire") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPFIREDAMAGE) / 100))); }
	if (%damagetype == "Energy") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPENERGYDAMAGE) / 100))); }
	if (%damagetype == "Projectile") 	{ %value = round(%value * (1 + (GetBonus(%id,$BPPROJDAMAGE) / 100))); }
	if (%damagetype == "Melee") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPMELEETYPEDAMAGE) / 100))); }
	if (%damagetype == "Poison") 		{ %value = round(%value * (1 + (GetBonus(%id,$BPPOISONDAMAGE) / 100))); }
	return %value;
}

function ViewOffensiveStatsMag(%id)
{
	%msg = %msg @ "<f1><jc>" @ Client::getName(%id) @ ", LEVEL " @ fetchData(%id, "LVL") @ " " @ fetchData(%id, "CruRACE") @ " " @ fetchData(%id, "CLASS") @ "<f0>\n";
	%msg = %msg @ "<jl><f1>Attack Rating <f0>" @ GetTempATK(%id) @ "\n";	
	%msg = %msg @ "<f1>Add All Offense <f0>" @ GetBonus(%id,$BPADDALLOFF) @ "\n";
	%msg = %msg @ "<f1>True Damage: <f0>" @ GetBonus(%id,$BPADDDAMAGE) @ "\n\n";
	%msg = %msg @ "<f1>Magic Stats \n";
	%msg = %msg @ "<f1> Spell Base Damage: <f0>" @ GetBonus(%id,$BPSPELLBASE) @ "\n";
	%msg = %msg @ "<f1> Magic Penetration: <f0>" @ GetBonus(%id,$BPMAGICPEN) @ "\n";
	%msg = %msg @ "<f1> Magic Damage Increase: <f0>" @ GetBonus(%id,$BPMAGICDAMAGE) @ "%\n";
	%msg = %msg @ "<f1> Spell Accuracy: <f0>" @ GetBonus(%id,$BPSPELLACCURACY) @ " \n";
	%msg = %msg @ "<f1> Reduce Mana Cost: <f0>" @ GetBonus(%id,$BPMANACOST) @ "% \n";
	%msg = %msg @ "<f1> Cooldown Reduction: <f0>" @ GetBonus(%id,$BPCOOLDOWN) @ "% \n";
	%msg = %msg @ "<f1> Spell Vamp: <f0>" @ GetBonus(%id,$BPSPELLVAMP) @ "% \n";
	%msg = %msg @ "<f1> Spell Crit Chance: <f0>" @ GetBonus(%id,$BPSPELLCRIT) @ "% \n";
	%msg = %msg @ "<f1> Spell Crit Damage: <f0>" @ GetBonus(%id,$BPSPCRITDAMAGE) @ "% \n";
	%msg = %msg @ "<f1> Type Increase: \n";
	%msg = %msg @ "<f1>	Wand: <f0>" @ GetBonus(%id,$BPWANDMAGIC) @ "% \n";
	%msg = %msg @ "<f1>	Staff: <f0>" @ GetBonus(%id,$BPSTAFFMAGIC) @ "% \n";
	%msg = %msg @ "\n";
	//------------------------------------------------------------------------------------------------------------------
	sendbufferbp(%id, %msg, 30);
}

function ViewOffensiveStats(%id) 
{
	%msg = %msg @ "<f1><jc>" @ Client::getName(%id) @ ", LEVEL " @ fetchData(%id, "LVL") @ " " @ fetchData(%id, "CruRACE") @ " " @ fetchData(%id, "CLASS") @ "<f0>\n";
	%msg = %msg @ "<jl><f1>Attack Rating <f0>" @ GetTempATK(%id) @ "\n";	
	%msg = %msg @ "<f1>Add All Offense <f0>" @ GetBonus(%id,$BPADDALLOFF) @ "\n";
	%msg = %msg @ "<f1>True Damage: <f0>" @ GetBonus(%id,$BPADDDAMAGE) @ "\n\n";
	//------------------------------------------------------------------------------------------------------------------
	%msg = %msg @ "<f1>Melee Base Damage: <f0>" @ GetBonus(%id,$BPPHYSBASE) @ "\n";
	%msg = %msg @ "<f1>Ranged Base Damage: <f0>" @ GetBonus(%id,$BPRANGEDBASE) @ "\n";
	%msg = %msg @ "<f1>Armor Penetration: <f0>" @ GetBonus(%id,$BPARMORPEN) @ "\n";
	%msg = %msg @ "<f1>Physical Damage Increase: <f0>" @ GetBonus(%id,$BPPHYSICALDAMAGE) @ "%\n";
	%msg = %msg @ "<f1>Accuracy: <f0>" @ GetBonus(%id,$BPACCURACY) @ " \n";
	%msg = %msg @ "<f1>Life Steal: <f0>" @ GetBonus(%id,$BPLIFESTEAL) @ "% \n";
	%msg = %msg @ "<f1>Crit Chance: <f0>" @ GetBonus(%id,$BPCRITCHANCE) @ "% \n";
	%msg = %msg @ "<f1>Crit Damage: <f0>" @ GetBonus(%id,$BPCRITDAMAGE) @ "% \n";
	%msg = %msg @ "<f1>Skill Type Increase: \n";
	%msg = %msg @ "<f1>	Slashing: <f0>" @ GetBonus(%id,$BPSLASHINGDAMAGE) @ "% \n";
	%msg = %msg @ "<f1> 	Piercing: <f0>" @ GetBonus(%id,$BPPIERCINGDAMAGE) @ "% \n";
	%msg = %msg @ "<f1> 	Bludgeoning: <f0>" @ GetBonus(%id,$BPBLUDGEDAMAGE) @ "% \n";
	%msg = %msg @ "<f1> 	Archery: <f0>" @ GetBonus(%id,$BPARCHERYDAMAGE) @ "% \n\n";
	//------------------------------------------------------------------------------------------------------------------
	%item = GetCurrentWearFull(%id,13);
	%weaponName = $BPItem[%item,$BPName];
	%mag = $BPItem[%item,$BPWeaponMagDamage];
	if (%mag == "") {
		%delay = $BPItem[%item,$BPWeaponDelay];
		%damage = $BPItem[%item,$BPDamage];
		%dmgmin = getWord(%damage,0);
		%dmgmax = getWord(%damage,2);
		//------------------------------------------------------------------------------------------------------------------
		//%msg = %msg @ "<f1>Base Weapon Stats:\n";
		//%msg = %msg @ "<f1> Weapon: <f0>" @ %weaponName @ "\n";
		//%qual = String::GetSubStr(%item,0,3);
		//%qual = %qual * 1;
		//%msg = %msg @ "<f1> QL: <f0>" @ %qual @ "\n";
		//%msg = %msg @ "<f1> DamageType: <f0>" @ $BPItem[%item,$BPDamageType] @ "\n";
		//%msg = %msg @ " <f1>Delay: <f0>" @ %delay @ " seconds\n";
		//%msg = %msg @ " <f1>Damage: <f0>" @ $BPItem[%item,$BPDamage] @ "\n";
		//%dps = round(((%dmgmin + %dmgmax) / 2) / %delay);
		//%msg = %msg @ " <f1>Weapon DPS: <f0>" @ %dps @ "\n";
		//%msg = %msg @ " <f1>Crit Chance: <f0>" @ $BPItem[%item,$BPWeaponCritChance] @ "%\n";
		//%msg = %msg @ " <f1>Crit Damage: <f0>" @  $BPItem[%item,$BPWeaponCritDamage] @ "%\n\n";
		//------------------------------------------------------------------------------------------------------------------
		%msg = %msg @ "<f1>Weapon Stats \n";
		%msg = %msg @ "<f1>	DPS: <f0>" @ fetchStat::DPS(%id,%item) @ "\n";
		%msg = %msg @ "<f1> 	Min Damage: <f0>" @ fetchStat::PhysValue(%id,%item,%dmgmin) @ "\n";
		%msg = %msg @ "<f1> 	Max Damage: <f0>" @ fetchStat::PhysValue(%id,%item,%dmgmax) @ "\n";
		%chance = $BPItem[%item,$BPWeaponCritChance];
		%critdamage = $BPItem[%item,$BPWeaponCritDamage];
		%playerChance = GetBonus(%id,$BPCRITCHANCE);
		%playerCritDmg = GetBonus(%id,$BPCRITDAMAGE);
		%crit = (%chance * (1 + (%playerChance / 100)));
		%critdmg = (%critdamage * (1 + (%playerCritDmg / 100)));
		if (%crit > 95) %crit = 95;
		%msg = %msg @ "<f1>	Critical Chance: <f0>" @ %playerChance @ "% (" @ FormatDecimal(%crit,2) @ "%)\n";
		%msg = %msg @ "<f1>	Critical Damage: <f0>" @ %playerCritDmg @ "% (" @ FormatDecimal(%critdmg,2) @ "%)\n\n";
	}
	//------------------------------------------------------------------------------------------------------------------
	%msg = %msg @ "<f1>General Stats:\n";
	%msg = %msg @ "<f1>	Damage Type Increase:\n";
	%msg = %msg @ "<f1>		Melee: <f0>" @ GetBonus(%id,$BPMELEETYPEDAMAGE) @ "%";
	%msg = %msg @ "<f1> Projectile: <f0>" @ GetBonus(%id,$BPPROJDAMAGE) @ "%";
	%msg = %msg @ "<f1> Fire: <f0>" @ GetBonus(%id,$BPFIREDAMAGE) @ "%";
	%msg = %msg @ "<f1> Cold: <f0>" @ GetBonus(%id,$BPCOLDDAMAGE) @ "%";
	%msg = %msg @ "<f1> Energy: <f0>" @ GetBonus(%id,$BPENERGYDAMAGE) @ "%";
	%msg = %msg @ "<f1> Poison: <f0>" @ GetBonus(%id,$BPPOISONDAMAGE) @ "% \n";
	%msg = %msg @ "<f1>	Monster Damage Increase:\n";
	%msg = %msg @ "<f1> 		Beast: <f0>" @ GetBonus(%id,$BPDAMAGEBEAST) @ "%";
	%msg = %msg @ "<f1> Undead: <f0>" @ GetBonus(%id,$BPDAMAGEUNDEAD) @ "%";
	%msg = %msg @ "<f1> Demon: <f0>" @ GetBonus(%id,$BPDAMAGEDEMON) @ "%";
	%msg = %msg @ "<f1> Elite: <f0>" @ GetBonus(%id,$BPDAMAGEELITE) @ "%";
	%msg = %msg @ "<f1> Boss: <f0>" @ GetBonus(%id,$BPDAMAGEBOSS) @ "% \n";
	sendbufferbp(%id, %msg, 30);
}

function PhysicalRating(%id)
{
	%lvl = fetchData(%id,"LVL");
	%dps = fetchStat::DPS(%id);
	%dps = (%dps / (1000 * (%lvl / 230)) * 100);
	return round(%dps);
}

function CompareDPS(%id,%item)
{
	$PlayerWear[0,13] = GetCurrentWearFull(%id,13);
	%dps = fetchStat::DPS(%id);
	for (%i = 0; %i <= 300; %i++)
		$PlayerBonus[0,%i] = $PlayerBonus[%id,%i];
	for (%i = 0; %i <= 50; %i++)
		$PlayerSkill[0,%i] = $PlayerSkill[%id,%i];
	for (%i = 0; %i <= 50; %i++)
		$SkillBonus[0,%i] = $SkillBonus[%id,%i];
	%ritem = GetCurrentWearFull(0,13);
	BackpackWieldBonus(0,%ritem,0,0);
	%newdps = fetchStat::DPS(0,%item);
	if (%dps < %newdps) {
		%i = %newdps - %dps; 
		return "<buparrow.bmp>" @ %i;
	}
	else {
		%i = %dps - %newdps;
		return "<bdownarrow.bmp>" @ %i;
	}
}


