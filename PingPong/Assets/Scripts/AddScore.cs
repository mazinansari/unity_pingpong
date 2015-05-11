using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AddScore : MonoBehaviour {

	Text score;

	int addScore;

	// Use this for initialization
	void Start () {

		score = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {

		if ( score.name == "AIScore" ) {

			addScore = GameManager.playerScoreTop;
			
			score.text = addScore.ToString();

		}

		if ( score.name == "PlayerScore" ) {

			addScore = GameManager.playerScoreBottom;
			
			score.text = addScore.ToString();

		}



	
	}
}
