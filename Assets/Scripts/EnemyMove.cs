using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	float speed = 0.2f;

	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.Instance.BeforeGameStart ()) return;
		Move ();
	}
	//移動
	void Move()
	{
		//対象の位置の方向を向く
		transform.LookAt(player.transform);

		//自分自身の位置から相対的に移動する
		transform.Translate(Vector3.forward * speed);
		//transform.Translate (0, 0, speed);
	}
}
