using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickUp : MonoBehaviour {

	public int value;
	public Collectibles theKM;


	// Use this for initialization
	void Start () {
		theKM = FindObjectOfType<Collectibles> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D treasure)
	{
		// if the treasure collides with player - add score
		if (treasure.gameObject.name == "Player") 
		{
			theKM.AddKey (value);
			Destroy (this.gameObject);
		}
	}
}