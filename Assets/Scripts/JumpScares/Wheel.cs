using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField]
    private GameObject[] WholeWheel = new GameObject[3];

    [SerializeField]
    private Light[] Spotlights = new Light[4];

    [SerializeField]
    private AudioSource MachineSounds;

    private bool Playing = true;
    public bool ActivateMacines;

    void Start()
    {
        //Set the spotlight on false.
        for (int i = 0; i <= Spotlights.Length; i++)
        {
            Spotlights[i].enabled = false;
        }
    }

    public bool MyBool
    {
        get { return ActivateMacines; }
        set
        {
            if (value == ActivateMacines)
                return;

            ActivateMacines = value;
            if (ActivateMacines)
            {
                MachineSounds.Play();

                for (int i = 0; i <= Spotlights.Length; i++)
                {
                    Spotlights[i].enabled = true;
                }

                while (Playing)
                {
                    for (int i = 0; i <= WholeWheel.Length; i++)
                    {
                        WholeWheel[i].transform.Rotate(0, 1, 0);
                    }
                }
            }
        }
    }
}
