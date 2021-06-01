using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : BaseMenu
{


    public void pauseGame()
    {
        EscManager.Instance.activeMenu = this;
        gameObject.SetActive(true);
        GameManager.Instance.isGameActive = false;
        CursorManager.Instance.pausedGameCursor();
    }
   

    public void continueGame()
    {
        gameObject.SetActive(false);
        GameManager.Instance.isGameActive = true;
        CursorManager.Instance.continuedGameCursor();
    }

    public void restartLevel()
    {
        GameManager.Instance.isGameActive = true;
        CursorManager.Instance.continuedGameCursor();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    public void returnMainMenu()
    {
        Destroy(GameManager.Instance.gameObject);
        SceneManager.LoadScene("MainMenu");
    }

    public void shutdownGame()
    {
        Application.Quit();
    }

    public override void CloseMenu()
    {
        continueGame();
    }
}
