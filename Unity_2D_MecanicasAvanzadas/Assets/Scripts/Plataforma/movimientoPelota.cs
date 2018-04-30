using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPelota : MonoBehaviour {

    public bool jump = false;

    public float Force = 365f;
    public float salto = 1000f;
    private float speed = 7.5f;
    bool doublejump;
    //float distGround;
    public Rigidbody2D rb;
    int jumps;
    public int maxjumps = 2;
    private bool isGrounded;
    // Use this for initialization
    void Start()
    {
        doublejump = false;
        isGrounded = true;
        //distGround = Vector2.Distance(transform.position, collider2D.transform.position);
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 movement = new Vector2(1.0f, 0.0f);


        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = speed +2;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed = speed - 2;
        }
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            Jump();
        }
        if(speed > 12)
        {
            speed = 12;
        }
        if(speed < 4)
        {
            speed = 4;
        }
    }

    void Jump() { 
   
        if (jumps > 0)
        {
            rb.velocity = new Vector2(0f, salto);
            isGrounded = false;
            jumps = jumps - 1;
        }
        if (jumps == 0)
        {
            return;
        }
    }
    void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.tag == "Suelo")
        {
            jumps = maxjumps;
            isGrounded = true;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tierra")
        {
            speed = speed - 2;
        }
        if (collision.tag == "Agua")
        {
            speed = speed + 2;
        }
    }

}
