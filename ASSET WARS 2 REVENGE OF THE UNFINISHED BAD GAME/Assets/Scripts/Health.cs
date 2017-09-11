using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	DamageOnHit dmgScript;
	CommonVars teamScript;
	Team team;

	[SerializeField]
	protected float maxHealth = 1;
	protected float health;
	protected bool isDead;

	// Use this for initialization
	void Start () {
		health = maxHealth;
		isDead = false;
		team = GetComponent<CommonVars> ().team;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D c) {
		dmgScript = c.GetComponent<DamageOnHit> ();
		teamScript = c.GetComponent<CommonVars> ();

		if (dmgScript == null || teamScript == null)
			return;

		if (teamScript.team == Team.Neutral || team == teamScript.team)
			return;	
		
		if (!isDead) {
			rigidBodyHurt (dmgScript.damage, c.transform);
		}


	}

	public void Update(){
		if (health <= 0) {
			Die ();
		}
	}

	public void Die(){
		//Probably do an explosion animation or something too
		isDead = true;
    }

	public void rigidBodyHurt(float damage, Transform other, float force = 20f){
		//DOESN'T WORK LOL - rigidbody null. not sure why.
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		if (rb != null) {
			rb.AddForce ((transform.position - other.position).normalized * force);
		}
		health -= damage;

	}
}
