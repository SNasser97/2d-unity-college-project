using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GameTimer : MonoBehaviour {

	public float myGameTimer = 99;
	public Text timerText;

	// Use this for initialization
	void Start () {

		timerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		myGameTimer -= Time.deltaTime;
		print (myGameTimer);
	}
}
