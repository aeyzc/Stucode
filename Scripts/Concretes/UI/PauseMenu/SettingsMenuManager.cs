using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenuManager : BaseMenu
{
    [SerializeField] PauseMenuManager pauseMenu;
    public BaseSettingsPanel[] settingsPanels; 
    
    public void openSettingPanels(BaseSettingsPanel openingSetting)
    {
        foreach(BaseSettingsPanel settingPanel in settingsPanels)
        {
            if (settingPanel == openingSetting)
            {
                settingPanel.OpenProgram();
            }
            else
            {
                settingPanel.CloseProgram();
            }
        }
    }
    public void openSettings()
    {
        EscManager.Instance.activeMenu = this;
        openSettingPanels(settingsPanels[0]);
        gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(false);
    }

    public void closeSettings()
    {
        EscManager.Instance.activeMenu = pauseMenu;
        gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(true);
    }

    public override void CloseMenu()
    {
        closeSettings();
    }
}
