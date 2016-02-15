using UnityEngine;
using System.Collections;


//This should only be necessary in the garage level
public class PlayerColorManager : MonoBehaviour {

	public Renderer characterRenderer;
	public Renderer swordRenderer;
	public Light swordLight;


	public float colorShiftRate = 1.0f;

	private float incrementTimer = 0.1f;

	private Color currentColor;

	// constructor
	void Awake () {
		currentColor = PlayerPersonality.playerColor ;
		characterRenderer.material.SetColor("_EmissionColor",currentColor);
		swordRenderer.material.SetColor ("_Color", Color.white - currentColor);
		swordLight.color = Color.white - currentColor;

	}

	void FixedUpdate () {
		if (!currentColor.Equals (PlayerPersonality.playerColor )) {
			ColorShiftTemporal ();

			//stop the increase
			if (currentColor.Equals (PlayerPersonality.playerColor)) {
				incrementTimer = 0.1f;
			}
		}
	}


	void ColorShiftTemporal(){
		//currentColor = Color.Lerp (currentColor, PlayerPersonality.playerColor, Time.deltaTime * colorShiftRate);
		//characterRenderer.material.SetColor("_EmissionColor",currentColor);

		incrementTimer += incrementTimer;
		SetColor( Color.Lerp (currentColor, PlayerPersonality.playerColor, Time.deltaTime * colorShiftRate * incrementTimer) );
	}
		

	void SetColor(Color cc){
		currentColor = cc;
		characterRenderer.material.SetColor("_EmissionColor",currentColor);
		swordRenderer.material.SetColor ("_Color", Color.white - currentColor);
		swordLight.color = Color.white - currentColor;
	}
}
