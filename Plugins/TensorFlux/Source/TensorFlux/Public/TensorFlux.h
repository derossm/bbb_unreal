// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include <concepts>
#include <bit>

#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"

class FTensorFluxModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
