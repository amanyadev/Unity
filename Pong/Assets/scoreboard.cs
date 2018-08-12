using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour {
	public GameObject prefabBall;
	public Text scoreP1;
	public Text scoreP2;
	public int P1 = 0;
	public int P2 = 0;
	public GameObject ball;
	public Rigidbody2D rb2D;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindGameObjectWithTag ("ball");
		prefabBall = GetComponent<GameObject> ();
		ball.AddComponent<Rigidbody2D> ();
		if(GameObject.FindGameObjectWithTag ("ball")){
			Debug.Log ("ball found");
		}
	}
	
	// Update is called once per frame
	void Update () {
		GameObject Ball;
		ball = GameObject.FindGameObjectWithTag ("ball");
		if (ball.transform.position.x < -10.6f) {
			Ball = Instantiate (prefabBall,new Vector2(0f,0f),Quaternion.identity);
			P2++;
			Destroy (ball);

			Ball.AddComponent<Ball> ();
		//	Ball.AddComponent<Rigidbody2D> ();

		} else if (ball.transform.position.x > 10.6f) {
			P1++;
			Destroy (ball);
			Ball = Instantiate (prefabBall,new Vector2(0f,0f),Quaternion.identity);
			Ball.AddComponent<Ball> ();
		//	Ball.AddComponent<Rigidbody2D> ();

		}
		//Instantiate (ball,new Vector2(0f,0f),Quaternion.identity);


		scoreP2.text = P2.ToString();
		scoreP2.text = P1.ToString ();
		
	}
	/*void OnCollisionEnter2D(Collision2D coll){
		Destroy(ball);
		Debug.Log ("Ball destroyed");
	}*/
}
