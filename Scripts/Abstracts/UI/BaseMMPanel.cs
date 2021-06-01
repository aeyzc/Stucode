using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseMMPanel : MonoBehaviour
{
    public Text panelButton;
    public abstract void OpenPanel();
    public abstract void OnOpened();
    public abstract void ClosePanel();
    public abstract void OnClosed();
}
