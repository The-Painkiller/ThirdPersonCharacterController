using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState_Run : PlayerMoveStateBase
{
    public PlayerMoveState_Run(FSMManager manager)
    {
        _fsmManager = manager;
        PlayerMovementStatus = MovementStatus.Run;
    }
    public override void Enter()
    {
        Debug.Log("Enter Run");
    }

    public override void Exit()
    {
        Debug.Log("Exit Run");
    }

    public override void FixedUpdate()
    {
        Debug.Log("Running...");
    }
}
