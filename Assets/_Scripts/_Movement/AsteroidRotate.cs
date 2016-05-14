using UnityEngine;
using System.Collections;
//Asteroid Rotation script.
public class AsteroidRotate : MonoBehaviour {
	
	public float speed;
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward, speed*Time.deltaTime,Space.World);
	}
}
