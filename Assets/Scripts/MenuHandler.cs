using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject optionPanel;
    [SerializeField] AudioSource onClickSound;
    [SerializeField] AudioSource gameMusic;
    [SerializeField] Slider soundVolumeSlider;
    [SerializeField] Slider musicVolumeSlider;

    String soundKey = "SoundVolume";
    String musicKey = "musicVolume"; 
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameMusic);
        if (!PlayerPrefs.HasKey(soundKey))
        {
            PlayerPrefs.SetFloat(soundKey, 1); 
        }
        if(!PlayerPrefs.HasKey(musicKey))
        {
            PlayerPrefs.SetFloat(musicKey, 1);
        }
        Load();
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
    private void Load(){
        soundVolumeSlider.value = PlayerPrefs.GetFloat(soundKey);
        musicVolumeSlider.value = PlayerPrefs.GetFloat(musicKey);
    }
    private void Save()
    {
        PlayerPrefs.SetFloat(soundKey,soundVolumeSlider.value);
        PlayerPrefs.SetFloat(musicKey,musicVolumeSlider.value);
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        onClickSound.Play();
        SceneManager.LoadScene("Sandbox");
    }

    public void showOptionsPanel()
    {
        onClickSound.Play();
        optionPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void showMainPanel()
    {
        onClickSound.Play();
        mainPanel.SetActive(true);
        optionPanel.SetActive(false);
    }
}
