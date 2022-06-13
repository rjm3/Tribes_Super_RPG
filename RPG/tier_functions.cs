function Trash_Harddisp()
{
	if (%type == "Amulet") {
		echo(" IS AMULET ");
		for (%i = 1; %i <= 10; %i++) {
			if (%s[%i] != "") {
				%v = %s[%i];
				%max = getWord($AmuletVal[%v],1);
				%t = floor((%max * %perc) * (%ql / 300) + 1);
				%msg = %msg @ getWord($AmuletVal[%v],0) @ " " @ %t;
			}
		}
	}
}


function CreateSet_UNUSED(%set,%mods,%slots,%type,%of,%nameset,%props)
{
	for (%i = 0; (%g = getWord(%slots,%i)) != -1; %i++) {
		// AMULET
		if (%g == "Amulet") {
			%name = getWord($SetNameSet[%nameset],0);
			if (%of) {
				%tname = %name @ "Of" @ %set;
				%fname = %name @ " Of " @ %set;
			}
			else {
				%tname = %set @ %name;
				%fname = %set @ " " @ %name;
			}
			$DynamicItem[%tname,$DName] = %fname;
			$DynamicItem[%tname,$DMinMax] = "1 300";
			$DynamicItem[%tname,$DWeight] = "1 0";
			$DynamicItem[%tname,$DPrice] = $SetPrice[%type] @ " " @ $SetPrice[%type];
			$DynamicItem[%tname,$DWield] = "LOCATION " @ $SetLocation[%g] @ " NA";
			$DynamicItem[%tname,$DDesc] = "None.";
			$DynamicItem[%tname,$DItemType] = %type @ " " @ %g;
			$DynamicItem[%tname,$DTier] = 1;
			// Create Hard
			%hardlist = "";
			for (%x = 0; (%y = getWord(%mods,%x)) != -1; %x++)
				%hardlist = %hardlist @ $AmuletVar[%y];
			$DynamicItem[%tname,$DTierHard] = %hardlist;
			$DynamicItem[%tname,$DTierProp] = %props;
			$DynamicItem[%tname,$DTierPerc] = $SetPerc[%type];
			$DynamicItem[%tname,$DIco] = $SetIco[%type] @ $SetLocation[%g] @ ".bmp";
			$DynamicItem[%tname,$DSet] = %set;
		}
		// CHEST
		// HEAD
		// RING
		if (%g == "Ring") {
			%name = getWord($SetNameSet[%nameset],3);
			if (%of) {
				%tname = %name @ "Of" @ %set;
				%fname = %name @ " Of " @ %set;
			}
			else {
				%tname = %set @ %name;
				%fname = %set @ " " @ %name;
			}
			$DynamicItem[%tname,$DName] = %fname;
			$DynamicItem[%tname,$DMinMax] = "1 300";
			$DynamicItem[%tname,$DWeight] = "1 0";
			$DynamicItem[%tname,$DPrice] = $SetPrice[%type] @ " " @ $SetPrice[%type];
			$DynamicItem[%tname,$DWield] = "LOCATION " @ $SetLocation[%g] @ " NA";
			$DynamicItem[%tname,$DDesc] = "None.";
			$DynamicItem[%tname,$DItemType] = %type @ " " @ %g;
			$DynamicItem[%tname,$DTier] = 1;
			// Create Hard
			%hardlist = "";
			for (%x = 0; (%y = getWord(%mods,%x)) != -1; %x++)
				%hardlist = %hardlist @ $RingVar[%y];
			$DynamicItem[%tname,$DTierHard] = %hardlist;
			$DynamicItem[%tname,$DTierProp] = %props;
			$DynamicItem[%tname,$DTierPerc] = $SetPerc[%type];
			$DynamicItem[%tname,$DIco] = $SetIco[%type] @ $SetLocation[%g] @ ".bmp";
			$DynamicItem[%tname,$DSet] = %set;
		}
		// HANDS
		if (%g == "Hands") {
			%name = getWord($SetNameSet[%nameset],4);
			if (%of) {
				%tname = %name @ "Of" @ %set;
				%fname = %name @ " Of " @ %set;
			}
			else {
				%tname = %set @ %name;
				%fname = %set @ " " @ %name;
			}
			$DynamicItem[%tname,$DName] = %fname;
			$DynamicItem[%tname,$DMinMax] = "1 300";
			$DynamicItem[%tname,$DWeight] = "1 0";
			$DynamicItem[%tname,$DPrice] = $SetPrice[%type] @ " " @ $SetPrice[%type];
			$DynamicItem[%tname,$DWield] = "LOCATION " @ $SetLocation[%g] @ " NA";
			$DynamicItem[%tname,$DDesc] = "None.";
			$DynamicItem[%tname,$DItemType] = %type @ " " @ %g;
			$DynamicItem[%tname,$DTier] = 1;
			// Create Hard
			%hardlist = "";
			for (%x = 0; (%y = getWord(%mods,%x)) != -1; %x++)
				%hardlist = %hardlist @ $HandsVar[%y];
			$DynamicItem[%tname,$DTierHard] = %hardlist;
			$DynamicItem[%tname,$DTierProp] = %props;
			$DynamicItem[%tname,$DTierPerc] = $SetPerc[%type];
			$DynamicItem[%tname,$DIco] = $SetIco[%type] @ $SetLocation[%g] @ ".bmp";
			$DynamicItem[%tname,$DSet] = %set;
		}
		// LEGS
		// BOOTS
		// TALISMAN
		if (%g == "Talisman") {
			%name = getWord($SetNameSet[%nameset],7);
			if (%of) {
				%tname = %name @ "Of" @ %set;
				%fname = %name @ " Of " @ %set;
			}
			else {
				%tname = %set @ %name;
				%fname = %set @ " " @ %name;
			}
			$DynamicItem[%tname,$DName] = %fname;
			$DynamicItem[%tname,$DMinMax] = "1 300";
			$DynamicItem[%tname,$DWeight] = "1 0";
			$DynamicItem[%tname,$DPrice] = $SetPrice[%type] @ " " @ $SetPrice[%type];
			$DynamicItem[%tname,$DWield] = "LOCATION " @ $SetLocation[%g] @ " NA";
			$DynamicItem[%tname,$DDesc] = "None.";
			$DynamicItem[%tname,$DItemType] = %type @ " " @ %g;
			$DynamicItem[%tname,$DTier] = 1;
			// Create Hard
			%hardlist = "";
			for (%x = 0; (%y = getWord(%mods,%x)) != -1; %x++)
				%hardlist = %hardlist @ $TalismanVar[%y];
			$DynamicItem[%tname,$DTierHard] = %hardlist;
			$DynamicItem[%tname,$DTierProp] = %props;
			$DynamicItem[%tname,$DTierPerc] = $SetPerc[%type];
			$DynamicItem[%tname,$DIco] = $SetIco[%type] @ $SetLocation[%g] @ ".bmp";
			$DynamicItem[%tname,$DSet] = %set;
		}
		// STUDY
		if (%g == "Study") {
			%name = getWord($SetNameSet[%nameset],8);
			if (%of) {
				%tname = %name @ "Of" @ %set;
				%fname = %name @ " Of " @ %set;
			}
			else {
				%tname = %set @ %name;
				%fname = %set @ " " @ %name;
			}
			$DynamicItem[%tname,$DName] = %fname;
			$DynamicItem[%tname,$DMinMax] = "1 300";
			$DynamicItem[%tname,$DWeight] = "1 0";
			$DynamicItem[%tname,$DPrice] = $SetPrice[%type] @ " " @ $SetPrice[%type];
			$DynamicItem[%tname,$DWield] = "LOCATION " @ $SetLocation[%g] @ " NA";
			$DynamicItem[%tname,$DDesc] = "None.";
			$DynamicItem[%tname,$DItemType] = %type @ " " @ %g;
			$DynamicItem[%tname,$DTier] = 1;
			// Create Hard
			%hardlist = "";
			for (%x = 0; (%y = getWord(%mods,%x)) != -1; %x++)
				%hardlist = %hardlist @ $StudyVar[%y];
			$DynamicItem[%tname,$DTierHard] = %hardlist;
			$DynamicItem[%tname,$DTierProp] = %props;
			$DynamicItem[%tname,$DTierPerc] = $SetPerc[%type];
			$DynamicItem[%tname,$DIco] = $SetIco[%type] @ $SetLocation[%g] @ ".bmp";
			$DynamicItem[%tname,$DSet] = %set;
		}
		// ORB
	}
}

echo("__TIER_FUNCTIONS LOADED");