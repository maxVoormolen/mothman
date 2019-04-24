using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class CodeChecker : MonoBehaviour
{
    public int[] CodeList = new int[4];// The correct Code for the numbPad.
    private bool _isValid;//Unlocks attached door.
    private EnterInputCode _enterCode;

    private DoorUnLocker DUL;

    private void Start()
    {
        _enterCode = gameObject.GetComponentInChildren<EnterInputCode>();
        _enterCode.unlockDoors += CompareInputCode;
    }

    public void CompareInputCode(int[] InputList)//Compares input with the correct code and sets _isValid to the return value of the SeqenceEqual.
    {
        bool isValid = CodeList.SequenceEqual(InputList);
        Debug.Log(isValid);
    }

    private void Update()
    {
        if(_isValid)
        {
            DUL.OpenDoor = true;
        }
    }
}
