using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemageHandler : MonoBehaviour {

    public GameObject bonusObject;

    public int health = 1;
    public float invulnPerion = 0;

    float invulnTimer = 0;
    int correctLayer;

    private static float bonusTimer = 60;
    //public float bonusDelay;

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
        bonusTimer -= Time.deltaTime;
        if (health <= 0)
        {
            
            Destroy(gameObject);
            if (bonusTimer <= 0)
            {
                Instantiate(bonusObject, this.transform.position, this.transform.rotation);
                bonusTimer = Random.Range(0, 60);                
            }
        }
        Debug.Log("Bonus time=" + bonusTimer);
    }
}
