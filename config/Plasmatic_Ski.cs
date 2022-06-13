// Jump/ Jet/ Ski script by Plasmatic
// www.annihilation.info/plasmatic
// drop this code into your Tribes\config\autoexec.cs
// Or drop this file into Tribes\config and add:
// exec(Plasmatic_Ski); 
// to Tribes\config\autoexec.cs



//===========================================================
editActionMap("playMap.sae");

BindCommand(mouse0, make, button1, TO, "Plas::Jet();");
bindAction(mouse0, break, button1, TO, IDACTION_JET, 0.000000);
function Plas::Jet()
{
	if(getMountedItem(0) != -1)	//check weapon slot -no jump jet with no weapon
		postAction(2048, IDACTION_MOVEUP, 1);
	postAction(2048,IDACTION_JET, 1.000000);	
}
bindCommand(keyboard0, make, "space", TO, "$Plas::skiing = true;Plas::Ski(true);");
bindCommand(keyboard0, break, "space", TO, "$Plas::skiing = false;");
function Plas::Ski()
{
	if($Plas::skiing)
	{
		postAction(2048, IDACTION_MOVEUP, 1);
		schedule("Plas::Ski();",0.05);	//jump jump jump	
	}
}
BindCommand("mouse0", "zaxis", TO, "nextWeapon();");	//scroll weapons