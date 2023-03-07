using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    protected override float rateOfFire { get; set; } = 0.5f;
    protected override float reloadTime { get; set; } = 1.5f;
    protected override float recoil { get; set; } = 3f;
    protected override int shootPower { get; set; } = 10;



    protected override void reload()
    {
        throw new System.NotImplementedException();
    }

    protected override void shoot()
    {
        throw new System.NotImplementedException();
    }
}
