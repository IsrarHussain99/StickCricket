using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {

	public Rigidbody RB;

	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		RB.velocity.Set (-3,1,-3);
		RB.AddForce (Vector3 (-3,1,-3,ForceMode.Force));



	}
}
