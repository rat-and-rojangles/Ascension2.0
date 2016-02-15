using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ColorChangePad : MonoBehaviour {

	public Color m_Color;

	void Awake(){
		GetComponent<ParticleSystem>().startColor = m_Color;
		GetComponentInChildren<Light> ().color = m_Color;
	}

	void OnTriggerEnter(Collider other){
		if (other.tag.Equals ("Player")) {
			PlayerPersonality.playerColor = m_Color;
		}
	}

}
