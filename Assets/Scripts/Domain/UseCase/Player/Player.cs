using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    // public attributes

    //private attributes
    private Rigidbody rb;
    private Vector3 rbPosition;

    [Header("Movement")]
    [SerializeField] private float movementSpeed = 40f;
    [SerializeField] private float jumpPower = 20f;
    [SerializeField] private float crouchSpeed = 10f;
    [SerializeField] private float rotationSpeed = 2f;
    [SerializeField] private float cameraYRotationSpeed = 2f;
    private bool isJump;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector2 moveDirection) {

        Vector3 newPosition = new Vector3(moveDirection.x, 0.0f, moveDirection.y);

        rbPosition = new Vector3(
            newPosition.x * movementSpeed,
            newPosition.y,
            newPosition.z * movementSpeed);


        rb.AddRelativeForce(rbPosition, ForceMode.Force);

        //OnPlayerMove?.Invoke(moveDirection);
    }

    public void Rotate(Vector3 rotation) {

        var rbYRotation = rb.rotation.eulerAngles.y + (rotation.x * rotationSpeed) * Time.fixedDeltaTime;

        rb.rotation = Quaternion.Euler(0.0f, rbYRotation, 0.0f);

    }

    public void Jump(bool toJump) {

        var jumpVector = new Vector3(0.0f, rb.position.y * jumpPower, 0.0f);

        if (toJump && !isJump)
        {
            rb.AddRelativeForce(jumpVector, ForceMode.Impulse);
            isJump = true;
        }
    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Ground") isJump = false;

    }
}
