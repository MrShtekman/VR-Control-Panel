using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ManipulateObject : MonoBehaviour
{
    [SerializeField] private GameObject item;
    [SerializeField] private MeshRenderer itemMeshRenderer;
    [SerializeField] private List<Collider> colliderList;
    [SerializeField] private Toggle invisToggle;
    [SerializeField] private Vector3 transformSpeed;
    
    private bool visible = true;
    private Coroutine coroutine = null;



    void Start()
    {
        invisToggle.onValueChanged.AddListener(delegate { ToggleInvisibility(); });
        
    }

   private void ToggleInvisibility()
    {
        visible = !visible;
        itemMeshRenderer.enabled = visible;
        foreach(Collider collider in colliderList)
        {
            collider.enabled = visible;
        }
    }

    public void StartTransform(float direction)
    {
        coroutine = StartCoroutine(ChangeSize(direction));
    }

    public void StopTransform()
    {
        StopCoroutine(coroutine);
    }

    IEnumerator ChangeSize(float direction)
    {
        while (true)
        {
            item.transform.localScale += transformSpeed * direction;
            yield return null;
        }
    }
}
