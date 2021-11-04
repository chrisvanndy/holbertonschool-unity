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
            rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Jump") * jump, Input.GetAxis("Vertical") * speed);
        }            
        // removing old version of adding movement / forces
         /* if (Input.GetKey("a") || Input.GetKey("left")) 
		 {
			  player.AddForce(-speed * Time.deltaTime, 0, 0);
		 }
		 if (Input.GetKey("d") || Input.GetKey("right"))
		 {
			  player.AddForce(speed * Time.deltaTime, 0, 0);
		 }
		 if (Input.GetKey("w") || Input.GetKey("up"))
		 {
			  player.AddForce(0, 0, speed * Time.deltaTime);
		 }
		 if (Input.GetKey("s") || Input.GetKey("down"))
		 {
			  player.AddForce(0, 0, -speed * Time.deltaTime);
		 }
         if (Input.GetKey("space"))
         {
            player.AddForce(0, jump, 0); */

    }

    void Update()
    {
        // if the player's Y position is less than -15, return to players spawnPoint.
        if (player.transform.position.y < -15)
        {
            rb.velocity = new Vector3(0, 0, 0);
            player.transform.position = spawnPoint.transform.position;
            // rb.velocity = new Vector3(0, 0, 0);
              
        }
    
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="floor")
            grounded = true;
        if (other.gameObject.tag=="Obstacle")
           grounded = true;
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag=="floor")
            grounded = false;
        if (other.gameObject.tag=="Obstacle")
            grounded = false;
    }

}