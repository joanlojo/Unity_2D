﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKickPosition : MonoBehaviour {

	public GameObject newPelota;
    public GameObject VectorDireccion;
	private RaycastHit colision;
    public Our_Vector3 fromBallCoordinates = new Our_Vector3(0, 0, 0);

    void Start () {
        //getKickPosition = GameObject.Find("ScriptsObject").GetComponent<GetKickPosition>().fromBallCoordinates; //Punto de impacto a la pelota respecto a su centro
    }
	
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray, out colision)) {
				newPelota.transform.position = colision.point;
                //Coordenadas del click respecto a la pelota.
                fromBallCoordinates.x = newPelota.transform.position.x - colision.transform.position.x;
                fromBallCoordinates.y = newPelota.transform.position.y - colision.transform.position.y;
                fromBallCoordinates.z = newPelota.transform.position.z - colision.transform.position.z;
			}
		}

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Our_Vector3 rot = new Our_Vector3(0, 0.01f, 0);
            VectorDireccion.transform.Translate(rot);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Our_Vector3 rot = new Our_Vector3(0, -0.01f, 0);
            VectorDireccion.transform.Translate(rot);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Our_Vector3 rot = new Our_Vector3(0 , 0, -0.01f);
            VectorDireccion.transform.Translate(rot);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Our_Vector3 rot = new Our_Vector3( 0, 0, 0.01f);
            VectorDireccion.transform.Translate(rot);
        }
    }
}
