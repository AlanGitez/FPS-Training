using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootData
{
    public readonly int currentBullets;
    public readonly int shootPower;
    //public readonly float reloadTime;
    //public readonly float recoil;
    public readonly string log;
    public ShootData(string log)
    {
        this.log = log;
    }
    public ShootData(int currentBullets, int shootPower)
    {
        this.currentBullets = currentBullets;
        this.shootPower = shootPower;
        //this.reloadTime = reloadTime;
        //this.recoil = recoil;
    }
}
