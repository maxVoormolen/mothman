using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnLocker : MonoBehaviour
{
    public Collider m_Collider;
    public bool OpenDoor = false;

    private void Start()
    {
        m_Collider.enabled = false;
    }

    void Update()
    {
        if(OpenDoor)
        {
            m_Collider.enabled = true;
        }
    }
}
