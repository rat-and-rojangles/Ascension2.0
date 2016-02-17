using UnityEngine;
using System.Collections;

public class GhoulController : MonoBehaviour {

	public Transform playerTransform;

	private int runningIndex;
	private bool playerInRange = false;

	private Animator anim;
	private Rigidbody rb;


	public float runSpeed = 300.0f;

	private float cooldownRemainingTime = 0.0f;	
	private const float maxCooldown = 1.0f;

	void Awake () {
		runningIndex = Animator.StringToHash("Running");
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody> ();
	}

	void Update(){
		if (cooldownRemainingTime > 0) {
			cooldownRemainingTime -= Time.deltaTime;
		}
	}

	// adding force makes it swing all over the place
	// velocity makes it smoother and won't swing out of range
	void FixedUpdate () {
		if (playerInRange) {

			//this does the rotation
			transform.LookAt ( new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z) );	//rotation

			if (cooldownRemainingTime <= 0) {	//don't charge while cooling down
				//rb.AddForce ( runDirectionVector() *runSpeed );
				rb.velocity = DirectionFacingPlayer () * runSpeed * Time.deltaTime;
			}
		}
	}

	//DIRECTION VECTOR = target - self
	private Vector3 DirectionFacingPlayer(){
		return Vector3.Normalize (playerTransform.position - transform.position);

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

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag.Equals ("Player")) {
			//player hit
			print("Player got rekt");
			cooldownRemainingTime = maxCooldown;

			//jump back so that the enemy doesn't hug the player
			rb.AddForce( -400 * DirectionFacingPlayer() );
			//rb.velocity = -2500 * runDirectionVector();
		}
	}
}
