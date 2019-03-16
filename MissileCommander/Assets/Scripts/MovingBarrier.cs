using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBarrier : MonoBehaviour {

    public bool movingRight = true;
    
    public float speed;
    Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (movingRight)
        {
            rb.velocity = rb.transform.right * speed;
            //Debug.Log("Right");
        }

        if (!movingRight)
        {
            rb.velocity = -rb.transform.right * speed;
            //Debug.Log("Left");
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.tag == "DestroyMissile")
        {
            switch(movingRight)
            {
                case false:
                    movingRight = true;
                    break;

                case true:
                    movingRight = false;
                    break;

                default:
                    movingRight = true;
                    break;
            }
            
        }

        
    }
}
