using Stucode.Scripts.Abstracts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stucode.Scripts.Concretes.Item 
{ 
    public class ComputerItem : UseableItem
    {
        [SerializeField] DesktopProgram desktopProgram;

      

        public override void InteractToItem()
        {
            CursorManager.Instance.pausedGameCursor();
            GameManager.Instance.isComputerActive = true;
            GameManager.Instance.isGameActive = false;
            desktopProgram.OpenProgram();
        }
    }
}
