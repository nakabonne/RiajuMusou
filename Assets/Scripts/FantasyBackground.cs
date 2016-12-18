using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasyBackground : MonoBehaviour {
	public static FantasyBackground instance = null;


	void Awake(){

		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
