public class ModelCharacter
{
    public float WalkSpeed { get; private set; }
    public float RunSpeed { get; private set; }
    public float CrouchedSpeed { get; private set; }
    public float JumpForce { get; private set; }

    public ModelCharacter ( float walkSpeed, float runSpeed, float crouchSpeed, float jumpForce )
    {
        WalkSpeed = walkSpeed;
        RunSpeed = runSpeed;
        CrouchedSpeed = crouchSpeed;
        JumpForce = jumpForce;
    }
}
