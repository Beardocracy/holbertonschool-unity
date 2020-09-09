using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Stops timer when victory is achieved.
/// </summary>
public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text timerText;
   
    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<Timer>().enabled = false;
        timerText.color = Color.green;
        timerText.fontSize = 60;
    }
}
