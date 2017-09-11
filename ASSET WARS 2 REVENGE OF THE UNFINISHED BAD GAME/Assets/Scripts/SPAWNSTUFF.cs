using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNSTUFF : MonoBehaviour {

	Bounds bounds;
	float spawnTime;
	Vector3 spawnPosition;
	[HideInInspector]
	public int difficultyModifier = 0;
	[HideInInspector]
	public bool upOne = false;

	[SerializeField]
	float initialSpawnTime = 10f;
	[SerializeField]
	GameObject[] Enemies;
	[SerializeField]
	int enemyNum = 3;

	// Use this for initialization
	void Awake () {
		bounds = GetComponent<BoxCollider2D> ().bounds;
		spawnTime = initialSpawnTime;
	}
	void Start(){
		StartCoroutine (SpawnShit ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnShit(){
		while (true) {
			for (int i = 0; i < enemyNum; i++) {
				spawnPosition = new Vector3 (bounds.center.x, Random.Range (bounds.min.y, bounds.max.y));
				Instantiate (Enemies [Random.Range (0, (difficultyModifier < Enemies.Length ? difficultyModifier : Enemies.Length))], spawnPosition, Quaternion.Euler(0, 0, -90));
			}
			if (upOne) {
				upOne = false;
				spawnTime = spawnTime > 0.5f ? spawnTime - 0.2f : spawnTime;
			}
			yield return new WaitForSeconds (spawnTime);
		}
	}
}
