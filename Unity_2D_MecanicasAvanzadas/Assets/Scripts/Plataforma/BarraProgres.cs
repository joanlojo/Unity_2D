﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraProgres : MonoBehaviour {

    public float barDisplay; //current progress
    public Vector2 pos = new Vector2(20, 40);
    public Vector2 size = new Vector2(60, 20);
    public GameObject end;
    public Texture2D emptyTex;
    public Texture2D fullTex;
    public GameObject Player;
    float posX;

    private void Start()
    {
        posX = Player.transform.position.x;
        //Player = GetComponent<GameObject>();
    }

    void OnGUI()
    {
        //draw the background:
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), emptyTex);

        //draw the filled-in part:
        GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), fullTex);
        GUI.EndGroup();
        GUI.EndGroup();
    }

    void Update()
    {
        //for this example, the bar display is linked to the current time,
        //however you would set this value based on your desired display
        //eg, the loading progress, the player's health, or whatever.
        barDisplay = ((posX + end.transform.position.x) - Player.transform.position.x) / end.transform.position.x;
        //Debug.Log(Player.transform.position.x);
        //        barDisplay = MyControlScript.staticHealth;
    }
}
