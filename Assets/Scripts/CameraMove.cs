using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + new Vector3 (0, 15, -11);
	}
}
