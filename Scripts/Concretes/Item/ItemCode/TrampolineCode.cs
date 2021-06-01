using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineCode : BaseItemCode
{
    [Range(0, 4)]
    public int trampolinePower = 2;
    int multiplePower = 25000;


    public override void falseAction()
    {
    }

    public override void minusAction()
    {
        if (trampolinePower != 0) trampolinePower--;
    }

    public override void plusAction()
    {
        if(trampolinePower!=4) trampolinePower++;
    }

    public override void trueAction()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        {
            if (trampolinePower != 0)
            {
                AudioSource.PlayClipAtPoint(Audioclips.Instance.trampoline, transform.position, PlayerPrefs.GetFloat("sfxvolume")*PlayerPrefs.GetFloat("soundvolume"));

            }
            collision.gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.parent.up * trampolinePower* multiplePower);
        }
    }
}
