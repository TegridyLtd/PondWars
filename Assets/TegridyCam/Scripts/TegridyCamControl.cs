/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
namespace Tegridy.Cam {
    public class TegridyCamControl : MonoBehaviour
    {
        public CameraSetup[] cams;
        public TegridyCamRig[] cameraRigs;
        
        PlayerInput playerInput;
        int currentCam = 0;

        int currentRig = 0;
        private void Awake()
        {
            playerInput = new PlayerInput();
            playerInput.Enable();
            currentCam = cameraRigs.Length -1;
            foreach(TegridyCamRig rig in cameraRigs) rig.StartUp();
            NextCam();
        }
        private void Update()
        {
            currentRig = cams[currentCam].control;

            //do we need to change any cam settings?
            if (playerInput.Camera.ChangeCamRig.triggered) NextCam();
            if (playerInput.Camera.ChangeCamConfig.triggered) cameraRigs[currentRig].NextCameraConfig();
            if (playerInput.Camera.ChangeMode.triggered) cameraRigs[currentRig].nextMode();
            if (playerInput.Camera.ChangeModeConfig.triggered) cameraRigs[currentRig].NextModeConfig();

            //send the player input to the current controller
            camInput input = new camInput();
            input.horizontal = playerInput.Camera.Look.ReadValue<Vector2>().y;
            input.vertical = playerInput.Camera.Look.ReadValue<Vector2>().x;
            input.zoom = playerInput.Camera.CamZoom.ReadValue<Vector2>().y;
            input.moveX = playerInput.Camera.Move.ReadValue<Vector2>().x;
            input.moveZ = playerInput.Camera.Move.ReadValue<Vector2>().y;
            input.rotate = playerInput.Camera.Rotate.ReadValue<float>();

            cameraRigs[currentRig].input = input;
        }
        public void NextCam()
        {
            cameraRigs[currentRig].ChangeMode(0);
            currentCam++;
            if (currentCam >= cams.Length) currentCam = 0;
            ChangeCam(currentCam);   
        }
        public void ChangeCam(int cam)
        {
            currentRig = cams[cam].control;
            cameraRigs[currentRig].StartUp();
            cameraRigs[currentRig].SetCamera(cams[currentCam]);
        }
    }
}