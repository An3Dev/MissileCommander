using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingObjects : MonoBehaviour {

    public Animator animator;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetTrigger("Slide");
    }
}
