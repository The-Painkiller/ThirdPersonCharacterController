public abstract class PlayerActionStateBase
{
    protected FSMManager _fsmManager;
    public ActionStatus PlayerActionStatus;

    public abstract void Enter();
    public abstract void FixedUpdate();
    public abstract void Exit();
}
