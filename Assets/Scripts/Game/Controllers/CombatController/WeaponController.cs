using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class WeaponController : MonoBehaviour
{

    private float raycastShootDistance = 100f;

    [SerializeField] private Transform shootOrigin;
    [SerializeField] private Transform headCamera;
    [SerializeField] private MouseInput _mouseInput;
    [SerializeField] private Weapon _weapon;

    ////Momentaneo
    public float laserDuration = 0.8f;
    private LineRenderer laser;

    private void Awake()
    {
        laser = GetComponent<LineRenderer>();
        laser.startWidth = 0.1f;
    }

    private void OnEnable()
    {
        _mouseInput.OnClickInput += checkMouseInput;
    }

    private void OnDisable()
    {
        _mouseInput.OnClickInput -= checkMouseInput;

    }

    private void checkMouseInput(bool leftClick, bool rightClick) {

        if (leftClick) onPlayerShoot();
        else onPlayerAim();
    
    }

    private void onPlayerShoot()
    {
        if (headCamera == null || shootOrigin.transform == null) return;

        Vector3 raycastOrigin = shootOrigin.position;

        Ray ray = headCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        Vector3 raycastDirection = ray.direction;

        laser.SetPosition(0, shootOrigin.position);
        laser.SetPosition(1, raycastOrigin + raycastDirection.normalized * raycastShootDistance);

        //RaycastHit hit;
        //if (Physics.Raycast(raycastOrigin, raycastDirection, out hit, raycastShootDistance))
        //{


        //}

        // mantenemos un poco la duracion del laser
        StartCoroutine(ShowLaser());

        _weapon.Shoot();
    }

    // tambien momentaneo.
    IEnumerator ShowLaser()
    {
        laser.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        laser.enabled = false;
    }

    private void onPlayerAim() { }

}
