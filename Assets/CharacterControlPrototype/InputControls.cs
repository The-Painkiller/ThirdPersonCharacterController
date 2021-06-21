// GENERATED AUTOMATICALLY FROM 'Assets/CharacterControlPrototype/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""InputActions"",
            ""id"": ""e285dcc8-3a7e-42af-a187-baa4800ac2d8"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2e9adde3-0886-4389-b852-52ebb9b914b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""44c47da4-a6ea-431a-9dc0-6e7e706ef84b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5e541d4a-9212-4bfc-ac83-14eacbc8e797"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""14e787e1-fc70-4f33-9ea5-14500bc15167"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""e4929694-a7b9-4788-82a7-0ae375110dc2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""c348dbdd-8f96-4c62-b15e-3fcb8118cd85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Defend"",
                    ""type"": ""Button"",
                    ""id"": ""ecb06966-bb3e-455f-a390-f488aa18fc08"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direction"",
                    ""id"": ""7386a864-ce72-47c0-b894-9d04553aff66"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""862327d7-2721-424c-be44-300de062beda"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8ef3b9b1-ca8d-4aa9-903c-f69c0231be4f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""391001a2-ed5e-4cc6-b722-070572ab6028"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3e96fb51-d00c-4b15-aad7-6c0d875d77fb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""31e671ba-0098-4b14-ba54-37a65a44c5c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a5a6bd9-024f-4d5a-84d8-0cf9b3e5ee06"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""525dce11-5be3-4fb9-87bd-65d77860a7ac"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65fe2e5b-ca67-4f8e-8472-b7b6587d11de"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4d42ccf-4c13-4a33-a4dc-3cfff6030eb4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15817651-4afd-4f6d-8a62-37533200bd96"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InputActions
        m_InputActions = asset.FindActionMap("InputActions", throwIfNotFound: true);
        m_InputActions_Movement = m_InputActions.FindAction("Movement", throwIfNotFound: true);
        m_InputActions_Jump = m_InputActions.FindAction("Jump", throwIfNotFound: true);
        m_InputActions_Run = m_InputActions.FindAction("Run", throwIfNotFound: true);
        m_InputActions_Crouch = m_InputActions.FindAction("Crouch", throwIfNotFound: true);
        m_InputActions_Look = m_InputActions.FindAction("Look", throwIfNotFound: true);
        m_InputActions_Attack = m_InputActions.FindAction("Attack", throwIfNotFound: true);
        m_InputActions_Defend = m_InputActions.FindAction("Defend", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // InputActions
    private readonly InputActionMap m_InputActions;
    private IInputActionsActions m_InputActionsActionsCallbackInterface;
    private readonly InputAction m_InputActions_Movement;
    private readonly InputAction m_InputActions_Jump;
    private readonly InputAction m_InputActions_Run;
    private readonly InputAction m_InputActions_Crouch;
    private readonly InputAction m_InputActions_Look;
    private readonly InputAction m_InputActions_Attack;
    private readonly InputAction m_InputActions_Defend;
    public struct InputActionsActions
    {
        private @InputControls m_Wrapper;
        public InputActionsActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_InputActions_Movement;
        public InputAction @Jump => m_Wrapper.m_InputActions_Jump;
        public InputAction @Run => m_Wrapper.m_InputActions_Run;
        public InputAction @Crouch => m_Wrapper.m_InputActions_Crouch;
        public InputAction @Look => m_Wrapper.m_InputActions_Look;
        public InputAction @Attack => m_Wrapper.m_InputActions_Attack;
        public InputAction @Defend => m_Wrapper.m_InputActions_Defend;
        public InputActionMap Get() { return m_Wrapper.m_InputActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActionsActions set) { return set.Get(); }
        public void SetCallbacks(IInputActionsActions instance)
        {
            if (m_Wrapper.m_InputActionsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnRun;
                @Crouch.started -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnCrouch;
                @Look.started -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnLook;
                @Attack.started -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnAttack;
                @Defend.started -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnDefend;
                @Defend.performed -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnDefend;
                @Defend.canceled -= m_Wrapper.m_InputActionsActionsCallbackInterface.OnDefend;
            }
            m_Wrapper.m_InputActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Defend.started += instance.OnDefend;
                @Defend.performed += instance.OnDefend;
                @Defend.canceled += instance.OnDefend;
            }
        }
    }
    public InputActionsActions @InputActions => new InputActionsActions(this);
    public interface IInputActionsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnDefend(InputAction.CallbackContext context);
    }
}
