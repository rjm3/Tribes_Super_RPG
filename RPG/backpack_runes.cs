// RUNES

function Rune::Random(%rune,%ql)
{
	//echo("[RANDOM RUNE] " @ %rune @ " " @ %ql);
	%n = $DynamicItem[%item,$DName];
	%bonus = $DynamicItem[%rune,$DRuneBonus];
	%mod = getWord(%bonus,0);
	%val = getWord(%bonus,1);
	%flux = $BPNoFlux[%mod];
	if (%flux != 1)
		%val = round(%val * (%ql / 300));
	if (%flux != 1) {
		%minval = round(%val * 0.5);
		%maxval = round(%val * 1.50);
	}
	else {
		%minval = round(%val * 0.5);
		%maxval = round(%val * 1.50);
	}
	if (%minval < 1) %minval = 1;
	if (%maxval < 1) %maxval = 1;
	%roll = MTRB(%minval,%maxval);
	%roll = TierFormatValue(%roll);
	%s = $BPCODE[%mod] @ %roll;
	//===============================================================================
	%full = FormatQL(%ql) @ %rune @ "#" @ %s;
	Rune::Create(%full);
	return %full;
}

function Rune::Create(%new)
{
	//echo("[RUNE CREATE] " @ %new);
	%find = string::FindSubStr(%new,"#");
	%name = string::GetSubStr(%new,3,(%find - 3));
	%ql = floor(string::GetSubStr(%new,0,3) + 0);
	%cropparts = string::GetSubStr(%new,(%find+1),999);
	%code = string::getSubStr(%cropparts,0,3);
	%val = string::getSubStr(%cropparts,4,6);
	%req = 	$DynamicItem[%name,$DRuneReq];
	//===============================================================================
	if (%req == $ReqStr) %ico = "ico_rune_str.bmp";
	if (%req == $ReqDex) %ico = "ico_rune_dex.bmp";
	if (%req == $ReqInt) %ico = "ico_rune_int.bmp";
	//===============================================================================
	%price = $DynamicItem[%name,$DPrice];
	%price = getWord(%price,0);
	%price = round(%price * (%ql / 300));
	//===============================================================================
	$BPItem[%new,$BPRune] = 1;
	$BPItem[%new,$BPRuneBonus] = $BPMOD[%code] @ " " @ (%val + 0);
	$BPItem[%new,$BPName] = $DynamicItem[%name,$DName];
	$BPItem[%new,$BPWeight] = 1;
	$BPItem[%new,$BPPrice] = %price;
	$BPItem[%new,$BPDesc] = $DynamicItem[%name,$DDesc];
	$BPItem[%new,$BPItemType] = "1 Rune";
	$BPItem[%new,$BPIco] = %ico;
	$BPItem[%new,$BPRuneReq] = %req;
	$BPItem[%new,$BPRuneLoc] = $DynamicItem[%name,$DRuneLoc];
	$BPItem[%new,$BPCraftType] = "RUNE";
	$BPItem[%new,$BPMaterial] = "Powder";
}

function AddToRuneLoot(%rune,%type)
{
	$CRURUNELOOTCOUNT++;
	%count = $CRURUNELOOTCOUNT;
	$CRURUNELOOT[%count] = %rune;
	// CRAFTING
	%c = $RuneCraftCount[%type]++;
	$RuneCraft[%type,%c] = %rune;
}

function TestRune2(%id,%rune,%ql)
{
	if (%ql == "") %ql = 1;
	%tt = Rune::Random(%rune,%ql);	
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ " " @ %tt @ " 1 ";
}

function TestRunes(%id)
{
	echo("==============================================");
	echo(" TEST RUNE ");
	$PlayerBackpack[%id] = "";
	%amulet = TierItem::RandomItem("SuperiorMithrilVest","300");
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ %amulet @ " 1 ";
	%rune = Rune::Random("BodyRuneOfStrength",50);
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ %rune @ " 1 ";
	%rune = Rune::Random("BodyRuneOfSense",50);
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ %rune @ " 1 ";
	%rune = Rune::Random("BodyRuneOfIntelligence",50);
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ %rune @ " 1 ";
	%rune = Rune::Random("BodyRuneOfAgility",50);
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ %rune @ " 1 ";
	%amulet = TierItem::RandomItem("CrackedBrimstoneAmulet","300");
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ %amulet @ " 1 ";

	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999MysticRelic 50 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999ArmourScrap 50 ";
	$PlayerBackpack[%id] = $PlayerBackpack[%id] @ "999RunePrism 50 ";
}

function fullTestRune()
{
	return false;
}

echo("__BACKPACK RUNES LOADED");