using UnrealBuildTool;

public class HousekiUE5ServerTarget : TargetRules
{
	public HousekiUE5ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("HousekiUE5");
	}
}
