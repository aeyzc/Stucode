using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class propT : BaseProp
{
    public Toggle toggle;
    public Text headline;

    public propT(GameObject T, GameObject propsLayout)
    {
        this.panel = MonoBehaviour.Instantiate(T);
        this.panel.transform.SetParent(propsLayout.transform);
        this.headline = this.panel.transform.GetChild(0).GetComponent<Text>();
        this.toggle = this.panel.transform.GetChild(1).GetChild(0).GetComponent<Toggle>();


    }
}
