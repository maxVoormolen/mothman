using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ResetNumbPad : MonoBehaviour
{

    private EnterInputCode codeToReset;
    // Start is called before the first frame update
    void Start()
    {
        codeToReset = transform.parent.GetComponentInChildren<EnterInputCode>();
        
    }


    public void AddNumber()//cals the reset Method
    {
        ResetCode(codeToReset.GetList());
    }
    private void ResetCode(int[] list)// set the entire list to 0;
    {
        for(int i = 0; i < list.Length; i++)
        {
            list[i] = 0;
            
        }

    }
}
