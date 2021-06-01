using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCode : BaseItemCode
{

    public GameObject door1, door2;

    public override void falseAction()
    {
        door1.GetComponent<Collider>().isTrigger = true;
        door2.GetComponent<Collider>().isTrigger = true;
        door1.transform.GetChild(0).gameObject.SetActive(false);
        door2.transform.GetChild(0).gameObject.SetActive(false);

    }

    public override void minusAction()
    {
        throw new System.NotImplementedException();
    }

    public override void plusAction()
    {
        throw new System.NotImplementedException();
    }

    public override void trueAction()
    {
        door1.GetComponent<Collider>().isTrigger = false;
        door2.GetComponent<Collider>().isTrigger = false;
        door1.transform.GetChild(0).gameObject.SetActive(true);
        door2.transform.GetChild(0).gameObject.SetActive(true);
    }


}
