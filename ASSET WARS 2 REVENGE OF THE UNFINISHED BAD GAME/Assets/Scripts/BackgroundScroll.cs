using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {
	private Renderer bg_renderer;
	public float speed = 0;
	// Use this for initialization
	void Start () {
		bg_renderer = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		bg_renderer.material.mainTextureOffset = new Vector2 ((Time.time * speed)%1, 0f);
	}
}
