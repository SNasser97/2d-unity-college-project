using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour {

	public Text keyText;
	public int currentKeys;

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.HasKey ("CurrentKey")) {
		
			currentKeys = PlayerPrefs.GetInt ("CurrentKey");

		} else {
			currentKeys = 0;
			PlayerPrefs.SetInt ("CurrentKey", 00);
		}

		keyText.text = "Gold collected: " + currentKeys;

	}

	// Update is called once per frame
	void Update () {
		
	}

	public void AddKey(int KeysToAdd) 
	{
		currentKeys += KeysToAdd;
		PlayerPrefs.SetInt ("CurrentMoney", currentKeys);
		keyText.text = "Gold collected: " + currentKeys;
	}
}
