using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplaySettings : BaseSettingsPanel
{
    [SerializeField] Scrollbar sensitivitySB;
    [SerializeField] Text valueText;


    public override void CloseProgram()
    {
        OnClosed();
        gameObject.SetActive(false);
    }

    public void valueChanged()
    {
        SettingManager.Instance.UpdateMouseSens(sensitivitySB.value);
        valueText.text = (PlayerPrefs.GetFloat("mouseSens")).ToString("#.0");
    }

    public override void OnClosed()
    {
        settingsButton.color = new Color(1, 1, 1, 1);
    }

    public override void OnOpened()
    {
        settingsButton.color = new Color(0, 1, 0, 1);
        valueText.text = PlayerPrefs.GetFloat("mouseSens").ToString("#.0");
        sensitivitySB.value=(PlayerPrefs.GetFloat("mouseSens") - 2)/ 20f;
    }

    public override void OpenProgram()
    {
        OnOpened();
        gameObject.SetActive(true);
    }


}
