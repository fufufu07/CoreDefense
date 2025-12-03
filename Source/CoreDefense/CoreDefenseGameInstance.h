// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Engine/GameInstance.h"
#include "JsEnv/Private/ContainerWrapper.h"
#include "CoreDefenseGameInstance.generated.h"

namespace puerts
{
class FJsEnv;
}

/**
 *
 */
UCLASS()
class COREDEFENSE_API UCoreDefenseGameInstance : public UGameInstance
{
	GENERATED_BODY()

public:

	virtual void OnStart() override;

	virtual void Shutdown() override;

private:

	TSharedPtr<puerts::FJsEnv> JsEnv;
};
