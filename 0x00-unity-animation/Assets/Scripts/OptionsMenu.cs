using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OptionsMenu : MonoBehaviour
{
    
    public bool isInverted = true;
    public Toggle invert;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Back()
    {
        int prevScene = PlayerPrefs.GetInt("PrevScene");
        SceneManager.LoadScene(prevScene);
        Time.timeScale = 1f;
        

    }

    public void Apply()
    {

        if (invert.isOn == true)
        {
            Debug.Log("invert = true / isInverted set to 1");
            PlayerPrefs.SetInt("isInverted", 1);
        }

        else if (invert.isOn == false)
        {
            Debug.Log("invert = false / isInverted set to 0");
            PlayerPrefs.SetInt("isInverted", 0);
        }

        Back();
    }

    
}
