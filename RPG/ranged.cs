// RANGED

$Bow = 1;
$Crossbow = 2;

function ClearProjectiles(%id)
{
	$PlayerProjectile[%id] = "-1 -1";
}

function LoadedToBackpack(%id)
{
	%var = $PlayerProjectile[%id];
	if (%var == "-1 -1")
		return;
	%w1 = GetLoadedProjectile(%id);
	%w2 = GetLoadedProjectile(%id,1);
	GiveThisStuff(%id,%w1 @ " " @ %w2,0,0,1);
}

function DisplayLoaded(%id)
{
	%w1 = GetLoadedProjectile(%id);
	%w2 = GetLoadedProjectile(%id,1);
	if (%w1 == -1)
		Client::SendMessage(%id,0,"You don't have any loaded projectiles.");
	else
		Client::SendMessage(%id,0,"You have " @ %w2 @ " " @ %w1 @ " loaded.");
}

function GetLoadedProjectile(%id,%ammo)
{
	if (%ammo)
		return getWord($PlayerProjectile[%id],1);
	else
		return getWord($PlayerProjectile[%id],0);
}

function LoadProjectile(%id,%item,%count)
{
	%type = $BPItem[%item,$BPProjectile];
	%weapon = $PlayerWear[%id,13];
	%wtype = $BPItem[%weapon,$BPRanged];
	//echo("TYPE " @ %type);
	//echo("WEAPON " @ %weapon);
	//echo("WTYPE " @ %wtype);
	if (%count < 1 || IsNumeric(%count) != True)
		return;
	if (%wtype == "" || %wtype != %type) {
		Client::SendMessage(%id,0,"This is not a valid projectile for your current weapon.");
		return;
	}
	%cur = GetLoadedProjectile(%id);
	if (%cur == %item) {
		%curcount = GetLoadedProjectile(%id,1);
		%count += %curcount;
	}
	Client::SendMessage(%id,0,"You loaded " @ %count @ " " @ GetBPData(%item,$BPName));
	$PlayerProjectile[%id] = %item @ " " @ %count;
}

function HasProjectile(%id)
{
	if (GetLoadedProjectile(%id,1))
		return True;
	else
		return False;
}

function DecProjectileAmmo(%id)
{
	%w1 = GetLoadedProjectile(%id);
	%w2 = GetLoadedProjectile(%id,1);
	%w2 -= 1;
	if (%w2 <= 0) {
		Client::SendMessage(%id,0,"Your weapon is out of ammo.");
		$PlayerProjectile[%id] = "-1 -1";
	}
	else {
		$PlayerProjectile[%id] = %w1 @ " " @ %w2;
	}
}

echo("__RANGED LOADED");
