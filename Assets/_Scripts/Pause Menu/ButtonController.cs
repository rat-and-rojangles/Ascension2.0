using UnityEngine;
using System.Collections;

using UnityEngine.UI;

//the button with this script attached will be selected by default
public class ButtonController : MonoBehaviour {

	public bool selectOnStart = false;

	private Button button;

	void Awake(){
		button = GetComponent<Button> ();
	}

	void OnEnable () {
		//print (GetComponent<Button> ());
		if (selectOnStart) {
			button.Select ();
		}
	}
		
	/*void Update(){
		if(Input.GetKeyDown(Input.GetButton("Submit")) ){
			button.onClick.Invoke ();
		}
	}*/

}
