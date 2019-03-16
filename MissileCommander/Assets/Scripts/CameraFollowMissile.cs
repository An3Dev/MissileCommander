using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMissile : MonoBehaviour {

    
    public Transform missile;
    public Rigidbody2D rb;
    public float smoothness = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (missile)
        {
            Vector3 from = transform.position;
            Vector3 to = missile.position;
            to.z = transform.position.z;

            transform.position -= (from - to);
        }

    }
}
