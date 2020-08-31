using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    [SerializeField]
    private Animator _playerAnimator;

    public void SetParameter ( string parameter, bool value )
    {
        _playerAnimator.SetBool ( parameter, value );
    }

    public void SetParameter ( string parameter, int value )
    {
        _playerAnimator.SetInteger ( parameter, value );
    }

    public void SetParameter ( string parameter, float value )
    {
        _playerAnimator.SetFloat ( parameter, value );
    }

    public void SetParameter ( string triggerParameter )
    {
        _playerAnimator.SetTrigger ( triggerParameter );
    }

    public void ResetAttackMove ( )
    {
        SetParameter ( "AttackMove", 0 );
        SetParameter ( "Attacking", false );
    }
}
