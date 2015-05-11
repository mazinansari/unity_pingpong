using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundToggle : MonoBehaviour {

	bool playMusic = true;
	bool playSFX = true;

	public UnityEngine.UI.Button musicButton;
	public Button SFXButton;

	public Color red;
	public Color green;

	// Use this for initialization
	void Start () {

		if ( ButtonSound.SFXSound == false ) {
			
			playSFX = false;
			
			ButtonSound.SFXSound = false;
			
			SFXButton.GetComponent<Image>().color = red;
			
		}
		
		else {
			
			ButtonSound.SFXSound = true;
			
			playSFX = true;
			
			SFXButton.GetComponent<Image>().color = green;
			
		}


		if ( MusicSounds.MusicSound == false ) {
			
			playMusic= false;
			
			MusicSounds.MusicSound = false;
			
			musicButton.GetComponent<Image>().color = red;
			
		}
		
		else {
			
			MusicSounds.MusicSound = true;
			
			playMusic = true;
			
			musicButton.GetComponent<Image>().color = green;
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void musicButtonPress () {

		if ( playMusic == true ) {
			
			playMusic = false;
			
			MusicSounds.MusicSound = false;
			
			musicButton.GetComponent<Image>().color = red;
			
		}
		
		else {
			
			MusicSounds.MusicSound = true;
			
			playMusic = true;
			
			musicButton.GetComponent<Image>().color = green;
			
		}

	}

	public void SFXButtonPress () {
		
		if ( playSFX == true ) {
			
			playSFX = false;

			ButtonSound.SFXSound = false;

			SFXButton.GetComponent<Image>().color = red;
			
		}
		
		else {

			ButtonSound.SFXSound = true;

			playSFX = true;

			SFXButton.GetComponent<Image>().color = green;

		}
		
	}

}
