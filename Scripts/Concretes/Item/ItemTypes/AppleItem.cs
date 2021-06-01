using Stucode.Scripts.Abstracts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stucode.Scripts.Concretes.Item { 
    public class AppleItem : FoodItem
    {
        [SerializeField] GameObject bittenAppleObject;
        


        public override void InteractToItem()
        {
            AudioSource.PlayClipAtPoint(Audioclips.Instance.appleBite, transform.position, PlayerPrefs.GetFloat("sfxvolume"));
            Instantiate(bittenAppleObject,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
            
        }

    
    }
}