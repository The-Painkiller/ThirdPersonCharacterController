using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState_Jump : PlayerMoveStateBase
{
    public PlayerMoveState_Jump(FSMManager manager)
    {
        _fsmManager = manager;
        PlayerMovementStatus = MovementStatus.Jump;
    }
    public override void Enter()
    {
        Debug.Log("Enter Jump");
    }

    public override void Exit()
    {
        Debug.Log("Exit Jump");
    }

    public override void FixedUpdate()
    {
        Debug.Log("Jumping...");
    }
}
