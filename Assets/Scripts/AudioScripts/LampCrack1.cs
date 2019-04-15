using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LampCrack1 : MonoBehaviour {

    [SerializeField]
    AudioSource ClickAudio;
    [SerializeField]
    AudioSource LampAudio;
    [SerializeField]
    AudioSource BulbBreakAudio;

    [SerializeField]
    private Light light1;
    [SerializeField]
    private Light light2;

    private bool IsOn = false;
    private bool IsAlreadyDead = false;

    public SteamVR_Action_Boolean m_GrabAction = null;
    private SteamVR_Behaviour_Pose m_Pose = null;
	
	void Update () {
        if (m_GrabAction.GetStateDown(m_Pose.inputSource) && !IsAlreadyDead)
        {
            IsOn = true;
            StartCoroutine(LampAudioDead());
        }
        if (Input.GetKeyDown("a") && !IsAlreadyDead)
        {
            IsOn = true;
            StartCoroutine(LampAudioDead());
        }
	}

    IEnumerator LampAudioDead()
    {
        if (IsOn == true)
        {
            ClickAudio.Play();
            LampAudio.Play();
            yield return new WaitForSeconds(0.3f);
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(4);
            LampAudio.Stop();
            BulbBreakAudio.Play();
            yield return new WaitForSeconds(0.4f);
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.1f);
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.05f);
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.05f);
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.2f);
            light1.enabled = false;
            light2.enabled = false;
            
            IsOn = false;
            IsAlreadyDead = true;
        }
    }
}
