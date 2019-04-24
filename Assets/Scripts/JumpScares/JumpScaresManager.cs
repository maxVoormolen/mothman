﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class JumpScaresManager : MonoBehaviour
{
    [SerializeField]
    private KitchenManager kitchenManager;
    [SerializeField]
    private ClowstickManager clowstickManager;
    [SerializeField]
    private Wheel wheel;
    
    [SerializeField]
    AudioSource GlowStickCrackAudio;
    [SerializeField]
    AudioSource FirstScareAudio;
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
    [SerializeField]
    AudioSource ScreamAudio;
    [SerializeField]
    AudioSource BreathingAudio;
    [SerializeField]
    AudioSource JumpScare3Audio;

    [SerializeField]
    private Rigidbody DoorKeuken;
    [SerializeField]
    private Transform VRHeadset;

    [SerializeField]
    private Light[] MothmanEyesList = new Light[4];

    private bool[] PlayBools = new bool[8];

    private float m_FadeTime = 0.8f;
    public bool isPickedUp = false;

    private void Start()
    {
        //Deactivate physics of kitchen door.
        DoorKeuken.detectCollisions = false;
        DoorKeuken.isKinematic = true;

        //Set the eyes of mothman on false.
        for (int i = 0; i <= MothmanEyesList.Length; i++)
        {
            MothmanEyesList[i].enabled = false;
        }
        //Set all Booleans false.
        for (int i = 0; i <= PlayBools.Length; i++)
        {
            PlayBools[i] = false;
        }

    }

    private void Update()
    {
        //Check of location of Player is near a JumpScare
        if (isPickedUp && !PlayBools[0])
        {
            PlayBools[0] = true;
            StartCoroutine(KitchenJumpScare());
        }
        else if (VRHeadset.transform.position.x <= 5.5f && VRHeadset.transform.position.z >= -6f && VRHeadset.transform.position.z <= -5f && !PlayBools[1])
        {
            PlayBools[1] = true;
            StartCoroutine(ScreechJumpScare());
        }
        else if (VRHeadset.transform.position.x <= 12f && VRHeadset.transform.position.x >= 10f && VRHeadset.transform.position.z <= 1f && !PlayBools[2])
        {
            PlayBools[2] = true;
            StartCoroutine(MonsterJumpScare());
        }
        else if (VRHeadset.transform.position.x >= -13f && VRHeadset.transform.position.x <= -10f && VRHeadset.transform.position.z >= 1f && !PlayBools[3])
        {
            PlayBools[3] = true;
            StartCoroutine(CryingJumpScare());
        }
        else if (VRHeadset.transform.position.x >= -7f && VRHeadset.transform.position.x <= -3f && VRHeadset.transform.position.z >= 3f && !PlayBools[4])
        {
            PlayBools[4] = true;
            StartCoroutine(ViolinJumpScare());
        }
        else if (VRHeadset.transform.position.x >= 3f && !PlayBools[5])
        {
            PlayBools[5] = true;
            StartCoroutine(ScreamJumpScare());
        }
        else if (VRHeadset.transform.position.x >= 10f && VRHeadset.transform.position.z <= -7f && !PlayBools[6])
        {
            PlayBools[6] = true;
            BreathingAudio.Play();
        }
        else if (VRHeadset.transform.position.x <= 13f && VRHeadset.transform.position.x >= 10f && VRHeadset.transform.position.z <= -13f && !PlayBools[7])
        {
            PlayBools[7] = true;
            SteamVR_Fade.Start(Color.black, m_FadeTime, true);
            JumpScare3Audio.Play();
            clowstickManager.DeadLight();
            for (int i = 0; i <= 1; i++)
            {
                MothmanEyesList[i].enabled = true;
            }
        }
    }

    //All the jump scares.
    IEnumerator KitchenJumpScare()
    {
        GlowStickCrackAudio.Play();
        yield return new WaitForSeconds(0.3f);
        clowstickManager.GreenLight();
        yield return new WaitForSeconds(1.0f);
        FirstScareAudio.Play();
        yield return new WaitForSeconds(7.5f);
        kitchenManager.DeadLight();
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.GreenLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.GreenLight();
        yield return new WaitForSeconds(0.3f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(3.3f);
        kitchenManager.RedLight();
        clowstickManager.RedLight();
        DoorKeuken.detectCollisions = true;
        DoorKeuken.isKinematic = false;
        DoorKeuken.AddForce(transform.forward * 250000);
        yield return new WaitForSeconds(4.0f);
        kitchenManager.DeadLight();
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(2.6f);
        kitchenManager.YellowLight();
        clowstickManager.GreenLight();
        yield return new WaitForSeconds(0.4f);
        kitchenManager.DeadLight();
        yield return new WaitForSeconds(0.8f);
        kitchenManager.YellowLight();
    }

    IEnumerator ScreechJumpScare()
    {
        ScreechAudio.Play();
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(6.2f);
        clowstickManager.GreenLight();
    }

    IEnumerator MonsterJumpScare()
    {
        MonsterSoundsAudio.Play();
        yield return new WaitForSeconds(1.8f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(2.9f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(3.4f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(5.3f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(3.2f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(2.8f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(3.5f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(2.8f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(4.3f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(2.8f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(4.7f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(3.9f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(3.6f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(4.0f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(3.8f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(6.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(9.3f);
        clowstickManager.GreenLight();
        yield return new WaitForSeconds(3.5f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(6.4f);
        clowstickManager.GreenLight();
        yield return new WaitForSeconds(1.5f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(2.4f);
        clowstickManager.GreenLight();
        yield return new WaitForSeconds(0.5f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(1.4f);
        clowstickManager.GreenLight();
    }

    IEnumerator CryingJumpScare()
    {
        CryingAudio.Play();
        yield return new WaitForSeconds(1.1f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(1.7f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(2.3f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(3.6f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.6f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(3.1f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.9f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(3.2f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.9f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(3.2f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(1.5f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(3.2f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(5.2f);
        clowstickManager.GreenLight();
    }

    IEnumerator ViolinJumpScare()
    {
        ViolinAudio.Play();
        wheel.ActivateMacines = true;
        yield return new WaitForSeconds(0.5f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(1.5f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.6f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(1.5f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.6f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(1.5f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.6f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(1.4f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(7.6f);
        clowstickManager.GreenLight();
    }

    IEnumerator ScreamJumpScare()
    {
        ScreamAudio.Play();
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(1.1f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.3f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.3f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.3f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.3f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.RedLight();
        yield return new WaitForSeconds(0.2f);
        clowstickManager.DeadLight();
        yield return new WaitForSeconds(2.6f);
        clowstickManager.GreenLight();
    }
}
