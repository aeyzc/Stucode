using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioclips : MonoBehaviour
{
    public static Audioclips Instance;
    public AudioClip code,appleBite,coffeeDrink,levelUp,trampoline,jump;


    private void Awake()
    {
        Instance = this;
    }

}
