using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {
	float flapSpeed = 175f;
	float forwardSpeed = 1f;
	bool didFlap = false;
	public bool dead = false;

	float deathCooldown=1f;
	// Use this for initialization
	void Start () {
	
	}

	//for all frames #graphics, #input
	void Update(){

		if (dead) {
			deathCooldown -= Time.deltaTime;
		}

		if (deathCooldown <= 0) {
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
				Application.LoadLevel(Application.loadedLevel);
			} else if (Input.touchCount > 0) {
				for (var i = 0; i < Input.touchCount; ++i) {
					if (Input.GetTouch(i).phase == TouchPhase.Began) {
						Application.LoadLevel(Application.loadedLevel);
					}
				}
			}

		}

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			didFlap = true;
		} else if (Input.touchCount > 0) {
			for (var i = 0; i < Input.touchCount; ++i) {
				if (Input.GetTouch(i).phase == TouchPhase.Began) {
					didFlap = true;
				}
			}
		}

		if (Input.GetKeyDown(KeyCode.Escape)) 
				Application.Quit(); 
	
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (dead)
			return;
				rigidbody2D.AddForce (Vector2.right * forwardSpeed);

				if (didFlap) {
						rigidbody2D.AddForce (Vector2.up * flapSpeed);
						didFlap = false;
				}
		}

	void OnCollisionEnter2D(Collision2D collision){
		dead = true;
	}
}
