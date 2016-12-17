using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamModoki : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, 4);
	}
}
