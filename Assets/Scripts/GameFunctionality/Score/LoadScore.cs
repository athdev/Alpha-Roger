using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//Load player score.
public class LoadScore : MonoBehaviour {
	int score;
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("Player Score");
		GetComponent<Text> ().text = "" + score;
		PlayerPrefs.SetInt ("Player Score",0);
	}
	

}
