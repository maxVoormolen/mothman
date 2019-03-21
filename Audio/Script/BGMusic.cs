using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
   [SerializeField]
    AudioSource audioSource;
    


    void Start()
    {
        audioSource.time = 2.7f;
        audioSource.SetScheduledEndTime(AudioSettings.dspTime + (198.519f - 2.7f));
        audioSource.Play();
       
    }

    void Update()
    {
        if (audioSource.time == 195.0f ) {
            audioSource.time = 2.7f;
            audioSource.SetScheduledEndTime(AudioSettings.dspTime + (198.519f - 2.7f));
            audioSource.Play();
        }
    }



}
