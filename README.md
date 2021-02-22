# bbb_unreal

This is the code bits of a UE4 project, sans most of the compile generated files and non-code assets.

Purposes:

- creating a class usable inside the UE4 Editor
- creating a plugin (C++)

# notes about UE4

The engine compiles with /std:c++17, but attempting to compile with /std:c++latest leads to error C2666 from disambiguity
with operator overloads involving the way class FName attempts to handle any combination of string formats and enums.

I suspect this is easily solved by simplifying the interface to use std::string_view in 90% of the places explicit `const StringType*`
variations are being passed, but there are so damn many overloads it will take considerable effort to test that theory. Considering that
UE5 is soon to be released, the incentive to explore this issue further is non-existent.

TL;DR in *.Build.cs for classes inheriting from ModuleRules:

	CppStandard = CppStandardVersion.Cpp17; // when #include engine headers
	CppStandard = CppStandardVersion.Latest; // when decoupled from engine headers

	// To avoid PCH incompatibilities, add these two lines and comment out the third
	PrivatePCHHeaderFile = "Public/ExampleHeader.h";
	PCHUsage = PCHUsageMode.NoSharedPCHs;
	//PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

And for default configuration, add the following to UnrealBuildTool\BuildConfiguration.xml:

	<BuildConfiguration>
		<CppStandard>Cpp17</CppStandard>
	</BuildConfiguration>

Other C++ Standard Notes:

	use of `std::result_of<F(A, B)>` is deprecated in C++17 (and removed in C++20), but easily replaced with `std::invoke_result<F, A, B>`
	which has a slight syntax change by removing the parens of the (invokable) type parameter and adding a comma (after the invokable).
