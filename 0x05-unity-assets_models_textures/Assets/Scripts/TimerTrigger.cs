using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionExit(Collision other)
    {
        player.GetComponent<Timer>().enabled = true;
    }
}
