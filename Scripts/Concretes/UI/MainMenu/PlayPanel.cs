using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayPanel : BaseMMPanel
{
    int pageCount = 1;
    [SerializeField] GameObject levelsPanel,levelButtonPrefab,temp;
    [SerializeField] Button leftButton, rightButton;
    [SerializeField] string[] levels;

    
    private void Start()
    {
        for(int i = 0; i < levels.Length; i++)
        {
            temp=Instantiate(levelButtonPrefab);
            temp.transform.parent = levelsPanel.transform;
            temp.SetActive(true);
            temp.transform.GetChild(0).gameObject.GetComponent<Text>().text =(i+1).ToString();

        }
    }

    public void levelLoad(GameObject levelButton)
    {

        SceneManager.LoadScene("level"+levelButton.transform.GetChild(0).gameObject.GetComponent<Text>().text);
    }

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
