using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMissile : MonoBehaviour {

    
    Transform missile;
    float smoothness = 0.1f;
	// Use this for initialization
	void Start () {
         missile = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(missile.transform.position.x, missile.transform.position.y, -10);
        //if (missile)
        //{
        //    Vector3 from = transform.position;
        //    Vector3 to = missile.position;
        //    to.z = transform.position.z;

        //    transform.position -= (from - to);
        //}

    }
}
