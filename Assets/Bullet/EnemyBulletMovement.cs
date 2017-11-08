using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour {

    float maxSpeed = 5f;

    void Update()
    {
        Vector3 position = transform.position;
        position.y -= maxSpeed * Time.deltaTime;
        transform.position = position;
    }
}
