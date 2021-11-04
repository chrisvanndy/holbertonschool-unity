using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScene : MonoBehaviour
{
    public string CurrentScene;

    //To access playerprefs an instance must be created
    void Start()
    {
        //set string with relevant (keyname, value)
        PlayerPrefs.SetString("currentScene", "CurrentScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
