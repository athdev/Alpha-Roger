using UnityEngine;
using System.Collections;
//Game start and scene loading script.
public class Start : MonoBehaviour {
	

	public void StartGame () {
		Application.LoadLevel(1);

	}

	public void RestartGame () {
		Application.LoadLevel(1);

	}

	public void EndGame(){
		Application.Quit ();
	}

	public void Back(){
		Application.LoadLevel (0);

	}

	public void HowTo(){
		Application.LoadLevel (3);

	}

	public void Credits(){
		Application.LoadLevel (4);

	}
}
