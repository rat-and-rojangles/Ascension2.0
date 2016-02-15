using UnityEngine;
using System.Collections;

public class EnemyDamaged : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.tag.Equals ("DamageDoneByPlayer")) {
			print ("ENEMY DAMAGED");
		}
	}
}
