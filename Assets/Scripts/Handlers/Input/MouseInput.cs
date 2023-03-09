using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[System.Serializable]
public class OnPlayerShootEvent : UnityEvent { }
[System.Serializable]
public class OnPlayerAimEvent : UnityEvent { }

public class MouseInput : MonoBehaviour
{
    public Vector2 moveInput;

    //public event Action<bool, bool> OnClickInput;
    public OnPlayerShootEvent onPlayerShootEvent;
    public OnPlayerAimEvent onPlayerAimEvent;

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

        if (buttonName == "leftButton" && ctx.ReadValue<float>() == 1f)
            onPlayerShootEvent?.Invoke();
        else if (buttonName == "rightButton" && ctx.ReadValue<float>() == 1f) 
            onPlayerAimEvent?.Invoke();

        //OnClickInput?.Invoke(leftClick, rightClick);
    }


    public Vector3 convertInputToWorldPoint(Camera camera) {

        return camera.ScreenToWorldPoint(new Vector3(moveInput.x, moveInput.y, 0.0f));
    }
}
