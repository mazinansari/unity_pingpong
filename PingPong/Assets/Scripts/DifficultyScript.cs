using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DifficultyScript : MonoBehaviour {

	public Text Difficulty;

	// Use this for initialization
	void Start () {

		if ( AIControl.Difficulty == "EASY" ) {

			SelectEasy();

		}

		if ( AIControl.Difficulty == "MEDIUM" ) {
			
			SelectMedium();
			
		}

		if ( AIControl.Difficulty == "HARD" ) {
			
			SelectHard();
			
		}

		if ( AIControl.Difficulty == "IMPOSSIBLE" ) {
			
			SelectImpossible();
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SelectEasy () {

		AIControl.speed = 10;
		AIControl.offset = 4;
		AIControl.Difficulty = "EASY";
		Difficulty.text = "DIFFICULTY:\n" + AIControl.Difficulty;

	}

	public void SelectMedium () {
		
		AIControl.speed = 15;
		AIControl.offset = 4;
		AIControl.Difficulty = "MEDIUM";
		Difficulty.text = "DIFFICULTY:\n" + AIControl.Difficulty;
		
	}

	public void SelectHard () {
		
		AIControl.speed = 18;
		AIControl.offset = 3;
		AIControl.Difficulty = "HARD";
		Difficulty.text = "DIFFICULTY:\n" + AIControl.Difficulty;
		
	}

	public void SelectImpossible () {
		
		AIControl.speed = 20;
		AIControl.offset = 1;
		AIControl.Difficulty = "IMPOSSIBLE";
		Difficulty.text = "DIFFICULTY:\n" + AIControl.Difficulty;
		
	}

	public void GoBack () {
		
		Application.LoadLevel ( "MainMenu" );
		
	}

}
