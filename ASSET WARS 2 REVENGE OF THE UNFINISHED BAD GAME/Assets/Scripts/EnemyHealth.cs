using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health {
	void Awake(){
		GetComponent<CommonVars> ().team = Team.Enemy;
	}
	// Update is called once per frame
	void Update () {
		
		base.Update();

		if (isDead==true) {
			Destroy (gameObject);
		}
	}


}
