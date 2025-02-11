﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {
	GameObject manager;
	public Manager myManager;
	public List<GameObject> myBlocks;
	public GameObject currentBlock;
	public Material myMat;
	GameObject previousBlock;

	// Use this for initialization
	void Start () {
		manager = GameObject.Find ("Manager");
		myManager = manager.GetComponent<Manager> ();
		currentBlock = myBlocks [myManager.count];
		myMat = currentBlock.GetComponent<MeshRenderer> ().material;
		currentBlock.GetComponent<MeshRenderer> ().material = currentBlock.GetComponent<MeshRenderer> ().materials [1];

	}

	void MovingBlocks () {
		if (Input.GetKey (KeyCode.D)) {
			currentBlock.transform.Translate (Vector3.right * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.A)) {
			currentBlock.transform.Translate (Vector3.left * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.W)) {
			currentBlock.transform.Translate (Vector3.forward * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.S)) {
			currentBlock.transform.Translate (Vector3.back * Time.deltaTime);
		}
	}

	void RotateBlocks () {
		if (Input.GetKeyDown (KeyCode.E)) {
			currentBlock.transform.Rotate (Vector3.up, 30);
		}

		if (Input.GetKeyDown (KeyCode.Q)) {
			currentBlock.transform.Rotate (Vector3.up, -30);
		}
	}

	void ChangeBlock () {
		if (Input.GetKeyDown (KeyCode.UpArrow) && myManager.count < 8) {
			previousBlock = currentBlock;	
			previousBlock.GetComponent<MeshRenderer> ().material = myMat;
			myManager.count += 1;
			currentBlock = myBlocks [myManager.count];
			myMat = currentBlock.GetComponent<MeshRenderer> ().material;
			currentBlock.GetComponent<MeshRenderer> ().material = currentBlock.GetComponent<MeshRenderer> ().materials [1];

		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			previousBlock = currentBlock;	
			previousBlock.GetComponent<MeshRenderer> ().material=myMat;
			myManager.count -= 1;
			currentBlock = myBlocks [myManager.count];
			myMat = currentBlock.GetComponent<MeshRenderer> ().material;
			currentBlock.GetComponent<MeshRenderer> ().material = currentBlock.GetComponent<MeshRenderer> ().materials [1];
		}

		if (myManager.count > 9) {
			myManager.count -= 1;
		}

		if (myManager.count < 0) {
			myManager.count += 1;
		}
	}

	// Update is called once per frame
	void Update () {
		 {
			
//			if (currentBlock != myBlocks [myManager.count]) {
//				Debug.Log ("Works");
//				for (int i = 0; i < myBlocks.Count; i++) {
//					myBlocks [i].GetComponent<MeshRenderer>().material = myMat;
//				}
//			}



		
			MovingBlocks ();
			ChangeBlock ();
			RotateBlocks ();

		}
	}
}
