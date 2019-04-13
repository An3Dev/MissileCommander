using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCollision : MonoBehaviour {

    public ParticleSystem explosionPrefab;
    Rigidbody2D rb;
    CameraFollowMissile cameraFollowMissile;
    MissileExhaustControl missileExhaustControl;
    Animator canvasAnimator;

    public bool gameOver = false;

    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        cameraFollowMissile = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollowMissile>();
        missileExhaustControl = GetComponentInChildren<MissileExhaustControl>();
        canvasAnimator = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Booster")
        {
            BoostMissile();
        }

        if (collision.tag == "AntiBooster")
        {
            SlowDownMissile();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

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
        missileExhaustControl.StartBoosting();
    }

    void SlowDownMissile()
    {
        missileExhaustControl.StopBoost();
    }

    
}
