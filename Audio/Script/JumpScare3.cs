using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare3 : MonoBehaviour {

    [SerializeField]
    AudioSource JumpScare3Audio;

    public Transform VRHeadset;

    private bool IsPlayed = false;

    private void Update()
    {
        if (VRHeadset.transform.position.x >= 0f && VRHeadset.transform.position.z <= 0f && IsPlayed == false)
        {
            JumpScare3Audio.Play();
            IsPlayed = true;
        }
    }
}
