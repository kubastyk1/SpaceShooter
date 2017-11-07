using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

    float maxSpeed = 2f;
    float randomXPosition = 0;
    float startXPosition = 0;

    void Start()
    {
        randomXPosition = Random.Range(0, 0.05f);
        startXPosition = transform.position.x;
    }

    void Update () {
        Vector3 spacecraftPosition = transform.position;
        spacecraftPosition.y -= maxSpeed * Time.deltaTime;

        spacecraftPosition.x += (startXPosition < 0) ?  randomXPosition : -randomXPosition;

        transform.position = spacecraftPosition;
    }
}
