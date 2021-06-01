using Stucode.Scripts.Abstracts.Item;
using Stucode.Scripts.Concretes.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EyeRaycast : MonoBehaviour
{
    RaycastHit item;
    BaseItem _item;
    float viewRange = 3f;
    public Text crosshairText;
    Image crosshairImage;
    Color greenCrosshairColor = new Color(0, 1, 0.2050042f, 1);
    Color defaultCrosshairColor= new Color(0, 0, 0, 0.5f);

    void Start()
    {
        crosshairImage = GameObject.Find("Cross").GetComponent<Image>();
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out item, viewRange) && !PlayerController.Instance.isCarrying && GameManager.Instance.isGameActive)
        {
            _item=item.collider.gameObject.GetComponent<BaseItem>();

            if (_item != null)
            {
                SetCrosshairGreen();


                if (_item.InteractionKey == KeyEnum.E)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        _item.InteractToItem();

                    }
                }

                else
                {
                    if (Input.GetKey(KeyCode.F))
                    {
                        _item.InteractToItem();

                    }
                }


            }

            else
            {
                SetCrosshairDefault();
            }

        }

        else
        {
            SetCrosshairDefault();
        }

    }

    void SetCrosshairGreen()
    {
        crosshairImage.color = greenCrosshairColor;
        crosshairText.text = _item.ItemName + "\n" +_item.KeyType +" ["+_item.InteractionKey+"] to " + _item.InteractionType;
    }

    void SetCrosshairDefault()
    {
        crosshairImage.color = defaultCrosshairColor;
        crosshairText.text = "";
    } 


}
