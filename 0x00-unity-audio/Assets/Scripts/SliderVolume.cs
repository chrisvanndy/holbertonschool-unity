using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SliderVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer myAudio;
    
    public void SetVol(float sliderVal)
    {
        myAudio.SetFloat("BGMVol", Mathf.Log10(sliderVal)*20);
    }
}
