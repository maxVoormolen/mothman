using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingLightNormal : MonoBehaviour {

    [SerializeField]
    AudioSource ClickAudio;
    [SerializeField]
    AudioSource LampAudio;

    [SerializeField]
    private Light light1;
    [SerializeField]
    private Light light2;

    private bool IsOn = false;

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKeyDown("w") && IsOn == false)
        {
            IsOn = true;
            ClickAudio.Play();
            LampAudio.Play();
            StartCoroutine(LampTrigger());
        }

    }


    IEnumerator LampTrigger()
    {

        if (IsOn == true)
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(0.0f, 0.5f));
                light1.enabled = true;
                light2.enabled = true;
                yield return new WaitForSeconds(Random.Range(0.1f, 5.2f));
                light1.enabled = false;
                light2.enabled = false;
            }

        }
    }
}
