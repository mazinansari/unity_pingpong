using UnityEngine;
using System.Collections;

public class PressButton : MonoBehaviour {

	public void LoadMultiPlayer() {

		Application.LoadLevel ( "MultiPlayer" );

	}

	public void LoadSinglePlayer() {

		Application.LoadLevel ( "SinglePlayer" );
		
	}

	public void LoadSettings () {

		Application.LoadLevel ( "Settings" );

	}

	public void LoadAbout () {

		Application.LoadLevel ( "About" );
		
	}

}
