using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    IEnumerator Move()
    {

        while (true)
        {
            transform.Translate(Vector3.right * 0.01f);
            yield return new WaitForSeconds(0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            StartCoroutine(Move());
        }

        if (Input.GetKeyDown("e"))
        {
            StopCoroutine(Move());
        }
    }
}
