using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBarrier : MonoBehaviour {

    public GameObject breakableBarrierExplosionPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject explosion = Instantiate(breakableBarrierExplosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, 3);
        Destroy(gameObject);
        
    }
}
