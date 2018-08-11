using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	[SerializeField]
	Rigidbody2D rb;
	[SerializeField]
	Vector2 location;
	[SerializeField]
	float speed = 5f;
//	Vector2 speed = new Vector2(0,5f);
	[SerializeField]
	float clamp = 4.8f;
	[SerializeField]
	string ControlAxis;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		location = new Vector3 (rb.position.x, rb.position.y);

	}

	// Update is called once per frame
	void FixedUpdate () {
//		float input = Input.GetAxis ("Vertical");
//		Debug.Log (rb.position.y);
//			
//		if(input>0&&(rb.position.y>=-4.8f||rb.position.y<=4.8f)){
//				rb.AddForce (speed, ForceMode2D.Force);
//			rb.transform.position.y = Mathf.Clamp (rb.position.y, -4.8f, 4.8f);
//			}
//	    	else if (input<0){
//				rb.AddForce (-speed, ForceMode2D.Force);
//			rb.transform.position.y = Mathf.Clamp (rb.position.y, -4.8f, 4.8f);
//			}
//		else if(input == 0 || (rb.position.y<=-4.8f||rb.position.y>=4.8f) ){
//			rb.velocity = Vector2.zero;
//		}
			

		var velocity = rb.velocity;
		if(Input.GetAxis("Vertical")!=0){
			velocity.y = Input.GetAxis (ControlAxis) * speed;
		}
		rb.velocity = velocity;

		location = rb.position;
		if(location.y >clamp){
			location.y = clamp;
		}
		if(location.y<-clamp){
			location.y = -clamp;
		}
		transform.position = location;
	}
}