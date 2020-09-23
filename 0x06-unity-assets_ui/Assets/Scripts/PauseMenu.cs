using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeSelf == false)
            {
                this.GetComponent<Timer>().enabled = false;
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                this.GetComponent<Timer>().enabled = true;
            }
        }
    }
}
