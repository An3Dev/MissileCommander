﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCollision : MonoBehaviour {

    public ParticleSystem explosionPrefab;
    public Rigidbody2D rb;
    public CameraFollowMissile cameraFollowMissile;
    public MissileExhaustControl missileExhaustControl;
    public Animator canvasAnimator;

    public bool gameOver = false;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Booster")
        {
            BoostMissile();
        }

        if (collision.collider.tag == "Target")
        {
            // Disable camera follow to prevent error
            cameraFollowMissile.enabled = false;

            // Freeze missile.
            rb.constraints = RigidbodyConstraints2D.FreezeAll;

            // Make the missile dissappear
            gameObject.SetActive(false);

            // Make the target dissappear
            collision.gameObject.SetActive(false);


            canvasAnimator.SetTrigger("LevelComplete");
        }


        if (collision.collider.tag == "DestroyMissile" && !gameOver)
        {

            gameOver = true;

            // Disable camera follow to prevent error
            cameraFollowMissile.enabled = false;

            // Freeze missile.
            rb.constraints = RigidbodyConstraints2D.FreezeAll;

            // Make the missile dissappear
            gameObject.SetActive(false);

            
            ParticleSystem explosion = (Instantiate(explosionPrefab, collision.GetContact(0).point, Quaternion.identity)).GetComponent<ParticleSystem>();

            explosion.Play();

            canvasAnimator.SetTrigger("GameOver");
        }

    }


    void BoostMissile()
    {
        missileExhaustControl.isBoosting = true;
    }

    
}
