// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class bbb_unreal : ModuleRules
{
	public bbb_unreal(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivatePCHHeaderFile = "MyClass.h";
		PCHUsage = PCHUsageMode.NoSharedPCHs;
		//PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule" });

		//PrivateDependencyModuleNames.AddRange(new string[] { "AutoSettings" });

		CppStandard = CppStandardVersion.Cpp17;
		//CppStandard = CppStandardVersion.Latest;
	}
}
