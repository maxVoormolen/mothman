using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare1 : MonoBehaviour {

    public GlowStickCrack js1;

    [SerializeField]
    private Light light1;
    [SerializeField]
    private Light light2;

    [SerializeField]
    private Light Roomlight1;
    [SerializeField]
    private Light Roomlight2;

    private bool stop = false;

    void Start () {
		
	}
	
	
	void Update () {
        if (js1.SSH == true && stop == false)
        {
            StartCoroutine(EnableLights());
        }
	}

    IEnumerator EnableLights()
    {
        stop = true;
        Roomlight1.enabled = false;
        Roomlight2.enabled = false;
        light1.enabled = false;
        light2.enabled = false;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = false;
        light2.enabled = false;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        yield return new WaitForSeconds(0.3f);
        light1.enabled = false;
        light2.enabled = false;
        yield return new WaitForSeconds(3.3f);
        light1.color = Color.red;
        light2.color = Color.red;
        Roomlight1.color = Color.red;
        Roomlight2.color = Color.red;
        light1.enabled = true;
        light2.enabled = true;
        Roomlight1.enabled = true;
        Roomlight2.enabled = true;
        yield return new WaitForSeconds(4.0f);
        light1.enabled = false;
        light2.enabled = false;
        Roomlight1.enabled = false;
        Roomlight2.enabled = false;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = false;
        light2.enabled = false;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        yield return new WaitForSeconds(0.2f);
        light1.enabled = false;
        light2.enabled = false;
        yield return new WaitForSeconds(2.6f);
        light1.color = Color.green;
        light2.color = Color.green;
        light1.enabled = true;
        light2.enabled = true;
        yield return new WaitForSeconds(3.0f);
        Roomlight1.color = Color.yellow;
        Roomlight2.color = Color.yellow;
        Roomlight1.enabled = true;
        Roomlight2.enabled = true;



    }
}
