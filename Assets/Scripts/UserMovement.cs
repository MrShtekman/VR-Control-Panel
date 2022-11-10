using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserMovement : MonoBehaviour
{
    private PlayerInput input;
    private Coroutine coroutine = null;
    [SerializeField] private Transform face;
    [SerializeField] private float speed = 0.03f;

    private void Start()
    {
        input = gameObject.GetComponent<PlayerInput>();
        input.onActionTriggered += PlayerMove;
        Controller.current.onAltitudeChanged += StartChange;
        Controller.current.onStopChange += StopChange;

    }

    private void PlayerMove(InputAction.CallbackContext value)
    {
        float facingAngle = face.eulerAngles.y;
        Vector2 direction = value.ReadValue<Vector2>();
        // Applying the facing direction to the movement
        Vector3 vector = Quaternion.Euler(0, facingAngle, 0) * new Vector3(direction.x * speed, 0, direction.y * speed);
        transform.Translate(vector);
    }


    IEnumerator ChangeAltitude(float altitude)
    {
        while (true)
        {
            transform.Translate(new Vector3(0, altitude, 0) * speed);
            yield return null;
        }
    }

    private void StartChange(float altitude)
    {
        coroutine = StartCoroutine(ChangeAltitude(altitude));
    }

    private void StopChange()
    {
        StopCoroutine(coroutine);
    }
}
