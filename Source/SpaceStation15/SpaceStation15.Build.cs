// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SpaceStation15 : ModuleRules
{
	public SpaceStation15(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SpaceStation15",
			"SpaceStation15/Variant_Horror",
			"SpaceStation15/Variant_Horror/UI",
			"SpaceStation15/Variant_Shooter",
			"SpaceStation15/Variant_Shooter/AI",
			"SpaceStation15/Variant_Shooter/UI",
			"SpaceStation15/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
