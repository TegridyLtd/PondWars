/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
namespace Tegridy.Boat
{
    public class TegridyBoatOldInput : MonoBehaviour
    {
        TegridyBoat ship;
        [SerializeField] bool active = false;
        public void StartUp(TegridyBoat boat)
        {
            ship = boat;
            active = true;
        }
        void Update()
        {
            if (active)
            {
                //set the rudder
                float horizontal = Input.GetAxis("Horizontal");
                if (horizontal < 0) ship.RudderLeft();
                else if (horizontal > 0) ship.RudderRight();

                //set the throttle
                float vertical = Input.GetAxis("Vertical");
                if (vertical > 0) ship.ThrottleUp();
                else if (vertical < 0) ship.ThrottleDown();

                //switch proppeller direction
                if (Input.GetButtonDown("Fire1")) ship.Reverse();
            }
        }
    }
}