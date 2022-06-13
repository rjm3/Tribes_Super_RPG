function Item::giveItem(%player, %item, %delta, %showmsg)
{
	dbecho($dbechoMode, "Item::giveItem(" @ %player @ ", " @ %item @ ", " @ %delta @ ", " @ %showmsg @ ")");

	%clientId = Player::getClient(%player);

	//i used to restrict what you could pick up here, but that sucks, so i made
	//it so you can pick up anything, but you can't EQUIP anything. (see Item::onUse)

	//also, the only reason you'd be getting a giveItem of an Equipped type is
	//by giving the client an item and pre-equipping it.

	if(%showmsg)
		Client::sendMessage(%clientId, 0, "You received " @ %delta @ " " @ %item.description @ ".");

	if (isBackpackItem(%item)) {
		if (%delta >= 0)
			AddToBackpack(%clientId,%item,%delta);
		else
			RemoveFromBackpack(%clientId,%item,%delta);
	}
	else
		Player::incItemCount(%clientId, %item, %delta);

	return %delta;
}

function Item::onCollision(%this,%object)
{
	dbecho($dbechoMode, "Item::onCollision(" @ %this @ ", " @ %object @ ")");
	%clientId = Player::getClient(%object);
	%armor = Player::getArmor(%clientId);
	if (%this.NoBonus)
		%object.NoDropBonus = 1;
	if (getObjectType(%object) == "Player" && !IsDead(%clientId)) {
		%time = getIntegerTime(true) >> 5;
		if (%time - %clientId.lastItemPickupTime <= 0.1)
			return 0;
		%clientId.lastItemPickupTime = %time;
		%item = Item::getItemData(%this);
		if (%item == "Lootbag" || %item == "Lootrock") {
			%nobonus = 0;
			%msg = "";
			if (Player::isAiControlled(%object))
				return;
			%ownerName = GetWord($loot[%this], 0);
			%namelist = GetWord($loot[%this], 1);
			if ($loot[%this] == "")
				%msg = "You found an empty backpack.";
			else {
				if (IsInCommaList(%namelist, Client::getName(%clientId)) || %namelist == "*") {
					if (String::ICompare(%ownerName, Client::getName(%clientId)) == 0)
						%msg = "You found one of your backpacks.";
					else if (%ownerName == "*")
						%msg = "You found a backpack.";
					else
						%msg = "You found one of " @ %ownerName @ "'s backpacks.";
				}
			}
			if (%this.NoBonus)
				%nobonus = 1;
			if (%msg != "") {
				%newloot = String::getSubStr($loot[%this], String::len(%ownerName)+String::len(%namelist)+2, 99999);
				Client::sendMessage(%clientId, 0, %msg);
				if (LootHasBackpackItem(%newloot) == true) {
					if (BackpackFull(%clientId) == true) {
						Client::SendMessage(%clientId,1,"You can not pick up this pack, your backpack is full!");
						return;
					}
				}
				GiveThisStuff(%clientId, %newloot, True, 1, %nobonus);
				if (%this.tag != "") {
					$tagToObjectId[%this.tag] = "";
					$SpawnPackList = RemoveFromCommaList($SpawnPackList, %this.tag);
				}
				Item::playPickupSound(%this);
				$loot[%this] = "";
				if (%ownerName != "*") {
					%ownerId = NEWgetClientByName(%ownerName);
					storeData(%ownerId, "lootbaglist", RemoveFromCommaList(fetchData(%ownerId, "lootbaglist"), %this));
				}
				deleteObject(%this);
			}
			else {
				if (%ownerName == "*")
					Client::sendMessage(%clientId, $MsgRed, "You do not have the right to take this backpack.");
				else
					Client::sendMessage(%clientId, $MsgRed, "You do not have the right to take " @ %ownerName @ "'s backpack.");
			}
		}
	}
	else if (%item.className == "TownBot")
		return;
}

function Item::onMount(%player,%item)
{
	return;
}

function Item::onUnmount(%player,%item)
{
	return;
}

function Item::onUse(%player,%item)
{
	return;
}

function Item::onDrop(%player,%item)
{
	return;
}

function Ammo::onDrop(%player,%item)
{
	return;
}	

function Item::onDeploy(%player,%item,%pos)
{
	return;
}
