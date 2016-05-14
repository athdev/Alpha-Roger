using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//Future game mode base functionality.
public class FuelRundown : MonoBehaviour {

	private int start_fuel=0;
	
	
	void Start (){
		GetComponent<Text> ().text = ""+start_fuel;
	}
	

	public void IncFuel( int x ){
		start_fuel += x;
		GetComponent<Text> ().text = ""+start_fuel;
		PlayerPrefs.SetInt ("Player Score", start_fuel);
	}
	// Update is called once per frame

}
