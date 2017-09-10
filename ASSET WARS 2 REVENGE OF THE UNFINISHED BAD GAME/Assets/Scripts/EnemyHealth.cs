using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health {
	void Awake(){
		team = Team.Enemy;
	}
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Die ();
		}
	}

	public void Die(){
		Destroy (gameObject);
	}
}
