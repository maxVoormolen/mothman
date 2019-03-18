using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorlockProperties : MonoBehaviour
{   
    [SerializeField]
    private string _doorLockID;// The ID of the doorlock. Used to compare Key ID's to unlock the door
    
    // Start is called before the first frame update


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Key")
        {
            CompareID(other.GetComponent<KeyProperties>().GetID());
        }
    }

    public bool CompareID(string otherID)
    {
        Debug.Log(_doorLockID == otherID);
        return _doorLockID == otherID;
    }
}
