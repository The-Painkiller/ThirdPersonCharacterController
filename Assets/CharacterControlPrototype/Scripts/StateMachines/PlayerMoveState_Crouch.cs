using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState_Crouch : PlayerMoveStateBase
{
    public PlayerMoveState_Crouch(FSMManager manager)
    {
        _fsmManager = manager;
        PlayerMovementStatus = MovementStatus.Crouch;
    }
    public override void Enter()
    {
        Debug.Log("Enter Crouch");
    }

    public override void Exit()
    {
        Debug.Log("Exit Crouch");
    }

    public override void FixedUpdate()
    {
        Debug.Log("Crouching...");
    }
}
