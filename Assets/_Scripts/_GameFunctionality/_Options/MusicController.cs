using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// Generic game music controller based on player pref. Two modes only ON/OFF
public class MusicController : MonoBehaviour {

	void Awake(){
		int mute= PlayerPrefs.GetInt("Audio");

		if( mute == 10){
			GetComponent<AudioSource> ().mute = true;
		}
	}

	public void ToggleSound(){
		if (GetComponent<AudioSource> ().mute == false) {
			GetComponent<AudioSource> ().mute = true;
			PlayerPrefs.SetInt("Audio",10);
		} else {
			GetComponent<AudioSource> ().mute = false;
			PlayerPrefs.SetInt("Audio",1);
		}
	}




}
