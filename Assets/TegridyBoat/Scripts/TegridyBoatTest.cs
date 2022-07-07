/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
using Tegridy.Water;
namespace Tegridy.Boat
{
    public class TegridyBoatTest : MonoBehaviour
    {
        public TegridyBoat boat;

        public TegridyBoatUIControlHolder gui;
        public TegridyBoatUIControl guiControl;
        
        public TegridyBoatNewInput newInputControl;
        public TegridyBoatOldInput oldInputControl;

        public TegridyBuoyancySettings buoyancySettings;
        TegridyBuoyancy[] buoyancies;

        void Start()
        {
            //set all objects to the default settings
            buoyancies = FindObjectsOfType<TegridyBuoyancy>();
            for (int i = 0; i < buoyancies.Length; i++) { buoyancies[i].config = buoyancySettings; buoyancies[i].StartUp(); }
            
            //if we have controllers start them up, why not?
            if(guiControl != null) guiControl.StartShipUI(boat, gui, null);
            if(newInputControl != null) newInputControl.StartUp(new PlayerInput(), boat);
            if (oldInputControl != null) oldInputControl.StartUp(boat);
        }
    }
}