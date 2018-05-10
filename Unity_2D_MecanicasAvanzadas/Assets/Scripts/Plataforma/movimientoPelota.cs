using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimientoPelota : MonoBehaviour {

    public bool jump = false;

    public float Force = 365f;
    public float salto = 1000f;
    private float speed = 7.5f;
    public GameObject enemys;
    private float maxSpeed;
    private float minSpeed;
    bool doublejump;
    Scene currScene;
    string nameScene;
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
        currScene = SceneManager.GetActiveScene();
        nameScene = currScene.name;
    }
    void Update()
    {
        if (nameScene == "lvl_tutorial")
        {
            maxSpeed = 12;
            minSpeed = 6;
        }
        if (nameScene == "lvl_2")
        {
            maxSpeed = 16;
            minSpeed = 2;
        }

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

        if (Input.GetKeyDown(KeyCode.G))
        {
            enemys.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            enemys.SetActive(true);
        }

        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }
        if(speed < minSpeed)
        {
            speed = minSpeed;
        }
    }

    void Jump() { 
   
        if (jumps > 0)
        {
            rb.velocity = new Vector2(0f, salto);
            SoundManager.PlaySound("bote");
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
