using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float playerSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // movement in all directions
        rb.velocity = new Vector3(horizontal * playerSpeed, rb.velocity.y, vertical * playerSpeed);
    }
}
