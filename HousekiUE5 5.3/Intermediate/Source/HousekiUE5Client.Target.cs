using UnrealBuildTool;

public class HousekiUE5ClientTarget : TargetRules
{
	public HousekiUE5ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("HousekiUE5");
	}
}
