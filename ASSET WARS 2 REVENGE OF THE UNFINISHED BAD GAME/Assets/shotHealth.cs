using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotHealth : Health{

	// Use this for initialization
	void Awake () {
		team = Team.Player;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D c){
		if (!c.GetComponent<Health> ())
			return;

		if (c.GetComponent<Health> ().team != team)
			Destroy (gameObject);
		
	}
}
