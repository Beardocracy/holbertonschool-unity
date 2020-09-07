using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 900f;
    public float jumpHeight = 200f;
    public Transform camTransform;
    private int contact = 0;
    
    // Called once per frame.
    void FixedUpdate()
    {
        
        Vector3 movement = Vector3.zero;
        if (Input.GetKey("d"))
        {
            movement += camTransform.right;
            movement *= speed * Time.deltaTime;
            movement.y = 0f;
        }      
        if (Input.GetKey("a"))
        {
            movement += -camTransform.right;
            movement *= speed * Time.deltaTime;
            movement.y = 0f;
        }
        if (Input.GetKey("w"))
        {
            movement += camTransform.forward;
            movement *= speed * Time.deltaTime;
            movement.y = 0f;
        }
        if (Input.GetKey("s"))
        {
            movement += -camTransform.forward;
            movement *= speed * Time.deltaTime;
            movement.y = 0f;
        }
        if(Input.GetKey("space") && contact > 0)
        {
            movement.y = jumpHeight;
        }
        rb.AddForce(movement);
    }

    // Checks if player is in contact with something.
    private void OnCollisionEnter(Collision other)
    {
        contact += 1;
    }
    private void OnCollisionExit(Collision other)
    {
        contact -= 1;
    }
}