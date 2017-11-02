using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

    float maxSpeed = 2f;
    int iteration = 0;
    float currentRundom = 0;

    void Start()
    {
        currentRundom = Random.Range(-0.1f, 0.1f);
    }

    void Update () {
        Vector3 spacecraftPosition = transform.position;
       // Vector3 temp = new Vector3(Random.Range(-10.6f, 10.6f), Random.Range(-10.6f, 10.6f), Random.Range(-10.6f, 10.6f));
        spacecraftPosition.y -= maxSpeed * Time.deltaTime;
        if(iteration < 120)
        {
            spacecraftPosition.x += currentRundom;
            iteration++;
        } else
        {
            currentRundom = Random.Range(-0.1f, 0.1f);
            iteration = 0;
        }

        transform.position = spacecraftPosition;
    }
}
