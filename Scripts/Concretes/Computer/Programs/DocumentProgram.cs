using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocumentProgram : BaseProgram
{
    [SerializeField] Text docText, docHeadText;
    [SerializeField] DocumentCategoryButton[] categoryButtons;

    public override void CloseProgram()
    {
        this.gameObject.SetActive(false);
        OnClosed();
    }

    public void selectDocButton(DocumentCategoryButton button)
    {
        docHeadText.text = button.headline;
        docText.text = button.context;
        foreach(DocumentCategoryButton i in categoryButtons)
        {
            if (i == button)
            {
                i.gameObject.GetComponent<Text>().color = new Color(0, 1, 0, 1);
            }
            else
            {
                i.gameObject.GetComponent<Text>().color = new Color(1, 1, 1, 1);
            }
        }
    }

    public override void OnClosed()
    {
        ComputerManager.Instance.activeProgram = ComputerManager.Instance.gameObject.GetComponent<BaseProgram>();
    }

    public override void OnOpened()
    {
        selectDocButton(categoryButtons[0]);
        ComputerManager.Instance.activeProgram = this;

    }

    public override void OpenProgram()
    {
        OnOpened();
        this.gameObject.SetActive(true);
    }
}
