// LOOT 

$HARDMF = 0;

function TestMT(%i)
{
	%lowest = 1;
	%highest = 0;
	for (%v = 0; %v <= %i; %v++) {
		%r = GetRandomMT() * 1.0;
		if (%r < %lowest) %lowest = %r;
		if (%r > %highest) %highest = %r;
	}
	echo(" LOWEST " @ %lowest);
	echo(" HIGHEST " @ %highest);			
}

function GetMagicFind(%id)
{
	if ((%aiowner = $CruAI[%id,$AiOwner]) != "")
		%id = %aiowner;
	return $MagicFind[%id];
}

function GetGoldFind(%id)
{
	if ((%aiowner = $CruAI[%id,$AiOwner]) != "")
		%id = %aiowner; 
	return $GoldFind[%id];
}

function RefreshMagicFind(%id,%gold)
{
	if (%gold != True)
		%list = $MagicFindList[%id];
	else
		%list = $GoldFindList[%id];
	if (%list == "") {
		if (%gold != True)
			$MagicFindList[%id] = "0 0 0 0 0 0 0 0 0 0";
		else
			$GoldFindList[%id] = "0 0 0 0 0 0 0 0 0 0";
	}
	%t = 0;
	for (%i = 0; %i <= 9; %i++)
		%t += getWord(%list,%i);
	if (%gold != True)
		$MagicFind[%id] = Cap(round(%t/10),0,1000);
	else
		$GoldFind[%id] = Cap(round(%t/10),0,1000);
}

function UpdateMagicFind(%id,%gold)
{
	if (%gold != True)
		%list = $MagicFindList[%id];
	else
		%list = $GoldFindList[%id];
	%newlist = "";
	if (%gold != True)
		%mf = GetBonus(%id,$BPMAGICFIND);
	else
		%mf = GetBonus(%id,$BPGOLDFIND);
	//=======================================================================
	// Add in sense heading bonus
	%skill = GetPlayerSkill(%id,$SkillSenseHeading);
	%mf += round(%skill/10);
	//=======================================================================
	for (%i = 1; %i <= 9; %i++)
		%newlist = %newlist @ getWord(%list,%i) @ " ";
	%newlist = %newlist @ %mf;
	if (%gold != True)
		$MagicFindList[%id] = %newlist;
	else
		$GoldFindList[%id] = %newlist;
	RefreshMagicFind(%id,%gold);
}

function UpdateMonsterFind(%aiId,%id,%damage)
{
	//echo(" UPDATE MONSTER FIND " @ %aiId @ " " @%id @ " " @ %damage);
	%ailvl = fetchData(%aiId,"LVL");
	%idlvl = fetchData(%id,"LVL") + fetchData(%id,"ALVL");
	%mod = %ailvl / %idlvl;
	if (%mod > 1.5) %mod = 1.5;
	if (%mod < 0.5) %mod = 0.5;
	%maxhp = fetchData(%aiId,"MaxHP");
	%curhp = fetchData(%aiId,"HP");
	if (%damage >= %curhp) %damage = %curhp;
	%p = Cap((%damage / %maxhp),0,1);
	%mf = GetMagicFind(%id);
	%zone = $CRUSPAWNZONE[%aiId];
	%mapmagic = $CRUZONE[%zone,$CZMapMagic];
	if ($ELITE[%aiId]) %mf += 100;
	if ($BOSS[%aiId]) %mf += 300;
	%mf += %mapmagic;
	$MonsterMagic[%aiId] += round((%mf * %mod) * %p);
	%gf = GetGoldFind(%id);
	if ($ELITE[%aiId]) %gf += 100;
	if ($BOSS[%aiId]) %gf += 300;
	%gf += %mapmagic;
	$MonsterGold[%aiId] += round((%gf * %mod) * %p);	
}

function Loot::Overall(%n,%mf,%lvl)
{
	echo("=============================================================");
	echo(" LOOT::OVERALL " @ %n @ " " @ %mf);
	%mf = 1 + (%mf / 100);
	%looton = 0;
	if (%lvl == "" || %lvl < 1) %lvl = 1;
	for (%i = 0; %i <= %n; %i++)
		%loot[%i] = Loot::DetermineLoot(0,%mf,%lvl);
	for (%i = 0; %i <= %n; %i++)
		if (%loot[%i] != "") echo(%loot[%i]);
	echo("=============================================================");
}

function Loot::DetermineLoot(%id,%mf,%lvl,%f,%upper)
{
	%loot = "";
	%count = Loot::GrabLootCount(%mf);
	if (%count > 0) {
		for (%i = 1; %i <= %count; %i++) {
			%add = Loot::GrabLoot(%mf,%lvl,%f,"",%upper);
			if (%add != "-1")
				%loot = %loot @ %add @ " 1 ";
		}
	}
	return %loot;
}

function Loot::Ratio(%n,%x,%mf,%m)
{
	if (%mf<1) %mf = 1;
	%x = round(%x/%mf);
	if (%x<1) %x = 1;
	if (%m && %x<%m) %x = %m;
	%r = MTRB(1,%x);
	if (%r == 1)
		return True;
	else
		return False;
}

function GetLootCoins(%lvl,%id)
{
	%m = round(100 * (%lvl / 300));
	%gold = $MonsterGold[%id];
	if (%gold < 0) %gold = 0;
	%m = round(%m * (1 + MaxCap(%gold,1000) / 100));
	return RandBetween(1,%m);
}

function CreateMerchantLoot(%merchant,%type,%count,%mf,%min,%max)
{
	%loot = "";
	if (%type == "weapon") {
		%w = TierItem::RandomItem("CorrodedSword",1) @ " 1 ";
		%loot = %loot @ %w;
		%w = TierItem::RandomItem("CorrodedSpike",1) @ " 1 ";
		%loot = %loot @ %w;
		%w = TierItem::RandomItem("TwigWand",1) @ " 1 ";
		%loot = %loot @ %w;
		%w = TierItem::RandomItem("DriftwoodMace",1) @ " 1 ";
		%loot = %loot @ %w;
		%w = TierItem::RandomItem("PineBow",1) @ " 1 ";
		%loot = %loot @ %w;
		%w = TierItem::RandomItem("OldwoodStaff",1) @ " 1 ";
		%loot = %loot @ %w;
	}
	%mf = 1 + (%mf / 100);
	for (%i = 1; %i <= %count; %i++) {
		%lvl = RandBetween(%min,%max);
		%r = MTRB(1,320);
		if (%r <= 320) %tier = 0;
		if (%r <= 160) %tier = 1;
		if (%r <= 80) %tier = 2;
		if (%r <= 40) %tier = 3;
		if (%r <= 20) %tier = 4;
		if (%r <= 10) %tier = 5;
		if (%r == 1) %tier = 6;
		if (%type == "weapon") {
			%loot = %loot @ Loot::Weapon(%tier,%mf,%lvl) @ " 1 ";
		}
		if (%type == "spell")
			%loot = %loot @ Loot::Spell(%lvl) @ " 1 ";
		if (%type == "armor") {
			%armor = Loot::Armor(%tier,%mf);
			%armor = TierItem::RandomItem(%armor,%lvl);
			%loot = %loot @ %armor @ " 1 ";
		}
		if (%type == "plan") {
			if (%tier < 1) %tier = 1;
			%plan = Loot::Plan(%tier,%lvl);
			%loot = %loot @ %plan @ " 1 ";
		}
	}
	//echo(" LOOT " @ %loot);
	$BPMerchantShop[%merchant] = %loot;
}

function CreateLoot(%id,%mf,%n,%lvl,%f,%merchant,%upper)
{
	//echo(" CREATELOOT ID:" @ %id @ " MF:" @ %mf @ " N:" @ %n @ " LVL:" @ %lvl @ " F:" @ %f @ " MERCHANT:" @ %merchant @ " UPPER:" @ %upper);
	if (%lvl == "") %lvl = 100;
	if (%f == "") %f = 0.1;
	%loot = "";
	%mf = ((1 + $HARDMF) + (%mf / 100));
	if (%n == "") %n = 0;
	for (%i = 0; %i <= %n; %i++)
		%loot = %loot @ Loot::DetermineLoot(0,%mf,%lvl,%f,%upper);
	if (%merchant == "")
		$PlayerBackpack[%id] = %loot;
	else {
		if ($BPItem["999HealthPotion",$BPName] == "") {
			DynamicItem::InitWear("999HealthPotion");
			DynamicItem::InitWear("999EnergyVial");
			DynamicItem::InitWear("999PortalScroll");
		}
		%loot = "999HealthPotion 1 999EnergyVial 1 999PortalScroll 1 " @ %loot;
		$BPMerchantShop[%merchant] = %loot;
	}
}

function Loot::GrabLootCount(%mf)
{
	%count = 0;
	if (Loot::Ratio(1,2,%mf) == True) %count = 1;
	if (Loot::Ratio(1,4,%mf) == True) %count = 2;
	if (Loot::Ratio(1,8,%mf) == True) %count = 3;
	if (Loot::Ratio(1,16,%mf) == True) %count = 4;
	if (Loot::Ratio(1,32,%mf) == True) %count = 5;
	if (%count > 0)
		return MTRB(1,%count);
	else
		return 0;
}

function Loot::GrabLoot(%mf,%lvl,%f,%hard,%upper)
{
	//echo(" LOOT::GRABLOOT MF:" @ %mf @ " LVL:" @ %lvl @ " F:" @ %f @ " HARD:" @ %hard @ " UPPER:" @ %upper);
	%tier = Loot::GrabTier(%mf);
	%type = Loot::GrabType(%mf);
	%ql = Loot::GrabQL(%lvl,%f,%upper);
	if (%hard != "") {
		%ql = %hard;
		%lvl = %ql;
	}
	if (%type == "BODY") {
		if (%tier >= 0 && %tier <= 6) {
			%i = Loot::Body(%tier,%mf);
			//echo(" LOOT BODY " @ %i);
			return TierItem::RandomItem(%i,%ql);
		}
	}
	if (%type == "MAGIC") {
		if (%tier >= 0 && %tier <= 6) {
			%i = Loot::Magic(%tier,%mf);
			//echo(" LOOT MAGIC " @ %i);
			return TierItem::RandomItem(%i,%ql);
		}
	}
	if (%type == "SPELL") {
		return Loot::Spell(%lvl);
	}
	if (%type == "WEAPON") {
		if (%tier >= 0 && %tier <= 6) {
			//echo(" LOOT WEAPON " @ %i);
			return Loot::Weapon(%tier,%mf,%ql);
		}
	}
	if (%type == "EXTRA") {
		%d = MTRB(1,3);
		if (%d == 1) {
			if (%tier >= 0 && %tier <= 6) {
				%i = Loot::Armor(%tier,%mf);
				//echo(" LOOT ARMOR " @ %i);
				return TierItem::RandomItem(%i,%ql);
			}
		}
		else if (%d == 2) {
			if (%tier >= 0 && %tier <= 6) {
				%i = Loot::Shield(%tier,%mf);
				//echo(" LOOT SHIELD " @ %i);
				return TierItem::RandomItem(%i,%ql);
			}
		}
		else if (%d == 3) {
			//echo(" LOOT BELT ");
			return Loot::Belt(%ql);
		}
	}
	if (%type == "RUNE") {
		return Loot::Rune(%mf,%ql);
	}
	if (%type == "MAP") {
		return Loot::Map(%tier,%ql);
	}
	if (%type == "RELIC") {
		return Loot::Relic(%tier);
	}
	if (%type == "PLAN") {
		return Loot::Plan(%tier,%ql);
	}
	return "-1";
	return %tier @ %type;
}

$GrabTypeSet[0] = "BODY";
$GrabTypeSet[1] = "BODY EXTRA";
$GrabTypeSet[2] = "BODY EXTRA MAGIC";
$GrabTypeSet[3] = "BODY EXTRA MAGIC SPELL";
$GrabTypeSet[4] = "BODY EXTRA MAGIC SPELL WEAPON PLAN";
$GrabTypeSet[5] = "BODY EXTRA MAGIC SPELL WEAPON PLAN RELIC";
$GrabTypeSet[6] = "BODY EXTRA MAGIC SPELL WEAPON PLAN RELIC RUNE";
$GrabTypeSet[7] = "BODY EXTRA MAGIC SPELL WEAPON PLAN RELIC RUNE MAP";

function TestLootGrab(%i,%mf)
{
	%MAP = 0;
	%RUNE = 0;
	%RELIC = 0;
	%WEAPON = 0;
	%SPELL = 0;
	%EXTRA = 0;
	%MAGIC = 0;
	%BODY = 0;
	for (%v = 0; %v <= %i; %v++) {
		%COUNT = Loot::GrabLootCount(%mf);
		if (%COUNT) {
			for (%x = 1; %x <= %COUNT; %x++) {
				%ret = Loot::GrabType(%mf);
				if (%ret == "MAP") %MAP++;
				if (%ret == "RUNE") %RUNE++;
				if (%ret == "RELIC") %RELIC++;
				if (%ret == "WEAPON") %WEAPON++;
				if (%ret == "SPELL") %SPELL++;
				if (%ret == "EXTRA") %EXTRA++;
				if (%ret == "MAGIC") %MAGIC++;
				if (%ret == "BODY") %BODY++;
			}
		}
	}
	echo("MAP " @ %map);
	echo("RUNE " @ %rune);
	echo("RELIC " @ %relic);
	echo("WEAPON " @ %weapon);
	echo("SPELL " @ %spell);
	echo("EXTRA " @ %extra);
	echo("MAGIC " @ %magic);
	echo("BODY " @ %body);
}

function Loot::GrabType(%mf)
{	
	%x = MTRB(1,100);
	%l = "BODY";
	if (%x > 33) {
		if (MTRB(1,2) == 1)
			%l = "WEAPON";
		else
			%l = "SPELL";
	}
	if (%x > 57) {
		if (MTRB(1,2) == 1)
			%l = "MAGIC";
		else
			%l = "EXTRA";
	}
	if (%x > 76) %l = "RELIC";
	if (%x > 89) %l = "RUNE";
	if (%x > 97) %l = "MAP";
	return %l;
}

function Loot::GrabTier(%mf,%max)
{
	if (%mf > 5) %mf = 5;
	%t = 0;
	if (Loot::Ratio(1,2,%mf) == True) %t = 1;
	if (Loot::Ratio(1,4,%mf) == True) %t = 2;
	if (Loot::Ratio(1,8,%mf) == True) %t = 3;
	if (Loot::Ratio(1,20,%mf) == True) %t = 4;
	if (Loot::Ratio(1,59,%mf) == True) %t = 5;
	if (Loot::Ratio(1,198,%mf) == True) %t = 6;
	if (Loot::Ratio(1,742,%mf) == True) %t = 7;
	if (Loot::Ratio(1,3065,%mf) == True) %t = 8;
	////////////////////////////////////////////////
	if (%max != "") {
		if (%t > %max)
			%t = %max;
	}
	if (%t > 6) %t = 6;
	////////////////////////////////////////////////
	return %t;
}

function Loot::Integrity()
{
	%set = "ArmourScrap SpoolOfThread PieceOfCloth SharpeningStone MagicStone";
	%r = MTRB(0,4);
	return "999" @ getWord(%set,%r);
}

function Loot::Relic(%tier)
{
	if (%tier < 2) %tier = 2;
	%tier = MTRB(2,%tier);
	if (%tier <= 2) { %set = "AlteringRelic"; %n = 0; }
	if (%tier == 3) { %set = "HavocRelic ScouringRelic RegalRelic"; %n = 2; }
	if (%tier == 4) { %set = "ChaosRelic CosmicRelic BlessedRelic"; %n = 2; }
	if (%tier == 5) { %set = "AnarchyRelic HeroicRelic DivineRelic"; %n = 2; }
	if (%tier >= 6) { %set = "MysticRelic RunePrism"; %n = 1; }
	%r = MTRB(0,%n);
	return "999" @ getWord(%set,%r);
}

function Loot::Rune(%mf,%ql)
{
	%r = floor(getRandom() * $CRURUNELOOTCOUNT + 1);
	%rune = $CRURUNELOOT[%r];
	return Rune::Random(%rune,%ql);
}

function Loot::Map(%tier,%ql)
{
	return TierItem::RandomMap(%tier,%ql);
}

function Loot::Plan(%tier,%ql)
{
	if (%tier < 1) %tier = 1;
	%n = $PlanLootOn[%tier];
	%r = MTRB(1,%n);
	%ret = $PLANLOOT[%tier,%r];
	return Plan::Create(%ret,%ql);
}

function Loot::Weapon(%tier,%mf,%lvl)
{
	%r = floor(getRandom() * 9 + 1);
	if (%r == 1)
		return Loot::Slashing(%tier,%mf,%lvl);
	else if (%r == 2)
		return Loot::Piercing(%tier,%mf,%lvl);
	else if (%r == 3)
		return Loot::Bludgeoning(%tier,%mf,%lvl);
	else if (%r == 4)
		return Loot::Bow(%tier,%mf,%lvl);
	else if (%r == 5)
		return Loot::Crossbow(%tier,%mf,%lvl);
	else if (%r == 6)
		return Loot::Wand(%tier,%mf,%lvl);
	else if (%r == 7)
		return Loot::Focus(%tier,%mf,%lvl);
	else if (%r == 8)
		return Loot::TwoHandSlash(%tier,%mf,%lvl);
	else if (%r == 9)
		return Loot::MartialArts(%tier,%mf,%lvl);
}

function Loot::Curve(%t,%c,%v,%r)
{
	//echo(" LOOT::CURVE " @ %t @ " " @ %c @ " " @ %v @ " " @ %r);
	%f[0] = 0;
	%f[1] = 2;
	%k = %c;
	for (%i = 2; %i <= %t; %i++) {
		%l = %i - 1;
		%p = %f[%l];
		%k += %c;
		%n = %p * (1 + (%k / %r));
		%f[%i] = %n;
		%m += %n;
		//echo(%i @ " " @ %n);		
	}
	//echo("M " @ %m);
	for (%i = 0; %i <= %t; %i++) {
		%x = %f[%i];
		%x = %x / %m;
		%x = round(%v * %x);
		//echo(%i @ " " @ %x);
		$LOOTCURVE[%t,%i] = %x;
	}
}

Loot::Curve(8,5,1300,25);
Loot::Curve(5,80,1028,125);
Loot::Curve(6,22,1110,50);
Loot::Curve(18,3.5,2048,100);

function Loot::Slashing(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[8,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[8,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[8,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[8,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[8,6],%mf) == True) %t = 6;
	if (Loot::Ratio(1,$LOOTCURVE[8,7],%mf) == True) %t = 7;
	if (Loot::Ratio(1,$LOOTCURVE[8,8],%mf) == True) %t = 8;
	%ret = $WeaponLootTable[Slashing,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Piercing(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[8,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[8,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[8,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[8,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[8,6],%mf) == True) %t = 6;
	if (Loot::Ratio(1,$LOOTCURVE[8,7],%mf) == True) %t = 7;
	if (Loot::Ratio(1,$LOOTCURVE[8,8],%mf) == True) %t = 8;
	%ret = $WeaponLootTable[Piercing,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Bludgeoning(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[8,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[8,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[8,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[8,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[8,6],%mf) == True) %t = 6;
	if (Loot::Ratio(1,$LOOTCURVE[8,7],%mf) == True) %t = 7;
	if (Loot::Ratio(1,$LOOTCURVE[8,8],%mf) == True) %t = 8;
	%ret = $WeaponLootTable[Bludgeoning,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Bow(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[5,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[5,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[5,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[5,5],%mf) == True) %t = 5;
	%ret = $WeaponLootTable[Bow,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Crossbow(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[5,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[5,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[5,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[5,5],%mf) == True) %t = 5;
	%ret = $WeaponLootTable[Crossbow,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Wand(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[6,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[6,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[6,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[6,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[6,6],%mf) == True) %t = 6;
	%ret = $WeaponLootTable[Wand,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Focus(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[6,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[6,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[6,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[6,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[6,6],%mf) == True) %t = 6;
	%ret = $WeaponLootTable[Focus,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::TwoHandSlash(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[5,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[5,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[5,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[5,5],%mf) == True) %t = 5;
	%ret = $WeaponLootTable["2HSlashing",%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::MartialArts(%tier,%mf,%lvl)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[5,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[5,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[5,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[5,5],%mf) == True) %t = 5;
	%ret = $WeaponLootTable[MartialArts,%t,%tier];
	%item = TierItem::RandomItem(%ret,%lvl);
	return %item;
}

function Loot::Magic(%tier,%mf,%overridel)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[18,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[18,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[18,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[18,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[18,6],%mf) == True) %t = 6;
	if (Loot::Ratio(1,$LOOTCURVE[18,7],%mf) == True) %t = 7;
	if (Loot::Ratio(1,$LOOTCURVE[18,8],%mf) == True) %t = 8;
	if (Loot::Ratio(1,$LOOTCURVE[18,9],%mf) == True) %t = 9;
	if (Loot::Ratio(1,$LOOTCURVE[18,10],%mf) == True) %t = 10;
	if (Loot::Ratio(1,$LOOTCURVE[18,11],%mf) == True) %t = 11;
	if (Loot::Ratio(1,$LOOTCURVE[18,12],%mf) == True) %t = 12;
	if (Loot::Ratio(1,$LOOTCURVE[18,13],%mf) == True) %t = 13;
	if (Loot::Ratio(1,$LOOTCURVE[18,14],%mf) == True) %t = 14;
	if (Loot::Ratio(1,$LOOTCURVE[18,15],%mf) == True) %t = 15;
	if (Loot::Ratio(1,$LOOTCURVE[18,16],%mf) == True) %t = 16;
	if (Loot::Ratio(1,$LOOTCURVE[18,17],%mf) == True) %t = 17;
	if (Loot::Ratio(1,$LOOTCURVE[18,18],%mf) == True) %t = 18;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 4 + 1);
	if (%r == 1) %l = "Amulet";
	else if (%r == 2) %l = "Talisman";
	else if (%r == 3) %l = "Ring";
	else if (%r == 4) %l = "Orb";
	if (%overridel != "")
		%l = %overridel;
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,DYN,%t];
	if (%tier == 0) {
		return %baseloot;
	}
	else {
		%tiername = $TIERNAME[%l,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Body(%tier,%mf,%overridex,%overridel)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[18,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[18,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[18,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[18,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[18,6],%mf) == True) %t = 6;
	if (Loot::Ratio(1,$LOOTCURVE[18,7],%mf) == True) %t = 7;
	if (Loot::Ratio(1,$LOOTCURVE[18,8],%mf) == True) %t = 8;
	if (Loot::Ratio(1,$LOOTCURVE[18,9],%mf) == True) %t = 9;
	if (Loot::Ratio(1,$LOOTCURVE[18,10],%mf) == True) %t = 10;
	if (Loot::Ratio(1,$LOOTCURVE[18,11],%mf) == True) %t = 11;
	if (Loot::Ratio(1,$LOOTCURVE[18,12],%mf) == True) %t = 12;
	if (Loot::Ratio(1,$LOOTCURVE[18,13],%mf) == True) %t = 13;
	if (Loot::Ratio(1,$LOOTCURVE[18,14],%mf) == True) %t = 14;
	if (Loot::Ratio(1,$LOOTCURVE[18,15],%mf) == True) %t = 15;
	if (Loot::Ratio(1,$LOOTCURVE[18,16],%mf) == True) %t = 16;
	if (Loot::Ratio(1,$LOOTCURVE[18,17],%mf) == True) %t = 17;
	if (Loot::Ratio(1,$LOOTCURVE[18,18],%mf) == True) %t = 18;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 3 + 1);
	if (%r == 1) %x = "AMR";
	else if (%r == 2) %x = "EVA";
	else if (%r == 3) %x = "RES";
	if (%overridex != "")
		%x = %overridex;
	//------------------------------------------------------------------------
	%r = floor(getRandom() * 5 + 1);
	if (%r == 1) %l = "Head";
	else if (%r == 2) %l = "Chest";
	else if (%r == 3) %l = "Hands";
	else if (%r == 4) %l = "Legs";
	else if (%r == 5) %l = "Boots";
	if (%overridel != "")
		%l = %overridel;
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,%x,%t];
	if (%tier == 0)
		return %baseloot;
	else {
		%tiername = $TIERNAME[%l,%x,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Armor(%tier,%mf,%overridex)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[18,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[18,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[18,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[18,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[18,6],%mf) == True) %t = 6;
	if (Loot::Ratio(1,$LOOTCURVE[18,7],%mf) == True) %t = 7;
	if (Loot::Ratio(1,$LOOTCURVE[18,8],%mf) == True) %t = 8;
	if (Loot::Ratio(1,$LOOTCURVE[18,9],%mf) == True) %t = 9;
	if (Loot::Ratio(1,$LOOTCURVE[18,10],%mf) == True) %t = 10;
	if (Loot::Ratio(1,$LOOTCURVE[18,11],%mf) == True) %t = 11;
	if (Loot::Ratio(1,$LOOTCURVE[18,12],%mf) == True) %t = 12;
	if (Loot::Ratio(1,$LOOTCURVE[18,13],%mf) == True) %t = 13;
	if (Loot::Ratio(1,$LOOTCURVE[18,14],%mf) == True) %t = 14;
	if (Loot::Ratio(1,$LOOTCURVE[18,15],%mf) == True) %t = 15;
	if (Loot::Ratio(1,$LOOTCURVE[18,16],%mf) == True) %t = 16;
	if (Loot::Ratio(1,$LOOTCURVE[18,17],%mf) == True) %t = 17;
	if (Loot::Ratio(1,$LOOTCURVE[18,18],%mf) == True) %t = 18;
	//------------------------------------------------------------------------
	%r = MTRB(1,3);
	if (%r == 1) %x = "AMR";
	else if (%r == 2) %x = "EVA";
	else if (%r == 3) %x = "RES";
	if (%overridex != "")
		%x = %overridex;
	//------------------------------------------------------------------------
	%l = "Armor";
	//------------------------------------------------------------------------
	%baseloot = $LootTable[%l,%x,%t];
	if (%tier == 0)
		return %baseloot;
	else {
		%tiername = $TIERNAME[%l,%x,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Shield(%tier,%mf,%overridex,%overridel)
{
	%t = 1;
	if (Loot::Ratio(1,$LOOTCURVE[8,2],%mf) == True) %t = 2;
	if (Loot::Ratio(1,$LOOTCURVE[8,3],%mf) == True) %t = 3;
	if (Loot::Ratio(1,$LOOTCURVE[8,4],%mf) == True) %t = 4;
	if (Loot::Ratio(1,$LOOTCURVE[8,5],%mf) == True) %t = 5;
	if (Loot::Ratio(1,$LOOTCURVE[8,6],%mf) == True) %t = 6;
	if (Loot::Ratio(1,$LOOTCURVE[8,7],%mf) == True) %t = 7;
	if (Loot::Ratio(1,$LOOTCURVE[8,8],%mf) == True) %t = 8;
	//------------------------------------------------------------------------
	%r = MTRB(1,3);
	if (%r == 1) %x = "MES";
	else if (%r == 2) %x = "SPS";
	else if (%r == 3) %x = "QUV";
	if (%overridex != "")
		%x = %overridex;
	//------------------------------------------------------------------------
	%l = "Shield";
	if (%r == 3)
		%l = "Quiver";
	if (%overridel != "")
		%l = %overridel;
	//------------------------------------------------------------------------
	//echo(%l @ " " @ %x);
	%baseloot = $LootTable[%l,%x,%t];
	if (%tier == 0)
		return %baseloot;
	else {
		//echo(%l @ " " @ %x);
		%tiername = $TIERNAME[%l,%x,%tier];
		return %tiername @ %baseloot;
	}
}

function Loot::Belt(%ql)
{
	%d = MTRB(1,2);
	if (%d == 1) {
		%count = $BELTLOOTCOUNT - 1;
		%r = MTRB(0,%count);
		%item = getWord($BELTLOOT,%r);
		return TierItem::RandomItem(%item,%ql);
	}
	else
		return TierItem::RandomItem("MemoryStone",%ql);					
}

function Loot::Spell(%lvl)
{
	%ql = Loot::GrabQL(%lvl,0.2);
	%ql = Loot::Round(%ql);
	%x = MTRB(1,3);
	if (%x == 1)
		%ret = Loot::GrabCrystal(%ql);
	if (%x == 2)
		%ret = Loot::GrabSpellBook(%ql);
	if (%x == 3) {
		%ret = DynamicItem::Create("EmptySpellcrystal",%ql);
	}
	return %ret;
}

function Loot::AddWeaponLoot(%req,%loot,%i,%tname)
{
	//echo(" LOOT::ADDWEAPONLOOT " @ %req @ " " @ %loot @ " " @ %i @ " " @ %tname);
	$WeaponLootTable[%req,%loot,%i] = %tname;
}

$LootPercConversion["1 50",0] 		= 1;
$LootPercConversion["5 55",0] 		= 2;
$LootPercConversion["10 60",0] 		= 3;
$LootPercConversion["15 65",0] 		= 4;
$LootPercConversion["20 70",0] 		= 5;
$LootPercConversion["25 75",0] 		= 6;
$LootPercConversion["30 80",0] 		= 7;
$LootPercConversion["35 85",0] 		= 8;
$LootPercConversion["40 90",0] 		= 9;
$LootPercConversion["45 95",0] 		= 10;
$LootPercConversion["50 100",0] 	= 11;
$LootPercConversion["55 105",0] 	= 12;
$LootPercConversion["60 110",0] 	= 13;
$LootPercConversion["65 115",0] 	= 14;
$LootPercConversion["70 120",0] 	= 15;
$LootPercConversion["75 125",0] 	= 16;
$LootPercConversion["80 130",0] 	= 17;
$LootPercConversion["85 135",0] 	= 18;

$LootPercConversion["1 50",1] 		= 1;
$LootPercConversion["10 60",1] 		= 2;
$LootPercConversion["20 70",1] 		= 3;
$LootPercConversion["30 80",1] 		= 4;
$LootPercConversion["40 90",1] 		= 5;
$LootPercConversion["50 100",1] 	= 6;
$LootPercConversion["60 110",1] 	= 7;
$LootPercConversion["70 120",1] 	= 8;

function Loot::AddToLoot(%type,%req,%perc,%item,%set,%plan)
{
	//echo(" LOOT::ADDTOLOOT " @ %type @ " " @ %req @ " " @ %perc @ " " @ %item @ " " @ %set);
	if (%set == "") %set = 0;
	if (%plan == "") %plan = 0;
	%perc = $LootPercConversion[%perc,%set];
	$LootTable[%type,%req,%perc] = %item;
	if (%plan)
		$LootTable[%type,%req,%perc,%plan] = %item;
}

function Loot::Round(%n)
{
	if (%n < 10) return 10;
	if (%n > 10 && %n < 100)
		return string::getSubStr(%n,0,1) @ "0";
	if (%n > 100)
		return string::getSubStr(%n,0,2) @ "0";
}

function Loot::GrabQL(%lvl,%v,%upper)
{
	//echo("LOOT::GRABQL " @ %lvl @ " " @ %v @ " " @ %upper);
	if (%v == "" || %v < 0) %v = 0.10;
	%f = round(%lvl * %v);
	%r = RandBetween((%lvl-%f),(%lvl+%f));
	if (%r < 1) %r = 1;
	if (%upper == 0 || %upper == "")
		if (%r > 300) %r = 300;
	else
		if (%r > 999) %r = 999;
	return %r;
}

function Loot::ResetCrystalLoot()
{
	for (%i = 0; %i <= 300; %i+=10)
		$SpellCrystalLootNum[%i] = 0;
}

function Loot::AddSpellCrystal(%v,%crystal)
{
	//echo(" LOOT::ADDSPELLCRYSTAL " @ %v @ " " @ %crystal);
	%n = $SpellCrystalLootNum[%v]++;
	$SpellCrystalLoot[%v,%n] = %crystal;
}

function Loot::GrabCrystal(%l)
{
	%n = $SpellCrystalLootNum[%l];
	%r = MTRB(1,%n);
	return $SpellCrystalLoot[%l,%r];
}

function Loot::AddSpellBook(%v,%book)
{
	//echo(" LOOT::ADDSPELLBOOK " @ %v @ " " @ %book);
	%n = $SpellBookLootNum[%v]++;
	$SpellBookLoot[%v,%n] = %book;
}

function Loot::GrabSpellbook(%l)
{
	%n = $SpellBookLootNum[%l];
	%r = MTRB(1,%n);
	return $SpellBookLoot[%l,%r];
}

echo("__LOOT LOADED");