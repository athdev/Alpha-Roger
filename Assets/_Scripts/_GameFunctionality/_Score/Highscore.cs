using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Highscore HUD indication.
public class Highscore : MonoBehaviour {

	int score;
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Player Highscore");
		GetComponent<Text> ().text = "Highscore: " + score;

	}
}
