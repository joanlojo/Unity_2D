using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    Scene currScene;
    string nameScene;
    // Use this for initialization
    void Start()
    {
        currScene = SceneManager.GetActiveScene();
        nameScene = currScene.name;
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(nameScene == "lvl_tutorial")
            {
                SceneManager.LoadScene("Main");
            }
            if(nameScene == "lvl_2")
            {
                SceneManager.LoadScene("Main 1");
            }
        }
    }
}
