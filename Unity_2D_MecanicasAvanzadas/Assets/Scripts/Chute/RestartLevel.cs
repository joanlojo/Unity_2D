using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

    public Transform pelota;
    public string levelName;
    public Our_Vector3 velocityP, gravity, Welocity, tau;
    // Use this for initialization
    void Start () {
        velocityP = GameObject.Find("Pelota").GetComponent<BallPhysics>().lVelocityInit;
        gravity = GameObject.Find("Pelota").GetComponent<BallPhysics>().fGravity;
        Welocity = GameObject.Find("Pelota").GetComponent<BallPhysics>().wVelocity;
        tau = GameObject.Find("Pelota").GetComponent<BallPhysics>().fTau;
    }
	
	// Update is called once per frame
	void Update () {
        if (levelName == "Start")
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SceneManager.LoadScene("Main");
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
