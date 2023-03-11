using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{
    public Vector2 moveInput;
    public bool isJump { get; private set; }

    public OnInventorySwitch onInventorySwitch;

    private InputActions _input;

    //public event Action<bool> changeCameraWasPressed;
    private void OnEnable()
    {
        _input = new InputActions();
        _input.InGame.Enable();

        _input.InGame.playermove.started += setMoveInput;
        _input.InGame.playermove.performed += setMoveInput;
        _input.InGame.playermove.canceled += setMoveInput;

        _input.InGame.playerjump.started += setJumpInput;
        _input.InGame.playerjump.performed += setJumpInput;
        _input.InGame.playerjump.canceled += setJumpInput;

        _input.InGame.inventory.started += setInventorySwitch;
        //_input.InGame.inventory.performed += setInventorySwitch;
        //_input.InGame.inventory.canceled += setInventorySwitch;

        //_input.InGame.playerchangeCamera.started += setChangeCameraWasPressed;
        //_input.InGame.playerchangeCamera.performed += setChangeCameraWasPressed;
        //_input.InGame.playerchangeCamera.canceled += setChangeCameraWasPressed;
    }

    private void OnDisable()
    {
        _input.InGame.playermove.started -= setMoveInput;
        _input.InGame.playermove.performed -= setMoveInput;
        _input.InGame.playermove.canceled -= setMoveInput;

        _input.InGame.playerjump.started -= setJumpInput;
        _input.InGame.playerjump.performed -= setJumpInput;
        _input.InGame.playerjump.canceled -= setJumpInput;

        //_input.InGame.inventory.started -= setInventorySwitch;
        _input.InGame.inventory.performed -= setInventorySwitch;
        //_input.InGame.inventory.canceled -= setInventorySwitch;

        //_input.InGame.playerchangeCamera.started -= setChangeCameraWasPressed;
        //_input.InGame.playerchangeCamera.performed -= setChangeCameraWasPressed;
        //_input.InGame.playerchangeCamera.canceled -= setChangeCameraWasPressed;
    }

    private void setMoveInput(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();

    }

    private void setJumpInput(InputAction.CallbackContext ctx)
    {
        isJump = ctx.ReadValue<float>() == 1;
    }

    private void setInventorySwitch(InputAction.CallbackContext ctx) {

        var switchInventory = ctx.ReadValue<float>() == 1;

        if(switchInventory) onInventorySwitch?.Invoke(switchInventory);
    }

    //private void setChangeCameraWasPressed(InputAction.CallbackContext ctx) {

    //    var changeCamera = ctx.ReadValue<float>() == 1;

    //    changeCameraWasPressed?.Invoke(changeCamera);
    //}
 
}
