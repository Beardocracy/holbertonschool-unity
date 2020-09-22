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
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        string min = String.Format("{0:0}", timer / 60);
        string sec = String.Format("{0:00}", timer % 60);
        string msec = String.Format("{0:.00}", timer % 1);
        timerText.text = min + ":" + sec + msec;
    }
}