using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 5.0f;
           
        // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        
        transform.Rotate(horizontal * rotationSpeed * Vector3.up, Space.World);
    }
}
