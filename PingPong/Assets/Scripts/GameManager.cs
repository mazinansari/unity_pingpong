using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int playerScoreTop = 0;
	public static int playerScoreBottom = 0;

	//public static Text AIScore;
	//public static Text PlayerScore;
	
	public void resetScore () {
		
		playerScoreTop = 0;
		playerScoreBottom = 0;
		Application.LoadLevel( "MainMenu" );
		
	}

	/*void Start() {
		Text[] textUIs = GetComponents <Text> ();
		
		foreach(Text textComp in textUIs) {
			if (textComp.name == "AIScore") {
				AIScore = textComp;
				continue;
			}
			
			if (textComp.name == "PlayerScore") {
				PlayerScore = textComp;
				continue;
			}
		}
	}*/
	
	public static void Score ( string wallName ) {
		
		if ( wallName == "bottomWall" ) {

			playerScoreTop += 1;

		}
		
		else {
			
			playerScoreBottom += 1;
			
		}

		//AIScore.text = playerScoreTop.ToString();
		//PlayerScore.text = playerScoreBottom.ToString();
		
		//Debug.Log( "PlayerRight score is " + playerScoreLeft );
		//Debug.Log( "PlayerLeft  score is " + playerScoreRight );
		
	}

}
