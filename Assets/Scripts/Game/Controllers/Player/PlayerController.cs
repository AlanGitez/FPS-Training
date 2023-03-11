using Assets.Scripts.Game.Controllers.Player;
using Assets.Scripts.Game.UseCase.Player;
using UnityEngine;

public class PlayerController : MonoBehaviour, ICollisionListener
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

    // To character control
    private IMove _move;
    private IRotate _rotate;
    private IJump _jump;

    private Rigidbody rb;
    private bool isJump = false;

    public void Initialize(IMove move, IJump jump, IRotate rotate) {
        _move = move;
        _jump = jump;
        _rotate = rotate;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;

        PlayerCollisions playerCollisions = GetComponent<PlayerCollisions>();

        if (playerCollisions != null) playerCollisions.SetCollisionListener(this);
        
    }

    private void OnEnable()
    {
        _playerInput.onInventorySwitch.AddListener(blockedPointerSwitch);
    }

    private void OnDisable()
    {
        _playerInput.onInventorySwitch.RemoveListener(blockedPointerSwitch);

    }

    private void FixedUpdate()
    {
        Vector3 moveInput = getMoveInput();
        Vector3 rotationInput = getMouseMoveInput();

        _move.PerformMovement(rb, moveInput, _player.movementSpeed);
        _rotate.PerformRotation(rb, rotationInput, _player.rotationSpeed);

        if (getJumpInput() && !isJump) _jump.PerformJump(rb, _player.jumpPower, out isJump);
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

    private void blockedPointerSwitch(bool switchInventory) {

        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    // Configuramos las props segun colisiones.
    public void OnCollide()
    {
        this.isJump = false;
    }
}
