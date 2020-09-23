using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    /// <summary>
    /// Loads the previous scene.
    /// </summary>
    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
