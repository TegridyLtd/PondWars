/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
using Tegridy.Ordinance;
namespace Tegridy.Turret
{
    public class TegridyTurretNewInputMulti : MonoBehaviour
    {
        public TegridyOrdinanceManager fireControl;

        // Start is called before the first frame update
        public TegridyTurret[] turret;
        public float inputSpeed;
        public int targetMode = 1;
        public int fireMode;

        public bool updateAll;
        public int updateTurret;

        PlayerInput input;

        public bool active;

        public void StartUp(PlayerInput thisInput)
        {
            //tell the turret what mode to use.
            for (int i = 0; i < turret.Length; i++)
            {
                turret[i].targetMode = targetMode;
                turret[i].fireMode = fireMode;
                turret[i].fireControl = fireControl;
                turret[i].StartUp();
                turret[i].active = true;
            }

            //get the player input
            input = thisInput;
        }
        public void TurretActive(bool active)
        {
            for (int i = 0; i < turret.Length; i++)
            {
                turret[i].active = active;
            }
        }

        void Update()
        {
            if (active)
            {
                //capture the input for the turret
                Vector2 _thisVector = input.Turret.RotateTurret.ReadValue<Vector2>();
                _thisVector *= (Time.deltaTime * inputSpeed);

                UpdateRotationAll(_thisVector);
                if (input.Turret.ChangeAmmo.triggered) ChangeProjectileAll();
                if (input.Turret.Fire.triggered) FireAll();
            }
        }
        #region Targeting & Movement
        public void UpdateRotationAll(Vector2 ammount)
        {
            for (int i = 0; i < turret.Length; i++)
            {
                UpdateRotation(i, ammount);
            }
        }
        public void UpdateRotation(int thisTurret, Vector2 ammount)
        {
                turret[thisTurret].bearing += ammount.x;
                turret[thisTurret].inclination += ammount.y;
        }
        public void SetRotationAll(float bearing, float inclination)
        {
            for (int i = 0; i < turret.Length; i++)
            {
                SetRotation(i, bearing, inclination);
            }
        }
        public void SetRotation(int thisTurret, float bearing, float inclination)
        {
            turret[thisTurret].bearing = bearing;
            turret[thisTurret].inclination = inclination;
        }
        public void SetTargetModeAll(int mode)
        {
            for (int i = 0; i < turret.Length; i++)
            {
                turret[i].targetMode = mode;
            }
        }
        public void SetTargetMode(int thisTurret, int mode)
        {
            turret[thisTurret].targetMode = mode;
        }
        public void SetFireModeAll(int mode)
        {
            for (int i = 0; i < turret.Length; i++)
            {
                turret[i].fireMode = mode;
            }
        }
        public void SetFireMode(int thisTurret, int mode)
        {
            turret[thisTurret].fireMode = mode;
        }
        public void SetTargetAll(Transform target)
        {
            for (int i = 0; i < turret.Length; i++)
            {
                SetTarget(i, target);
            }
        }
        public void SetTarget(int thisTurret, Transform target)
        {
            turret[thisTurret].target = target;
        }
        public void FireAll()
        {
            for (int i = 0; i < turret.Length; i++)
            {
                Fire(i);
            }
        }
        public void Fire(int thisTurret)
        {
            turret[thisTurret].Fire();
        }
        #endregion


        #region Ammo Changes
        public void ChangeAmmoAll()
        {
            for (int i = 0; i < turret.Length; i++)
            {
                ChangeAmmo(i);
            }
        }
        public void ChangeAmmo(int thisTurret)
        {
            turret[thisTurret].ChangeAmmo();
        }
        public void SetProjectileAll(int ammo) 
        {
            for (int i = 0; i < turret.Length; i++)
            {
                SetProjectile(i, ammo);
            }

        }
        public void SetProjectile(int pod, int ammo)
        {
            turret[pod].SetProjectileAmmo(ammo);
        }
        public void ChangeProjectileAll()
        {
            for (int i = 0; i < turret.Length; i++)
            {
                ChangeProjectile(i);
            }

        }
        public void ChangeProjectile(int pod)
        {
            turret[pod].ChangeProjectileAmmo();
        }
        public void ChangeMissileAll() 
        {
            for (int i = 0; i < turret.Length; i++)
            {
                ChangeMissile(i);
            }

        }
        public void ChangeMissile(int thisTurret) 
        {
            for (int i =0; i< turret[thisTurret].missilePod.Length; i++)
            {
                turret[thisTurret].ChangeMissileAmmo(i);
            }
            
        }
        #endregion
    }
}