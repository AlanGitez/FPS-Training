using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CrosshairController : MonoBehaviour
{
    //[SerializeField]
    //private Transform crosshairCanvas;

    [SerializeField]
    private MouseInput mouseInput;




    private void OnEnable()
    {
        transform.SetPositionAndRotation(new Vector3(Screen.width / 2, Screen.width / 2, 0.0f), transform.rotation);
        //mouseInput.OnMoveInput += moveCrosshairTowardsMousePosition;
    }

    //private void OnDisable()
    //{
    //    mouseInput.OnMoveInput -= moveCrosshairTowardsMousePosition;
    //}

    //private void Update()
    //{
    //    moveCrosshairTowardsMousePosition();
    //}

    //private void moveCrosshairTowardsMousePosition() {

    //    var mousePosition = new Vector2(mouseInput.moveInput.x, mouseInput.moveInput.y);

    //    Vector3 worldMousePosition = firstPersonCamera.ScreenToWorldPoint(
    //        new Vector3(mousePosition.x, mousePosition.y, 8));


    //    transform.position = worldMousePosition;

    //}

}
