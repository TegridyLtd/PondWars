/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
namespace Tegridy.Cam
{
    public class TegridyCamRigControlNew : MonoBehaviour
    {
        public TegridyCamRig cameraRig;
        PlayerInput playerInput;

        private void Awake()
        {
            playerInput = new PlayerInput();
            playerInput.Enable();
            cameraRig.StartUp();
            cameraRig.nextMode();
        }
        private void Update()
        {
            if (playerInput.Camera.ChangeCamConfig.triggered) cameraRig.NextCameraConfig();
            if (playerInput.Camera.ChangeMode.triggered) cameraRig.nextMode();
            if (playerInput.Camera.ChangeModeConfig.triggered) cameraRig.NextModeConfig();

            //send the player input to the current controller
            camInput input = new camInput();
            input.horizontal = playerInput.Camera.Look.ReadValue<Vector2>().y;
            input.vertical = playerInput.Camera.Look.ReadValue<Vector2>().x;
            input.zoom = playerInput.Camera.CamZoom.ReadValue<Vector2>().y;
            input.moveX = playerInput.Camera.Move.ReadValue<Vector2>().x;
            input.moveZ = playerInput.Camera.Move.ReadValue<Vector2>().y;
            input.rotate = playerInput.Camera.Rotate.ReadValue<float>();
            cameraRig.input = input;
        }

    }
}