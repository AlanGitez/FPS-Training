using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action<Vector3> OnPlayerMove;

    [SerializeField]
    private PlayerInput playerInput;
    [SerializeField]
    private MouseInput mouseInput;

    public void Move(Vector3 moveDirection) { 
        
        OnPlayerMove?.Invoke(moveDirection);
    }
}
