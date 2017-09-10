using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Direction {North, East, South, West};
public class godspeed : MonoBehaviour {

	public Direction dir;
    public float speed;

	Rigidbody2D rb2D;

	void Awake(){
		rb2D = GetComponent<Rigidbody2D> ();
	}
    void Start()
    {
		switch (dir) {
		case Direction.North:
			rb2D.velocity = transform.up * speed;
			break;
		case Direction.East:
			rb2D.velocity = transform.right * speed;
			break;
		case Direction.South:
			rb2D.velocity = transform.up * -speed;
			break;
		case Direction.West:
			rb2D.velocity = transform.right * -speed;
			break;
			
		}
        GetComponent<Rigidbody2D>().velocity = transform.up * -speed;
       
    }
    void Update()
    {
    }
}
