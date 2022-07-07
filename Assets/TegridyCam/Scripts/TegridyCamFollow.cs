/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
namespace Tegridy.Cam
{
    public class TegridyCamFollow
    {
        //player settings
        public TegridyCamRig control;
        public FollowConfig settings;
        public void StartUp(TegridyCamRig thisControl, FollowConfig config)
        {
            control = thisControl;
            settings = config;

            control.camRig.main.transform.position = settings.offsetPos;
            control.camRig.main.transform.eulerAngles = settings.offsetRot;
        }
        public void MoveCam()  //set the position for frame.
        { 
            Vector3 newPos = settings.offsetPos;
            Vector3 newRot = settings.offsetRot;

            //if we are following target rotation, pick wich axis to transform
            if (settings.rotate)
            {
                if (settings.rotateX) newRot.x = control.target.transform.eulerAngles.x;
                if (settings.rotateY) newRot.y = control.target.transform.eulerAngles.y;
                if (settings.rotateZ) newRot.z = control.target.transform.eulerAngles.z;
            }

            //if we are following the player decide on wich axis
            if (settings.follow)
            {
                if (settings.followX) newPos.x = control.target.transform.position.x + settings.offsetPos.x;
                if (settings.followY) newPos.y = control.target.transform.position.y + settings.offsetPos.y;
                if (settings.followZ) newPos.z = control.target.transform.position.z + settings.offsetPos.z;
            }

            //If we are zooming pick which axis
            if(settings.zoom != 0) 
            {
                settings.zoomCurrent += (control.input.zoom / 1000) * settings.zoomSpeed;
                settings.zoomCurrent = Mathf.Clamp(settings.zoomCurrent, settings.zoomMin, settings.zoomMax);
                switch (settings.zoom)
                {
                    case 1:
                        newPos.x = control.target.transform.position.x + settings.zoomCurrent;
                        break;
                    case 2:
                        newPos.y = control.target.transform.position.y + settings.zoomCurrent;
                        break;
                    case 3:
                        newPos.z = control.target.transform.position.z + settings.zoomCurrent;
                        break;
                }
            }

            //should the camera look at the player do this last as it only adjusts the rotation
            if (settings.lookAt)
            {
                Vector3 lookat = Quaternion.LookRotation((control.target.transform.position - control.camRig.main.transform.position), Vector3.up).eulerAngles;
                if (settings.lookAtX) newRot.x = lookat.x;
                if (settings.lookAtY) newRot.y = lookat.y;
                if (settings.lookAtZ) newRot.z = lookat.z;
            }

            control.camRig.main.transform.position = newPos;
            control.camRig.main.transform.eulerAngles = newRot;
        }
    }
}