using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// PlayerController Handles behaviors of Player Object
/// <summary>
public class PlayerController : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    public Transform spawnPoint;
    public float speed = 10.0f;
    public float jump = 15.0f;
    public bool grounded;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        grounded = true;
        Time.timeScale = 1f;
    }

    /// <summary>
    /// FixedUpdate is called every fixed framerate frame, if MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        if (grounded == true)
        {
            float moveH = Input.GetAxisRaw ("Horizontal");
            float moveV = Input.GetAxisRaw ("Vertical");
            float moveJ = Input.GetAxisRaw ("Jump");

            rb.velocity = new Vector3(moveH * speed, moveJ * jump, moveV* speed); 

            Vector3 movement = new Vector3(moveH, 0.0f, moveV);
            //transform.rotation = Quaternion.LookRotation(movement);

            if (rb.velocity != Vector3.zero)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.2f);
                
            }
        }
        /*
        CharacterController charCon = GetComponent<CharacterController>();
        if (grounded == true)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
            if (Input.GetButton("Jump"))
                moveDir.y = jump;
        }    
        moveDir.y -= gravity * Time.deltaTime;
        charCon.Move(moveDir * Time.deltaTime);
        */
    }

    void Update()
    {
        // if the player's Y position is less than -15, return to players spawnPoint.
        if (player.transform.position.y < -15)
        {
            rb.velocity = new Vector3(0, 0, 0);
            player.transform.position = spawnPoint.transform.position;

        }
    
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="floor")
            grounded = true;
        /* if (other.gameObject.tag=="Obstacle")
           grounded = true; */
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag=="floor")
            grounded = false;
        /* if (other.gameObject.tag=="Obstacle")
            grounded = false; */
    }

}