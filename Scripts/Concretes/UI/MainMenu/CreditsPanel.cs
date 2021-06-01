using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsPanel : BaseMMPanel
{
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
    }

    public override void OpenPanel()
    {
        OnOpened();
        gameObject.SetActive(true);
    }


}