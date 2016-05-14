using UnityEngine;
using System.Collections;
//Player Collision script.
public class PlayerCollision : MonoBehaviour {

	public GameObject explosionFX;
	void OnTriggerEnter (Collider other) {
        //Fuel corresponds to crystals. 
		if(other.tag =="Fuel"){ //Cyan crystals.
			GameObject.Find("FuelText").GetComponent<FuelRundown>().IncFuel(100);
        
		}else if(other.tag=="Fuel2"){ //Purple crystals.
			GameObject.Find("FuelText").GetComponent<FuelRundown>().IncFuel(500);
		}else if(other.tag=="Fuel3"){ //Red Crystals.
			GameObject.Find("FuelText").GetComponent<FuelRundown>().IncFuel(1000);
		}else if (other.tag == "Asteroid"){ //Asteroids.
			Instantiate(explosionFX,transform.position, Quaternion.identity);
			gameObject.SetActive(false);
			int score=PlayerPrefs.GetInt("Player Score");
			if(PlayerPrefs.HasKey("Player Highscore") == true){
				int high_score=PlayerPrefs.GetInt("Player Highscore");
				if(score > high_score){
					PlayerPrefs.SetInt("Player Highscore", score);
				}
			}else{
				PlayerPrefs.SetInt("Player Highscore",score);
			}
			Destroy(gameObject,3.0f);

		}
		// Destroy everything that leaves the trigger
		Destroy(other.gameObject);

	}

	void OnDestroy(){
		Application.LoadLevel(2);
	}
}
