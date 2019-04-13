using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileControls : MonoBehaviour {

    public Rigidbody2D rb;
    public float rotationalForce = 20;
    public float forwardForce = 10;
	// Use this for initialization
	void Start () {
		
	}

    public void FixedUpdate()
    {
        rb.velocity = rb.transform.right * forwardForce;
        
    }

    // Update is called once per frame
    void Update () {
        

        // Move to left
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            rb.MoveRotation(rb.rotation + Input.GetAxisRaw("Horizontal") * -rotationalForce * Time.deltaTime);
            
        } 
        //// Move to right
        //if (Input.GetAxisRaw("Horizontal") == 1)
        //{
        //    rb.MoveRotation(rb.rotation + -rotationalForce * Time.deltaTime);
            

        //}

        // If touch detected
        if (Input.touchCount > 0)
        {
            // if touch started
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                TouchControls();

            }

            // if touch started
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                TouchControls();

            }

            // if touch started
            if (Input.GetTouch(0).phase != TouchPhase.Ended)
            {
                TouchControls();
            }


        }
	}

    void TouchControls()
    {
        // If touch is on left side of screen
        if (Input.GetTouch(0).position.x < Screen.width / 2)
        {
            // Apply rotation force to right
            
            rb.MoveRotation(rb.rotation + rotationalForce * Time.deltaTime);
            //rb.AddForce(rb.transform.right * forwardForce);
        }

        // If touch is on right side of screen
        if (Input.GetTouch(0).position.x > Screen.width / 2)
        {
            // Apply rotation force to left
            
            rb.MoveRotation(rb.rotation + -rotationalForce * Time.deltaTime);


            //rb.AddForce(rb.transform.right * forwardForce);

        }
    }
}
