using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallControl : MonoBehaviour {

	public float speed = 30;

	// Use this for initialization
	void Start () {


		//wait ();

		//goBall ();

		Invoke ( "goBall", 3f );
		
	}
	
	public void goBall () {

		float leftRight = Random.Range(-1, 2);
		
		if ( leftRight <= 0 ) {
			
			float rnd = Random.Range( -1, 1 );
			Vector2 dir = new Vector2 ( rnd, 1 ).normalized;
			GetComponent<Rigidbody2D>().velocity = -1 * dir * speed;
			
		}
		
		else {
			
			float rnd = Random.Range( 0, 2 );
			Vector2 dir = new Vector2 ( rnd, 1 ).normalized;
			GetComponent<Rigidbody2D>().velocity = dir * speed;
			
		}

		//countDown.text = "";
		
	}
	
	public void resetBall () {
		
		GetComponent<Rigidbody2D>().velocity = new Vector2 ( 0, 0 ) * 0;;
		//GetComponent<Rigidbody2D>().velocity.y = 0;
		
		transform.position = new Vector2 ( 0, 0 );
		
		Invoke ( "goBall", 0.5f );
		
	}
	
	float hitFactor ( Vector2 ballPos, Vector2 racketPos, float racketWidth ) {

		// ascii art:
		// ||  1 <- at the top of the racket
		// ||
		// ||  0 <- at the middle of the racket
		// ||
		// || -1 <- at the bottom of the racket

		return ( ballPos.x - racketPos.x ) / racketWidth;
		
	}
	
	void OnCollisionEnter2D ( Collision2D col ) {
		
		// Note: 'col' holds the collision information. If the
		// Ball collided with a racket, then:
		//   col.gameObject is the racket
		//   col.transform.position is the racket's position
		//   col.collider is the racket's collider
		
		// Hit left racket?
		if ( col.gameObject.name == "bottomRacket" ) {

			// Calculate hitFactor
			float x = hitFactor ( transform.position, col.transform.position, col.collider.bounds.size.x );
			
			Vector2 dir = new Vector2 ( x, 1 ).normalized;
			
			GetComponent<Rigidbody2D>().velocity = dir * speed;
			
		}
		
		// Hit right Racket?
		if ( col.gameObject.name == "topRacket" ) {
			
			// Calculate hitFactor
			float x = hitFactor ( transform.position, col.transform.position, col.collider.bounds.size.x );
			
			Vector2 dir = new Vector2 ( x, -1 ).normalized;
			
			GetComponent<Rigidbody2D>().velocity = dir * speed;
			
		}

		if ( ButtonSound.SFXSound == true ) {

			if ( col.collider.tag == "Racket" || col.collider.tag == "AI" ) {
				
				GetComponent<AudioSource>().Play();
				
			}

		}
		
	}

}
