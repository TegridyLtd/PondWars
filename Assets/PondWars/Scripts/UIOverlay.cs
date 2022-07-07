/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
using TMPro;
using Tegridy.Boat;
using UnityEngine.UI;
using Tegridy.Turret;
using System.Collections;
using Tegridy.Tools;
namespace Tegridy.PondWars
{
    public class UIOverlay : MonoBehaviour
    {
        [HideInInspector] public PlayerVessel player;

        public Button close;

        [Header("Game Over")]
        public Image gameOver;
        public TextMeshProUGUI gameOverTitle;
        public TextMeshProUGUI gameOverDescription;

        [Header("Ship Info Display")]
        public TextMeshProUGUI throttle;
        public TextMeshProUGUI rudder;
        public TextMeshProUGUI fuel;
        public TextMeshProUGUI speed;
        public TextMeshProUGUI rpmT;
        public TextMeshProUGUI direction;

        public Image throttleMeter;
        public Image fuelMeter;

        [Header("Turrent Info Display")]
        public UITurretPrefab turretPrefab;
        public float prefabSpacing;
        public UITurretPrefab[] turretDisplay;

        [Header("Objective Info")]
        public TextMeshProUGUI objective;
        //saves us recalulating every frame
        float maxFuel;
        float fuelPerc;

        CanManager canManager;

        public bool active;
        public void StartUp()
        {
            canManager = FindObjectOfType<CanManager>();
            canManager.StartUp();
            maxFuel = player.boat.fuel;
            fuelPerc = maxFuel / 100;

            //draw the ui ready for starting the demo, it wont change so might as well
            GameObject[] temp = UITools.DrawStraight(turretPrefab.gameObject, player.turretControl.turret.Length, prefabSpacing, false, false, null);
            turretDisplay = new UITurretPrefab[temp.Length];
            for(int i = 0; i < temp.Length; i++)
            {
                //get the turret prefabs for later
                turretDisplay[i] = temp[i].GetComponent<UITurretPrefab>();

                //draw the barrel prefabs for each turret and store them in the prefab for later
                turretDisplay[i].barrelHolder = new UITurretBarrelPrefab[player.turretControl.turret[i].projectilePod.Length];
                GameObject[] temp2 = UITools.DrawStraight(turretDisplay[i].barrel.gameObject, player.turretControl.turret[i].projectilePod.Length, turretDisplay[i].prefabSpacing, true, false, null);

                for (int i2 = 0; i2 < turretDisplay[i].barrelHolder.Length; i2++)
                {
                    turretDisplay[i].barrelHolder[i2] = temp2[i2].GetComponent<UITurretBarrelPrefab>();
                    turretDisplay[i].barrelHolder[i2].turretText.text = LanguageTurret.turret + (i2 + 1).ToString();
                }
            }
        }
        private void Update()
        {
         if(active) UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            //figure out how much fuel we have
            float thisFuel = player.boat.fuel / fuelPerc;
            fuel.text = TegridyBoatLanguage.fuel + thisFuel.ToString("F1") + "%<br>";
            fuelMeter.fillAmount = thisFuel / 100;

            //set the throttle
            throttle.text = TegridyBoatLanguage.throttle + (player.boat.throttle * 100).ToString("F0") + "%<br>";
            throttleMeter.fillAmount = player.boat.throttle;

            //Make sure the Rpm stays positive for display
            int rpm = (int)player.boat.rpm;
            if (rpm < 0) rpm *= -1;
            rpmT.text = TegridyBoatLanguage.rpm + rpm + "/" + player.boat.maxRPM.ToString("F0") + "<br>";

            //decide what direction we are going
            if (player.boat.direction == 1) direction.text = TegridyBoatLanguage.gear + TegridyBoatLanguage.forward;
            else direction.text = TegridyBoatLanguage.gear + TegridyBoatLanguage.reverse;

            //Finish up
            speed.text = TegridyBoatLanguage.speed + ((player.boat.rb.velocity.magnitude * 2.237) * 2).ToString("F2") + "mph<br>";
            rudder.text = TegridyBoatLanguage.rudderPos + player.boat.angle.ToString("F2") + "<br>";

            objective.text = canManager.hit.Count + "/" + canManager.cans.Length + TegridyBoatLanguage.objective;

            //update the turret info
            for (int i = 0; i < turretDisplay.Length; i++)
            {
                turretDisplay[i].pivot.text = LanguageTurret.pivot + player.turretControl.turret[i].inclination;
                turretDisplay[i].rotation.text = LanguageTurret.rotation + player.turretControl.turret[i].bearing;
                turretDisplay[i].ammo.text = LanguageTurret.ammo + player.turretControl.turret[i].projectileType;
                turretDisplay[i].ammoQty.text = LanguageTurret.ammoQty + player.turretControl.turret[i].projectileAmmo[player.turretControl.turret[i].projectileType].ammoQuty;
                turretDisplay[i].fireMode.text = LanguageTurret.fireMode + player.turretControl.fireMode;
                turretDisplay[i].targetMode.text = LanguageTurret.targetMode + player.turretControl.targetMode;
                for (int i2 = 0; i2 < player.turretControl.turret[i].projectilePod.Length; i2++)
                {
                    Debug.Log("Setting barrel reload status");
                if (player.turretControl.turret[i].projectilePod[i2].reloading) turretDisplay[i].barrelHolder[i2].reloading.color = turretDisplay[i].barrelHolder[i2].reloadingColor[1];
                else turretDisplay[i].barrelHolder[i2].reloading.color = turretDisplay[i].barrelHolder[i2].reloadingColor[0];
                }
            }

            if (player.boat.fuel <= 0) StartCoroutine(GameOver(TegridyBoatLanguage.gameOverFuel));
            if (player.boat.landHit == true) StartCoroutine(GameOver(TegridyBoatLanguage.gameOverLand));
            if (canManager.hit.Count == canManager.cans.Length) StartCoroutine(GameOver(TegridyBoatLanguage.gameOverWinner));
        }

        IEnumerator GameOver(string reason)
        {
            active = false;
            FindObjectOfType<PlayerControl>().EnablePlayer(0, false);
            gameOverTitle.text = TegridyBoatLanguage.gameOverTitle;
            gameOverDescription.text = reason;
            gameOver.SetActive(true);
            yield return new WaitForSeconds(3);
            FindObjectOfType<MainMenu>().ResetScene();
        }
    }
}