using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : BaseMenu
{
    public BaseMMPanel[] mmPanels;
    public Texture2D cursorTexture;

    private void Start()
    {
        if (PlayerPrefs.GetInt("isFirst")==0)
        {
            PlayerPrefs.SetFloat("soundvolume", 1);
            PlayerPrefs.SetFloat("sfxvolume", 1);
            PlayerPrefs.SetFloat("musicvolume", 1);
            PlayerPrefs.SetFloat("mouseSens", 8);
            PlayerPrefs.SetInt("isFirst", 1);

        }
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);

    }
    public void openPanel(BaseMMPanel openingPanel)
    {
        foreach (BaseMMPanel mmPanel in mmPanels)
        {
            if (mmPanel == openingPanel)
            {
                mmPanel.OpenPanel();
            }
            else
            {
                mmPanel.ClosePanel();
            }
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public override void CloseMenu()
    {
        throw new System.NotImplementedException();
    }
}
