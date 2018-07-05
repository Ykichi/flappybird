using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	//Movement speed (0 means don't move)
	public float speed = 0;
	//Swich movement direction every few seconds
	public float switchTime = 2;

	// Use this for initialization
	void Start () {
		//Initial movement direction
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
		//Switch every few seconds 
		InvokeRepeating("obstacleSwitch", 0, switchTime);
	}

	void obstacleSwitch () {
		GetComponent<Rigidbody2D>().velocity *= -1;
	}
	
}
