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


    private void Update()
    {
        
            if (isWalking && isOnFloor && GameManager.Instance.isGameActive)
            {
                gameObject.GetComponent<AudioSource>().volume = 0.5f * PlayerPrefs.GetFloat("sfxvolume")* PlayerPrefs.GetFloat("soundvolume");

            }

            else
            {
                gameObject.GetComponent<AudioSource>().volume = 0;

            }
    }

}
