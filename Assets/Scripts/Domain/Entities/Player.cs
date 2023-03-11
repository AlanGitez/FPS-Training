using Assets.Scripts.Game.UseCase.Player;
using UnityEngine;


[CreateAssetMenu]
public class Player : ScriptableObject
{

    [Header("Movement")]
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _crouchSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _cameraYRotationSpeed;

    public float movementSpeed 
    {
        get { return this._movementSpeed; }
        set { this._movementSpeed = value; }
    }

    public float jumpPower
    {
        get { return this._jumpPower; }
        set { this._jumpPower = value; }
    }

    public float crouchSpeed
    {
        get { return this._crouchSpeed; }
        set { this._crouchSpeed = value; }
    }

    public float rotationSpeed
    {
        get { return this._rotationSpeed; }
        set { this._rotationSpeed = value; }
    }

    public float cameraYRotationSpeed
    {
        get { return this._cameraYRotationSpeed; }
        set { this._cameraYRotationSpeed = value; }
    }
}



