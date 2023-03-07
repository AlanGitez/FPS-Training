using UnityEngine;

public class WeaponController : MonoBehaviour
{
    private float rayDistance = 100f;

    [SerializeField]
    private Transform shootOrigin;

    [SerializeField]
    private Transform headCamera;

    [SerializeField]
    private GameObject bulletPrefab;

    void Start()
    {
        
    }

    private void OnEnable()
    {
   
    }

    void Update()
    {
        //Ray ray = new Ray(shootOrigin.position, crosshair.transform.position);
        Debug.DrawRay(shootOrigin.position, headCamera.forward * rayDistance, Color.black);

        if (Input.GetMouseButtonDown(0)) { 
            
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = shootOrigin.position;

            Vector3 direction = headCamera.position + (headCamera.forward * 10f);
            bullet.transform.LookAt(direction);
            
        }
    }
}
