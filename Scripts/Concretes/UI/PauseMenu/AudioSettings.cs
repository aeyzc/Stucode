using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : BaseSettingsPanel
{
    [SerializeField] Scrollbar sfxSB,soundSB,musicSB;
    [SerializeField] Text sfxValueText,soundValueText,musicValueText;


    public override void CloseProgram()
    {
        OnClosed();
        gameObject.SetActive(false);
    }

    public void musicvalueChanged()
    {
        SettingManager.Instance.UpdateMusicVolume(musicSB.value);
        musicValueText.text = (PlayerPrefs.GetFloat("musicvolume") * 100).ToString("#.0");
    }

    public void soundvalueChanged()
    {
        SettingManager.Instance.UpdateSoundVolume(soundSB.value);
        soundValueText.text = (PlayerPrefs.GetFloat("soundvolume") * 100).ToString("#.0");
    }

    public void sfxvalueChanged()
    {
        SettingManager.Instance.UpdateSfxVolume(sfxSB.value);
        sfxValueText.text = (PlayerPrefs.GetFloat("sfxvolume") *100).ToString("#.0");
    }

    public override void OnClosed()
    {
        settingsButton.color = new Color(1, 1, 1, 1);

    }

    public override void OnOpened()
    {
        settingsButton.color = new Color(0, 1, 0, 1);
        musicValueText.text = (PlayerPrefs.GetFloat("musicvolume") * 100).ToString("#.0");
        soundValueText.text = (PlayerPrefs.GetFloat("soundvolume") * 100).ToString("#.0");
        sfxValueText.text = (PlayerPrefs.GetFloat("sfxvolume") * 100).ToString("#.0");
        sfxSB.value = PlayerPrefs.GetFloat("sfxvolume");
        soundSB.value = PlayerPrefs.GetFloat("soundvolume");
        musicSB.value = PlayerPrefs.GetFloat("musicvolume");
    }

    public override void OpenProgram()
    {
        OnOpened();
        gameObject.SetActive(true);
    }
}
