using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWindmill : MonoBehaviour {

    public float spinSpeed = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale != 0)
        {
            transform.Rotate(new Vector3(0, 0, spinSpeed * Time.deltaTime));

        }
    }
}
