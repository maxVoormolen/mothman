using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream1 : MonoBehaviour
{
    [SerializeField]
    public JumpScare1 JS1;

    [SerializeField]
    AudioSource ScreamAudio;
    [SerializeField]
    private Light light1;
    [SerializeField]
    private Light light2;

    public Transform VRHeadset;

    private bool IsPlayed = false;

    private void Update()
    {
        if (VRHeadset.transform.position.x >= 3f && IsPlayed == false && JS1.IsReady == true)
        {
            ScreamAudio.Play();
            StartCoroutine(LightFlicker());
            IsPlayed = true;
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
        float emission = Mathf.PingPong(Time.time, 0.9f);
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

    IEnumerator LightFlicker()
    {

        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(1.1f);
        light1.color = Color.red;
        light2.color = Color.red;
        RedLight();
        light1.enabled = true;
        light2.enabled = true;
        yield return new WaitForSeconds(0.3f);
        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        RedLight();
        yield return new WaitForSeconds(0.3f);
        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        RedLight();
        yield return new WaitForSeconds(0.3f);
        light1.enabled = false;
        light2.enabled = false;
        DeadLight();
        yield return new WaitForSeconds(0.2f);
        light1.enabled = true;
        light2.enabled = true;
        RedLight();
        yield return new WaitForSeconds(0.3f);
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
        light1.enabled = true;
        light2.enabled = true;
        GreenLight();
        


    }
}
