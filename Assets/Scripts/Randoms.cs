using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randoms : MonoBehaviour
{

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        Color color = Random.ColorHSV();

        renderer.material.color = color;
    }


}
