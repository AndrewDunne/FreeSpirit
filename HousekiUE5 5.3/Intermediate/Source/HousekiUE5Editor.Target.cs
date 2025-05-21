using UnrealBuildTool;

public class HousekiUE5EditorTarget : TargetRules
{
	public HousekiUE5EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("HousekiUE5");
	}
}
