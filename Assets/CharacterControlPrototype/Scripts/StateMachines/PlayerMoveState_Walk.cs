using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState_Walk : PlayerMoveStateBase
{
    public PlayerMoveState_Walk(FSMManager manager)
    {
        _fsmManager = manager;
        PlayerMovementStatus = MovementStatus.Walk;
    }

    public override void Enter()
    {
        Debug.Log("Enter Walk");
    }

    public override void Exit()
    {
        Debug.Log("Exit Walk");
    }

    public override void FixedUpdate()
    {
        Debug.Log("Walking...");
    }
}
