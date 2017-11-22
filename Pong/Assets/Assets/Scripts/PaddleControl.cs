﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour {

	public float paddleSpeed = 2;

	public Vector2 playerPos;

	void Update () {
		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical")*paddleSpeed);
		playerPos = new Vector2 (-1600, Mathf.Clamp(yPos, -20, 400));
		gameObject.transform.position = playerPos;

	}
}
