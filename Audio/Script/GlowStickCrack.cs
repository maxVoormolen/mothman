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

    Color color = Color.white;

    void Start()
    {
        light1.enabled = false;
        light2.enabled = false;
        color[0] = 0;
        color[1] = 241;
        color[2] = 9;
        color[3] = 127;     
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

    private float coloNumberConversion(float num)
    {
        return (num / 255.0f);
    }

    IEnumerator EnableLights()
    {

            yield return new WaitForSeconds(0.3f);

            light1.enabled = true;
            light2.enabled = true;

            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Light");
            
            rend.material.SetColor("Light", Color.green);

            yield return new WaitForSeconds(15.3f);

            FirstScareAudio.Play();
            yield return new WaitForSeconds(7.5f);
            SSH = true;
            

    }
}
