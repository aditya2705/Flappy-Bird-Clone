using UnityEngine;
using System.Collections;

public class SkyMover : MonoBehaviour {

	Rigidbody2D player;
	// Use this for initialization
	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		
		if (player_go == null) {
			
		}
		player = player_go.rigidbody2D;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float vel =player.velocity.x*0.9f;
		transform.position += Vector3.right * vel * Time.deltaTime;
	}
}
