using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	[SerializeField]
	Rigidbody2D rb ;
	[SerializeField]
	float minSpeed = 5f,maxSpeed = 11f;
	float velocity =0;

	//for audio

	public AudioSource source;
	public AudioClip bip;
	public AudioClip paddlepop;
	public AudioClip crash;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		source = GetComponent<AudioSource>();
		velocity = Random .Range(minSpeed, maxSpeed);
		float service = Random .Range(0f, 2f);
		Vector2 direction;
		float angle= Mathf.Deg2Rad*0;
		if(service>=1f){
			angle = Random.Range (50, -50);
		}else if (service<1f){
			angle = Random.Range (130, 230);
		}
//		Debug.Log ("Service Angle" + angle+"Speed "+ velocity);
		direction = new Vector2 (Mathf.Cos (angle*Mathf.Deg2Rad), Mathf.Sin (angle*Mathf.Deg2Rad));
		rb.AddForce (direction * velocity, ForceMode2D.Impulse);

	}

	// Update is called once per frame
	void Update () {

		if (rb.transform.position.x <=-10.5f||rb.transform.position.x >=10.5f) {
			source.PlayOneShot (crash);
		}


	}
	void OnCollisionEnter2D(Collision2D col){
		string col_id = col.gameObject.tag;


		if(col_id=="paddle"){
			source.PlayOneShot(paddlepop);
		}
		if(col_id=="topwall"||col_id=="bottomwall"){
			source.PlayOneShot(bip);
		}
			velocity *= 1.05f;
//			Debug.Log (transform.position.x);
	
		
	}
}
