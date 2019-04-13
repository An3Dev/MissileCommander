using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileExhaustControl : MonoBehaviour
{

    public ParticleSystem exhaust;
    public MissileControls missileControls;
    

    public float boostTime = 5;

    bool startedBoost = false;
    bool stoppedBoost = false;
    float timeBoosting;
    // Use this for initialization
    void Start()
    {

    }

    public void StartBoosting()
    {
        if (!startedBoost)
        {
            missileControls.forwardForce *= 2;
            missileControls.rotationalForce *= 2;
            startedBoost = true;
            stoppedBoost = false;
        }
    }

    public void StopBoost()
    {
        if (!stoppedBoost)
        {
            missileControls.forwardForce /= 2;
            missileControls.rotationalForce /= 2;

            startedBoost = false;
            stoppedBoost = true;
        }
       
    }
}
