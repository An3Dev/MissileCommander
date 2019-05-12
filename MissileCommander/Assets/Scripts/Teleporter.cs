using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    private Transform exitPortal;

	// Use this for initialization
	void Start () {
        // Exit portal needs to be the second child
        exitPortal = transform.parent.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.parent.transform.position = exitPortal.position;
        Debug.Log(collision.transform);
    }
}
