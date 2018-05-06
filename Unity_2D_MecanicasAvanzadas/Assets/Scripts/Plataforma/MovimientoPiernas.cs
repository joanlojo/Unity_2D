using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPiernas : MonoBehaviour {

    float time;
    public Rigidbody2D rb;
    public int vel;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
      rb.velocity = new Vector2(-vel, 0f);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {

        }
    }

}
