/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
using Tegridy.Water;
namespace Tegridy.PondWars
{
    public class PlayerControl : MonoBehaviour
    {
        public PlayerVessel[] players;
        PlayerInput controls;
        public void StartUp()
        {
            //setup the player vessels and keep them idle for now
            controls = new PlayerInput();
            for (int i = 0; i < players.Length; i++)
            {
                players[i].input = controls;
                players[i].boat.GetComponent<TegridyBuoyancy>().StartUp();
                players[i].boat.StartUp();
                players[i].boatControl.StartUp(controls, players[i].boat);
                players[i].turretControl.StartUp(controls);
                EnablePlayer(i, false);
            }
        }
        public void EnablePlayer(int playerNum, bool active)
        {
            //toggles the vessels active state.
            players[playerNum].boat.active = active;
            players[playerNum].boat.enabled = active;
            players[playerNum].boat.EnableShip(active);
            players[playerNum].boatControl.active = active;
            players[playerNum].turretControl.active = active;
        }
    }
}