using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float moveSpeed;
	private Animator anim;

	private static bool playerExists;

	// Use this for initialization
	void Start () {
		//Get animation from here
		anim = GetComponent<Animator> ();

		//Check for player duplicate
		if (!playerExists)
		{
			playerExists = true;
			//Makes playercontroller work in next area
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f )
		{
			transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f ));

		}
		if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
		{
			transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));

		}

		anim.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));
	}


	void OnTriggrEnter2D(Collision2D other)
	{
		if (this.gameObject.name == "Key") {
			gameObject.SetActive (false);
		}
	} 
}﻿