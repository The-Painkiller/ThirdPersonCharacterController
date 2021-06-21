using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState_Idle : PlayerMoveStateBase
{
    public PlayerMoveState_Idle(FSMManager manager)
    {
        _fsmManager = manager;
        PlayerMovementStatus = MovementStatus.Idle;
    }
    public override void Enter()
    {
        Debug.Log("Enter Idle");
    }

    public override void Exit()
    {
        Debug.Log("Exit Idle");
    }

    public override void FixedUpdate()
    {
        //Debug.Log("Idling...");
    }
}