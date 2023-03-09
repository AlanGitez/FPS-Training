

using System.Collections;
using UnityEngine;

public  class Weapon : MonoBehaviour
{
    // public methods. 
    public int currentBullets { get; private set; }
    public float rateOfFire { get; private set; }
    public int shootPower { get; private set; }
    public float reloadTime { get; private set; }

    // private methods.
    [SerializeField]
    private int maxBullets;

    [SerializeField]
    private float recoil;

    [SerializeField]
    private float raycastShootDistance;

    [SerializeField]
    private Transform shootOrigin;

    //Momentaneo
    public float laserDuration = 0.8f;
    private LineRenderer laser;

    private void Awake()
    {
       laser = GetComponent<LineRenderer>();
        laser.startWidth = 0.1f;
    }
    public void Shoot(Transform cameraTransform) {
        if (cameraTransform == null || shootOrigin.transform == null) return;

        Debug.Log("disparaste rey " + cameraTransform);
        Vector3 raycastOrigin = shootOrigin.position;

        //Vector3 raycastDirection = cameraTransform.position + (cameraTransform.forward * 30f);

        Ray ray = cameraTransform.GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        Vector3 raycastDirection = ray.direction;

        laser.SetPosition(0, shootOrigin.position);
        laser.SetPosition(1, raycastOrigin + raycastDirection.normalized * raycastShootDistance);

        RaycastHit hit;
        if (Physics.Raycast(raycastOrigin, raycastDirection, out hit, raycastShootDistance))
        {


        }
     

        // mantenemos un poco la duracion del laser
        StartCoroutine(ShowLaser());

        if (currentBullets > 0)
        {

            currentBullets--;
        }

    }


    protected void reload() {
        // falta implementar la cantidad de cargadores que tiene
        if (currentBullets < maxBullets)
        {

            currentBullets = maxBullets;
        }
    }

    // tambien momentaneo.
    IEnumerator ShowLaser()
    {
        laser.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        laser.enabled = false;
    }
}
