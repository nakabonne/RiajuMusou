using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	float speed = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.Instance.BeforeGameStart ()) return;
		Move ();
	}
	//移動
	void Move()
	{
		transform.Translate (0, 0, speed);
	}
}
