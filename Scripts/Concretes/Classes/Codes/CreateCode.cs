using Stucode.Scripts.Abstracts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCode : GoCode
{
    private static string codeSyntax="create";
    public Transform ItemSpawnPoint;

    public CreateCode(string name,GameObject item,Transform spawnPoint)
    {
        this.codeType = "go";
        this.codeString = codeSyntax+"(" + name + ");";
        this.gobject = item;
        this.ItemSpawnPoint = spawnPoint;
    }

    public CreateCode(string name,GameObject item)
    {
        this.codeType = "go";
        this.codeString = codeSyntax + "(" + name + ");";
        this.gobject = item;
        this.ItemSpawnPoint = item.transform;
    }

    public override void codeAction()
    {
        if (gobject.GetComponent<BaseItem>() != null && InspectorItemSelector.Instance.activeItem!=null)
        {
            if (InspectorItemSelector.Instance.activeItem.ItemName == gobject.GetComponent<BaseItem>().ItemName) InspectorItemSelector.Instance.activeItem = null;
        }

        gobject.transform.position = ItemSpawnPoint.position;

        ItemProp propControl = gobject.GetComponent<ItemProp>();
        if (propControl!=null) propControl.resetProps();

        gobject.SetActive(true);
    }

}
