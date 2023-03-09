using System;
using UnityEngine;
using UnityEngine.Events;

public class WeaponController : MonoBehaviour
{
    private float rayDistance = 100f;

    [SerializeField]
    private Transform shootOrigin;

    [SerializeField]
    private Transform headCamera;

    //[SerializeField]
    //private OnPlayerShootEvent onPlayerShootEvent;
    [SerializeField]
    private MouseInput _mouseInput;
    [SerializeField]
    private Weapon _weapon;

    //[SerializeField]
    //private GameObject bulletPrefab;


    private void OnEnable()
    {
        _mouseInput.onPlayerShootEvent?.AddListener(onPlayerShoot);
    }


    void Update()
    {
        //Ray ray = new Ray(shootOrigin.position, crosshair.transform.position);
        Debug.DrawRay(shootOrigin.position, headCamera.forward * rayDistance, Color.black);

        //if (Input.GetMouseButtonDown(0))
        //{

        //    GameObject bullet = Instantiate(bulletPrefab);
        //    bullet.transform.position = shootOrigin.position;

        //    Vector3 direction = headCamera.position + (headCamera.forward * 10f);
        //    bullet.transform.LookAt(direction);

        //}
    }

    private void onPlayerShoot() {
        Debug.Log("Estoy en el controller");
        _weapon.Shoot(headCamera);
        
    }

}
