
using UnityEngine;

public interface IWeapon
{

    int maxBullets { get; set; }
    int currentBullets { get; set; }
    int shootPower { get; set; }
    float recoil { get; set; }
    OnPlayerShootEvent OnPlayerShootEvent { get; set; }

}
