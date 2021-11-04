using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public float inputX;
    public float inputY;
    public float jumping;
    public bool isRunning = false;
    public bool isJumping = false;
    public bool isFalling = false;


    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        jumping = Input.GetAxis("Jump");
        
        PlayerController pControl = player.GetComponent<PlayerController>();

        // Running Animation
        if (inputX != 0 || inputY != 0)
        {
            anim.SetBool("isRunning", true);
        }

        if (inputX == 0 && inputY == 0)
        {
            anim.SetBool("isRunning", false);
        }
        
        // Jumping Animation
        if (pControl.grounded == false)
        {
            // isJumping = true;
            anim.SetBool("isJumping", true);
        }

        else
        {
            anim.SetBool("isJumping", false);
        }

        // Falling Animation
        if (player.transform.position.y < -14)
        {
            Debug.Log("Player should be falling");
            // isfalling = true;
            anim.SetBool("isFalling", true);

        }

        if (pControl.grounded == true)
        {
            anim.SetBool("isFalling", false);
        }

    }
}
