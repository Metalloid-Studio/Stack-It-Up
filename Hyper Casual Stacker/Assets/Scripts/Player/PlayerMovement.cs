using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] private float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // print(Input.mousePosition);
        if (Input.GetMouseButton(0)){

            Vector3 moveDirection = new Vector3(Input.mousePosition.x - Screen.width/2, 0, Input.mousePosition.y - Screen.height/2).normalized;
            float deltaSpeed = speed * Time.deltaTime * 100;

            rb.velocity = new Vector3(moveDirection.x*deltaSpeed, rb.velocity.y, moveDirection.z*deltaSpeed);
        }
        else rb.velocity = new Vector3(0,rb.velocity.y,0);
    }
}
