using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    
    private Slider slider;
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        OnTVvolumeChanged(slider.value);
        slider.onValueChanged.AddListener(OnTVvolumeChanged);
    }
    private void OnTVvolumeChanged(float volume) => Controller.current.TVvolumeChanged(volume);

  
}
