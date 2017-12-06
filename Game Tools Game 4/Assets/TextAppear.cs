using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAppear : MonoBehaviour {

	public List<GameObject> texts;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider text) {
		
		texts[0].SetActive(true);
			texts[1].SetActive (true);

	}
}
