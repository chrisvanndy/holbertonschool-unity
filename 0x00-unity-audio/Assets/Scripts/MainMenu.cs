using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSelect(int level)
    {
        // store build index of current screen into var "previous scene" when entering level
        PlayerPrefs.SetInt("PrevScene", SceneManager.GetActiveScene().buildIndex);
        // load build index of level passed to LevelSelect func
        SceneManager.LoadScene(level);
    }

    public void Options()
    {
        // store build index of current screen into var "previous scene" when entering OptionsMenu 
        PlayerPrefs.SetInt("PrevScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        Debug.Log("Application Quit.");
        Application.Quit();
    }
}