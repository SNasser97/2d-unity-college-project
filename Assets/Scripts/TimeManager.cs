using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour {

	public string levelToLoad;
	public float startingTime;
	private Text theText;

	// Use this for initialization
	void Start () {

		theText = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {

		startingTime -= Time.deltaTime;
		theText.text = "" + Mathf.Round(startingTime);

		//when timer hits zero will reload game to starting point
		if (startingTime <= 0 ) 
		{
			SceneManager.LoadScene ("main");
		}
	}
}
