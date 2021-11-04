using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneController : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public GameObject timerCanvas;
    public GameObject playCam;
    private GameObject cutSceneCam;

    // Start is called before the first frame update
    void Start()
    {
        cutSceneCam = GameObject.Find("CutsceneCamera");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            // normalizedTime refers to the total length of a given animation 0-1.
            // == 0 animation has not started, > 1 animation has completed
            Debug.Log("Script recognizes Animation");
            timerCanvas.gameObject.SetActive(true);
            player.GetComponent<PlayerController>().enabled = true;
            playCam.gameObject.SetActive(true);
            cutSceneCam.gameObject.SetActive(false);
        }
    }
}
