using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpControler : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "plane")
        {
            PlayerController.Instance.isOnFloor = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "plane")
        {
            PlayerController.Instance.isOnFloor = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "plane")
        {
            PlayerController.Instance.isOnFloor = false;
        }
    }

}
