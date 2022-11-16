using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class TVbutton : MonoBehaviour
{
    [SerializeField] private VideoClip video;
    private Toggle toggle;
    private void Start()
    {
        toggle = gameObject.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate { OnTVbuttonPressed(); });
    }

    
    private void OnTVbuttonPressed() => Controller.current.TVbuttonPressed(video);

}
