﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour {

    Text text;

	// Use this for initialization
	void Start () {
        text = text.GetComponent<Text>();
        text.text = "Blarg";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
