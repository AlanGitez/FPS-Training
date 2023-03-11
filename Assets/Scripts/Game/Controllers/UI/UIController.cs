using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private MouseInput _mouseInput;

    [SerializeField]
    private UICombat combat;

    [SerializeField] private OnShootUpdateUIEvent onShootUpdateUIEvent;


    private void OnEnable()
    {
        onShootUpdateUIEvent.AddListener(playerShootParametersUpdate);    
    }

    private void OnDisable()
    {
        onShootUpdateUIEvent.RemoveListener(playerShootParametersUpdate);

    }

    private void playerShootParametersUpdate(ShootData data) {
        Debug.Log("entraste");
        combat.UpdateOnPlayerShootUI(data);

    }
}
