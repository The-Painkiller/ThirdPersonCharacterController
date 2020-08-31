using UnityEngine;
using UnityEngine. InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private CameraController _cameraController;
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

    private CharacterControlActions _characterControlActions;

    private Transform _playerTransform;

    private float _moveSpeed = 0f;
    private Vector2 _movementAnimatorMultiplier = Vector2.zero;

    private float _lerpTime = 0;
    private float _lerpMultiplier = 0.05f;
    private float _requiredSpeed = 0f;
    private Vector3 _characterOrientation = Vector3.zero;

    private Vector2 _movementDirection = Vector2.zero;
    private Vector2 _lookDirection = Vector2.zero;

    private bool _hasJumped = false;
    private bool _isInAir = false;
    private bool _isRunning = true;
    private bool _isCrouching = false;
    private bool _isFighting = false;
    public bool IsMoving { get; private set; } = false;

    private CharacterAnimatorController _animatorController;

    private void Awake ( )
    {
        _playerRigidBody = GetComponent<Rigidbody> ( );
        _playerCollider = GetComponent<Collider> ( );
        _animatorController = GetComponentInChildren<CharacterAnimatorController> ( );

        _characterControlActions = new CharacterControlActions ( );

        _characterControlActions.PlayerControls.Movement.performed += ( moveVector ) =>
        {
            _movementDirection = moveVector.ReadValue<Vector2>();

            if ( _movementDirection != Vector2.zero )
            {
                if ( !_isCrouching )
                    _requiredSpeed = _isRunning ? _runSpeed : _walkSpeed;
                else
                    _requiredSpeed = _crouchSpeed;

                IsMoving = true;
            }
            else
            {
                _requiredSpeed = 0;
                IsMoving = false;
            }

            UpdateCharacterMovement ( );

        };

        _characterControlActions.PlayerControls.LookDirection.performed += ( lookVector ) =>
        {
            _lookDirection = lookVector.ReadValue<Vector2> ( );
        };

        _characterControlActions.PlayerControls.Jump.performed += (jump ) => 
        {
            if ( _isInAir )
                return;

            _playerRigidBody.AddForce ( Vector3.up * _jumpForce, ForceMode.Impulse );            
            _isInAir = false;
            _hasJumped = true;
            PlayJumpAnimation ( );
        };

        _characterControlActions.PlayerControls.RunToggle.started += ( runToggle ) =>
        {
            _isRunning = false;
            _requiredSpeed = _walkSpeed;
        };

        _characterControlActions.PlayerControls.RunToggle.canceled += ( runToggle ) => 
        {
            _isRunning = true;
            _requiredSpeed = _runSpeed;
        };

        _characterControlActions.PlayerControls.CrouchToggle.started += ( crouchTOggle ) =>
        {
            _isCrouching = true;
            _requiredSpeed = IsMoving? _crouchSpeed : 0;
            _animatorController.SetParameter ( "Crouching", _isCrouching );
        };

        _characterControlActions.PlayerControls.CrouchToggle.canceled += ( crouchTOggle ) =>
        {
            _isCrouching = false;
            _requiredSpeed = IsMoving? _runSpeed : 0;
            _animatorController.SetParameter ( "Crouching", _isCrouching );
        };

        _characterControlActions.PlayerControls.AttackToggle.started += ( attack ) =>
        {
            _animatorController.SetParameter ( "Attacking", true );
            int rand = Random.Range ( 1, 3 );
            _animatorController.SetParameter ( "AttackMove", rand );
        };

        _characterControlActions.PlayerControls.Defend.started += ( defend ) =>
        {
            _animatorController.SetParameter ( "Defending", true );
        };

        _characterControlActions.PlayerControls.Defend.canceled += ( defend ) =>
        {
            _animatorController.SetParameter ( "Defending", false );
        };
    }

    private void UpdateCharacterMovement ( )
    {
        if ( !IsMoving )
            return;

        if ( _movementDirection.x != 0 )
        {
            _characterOrientation = _cameraController.transform.right * Mathf.Sign ( _movementDirection.x );
        }

        if ( _movementDirection.y != 0 )
        {
            _characterOrientation = _cameraController.transform.forward * Mathf.Sign ( _movementDirection.y );
        }

        _characterBodyTransform.transform.forward = _characterOrientation;
    }


    private void OnEnable ( )
    {
        _characterControlActions.Enable ( );
    }

    private void OnDisable ( )
    {
        _characterControlActions.Disable ( );
    }

    private void Start ( )
    {
        _playerTransform = this.transform;
        _cameraController.AssignPlayerController ( this );
        _cameraController.AssignTargetToFollow ( _animatorController.transform );
    }

    private void FixedUpdate ( )
    {
        TransitionMovementSpeed ( );

        if ( IsMoving )
        {
            _playerTransform.Rotate( 0, _lookDirection.x * _mouseSensitivity, 0 );
            _cameraController.SetCamerOrientation ( _lookDirection.x * _mouseSensitivity, _lookDirection.y * _mouseSensitivity );
        }
        else
        {
            _cameraController.SetCamerOrientation ( _lookDirection.x * _mouseSensitivity, _lookDirection.y * _mouseSensitivity );
        }

        _playerTransform.position += _cameraController.transform.right * _movementDirection.x * Time.fixedDeltaTime * _moveSpeed + _cameraController.transform.forward * _movementDirection.y * Time.fixedDeltaTime * _moveSpeed;

       _animatorController.SetParameter ( "BlendHorizontal",_movementDirection.x + _moveSpeed );
       _animatorController.SetParameter ( "BlendVertical", _movementDirection.y + _moveSpeed );
       _animatorController.SetParameter ( "MoveSpeed", _moveSpeed );

        if ( Mathf.Abs( _playerRigidBody.velocity.y) >= 0.5f )
        {
            _isInAir = true;
        }

        if ( _isInAir )
        {
            if ( Mathf.Approximately(_playerRigidBody.velocity.y,  0f ))
            {
                _isInAir = false;

                if ( _hasJumped )
                {
                    _hasJumped = false;
                }
                PlayLandAnimation ( );
            }
        }
    }

    private void PlayJumpAnimation ( )
    {
        _animatorController.SetParameter ( "Jumping" );
    }

    private void PlayLandAnimation ( )
    {
        _animatorController.SetParameter ( "Landing" );
    }

    private void TransitionMovementSpeed ( )
    {
        if ( Mathf.Approximately(_moveSpeed, _requiredSpeed ))
        {
            if ( _lerpTime != 0 )
                _lerpTime = 0;

            return;
        }

        _lerpTime += _lerpMultiplier;
        _moveSpeed = Mathf.Lerp ( _moveSpeed, _requiredSpeed, _lerpTime );
    }
}
