using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public GameObject followTarget;
	private Vector3 targetPos;
	//moveSpeed adjustable in Unity
	public float moveSpeed;

	private static bool cameraExists;

	//camera follows player

	// Use this for initialization
	void Start () {
		
		//Makes playercontroller work in next area
		DontDestroyOnLoad (transform.gameObject);

		//check for camera duplicate
		if (!cameraExists)
		{
			cameraExists = true;
			//Makes playercontroller work in next area
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		targetPos = new Vector3 (followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed * Time.deltaTime);

	}
}
