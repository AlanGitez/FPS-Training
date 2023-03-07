using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float life = 2f;
    [SerializeField]
    private float lifeCounter;


    void Start()
    {
        lifeCounter = 0f;
    }

    void Update()
    {
        lifeCounter += Time.deltaTime;
        if (lifeCounter >= life) gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
}
