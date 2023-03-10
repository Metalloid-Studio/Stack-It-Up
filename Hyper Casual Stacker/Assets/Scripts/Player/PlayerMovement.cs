using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.mousePosition);
        if (Input.GetMouseButton(0)){
            Vector3 moveDirection = new Vector3(Input.mousePosition.x - Screen.width/2, 0, Input.mousePosition.y - Screen.height/2).normalized;
            rb.velocity = moveDirection * speed * Time.deltaTime * 100;
            print(moveDirection);
        }
        else rb.velocity = Vector3.zero;
    }
}
