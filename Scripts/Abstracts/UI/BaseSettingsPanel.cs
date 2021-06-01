using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSettingsPanel : MonoBehaviour
{
    public Text settingsButton;
    public abstract void OpenProgram();
    public abstract void OnOpened();
    public abstract void CloseProgram();
    public abstract void OnClosed();
}
