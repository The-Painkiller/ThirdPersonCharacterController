using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionState_Jump : PlayerActionStateBase
{
    public PlayerActionState_Jump(FSMManager manager)
    {
        _fsmManager = manager;
        PlayerActionStatus = ActionStatus.Jump;
    }

    public override void Enter()
    {
        Debug.Log("Enter Jump");
    }

    public override void FixedUpdate()
    {
        Debug.Log("Jumping...");
    }

    public override void Exit()
    {
        Debug.Log("Exit Jump");
    }
}
