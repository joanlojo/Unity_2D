using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public static AudioClip jump, end;
    static AudioSource AS;
    // Use this for initialization
	void Start () {
        jump = Resources.Load<AudioClip>("bote");
        end = Resources.Load<AudioClip>("pito");
        AS = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "pito":
                AS.PlayOneShot(end);
                break;
            case "bote":
                AS.PlayOneShot(jump);
                break;

                   
        }
    }
}
