/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Tegridy.Tools;
using UnityEngine.SceneManagement;
namespace Tegridy.PondWars {
    public class MainMenu : MonoBehaviour
    {
        public UIOverlay gameOverlay; //overlay to be used ingame

        public GameObject menuHolder;

        [Header("Main Menu Objects")]
        public AudioClip mainAudio; //music to be played on main menu
        public Image mainMenu; //main menu holder
        public TextMeshProUGUI title; //game name
        public TextMeshProUGUI description; 
        public Button start;
        public Button exit;
        public Button notesView;

        [Header("Info Screen")]
        public Image notes;
        public Button notesBack;
        public TextMeshProUGUI notesTitle;
        public TextMeshProUGUI notesDescription;

        [Header("Language Screen")]
        public Image languageScreen;
        public Button languagePrefab;
        public float vSpacing;
        public float hSpacing;
        public GameObject[] langButt;

        PlayerControl playerControl;
        AudioSource audioSource;
        LanguageController language;

        void Awake()
        {
            //find the game objects and play a little music
            playerControl = FindObjectOfType<PlayerControl>();
            playerControl.StartUp();

            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.loop = true;
            if (mainAudio != null) audioSource.clip = mainAudio;
            audioSource.Play();

            //setup the buttons for the gui
            start.onClick.AddListener(() => StartGame());
            notesView.onClick.AddListener(() => OpenNotes(true));
            notesBack.onClick.AddListener(() => OpenNotes(false));
            exit.onClick.AddListener(() => ExitGame());
            gameOverlay.close.onClick.AddListener(() => ResetScene());

            //make sure the ui wasn't left open in the editor
            mainMenu.SetActive(false);
            notes.SetActive(false);
            gameOverlay.SetActive(false);
            menuHolder.SetActive(true);

            gameOverlay.player = playerControl.players[0];


            //open the language screen and load the selected language
            language = FindObjectOfType<LanguageController>();
            language.GetLanguagePacks();
            OpenLanguageSelect();
        }
        void OpenMainMenu()
        {
            UITools.SetButtonText(start, LanguageMenu.start);
            UITools.SetButtonText(exit, LanguageMenu.exit);
            UITools.SetButtonText(notesView, LanguageMenu.notesOpen);
            UITools.SetButtonText(notesBack, LanguageMenu.notesClose);
            title.text = LanguageMenu.gameName;
            description.text = LanguageMenu.gameDescription;
            notesTitle.text = LanguageMenu.notesTitle;
            notesDescription.text = LanguageMenu.notesDescription;
            mainMenu.SetActive(true);
        }
        void StartGame()
        {
            mainMenu.SetActive(false);
            menuHolder.SetActive(false);
            gameOverlay.SetActive(true);
            gameOverlay.active = true;
            playerControl.EnablePlayer(0, true);
            FindObjectOfType<CanManager>().ResetCans();
        }
        void ExitGame()
        {
            Application.Quit();
        }
        void OpenNotes(bool open)
        {
            mainMenu.SetActive(!open);
            notes.SetActive(open);
            
        }
        private void OpenLanguageSelect()
        {
            //create the buttons
            UITools.DestoryOld(langButt);
            langButt = UITools.DrawTiled(languagePrefab.gameObject, language.languageNames.Length, hSpacing, vSpacing, 2);

            //add the listeners
            for (int i = 0; i < langButt.Length; i++)
            {
                int selection = i;
                langButt[i].GetComponentInChildren<TextMeshProUGUI>().text = language.languageNames[i];
                langButt[i].GetComponent<Button>().onClick.AddListener(() => CloseLanguageSelect(selection));
            }

            //enable the ui
            languageScreen.SetActive(true);
        }
        private void CloseLanguageSelect(int i)
        {
            UITools.DestoryOld(langButt);
            language.selectedLanguage = i;
            language.LoadSelectedLanguage();
            languageScreen.SetActive(false);
            gameOverlay.StartUp();
            OpenMainMenu();
        }
        public void ResetScene()
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}