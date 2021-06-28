using UnityEngine;

public enum MovementStatus
{
    Idle,
    Walk,
    Run,
    Jump,
    Crouch
}

public enum ActionStatus
{
    None,
    Jump,
    Crouch,
    Attack,
    HeavyAttack,
    Defend
}

public class FSMManager : MonoBehaviour
{
    public MovementStatus CurrentMovementStatus { get; private set; }
    public ActionStatus CurrentActionStatus { get; private set; }

    [SerializeField]
    private InputControlsManager _inputControlsManager;
    [SerializeField]
    private CharactreMovementController _characterController;

    private PlayerMoveStateBase _currentMoveState;
    private PlayerActionStateBase _currentActionState;

    private PlayerMoveState_Idle _stateIdle = null;
    private PlayerMoveState_Walk _stateWalk = null;
    private PlayerMoveState_Run _stateRun = null;

    private PlayerActionState_Crouch _actionCrouch = null;
    private PlayerActionState_Jump _actionJump = null;
        
    private bool _isMoving = false;
    private bool _isCrouching = false;
    private bool _isRunning = false;
    private bool _isJumping = false;

    private void Start()
    {
        _inputControlsManager.Idle += OnIdle;
        _inputControlsManager.Movement += OnMovement;
        _inputControlsManager.Run += OnRun;
        _inputControlsManager.Jump += OnJump;
        _inputControlsManager.Crouch += OnCrouch;

        _stateIdle = new PlayerMoveState_Idle(this);
        _stateWalk = new PlayerMoveState_Walk(this);
        _stateRun = new PlayerMoveState_Run(this);

        _actionJump = new PlayerActionState_Jump(this);
        _actionCrouch = new PlayerActionState_Crouch(this);

        SetState(MovementStatus.Idle);
        SetAction(ActionStatus.None);
    }

    private void OnIdle(object sender, System.EventArgs e)
    {
        _isMoving = false;
        SetState(MovementStatus.Idle);
    }
    private void OnMovement(object sender, Vector2 movementVector)
    {
        _isMoving = true;
        if (_isRunning)
            SetState(MovementStatus.Run);
        else
            SetState(MovementStatus.Walk);
    }

    private void OnCrouch(object sender, bool _isCrouched)
    {
        _isCrouching = _isCrouched;

        if (_isCrouched)
            SetAction(ActionStatus.Crouch);
        else
            SetAction(ActionStatus.None);

        //if (_isCrouching)
        //{
        //    SetState(MovementStatus.Crouch);
        //}
        //else
        //{
        //    if (_isMoving)
        //    {
        //        _isMoving = true;
        //        SetState(MovementStatus.Walk);
        //    }
        //    else
        //    {
        //        _isMoving = false;
        //        SetState(MovementStatus.Idle);
        //    }
        //}
    }

    private void OnJump(object sender, bool _hasJumped)
    {
        SetAction(ActionStatus.Jump);
        //if (_isJumping)
        //{
        //    SetState(MovementStatus.Jump);
        //}
        //else
        //{
        //    if (_isMoving)
        //    {
        //        if (_isRunning)
        //            SetState(MovementStatus.Run);
        //        else
        //            SetState(MovementStatus.Walk);
        //    }
        //    else
        //    {
        //        SetState(MovementStatus.Idle);
        //    }
        //}
    }

    private void OnRun(object sender, bool _hasRun)
    {
        _isRunning = _hasRun;

        if (_isMoving)
        {
            if (_isRunning)
                SetState(MovementStatus.Run);
            else
                SetState(MovementStatus.Walk);
        }
        else
        {
            SetState(MovementStatus.Idle);
        }
    }

    private void FixedUpdate()
    {
        if (_currentMoveState != null)
            _currentMoveState.FixedUpdate();

        if (_currentActionState != null)
            _currentActionState.FixedUpdate();
    }

    public void SetState(MovementStatus status)
    {
        if(_currentMoveState != null)
            _currentMoveState.Exit();

        switch (status)
        {
            case MovementStatus.Idle:
                _currentMoveState = _stateIdle;
                break;

            case MovementStatus.Walk:
                _currentMoveState = _stateWalk;
                break;
            
            case MovementStatus.Run:
                _currentMoveState = _stateRun;
                break;

            default:
                break;
        }


        CurrentMovementStatus = status;
        _currentMoveState.Enter();
    }

    public void SetAction(ActionStatus action)
    {
        if (_currentActionState != null)
            _currentActionState.Exit();

        switch (action)
        {
            case ActionStatus.None:
                _currentActionState = null;
                _isCrouching = false;
                _isJumping = false;
                break;

            case ActionStatus.Crouch:
                _currentActionState = _actionCrouch;
                _isCrouching = true;
                _isJumping = false;
                break;

            case ActionStatus.Jump:
                _currentActionState = _actionJump;
                _isCrouching = false;
                _isJumping = true;
                break;

            default:
                break;
        }
    }
}
