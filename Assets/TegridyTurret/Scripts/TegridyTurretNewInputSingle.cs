/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
namespace Tegridy.Turret
{
    public class TegridyTurretNewInputSingle : MonoBehaviour
    {
        // Start is called before the first frame update
        public TegridyTurret turret;
        public float inputSpeed;

        PlayerInput input;
        void Start()
        {
            //tell the turret what mode to use.
            turret.targetMode = 1;

            //get the player input
            input = new PlayerInput();
            input.Enable();
            turret.StartUp();
            turret.active = true;
        }

        void Update()
        {
            //capture the input for the turret
            Vector2 _thisVector = input.Turret.RotateTurret.ReadValue<Vector2>();
            turret.bearing += _thisVector.x * (Time.deltaTime * inputSpeed);
            turret.inclination += _thisVector.y * (Time.deltaTime * inputSpeed);
            //do our fire control
            if (input.Turret.ChangeAmmo.triggered) turret.ChangeProjectileAmmo();
            if (input.Turret.Fire.triggered) turret.Fire();
        }
    }
}