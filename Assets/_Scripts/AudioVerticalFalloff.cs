using UnityEngine;
using System.Collections;

public class AudioVerticalFalloff : MonoBehaviour {

	public float maxDistance;
	public Transform listener;

	public float volumeScale = 1.0f;	//this overrides the audiosource volume control. keep it between zero and one

	//listener.y will be higher than transform.y

	void FixedUpdate () {
		if ((listener.position.y - transform.position.y) > maxDistance) {	//out of max distance, hear nothing
			GetComponent<AudioSource> ().volume = 0.0f;
		} else if ( listener.position.y < transform.position.y) {			//listener below plane, 
			GetComponent<AudioSource> ().volume = 1.0f;
		}
		else{
			GetComponent<AudioSource> ().volume = (1.0f - ((listener.position.y - transform.position.y) / maxDistance)) * volumeScale;
		}
	}
}
