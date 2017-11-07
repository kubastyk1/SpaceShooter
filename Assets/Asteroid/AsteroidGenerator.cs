using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour {

    public GameObject[] bulletPrefab;

    public float fireDelay = 1f;
    float cooldownTimer = 0;
    int prefabNumber = 0;
    Vector3 startPosition;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            startPosition = new Vector3(Random.Range(-10f, 10f), transform.position.y, 0);   

            prefabNumber = Random.Range(0, bulletPrefab.Length);
            Instantiate(bulletPrefab[prefabNumber], startPosition, new Quaternion(0f, 0f, 0f, 0f));
        }
    }
}
