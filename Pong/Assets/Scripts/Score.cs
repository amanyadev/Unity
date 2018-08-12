using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	Ball ballscript;
	public GameObject ball;
	public Text scoreP1;
	public Text scoreP2;
	// Use this for initialization
	void Start () {
		GetComponent<Ball> ();
		scoreP1 = GetComponent<Text> ();
		scoreP2 = GetComponent<Text> ();
		scoreP1.text = 0.ToString();
		scoreP2.text = 0.ToString();
		Debug.Log ("Score 2"+scoreP2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll){
		if(coll.collider.tag=="leftwall"){
			Debug.Log ("BAll hits");
		}
	}
}
