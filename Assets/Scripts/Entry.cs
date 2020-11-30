using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Entry : MonoBehaviour {


	public string levelToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	//Will trigger new area from collider
	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.name == "Player") 
		{
			//Load new area
			SceneManager.LoadScene (levelToLoad);
		}
	}
}
