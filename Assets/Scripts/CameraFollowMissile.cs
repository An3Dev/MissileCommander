using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMissile : MonoBehaviour {

    public Transform missile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(missile.position.x, missile.position.y, -10);
	}
}
