//Creator:          Bovidi(In Bov's server), WowjustWow(In Particle's server)

//Version:          1

//Comments:         Anyone is free to change around the code in here as they see fit.  Some logic I use in this file
//                  might have more efficient ways of executing and I freely allow anyone to change it.  This is to
//                  help fix the known Inventory problems in Tribes.

//Installing notes: Basically I made this so it will be as easy as possible to install on the client-side while
//                  trying to remain easy to load on the server-side as well.  I am sorry to say there isn't any
//                  easy way of just going exec(...) but instead you will need to execute this file somewhere in
//                  in your server and make the following changes to the code
//
//                  Replace all occurances of
//                  player::setItemCount with RPG::setItemCount
//                  player::incItemCount with RPG::incItemCount
//                  player::decItemCount with RPG::decItemCount
//                  Client::clearItemBuying with Client::newclearItemBuying
//                  Client::setItemShopping with Client::newsetItemShopping
//
//                  In file: connectivity.cs
//                      In function: Server::onClientConnect(%clientid)
//                      added line: checkRPGMenu(%clientid);
//                      placed at: end of the function after the rest of the remoteevals
//
//                  Installation should now be complete

//Bugs:             Currently the only bugs that I know of is if your server uses Client::clearItemBuying and actually
//                  uses the arguments to clear the list instead of clearing the whole list and rebuilding it.  The
//                  version of RPG I use doesn't use the %args so I didn't originally build the Inventory with it in mind
//                  so this will be fixed hopefully in later versions if there are to many problems

//Support:          CT_KEVIN_IMP@hotmail.com
//                  Feel free to email me if you need support in installing the script server or client side.  In the event
//                  of finding more bugs, glitches or exploits please contact me quickly.


//-------------\\
//RPG Inventory\\
//-------------\\

for(%i=0; %i<=getNumItems(); %i++)
{
	%item = getItemData(%i);
	$RPG::itemtonum[%item] = %i;
}


function Client::newclearItemShopping(%clientId, %args)
{
	Client::clearItemShopping(%clientId, %args);
	if(%clientid > 3000)
	{
		if(getObjectType(%clientid)!="Player" || Player::isDead(%clientid)){
			return;
		}
		%clientid = Player::getClient(%clientid);
	}
	if(%clientid.hasRPGMenu)
	{
		remoteeval(%clientid, ClearInv, %args);
	}
}

function Client::newclearItemBuying(%clientId, %args)
{
	Client::clearItemBuying(%clientId, %args);
	if(%clientid > 3000)
	{
		if(getObjectType(%clientid)!="Player" || Player::isDead(%clientid)){
			return;
		}
		%clientid = Player::getClient(%clientid);
	}
	if(%clientid.hasRPGMenu)
	{
		remoteeval(%clientid, ClearInv, %args);
	}
}

function Client::newsetItemShopping(%clientid, %item, %amt)
{
	Client::setItemShopping(%clientId, %item);
	if(%clientid > 3000)
	{
		if(getObjectType(%clientid)!="Player" || Player::isDead(%clientid)){
			return;
		}
		%clientid = Player::getClient(%clientid);
	}
	if(%clientid.hasRPGMenu)
	{
		if(isNumeric(%item))
			%item = getItemDate(%item);
		if(%amt == "")
			%amt = "";
		remoteeval(%clientid, setBuyList, $RPG::itemtonum[%item], %item.description, %amt, %item.className);
	}
}


function remoteUseBPItem(%clientid,%u)
{
	echo(" REMOTE USE BP ITEM " @ %clientId @ " " @ %u);
	%cl = $BPUnique[%u];
	if (%cl == "")
		return;
	else {
		BackpackWield(%clientId,%cl);
		BackpackInventory(%clientId);
	}
}

function remoteUnequipBPItem(%clientId,%u)
{

	WearUnEquip(%clientId,%cl);
	BackpackInventory(%clientId);

}

function BackpackInventory(%clientId)
{
	remoteeval(%clientId, ClearInv);

	// Create Wear

	%v = 1;

	// Armor
	%item = GetCurrentWearFull(%clientId,12);
	echo("ITEM " @ %item);
	%name = $BPItem[%item,$BPName];
	echo("NAME " @ %name);
	%u = $BPItem[%item,999];
	echo(" U " @ %u);
	remoteeval(%clientid, setItemCount, %u, %name @ "          CRUEQUIP12", 1, "Equip: Armor");
	remoteeval(%clientid, setItemCount, 1, "none", 1, "Equip: Amulet");
	remoteeval(%clientid, setItemCount, 2, "none", 1, "Equip: Rings");
	remoteeval(%clientid, setItemCount, 3, "none", 1, "Equip: Rings");


	// Create Backpack

	%backpack = $PlayerBackpack[%clientId];
	
	for (%i = 0; (%item = getWord(%backpack,%i)) != -1; %i+= 2) {
		%cnt = getWord(%backpack,%i+1);
		%name = $BPItem[%item,$BPName];
		if (%name == "")
			%name = "Unknown";
		%u = $BPItem[%item,999];
		remoteeval(%clientid, setItemCount, %u, %name @ "          " @ %u, %cnt, "Backpack");
	}
}

function RPG::setItemCount(%clientid, %item, %amt)
{
	%rtn = Player::setItemCount(%clientid, %item, %amt);
	if(%clientid > 3000)
	{
		if(getObjectType(%clientid)!="Player" || Player::isDead(%clientid)){
			return;
		}
		%clientid = Player::getClient(%clientid);
	}
	if(%clientid.hasRPGMenu)
	{
		if(isNumeric(%item))
			%item = getItemDate(%item);
		remoteeval(%clientid, setItemCount, $RPG::itemtonum[%item], %item.description, %rtn, %item.className);
	}
	return %rtn;
}

function RPG::incItemCount(%clientid, %item, %amt)
{
	if(%amt == "")
		%rtn = Player::incItemCount(%clientid, %item);
	else
		%rtn = Player::incItemCount(%clientid, %item, %amt);
	if(%clientid > 3000)
	{
		if(getObjectType(%clientid)!="Player" || Player::isDead(%clientid)){
			return;
		}
		%clientid = Player::getClient(%clientid);
	}
	if(%clientid.hasRPGMenu)
	{
		if(isNumeric(%item))
			%item = getItemDate(%item);
		%amt = Player::getItemCount(%clientid, %item);
		remoteeval(%clientid, setItemCount, $RPG::itemtonum[%item], %item.description, %amt, %item.className);
	}
	return %rtn;
}

function RPG::decItemCount(%clientid, %item, %amt)
{
	if(%amt == "")
		%rtn = Player::decItemCount(%clientid, %item);
	else
		%rtn = Player::decItemCount(%clientid, %item, %amt);
	if(%clientid > 3000)
	{
		if(getObjectType(%clientid)!="Player" || Player::isDead(%clientid)){
			return;
		}
		%clientid = Player::getClient(%clientid);
	}
	if(%clientid.hasRPGMenu)
	{
		if(isNumeric(%item))
			%item = getItemDate(%item);
		%amt = Player::getItemCount(%clientid, %item);
		remoteeval(%clientid, setItemCount, $RPG::itemtonum[%item], %item.description, %amt, %item.className);
	}
	return %rtn;
}

function checkRPGMenu(%clientid)
{
	remoteeval(%clientid, RPGMenuInfo);
}

function remoteRPGMenuVer(%clientid)
{
	%clientid.hasRPGMenu = 1;
}

//function isNumeric(%val)
//{
	//Adding 1 and subtracting 1 from a string == 0 then add a blank space to make
	//sure it won't convert the right side to an integer(ie change the right side to 0)
	//if((%val + 1 - 1) @ " " == %val @ " ")
	//{
	//	return true;
	//}
	//return false;
//}