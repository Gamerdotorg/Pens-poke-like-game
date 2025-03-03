using UnrealBuildTool;

public class MultiPokeClientTarget : TargetRules
{
	public MultiPokeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MultiPoke");
	}
}
