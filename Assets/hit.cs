using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour {

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
		if (Input.GetKeyDown(KeyCode.DownArrow))
        {
					Debug.Log("Down");
        }
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
					Debug.Log("Left");
        }
		else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
					Debug.Log("Up");
        }
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			Debug.Log("Right");
		}
		else if (Input.GetKeyDown(KeyCode.W))
		{
			Debug.Log("W");
		}
		else if (Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("A");
		}
		else if (Input.GetKeyDown(KeyCode.Z))
		{
			Debug.Log("Z");
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			Debug.Log("S");
		}

    }
}
