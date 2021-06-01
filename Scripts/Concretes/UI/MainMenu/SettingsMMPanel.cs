using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMMPanel : BaseMMPanel
{
    [SerializeField] Scrollbar sfxSB, soundSB, musicSB,sensSB;
    [SerializeField] Text sfxValueText, soundValueText, musicValueText,sensValueText;

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
        sfxValueText.text = (PlayerPrefs.GetFloat("sfxvolume") * 100).ToString("#.0");
    }

    public void sensvalueChanged()
    {
        SettingManager.Instance.UpdateMouseSens(sensSB.value);
        sensValueText.text = (PlayerPrefs.GetFloat("mouseSens")).ToString("#.0");
    }

    public override void ClosePanel()
    {
        OnClosed();
        gameObject.SetActive(false);
    }

    public override void OnClosed()
    {
        panelButton.color = new Color(1, 1, 1, 1);


    }

    public override void OnOpened()
    {
        panelButton.color = new Color(0, 1, 0, 1);
        musicValueText.text = (PlayerPrefs.GetFloat("musicvolume") * 100).ToString("#.0");
        soundValueText.text = (PlayerPrefs.GetFloat("soundvolume") * 100).ToString("#.0");
        sfxValueText.text = (PlayerPrefs.GetFloat("sfxvolume") * 100).ToString("#.0");
        sfxSB.value = PlayerPrefs.GetFloat("sfxvolume");
        soundSB.value = PlayerPrefs.GetFloat("soundvolume");
        musicSB.value = PlayerPrefs.GetFloat("musicvolume");
        sensValueText.text = PlayerPrefs.GetFloat("mouseSens").ToString("#.0");
        sensSB.value = (PlayerPrefs.GetFloat("mouseSens") - 2) / 20f;
    }

    public override void OpenPanel()
    {
        OnOpened();
        gameObject.SetActive(true);
    }


}