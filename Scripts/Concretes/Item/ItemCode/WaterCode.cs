using Stucode.Scripts.Abstracts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCode : BaseItemCode
{
    bool isFrozen = false;
    [SerializeField] GameObject water, ice;
    float exitScaleStack = 0;


    private void OnTriggerEnter(Collider other)
    {
        BaseItem tempItem = other.gameObject.GetComponent<BaseItem>();
        if (tempItem != null && !isFrozen)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, gameObject.transform.position +
                new Vector3(0,10* tempItem.gameObject.transform.localScale.y, 0),Time.deltaTime*2);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        BaseItem tempItem = other.gameObject.GetComponent<BaseItem>();
        if (tempItem != null && !isFrozen)
        {
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, gameObject.transform.position -
                new Vector3(0,10* tempItem.gameObject.transform.localScale.y, 0), Time.deltaTime*2);
        }

        else if(tempItem != null && isFrozen)
        {
            exitScaleStack += 10 * tempItem.gameObject.transform.localScale.y;
        }
    }



    public override void falseAction()
    {
    }

    public override void minusAction()
    {
        isFrozen = true;
        water.SetActive(false);
        ice.SetActive(true);
    }

    public override void plusAction()
    {
        isFrozen = false;
        water.SetActive(true);
        ice.SetActive(false);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, gameObject.transform.position -
    new Vector3(0,exitScaleStack, 0), Time.deltaTime * 2);
        exitScaleStack = 0;
    }

    public override void trueAction()
    {
    }
}
