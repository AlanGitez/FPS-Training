using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField]
    private Camera targetCamera;

    [SerializeField] 
    private float cameraYRotationSpeed = 10f;
    private float cameraYRotation = 0.0f;

    public void cameraYRotate(Vector3 direction)
    {
        Vector3 rotationValues = targetCamera.transform.rotation.eulerAngles;

        cameraYRotation += direction.y * cameraYRotationSpeed * Time.fixedDeltaTime;
        cameraYRotation = Mathf.Clamp(cameraYRotation, -89.9f, 89.9f);

        targetCamera.transform.rotation = Quaternion.Euler(cameraYRotation, rotationValues.y, rotationValues.z);
        //armsTransform.rotation = Quaternion.Euler(0.0f,  0.0f, -cameraYRotation);
    }
}
