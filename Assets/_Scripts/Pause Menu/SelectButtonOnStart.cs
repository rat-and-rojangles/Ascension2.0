using UnityEngine;
using System.Collections;

using UnityEngine.UI;

//the button with this script attached will be selected by default
public class SelectButtonOnStart : MonoBehaviour {

	void OnEnable () {
		GetComponent<Button> ().Select ();
	}

}
