using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool gamePaused;
    public GameObject pauseCanvas;
    public Button resume;
    public Button menu;
    public Button restart;
    public Button options;
    private Timer TimerText;
    public string CurrentScene;
    int level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Escape))
         {
             if(gamePaused)
             {
                 Resume();
             }
             else
             {
                 gamePaused = true;
                 pauseCanvas.SetActive(true);
                 Time.timeScale = 0f;
             }
         }

    }

    public void Pause()
    {
       
    }

    public void Resume()
    {
        gamePaused = false;
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart(int level)
    {
        Time.timeScale = 1f;
       // SceneManager.LoadScene(level);
        SceneManager.LoadScene(CurrentScene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        PlayerPrefs.SetInt("PrevScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }
}

