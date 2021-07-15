// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerScripts/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ef5f9f0f-e2bc-4be7-9fad-372a9f79d35a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1ea609cf-69cf-40c4-bf11-f06b7d70ee8e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""31cad82d-79b2-455d-8a35-f7b9bf55bc07"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouePosition"",
                    ""type"": ""Value"",
                    ""id"": ""24d552a5-b846-4cc2-bd22-e2b5dba1c2ff"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheelY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f548a496-ac28-4a76-9d6d-7dbb7897c3b3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9a9d65c4-2d72-450d-895d-bd18d8fe2fff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireLMB"",
                    ""type"": ""Value"",
                    ""id"": ""028c35d4-fe6e-4d7c-8af0-deb39e1f30e5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireRMB"",
                    ""type"": ""Value"",
                    ""id"": ""33ccb65d-5c08-4e1f-8c8d-26a74c8b6498"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""57ca5fdd-242e-419b-87d1-d10a15032cf1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""34ad7790-df6d-4938-89cb-02c45c451777"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0cc1f696-8c48-4ede-a555-db9f58c9cd85"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""122615d8-f3e7-4ab5-9dff-bdecc98a94c2"",
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
                    ""id"": ""7475e283-b52f-4558-95c4-e2ac3d71559c"",
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
                    ""id"": ""2c62b889-5fd4-49fc-9121-077e75e91ed3"",
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
                    ""id"": ""0969e580-3a44-4d56-a8d3-753717103767"",
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
                    ""id"": ""fb8a6e3e-62e2-4f5d-9702-8a2a2d2811ff"",
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
                    ""id"": ""d6aef746-a178-4629-ab1b-7f972bd5a830"",
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
                    ""id"": ""52fcebb1-553c-413c-9de6-68cafe21b9ac"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireLMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c74f588e-303f-4b87-abce-f424c14f9803"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireRMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""948ec5fa-65a4-48ca-9731-07bd62bafa5c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dcde8ce-0c63-4bb1-8ac0-bbb76b5dde52"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ScrollWheelY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cde0cbe3-9ef1-41d3-bd51-a53ce6b2520e"",
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
                    ""id"": ""3ab045bc-e5f6-4f18-8a2f-d001ae483d45"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bd4c1a0-5652-411d-8e96-3c63802f4bd8"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3771a5b7-55fc-4c03-b52d-2d2980739a81"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_MouePosition = m_Player.FindAction("MouePosition", throwIfNotFound: true);
        m_Player_ScrollWheelY = m_Player.FindAction("ScrollWheelY", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_FireLMB = m_Player.FindAction("FireLMB", throwIfNotFound: true);
        m_Player_FireRMB = m_Player.FindAction("FireRMB", throwIfNotFound: true);
        m_Player_Reload = m_Player.FindAction("Reload", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_MouePosition;
    private readonly InputAction m_Player_ScrollWheelY;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_FireLMB;
    private readonly InputAction m_Player_FireRMB;
    private readonly InputAction m_Player_Reload;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_Sprint;
    public struct PlayerActions
    {
        private @PlayerActs m_Wrapper;
        public PlayerActions(@PlayerActs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @MouePosition => m_Wrapper.m_Player_MouePosition;
        public InputAction @ScrollWheelY => m_Wrapper.m_Player_ScrollWheelY;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @FireLMB => m_Wrapper.m_Player_FireLMB;
        public InputAction @FireRMB => m_Wrapper.m_Player_FireRMB;
        public InputAction @Reload => m_Wrapper.m_Player_Reload;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @MouePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouePosition;
                @MouePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouePosition;
                @MouePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouePosition;
                @ScrollWheelY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWheelY;
                @ScrollWheelY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWheelY;
                @ScrollWheelY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnScrollWheelY;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @FireLMB.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireLMB;
                @FireLMB.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireLMB;
                @FireLMB.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireLMB;
                @FireRMB.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireRMB;
                @FireRMB.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireRMB;
                @FireRMB.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireRMB;
                @Reload.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @MouePosition.started += instance.OnMouePosition;
                @MouePosition.performed += instance.OnMouePosition;
                @MouePosition.canceled += instance.OnMouePosition;
                @ScrollWheelY.started += instance.OnScrollWheelY;
                @ScrollWheelY.performed += instance.OnScrollWheelY;
                @ScrollWheelY.canceled += instance.OnScrollWheelY;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @FireLMB.started += instance.OnFireLMB;
                @FireLMB.performed += instance.OnFireLMB;
                @FireLMB.canceled += instance.OnFireLMB;
                @FireRMB.started += instance.OnFireRMB;
                @FireRMB.performed += instance.OnFireRMB;
                @FireRMB.canceled += instance.OnFireRMB;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMouePosition(InputAction.CallbackContext context);
        void OnScrollWheelY(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFireLMB(InputAction.CallbackContext context);
        void OnFireRMB(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
