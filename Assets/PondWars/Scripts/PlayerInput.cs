// GENERATED AUTOMATICALLY FROM 'Assets/PondWars/Scripts/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Boat"",
            ""id"": ""0bd3f1c4-72d0-4de5-9dcb-c1d7fab778ca"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f06e8916-a6ee-4aae-84f0-b4427704bc43"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reverse"",
                    ""type"": ""Button"",
                    ""id"": ""84149e26-6076-4247-909b-769f69609edb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Dpad"",
                    ""id"": ""3920c214-1a15-47fe-9e2d-c0c5a9802b46"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f43d71e6-a6dd-433a-9dea-e80610ac251e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3ec4cd6e-784b-4944-9f07-2462038b2455"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dcc74ecd-8082-4259-902e-0a909be94278"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e78f9e38-3c8e-48c1-9fed-8293e891c927"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""126217b3-a021-48f3-8260-13b12c69d613"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3c73a4e0-bf2e-4855-bfef-2c7eeb96b6ee"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aafb990e-b918-4318-bc61-43f69354b487"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1c62e61d-a03a-4d6a-b27a-70856c0b0f2f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0a51d26c-ff67-46a5-9b39-39fd5425d2dd"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e2918668-cf95-4c2a-9ba9-0d74029164ff"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad947917-aa67-49f9-bd54-167ca28aa309"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Turret"",
            ""id"": ""33f56250-1b43-4376-a409-1961b47c9b80"",
            ""actions"": [
                {
                    ""name"": ""RotateTurret"",
                    ""type"": ""Value"",
                    ""id"": ""fbdeb87e-81e6-43a6-85c6-1cf3fe521229"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""a14b6edd-c9a8-4dd7-9768-3290934f2823"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeAmmo"",
                    ""type"": ""Button"",
                    ""id"": ""6b4c7ad0-1185-4af3-8b32-8c33d6806116"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e5faea57-a18a-4f44-8bbb-c7cb6290d11d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTurret"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f2883b89-03f0-4311-9ddd-1c177be40a44"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTurret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""65132b5c-7d10-4b34-89b6-5a21c2d438a3"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTurret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4d16a3d8-d391-449d-b25f-42ec30c9b773"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTurret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f31ed760-b3ce-46f3-ab8c-c5e5eb60eb41"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateTurret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a6e17385-bbf1-457f-b861-be839e163b01"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83f97f08-57cc-4810-86f2-cfa03d2c9f0f"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeAmmo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""58160274-fced-4de1-ba0e-cddf3f77419f"",
            ""actions"": [
                {
                    ""name"": ""ChangeCamRig"",
                    ""type"": ""Button"",
                    ""id"": ""5db5c6ea-f115-4ca0-9b21-da39b969e0d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeCamConfig"",
                    ""type"": ""Button"",
                    ""id"": ""fdaafd49-0412-4532-8f78-8d40a030ad8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeMode"",
                    ""type"": ""Button"",
                    ""id"": ""7d414919-3926-4a96-b88f-7e1f2236a928"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeModeConfig"",
                    ""type"": ""Button"",
                    ""id"": ""a4d697e4-f2b6-4667-b253-aa60c2253a58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CamZoom"",
                    ""type"": ""Value"",
                    ""id"": ""9d244d7a-017c-4bec-807e-bd6b7f8e181d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""b4df71f3-6557-41cc-9364-bba2df3715ac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3b88f3f3-724a-4dd0-95db-33b6c7296b43"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""cd8cbbb1-8652-4ec5-bb9e-e73eeb374585"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bab09cff-26f7-4abf-9de7-de1b1f261500"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamRig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be498206-76cc-4a21-87f1-a7a3370a3abf"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamRig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4ad57ca-6115-482d-8e94-4e11f968dc9e"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CamZoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c742c006-2ecd-44f9-a389-1eb8fbd551d2"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamConfig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3eedbc72-df06-4a65-bd4b-942a207c5260"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamConfig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22ff600d-e25e-4674-b2af-d0ade4f6a63b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2d554ba-0aff-4556-98f2-4c1ff2bddade"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5bf62549-b152-402f-8f98-7e7c155a1aeb"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5430b8a3-dd12-4119-9a9c-702fea3b613f"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeModeConfig"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c6af9da-d40e-481e-9f65-49daea0b736d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""52177457-a539-45d4-a82a-7bd953adc2cc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d6299c7f-1b59-490e-a1dc-a2b72fc3f61c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c25ba7b1-9c23-4f43-8e0c-83efdf0853d7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""911e3552-9a7b-4f92-989e-f6f462484093"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""de05d5c5-0c91-494d-9b01-8f0ed19b0e22"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""36b0af13-908e-43b8-8c39-e4b6000f0f8c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6b5c698a-179f-4118-a8a9-458ce5953e19"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8c4de717-29cc-4568-b425-e8eb11a6439b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Boat
        m_Boat = asset.FindActionMap("Boat", throwIfNotFound: true);
        m_Boat_Move = m_Boat.FindAction("Move", throwIfNotFound: true);
        m_Boat_Reverse = m_Boat.FindAction("Reverse", throwIfNotFound: true);
        // Turret
        m_Turret = asset.FindActionMap("Turret", throwIfNotFound: true);
        m_Turret_RotateTurret = m_Turret.FindAction("RotateTurret", throwIfNotFound: true);
        m_Turret_Fire = m_Turret.FindAction("Fire", throwIfNotFound: true);
        m_Turret_ChangeAmmo = m_Turret.FindAction("ChangeAmmo", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_ChangeCamRig = m_Camera.FindAction("ChangeCamRig", throwIfNotFound: true);
        m_Camera_ChangeCamConfig = m_Camera.FindAction("ChangeCamConfig", throwIfNotFound: true);
        m_Camera_ChangeMode = m_Camera.FindAction("ChangeMode", throwIfNotFound: true);
        m_Camera_ChangeModeConfig = m_Camera.FindAction("ChangeModeConfig", throwIfNotFound: true);
        m_Camera_CamZoom = m_Camera.FindAction("CamZoom", throwIfNotFound: true);
        m_Camera_Look = m_Camera.FindAction("Look", throwIfNotFound: true);
        m_Camera_Move = m_Camera.FindAction("Move", throwIfNotFound: true);
        m_Camera_Rotate = m_Camera.FindAction("Rotate", throwIfNotFound: true);
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

    // Boat
    private readonly InputActionMap m_Boat;
    private IBoatActions m_BoatActionsCallbackInterface;
    private readonly InputAction m_Boat_Move;
    private readonly InputAction m_Boat_Reverse;
    public struct BoatActions
    {
        private @PlayerInput m_Wrapper;
        public BoatActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Boat_Move;
        public InputAction @Reverse => m_Wrapper.m_Boat_Reverse;
        public InputActionMap Get() { return m_Wrapper.m_Boat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoatActions set) { return set.Get(); }
        public void SetCallbacks(IBoatActions instance)
        {
            if (m_Wrapper.m_BoatActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BoatActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BoatActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BoatActionsCallbackInterface.OnMove;
                @Reverse.started -= m_Wrapper.m_BoatActionsCallbackInterface.OnReverse;
                @Reverse.performed -= m_Wrapper.m_BoatActionsCallbackInterface.OnReverse;
                @Reverse.canceled -= m_Wrapper.m_BoatActionsCallbackInterface.OnReverse;
            }
            m_Wrapper.m_BoatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Reverse.started += instance.OnReverse;
                @Reverse.performed += instance.OnReverse;
                @Reverse.canceled += instance.OnReverse;
            }
        }
    }
    public BoatActions @Boat => new BoatActions(this);

    // Turret
    private readonly InputActionMap m_Turret;
    private ITurretActions m_TurretActionsCallbackInterface;
    private readonly InputAction m_Turret_RotateTurret;
    private readonly InputAction m_Turret_Fire;
    private readonly InputAction m_Turret_ChangeAmmo;
    public struct TurretActions
    {
        private @PlayerInput m_Wrapper;
        public TurretActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateTurret => m_Wrapper.m_Turret_RotateTurret;
        public InputAction @Fire => m_Wrapper.m_Turret_Fire;
        public InputAction @ChangeAmmo => m_Wrapper.m_Turret_ChangeAmmo;
        public InputActionMap Get() { return m_Wrapper.m_Turret; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TurretActions set) { return set.Get(); }
        public void SetCallbacks(ITurretActions instance)
        {
            if (m_Wrapper.m_TurretActionsCallbackInterface != null)
            {
                @RotateTurret.started -= m_Wrapper.m_TurretActionsCallbackInterface.OnRotateTurret;
                @RotateTurret.performed -= m_Wrapper.m_TurretActionsCallbackInterface.OnRotateTurret;
                @RotateTurret.canceled -= m_Wrapper.m_TurretActionsCallbackInterface.OnRotateTurret;
                @Fire.started -= m_Wrapper.m_TurretActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_TurretActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_TurretActionsCallbackInterface.OnFire;
                @ChangeAmmo.started -= m_Wrapper.m_TurretActionsCallbackInterface.OnChangeAmmo;
                @ChangeAmmo.performed -= m_Wrapper.m_TurretActionsCallbackInterface.OnChangeAmmo;
                @ChangeAmmo.canceled -= m_Wrapper.m_TurretActionsCallbackInterface.OnChangeAmmo;
            }
            m_Wrapper.m_TurretActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateTurret.started += instance.OnRotateTurret;
                @RotateTurret.performed += instance.OnRotateTurret;
                @RotateTurret.canceled += instance.OnRotateTurret;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @ChangeAmmo.started += instance.OnChangeAmmo;
                @ChangeAmmo.performed += instance.OnChangeAmmo;
                @ChangeAmmo.canceled += instance.OnChangeAmmo;
            }
        }
    }
    public TurretActions @Turret => new TurretActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_ChangeCamRig;
    private readonly InputAction m_Camera_ChangeCamConfig;
    private readonly InputAction m_Camera_ChangeMode;
    private readonly InputAction m_Camera_ChangeModeConfig;
    private readonly InputAction m_Camera_CamZoom;
    private readonly InputAction m_Camera_Look;
    private readonly InputAction m_Camera_Move;
    private readonly InputAction m_Camera_Rotate;
    public struct CameraActions
    {
        private @PlayerInput m_Wrapper;
        public CameraActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeCamRig => m_Wrapper.m_Camera_ChangeCamRig;
        public InputAction @ChangeCamConfig => m_Wrapper.m_Camera_ChangeCamConfig;
        public InputAction @ChangeMode => m_Wrapper.m_Camera_ChangeMode;
        public InputAction @ChangeModeConfig => m_Wrapper.m_Camera_ChangeModeConfig;
        public InputAction @CamZoom => m_Wrapper.m_Camera_CamZoom;
        public InputAction @Look => m_Wrapper.m_Camera_Look;
        public InputAction @Move => m_Wrapper.m_Camera_Move;
        public InputAction @Rotate => m_Wrapper.m_Camera_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @ChangeCamRig.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamRig;
                @ChangeCamRig.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamRig;
                @ChangeCamRig.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamRig;
                @ChangeCamConfig.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamConfig;
                @ChangeCamConfig.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamConfig;
                @ChangeCamConfig.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamConfig;
                @ChangeMode.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeMode;
                @ChangeMode.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeMode;
                @ChangeMode.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeMode;
                @ChangeModeConfig.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeModeConfig;
                @ChangeModeConfig.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeModeConfig;
                @ChangeModeConfig.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeModeConfig;
                @CamZoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCamZoom;
                @CamZoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCamZoom;
                @CamZoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCamZoom;
                @Look.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeCamRig.started += instance.OnChangeCamRig;
                @ChangeCamRig.performed += instance.OnChangeCamRig;
                @ChangeCamRig.canceled += instance.OnChangeCamRig;
                @ChangeCamConfig.started += instance.OnChangeCamConfig;
                @ChangeCamConfig.performed += instance.OnChangeCamConfig;
                @ChangeCamConfig.canceled += instance.OnChangeCamConfig;
                @ChangeMode.started += instance.OnChangeMode;
                @ChangeMode.performed += instance.OnChangeMode;
                @ChangeMode.canceled += instance.OnChangeMode;
                @ChangeModeConfig.started += instance.OnChangeModeConfig;
                @ChangeModeConfig.performed += instance.OnChangeModeConfig;
                @ChangeModeConfig.canceled += instance.OnChangeModeConfig;
                @CamZoom.started += instance.OnCamZoom;
                @CamZoom.performed += instance.OnCamZoom;
                @CamZoom.canceled += instance.OnCamZoom;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    private int m_PlayerSchemeIndex = -1;
    public InputControlScheme PlayerScheme
    {
        get
        {
            if (m_PlayerSchemeIndex == -1) m_PlayerSchemeIndex = asset.FindControlSchemeIndex("Player");
            return asset.controlSchemes[m_PlayerSchemeIndex];
        }
    }
    public interface IBoatActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnReverse(InputAction.CallbackContext context);
    }
    public interface ITurretActions
    {
        void OnRotateTurret(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnChangeAmmo(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnChangeCamRig(InputAction.CallbackContext context);
        void OnChangeCamConfig(InputAction.CallbackContext context);
        void OnChangeMode(InputAction.CallbackContext context);
        void OnChangeModeConfig(InputAction.CallbackContext context);
        void OnCamZoom(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
