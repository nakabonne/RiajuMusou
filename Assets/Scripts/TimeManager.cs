using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	public float time = 30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CountDown ();
	}

	//時間を減らす
	void CountDown()
	{
		time -= 1.0f * Time.deltaTime;
	}
}
