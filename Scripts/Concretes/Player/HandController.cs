using Stucode.Scripts.Abstracts.Item;
using Stucode.Scripts.Concretes.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    RaycastHit item;
    private void FixedUpdate()
    {

        if (PlayerController.Instance.isCarrying && PlayerController.Instance.carryingItem != null)
        {


            if (Physics.Raycast(transform.position, transform.forward, out item, PlayerController.Instance.carryingItem.objectDistance+PlayerController.Instance.carryingItem.transform.localScale.x/2))
            {
                PlayerController.Instance.isHandCollision = true;
            }



            else PlayerController.Instance.isHandCollision = false;

        }


    
    }
  


}
