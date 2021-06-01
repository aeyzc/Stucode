using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoSettings : BaseSettingsPanel
{
    public override void CloseProgram()
    {
        OnClosed();
        gameObject.SetActive(false);
    }

    public override void OnClosed()
    {
        settingsButton.color = new Color(1, 1, 1, 1);
    }

    public override void OnOpened()
    {
        settingsButton.color = new Color(0, 1, 0, 1);
    }

    public override void OpenProgram()
    {
        OnOpened();
        gameObject.SetActive(true);
    }
}
