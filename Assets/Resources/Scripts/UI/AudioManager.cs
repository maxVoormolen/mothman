using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private List<Slider> _sliderList = new List<Slider>();
    [SerializeField]
    private List<GameObject> _masterList = new List<GameObject>();
    public List<GameObject> GetList()
    {
        return _masterList;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        _masterList = GameObject.FindGameObjectsWithTag("MasterAudio").ToList();

    }

    // Update is called once per frame
    void Update()
    {   
        if (GameObject.Find("AudioPanel(Clone)"))
        {
            SetVolume(0);
            SetVolume(1);
            
        }
        
    }

    public List<Slider> GetSliderList()
    {
        return _sliderList;
    }

    public void SetList(int index , Slider slider)
    {
        // _sliderList[i] = slider;
        _sliderList.Add(slider);

    }

    public void SetVolume(int index)
    {
       
        for (int i = 0; i < _masterList.Count; i++)
        {

            // var volume = _masterList[i].GetComponent<AudioSource>().volume
         //   var newVolume = 
            _masterList[i].GetComponent<AudioSource>().volume = _sliderList[0].value;
       
        }
    }

}   