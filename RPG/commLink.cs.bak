// COMMLINK

Comm::create($commID,2);

function comm::ReadLoop() {
	// %servertype 1 is for CRURPG
	%servertype = 1;
	%str = Comm::read();
	while (%str != false) {
		%id = getWord(%str,0);
		%cmd = getWord(%str,1);
		%msg = Word::getSubWord(%str,2,999999);
		//echo("ID:" @ %id @ " CMD:" @ %cmd @ " MSG:" @ %msg);
		if (%cmd == "MSG") {
			if (%servertype == 1) {
				for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
					rpg::sendMessage(%cl, $MsgHudGreen, %msg,true);
			}
			else {
				for (%cl = Client::getFirst(); %cl != -1; %cl = Client::getNext(%cl))
					Client::sendMessage(%cl, 3, %msg);
			}
		}
		%str = Comm::read();
	}
	schedule("comm::ReadLoop();", 0.1);
}

function comm::SendAll(%msg)
{
	//echo("COMM::SENDALL " @ %msg);
	for (%i = 0; (%server = getWord($commServers, %i)) != -1; %i++)
		comm::write(%server,%msg);
}

comm::ReadLoop();

echo("__COMMLINK LOADED");