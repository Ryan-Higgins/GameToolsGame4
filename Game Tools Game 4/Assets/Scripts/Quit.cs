using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {
	public bool test;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider player) {
		test = true;
		if (player.tag == "Player") {
			Application.Quit();
		}
	}
}
