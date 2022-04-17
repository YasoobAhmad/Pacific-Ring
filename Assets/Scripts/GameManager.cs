using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public AudioSource onClickSound;
    public AudioSource gameMusic;
    public GameObject settingsButton;
    public GameObject closeButton;
    public GameObject pausePanel;
    public GameObject optionsPanel;
    public GameObject backButton;
    //[SerializeField] AudioSource gameMusic;
    public Slider soundVolumeSlider;
    public Slider musicVolumeSlider;

    String soundKey = "SoundVolume";
    String musicKey = "musicVolume";
    void Start()
    {
        if (!PlayerPrefs.HasKey(soundKey))
        {
            PlayerPrefs.SetFloat(soundKey, 1);
        }
        if (!PlayerPrefs.HasKey(musicKey))
        {
            PlayerPrefs.SetFloat(musicKey, 1);
        }
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OpenPausePanel()
    {
        onClickSound.Play();
        closeButton.SetActive(true);
        pausePanel.SetActive(true);
        settingsButton.SetActive(false);
    }

    public void Resume()
    {
        onClickSound.Play();
        closeButton.SetActive(false);
        pausePanel.SetActive(false);
        optionsPanel.SetActive(false);
        settingsButton.SetActive(true);
        
    }

    public void ShowPausePanel()
    {
        onClickSound.Play();
        pausePanel.SetActive(true);
        optionsPanel.SetActive(false); 
    }

  
    public void ShowOptionsPanel()
    {
        onClickSound.Play();
        pausePanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void changeSoundVolume()
    {
        onClickSound.volume = soundVolumeSlider.value;
        Save();
    }
    public void changeMusicVolume()
    {
        gameMusic.volume = musicVolumeSlider.value;
        Save();
    }
    private void Load()
    {
        soundVolumeSlider.value = PlayerPrefs.GetFloat(soundKey);
        musicVolumeSlider.value = PlayerPrefs.GetFloat(musicKey);
    }
    private void Save()
    {
        PlayerPrefs.SetFloat(soundKey, soundVolumeSlider.value);
        PlayerPrefs.SetFloat(musicKey, musicVolumeSlider.value);
    }

}
