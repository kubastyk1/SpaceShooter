using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour {

    public GameObject[] bulletPrefab;

    public float fireDelay = 1f;
    float cooldownTimer = 0;
    int prefabNumber = 0;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            transform.Find("AsteroidStartPosition").position = new Vector3(0, transform.Find("AsteroidStartPosition").position.y, 0);
            transform.Find("AsteroidStartPosition").position += new Vector3(Random.Range(-10f, 10f), 0,0);


            prefabNumber = Random.Range(0, bulletPrefab.Length);
            Instantiate(bulletPrefab[prefabNumber], transform.Find("AsteroidStartPosition"));
        }
    }
}
