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

    public GameObject m_camera;
    public GameObject pauseMenu;

    CharacterController _characterController;
    Vector3 _moveDirection;

    void Awake() => _characterController = GetComponent<CharacterController>();
    
    private void FixedUpdate()
    {
        if (pauseMenu.activeSelf == true)
            return;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontal, 0, vertical);
        Vector3 transformDirection = m_camera.transform.TransformDirection(inputDirection);

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
}