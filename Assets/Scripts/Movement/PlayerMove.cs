using UnityEngine;
using System.Collections;
//Player move script.
public class PlayerMove : MonoBehaviour {

	public float speed=27;
	float LeftRight=0.0f;
	
	void FixedUpdate (){
		
		
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		//float moveHorizontal = Input.acceleration.x;
		/*if (Input.touchCount > 0) {
			if (Input.GetTouch (0).position.x > Screen.width / 2) {
				LeftRight = 1.0f;
			} else if (Input.GetTouch (0).position.x < Screen.width / 2) {
				LeftRight = -1.0f;
			}
		} else
			LeftRight = 0.0f*/;
        float moveHorizontal = Input.GetAxis("Horizontal");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		/*if (Input.GetKey(KeyCode.W)) {
			speed +=0.4f;

		} else {
			speed=20;
		}*/
		rigidbody.velocity = movement * speed;
		//rigidbody.AddRelativeForce (Vector3.forward * speed);
		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, -2.5f, 2.5f), 
				Mathf.Clamp (rigidbody.position.y, -4.0f, 0.0f), 
				rigidbody.position.z
				);
		
		rigidbody.rotation = Quaternion.Euler (282.0f, 180.0f, 180.0f + rigidbody.velocity.x * -5.0f);
		
	}
}
