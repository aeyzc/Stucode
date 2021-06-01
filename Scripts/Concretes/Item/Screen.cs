using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    [SerializeField] SpriteRenderer screen;
    [SerializeField] Sprite nullItem;

    public void UpdateScreen()
    {
        if(InspectorItemSelector.Instance.activeItem!=null) screen.sprite = InspectorItemSelector.Instance.activeItem.ItemIcon;
        
        else screen.sprite = nullItem;
    }

}
