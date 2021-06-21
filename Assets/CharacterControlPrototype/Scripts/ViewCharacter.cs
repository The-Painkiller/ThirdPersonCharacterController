using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimatorParameters
{
    BlendVertical,
    BlendHorizontal,
    MoveSpeed,
    Jumping,
    Landing,
    Crouching,
    Attacking,
    Defending,
    AttackMove,
    IsFighting
}

public class ViewCharacter : MonoBehaviour
{
    [SerializeField]
    private CamComponent _cameraComponent;

    [SerializeField]
    private Transform _characterBodyTransform;

    [SerializeField]
    private Animator _animator;

    private Rigidbody _rigidBody;
    private Collider _collider;
    private Transform _transform;

    private void Awake ( )
    {
        _rigidBody = GetComponent<Rigidbody> ( );
        _collider = GetComponent<Collider> ( );
    }

    public void SetAnimatorParameter ( AnimatorParameters parameter, bool value )
    {
        _animator.SetBool ( parameter.ToString(), value );
    }

    public void SetAnimatorParameter ( AnimatorParameters parameter, int value )
    {
        _animator.SetInteger ( parameter.ToString ( ), value );
    }

    public void SetAnimatorParameter ( AnimatorParameters parameter, float value )
    {
        _animator.SetFloat ( parameter.ToString ( ), value );
    }

    public void SetAnimatorParameter ( AnimatorParameters triggerParameter )
    {
        _animator.SetTrigger ( triggerParameter.ToString ( ) );
    }

    public void ResetAttackMove ( )
    {
        SetAnimatorParameter ( AnimatorParameters.AttackMove, 0 );
        SetAnimatorParameter ( AnimatorParameters.Attacking, false );
    }

    public void UpdateCharacterOrientation ( Vector3 forwardVector)
    {
        _characterBodyTransform.forward = forwardVector;
    }

    public void UpdateCharacterMovement ( )
    {

    }
}
