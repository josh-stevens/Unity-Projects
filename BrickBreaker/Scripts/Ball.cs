﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public Paddle paddle;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;
	
	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			
			// Lock the ball relative to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			// Listen for mouseclick to launch the ball.
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked, launch ball");
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
			}
		}
	}
}
