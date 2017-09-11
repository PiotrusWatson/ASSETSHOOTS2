using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnResolver : MonoBehaviour {
	public float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D c){
		if (c.gameObject.tag == "Enemy") {
			if (Random.Range(1,10) <= 5) {
				Vector3 pos = transform.position;
				pos.x += 50;
				transform.position = pos;
			}
		}
	}
}
