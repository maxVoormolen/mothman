using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowStickCrack : MonoBehaviour {


    [SerializeField]
    AudioSource GlowStickCrackAudio;
    [SerializeField]
    AudioSource FirstScareAudio;

    [SerializeField]
    private Light light1;
    [SerializeField]
    private Light light2;

    private bool IsAlreadyDead = false;
    public bool SSH = false;


    void Start()
    {
        light1.enabled = false;
        light2.enabled = false;
    
    }


    void Update()
    {

        if (Input.GetKeyDown("d") && IsAlreadyDead == false)
        {
            GlowStickCrackAudio.Play();
            IsAlreadyDead = true;
            StartCoroutine(EnableLights());

        }

    }

    IEnumerator EnableLights()
    {

            yield return new WaitForSeconds(0.3f);

            light1.enabled = true;
            light2.enabled = true;
            light1.color = Color.green;
            light2.color = Color.green;


        
            Renderer renderer = GetComponent<Renderer>();
            Material mat = renderer.material;
            float emission = Mathf.PingPong(Time.time, 0.3f);
            Color baseColor = Color.green;
            Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
            mat.SetColor("_EmissionColor", finalColor);


            yield return new WaitForSeconds(15.3f);
            FirstScareAudio.Play();
            yield return new WaitForSeconds(7.5f);
            SSH = true;
            

    }
}
