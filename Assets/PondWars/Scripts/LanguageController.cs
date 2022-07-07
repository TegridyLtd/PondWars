/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
using System.IO;
using System;
using Tegridy.Boat;
namespace Tegridy.PondWars
{
    public static class LanguageMenu
    {
        public static string gameName;
        public static string gameDescription;
        public static string start;
        public static string exit;
        public static string notesOpen;
        public static string notesClose;
        public static string notesTitle;
        public static string notesDescription;
    }
    public static class LanguageTurret
    {
        public static string pivot;
        public static string rotation;
        public static string ammo;
        public static string ammoQty;
        public static string fireMode;
        public static string targetMode;
        public static string turret;
    }
    public class LanguageController : MonoBehaviour
    {
        //Note to readers, sorry.
        readonly string mainPath = Application.streamingAssetsPath + "/Languages/languages.txt";

        public int selectedLanguage = 0;
        public string[] languageNames;
        string[] languageImages;
        string[] languagePaths;

        public string creditsText;
        public void GetLanguagePacks()
        {
            string[] data;
            data = File.ReadAllLines(mainPath);
            Array.Resize(ref languageNames, data.Length);
            Array.Resize(ref languageImages, data.Length);
            Array.Resize(ref languagePaths, data.Length);

            //get our split and load the images
            for (int i = 0; i < data.Length; i++)
            {
                string value = data[i];
                string[] split = value.Split(',');
                languageNames[i] = split[0];
                languageImages[i] = Application.streamingAssetsPath + "/Languages" + (split[1]);
                languagePaths[i] = Application.streamingAssetsPath + "/Languages" + (split[2]);
            }
        }
        public void LoadSelectedLanguage()
        {
            //check if we have a matching language file for the selected language, if not use the default language for that part of the ui
            //load and format game credits
            string[] creditData;
            if (File.Exists(languagePaths[selectedLanguage] + "/Credits.txt")) creditData = File.ReadAllLines(languagePaths[selectedLanguage] + "/Credits.txt");
            else creditData = File.ReadAllLines(languagePaths[0] + "/Credits.txt");
            for (int i = 0; i < creditData.Length; i++)
            {
                creditsText += "<br>" + creditData[i];
            }

            //load the strings used in the main menu
            string[] mainMenu;
            if (File.Exists(languagePaths[selectedLanguage] + "/MainMenu.txt")) mainMenu = File.ReadAllLines(languagePaths[selectedLanguage] + "/MainMenu.txt");
            else mainMenu = File.ReadAllLines(languagePaths[0] + "/MainMenu.txt");
            LanguageMenu.gameName = mainMenu[0];
            LanguageMenu.gameDescription = mainMenu[1];
            LanguageMenu.start = mainMenu[2];
            LanguageMenu.exit = mainMenu[3];
            LanguageMenu.notesOpen = mainMenu[4];
            LanguageMenu.notesClose = mainMenu[5];
            LanguageMenu.notesTitle = mainMenu[6];
            LanguageMenu.notesDescription = mainMenu[7];

            //load the strings for the game overlay
            string[] overlay;
            if (File.Exists(languagePaths[selectedLanguage] + "/Overlay.txt")) overlay = File.ReadAllLines(languagePaths[selectedLanguage] + "/Overlay.txt");
            else overlay = File.ReadAllLines(languagePaths[0] + "/Overlay.txt");
            TegridyBoatLanguage.forward = overlay[0];
            TegridyBoatLanguage.reverse = overlay[1];
            TegridyBoatLanguage.rpm = overlay[2];
            TegridyBoatLanguage.gear = overlay[3];
            TegridyBoatLanguage.rudderPos = overlay[4];
            TegridyBoatLanguage.fuel = overlay[5];
            TegridyBoatLanguage.throttle = overlay[6];
            TegridyBoatLanguage.speed = overlay[7];
            TegridyBoatLanguage.speedFormat = overlay[8];
            TegridyBoatLanguage.maxRPM = overlay[9];
            TegridyBoatLanguage.close = overlay[10];
            TegridyBoatLanguage.gameOverTitle = overlay[11];
            TegridyBoatLanguage.gameOverLand = overlay[12];
            TegridyBoatLanguage.gameOverFuel = overlay[13];
            TegridyBoatLanguage.gameOverTime = overlay[14];
            TegridyBoatLanguage.gameOverWinner = overlay[15];
            TegridyBoatLanguage.objective = overlay[16];

            string[] turret;
            if (File.Exists(languagePaths[selectedLanguage] + "/Turret.txt")) turret = File.ReadAllLines(languagePaths[selectedLanguage] + "/Turret.txt");
            else turret = File.ReadAllLines(languagePaths[0] + "/Turret.txt");
            LanguageTurret.pivot = turret[0];
            LanguageTurret.rotation = turret[1];
            LanguageTurret.ammo = turret[2];
            LanguageTurret.ammoQty = turret[3];
            LanguageTurret.fireMode = turret[4];
            LanguageTurret.targetMode = turret[5];
            LanguageTurret.turret = turret[6];
    }
    }
}