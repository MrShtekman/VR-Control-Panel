using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class TVbutton : MonoBehaviour
{
    [SerializeField] private VideoClip video;
    private Button button;
    private void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnTVbuttonPressed);
    }

    
    private void OnTVbuttonPressed() => Controller.current.TVbuttonPressed(video);

}
