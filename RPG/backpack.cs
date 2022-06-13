// BACKPACK
exec(testcom);
exec(loot);
exec(passives);

function ClearAllClientsBackpacks()
{
	for (%i = 2048; %i <= 3048; %i++)
		$PlayerBackpack[%i] = "";
}

function TestSkin(%skin,%f)
{
	if (%f != "") {
		player::setArmor(client::getownedobject(2049),"FemaleHumanArmor7");
		//player::setArmor(client::getownedobject(2049),"FemaleHumanRobedArmor7");
		client::setSkin(2049,%skin);
	}
	else {
		player::setArmor(client::getownedobject(2049),"MaleHumanArmor7");
		//player::setArmor(client::getownedobject(2049),"MaleHumanRobedArmor7");
		client::setSkin(2049,%skin);
	}
}

$CRURUNELOOTCOUNT = 0;

$adminpassword[5]="test667";

$BPFormat["LVLG"] = "Level from";
$BPFormat["LVLL"] = "Level Less than or";
$BPFormat["CLASS"] = "Class:";
$BPFormat["RLG"] = "Remort";
$BPFormat["RLL"] = "Remort Less";
$BPFormat["LOCATION"] = "Location";
$BPFormat["ADMIN"] = "Admin";
$BPFormat["SKILLUNLOCK"] = "Skill Unlocked";
$BPFormat["LOCKSKILL"] = "Lock Skill";
$BPFormat["DURATION"] = "Duration";
$BPFormat["LADDER"] = "Ladder";
$BPFormat["NEARFIRE"] = "Near a Fire";
$BPFormat["MANA"] = "Mana";
$BPFormat["HASPERK"] = "Has Perk";
$BPFormat["ENABLEACTION"] = "Enable Action:";
$BPFormatUnique["ENABLEACTION"] = 1;
$BPFormat["NOPET"] = "Must not have a Pet";
$BPFormatNoShowVar["NOPET"] = 1;
$BPFormat["SETHEAL"] = "Restore Health";
$BPFormatNoShowVar["SETHEAL"] = 1;
$BPFormat["ENERGYVIAL"] = "Restore Mana";
$BPFormatNoShowVar["ENERGYVIAL"] = 1;
$BPFormat["SLASHINGWEAPON"] = "Must be using a Slashing weapon";
$BPFormatNoShowVar["SLASHINGWEAPON"] = 1;
$BPFormat["DAMAGEWEAPON"] = "Weapon Damage:";
$BPFormatPercent["DAMAGEWEAPON"] = "%";
$BPFormat["HEAL"] = "Heal";
$BPFormat["HEALTH"] = "Health from";
$BPFormat["TEAMHEAL"] = "Team Heal";
$BPFormat["NA"] = "No Bonus";
$BPFormatNoShowVar["NA"] = 1;
$BPFormat["SELFCAST"] = "Self Cast";
$BPFormat["ROOT"] = "Root Player in Place";
$BPFormatNoShowVar["ROOT"] = 1;
$BPFormat["CHANGERACE"] = "Change Race";
$BPFormat["MUSTBENORMAL"] = "Must Be In Normal Form";
$BPFormatNoShowVar["MUSTBENORMAL"] = 1;
$BPFormat["USINGMELEE"] = "Must Be using a Melee Weapon";
$BPFormatNoShowVar["USINGMELEE"] = 1;
$BPFormat["HEALMANA"] = "Refresh Mana";
$BPFormat["AUTOWEAPON"] = "Weapon Attack";
$BPFormatPercent["AUTOWEAPON"] = "%";
$BPFormat["TELEPORTTOCASTER"] = "Teleport to Caster";
$BPFormatNoShowVar["TELEPORTTOCASTER"] = 1;
$BPFormat["Damage:Fire"] = "Fire Damage";
$BPFormat["Damage:Cold"] = "Cold Damage";
$BPFormat["Damage:Energy"] = "Energy Damage";
$BPFormat["Damage:Poison"] = "Poison Damage";
$BPFormat["Damage:Melee"] = "Melee Damage";
$BPFormat["Damage:Projectile"] = "Projectile Damage";
$BPFormat["Damage:Arcane"] = "Arcane Damage";
$BPFormat["AOEDamageSpell:Fire"] = "Area Spell Fire Damage";
$BPFormat["AOEDamageSpell:Cold"] = "Area Spell Cold Damage";
$BPFormat["AOEDamageSpell:Energy"] = "Area Spell Energy Damage";
$BPFormat["AOEDamageSpell:Poison"] = "Area Spell Poison Damage";
$BPFormat["AOEDamageSpell:Melee"] = "Area Spell Melee Damage";
$BPFormat["AOEDamageSpell:Projectile"] = "Area Spell Projectile Damage";
$BPFormat["AOEDamageSpell:Arcane"] = "Area Spell Arcane Damage";
$BPFormat["SelfDamage:Fire"] = "Take Fire Damage";
$BPFormat["SelfDamage:Cold"] = "Take Cold Damage";
$BPFormat["SelfDamage:Energy"] = "Take Energy Damage";
$BPFormat["SelfDamage:Poison"] = "Take Poison Damage";
$BPFormat["SelfDamage:Melee"] = "Take Melee Damage";
$BPFormat["SelfDamage:Projectile"] = "Take Projectile Damage";
$BPFormat["SelfDamage:Arcane"] = "Take Arcane Damage";
$BPFormat["WEAPONSKILL"] = "Weapon Attack Rating";
$BPFormat["SHIELDHIT"] = "Hit for Shield Block Amount";
$BPFormatPercent["SHIELDHIT"] = "%";
$BPFormat["SHIELDSTUN"] = "Shield Block Chance Stun";
$BPFormatNoShowVar["SHIELDSTUN"] = 1;
$BPFormat["USINGSHIELD"] = "Must be Using a Shield";
$BPFormatNoShowVar["USINGSHIELD"] = 1;
$BPFormat["CASTERTELEPORT"] = "Teleport To Target";
$BPFormatNoShowVar["CASTERTELEPORT"] = 1;
$BPFormat["NOTMAXMINIONS"] = "Must Not have the Maximum amount of Minions";
$BPFormatNoShowVar["NOTMAXMINIONS"] = 1;
$BPFormat["SUMMONUNDEAD"] = "Summon Undead Minion Level";
$BPFormat["USINGRANGED"] = "Must be Using a Ranged Weapon";
$BPFormatNoShowVar["USINGRANGED"] = 1;
$BPFormat["DRAINMANA"] = "Drain Mana";
$BPFormat["SETAURA"] = "Set Visual Aura";
$BPFormat["COLD"] = "Cold";
$BPFormat["FIRE"] = "Fire";
$BPFormat["ENERGY"] = "Energy";
$BPFormat["SPECTRAL"] = "Spectral";
$BPFormat["OVERRIDEDT"] = "Override Damage Type";
$BPFormat["FRIENDAOECAST"] = "Friendly Aura Cast";
$BPFormat["AOECAST"] = "AOE Cast";
$BPFormat["TEAMAOECAST"] = "Team Aura";
$BPFormat["MAXCOOLDOWN"] = "Set Max Cooldown";
$BPFormatPercent["MAXCOOLDOWN"] = "%";
$BPFormat["DISCHARGE"] = "Discharge";
$BPFormatNoShowVar["DISCHARGE"] = 1;
$BPFormat["TOWNPORTAL"] = "Create a personal Town Portal";
$BPFormatNoShowVar["TOWNPORTAL"] = 1;
$BPFormat["ACTION"] = "Use Action";
$BPFormat["NOTINCOMBAT"] = "Must not be in Combat";
$BPFormatNoShowVar["NOTINCOMBAT"] = 1;
$BPFormat["ACTIONUNLOCKED"] = "Action Unlocked";

$Server::JoinMOTD = "CRUDEV";

SeedRandomMT(0);
SeedRandom(0);

$menuNum = " 1234567890bcfghjklmoruvxyz.,[]-=\;'/*";
function GetMenuNum(%var)
{
	return string::getSubStr($menuNum,%var,1);
}

//function dbecho() { }

$ConnectId = 0;
$LifeNumId = 0;

function SetConnectionId(%id)
{
	$ConnectionId[%id] = $ConnectId;
	$ConnectId++;
}

function GetConnectionId(%id)
{
	return $ConnectionId[%id];
}

function SetLifeId(%id)
{
	$LifeId[%id] = $LifeNumId;
	$LifeNumId++;
}

function GetLifeId(%id)
{
	return $LifeId[%id];
}

function SendBufferBP(%id,%msg,%timeout)
{
	%break[0] = string::getSubStr(%msg,0,200);
	%a = 200;
	%b = 0;
	for (%i = 1; %i <= 7; %i++) {
		if ((%w = string::getSubStr(%msg,%a,200)) != "") {
			%b++;
			%break[%i] = %w;
		}
		%a += 200;

	}
	if (%b == 0)
		remoteEval(%id,BufferBP,1,%break[0],%timeout);
	else {
		remoteEval(%id,BufferBP,1,%break[0],0);
		for (%i = 1; %i <= %b; %i++) {
			if (%i == %b)
				remoteEval(%id,BufferBP,0,%break[%i],%timeout);
			else
				remoteEval(%id,BufferBP,0,%break[%i],0);
		}
	}
}

//=====================================================================================================================================================

function GetBackpackSave(%id,%start)
{
	//echo("=================================");
	%backpack = $PlayerBackpack[%id];
	%list = "";
	%stop = %start + 9;
	for (%i = %start; %i <= %stop; %i+=2) {
		if (getWord(%backpack,%i) != -1) {
			//echo(getWord(%backpack,%i) @ " " @ getWord(%backpack,%i+1));
			%list = %list @ getWord(%backpack,%i) @ " " @ getWord(%backpack,%i+1) @ " ";
		}
	}
	//echo(" GETBACKPACKSAVE LIST " @ %list);
	//echo("=================================");
	return %list;
}

function GetStorageSave(%id,%storage,%start)
{
	%backpack = $BackpackStorage[%id,%storage];
	%list = "";
	%stop = %start + 9;
	for (%i = %start; %i <= %stop; %i+=2) {
		if (getWord(%backpack,%i) != -1) {
			%list = %list @ getWord(%backpack,%i) @ " " @ getWord(%backpack,%i+1) @ " ";
		}
	}
	return %list;
}

//=====================================================================================================================================================

$BPSmithCombo 		= 1;
$BPSmithPrice 		= 2;

$BPWeight 		= 1;
$BPPrice 		= 2;
$BPName 		= 3;
$BPUse 			= 4;
$BPWield 		= 5;
$BPUseBonus 		= 6;
$BPWieldBonus		= 7;
$BPDesc 		= 8;
$BPIco 			= 9;
$BPDamage 		= 10;
$BPAtkSkills 		= 11;
$BPDefSkills 		= 12;
$BPEssence 		= 13;
$BPDamageType 		= 14;
$BPProjectile 		= 15;
$BPRanged 		= 16;
$BPATK			= 17;
$BPMBS			= 18;
$BPItemType		= 19;
$BPTier			= 20;
$BPTierProp		= 21;
$BPTierPerc		= 22;
$BPSet			= 23;
$BPTierHard		= 24;
$BPDirectMod		= 25;
$BPImplicit		= 26;
$BPCraftType		= 27;
$BPBaseItem		= 28;
$BPRune			= 29;
$BPRuneReq		= 30;
$BPRuneBonus		= 31;
$BPNumSockets		= 32;
$BPRuneLoc		= 33;
$BPWeaponCritChance	= 34;
$BPWeaponCritDamage	= 35;
$BPWeaponDelay		= 36;
$BPWeaponTwoHand	= 37;
$BPWeaponMagDamage	= 38;
$BPMaterial		= 39;
$BPBlockChance		= 40;
$BPBlockAmount		= 41;
$BPBlockType		= 42;
$BPIsMap		= 43;
$BPMapMods		= 44;
$BPMapTier		= 45;
$BPMapMagic		= 46;
$BPDeleteOnUse		= 47;
$BPArmorHitSound	= 48;
$BPIntegrity		= 49;
$BPPerc			= 50;
$BPPlan			= 51;
$BPPlanReqs		= 52;
$BPPlanMats		= 53;
$BPPlanTypeReq		= 54;
$BPIsMagWeapon		= 55;
$BPIsQuiver		= 56;
$BPQuiverDamage		= 57;
$BPCraftCreate		= 58;
$BPNoInteg		= 59;
$BPPockets		= 60;
$BPIsBelt		= 61;
$BPDamageStone		= 62;

$BPVisSlot 		= 1000;
$BPVis 			= 1001;
$BPIsVis 		= 1002;
$BPVisSkin 		= 1;
$BPVisItem 		= 2;


//=====================================================================================================================================================

// BONUS

function GetBonus(%id,%i)
{
	if (%i == "") return 0;
	%b = $PlayerBonus[%id,%i];
	%ai = Player::isAiControlled(Client::GetOwnedObject(%id));
	if (%i == $BPADDALLOFF || %i == $BPADDALLDEF) {
		%b += fetchData(%id,"RemortStep");
	}
	if (%i == $BPMAGICFIND || %i == $BPGOLDFIND || %i == $BPADDEXP) {
		%b += fetchData(%id,"RemortStep");
	}
	if (%i == $BPPHYSBASE || %i == $BPRANGEDBASE) {
		%b += round(GetPlayerSkill(%id,$SkillStrength) / 60);
		%b += round(GetPlayerSkill(%id,$SkillWeaponHandling) / 30);
	}
	if (%i == $BPARMOR)
		%b += round(GetPlayerSkill(%id,$SkillStrength) / 3);
	if (%i == $BPCRITCHANCE || %i == $BPCRITDAMAGE || %i == $BPSPELLCRIT || %i == $BPSPCRITDAMAGE)
		%b += round(GetPlayerSkill(%id,$SkillDexterity) / 60);
	if (%i == $BPEVASION)
		%b += round(GetPlayerSkill(%id,$SkillDexterity) / 3);
	if (%i == $BPSPELLBASE) {
		%b += round(GetPlayerSkill(%id,$SkillIntelligence) / 60);
		%b += round(GetPlayerSkill(%id,$SkillSpellCapacity) / 30);
	}
	if (%i == $BPALLRESIST)
		%b += round(GetPlayerSkill(%id,$SkillIntelligence) / 3);
	//%cap = $BPCAP[%i];
	//if ($BPCAPLVL[%i] && !%ai && %cap != "") %cap = round(%cap * ($ClientData[%id,LVL] / 230));
	//if (%b > %cap && %cap != "" && !%ai) return %cap;
	//if (%b == "") return 0;
	//else return %b;
	return %b;
}

function SideBonus(%id,%i,%b,%nobonus,%sepmsg)
{
	return;
	%bonus = $PlayerBonus[%id,%i];
	if (%sepmsg == "") %sepmsg = 0;
	if (%bonus == "")
		return false;
	if (!$SideBonusEnabled)
		return false;
	if (%bonus <= 0)
		return false;
	if (%nobonus)
		return false;
	%finalbonus = floor(%b * (%bonus / 100));
	if (%finalbonus <= 0)
		return false;
	if (%i == $ExpBonus) {
		storeData(%id, "EXP", %finalbonus, "inc");
		Client::sendMessage(%id, 2, "You received " @ %finalbonus @ " experience as a side bonus.");
	}
	if (%i == $GoldBonus) {
		storeData(%id, "COINS", %finalbonus, "inc");
		Client::sendMessage(%id, 2, "You received " @ %finalbonus @ " coins as a side bonus.");
	}
	if (%i == $SpBonus) {
		storeData(%id, "SPCredits", %finalbonus, "inc");
		Client::sendMessage(%id, 2, "You received " @ %finalbonus @ " Skill Points as a side bonus.");
	}
	if (%i == $RankBonus) {
		storeData(%id, "RankPoints", %finalbonus, "inc");
		Client::sendMessage(%id, 2, "You received " @ %finalbonus @ " Rank Points as a side bonus.");
	}
	if (%i == $LckBonus) {
		storeData(%id, "LCK", %finalbonus, "inc");
		Client::sendMessage(%id, 2, "You received " @ %finalbonus @ " LCK as a side bonus.");
	}
	return %finalbonus;
}

function ShowBonusStates(%id)
{
	focusServer();
	%msg = "";
	for (%i = 0; %i <= 200; %i++) {
		%n = GetBonus(%id,%i);
		if (%n > 0)
		%msg = %msg @ %i @ " " @ %n @ ", ";
	}
	//%msg = BPFormat(%msg);
	SendBufferBP(%id," " @ Client::GetName(%id) @ "'s Bonus States: <n><f1> " @ %msg,10);
	return;
}

//=====================================================================================================================================================

// AC's

$GetAC[POISONAC] 	= $BPPoisonAC;
$GetAC[FIREAC] 		= $BPFireAC;
$GETAC[COLDAC] 		= $BPColdAC;
$GETAC[MELEEAC] 	= $BPMeleeAC;
$GETAC[PROJECTILEAC] 	= $BPProjectileAC;
$GETAC[ENERGYAC] 	= $BPEnergyAC;

function GetPlayerAC(%id,%d)
{
	%g = $GetAC[%d];
	%ac = GetBonus(%id,%g);
	if (%ac == "" || %ac <= 0)
		%ac = 0;
	return floor(%ac / 9.996);
}

function NewGetWeaponDamageType(%w)
{
	if ($BPItem[%w,$BPDamageType] == "")
		return "Melee";
	else
		return $BPItem[%w,$BPDamageType];
}

//=====================================================================================================================================================

$MaxBackpack = 50;
$MaxMerchantStorage = 50;
$MaxBelt = 8;

function IsBackpackItem(%w)
{
	if ($BPItem[%w,$BPName] != "")
		return 1;
	else
		return 0;
}

function AddToBackpack(%id,%i,%a,%storage,%merchant,%belt,%num)
{
	if (%storage == "")
		%storage = 0;
	if (%merchant == "")
		%merchant = 0;
	if (%belt == "")
		%belt = 0;
	if (%num == "")
		%num = 1;

	if (%merchant != 0)
		%bp = $BPMerchantShop[%merchant];
	if (%belt != 0)
		%bp = $PlayerBelt[%id];
	if (%storage != 0)
		%bp = $BackpackStorage[%id,%storage];
	else
		if (!%merchant && !%belt)
			%bp = $PlayerBackpack[%id];

	if (%bp == "") {
		if (%merchant != 0) {
			$BPMerchantShop[%merchant] = %i @ " " @ %a @ " ";
			return;
		}
		if (%belt != 0) {
			$PlayerBelt[%id] = %i @ " " @ %a @ " ";
			Client::SendMessage(%id,0,"You put " @ %a @ " " @ $BPItem[%i,$BPName] @ " into your belt.");
			return;
		}
		if (%storage == 0 && !%merchant && !%belt) {
			$PlayerBackpack[%id] = %i @ " " @ %a @ " ";
			Client::SendMessage(%id,0,"You received " @ %a @ " " @ $BPItem[%i,$BPName] @ ".");
		}
		else {
			$BackpackStorage[%id,%storage] = %i @ " " @ %a @ " ";
			Client::SendMessage(%id,0,"You stored " @ %a @ " " @ $BPItem[%i,$BPName] @ ".");
		}
		return;
	}
	%bpcrop = "";
	%found = 0;
	for (%v = 0; (%item = getWord(%bp,%v)) != -1; %v += 2) {
		if (string::ICompare(%item,%i) == 0) {
			%found = 1;
			%bpcrop = %bpcrop @ %item @ " " @ (getWord(%bp,%v+1) + %a) @ " ";
		}
		else {
			%bpcrop = %bpcrop @ %item @ " " @ getWord(%bp,%v+1) @ " ";
		}
	}
	if (!%found)
		%bpcrop = %bpcrop @ %i @ " " @ %a @ " ";
	if (%merchant != 0) {
		$BPMerchantShop[%merchant] = %bpcrop;
		return;
	}
	if (%belt != 0) {
		$PlayerBelt[%id] = %bpcrop;
		Client::SendMessage(%id,0,"You put " @ %a @ " " @ $BPItem[%i,$BPName] @ " into your belt.");
		return;
	}
	if (%storage == 0) {
		Client::SendMessage(%id,0,"You received " @ %a @ " " @ $BPItem[%i,$BPName] @ ".");
		$PlayerBackpack[%id] = %bpcrop;
	}
	else {
		Client::SendMessage(%id,0,"You stored " @ %a @ " " @ $BPItem[%i,$BPName] @ ".");
		$BackpackStorage[%id,%storage] = %bpcrop;
	}
	$DOSAVE[%id] = 1;
}

function RemoveFromBackpack(%id,%i,%a,%store,%merchant,%belt,%once)
{
	//echo(" REMOVE FROM BACKPACK " @ %id @ " " @ %i @ " " @ %a @ " " @ %store @ " " @ %merchant @ " " @ %belt);
	if (%store == "" || %store <= 0)
		%storage = 0;
	if (%merchant == "")
		%merchant = 0;
	if (%belt == "")
		%belt = 0;
	if (%once == 1)
		%found = false;

	if (%belt != 0)
		%bp = $PlayerBelt[%id];
	if (%merchant != 0)
		%bp = $BPMerchantShop[%merchant];
	if (%store != 0)
		%bp = $BackpackStorage[%id,%store];
	else
		if (!%merchant && !%belt)
			%bp = $PlayerBackpack[%id];
	%bpcrop = "";
	for (%v = 0; (%item = getWord(%bp,%v)) != -1; %v += 2) {
		if (string::ICompare(%item,%i) == 0) {
			%n = (getWord(%bp,%v+1) + %a);
			if (%n > 0)
				%bpcrop = %bpcrop @ %item @ " " @ %n @ " ";
			if (%found == True && %once == 1)
				%bpcrop = %bpcrop @ %item @ " " @ getWord(%bp,%v+1) @ " ";
			%found = True;
		}
		else {
			%bpcrop = %bpcrop @ %item @ " " @ getWord(%bp,%v+1) @ " ";
		}
	}
	if (%belt != 0) {
		$PlayerBelt[%id] = %bpcrop;
		Client::SendMessage(%id,0,"You removed " @ (%a * -1) @ " " @ $BPItem[%i,$BPName] @ " from your belt.");
		return;
	}
	if (%merchant != 0) {
		$BPMerchantShop[%merchant] = %bpcrop;
		return;
	}
	if (%store == 0)
		$PlayerBackpack[%id] = %bpcrop;
	else
		$BackpackStorage[%id,%store] = %bpcrop;
	$DOSAVE[%id] = 1;
}

function GetBackpackWeight(%id)
{
	%w = 0;
	%bw = 0;
	%belt = $PlayerBelt[%id];
	if (%belt != "") {
		for (%i = 0; (%item = getWord(%belt,%i)) != -1; %i += 2) {
			%n = GetBackpackVar(%item,$BPWeight);
			%a = getWord(%belt,%i+1);
			if (%n > 0 && %a > 0)
				%bw += (%n * %a);
		}
	}
	%backpack = $PlayerBackpack[%id];
	if (%backpack == "")
		%w = 0;
	for (%i = 0; (%item = getWord(%backpack,%i)) != -1; %i += 2) {
		%n = GetBackpackVar(%item,$BPWeight);
		%a = getWord(%backpack,%i+1);
		if (%n > 0 && %a > 0)
			%w += (%n * %a);
	}
	return %w + %bw;
}

function BackpackFull(%id,%i)
{
	if (%i > 0 && %i != "" && %i != False)
		%bp = $BackpackStorage[%id,%i];
	else
		%bp = $PlayerBackpack[%id];
	if (getWord(%bp,($MaxBackpack + ($MaxBackpack - 2))) != -1)
		return true;
	else
		return false;
}

function BeltFull(%id)
{
	%bp = $PlayerBelt[%id];
	if (getWord(%bp,($MaxBelt + ($MaxBelt - 2))) != -1)
		return true;
	else
		return false;
}

function LootHasBackpackItem(%var)
{
	if (getWord(%var,0) == -1)
		%var = string::GetSubStr(%var,1,99999);
	for (%i = 0; (%item = getWord(%var,%i)) != -1; %i += 2) {
		if (IsBackpackItem(%item)) {
			return true;
		}
	}
	return false;
}

function GetBackpackVar(%item,%var)
{
	return $BPItem[%item,%var];
}

function GetBPData(%item,%i)
{
	if ($BPItem[%item,%i] == "")
		return "False";
	else
		return $BPItem[%item,%i];
}

function GetBeltSlot(%id,%slot)
{
	%bp = $PlayerBelt[%id];
	if (getWord(%bp,%slot) != -1)
		return GetBPData(getWord(%bp,%slot),$BPName) @ " " @ getWord(%bp,%slot+1);
	else
		return false;
}

function GetTrueBeltSlot(%id,%slot)
{
	%bp = $PlayerBelt[%id];
	if (getWord(%bp,%slot) != -1)
		return getWord(%bp,%slot) @ " " @ getWord(%bp,%slot+1);
	else
		return false;
}

function GetBackpackStorage(%id,%slot,%s)
{
	%storage = $BackpackStorage[%id,%s];
	if (getWord(%storage,%slot) != -1) {
		if (getWord(%storage,%slot+1) > 1) return getWord(%storage,%slot+1) @ " " @ GetBPData(getWord(%storage,%slot),$BPName);
		else return GetBPData(getWord(%storage,%slot),$BPName);
	}
	else
		return false;
}

function GetTrueBackpackStorage(%id,%slot,%s)
{
	%storage = $BackpackStorage[%id,%s];
	if (getWord(%storage,%slot) != -1)
		return getWord(%storage,%slot) @ " " @ getWord(%storage,%slot+1);
	else
		return false;
}

function GetBackpackSlot(%id,%slot)
{
	%bp = $PlayerBackpack[%id];
	if (getWord(%bp,%slot) != -1) {
		if (getWord(%bp,%slot+1) > 1) return getWord(%bp,%slot+1) @ " " @ GetBPData(getWord(%bp,%slot),$BPName);
		else return GetBPData(getWord(%bp,%slot),$BPName);
	}
	else
		return false;
}

function GetTrueBackpackSlot(%id,%slot)
{
	%bp = $PlayerBackpack[%id];
	if (getWord(%bp,%slot) != -1)
		return getWord(%bp,%slot) @ " " @ getWord(%bp,%slot+1);
	else
		return false;
}

function GetBackpackSlotName(%id,%slot)
{
	%bp = $PlayerBackpack[%id];
	%get = getWord(%bp,%slot);
	return GetBPData(getWord(%bp,%slot),$BPName);
}

function Game::MenuSelectStorage(%id,%i,%storage,%page)
{
	%s = GetTrueBackpackStorage(%id,%i,%storage);
	%item = getWord(%s,0);
	%count = getWord(%s,1);
	%curItem = 0;
	Client::buildMenu(%id, GetBPData(%item,$BPName) @ " " @ %count , "storage", true);
	%bulk = %id.bulkNum;
	if (%bulk <= 0) %bulk = 1;
	if (%bulk > %count) %bulk = %count;
	if (%bulk > 500000) %bulk = 500000;
	%msg = WhatIs(%item,%id);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
	Client::addMenuItem(%id, %curItem++ @ "Examine..","examine " @ %i @ " " @ %storage);
	Client::addMenuItem(%id, %curItem++ @ "Withdraw " @ %bulk,"withdraw " @ %i @ " " @ %bulk @ " " @ %storage);
	Client::addMenuItem(%id, %curItem++ @ "<< Back ","selback " @ %storage @ " " @ %i);
}

function Game::MenuChooseStorage(%id)
{
	Client::buildMenu(%id,"Select a Storage:", "storage", true);
	Client::addMenuItem(%id, %curItem++ @ "Storage #1","open 1");
	Client::addMenuItem(%id, %curItem++ @ "Storage #2","open 2");
	Client::addMenuItem(%id, %curItem++ @ "Storage #3","open 3");
	Client::addMenuItem(%id, %curItem++ @ "Storage #4","open 4");
	Client::addMenuItem(%id, %curItem++ @ "Storage #5","open 5");
	Client::addMenuItem(%id, "x<< Back","chooseback");
}

function processMenuStorage(%clientId, %option)
{

	%opt = getWord(%option, 0);
	%cl = getWord(%option, 1);
	%x = getWord(%option,2);
	%page = getWord(%option,3);

	%s = GetTrueBackpackStorage(%clientId,%cl,%x);
	%item = getWord(%s,0);
	%count = getWord(%s,1);

	if (%opt == "open") {
		if (%cl < 1 || %cl > 5) return;
		Game::MenuBackpackStorage(%clientId,0,%cl);
	}
	if (%opt == "storagenext") Game::MenuBackpackStorage(%clientId,%cl,%x);
	if (%opt == "storageback") {
		if (%cl == 60)
			Game::MenuChooseStorage(%clientId);
		else
			Game::MenuBackpackStorage(%clientId,(%cl - 120),%x);
	}
	if (%opt == "selstorage") Game::MenuSelectStorage(%clientId,%cl,%x,%page);
	if (%opt == "examine") {
		%msg = WhatIs(%item,%clientId);
		SendBufferBP(%clientId, %msg, floor(String::len(%msg) / 20));
		Game::MenuSelectStorage(%clientId,%cl,%x);
	}
	if (%opt == "selback") {
		if (%x < 60) Game::MenuBackpackStorage(%clientId,0,%cl);
		if (%x >= 60) Game::MenuBackpackStorage(%clientId,60,%cl);
	}
	if (%opt == "chooseback")
		Game::MenuRequest(%clientId);
	if (%opt == "withdraw") {
		RemoveBackpackStorage(%clientId,%cl,%x,%page);
		Game::MenuBackpackStorage(%clientId,GetBackpackMenuBack(%cl),%page);
	}
}

function GetBackpackMenuBack(%cl)
{
	if (%cl < 60) return 0;
	else if (%cl >= 60 && %cl < 120) return 60;
	else if (%cl >= 120 && %cl < 180) return 120;
	else if (%cl >= 180 && %cl < 240) return 180;
	else return 0;
}

function Game::MenuSelectBackpack(%id,%i,%page)
{
	%s = GetTrueBackpackSlot(%id,%i);
	%item = getWord(%s,0);
	%count = getWord(%s,1);
	%msg = WhatIs(%item,%id);
	%fix = %i;
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 15));

	%curItem = 0;
	%name = GetBPData(%item,$BPName);
	if (string::getSubStr(%name,24,1) != "")
		%name = string::GetSubStr(%name,0,24) @ "..";

	Client::buildMenu(%id, %name @ "(" @ DynamicItem::GetQualityDisp(%item) @ ") " @ %count , "backpack", true);
	if ($BPItem[%item,$BPWield] != "")
		Client::addMenuItem(%id, %curItem++ @ "Wield..","selbackpackwield " @ %fix);
	if ($BPItem[%item,$BPUse] != "")
		Client::addMenuItem(%id, %curItem++ @ "Use..","selbackpackuse " @ %fix);
	if ($BPItem[%item,$BPIsMap] != "")
		Client::addMenuItem(%id, %curItem++ @ "Activate Map..","selmap " @ %fix);
	Client::addMenuItem(%id, %curItem++ @ "Examine..","selbackpackexamine " @ %fix @ " " @ %id @ " " @ %i @ " " @ %page);
	%bulk = %id.bulkNum;
	if (%bulk <= 0) %bulk = 1;
	if (%bulk > %count) %bulk = %count;
	if (%bulk > 500000) %bulk = 500000;
	Client::addMenuItem(%id, %curItem++ @ "Drop " @ %bulk,"selbackpackdrop " @ %fix @ " " @ %bulk);
	if ($BPItem[%item,$BPUse] != "")
		Client::addMenuItem(%id, %curItem++ @ "Bind To Key..","selbind " @ %fix @ " " @ %page);
	//------------------------------------------------------------------------------------------------------------
	//if ($BPItem[%item,$BPUse] != "")
	//	Client::addMenuItem(%id, %curItem++ @ "Add " @ %bulk @ " to Belt..","seladdbelt " @ %fix @ " " @ %bulk);
	//------------------------------------------------------------------------------------------------------------
	if (BackpackMerchantArea(%id) != false)
		Client::addMenuItem(%id, %curItem++ @ "Sell " @ %bulk,"selbackpacksell " @ %fix @ " " @ %bulk @ " " @ %i @ " " @ %page);
	if (BackpackStorageArea(%id) != false)
		Client::addMenuItem(%id, %curItem++ @ "Store " @ %bulk,"selbackpackstore " @ %fix @ " " @ %bulk);
	Client::addMenuItem(%id, %curItem++ @ "Add to Craft..","seladdcraft " @ %fix @ " " @ %page);
	if (HasNoSale(%id,%item) == False && $HARDNOSELL[%item] != 1)
		Client::addMenuItem(%id, %curItem++ @ "Add to No Sale..","selnosale " @ %fix @ " " @ %page);
	else
		Client::addMenuItem(%id, %curItem++ @ "Remove from No Sale..","selremnosale " @ %fix @ " " @ %page);
	if ($BPItem[%item,$BPMaterial] != "")
		Client::addMenuItem(%id,"xSalvage..","selbackpacksalvage " @ %fix @ " " @ %page);
	Client::addMenuItem(%id, "p<< Prev","selbackpackselback " @ %page);
}

function Game::MenuSalvageConfirm(%id,%item,%page)
{
	%name = GetBPData(%item,$BPName);
	Client::buildMenu(%id,%name, "salvage", true);
	Client::addMenuItem(%id, %curItem++ @ "Salvage Item..","salvage " @ %item @ " " @ %page);
	Client::addMenuItem(%id,"xCancel","cancel " @ %item @ " " @ %page);
}

function processMenuSalvage(%clientId, %option)
{
	%mode = getWord(%option,0);
	%item = getWord(%option,1);
	%page = getWord(%option,2);
	if (%mode == "salvage") {
		BackpackSalvage(%clientId,%item);
	}
}

function processMenuBackpack(%clientId, %option)
{

	%opt = getWord(%option, 0);
	%cl = getWord(%option, 1);
	%x = getWord(%option,2);

	%s = GetTrueBackpackSlot(%clientid,%cl);
	%item = getWord(%s,0);
	%count = getWord(%s,1);

	if (%opt == "selbackpacknext") Game::MenuBackpack(%clientId,%cl);

	if (%opt == "selbackpackback") {
		if (%cl == 60)
			Game::menuRequest(%clientId);
		else
			Game::MenuBackpack(%clientId,(%cl - 120));
	}
	if (%opt == "selbackpackselback") Game::MenuBackpack(%clientId,(%cl - 8));
	if (%opt == "selbackpackmerchantnext") Game::MenuBackpackMerchant(%clientId,%cl);

	if (%opt == "selbackpackmerchantback") {
		if (%cl == 12)
			Game::menuRequest(%clientId);
		else
			Game::MenuBackpackMerchant(%clientId,(%cl - 24));
	}

	if (%opt == "selbackpackstore") {
		Game::MenuAddStorage(%clientId,%cl,%x);
	}

	if (%opt == "selbackpackwithdraw") WithdrawBackpackStorage(%clientId,%cl,getWord(%option,2));
	if (%opt == "selbackpack") Game::MenuSelectBackpack(%clientId,%cl,getWord(%option,2));
	if (%opt == "selstorage") Game::MenuSelectStorage(%clientId,%cl);
   	if (%opt == "selmerchant") Game::MenuSelectMerchant(%clientId,%cl);

	if (%opt == "selbackpackexamine") {
		%msg = WhatIs(%item,%clientId);
		SendBufferBP(%clientId, %msg, floor(String::len(%msg) / 20));
		Game::MenuSelectBackpack(%clientId,getWord(%option,3),getWord(%option,4));
	}

	if (%opt == "selbackpackexamineequip") {
		%msg = WhatIs(%item,%clientId);
		if (%msg != "Unknown Item") {
			SendBufferBP(%clientId, %msg, floor(String::len(%msg) / 20));
		}
	}

	if (%opt == "selbackpackwield") BackpackWield(%clientId,%item);
	if (%opt == "selbackpackuse") BackpackUse(%clientId,%item,False);
	if (%opt == "selbackpacksalvage") Game::MenuSalvageConfirm(%clientId,%item);

	if (%opt == "selmap") ActivateMap(%clientId,%item);

	if (%opt == "selbackpackdrop") {
		if (%clientId.CantDrop == 1) {
			Client::SendMessage(%clientId,2,"You cant drop items while talking to an NPC.");
			return;
		}
		%bulk = %clientId.bulkNum;
		if (%bulk <= 0 || %bulk == "") %bulk = 1;
		if (%bulk > %count) %bulk = %count;
		if (%bulk > 500000) %bulk = 500000;
		if (HasBackpackCount(%clientId,%item,%bulk)) {
			if ($NoDropItem[%item] != 1) {
				//%loot = %item @ " " @ getWord(%option,2);
				%loot = %item @ " " @ %bulk;
				%name = $BPItem[%item,$BPName];
				Client::SendMessage(%clientId,2,"You drop " @ %bulk @ " " @ %name @ ".");
				TossLootbag(%clientId, %loot, 8, "*", 0, 1);
				RemoveFromBackpack(%clientId,%item,%bulk * -1);
				SaveCharacter(%clientId);
			}
			else {
				Client::SendMessage(%clientId,0,$BPItem[%item,$BPName] @ " is a No Drop Item.");
				return;
			}
		}
	}

	if (%opt == "seladdcraft") {
		if (HasBackpackCount(%clientId,%item,%count)) {
			if (Plan::IsPlanItem(%item) == True) {
				AddToPlanCraft(%clientId,%item);
				RemoveFromBackpack(%clientId,%item,-1);
				if (%clientId.PlanCraft[4] != "")
					Game::MenuPlanCraft(%clientId);
				else
					Game::MenuBackpack(%clientId,(getWord(%option,2) - 8));
				return;
			}
			else {
				AddToCraft(%clientId,%item);
				if (%clientId.CraftAdditions == "")
					Game::MenuBackpack(%clientId,(getWord(%option,2) - 8));
				else
					Game::MenuCraft(%clientId);
			}
		}
	}

	if (%opt == "selnosale") {
		if (HasBackpackCount(%clientId,%item,%count)) {
			AddToNoSale(%clientId,%item);
			Game::MenuBackpack(%clientId,(getWord(%option,2) - 8));
		}
	}

	if (%opt == "selremnosale") {
		if (HasBackpackCount(%clientId,%item,%count)) {
			RemoveFromNoSale(%clientId,%item);
			Game::MenuBackpack(%clientId,(getWord(%option,2) - 8));
		}
	}

	if (%opt == "selbackpacksell") {
		BackpackSetSell(%clientId,%item,%x,getWord(%option,3),getWord(%option,4));
	}

	if (%opt == "selbind") {
		%clientId.Bind = %item;
		%clientId.BindType = "ITEM";
		Game::MenuBind(%clientId);
	}
}

function Game::MenuBind(%id)
{
	Client::buildMenu(%id, "Select A Key:", "selectBind", true);
	for (%i = 0; (%g = string::getSubStr($BindList,%i,1)) != ""; %i++) {
		Client::addMenuItem(%id,%g @ "Key: " @ %g,%g);
	}
}

function processMenuSelectBind(%clientId,%option)
{
	BackpackBind(%clientId,%option);
}

function BackpackBind(%id,%key)
{
	%t = %id.BindType;
	if (%t == "ITEM") {
		$numMessage[%id,%key] = "USE " @ %id.Bind;
		Client::SendMessage(%id,0,$BPItem[%id.Bind,$BPName] @ " successfully bound to key: " @ %key);
	}
	if (%t == "SPELL") {
		$numMessage[%id,%key] = "CAST " @ %id.Bind;
		Client::SendMessage(%id,0,$CruSpell[%id.Bind,$CSName] @ " successfully bound to key: " @ %key);
	}
}

function Game::MenuAddStorage(%id,%item,%count)
{
	Client::buildMenu(%id, "Add to Storage:", "addstorage", true);
	Client::addMenuItem(%id, %curItem++ @ "Storage #1","add 1 " @ %item @ " " @ %count);
	Client::addMenuItem(%id, %curItem++ @ "Storage #2","add 2 " @ %item @ " " @ %count);
	Client::addMenuItem(%id, %curItem++ @ "Storage #3","add 3 " @ %item @ " " @ %count);
	Client::addMenuItem(%id, %curItem++ @ "Storage #4","add 4 " @ %item @ " " @ %count);
	Client::addMenuItem(%id, %curItem++ @ "Storage #5","add 5 " @ %item @ " " @ %count);
	Client::addMenuItem(%id, "xCancel","cancel " @ %item);
}

function processMenuAddStorage(%clientId,%option)
{
	%opt = getWord(%option,0);
	%store = getWord(%option,1);
	%n =  getWord(%option,2);
	%c = getWord(%option,3);
	if (%opt == "cancel")
		Game::MenuBackpack(%clientId,0);
	if (%opt == "add")
		AddStorageCheck(%clientId,%store,%n,%c);
}

function AddStorageCheck(%clientId,%store,%n,%c)
{
	%s = GetTrueBackpackSlot(%clientid,%n);
	%item = getWord(%s,0);
	%count = getWord(%s,1);
	if (%count < %c) {
		Client::SendMessage(%clientId,1,"You do not have this many items. (" @ %c @ ")");
		return;
	}
	%name = GetBPData(%item,$BPName);
	// Client::SendMessage(%clientId,0,"You put " @ %name @ " into storage " @ %store @ ".");
	AddBackpackStorage(%clientId,%item,%c,%store,%n);
}

function Game::menuExamineBackpack(%id,%item)
{
	// N/A
}

function Game::menuBelt(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Belt", "options", true);
	%menu = 0;
	for (%i = 1; %i <= 8; %i++) {
		%slot = GetBeltSlot(%id,%menu);
		%true = GetTrueBeltSlot(%id,%menu);
		%item = getWord(%true,0);
		if (%slot != false) {
			Client::addMenuItem(%id, %curItem++ @ %slot,"selbeltuse " @ %item);
		}
		%menu += 2;
	}
}

function Game::menuBackpack(%id,%menu)
{
	%curItem = 0;
	Client::buildMenu(%id, "Backpack: " @ fetchdata(%id,"COINS") @ " Coins", "backpack", true);
	%page = %menu + 8;
	for (%i = 1; %i <= 30; %i++) {
		%slot = GetBackpackSlot(%id,%menu);
		%item = GetTrueBackpackSlot(%id,%menu);
		%item = getWord(%item,0);
		if (%slot != false) {
			%name = GetBackpackSlotName(%id,%menu);
			if ($HARDNOSELL[%name] == 1 || HasNoSale(%id,%item))
				%slot = string::Translate(%slot);
			Client::addMenuItem(%id, GetMenuNum(%curItem++) @ %slot,"selbackpack " @ %menu @ " " @ %page);
		}
		%menu += 2;
	}
	if (GetBackpackSlot(%id,%menu) != false)
		Client::addMenuItem(%id,GetMenuNum(%curItem++) @ "Next >>","selbackpacknext " @ %menu);
	Client::addMenuItem(%id,GetMenuNum(%curItem++) @ "<< Prev","selbackpackback " @ %menu);
}

function Game::menuBackpackStorage(%id,%menu,%storage)
{
	%curItem = 0;
	Client::buildMenu(%id, "Backpack Storage", "storage", true);
	%page = %menu + 8;
	for (%i = 1; %i <= 30; %i++) {
		%slot = GetBackpackStorage(%id,%menu,%storage);
		if (%slot != false) {
			Client::addMenuItem(%id, GetMenuNum(%curItem++) @ %slot,"selstorage " @ %menu @ " " @ %storage @ " " @ %page);
		}
		%menu += 2;
	}
	if (GetBackpackStorage(%id,%menu,%storage) != false)
		Client::addMenuItem(%id,GetMenuNum(%curItem++) @ " Next >>","storagenext " @ %menu @ " " @ %storage);
	Client::addMenuItem(%id,GetMenuNum(%curItem++) @ " << Prev","storageback " @ %menu @ " " @ %storage);
}

function Game::menuSwitchBackpack(%id,%item)
{
	%curItem = 0;
	Client::buildMenu(%id, "Move " @ %item @ " to..", "switchbackpack", true);
}

function HasStorageCount(%id,%item,%a,%s)
{
	%bp = $BackpackStorage[%id,%s];
	for (%i = 0; (%has = getWord(%bp,%i)) != -1; %i += 2) {
		%count = getWord(%bp,%i+1);
		if (%count >= %a && string::ICompare(%has,%item) == 0)
			return true;
	}
	return false;
}

function BackpackHasItem(%id,%item,%backpack,%storage,%merchant,%belt)
{
	if (%belt == "")
		%belt = False;
	if (%backpack == True)
		%bp = $PlayerBackpack[%id];
	else if (%storage > 0 && %storage != "False")
		%bp = $BackpackStorage[%id,%storage];
	else if (%merchant != False)
		%bp = $BPMerchantShop[%merchant];
	else if (%belt != False)
		%bp = $PlayerBelt[%id];
	for (%i = 0; (%has = getWord(%bp,%i)) != -1; %i += 2) {
		if (string::ICompare(%has,%item) == 0)
			return true;
	}
	return false;
}

function HasBackpackCount(%id,%item,%a,%storage)
{
	%bp = $PlayerBackpack[%id];
	if (%storage > 0 || %storage != "")
		%bp = $BackpackStorage[%id,%storage];
	for (%i = 0; (%has = getWord(%bp,%i)) != -1; %i += 2) {
		%count = getWord(%bp,%i+1);
		if (%count >= %a && string::ICompare(%has,%item) == 0) {
			return true;
		}
	}
	return false;
}

function GetMerchantCount(%merchant,%item,%a)
{
	%bp = $BPMerchantShop[%merchant];
	for (%i = 0; (%has = getWord(%bp,%i)) != -1; %i += 2) {
		%count = getWord(%bp,%i+1);
		if (string::ICompare(%has,%item) == 0) {
			if (%count == -1)
				return -1;
			if (%count >= %a)
				return %a;
		}
	}
	return 0;
}

function GetBeltCount(%id,%item)
{
	%bp = $PlayerBelt[%id];
	for (%i = 0; (%has = getWord(%bp,%i)) != -1; %i += 2) {
		%count = getWord(%bp,%i+1);
		if (string::ICompare(%has,%item) == 0) {
			return %count;
		}
	}
	return 0;
}

function GetBackpackCount(%id,%item)
{
	%bp = $PlayerBackpack[%id];
	for (%i = 0; (%has = getWord(%bp,%i)) != -1; %i += 2) {
		%count = getWord(%bp,%i+1);
		if (string::ICompare(%has,%item) == 0) {
			return %count;
		}
	}
	return 0;
}

//=====================================================================================================================================================
// BELT

function AddToBelt(%id,%item,%a)
{
	return;
	if (HasBackpackCount(%id,%item,%a)) {
		if (BackpackHasItem(%id,%item,False,False,False,True)) {
			AddToBackpack(%id,%item,%a,0,0,1);
			RemoveFromBackpack(%id,%item,(%a * -1),0,0,0);
		}
		else {
			if (BeltFull(%id) == false) {
				AddToBackpack(%id,%item,%a,0,0,1);
				RemoveFromBackpack(%id,%item,(%a * -1),0,0,0);
			}
			else {
				Client::SendMessage(%id,1,"Your belt is full!");
			}
		}
	}
}

function RemoveFromBelt(%id,%item)
{
	return;
	if ((%a = GetBeltCount(%id,%item)) > 0) {
		if (BackpackHasItem(%id,%item,True,False,False,False)) {
			AddToBackpack(%id,%item,%a,0,0,0);
			RemoveFromBackpack(%id,%item,(%a * -1),0,0,1);
		}
		else {
			if (BackpackFull(%id) == false) {
				AddToBackpack(%id,%item,%a,0,0,0);
				RemoveFromBackpack(%id,%item,(%a * -1),0,0,1);
			}
			else {
				Client::SendMessage(%id,1,"Your backpack is full!");
			}
		}
	}
	else {
		echo(" NO BELT COUNT ");
	}
}

//=====================================================================================================================================================

// WEAR

// AMULET BACK CHEST HEAD RING RING HANDS LEGS BOOTS TALISMAN STUDY ARMOR WEAPON ORB SHIELD BELT POCKET1 POCKET2 POCKET3 POCKET4 POCKET5 POCKET6 BADGE1 BADGE2 BADGE3

$SideBonusEnabled = 1;

$MaxWearSlots = 25;

$BPWearLocation[1] = "amulet";
$BPLocationToNumeric["amulet"] = 1;

$BPWearLocation[2] = "back";
$BPLocationToNumeric["back"] = 2;

$BPWearLocation[3] = "chest";
$BPLocationToNumeric["chest"] = 3;

$BPWearLocation[4] = "head";
$BPLocationToNumeric["head"] = 4;

$BPWearLocation[5] = "ring1";
$BPLocationToNumeric["ring1"] = 5;

$BPWearLocation[6] = "ring2";
$BPLocationToNumeric["ring2"] = 6;

$BPWearLocation[7] = "hands";
$BPLocationToNumeric["hands"] = 7;

$BPWearLocation[8] = "legs";
$BPLocationToNumeric["legs"] = 8;

$BPWearLocation[9] = "boots";
$BPLocationToNumeric["boots"] = 9;

$BPWearLocation[10] = "talisman";
$BPLocationToNumeric["talisman"] = 10;

$BPWearLocation[11] = "study";
$BPLocationToNumeric["study"] = 11;

$BPWearLocation[12] = "armor";
$BPLocationToNumeric["armor"] = 12;

$BPWearLocation[13] = "weapon";
$BPLocationToNumeric["weapon"] = 13;

$BPWearLocation[14] = "orb";
$BPLocationToNumeric["orb"] = 14;

$BPWearLocation[15] = "shield";
$BPLocationToNumeric["shield"] = 15;

// ESSENCE REMOVED

$BPWearLocation[16] = "belt";
$BPLocationToNumeric["belt"] = 16;

$BPWearLocation[17] = "pocket1";
$BPLocationToNumeric["pocket1"] = 17;

$BPWearLocation[18] = "pocket2";
$BPLocationToNumeric["pocket2"] = 18;

$BPWearLocation[19] = "pocket3";
$BPLocationToNumeric["pocket3"] = 19;

$BPWearLocation[20] = "pocket4";
$BPLocationToNumeric["pocket4"] = 20;

$BPWearLocation[21] = "pocket5";
$BPLocationToNumeric["pocket5"] = 21;

$BPWearLocation[22] = "pocket6";
$BPLocationToNumeric["pocket6"] = 22;

$BPWearLocation[23] = "badge1";
$BPLocationToNumeric["badge1"] = 23;

$BPWearLocation[24] = "badge2";
$BPLocationToNumeric["badge2"] = 24;

$BPWearLocation[25] = "badge3";
$BPLocationToNumeric["badge3"] = 25;


function clearallbonuses(%id)
{
	for (%i = 1; %i <= 299; %i++)
		$PlayerBonus[%id,%i] = 0;
	for (%i = 1; %i <= 199; %i++)
		$SkillBonus[%id,%i] = 0;
	$DamageOverride[%id] = "";
}

$BPSkillToNumeric["Slashing"] 		= 1;
$BPSkillToNumeric["Piercing"] 		= 2;
$BPSkillToNumeric["Bludgeoning"] 	= 3;
$BPSkillToNumeric["Dodging"] 		= 4;
$BPSkillToNumeric["WeightCapacity"] 	= 5;
$BPSkillToNumeric["Bashing"] 		= 6;
$BPSkillToNumeric["Stealing"] 		= 7;
$BPSkillToNumeric["Hiding"] 		= 8;
$BPSkillToNumeric["SneakAttack"] 	= 9;
$BPSkillToNumeric["OffensiveCasting"] 	= 10;
$BPSkillToNumeric["DefensiveCasting"] 	= 11;
$BPSkillToNumeric["SpellResistance"] 	= 12;
$BPSkillToNumeric["Healing"] 		= 13;
$BPSkillToNumeric["Archery"] 		= 14;
$BPSkillToNumeric["Endurance"] 		= 15;
$BPSkillToNumeric["MartialArts"] 	= 16;
$BPSkillToNumeric["Mining"] 		= 17;
$BPSkillToNumeric["Speech"] 		= 18;
$BPSkillToNumeric["SenseHeading"] 	= 19;
$BPSkillToNumeric["Energy"] 		= 20;
$BPSkillToNumeric["Haggling"] 		= 21;
$BPSkillToNumeric["NeutralCasting"] 	= 22;
$BPSkillToNumeric["Strength"] 		= 23;
$BPSkillToNumeric["Stamina"] 		= 24;
$BPSkillToNumeric["Agility"] 		= 25;
$BPSkillToNumeric["Intelligence"] 	= 26;
$BPSkillToNumeric["Sense"] 		= 27;
$BPSkillToNumeric["Psychic"] 		= 28;
$BPSkillToNumeric["CastInit"] 		= 29;
$BPSkillToNumeric["CastSpeed"] 		= 29;
$BPSkillToNumeric["Literacy"] 		= 30;
$BPSkillToNumeric["Smithing"] 		= 31;
$BPSkillToNumeric["MagicCraft"] 	= 32;
$BPSkillToNumeric["Alchemy"] 		= 33;
$BPSkillToNumeric["Focus"] 		= 34;
$BPSkillToNumeric["SpellCapacity"] 	= 34;
$BPSkillToNumeric["WeaponHandling"] 	= 35;
$BPSkillToNumeric["EvadeMelee"] 	= 36;
$BPSkillToNumeric["Aiming"] 		= 37;
$BPSkillToNumeric["Brawling"] 		= 38;
$BPSkillToNumeric["Cleave"] 		= 39;
$BPSkillToNumeric["DivineCasting"] 	= 40;
$BPSkillToNumeric["PrimalMagic"] 	= 41;
$BPSkillToNumeric["HolyMagic"] 		= 42;
$BPSkillToNumeric["Empowerment"] 	= 43;
$BPSkillToNumeric["DarkMagic"] 		= 44;
$BPSkillToNumeric["LightMagic"] 	= 45;
$BPSkillToNumeric["Ritual"] 		= 46;
$BPSkillToNumeric["Sorcery"] 		= 47;
$BPSkillToNumeric["Protection"] 	= 48;
$BPSkillToNumeric["Enchantment"] 	= 49;
$BPSkillToNumeric["Wisdom"] 		= 50;
$BPSkillToNumeric["Dexterity"] 		= 51;

function UnequipBackpackWear(%id)
{
	for (%i = 1; %i <= $MaxWearSlots; %i++) {
		if ((%item = $PlayerWear[%id,%i]) != "") {
			AddToBackpack(%id,%item,1);
			BackpackWieldBonus(%id,%item,0,0);
			$PlayerWear[%id,%i] = "";
			UpdateAppearance(%id);
		}
	}
}

function GetWearList(%id)
{
	%list = "";
	for (%i = 1; %i <= $MaxWearSlots; %i++) {
		if ($PlayerWear[%id,%i] != "") {
			%list = %list @ $PlayerWear[%id,%i] @ " ";
		}
		else
			%list = %list @ "-1 ";
	}
	return %list;
}

function WearListToVar(%id,%list)
{

	for (%i = 1; %i <= $MaxWearSlots; %i++) {
		if (getWord(%list,%i - 1) != -1)
			$PlayerWear[%id,%i] = getWord(%list,%i - 1);
		else
			$PlayerWear[%id,%i] = "";
	}
}

function InitWearBonus(%id)
{
	clearallbonuses(%id);
	for (%i = 1; %i <= $MaxWearSlots; %i++) {
		if ((%item = $PlayerWear[%id,%i]) != "") {
			DynamicItem::InitWear(%item);
			BackpackWieldBonus(%id,%item,1,"","","",%i);
		}
	}
}

function GetCurrentWear(%id,%p)
{
	%cur = $PlayerWear[%id,%p];
	if (%cur != "")
		return $BPItem[%cur,$BPName];
	else
		return "none";
}

function GetCurrentWearFull(%id,%p)
{
	%cur = $PlayerWear[%id,%p];
	if (%cur != "")
		return $PlayerWear[%id,%p];
	else
		return "none";
}

function Game::MenuSelectWear(%id,%w)
{
	%l = $BPLocationToNumeric[%w];
	%item = $PlayerWear[%id,%l];
	%curItem = 0;
	Client::buildMenu(%id, $BPItem[%item,$BPName], "selectwear", true);
	if (%item != "") {
		%msg = WhatIs(%item,-1);
		if (%msg != "Unknown Item") SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
		Client::addMenuItem(%id, %curItem++ @ "Unequip","selbackpackunequip " @ %l);
		Client::addMenuItem(%id, %curItem++ @ "Examine..","selbackpackexamineequip " @ %w);
	}
	Client::addMenuItem(%id, "p" @ "<< Prev","selbackselectwear");
}

function ProcessMenuSelectWear(%id,%option)
{
	%opt = getWord(%option,0);
	%cl = getWord(%option,1);
	if (%opt == "selbackpackunequip") WearUnEquip(%id,%cl);
	if (%opt == "selbackpackexamineequip") Game::MenuSelectWear(%id,%cl);
	if (%opt == "selbackselectwear") Game::MenuWear(%id);
}

function Game::MenuWearWindow(%clientId)
{
	%id = %clientId;
	%curItem = 0;
	Client::buildMenu(%clientId, "Wear & Essence", "wearwindow", true);
	Client::addMenuItem(%id, %curItem++ @ "Equiped Gear..", "wear");
	Client::addMenuItem(%id, %curItem++ @ "Equiped Runes..", "essence");
	Client::addMenuItem(%clientId, "p" @ "<< Prev","back");
}

function ProcessMenuWearWindow(%clientId,%option)
{
	if (%option == "wear")
		Game::MenuWear(%clientId);
	if (%option == "essence")
		Game::MenuEssence(%clientId);
	if (%option == "back")
		Game::MenuRequest(%clientId);
}


function Game::MenuEssence(%clientId)
{
	%id = %clientId;
	%curItem = 0;
	Client::buildMenu(%clientId, "Essence", "options", true);
	Client::addMenuItem(%clientId, %curItem++ @ "Mind: " @ GetCurrentWear(%id,$BPLocationToNumeric["mind"]),"selselectwear mind");
	Client::addMenuItem(%clientId, %curItem++ @ "Body: " @ GetCurrentWear(%id,$BPLocationToNumeric["body"]),"selselectwear body");
	Client::addMenuItem(%clientId, %curItem++ @ "Soul: " @ GetCurrentWear(%id,$BPLocationToNumeric["soul"]),"selselectwear soul");
	Client::addMenuItem(%clientId, %curItem++ @ "Spirit: " @ GetCurrentWear(%id,$BPLocationToNumeric["spirit"]),"selselectwear spirit");
	Client::addMenuItem(%clientId, %curItem++ @ "Ghost: " @ GetCurrentWear(%id,$BPLocationToNumeric["ghost"]),"selselectwear ghost");
	Client::addMenuItem(%clientId, "p" @ "<< Prev","selbackessence");
}

function Game::MenuWear(%clientId)
{
	%id = %clientId;
	%curItem = 0;
	Client::buildMenu(%clientId, "Equipped Gear", "options", true);
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Armor: " @ GetCurrentWear(%id,$BPLocationToNumeric["armor"]),"selselectwear armor");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Weapon: " @ GetCurrentWear(%id,$BPLocationToNumeric["weapon"]),"selselectwear weapon");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Shield: " @ GetCurrentWear(%id,$BPLocationToNumeric["shield"]),"selselectwear shield");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Back: " @ GetCurrentWear(%id,$BPLocationToNumeric["back"]),"selselectwear back");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Amulet: " @ GetCurrentWear(%id,$BPLocationToNumeric["amulet"]),"selselectwear amulet");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Chest: " @ GetCurrentWear(%id,$BPLocationToNumeric["chest"]),"selselectwear chest");
	// NEW
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Head: " @ GetCurrentWear(%id,$BPLocationToNumeric["head"]),"selselectwear head");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Hands: " @ GetCurrentWear(%id,$BPLocationToNumeric["hands"]),"selselectwear hands");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Ring: " @ GetCurrentWear(%id,$BPLocationToNumeric["ring1"]),"selselectwear ring1");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Ring: " @ GetCurrentWear(%id,$BPLocationToNumeric["ring2"]),"selselectwear ring2");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Legs: " @ GetCurrentWear(%id,$BPLocationToNumeric["legs"]),"selselectwear legs");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Boots: " @ GetCurrentWear(%id,$BPLocationToNumeric["boots"]),"selselectwear boots");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Orb: " @ GetCurrentWear(%id,$BPLocationToNumeric["orb"]),"selselectwear orb");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Talisman: " @ GetCurrentWear(%id,$BPLocationToNumeric["talisman"]),"selselectwear talisman");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Study: " @ GetCurrentWear(%id,$BPLocationToNumeric["study"]),"selselectwear study");
	// ADDED
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Belt: " @ GetCurrentWear(%id,$BPLocationToNumeric["belt"]),"selselectwear belt");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Pocket: " @ GetCurrentWear(%id,$BPLocationToNumeric["pocket1"]),"selselectwear pocket1");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Pocket: " @ GetCurrentWear(%id,$BPLocationToNumeric["pocket2"]),"selselectwear pocket2");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Pocket: " @ GetCurrentWear(%id,$BPLocationToNumeric["pocket3"]),"selselectwear pocket3");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Pocket: " @ GetCurrentWear(%id,$BPLocationToNumeric["pocket4"]),"selselectwear pocket4");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Pocket: " @ GetCurrentWear(%id,$BPLocationToNumeric["pocket5"]),"selselectwear pocket5");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Pocket: " @ GetCurrentWear(%id,$BPLocationToNumeric["pocket6"]),"selselectwear pocket6");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Badge: " @ GetCurrentWear(%id,$BPLocationToNumeric["badge1"]),"selselectwear badge1");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Badge: " @ GetCurrentWear(%id,$BPLocationToNumeric["badge2"]),"selselectwear badge2");
	Client::addMenuItem(%clientId, GetMenuNum(%curItem++) @ "Badge: " @ GetCurrentWear(%id,$BPLocationToNumeric["badge3"]),"selselectwear badge3");
	//Client::addMenuItem(%clientId, "n" @ "Next >>","selnextwear");
	Client::addMenuItem(%clientId, "p" @ "<< Prev","selbackwear1");
}
function Game::MenuWear2(%clientId)
{
	%id = %clientId;
	%curItem = 0;
	Client::buildMenu(%clientId, "Wear", "options", true);
	Client::addMenuItem(%clientId, %curItem++ @ "Head: " @ GetCurrentWear(%id,$BPLocationToNumeric["head"]),"selselectwear head");
	Client::addMenuItem(%clientId, %curItem++ @ "Hands: " @ GetCurrentWear(%id,$BPLocationToNumeric["hands"]),"selselectwear hands");
	Client::addMenuItem(%clientId, %curItem++ @ "Ring: " @ GetCurrentWear(%id,$BPLocationToNumeric["ring1"]),"selselectwear ring1");
	Client::addMenuItem(%clientId, %curItem++ @ "Ring: " @ GetCurrentWear(%id,$BPLocationToNumeric["ring2"]),"selselectwear ring2");
	Client::addMenuItem(%clientId, %curItem++ @ "Legs: " @ GetCurrentWear(%id,$BPLocationToNumeric["legs"]),"selselectwear legs");
	Client::addMenuItem(%clientId, %curItem++ @ "Boots: " @ GetCurrentWear(%id,$BPLocationToNumeric["boots"]),"selselectwear boots");
	Client::addMenuItem(%clientId, "n" @ "Next >>","selnextwear2");
	Client::addMenuItem(%clientId, "p" @ "<< Prev","selbackwear2");
}
function Game::MenuWear3(%clientId)
{
	%id = %clientId;
	%curItem = 0;
	Client::buildMenu(%clientId, "Wear", "options", true);
	Client::addMenuItem(%clientId, %curItem++ @ "Orb: " @ GetCurrentWear(%id,$BPLocationToNumeric["orb"]),"selselectwear orb");
	Client::addMenuItem(%clientId, %curItem++ @ "Talisman: " @ GetCurrentWear(%id,$BPLocationToNumeric["talisman"]),"selselectwear talisman");
	Client::addMenuItem(%clientId, %curItem++ @ "Study: " @ GetCurrentWear(%id,$BPLocationToNumeric["study"]),"selselectwear study");
	Client::addMenuItem(%clientId, "p" @ "<< Prev","selbackwear3");
}

function WearUnEquip(%id,%l)
{
	%item = $PlayerWear[%id,%l];
	if (%item == "")
		return;
	if (BackpackFull(%id)) {
		Client::SendMessage(%id,0,"Your backpack is full.");
		return;
	}
	if (%l == 16) {
		%m = 1;
		if ($PlayerWear[%id,17] != "") %m = 0;
		if ($PlayerWear[%id,18] != "") %m = 0;
		if ($PlayerWear[%id,19] != "") %m = 0;
		if ($PlayerWear[%id,20] != "") %m = 0;
		if ($PlayerWear[%id,21] != "") %m = 0;
		if ($PlayerWear[%id,22] != "") %m = 0;
		if (%m == 0) {
			Client::SendMessage(%id,0,"You must empty your pockets before removing your belt.");
			return;
		}
	}
	AddToBackpack(%id,%item,1);
	BackpackWieldBonus(%id,%item,0,0,"","",%l);
	Client::SendMessage(%id,2,"You unequipped " @ $BPItem[%item,$BPName] @ ".");
	$PlayerWear[%id,%l] = "";
	RefreshWeight(%id);
	UpdateAppearance(%id);
}

function WearEquip(%id,%item,%l)
{
	%req = $BPItem[%item,$BPWield];
	if (%req == "")
		return false;
	%loc = "";
	if (%l == 5 || %l == 6 || %l == 17 || %l == 18 || %l == 19 || %l == 20 || %l == 21 || %l == 22) {
		$PlayerWear[%id,%l] = %item;
		return;
	}
	for (%i = 0; (%r = getWord(%req,%i)) != -1; %i += 2) {
		%a = getWord(%req,%i+1);
		if (%r == "LOCATION") {
			%loc = $BPLocationToNumeric[%a];
			$PlayerWear[%id,%loc] = %item;
		}
	}
	RefreshWeight(%id);
	UpdateAppearance(%id);
}

function DefaultSkillLocks(%id)
{
	// SPECIAL SKILLS
	$PlayerSkillLocked[%id,"Magic"] = 0;
	$PlayerSkillLocked[%id,"Potion"] = 0;
	$PlayerSkillLocked[%id,"Navigation"] = 0;
	$PlayerSkillLocked[%id,"Smoke"] = 0;
	$PlayerSkillLocked[%id,"Transport"] = 0;

	// REGULAR SKILLS
	$PlayerSkillLocked[%id,"Healing"] = 0;
	$PlayerSkillLocked[%id,"Energy"] = 0;

	// WEAPON SPECIALS
	$PlayerSkillLocked[%id,"Bashing"] = 0;
	$PlayerSkillLocked[%id,"Cleave"] = 0;
	$PlayerSkillLocked[%id,"Aiming"] = 0;
	$PlayerSkillLocked[%id,"Brawling"] = 0;
	$PlayerSkillLocked[%id,"Backstabbing"] = 0;
}

function BPLockSkill(%id,%a,%dur,%item)
{
	//echo("LOCKING SKILL " @ %id @ " " @ %a @ " " @ %dur);
	$PlayerSkillLocked[%id,%a] = 1;
	%id.LockSkill[%a,START] = getSimTime();
	%id.LockSkill[%a,DUR] = %dur;
	%connectId = GetConnectionId(%id);
	//echo(" LOCK ALL " @ %id @ " " @ %connectId @ " " @ %a @ " " @ %item @ " " @ %dur);
	schedule("BPAutoUnlock(" @ %id @ "," @ %connectId @ ",\"" @ %a @ "\",\"" @ %item @ "\");",%dur);
}

function BPGetSkillLockTime(%id,%skill)
{
	%start = %id.LockSkill[%skill,START];
	%dur = %id.LockSkill[%skill,DUR];
	//echo("START " @ %start);
	//echo("DUR " @ %dur);
	if (%start == "")
		return;
	return floor((%start + %dur) - getSimTime());
}

function BPDisplaySkillLockTime(%id,%skill)
{
	%r = BPGetSkillLockTime(%id,%skill);
	%r = CruTimeFormat(%r,1);
	Client::SendMessage(%id,0,"Skill " @ %skill @ " is locked for " @ %r);
}

function BackpackAreaOfEffect(%id,%a,%dur,%item)
{
	for (%cl = Client::GetFirst(); %cl != -1; %cl = Client::GetNext(%cl))
	{
		if (!IsDead(%cl) && fetchData(%cl,"HasLoadedAndSpawned") == true && %cl != %id) {
			%clpos = GameBase::getPosition(%cl);
			%idpos = GameBase::getPosition(%id);
			%dist1 = Vector::getDistance(%clpos,%idpos);
			if (%dist1 <= %a) {
				BPGotAOE(%cl,%a,%dur,%item);
			}
		}
	}
}

function BPGotAOE(%cl,%a,%dur,%item)
{
	%connectId = GetConnectionId(%cl);
	BackpackWieldBonus(%cl,%item,1,1,1);
	schedule("BPMinusAOE(" @ %cl @ "," @ %connectId @ ",\"" @ %a @ "\",\"" @ %item @ "\");",%dur);
}

function BPMinusAOE(%cl,%connect,%a,%item)
{
	if (GetConnectionId(%cl) == %connect) {
		Client::SendMessage(%cl,2,"The effects of " @ GetBPData(%item,$BPName) @ " wear off...");
		BackpackWieldBonus(%cl,%item,0,1,1);
	}
}

function BPAutoUnlock(%id,%connect,%a,%item)
{
	//echo("UNLOCKING SKILL.........");
	if (GetConnectionId(%id) == %connect) {
		$PlayerSkillLocked[%id,%a] = 0;
		if (%item != -1)
			BackpackWieldBonus(%id,%item,0,1);
		rpg::SendMessage(%id,$msgpink,"Your " @ %a @ " skill is available.");
	}
}

function BPSkillUnlocked(%id,%a)
{
	//echo("BPSKILL UNLOCKED " @ %id @ " " @ %a);
	if ($PlayerSkillLocked[%id,%a] == 0)
		return true;
	else
		return false;
}

function BPUsingShield(%id,%type)
{
	%shield = getCurrentWearFull(%id,15);
	if (%shield == "none")
		return False;
	else {
		%t = $BPItem[%shield,$BPBlockType];
		if (%type != "") {
			if (%t == %type) return True;
			else return False;
		}
		else
			return True;
	}
}

function InitWearVisuals(%id)
{
	for (%i = 0; %i <= 15; %i++) {
		%item = $PlayerWear[%id,%i];
		if (%item != -1) {
			if ((%vistype = $BPItem[%item,$BPVisType]) != "") {
				if (%vistype == $BPVisItem) {
					%vslot = $BPItem[%item,$BPVisSlot];
					%vis = $BPItem[%item,$BPVis];
					if (%vis != "" && %vslot != "")
						Player::MountItem(%id,%vis,%vslot);
				}
			}
		}
	}
	RefreshWeight(%id);
	UpdateAppearance(%id);
}

// BackpackWieldBonus(%id,%item,1,1);

function BackpackWieldBonus(%id,%item,%v,%use,%notowner,%combine,%location)
{
	if (%notowner == "")
		%notowner = 0;
	if (%use == 1)
		%bonus = $BPItem[%item,$BPUseBonus];
	else
		%bonus = $BPItem[%item,$BPWieldBonus];

	if (%combine != "")
		%bonus = %combine;

	if (%location == "")
		%location = -1;

	%text = $AreaText[%item];
	if (%text != "" && %v == 1)
		FloatText(%id,%text);

	// CHECK FOR VISUALS
	if ((%vistype = $BPItem[%item,$BPVisType]) != "") {
		if (%vistype == $BPVisItem) {
			%vslot = $BPItem[%item,$BPVisSlot];
			%vis = $BPItem[%item,$BPVis];
			if (%vis != "" && %vslot != "") {
				if (%v)
					Player::MountItem(%id,%vis,%vslot);

				else
					Player::UnMountItem(%id,%vslot);
			}
		}
	}

	%baseitem = $BPItem[%item,$BPBaseItem];
	%sreq = $DynamicItem[%baseitem,$DReq];
	//echo("---------------------------------------------------> BASEITEM SREQ " @ %baseitem @ " " @ %sreq);

	if (%bonus != "") {
		%dur = 15;
		for (%i = 0; (%b = getWord(%bonus,%i)) != -1; %i += 2) {
			%a = getWord(%bonus,%i + 1);
			if (%a == %a || %b == "LOCKSKILL" || %b == "TRANSPORT" || %b == "TOWNPORTAL" || %b == "ACTION") {
				if ((%num = $BPSkillToNumeric[%b]) == "") {
					if (%b == "DURATION") {
						%dur = %a;
					}
					else if (%b == "AOE" && %a >= 1 && %v != 0 && !%notowner) {
						BackpackAreaOfEffect(%id,%a,%dur,%item);
					}
					else if (%b == "LOCKSKILL" && %v != 0 && !%notowner) {
						BPLockSkill(%id,%a,%dur,%item);
					}
					else if (%b == "HEAL") {
						if (%v != 0) {
							%hp = fetchData(%id, "HP");
							refreshHP(%id, ((%a / 100) * -1));
						}
					}
					else if (%b == "HEALMP") {
						if (%v != 0) {
							%mana = fetchData(%id, "ManaPoints");
							refreshMANA(%id, (%a * -1));
						}
					}
					else if (%b == "ACTION" && %v != 0) {
						InitUseAction(%id,%a);
					}
					else if (%b == "TRANSPORT" && %v != 0) {
						BackpackTransport(%id,%a);
					}
					else if (%b == "TOWNPORTAL" && %v != 0) {
						BackpackTownPortal(%id);
					}
					else if (%b == "EXP" || %b == "LCK" || %b == "SP" || %b == "COINS" || %b == "RankPoints") {
						if (%v != 0)
							GiveThisStuff(%id, %b @ " " @ %a, 1, 1, 0);
					}
					else if (%b == "Fishing" || %b == "Farming" || %b == "PhysCraft" || %b == "MagicCraft" || %b == "Alchemy") {
						return True;
					}
					else if (%b == "LearnSpell") {
						if (HasLearnedSpell(%id,%a) == True) {
							Client::SendMessage(%id,2,"You have already learned spell: " @ $CruSpell[%a,$CSName]);
							return False;
						}
						LearnSpell(%id,%a);
					}
					else if (%b == "LOADPROJECTILE") {
						%count = GetBackpackCount(%id,%item);
						LoadProjectile(%id,%item,%count);
					}
					else if (%b == "SETHEAL") {
						if (%v) {
							$HealPotion[%id] = 5;
							$HealDelta[%id] = 0;
							$HealDeltaTick[%id] = 0;
						}
					}
					else if (%b == "SETCLASS") {
						if (%v)
							SetClass(%id,%a);
						else
							SetClass(%id,"");
					}
					else if (%b == "ENERGYVIAL") {
						if (%v) {
							$EnergyVial[%id] = 5;
							$ManaDelta[%id] = 0;
							$ManaDeltaTick[%id] = 0;
						}
					}
					else if (%b == "ROOT") {
						if (%v)
							RootPlayer(%id);
						else
							UnRootPlayer(%id);
					}
					else {
						%num = $BPBonusToNumeric[%b];
						%lok = True;
						//echo("---------------> B " @ %b @ " NUM " @ %num @ " A " @ %a @ " LOCATION " @ %location @ " SREQ " @ %sreq);
						if (%location != -1) {
							if ($BPNOEFFECT[%num,%location] == 1) %lok = False;
							if ($BPNOEFFECT[%num,%location,%sreq] == 1) %lok = False;
						}
						//echo(" LOK " @ %lok);
						if (%num != "" && %lok != False) {
							if (%b == "DDARCANE") { if (%v) { $DamageOverride[%id] = "Arcane"; } else { $DamageOverride[%id] = ""; } }
							else if (%b == "DDFIRE") { if (%v) { $DamageOverride[%id] = "Fire"; } else { $DamageOverride[%id] = ""; } }
							else if (%b == "DDCOLD") { if (%v) { $DamageOverride[%id] = "Cold"; } else { $DamageOverride[%id] = ""; } }
							else if (%b == "DDPOISON") { if (%v) { $DamageOverride[%id] = "Poison"; } else { $DamageOverride[%id] = ""; } }
							else if (%b == "DDSPECTRAL") { if (%v) { $DamageOverride[%id] = "SPECTRAL"; } else { $DamageOverride[%id] = ""; } }
							else {
								if (%v != 0)
									$PlayerBonus[%id,%num] += %a;
								else
									$PlayerBonus[%id,%num] -= %a;
							}
						}
						else {
							if (%lok != False)
								GiveThisStuff(%id, %b @ " " @ %a, 1, 1, 0);
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
	}
	%implicit = $BPItem[%item,$BPImplicit];
	if (%implicit != "") {
		for (%i = 0; (%mod = getWord(%implicit,%i)) != -1; %i+=2) {
			%a = getWord(%implicit,%i+1);
			%num = $BPBonusToNumeric[%mod];
			if (%num != "") {
				if (%v != 0)
					$PlayerBonus[%id,%num] += %a;
				else
					$PlayerBonus[%id,%num] -= %a;
			}
		}
	}
}

function BackpackUse(%id,%item,%belt)
{
	if (%belt == "")
		%belt = False;
	%can = CanBackpackWield(%id,%item,1);
	if (%can != false) {
		rpg::SendMessage(%id,$MsgPink,"You used " @ $BPItem[%item,$BPName] @ ".");
		BackpackWieldBonus(%id,%item,1,1);
		if ($BPItem[%item,$BPDeleteOnUse] == 1) {
			if (%belt == True)
				RemoveFromBackpack(%id,%item,-1,0,0,1);
			else
				RemoveFromBackpack(%id,%item,-1,0,0,0);
		}
	}
	else {
		Client::SendMessage(%id,0,"You don't meet the requirements to use " @ GetBPData(%item,$BPName) @ ".");
	}
}

function BackpackWield(%id,%item)
{
	%can = CanBackpackWield(%id,%item);
	if (%can != false) {
		Client::SendMessage(%id,2,"You equipped " @ $BPItem[%item,$BPName] @ ".");
		WearEquip(%id,%item,%can);
		BackpackWieldBonus(%id,%item,1,0,"","",%can);
		RemoveFromBackpack(%id,%item,-1);
		RefreshATK(%id);
	}
	else {
		Client::SendMessage(%id,0,"You don't meet the requirements to wield " @ GetBPData(%item,$BPName) @ ".");
	}
}

// SPECIALS
$BPLockMagic 		= 1;
$BPLockPotion 		= 2;
$BPLockNavigation 	= 3;
$BPLockSmoke 		= 4;
$BPLockTransport 	= 5;
$BPLockEat 		= 6;
// REGULAR
$BPLockHealing 		= 7;
$BPLockEnergy		= 8;

// SPECIALS
$BPLockToNumeric["Magic"] 		= 1;
$BPLockToNumeric["Potion"] 		= 2;
$BPLockToNumeric["Navigation"] 		= 3;
$BPLockToNumeric["Smoke"] 		= 4;
$BPLockToNumeric["Transport"] 		= 5;
$BPLockToNumeric["Eat"] 		= 6;
// REGULAR
$BPLockToNumeric["Healing"]		= 7;
$BPLockToNumeric["Energy"] 		= 8;

function BPFormat(%string,%novar)
{
	%new = "";
	if (%string == "")
		return %string;
	for (%i = 0; (%f = getWord(%string,%i)) != -1; %i += 2) {
		if ($BPFormat[%f] != "") {
			if ($BPFormatNoShowVar[%f] == 1 || %novar == True) {
				//if ($BPFormatUnique[%f] != 1)
					%new = %new @ $BPFormat[%f];
				//else
				//	%new = %new @ "<f2>" @ $BPFormat[%f] @ "<f0>";
			}
			else
				if ($BPFormatNoDisplay[%f] != 1) {
					if (%f == "SETCLASS") {
						%x = getWord(%string,%i+1);
						%val = $CLASS[%x];
					}
					else
						%val = getWord(%string,%i+1);
					%new = %new @ $BPFormat[%f] @ " " @ $BPFormatMinus[%f] @ %val @ $BPFormatPercent[%f];
					//if ($BPFormatUnique[%f] != 1)
					//	%new = %new @ $BPFormat[%f] @ " " @ $BPFormatMinus[%f] @ %val @ $BPFormatPercent[%f];
					//else
					//	%new = %new @ $BPFormat[%f] @ " " @ $BPFormatMinus[%f] @ %val @ $BPFormatPercent[%f];
				}
		}
		else
			%new = %new @ %f @ " " @ getWord(%string,%i+1);
		if (getWord(%string,%i+2) != -1)
			if ($BPFormatNoDisplay[%f] != 1)
				%new = %new @ "\n ";
	}
	return %new;
}

function CanBackpackWield(%id,%item,%use,%combine)
{
	//echo("CANBACKPACKWIELD " @ %id @ " " @ %item @ " " @ %use @ " " @ %combine);
	if (%use == 1)
		%req = $BPItem[%item,$BPUse];
	else
		%req = $BPItem[%item,$BPWield];
	if (%req == "" && %combine == "")
		return false;
	if (%combine != "")
		%req = %combine;
	%m = 1;
	%loc = "";
	%lock = "";
	%deny = "";
	for (%i = 0; (%r = getWord(%req,%i)) != -1; %i += 2) {
		%a = getWord(%req,%i+1);
		if (%a <= 0 && %r != "LOCATION" && %r != "SKILLUNLOCK" && %r != "CLASS" && %r != "HOUSE" && %r != "GROUP" && %r != "RACE" && %r != "ACTIONUNLOCKED")
			%a = 0;
		if (%r == "LVLG") {
			if (fetchData(%id,"LVL") < %a) {
				%m = 0;
				%deny = %deny @ "lvlg:" @ %a @ " ";
			}
		}
		else if (%r == "LVLL") {
			if (fetchData(%id,"LVL") > %a)
				%m = 0;
		}
		else if (%r == "LOCATION") {
			%loc = %loc @ %a;
		}
		else if (%r == "SKILLUNLOCK") {
			%deny = %deny @ "skilllocked:" @ %a @ " ";
			%lock = %lock @ %a;
		}
		else if (%r == "NEARFIRE") {
			if (NearFire(%id) == False) {
				%m = 0;
				%deny = %deny @ "nearfire:" @ %a @ " ";
			}
		}
		else if (%r == "MANA") {
			if (fetchData(%id,"MANA") < %a) {
				%deny = %deny @ "MANA:" @ %a @ " ";
				%m = 0;
			}
		}
		else if (%r == "ACTIONUNLOCKED") {
			if (PlayerCanAction(%id,%a) == False || ActionUnlocked(%id,%a) == False || CurrentlyInitAction(%id,%a) == True) {
				%m = 0;
				%deny = %deny @ "action:" @ %a @ " ";
			}
		}
		else if (%r == "NOTINCOMBAT") {
			if ($InCombat[%id] > 0) {
				%m = 0;
				%deny = %deny @ "combat:" @ %a @ " ";
			}
		}
		else {
			%rcrop = $BPSkillToNumeric[%r];
			if (%rcrop != "") {
				if (GetPlayerSkill(%id,%rcrop) < %a) {
					%deny = %deny @ %r @ ":" @ %a @ " ";
					%m = 0;
				}
			}
		}
	}
	if (!%m) {
		WeildDenyMessage(%id,%deny);
		return false;
	}
	if (%use != 1) {
		if (%loc == "") {
			return false;
		}
		if (%loc == "pocket") {
			if ((%pocket = GetEmptyPocket(%id)) != -1) {
				echo(" POCKET " @ %pocket);
				return %pocket;
			}
			else {
				%deny = %deny @ "pocket:0";
				WeildDenyMessage(%id,%deny);
				return false;
			}
		}
		if (%loc == "ring") {
			if ($PlayerWear[%id,5] == "")
				return 5;
			if ($PlayerWear[%id,6] == "")
				return 6;
			else {
				%deny = %deny @ "location:" @ %loc @ " ";
				WeildDenyMessage(%id,%deny);
				return false;
			}
		}
		%locnum = $BPLocationToNumeric[%loc];
		if (%locnum == "")
			return false;
		%ml = 0;
		if ($PlayerWear[%id,%locnum] == "")
			%ml = 1;
		if (%loc == "shield") {
			%weapon = $PlayerWear[%id,13];
			if ($BPItem[%item,$BPIsQuiver] == 1) {
				if (%weapon != "" && %weapon != -1) {
					if ($BPItem[%weapon,$BPRanged] != 1) {
						%msg = "You can not use a quiver with your current equipped items.";
						Client::sendMessage(%id,0,%msg);
						return false;
					}
				}
			}
			else {
				if (%weapon != "" && %weapon != -1) {
					if ($BPItem[%weapon,$BPRanged] == 1 || $BPItem[%weapon,$BPWeaponTwoHand] == 1) {
						%msg = "You can not use a shield with your current equipped items.";
						Client::sendMessage(%id,0,%msg);
						return false;
					}
				}
			}
		}
		if (%loc == "weapon") {
			%twohand = $BPItem[%item,$BPWeaponTwoHand];
			%ranged = $BPItem[%item,$BPRanged];
			%shield = $PlayerWear[%id,15];
			if (%shield != -1 && %shield != "") {
				%quiver = $BPItem[%shield,$BPIsQuiver];
				if (%quiver == 1) {
					if (%ranged != 1) {
						%msg = "You can not equip this Weapon while using a quiver.";
						Client::sendMessage(%id,0,%msg);
						return false;
					}
				}
				else {
					if (%twohand == 1) {
						%msg = "You can not equip this Weapon while using a shield.";
						Client::sendMessage(%id,0,%msg);
						return false;
					}
				}
			}
		}
		if (!%ml) {
			%deny = %deny @ "location:" @ %loc @ " ";
			WeildDenyMessage(%id,%deny);
			return false;
		}
		else
			return %locnum;
	}
	else {
		if (BPSkillUnlocked(%id,%lock) == true)
			return true;
		else {
			BPDisplaySkillLockTime(%id,%lock);
			return false;
		}
	}
}

function GetEmptyPocket(%id)
{
	%belt = $PlayerWear[%id,16];
	if (%belt == -1 || %belt == "")
		return -1;
	if (GetBPData(%belt,$BPIsBelt) != 1)
		return -1;
	%pockets = GetBPData(%belt,$BPPockets);
	if (%pockets < 1)
		return -1;
	%p[1] = $PlayerWear[%id,17];
	%p[2] = $PlayerWear[%id,18];
	%p[3] = $PlayerWear[%id,19];
	%p[4] = $PlayerWear[%id,20];
	%p[5] = $PlayerWear[%id,21];
	%p[6] = $PlayerWear[%id,22];
	%t[1] = 17;
	%t[2] = 18;
	%t[3] = 19;
	%t[4] = 20;
	%t[5] = 21;
	%t[6] = 22;
	for (%i = 1; %i <= 6; %i++) {
		if (%p[%i] == "") {
			if (%i <= %pockets)
				return %t[%i];
		}
	}
	return -1;
}

function WeildDenyMessage(%cl,%deny)
{
	for (%i = 0; (%g = getWord(%deny,%i)) != -1; %i++) {
		%p = string::FindSubStr(%g,":");
		%t = string::GetSubStr(%g,0,%p);
		%n = string::GetSubStr(%g,(%p + 1),999);
		echo(%p @ " " @ %t @ " " @ %n);
		if (%t == "skilllocked")
			%msg = "Skill is locked: " @ %n;
		if (%t == "combat")
			%msg = "Cannot use in combat.";
		if (%t == "action")
			%msg = "Cannot currently use action: " @ %n;
		if (%t == "location")
			%msg = "You already have an item equiped in this location: " @ %n;
		if (%t == "nearfire")
			%msg = "You are not near a fire.";
		if (%t == "lvlg")
			%msg = "You must be level " @ %n @ " or greater.";
		if ($BPSkillToNumeric[%t] != "")
			%msg = "Your " @ %t @ " must be at least " @ %n @ ".";
		if (%t == "MANA")
			%msg = "Your MANA must be greater than " @ %n @ ".";
		if (%t == "pocket")
			%msg = "You do not have an available pocket to equip this.";
		Client::sendMessage(%cl,0,%msg);
	}
}

//=====================================================================================================================================================

// BACKPACK TRANSPORT

function BackpackTransport(%id,%area)
{
	%a = $BPTransport[%area];
	if (%a != "") {
		Client::SendMessage(%id,2,"Transporting to " @ $BPFormat[%area] @ "...");
		Item::SetVelocity(client::GetOwnedObject(%id),"0 0 0");
		GameBase::SetPosition(%id,%a);
	}
	else
		 Client::SendMessage(%id,1,"Transportation failed.");
}

// BACKPACK PORTAL

function BackpackTownPortal(%id)
{
	Client::SendMessage(%id,2,"Opening a Town Portal...");
	InitUseAction(%id,"TownPortal");
}

function BackpackTownPortal::Create(%id)
{
	%obj = client::GetOwnedObject(%id);
	%id.Portal = GameBase::GetPosition(%obj);
	%id.PortalZone = fetchData(%id,"ZONE");
	%pos = $TOWNPORTALPOS;
	%rot = $TOWNPORTALROT;
	Item::SetVelocity(%obj,"0 0 0");
	GameBase::SetPosition(%obj,%pos);
	GameBase::SetRotation(%obj,%rot);
	%id.lastTargetingArea = $TARGETINGAREA[%id];
	$TARGETINGAREA[%id] = 0;
}

//=====================================================================================================================================================

function BackpackSmithCombo(%id,%w)
{
	%c = $BPSmith[%w,$BPSmithCombo];
	%s = "";
	if (%c == "") {
		Client::SendMessage(%id,1,%w @ " is not a smithable item.");
		return;
	}
	else {
		for (%i == 0; (%p = getWord(%c,%i)) != -1; %i += 2) {
			%a = getWord(%c,%i + 1);
			if (getWord(%c,%i + 2) != -1)
				%s = %s @ %p @ " " @ %a @ ", ";
			else
				%s = %s @ %p @ " " @ %a;
		}
		Client::SendMessage(%id,0,GetBPData(%w,$BPName) @ ", smith using: " @ %s @ " - price $" @ $BPSmith[%w,$BPSmithPrice]);
	}

}

//=====================================================================================================================================================

$AreaTextDist = 15;

function AreaText(%id,%message,%color,%dist)
{
	if (%color == "") %color = 0;
	if (%dist == "") %dist = $AreaTextDist;
	%pos = GameBase::getPosition(%id);
	for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
	{
		%clpos = GameBase::getPosition(%cl);
		%dist1 = Vector::getDistance(%clpos,%pos);
		if(%dist1 <= %dist)
			if (!IsDead(%cl))
				Client::sendMessage(%cl,%color,%message);
	}
}

function FloatText(%id,%text)
{
	%r = "";
	for (%i = 0; (%w = getWord(%text,%i)) != -1; %i++) {
		if (%w == "*")
			%r = %r @ Client::GetName(%id) @ " ";
		else
			%r = %r @ %w @ " ";
	}
	AreaText(%id,%r);
}

//=====================================================================================================================================================

function FormatQL(%ql)
{
	if (%ql < 100)
		%ql = "0" @ %ql;
	if (%ql < 10)
		%ql = "0" @ %ql;
	return %ql;
}

function RandBetween(%a,%b)
{
	if (%a == %b)
		return %a;
	else
		return floor(getRandom() * ((%b - %a) + 1) + %a);
}

function PercBetween(%a,%b,%p)
{
	%add = %b - %a;
	%add = floor(%add * %p);
	return %a + %add;
}

//=====================================================================================================================================================

// DYNAMIC BACKPACK CREATE

$DMinMax 		= 1;
$DWeight 		= 3;
$DPrice 		= 4;
$DWield			= 5;
$DWieldBonus 		= 6;
$DUse 			= 7;
$DUseBonus 		= 8;
$DDesc 			= 9;
$DName 			= 10;
$DVis 			= 11;
$DVisSlot 		= 12;
$DVisType		= 13;
$DProjectile 		= 14;
$DRanged		= 15;
$DATK			= 16;
$DRobed			= 17;
$DNameRange		= 18;
$DCraftBonus		= 19;
$DWeapon 		= 20;
$DArmor			= 21;
$DIco			= 22;
$DDamage		= 23;
$DATKSkills		= 24;
$DDEFSkills		= 25;
$DSpecialAdd		= 26;
$DDeleteOnUse		= 27;
$DDamageType		= 28;
$DMBS			= 29;
$DItemType		= 30;
$DTier			= 31;
$DTierHard		= 32;
$DTierProp 		= 33;
$DTierPerc 		= 34;
$DSet			= 35;
$DWeaponPerc 		= 36;
$DWeaponDamage 		= 37;
$DWeaponDamageF 	= 38;
$DWeaponPrice 		= 39;
$DWeaponReq 		= 40;
$DMain			= 41;
$DReq			= 42;
$DCraftType		= 43;
$DBaseItem		= 44;
$DRune			= 45;
$DRuneReq		= 46;
$DRuneBonus		= 47;
$DRuneLoc		= 48;
$DWeaponMinDmg		= 49;
$DWeaponMaxDmg		= 50;
$DWeaponMagDmg		= 51;
$DIsWeapon 		= 52;
$DIsMagWeapon		= 53;
$DWeaponCritChance	= 54;
$DWeaponCritDamage	= 55;
$DWeaponDelay		= 56;
$DWeaponTwoHand		= 57;
$DWeaponPerc		= 58;
$DMaterial		= 59;
$DBlockChance		= 60;
$DBlockAmount		= 61;
$DBlockType		= 62;
$DAHS			= 63;
$DPerc			= 64;
$DShowQLInName		= 65;
$DPlanReqs		= 66;
$DPlanTypeReq		= 67;
$DReqName		= 68;
$DIsQuiver		= 69;
$DQuiverDamage		= 70;
$DNoInteg		= 71;
$DNoDropFlag		= 72;
$DQLFluxImplicit	= 73;
$DIsBelt		= 74;
$DDamageStone		= 75;

$DVisSlot[Weapon] 	= 0;
$DVisSlot[Shield] 	= 2;
$Bow = 1;
$Crossbow = 2;

$SetBonus["Power",2] = "CRITICALDAMAGE 10";
$SetBonus["Power",3] = "CRITICALCHANCE 1";

$ReqStr = 1;
$ReqDex = 2;
$ReqInt = 3;

//$ReqSta = 2;
//$ReqAgi = 3;
//$ReqSen = 4;
//$ReqPsy = 5;
//$ReqInt = 6;

$ReqDisp[1] = "Strength";
$ReqDisp[2] = "Dexterity";
$ReqDisp[3] = "Intelligence";

//$ReqDisp[2] = "Stamina";
//$ReqDisp[3] = "Agility";
//$ReqDisp[4] = "Sense";
//$ReqDisp[5] = "Psychic";
//$ReqDisp[6] = "Intelligence";

function BPReqDisplay(%req)
{
	return $ReqDisp[%req];
}

function BPRuneReqVal(%n,%ql)
{
	return floor(%n * (3450 * (%ql / 300)));
}

//exec(tier_vars);

exec(backpack_runes);
exec(backpack_modifiers);

$TierRandom["Amulet","DYN"] 	= $COUNTAMULET[DYN];
$TierRandom["Amulet","AMR"] 	= $COUNTAMULET[AMR];
$TierRandom["Amulet","EVA"] 	= $COUNTAMULET[EVA];
$TierRandom["Amulet","RES"] 	= $COUNTAMULET[RES];
$TierRandom["Amulet","LDYN"] 	= $COUNTAMULET[LDYN];
$TierRandom["Amulet","LAMR"] 	= $COUNTAMULET[LAMR];
$TierRandom["Amulet","LEVA"] 	= $COUNTAMULET[LEVA];
$TierRandom["Amulet","LRES"] 	= $COUNTAMULET[LRES];

$TierRandom["RING","DYN"] 	= $COUNTRING[DYN];
$TierRandom["RING","AMR"] 	= $COUNTRING[AMR];
$TierRandom["RING","EVA"] 	= $COUNTRING[EVA];
$TierRandom["RING","RES"] 	= $COUNTRING[RES];
$TierRandom["RING","LDYN"] 	= $COUNTRING[LDYN];
$TierRandom["RING","LAMR"] 	= $COUNTRING[LAMR];
$TierRandom["RING","LEVA"] 	= $COUNTRING[LEVA];
$TierRandom["RING","LRES"] 	= $COUNTRING[LRES];

$TierRandom["TALISMAN","DYN"] 	= $COUNTTALISMAN[DYN];
$TierRandom["TALISMAN","AMR"] 	= $COUNTTALISMAN[AMR];
$TierRandom["TALISMAN","EVA"] 	= $COUNTTALISMAN[EVA];
$TierRandom["TALISMAN","RES"] 	= $COUNTTALISMAN[RES];
$TierRandom["TALISMAN","LDYN"] 	= $COUNTTALISMAN[LDYN];
$TierRandom["TALISMAN","LAMR"] 	= $COUNTTALISMAN[LAMR];
$TierRandom["TALISMAN","LEVA"] 	= $COUNTTALISMAN[LEVA];
$TierRandom["TALISMAN","LRES"] 	= $COUNTTALISMAN[LRES];

$TierRandom["ORB","DYN"] 	= $COUNTORB[DYN];
$TierRandom["ORB","AMR"] 	= $COUNTORB[AMR];
$TierRandom["ORB","EVA"] 	= $COUNTORB[EVA];
$TierRandom["ORB","RES"] 	= $COUNTORB[RES];
$TierRandom["ORB","LDYN"] 	= $COUNTORB[LDYN];
$TierRandom["ORB","LAMR"] 	= $COUNTORB[LAMR];
$TierRandom["ORB","LEVA"] 	= $COUNTORB[LEVA];
$TierRandom["ORB","LRES"] 	= $COUNTORB[LRES];

$TierRandom["HEAD","DYN"] 	= $COUNTHEAD[DYN];
$TierRandom["HEAD","AMR"] 	= $COUNTHEAD[AMR];
$TierRandom["HEAD","EVA"] 	= $COUNTHEAD[EVA];
$TierRandom["HEAD","RES"] 	= $COUNTHEAD[RES];
$TierRandom["HEAD","LDYN"] 	= $COUNTHEAD[LDYN];
$TierRandom["HEAD","LAMR"] 	= $COUNTHEAD[LAMR];
$TierRandom["HEAD","LEVA"] 	= $COUNTHEAD[LEVA];
$TierRandom["HEAD","LRES"] 	= $COUNTHEAD[LRES];

$TierRandom["Chest","DYN"] 	= $COUNTCHEST[DYN];
$TierRandom["Chest","AMR"] 	= $COUNTCHEST[AMR];
$TierRandom["Chest","EVA"] 	= $COUNTCHEST[EVA];
$TierRandom["Chest","RES"] 	= $COUNTCHEST[RES];
$TierRandom["Chest","LDYN"] 	= $COUNTCHEST[LDYN];
$TierRandom["Chest","LAMR"] 	= $COUNTCHEST[LAMR];
$TierRandom["Chest","LEVA"] 	= $COUNTCHEST[LEVA];
$TierRandom["Chest","LRES"] 	= $COUNTCHEST[LRES];

$TierRandom["HANDS","DYN"] 	= $COUNTHANDS[DYN];
$TierRandom["HANDS","AMR"] 	= $COUNTHANDS[AMR];
$TierRandom["HANDS","EVA"] 	= $COUNTHANDS[EVA];
$TierRandom["HANDS","RES"] 	= $COUNTHANDS[RES];
$TierRandom["HANDS","LDYN"] 	= $COUNTHANDS[LDYN];
$TierRandom["HANDS","LAMR"] 	= $COUNTHANDS[LAMR];
$TierRandom["HANDS","LEVA"] 	= $COUNTHANDS[LEVA];
$TierRandom["HANDS","LRES"] 	= $COUNTHANDS[LRES];

$TierRandom["LEGS","DYN"] 	= $COUNTLEGS[DYN];
$TierRandom["LEGS","AMR"] 	= $COUNTLEGS[AMR];
$TierRandom["LEGS","EVA"] 	= $COUNTLEGS[EVA];
$TierRandom["LEGS","RES"] 	= $COUNTLEGS[RES];
$TierRandom["LEGS","LDYN"] 	= $COUNTLEGS[LDYN];
$TierRandom["LEGS","LAMR"] 	= $COUNTLEGS[LAMR];
$TierRandom["LEGS","LEVA"] 	= $COUNTLEGS[LEVA];
$TierRandom["LEGS","LRES"] 	= $COUNTLEGS[LRES];

$TierRandom["BOOTS","DYN"] 	= $COUNTBOOTS[DYN];
$TierRandom["BOOTS","AMR"] 	= $COUNTBOOTS[AMR];
$TierRandom["BOOTS","EVA"] 	= $COUNTBOOTS[EVA];
$TierRandom["BOOTS","RES"] 	= $COUNTBOOTS[RES];
$TierRandom["BOOTS","LDYN"] 	= $COUNTBOOTS[LDYN];
$TierRandom["BOOTS","LAMR"] 	= $COUNTBOOTS[LAMR];
$TierRandom["BOOTS","LEVA"] 	= $COUNTBOOTS[LEVA];
$TierRandom["BOOTS","LRES"] 	= $COUNTBOOTS[LRES];

$TierRandom["WEAPON","WPN"] 	= $COUNTWEAPON[WPN];
$TierRandom["WEAPON","LWPN"] 	= $COUNTWEAPON[LWPN];
$TierRandom["WEAPON","STF"] 	= $COUNTWEAPON[STF];
$TierRandom["WEAPON","LSTF"] 	= $COUNTWEAPON[LSTF];

$TierRandom["ARMOR","DYN"] 	= $COUNTARMOR[DYN];
$TierRandom["ARMOR","AMR"] 	= $COUNTARMOR[AMR];
$TierRandom["ARMOR","EVA"] 	= $COUNTARMOR[EVA];
$TierRandom["ARMOR","RES"] 	= $COUNTARMOR[RES];
$TierRandom["ARMOR","LDYN"] 	= $COUNTARMOR[LDYN];
$TierRandom["ARMOR","LAMR"] 	= $COUNTARMOR[LAMR];
$TierRandom["ARMOR","LEVA"] 	= $COUNTARMOR[LEVA];
$TierRandom["ARMOR","LRES"] 	= $COUNTARMOR[LRES];

$TierRandom["SHIELD","MES"] 	= $COUNTSHIELD[MES];
$TierRandom["SHIELD","SPS"] 	= $COUNTSHIELD[SPS];
$TierRandom["SHIELD","LMES"] 	= $COUNTSHIELD[LMES];
$TierRandom["SHIELD","LSPS"] 	= $COUNTSHIELD[LSPS];
$TierRandom["SHIELD","QUV"] 	= $COUNTSHIELD[QUV];


function TierItem::GetHardDisp(%type,%hard,%ql,%perc)
{
	%msg = "";
	for (%i = 0; (%mod = getWord(%hard,%i)) != -1; %i+=2) {
		%val = getWord(%hard,%i+1);
		if (string::FindSubStr(%val,"H:") != -1) {
			if (string::FindSubStr(%val,"-") != -1) {
				%newval = String::getWord(%val,":",1);
				%nvmin = String::getWord(%newval,"-",0);
				%nvmax = String::getWord(%newval,"-",1);
				%valmsg = "(" @ %nvmin @ "-" @ %nvmax @ ")";
			}
			else {
				%newval = String::GetSubStr(%val,2,99);
				%valmsg = "(" @ %newval @ ")";
			}
		}
		else if (string::FindSubStr(%val,"L:") != -1) {
			if (string::FindSubStr(%val,"-") != -1) {
				%newval = String::getWord(%val,":",1);
				%nvmin = String::getWord(%newval,"-",0);
				%nvmax = String::getWord(%newval,"-",1);
				%nvminql = round(%nvmin * (%ql/300));
				%nvmaxql = round(%nvmax * (%ql/300));
				%valmsg = "(" @ %nvminql @ "-" @ %nvmaxql @ ")";
			}
			else {
				%newval = String::GetSubStr(%val,2,99);
				%newval = round(%newval * (%ql/300));
				%valmsg = "(" @ %newval @ ")";
			}
		}
		else {
			%valmsg = "";
		}
		if ($BPFormatNoShowVar[%mod] != 1)
			%msg = %msg @ " " @ $BPFormat[%mod] @ " " @ %valmsg @ " \n";
		else
			%msg = %msg @ " " @ $BPFormat[%mod] @ " \n ";
	}
	return %msg;
}

function TierItem::SetBonusDisp(%set)
{
	%msg = "";
	%msg = %msg @ "Item Set: " @ %set @ "\n";
	%setitems = $SetBonus[%set,1];
	%msg = %msg @ " ";
	for (%v = 0; (%item = getWord(%setitems,%v)) != -1; %v += 1) {
		if (getWord(%setitems,(%v+1)) != -1)
			%msg = %msg @ $DynamicItem[%item,$DName] @ "\n ";
		else
			%msg = %msg @ $DynamicItem[%item,$DName];
	}
	%msg = %msg @ "\nSet Bonus:\n";
	if ($SetBonus[%set,2] != "")
		%msg = %msg @ " (2) " @ BPFormat($SetBonus[%set,2]) @ "\n";
	if ($SetBonus[%set,3] != "")
		%msg = %msg @ " (3) " @ BPFormat($SetBonus[%set,3]) @ "\n";
	if ($SetBonus[%set,4] != "")
		%msg = %msg @ " (4) " @ BPFormat($SetBonus[%set,4]) @ "\n";
	if ($SetBonus[%set,5] != "")
		%msg = %msg @ " (5) " @ BPFormat($SetBonus[%set,5]) @ "\n";
	if ($SetBonus[%set,6] != "")
		%msg = %msg @ " (6) " @ BPFormat($SetBonus[%set,6]) @ "\n";
	if ($SetBonus[%set,7] != "")
		%msg = %msg @ " (7) " @ BPFormat($SetBonus[%set,7]) @ "\n";
	return %msg @ "\n";
}

function TierFormatValue(%val,%rune)
{
	if (%rune == 1) { %val = "+" @ %val; }
	if (%rune == 2) { %val = "$" @ %val; }
	if (string::Len(%val) == 6) return %val;
	if (string::Len(%val) == 5) return "0" @ %val;
	if (string::Len(%val) == 4) return "00" @ %val;
	if (string::Len(%val) == 3) return "000" @ %val;
	if (string::Len(%val) == 2) return "0000" @ %val;
	if (string::Len(%val) == 1) return "00000" @ %val;
	return %new;
}

$BPTIERBONUS[0] = 1.00;
$BPTIERBONUS[1] = 1.00;
$BPTIERBONUS[2] = 1.05;
$BPTIERBONUS[3] = 1.10;
$BPTIERBONUS[4] = 1.15;
$BPTIERBONUS[5] = 1.20;
$BPTIERBONUS[6] = 1.30;
$BPTIERBONUS[7] = 1.40;
$BPTIERBONUS[8] = 1.50;


function ClearBackpack(%id)
{
	$PlayerBackpack[%id] = "";
}

function TierItemListVars(%type,%set)
{
	%count = $COUNTAMULET[DYN];
	if (%count <= 0) return;
	for (%i = 0; %i <= %count; %i++) {
		%var = $BPTIERVAR["Amulet","DYN",%i];
		%val = $BPTIERVAL["Amulet","DYN",%i];
		%mod = $BPMOD[%var];
		echo(" * " @ %i @ " " @ %var @ " " @ %val @ " " @ %mod);
	}
}

//===============================================

$TierImplicit[ARMOR,AMR] 	= 400;
$TierImplicit[SHIELD,MES] 	= 400;
$TierImplicit[HEAD,AMR] 	= 200;
$TierImplicit[CHEST,AMR] 	= 400;
$TierImplicit[HANDS,AMR] 	= 200;
$TierImplicit[LEGS,AMR] 	= 200;
$TierImplicit[BOOTS,AMR] 	= 200;
$TierImplicit[BELT,AMR] 	= 100;

$TierImplicit[ARMOR,LAMR] 	= 400;
$TierImplicit[SHIELD,LMES] 	= 400;
$TierImplicit[HEAD,LAMR] 	= 200;
$TierImplicit[CHEST,LAMR] 	= 400;
$TierImplicit[HANDS,LAMR] 	= 200;
$TierImplicit[LEGS,LAMR] 	= 200;
$TierImplicit[BOOTS,LAMR] 	= 200;
$TierImplicit[BELT,LAMR] 	= 100;

//----------------------------------------------

$TierImplicit[ARMOR,EVA] 	= 600;
$TierImplicit[SHIELD,EVA] 	= 0;
$TierImplicit[HEAD,EVA] 	= 200;
$TierImplicit[CHEST,EVA] 	= 200;
$TierImplicit[HANDS,EVA] 	= 200;
$TierImplicit[LEGS,EVA] 	= 400;
$TierImplicit[BOOTS,EVA] 	= 400;
$TierImplicit[BELT,EVA] 	= 100;

$TierImplicit[ARMOR,LEVA] 	= 600;
$TierImplicit[SHIELD,LEVA] 	= 0;
$TierImplicit[HEAD,LEVA] 	= 200;
$TierImplicit[CHEST,LEVA] 	= 200;
$TierImplicit[HANDS,LEVA] 	= 200;
$TierImplicit[LEGS,LEVA] 	= 400;
$TierImplicit[BOOTS,LEVA] 	= 400;
$TierImplicit[BELT,LEVA] 	= 100;

//----------------------------------------------

$TierImplicit[ARMOR,RES] 	= 400;
$TierImplicit[SHIELD,SPS] 	= 400;
$TierImplicit[HEAD,RES] 	= 400;
$TierImplicit[CHEST,RES] 	= 200;
$TierImplicit[HANDS,RES] 	= 200;
$TierImplicit[LEGS,RES] 	= 200;
$TierImplicit[BOOTS,RES] 	= 200;
$TierImplicit[BELT,RES] 	= 100;

$TierImplicit[ARMOR,LRES] 	= 400;
$TierImplicit[SHIELD,LSPS] 	= 400;
$TierImplicit[HEAD,LRES] 	= 400;
$TierImplicit[CHEST,LRES] 	= 200;
$TierImplicit[HANDS,LRES] 	= 200;
$TierImplicit[LEGS,LRES] 	= 200;
$TierImplicit[BOOTS,LRES] 	= 200;
$TierImplicit[BELT,LRES] 	= 100;

//===============================================

$TierLoc["Amulet"] 	= "amulet";
$TierLoc["Chest"] 	= "chest";
$TierLoc["Head"] 	= "head";
$TierLoc["Ring"] 	= "ring";
$TierLoc["Hands"] 	= "hands";
$TierLoc["Legs"] 	= "legs";
$TierLoc["Boots"] 	= "boots";
$TierLoc["Talisman"] 	= "talisman";
$TierLoc["Study"] 	= "study";
$TierLoc["Orb"] 	= "orb";
$TierLoc["Belt"] 	= "belt";
$TierLoc["Pocket"] 	= "pocket";
$TierLoc["Shield"] 	= "shield";
$TierLoc["MagicShield"] = "shield";
$TierLoc["Weapon"] 	= "weapon";
$TierLoc["MagicWeapon"] = "weapon";
$TierLoc["Back"] 	= "back";
$TierLoc["Armor"] 	= "armor";

function getRarityPriceIncrease(%rare)
{
	if (%rare == "0") return 1;
	else if (%rare == "1") return 1;
	else if (%rare == "2") return 2;
	else if (%rare == "3") return 4;
	else if (%rare == "4") return 8;
	else if (%rare == "5") return 16;
	else if (%rare == "6") return 32;
	else if (%rare == "7") return 64;
	else if (%rare == "8") return 128;
	else return 1;
}

function TierItem::getImplictRoll(%item,%req,%ql,%tm,%min,%max)
{
	if (%tm < 1 || %tm == "") %tm = 1;
	if (%min < 1 || %min == "") %min = 1;
	if (%max < 1 || %max == "") %min = 1;
	%val = $TierImplicit[%item,%req];
	%val = %val * (%ql / 300);
	%minval = %val * (%min / 100);
	%maxval = %val * (%max / 100);
	%roll = MTRB(%minval,%maxval);
	%roll = round(%roll * %tm);
	if (%roll < 1) %roll = 1;
	return %roll;
}

function TierItem::getWeaponImplicit(%item,%ql,%tm)
{
	if (%tm < 1 || %tm == "") %tm = 1;
	%min = 10;
	%max = 100;
	%val = $TierImplicit[%item];
	if ($TierImplicitNoFlux[%item] != 1)
		%val = %val * (%ql / 300);
	%minval = %val * (%min / 100);
	%maxval = %val * (%max / 100);
	%roll = MTRB(%minval,%maxval);
	%roll = round(%roll * %tm);
	return %roll;
}

function BPStripPlus(%val)
{
	if ((%l = string::findSubStr(%val,"+")) != -1) {
		%g = string::getSubStr(%val,(%l+1),6);
		return %g + 0;
	}
	else if ((%l = string::findSubStr(%val,"$")) != -1) {
		%g = string::getSubStr(%val,(%l+1),6);
		return %g + 0;
	}
	else
		return %val + 0;
}

$BPRANDOMDAMAGE[1] = "DDF";
$BPRANDOMDAMAGE[2] = "DDC";
$BPRANDOMDAMAGE[3] = "DDP";
$BPRANDOMDAMAGE[4] = "DDE";
$BPRANDOMDAMAGE[5] = "DDA";

$BPCODEDAMAGE["DDF"] = "Fire";
$BPCODEDAMAGE["DDC"] = "Cold";
$BPCODEDAMAGE["DDP"] = "Poison";
$BPCODEDAMAGE["DDE"] = "Energy";
$BPCODEDAMAGE["DDA"] = "Arcane";
$BPCODEDAMAGE["DDS"] = "Spectral";

//function MTRB(%a,%b)
//{
//	return round(getRandomMT() * (%b - %a) + %a);
//}

function TierItem::RandomItem(%item,%ql,%overridep,%hardvals,%oldtier,%prevmain,%sockchance,%plus,%runecode)
{
	//echo("[TIERITEM::RANDOMITEM] ITEM:" @ %item @ " QL:" @ %ql @ " OVERRIDEP:" @ %overridep @ " HARDVALS:" @ %hardvals @ " OLDTIER:" @ %oldtier @ " PREVMAIN:" @ %prevmain @ " SOCKCHANCE:" @ %sockchance @ " PLUS:" @ %plus);
	if (%item == "") {
		echo(" ================================================================================= ");
		echo(" WARNING : BLANK ITEM INPUT ");
		echo(" ABORTING ITEM BUILD ");
		echo(" ================================================================================= ");
		return;
	}
	if (string::FindSubStr(%item,"Plan*") != -1) {
		Plan::Create(%item,%ql);
		return;
	}
	%s = "";
	%n = $DynamicItem[%item,$DName];
	%h = $DynamicItem[%item,$DTierHard];
	%p = $DynamicItem[%item,$DTierProp];
	%x = $DynamicItem[%item,$DItemType];
	%greq = $DynamicItem[%item,$DReq];
	%main = $DynamicItem[%item,$DMain];
	%tier = getWord(%x,0);
	%x = getWord(%x,1);
	%magic = 0;
	if (%x == "MagicWeapon") { %x = "Weapon"; %magic = 1; }
	%tiermulti = $BPTIERBONUS[%tier];
	%numr = $TierRandom[%x,%greq];
	%perc = $DynamicItem[%item,$DTierPerc];
	%min = getWord(%perc,0);
	%max = getWord(%perc,1);
	%dperc = $DynmicItem[%item,$DPerc];
	if (%dperc == "") %dperc = 1.0;
	//===============================================================================
	if (%plus != "") %p = %plus;
	//===============================================================================
	// COUNT HARD PROPS
	%hardcount = 0;
	%newmulti = "";
	%hardinit = 0;
	%damageset = 0;
	%hardlist = "";
	if (%oldtier != "")
		%newmulti = ($BPTIERBONUS[%tier] - $BPTIERBONUS[%oldtier]) + 1;
	else
		%newmulti = 1;
	if (%h != "" && %hardvals == "") {
		%hardvals = %h;
		%hardinit = 1;
	}
	if (%hardvals != "") {
		//echo(" HARDVALS " @ %hardvals);
		for (%i = 0; (%g = getWord(%hardvals,%i)) != -1; %i+=2) {
			%code = $BPCODE[%g];
			%hardlist = %hardlist @ %code @ " ";
		}
		//echo(" HARDLIST2 " @ %hardlist);
		for (%i = 0; (%mod = getWord(%hardvals,%i)) != -1; %i+=2) {
			if ($DamageSetCheck[%mod] == 1) %damageset = 1;
			%p = %p - 1;
			%val = getWord(%hardvals,%i+1);
			if (%val == "R") {
				%r = $BPTIERNUM[%x,%greq,%mod];
				%s = %s @ $BPCODE[%mod];
				%val = $BPTIERVAL[%x,%greq,%r];
				if ($BPNoFlux[%mod] != 1) %val = round(%val * (%ql / 300));
				%minval = floor((%val * (%min / 100)) * %tiermulti);
				%maxval = floor((%val * (%max / 100)) * %tiermulti);
				if (%minval < 1) %minval = 1;
				if (%maxval < 1) %maxval = 1;
				%roll = MTRB(%minval,%maxval);
				if (%hardinit)
					%roll = TierFormatValue(%roll,2);
				else
					%roll = TierFormatValue(%roll,0);
				%s = %s @ %roll;
			}
			else if (string::FindSubStr(%val,"H:") != -1) {
				if (string::FindSubStr(%val,"-") != -1) {
					%newval = String::getWord(%val,":",1);
					%nvmin = String::getWord(%newval,"-",0);
					%nvmax = String::getWord(%newval,"-",1);
					%nvroll = MTRB(%nvmin,%nvmax);
					%s = %s @ $BPCODE[%mod] @ TierFormatValue(%nvroll,2);
				}
				else {
					%newval = String::GetSubStr(%val,2,99);
					%s = %s @ $BPCODE[%mod] @ TierFormatValue(%newval,2);
				}
			}
			else if (string::FindSubStr(%val,"L:") != -1) {
				if (string::FindSubStr(%val,"-") != -1) {
					%newval = String::getWord(%val,":",1);
					%nvmin = String::getWord(%newval,"-",0);
					%nvmax = String::getWord(%newval,"-",1);
					%nvroll = MTRB(%nvmin,%nvmax);
					%nvroll = round(%nvroll * (%ql/300));
					%s = %s @ $BPCODE[%mod] @ TierFormatValue(%nvroll,2);
				}
				else {
					%newval = String::GetSubStr(%val,2,99);
					%newval = round(%newval * (%ql/300));
					%s = %s @ $BPCODE[%mod] @ TierFormatValue(%newval,2);
				}
			}
			else {
				if (string::findSubStr(%val,"+") == -1 && string::findSubStr(%val,"$") == -1) {
					%val = round(%val * %newmulti);
					%s = %s @ $BPCODE[%mod] @ TierFormatValue(%val,0);
				}
				else {
					if (string::findSubStr(%val,"+") != -1) %char = 1;
					if (string::findSubStr(%val,"$") != -1) %char = 2;
					%val = BPStripPlus(%val);
					if (%runecode != "") {
						if ($BPCODE[%mod] == %runecode)
							%val = round(%val * %tiermulti);
					}
					else
						%val = round(%val * %newmulti);
					%s = %s @ $BPCODE[%mod] @ TierFormatValue(%val,%char);
				}
			}
		}
	}
	//===============================================================================
	// SOCKETS
	//%sockets = $BPSOCKETS[%x];
	%sockets = 6;
	if (%sockchance != "")
		%sockets = %sockchance;
	if (%p > 0) {
		for (%i = 1; %i <= %sockets; %i++) {
			%sok = MTRB(1,10);
			if (%sok == 1 && %p > 0) {
				%s = %s @ "SOK000001";
				%p = %p - 1;
			}
		}
	}
	//===============================================================================
	// DAMAGE TYPE
	if (%x == "Weapon" && %magic != 1) {
		if (%damageset == 0) {
			if (%p > 0) {
				%t = MTRB(1,%numr);
				if (%t <= %p) {
					%c = MTRB(1,4);
					%s = %s @ $BPRANDOMDAMAGE[%c] @ "000001";
					%p = %p - 1;
				}
			}
		}
	}
	//===============================================================================
	// ROLL
	%list = $BPTIERLST[%x,%greq];
	%list = String::Remove(%list,%hardlist);
	%list = String::Shuffle(%list);
	for (%i = 1; %i <= %p; %i++) {
		%mod = getWord(%list,%i-1);
		%s = %s @ %mod;
		%m = $BPMOD[%mod];
		%num = $BPTIERNUM[%x,%greq,%m];
		%val = $BPTIERVAL[%x,%greq,%num];
		if ($BPNoFlux[%m] != 1) %val = round(%val * (%ql / 300));
		%minval = floor((%val * (%min / 100)) * %tiermulti);
		%maxval = floor((%val * (%max / 100)) * %tiermulti);
		if (%minval < 1) %minval = 1;
		if (%maxval < 1) %maxval = 1;
		%roll = MTRB(%minval,%maxval);
		%roll = TierFormatValue(%roll);
		%s = %s @ %roll;
	}
	//===============================================================================
	// RANP
	%test = MTRB(1,100);
	%ranp = 0;
	if (%test <= 6) { %ranp = MTRB(1,10); }
	if (%test <= 3) { %ranp = MTRB(10,20); }
	if (%test <= 1) { %ranp = MTRB(20,30); }
	%nointeg = $DynamicItem[%item,$DNoInteg];
	if (%nointeg)
		%ranp = 0;
	//===============================================================================
	// MAIN
	//echo(" MAIN -----------------> " @ %main);
	if (%main == "NON 0 0" || %main == "NON") {
		%m = "NON000000";
	}
	else {
		if (%main == "ARMOR") {
			%roll = TierItem::getImplictRoll(%x,%greq,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "ARM" @ TierFormatValue(%roll);
		}
		else if (%main == "EVASION") {
			%roll = TierItem::getImplictRoll(%x,%greq,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "EVV" @ TierFormatValue(%roll);
		}
		else if (%main == "ALLRESIST") {
			%roll = TierItem::getImplictRoll(%x,%greq,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "ARS" @ TierFormatValue(%roll);
		}
		else if (%main == "ARMORPEN") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "ARP" @ TierFormatValue(%roll);
		}
		else if (%main == "CRITDAMAGE") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "CRD" @ TierFormatValue(%roll);
		}
		else if (%main == "CRITCHANCE") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "CRC" @ TierFormatValue(%roll);
		}
		else if (%main == "MAXHP") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "MXH" @ TierFormatValue(%roll);
		}
		else if (%main == "MAGICPEN") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "MGP" @ TierFormatValue(%roll);
		}
		else if (%main == "SPELLCRIT") {
			%roll = TierItem::GetWeaponImplicit(%item,%ql,%tiermulti,%min,%max);
			if (%newmulti != "") %roll = floor(%roll * %newmulti);
			%m = "SPX" @ TierFormatValue(%roll);
		}
		else {
			%minval = getWord(%main,1);
			%maxval = getWord(%main,2);
			%roll = MTRB(%minval,%maxval);
			if ($DynamicItem[%item,$DQLFluxImplicit] == 1)
				%roll = round(%roll * (%ql/300));
			%m = getWord(%main,0) @ TierFormatValue(%roll);
		}
	}
	//===============================================================================
	// SHIELDS
	%blocktype = $DynamicItem[%item,$DBlockType];
	if (%blocktype != "") {
		%blockchance = $DynamicItem[%item,$DBlockChance];
		%minval = getWord(%blockchance,0);
		%maxval = getWord(%blockchance,1);
		%roll = MTRB(%minval,%maxval);
		if (%blocktype == "PHYSICAL")
			%m = %m @ "BLK" @ TierFormatValue(round(%roll * %tiermulti));
		else
			%m = %m @ "BLS" @ TierFormatValue(round(%roll * %tiermulti));
		%blockamount = $DynamicItem[%item,$DBlockAmount];
		%minval = round(getWord(%blockamount,0) * (%ql / 300)) + 1;
		%maxval = round(getWord(%blockamount,1) * (%ql / 300)) + 5;
		%roll = MTRB(%minval,%maxval);
		if (%blocktype == "PHYSICAL")
			%m = %m @ "BLA" @ TierFormatValue(round(%roll * %tiermulti));
		else
			%m = %m @ "SBA" @ TierFormatValue(round(%roll * %tiermulti));
	}
	//===============================================================================
	// QUIVERS
	if ($DynamicItem[%item,$DIsQuiver]) {
		%qd = $DynamicItem[%item,$DQuiverDamage];
		%qdmax = round((%qd * 1.3) * (%ql / 300));
		%qdmin = round((%qd * 0.7) * (%ql / 300));
		%qd = MTRB(%qdmax,%qdmin);
		if (%qd < 1) %qd = 1;
		%m = "RRB" @ TierFormatValue(%qd);
	}
	//===============================================================================
	// PREVMAIN
	if (%prevmain != "") {
		if (%oldtier > %tier) {
			%t = string::getSubStr(%prevmain,0,3);
			%v = string::getSubStr(%prevmain,4,6);
			%v = (%v + 0);
			%oldbonus = $BPTIERBONUS[%oldtier];
			%newbonus = $BPTIERBONUS[%tier];
			%d = (%oldbonus - %newbonus);
			%d = 1.05 - %d;
			%m = %t @ TierFormatValue(round(%v * %d));
		}
		else {
			if (%newmulti != "") {
				%t = string::getSubStr(%prevmain,0,3);
				%v = string::getSubStr(%prevmain,4,6);
				%v = (%v + 0);
				%m = %t @ TierFormatValue(floor(%v * %newmulti));
			}
			else
				%m = %prevmain;
		}
	}
	//===============================================================================
	// QUALITY
	if (%ql < 100) { %ql = "0" @ %ql; }
	if (%ql < 10) { %ql = "0" @ %ql; }
	if (%overridep != "") %ranp = %overridep;
	//===============================================================================
	%full = %ql @ %item @ "&" @ %m @ "^" @ %s @ "%" @ %ranp;
	TierItem::Create(%full,%x);
	return %full;
}

function TierItem::Create(%new,%slot)
{
	//echo("[TIERITEM::CREATE] " @ %new @ " " @ %slot);
	//===============================================================================
	// BREAK STRING
	%find = string::FindSubStr(%new,"&");
	%main = string::getSubStr(%new,(%find + 1),999);
	%find = string::FindSubStr(%main,"^");
	%main = string::getSubStr(%main,0,%find);
	//------------------------------------------------------
	%find = string::FindSubStr(%new,"&");
	%name = string::GetSubStr(%new,3,(%find - 3));
	%ql = floor(string::GetSubStr(%new,0,3) + 0);
	%findperc = string::FindSubStr(%new,"%");
	%tperc = string::GetSubStr(%new,(%findperc+1),999);
	%plen = string::len(%tperc) + 1;
	%sreq = $DynamicItem[%name,$DReq];
	%find = string::FindSubStr(%new,"^");
	%perc = (%tperc / 100) + 1;
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%len = string::Len(%cropparts);
	%cropparts = string::GetSubStr(%cropparts,0,(%len - %plen));
	//===============================================================================
	// INITIAL CREATE
	if (%slot == -1) {
		%slot = $DynamicItem[%name,$DItemType];
		%slot = getWord(%slot,1);
	}
	//===============================================================================
	// BREAK LIST
	%start = 0;
	for (%i = 1; %i <= 30; %i++) {
		%s[%i] = string::GetSubStr(%cropparts,%start,9);
		%start += 9;
	}
	//===============================================================================
	// SOCKETS & RUNE & DAMAGETYPE
	%sockets = 0;
	%newlist = "";
	%runelist = "";
	%dd = "";
	for (%i = 1; %i <= 30; %i++) {
		if ((%crop = %s[%i]) != "") {
			%code = string::getSubStr(%crop,0,3);
			if (%code == "SOK") %sockets++;
			if ($BPCODEDAMAGE[%code] != "") %dd = $BPCODEDAMAGE[%code];
			%v = string::getSubStr(%crop,3,9);
			if ((%l = string::findSubStr(%v,"+")) != -1) {
				%v = string::getSubStr(%v,(%l+1),9);
				%val[%code] += (%v + 0);
				%runelist = %runelist @ %code @ " ";
			}
			else {
				if ((%l = string::findSubStr(%v,"$")) != -1)
					%v = string::getSubStr(%v,(%l+1),9);
				%val[%code] += (%v + 0);
				%full[%code] = 1;
			}
			if (string::findSubStr(%newlist,%code) == -1)
				%newlist = %newlist @ %code @ " ";
		}
	}
	//===============================================================================
	// MODS AND REQ
	%AMRBASE = 0;
	%RESBASE = 0;
	%EVABASE = 0;
	%AMRINC = 0;
	%EVAINC = 0;
	%RESINC = 0;
 	%DMGINC = 0;
 	%MINDMG = 0;
	%MAXDMG = 0;
	%BLKADD = 0;
	%BLSADD = 0;
	%BLAADD = 0;
	%SPAADD = 0;
	// ----------------------------------------------------
	%list = "";
	%weight = 0;
	for (%i = 1; %i <= 6; %i++) %r[%i] = 0;
	for (%i = 1; %i <= 6; %i++) %rh[%i] = 0;
	for (%i = 0; %i <= 30; %i++) {
		if ((%newcode = getWord(%newlist,%i)) != -1) {
			%multi = round(%val[%newcode] * %perc);
			%mod = $BPMOD[%newcode];
			%req = $TierReq[%mod];
			%isfull = 0;
			if (%full[%newcode] == 1) {
				%rf[%req] = 1;
				%isfull = 1;
			}
			if (%req == "") %req = 1;
			if (%r[%req] == 0) {
				if (%mod != "SOCKET") {
					if (%isfull == 1) {
						%r[%req] += $TierReqP[%mod];
						%rh[%req] = $TierReqP[%mod];
					}
					else {
						%r[%req] += ($TierReqP[%mod] * 0.75);
						%rh[%req] = ($TierReqP[%mod] * 0.75);
					}
				}
			}
			else {
				%reqp = $TierReqP[%mod];
				if (%isfull == 0)
					%reqp = (%reqp / 2);
				if (%rh[%req] < %reqp) {
					if (%mod != "SOCKET") {
						%rh[%req] = %reqp;
						%r[%req] = %reqp;
					}
				}
				else {
					if (%mod != "SOCKET")
						%r[%req] = %reqp;
				}
			}
			%weight = %weight + floor(floor(floor($TierWeight[%stat] * %perc) + 1) * (%ql/300));
			%weight = %weight + 1;
			if (%mod != "SOCKET")
				%list = %list @ %mod @ " " @ %multi @ " ";
			// ----------------------------------------------------
			// ARMORS
			if (%newcode == "ARM") %AMRBASE += %multi;
			if (%newcode == "EVV") %EVABASE += %multi;
			if (%newcode == "ARS") %RESBASE += %multi;
			if (%newcode == "INA") %AMRINC += %multi;
			if (%newcode == "INE") %EVAINC += %multi;
			if (%newcode == "IRR") %RESINC += %multi;
			// ----------------------------------------------------
			// WEAPONS
			if (%newcode == "IND") %DMGINC += %multi;
			if (%newcode == "MND") %MINDMG += %multi;
			if (%newcode == "MXD") %MAXDMG += %multi;
			// ----------------------------------------------------
			// SHIELDS
			if (%newcode == "BLK") %BLKADD += %multi;
			if (%newcode == "BLS") %BLSADD += %multi;
			if (%newcode == "BLA") %BLAADD += %multi;
			if (%newcode == "SPA") %SPAADD += %multi;
			// ----------------------------------------------------
			// MAGIC WEAPONS
		}
	}
	%rlist = "";
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	%rmax = 1500;
	// REMOVE ACCESSORY REQUIREMENTS
	for (%i = 1; %i <= 3; %i++) %r[%i] = 0;
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	for (%i = 1; %i <= 3; %i++) {
		if (%r[%i] > 0) {
			%radd = floor(floor(floor((%rmax * %r[%i]) * %perc) * (%ql / 300)) + 0);
			%rlist = %rlist @ $reqdisp[%i] @ " " @ %radd @ " ";
		}
	}
	if (%slot == "Mod")
		%rlist = "";
	//===============================================================================
	// MAIN REQ
	%fixedreq = "";
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	%rmax = 3000;
	//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
	//echo(" SREQ --------> " @ %sreq);
	if (%sreq == "AMR" || %sreq == "LAMR") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[1] @ " " @ %radd @ " ";
		%fixedreq = "1";
	}
	if (%sreq == "MES" || %sreq == "LMES") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[1] @ " " @ %radd @ " ";
		%fixedreq = "1";
	}
	if (%sreq == "EVA" || %sreq == "LEVA") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[2] @ " " @ %radd @ " ";
		%fixedreq = "2";
	}
	if (%sreq == "RES" || %sreq == "LRES") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[3] @ " " @ %radd @ " ";
		%fixedreq = "2";
	}
	if (%sreq == "SPS" || %sreq == "LSPS") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DPerc];
		if (%perc == "" || %perc < 0.75) %perc = 0.75;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ $reqdisp[3] @ " " @ %radd @ " ";
		%fixedreq = "3";
	}
	if (%sreq == "WPN") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DWeaponPerc];
		%wreq = $DynamicItem[%name,$DWeaponReq];
		if (%perc < 1.0) %perc = %perc * 1.2;
		if (%perc > 1.0) %perc = 1.0;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ %wreq @ " " @ %radd @ " ";
	}
	if (%sreq == "STF") {
		%rlist = "";
		%perc = $DynamicItem[%name,$DWeaponPerc];
		%wreq = $DynamicItem[%name,$DWeaponReq];
		if (%perc < 1.0) %perc = %perc * 1.2;
		if (%perc > 1.0) %perc = 1.0;
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ %wreq @ " " @ %radd @ " ";
	}
	if (%sreq == "QUV") {
		%rlist = "";
		%radd = floor(floor(floor((%rmax * 1.0) * %perc) * (%ql / 300)) + 0);
		%rlist = %rlist @ "Archery" @ " " @ %radd @ " ";
	}
	if (%sreq == "LIT") {
		%rlist = "";
		%radd = floor((%rmax * 0.5) * (%ql / 300));
		%rlist = %rlist @ "Literacy" @ " " @ %radd @ " ";
	}
	if (%sreq == "LITMAX") {
		%rlist = "";
		%radd = floor((%rmax * 1.0) * (%ql / 300));
		%rlist = %rlist @ "Literacy" @ " " @ %radd @ " ";
	}
	if (%sreq == "LITSTR") {
		%rlist = "";
		%radd = floor((%rmax * 0.5) * (%ql / 300));
		%rlist = %rlist @ "Literacy" @ " " @ %radd @ " ";
		%rlist = %rlist @ "Strength" @ " " @ %radd @ " ";
	}
	if (%sreq == "LITDEX") {
		%rlist = "";
		%radd = floor((%rmax * 0.5) * (%ql / 300));
		%rlist = %rlist @ "Literacy" @ " " @ %radd @ " ";
		%rlist = %rlist @ "Dexterity" @ " " @ %radd @ " ";
	}
	if (%sreq == "LITINT") {
		%rlist = "";
		%radd = floor((%rmax * 0.5) * (%ql / 300));
		%rlist = %rlist @ "Literacy" @ " " @ %radd @ " ";
		%rlist = %rlist @ "Intelligence" @ " " @ %radd @ " ";
	}
	if (%sreq == "MEMWIS") {
		%rlist = "";
		%radd = floor((%rmax * 0.2) * (%ql / 300));
		%rlist = %rlist @ "Wisdom" @ " " @ %radd @ " ";
	}
	if (%sreq == "FOCUS") {
		%rlist = "";
		%radd = floor((%rmax * 1.0) * (%ql / 300));
		%rlist = %rlist @ "SPELLCAPACITY" @ " " @ %radd @ " ";
	}
	if (%fixedreq != "" && %runelist != "") {
		for (%i = 1; %i <= 3; %i++) %rr[%i] = 0;
		for (%i = 1; %i <= 3; %i++) %rrh[%i] = 0;
		for(%i = 0; (%rune = getWord(%runelist,%i)) != -1; %i++) {
			%mod = $BPMOD[%rune];
			%trp = ($TierReqP[%mod] / 2);
			%treq = $TierReq[%mod];
			if (%trp > %rrh[%treq]) {
				%rr[%treq] = %trp;
				%rrh[%treq] = %trp;
			}
		}
		for (%i = 1; %i <= 3; %i++) {
			if (string::findSubStr(%fixedreq,%i) == -1) {
				if (%rr[%i] > 0) {
					%radd = floor(floor(floor((2300 * %rr[%i]) * %perc) * (%ql / 300)) + 0);
					%rlist = %rlist @ $reqdisp[%i] @ " " @ %radd @ " ";
				}
			}
		}
	}
	//===============================================================================
	// LEVEL REQ
	%lreq = floor(%ql / 2);
	if (%lreq > 230) %lreq = 230;
	if (%slot != "Mod")
		%rlist = %rlist @ "LVLG " @ %lreq;
	//===============================================================================
	// PRICE
	%price = $DynamicItem[%name,$DPrice];
	%pmin = getWord(%price,0);
	%praise = getWord(%price,1);
	%x = $DynamicItem[%name,$DItemType];
	%rare = getWord(%x,0);
	%price = floor((%pmin / 300) * %ql) + 1;
	%price = floor(%price * getRarityPriceIncrease(%rare));
	//===============================================================================
	// WEAPON
	if (%sreq == "WPN") {
		// DAMAGE
		%wperc = (%ql / 300);
		%min = ($DynamicItem[%name,$DWeaponMinDmg] * %wperc);
		%max = ($DynamicItem[%name,$DWeaponMaxDmg] * %wperc);
		%perc = (%tperc / 100) + 1;
		%min += %MINDMG;
		%max += %MAXDMG;
		%min = round(%min * %perc);
		%max = round(%max * %perc);
		%maxcap = MaxCap(%DMGINC,300);
		%min = round(%min * (1 + (%maxcap / 100)));
		%max = round(%max * (1 + (%maxcap / 100)));
		%delay = $DynamicItem[%name,$DWeaponDelay];
		if (%delay == 1) { %mindmgx = 1; %maxdmgx = 5; }
		if (%delay == 2) { %mindmgx = 2; %maxdmgx = 10; }
		if (%delay == 3) { %mindmgx = 3; %maxdmgx = 15; }
		%min = %min + %mindmgx;
		%max = %max + %maxdmgx;
		if (%min < 1) %min = 1;
		if (%max < 5) %max = 5;
		if (%min > %max)
			%max = %min;
		$BPItem[%new,$BPDamage] = %min @ " - " @ %max;
		$BPItem[%new,$BPWeaponCritChance] = $DynamicItem[%name,$DWeaponCritChance];
		$BPItem[%new,$BPWeaponCritDamage] = $DynamicItem[%name,$DWeaponCritDamage];
		if (%dd != "")
			$BPItem[%new,$BPDamageType] = %dd;
		else
			$BPItem[%new,$BPDamageType] = $DynamicItem[%name,$DDamageType];
		$BPItem[%new,$BPATKSkills] = $DynamicItem[%name,$DATKSkills];
		$BPItem[%new,$BPDEFSkills] = $DynamicItem[%name,$DDEFSkills];
		$BPItem[%new,$BPWeaponDelay] = $DynamicItem[%name,$DWeaponDelay];
		$BPItem[%new,$BPWeaponTwoHand] = $DynamicItem[%name,$DWeaponTwoHand];
	}
	//===============================================================================
	// MAGICWEAPON
	if (%sreq == "STF") {
		%wperc = (%ql / 300);
		%perc = (%tperc / 100) + 1;
		%mag = round($DynamicItem[%name,$DWeaponMagDmg] * %wperc);
		$BPItem[%new,$BPWeaponMagDamage] = round(%mag * %perc);
		$BPItem[%new,$BPWeaponCritChance] = $DynamicItem[%name,$DWeaponCritChance];
		$BPItem[%new,$BPWeaponCritDamage] = $DynamicItem[%name,$DWeaponCritDamage];
		$BPItem[%new,$BPATKSkills] = $DynamicItem[%name,$DATKSkills];
		$BPItem[%new,$BPDEFSkills] = $DynamicItem[%name,$DDEFSkills];
		$BPItem[%new,$BPWeaponTwoHand] = $DynamicItem[%name,$DWeaponTwoHand];
	}
	//===============================================================================
	// IMPLICIT
	%implicit = "";
	%crop = %main;
	if (string::getSubStr(%crop,9,3) == "") {
		%mod = string::getSubStr(%crop,0,3);
		%val = string::getSubStr(%crop,3,6);
		if (%mod != "NON") {
			%val = %val + 0;
			if (%mod == "ARM") %val = round((%val + %AMRBASE) * (1 + (MaxCap(%AMRINC,300) / 100)));
			if (%mod == "EVV") %val = round((%val + %EVABASE) * (1 + (MaxCap(%EVAINC,300) / 100)));
			if (%mod == "ARS") %val = round((%val + %RESBASE) * (1 + (MaxCap(%RESINC,300) / 100)));
			if (string::findsubstr($ACCESSORY_IMPLICIT_LIST,%mod) != -1) {
					%val = GetAccessoryImplicit(%mod,%ql);
			}
			else {
				%val = floor(%val * (1 + (%tperc / 100)));
			}
			%mod = $BPMOD[%mod];
			%implicit = %mod @ " " @ (%val+1);
		}
	}
	else {
		%start = 0;
		for (%i = 1; %i <= 30; %i++) {
			%s[%i] = string::GetSubStr(%crop,%start,9);
			%start += 9;
		}
		for (%i = 1; %i <= 30; %i++) {
			if ((%crop = %s[%i]) != "") {
				%mod = string::getSubStr(%crop,0,3);
				%val = string::getSubStr(%crop,3,6);
				%val = %val + 0;
				if (%mod != "NON") {
					if (%mod == "ARM") %val = round((%val + %AMRBASE) * (1 + (MaxCap(%AMRINC,300) / 100)));
					if (%mod == "ARS") %val = round((%val + %RESBASE) * (1 + (MaxCap(%RESINC,300) / 100)));
					if (%mod == "BLK") %val = round(%val + %BLKADD);
					if (%mod == "BLS") %val = round(%val + %BLSADD);
					if (%mod == "BLA") %val = round(%val + %BLAADD);
					if (%mod == "SPA") %val = round(%val + %SPAADD);
					%implicit = %implicit @ $BPMOD[%mod] @ " " @ %val @ " ";
				}
			}
		}
	}
	//===============================================================================
	// VISUAL
	if ((%vis = $DynamicItem[%name,$DVis]) != "") {
		$BPItem[%new,$BPVis] = %vis;
		%visslot = $DynamicItem[%name,$DVisSlot];
		//echo("NAME " @ %name @ " VIS:" @ %vis @ " VISSLOT:" @ %visslot @ " NEW:"@%new);
		$BPItem[%new,$BPVisSlot] = $DynamicItem[%name,$DVisSlot];
		$BPItem[%new,$BPVisType] = $DynamicItem[%name,$DVisType];
	}
	//===============================================================================
	if ($DynamicItem[%name,$DShowQLInName] == "")
		$BPItem[%new,$BPName] = $DynamicItem[%name,$DName];
	else
		$BPItem[%new,$BPName] = $DynamicItem[%name,$DName] @ " [" @ %ql @ "]";
	$BPItem[%new,$BPWeight] = %weight;
	$BPItem[%new,$BPPrice] = %price;
	//echo(" SLOT " @ %slot);
	$BPItem[%new,$BPWield] = "LOCATION " @ $TierLoc[%slot] @ " " @ %rlist;
	$BPItem[%new,$BPWieldBonus] = %list;
	$BPItem[%new,$BPDesc] = $DynamicItem[%name,$DDesc];
	$BPItem[%new,$BPItemType] = $DynamicItem[%name,$DItemType];
	$BPItem[%new,$BPIntegrity] = %tperc;
	//$BPItem[%new,$BPTierPerc] = %tperc;
	$BPItem[%new,$BPBaseItem] = $DynamicItem[%name,$DBaseItem];
	$BPItem[%new,$BPArmorHitSound] = $DynamicItem[%name,$DAHS];
	$BPItem[%new,$BPRanged] = $DynamicItem[%name,$DRanged];
	$BPItem[%new,$BPIsMagWeapon] = $DynamicItem[%name,$DIsMagWeapon];
	$BPItem[%new,$BPBlockType] = $DynamicItem[%name,$DBlockType];
	if (%implicit != "")
		$BPItem[%new,$BPImplicit] = %implicit;
	if ($DynamicItem[%name,$DIco] != "")
		$BPItem[%new,$BPIco] = $DynamicItem[%name,$DIco];
	if ($DynamicItem[%name,$DSet] != "")
		$BPItem[%new,$BPSet] = $DynamicItem[%name,$DSet];
	if (%sockets > 0)
		$BPItem[%new,$BPNumSockets] = %sockets;
	if ($DynamicItem[%name,$DMaterial] != "")
		$BPItem[%new,$BPMaterial] = $DynamicItem[%name,$DMaterial];
	if ($DynamicItem[%name,$DIsQuiver] == 1)
		$BPItem[%new,$BPIsQuiver] = 1;
	if ($DynamicItem[%name,$DNoDropFlag] == 1)
		$NoDropItem[%new] = 1;
	if ($DynamicItem[%name,$DIsBelt] == 1) {
		$BPItem[%new,$BPIsBelt] = 1;
		$BPItem[%new,$BPPockets] = DynamicItem::GetPockets(%ql);
	}
}

function DynamicItem::GetPockets(%ql)
{
	if (%ql <= 50) return 3;
	if (%ql <= 100) return 4;
	if (%ql <= 150) return 5;
	return 6;
}

function DynamicItem::GetItem(%var)
{
	return String::GetSubStr(%var,3,999);
}

function DynamicItem::GetQuality(%var)
{
	return String::GetSubStr(%var,0,3);
}

function DynamicItem::GetQualityDisp(%var)
{
	return (String::GetSubStr(%var,0,3) + 0);
}

function DynamicItem::IsDynamic(%item)
{
	if ((%new = string::FindSubStr(%item,"^")) != -1) {
		%find = string::FindSubStr(%new,"^");
		%type = string::GetSubStr(%new,3,(%find-3));
		if ($DynamicItem[%type,$DName] != "")
			return true;
	}
	if ((%new = string::FindSubStr(%item,"&")) != -1) {
		%find = string::FindSubStr(%new,"&");
		%type = string::GetSubStr(%new,3,(%find-3));
		if ($DynamicItem[%type,$DName] != "")
			return true;
	}
	if ($DynamicItem[%item,$DName] != "")
		return True;
	else
		return False;
}

function DynamicItem::ItemExists(%item)
{
	if ($BPItem[%item,$BPName] == 0) {
		return False;
	}
	else
		return True;
}

function DynamicItem::InitWear(%item)
{

	//echo (" >> INIT WEAR TRIGGERED " @ %item);
	%ql = DynamicItem::GetQuality(%item);
	%crop = DynamicItem::GetItem(%item);
	if (string::FindSubStr(%item,"Plan*") != -1) {
		Plan::Create(%item,-1,True);
		return;
	}
	if (string::FindSubStr(%item,"#") != -1) {
		Rune::Create(%item);
		return;
	}
	if (string::FindSubStr(%item,"!") != -1) {
		TierItem::CreateMap(%item);
		return;
	}
	if (string::FindSubStr(%item,"^") != -1) {
		TierItem::Create(%item,-1);
		return;
	}
	if (DynamicItem::ItemExists(%ql @ "" @ %crop)) {
		return;
	}
	if (DynamicItem::IsDynamic(%crop) == True) {
		if (DynamicItem::IsValidQL(%crop,%ql) == True) {
			DynamicItem::Create(%crop,(%ql * 1.0));
		}
	}
}

function DynamicItem::InitCreate(%id)
{
	%bp = $PlayerBackpack[%id];
	for (%i = 0; (%item = getWord(%bp,%i)) != -1; %i += 2)
		DynamicItem::InitWear(%item);
	%belt = $PlayerBelt[%id];
	for (%i = 0; (%item = getWord(%belt,%i)) != -1; %i += 2)
		DynamicItem::InitWear(%item);
	%storage = $BackpackStorage[%id,1];
	for (%i = 0; (%item = getWord(%storage,%i)) != -1; %i += 2)
		DynamicItem::InitWear(%item);
	%storage = $BackpackStorage[%id,2];
	for (%i = 0; (%item = getWord(%storage,%i)) != -1; %i += 2)
		DynamicItem::InitWear(%item);
	%storage = $BackpackStorage[%id,3];
	for (%i = 0; (%item = getWord(%storage,%i)) != -1; %i += 2)
		DynamicItem::InitWear(%item);
	%storage = $BackpackStorage[%id,4];
	for (%i = 0; (%item = getWord(%storage,%i)) != -1; %i += 2)
		DynamicItem::InitWear(%item);
	%storage = $BackpackStorage[%id,5];
	for (%i = 0; (%item = getWord(%storage,%i)) != -1; %i += 2)
		DynamicItem::InitWear(%item);
}

function DynamicItem::CheckItemCreate(%item,%ql)
{
	if (DynamicItem::ItemExists(%ql @ "" @ %item))
		return;
	if (DynamicItem::IsDynamic(%item) == False) {
		return;
	}
	if (DynamicItem::IsValidQL(%item,%ql) == False) {
		return;
	}
	DynamicItem::Create(%item,(%ql * 1.0));
}

function IsNumeric(%string)
{
	for (%i=0; (%letter = String::getSubStr(%string, %i, 1)) != ""; %i++)
	{
		%b = (%letter + 1 - 1);
		if(String::ICompare(%b, %letter) != 0)
			return False;
	}
	return True;
}

function DynamicItem::IsValidQL(%item,%ql)
{
	%s = $DynamicItem[%item,$DMinMax];
	if (IsNumeric(%ql) == False)
		return False;
	if (%ql < getWord(%s,0))
		return False;
	if (%ql > getWord(%s,1))
		return False;
	return True;
}

$DynamicItemUniqueId = 1001;

function DynamicItem::Create(%item,%quality)
{
	%q = %quality;
	if (%q < 100)
		%q = "0" @ %quality;
	if (%q < 10)
		%q = "00" @ %quality;
	%full = %q @ "" @ %item;

	//$BPItem[%full,$BPName] = $DynamicItem[%item,$DName] @ "[" @ %quality @ "]";

	// CREATE NAME ------------------------------------------
	%max = GetWord($DynamicItem[%item,$DMinMax],1);
	%nr = $DynamicItem[%item,$DNameRange];
	if (%nr != "") {
		%p = %quality;
		%nn = "";
		for (%a = 0; (%range = getWord(%nr,%a)) != -1; %a += 2) {
			if (%p >= %range)
				%nn = getWord(%nr,%a + 1);
		}
		if ($DynamicItem[%item,$DSpecialAdd] != "")
			$BPItem[%full,$BPName] = %nn @ " " @ $DynamicItem[%item,$DName] @ $DynamicItem[%item,$DSpecialAdd];
		else
			$BPItem[%full,$BPName] = %nn @ " " @ $DynamicItem[%item,$DName];
	}
	else {
		//echo(" DSHOWQLINNAME " @ $DynamicItem[%item,$DShowQLInName]);
		if ($DynamicItem[%item,$DShowQLInName] == "")
			$BPItem[%full,$BPName] = $DynamicItem[%item,$DName];
		else
			$BPItem[%full,$BPName] = $DynamicItem[%item,$DName] @ " [" @ %quality @ "]";
	}

	// PRICE ------------------------------------------
	%v = $DynamicItem[%item,$DPrice];
	if (%quality != 999) {
		%n = getWord(%v,0) + (getWord(%v,1) * %quality);
        	%n = floor(%n + 1);
		$BPItem[%full,$BPPrice] = %n;
	}
	else {
		%n = getWord(%v,0);
		$BPItem[%full,$BPPrice] = %n;
	}

	// WEIGHT ------------------------------------------
	%v = $DynamicItem[%item,$DWeight];
	%n = getWord(%v,0) + (getWord(%v,1) * %quality);
	$BPItem[%full,$BPWeight] = %n;

	// WIELD ------------------------------------------
	%v = $DynamicItem[%item,$DWield];
	if (%v != "") {
		%n = "";
		for (%i = 0; (%m = getWord(%v,%i)) != -1; %i += 3) {
			%val = getWord(%v,%i + 1);
			%multi = getWord(%v,%i + 2);
			if (%m == "LOCATION" || %m == "CLASS" || %m == "GROUP")
				%n = %n @ %m @ " " @ %val @ " ";
			else {
				%this = floor(%val + (%quality * %multi));
				%n = %n @ %m @ " " @ %this @ " ";
			}
		}
		%len = (string::Len(%n) - 1);
		%n = string::GetSubStr(%n,0,%len);
		$BPItem[%full,$BPWield] = %n;
	}

	// WIELD BONUS ------------------------------------------
	%v = $DynamicItem[%item,$DWieldBonus];
	if (%v != "") {
		%n = "";
		for (%i = 0; (%m = getWord(%v,%i)) != -1; %i += 3) {
			%val = getWord(%v,%i + 1);
			%multi = getWord(%v,%i + 2);
			%this = floor(%val + (%quality * %multi));
			%n = %n @ %m @ " " @ %this @ " ";
		}
		%len = (string::Len(%n) - 1);
		%n = string::GetSubStr(%n,0,%len);
		$BPItem[%full,$BPWieldBonus] = %n;
	}

	// DAMAGE ------------------------------------------------
	%v = $DynamicItem[%item,$DDamage];
	if (%v != "") {
		%n = "";
		%val = getWord(%v,0);
		%multi = getWord(%v,1);
		%this = floor(%val + (%quality * %multi));
		%n = %this @ " - ";
		%val = getWord(%v,2);
		%multi = getWord(%v,3);
		%this = floor(%val + (%quality * %multi));
		%n = %n @ %this;
		$BPItem[%full,$BPDamage] = %n;
	}

	// ATK / DEF SKILLS ---------------------------------------
	%v = $DynamicItem[%item,$DATKSkills];
	if (%v != "")
		$BPItem[%full,$BPATKSkills] = %v;

	%v = $DynamicItem[%item,$DDEFSkills];
	if (%v != "")
		$BPItem[%full,$BPDEFSkills] = %v;

	// USE ------------------------------------------
	%v = $DynamicItem[%item,$DUse];
	if (%v != "") {
		%n = "";
		for (%i = 0; (%m = getWord(%v,%i)) != -1; %i += 3) {
			%val = getWord(%v,%i + 1);
			%multi = getWord(%v,%i + 2);
			if (%m == "LOCATION" || %m == "CLASS" || %m == "GROUP" || %m == "LOADPROJECTILE" || %m == "SKILLUNLOCK" || %m == "ACTIONUNLOCKED")
				%n = %n @ %m @ " " @ %val @ " ";
			else {
				%this = floor(%val + (%quality * %multi));
				%n = %n @ %m @ " " @ %this @ " ";
			}
		}
		%len = (string::Len(%n) - 1);
		%n = string::GetSubStr(%n,0,%len);
		$BPItem[%full,$BPUse] = %n;
	}

	// USE BONUS ------------------------------------------
	%v = $DynamicItem[%item,$DUseBonus];
	if (%v != "") {
		%n = "";
		for (%i = 0; (%m = getWord(%v,%i)) != -1; %i += 3) {
			%val = getWord(%v,%i + 1);
			%multi = getWord(%v,%i + 2);
			if (%m == "LOCKSKILL" || %m == "DURATION" || %m == "ACTION")
				%n = %n @ %m @ " " @ %val @ " ";
			else {
				%this = floor(%val + (%quality * %multi));
				%n = %n @ %m @ " " @ %this @ " ";
			}
		}
		%len = (string::Len(%n) - 1);
		%n = string::GetSubStr(%n,0,%len);
		$BPItem[%full,$BPUseBonus] = %n;
	}

	// HARDCODED ATK -----------------------------------------
	%v = $DynamicItem[%item,$DATK];
	if (%v != "") {
		%val = getWord(%v,0);
		%multi = getWord(%v,1);
		%this = floor(%val + (%quality * %multi));
		$BPItem[%full,$BPATK] = %this;
	}

	// EXTRAS
	%v = $DynamicItem[%item,$DRanged];
	if (%v != "")
		$BPItem[%full,$BPRanged] = %v;
	%v = $DynamicItem[%item,$DProjectile];
	if (%v != "")
		$BPItem[%full,$BPProjectile] = %v;
	if ($DynamicItem[%item,$DVisType] != "") {
		$BPItem[%full,$BPVisType] = $DynamicItem[%item,$DVisType];
		$BPItem[%full,$BPVis] =	$DynamicItem[%item,$DVis];
		$BPItem[%full,$BPVisSlot] = $DynamicItem[%item,$DVisSlot];
	}
	if ($DynamicItem[%item,$DRobed] == 1)
		$ArmorPlayerModel[%full] = "Robed";
	if ($DynamicItem[%item,$DIco] != "") {
		$BPItem[%full,$BPIco] = $DynamicItem[%item,$DIco];
	}
	if ($DynamicItem[%item,$DDeleteOnUse] == 1) {
		$BPItem[%full,$BPDeleteOnUse] = 1;
	}
	$BPItem[%full,$BPDesc] = $DynamicItem[%item,$DDesc];
	if ($DynamicItem[%item,$DDamageType] != "")
		$BPItem[%full,$BPDamageType] = $DynamicItem[%item,$DDamageType];

	%v = $DynamicItem[%item,$DMBS];
	if (%v != "") {
		%val = getWord(%v,0);
		%multi = getWord(%v,1);
		%this = floor(%val + (%quality * %multi));
		$BPItem[%full,$BPMBS] = %this;
	}

	%v = $DynamicItem[%item,$DItemType];
	if (%v != "") $BPItem[%full,$BPItemType] = %v;

	%v = $DynamicItem[%item,$DTierProp];
	if (%v != "") $BPItem[%full,$BPTierProp] = %v;

	%v = $DynamicItem[%item,$DTierHard];
	if (%v != "") $BPItem[%full,$BPTierHard] = %v;

	%v = $DynamicItem[%item,$DTierPerc];
	if (%v != "") $BPItem[%full,$BPTierPerc] = %v;

	%v = $DynamicItem[%item,$DSet];
	if (%v != "") $BPItem[%full,$BPSet] = %v;

	%v = $DynamicItem[%item,$DCraftType];
	if (%v != "") $BPItem[%full,$BPCraftType] = %v;

	%v = $DynamicItem[%item,$DBaseItem];
	if (%v != "") $BPItem[%full,$BPBaseItem] = %v;

	%v = $DynamicItem[%item,$DRune];
	if (%v != "") $BPItem[%full,$BPRune] = %v;

	%v = $DynamicItem[%item,$DRuneReq];
	if (%v != "") $BPItem[%full,$BPRuneReq] = %v;

	%v = $DynamicItem[%item,$DRuneBonus];
	if (%v != "") $BPItem[%full,$BPRuneBonus] = %v;

	//%v = $DynamicItem[%item,$DCritChance];
	//if (%v != "") $BPItem[%full,$BPCritChance] = %v;

	//%v = $DynamicItem[%item,$DCritDamage];
	//if (%v != "") $BPItem[%full,$BPCritDamage] = %v;

	%v = $DynamicItem[%item,$DWeaponDelay];
	if (%v != "") $BPItem[%full,$BPWeaponDelay] = %v;

	%v = $DynamicItem[%item,$DWeaponTwoHand];
	if (%v != "") $BPItem[%full,$BPWeaponTwoHand] = %v;

	%v = $DynamicItem[%item,$DMaterial];
	if (%v != "") $BPItem[%full,$BPMaterial] = %v;

	%v = $DynamicItem[%item,$DBlockChance];
	if (%v != "") $BPItem[%full,$BPBlockChance] = %v;

	%v = $DynamicItem[%item,$DBlockAmount];
	if (%v != "") $BPItem[%full,$BPBlockAmount] = %v;

	%v = $DynamicItem[%item,$DBlockType];
	if (%v != "") $BPItem[%full,$BPBlockType] = %v;

	%v = $DynamicItem[%item,$DAHS];
	if (%v != "") $BPItem[%full,$BPArmorHitSound] = %v;

	%v = $DynamicItem[%item,$DPerc];
	if (%v != "") $BPItem[%full,$BPPerc] = %v;

	%v = $DynamicItem[%item,$DIsMagWeapon];
	if (%v != "") $BPItem[%full,$BPIsMagWeapon] = %v;

	%v = $DynamicItem[%item,$DIsQuiver];
	if (%v != "") $BPItem[%full,$BPIsQuiver] = %v;

	%v = $DynamicItem[%item,$DQuiverDamage];
	if (%v != "") $BPItem[%full,$BPQuiverDamage] = %v;

	%v = $DynamicItem[%item,$DDamageStone];
	if (%v != "") $BPItem[%full,$BPDamageStone] = %v;

	%unique = $DynamicItemUniqueId;
	$BPItem[%full,999] = %unique;
	$BPUnique[%unique] = %full;
	$DynamicItemUniqueId += 1;

	return %full;
}

//=====================================================================================================================================================

$DynamicItem[HealthPotion,$DName] = "Health Potion";
$DynamicItem[HealthPotion,$DIco] = "";
$DynamicItem[HealthPotion,$DMinMax] = "999 999";
$DynamicItem[HealthPotion,$DWeight] = "1 0";
$DynamicItem[HealthPotion,$DPrice] = "2 0";
$DynamicItem[HealthPotion,$DUse] = "SKILLUNLOCK Healing NA";
$DynamicItem[HealthPotion,$DUseBonus] = "SETHEAL 1 NA DURATION 60 NA LOCKSKILL Healing NA";
$DynamicItem[HealthPotion,$DDesc] = "A small potion that will restore your health.";
$DynamicItem[HealthPotion,$DDeleteOnUse] = 1;
$DynamicItem[HealthPotion,$DIco] = "ico_healthpotion.bmp";

$DynamicItem[EnergyVial,$DName] = "Energy Vial";
$DynamicItem[EnergyVial,$DIco] = "";
$DynamicItem[EnergyVial,$DMinMax] = "999 999";
$DynamicItem[EnergyVial,$DWeight] = "1 0";
$DynamicItem[EnergyVial,$DPrice] = "2 0";
$DynamicItem[EnergyVial,$DUse] = "SKILLUNLOCK Energy NA";
$DynamicItem[EnergyVial,$DUseBonus] = "ENERGYVIAL 1 NA DURATION 60 NA LOCKSKILL Energy NA";
$DynamicItem[EnergyVial,$DDesc] = "A small energy vial that will restore your mana.";
$DynamicItem[EnergyVial,$DDeleteOnUse] = 1;
$DynamicItem[EnergyVial,$DIco] = "ico_energyvial.bmp";

$DynamicItem[ForestKeyFragmentA,$DName] = "Forest Keystone Fragment #1";
$DynamicItem[ForestKeyFragmentA,$DIco] = "";
$DynamicItem[ForestKeyFragmentA,$DMinMax] = "999 999";
$DynamicItem[ForestKeyFragmentA,$DWeight] = "1 0";
$DynamicItem[ForestKeyFragmentA,$DPrice] = "1 0";
$DynamicItem[ForestKeyFragmentA,$DDesc] = "This looks like a piece to some sort of key..";

//=====================================================================================================================================================

// PLUGINS

exec("backpack_craft.cs");
exec("tier_tradeitems.cs");
exec("backpack_plans.cs");
//exec("tier_setitems.cs");
exec("tier_basicitems.cs");
exec("tier_basicweapons.cs");
//exec("backpack_modifiers.cs");
exec("dev_items.cs");
exec("backpack_relic.cs");
exec("backpack_sets.cs");
exec("backpack_uniques.cs");
exec("backpack_maps.cs");
exec("backpack_npc.cs");
exec("backpack_merchant.cs");
exec("backpack_music.cs");
exec("backpack_treasure.cs");
exec("backpack_mm.cs");

echo("__BACKPACK LOADED");
