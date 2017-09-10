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
		
		if (!isDead)
			health -= (dmgScript.damage);


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
}
