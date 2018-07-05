using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
	
	//Movement speed
	public float speed = 2;

	//Flap force
	public float force = 300;

	// Use this for initialization
	void Start () {
		//Fly towards the right
		GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			//Flap
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
		}
	}

	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	void OnCollisionEnter2D(Collision2D other)
	{
		//Restart
		Application.LoadLevel(Application.loadedLevel);
	}
}
