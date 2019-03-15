using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    public GameObject Headset;

    void Update()
    {
        transform.rotation = Headset.transform.rotation;
    }
}
