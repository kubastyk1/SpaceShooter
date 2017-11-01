using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpacecraftMovement : MonoBehaviour
{
    float maxSpeed = 5f;

    public void MoveLeft ()
    {
        Vector3 spacecraftPosition = transform.position;
        spacecraftPosition.x -= maxSpeed * Time.deltaTime;
        transform.position = spacecraftPosition;
    } 

    public void MoveRight ()
    {
        Vector3 spacecraftPosition = transform.position;
        spacecraftPosition.x += maxSpeed * Time.deltaTime;
        transform.position = spacecraftPosition;
    }

    void Update () {

        /*   Vector3 spacecraftPosition = transform.position;
           spacecraftPosition.x += maxSpeed * Time.deltaTime;
           transform.position = spacecraftPosition; */
    }
}
