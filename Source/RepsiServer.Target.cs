using UnrealBuildTool;

public class RepsiServerTarget : TargetRules
{
	public RepsiServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        DefaultBuildSettings = BuildSettingsVersion.V5;
		ExtraModuleNames.AddRange( new string[] { "RepsiCore" } );
	}
}
