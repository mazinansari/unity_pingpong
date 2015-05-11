using UnityEngine;
using System.Collections;

public class TouchScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetMouseButtonDown( 0 ) ) {

			//GetComponent<AudioSource>().Play();

			Application.LoadLevel ( "MainMenu" );

		}
	
	}
}
