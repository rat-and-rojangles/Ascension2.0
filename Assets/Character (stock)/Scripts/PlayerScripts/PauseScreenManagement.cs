using UnityEngine;
using System.Collections;

public class PauseScreenManagement : MonoBehaviour {

	private bool isPaused = false;

	public GameObject pauseMenuCanvas;
	
	// Toggle pause on escape key
	void Update () {
		if (Input.GetButtonDown ("Pause")) {
			isPaused = !isPaused;

			if (isPaused) {
				Time.timeScale = 0.0f;
				pauseMenuCanvas.SetActive (true);
			} else {
				Time.timeScale = 1.0f;
				pauseMenuCanvas.SetActive (false);
			}
		}
	}

	public void Pause(){
		isPaused = true;
		Time.timeScale = 0.0f;
		pauseMenuCanvas.SetActive (true);
	}

	public void Unpause(){
		isPaused = false;
		Time.timeScale = 1.0f;
		pauseMenuCanvas.SetActive (false);
	}
}
