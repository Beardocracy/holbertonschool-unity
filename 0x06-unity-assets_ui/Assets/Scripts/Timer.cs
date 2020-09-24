using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

/// <summary>
/// Running timer.
/// </summary>
public class Timer : MonoBehaviour
{
    private float timer = 0f;
    public Text timerText;
    public Text winText;
    public GameObject winCanvas;
    
    // Update is called once per frame
    void Update()
    {
        if (winCanvas.activeSelf == false)
        {
            timer += Time.deltaTime;
            string min = String.Format("{0:0}", timer / 60);
            string sec = String.Format("{0:00}", timer % 60);
            string msec = String.Format("{0:.00}", timer % 1);
            timerText.text = min + ":" + sec + msec;
        }
        else
            Win();
    }

    /// <summary>
    /// Enables the win canvas.
    /// </summary>
    public void Win()
    {
        timerText.text = "";
        timer += Time.deltaTime;
        string min = String.Format("{0:0}", timer / 60);
        string sec = String.Format("{0:00}", timer % 60);
        string msec = String.Format("{0:.00}", timer % 1);
        //winText.text = "Test";
        winText.text = min + ":" + sec + msec;
        this.GetComponent<Timer>().enabled = false;
    }
}