using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SettingManager : MonoBehaviour
{
    public Toggle fullscreenToggle;
    public Slider soundVolumeSlider;
    public Button applyButton;

    public AudioSource musicSource;
    public GameSettings gameSettings;

    public void OnEnable()
    {
        gameSettings = new GameSettings();

        fullscreenToggle.onValueChanged.AddListener(delegate { OnFullScreenToggle(); });
        soundVolumeSlider.onValueChanged.AddListener(delegate { onSoundVolumeChange(); });
        applyButton.onClick.AddListener(delegate { OnApplyButtonClick(); });

        LoadSettings();
    }

    public void OnFullScreenToggle()
    {
        gameSettings.fullscreen = Screen.fullScreen = fullscreenToggle.isOn;
    }

    public void onSoundVolumeChange()
    {
        musicSource.volume = gameSettings.soundVolume = soundVolumeSlider.value;
    }

    public void OnApplyButtonClick()
    {
        SaveSettings();
    }

    public void SaveSettings()
    {
        string jsonData = JsonUtility.ToJson(gameSettings, true);
        File.WriteAllText(Application.persistentDataPath + "/gamesettings.json", jsonData);
    }

    public void LoadSettings()
    {
        gameSettings = JsonUtility.FromJson<GameSettings>(File.ReadAllText(Application.persistentDataPath + "/gamesettings.json"));
        soundVolumeSlider.value = gameSettings.soundVolume;
        fullscreenToggle.isOn = gameSettings.fullscreen;
    }
}
