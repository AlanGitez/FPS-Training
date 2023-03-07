using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseInput : MonoBehaviour
{
    public Vector2 moveInput;

    public event Action<bool, bool> OnClickInput;

    public bool invertMouseY = true;

    private InputActions _input;

    private void OnEnable()
    {
        _input = new InputActions();
        _input.InGame.Enable();

        _input.InGame.mousemove.started += setMoveInput;
        _input.InGame.mousemove.performed += setMoveInput;
        _input.InGame.mousemove.canceled += setMoveInput;

        _input.InGame.mouseclick.started += setMouseClick;
        _input.InGame.mouseclick.performed += setMouseClick;
        _input.InGame.mouseclick.canceled += setMouseClick;

    }

    private void OnDisable()
    {
        _input.InGame.mousemove.started -= setMoveInput;
        _input.InGame.mousemove.performed -= setMoveInput;
        _input.InGame.mousemove.canceled -= setMoveInput;

        _input.InGame.mouseclick.started -= setMouseClick;
        _input.InGame.mouseclick.performed -= setMouseClick;
        _input.InGame.mouseclick.canceled -= setMouseClick;

    }

    private void setMoveInput(InputAction.CallbackContext ctx) {

        
        moveInput = ctx.ReadValue<Vector2>();

        //OnMoveInput?.Invoke(moveInput);
    
    }


    private void setMouseClick(InputAction.CallbackContext ctx)
    {
        string buttonName = ctx.control.name;

        bool leftClick = false;
        bool rightClick = false;

        if (buttonName == "leftButton") leftClick = ctx.ReadValue<float>() == 1f;
        else if (buttonName == "rightButton") rightClick = ctx.ReadValue<float>() == 1f;

        OnClickInput?.Invoke(leftClick, rightClick);
    }


    public Vector3 convertInputToWorldPoint(Camera camera) {

        return camera.ScreenToWorldPoint(new Vector3(moveInput.x, moveInput.y, 0.0f));
    }
}
