using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : MonoBehaviour
{
    public static SettingManager Instance { get; private set; }



    private void Awake()
    {
        SingletonThisGameObject();
    }

    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void UpdateSfxVolume(float value)
    {
        PlayerPrefs.SetFloat("sfxvolume", value);

    }

    public void UpdateMusicVolume(float value)
    {
        PlayerPrefs.SetFloat("musicvolume", value);
    }

    public void UpdateSoundVolume(float value)
    {
        PlayerPrefs.SetFloat("soundvolume", value);
    }

    public void UpdateMouseSens(float value)
    {
        PlayerPrefs.SetFloat("mouseSens", (value * 20) + 2);
    }
}
