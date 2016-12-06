using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayreMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}
	//移動する
	void Move()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += transform.forward;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position -= transform.forward;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += transform.right;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position -= transform.right;
		}
	}
}
