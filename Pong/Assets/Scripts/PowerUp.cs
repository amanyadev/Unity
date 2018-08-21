using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
	//currently only one powerup
	//grow paddle.
	public int spawningTime = 10;
	public int powerupDuration = 6;
	[SerializeField]
	 GameObject Paddle1;
	[SerializeField]
	 GameObject Paddle2;
	[SerializeField]
	 GameObject ball;
	[SerializeField]
	 Rigidbody2D rbPaddle1;
	[SerializeField]
	 Rigidbody2D rbPaddle2;
	[SerializeField]
     Rigidbody2D rbBall;

	Vector3 originalScale;
	int turns = 0;
	string shrinkNeeded ="";
	public bool flag = false;
	// Use this for initialization
	void Start () {
		
		Paddle1 = GameObject.FindWithTag("paddle");
		Paddle2 = GameObject.FindWithTag ("Comp<3");
		rbPaddle1 =Paddle1.GetComponent<Rigidbody2D> ();
		rbPaddle2 = Paddle2.GetComponent<Rigidbody2D> ();
		originalScale = Paddle1.GetComponent<Transform> ().localScale = new Vector3(2.5f,3f,1f);
		Shrink ("paddle");
		Shrink ("Comp<3");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(GameObject.FindWithTag ("ball")==true){
			ball = GameObject.FindWithTag ("ball");
		rbBall = ball.GetComponent<Rigidbody2D> ();
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		string id = col.gameObject.tag;
	//	Debug.Log (id+"in here"+Ball.collisionCount);
		Ball.collisionCount++;
		if(Ball.collisionCount>spawningTime&&flag == false){
			/*if(id=="paddle"){
				Debug.Log ("now inside wholesome riches");
				Vector3 scale = Paddle1.GetComponent<Transform> ().localScale;
				scale = new Vector3 (scale.x, 1.3f * scale.y, scale.z);
				Paddle1.transform.localScale = scale;*/
			if (id == "paddle" || id == "Comp<3") {
				Grow (id,col);
				flag = true;
				turns = 0;

			}
			}
		if(flag == true){
			turns++;
		}
		if(turns >powerupDuration||Ball.collisionCount>20){
			flag=false;
			Ball.collisionCount = 0;
			Shrink (shrinkNeeded);
			turns = 0;

		}
			//now get id of paddle. and add powerup

		}
	public void Grow(string id,Collision2D col){

		Vector3 scale = col.gameObject.GetComponent<Transform> ().localScale;
			scale = new Vector3 (scale.x, 1.3f * scale.y, scale.z);
			col.gameObject.transform.localScale = scale;
		shrinkNeeded = col.gameObject.tag;
		Debug.Log (shrinkNeeded);

	}
	public void Shrink(string id){
		GameObject temp = GameObject.FindWithTag (id);
		temp.transform.localScale = originalScale;

	}

}
