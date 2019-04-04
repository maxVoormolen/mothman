using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

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
    public bool isPickedUp = false;

    public SteamVR_Action_Boolean m_TeleportAction;
    private SteamVR_Behaviour_Pose m_Pose = null;

    void Start()
    {
        m_Pose = GetComponent<SteamVR_Behaviour_Pose>();

        light1.enabled = false;
        light2.enabled = false;
    }


    void Update()
    {
        if (isPickedUp && !IsAlreadyDead)
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


            yield return new WaitForSeconds(1.0f);
            FirstScareAudio.Play();
            yield return new WaitForSeconds(7.5f);
            SSH = true;
    }
}
