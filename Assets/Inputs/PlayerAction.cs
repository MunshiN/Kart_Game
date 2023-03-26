//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Inputs/PlayerInput.inputactions
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

public partial class @PlayerAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Map2"",
            ""id"": ""3b306a05-3c29-4e08-922c-a9fed3d54465"",
            ""actions"": [
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Button"",
                    ""id"": ""bc41b9ab-04a1-4eef-ae27-118bfde2cb6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""343a9eb3-9b95-4793-a1ca-f32f4328afa5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SteeringAngle"",
                    ""type"": ""Value"",
                    ""id"": ""a3101e26-d3d7-4d9b-9964-a4b9b5d4081c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f8de6945-f189-4534-9a70-a04207b7895a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e6b1fac-51de-4d28-b756-db24c82ac23f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SteeringAngle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91b37492-08e9-49aa-9d14-0349ece63cb6"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Map2
        m_Map2 = asset.FindActionMap("Map2", throwIfNotFound: true);
        m_Map2_Handbrake = m_Map2.FindAction("Handbrake", throwIfNotFound: true);
        m_Map2_Accelerate = m_Map2.FindAction("Accelerate", throwIfNotFound: true);
        m_Map2_SteeringAngle = m_Map2.FindAction("SteeringAngle", throwIfNotFound: true);
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

    // Map2
    private readonly InputActionMap m_Map2;
    private IMap2Actions m_Map2ActionsCallbackInterface;
    private readonly InputAction m_Map2_Handbrake;
    private readonly InputAction m_Map2_Accelerate;
    private readonly InputAction m_Map2_SteeringAngle;
    public struct Map2Actions
    {
        private @PlayerAction m_Wrapper;
        public Map2Actions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Handbrake => m_Wrapper.m_Map2_Handbrake;
        public InputAction @Accelerate => m_Wrapper.m_Map2_Accelerate;
        public InputAction @SteeringAngle => m_Wrapper.m_Map2_SteeringAngle;
        public InputActionMap Get() { return m_Wrapper.m_Map2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Map2Actions set) { return set.Get(); }
        public void SetCallbacks(IMap2Actions instance)
        {
            if (m_Wrapper.m_Map2ActionsCallbackInterface != null)
            {
                @Handbrake.started -= m_Wrapper.m_Map2ActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_Map2ActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_Map2ActionsCallbackInterface.OnHandbrake;
                @Accelerate.started -= m_Wrapper.m_Map2ActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_Map2ActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_Map2ActionsCallbackInterface.OnAccelerate;
                @SteeringAngle.started -= m_Wrapper.m_Map2ActionsCallbackInterface.OnSteeringAngle;
                @SteeringAngle.performed -= m_Wrapper.m_Map2ActionsCallbackInterface.OnSteeringAngle;
                @SteeringAngle.canceled -= m_Wrapper.m_Map2ActionsCallbackInterface.OnSteeringAngle;
            }
            m_Wrapper.m_Map2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @SteeringAngle.started += instance.OnSteeringAngle;
                @SteeringAngle.performed += instance.OnSteeringAngle;
                @SteeringAngle.canceled += instance.OnSteeringAngle;
            }
        }
    }
    public Map2Actions @Map2 => new Map2Actions(this);
    public interface IMap2Actions
    {
        void OnHandbrake(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnSteeringAngle(InputAction.CallbackContext context);
    }
}
