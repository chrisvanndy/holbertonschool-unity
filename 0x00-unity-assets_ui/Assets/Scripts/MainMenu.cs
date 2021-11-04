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
        PlayerPrefs.SetInt("PrevScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(level);
    }

    public void Options()
    {
        PlayerPrefs.SetInt("PrevScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        Debug.Log("Application Quit.");
        Application.Quit();
    }
}