using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICombat : MonoBehaviour
{
    [SerializeField]
    private Text bulletCounter;

    public void UpdateOnPlayerShootUI(ShootData shootData) {
        Debug.Log("estas disparando rey: " + bulletCounter.text);
        bulletCounter.text = "Bullets: " + shootData.currentBullets;
        
    }
}
