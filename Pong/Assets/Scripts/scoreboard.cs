using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour {
/*	public Timer timer;*/
	public GameObject prefabBall;
	public Text scoreP1;
	public Text scoreP2;
	public int P1 = 0;
	public int P2 = 0;
	// Use this for initialization
	void Start () {
		/*timer = gameObject.AddComponent<Timer> ();
		timer.Duration = 1f;*/
		if (GameObject.FindGameObjectWithTag ("ball")) {
			Debug.Log ("ball found");
		}
			spawnBall ();

		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject ball = GameObject.FindWithTag ("ball");
		if (ball.transform.position.x < -10.6f) {
			P2++;
			Destroy (GameObject.FindWithTag ("ball"));
/*			timer.Run ();
			if(timer.Finished)
*/			spawnBall ();


		} else if (ball.transform.position.x > 10.6f) {
			P1++;
			Destroy (ball);
			/*timer.Run();
			if(timer.Finished)*/
			spawnBall ();
		}
		//Instantiate (ball,new Vector2(0f,0f),Quaternion.identity);


	    scoreP2.text = P2.ToString();
		scoreP1.text = P1.ToString();
		
	}
	/*void OnCollisionEnter2D(Collision2D coll){
		Destroy(ball);
		Debug.Log ("Ball destroyed");
	}*/

	void spawnBall(){
		
		Debug.Log ("Inside SpawnBall method");
		Vector3 location = new Vector3 (0f, 0f, -Camera.main.transform.position.z);
		/*	Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);*/

		GameObject newBall = Instantiate (prefabBall) as GameObject;
		newBall.transform.position = location;
	}


}
