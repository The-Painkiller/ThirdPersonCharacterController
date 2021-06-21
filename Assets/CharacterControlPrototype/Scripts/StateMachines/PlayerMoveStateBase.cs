public abstract class PlayerMoveStateBase
{
    protected FSMManager _fsmManager;
    public MovementStatus PlayerMovementStatus { get; protected set; }
    public abstract void Enter();
    public abstract void FixedUpdate();
    public abstract void Exit();

}
