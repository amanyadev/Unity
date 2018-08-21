using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
	public Transform pad;
	public Transform target;
	public float speed = 5f;
	public float jam = 1f;// so that paddle is not too fast used later for dynamic difficulty.
	// Use this for initialization
	void Start () {
		target =GameObject.FindWithTag ("ball").GetComponent<Transform>();
		pad = GameObject.FindWithTag ("Comp<3").GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		if (GameObject.FindWithTag ("ball")&&GameObject.FindWithTag("Comp<3")) {
			target =GameObject.FindGameObjectWithTag("ball").GetComponent<Transform>();
			pad = GameObject.FindGameObjectWithTag("Comp<3").GetComponent<Transform> ();
			Vector2 loc1 = pad.position;
			Vector2 loct = new Vector2 (pad.position.x, target.position.y);
			if (Mathf.Abs(loc1.x - target.transform.position.x) <5) {
				pad.position = Vector2.MoveTowards (loc1, loct, speed*Time.deltaTime*jam);
			}
		}
	}
}
