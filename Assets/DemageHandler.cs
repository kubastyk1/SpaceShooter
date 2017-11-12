using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemageHandler : MonoBehaviour {

    public int health = 1;
    public float invulnPerion = 0;

    float invulnTimer = 0;
    int correctLayer;

    void Start()
    {
        correctLayer = gameObject.layer;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        health--;

        invulnTimer = invulnPerion;
        gameObject.layer = 10;
    }

    void Update()
    {
        invulnTimer -= Time.deltaTime;
        if(invulnTimer <= 0)
        {
            gameObject.layer = correctLayer;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
