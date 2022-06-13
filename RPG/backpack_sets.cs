// SETS

function ListAllMods(%loc,%type)
{
	echo("***************************************");
	echo(" LISTALLMOD " @ %loc @ " " @ %type);
	%list = "";
	for (%i = 0; %i <= 300; %i++) {
		if ((%var = $BPTIERVAR[%loc,%type,%i]) != "") {
			echo($BPMOD[%var] @ " " @ $BPTIERVAL[%loc,%type,%i]);
			%list = %list @ $BPMOD[%var] @ " . ";
		}
	}
	//echo("LIST: " @ %list);
	echo("***************************************");
}

function CreateSetItem(%name,%type,%set,%main,%req,%hard,%ico,%desc)
{
	echo("[CREATESETITEM] " @ %name @ " " @ %type);
	%item = "";
	for (%i = 0; (%a = getWord(%name,%i)) != -1; %i++)
		%item = %item @ %a;
	//=================================================================================
	$DynamicItem[%item,$DName] = %name;
	$DynamicItem[%item,$DMinMax] = "1 300";
	$DynamicItem[%item,$DWeight] = "1 0";
	$DynamicItem[%item,$DPrice] = "100 100";
	$DynamicItem[%item,$DWield] = "LOCATION " @ %type @ " NA";
	$DynamicItem[%item,$DTierHard] = %hard;
	$DynamicItem[%item,$DIco] = %ico;
	$DynamicItem[%item,$DSet] = %set;
	$DynamicItem[%item,$DItemType] = "7 " @ %type;
	$DynamicItem[%item,$DDesc] = %desc;
	$DynamicItem[%item,$DTier] = 1;
	$DynamicItem[%item,$DMain] = %main;
	$DynamicItem[%item,$DReq] = %req;
	$DynamicItem[%item,$DTierProp] = 7;
	$DynamicItem[%item,$DTierPerc] = "100 150";
}

//-------------------------------------------------------------------------------------------------------
// WARRIORS
CreateSetItem("Warriors Chestplate","Chest","Warriors","ARMOR","AMR","STRENGTH R MAXHP R INCARMOR R ADDALLOFF L:100 ADDALLDEF L:100","ico_","A true warriors battle gear");
CreateSetItem("Warriors Ring","Ring","Warriors","NON 0 0","DYN","STRENGTH R MAXHP R ARMOR R","ico_","A true warriors battle gear");











echo("__SETS LOADED");