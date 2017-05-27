using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour {

	public float thrust;
	// Use this for initialization
	void Start () {

			
	}
	
	// Update is called once per frame
	void Update () {
		/*if ( (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow)) || (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow)))
		{
			Debug.Log("LU");
		}
		else if ( (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) || (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow)))
		{
			Debug.Log("RU");

		}
		else if ( (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow)) || (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow)))
		{
			Debug.Log("RD");
		}
		else if ( (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow)) || (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow)))
		{
			Debug.Log("LD");
		}
		else if (Input.GetButtonDown("Fire1"))
        {
					Debug.Log("Up");
        }*/
		
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			Debug.Log ("Down");
			transform.Rotate (0, -45, 0);
			Rigidbody rb = GetComponent<Rigidbody> ();
			//rb.velocity.Set ();
			rb.isKinematic = true;
			rb.AddForce (transform.right * thrust);
					
		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Debug.Log ("Left");
			transform.Rotate (45, 0, 0);
			Rigidbody rb = GetComponent<Rigidbody> ();
			//rb.velocity.Set ();
			rb.isKinematic = true;
			rb.AddForce (transform.right * thrust);

		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.Rotate (0, 45, 0);
			Debug.Log ("Up");
			Rigidbody rb = GetComponent<Rigidbody> ();
			//rb.velocity.Set ();
			rb.isKinematic = true;
			rb.AddForce (transform.right * thrust);

		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Debug.Log ("Right");
			transform.Rotate (-45, 0, 0);
			Rigidbody rb = GetComponent<Rigidbody> ();
			//rb.velocity.Set ();
			rb.isKinematic = true;
			rb.AddForce (transform.right * thrust);

		} else if (Input.GetKeyDown (KeyCode.Q)) {
			Debug.Log ("Q");
			transform.Rotate (45, 45, 0);
			Rigidbody rb = GetComponent<Rigidbody> ();
			//rb.velocity.Set ();
			rb.isKinematic = true;
			rb.AddForce (transform.right * thrust);

		} else if (Input.GetKeyDown (KeyCode.W)) {
			Debug.Log ("W");
			transform.Rotate (-45, 45, 0);
			Rigidbody rb = GetComponent<Rigidbody> ();
			//rb.velocity.Set ();
			rb.isKinematic = true;
			rb.AddForce (transform.right * thrust);

		} else if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log ("A");
			transform.Rotate (45, -45, 0);
			Rigidbody rb = GetComponent<Rigidbody> ();
			rb.isKinematic = true;
			rb.AddForce (transform.right * thrust);
		} else if (Input.GetKeyDown (KeyCode.S)) {
			Debug.Log ("S");
			transform.Rotate (-45, -45, 0);
			Rigidbody rb = GetComponent<Rigidbody> ();
			//rb.velocity.Set ();
			rb.isKinematic = true;
			rb.AddForce (transform.right * thrust);

		}
	
	}
		
}
