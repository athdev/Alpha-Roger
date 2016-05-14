using UnityEngine;
using System.Collections;

// Area check that destroys items that leave the game area.
public class LiimitDestruction : MonoBehaviour {

	void OnTriggerExit (Collider other) {
		// Destroy everything that leaves the trigger
		Destroy(other.gameObject);
	}
}
