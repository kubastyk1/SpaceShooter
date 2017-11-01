using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacecraftShooting : MonoBehaviour {

    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldownTimer = 0;

    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, transform.GetChild(0));
        }
    }
}
