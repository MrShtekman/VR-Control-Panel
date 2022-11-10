using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerAltitude : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Button button;
    [SerializeField] private float direction;

    void Start()
    {
        button = gameObject.GetComponent<Button>();
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        
        Controller.current.AltitudeChanged(direction);
        
    }



    public void OnPointerUp(PointerEventData eventData)
    {
        Controller.current.StopChange();
    }
}
