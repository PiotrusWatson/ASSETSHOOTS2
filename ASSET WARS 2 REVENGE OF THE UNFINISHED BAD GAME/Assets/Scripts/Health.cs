using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	[SerializeField]
	float maxHealth = 100;
	float health;
	bool isDead;

	// Use this for initialization
	void Start () {
		health = maxHealth;
		isDead = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D c) {
		if (c.GetComponent<DamageOnHit>()) {
			if (!isDead)
				health -= (c.GetComponent<DamageOnHit> ().damage);
		}
	}

	void Update(){
		if (health <= 0) {
			Die ();
		}
	}

	public void Die(){
		isDead = true;
	}
}
