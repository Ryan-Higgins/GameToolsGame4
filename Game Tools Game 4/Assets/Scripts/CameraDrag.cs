﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour {

	public float dragSpeed;
	private Vector3 dragOrigin;


	void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			dragOrigin = Input.mousePosition;
			return;
		}

		if (!Input.GetMouseButton(1)) return;

		Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
		Vector3 move = new Vector3(pos.x * -dragSpeed, 0, pos.y * -dragSpeed);

		transform.Translate(move, Space.World);  
	}
}
