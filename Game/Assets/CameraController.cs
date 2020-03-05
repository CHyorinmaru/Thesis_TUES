using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform spectator;

    private float rotationSpeed = 0.5f;

    private float inputX;
    private float inputY;

    void Awake()
    {
        Cursor.visible = false;
    }

    private void LateUpdate()
    {
        CamControl();
    }

    private void CamControl()
    {
        inputX += Input.GetAxis("Mouse X") * rotationSpeed;
        inputY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        inputY = Mathf.Clamp(inputY, -30, 60);

        var targetRotation = Quaternion.LookRotation(transform.position);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = Quaternion.Euler(inputY, inputX, 0);
    }
}
