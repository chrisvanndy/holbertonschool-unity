using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Text TimerText;
    public Text winText;
    public float currentTime;
    public bool StopWatch = false;

    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = "0:00.00";
        currentTime = 0;
    }

    void Update()
    {
        if (StopWatch == true)
        {
            currentTime += Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);

        TimerText.text = time.ToString(@"m\:ss\.ff");
    }

    public void StartTime()
    {
        StopWatch = true;
    }

    public void StopTime()
    {
        StopWatch = false;
    }

    public void Win()
    {
        winText.text = TimerText.text;
    }

}
