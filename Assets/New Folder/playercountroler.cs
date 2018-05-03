using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercountroler : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");	
	

		Vector3 dir = new Vector3 (h, 0, v);
	
		rb.AddForce (dir * speed);
	}
}