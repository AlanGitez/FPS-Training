using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootData : MonoBehaviour
{
    public readonly int currentBullets;
    public readonly int shootPower;
    public readonly float reloadTime;
    public readonly float recoil;

    public ShootData(int currentBullets, int shootPower, float reloadTime, float recoil)
    {
        this.currentBullets = currentBullets;
        this.shootPower = shootPower;
        this.reloadTime = reloadTime;
        this.recoil = recoil;
    }
}
