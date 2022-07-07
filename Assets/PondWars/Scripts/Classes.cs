/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tegridy.Boat;
using Tegridy.Turret;
using Tegridy.Ordinance;
namespace Tegridy.PondWars
{
    [System.Serializable] public class PlayerVessel
    {
        public PlayerInput input;
        public TegridyBoat boat;
        public TegridyBoatNewInput boatControl;
        public TegridyTurretNewInputMulti turretControl;
    }
}