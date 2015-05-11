using UnityEngine;
using System.Collections;

public class WallTrigger : MonoBehaviour {

	void OnTriggerEnter2D ( Collider2D hitInfo ) {
		
		if ( hitInfo.name == "Ball" ) {

			if ( ButtonSound.SFXSound == true ) {

				GetComponent<AudioSource>().Play ();

			}

			string wallName = transform.name;
			GameManager.Score( wallName );
			hitInfo.gameObject.SendMessage("resetBall");
			
		}
		
	}

}
