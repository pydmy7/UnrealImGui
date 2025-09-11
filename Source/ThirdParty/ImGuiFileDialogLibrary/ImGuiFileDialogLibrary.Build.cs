using UnrealBuildTool;

public class ImGuiFileDialogLibrary : ModuleRules
{
#if WITH_FORWARDED_MODULE_RULES_CTOR
	public ImGuiFileDialogLibrary(ReadOnlyTargetRules Target) : base(Target)
#else
	public ImGuiFileDialogLibrary(TargetInfo Target)
#endif
	{
		Type = ModuleType.External;
	}
}
