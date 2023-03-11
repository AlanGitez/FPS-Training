using UnityEngine;

[CreateAssetMenu]
public class Weapon : ScriptableObject, IWeapon
{
    // public methods. 
    public OnPlayerShootEvent OnPlayerShootEvent { get; set; } = new OnPlayerShootEvent();

    // private methods.
    [SerializeField] private int _maxBullets;
    [SerializeField] private int _currentBullets;
    [SerializeField] private int _shootPower;
    [SerializeField] private float _recoil;
    //public float rateOfFire { get; private set; }
    //public float reloadTime { get; private set; }
    

    public void Shoot() {
        Debug.Log("entre");
        if (currentBullets > 0) {
            currentBullets -= 1;
        }
        else if (currentBullets <= 0) Reload();

        OnPlayerShootEvent?.Invoke(new ShootData(currentBullets, shootPower));
    }

    public void Reload() { 
    
        currentBullets = maxBullets;
    }

    public int maxBullets
    {
        get { return _maxBullets; }
        set { _maxBullets = value; }
    }

    public int currentBullets
    {
        get { return _currentBullets; }
        set { _currentBullets = value; }
    }

    public int shootPower
    {
        get { return _shootPower; }
        set { _shootPower = value; }
    }

    public float recoil
    {
        get { return _recoil; }
        set { _recoil = value; }
    }
}
