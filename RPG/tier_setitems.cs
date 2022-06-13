//$DynamicItem["AmuletOfPower",$DName] = "Amulet Of Power";
//$DynamicItem["AmuletOfPower",$DMinMax] = "1 300";
//$DynamicItem["AmuletOfPower",$DWeight] = "1 0";
//$DynamicItem["AmuletOfPower",$DPrice] = "13333 13334";
//$DynamicItem["AmuletOfPower",$DWield] = "LOCATION amulet NA";
//$DynamicItem["AmuletOfPower",$DDesc] = "One powerful amulet.";
//$DynamicItem["AmuletOfPower",$DItemType] = "S2 Amulet";
//$DynamicItem["AmuletOfPower",$DTier] = 1;
//$DynamicItem["AmuletOfPower",$DTierHard] = "41";
//$DynamicItem["AmuletOfPower",$DTierProp] = 1;
//$DynamicItem["AmuletOfPower",$DTierPerc] = "100 110";
//$DynamicItem["AmuletOfPower",$DIco] = "ico_is_amulet.bmp";
//$DynamicItem["AmuletOfPower",$DSet] = "Power";

$SetPrice["S2"] 	= 66;
$SetPrice["S3"]		= 133;
$SetPrice["S4"]		= 266;
$SetIco["S2"] 		= "ico_is_";
$SetIco["S3"] 		= "ico_fs_";
$SetIco["S4"] 		= "ico_ms_";
$SetPerc["S2"] 		= "100 110";
$SetPerc["S3"] 		= "100 115";
$SetPerc["S4"] 		= "100 120";

$SetLocation["Amulet"] 		= "amulet";
$SetLocation["Chest"] 		= "chest";
$SetLocation["Head"] 		= "head";
$SetLocation["Ring"] 		= "ring";
$SetLocation["Hands"] 		= "hands";
$SetLocation["Legs"] 		= "legs";
$SetLocation["Boots"] 		= "boots";
$SetLocation["Talisman"]	= "talisman";
$SetLocation["Study"] 		= "study";
$SetLocation["Orb"] 		= "orb";

$SetLootI = 0;
function AddToSetLoot(%tname)
{
	%i = $SetLootI;
	$SetLootTable[%i] = %tname;
	$SetLootI++;
}


function CreateSet_UNUSED(%set,%mods,%slots,%type,%of,%renames,%props,%desc)
{
	echo("-------------------------------------------");
	// echo(" -------- CREATING SET ");
	// echo(" SET " @ %set);
	// echo(" MODS " @ %mods);
	// echo(" SLOTS " @ %slots);
	// echo(" TYPE " @ %type);
	// echo(" OF " @ %of);
	// echo(" RENAMES " @ %renames);
	// echo(" PROPS " @ %props);
	// CREATE CUSTOM NAMES
	// DEFAULT NAMES
	%name["Amulet"] = "Amulet";
	%name["Chest"] = "Chestplate";
	%name["Head"] = "Helm";
	%name["Ring"] = "Ring";
	%name["Hands"] = "Gloves";
	%name["Legs"] = "Leggings";
	%name["Boots"] = "Boots";
	%name["Talisman"] = "Talisman";
	%name["Study"] = "Tome";
	%name["Orb"] = "Orb";
	for (%i = 0; (%g = getWord(%renames,%i)) != -1; %i += 2) {
		// echo(" SETTING NAME " @ %g @ " " @ getWord(%renames,%i+1));
		%name[%g] = getWord(%renames,%i+1);
	}
	// echo(" --- START CYCLE LIST --- ");
	$SetBonus[%set,1] = "";
	for (%i = 0; (%g = getWord(%slots,%i)) != -1; %i++) {
		if (%of) {
			%tname = %name[%g] @ "Of" @ %set;
			%fname = %name[%g] @ " Of " @ %set;
		}
		else {
			%tname = %set @ %name[%g];
			%fname = %set @ " " @ %name[%g];
		}
		// echo (" TNAME " @ %tname);

		// ADD TO LOOT
		AddToSetLoot(%tname);

		$DynamicItem[%tname,$DName] = %fname;
		$DynamicItem[%tname,$DMinMax] = "1 300";
		$DynamicItem[%tname,$DWeight] = "1 0";
		$DynamicItem[%tname,$DPrice] = $SetPrice[%type] @ " " @ $SetPrice[%type];
		$DynamicItem[%tname,$DWield] = "LOCATION " @ $SetLocation[%g] @ " NA";
		if (%desc != "")
			$DynamicItem[%tname,$DDesc] = %desc;
		else
			$DynamicItem[%tname,$DDesc] = "No description.";
		$DynamicItem[%tname,$DItemType] = %type @ " " @ %g;
		$DynamicItem[%tname,$DTier] = 1;
		// CREATE HARD
		%hardlist = "";
		%checklist = "";
		// if (%g == "Chest") %hardlist = $ChestVar["Armor"];
		// if (%g == "Head") %hardlist = $HeadVar["Armor"];
		// if (%g == "Hands") %hardlist = $HandsVar["Armor"];
		// if (%g == "Legs") %hardlist = $LegsVar["Armor"];
		// if (%g == "Boots") %hardlist = $BootsVar["Armor"];
		for (%x = 0; (%y = getWord(%mods,%x)) != -1; %x++) {
			if (%g == "Amulet") { %c = $AmuletVar[%y]; %hardlist = %hardlist @ $AmuletVar[%y]; %checklist = %checklist @ getWord($AmuletVal[%c],0) @ " "; }
			if (%g == "Chest") { %c = $ChestVar[%y]; %hardlist = %hardlist @ $ChestVar[%y]; %checklist = %checklist @ getWord($ChestVal[%c],0) @ " "; }
			if (%g == "Head") { %c = $HeadVar[%y]; %hardlist = %hardlist @ $HeadVar[%y]; %checklist = %checklist @ getWord($HeadVal[%c],0) @ " "; }
			if (%g == "Ring") { %c = $RingVar[%y]; %hardlist = %hardlist @ $RingVar[%y]; %checklist = %checklist @ getWord($RingVal[%c],0) @ " "; }
			if (%g == "Hands") { %c = $HandsVar[%y]; %hardlist = %hardlist @ $HandsVar[%y]; %checklist = %checklist @ getWord($HandsVal[%c],0) @ " "; }
			if (%g == "Legs") { %c = $LegsVar[%y]; %hardlist = %hardlist @ $LegsVar[%y]; %checklist = %checklist @ getWord($LegsVal[%c],0) @ " "; }
			if (%g == "Boots") { %c = $BootsVar[%y]; %hardlist = %hardlist @ $BootsVar[%y]; %checklist = %checklist @ getWord($BootsVal[%c],0) @ " "; }
			if (%g == "Talisman") { %c = $TalismanVar[%y]; %hardlist = %hardlist @ $TalismanVar[%y]; %checklist = %checklist @ getWord($TalismanVal[%c],0) @ " "; }
			if (%g == "Study") { %c = $StudyVar[%y]; %hardlist = %hardlist @ $StudyVar[%y]; %checklist = %checklist @ getWord($StudyVal[%c],0) @ " "; }
			if (%g == "Orb") { %c = $OrbVar[%y]; %hardlist = %hardlist @ $OrbVar[%y]; %checklist = %checklist @ getWord($OrbVal[%c],0) @ " "; }
		}
		// echo(" HARD LIST " @ %hardlist);
		$DynamicItem[%tname,$DTierHard] = %hardlist;
		$DynamicItem[%tname,$DTierProp] = %props;
		$DynamicItem[%tname,$DTierPerc] = $SetPerc[%type];
		$DynamicItem[%tname,$DIco] = $SetIco[%type] @ $SetLocation[%g] @ ".bmp";
		$DynamicItem[%tname,$DSet] = %set;
		$SetBonus[%set,1] = $SetBonus[%set,1] @ %tname @ " ";
		echo(" CREATESETITEM " @ %tname @ " " @ %checklist);
	}
	//echo("-------------------------------------------");
}
 
// CreateSet("","","","S2",1,"",1);

// TIER 2: 1 RANDOM
CreateSet("Power","CriticalDamage","Amulet Ring Hands Talisman Study","S2",1,"Amulet Charm Ring Band",1,"One sought after unlimited power");
CreateSet("Precision","CriticalChance","Amulet Head Ring Hands Talisman Study","S2",1,"Ring Band",1,"The hand is quick to meet the eye");
CreateSet("Careful","AddAllDef","Amulet Chest Ring Legs Boots Orb Talisman","S2",0,"",1,"One can never be too careful");
CreateSet("Dark","Stealing","Amulet Hands Chest Ring Legs Boots Orb Talisman","S2",0,"Ring Seal Head Mask",1,"From the shadows he arised");
CreateSet("Speed","RunSpeed","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S2",1,"Boots Shoes Legs Pants Chest Shirt",1,"This is not a race");
CreateSet("Healthy","MaxHP","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S2",0,"Orb Sphere Head Cap",1,"Bringing health among the land");
CreateSet("Force","MaxMana","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S2",1,"Head Mask Study Book",1,"The unseen being this is");
CreateSet("Recharging","ManaDelta","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S2",0,"",1,"This armor glows");
CreateSet("Regeneration","HealDelta","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S2",0,"Amulet Charm Talisman Idol Legs Greaves",1,"Stay awhile and listen");
CreateSet("Protection","Armor","Amulet Head Ring Talisman Study Orb","S2",1,"",1,"Hold your shield high");
CreateSet("Resistance","AllResist","Amulet Head Ring Talisman Study Orb","S2",1,"Chest Breastplate",1,"Resistance is futile");
CreateSet("Thoughtful","AddEXP","Amulet Head Ring Talisman Study Orb","S2",0,"Amulet Charm Legs Greaves Orb Sphere Study Novel",1,"The thinking man carries the weight");
CreateSet("Forgiving","AddManaCost","Amulet Chest Ring Hands Talisman Study Orb","S2",0,"Head Crown",1,"You must forgive to forget");
CreateSet("Training","WeaponHandling","Amulet Chest Ring Hands Legs Boots Talisman Study Orb","S2",0,"Study Guide",1,"Study hard, train hard");
CreateSet("Lucky","GoldFind","Amulet Chest Head Ring Legs Boots Talisman Study Orb","S2",0,"Study Map Amulet Charm Ring Seal Orb Star Boots Shoes Chest Shirt",1,"You are feeling lucky today");
CreateSet("Searching","MagicFind","Amulet Chest Head Ring Legs Boots Talisman Study Orb","S2",0,"Amulet Charm Study Map Orb Star Boots Shoes Chest Shirt",1,"To find, one must search");
CreateSet("Might","AddDamage","Amulet Ring Hands Legs Boots Talisman Study Orb","S2",1,"Talisman Idol Boots Sabatons Legs Greaves Hands Gauntlets",1,"The mighty guardian");
CreateSet("Blood","LifeSteal","Amulet Talisman Study","S2",0,"Legs Greaves Hands Gauntlets",1);
// CreateSet("Barrier","Armor","Amulet Chest Ring Legs Boots Orb Talisman","S2",0,"Legs Greaves Hands Gauntlets",1);
CreateSet("Slaughter","AddAllOff","Amulet Chest Ring Hands Legs Talisman Study Orb","S2",1,"Legs Faulds Hands Gauntlets Chest Breastplate",1,"This armor is stained with blood");
CreateSet("Focus","MagicDamage","Amulet Chest Hands Talisman Study Orb","S2",0,"",1,"Focus on the task at hand");
CreateSet("Strong","ArmorPen","Amulet Chest Head Ring Hands Legs Boots Study Orb Talisman","S2",0,"Talisman Idol Boots Sabatons Legs Greaves Hands Gauntlets",1,"From strength we will reside");
CreateSet("Nexus","MagicPen","Amulet Chest Head Ring Hands Boots Talisman Study Orb","S2",0,"",1,"The core of your being");

// TIER 3: 1 RANDOM				     
CreateSet("Accurate","CriticalDamage CriticalChance","Amulet Ring Hands Talisman Study Legs","S3",0,"",1,"");
CreateSet("Hardend","CriticalDamage AddDamage","Amulet Ring Hands Talisman Study","S3",0,"",1,"");
CreateSet("Kindred","CriticalDamage LifeSteal","Amulet Talisman Study","S3",0,"",1,"");
CreateSet("Potent","CriticalDamage AddAllOff","Amulet Ring Hands Talisman Study","S3",0,"",1,"");
CreateSet("Bloodlust","CriticalChance LifeSteal","Amulet Talisman Study","S3",0,"",1,"");
CreateSet("Pain","CriticalChance AddAllOff","Amulet Ring Hands Talisman Study","S3",1,"",1,"");
CreateSet("Sinew","CriticalChance ArmorPen","Amulet Head Ring Hands Talisman Study","S3",1,"",1,"");
CreateSet("Gore","LifeSteal AddAllOff","Amulet Talisman Study","S3",1,"",1,"");
CreateSet("Averting","LifeSteal AddAllDef","Amulet Head","S3",0,"",1,"");
CreateSet("Vital","LifeSteal MaxHP","Amulet Talisman Study Head Legs","S3",0,"",1,"");
CreateSet("Cleaving","LifeSteal ArmorPen","Amulet Talisman Study","S3",0,"",1,"");
CreateSet("Balanced","AddAllOff AddAllDef","Amulet Chest Ring Legs Orb","S3",0,"",1,"");
CreateSet("Assault","AddAllOff WeaponHandling","Amulet Chest Ring Hands Legs Talisman Study Orb","S3",0,"",1,"");
CreateSet("Restraint","AddAllDef MaxHP","Amulet Chest Ring Legs Boots Orb Talisman","S3",1,"",1,"");
CreateSet("Refusing","AddAllDef Armor","Amulet Chest Ring Legs Boots Orb Talisman","S3",0,"",1,"");
CreateSet("Refraining","AddAllDef AllResist","Amulet Chest Legs Boots Head Ring Orb Talisman","S3",0,"",1,"");
CreateSet("Challenger","ArmorPen AddDamage","Amulet Ring Hands Legs Boots Talisman Study Orb","S3",0,"",1,"");
CreateSet("Rival","ArmorPen WeaponHandling","Amulet Chest Ring Hands Legs Boots Talisman Study Orb","S3",0,"",1,"");
CreateSet("Apprentice","MagicPen MagicDamage","Amulet Chest Hands Talisman Study Orb","S3",0,"",1,"");
CreateSet("Enlightend","MagicPen AddManaCost","Amulet Chest Ring Hands Talisman Study Orb","S3",0,"",1,"");
CreateSet("Blockade","Armor AllResist","Amulet Head Ring Legs Boots Talisman Study Orb","S3",0,"",1,"");
CreateSet("Vigor","Armor MaxHP","Amulet Head Ring Talisman Study Orb","S3",1,"",1,"");
CreateSet("Forgoing","AllResist MaxHP","Amulet Head Ring Talisman Study Orb","S3",0,"",1,"");
CreateSet("Refusal","AllResist MaxMana","Amulet Head Ring Talisman Study Orb","S3",1,"",1,"");
CreateSet("Warding","MaxHP MaxMana","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S3",0,"",1,"");
CreateSet("Zeal","MaxHP HealDelta","Amulet Chest Head Hands Legs Boots Talisman Study Orb","S3",1,"",1,"");
CreateSet("Effective","ManaDelta MaxMana","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S3",0,"",1,"");
CreateSet("Efficient","ManaDelta AddManaCost","Amulet Chest Ring Hands Talisman Study Orb","S3",0,"",1,"");
CreateSet("Divine","MagicDamage OffensiveCasting","Amulet Chest Hands Talisman Study Orb","S3",0,"",1,"");
CreateSet("Radiant","MagicDamage MaxMana","Amulet Chest Hands Talisman Study Orb","S3",0,"",1,"");
CreateSet("Shaman","MagicDamage ManaDelta","Amulet Chest Hands Talisman Study Orb","S3",0,"",1,"");
CreateSet("Greed","GoldFind MagicFind","Amulet Chest Head Ring Legs Boots Talisman Study Orb","S3",1,"",1,"");
CreateSet("Rouge","Sense Agility","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S3",0,"",1,"");
CreateSet("Wizard","Intelligence Psychic","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S3",0,"",1,"");
CreateSet("Warrior","Strength Stamina","Amulet Chest Head Ring Hands Legs Boots Talisman Study Orb","S3",0,"",1,"");

// TIER 4: 1 RANDOM
CreateSet("Battle","CriticalDamage CriticalChance AddDamage","Amulet Ring Hands Talisman Study","S4",1,"",1,"");
CreateSet("Dueling","CriticalDamage CriticalChance WeaponHandling","Amulet Ring Hands Talisman Study","S4",0,"",1,"");
CreateSet("Striking","CriticalDamage CriticalChance AddAllOff","Amulet Ring Hands Talisman Study","S4",0,"",1,"");
CreateSet("Decisive","CriticalDamage CriticalChance LifeSteal","Amulet Talisman Study","S4",0,"",1,"");
CreateSet("Clawing","CriticalChance LifeSteal AddAllOff","Amulet Talisman Study","S4",0,"",1,"");
CreateSet("Inflicting","CriticalChance MaxHP WeaponHandling","Amulet Ring Hands Talisman Study","S4",0,"",1,"");
CreateSet("Defile","CriticalChance AddDamage WeaponHandling","Amulet Ring Hands Talisman Study","S4",0,"",1,"");
CreateSet("Rage","CriticalChance AddDamage Slashing","Amulet Chest Ring Legs Orb","S4",1,"",1,"");
CreateSet("Boundless","AddAllOff AddAllDef MaxHP","Amulet Chest Ring Legs Orb","S4",0,"",1,"");
CreateSet("Fringe","AddAllOff AddAllDef MaxMana","Amulet Ring Hands Legs Talisman Study Orb","S4",0,"",1,"");
CreateSet("Mistreating","AddAllOff AddAllDef Armor","Amulet Ring Orb Head Chest Legs","S4",0,"",1,"");
CreateSet("Destroying","AddAllOff AddAllDef AllResist","Amulet Ring Orb Head Chest Legs","S4",0,"",1,"");
CreateSet("Harrowing","AddAllOff ArmorPen AddDamage","Amulet Ring Hands Legs Talisman Study Orb","S4",0,"",1,"");
CreateSet("Bitter","AddAllOff Armor WeaponHandling","Amulet Ring Talisman Study Orb Hands","S4",0,"",1,"");
CreateSet("Repairing","AddAllDef LifeSteal MaxHP","Amulet Head Chest","S4",0,"",1,"");
CreateSet("Conditioning","AddAllDef MaxHP MaxMana","Amulet Chest Ring Legs Boots Orb Talisman","S4",0,"",1,"");
CreateSet("Pith","MaxHP LifeSteal AllResist","Amulet Talisman Study","S4",1,"",1,"");
CreateSet("Ruling","MaxHP LifeSteal Armor","Amulet Talisman Study Head","S4",0,"",1,"");
CreateSet("Stressing","MaxHP MaxMana MaxWeight","Amulet Chest Hands Legs Boots Talisman Study Orb","S4",0,"",1,"");
CreateSet("Resiliance","MaxHP HealDelta ManaDelta","Amulet Chest Head Hands Legs Boots Talisman Study Orb","S4",1,"",1,"");
CreateSet("Mortal","Armor AllResist MaxHP","Amulet Head Ring Talisman Study Orb","S4",0,"",1,"");
CreateSet("Lifeblood","Armor AllResist LifeSteal","Amulet Talisman Study Hands","S4",1,"",1,"");
CreateSet("Living","Armor AllResist HealDelta","Amulet Head Talisman Study Orb Legs","S4",0,"",1,"");
CreateSet("Wealth","AddEXP GoldFind MagicFind","Amulet Head Ring Talisman Study Orb Legs Boots","S4",1,"",1,"");
CreateSet("Treasure","GoldFind MagicFind MaxWeight","Amulet Chest Legs Boots Talisman Study Orb","S4",1,"1",1,"");
CreateSet("Fortitude","HealDelta Stamina MaxHP","Amulet Chest Head Hands Legs Boots Talisman Study Orb","S4",0,"Chest Covering Boots Sabatons Legs Greaves",1,"");
CreateSet("Counjuring","MagicDamage AddManaCost MagicPen","Amulet Chest Hands Talisman Study Orb","S4",1,"",1,"");
CreateSet("Marvelous","MagicDamage AddManaCost MaxMana","Amulet Chest Hands Talisman Study Orb","S4",0,"",1,"");
CreateSet("Radiance","MagicDamage AddManaCost ManaDelta","Amulet Chest Hands Talisman Study Orb","S4",1,"",1,"");
CreateSet("Black","MagicDamage AddManaCost OffensiveCasting","Amulet Chest Hands Talisman Study Orb","S4",0,"",1,"");

// TIER 5: 2 RANDOM
// CreateSet("","","","S2",1,"",1);
//

echo("__TIER_SETITEMS LOADED");