using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
                Pause();
                
            }
            else
            {
                Resume();
            }
        }
    }

    /// <summary>
    /// Pauses the game.
    /// </summary>
    public void Pause()
    {
        this.GetComponent<Timer>().enabled = false;
        pauseMenu.SetActive(true);
    }

    /// <summary>
    /// Resumes the game.
    /// </summary>
    public void Resume()
    {
        pauseMenu.SetActive(false);
        this.GetComponent<Timer>().enabled = true;
    }

    /// <summary>
    /// Restarts the game.
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Loads the main menu.
    /// </summary>
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /// <summary>
    /// Loads the options menu.
    /// </summary>
    public void Options()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        PlayerPrefs.SetString("prevScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
