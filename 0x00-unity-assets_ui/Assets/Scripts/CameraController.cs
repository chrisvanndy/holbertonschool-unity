using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CameraController handles behavior of Main Camera object.
public class CameraController : MonoBehaviour 
{
	public Transform player;
    public Vector3 offsetX;
    public Vector3 offsetY;
    public float turnSpeed = 10.0f;
    public float height = 2.5f;
    public float distance = -6.25f;
    public bool isInverted = false;
   


    void Start()
    {
        offsetX = new Vector3 (0, height, distance);
        offsetY = new Vector3 (0, 0, distance);
        

    }

	// Update is called once per frame
	void Update ()
	{

        if (isInverted == true)
        {
            offsetX = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;

            offsetY = Quaternion.AngleAxis (Input.GetAxis("Mouse Y") * turnSpeed, Vector3.left) * offsetY;
        }
        else
        {
            offsetX = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;

            offsetY = Quaternion.AngleAxis (Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offsetY;
        }


		transform.position = player.position + offsetX + offsetY;

        transform.LookAt(player.position);
    
	}
}
