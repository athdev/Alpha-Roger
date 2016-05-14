using UnityEngine;
using System.Collections;

//An auto destroy timer for generic use.
public class AutoDestroy : MonoBehaviour {
	public float timer;
	private float kill;
	// Use this for initialization
	void Start () {
		kill = Time.time + timer;
	}
	
	// Update is called once per frame
	void Update () {

		if(Time.time > kill){
			Destroy(gameObject);
		}
			
	}
}
