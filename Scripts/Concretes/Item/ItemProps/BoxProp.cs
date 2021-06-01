using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxProp : ItemProp
{

    propDD colorProp;



    List<string> colors = new List<string> { "white", "yellow","red", "black" };

    public override void setProps()
    {
        

        colorProp = new propDD(Drop, propLayout);
        props.Add(colorProp);
        colorProp.headline.text = "Color";
        colorProp.dropdown.AddOptions(colors);
        colorProp.dropdown.onValueChanged.AddListener(delegate { updateColor(); });



        base.setProps();
    }

    private void updateColor()
    {
        
    }
}
