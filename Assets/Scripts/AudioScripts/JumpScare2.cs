using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare2 : MonoBehaviour
{

    public GlowStickCrack GSC;
    public JumpScare1 JS1;
    public Wheel ME;

    [SerializeField]
    AudioSource ScreechAudio;
    [SerializeField]
    AudioSource MothmanScreamAudio;
    [SerializeField]
    AudioSource MonsterSoundsAudio;
    [SerializeField]
    AudioSource CryingAudio;
    [SerializeField]
    AudioSource ViolinAudio;

    [SerializeField]
    private Light light1;
    [SerializeField]
    private Light light2;

    public Transform VRHeadset;
    public bool test = false;

    private bool IsPlayed1 = false;
    private bool IsPlayed2 = false;
    private bool IsPlayed3 = false;
    private bool IsPlayed4 = false;
    private bool IsPlayed5 = false;

    private bool Play1 = false;
    private bool Play2 = false;
    private bool Play3 = false;
    private bool Play4 = false;
    private bool Play5 = false;

    private void Update()
    {
        if (VRHeadset.transform.position.x <= 5.5f && VRHeadset.transform.position.z >= -6f && VRHeadset.transform.position.z <= -5f && IsPlayed1 == false)
        {
            Play1 = true;
            StartCoroutine(JumpScares());
            ScreechAudio.Play();
            IsPlayed1 = true;
        }

        /*if (VRHeadset.transform.position.x >= 12f && VRHeadset.transform.position.x <= 10f && VRHeadset.transform.position.z <= 1f && IsPlayed2 == false)
        {
            Play2 = true;
            StartCoroutine(JumpScares());
            MothmanScreamAudio.Play();
            IsPlayed2 = true;
        }*/

        if (VRHeadset.transform.position.x <= 12f && VRHeadset.transform.position.x >= 10f && VRHeadset.transform.position.z <= 1f && IsPlayed3 == false)
        {
            Play3 = true;
            StartCoroutine(JumpScares());
            MonsterSoundsAudio.Play();
            IsPlayed3 = true;
        }

        if (VRHeadset.transform.position.x >= -13f && VRHeadset.transform.position.x <= -10f && VRHeadset.transform.position.z >= 1f && IsPlayed4 == false)
        {
            Play4 = true;
            StartCoroutine(JumpScares());
            CryingAudio.Play();
            IsPlayed4 = true;
        }

        if (VRHeadset.transform.position.x >= -7f && VRHeadset.transform.position.x <= -3f && VRHeadset.transform.position.z >= 3f && IsPlayed5 == false)
        {
            Play5 = true;
            StartCoroutine(JumpScares());
            ViolinAudio.Play();
            IsPlayed5 = true;
            ME.ActivateMacines = true;
        }
    }



    IEnumerator JumpScares()
    {
        if (Play1 == true)
        {
            Debug.Log("het speelt");
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.4f);
            JS1.RedLight();
            light1.color = Color.red;
            light2.color = Color.red;
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.4f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.4f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.4f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.4f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.4f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.4f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(6.2f);
            JS1.GreenLight();
            light1.color = Color.green;
            light2.color = Color.green;
            light1.enabled = true;
            light2.enabled = true;
            Play1 = false;
        }

        if (Play2 == true)
        {
            yield return new WaitForSeconds(1.2f);
            JS1.RedLight();
            light1.color = Color.red;
            light2.color = Color.red;
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(2.8f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(5.6f);
            JS1.GreenLight();
            light1.color = Color.green;
            light2.color = Color.green;
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.3f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.3f);
            JS1.GreenLight();
            light1.color = Color.green;
            light2.color = Color.green;
            light1.enabled = true;
            light2.enabled = true;
            Play2 = false;
        }

        if (Play3 == true)
        {
            yield return new WaitForSeconds(1.8f);
            JS1.RedLight();
            light1.color = Color.red;
            light2.color = Color.red;
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(2.9f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(3.4f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(5.3f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(3.2f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(2.8f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(3.5f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(2.8f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(4.3f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(2.8f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(4.7f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(3.9f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(3.6f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(4.0f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(3.8f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(6.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(9.3f);
            JS1.GreenLight();
            light1.color = Color.green;
            light2.color = Color.green;
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(3.5f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(6.4f);
            JS1.GreenLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(1.5f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(2.4f);
            JS1.GreenLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(0.5f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(1.4f);
            JS1.GreenLight();
            light1.color = Color.green;
            light2.color = Color.green;
            light1.enabled = true;
            light2.enabled = true;
            Play3 = false;
        }

        if (Play4 == true)
        {
            yield return new WaitForSeconds(1.1f);
            JS1.RedLight();
            light1.color = Color.red;
            light2.color = Color.red;
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(1.7f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(2.3f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(3.6f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.6f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(3.1f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.9f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(3.2f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.9f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(3.2f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(1.5f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(3.2f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(5.2f);
            JS1.GreenLight();
            light1.color = Color.green;
            light2.color = Color.green;
            light1.enabled = true;
            light2.enabled = true;
            Play4 = false;
        }

        if (Play5 == true)
        {
            yield return new WaitForSeconds(0.5f);
            JS1.RedLight();
            light1.color = Color.red;
            light2.color = Color.red;
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(1.5f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.6f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(1.5f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.6f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(1.5f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(0.6f);
            JS1.RedLight();
            light1.enabled = true;
            light2.enabled = true;
            yield return new WaitForSeconds(1.4f);
            JS1.DeadLight();
            light1.enabled = false;
            light2.enabled = false;
            yield return new WaitForSeconds(7.6f);
            JS1.GreenLight();
            light1.color = Color.green;
            light2.color = Color.green;
            light1.enabled = true;
            light2.enabled = true;
            Play5 = false;
        }
    }
}
