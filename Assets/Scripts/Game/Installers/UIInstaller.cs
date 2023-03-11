using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInstaller : MonoBehaviour
{
    [SerializeField] BulletViews bulletViews;
    [SerializeField] private Weapon weapon;

    private void Awake()
    {
        bulletViews.Configure(weapon);
    }

}
