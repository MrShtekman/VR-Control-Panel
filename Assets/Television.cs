using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Television : MonoBehaviour
{

    [SerializeField] private List<VideoClip> videos = new List<VideoClip>();
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private Slider volumeSlider;

    void Start()
    {
        volumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(volumeSlider.value); });
        AudioListener.volume = volumeSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(AudioListener.volume);
    }

    public void ChangeVideo(int number)
    {
        
        videoPlayer.clip = videos[number];
        Debug.Log("test");

    }

    public void ChangeVolume(float volume) => AudioListener.volume = volume;


    
}
