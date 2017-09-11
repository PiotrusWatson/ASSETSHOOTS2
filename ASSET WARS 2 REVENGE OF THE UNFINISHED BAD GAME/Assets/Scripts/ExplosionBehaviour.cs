using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBehaviour : MonoBehaviour {

	private AnimationClip anim;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>().runtimeAnimatorController.animationClips[0];
		audio = GetComponent<AudioSource>();
		StartCoroutine (doAnimation());
		StartCoroutine (doDestroy ());
	}

	private IEnumerator doAnimation(){
		yield return new WaitForSeconds(anim.length);
		Destroy (GetComponent<SpriteRenderer>());
	}

	private IEnumerator doDestroy(){
		yield return new WaitForSeconds (Mathf.Max (anim.length, audio.clip.length));
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
