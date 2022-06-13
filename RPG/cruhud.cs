// CRU HUD

$HotbarDeclare[0] = "hotbar1";
$HotbarDeclare[1] = "hotbar2";
$HotbarDeclare[2] = "hotbar3";
$HotbarDeclare[3] = "hotbar4";
$HotbarDeclare[4] = "hotbar5";
$HotbarDeclare[5] = "hotbar6";
$HotbarDeclare[6] = "hotbar7";
$HotbarDeclare[7] = "hotbar8";
$HotbarDeclare[8] = "hotbar9";
$HotbarDeclare[9] = "hotbar0";

$HotbarToSelect[1] = 0;
$HotbarToSelect[2] = 1;
$HotbarToSelect[3] = 2;
$HotbarToSelect[4] = 3;
$HotbarToSelect[5] = 4;
$HotbarToSelect[6] = 5;
$HotbarToSelect[7] = 6;
$HotbarToSelect[8] = 7;
$HotbarToSelect[9] = 8;
$HotbarToSelect[0] = 9;

function GetKeyType(%key)
{
	if ($CruSpell[%key,$CSName] != "")
		return "spell";
	if ($CruAction[%key,$CAName] != "")
		return "action";
	if ($BPItem[%key,$BPName] != "")
		return "item";
}

function remoteUseHotbar(%id,%select)
{
	%do = $HotbarToSelect[%select];
	Client::SendMessage(%id,0,"You used hotbar " @ %do);
}

function UpdateHotbar(%id,%client)
{
	return;
	
	echo("UPDATING HOTBAR");


	for (%i = 0; %i <= 10; %i++) {
		%key = GetWord($PlayerHotbar[%id],%i);
		%type = GetKeyType(%key);


		if (%i == 0) {
			echo("KEY " @ %key);
			echo("TYPE " @ %type);
		}

		if (%type == "spell") {
			
			echo("IS SPELL");

			if (PlayerRecoverCS(%id) == True) {
				%icon = "hbc_" @ $HBIco[%key];
			}
			else {
				%icon = "hb_" @ $HBIco[%key];
			}
		}
		else if (%type == "item") {
			%icon = "hb_empty";
		}
		else {
			%icon = "hb_empty";
		}
		
		if (%i == 0) {
			echo("ICO IS " @ %icon);
		}

		if (%client != 1)
			focusServer();
		else
			focusClient();
		
		remoteEval(%id,"CruHotbar",$HotbarDeclare[%i],%icon);
	}

	echo("HOTBAR UPDATED");

}