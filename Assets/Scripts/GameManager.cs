using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	//倒したエネミーの数
	public int killedEnemy;

	//プレイ可能状態ならtrueを返す
	public bool isPlaying;
	// Use this for initialization
	void Start () {
		killedEnemy = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (BeforePlay()) {
			GameStart ();
		}
		//これより下はゲーム開始後しか呼ばれない
		if (!isPlaying) return;
	}
	//ゲームを開始する
	void GameStart()
	{
		isPlaying = true;
	}

	//ゲーム開始前に左クリックをしたらtrue
	bool BeforePlay()
	{
		return Input.GetMouseButtonDown (0) && !isPlaying;
	}
}
