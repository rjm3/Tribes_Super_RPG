// AUTOSPELLS 

$AutoSpellMaxMana = 3000;
$AutoSpellMaxSkill = 3000;
$AutoSpellMaxSC = 100;

function RomanNumeral(%n)
{
	%v = %n;
	%ret = 0;
	while (%v >= 30) { %ret = "XXX"; %v -= 30; }
	while (%v >= 20) { %ret = "XX"; %v -= 20; }
	while (%v >= 10) { %ret = "X"; %v -= 10; }
	if (%ret == "0") %ret = "";
	if (%v == 1) %ret = %ret @ "I";
	if (%v == 2) %ret = %ret @ "II";	
	if (%v == 3) %ret = %ret @ "III";	
	if (%v == 4) %ret = %ret @ "IV";	
	if (%v == 5) %ret = %ret @ "V";	
	if (%v == 6) %ret = %ret @ "VI";	
	if (%v == 7) %ret = %ret @ "VII";	
	if (%v == 8) %ret = %ret @ "VIII";	
	if (%v == 9) %ret = %ret @ "IX";
	return %ret;
}

function ResetCruSpellNum()
{
	echo(" *** RESETCRUSPELLNUM *** ");
	$TotalSpellNum[PrimalMagic] 	= 0;
	$TotalSpellNum[HolyMagic] 	= 0;
	$TotalSpellNum[Empowerment] 	= 0;
	$TotalSpellNum[DarkMagic] 	= 0;
	$TotalSpellNum[LightMagic] 	= 0;
	$TotalSpellNum[Ritual] 		= 0;
	$TotalSpellNum[Sorcery] 	= 0;
	$TotalSpellNum[Protection] 	= 0;
	$TotalSpellNum[Enchantment] 	= 0;
	$DefaultSpellList[PrimalMagic]	= "";
	$DefaultSpellList[HolyMagic] 	= "";
	$DefaultSpellList[Empowerment] 	= "";
	$DefaultSpellList[DarkMagic] 	= "";
	$DefaultSpellList[LightMagic] 	= "";
	$DefaultSpellList[Ritual] 	= "";
	$DefaultSpellList[Sorcery] 	= "";
	$DefaultSpellList[Protection] 	= "";
	$DefaultSpellList[Enchantment] 	= "";
	$SpellCatList[PrimalMagic] 	= "";
	$SpellCatList[HolyMagic] 	= "";
	$SpellCatList[Empowerment] 	= "";
	$SpellCatList[DarkMagic] 	= "";
	$SpellCatList[LightMagic] 	= "";
	$SpellCatList[Ritual] 		= "";
	$SpellCatList[Sorcery] 		= "";
	$SpellCatList[Protection] 	= "";
	$SpellCatList[Enchantment] 	= "";
	$SpellCatNum[PrimalMagic] 	= 0;
	$SpellCatNum[HolyMagic] 	= 0;
	$SpellCatNum[Empowerment] 	= 0;
	$SpellCatNum[DarkMagic] 	= 0;
	$SpellCatNum[LightMagic] 	= 0;
	$SpellCatNum[Ritual] 		= 0;
	$SpellCatNum[Sorcery] 		= 0;
	$SpellCatNum[Protection] 	= 0;
	$SpellCatNum[Enchantment] 	= 0;
}
ResetCruSpellNum();

function AutoSpell(%spell,%dispname,%num,%type,%mode,%hostile,%req,%class,%effect,%take,%cast,%recover,%sc,%dur,%tree,%category,%anim,%ico,%desc,%conv,%rev,%silent,%ticks,%durstep,%start,%max,%lvlreq,%dot,%dotint,%dotticks,%flat,%newoff,%newdef,%range,%dotanim,%hostilebonus,%aura,%auradur,%auraname,%aurahostile,%enemy)
{
	echo("AUTOSPELL *** " @ %spell @ " " @ %dispname @ " " @ %num @ " " @ %type @ " " @ %mode @ " " @ %hostile @ " " @ %req @ " " @ %class @ " " @ %effect @ " " @ %take);
	//=================================================================================================================================================
	%maxskill = $AutoSpellMaxSkill;
	if (getWord(%req,1) != -1) {
		%maxskill = getWord(%req,1);
	}
	%req = getWord(%req,0);
	//=================================================================================================================================================
	if ($ENEMYSPELL[%spell] == 1)
		%enemy = 1;
	if ($UNCASTSPELL[%spell] == 1)
		%uncast = True;
	else
		%uncast = False;
	if ($MINCAST[%spell] != "")
		%mincast = $MINCAST[%spell];
	else
		%mincast = -1;
	if ($MINCOOLDOWN[%spell] != "")
		%mincooldown = $MINCOOLDOWN[%spell];
	else
		%mincooldown = -1;
	if (%enemy != 1) {
		%catnum = 1;	
		$SpellCatNum[%req]++;
		%znum = $SpellCatNum[%req];
		$SpellCatList[%req,%znum] = %spell;
	}
	//=================================================================================================================================================
	for (%i = 1; %i <= %num; %i++) {
		//-----------------------------------------------------------------------------------------------------------
		// CONVERT TO SELF
		if (%i >= %conv && %conv != 0) { %mode = "SELF"; }
		//-----------------------------------------------------------------------------------------------------------
		%name = %spell @ %i;
		// %disp = %dispname @ " (" @ %i @ ")";
		%disp = %dispname @ " " @ RomanNumeral(%i);
		%dotname = "DOT" @ %spell @ %i;
		//-----------------------------------------------------------------------------------------------------------
		%perc = %i / %num;
		//-----------------------------------------------------------------------------------------------------------
		// ADD TO SAVE LIST
		if (%enemy != 1) {
			$TotalSpellNum[%req]++;
			%totalspellnum = $TotalSpellNum[%req];
			$CruSpellNum[%req,%totalspellnum] = %name;
			$CruSpellNTN[%name] = %totalspellnum;
			$CruSpellNTR[%name] = %req;
			$CruSpellCategory[%category,%catnum] = %name;
			$CruSpellCategory[%category,0] = %catnum;
			%catnum++;
			$DefaultSpellList[%req] = $DefaultSpellList[%req] @ "0";
		}
		//-----------------------------------------------------------------------------------------------------------
		if (%type == "DOT") {
			//-----------------------------------------------------------------------------------------------------------
			// CREATE EFFECT
			%neweffect = "";
			if (getWord(%effect,0) == "DAMAGE") {
				%val = getWord(%effect,2);
				%val = round(%val * %perc);
				%val = %val / 30;
				%flux = %val * 0.3;
				%min = round(%val - %flux) + 1;
				%max = round(%val + %flux) + 1;
				%neweffect = "DAMAGE " @ getWord(%effect,1) @ "-" @ %min @ ".." @ %max;
			}
			//-----------------------------------------------------------------------------------------------------------
			// CREATE REQ
			%maxskill = $AutoSpellMaxSkill;
			%maxmana = $AutoSpellMaxMana;
			%val = round(%maxskill * %perc);
			//-----------------------------------------------------------------------------------------------------------
			// CLASS REMOVED
			// %newreq = "CLASS " @ %class @ " ";
			//-----------------------------------------------------------------------------------------------------------
			%newrew = "";
			%newreq = %newreq @ %req @ " " @ %val @ " ";
			if (getWord(%take,0) == "MANA") {
				%tp = getWord(%take,1);
				%val = round((%maxmana * %tp) * %perc);
				%newreq = %newreq @ "MANA " @ %val;
				%newtake = "MANA " @ %val;
			}
			//-----------------------------------------------------------------------------------------------------------
			if (%max == -1) {
				%qual = floor(300 / %num);
				%qual = floor(%qual * %i);
			}
			else {
				if (%start > 0) {
					if (%num == 1)
						%qual = %start;
					else {
						%qual = (%start + (%max * %num));
					}
				}
				else {
					%qual = %max / %num;
					%qual = floor(%qual * %i);
				}
			}
			//-----------------------------------------------------------------------------------------------------------
			$CruSpell[%name,$CSQuality] = %qual;
			$CruSpell[%name,$CSName] = %disp;
			$CruSpell[%name,$CSCategory] = %category;
			$CruSpell[%name,$CSMustLearn] = 0;
			$CruSpell[%name,$CSReqs] = %newreq;
			$CruSpell[%name,$CSMode] = %mode;
			//-----------------------------------------------------------------------------------------------------------
			if (getWord(%tree,1) == -1)
				$CruSpell[%name,$CSTree] = %tree @ " " @ %i;
			else {
				%newtree = "";
				for (%k = 0; (%c = getWord(%tree,%k)) != -1; %k++)
					%newtree = %newtree @ %c @ " " @ %i @ " ";
				$CruSpell[%name,$CSTree] = %newtree;
			}
			//-----------------------------------------------------------------------------------------------------------
			$CruSpell[%name,$CSCastTime] = %cast;
			$CruSpell[%name,$CSRecovery] = %recover;
			$CruSpell[%name,$CSDur] = %dur;
			$CruSpell[%name,$CSHaveReqs] = "LVLG 0";
			$CruSpell[%name,$CSTake] = %newtake;
			$CruSpell[%name,$CSBonus] = "";
			$CruSpell[%name,$CSDOT] = %dotname;
			$CruSpell[%name,$CSInfo] = %desc;
			$CruSpell[%name,$CSAnimation] = %anim;
			$CruSpell[%name,$CSOffense] = $SkillOffensiveCasting @ " 100";
			$CruSpell[%name,$CSDefense] = $SkillSpellResistance @ " 100";
			$CruSpell[%name,$CSHostile] = %hostle;
			$CruSpell[%name,$CSSC] = round((%sc * $AutoSpellMaxSc) * %perc);
			$CruDOT[%dotname,$CDOTInterval] = 2;
			$CruDOT[%dotname,$CDOTHits] = 30;
			$CruDOT[%dotname,$CDOTBonus] = %neweffect;
			if (%uncast)
				$CruSpell[%name,$CSUnCast] = 1;
			if (%mincast != -1)
				$CruSpell[%name,$CSMinCast] = %mincast;
			if (%mincooldown != -1)
				$CruSpell[%name,$CSMinCooldown] = %mincooldown;  
			//-----------------------------------------------------------------------------------------------------------
			if (%enemy != 1)
				AutoSpellCrystal(%name,%qual,%newreq,%req);
		}
		if (%type == "FRIEND" || %type == "FOE" && getWord(%effect,0) != "CONTROL") {
			%maxlvl = 230;
			//-----------------------------------------------------------------------------------------------------------
			// CREATE EFFECT
			%neweffect = "";
			if (getWord(%effect,0) == "HEAL" || getWord(%effect,0) == "TEAMHEAL") {
				%valz = getWord(%effect,1);
				%valz = round(%valz * %perc);
				%fluxz = %valz * 0.3;
				%minz = round(%valz - %fluxz) + 1;
				%maxz = round(%valz + %fluxz) + 1;
				%neweffect = getWord(%effect,0) @ " " @ %minz @ ".." @ %maxz;
			}
			else {		
				for (%z = 1; %z <= 13; %z += 2) {
					%w = getWord(%effect,%z);
					%c = getWord(%effect,%z-1);
					if (%w != -1) {
						if (%w != "Wolf" && %w != "Bear") {
							%val = getWord(%effect,%z);
							if (%c == "SELFCAST" || %c == "CHANGERACE" || %c == "TELEPORTTOCASTER" || %c == "CHILLONHIT" || %c == "SHIELDSTUN" || %c == "CASTERTELEPORT" || %c == "SETAURA" || %c == "OVERRIDEDT" || %c == "DISCHARGE" || $AUTOSPELLNOFLUXVAL[%c] == 1) {
								%val = %val;
							}
							else if (string::findSubStr(%c,"Damage:") != -1) {
								%val = round(%val * %perc);
								%fluxe = %val * 0.2;
								%mine = round(%val - %fluxe) + 1;
								%maxe = round(%val + %fluxe) + 1;
								%val = %mine @ ".." @ %maxe;
							}
							else if (%c == "AOECAST" || %c == "TEAMAOECAST") {
								if (string::findSubStr(%val,"*") != -1) {
									%val = String::CopyUntil(%val,"*");
									%val = %val @ %i;
								}
							}
							else {
								if ((%find = string::FindSubStr(%val,":")) != -1) {
									%valmin = string::getSubStr(%val,0,%find);
									%valmax = string::getSubStr(%val,(%find+1),99);
									%val = PercBetween(%valmin,%valmax,%perc);
								}
								else {
									%val = round(%val * %perc);
								}
							}
							%neweffect = %neweffect @ getWord(%effect,%z-1) @ " " @ %val @ " ";
						}
						else {
							%neweffect = %neweffect @ getWord(%effect,%z-1) @ " " @ %w @ " ";
						}
					}
				}
			}
			//-----------------------------------------------------------------------------------------------------------
			if (%hostileBonus != "") {
				%newhostile = "";
				for (%p = 0; (%ht = getWord(%hostileBonus,%p)) != -1; %p += 2) {
					if (%ht == "OVERRIDEDT") {
						%val = getWord(%hostileBonus,%p+1);
						%newhostile = %newhostile @ %ht @ " " @ %val @ " ";
					}
					else {
						%val = getWord(%hostileBonus,%p+1);
						if ((%find = string::FindSubStr(%val,":")) != -1) {
							%valmin = string::getSubStr(%val,0,%find);
							%valmax = string::getSubStr(%val,(%find+1),99);
							%val = PercBetween(%valmin,%valmax,%perc);
						}
						else {
							%val = round(%val * %perc);
						}
						%newhostile = %newhostile @ %ht @ " " @ %val @ " ";
					}
				}
				$CruSpell[%name,$CSHostileBonus] = %newhostile;
			}
			//-----------------------------------------------------------------------------------------------------------
			if (%flat != "")
				%neweffect = %neweffect @ %flat @ " ";
			//-----------------------------------------------------------------------------------------------------------
			if (%max == -1) {
				%qual = floor(300 / %num);
				%qual = floor(%qual * %i);
			}
			else {
				if (%start > 0) {
					if (%i == 1)
						%qual = %start;
					else {
						%qual = (%start + (%max * (%i - 1)));
					}
				}
				else {
					%qual = %max / %num;
					%qual = floor(%qual * %i);
				}
			}
			//-----------------------------------------------------------------------------------------------------------
			// CREATE REQ
			%maxskill = $AutoSpellMaxSkill;
			%maxmana = $AutoSpellMaxMana;
			%newreq = "";
			//-----------------------------------------------------------------------------------------------------------
			if (%max != -1) {
				%maxskill = floor($AutoSpellMaxSkill * (%qual / 300));
				%maxmana = floor($AutoSpellMaxMana * (%qual / 300));
				%val = %maxskill;
			}
			else 
				%val = round(%maxskill * %perc);
			//-----------------------------------------------------------------------------------------------------------
			// CLASS REMOVED
			if (%class != "NA") {
				for (%a = 0; (%greq = getWord(%class,%a)) != -1; %a+=2) {
					%gval = getWord(%class,%a+1);
				if (%greq == "LVLG")
					%newreq = %newreq @ "LVLG " @ round((%maxlvl * %gval) * %perc) @ " ";
				else
					%newreq = %newreq @ %greq @ " " @ %gval @ " ";
				}
			}
			//-----------------------------------------------------------------------------------------------------------
			%newreq = %newreq @ %req @ " " @ %val @ " ";
			if (getWord(%take,0) == "MANA") {
				%tp = getWord(%take,1);
				if (%max != -1)
					%val = %maxmana;
				else
					%val = round((%maxmana * %tp) * %perc);
				%newreq = %newreq @ "MANA " @ %val;
				%newtake = "MANA " @ %val;
			}
			if (getWord(%take,0) == "HEALTH") {
				%tp = getWord(%take,1);
				if (%max != -1)
					%val = %maxmana;
				else
					%val = round((%maxmana * %tp) * %perc);
				%newreq = %newreq @ "HEALTH " @ %val;
				%newtake = "HEALTH " @ round(%val * 0.9);
			}
			//-----------------------------------------------------------------------------------------------------------
			// CREATE SC
			%newsc = round((%sc * $AutoSpellMaxSc) * %perc);
			//-----------------------------------------------------------------------------------------------------------
			if (%lvlreq != 0) { %havereq = "LVLG " @ round((%maxlvl * %lvlreq) * %perc); }
			else { %havereq = "LVLG 0"; }
			//-----------------------------------------------------------------------------------------------------------
			$CruSpell[%name,$CSQuality] = %qual;
			$CruSpell[%name,$CSName] = %disp;
			$CruSpell[%name,$CSCategory] = %category;
			$CruSpell[%name,$CSMustLearn] = 0;
			$CruSpell[%name,$CSReqs] = %newreq;
			$CruSpell[%name,$CSMode] = %mode;
			//-----------------------------------------------------------------------------------------------------------
			if (getWord(%tree,1) == -1)
				$CruSpell[%name,$CSTree] = %tree @ " " @ %i;
			else {
				%newtree = "";
				for (%k = 0; (%c = getWord(%tree,%k)) != -1; %k++)
					%newtree = %newtree @ %c @ " " @ %i @ " ";
				$CruSpell[%name,$CSTree] = %newtree;
			}
			//-----------------------------------------------------------------------------------------------------------
			$CruSpell[%name,$CSCastTime] = %cast;
			$CruSpell[%name,$CSRecovery] = %recover;
			$CruSpell[%name,$CSDur] = %dur;
			$CruSpell[%name,$CSHaveReqs] = %havereq;
			$CruSpell[%name,$CSTake] = %newtake;
			$CruSpell[%name,$CSBonus] = "";
			$CruSpell[%name,$CSInfo] = %desc;
			$CruSpell[%name,$CSAnimation] = %anim;
			$CruSpell[%name,$CSSC] = %newsc;
			if (%uncast)
				$CruSpell[%name,$CSUnCast] = 1;
			if (%newoff != "")
				$CruSpell[%name,$CSOffense] = %newoff;
			else
				$CruSpell[%name,$CSOffense] = %type @ " 100";
			if (%newdef != "")
				$CruSpell[%name,$CSDefense] = %newdef;
			else
				$CruSpell[%name,$CSDefense] = "SpellReistance 100";
			$CruSpell[%name,$CSHostile] = %hostile;
			$CruSpell[%name,$CSBonus] = %neweffect;
			if ($SpellEndOnNoMana[%tree] == 1)
				$CruSpell[%name,$CSEndOnNoMana] = 1;
			if (%range != "")
				$CruSpell[%name,$CSRange] = %range;
			if (%mincast != -1)
				$CruSpell[%name,$CSMinCast] = %mincast;
			if (%mincooldown != -1)
				$CruSpell[%name,$CSMinCooldown] = %mincooldown;  
			//-----------------------------------------------------------------------------------------------------------
			if (%dot != "") {
				%neweffect = "";
				%dotname = %name @ "DOT";
				$CruDOT[%dotname,$CDOTInterval] = %dotint;
				$CruDOT[%dotname,$CDOTHits] = %dotticks;
				%flag = False;
				for (%g = 0; (%var = getWord(%dot,%g)) != -1; %g++) {				
					if (%var == "HEALMANA" || %var == "HEAL" || %var == "DRAINMANA") {
						%valz = getWord(%dot,%g+1);
						%valz = round(%valz * %perc);
						%fluxz = %valz * 0.3;
						%minz = round(%valz - %fluxz) + 1;
						%maxz = round(%valz + %fluxz) + 1;
						%neweffect = %neweffect @ %var @ " " @ %minz @ ".." @ %maxz @ " ";
					}
					if (%var == "AOECAST" || %var == "TEAMAOECAST") {
						%flag = True;
						%val = getWord(%dot,%g+1);
						if (string::findSubStr(%val,"*") != -1) {
							%val = String::CopyUntil(%val,"*");
							%val = %val @ %i;
							%neweffect = %neweffect @ %var @ " " @ %val @ " ";
						}
					}
					if (string::findSubStr(%var,"Damage:") != -1 || string::findSubStr(%var,"SelfDamage:") != -1 || string::findSubStr(%var,"AOE") != -1 && %flag != True) {
						%val = getWord(%dot,%g+1);
						%vtemp = %val;
						%ptemp = "";
						if ((%mid = string::FindSubStr(%val,"%")) != -1) {
							%vtemp = string::GetSubStr(%val,0,%mid);
							%ptemp = string::GetSubStr(%val,%mid,255);
						}
						%val = round(%vtemp * %perc);
						%fluxe = %val * 0.2;
						%mine = round(%val - %fluxe) + 1;
						%maxe = round(%val + %fluxe) + 1;
						%val = %mine @ ".." @ %maxe @ %ptemp;
						%neweffect = %neweffect @ %var @ " " @ %val @ " ";
					}
				}
				$CruDOT[%dotname,$CDOTBonus] = %neweffect;
				$CruDOT[%dotname,$CDOTAnim] = %dotanim;
				$CruSpell[%name,$CSDOT] = %dotname;
			}
			//-----------------------------------------------------------------------------------------------------------
			if (%aura != "") {
				%auraline = %auraname @ " " @ %i;
				%auranew = %auraname @ %i;
				$CruSpell[%auranew,$CSName] 		= %auranew;
				$CruSpell[%auranew,$CSReqs] 		= "LVLG 0";
				$CruSpell[%auranew,$CSHostile] 		= %aurahostile;
				$CruSpell[%auranew,$CSMode] 		= "SELF";
				$CruSpell[%auranew,$CSTree] 		= %auraline;
				$CruSpell[%auranew,$CSCastTime] 	= 0;
				$CruSpell[%auranew,$CSRecovery] 	= 0;
				$CruSpell[%auranew,$CSDur] 		= %auradur;
				$CruSpell[%auranew,$CSHaveReqs] 	= "LVLG 0";
				$CruSpell[%auranew,$CSTake] 		= "MANA 0";
				$CruSpell[%auranew,$CSSC] 		= 0;
				%neweffect = "";
				for (%g = 0; (%var = getWord(%aura,%g)) != -1; %g+=2) {
					%val = getWord(%aura,%g+1);
					if ((%find = string::FindSubStr(%val,":")) != -1) {
						%valmin = string::getSubStr(%val,0,%find);
						%valmax = string::getSubStr(%val,(%find+1),99);
						%val = PercBetween(%valmin,%valmax,%perc);
					}
					else {
						if (%var == "SETAURA")
							%val = %val;
						else
							%val = round(%val * %perc);
					}
					%neweffect = %neweffect @ %var @ " " @ %val @ " ";
				}
				$CruSpell[%auranew,$CSBonus] 		= %neweffect;
				$CruSpell[%auranew,$CSSilent]		= 1;
			}
			//-----------------------------------------------------------------------------------------------------------
			if (%enemy != 1)
				AutoSpellCrystal(%name,%qual,%newreq,%req);
		}
		if (%type == "SELF" || getWord(%effect,0) == "CONTROL") {
			%neweffect = "";
			%addreq = "";
			if (getWord(%effect,0) == "SPAWNPET") {
				%neweffect = "SPAWNPET Summon" @ %i;
				%addreq = " NOPET 1";
			}
			if (getWord(%effect,0) == "CONTROL") {
				%neweffect = "CONTROL Caster";
				%addreq = " NOPET 1";
			}
			//-----------------------------------------------------------------------------------------------------------
			// CREATE REQ
			%maxskill = $AutoSpellMaxSkill;
			%maxmana = $AutoSpellMaxMana;
			//-----------------------------------------------------------------------------------------------------------
			if (%max != -1) {
				%maxskill = floor($AutoSpellMaxSkill * (%max / 300));
				%maxmana = floor($AutoSpellMaxMana * (%max / 300));
			}	
			//-----------------------------------------------------------------------------------------------------------
			%val = round(%maxskill * %perc);
			//-----------------------------------------------------------------------------------------------------------
			// CLASS REMOVED
			if (%class != "NA")
				%newreq = %newreq @ %class @ " ";
			//-----------------------------------------------------------------------------------------------------------
			%newreq = "";
			if (getWord(%take,0) == "MANA") {
				%tp = getWord(%take,1);
				%val = round((%maxmana * %tp) * %perc);
				%newreq = %newreq @ "MANA " @ %val @ " " @ %addreq;
				%newtake = "MANA " @ %val;
			}
			if (getWord(%take,0) == "HEALTH") {
				%tp = getWord(%take,1);
				%val = round((%maxmana * %tp) * %perc);
				%newreq = %newreq @ "HEALTH " @ %val;
				%newtake = "HEALTH " @ %val;
			}
			//-----------------------------------------------------------------------------------------------------------
			// CREATE SC
			%newsc = round((%sc * $AutoSpellMaxSc) * %perc);
			//-----------------------------------------------------------------------------------------------------------
			// CREATE CUSTOM HAVE
			if (getWord(%effect,0) == "CONTROL") {
				%maxlvl = 250;
				%havereq = "LVLL " @ round(%maxlvl * %perc);
			}
			else {
				%maxlvl = 230;
				if (%lvlreq != 0) { %havereq = "LVLG " @ round((%maxlvl * %lvlreq) * %perc); }
				else { %havereq = "LVLG 0"; }
			}
			//-----------------------------------------------------------------------------------------------------------
			for (%z = 1; %z <= 13; %z += 2) {
				%w = getWord(%effect,%z);
				if (%w != -1) {
					if (%w != "Wolf" && %w != "Bear") {
						%val = getWord(%effect,%z);
						if (%rev != 1) {
							if ((%find = string::FindSubStr(%val,":")) != -1) {
								%valmin = string::getSubStr(%val,0,%find);
								%valmax = string::getSubStr(%val,(%find+1),99);
								%val = PercBetween(%valmin,%valmax,%perc);

							}
							else {
								%val = round(%val * %perc);
							}
						}
						else {
							%val = round(%val * $HARDVALPERC[%name]);
						}
						%neweffect = %neweffect @ getWord(%effect,%z-1) @ " " @ %val @ " ";
					}
					else {
						%neweffect = %neweffect @ getWord(%effect,%z-1) @ " " @ %w @ " ";
					}
				}
			}
			//-----------------------------------------------------------------------------------------------------------
			if (%max == -1) {
				%qual = floor(300 / %num);
				%qual = floor(%qual * %i);
			}
			else {
				%qual = %max / %num;
				%qual = floor(%qual * %i);
			}
			//-----------------------------------------------------------------------------------------------------------
			if (%flat != "")
				%neweffect = %neweffect @ %flat @ " ";
			//-----------------------------------------------------------------------------------------------------------
			$CruSpell[%name,$CSQuality] = %qual;
			$CruSpell[%name,$CSName] = %disp;
			$CruSpell[%name,$CSCategory] = %category;
			$CruSpell[%name,$CSMustLearn] = 0;
			$CruSpell[%name,$CSReqs] = %newreq;
			$CruSpell[%name,$CSMode] = %mode;
			$CruSpell[%name,$CSTree] = %tree @ " " @ %i;
			$CruSpell[%name,$CSCastTime] = %cast;
			$CruSpell[%name,$CSRecovery] = %recover;
			$CruSpell[%name,$CSDur] = %dur;
			$CruSpell[%name,$CSHostile] = %hostile;
			$CruSpell[%name,$CSHaveReqs] = %havereq;
			$CruSpell[%name,$CSTake] = %newtake;
			$CruSpell[%name,$CSBonus] = "";
			$CruSpell[%name,$CSInfo] = %desc;
			$CruSpell[%name,$CSAnimation] = %anim;
			$CruSpell[%name,$CSSC] = %newsc;
			$CruSpell[%name,$CSOffense] = $SkillOffensiveCasting @ " 100";
			$CruSpell[%name,$CSDefense] = $SkillSpellResistance @ " 100";
			$CruSpell[%name,$CSHostile] = %hostle;
			$CruSpell[%name,$CSBonus] = %neweffect;
			if (%uncast)
				$CruSpell[%name,$CSUnCast] = 1;
			if (%mincast != -1)
				$CruSpell[%name,$CSMinCast] = %mincast;
			if (%mincooldown != -1)
				$CruSpell[%name,$CSMinCooldown] = %mincooldown;  
			//-----------------------------------------------------------------------------------------------------------
			if (%dot != "") {
				%dotname = %name @ "DOT";
				$CruDOT[%dotname,$CDOTInterval] = %dotint;
				$CruDOT[%dotname,$CDOTHits] = %dotticks;
				if (getWord(%dot,0) == "HEALMANA" || getWord(%dot,0) == "HEAL") {
					%valz = getWord(%dot,1);
					%valz = round(%valz * %perc);
					%fluxz = %valz * 0.3;
					%minz = round(%valz - %fluxz) + 1;
					%maxz = round(%valz + %fluxz) + 1;
					%neweffect = getWord(%dot,0) @ " " @ %minz @ ".." @ %maxz;
				}
				$CruDOT[%dotname,$CDOTBonus] = %neweffect;
				$CruSpell[%name,$CSDOT] = %dotname;
			}
			//-----------------------------------------------------------------------------------------------------------
			if (%enemy != 1)
				AutoSpellCrystal(%name,%qual,%newreq,%req);
		}
	}
}

function AutoSpellCrystal(%name,%qual,%newreq,%req)
{
	//echo(" AUTOSPELLCRYSTAL " @ %name @ " " @ %qual @ " " @ %newreq);
	%ql = FormatQL(%qual);
	%crystal = %ql @ "Crystal" @ %name;
	$BPItem[%crystal,$BPName] = "Crystal: " @ $CruSpell[%name,$CSName];
	$BPItem[%crystal,$BPWeight] = 1;
	$BPItem[%crystal,$BPPrice] = round(3000 * (%ql / 300));
	$BPItem[%crystal,$BPUse] = %newreq;
	$BPItem[%crystal,$BPUseBonus] = "LearnSpell " @ %name;
	$BPItem[%crystal,$BPDesc] = " Using this spell crystal will cause you to learn spell: " @ $CruSpell[%name,$CSName];
	$BPItem[%crystal,$BPDeleteOnUse] = 1;
	%ico = "ico_c_" @ %req @ ".bmp";
	$BPItem[%crystal,$BPIco] = %ico;
	$BPItem[%crystal,$BPItemType] = %req @ " Spellcrystal";
	$BPItem[%crystal,$BPMaterial] = "CrystalShard";
	Loot::AddSpellCrystal(%qual,%crystal);
	CC::AddSpellCrystal(%qual,%crystal,%req);
	// ADD THE SPELL BOOK
	%book = %ql @ "Spellbook" @ %name;
	$BPItem[%book,$BPName] = "Spellbook: " @ $CruSpell[%name,$CSName];
	$BPItem[%book,$BPWeight] = 1;
	$BPItem[%book,$BPPrice] = round(1500 * (%ql / 300));
	$BPItem[%book,$BPDesc] = " You can combine this Spellbook with an Empty Spellcrystal to make: " @ $CruSpell[%name,$CSName];
	%ico = "ico_b_" @ %req @ ".bmp"; 
	$BPItem[%book,$BPIco] = %ico;
	$BPItem[%book,$BPCraftType] = "SPELLBOOK";
	$BPItem[%book,$BPCraftCreate] = %crystal;
	$BPItem[%book,$BPMaterial] = "Page";
	Loot::AddSpellBook(%qual,%book);
}

// CREATE THE EMPTY SPELL CRYSTAL ITEM
$DynamicItem[EmptySpellcrystal,$DName] = "Empty Spellcrystal";
$DynamicItem[EmptySpellcrystal,$DMinMax] = "1 300";
$DynamicItem[EmptySpellcrystal,$DWeight] = "1 0";
$DynamicItem[EmptySpellcrystal,$DPrice] = "1 1";
$DynamicItem[EmptySpellcrystal,$DDesc] = "This Empty Spellcrystal can be combined with a Spellbook to create a Spell Crystal";
$DynamicItem[EmptySpellcrystal,$DIco] = "ico_c_empty.bmp";
$DynamicItem[EmptySpellcrystal,$DCraftType] = "EMPTYCRYSTAL";
$DynamicItem[EmptySpellcrystal,$DShowQLInName] = 1;
$DynamicItem[EmptySpellcrystal,$DMaterial] = "CrystalShard";

function BPCraft::SpellCrystal(%id,%book,%crystal)
{
	echo(" BPCRAFT::SPELLCRYSTAL " @ %id @ " " @ %book @ " " @ %crystal);
	%flag = False;
	//-------------------------------------------------------------------------------------------------
	// CRYSTAL CHECK
	echo($BPItem[%crystal,$BPCraftType]);
	if ($BPItem[%crystal,$BPCraftType] != "EMPTYCRYSTAL") {
		Client::SendMessage(%id,0,"You must combine a Spell book with an Empty Spellcrystal.");
		%flag = True;
	}
	//------------------------------------------------------------------------------------------------- 
	// QL CHECK
	%bql = string::GetSubStr(%book,0,3) + 0;
	%eql = string::GetSubStr(%crystal,0,3) + 0;
	if (%eql < (%bql * 0.8)) {
		Client::SendMessage(%id,0,"The Empty Spellcrystal must be at least 80% Quality Level of the Spellbook.");
		%flag = True;
	}
	//-------------------------------------------------------------------------------------------------
	// SKILL CHECK
	%skillmc = floor(3000 * (%bql / 300));
	%skilllt = floor(1500 * (%bql / 300));
	%b = GetBonus(%id,$BPMAGICCRAFTREQ);
	%skillmc = %skillmc * (1 - (%b/100));
	if (GetPlayerSkill(%id,$SkillMagicCraft) < %skillmc) {
		Client::SendMessage(%id,0,"Your skill in Magic Crafting must be at least " @ %skillmc @ ".");
		%flag = True;
	}
	if (GetPlayerSkill(%id,$SkillLiteracy) < %skilllt) {
		Client::SendMessage(%id,0,"Your skill in Literacy must be at least " @ %skilllt @ ".");
		%flag = True;
	}
	//-------------------------------------------------------------------------------------------------
	if (!%flag) {
		%cc = $BPItem[%book,$BPCraftCreate];
		AddToBackpack(%id,%cc,1);
		Client::SendMessage(%id,2,"The combine was Successful.");
		Game::MenuBackpack(%id,0);
		ClearCraftTable(%id,1);
	}
	else {
		Client::SendMessage(%id,2,"The combine Failed.");
		Game::MenuBackpack(%id,0);
		ClearCraftTable(%id,0);
	}	
}

function AutoSummons()
{
	for (%i = 1; %i <= 30; %i++) {
		%name = "Summon" @ %i;
		%lvl = %i * 10;
		$CruSummon[%name] = "LVL " @ %lvl;
	}
}
AutoSummons();

function AutoHardValPerc()
{
	%perc = 1.0;
	for (%i = 1; %i <= 5; %i++) { %name = "MimicCleric" @ %i; $HARDVALPERC[%name] = %perc; %perc -= 0.1; }
	%perc = 1.0;
	for (%i = 1; %i <= 5; %i++) { %name = "MimicDruid" @ %i; $HARDVALPERC[%name] = %perc; %perc -= 0.1; }
	%perc = 1.0;
	for (%i = 1; %i <= 5; %i++) { %name = "MimicBard" @ %i; $HARDVALPERC[%name] = %perc; %perc -= 0.1; }
	%perc = 1.0;
	for (%i = 1; %i <= 5; %i++) { %name = "MimicPaladin" @ %i; $HARDVALPERC[%name] = %perc; %perc -= 0.1; }
	%perc = 1.0;
	for (%i = 1; %i <= 5; %i++) { %name = "MimicFighter" @ %i; $HARDVALPERC[%name] = %perc; %perc -= 0.1; }
	%perc = 1.0;
	for (%i = 1; %i <= 5; %i++) { %name = "MimicMage" @ %i; $HARDVALPERC[%name] = %perc; %perc -= 0.1; }

}
AutoHardValPerc();

$Pet["Summon1","LVL"] = "15";
$Pet["Summon1","TYPE"] = "UndeadFighter";

function AutoDamageSpell(%spellset,%category,%damagetype,%damage,%range,%mana,%cast,%cooldown,%mincast,%mincooldown,%critchance,%critdamage)
{
	echo("AUTODAMAGESPELL *** " @ %spellset @ " " @ %category @ " " @ %damagetype);

	%ql = 0;
	%catnum = 1;
	if (%spellset == "POISON" || %spellset == "MELEE") {
		%req = "DarkMagic";
		%cat = "DARKMAGIC";
	}
	else {
		%req = "Sorcery";
		%cat = "SORCERY";
	}
	$SpellCatNum[%req]++;
	%znum = $SpellCatNum[%req];
	$SpellCatList[%req,%znum] = %category;

	for (%i = 0; %i <= 30; %i++) {

		%ql = %ql + 10;

		if (%i == 0) %ql = 1;		

		%set = $SpellSet[%spellset,0];
		if (%i > 0) %gname = getWord(%set,0);
		if (%i > 5) %gname = getWord(%set,1);
		if (%i > 10) %gname = getWord(%set,2);
		if (%i > 15) %gname = getWord(%set,3);
		if (%i > 20) %gname = getWord(%set,4);
		if (%i > 25) %gname = getWord(%set,5);

		if (%i > 0) {
			%n = %nameon[%gname]++;
			%name = %gname @ %n;
			%disp = %gname @ " " @ RomanNumeral(%n);
		}
		else {
			%name = getWord(%set,0);
			%disp = %name;
		}

		//echo("AUTO " @ %name @ " | " @ %disp @ " | " @ %ql);	
		%spell = %name;

		//================================================================================================
		// ADD TO SAVE LIST
		$TotalSpellNum[%req]++;
		%totalspellnum = $TotalSpellNum[%req];
		$CruSpellNum[%req,%totalspellnum] = %name;
		$CruSpellNTN[%name] = %totalspellnum;
		$CruSpellNTR[%name] = %req;
		$CruSpellCategory[%category,%catnum] = %name;
		$CruSpellCategory[%category,0] = %catnum;
		%catnum++;
		$DefaultSpellList[%req] = $DefaultSpellList[%req] @ "0";

		//================================================================================================

		$CruSpell[%name,$CSQuality] = %ql;
		$CruSpell[%name,$CSName] = %disp;

		//================================================================================================
		$CruSpell[%spell,$CSCategory] 		= %cat;
		$CruSpell[%spell,$CSMustLearn] 		= 0;
		//================================================================================================
		%sorc = round(3000 * (%ql / 300));
		%mana = round(3000 * (%ql / 300));

		%mana = round(1500 * (%ql / 300));
		%delay = %mincast + %mincooldown;
		%mana *= %delay;

		//%mana = round(%mana * ((%mincast + %mincooldown) / 3));
		
		%sorc -= 1;
		$CruSpell[%spell,$CSReqs] 		= %req @ " " @ %sorc @ " MANA " @ %mana;
		//================================================================================================
		$CruSpell[%spell,$CSHostile] 		= 1;
		$CruSpell[%spell,$CSMode] 		= "LOS";
		$CruSpell[%spell,$CSTree] 		= "Damage 0";
		//================================================================================================
		%cast = %ql / 30;
		$CruSpell[%spell,$CSCastTime] 		= %cast + %mincast;
		$CruSpell[%spell,$CSRecovery] 		= %cooldown;
		$CruSpell[%spell,$CSMinCast]		= %mincast;
		$CruSpell[%spell,$CSMinCooldown]	= %mincooldown;
		$CruSpell[%spell,$CSRange] 		= %range; 	
		//================================================================================================
		$CruSpell[%spell,$CSDur] 		= 0;
		$CruSpell[%spell,$CSHaveReqs] 		= "LVLG 0";
		//================================================================================================
		$CruSpell[%spell,$CSTake] 		= "MANA " @ %mana;
		//================================================================================================
		// CREATE THE DAMAGE VALUE
		%nd = (%damage * (%ql / 300));
		%mm = %nd * 0.01;
		%min = round((%nd - %mm) + 1);
		%max = round((%nd + %mm) + 5);
		$CruSpell[%spell,$CSBonus] 		= "Damage:" @ %damagetype @ " " @ %min @ ".." @ %max;
		//================================================================================================
		$CruSpell[%spell,$CSInfo] 		= $SpellSet[%spellset,2,%gname];
		//================================================================================================
		if (%i >= 0 && %i <= 5) %anim = getWord($SpellSet[%spellset,1],0);
		if (%i >= 6 && %i <= 10) %anim = getWord($SpellSet[%spellset,1],1);
		if (%i >= 11 && %i <= 15) %anim = getWord($SpellSet[%spellset,1],2);
		if (%i >= 16 && %i <= 20) %anim = getWord($SpellSet[%spellset,1],3);
		if (%i >= 21 && %i <= 25) %anim = getWord($SpellSet[%spellset,1],4);
		if (%i >= 26 && %i <= 30) %anim = getWord($SpellSet[%spellset,1],5);
		//echo("ANIM " @ %anim);
		$CruSpell[%spell,$CSAnimation] 		= %anim;
		$CruSpell[%spell,$CSOffense] 		= %req @ " 100";
		$CruSpell[%spell,$CSDefense] 		= "SpellResistance 100";
		$CruSpell[%spell,$CSSC] 		= 0;
		$CruSpell[%spell,$CSCritChance] 	= %critchance;
		$CruSpell[%spell,$CSCritDamage]		= %critdamage;

		AutoSpellCrystal(%spell,%ql,%req @ " " @ %sorc @ " MANA " @ %mana,%req);

		if (%i == 0) %ql = 0;
	}
}

$SpellSet[FIRE,0] = "Fireball Smoke Melt Magma Firestorm Hellfire";
$SpellSet[FIRE,1] = "ANIM_FIREBALL ANIM_SMOKE ANIM_MELT ANIM_MAGMA ANIM_FIRESTORM ANIM_HELLFIRE";
$SpellSet[FIRE,2,Fireball] = "Summons a fireball";
$SpellSet[FIRE,2,Smoke] = "Cast a deadly smoke cloud";
$SpellSet[FIRE,2,Melt] = "Melt the flesh off your enemy";
$SpellSet[FIRE,2,Magma] = "Summon magma from deep within";
$SpellSet[FIRE,2,Firestorm] = "Rain fire on your enemy";
$SpellSet[FIRE,2,Hellfire] = "Conjure fire from the depths of hell";

$SpellSet[COLD,0] = "Icicle Frost Hail Snowstorm Avalanche Icetwister";
$SpellSet[COLD,1] = "ANIM_ICICLE ANIM_FROST ANIM_HAIL ANIM_SNOWSTORM ANIM_AVALANCHE ANIM_ICETWISTER";
$SpellSet[COLD,2,Icicle] = "";
$SpellSet[COLD,2,Frost] = "";
$SpellSet[COLD,2,Hail] = "";
$SpellSet[COLD,2,Snowstorm] = "";
$SpellSet[COLD,2,Avalanche] = "";
$SpellSet[COLD,2,Icetwister] = "";

$SpellSet[ENERGY,0] = "Spark Shock Bolt Lightning Supernova Rift";
$SpellSet[ENERGY,1] = "ANIM_SPARK ANIM_SHOCK ANIM_BOLT ANIM_LIGHTNING ANIM_SUPERNOVA ANIM_RIFT";
$SpellSet[ENERGY,2,Spark] = "";
$SpellSet[ENERGY,2,Shock] = "";
$SpellSet[ENERGY,2,Bolt] = "";
$SpellSet[ENERGY,2,Lightning] = "";
$SpellSet[ENERGY,2,Supernova] = "";
$SpellSet[ENERGY,2,Rift] = "";

$SpellSet[POISON,0] = "Thorn Viper Plague Cobra Swarm Blackdeath";
$SpellSet[POISON,1] = "ANIM_THORN ANIM_FANGS ANIM_PLAGUE ANIM_COBRA ANIM_SWARM ANIM_BLACKDEATH";
$SpellSet[POISON,2,Thorn] = "";
$SpellSet[POISON,2,Viper] = "";
$SpellSet[POISON,2,Plague] = "";
$SpellSet[POISON,2,Cobra] = "";
$SpellSet[POISON,2,Swarm] = "";
$SpellSet[POISON,2,Blackdeath] = "";

$SpellSet[MELEE,0] = "Ironfist ChaosSlash PowerPunch ChaosClaws ThorsHammer Swordstorm";
$SpellSet[MELEE,1] = "ANIM_IRONFIST ANIM_CHAOSSLASH ANIM_POWERPUNCH ANIM_CHAOSCLAWS ANIM_THORSHAMMER ANIM_SWORDSTORM";
$SpellSet[MELEE,2,Ironfist] = "";
$SpellSet[MELEE,2,ChaosSlash] = "";
$SpellSet[MELEE,2,PowerPunch] = "";
$SpellSet[MELEE,2,ChaosClaws] = "";
$SpellSet[MELEE,2,ThorsHammer] = "";
$SpellSet[MELEE,2,Swordstorm] = "";

$SpellSet[PROJECTILE,0] = "Rock ChaosKnife Volley Tornado ChaosArrow Meteor";
$SpellSet[PROJECTILE,1] = "ANIM_ROCK ANIM_CHAOSKNIFE ANIM_VOLLEY ANIM_TORNADO ANIM_CHAOSARROW ANIM_METEOR";
$SpellSet[PROJECTILE,2,Rock] = "";
$SpellSet[PROJECTILE,2,ChaosKnife] = "";
$SpellSet[PROJECTILE,2,Volley] = "";
$SpellSet[PROJECTILE,2,Tornado] = "";
$SpellSet[PROJECTILE,2,ChaosArrow] = "";
$SpellSet[PROJECTILE,2,Meteor] = "";

// %spellset,%category,%damagetype,%damage,%range,%mana,%cast,%cooldown,%mincast,%mincooldown,%critchance,%critdamage)
AutoDamageSpell("FIRE","FireElemental","Fire",816,15,150,3,4,1,2,5,5);
AutoDamageSpell("COLD","ColdElemental","Cold",544,10,100,2,2,1,1,10,10);
AutoDamageSpell("ENERGY","EnergyElemental","Energy",544,10,100,2,2,1,1,10,10);
AutoDamageSpell("POISON","PoisonCasting","Poison",272,5,50,1,2,0,1,15,15);
AutoDamageSpell("MELEE","MeleeCasting","Melee",272,5,50,1,2,0,1,15,15);
AutoDamageSpell("PROJECTILE","ProjectileCasting","Projectile",816,15,150,3,4,1,2,5,5);

$SpellEndOnNoMana["FireAura"] = 1;
$SpellEndOnNoMana["IcebornAegis"] = 1;
$SpellEndOnNoMana["LightningShield"] = 1;

// function AutoSpell(%spell,%dispname,%num,%type,%mode,%hostile,%req,%class,%effect,%take,%cast,%recover,%sc,%dur,%tree,%category,%anim,%ico,%desc,%conv,%rev,%silent,%ticks,%durstep,%start,%max,%lvlreq,%dot,%dotint,%dotticks,%flat)

// SPELL DISPNAME NUM TYPE MODE HOSTLE REQ CLASS EFFECT TAKE CAST RECOVER SC DUR TREE CATEGORY ANIM ICO DESC CONV REV SILENT TICKS DURSTEP START MAX LVLREQ DOT DOTINT DOTTICKS FLAT

//===============================================================================================================================
// PRIMAL
AutoSpell("Brute","Brute",10,"FRIEND","LOS",0,"PrimalMagic","LVLG 0.5","ADDALLOFF 100 ARMORPEN 2500 PHYSICALDAMAGE 30:50 WEAPONRANGE 30:50 PHYSBASE 150 RANGEDBASE 100","MANA 1.0",2.5,5,1.0,3600,"Combat","Brute","ANIM_BODY_OFF","icos_brute"," You brute force your way to victory",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Knight","Knight",15,"FRIEND","LOS",0,"PrimalMagic","LVLG 0.5","SLASHING 575 CLEAVE 575","MANA 1.0",2.5,5,1.0,3600,"Slashing","Knight","ANIM_WEAPON_OFF","icos_knight"," You arm yourself with the mighty sword ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Duelist","Duelist",15,"FRIEND","LOS",0,"PrimalMagic","LVLG 0.5","PIERCING 575 BACKSTABBING 575","MANA 1.0",2.5,5,1.0,3600,"Piercing","Duelist","ANIM_BODY_OFF","icos_duelist"," You skill yourself in the art of fencing ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Guardian","Guardian",15,"FRIEND","LOS",0,"PrimalMagic","LVLG 0.5","BLUDGEONING 575 BASHING 575 INCSTUN 5:10","MANA 1.0",2.5,5,1.0,3600,"Bludgeoning","Guardian","ANIM_BODY_OFF","icos_Guardian"," Raise the hammer high! ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Marksman","Marksman",15,"FRIEND","LOS",0,"PrimalMagic","LVLG 0.5","ARCHERY 575 AIMING 575","MANA 1.0",2.5,5,1.0,3600,"Archery","Marksman","ANIM_BODY_OFF","icos_Marksman"," Steady your aim ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Master","Master",10,"FRIEND","LOS",0,"PrimalMagic","LVLG 0.5","WEAPONHANDLING 575","MANA 1.0",2.5,5,1.0,3600,"Weaponhandling","Master","ANIM_BODY_OFF","icos_Master"," Master of Arms ",6,0,0,0,0,-1,-1,0.5);
//***************************************************************************************************
AutoSpell("Ragebeast","Ragebeast",10,"FRIEND","LOS",0,"PrimalMagic","MUSTBENORMAL 1 LVLG 0.5","CHANGERACE Minotaur SELFCAST RagebeastCooldown MAXHP 1500 PHYSBASE 85 RANGEDBASE 75 ACCURACY 1500","HEALTH 3.0",2.5,5,1.0,60,"Ragebeast","Ragebeast","ANIM_BODY_OFF","icos_Ragebeast","You are filled with rage",1,0,0,0,0,-1,-1,0.5,"HEAL 600",1,60);
AutoSpell("Spectralthrow","Spectralthrow",15,"FOE","LOS",1,"PrimalMagic","USINGMELEE 1 LVLG 0.5","AUTOWEAPON 75:125","MANA 0.5",1.5,3,0,0,"Spectralthrow","Spectralthrow","ANIM_WEAPON_THROW","icos_Spectralthrow","You hurl your weapon in spectral form",0,0,0,0,0,-1,-1,0,"","","","","PRIMALMAGIC 50 WEAPONSKILL 50","SPELLRESISTANCE 50 EVADEMELEE 50",20,"","PHYSBASE 237 OVERRIDEDT SPECTRAL");
AutoSpell("Graspinghook","Graspinghook",15,"FOE","LOS",1,"PrimalMagic","LVLG 0.5","TELEPORTTOCASTER 1 Damage:Fire 250 ROOT 1","MANA 0.5",1.5,3,0,5,"Graspinghook","Graspinghook","ANIM_WEAPON_OFF","icos_Graspinghook","You pull your target to you, damaging them",0,0,0,0,0,-1,-1,0,"","","","","PRIMALMAGIC 100","SPELLRESISTANCE 100",20);
AutoSpell("MartialStudies","MartialStudies",15,"FRIEND","LOS",0,"PrimalMagic","LVLG 0.5","MARTIALARTS 575 BRAWLING 575 MAACCURACY 575","MANA 1.0",2.5,5,1.0,3600,"MartialArts","MartialStudies","ANIM_BODY_OFF","icos_MartialStudies","To find inner peace",7,0,0,0,0,-1,-1,0.5);
AutoSpell("MeleeSplash","MeleeSplash",15,"FRIEND","LOS",0,"PrimalMagic","LVLG 0.5","MELEESPLASH 1:1 LESSMULTI 50:35","MANA 0.5",2.5,5,0,3600,"Meleesplash","MeleeSplash","ANIM_WEAPON_OFF","icos_Meleesplash","Your melee hits damage surrounding targets",7,0,0,0,0,-1,-1,0.5);
AutoSpell("MultiArrow","Multiarrow",15,"FRIEND","LOS",0,"PrimalMagic","USINGRANGED 1 LVLG 0.5","MULTIARROW 3:6 LESSMULTI 50:35","MANA 0.5",2.5,5,0,3600,"Multishot","Multiarrow","ANIM_WEAPON_OFF","icos_Multiarrow","You fire multiple arrows at surrounding targets",7,0,0,0,0,-1,-1,0.5);

//===============================================================================================================================
// HOLY
AutoSpell("Templar","Templar",10,"FRIEND","LOS",0,"HolyMagic","LVLG 0.5","ADDALLDEF 100 ARMOR 2000 AVOIDSTUN 10:20 INCARMOR 50:100","MANA 1.0",2.5,5,1.0,3600,"Armor","Templar","ANIM_WEAPON_DEF","icos_Templar"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Enforcer","Enforcer",15,"FRIEND","LOS",0,"HolyMagic","LVLG 0.5","MAXHP 1000 HEALDELTA 100 ENDURANCE 575 BANDAGE 1000","MANA 1.0",2.5,5,1.0,3600,"Health","Enforcer","ANIM_BODY_DEF","icos_Enforcer"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Saint","Saint",15,"FRIEND","LOS",0,"HolyMagic","LVLG 0.5","HEALING 575 HEALING% 10:30","MANA 1.0",2.5,5,1.0,3600,"Healing","Saint","ANIM_BODY_DEF","icos_Saint"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Dragonguard","Dragonguard",15,"FRIEND","LOS",0,"HolyMagic","LVLG 0.5","BLOCKHIT% 5:10 RIPOSTE 1000 SHIELDBONUS 10:30 BLOCKAMMOUNT 2000","MANA 1.0",2.5,5,1.0,3600,"Shield","Dragonguard","ANIM_WEAPON_DEF","icos_Dragonguard"," Description ",7,0,0,0,0,-1,-1,0.5);
//***************************************************************************************************
AutoSpell("IcebornAegis","IcebornAegis",10,"FRIEND","LOS",0,"HolyMagic","LVLG 0.5","ARMOR 3000 INCARMOR 50:150 CHILLONHIT 1 SETAURA COLD","MANA 1.0",2.5,5,1.0,1800,"IcebornAegis","IcebornAegis","ANIM_BODY_DEF","icos_IcebornAegis"," You increase your Armor greatly, and chill attackers on hit",1,0,0,0,0,-1,-1,0.5,"TEAMAOECAST IcebornAura* DRAINMANA 960",3,600,"","","",20,"","","ARMOR 1500",10,"IcebornAura",0);
AutoSpell("Shieldbash","Shieldbash",15,"FOE","LOS",1,"HolyMagic","USINGSHIELD 1 LVLG 0.5","SHIELDHIT 100:200 SHIELDSTUN 1","MANA 1.0",1.5,2.5,0,0,"Shieldbash","Shieldbash","ANIM_TRADE_1","icos_Shieldbash","You bash your enemy with your Shield, hitting them for Shield Block Amount. Chance to stun your enemy based on Shield Block Chance.",0,0,0,0,0,-1,-1,0,"","","","","HOLYMAGIC 100","SPELLRESISTANCE 100",10);
AutoSpell("Heal","Heal",15,"FRIEND","LOS",0,"HolyMagic","LVLG 0.5","HEAL 4950","MANA 2.0",2.5,5,0.0,0,"Heal","Heal","ANIM_HEAL_1","icos_Heal"," You Heal your Friendly Target",0,0,0,0,0,-1,-1,0.0);
AutoSpell("Radiance","Radiance",15,"FRIEND","SELF",0,"HolyMagic","LVLG 0.5","TEAMHEAL 1650","MANA 2.0",2.5,5,0.0,0,"Radiance","Radiance","ANIM_HEAL_1","icos_Radiance"," You Heal your Team",0,0,0,0,0,-1,-1,0.0);
AutoSpell("Revitalize","Revitalize",10,"FRIEND","LOS",0,"HolyMagic","LVLG 0.5","","MANA 1.0",2.5,5,1.0,1800,"Revitalize","Revitalize","ANIM_BODY_DEF","icos_Revitalize","You are being healed",10,0,0,0,0,-1,-1,0.5,"HEAL 500",10,180,"","","","","ANIM_HEAL_1");

//===============================================================================================================================
// EMPOWERMENT
AutoSpell("Scholar","Scholar",3,"FRIEND","LOS",0,"Empowerment","NA","ADDEXP 10:30","MANA 0.5",5,5,0.5,3600,"Exp","Scholar","ANIM_BODY_NEU","icos_Scholar"," Description ",999,0,0,0,0,10,30,0);
AutoSpell("Lifting","Lifting",10,"FRIEND","LOS",0,"Empowerment","NA","MAXWEIGHT 2000 WEIGHTCAPACITY 575","MANA 1.0",5,5,0.5,3600,"Weightcap","Lifting","ANIM_BODY_NEU","icos_Lifting"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Warcry","Warcry",10,"FRIEND","LOS",0,"Empowerment","NA","SPEECH 575 ANGER 3000","MANA 1.0",5,5,0.5,3600,"Speech","Warcry","ANIM_BODY_OFF","icos_Warcry"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Champion","Champion",15,"FRIEND","LOS",0,"Empowerment","NA","STRENGTH 575","MANA 1.0",5,5,1.0,3600,"Champion","Champion","ANIM_BODY_NEU","icos_Champion"," Description ",11,0,0,0,0,-1,-1,0.5);
AutoSpell("Artisan","Artisan",10,"FRIEND","LOS",0,"Empowerment","NA","SMITHING 575 SMITHREQ 10:20","MANA 1.0",5,5,1.0,3600,"Artisan","Artisan","ANIM_BODY_NEU","icos_Artisan"," Description ",6,0,0,0,0,-1,-1,0.2);
AutoSpell("Keeper","Keeper",15,"FRIEND","LOS",0,"Empowerment","NA","PRIMALMAGIC 575 HOLYMAGIC 575 EMPOWERMENT 575","MANA 1.0",5,5,1.0,3600,"Keeper","Keeper","ANIM_BODY_NEU","icos_Keeper"," Description ",7,0,0,0,0,-1,-1,0.9);

//===============================================================================================================================
// DARK
AutoSpell("Spellthief","Spellthief",10,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","ADDALLOFF 100 MAGICDAMAGE 40:50 WANDMAGIC 15:25 CASTRANGE 15:25 SPELLBASE 140","MANA 1.0",2.5,5,1.0,3600,"MagicCombat","Spellthief","ANIM_BODY_NEU","icos_Spellthief"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Ninja","Ninja",10,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","ADDALLOFF 100 PHYSICALDAMAGE 30:50 WEAPONRANGE 15:30 PHYSBASE 150 RANGEDBASE 100","MANA 1.0",2.5,5,1.0,3600,"Combat","Ninja","ANIM_WEAPON_OFF","icos_Ninja"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Puncture","Puncture",10,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","CRITCHANCE 25:100 CRITDAMAGE 25:100","MANA 1.0",2.5,5,1.0,3600,"Crit","Puncture","ANIM_WEAPON_OFF","icos_Puncture"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Exaction","Exaction",10,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","SPELLCRIT 25:100 SPCRITDAMAGE 25:100","MANA 1.0",2.5,5,1.0,3600,"Spellcrit","Exaction","ANIM_BODY_OFF","icos_Exaction"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Outlaw","Outlaw",15,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","PIERCING 575 BACKSTABBING 575","MANA 1.0",2.5,5,1.0,3600,"Piercing","Outlaw","ANIM_BODY_OFF","icos_Outlaw"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Sharpshooter","Sharpshooter",15,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","ARCHERY 575 AIMING 575 XBOWDAMAGE 5:15","MANA 1.0",2.5,5,1.0,3600,"Archery","Sharpshooter","ANIM_BODY_OFF","icos_Sharpshooter"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Spiritist","Spiritist",3,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","MINIONHEALTH 50:100 MINIONDAMAGE 50:100","MANA 1.0",2.5,5,1.0,3600,"Minion","Spiritist","ANIM_BODY_OFF","icos_Spiritist"," Description ",7,0,0,0,0,20,60,0.5);
AutoSpell("Sharpcast","Sharpcast",15,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","CASTINIT 575 SPELLCAPACITY 575 COOLDOWN 10:20","MANA 1.0",2.5,5,1.0,3600,"Focus","Sharpcast","ANIM_BODY_OFF","icos_Sharpcast"," Description ",7,0,0,0,0,-1,-1,0.5);
//***************************************************************************************************
AutoSpell("Blinkstrike","Blinkstrike",15,"FOE","LOS",1,"DarkMagic","USINGMELEE 1 LVLG 0.5","AUTOWEAPON 50:150 CASTERTELEPORT 1","MANA 0.5",1.5,3,0,0,"Blinkstrike","Blinkstrike","ANIM_WEAPON_OFF","icos_Blinkstrike","You teleport to your target and strike them",0,0,0,0,0,-1,-1,0,"","","","","DARKMAGIC 50 WEAPONSKILL 50","SPELLRESISTANCE 50 EVADEMELEE 50",20,"","CRITCHANCE 80:180 CRITDAMAGE 80:180 PHYSBASE 125");
AutoSpell("SummonUndead","SummonUndead",15,"FRIEND","LOS",0,"DarkMagic","NOTMAXMINIONS 1 LVLG 0.5","SUMMONUNDEAD 300","MANA 1.0",2.5,5,0.0,0,"SummonUndead","SummonUndead","ANIM_BODY_OFF","icos_SummonUndead","You summon an Undead Minion",1,0,0,0,0,-1,-1,0.5);
AutoSpell("Hellchain","Hellchain",15,"FOE","LOS",1,"DarkMagic","LVLG 0.5","ROOT 1","MANA 0.5",1.5,3,0.0,5,"Hellchain","Hellchain","ANIM_HELLCHAIN","icos_Hellchain","Summon chains from hell to hold your target to the ground",0,0,0,0,0,-1,-1,0,"SelfDamage:Fire 300",1,5,"","DARKMAGIC 100","SPELLRESISTANCE 100");
AutoSpell("Deathsmark","Deathsmark",15,"FOE","LOS",1,"DarkMagic","LVLG 0.5","TAKECRIT 25:75 TAKECRITDAMAGE 25:75 TAKEPHYSDAMAGE 125","MANA 0.5",1.5,3,0,20,"Deathsmark","Deathsmark","ANIM_SHIELD_BASH","icos_Deathsmark","You are marked for Death!",0,0,0,0,0,-1,-1,0,"","","","","DARKMAGIC 100","SPELLRESISTANCE 100",10);
AutoSpell("Multishot","Multishot",15,"FRIEND","LOS",0,"DarkMagic","USINGRANGED 1 LVLG 0.5","MULTIARROW 3:6 LESSMULTI 50:35","MANA 0.5",2.5,5,0,3600,"Multishot","Multishot","ANIM_WEAPON_OFF","icos_Multishot","You fire multiple arrows at surrounding targets",7,0,0,0,0,-1,-1,0.5);
AutoSpell("DarkMaster","DarkMaster",15,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","MARTIALARTS 575 BRAWLING 575 CRITMA 50","MANA 1.0",2.5,5,1.0,3600,"MartialArts","DarkMaster","ANIM_BODY_OFF","icos_DarkMaster","To release inner rage",7,0,0,0,0,-1,-1,0.5);
AutoSpell("MultiMagic","MultiMagic",15,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","MULTISPELL 1:1 LESSMULTI 50:35","MANA 0.5",2.5,5,0,3600,"Multispell","MultiMagic","ANIM_SPELL_OFF","icos_Multispell","Your spells damage surrounding targets",7,0,0,0,0,-1,-1,0.5);
AutoSpell("MultiMelee","MultiMelee",15,"FRIEND","LOS",0,"DarkMagic","LVLG 0.5","MELEESPLASH 1:1 LESSMULTI 50:35","MANA 0.5",2.5,5,0,3600,"Meleesplash","MultiMelee","ANIM_WEAPON_OFF","icos_MultiMelee","Your melee hits damage surrounding targets",7,0,0,0,0,-1,-1,0.5);

//===============================================================================================================================
// LIGHT
AutoSpell("Avoidance","Avoidance",10,"FRIEND","LOS",0,"LightMagic","NA","ADDALLDEF 100 AVOIDPOISON 10:20 AVOIDCRIT 10:20 AVOIDSPCRIT 10:20","MANA 1.0",2.5,5,1.0,3600,"Avoidance","Avoidance","ANIM_BODY_DEF","icos_Avoidance"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Preservation","Preservation",10,"FRIEND","LOS",0,"LightMagic","NA","ARMOR 1000 ALLRESIST 1000 INCRESIST 20:50 INCARMOR 20:50","MANA 1.0",2.5,5,1.0,3600,"Armor Resistance","Preservation","ANIM_BODY_DEF","icos_Preservation"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Nimble","Nimble",10,"FRIEND","LOS",0,"LightMagic","NA","EVASION 2000 INCEVASION 70:100","MANA 1.0",2.5,5,1.0,3600,"Evasion","Nimble","ANIM_BODY_DEF","icos_Nimble"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Elude","Elude",10,"FRIEND","LOS",0,"LightMagic","NA","DODGING 575 EVADEMELEE 575","MANA 1.0",2.5,5,1.0,3600,"Hardevade","Elude","ANIM_BODY_DEF","icos_Elude"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Diffraction","Diffraction",10,"FRIEND","LOS",0,"LightMagic","NA","SPELLRESISTANCE 287","MANA 1.0",2.5,5,1.0,3600,"Spellresistance","Diffraction","ANIM_BODY_DEF","icos_Diffraction"," Description ",6,0,0,0,0,-1,-1,0.5);
//***************************************************************************************************
AutoSpell("Foolsdance","Foolsdance",10,"FRIEND","LOS",0,"LightMagic","LVLG 0.5","DODGING 1000 EVADEMELEE 1000 ADDALLDEF 500 SELFCAST FoolsdanceCooldown","MANA 1.0",1.5,3.5,1.0,30,"Foolsdance","Foolsdance","ANIM_BODY_DEF","icos_Foolsdance","You greatly increase your defenses",1,0,0,0,0,-1,-1,0.5);
AutoSpell("Nullify","Nullify",10,"FRIEND","LOS",0,"LightMagic","LVLG 0.5","ABSORB 7500 SETAURA ABSORB TEAMAOECAST NullifyAura*","MANA 1.0",1.5,3,1.0,120,"Nullify","Nullify","ANIM_BODY_DEF","icos_Nullify"," You cast an Absorb shield",1,0,0,0,0,-1,-1,0.5,"","","","","","",20,"","","ABSORB 3750 SETAURA ABSORB",10,"NullifyAura",0);

//===============================================================================================================================
// RITUAL
AutoSpell("Heartsoul","Heartsoul",10,"FRIEND","LOS",0,"Ritual","NA","MAXMANA 500 MAXHP 500","MANA 1.0",2.5,5,1.0,3600,"Health Mana","Heartsoul","ANIM_BODY_DEF","icos_Heartsoul"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Searching","Searching",3,"FRIEND","LOS",0,"Ritual","NA","GOLDFIND 10:30","MANA 0.5",2.5,5,0.5,3600,"Goldfind","Searching","ANIM_BODY_NEU","icos_Searching"," Description ",999,0,0,0,0,10,30,0);
AutoSpell("Bandit","Bandit",15,"FRIEND","LOS",0,"Ritual","NA","STEALING 575 HIDING 575","MANA 1.0",2.5,5,1.0,3600,"Stealing","Bandit","ANIM_BODY_DEF","icos_Bandit"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Grace","Grace",15,"FRIEND","LOS",0,"Ritual","NA","DEXTERITY 575","MANA 1.0",2.5,5,1.0,3600,"AgilitySense","Grace","ANIM_BODY_DEF","icos_Grace"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Mixing","Mixing",10,"FRIEND","LOS",0,"Ritual","NA","ALCHEMY 575 ALCHEMYREQ 10:20","MANA 1.0",2.5,5,1.0,3600,"Alchemy","Mixing","ANIM_BODY_DEF","icos_Mixing"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Murk","Murk",15,"FRIEND","LOS",0,"Ritual","NA","DARKMAGIC 575 LIGHTMAGIC 575 RITUAL 575","MANA 1.0",2.5,5,1.0,3600,"Murk","Murk","ANIM_BODY_DEF","icos_Murk"," Description ",6,0,0,0,0,-1,-1,0.9);
AutoSpell("Trader","Trader",10,"FRIEND","LOS",0,"Ritual","NA","HAGGLING 575","MANA 1.0",2.5,5,1.0,3600,"Haggling","Trader","ANIM_BODY_DEF","icos_Trader"," Description ",6,0,0,0,0,-1,-1,0.5);

//===============================================================================================================================
// SORCERY
$UNCASTSPELL["Discharge"] = 1;
$MINCAST["Discharge"] = 1;
$MINCOOLDOWN["Discharge"] = 1;
AutoSpell("Warlock","Warlock",10,"FRIEND","LOS",0,"Sorcery","NA","ADDALLOFF 100 MAGICPEN 1500 MAGICDAMAGE 40:50 STAFFMAGIC 15:25 WANDMAGIC 15:25 CASTRANGE 30:50 SPELLBASE 140","MANA 1.0",2.5,5,1.0,3600,"MagicCombat","Warlock","ANIM_BODY_OFF","icos_Warlock"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Magus","Magus",15,"FRIEND","LOS",0,"Sorcery","NA","CASTINIT 575 SPELLCAPACITY 575 COOLDOWN 5:10","MANA 1.0",2.5,5,1.0,3600,"Focus","Magus","ANIM_BODY_OFF","icos_Magus"," Description ",7,0,0,0,0,-1,-1,0.5);
//***************************************************************************************************
AutoSpell("Incinerate","Incinerate",15,"FRIEND","SELF",0,"Sorcery","LVLG 0.5","SETAURA FIRE","MANA 1.0",2.5,5,1.0,1800,"FireAura","Incinerate","ANIM_SPELL_OFF","icos_Incinerate","You burn enemies around you",0,0,0,0,0,-1,-1,0.5,"AOEDamageSpell:FIRE 136%25 DRAINMANA 640",2,900);
AutoSpell("Being","Being",10,"FRIEND","SELF",0,"Sorcery","MUSTBENORMAL 1 LVLG 0.5","CHANGERACE Arcane SELFCAST BeingCooldown CASTINIT 6000 MAXCOOLDOWN 70:90 COOLDOWN 40:60 OVERRIDEDT ARCANE MAGICDAMAGE 30:50 SPELLBASE 365 SPELLACCURACY 150","MANA 1.0",2.5,5,1.0,30,"Being","Being","ANIM_SPELL_OFF","icos_Being","You are tranformed into pure Arcane Energy",0,0,0,0,0,-1,-1,0.5,"DRAINMANA 300",1,30);
AutoSpell("Discharge","Discharge",10,"FRIEND","SELF",0,"Sorcery","LVLG 0.5","SELFCAST DischargeCooldown OVERRIDEDT ARCANE SPELLBASE 500 DISCHARGE 1","MANA 0.0",2.5,5,0.0,0,"Discharge","Discharge","ANIM_DISCHARGE","icos_Discharge","You discharge all of your Energy",0,0,0,0,0,-1,-1,0.5);
AutoSpell("Snare","Snare",15,"FOE","LOS",1,"Sorcery","LVLG 0.5","ROOT 1","MANA 1.0",2,4,0.0,5,"Snare","Snare","ANIM_BODY_NEU","icos_Hellchain","Snare your target",0,0,0,0,0,-1,-1,0,"SelfDamage:Energy 100",1,5,"","SORCERY 100","SPELLRESISTANCE 100");
// REMOVED
//AutoSpell("Conjuring","Conjuring",10,"FRIEND","LOS",0,"Sorcery","NA","STAFFMAGIC 30:35 WANDMAGIC 30:35 SPELLBASE 136","MANA 1.0",2.5,5,1.0,3600,"Wandstaff","Conjuring","ANIM_BODY_OFF","icos_Conjuring"," Description ",6,0,0,0,0,-1,-1,0.5);
//AutoSpell("Elementalist","Elementalist",10,"FRIEND","LOS",0,"Sorcery","NA","FIREDAMAGE% 5:15 COLDDAMAGE% 5:15 ENERGYDAMAGE% 5:15 INCCHILL 5:15 INCBURN 5:15 INCSHOCK 5:15 SPELLBASE 100","MANA 1.0",5,5,1.0,3600,"Elementaldamage","Elementalist","ANIM_BODY_OFF","icos_Elementalist"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Multispell","Multispell",15,"FRIEND","LOS",0,"Sorcery","LVLG 0.5","MULTISPELL 1:1 LESSMULTI 50:35","MANA 0.5",2.5,5,0,3600,"Multispell","Multispell","ANIM_SPELL_OFF","icos_Multispell","Your spells damage surrounding targets",7,0,0,0,0,-1,-1,0.5);

//===============================================================================================================================
// PROTECTION
$AUTOSPELLNOFLUXVAL["SHOCKONHIT"] = 1;
AutoSpell("Sourcevoid","Sourcevoid",10,"FRIEND","LOS",0,"Protection","NA","ADDALLDEF 100 ALLRESIST 2000 INCRESIST 50:100 AVOIDROOT 10:20 AVOIDCHILL 10:20 AVOIDBURN 10:20 AVOIDSHOCK 10:20","MANA 1.0",2.5,5,1.0,3600,"Resist","Sourcevoid","ANIM_BODY_OFF","icos_Sourcevoid"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Isolation","Isolation",15,"FRIEND","LOS",0,"Protection","NA","SPELLRESISTANCE 575","MANA 1.0",2.5,5,1.0,3600,"Spellreistance","Isolation","ANIM_BODY_OFF","icos_Isolation"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Brightguard","Brightguard",10,"FRIEND","LOS",0,"Protection","NA","BLOCKSPELL% 5:10 SHIELDBONUS 10:30 SPLBLOCKAMM 2000","MANA 1.0",2.5,5,1.0,3600,"Spellshield","Brightguard","ANIM_BODY_OFF","icos_Brightguard"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Shelter","Shelter",15,"FRIEND","SELF",0,"Protection","MUSTBENORMAL 1 LVLG 0.5","MAXMANA 10000 MANA% 50:60 DAMAGEMANA 100:100 CHANGERACE Shelter SELFCAST ShelterCooldown","MANA 0.0",2.5,5,1.0,30,"Shelter","Shelter","ANIM_BODY_DEF","icos_Discharge","You shelter yourself from harm",0,0,0,0,0,-1,-1,0.5);
AutoSpell("LightningShield","LightningShield",10,"FRIEND","LOS",0,"Protection","LVLG 0.5","ALLRESIST 3000 INCRESIST 50:150 SHOCKONHIT 1 LIGHTNINGHIT 600 SETAURA ENERGY","MANA 1.0",2.5,5,1.0,1800,"LightningShield","LightningShield","ANIM_BODY_DEF","icos_LightningShield","You increase your All Resist greatly. Attackers take Energy damage on hit and are shocked.",1,0,0,0,0,-1,-1,0.5,"TEAMAOECAST ResistAura* DRAINMANA 960",3,600,"","","",20,"","","ALLRESIST 1500",10,"ResistAura",0);

//===============================================================================================================================
// ENCHANTMENT
AutoSpell("Sourcetap","Sourcetap",10,"FRIEND","LOS",0,"Enchantment","NA","MAXMANA 1000 MANADELTA 200 ENERGY 575","MANA 1.0",2.5,5,1.0,3600,"Mana","Sourcetap","ANIM_BODY_OFF","icos_Sourcetap"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Charm","Charm",3,"FRIEND","LOS",0,"Enchantment","NA","MAGICFIND 10:30","MANA 0.5",2.5,5,0.5,3600,"Magicfind","Charm","ANIM_BODY_NEU","icos_Charm"," Description ",999,0,0,0,0,30,30,0);
AutoSpell("Stimulator","Stimulator",15,"FRIEND","LOS",0,"Enchantment","NA","INTELLIGENCE 575","MANA 1.0",2.5,5,1.0,3600,"Intpsy","Stimulator","ANIM_BODY_OFF","icos_Stimulator"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Understanding","Understanding",10,"FRIEND","LOS",0,"Enchantment","NA","LITERACY 575","MANA 1.0",2.5,5,1.0,3600,"Literacy","Understanding","ANIM_BODY_OFF","icos_Understanding"," Description ",6,0,0,0,0,-1,-1,0.5);
AutoSpell("Binding","Binding",10,"FRIEND","LOS",0,"Enchantment","NA","MAGICCRAFT 575 MAGICCRAFTREQ 10:20","MANA 1.0",2.5,5,1.0,3600,"Magiccraft","Binding","ANIM_BODY_OFF","icos_Binding"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Sage","Sage",10,"FRIEND","LOS",0,"Enchantment","NA","WISDOM 575 MAXMEMORY 100","MANA 1.0",2.5,5,0.1,3600,"Wisdom","Sage","ANIM_BODY_OFF","icos_Sage"," Description ",7,0,0,0,0,-1,-1,0.5);
AutoSpell("Crystalball","Crystalball",10,"FRIEND","LOS",0,"Enchantment","NA","SORCERY 575 PROTECTION 575 ENCHANTMENT 575","MANA 1.0",2.5,5,1.0,3600,"Crystalball","Crystalball","ANIM_BODY_OFF","icos_Crystalball"," Description ",7,0,0,0,0,-1,-1,0.9);
AutoSpell("Harvester","Harvester",15,"FRIEND","LOS",0,"Enchantment","NA","","MANA 1.0",2.5,5,1.0,3600,"Harvester","Harvester","ANIM_BODY_NEU","icos_Harvester","You harvest mana from your surroundings",7,0,0,0,0,-1,-1,0.5,"HEALMANA 1500",10,600,"","","","","ANIM_MANA_1");

//===============================================================================================================================
// ENEMYSPELLS
$ENEMYSPELL["Flashstrike"] = 1;
$ENEMYSPELL["ArcaneThrow"] = 1;
$ENEMYSPELL["Killhook"] = 1;
$ENEMYSPELL["Killshot"] = 1;
$ENEMYSPELL["SnakeGrasp"] = 1;
AutoSpell("Flashstrike","Flashstrike",30,"FOE","LOS",1,"DarkMagic","USINGMELEE 1 LVLG 0.0","AUTOWEAPON 75:175 CASTERTELEPORT 1","MANA 0.0",0,0,0,0,"Flashstrike","Flashstrike","ANIM_FLICKER","icos_Flashstrike","The monster teleports to you and slices you with their weapon",0,0,0,0,0,-1,-1,0,"","","","","DARKMAGIC 50 WEAPONSKILL 50","SPELLRESISTANCE 50 EVADEMELEE 50",20,"","CRITCHANCE 80:80 CRITDAMAGE 80:180 PHYSBASE 125","","","","",1);
AutoSpell("Arcanethrow","Arcanethrow",30,"FOE","LOS",1,"PrimalMagic","USINGMELEE 1 LVLG 0.0","AUTOWEAPON 75:175","MANA 0.0",0,0,0,0,"Arcanethrow","Arcanethrow","ANIM_WEAPON_THROW","icos_Arcanethrow","The monster throws his weapon at you in arcane form",0,0,0,0,0,-1,-1,0,"","","","","PRIMALMAGIC 50 WEAPONSKILL 50","SPELLRESISTANCE 50 EVADEMELEE 50",20,"","PHYSBASE 237 OVERRIDEDT Arcane");
AutoSpell("Killhook","Killhook",30,"FOE","LOS",1,"PrimalMagic","LVLG 0.5","TELEPORTTOCASTER 1 ROOT 1","MANA 0.0",0.0,0,0,5,"Killhook","Killhook","ANIM_WEAPON_OFF","icos_Killhook","The monster pulls you to him and roots you in place",0,0,0,0,0,-1,-1,0,"","","","","PRIMALMAGIC 100","SPELLRESISTANCE 100",20);
AutoSpell("Killshot","Killshot",30,"FOE","LOS",1,"DarkMagic","USINGRANGED 1 LVLG 0.5","AUTOWEAPON 125:175","MANA 0.0",0,0,0,0,"Killshot","Killshot","ANIM_MULTISHOT","icos_Killshot","The monster fires a massive bolt at you",0,0,0,0,0,-1,-1,0,"","","","","DARKMAGIC 50 WEAPONSKILL 50","SPELLRESISTANCE 50 DODGING 50",20,"","RANGEDBASE 212");
AutoSpell("SnakeGrasp","SnakeGrasp",30,"FOE","LOS",1,"DarkMagic","LVLG 0.5","ROOT 1","MANA 1.0",0,0,0.0,5,"SnakeGrasp","SnakeGrasp","ANIM_BODY_NEU","icos_SnakeGrasp","Your enemy holds you in place",0,0,0,0,0,-1,-1,0,"SelfDamage:Poison 100",1,5,"","DARKMAGIC 100","SPELLRESISTANCE 100");

// AUTOSMAGIC
$CruSpell[AutoMagic,$CSMinCast] 	= 1;
$CruSpell[AutoMagic,$CSMinCooldown] 	= 1;
$CruSpell[AutoMagic,$CSCritChance] 	= 5;
$CruSpell[AutoMagic,$CSCritDamage] 	= 5;

$CruSpell[IronbloodCooldown,$CSName] 		= "Ironblood Cooldown";
$CruSpell[IronbloodCooldown,$CSCategory] 	= "HOLY";
$CruSpell[IronbloodCooldown,$CSMustLearn] 	= 0;
$CruSpell[IronbloodCooldown,$CSReqs] 		= "HOLYMAGIC 0 MANA 0";
$CruSpell[IronbloodCooldown,$CSHostile] 	= 1;
$CruSpell[IronbloodCooldown,$CSMode] 		= "SELF";
$CruSpell[IronbloodCooldown,$CSTree] 		= "Ironblood 999";
$CruSpell[IronbloodCooldown,$CSCastTime] 	= 0;
$CruSpell[IronbloodCooldown,$CSRecovery] 	= 0;
$CruSpell[IronbloodCooldown,$CSDur] 		= 300;
$CruSpell[IronbloodCooldown,$CSHaveReqs] 	= "LVLG 0";
$CruSpell[IronbloodCooldown,$CSTake] 		= "MANA 0";
$CruSpell[IronbloodCooldown,$CSBonus] 		= "NA 0";
$CruSpell[IronbloodCooldown,$CSInfo] 		= "You cannot use Iron blood";
$CruSpell[IronbloodCooldown,$CSAnimation] 	= "ENERGY1";
$CruSpell[IronbloodCooldown,$CSOffense] 	= "HolyMagic 1000";
$CruSpell[IronbloodCooldown,$CSDefense] 	= "SpellResistance 0";
$CruSpell[IronbloodCooldown,$CSSC] 		= 0;
$CruSpell[IronbloodCooldown,$NoClearFlag] 	= 1;

$CruSpell[RagebeastCooldown,$CSName] 		= "Ragebeast Cooldown";
$CruSpell[RagebeastCooldown,$CSCategory] 	= "PRIMAL";
$CruSpell[RagebeastCooldown,$CSMustLearn] 	= 0;
$CruSpell[RagebeastCooldown,$CSReqs] 		= "PRIMALMAGIC 0 MANA 0";
$CruSpell[RagebeastCooldown,$CSHostile] 	= 1;
$CruSpell[RagebeastCooldown,$CSMode] 		= "SELF";
$CruSpell[RagebeastCooldown,$CSTree] 		= "Ragebeast 999";
$CruSpell[RagebeastCooldown,$CSCastTime] 	= 0;
$CruSpell[RagebeastCooldown,$CSRecovery] 	= 0;
$CruSpell[RagebeastCooldown,$CSDur] 		= 120;
$CruSpell[RagebeastCooldown,$CSHaveReqs] 	= "LVLG 0";
$CruSpell[RagebeastCooldown,$CSTake] 		= "MANA 0";
$CruSpell[RagebeastCooldown,$CSBonus] 		= "NA 0";
$CruSpell[RagebeastCooldown,$CSInfo] 		= "You cannot use Ragebeast";
$CruSpell[RagebeastCooldown,$CSAnimation] 	= "ENERGY1";
$CruSpell[RagebeastCooldown,$CSOffense] 	= "PrimalMagic 1000";
$CruSpell[RagebeastCooldown,$CSDefense] 	= "SpellResistance 0";
$CruSpell[RagebeastCooldown,$CSSC] 		= 0;
$CruSpell[RagebeastCooldown,$NoClearFlag] 	= 1;

$CruSpell[BeingCooldown,$CSName] 		= "Being Cooldown";
$CruSpell[BeingCooldown,$CSCategory] 		= "SORCERY";
$CruSpell[BeingCooldown,$CSMustLearn] 		= 0;
$CruSpell[BeingCooldown,$CSReqs] 		= "SORCERY 0 MANA 0";
$CruSpell[BeingCooldown,$CSHostile] 		= 1;
$CruSpell[BeingCooldown,$CSMode] 		= "SELF";
$CruSpell[BeingCooldown,$CSTree] 		= "Being 999";
$CruSpell[BeingCooldown,$CSCastTime] 		= 0;
$CruSpell[BeingCooldown,$CSRecovery] 		= 0;
$CruSpell[BeingCooldown,$CSDur] 		= 120;
$CruSpell[BeingCooldown,$CSHaveReqs] 		= "LVLG 0";
$CruSpell[BeingCooldown,$CSTake] 		= "MANA 0";
$CruSpell[BeingCooldown,$CSBonus] 		= "NA 0";
$CruSpell[BeingCooldown,$CSInfo] 		= "You cannot use Being";
$CruSpell[BeingCooldown,$CSAnimation] 		= "ENERGY1";
$CruSpell[BeingCooldown,$CSOffense] 		= "Sorcery 1000";
$CruSpell[BeingCooldown,$CSDefense] 		= "SpellResistance 0";
$CruSpell[BeingCooldown,$CSSC] 			= 0;
$CruSpell[BeingCooldown,$NoClearFlag] 		= 1;

$CruSpell[DischargeCooldown,$CSName] 		= "Discharge Cooldown";
$CruSpell[DischargeCooldown,$CSCategory] 	= "SORCERY";
$CruSpell[DischargeCooldown,$CSMustLearn] 	= 0;
$CruSpell[DischargeCooldown,$CSReqs] 		= "SORCERY 0 MANA 0";
$CruSpell[DischargeCooldown,$CSHostile] 	= 1;
$CruSpell[DischargeCooldown,$CSMode] 		= "SELF";
$CruSpell[DischargeCooldown,$CSTree] 		= "Discharge 999";
$CruSpell[DischargeCooldown,$CSCastTime] 	= 0;
$CruSpell[DischargeCooldown,$CSRecovery] 	= 0;
$CruSpell[DischargeCooldown,$CSDur] 		= 120;
$CruSpell[DischargeCooldown,$CSHaveReqs] 	= "LVLG 0";
$CruSpell[DischargeCooldown,$CSTake] 		= "MANA 0";
$CruSpell[DischargeCooldown,$CSBonus] 		= "NA 0";
$CruSpell[DischargeCooldown,$CSInfo] 		= "You cannot use Discharge";
$CruSpell[DischargeCooldown,$CSAnimation] 	= "ENERGY1";
$CruSpell[DischargeCooldown,$CSOffense] 	= "Sorcery 1000";
$CruSpell[DischargeCooldown,$CSDefense] 	= "SpellResistance 0";
$CruSpell[DischargeCooldown,$CSSC] 		= 0;
$CruSpell[DischargeCooldown,$NoClearFlag] 	= 1;

$CruSpell[ShelterCooldown,$CSName] 		= "Shelter Cooldown";
$CruSpell[ShelterCooldown,$CSCategory] 		= "SORCERY";
$CruSpell[ShelterCooldown,$CSMustLearn] 	= 0;
$CruSpell[ShelterCooldown,$CSReqs] 		= "SORCERY 0 MANA 0";
$CruSpell[ShelterCooldown,$CSHostile] 		= 1;
$CruSpell[ShelterCooldown,$CSMode] 		= "SELF";
$CruSpell[ShelterCooldown,$CSTree] 		= "Shelter 999";
$CruSpell[ShelterCooldown,$CSCastTime] 		= 0;
$CruSpell[ShelterCooldown,$CSRecovery] 		= 0;
$CruSpell[ShelterCooldown,$CSDur] 		= 120;
$CruSpell[ShelterCooldown,$CSHaveReqs] 		= "LVLG 0";
$CruSpell[ShelterCooldown,$CSTake] 		= "MANA 0";
$CruSpell[ShelterCooldown,$CSBonus] 		= "NA 0";
$CruSpell[ShelterCooldown,$CSInfo] 		= "You cannot use Shelter";
$CruSpell[ShelterCooldown,$CSAnimation] 	= "ENERGY1";
$CruSpell[ShelterCooldown,$CSOffense] 		= "Protection 1000";
$CruSpell[ShelterCooldown,$CSDefense] 		= "SpellResistance 0";
$CruSpell[ShelterCooldown,$CSSC] 		= 0;
$CruSpell[ShelterCooldown,$NoClearFlag] 	= 1;

$CruSpell[FoolsdanceCooldown,$CSName] 		= "Foolsdance Cooldown";
$CruSpell[FoolsdanceCooldown,$CSCategory] 	= "LIGHT";
$CruSpell[FoolsdanceCooldown,$CSMustLearn] 	= 0;
$CruSpell[FoolsdanceCooldown,$CSReqs] 		= "LIGHTMAGIC 0 MANA 0";
$CruSpell[FoolsdanceCooldown,$CSHostile] 	= 1;
$CruSpell[FoolsdanceCooldown,$CSMode] 		= "SELF";
$CruSpell[FoolsdanceCooldown,$CSTree] 		= "Foolsdance 999";
$CruSpell[FoolsdanceCooldown,$CSCastTime] 	= 0;
$CruSpell[FoolsdanceCooldown,$CSRecovery] 	= 0;
$CruSpell[FoolsdanceCooldown,$CSDur] 		= 120;
$CruSpell[FoolsdanceCooldown,$CSHaveReqs] 	= "LVLG 0";
$CruSpell[FoolsdanceCooldown,$CSTake] 		= "MANA 0";
$CruSpell[FoolsdanceCooldown,$CSBonus] 		= "NA 0";
$CruSpell[FoolsdanceCooldown,$CSInfo] 		= "You cannot use Foolsdance";
$CruSpell[FoolsdanceCooldown,$CSAnimation] 	= "ENERGY1";
$CruSpell[FoolsdanceCooldown,$CSOffense] 	= "LightMagic 1000";
$CruSpell[FoolsdanceCooldown,$CSDefense] 	= "SpellResistance 0";
$CruSpell[FoolsdanceCooldown,$CSSC] 		= 0;
$CruSpell[FoolsdanceCooldown,$NoClearFlag] 	= 1;

$CruSpell[IcebornCooldown,$CSName] 		= "Iceborn Cooldown";
$CruSpell[IcebornCooldown,$CSCategory] 		= "HOLY";
$CruSpell[IcebornCooldown,$CSMustLearn] 	= 0;
$CruSpell[IcebornCooldown,$CSReqs] 		= "HOLYMAGIC 0 MANA 0";
$CruSpell[IcebornCooldown,$CSHostile] 		= 1;
$CruSpell[IcebornCooldown,$CSMode] 		= "SELF";
$CruSpell[IcebornCooldown,$CSTree] 		= "IcebornAegis 999";
$CruSpell[IcebornCooldown,$CSCastTime] 		= 0;
$CruSpell[IcebornCooldown,$CSRecovery] 		= 0;
$CruSpell[IcebornCooldown,$CSDur] 		= 70;
$CruSpell[IcebornCooldown,$CSHaveReqs] 		= "LVLG 0";
$CruSpell[IcebornCooldown,$CSTake] 		= "MANA 0";
$CruSpell[IcebornCooldown,$CSBonus] 		= "NA 0";
$CruSpell[IcebornCooldown,$CSInfo] 		= "You cannot use IcebornAegis";
$CruSpell[IcebornCooldown,$CSAnimation] 	= "ENERGY1";
$CruSpell[IcebornCooldown,$CSOffense] 		= "HolyMagic 1000";
$CruSpell[IcebornCooldown,$CSDefense] 		= "SpellResistance 0";
$CruSpell[IcebornCooldown,$CSSC] 		= 0;
$CruSpell[IcebornCooldown,$NoClearFlag] 	= 1;

$CruSpell["SelfSacrifice1",$CSName] 		= "Self Sacrifice I";
$CruSpell["SelfSacrifice1",$CSCategory] 	= "LIGHT";
$CruSpell["SelfSacrifice1",$CSMustLearn] 	= 0;
$CruSpell["SelfSacrifice1",$CSReqs] 		= "LIGHTMAGIC 0 MANA 0";
$CruSpell["SelfSacrifice1",$CSHostile] 		= 1;
$CruSpell["SelfSacrifice1",$CSMode] 		= "SELF";
$CruSpell["SelfSacrifice1",$CSTree] 		= "SelfSacrifice1 1";
$CruSpell["SelfSacrifice1",$CSCastTime] 	= 0;
$CruSpell["SelfSacrifice1",$CSRecovery] 	= 0;
$CruSpell["SelfSacrifice1",$CSDur] 		= 60;
$CruSpell["SelfSacrifice1",$CSHaveReqs] 	= "LVLG 0";
$CruSpell["SelfSacrifice1",$CSTake] 		= "MANA 0";
$CruSpell["SelfSacrifice1",$CSBonus] 		= "NA 0";
$CruSpell["SelfSacrifice1",$CSInfo] 		= "You have sacrificed Yourself";
$CruSpell["SelfSacrifice1",$CSAnimation] 	= "ENERGY1";
$CruSpell["SelfSacrifice1",$CSOffense] 		= "LIGHTMAGIC 1000";
$CruSpell["SelfSacrifice1",$CSDefense] 		= "SPELLRESISTANCE 0";
$CruSpell["SelfSacrifice1",$CSSC] 		= 0;
$CruSpell["SelfSacrifice1",$CSDOT] 		= "SelfSacrifice1DOT";
$CruDOT["SelfSacrifice1DOT",$CDOTBonus] 	= "Damage:unknown 100..100";
$CruDOT["SelfSacrifice1DOT",$CDOTInterval] 	= 2;
$CruDOT["SelfSacrifice1DOT",$CDOTHits] 		= 30;




echo("__AUTOSPELLS LOADED");

