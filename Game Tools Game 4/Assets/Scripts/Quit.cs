using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void TriggerEnter (Collider player) {
		if (player.tag == "Player") {
			Application.Quit();
		}
	}
}
