using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoPiernas : MonoBehaviour {

    float time;
    public float maxTime;
    public Rigidbody2D rb;
    public int salto;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if (time >= maxTime)
        {
            rb.velocity = new Vector2(0f, salto);
            time = 0;
        }
    }
}
