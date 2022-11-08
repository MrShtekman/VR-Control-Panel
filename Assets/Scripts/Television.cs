using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Television : MonoBehaviour
{

    private VideoPlayer videoPlayer;
    private AudioSource audioSource;

    void Start()
    {
        videoPlayer = gameObject.GetComponent<VideoPlayer>();
        audioSource = gameObject.GetComponent<AudioSource>();
        Controller.current.onTVbuttonPressed += ChangeVideo;
        Controller.current.onTVvolumeChanged += ChangeVolume;
    }


    public void ChangeVideo(VideoClip video) => videoPlayer.clip = video;
    public void ChangeVolume(float volume) => AudioListener.volume = volume;

    private void OnDestroy()
    {
        Controller.current.onTVbuttonPressed -= ChangeVideo;
        Controller.current.onTVvolumeChanged -= ChangeVolume;
    }

}
