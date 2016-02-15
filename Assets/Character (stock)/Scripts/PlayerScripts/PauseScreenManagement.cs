using UnityEngine;
using System.Collections;

public class PauseScreenManagement : MonoBehaviour {

	private bool isPaused = false;

	
	// Toggle pause on escape key
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;

			if (isPaused) {
				Time.timeScale = 0.0f;
			} else {
				Time.timeScale = 1.0f;
			}
		}
	}
}
