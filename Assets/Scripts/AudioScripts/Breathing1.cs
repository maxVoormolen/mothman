using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing1 : MonoBehaviour {

    [SerializeField]
    AudioSource BreathingAudio;

    public Transform VRHeadset;

    private bool IsPlayed = false;

    private void Update()
    {
        if (VRHeadset.transform.position.x >= 10f && VRHeadset.transform.position.z <= -7f && IsPlayed == false)
        {
            BreathingAudio.Play();          
            IsPlayed = true;
        }
    }
}
