using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorTexture;

    public static CursorManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);


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
    private void Start()
    {
        continuedGameCursor();
    }
    public void pausedGameCursor()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void continuedGameCursor()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        

    }
    
    
}
