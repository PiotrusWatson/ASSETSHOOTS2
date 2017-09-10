using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health {
	void Awake(){
		team = Team.Enemy;
	}
	// Update is called once per frame
	public void Update () {
		base.Update();

		if (isDead==true) {
			Destroy (gameObject);
		}
	}
}
