using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ireba : MonoBehaviour {

	public GameObject tomoaki;
	public Vector3 tomoakiVec;
	// Use this for initialization
	void Start () {
		//プレイヤーを探す
		tomoaki = GameObject.FindGameObjectWithTag("Partner");
		//プレイヤーの横方向の向きを取得
		tomoakiVec = tomoaki.transform.TransformDirection(Vector3.forward)  * 50;
		//プレイヤーの縦方向の向きを取得
		tomoakiVec += Vector3.up * 1;
		// 爆弾にプレイヤーの向いてる方向への力を与える
		this.GetComponent< Rigidbody >().velocity = tomoakiVec;

		// 爆弾を回転させる
		this.GetComponent< Rigidbody >().angularVelocity = Vector3.forward * 7;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
