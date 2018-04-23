using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPelota : MonoBehaviour {

    public float speed;
    public float salto;
    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
       // salto = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = new Vector3(1.0f, 0.0f, 0.0f);


      //  if (Input.GetKeyDown(KeyCode.Space)){
        //    movement = new Vector3(speed, salto, 0.0f);
        //}

        rb.velocity = (movement * speed);
    }
}
