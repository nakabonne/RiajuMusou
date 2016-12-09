using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager> {

	//そのゲームで倒されたエネミーの数
	public int killedEnemy;

	// Use this for initialization
	void Start () {
		//スコアの初期化
		killedEnemy = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//デバッグ用
		if (Input.GetKeyDown (KeyCode.A)) {
			AddScore ();
		}
	}
	//スコア追加
	public void AddScore()
	{
		killedEnemy++;
	}

}
