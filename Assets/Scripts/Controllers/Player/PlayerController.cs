using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Attributes to control the mouse interactions.
    private Vector3 previousMouseMoveInput = Vector3.zero;
    private Vector3 mouseMoveInput = Vector3.zero;

    // this attribute controle the player rotation speed.
    [SerializeField]
    private float playerLookLerpTime = 0.25f;

    // We take the keyboard and mouse handlers.
    [SerializeField]
    private PlayerInput _playerInput;

    [SerializeField]
    private MouseInput _mouseInput;

    // Player reference.
    [SerializeField]
    private Player _player;

    private void FixedUpdate()
    {
        _player.Rotate(getMouseMoveInput());
    
        _player.Move(getMoveInput());

        _player.Jump(getJumpInput());
    }

    private Vector3 getMoveInput() {

        // Se utiliza el input.y para el eje x y se utiliza el valor negativo de input.x
        // debido a que por algun motivo desconocido aun, los axis de movimiento se encontraban desconfigurados.
        // Con esto queda momentaneamente resuelto.
        return new Vector3(_playerInput.moveInput.y, 0.0f, -_playerInput.moveInput.x);

    }

    private bool getJumpInput() {

        return _playerInput.isJump;
    }

    private Vector3 getMouseMoveInput() {

        previousMouseMoveInput = mouseMoveInput;

        mouseMoveInput = new Vector3(
            _mouseInput.moveInput.x, 
            _mouseInput.invertMouseY ? - _mouseInput.moveInput.y : _mouseInput.moveInput.y,
            0.0f);

        return Vector3.Lerp(previousMouseMoveInput, mouseMoveInput, playerLookLerpTime);
    }
   
}
