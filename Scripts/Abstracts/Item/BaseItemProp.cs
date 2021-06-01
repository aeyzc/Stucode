using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseItemProp : MonoBehaviour
{
    public propSB sizeProp;
    public propT gravityT;

    public float size, scaleMultiple=1;
    public GameObject propLayout;
    public GameObject SB,Drop,Toggle;
    public List<BaseProp> props = new List<BaseProp> { };

    private void Start()
    {
        SB = InspectorItemSelector.Instance.SB;
        Drop = InspectorItemSelector.Instance.Drop;
        Toggle = InspectorItemSelector.Instance.Toggle;
        propLayout = InspectorItemSelector.Instance.propLayout;
    }


    public abstract void setProps();
    public abstract void updateSize();
    public abstract void updateGravity();

    public abstract void resetProps();

}
