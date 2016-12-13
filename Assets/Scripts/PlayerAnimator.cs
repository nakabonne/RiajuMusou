using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

	public Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Run()
	{
		animator.SetBool ("isRun",true);
		Debug.Log ("走る");
	}

	public void Stop()
	{
		animator.SetBool ("isRun", false);
		Debug.Log ("止まる");
	}
}
