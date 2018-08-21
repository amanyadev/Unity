using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour {
	public GameObject prefabBall;//The ball prefab O.O
	public Text scoreP1;
	public Text scoreP2;
	public int P1 = 0;//Respective scores.
	public int P2 = 0;
	// Use this for initialization
	void Start () {//spawn a ball to begin! 
			spawnBall ();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject ball = GameObject.FindWithTag ("ball");
		if (ball.transform.position.x < -10.6f) {
			P2++;
			Destroy (GameObject.FindWithTag ("ball"));
         	spawnBall ();


		} else if (ball.transform.position.x > 10.6f) {
			P1++;
			Destroy (ball);
			spawnBall ();
		}

	    scoreP2.text = P2.ToString();
		scoreP1.text = P1.ToString();
	}

	void spawnBall(){
		Vector3 location = new Vector3 (0f, 0f, -Camera.main.transform.position.z);
		GameObject newBall = Instantiate (prefabBall) as GameObject;
		newBall.transform.position = location;
	}


}
