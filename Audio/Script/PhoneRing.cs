using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneRing : MonoBehaviour {

    [SerializeField]
    AudioSource RingingAudio;
    [SerializeField]
    AudioSource ClickAudio;
    [SerializeField]
    AudioSource RuisAudio;


    [SerializeField]
    private Light light1;
    [SerializeField]
    private Light light2;


    private bool Rings = false;
    private bool PhoneUp = false;
    private bool OnThePoint = false;

    private bool IsOn = false;
    private bool IsAlreadyDead = false;

    void Start()
    {
        RingingAudio.time = 0.3f;
        RingingAudio.SetScheduledEndTime(AudioSettings.dspTime + (14f - 0.3f));
        RuisAudio.time = 0.3f;
        RuisAudio.SetScheduledEndTime(AudioSettings.dspTime + (8.1f - 0.3f));
    }


    void Update()
    {
        //Als hij in de op n punt komt gaat hij ringen (zelf lekker codes bij doen XD)
        if (IsAlreadyDead == false && OnThePoint == true )
        {
            IsOn = true;
            Rings = true;
            StartCoroutine(PhoneRings());

            if (Rings == true)
            {
                PhoneUp = true;
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {

            if (Rings == true)
            {
                PhoneUp = true;
            }
    }


    IEnumerator PhoneRings()
    {

        if (IsOn == true)
        {


           while (Rings == true)
            {
                RingingAudio.Play();
                light1.enabled = true;
                yield return new WaitForSeconds(1.4f);
                light1.enabled = false;
                yield return new WaitForSeconds(1.4f);

            }



            if (PhoneUp == true)
            {
                Rings = false;
                RingingAudio.Stop();
                ClickAudio.Play();
                yield return new WaitForSeconds(0.4f);
                light2.enabled = true;
                RuisAudio.Play();
                yield return new WaitForSeconds(4);
                RuisAudio.Stop();
                yield return new WaitForSeconds(0.1f);
                light2.enabled = false;
                ClickAudio.Play();
            }




            IsOn = false;
            IsAlreadyDead = true;

        }
    }
}
