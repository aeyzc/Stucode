using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class propSB: BaseProp
{
    public Scrollbar scrollBar;
    public Text headline, scrollBarText;

    public propSB(GameObject SB,GameObject propsLayout)
    {
        this.panel = MonoBehaviour.Instantiate(SB);
        this.panel.transform.SetParent(propsLayout.transform);
        this.headline = this.panel.transform.GetChild(0).GetComponent<Text>();
        this.scrollBar= this.panel.transform.GetChild(1).GetChild(0).GetComponent<Scrollbar>();
        this.scrollBarText= this.panel.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Text>();


    }
}
