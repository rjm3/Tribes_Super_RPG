// BACKPACK MM

$TierLoc["Mod"] = "MM";
$MaxMM = 1;
function ClearMM()
{
	for (%i = 0; %i <= $MaxMM; %i++)
		$MMLIST[%i] = "";
	$MMLIST[0] = "L:1 ";
}
ClearMM();

function SelectMM(%aiId,%v,%lvl)
{
	if (%lvl < 1) %lvl = 1;
	if (%lvl > 999) %lvl = 999;
	for (%i = 0; %i <= $MaxMM; %i++)
		%l[%i] = String::Shuffle($MMLIST[%i]);
	%ml = %l[0];
	for (%i = 0; %i <= %v; %i++) {
		%g = getWord(%ml,%i);
		if ((%k = string::FindSubStr(%g,"L:")) != -1) {
			%x = string::GetSubStr(%g,2,3);
			%n = %n @ getWord(%l[%x],0) @ " ";
		}
		else
			%n = %n @ getWord(%ml,%i) @ " ";
	}
	for (%i = 0; (%g = GetWord(%n,%i)) != -1; %i++) {
		%nn = %nn @ TierItem::RandomItem(%g,%lvl) @ " ";
	}
	$MM[%aiId] = %nn;
	CreateMMDisplay(%aiId,%nn);
	UpdateMM(%aiId,1);
}

function UpdateMM(%id,%v)
{
	%mm = $MM[%id];
	if (%mm == "") return;
	for (%i = 0; (%item = getWord(%mm,%i)) != -1; %i++)
		BackpackWieldBonus(%id,%item,%v);		
}

function CreateMMDisplay(%id,%nn)
{
	//echo(" CREATEMMDISPLAY " @ %id @ " " @ %nn);
	%msg = "<jc><f2>";
	for (%i = 0; (%item = getWord(%nn,%i)) != -1; %i++)
		%msg = %msg @ GetBPData(%item,$BPName) @ "<n>";
	$MMDISPLAY[%id] = %msg;
}

function MMDisplay(%id)
{
	return $MMDISPLAY[%id];
}

function CreateMM(%name,%hard,%desc,%list)
{
	//echo("[CREATEMM] " @ %name @ " " @ %type);
	%item = "";
	for (%i = 0; (%a = getWord(%name,%i)) != -1; %i++)
		%item = %item @ %a;
	//=================================================================================
	$DynamicItem[%item,$DName] = %name;
	$DynamicItem[%item,$DMinMax] = "1 300";
	$DynamicItem[%item,$DWeight] = "1 0";
	$DynamicItem[%item,$DPrice] = "100 100";
	$DynamicItem[%item,$DWield] = "LOCATION MM NA";
	$DynamicItem[%item,$DTierHard] = %hard;
	$DynamicItem[%item,$DIco] = %ico;
	$DynamicItem[%item,$DItemType] = "0 Mod";
	$DynamicItem[%item,$DDesc] = %desc;
	$DynamicItem[%item,$DTier] = 1;
	$DynamicItem[%item,$DMain] = "NON 0 0";
	$DynamicItem[%item,$DReq] = "LVLG 0 0";
	$DynamicItem[%item,$DTierProp] = 0;
	$DynamicItem[%item,$DTierPerc] = "0 0";
	if (%list == "" || %list == 0)
		$MMLIST[0] = $MMLIST[0] @ %item @ " ";
	else
		$MMLIST[%list] = $MMLIST[%list] @ %item @ " ";
	
}

// MONSTER MODS
CreateMM("Armored","ARMOR L:3300 INCARMOR H:150","Monsters are Armored");
CreateMM("Resistant","ALLRESIST L:3300 INCRESIST H:150","Monsters are Resistant");
CreateMM("Evasive","EVASION L:3300 INCEVASION H:150","Monsters are Evasive");
CreateMM("Bloodsucker","LIFESTEAL H:10 SPELLVAMP H:10","Monsters are Bloodsuckers");
CreateMM("Massive","MAXHP L:6000 HEALTH% H:50","Monsters are Huge");
CreateMM("Precision","ACCURACY L:3000 SPELLACCURACY L:3000","Monsters are Precise");
CreateMM("Critical Mass","CRITCHANCE H:500 CRITDAMAGE H:500 SPELLCRIT H:500 SPCRITDAMAGE H:500","Monsters are Critical");
CreateMM("Penetrating","ARMORPEN L:3000 MAGICPEN L:3000","Monsters are Penetrating");
CreateMM("Brutal","BLEEDCHANCE H:60","Monsters are Brutal");
CreateMM("Berserk","BERSERK H:50","Monsters are Berserk");
CreateMM("Spectral","DDSPECTRAL H:1 ENERGYDAMAGE% H:50 FIREDAMAGE% H:50 COLDDAMAGE% H:50","Monsters are Spectral",1);
CreateMM("Plagued","DDPOISON H:1 INCPOISON H:60 POISONDAMAGE% H:100","Monsters are Poisonous",1);
CreateMM("Arcanist","DDARCANE H:1 ENERGYDAMAGE% H:50 FIREDAMAGE% H:50 COLDDAMAGE% H:50","Monsters are Arcane",1);
CreateMM("Bringer of Pain","PHYSICALDAMAGE H:50 MAGICDAMAGE H:50","Monsters are Painful");
CreateMM("Teleporter","TELEPORTER H:1","Monsters Teleport");
CreateMM("Thornflesh","REFLECT H:30","Monsters have Thorns");

echo("__BACKPACKMM LOADED");