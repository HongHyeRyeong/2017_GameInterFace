using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(PauseGame.isPaused==false)		transform.Translate (0, 0, speed);	
	}
}
