using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionState_Crouch : PlayerActionStateBase
{
    public PlayerActionState_Crouch(FSMManager manager)
    {
        _fsmManager = manager;
        PlayerActionStatus = ActionStatus.Jump;
    }
    public override void Enter()
    {
        Debug.Log("Enter Crouch");
    }

    public override void FixedUpdate()
    {
        Debug.Log("Crouching...");
    }

    public override void Exit()
    {
        Debug.Log("Exit Crouch");
    }
}
