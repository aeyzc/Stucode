using Stucode.Scripts.Concretes.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorItemSelector : MonoBehaviour
{
    public MovableItem activeItem;
    MovableItem _item;
    [SerializeField] Screen screen;
    public static InspectorItemSelector Instance;
    public GameObject SB, Drop, Toggle,propLayout;

    private void Awake()
    {
        Instance = this;
    }


    private void OnTriggerEnter(Collider other)
    {
        _item = other.GetComponent<MovableItem>();
        if(_item!=null && activeItem == null)
        {
            activeItem = _item;
            screen.UpdateScreen();
        }

    }

    private void OnTriggerStay(Collider other)
    {
        _item = other.GetComponent<MovableItem>();
        if (_item != null && activeItem == null)
        {
            activeItem = _item;
            screen.UpdateScreen();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        _item = other.GetComponent<MovableItem>();
        if (_item != null && activeItem != null)
        {
            activeItem = null;
            screen.UpdateScreen();

        }
    }

}
