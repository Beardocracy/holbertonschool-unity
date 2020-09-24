using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Starts the timer once the player moves.
/// </summary>
public class TimerTrigger : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Contact");
    }
    
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Exit");
        player.GetComponent<Timer>().enabled = true;
    }
}
