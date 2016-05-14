using UnityEngine;
using System.Collections;
//Pattern movement (under development). Unused feature for future game mode.
public class SunMovement : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movement = new Vector2 (transform.position.x,transform.position.y);
		//Moving Pattern
		
		movement.y -=  speed * Time.deltaTime;
		
		transform.position = movement;

	
	}
}
