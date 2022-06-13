// BACKPACK MERCHANT

function DisplayMerchantMsg(%id,%merchant)
{
	%msg = $BPMerchantShop[%merchant];
	for (%i = 0; (%g = getWord(%msg,%i)) != -1; %i+=2)
		%newmsg = %newmsg @ %g @ " " @ getWord(%msg,%i+1) @ "\n";
	SendBufferBP(%id,%newmsg,30);
}

function GetBackpackMerchant(%id,%slot)
{
	%area = %id.MerchantArea;
	%storage = $BPMerchantShop[%id];
	if (getWord(%storage,%slot) != -1)
		return GetBPData(getWord(%storage,%slot),$BPName) @ " " @ getWord(%storage,%slot+1);
	else
		return false;
}

function GetTrueBackpackMerchant(%id,%slot)
{
	%area = %id.MerchantArea;
	%storage = $BPMerchantShop[%id];
	if (getWord(%storage,%slot) != -1)
		return getWord(%storage,%slot) @ " " @ getWord(%storage,%slot+1);
	else
		return false;
}

function BackpackStorageArea(%id)
{
	%l = GameBase::getPosition(Client::getOwnedObject(%id));
	%gdist = $maxAIdistVec + (GetPlayerSkill(%id,$SkillSpeech) / 50);
	for (%i = 1; %i <= $BPStorages; %i++) {
		%s = $BPStorageArea[%i];
		%dist = Vector::getDistance(%l,%s);
		if (%dist <= %gdist) {
			return true;
		}
	}
	return false;
}

function AddBackpackStorage(%id,%item,%d,%storage,%n)
{
	// echo("ADD BACKPACK STORAGE " @ %id @ " " @ %item @ " " @ %d @ " " @ %storage @ " N " @ %n);
	if (%storage < 1 || %storage > 5) return;
	if (HasBackpackCount(%id,%item,%d)) {
		if (BackpackHasItem(%id,%item,False,%storage,False) == false) {
			if (BackpackFull(%id,%storage) == false) {
				// Client::SendMessage(%id,0,"You store " @ %d @ " " @ GetBPData(%item,$BPName) @ " in storage " @ %storage @ ".");
				RemoveFromBackpack(%id,%item,(%d * -1),0);
				AddToBackpack(%id,%item,%d,%storage);
				SaveCharacter(%id,True);
			}
			else {
				Client::SendMessage(%id,1,"Your storage is full.");
			}
		}
		else {
			RemoveFromBackpack(%id,%item,(%d * -1),0);
			AddToBackpack(%id,%item,%d,%storage);
			SaveCharacter(%id,True);
		}
	}
	Game::MenuBackpack(%id,GetBackpackMenuBack(%n));
}

function RemoveBackpackStorage(%id,%cl,%d,%storage)
{
	// echo("REMOVE BACKPACK STORAGE " @ %id @ " " @ %cl @ " " @ %d @ " " @ %storage);
	if (%storage < 1 || %storage > 5) return;
	%s = GetTrueBackpackStorage(%id,%cl,%storage);
	%item = getWord(%s,0);
	%count = getWord(%s,1);
	if (HasBackpackCount(%id,%item,%d,%storage)) {
		if (BackpackHasItem(%id,%item,False,False,False) == false) {
			if (BackpackFull(%id) == false) {
				RemoveFromBackpack(%id,%item,(%d * -1),%storage);
				AddToBackpack(%id,%item,%d);
				SaveCharacter(%id,True);
			}
			else {
				Client::SendMessage(%id,1,"Your backpack is full.");
			}
		}
		else {
			RemoveFromBackpack(%id,%item,(%d * -1),%storage);
			AddToBackpack(%id,%item,%d);
			SaveCharacter(%id,True);
		}
	}
}

function BackpackMerchantArea(%id)
{
	%l = GameBase::getPosition(Client::getOwnedObject(%id));
	%in = 0;
	%gdist = $maxAIdistVec + (GetPlayerSkill(%id,$SkillSpeech) / 50);
	%ldist = 0;
	for (%i = 1; %i <= $BPMerchants; %i++) {
		%s = $BPMerchantArea[%i];
		%dist = Vector::getDistance(%l,%s);
		if (%dist <= %gdist) {
			if (%dist < %ldist || %ldist == 0) {
				%ldist = %dist;
				%ldisti = %i;
				%in = 1;
			}
		}
	}
	if (%in) {
		%id.MerchantArea = %ldisti;
		return %ldisti;
	}
	else
		return false;
}

function Game::menuBackpackMerchant(%id,%menu)
{
	%curItem = 0;
	%area = %id.MerchantArea;
	%coins = fetchData(%id,"COINS");
	Client::buildMenu(%id, "Merchant | " @ %coins @ " coins", "merchant", true);
	for (%i = 1; %i <= 30; %i++) {
		%slot = GetTrueBackpackMerchant(%area,%menu);
		%true = getWord(%slot,0);
		%num = getWord(%slot,1);
		%name = GetBPData(%true,$BPName);
		%ql = DynamicItem::GetQualityDisp(%true);
		%disp = %name;
		if (%slot != false) {
			%curitem++;
			if (%num == -1 || %num == 1)
				Client::addMenuItem(%id, GetMenuNum(%curItem) @ %disp,"selmerchant " @ %menu);
			else
				Client::addMenuItem(%id, GetMenuNum(%curItem) @ %disp @ " " @ %num,"selmerchant " @ %menu);
		}
		%menu += 2;
	}
	if (GetBackpackMerchant(%area,%menu) != false)
		Client::addMenuItem(%id,"n Next >>","selbackpackmerchantnext " @ %menu);
	Client::addMenuItem(%id,"p << Prev","selbackpackmerchantback " @ %menu);
}

function processMenuMerchant(%clientId, %option)
{
	%opt = getWord(%option, 0);
	%cl = getWord(%option, 1);

	%s = GetTrueBackpackSlot(%clientid,%cl);
	%item = getWord(%s,0);
	%count = getWord(%s,1);

	if (%opt == "selbackpackmerchantnext") Game::menuBackpackMerchant(%clientId,%cl);
	if (%opt == "selbackpackmerchantback") {
		if (%cl == 60)
			Game::menuRequest(%clientId);
		else
			Game::menuBackpackMerchant(%clientId,(%cl - 120));
	}
	if (%opt == "selmerchant") Game::MenuSelectMerchant(%clientId,%cl);
	if (%opt == "selbackpackexamineb") {
		//%msg = WhatIs(%item,%clientId);
		//if (%msg != "Unknown Item") {
		//	SendBufferBP(%clientId, %msg, floor(String::len(%msg) / 20));
		Game::MenuSelectMerchant(%clientId,%cl);
		//}
	}
 	if (%opt == "selbackpackselectmerchantback") {
 		Game::menuBackpackMerchant(%clientId,GetBackpackMenuBack(%cl));
	}
	if (%opt == "selbackpackbuy") {
		echo(" CL " @ %cl);
		BackpackBuy(%clientId);
		Game::menuBackpackMerchant(%clientId,GetBackpackMenuBack(%cl));
	}
}

function Game::MenuSelectMerchant(%id,%i,%page)
{
	%area = %id.MerchantArea;
	%s = GetTrueBackpackMerchant(%area,%i);
	%item = getWord(%s,0);
	%count = getWord(%s,1);
	%bulk = %id.bulkNum;
	if (%bulk <= 0) %bulk = 1;
	if (%bulk > %count) {
		if (%count != -1) {
			if (%bulk > %count) %bulk = 1;
   		}
	}
	if (%bulk > 1000) %bulk = 1000;
	%msg = WhatIs(%item,%id);
	SendBufferBP(%id, %msg, floor(String::len(%msg) / 20));
	%curItem = 0;
	BackpackSetBuy(%id,%item,%bulk);
	if (%count != -1 && %count != 1)
		Client::buildMenu(%id, GetBPData(%item,$BPName) @ " " @ %count , "merchant", true);
	else
		Client::buildMenu(%id, GetBPData(%item,$BPName), "merchant", true);
	Client::addMenuItem(%id, %curItem++ @ "Examine..","selbackpackexamineb " @ %i);
	Client::addMenuItem(%id, %curItem++ @ "Buy " @ %bulk @ " for $" @ %id.BBuyPrice,"selbackpackbuy " @ %i);
	Client::addMenuItem(%id, "p<< Prev ","selbackpackselectmerchantback " @ %i);
}

function SetupBackpackMerchant(%id)
{
	BackpackSetBuy(%id,%item,%count);
}

$BPSellMaxHaggle = 5000;

function BackpackSetBuy(%id,%item,%count)
{
	%price = $BPItem[%item,$BPPrice];
	if (%price < 1)
		%price = 1;
	%hagskill = GetPlayerSkill(%id,$SkillHaggling);
	if (%hagskill > $BPSellMaxHaggle)
		%hagskill = $BPSellMaxHaggle;
	%sellprice = floor(%price - (%price * ((%hagskill / $BPSellMaxHaggle) / 3)));
	if (%sellprice < 1) %sellprice = 1;
	%sellprice = (%sellprice * %count);
	%id.BBuyPrice = %sellprice;
	%id.BBuyCount = %count;
	%id.BBuyItem = %item;
	%id.BuyingBackpack = 1;
	%id.SmithingBackpack = "";
	%id.SellingBackpack = "";
	if (%sellprice > 1) %coin = "coins";
	else %coin = "coin";
	if (%count > 1) 
		Client::SendMessage(%id,0,"The merchant will sell you '" @ %count @ " " @ GetBPData(%item,$BPName) @ "' for " @ %sellprice @ " " @ %coin @ ".");
	else
		Client::SendMessage(%id,0,"The merchant will sell you '" @ GetBPData(%item,$BPName) @ "' for " @ %sellprice @ " " @ %coin @ ".");
}

function ResetBackpackBuy(%id)
{
	%id.BBuyPrice = "";
	%id.BBuyCount = "";
	%id.BBuyItem = "";
	%id.BuyingBackpack = 0;
	%id.SmithingBackpack = "";
	%id.SellingBackpack = "";
}

function MoneySound(%id)
{
	Client::SendMessage(%id,0,"~wmoney.wav");
}

function BackpackBuy(%id) 
{
	if (%id.BuyingBackpack != 1)
		return;
	%price = %id.BBuyPrice;
	%delta = %id.BBuyCount;
	%item = %id.BBuyItem;
	%area = %id.MerchantArea;
	if (BackpackHasItem(0,%item,False,False,%area,False) == False) {
		Client::SendMessage(%id,1,"The merchant does not have this.");
		ResetBackpackBuy(%id);
		return;
	}
	if (BackpackFull(%id)) {
		Client::SendMessage(%id,1,"Your backpack is full.");
		ResetBackpackBuy(%id);
		return;
	}
	if (BackpackMerchantArea(%id) == %area) {
		if (HasThisStuff(%id,"COINS " @ %price,%count) == true) {
			%cnt = GetMerchantCount(%area,%item,%delta);
			if (%cnt == -1) {
				Client::SendMessage(%id,0,"You bought " @ %delta @ " " @ $BPItem[%item,$BPName] @ " for " @ %price @ " coins.");
				AddToBackpack(%id,%item,%delta);
				TakeThisStuff(%id,"COINS " @ %price,1);
			}
			else {
				if (%cnt >= %delta) {
					Client::SendMessage(%id,0,"You bought " @ %delta @ " " @ $BPItem[%item,$BPName] @ " for " @ %price @ " coins.");
					AddToBackpack(%id,%item,%delta);
					TakeThisStuff(%id,"COINS " @ %price,1);
					%flag = false;
					if (%item == "999HealthPotion") %flag = true;
					if (%item == "999EnergyVial") %flag = true;
					if (%item == "999PortalScroll") %flag = true;
					if ($BPItem[%item,$BPName] == "Corroded Sword") %flag = true;
					if ($BPItem[%item,$BPName] == "Corroded Spike") %flag = true;
					if ($BPItem[%item,$BPName] == "Twig Wand") %flag = true;
					if ($BPItem[%item,$BPName] == "Driftwood Mace") %flag = true;
					if ($BPItem[%item,$BPName] == "Pine Bow") %flag = true;
					if ($BPItem[%item,$BPName] == "Oldwood Staff") %flag = true;
					if (%flag != true)
						RemoveFromBackpack(%area,%item,(%delta * -1),0,%area,0,1);
					MoneySound(%id);
				}
				else
					Client::SendMessage(%id,1,"The merchant does not have this.");		
			}
		}
		else 
			Client::SendMessage(%id,1,"You dont have enough coins to buy this.");
	}
	else
		Client::SendMessage(%id,1,"You are not near a merchant.");
	ResetBackpackBuy(%id);
}

$HARDNOSELL["Brawler Tome"] = 1;
$HARDNOSELL["Fighter Tome"] = 1;
$HARDNOSELL["Companion Tome"] = 1;

$HARDNOSELL["Defender Tome"] = 1;
$HARDNOSELL["Layman Tome"] = 1;
$HARDNOSELL["Acolyte Tome"] = 1;

$HARDNOSELL["Recruit Tome"] = 1;
$HARDNOSELL["Murderer Tome"] = 1; 
$HARDNOSELL["Assistant Tome"] = 1;

$HARDNOSELL["Trainee Tome"] = 1;
$HARDNOSELL["Initiate Tome"] = 1;
$HARDNOSELL["Scoundrel Tome"] = 1;

$HARDNOSELL["Pupil Tome"] = 1;
$HARDNOSELL["Associate Tome"] = 1;
$HARDNOSELL["Adept Tome"] = 1;

$HARDNOSELL["Student Tome"] = 1;
$HARDNOSELL["Apprentice Tome"] = 1;
$HARDNOSELL["Understudy Tome"] = 1;

$HARDNOSELL["Portal Scroll"] = 1;
$HARDNOSELL["Health Potion"] = 1;
$HARDNOSELL["Energy Vial"] = 1;

$HARDNOSELL["Piece Of Cloth"] = 1;
$HARDNOSELL["Armour Scrap"] = 1;
$HARDNOSELL["Spool Of Thread"] = 1;
$HARDNOSELL["Treasure Key"] = 1;
$HARDNOSELL["Magic Stone"] = 1;
$HARDNOSELL["Sharpening Stone"] = 1;

$HARDNOSELL["Altering Relic"] = 1;
$HARDNOSELL["Havoc Relic"] = 1;
$HARDNOSELL["Chaos Relic"] = 1;
$HARDNOSELL["Anarchy Relic"] = 1;
$HARDNOSELL["Regal Relic"] = 1;
$HARDNOSELL["Cosmic Relic"] = 1;
$HARDNOSELL["Heroic Relic"] = 1;
$HARDNOSELL["Scouring Relic"] = 1;
$HARDNOSELL["Blessed Relic"] = 1;
$HARDNOSELL["Mystic Relic"] = 1;
$HARDNOSELL["Rune Prism"] = 1;
$HARDNOSELL["Divine Relic"] = 1;
$HARDNOSELL["Crafting Material"] = 1;
$HARDNOSELL["Smithing Material"] = 1;
$HARDNOSELL["Pristine Crafting"] = 1;
$HARDNOSELL["Pristine Smithing"] = 1;
$HARDNOSELL["Fire Stone"] = 1;
$HARDNOSELL["Cold Stone"] = 1;
$HARDNOSELL["Energy Stone"] = 1;
$HARDNOSELL["Poison Stone"] = 1;
$HARDNOSELL["Crystal Shard"] = 1;
$HARDNOSELL["Ancient Page"] = 1;
$HARDNOSELL["Arcane Dust"] = 1;
$HARDNOSELL["Rune Powder"] = 1;

$HARDNOSELL["Goblin Head"] = 1;

$HARDNOSELL["Dark Temple Key"] = 1;
$HARDNOSELL["Dark Gate Key I"] = 1;
$HARDNOSELL["Dark Gate Key II"] = 1;
$HARDNOSELL["Dark Gate Key III"] = 1;
$HARDNOSELL["Dark Gate Key IV"] = 1;
$HARDNOSELL["Dark Gate Key V"] = 1;

$HARDNOSELL["Mossy Tome Vol I"] = 1;
$HARDNOSELL["Mossy Tome Vol II"] = 1;
$HARDNOSELL["Mossy Tome Vol III"] = 1;
$HARDNOSELL["Mossy Tome Vol IV"] = 1;
$HARDNOSELL["Mossy Tome Vol V"] = 1;
$HARDNOSELL["Mossy Tome Vol VI"] = 1;

function CheckNoSaleCreate(%id)
{
	%str = $PlayerNoSale[%id];
	for (%i = 0; (%g = getWord(%str,%i)) != -1; %i++)
		DynamicItem::InitWear(%g);
}

function AddToNoSale(%id,%item)
{
	%str = $PlayerNoSale[%id];
	%name = GetBPData(%item,$BPName);
	if (%str == "") {
		Client::SendMessage(%id,0,%name @ " added to No Sale list. #nosale");
		$PlayerNoSale[%id] = %item @ " ";
		return;
	}
	if (word::FindWord(%str,%item) != -1) {
		Client::SendMessage(%id,0,%name @ " is already on your No Sale list. #nosale");
		return;
	}
	else {
		if (getWord(%str,29) != -1) {
			Client::SendMessage(%id,0,"Your No Sale list is full. #nosale");
			return;
		}
		else {
			$PlayerNoSale[%id] = $PlayerNoSale[%id] @ %item @ " ";
			Client::SendMessage(%id,0,%name @ " added to No Sale list. #nosale");
		}
	}	
}

function HasNoSale(%id,%item)
{
	%str = $PlayerNoSale[%id];
	if (word::FindWord(%str,%item) == -1)
		return False;
	else
		return True;
}

function RemoveFromNoSale(%id,%item)
{
	%str = $PlayerNoSale[%id];
	%name = GetBPData(%item,$BPName);
	if (word::FindWord(%str,%item) == -1) {
		Client::SendMessage(%id,0,%name @ " is not on your No Sale list. #nosale");
		return;
	}
	%str = String::RemoveWords(%str,%item);
	Client::SendMessage(%id,0,%name @ " was removed from your no sale list. #nosale");
	$PlayerNoSale[%id] = %str;
}

function Game::MenuNoSale(%id)
{
	%curItem = 0;
	Client::buildMenu(%id, "Remove from No Sale List", "nosale", true);
	%list = $PlayerNoSale[%id];
	for (%i = 0; %i <= 29; %i++) {
		if ((%item = GetWord(%list,%i)) != -1) {
			%name = GetBPData(%item,$BPName);
			Client::addMenuItem(%id, GetMenuNum(%curItem++) @ %name,%i);
		}
	}
}

function processMenunosale(%id,%option)
{	
	%list = $PlayerNoSale[%id];
	%item = GetWord(%list,%option);
	if (%item != -1)
		RemoveFromNoSale(%id,%item);
	if ($PlayerNoSale[%id] != "")
		Game::MenuNoSale(%id);
}

function GetNoSaleSave(%id,%x)
{
	%list = $PlayerNoSale[%id];
	%ret = "";
	for (%i = %x; %i <= (%x + 4); %i++) {
		if ((%item = getWord(%list,%i)) != -1)
			%ret = %ret @ %item @ " ";
	}
	return %ret;
}

function SellAll(%id)
{
	%backpack = $PlayerBackpack[%id];
	%hagskill = GetPlayerSkill(%id,$SkillHaggling);
	%coins = 0;
	if (%hagskill > $BPSellMaxHaggle)
		%hagskill = $BPSellMaxHaggle;
	
}

function SellAll(%id)
{
	%backpack = $PlayerBackpack[%id];
	%hagskill = GetPlayerSkill(%id,$SkillHaggling);
	%coins = 0;
	%new = "";
	%area = %id.MerchantArea;
	if (%hagskill > $BPSellMaxHaggle)
		%hagskill = $BPSellMaxHaggle;
	for (%i = 0; (%item = getWord(%backpack,%i)) != -1; %i+=2) {
		%name = GetBPData(%item,$BPName);
		if ($HARDNOSELL[%name] == 1 || HasNoSale(%id,%item)) {
			%new = %new @ %item @ " " @ getWord(%backpack,%i+1) @ " ";
		}
		else {
			%price = $BPItem[%item,$BPPrice];
			%price *= getWord(%backpack,%i+1);
			%sellprice = floor(%price / (10 - (%hagskill / ($BPSellMaxHaggle / 8))));
			if (%sellprice < 1) %sellprice = 1;
			%coins += %sellprice;
			%delta = getWord(%backpack,%i+1);
			for (%x = 1; %x <= %delta; %x++)
				$BPMerchantShop[%area] = $BPMerchantShop[%area] @ %item @ " 1 ";

		}
	}
	if (!%coins) {
		Client::SendMessage(%id,2,"You don't have any items to sell.");
		return;
	}
	Client::SendMessage(%id,2,"You sold all your items for " @  %coins @ " coins.");
	GiveThisStuff(%id, "COINS " @ %coins, True, 1, 1);
	MoneySound(%id);
	$PlayerBackpack[%id] = %new;
	saveCharacter(%id);
}

function BackpackSetSell(%id,%item,%count,%i,%page)
{
	if ($NoDropItem[%item] == 1) {
		Client::SendMessage(%clientId,0,$BPItem[%cl,$BPName] @ " is a NODROP item.");
		return;
	}
	%price = $BPItem[%item,$BPPrice];
	if (%price <= 0)
		%price = 0;
	%hagskill = GetPlayerSkill(%id,$SkillHaggling);
	if (%hagskill > $BPSellMaxHaggle)
		%hagskill = $BPSellMaxHaggle;
	%sellprice = floor(%price / (10 - (%hagskill / ($BPSellMaxHaggle / 8))));
	if (%sellprice < 1) %sellprice = 1;
	%sellprice = (%sellprice * %count);
	%id.BSellPrice = %sellprice;
	%id.BSellCount = %count;
	%id.BSellItem = %item;
	%id.SellingBackpack = 1;
	%id.SmithingBackpack = "";
	%id.BuyingBackpack = "";
	Client::SendMessage(%id,0,"The merchant will give you " @ %sellprice @ " coins for " @ %count @ " " @ $BPItem[%item,$BPName] @ ".");
	%area = %id.MerchantArea;
	Game::MenuSellBackpack(%id,%menu,%page,%i);
}

function Game::MenuSellBackpack(%id,%menu,%page,%i)
{
	%sellprice = %id.BSellPrice;
	%count = %id.BSellCount;
	%item = %id.BSellItem;
	%curItem = 0;
	%name = GetBPData(%item,$BPName);
	if (string::getSubStr(%name,24,1) != "")
		%name = string::GetSubStr(%name,0,24) @ "..";
	Client::buildMenu(%id, "Sell " @ %name @ "?", "optionssellbp", true);
	Client::addMenuItem(%id, "aSell " @ %count @ " for $" @ %sellprice,"selbackpacksellaccept " @ %item @ " " @ %page);
	Client::addMenuItem(%id, "xCancel","selbackpacksellcancel " @ %i @ " " @ %page);
}

function processMenuOptionsSellBP(%id, %option)
{
	%opt = getWord(%option, 0);
	%cl = getWord(%option, 1);
	%page = getWord(%option,2);
	if (%opt == "selbackpacksellaccept") {
		BackpackSell(%id);
		Game::MenuBackpack(%id,(%page - 8));
	}
	if (%opt == "selbackpacksellcancel") {
		%id.BSellPrice = "";
		%id.BSellCount = "";
		%id.BSellItem = "";
		%id.SellingBackpack = "";
		%id.SmithingBackpack = "";
		%id.BuyingBackpack = "";
		Game::MenuBackpack(%id,(%page - 8));
	}
}

function BackpackSell(%id)
{
	%item = %id.BSellItem;
	%delta = %id.BSellCount;
	%price = %id.BSellPrice;
	if (BackpackMerchantArea(%id) != false) {
		%area = %id.MerchantArea;
		if (HasBackpackCount(%id,%item,%delta) == true) {
			Client::SendMessage(%id,0,"You sold " @ %delta @ " " @ $BPItem[%item,$BPName] @ ".");
			RemoveFromBackpack(%id,%item,%delta * -1);
			GiveThisStuff(%id, "COINS " @ %price, True, 1, 1);
			for (%i = 1; %i <= %delta; %i++)
				$BPMerchantShop[%area] = $BPMerchantShop[%area] @ %item @ " 1 ";
			MoneySound(%id);
		}
	}
	else {
		Client::SendMessage(%id,0,"You have left the shop area.");
	}
	%id.BSellPrice = "";
	%id.BSellCount = "";
	%id.BSellItem = "";
	%id.SellingBackpack = "";
	%id.SmithingBackpack = "";
	%id.BuyingBackpack = "";
}

echo("__BACKPACK MERCHANT LOADED");