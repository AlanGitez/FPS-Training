using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private MouseInput _mouseInput;

    [SerializeField]
    private CameraMovement cameraMovement;

    [SerializeField]
    private float lookLerpTime = 0.25f;

    private Vector3 mouseMoveInput = Vector3.zero;
    private Vector3 previousMouseMoveInput = Vector3.zero;

    private void Update()
    {
        cameraMovement.cameraYRotate(getMouseMoveInput());
    }

    private Vector3 getMouseMoveInput()
    {
        previousMouseMoveInput = mouseMoveInput;

        mouseMoveInput = new Vector3(
            _mouseInput.moveInput.x,
            _mouseInput.invertMouseY ? -_mouseInput.moveInput.y : _mouseInput.moveInput.y,
            0.0f);

        return Vector3.Lerp(previousMouseMoveInput, mouseMoveInput * Time.deltaTime, lookLerpTime);
    }
}
