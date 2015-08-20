using UnityEngine;
using System.Collections;

public class PipeLooper : MonoBehaviour {

	int numBGPanels = 6;

	float pipeMax = -0.05188012f;
	float pipeMin = -0.641995f;

	void Start(){
		GameObject[] pipes = GameObject.FindGameObjectsWithTag ("Pipes");

		foreach (GameObject pipe in pipes) {
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range(pipeMin,pipeMax);

			pipe.transform.position = pos;
		}
	}
	
	void OnTriggerEnter2D(Collider2D collider){
		
		float widthBGobject = ((BoxCollider2D)collider).size.x;
		
		Vector3 pos = collider.transform.position;
		
		pos.x += widthBGobject * numBGPanels - widthBGobject/2;

		pos.y = Random.Range (pipeMin, pipeMax);
		
		collider.transform.position = pos;
		
	}
}
