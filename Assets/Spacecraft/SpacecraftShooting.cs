using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacecraftShooting : MonoBehaviour {

    public GameObject bulletPrefab;

    public float fireDelay;
    float cooldownTimer = 1f;

    public Transform shotSpawn;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
