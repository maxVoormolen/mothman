using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing1 : MonoBehaviour {

    [SerializeField]
    AudioSource BreathingAudio;


    public GameObject VRHeadset;

    private bool IsPlayed = false;

    Vector3 Corner1;
    Vector3 Corner2;

    void Start()
    {
        Corner1 = new Vector3(0, 0, 0);
        Corner2 = new Vector3(0, 0, 0);

    }


    void Update()
    {



        if (VRHeadset.transform.position.magnitude <= Corner1.magnitude && VRHeadset.transform.position.magnitude <= Corner2.magnitude && IsPlayed == false)
        {
            BreathingAudio.Play();          
            IsPlayed = true;

        }

    }
}
