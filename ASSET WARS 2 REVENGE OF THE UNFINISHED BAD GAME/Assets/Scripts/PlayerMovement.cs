using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int speed = 0;
    public string horizontalMovInput;
    public string verticalMovInput;
    float moveHori = 0;
    float moveVert = 0;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        moveHori = 0;
        moveVert = 0;
        moveHori = Input.GetAxisRaw(horizontalMovInput);
        moveVert = Input.GetAxisRaw(verticalMovInput);
    }

    void FixedUpdate() {
        Vector2 movement = new Vector2(moveHori, moveVert);
        rb.velocity = speed * movement;

    }

    }
