using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health {

	Text livesText;
    public int lives = 3;
    bool gameOver = false;

 void Awake()
    {
		GetComponent<CommonVars> ().team = Team.Player;
		livesText = GameObject.FindGameObjectWithTag ("UITEXT").GetComponent<Text> ();	
        livesText.text = "Lives: " + lives;
	}

	void Start() {
		
	}

	new public void Die()
    {
        //erase
        lives -= 1;
        livesText.text = "Lives: " + lives;
        GetComponent<SpriteRenderer>().color = Color.clear;
        GetComponent<BoxCollider2D>().enabled = false;
        //respawn: reset position
        transform.position = new Vector3(-200, 0, 0);
        //respawn: make appear
        Respawn ();
    }


    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
        if(lives < 0)
        {
            gameOver = true;
        }
    }

	void Respawn ()
	{
		GetComponent<SpriteRenderer> ().color = Color.white;
		GetComponent<BoxCollider2D> ().enabled = true;
		health = maxHealth;
		isDead = false;
	}
}
