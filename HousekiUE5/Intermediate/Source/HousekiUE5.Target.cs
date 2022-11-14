using UnrealBuildTool;

public class HousekiUE5Target : TargetRules
{
	public HousekiUE5Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HousekiUE5");
	}
}
