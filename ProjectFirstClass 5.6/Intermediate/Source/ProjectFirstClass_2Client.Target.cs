using UnrealBuildTool;

public class ProjectFirstClass_2ClientTarget : TargetRules
{
	public ProjectFirstClass_2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ProjectFirstClass_2");
	}
}
