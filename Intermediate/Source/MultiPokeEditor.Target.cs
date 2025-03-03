using UnrealBuildTool;

public class MultiPokeEditorTarget : TargetRules
{
	public MultiPokeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MultiPoke");
	}
}
