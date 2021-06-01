using Stucode.Scripts.Concretes.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isCarrying,isOnFloor,isHandCollision,isWalking;
    public MovableItem carryingItem;
    public static PlayerController Instance;

    private void Awake()
    {
        Instance = this;
    }



}
