using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
    
    public Text TimerText;
    public  Text winText;
    
    int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        winText = TimerText;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Next(int level)
    {
        if (level == 3)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
            SceneManager.LoadScene(level + 1);
    }
}
