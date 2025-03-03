using UnrealBuildTool;

public class MultiPokeServerTarget : TargetRules
{
	public MultiPokeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MultiPoke");
	}
}
