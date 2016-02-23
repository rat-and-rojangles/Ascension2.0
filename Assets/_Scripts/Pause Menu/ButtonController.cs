using UnityEngine;
using System.Collections;

using UnityEngine.UI;

//the button with this script attached will be selected by default
public class ButtonController : MonoBehaviour {

	public bool selectOnStart = false;

	private Button button;

	private Button scapegoatButton;

	void Awake(){
		button = GetComponent<Button> ();
		scapegoatButton = GameObject.FindGameObjectWithTag ("ScapegoatButton").GetComponent<Button> ();
	}

	void OnEnable () {
		if (selectOnStart) {
			scapegoatButton.Select ();	//this gets it off of the actual button
			button.Select ();
		}

	}

}
