using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopProgram : BaseProgram
{
    public override void CloseProgram()
    {
        this.gameObject.SetActive(false);
        OnClosed();
    }

    public override void OnClosed()
    {
        GameManager.Instance.isComputerActive = false;
        GameManager.Instance.isGameActive = true;
        CursorManager.Instance.continuedGameCursor();
    }

    public override void OnOpened()
    {

    }

    public override void OpenProgram()
    {
        OnOpened();
        this.gameObject.SetActive(true);
    }
}
