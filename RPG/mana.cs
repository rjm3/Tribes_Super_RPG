function setMANA(%clientId, %val)
{
	dbecho($dbechoMode, "setMANA(" @ %clientId @ ", " @ %val @ ")");

	%armor = Player::getArmor(%clientId);

	if(%val == "")
		%val = fetchData(%clientId, "MaxMANA");

	%a = %val * %armor.maxEnergy;
	%b = %a / fetchData(%clientId, "MaxMANA");

	if(%b <= 0) {
		NoManaEndSpells(%clientId);
		%b = 0;
	}
	else if(%b > %armor.maxEnergy)
		%b = %armor.maxEnergy;

	GameBase::setEnergy(Client::getOwnedObject(%clientId), %b);

	//Targeting::RefreshTargeters(%clientId);
	RefreshTeamHud(%clientId);

}
function refreshMANA(%clientId, %value)
{
	dbecho($dbechoMode, "refreshMANA(" @ %clientId @ ", " @ %value @ ")");

	setMANA(%clientId, (fetchData(%clientId, "MANA") - %value));
}
function refreshMANAREGEN(%clientId)
{
	// DO NOTHING
}
