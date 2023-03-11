using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Installer : MonoBehaviour
{
    [SerializeField] BulletViews bulletViews;
    [SerializeField] private Weapon weapon;

    private void Awake()
    {
        bulletViews.Configure(weapon);
    }

}
