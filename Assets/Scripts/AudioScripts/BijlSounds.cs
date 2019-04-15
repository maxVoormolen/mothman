using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BijlSounds : MonoBehaviour {

    [SerializeField]
    AudioSource BijlAudio;
    [SerializeField]
    AudioSource ScaryAudio;

    private bool ScaryAudioDead = false;
    private bool HitsDoor = false;
	
	void Update ()
    {
        if (Input.GetKeyDown("u") && !ScaryAudioDead)
        {
            ScaryAudio.Play();
            ScaryAudioDead = true;
        }

        if (HitsDoor == true)
        {
            BijlAudio.Play();
        }
    }
}
