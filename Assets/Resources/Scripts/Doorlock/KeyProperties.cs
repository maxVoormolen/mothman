using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyProperties : MonoBehaviour
{   
    [SerializeField]
    private string _keyID;
   



    public string GetID()
    {
        return _keyID;
    }
}
