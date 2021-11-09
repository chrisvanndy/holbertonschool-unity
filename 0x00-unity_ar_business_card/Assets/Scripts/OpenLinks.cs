using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLinks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EmailMe()
    {
        Application.OpenURL("mailto:chrisvanndy@gmail.com");
    }

    public void Linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/christopher-vandenhende-3a719054/");
    }

    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/chrisvanndy/");
    }

    public void Github()
    {
        Application.OpenURL("https://github.com/chrisvanndy");
    }
}


