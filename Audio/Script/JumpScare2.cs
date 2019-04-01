using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare2 : MonoBehaviour {

    [SerializeField]
    AudioSource ScreechAudio;
    [SerializeField]
    AudioSource MothmanScreamAudio;
    [SerializeField]
    AudioSource MonsterSoundsAudio;
    [SerializeField]
    AudioSource CryingAudio;
    [SerializeField]
    AudioSource ViolinAudio;

    public Transform VRHeadset;

    private bool IsPlayed1 = false;
    private bool IsPlayed2 = false;
    private bool IsPlayed3 = false;
    private bool IsPlayed4 = false;
    private bool IsPlayed5 = false;

    private void Update()
    {
        if (VRHeadset.transform.position.x >= 0f && VRHeadset.transform.position.z <= 0f && IsPlayed1 == false)
        {
            ScreechAudio.Play();
            IsPlayed1 = true;
        }

        if (VRHeadset.transform.position.x >= 0f && VRHeadset.transform.position.z <= 0f && IsPlayed2 == false)
        {
            MothmanScreamAudio.Play();
            IsPlayed2 = true;
        }

        if (VRHeadset.transform.position.x >= 0f && VRHeadset.transform.position.z <= 0f && IsPlayed3 == false)
        {
            MonsterSoundsAudio.Play();
            IsPlayed3 = true;
        }

        if (VRHeadset.transform.position.x >= 0f && VRHeadset.transform.position.z <= 0f && IsPlayed4 == false)
        {
            CryingAudio.Play();
            IsPlayed4 = true;
        }

        if (VRHeadset.transform.position.x >= 0f && VRHeadset.transform.position.z <= 0f && IsPlayed5 == false)
        {
            ViolinAudio.Play();
            IsPlayed5 = true;
        }
    }
}
