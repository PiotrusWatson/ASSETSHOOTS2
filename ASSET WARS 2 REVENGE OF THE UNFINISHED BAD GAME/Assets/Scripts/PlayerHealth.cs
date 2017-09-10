using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health {

    public Text livesText;
    public int lives = 3;
    bool gameOver = false;

 void Awake()
    {
        livesText = livesText.GetComponent<Text>();
        livesText.text = "Lives: " + lives;
		team = Team.Player;
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
        if(lives < 0)
        {
            gameOver = true;
        }
    }
}
