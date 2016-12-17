using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObj : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
			transform.position = new Vector3 (0, player.transform.position.y, player.transform.position.z + 24.0f);
	}
}
