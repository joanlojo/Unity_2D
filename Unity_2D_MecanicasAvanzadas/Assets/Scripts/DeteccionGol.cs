using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeteccionGol : MonoBehaviour {
    Scene currScene;
    string nameScene;
    // Use this for initialization
    void Start () {
        currScene = SceneManager.GetActiveScene();
        nameScene = currScene.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "VAR")
        {
           // Debug.Log("hola");
            if (nameScene == "Main")
            {
                SceneManager.LoadScene("Loading1");
            }
            if (nameScene == "Main 1")
            {
                SceneManager.LoadScene("Loading2");
            }
        }
    }

}
