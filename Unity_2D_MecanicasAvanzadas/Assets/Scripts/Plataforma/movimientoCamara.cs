using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCamara : MonoBehaviour {

    public GameObject player;
    public float vel;
    private Vector3 tempVec3 = new Vector3();
    // Use this for initialization
    float offsetX;
	void Start () {
        offsetX = transform.position.x - player.transform.position.x;
    }
	
	// Update is called once per frame
	void LateUpdate () {
       // GameObject.Find("ThePlayer").GetComponent<PlayerScript>().Health
        transform.Translate(Time.deltaTime * vel, 0, 0);
        
    }
}
