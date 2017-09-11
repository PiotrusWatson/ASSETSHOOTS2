using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health {
	public GameObject explosion;

	void Awake(){
		GetComponent<CommonVars> ().team = Team.Enemy;
	}
	// Update is called once per frame
	void Update () {
		
		base.Update();

		if (isDead==true) {
			Instantiate(explosion, gameObject.transform.position, Quaternion.Euler (0,0,90));
			Destroy (gameObject);
		}
	}

}
