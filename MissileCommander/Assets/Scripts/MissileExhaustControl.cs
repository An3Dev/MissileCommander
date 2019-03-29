using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileExhaustControl : MonoBehaviour {

    public ParticleSystem exhaust;
    public MissileControls missileControls;
    public bool isBoosting = false;

    public float boostTime = 5;

    bool modifiedSpeed = false;
    float timeBoosting;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timeBoosting >= boostTime)
        {
            missileControls.forwardForce /= 2;
            missileControls.rotationalForce /= 2;

            isBoosting = false;
            timeBoosting = 0;
            modifiedSpeed = false;
        }

		if (isBoosting)
        {
            timeBoosting += Time.deltaTime;

            if (!modifiedSpeed)
            {
                missileControls.forwardForce *= 2;
                missileControls.rotationalForce *= 2;
                modifiedSpeed = true;
            }
        }
	}
}
