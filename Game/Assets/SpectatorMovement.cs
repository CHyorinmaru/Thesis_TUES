using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectatorMovement : MonoBehaviour
{

    private Vector3 direction;

    [SerializeField]
    private int movementSpeed;

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float InputX = Input.GetAxis("Horizontal");
        float InputZ = Input.GetAxis("Vertical");

        var camera = Camera.main;
        var forward = camera.transform.forward;
        var right = camera.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        direction = forward * InputZ + right * InputX;

        transform.Translate(direction * Time.deltaTime * movementSpeed);
    }
}
