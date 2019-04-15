using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class JumpScare3 : MonoBehaviour
{
    [SerializeField]
    AudioSource JumpScare3Audio;

    [SerializeField]
    private Light LightStick;
    [SerializeField]
    private Light LightStick2;
    [SerializeField]
    private Light eye1_1;
    [SerializeField]
    private Light eye1_2;
    [SerializeField]
    private Light eye2_1;
    [SerializeField]
    private Light eye2_2;

    public Transform VRHeadset;

    private float m_FadeTime = 0.8f;
    private bool IsPlayed = false;
    public bool test = false;

    private void Awake()
    {
        eye1_1.enabled = false;
        eye1_2.enabled = false;
        eye2_1.enabled = false;
        eye2_2.enabled = false;
    }

    private void Update()
    {
        if (VRHeadset.transform.position.x <= 13f && VRHeadset.transform.position.x >= 10f && VRHeadset.transform.position.z <= -13f && IsPlayed == false || test && !IsPlayed)
        {
            SteamVR_Fade.Start(Color.black, m_FadeTime, true);
            JumpScare3Audio.Play();
            IsPlayed = true;
            LightStick.enabled = false;
            LightStick2.enabled = false;
            eye1_1.enabled = true;
            eye1_2.enabled = true;
            eye2_1.enabled = true;
            eye2_2.enabled = true;
            DeadLight();
        }
    }

    public void DeadLight()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material mat = renderer.material;
        float emission = Mathf.PingPong(Time.time, 0.1f);
        Color baseColor = Color.gray;
        Color finalColor = baseColor * Mathf.LinearToGammaSpace(emission);
        mat.SetColor("_EmissionColor", finalColor);
    }
}