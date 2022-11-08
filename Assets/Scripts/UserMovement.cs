using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserMovement : MonoBehaviour
{
    private PlayerInput input;
    private Vector2 direction;

    private void Start()
    {
        input = gameObject.GetComponent<PlayerInput>();
        input.onActionTriggered += PlayerMove;
    }

    private void PlayerMove(InputAction.CallbackContext value)
    {
        Debug.Log(value.action);
        direction = value.ReadValue<Vector2>();
        transform.Translate(new Vector3(direction.x * 0.03f, 0, direction.y * 0.03f));
    }
}
