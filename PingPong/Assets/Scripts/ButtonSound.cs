using UnityEngine;
using System.Collections;

public class ButtonSound : MonoBehaviour {
	
	public static bool SFXSound = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playSound () {

		if ( SFXSound == true ) {

			//play scound
			GetComponent<AudioSource>().Play();

		}

	}

}
