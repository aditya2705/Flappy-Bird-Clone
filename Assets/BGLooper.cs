using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {
	int numBGPanels = 6;

	void OnTriggerEnter2D(Collider2D collider){

		float widthBGobject = ((BoxCollider2D)collider).size.x;

		Vector3 pos = collider.transform.position;

		pos.x += widthBGobject * numBGPanels - widthBGobject/2;

		collider.transform.position = pos;

	}
}
