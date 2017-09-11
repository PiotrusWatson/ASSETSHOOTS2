using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (doResetGame());
	}

	private IEnumerator doResetGame(){
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene("THEONLYLEVEL");
	}
	// Update is called once per frame
	void Update () {

	}
}
