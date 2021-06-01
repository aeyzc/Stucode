using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBoolItemCode : BaseItemCode
{
    public override void falseAction()
    {
        gameObject.SetActive(false);
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
        gameObject.SetActive(true);

    }


}
