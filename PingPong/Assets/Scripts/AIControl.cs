using UnityEngine;
using System.Collections;

public class AIControl : MonoBehaviour {

	public static string Difficulty = "EASY";

	public static float speed = 10;
	public static float offset = 4;

	public Transform Ball;
	public Transform AI;



	// Update is called once per frame
	void FixedUpdate () {

		if ( Ball.position.x >  AI.position.x + offset ){//&& ballDir.normalized.y < 0 ) {

			GetComponent<Rigidbody2D>().velocity = new Vector2 ( 1, 0 ) * speed ;

		}

		else if ( Ball.position.x <  AI.position.x - offset ) {//&& ballDir.normalized.y > 0 ) {
			
			GetComponent<Rigidbody2D>().velocity = new Vector2 ( -1, 0 ) * speed ;

		}

		else if ( Ball.position.x ==  AI.position.x ) {

			GetComponent<Rigidbody2D>().velocity = new Vector2 ( 0, 0 ) * speed;

		}

	}

}