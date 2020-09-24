using UnityEngine;

/// <summary>
/// Rotates the player.
/// </summary>
public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 2.0f;
    public GameObject pauseMenu;
    public GameObject player;
    public bool isInverted = false;


    private Vector3 offset;
    private float distance;
    private float xCoord = 0f;
    private float yCoord = 0f;

           
    void Start()
    {
        offset = transform.position - player.transform.position;
        distance = Vector3.Distance(transform.position, player.transform.position);
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        if (pauseMenu.activeSelf == true)
            return;
        
        xCoord += Input.GetAxis("Mouse X") * rotationSpeed;
        
        CheckInversion();
        if (isInverted == true)
            yCoord += Input.GetAxis("Mouse Y") * rotationSpeed;
        else
            yCoord -= Input.GetAxis("Mouse Y") * rotationSpeed;

        yCoord = Mathf.Clamp(yCoord, 0f, 80f);

        Vector3 direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(yCoord, xCoord, 0);
        transform.position = player.transform.position + rotation * direction;

        transform.LookAt(player.transform.position);
    }

    private void CheckInversion()
    {
        if (PlayerPrefs.HasKey("isInverted"))
        {
            if (PlayerPrefs.GetInt("isInverted") == 0)
                isInverted = false;
            else
                isInverted = true;
        }
    }
}
