using UnrealBuildTool;

public class ProjectFirstClass_2EditorTarget : TargetRules
{
	public ProjectFirstClass_2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ProjectFirstClass_2");
	}
}
