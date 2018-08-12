using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	[SerializeField]
	Rigidbody2D rb ;
	[SerializeField]
	float minSpeed = 2f,maxSpeed = 10f;
	float velocity =0;
	int count = 0;
	//for audio
	public AudioSource bip;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		bip = GetComponent<AudioSource> ();
		velocity = Random .Range(minSpeed, maxSpeed);
		float service = Random .Range(0f, 2f);
		Vector2 direction;
		float angle= Mathf.Deg2Rad*0;
		if(service>=1f){
			angle = Random.Range (50, 310);
		}else if (service<1f){
			angle = Random.Range (130, 230);
		}
		direction = new Vector2 (Mathf.Cos (angle*Mathf.Deg2Rad), Mathf.Sin (angle*Mathf.Deg2Rad));
		rb.AddForce (direction * velocity, ForceMode2D.Impulse);

	}
	
	// Update is called once per frame
	void Update () {
		


	}
	void OnCollisionEnter2D(Collision2D col){
		bip.Play ();
			velocity *= 1.03f;
			Debug.Log (transform.position.x);
	
		
	}
}
