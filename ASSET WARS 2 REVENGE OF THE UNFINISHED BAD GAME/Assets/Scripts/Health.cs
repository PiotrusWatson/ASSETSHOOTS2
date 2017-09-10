using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Team{Player,Enemy,Neutral};

public class Health : MonoBehaviour {
	public Team team  = Team.Neutral;

	DamageOnHit dmgScript;
	Health healthScript;

	[SerializeField]
	protected float maxHealth = 1;
	protected float health;
	protected bool isDead;

	// Use this for initialization
	void Start () {
		health = maxHealth;
		isDead = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D c) {
		dmgScript = c.GetComponent<DamageOnHit> ();
		healthScript = c.GetComponent<Health> ();

		if (dmgScript == null || healthScript == null)
			return;

		if (team == c.GetComponent<Health> ().team)
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
