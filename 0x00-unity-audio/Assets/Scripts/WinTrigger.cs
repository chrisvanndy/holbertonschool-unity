using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// WinTrigger moniters a trigger event between Player and the Win Flag Obj at the end of the level.
/// <summary>

public class WinTrigger : MonoBehaviour
{
   
    public GameObject player;
    public GameObject flag;
    public GameObject winCanvas;
    public GameObject timerCanvas;
    private Rigidbody fl;
    public Text TimerText;
    public Text winText;
    public AudioSource sting;
    public AudioSource bgm;

    
    

    // Start is called before the first frame update
    void Start()
    {
        fl = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            // Stop "stop watch".
            player.GetComponent<Timer>().StopWatch = false;
            player.GetComponent<Timer>().Win();
            timerCanvas.SetActive(false);
            winCanvas.SetActive(true);
            bgm.Stop();
            sting.Play();
            Time.timeScale = 0f;
            Debug.Log("WIN CANVAS should be TRUE");

            // First Gen Actions for TimerText Obj 
                // Debug.Log("YOU WIN");
                //TimerText.color = Color.green;
                //TimerText.fontStyle = FontStyle.Bold;
                //TimerText.fontSize = 80;
            
        }
    }
}
