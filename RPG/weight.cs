function GetWeight(%id)
{
	return %id.ArmorWeight;
}

function RefreshWeight(%id)
{
	%armor = getBonus(%id,$BPARMOR);
	%armor = %armor + GetBonus(%id,$BPMELEEAC) + GetBonus(%id,$BPPROJAC) + GetBonus(%id,$BPFIREAC) + GetBonus(%id,$BPCOLDAC) + GetBonus(%id,$BPENERGYAC) + GetBonus(%id,$BPPOISONAC);
	%armor = round((%armor + GetBonus(%id,$BPADDALLDEF) * 3) * ((GetBonus(%id,$BPINCARMOR) / 100) + 1));
	%w = round(%armor/5);
	%id.ArmorWeight = %w;
}

function WeightPenalty(%id)
{
	if (Player::isAiControlled(%id))
		return 0;
	%p = 1 - (GetWeight(%id) / fetchData(%id,"MaxWeight"));
	if (%p < -0.3) %p = -0.3;
	%p = %p * -100;
	if (%p < 0 || %p == -0) %p = 0;
	return %p;
}