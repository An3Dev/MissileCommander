using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissile : MonoBehaviour {

    Rigidbody2D rb;
    public float forwardForce = 10;
    public float rotatingForce = 100;
    Transform player;
    Quaternion rotateToTarget;
    Vector3 dir;

    public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}

    public void Update()
    {
        if (player.gameObject == null)
        {
            Explode();
        }
    }

    void FixedUpdate()
    {
        dir = (player.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rotateToTarget = Quaternion.AngleAxis(angle, Vector3.forward);
        rb.MoveRotation(Quaternion.Slerp(transform.rotation, rotateToTarget, Time.deltaTime * rotatingForce).eulerAngles.z);
        //rb.velocity = new Vector2(dir.x * forwardForce, dir.y * forwardForce);
        rb.velocity = transform.right * forwardForce;


        //rb.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotatingForce);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void Explode()
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
