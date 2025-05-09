//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/PlayerContoller.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerContoller : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerContoller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerContoller"",
    ""maps"": [
        {
            ""name"": ""MenuCrontroller"",
            ""id"": ""22f794e1-bbf9-4994-b603-23d26bb6cc78"",
            ""actions"": [
                {
                    ""name"": ""PressButton"",
                    ""type"": ""Button"",
                    ""id"": ""01d36114-5b40-43d0-804d-4d4d0f736687"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""aa261f0b-fa47-4054-b1a8-4034caf20d20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4e9d9e6e-1282-428d-b19e-b48b6a81e4c2"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bac0204-29d9-414b-903e-6f39467ba6a3"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88900884-ef53-4db1-b4ba-cfad2c8042d1"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerControl"",
            ""id"": ""e324e917-c32e-426c-be53-b3a575ccb8cb"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""38fe79ad-c71a-4543-af17-e2f60a795c67"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""b1624d7e-3ffc-4b30-9b03-e776162e2fea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slash"",
                    ""type"": ""Button"",
                    ""id"": ""7ff2cf71-a4c3-485e-afa8-76288614b39e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e635ba36-503d-433c-a6b6-1e7a740586d0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f585fbbd-48c8-4e36-9815-cd76899cbec8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5f07cb1-0e14-4c01-9b0d-483e0dd70bc7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player"",
            ""bindingGroup"": ""Player"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MenuCrontroller
        m_MenuCrontroller = asset.FindActionMap("MenuCrontroller", throwIfNotFound: true);
        m_MenuCrontroller_PressButton = m_MenuCrontroller.FindAction("PressButton", throwIfNotFound: true);
        m_MenuCrontroller_PauseGame = m_MenuCrontroller.FindAction("PauseGame", throwIfNotFound: true);
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Move = m_PlayerControl.FindAction("Move", throwIfNotFound: true);
        m_PlayerControl_Dash = m_PlayerControl.FindAction("Dash", throwIfNotFound: true);
        m_PlayerControl_Slash = m_PlayerControl.FindAction("Slash", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MenuCrontroller
    private readonly InputActionMap m_MenuCrontroller;
    private IMenuCrontrollerActions m_MenuCrontrollerActionsCallbackInterface;
    private readonly InputAction m_MenuCrontroller_PressButton;
    private readonly InputAction m_MenuCrontroller_PauseGame;
    public struct MenuCrontrollerActions
    {
        private @PlayerContoller m_Wrapper;
        public MenuCrontrollerActions(@PlayerContoller wrapper) { m_Wrapper = wrapper; }
        public InputAction @PressButton => m_Wrapper.m_MenuCrontroller_PressButton;
        public InputAction @PauseGame => m_Wrapper.m_MenuCrontroller_PauseGame;
        public InputActionMap Get() { return m_Wrapper.m_MenuCrontroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuCrontrollerActions set) { return set.Get(); }
        public void SetCallbacks(IMenuCrontrollerActions instance)
        {
            if (m_Wrapper.m_MenuCrontrollerActionsCallbackInterface != null)
            {
                @PressButton.started -= m_Wrapper.m_MenuCrontrollerActionsCallbackInterface.OnPressButton;
                @PressButton.performed -= m_Wrapper.m_MenuCrontrollerActionsCallbackInterface.OnPressButton;
                @PressButton.canceled -= m_Wrapper.m_MenuCrontrollerActionsCallbackInterface.OnPressButton;
                @PauseGame.started -= m_Wrapper.m_MenuCrontrollerActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_MenuCrontrollerActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_MenuCrontrollerActionsCallbackInterface.OnPauseGame;
            }
            m_Wrapper.m_MenuCrontrollerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PressButton.started += instance.OnPressButton;
                @PressButton.performed += instance.OnPressButton;
                @PressButton.canceled += instance.OnPressButton;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
            }
        }
    }
    public MenuCrontrollerActions @MenuCrontroller => new MenuCrontrollerActions(this);

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_Move;
    private readonly InputAction m_PlayerControl_Dash;
    private readonly InputAction m_PlayerControl_Slash;
    public struct PlayerControlActions
    {
        private @PlayerContoller m_Wrapper;
        public PlayerControlActions(@PlayerContoller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControl_Move;
        public InputAction @Dash => m_Wrapper.m_PlayerControl_Dash;
        public InputAction @Slash => m_Wrapper.m_PlayerControl_Slash;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMove;
                @Dash.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnDash;
                @Slash.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSlash;
                @Slash.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSlash;
                @Slash.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnSlash;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Slash.started += instance.OnSlash;
                @Slash.performed += instance.OnSlash;
                @Slash.canceled += instance.OnSlash;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);
    private int m_PlayerSchemeIndex = -1;
    public InputControlScheme PlayerScheme
    {
        get
        {
            if (m_PlayerSchemeIndex == -1) m_PlayerSchemeIndex = asset.FindControlSchemeIndex("Player");
            return asset.controlSchemes[m_PlayerSchemeIndex];
        }
    }
    public interface IMenuCrontrollerActions
    {
        void OnPressButton(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
    }
    public interface IPlayerControlActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnSlash(InputAction.CallbackContext context);
    }
}
