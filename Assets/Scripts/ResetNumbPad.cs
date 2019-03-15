using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetNumbPad : MonoBehaviour
{

    private EnterInputCode codeToReset;
    // Start is called before the first frame update
    void Start()
    {
        codeToReset = transform.parent.GetComponentInChildren<EnterInputCode>();
    }


    private void OnMouseDown()//cals the reset Method
    {
        ResetCode();
    }
    private void ResetCode()// set the entire list to 0;
    {
        for(int i = 0; i < codeToReset.getList().Length; i++)
        {
            codeToReset.getList()[i] = 0;
            
        }

    }
}
