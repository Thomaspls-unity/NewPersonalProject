using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Toggle musicToggle;
    [SerializeField] private AudioSource musicSource;

    [SerializeField] private Slider sfxSlider;
    [SerializeField] private Toggle sfxToggle;
    [SerializeField] private AudioSource sfxSources;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateGameSettings()
    {
        bool musicIntToBool = PlayerPrefs.GetInt("Music_Toggle") == 0 ? false : true;
        musicToggle.isOn = musicIntToBool;
        musicSlider.value = PlayerPrefs.GetFloat("Music_Volume");

        bool sfxIntToBool = PlayerPrefs.GetInt("SFX_Toggle") == 0 ? false : true;
        sfxToggle.isOn = sfxIntToBool;
        sfxSlider.value = PlayerPrefs.GetFloat("SFX_Volume");
    }

    public void SetMusicValue(float value)
    {
        Utility.musicVolume = value;
        SavePlayerSettings();
    }

    public void SetMusicOn(bool value)
    {
        Utility.isMusicOn = value;
        SavePlayerSettings();
    }
    
    public void SetSFXValue(float value)
    {
        Utility.sfxVolume = value;
        SavePlayerSettings();
    }

    public void SetSFXOn(bool value)
    {
        Utility.isSfxOn = value;
        SavePlayerSettings();
    }

    public void SavePlayerSettings()
    {
        PlayerPrefs.SetFloat("Music_Volume", Utility.musicVolume);

        int musicBoolToInt = Utility.isMusicOn ? 1 : 0;
        PlayerPrefs.SetInt("Music_Toggle", musicBoolToInt);
        
        PlayerPrefs.SetFloat("SFX_Volume", Utility.sfxVolume);

        int sfxBoolToInt = Utility.isSfxOn ? 1 : 0;
        PlayerPrefs.SetInt("SFX_Toggle", sfxBoolToInt);
    }

}
