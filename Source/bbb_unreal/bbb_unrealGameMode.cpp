// Copyright Epic Games, Inc. All Rights Reserved.

#include "bbb_unrealGameMode.h"
#include "bbb_unrealPlayerController.h"
#include "bbb_unrealCharacter.h"
#include "UObject/ConstructorHelpers.h"

Abbb_unrealGameMode::Abbb_unrealGameMode()
{
	// use our custom PlayerController class
	PlayerControllerClass = Abbb_unrealPlayerController::StaticClass();

	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/TopDownCPP/Blueprints/TopDownCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
