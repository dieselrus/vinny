﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform target;
	int distance = -10;
	float lift = 1.5f;
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3(0, lift, distance) + target.position;
		//transform.LookAt(target);
	}
}
