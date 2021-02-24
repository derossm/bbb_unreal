// Copyright Epic Games, Inc. All Rights Reserved.

#define PY_SSIZE_T_CLEAN
#include <Python.h>

#include <string>
#include <cstdio>

#include "TensorFlux.h"

#define LOCTEXT_NAMESPACE "FTensorFluxModule"

void FTensorFluxModule::StartupModule()
{
	Py_SetProgramName(L"TensorFlux");
	Py_Initialize();

	//auto sys = PyImport_ImportModule("sys");
	std::string filename{"somefile"};
	// python is forcing us to use a FILE*, but I refuse to use the output parameter version fopen_s; we have SOME dignity
	auto fp{fopen(filename.c_str(), "rb")};
	PyRun_SimpleFile(fp, filename.c_str());
	fclose(fp);

	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
}

void FTensorFluxModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.
	// For modules that support dynamic reloading, we call this function before unloading the module.
	Py_Finalize();
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FTensorFluxModule, TensorFlux)
