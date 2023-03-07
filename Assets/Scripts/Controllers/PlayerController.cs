using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Camera firstPersonCamera;
    [SerializeField]
    private CameraController cameraController;

    [SerializeField]
    private Transform armsTransform;

    private Rigidbody rb;

    private Vector3 rbPosition = Vector3.zero;
    private Vector3 initialPosition = Vector3.zero;

    // Attributes to control the mouse interactions.
    private Transform cameraTransform;
    private Vector3 mouseMoveInput = Vector3.zero;
    private Vector3 previousMouseMoveInput = Vector3.zero;
    private float cameraYRotation = 0.0f;

    // this attribute controle the player rotation speed.
    [SerializeField]
    private float playerLookLerpTime = 0.25f;

    [Header("Movement")]
    [SerializeField] private float movementSpeed = 40f;
    [SerializeField] private float jumpPower = 20f;
    [SerializeField] private float crouchSpeed = 10f;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float cameraYRotationSpeed = 10f;

    private bool isJump;

    // We take the keyboard and mouse handlers.
    [SerializeField]
    private PlayerInput _playerInput;

    [SerializeField]
    private MouseInput _mouseInput;


    private void Awake()
    {
        rb = GetComponent<Rigidbody> ();
        cameraTransform = firstPersonCamera.transform;

        initialPosition = transform.position;
    }

    private void FixedUpdate()
    {
        mouseMoveInput = getMouseMoveInput();
     
        if (!cameraController.isOrbitalCamActive) {
            playerRotate();
            cameraYRotate();
        }

        playerMove();

        playerJump();
    }

    private void playerMove()
    {
        Vector3 newPosition = getMoveInput();

        rbPosition = new Vector3(
            newPosition.x * movementSpeed,
            newPosition.y,
            newPosition.z * movementSpeed);

      
        rb.AddRelativeForce(rbPosition, ForceMode.Force);
    }

    private void playerRotate() {

        rb.rotation = Quaternion.Euler(0.0f, rb.rotation.eulerAngles.y + (mouseMoveInput.x * rotationSpeed), 0.0f);
    }

    private void cameraYRotate() {
        Vector3 rotationValues = cameraTransform.rotation.eulerAngles;

        cameraYRotation += mouseMoveInput.y * cameraYRotationSpeed;
        cameraYRotation = Mathf.Clamp(cameraYRotation, -89.9f, 89.9f);

        cameraTransform.rotation = Quaternion.Euler(cameraYRotation, rotationValues.y, rotationValues.z);
        //armsTransform.rotation = Quaternion.Euler(0.0f,  0.0f, -cameraYRotation);
    }

    private void playerJump(){


        var jumpVector = new Vector3(0.0f, rb.position.y * jumpPower, 0.0f);

        if (getJumpInput() && !isJump) {
            rb.AddRelativeForce(jumpVector, ForceMode.Impulse);
            isJump = true;
        }

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

        //var mouseInputToWorldPoint = _mouseInput.convertInputToWorldPoint(firstPersonCamera);
        mouseMoveInput = new Vector3(
            _mouseInput.moveInput.x, 
            _mouseInput.invertMouseY ? - _mouseInput.moveInput.y : _mouseInput.moveInput.y,
            0.0f);

        return Vector3.Lerp(previousMouseMoveInput, mouseMoveInput * Time.deltaTime, playerLookLerpTime);
    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Ground") isJump = false;

    }


    // Auxiliares
    private void massAdjustmentOnJump() {

        float minMass = rb.mass;
        float maxMass = minMass + 5.0f;

        Debug.Log("FIRST rb.mass: " + rb.mass);


        float mass = Mathf.Lerp(minMass, maxMass, 0.7f);
       
        rb.mass = mass;

        Debug.Log("LAST rb.mass: " + rb.mass);
       
    }
}
