using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour {

    public GameObject bulletPrefab;

    public float fireDelay = 1f;
    float cooldownTimer = 0;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
      //      transform.Find("AsteroidStartPosition").position = Vector3.left * 2;
            Instantiate(bulletPrefab, transform.Find("AsteroidStartPosition"));
        }
    }
}
