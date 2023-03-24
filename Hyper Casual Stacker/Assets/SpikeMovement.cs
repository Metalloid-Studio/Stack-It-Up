using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    public Transform pointA; 
    public Transform pointB; 
    public float speed = 1f; 
    private bool isMovingToB = true; 

    void Update()
    {
        Vector3 targetPosition = isMovingToB ? pointB.position : pointA.position;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            isMovingToB = !isMovingToB;
        }
    }
}
