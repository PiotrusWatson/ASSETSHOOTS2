using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBehaviour : MonoBehaviour {

	Team team;
	// Use this for initialization
	void Awake () {
		team = GetComponent<CommonVars> ().team;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D c){
		if (team == c.GetComponent<CommonVars> ().team)
			return;
		if (c.GetComponent<CommonVars> ().team == Team.Neutral)
			return;
		
		Destroy (gameObject);
			
	}
}
