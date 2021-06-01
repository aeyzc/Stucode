using Stucode.Scripts.Concretes.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallProp : ItemProp
{
    propDD BallTypeProp;
    int selectedTypeIndex = 0;
    [SerializeField] Material pool, beach;
    [SerializeField] PhysicMaterial beachPM;
    [SerializeField] Sprite poolIcon, beachIcon;


    List<string> types = new List<string> { "Pool", "Beach"};

    public override void setProps()
    {


        BallTypeProp = new propDD(Drop, propLayout);
        props.Add(BallTypeProp);
        BallTypeProp.headline.text = "Ball Type";
        BallTypeProp.dropdown.AddOptions(types);
        BallTypeProp.dropdown.value = selectedTypeIndex;
        BallTypeProp.dropdown.onValueChanged.AddListener(delegate { updateType(); });



        base.setProps();
    }

    private void updateType()
    {
        if (BallTypeProp.dropdown.value == 0)
        {
            setPoolBall();
        }

        else if (BallTypeProp.dropdown.value == 1)
        {
            setBeachBall();
        }
    }
    public override void resetProps()
    {
        setPoolBall();
        base.resetProps();
    }


    void setPoolBall()
    {
        
        //gameObject.GetComponent<MovableItem>().ItemIcon = poolIcon;
        gameObject.GetComponent<Collider>().material = null;
        gameObject.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material = pool;
        selectedTypeIndex = 0;
    }

    void setBeachBall()
    {
        //gameObject.GetComponent<MovableItem>().ItemIcon = beachIcon;
        gameObject.GetComponent<Collider>().material = beachPM;
        selectedTypeIndex = 1;
        gameObject.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().material = beach;

    }



}
