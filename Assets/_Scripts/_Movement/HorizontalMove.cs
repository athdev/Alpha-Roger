using UnityEngine;
using System.Collections;
//Horizontal move script. Used by generators.
public class HorizontalMove : MonoBehaviour {

	public float speed;
	public float xmin;
	public float xmax;
	float orientation=1.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Random.seed = (int)Time.time;
		Vector2 movement = new Vector2 (transform.position.x, transform.position.y);
		//Moving Pattern

		if (movement.x > xmax - 0.5f) {
			orientation = -1.0f;
		} else if (movement.x < xmin + 0.5f) {
			orientation = 1.0f;
		}
		movement.x += orientation * speed * Time.deltaTime * Random.Range(0.0f,1.0f);
		
		transform.position = movement;
		
		
	}
}

