using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {

	public GameObject ball_prefab;
	public GameObject bat;

	// Use this for initialization
	void Start () {
		InvokeRepeating("ThrowBall",3f,3f);
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void ThrowBall(){
		//set bat correctly
		Vector3 temp = bat.transform.rotation.eulerAngles ;
		temp.x = -90; temp.y = 0; temp.z = 90;
		bat.transform.rotation = Quaternion.Euler (temp);


		//bat.transform.rotation.Set (-90, 0, 90, 0);
		Rigidbody rb = bat.GetComponent<Rigidbody>();
		rb.isKinematic = false;

		//throw ball
		GameObject ball_clone = (GameObject) Instantiate(ball_prefab, ball_prefab.transform.position, ball_prefab.transform.rotation);
		Rigidbody ball_rb = ball_clone.GetComponent<Rigidbody>();
		/*
		float horizontal_angle = Mathf.Atan (8.0f / 11.0f);
		float vertical_angle = 1.047f; //60 degrees

		float velocity = 15.0f;
		float horizontal_force = 15.0f;


		ball_rb.velocity.Set (-velocity*Mathf.Cos(vertical_angle)*Mathf.Sin(horizontal_angle),velocity*Mathf.Sin(vertical_angle),-velocity*Mathf.Cos(vertical_angle)*Mathf.Cos(horizontal_force));
		ball_rb.AddForce (-horizontal_force*Mathf.Sin(horizontal_angle),0,-horizontal_force*Mathf.Cos(horizontal_angle),ForceMode.Impulse);
		*/

		float speed = 20f;
		float step = speed * Time.deltaTime;
		Vector3 direction = (bat.transform.position - ball_rb.transform.position);
		direction.Normalize();
		ball_rb.AddForce (direction * 35,ForceMode.Acceleration);

		ball_rb.transform.position = Vector3.MoveTowards(ball_rb.transform.position,bat.transform.position, step);

		//after hit by bat destroy it
        //emd here
	}


}