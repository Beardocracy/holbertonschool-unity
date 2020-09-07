using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public float rotationSpeed = 5.0f;
    
    [Range(0.01f, 1.0f)]
    public float smoothness = 0.5f;
    
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Quaternion camAngleX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
        offset = camAngleX * offset;

        Vector3 newPos = player.transform.position + offset;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothness);

        transform.LookAt(player.transform.position);
    }
}
