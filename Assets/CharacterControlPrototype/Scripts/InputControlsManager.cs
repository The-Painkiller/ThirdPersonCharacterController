using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlsManager : MonoBehaviour
{
    private InputControls _inputControls;

    public event EventHandler<Vector2> Movement;
    public event EventHandler Idle;
    public event EventHandler<bool> Run;
    public event EventHandler<bool> Crouch;
    public event EventHandler<bool> Jump;

    private void Awake()
    {
        _inputControls = new InputControls();

        _inputControls.InputActions.Movement.performed += (moveVector) =>
        {
            Vector2 movementVector = moveVector.ReadValue<Vector2>();

            if (movementVector == Vector2.zero)
                Idle?.Invoke(this, EventArgs.Empty);
            else
            {
                Movement?.Invoke(this, movementVector);
            }
        };

        _inputControls.InputActions.Run.started += (runToggle) =>
        {
            Run?.Invoke(this, true);
        };

        _inputControls.InputActions.Run.canceled += (runToggle) =>
        {
            Run?.Invoke(this, false);
        };

        _inputControls.InputActions.Crouch.started += (crouchToggle) =>
        {
            Crouch?.Invoke(this, true);
        };

        _inputControls.InputActions.Crouch.canceled += (crouchToggle) =>
        {
            Crouch?.Invoke(this, false);
        };

        _inputControls.InputActions.Jump.started+= (jumpToggle) =>
        {
            Jump?.Invoke(this, true);
        };

        _inputControls.InputActions.Jump.canceled += (jumpToggle) =>
        {
            Jump?.Invoke(this, false);
        };
    }

    private void OnEnable()
    {
        _inputControls.Enable();
    }

    private void OnDisable()
    {
        _inputControls.Disable();
    }
}
