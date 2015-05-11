using UnityEngine;
using System.Collections;

public class MusicSounds : MonoBehaviour {

	public static bool MusicSound = true;

	// Use this for initialization
	void Start () {

		if ( MusicSound == true ) {
			
			GetComponent<AudioSource>().Play();
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*public void playMusic () {

		if ( MusicSound == true ) {

			GetComponent<AudioSource>().Play();

		}

	}*/

}
