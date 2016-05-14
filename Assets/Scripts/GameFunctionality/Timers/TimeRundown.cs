using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//Future game mode base functionality.
public class TimeRundown : MonoBehaviour {

	private float nextSpawn;
	private float time_elapsed = 0.0f;
	void Start (){
		nextSpawn = Time.time;

	}
	

	// Update is called once per frame
	void Update () {
		
		if( Time.time > nextSpawn){
			nextSpawn= 1.0f + Time.fixedTime;
			time_elapsed+=1.0f;
			GetComponent<Text>().text=""+time_elapsed;
			PlayerPrefs.SetFloat ("Player Score", time_elapsed);
		}
		
	}
	
}
