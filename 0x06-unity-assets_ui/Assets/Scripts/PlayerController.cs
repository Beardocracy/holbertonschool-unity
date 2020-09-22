using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls player movement.
/// </summary>
public class PlayerController : MonoBehaviour
{
    public float _gravity = 1f;
    public float _speed = 20f;
    public float _jumpHeight = 2f;

    CharacterController _characterController;
    Vector3 _moveDirection;

    void Awake() => _characterController = GetComponent<CharacterController>();
    
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontal, 0, vertical);
        Vector3 transformDirection = transform.TransformDirection(inputDirection);

        Vector3 flatMovement = _speed * Time.deltaTime * transformDirection;

        _moveDirection = new Vector3(flatMovement.x, _moveDirection.y, flatMovement.z);

        if (_characterController.isGrounded && Input.GetKey(KeyCode.Space))
            _moveDirection.y = _jumpHeight;
        else if (_characterController.isGrounded)
            _moveDirection.y = 0f;
        else
            _moveDirection.y -= _gravity * Time.deltaTime;

        _characterController.Move(_moveDirection);

        if (transform.position.y < -10)
            transform.position = new Vector3(0f, 25f, 0f);
    }
       /* 
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
        //transform.position += movement;

        // Drops player back in starting position
        if (transform.position.y < -10)
        {
            rb.velocity = Vector3.zero;
            transform.position = new Vector3(0f, 12.5f, 0f);
        }
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
*/
}