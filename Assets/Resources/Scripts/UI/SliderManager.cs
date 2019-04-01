using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SliderManager : MonoBehaviour
{

    private AudioManager auManager;
   [SerializeField]
    private List<Slider> _sliderlist = new List<Slider>();
    // Start is called before the first frame update
    void Awake()
    {
        _sliderlist = gameObject.GetComponentsInChildren<Slider>().ToList();
        auManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        for (int i=0; i < _sliderlist.Count; i++)
        {
            
            //_sliderlist[i].value = auManager.GetList()[i].GetComponent<AudioSource>().volume;
            auManager.SetList(i,_sliderlist[i]);

        }
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
