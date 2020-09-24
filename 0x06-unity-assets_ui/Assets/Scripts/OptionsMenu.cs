using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public Toggle yToggle;

    public void Start()
    {
        if (PlayerPrefs.HasKey("isInverted"))
        {
            if (PlayerPrefs.GetInt("isInverted") == 1)
                yToggle.isOn = true;
            else
                yToggle.isOn = false;
        }
        
    }
    /// <summary>
    /// Applies changes and returns to previous scene.
    /// </summary>
    public void Apply()
    {
        if (yToggle.isOn == true)
            PlayerPrefs.SetInt("isInverted", 1);
        else
            PlayerPrefs.SetInt("isInverted", 0);

        SceneManager.LoadScene(PlayerPrefs.GetString("prevScene"));
    }

    /// <summary>
    /// Loads the previous scene.
    /// </summary>
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("prevScene"));
    }
}
