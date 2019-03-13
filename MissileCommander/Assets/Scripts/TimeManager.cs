using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    //public Behaviour[] scriptsToDisable;

    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StopTime()
    {
        //for(int i = 0; i < scriptsToDisable.Length; i++)
        //{
        //    scriptsToDisable[i].enabled = false;

        //}
        if (rb != null)
        {
            rb.simulated = false;

        }
    }

    public void StartTime()
    {
        //for (int i = 0; i < scriptsToDisable.Length; i++)
        //{
        //    scriptsToDisable[i].enabled = true;

        //}

        if (rb != null)
        {
            rb.simulated = true;

        }
        
    }
}
