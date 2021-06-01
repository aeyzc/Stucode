using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscManager : MonoBehaviour
{
    public PauseMenuManager pauseMenu;
    public BaseMenu activeMenu;
    public GameObject escMenu,ayarlarMenu;

    public static EscManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameManager.Instance.isComputerActive)
            {
                ComputerManager.Instance.activeProgram.CloseProgram();
            }

            else 
            {
                if (!GameManager.Instance.isGameActive)
                {
                    activeMenu.CloseMenu();
                }

                else
                {
                    pauseMenu.pauseGame();
                }
            }
        }
    }

    

}
