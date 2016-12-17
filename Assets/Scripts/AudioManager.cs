using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : SingletonMonoBehaviour<AudioManager> {

	AudioSource bgm;
	// Use this for initialization
	void Start () {
		bgm = GetComponent<AudioSource> ();
		bgm.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
