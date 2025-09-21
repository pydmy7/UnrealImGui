using UnrealBuildTool;

public class ImOGuizmoLibrary : ModuleRules
{
#if WITH_FORWARDED_MODULE_RULES_CTOR
	public ImOGuizmoLibrary(ReadOnlyTargetRules Target) : base(Target)
#else
	public ImOGuizmoLibrary(TargetInfo Target)
#endif
	{
		Type = ModuleType.External;
	}
}
