﻿using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

	public int xPos;

	public Vector3 target;
	public float speed;

	// Use this for initialization
	void Start () {
		xPos = (int) (transform.position.x * 100);
		target = new Vector3 (1.71f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		xPos = (int) (transform.position.x * 100);

		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target, step);
	}

	public void moveTowards(float des){
		target = new Vector3 (des, 0f, 0f);
	}
}
