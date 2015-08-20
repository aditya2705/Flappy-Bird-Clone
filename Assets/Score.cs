using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static public int score = 0;
	static public int highscore = 0;
	static Score instance;

	static public void AddPoint(){
		if (instance.bird.dead)
			return;
		++score;
		if (score > highscore) {
			highscore=score;
		}

	}
	BirdMovement bird;

	void Start(){
		instance = this;
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		bird = player_go.GetComponent<BirdMovement> ();
		score = 0;
		highscore = PlayerPrefs.GetInt ("highScore", 0);
	}

	void OnDestroy(){
		instance = null;
		PlayerPrefs.SetInt ("highScore", highscore);
	}
	// Update is called once per frame
	void Update () {
		guiText.text = "Score:" + score+"\n"+"HighScore: "+highscore;
	}
}
