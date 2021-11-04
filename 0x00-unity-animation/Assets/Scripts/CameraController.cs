using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


// CameraController handles behavior of Main Camera object.
public class CameraController : MonoBehaviour 
{
	public Transform player;
    public Vector3 offsetX;
    public Vector3 offsetY;
    public float turnSpeed = 5.0f;
    public float height = 2.5f;
    public float distance = -6.25f;

    public float rotation = 9.0f;
    public bool isInverted = false;
   
    public CinemachineFreeLook thirdperson;
 
    void Start()
    {
        offsetX = new Vector3 (0, height, distance);
        offsetY = new Vector3 (rotation, 0, 0);

        // sudo for invert 
        // search key isInverted for value associated w variable
        if (PlayerPrefs.GetInt("isInverted") == 1)
            thirdperson.m_YAxis.m_InvertInput = true;
        else 
            thirdperson.m_YAxis.m_InvertInput = false;
        

    }

	// Update is called once per frame
	void FixedUpdate ()
	{
        /*Vector3 camF = thirdperson.forward;
        Vector3 camR = thirdperson.right;

        camF.y = 0;
        camR.y = 0;

        camF = camF.normalized;
        camR = camR.normalized;

        player.position += (camF*input.y + camR.inputx)*Time.deltaTime*5; */

    

        /* if (isInverted == true)
        {
            offsetX = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;

            offsetY = Quaternion.AngleAxis (Input.GetAxis("Mouse Y") * turnSpeed, Vector3.left) * offsetY;
        }
        else
        {
            offsetX = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offsetX;

            offsetY = Quaternion.AngleAxis (Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offsetY;
        } */


		transform.position = player.position + offsetX + offsetY;

        transform.LookAt(player.position);
    
	}
}
