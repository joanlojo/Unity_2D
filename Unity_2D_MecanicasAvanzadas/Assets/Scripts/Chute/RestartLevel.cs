using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

    public Transform pelota;
    public string levelName;
    Scene currScene;
    string nameScene;
    public Our_Vector3 velocityP, gravity, Welocity, tau;
    // Use this for initialization
    void Start () {
        velocityP = GameObject.Find("Pelota").GetComponent<BallPhysics>().lVelocityInit;
        gravity = GameObject.Find("Pelota").GetComponent<BallPhysics>().fGravity;
        Welocity = GameObject.Find("Pelota").GetComponent<BallPhysics>().wVelocity;
        tau = GameObject.Find("Pelota").GetComponent<BallPhysics>().fTau;
        currScene = SceneManager.GetActiveScene();
        nameScene = currScene.name;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            if (nameScene == "Main")
            {
                SceneManager.LoadScene("Main");
            }
            if (nameScene == "Main 1")
            {
                SceneManager.LoadScene("Main 1");
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    
}
