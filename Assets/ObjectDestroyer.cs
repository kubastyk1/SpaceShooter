﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour {

    public float timer = 0;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            //Destroy(gameObject);
        }
    }
}
