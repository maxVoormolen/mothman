using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSounds : MonoBehaviour {

    [SerializeField]
    AudioSource GlassAudio;
    [SerializeField]
    AudioSource BarrelAudio;
    [SerializeField]
    AudioSource CardboardAudio;
    [SerializeField]
    AudioSource OtherAudio;

    void Start () {

        GlassAudio.time = 0.07f;
        GlassAudio.SetScheduledEndTime(AudioSettings.dspTime + (0.432f - 0.1f));

        OtherAudio.time = 0.12f;
        OtherAudio.SetScheduledEndTime(AudioSettings.dspTime + (0.576f - 0.12f));

        BarrelAudio.time = 0.14f;
        BarrelAudio.SetScheduledEndTime(AudioSettings.dspTime + (0.720f - 0.2f));

        CardboardAudio.time = 0.30f;
        CardboardAudio.SetScheduledEndTime(AudioSettings.dspTime + (0.720f - 0.3f));
    }
	

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Glass")
        {
            GlassAudio.Play();
        }
        if (gameObject.tag == "Cardboard")
        {
            CardboardAudio.Play();
        }
        if (gameObject.tag == "Barrel")
        {
            BarrelAudio.Play();
        }
        if (gameObject.tag == "Other")
        {
            OtherAudio.Play();
        }
    }
}
