﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	//shooting stuff
	public float fireRate = 2;
	public GameObject shot;
	public Transform shotSpawn;
	private float shootTimer = 0.0f;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Jump") && shootTimer <= 0)
		{
			shootTimer = fireRate;
			Instantiate(shot, shotSpawn.position, Quaternion.Euler (0,0,90));
		}

		if (shootTimer > 0) {
			shootTimer -= Time.deltaTime;
		}
	}
}
