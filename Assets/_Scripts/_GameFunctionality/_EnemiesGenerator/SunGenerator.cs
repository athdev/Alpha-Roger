using UnityEngine;
using System.Collections;

//Generic generator for enemies and crystals (Sun was the previous sprite used)
public class SunGenerator : MonoBehaviour {
	public GameObject sun;
	public float spawnRate;
	private float nextSpawn;
	private float nextScale;
	public bool scale=false;
	public float scale_num=0.0f;
	public float max_scale=0.0f;
	public float scale_time=0.0f;
	
	void Start (){
		nextSpawn = Time.time+spawnRate;
		if(scale == true){
			nextScale=Time.time+scale_time;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Spawn timer
		if( Time.time > nextSpawn){
			nextSpawn= spawnRate + Time.time; 
			Instantiate(sun,transform.position, Quaternion.identity);
			
		}

        //Optional balance/difficulty scale with time.
		if(scale == true && Time.time > nextScale){
			nextScale = scale_time + Time.time;
			spawnRate-=scale_num;
			if(spawnRate < max_scale ){
				spawnRate=max_scale;
				scale=false;
			}

		}
		
	}
}
