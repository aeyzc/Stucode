using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class propDD : BaseProp
{
    public Dropdown dropdown;
    public Text headline;

    public propDD(GameObject DD, GameObject propsLayout)
    {
        this.panel = MonoBehaviour.Instantiate(DD);
        this.panel.transform.SetParent(propsLayout.transform);
        this.headline = this.panel.transform.GetChild(0).GetComponent<Text>();
        this.dropdown = this.panel.transform.GetChild(1).GetChild(0).GetComponent<Dropdown>();


    }
}
