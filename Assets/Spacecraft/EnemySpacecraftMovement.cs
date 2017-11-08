using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpacecraftMovement : MonoBehaviour {

    float maxSpeed = 2f;

    void Update()
    {
        Vector3 spacecraftPosition = transform.position;
        spacecraftPosition.y -= maxSpeed * Time.deltaTime;

        transform.position = spacecraftPosition;
    }
}
