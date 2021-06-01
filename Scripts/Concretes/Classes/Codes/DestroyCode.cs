using Stucode.Scripts.Abstracts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCode : GoCode
{
    private static string codeSyntax = "destroy";

    public DestroyCode(string name, GameObject item)
    {
        this.codeType = "go";
        this.codeString = codeSyntax + "(" + name + ");";
        this.gobject = item;
    }

    public override void codeAction()
    {
        if(gobject.GetComponent<BaseItem>() != null && InspectorItemSelector.Instance.activeItem != null)
        {
            if (InspectorItemSelector.Instance.activeItem.ItemName == gobject.GetComponent<BaseItem>().ItemName) InspectorItemSelector.Instance.activeItem = null;
        }

        gobject.SetActive(false);
    }

}
