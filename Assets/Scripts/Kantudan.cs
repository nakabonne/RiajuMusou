using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kantudan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, 1);
	}
}
