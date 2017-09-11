using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	[HideInInspector]
	public int seconds;
	[HideInInspector]
	public int difficultyModifier;
	float timer;
	[SerializeField]
	int levelSecond = 15;

	// Use this for initialization
	void Start () {
		ResetTimer ();

	}
	
	// Update is called once per frame
	void LateUpdate () {
		timer += Time.deltaTime;
		seconds = (int) timer % 60;

		if (seconds % levelSecond == 0) {
			difficultyModifier += 1;
			//LMAO
			GameObject.FindGameObjectWithTag ("Spawner").GetComponent<SPAWNSTUFF> ().difficultyModifier = difficultyModifier;
			GameObject.FindGameObjectWithTag ("Spawner").GetComponent<SPAWNSTUFF> ().upOne = true;
		}
	}

	public void ResetTimer(){
		timer = 0.0f;
		seconds = 0;
		difficultyModifier = 0;
	}
}
