"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const UE = require("ue");
const puerts_1 = require("puerts");
const UClass = UE.Class.Load("/Game/FirstPerson/BP_Cube.BP_Cube_C");
const JSClass = puerts_1.blueprint.tojs(UClass);
class TS_Cube {
    ReceiveTick(DeltaSeconds) {
        this.K2_AddActorLocalRotation(new UE.Rotator(0, 0, DeltaSeconds * 10), false, (0, puerts_1.$ref)(), false);
    }
}
puerts_1.blueprint.mixin(JSClass, TS_Cube);
//# sourceMappingURL=BP_Cube.js.map