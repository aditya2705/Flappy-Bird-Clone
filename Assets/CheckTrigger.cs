using UnityEngine;
using System.Collections;

public class CheckTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Triggered: " + collider.name);
	}
}
