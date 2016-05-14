using UnityEngine;
using System.Collections;
//Crystal rotation script.
public class CrystalRotate : MonoBehaviour {

	public float speed;
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, speed*Time.deltaTime,Space.World);
	}
}
