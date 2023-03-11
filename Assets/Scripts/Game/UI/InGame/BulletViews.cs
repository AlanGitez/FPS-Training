using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BulletViews : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bullets;
    public void Configure(IWeapon weapon) {
         bullets.SetText("BULLETS: " + weapon.currentBullets);
        weapon.OnPlayerShootEvent.AddListener(Updated);
    }

    public void Updated(ShootData data) {
        if (data == null) return;
        Debug.Log("Aplicaste " + data.shootPower + " de daño!");

        bullets.SetText("BULLETS: " + data.currentBullets.ToString());
    }
}
