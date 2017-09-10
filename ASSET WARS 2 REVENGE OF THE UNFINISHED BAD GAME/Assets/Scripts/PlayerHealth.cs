using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health {

	void Awake(){
		team = Team.Player;
	}

	new public void Die()
    {
        //erase
        GetComponent<SpriteRenderer>().color = Color.clear;
        GetComponent<BoxCollider2D>().enabled = false;
        //respawn: reset position
        transform.position = new Vector3(0, 0, 0);
        //respawn: make appear
        GetComponent<SpriteRenderer>().color = Color.white;
        GetComponent<BoxCollider2D>().enabled = true;
        health = maxHealth;
        isDead = false;
    }
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
}
