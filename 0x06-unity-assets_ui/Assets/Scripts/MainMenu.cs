using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// Loads a level.
    /// </summary>
    public void LevelSelect(int level)
    {
        //Debug.Log("You want to load level " + level.ToString());
        
        switch (level)
        {
            case 1:
                PlayerPrefs.SetString("prevScene", "Level01");
                SceneManager.LoadScene("Level01");
                break;
            case 2:
                PlayerPrefs.SetString("prevScene", "Level02");
                SceneManager.LoadScene("Level02");
                break;
            case 3:
                PlayerPrefs.SetString("prevScene", "Level03");
                SceneManager.LoadScene("Level03");
                break;
        }
    }

    /// <summary>
    /// Loads the options menu scene.
    /// </summary>
    public void Options()
    {
        PlayerPrefs.SetString("prevScene", "MainMenu");
        SceneManager.LoadScene("Options");
    }

    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}