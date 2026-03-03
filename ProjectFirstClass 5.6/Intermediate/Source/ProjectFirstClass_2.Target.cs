using UnrealBuildTool;

public class ProjectFirstClass_2Target : TargetRules
{
	public ProjectFirstClass_2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectFirstClass_2");
	}
}
