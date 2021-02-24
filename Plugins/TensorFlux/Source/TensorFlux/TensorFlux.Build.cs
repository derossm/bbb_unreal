// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TensorFlux : ModuleRules
{
	public TensorFlux(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivatePCHHeaderFile = "Public/TensorFlux.h";
		PCHUsage = PCHUsageMode.NoSharedPCHs;
		//PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicAdditionalLibraries.AddRange(
			new string[] {
				// ... add public library paths required here ...
				"C:/Program Files/Python39/libs/python39.lib",
			}
			);

		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
				"C:/Program Files/Python39/include",
			}
			);

		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);

		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...
			}
			);

		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

		CppStandard = CppStandardVersion.Latest;
	}
}
