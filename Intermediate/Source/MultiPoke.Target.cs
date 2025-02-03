using UnrealBuildTool;

public class MultiPokeTarget : TargetRules
{
	public MultiPokeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MultiPoke");
	}
}
