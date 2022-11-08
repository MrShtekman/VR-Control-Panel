using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System;

public class Controller : MonoBehaviour
{
    public static Controller current;
    [SerializeField] private VideoClip video;
    private void Awake()
    {
        current = this;
    }

    public event Action<VideoClip> onTVbuttonPressed;
    public void TVbuttonPressed(VideoClip video)
    {
        if (onTVbuttonPressed != null)
        {
            onTVbuttonPressed(video);
        }
    }

    public event Action<float> onTVvolumeChanged;
    public void TVvolumeChanged(float volume)
    {
        if (onTVvolumeChanged != null)
        {
            onTVvolumeChanged(volume);
        }
    }

    public void ChangeBrightness(float brightness) => RenderSettings.skybox.SetFloat("_Exposure", brightness);


}
