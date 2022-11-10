using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                                                                   

public class BrightnessControl : MonoBehaviour
{
    private Slider slider;
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        OnBrightnessChange(slider.value);
        slider.onValueChanged.AddListener(OnBrightnessChange);
    }
    private void OnBrightnessChange(float brightness) => Controller.current.ChangeBrightness(brightness);
}
