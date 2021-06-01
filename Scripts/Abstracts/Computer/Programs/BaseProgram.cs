using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseProgram : MonoBehaviour
{

    public string programName;
    public Sprite programIcon;

    public abstract void OpenProgram();
    public abstract void OnOpened();
    public abstract void CloseProgram();
    public abstract void OnClosed();


}
