using UnrealBuildTool;

public class RepsiTarget : TargetRules
{
	public RepsiTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        DefaultBuildSettings = BuildSettingsVersion.V5;
		ExtraModuleNames.AddRange( new string[] { "RepsiCore" } );
	}
}
