// GENERATED AUTOMATICALLY FROM 'Assets/CharacterControlPrototype/CharacterControlActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharacterControlActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterControlActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterControlActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""a4a889bf-96b5-47ef-87f8-d898c7346da7"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1232ac63-8d12-4ae1-9f28-70dc79f42a83"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6b5aa1f6-f6a9-4772-9dcd-325d1ed361a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LookDirection"",
                    ""type"": ""PassThrough"",
                    ""id"": ""092a51f4-d624-4e2d-a849-c77ffd2abfc7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RunToggle"",
                    ""type"": ""PassThrough"",
                    ""id"": ""70675deb-0faf-4078-8786-0a5e58f54d76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""CrouchToggle"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c7fc4f32-8dc5-4fab-b504-887238d62cf0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""AttackToggle"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e50f14da-f340-4b98-b619-3bfa636348a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Defend"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fc5255c5-be14-44ba-9631-9b2457ebeebe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direction"",
                    ""id"": ""b391bdd8-b1b4-4add-910f-aa235a304639"",
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
                    ""id"": ""62ec02a5-c293-468f-9734-749de8fed3eb"",
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
                    ""id"": ""cc808905-97e2-4cde-a509-3eef2cee00ec"",
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
                    ""id"": ""7bdb12cb-18bc-45d8-a46c-bc2e995cabb8"",
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
                    ""id"": ""c9b427d3-40e3-4d21-83ec-dc2d0b45d8f3"",
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
                    ""id"": ""c2728815-cefd-4eb0-8fff-201a331babe1"",
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
                    ""id"": ""83c4f222-b234-4044-a84d-76fd58c499c5"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c49d1bfb-5e19-4437-bef8-a7cd44a2b07f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80d23a4b-4762-43b3-8501-2bd29e19c40d"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CrouchToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ba4a7a5-5ca4-4398-824b-23104bb01a3b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AttackToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb2b3c74-6805-40b8-9e81-e703ee273a48"",
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
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_LookDirection = m_PlayerControls.FindAction("LookDirection", throwIfNotFound: true);
        m_PlayerControls_RunToggle = m_PlayerControls.FindAction("RunToggle", throwIfNotFound: true);
        m_PlayerControls_CrouchToggle = m_PlayerControls.FindAction("CrouchToggle", throwIfNotFound: true);
        m_PlayerControls_AttackToggle = m_PlayerControls.FindAction("AttackToggle", throwIfNotFound: true);
        m_PlayerControls_Defend = m_PlayerControls.FindAction("Defend", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_LookDirection;
    private readonly InputAction m_PlayerControls_RunToggle;
    private readonly InputAction m_PlayerControls_CrouchToggle;
    private readonly InputAction m_PlayerControls_AttackToggle;
    private readonly InputAction m_PlayerControls_Defend;
    public struct PlayerControlsActions
    {
        private @CharacterControlActions m_Wrapper;
        public PlayerControlsActions(@CharacterControlActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @LookDirection => m_Wrapper.m_PlayerControls_LookDirection;
        public InputAction @RunToggle => m_Wrapper.m_PlayerControls_RunToggle;
        public InputAction @CrouchToggle => m_Wrapper.m_PlayerControls_CrouchToggle;
        public InputAction @AttackToggle => m_Wrapper.m_PlayerControls_AttackToggle;
        public InputAction @Defend => m_Wrapper.m_PlayerControls_Defend;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @LookDirection.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLookDirection;
                @LookDirection.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLookDirection;
                @LookDirection.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnLookDirection;
                @RunToggle.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRunToggle;
                @RunToggle.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRunToggle;
                @RunToggle.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRunToggle;
                @CrouchToggle.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouchToggle;
                @CrouchToggle.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouchToggle;
                @CrouchToggle.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCrouchToggle;
                @AttackToggle.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackToggle;
                @AttackToggle.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackToggle;
                @AttackToggle.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttackToggle;
                @Defend.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDefend;
                @Defend.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDefend;
                @Defend.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDefend;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @LookDirection.started += instance.OnLookDirection;
                @LookDirection.performed += instance.OnLookDirection;
                @LookDirection.canceled += instance.OnLookDirection;
                @RunToggle.started += instance.OnRunToggle;
                @RunToggle.performed += instance.OnRunToggle;
                @RunToggle.canceled += instance.OnRunToggle;
                @CrouchToggle.started += instance.OnCrouchToggle;
                @CrouchToggle.performed += instance.OnCrouchToggle;
                @CrouchToggle.canceled += instance.OnCrouchToggle;
                @AttackToggle.started += instance.OnAttackToggle;
                @AttackToggle.performed += instance.OnAttackToggle;
                @AttackToggle.canceled += instance.OnAttackToggle;
                @Defend.started += instance.OnDefend;
                @Defend.performed += instance.OnDefend;
                @Defend.canceled += instance.OnDefend;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLookDirection(InputAction.CallbackContext context);
        void OnRunToggle(InputAction.CallbackContext context);
        void OnCrouchToggle(InputAction.CallbackContext context);
        void OnAttackToggle(InputAction.CallbackContext context);
        void OnDefend(InputAction.CallbackContext context);
    }
}
