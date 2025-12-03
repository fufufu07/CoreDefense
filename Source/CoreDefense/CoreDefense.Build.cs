// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CoreDefense : ModuleRules
{
	public CoreDefense(ReadOnlyTargetRules Target) : base(Target)
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
			"Slate",
			"JsEnv",
			"Puerts"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CoreDefense",
			"CoreDefense/Variant_Horror",
			"CoreDefense/Variant_Horror/UI",
			"CoreDefense/Variant_Shooter",
			"CoreDefense/Variant_Shooter/AI",
			"CoreDefense/Variant_Shooter/UI",
			"CoreDefense/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
