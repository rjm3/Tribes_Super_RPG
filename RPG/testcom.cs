function Bolt()
{
	testfire(2049,2050);
	//%player = client::getOwnedObject(2049);
	//%target = client::getOwnedObject(2050);
	//%pos1 = gamebase::getPosition(%player);
	//%pos2 = gamebase::getPosition(%target);
  	//%v = Vector::sub(%pos1, %pos2);
	//echo(%v);
	//%v = Vector::normalize(%v);
	//echo(%v);
	//%dir = Vector::getRotation(%v);
	//%dir = %dir + 1;
   	// %n = Vector::normalize(%v);
	// %rot = Vector::normalize(Vector::getRotation(%n));
	// %dir = Vector::getfromrot(%rot);
   	//%velocity = Item::getVelocity(%player);
	//%trans = "0 0 0" @ " " @ %dir @ " " @ "0 0 0" @ " " @ %pos1;
   	//%object = Projectile::spawnProjectile(FusionBolt, %trans, %player, %velocity, %target);
}


function loscheck3()
{
	%a = GameBase::getPosition(2049);
 	%b = GameBase::getPosition(2050);
	%c = getWord(%a,0) @ " " @ getWord(%a,1) @ " " @ (getWord(%a,2) + 1.359);
	%d = getWord(%b,0) @ " " @ getWord(%b,1) @ " " @ (getWord(%b,2) + 1.359);
	%test = getlosinfo(%c,%d,0);
	echo("TEST " @ %test);
}

function loscheck4()
{
 	echo(" LOS FOV Checking ");
 	%clpos = GameBase::getPosition(2049);
 	%gupos = GameBase::getPosition(2050);
 	%v1 = Vector::sub(%clpos, %gupos);
 	%norm = Vector::normalize(%v1);
 	%rot = Vector::getRotation(%norm);
 	GameBase::getLOSinfo(Client::getOwnedObject(2050), 100, "0 0 " @ getword(%rot,2));
 	echo(" LOS POSITION " @ $los::position);
 	%obj = getObjectType($los::object);
 	if (%obj == "Player") {
  		%target = $los::object;
  		%target = Player::GetClient(%target);
  		echo("====================> Player Found: " @ %target);
 	}
	else
		echo(" Not found ");
}

echo("__TESTCOM LOADED");

function getanglebetweenvectors(%vec1,%vec2)
{
%dist = vector::getdistance(%vec1,%vec2);
%alpha = coss((2-%dist*%dist)/2,d);
return %alpha;
}

function vector::Multiply(%vec1, %vec2)
{
%vec1a = getword(%vec1, 0);
%vec1b = getword(%vec1, 1);
%vec1c = getword(%vec1, 2);

%vec2a = getword(%vec2, 0);
%vec2b = getword(%vec2, 1);
%vec2c = getword(%vec2, 2);

return %vec1a * %vec2a @ " " @ %vec1b * %vec2b @ " " @ %vec1c * %vec2c;
}

function Bigvector::sub(%vec1, %vec2, %abs)
{
%num = getnumwords(%vec1);
for(%x = 0; %x < %num; %x++)
   {
   %v1word = getword(%vec1, %x);
   %v2word = getword(%vec2, %x);
   %v3word = %v1word - %v2word;
   if(%abs && %v3word < 0) %final = %final @ -%v3word @ " ";
   else %final = %final @ %v3word @ " ";
   }
return %final;
}



function sin(%angle, %m)   //Sine
{ 
   if(%m == d) 
      %angle /= 180 / 3.14159;
   else if(%m == g) 
      %angle /= 200 / 3.14159;
   %ans = -getWord(Vector::getFromRot("0 0 " @ %angle), 0) + 0.00001; 
   %return =  string::getsubstr(%ans, 0, 6);
   return %return;
}

function cos(%angle, %m)  //Cosine
{
   if(%m == d) 
      %a = 90;
   else if(%m == g) 
      %a = 100;
   else 
      %a = 1.57079;
   return sin(%a-%angle, %m);
}

function tan(%angle, %m)  //Tangent
{
   return string::getsubstr(sin(%angle, %m)/cos(%angle, %m) + 0.0001, 0, 6);

}

function sins(%sin, %m) //arc sin
{
   %ans = getword(vector::add(vector::getrotation(-%sin @ " " @ sqrt(1-%sin*%sin) @ " 0"), "1.57079 0 0"), 2)+0.00001;
   if(%m == g) 
      %ans *= 200/3.14159;
   else if(%m == d) 
      %ans *= 180/3.14159;
   return %ans;
}

function coss(%cos, %m) //arc cos
{
   if(%m == d) 
      %a = 180/3.14159;
   else if(%m == g) 
      %a = 200/3.14159;
   else 
      %a = 1;
   return 1.57079*%a - sins(%cos, %m) + 0.001;
}

function tans(%val, %m) //arc tan
{
   %a = %val*%val;
   %sinx = %a/(1+%a);
   %sinx = sqrt(%sinx);
   %ans = sins(%sinx);
   if(%m == g) 
      %e = 200/3.14159;
   else if(%m == d) 
      %e = 180/3.14159;
   else 
      %e = 1;
   return %ans*%e;
}


