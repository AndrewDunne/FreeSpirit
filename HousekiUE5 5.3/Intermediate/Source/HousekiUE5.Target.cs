using UnrealBuildTool;

public class HousekiUE5Target : TargetRules
{
	public HousekiUE5Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HousekiUE5");
	}
}
