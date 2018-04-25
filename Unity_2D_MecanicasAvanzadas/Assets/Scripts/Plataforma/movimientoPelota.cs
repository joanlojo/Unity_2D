using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPelota : MonoBehaviour {

    public bool jump = false;

    public float Force = 365f;
    public float salto = 1000f;
    public float speed = 5f;
    bool doublejump;
    //float distGround;
    private Rigidbody2D rb;
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

        if (movement.x * rb.velocity.x < speed)
        {
            rb.AddForce(Vector2.right * movement.x * Force);
        }
        if (Mathf.Abs(rb.velocity.x) > speed)
        {
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * speed, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            Jump();

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
           // movespeed = 2.0F;

        }
    }
   /*         void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            isGrounded = true;
        }
    }*/
}
