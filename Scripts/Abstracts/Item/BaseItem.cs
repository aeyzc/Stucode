using Stucode.Scripts.Concretes.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stucode.Scripts.Abstracts.Item 
{
    public abstract class BaseItem : MonoBehaviour
    {
        public string ItemName;
        public Sprite ItemIcon;
        public InteractionTypeEnum InteractionType;
        public KeyTypeEnum KeyType;
        public KeyEnum InteractionKey;

        public abstract void InteractToItem();


    }

}