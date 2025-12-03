// Fill out your copyright notice in the Description page of Project Settings.


#include "CoreDefenseGameInstance.h"

#include "JsEnv.h"


void UCoreDefenseGameInstance::OnStart()
{
	Super::OnStart();

	JsEnv = MakeShared<puerts::FJsEnv>();
	JsEnv->Start("MainGame");

}

void UCoreDefenseGameInstance::Shutdown()
{
	Super::Shutdown();
	JsEnv.Reset();
}
