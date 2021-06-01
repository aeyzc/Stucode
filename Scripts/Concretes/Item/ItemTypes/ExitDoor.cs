using Stucode.Scripts.Abstracts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : UseableItem
{
    BaseLevel level;
    private void Start()
    {
        level=GameObject.Find("LevelManager").GetComponent<BaseLevel>();
    }

    public override void InteractToItem()
    {
        level.PassNextLevel();
    }


}
