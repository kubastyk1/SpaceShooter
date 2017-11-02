using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

    float maxSpeed = 2f;
    int turnDelay = 0;
    float randomXPosition = 0;
    float startXPosition = 0;

    void Start()
    {
        randomXPosition = Random.Range(0, 0.1f);
        startXPosition = transform.position.x;
    }

    void Update () {
        Vector3 spacecraftPosition = transform.position;
        spacecraftPosition.y -= maxSpeed * Time.deltaTime;

        if(turnDelay < 120)
        {
            if(startXPosition < 0)
            {
                spacecraftPosition.x += randomXPosition;
            } else
            {
                spacecraftPosition.x -= randomXPosition;
            }
            turnDelay++;
        } else
        {
            randomXPosition = Random.Range(0, 0.1f);
            startXPosition = transform.position.x;
            turnDelay = 0;
        }

        transform.position = spacecraftPosition;
    }
}
