using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    //public Behaviour[] scriptsToDisable;

    Rigidbody2D rb;

    float timeScale = 1;
	// Use this for initialization
	void Start () {
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        StartTime();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale != 0)
        {
            Time.timeScale = timeScale;
        }
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

            Time.timeScale = 0;
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
            Time.timeScale = timeScale;
        }
        
    }
}
