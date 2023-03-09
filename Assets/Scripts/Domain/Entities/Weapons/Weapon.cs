

using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public abstract int maxBullets { get; set; }
    public abstract int currentBullets { get; set; }
    protected abstract float rateOfFire { get; set; }
    public abstract int shootPower { get; set; }
    protected abstract float reloadTime { get; set; }
    protected abstract float recoil { get; set; }


    protected abstract void shoot();

    protected abstract void reload();


    
}
