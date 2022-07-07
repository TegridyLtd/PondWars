/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
namespace Tegridy.Boat
{
    public class TegridyBoatNewInput : MonoBehaviour
    {
        TegridyBoat ship;
        PlayerInput controls;
        public bool active = false;
        public void StartUp(PlayerInput input, TegridyBoat boat)
        {
            ship = boat;
            controls = input;
            controls.Enable();
        }
        void Update()
        {
            if (active)
            {
                //set the rudded
                if (controls.Boat.Move.ReadValue<Vector2>().x < 0) ship.RudderLeft();
                else if (controls.Boat.Move.ReadValue<Vector2>().x > 0) ship.RudderRight();

                //set the throttle
                if (controls.Boat.Move.ReadValue<Vector2>().y > 0) ship.ThrottleUp();
                else if (controls.Boat.Move.ReadValue<Vector2>().y < 0) ship.ThrottleDown();

                //switch proppeller direction
                if (controls.Boat.Reverse.triggered) ship.Reverse();
            }
        }
    }
}