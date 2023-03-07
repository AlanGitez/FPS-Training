//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Scripts/Actions/InputActions.inputactions
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

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""0125227f-7c02-4a40-a373-3400e801dacb"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""03b1983f-1e47-44fa-93e0-0fe26e5491e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ada218c8-ea5c-4b7e-a078-2d7d7d403546"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InGame"",
            ""id"": ""91e1b3c8-5877-4769-b45c-2997e17fef31"",
            ""actions"": [
                {
                    ""name"": ""mouse.move"",
                    ""type"": ""Value"",
                    ""id"": ""d71bd7ba-e137-4b0b-b98c-8f0ee10a95df"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""mouse.click"",
                    ""type"": ""Button"",
                    ""id"": ""c3052a12-59eb-4605-bb05-99e3dd6321ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""player.move"",
                    ""type"": ""Value"",
                    ""id"": ""86758d70-ff10-474d-a8ed-c1377ada24dc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""player.jump"",
                    ""type"": ""Button"",
                    ""id"": ""aaaa07d0-1f4d-4db4-a2a5-84d1a0af6fad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""player.crouch"",
                    ""type"": ""Button"",
                    ""id"": ""f7867d94-406c-44f1-9465-4b26244573a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""player.changeCamera"",
                    ""type"": ""Value"",
                    ""id"": ""d0df4bd1-2f1b-4363-9a40-fceabba3fa53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e07d64b5-bb23-4f52-8112-c6c420e4db15"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouse.move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""511c7281-4fab-4eba-95c0-ac16a99b6d12"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouse.click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbe321fe-8fec-46ca-86f1-e34e7bc18d3e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouse.click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c08d7c93-3800-4113-a05d-17369efdc809"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouse.click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e756196-2f57-49f4-9955-baa17295b211"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""player.crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c79498a0-7e0e-4500-8b8a-e84ca1d2fb60"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""player.move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""60e421d0-8d43-4a41-bd63-7725dba05ab0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""player.move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4b276518-88c0-4c17-89a7-8a9e4e43b0b3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""player.move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""82e639cf-63a0-48f0-a4ac-d4ff8ee9cec6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""player.move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c265dde2-3e7c-470e-b6cd-1eeb3c1bad33"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""player.move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4893e64c-2f95-4f7d-bc26-690899e60675"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""player.jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ae0c0f2-10be-4f92-96c4-3cdb7cd17acc"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""player.changeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_mousemove = m_InGame.FindAction("mouse.move", throwIfNotFound: true);
        m_InGame_mouseclick = m_InGame.FindAction("mouse.click", throwIfNotFound: true);
        m_InGame_playermove = m_InGame.FindAction("player.move", throwIfNotFound: true);
        m_InGame_playerjump = m_InGame.FindAction("player.jump", throwIfNotFound: true);
        m_InGame_playercrouch = m_InGame.FindAction("player.crouch", throwIfNotFound: true);
        m_InGame_playerchangeCamera = m_InGame.FindAction("player.changeCamera", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
    private readonly InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private @InputActions m_Wrapper;
        public MenuActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void AddCallbacks(IMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IMenuActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // InGame
    private readonly InputActionMap m_InGame;
    private List<IInGameActions> m_InGameActionsCallbackInterfaces = new List<IInGameActions>();
    private readonly InputAction m_InGame_mousemove;
    private readonly InputAction m_InGame_mouseclick;
    private readonly InputAction m_InGame_playermove;
    private readonly InputAction m_InGame_playerjump;
    private readonly InputAction m_InGame_playercrouch;
    private readonly InputAction m_InGame_playerchangeCamera;
    public struct InGameActions
    {
        private @InputActions m_Wrapper;
        public InGameActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @mousemove => m_Wrapper.m_InGame_mousemove;
        public InputAction @mouseclick => m_Wrapper.m_InGame_mouseclick;
        public InputAction @playermove => m_Wrapper.m_InGame_playermove;
        public InputAction @playerjump => m_Wrapper.m_InGame_playerjump;
        public InputAction @playercrouch => m_Wrapper.m_InGame_playercrouch;
        public InputAction @playerchangeCamera => m_Wrapper.m_InGame_playerchangeCamera;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void AddCallbacks(IInGameActions instance)
        {
            if (instance == null || m_Wrapper.m_InGameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InGameActionsCallbackInterfaces.Add(instance);
            @mousemove.started += instance.OnMousemove;
            @mousemove.performed += instance.OnMousemove;
            @mousemove.canceled += instance.OnMousemove;
            @mouseclick.started += instance.OnMouseclick;
            @mouseclick.performed += instance.OnMouseclick;
            @mouseclick.canceled += instance.OnMouseclick;
            @playermove.started += instance.OnPlayermove;
            @playermove.performed += instance.OnPlayermove;
            @playermove.canceled += instance.OnPlayermove;
            @playerjump.started += instance.OnPlayerjump;
            @playerjump.performed += instance.OnPlayerjump;
            @playerjump.canceled += instance.OnPlayerjump;
            @playercrouch.started += instance.OnPlayercrouch;
            @playercrouch.performed += instance.OnPlayercrouch;
            @playercrouch.canceled += instance.OnPlayercrouch;
            @playerchangeCamera.started += instance.OnPlayerchangeCamera;
            @playerchangeCamera.performed += instance.OnPlayerchangeCamera;
            @playerchangeCamera.canceled += instance.OnPlayerchangeCamera;
        }

        private void UnregisterCallbacks(IInGameActions instance)
        {
            @mousemove.started -= instance.OnMousemove;
            @mousemove.performed -= instance.OnMousemove;
            @mousemove.canceled -= instance.OnMousemove;
            @mouseclick.started -= instance.OnMouseclick;
            @mouseclick.performed -= instance.OnMouseclick;
            @mouseclick.canceled -= instance.OnMouseclick;
            @playermove.started -= instance.OnPlayermove;
            @playermove.performed -= instance.OnPlayermove;
            @playermove.canceled -= instance.OnPlayermove;
            @playerjump.started -= instance.OnPlayerjump;
            @playerjump.performed -= instance.OnPlayerjump;
            @playerjump.canceled -= instance.OnPlayerjump;
            @playercrouch.started -= instance.OnPlayercrouch;
            @playercrouch.performed -= instance.OnPlayercrouch;
            @playercrouch.canceled -= instance.OnPlayercrouch;
            @playerchangeCamera.started -= instance.OnPlayerchangeCamera;
            @playerchangeCamera.performed -= instance.OnPlayerchangeCamera;
            @playerchangeCamera.canceled -= instance.OnPlayerchangeCamera;
        }

        public void RemoveCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInGameActions instance)
        {
            foreach (var item in m_Wrapper.m_InGameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InGameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IInGameActions
    {
        void OnMousemove(InputAction.CallbackContext context);
        void OnMouseclick(InputAction.CallbackContext context);
        void OnPlayermove(InputAction.CallbackContext context);
        void OnPlayerjump(InputAction.CallbackContext context);
        void OnPlayercrouch(InputAction.CallbackContext context);
        void OnPlayerchangeCamera(InputAction.CallbackContext context);
    }
}