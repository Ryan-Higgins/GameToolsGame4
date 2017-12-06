using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
	public bool test;
	public string sceneToLoad;

	void Start () {
		test = false;
	}

	void OnTriggerEnter(Collider agent) {
		test = true;
		if (agent.tag == "Player") {
			SceneManager.LoadScene (sceneToLoad, LoadSceneMode.Single);
		}
	}

	void Update () {

	}
}
