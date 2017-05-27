using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {

	public GameObject ball_prefab;
	public static bool ready_to_throw_ball ;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		InvokeRepeating("ThrowBall",1f,5f);

	}

	void ThrowBall(){
		//set bat correctly
		hit.transform.rotation.Set (-90, 0, 90, 0);
		Rigidbody rb = hit.GetComponent<Rigidbody>();
		rb.isKinematic = false;

		//throw ball
		GameObject ball_clone = (GameObject) Instantiate(ball_prefab, ball_prefab.transform.position, ball_prefab.transform.rotation);
		Rigidbody ball_rb = ball_clone.GetComponent<Rigidbody>();
		float horizontal_angle = Mathf.Atan (8.0f / 11.0f);
		float vertical_angle = 1.047f; //60 degrees

		float velocity = 15.0f;
		float horizontal_force = 15.0f;


		ball_rb.velocity.Set (-velocity*Mathf.Cos(vertical_angle)*Mathf.Sin(horizontal_angle),velocity*Mathf.Sin(vertical_angle),-velocity*Mathf.Cos(vertical_angle)*Mathf.Cos(horizontal_force));
		ball_rb.AddForce (-horizontal_force*Mathf.Sin(horizontal_angle),0,-horizontal_force*Mathf.Cos(horizontal_angle),ForceMode.Impulse);


		//after hit by bat destroy it
	}


}