using UnrealBuildTool;

public class ImGuiZmoLibrary : ModuleRules
{
#if WITH_FORWARDED_MODULE_RULES_CTOR
	public ImGuiZmoLibrary(ReadOnlyTargetRules Target) : base(Target)
#else
	public ImGuiZmoLibrary(TargetInfo Target)
#endif
	{
		Type = ModuleType.External;
	}
}
