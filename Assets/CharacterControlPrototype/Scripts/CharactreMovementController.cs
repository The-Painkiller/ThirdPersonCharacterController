using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// add functions to move character only.
/// To be called from FSM Manager
/// </summary>
public class CharactreMovementController : MonoBehaviour
{
    [SerializeField]
    private CamComponent _cameraController;
    [SerializeField]
    private float _walkSpeed;
    [SerializeField]
    private float _runSpeed;
    [SerializeField]
    private float _crouchSpeed;
    [SerializeField]
    private float _jumpForce;
    [SerializeField]
    private float _mouseSensitivity;
    [SerializeField]
    private Transform _characterBodyTransform;

    private Rigidbody _playerRigidBody;
    private Collider _playerCollider;
    private CharacterAnimatorController _animatorController;

    private bool _isGrounded = false;
    public bool IsGrounded => _isGrounded;

    private bool _isIdle = false;
    public bool IsIdle => _isIdle;

    private bool _isRunning = false;
    public bool IsRunning => _isRunning;

    public bool _isCrouching = false;
    public bool IsCrouching => _isCrouching;


    private void Awake()
    {
        _playerRigidBody = GetComponent<Rigidbody>();
        _playerCollider = GetComponent<Collider>();
        _animatorController = GetComponentInChildren<CharacterAnimatorController>();
    }

    private IEnumerator JumpCharacter()
    {
        ///only temporary solution for logs to work out.
        ///Proper solution pending.
        yield return new WaitForSeconds(0.75f);
        _isGrounded = true;
    }

    public void MoveCharacter(Vector3 movementVector)
    {
        ///only temporary solution for logs to work out.
        ///Proper solution pending.
        if (movementVector == Vector3.zero)
            _isIdle = true;
        else
            _isIdle = false;
    }

    public void ToggleRun(bool running)
    {
        _isRunning = running;
    }

    public void ToggleCrouch(bool crouching)
    {
        _isCrouching = crouching;
    }

    public void Jump()
    {
        _isGrounded = false;
    }
}
