using UnrealBuildTool;

public class RepsiEditorTarget : TargetRules
{
	public RepsiEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        DefaultBuildSettings = BuildSettingsVersion.V5;
		ExtraModuleNames.AddRange( new string[] { "RepsiCore" } );
	}
}
