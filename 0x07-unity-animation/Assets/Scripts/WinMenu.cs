using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinMenu : MonoBehaviour
{
    /// <summary>
    /// Loads the main menu.
    /// </summary>
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /// <summary>
    /// Loads the next scene or main menu.
    /// </summary>
    public void Next()
    {
        //Debug.Log(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "Level01") {
            //Debug.Log("Why not here");
            SceneManager.LoadScene("Level02");
        } else if (SceneManager.GetActiveScene().name == "Level02") {
            SceneManager.LoadScene("Level03");
        }
        else {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
