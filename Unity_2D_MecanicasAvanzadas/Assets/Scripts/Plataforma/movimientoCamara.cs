using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCamara : MonoBehaviour {

    public GameObject player;
    private Vector3 tempVec3 = new Vector3();
    // Use this for initialization
    float offsetX;
	void Start () {
        offsetX = transform.position.x - player.transform.position.x;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(player.transform.position.x + offsetX, 0.65f, -12f);
        
    }
}
