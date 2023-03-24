using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 50f;
    public Vector3 axis = Vector3.up; // default axis of rotation is up

    private void Update()
    {
        float rotationAmount = speed * Time.deltaTime;
        transform.Rotate(axis, rotationAmount);
    }
}

