using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

/// <summary>
/// Control Ìnformation Trackpad!
/// 
/// Left Controller Trackpad (2)	Axis2D.PrimaryThumbstick	Left Controller Trackpad	Horizontal Movement	    1	–1.0 to 1.0
/// Left Controller Trackpad(2)     Axis2D.PrimaryThumbstick Left Controller Trackpad       Vertical Movement       2	–1.0 to 1.0
/// Right Controller Trackpad(2)    Axis2D.SecondaryThumbstick Right Controller Trackpad    Horizontal Movement     4	–1.0 to 1.0
/// Right Controller Trackpad(2)    Axis2D.SecondaryThumbstick Right Controller Trackpad    Vertical Movement       5	–1.0 to 1.0
/// </summary>

public class InputManager : MonoBehaviour
{
    public SteamVR_Action_Vector2 TouchPad;
    public Transform CurrentTransform;


    private void Update()
    {
        Vector2 touchpadValue = TouchPad.GetAxis(SteamVR_Input_Sources.Any);

        //X van Trackpad
        if (touchpadValue.x <= -0.4f)
        {
            CurrentTransform.transform.position = CurrentTransform.transform.position + new Vector3(0.0f, 0.0f, 0.01f);
        }
        else if (touchpadValue.x >= 0.4f)
        {
            CurrentTransform.transform.position = CurrentTransform.transform.position + new Vector3(0.0f, 0.0f, -0.01f);
        }
        else { }

        //Y van Trackpad
        if (touchpadValue.y <= -0.4f)
        {
            CurrentTransform.transform.position = CurrentTransform.transform.position + new Vector3(-0.01f, 0.0f, 0.0f);
        }
        else if (touchpadValue.y >= 0.4f)
        {
            CurrentTransform.transform.position = CurrentTransform.transform.position + new Vector3(0.01f, 0.0f, 0.0f);
        }
        else { }
    }
}
