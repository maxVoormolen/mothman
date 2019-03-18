
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class NumberInput : MonoBehaviour
{
    public int numberToInput;

    private EnterInputCode _inputField;

    // Start is called before the first frame update
    void Start()
    {
        _inputField = transform.parent.GetComponentInChildren<EnterInputCode>();
    }
    private void OnTriggerEnter(Collider other)//Adds a number to the inputlist according to numberToInput
    {
        _inputField.AddNumber(numberToInput);
        
    }

}
