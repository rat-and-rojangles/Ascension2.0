using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpToScene : MonoBehaviour {

	//public string sceneName;

	public void sceneJump(string sceneName){
		SceneManager.LoadScene (sceneName);
	}
}
