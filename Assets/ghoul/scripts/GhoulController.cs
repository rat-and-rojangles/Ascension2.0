using UnityEngine;
using System.Collections;

public class GhoulController : MonoBehaviour {

	public float runSpeed = 1.0f;

	public Transform playerTransform;

	private int runningIndex;
	private bool playerInRange = false;

	private Animator anim;
	private Rigidbody rb;

	void Awake () {
		runningIndex = Animator.StringToHash("Running");
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {
		if (playerInRange) {
			rb.AddForce ( runDirectionVector() *runSpeed );
		}
	}

	private Vector3 runDirectionVector(){
		return Vector3.Normalize (playerTransform.position + transform.position);

	}

	void OnTriggerEnter(Collider other){
		if(other.tag.Equals("Player")){
			playerInRange = true;
			anim.SetBool (runningIndex, true);
		}
	}

	void OnTriggerExit(Collider other){
		if(other.tag.Equals("Player")){
			playerInRange = false;
			anim.SetBool (runningIndex, false);
		}
	}
}
