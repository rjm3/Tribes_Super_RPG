// PluginLoader Info:
// -----------------------------------------------------------------------------
// CommandLine Forced Load or No-Load < Over-rides Script-Based Load  >
// -----------------------------------------------------------------------------
// Forced Load Example: Tribes.exe +p DoSFix
// Forced No-Load Example: Tribes.exe -p DoSFix
// Multiple Plugin Example: Tribes.exe +p DoSFix,crcBypass,etc.
// -----------------------------------------------------------------------------
// Script-Based Load
// Example: $PluginLoader::DoSFix = true;
// -----------------------------------------------------------------------------
if($dedicated) {
	$PluginLoader::DoSFix = true;
	$PluginLoader::ClientSideAddonPlugin = false;
}
else {
	$PluginLoader::DoSFix = false; //Because dosfix doesn't play nice with special chats
	$PluginLoader::ClientSideAddonPlugin = true;
}

$PluginLoader::MathPlugin = true;
$PluginLoader::StringPlugin = true;
$PluginLoader::GraphicPlugin = true;
$PluginLoader::PatchesPlugin = false; //Keeping this disabled for not, kept here for a legacy release still
$PluginLoader::CommLinkPlugin = true;
$PluginLoader::BovExpansionPlugin = true;
$PluginLoader::ServerSidePlugin = true;