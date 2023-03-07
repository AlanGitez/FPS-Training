using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected abstract float rateOfFire { get; set; }
    protected abstract int shootPower { get; set; }
    protected abstract float reloadTime { get; set; }
    protected abstract float recoil { get; set; }


    protected abstract void shoot();

    protected abstract void reload();


    
}
