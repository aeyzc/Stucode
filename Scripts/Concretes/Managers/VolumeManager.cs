using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour
{
    AudioSource ses;

    // Start is called before the first frame update
    void Start()
    {
        ses=gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ses.volume = PlayerPrefs.GetFloat("musicvolume")*PlayerPrefs.GetFloat("soundvolume");
    }
}
