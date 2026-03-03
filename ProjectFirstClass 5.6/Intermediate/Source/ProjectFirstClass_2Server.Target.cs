using UnrealBuildTool;

public class ProjectFirstClass_2ServerTarget : TargetRules
{
	public ProjectFirstClass_2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ProjectFirstClass_2");
	}
}
