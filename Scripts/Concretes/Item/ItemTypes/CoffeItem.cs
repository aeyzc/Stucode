using Stucode.Scripts.Abstracts.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stucode.Scripts.Concretes.Item
{
    public class CoffeItem : FoodItem
    {
        [SerializeField] GameObject drunkCoffeeObject;
        [SerializeField] bool isHot;
        [SerializeField] GameObject steamEffect;

        private void Start()
        {
            
            if (isHot) steamEffect.SetActive(true);
            
            else steamEffect.SetActive(false);
        }

        public override void InteractToItem()
        {
            AudioSource.PlayClipAtPoint(Audioclips.Instance.coffeeDrink, transform.position, PlayerPrefs.GetFloat("sfxvolume"));
            Instantiate(drunkCoffeeObject, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);

        }


    }
}