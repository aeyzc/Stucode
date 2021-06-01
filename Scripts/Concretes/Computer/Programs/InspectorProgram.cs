using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectorProgram : BaseProgram
{
    [SerializeField] Image ItemIconImage;
    [SerializeField] Text ItemNameText;
    [SerializeField] Sprite EmptyItemIcon;
    [SerializeField] GameObject propPanel;


    public override void CloseProgram()
    {
        this.gameObject.SetActive(false);
        OnClosed();
    }

    public override void OnClosed()
    {
        ClearPage();
        ComputerManager.Instance.activeProgram = ComputerManager.Instance.gameObject.GetComponent<BaseProgram>();
    }

    public override void OnOpened()
    {
        ComputerManager.Instance.activeProgram = this;
        if (InspectorItemSelector.Instance.activeItem == null)
        {
            ClearPage();
        }
        else
        {
            ItemIconImage.sprite = InspectorItemSelector.Instance.activeItem.ItemIcon;
            ItemNameText.text = InspectorItemSelector.Instance.activeItem.ItemName;
            InspectorItemSelector.Instance.activeItem.gameObject.GetComponent<BaseItemProp>().setProps();
        }

    }

    public void ClearPage()
    {
        if (InspectorItemSelector.Instance.activeItem != null)
        {
            InspectorItemSelector.Instance.activeItem.gameObject.GetComponent<BaseItemProp>().props.Clear();
        }

        foreach (Transform child in propPanel.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        ItemIconImage.sprite = EmptyItemIcon;
        ItemNameText.text = "None";
    }

    public override void OpenProgram()
    {
        OnOpened();
        this.gameObject.SetActive(true);
    }
}
