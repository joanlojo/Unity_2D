using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public Our_Vector3 velocityP, gravity, Welocity, tau;
    public GameObject pelota;
    // Use this for initialization
    void Start()
    {
        velocityP = GameObject.Find("Pelota").GetComponent<BallPhysics>().lVelocityInit;
        gravity = GameObject.Find("Pelota").GetComponent<BallPhysics>().fGravity;
        Welocity = GameObject.Find("Pelota").GetComponent<BallPhysics>().wVelocity;
        tau = GameObject.Find("Pelota").GetComponent<BallPhysics>().fTau;
    }

    // Update is called once per frame
    void Update()
    {



    }
}
