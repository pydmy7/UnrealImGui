using UnrealBuildTool;

public class ImPlot3DLibrary : ModuleRules
{
#if WITH_FORWARDED_MODULE_RULES_CTOR
	public ImPlot3DLibrary(ReadOnlyTargetRules Target) : base(Target)
#else
	public ImPlot3DLibrary(TargetInfo Target)
#endif
	{
		Type = ModuleType.External;
	}
}
