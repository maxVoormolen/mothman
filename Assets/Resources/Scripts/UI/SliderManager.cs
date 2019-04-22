﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class SliderManager : MonoBehaviour
{

    private AudioManager auManager;
    public int listSlot = 0;
    private List<string> _tagnames = new List<string>();
    [SerializeField]
    private List<Slider> _sliderlist = new List<Slider>();
    // Start is called before the first frame update
    void Awake()
    {

        _sliderlist = gameObject.GetComponentsInChildren<Slider>().ToList();
        auManager = GameObject.FindGameObjectWithTag(_tagnames[listSlot]).GetComponent<AudioManager>();
        for (int i = 0; i < _sliderlist.Count; i++)
        {


            auManager.SetList(i, _sliderlist[i]);


        }

        for (int i = 0; i < auManager.GetMList().Count; i++)
        {
            for (int j = 0; j < auManager.GetMList().Count; j++)
            {
                _sliderlist[i].value = auManager.GetMList()[j].GetComponent<AudioSource>().volume;
                Debug.Log(_sliderlist[i]);
                Debug.Log(auManager.GetMList()[i]);
            }



        }
        //    for (int i = 0; i < auManager.GetEList().Count; i++)
        //    {
        //        _sliderlist[1].value = auManager.GetEList()[0].GetComponent<AudioSource>().volume;


        //    }
        //}
        //private void Start()
        //{
        //}

        ////// Update is called once per frame
        ////void Update()
        ////{

        ////}
    }
}
