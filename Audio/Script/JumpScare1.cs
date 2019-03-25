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

    void RedLight()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material mat = renderer.material;
        float emission = Mathf.PingPong(Time.time, 0.9f);
        Color baseColor = Color.red;
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
        mat.SetColor("_EmissionColor", finalColor);
    }

    void GreenLight()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material mat = renderer.material;
        float emission = Mathf.PingPong(Time.time, 0.2f);
        Color baseColor = Color.green;
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
        mat.SetColor("_EmissionColor", finalColor);
    }

    void DeadLight()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material mat = renderer.material;
        float emission = Mathf.PingPong(Time.time, 0.1f);
        Color baseColor = Color.gray;
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
        mat.SetColor("_EmissionColor", finalColor);
    }

    IEnumerator EnableLights()
    {
        stop = true;
        Roomlight1.enabled = false;
        Roomlight2.enabled = false;
        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        GreenLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        GreenLight();
        yield return new WaitForSeconds(0.3f);
        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(3.3f);
        light1.color = Color.red;
        light2.color = Color.red;
        Roomlight1.color = Color.red;
        Roomlight2.color = Color.red;
        RedLight();
        light1.enabled = true;
        light2.enabled = true;
        Roomlight1.enabled = true;
        Roomlight2.enabled = true;
        yield return new WaitForSeconds(4.0f);
        light1.enabled = false;
        light2.enabled = false;
        Roomlight1.enabled = false;
        Roomlight2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        RedLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        RedLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(2.6f);
        light1.color = Color.green;
        light2.color = Color.green;
        Roomlight1.color = Color.yellow;
        Roomlight2.color = Color.yellow;
        light1.enabled = true;
        light2.enabled = true;
        Roomlight1.enabled = true;
        Roomlight2.enabled = true;
        GreenLight();
        yield return new WaitForSeconds(0.4f);
        Roomlight1.enabled = false;
        Roomlight2.enabled = false;
        yield return new WaitForSeconds(0.8f);
        Roomlight1.enabled = true;
        Roomlight2.enabled = true;



    }
}
