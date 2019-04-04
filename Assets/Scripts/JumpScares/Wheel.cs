using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public GameObject Wiel;
    public GameObject As;
    public GameObject Spaken;

    public AudioSource MachineSounds;
    
    public Light Spotlight1;
    public Light Spotlight2;
    public Light light1;
    public Light light2;

    private bool Playing = true;
    public bool ActivateMacines;

    void Start()
    {
        Spotlight1.enabled = false;
        Spotlight2.enabled = false;
        light1.enabled = false;
        light2.enabled = false;
    }
    
    void Update()
    {
        if (ActivateMacines)
        {
            if (Playing)
            {
                MachineSounds.Play();
                Playing = false;
            }

            Spotlight1.enabled = true;
            Spotlight2.enabled = true;
            light1.enabled = true;
            light2.enabled = true;

            Wiel.transform.Rotate(0, 1, 0);
            As.transform.Rotate(0, 1, 0);
            Spaken.transform.Rotate(0, 1, 0);
        }
    }
}
