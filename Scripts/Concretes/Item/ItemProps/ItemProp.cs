using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemProp : BaseItemProp
{


    public override void setProps()
    {
        sizeProp = new propSB(SB, propLayout);
        props.Add(sizeProp);
        sizeProp.headline.text = "Size";
        sizeProp.scrollBar.value = scaleMultiple - 1;
        sizeProp.scrollBarText.text = (sizeProp.scrollBar.value + 1f).ToString("#.00");
        sizeProp.scrollBar.onValueChanged.AddListener(delegate { updateSize(); });

        gravityT = new propT(Toggle, propLayout);
        props.Add(gravityT);
        gravityT.toggle.isOn = gameObject.GetComponent<Rigidbody>().useGravity;
        gravityT.toggle.onValueChanged.AddListener(delegate { updateGravity(); });
        gravityT.headline.text = "Gravity";

        for (int i = 0; i < props.Count; i++)
        {
            if (i % 2 == 0)
            {
                props[i].panel.GetComponent<Image>().color = new Color(0, 0, 0, 0.1f);
            }
        }
    }



    public override void updateGravity()
    {
        if (gravityT.toggle.isOn)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().angularDrag = 0.05f;
        }

        else
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().angularDrag = 0f;

        }
    }

    public override void updateSize()
    {
        sizeProp.scrollBarText.text = ((sizeProp.scrollBar.value + 1f)).ToString("#.00");
        scaleMultiple = sizeProp.scrollBar.value + 1f;
        transform.localScale = new Vector3(size * scaleMultiple, size * scaleMultiple, size * scaleMultiple);
    }

    public override void resetProps()
    {
        scaleMultiple = 1;
        transform.localScale = new Vector3(size , size , size);
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity=Vector3.zero;

    }

}
