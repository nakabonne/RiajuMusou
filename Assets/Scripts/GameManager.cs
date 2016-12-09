using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager> {

	//プレイ可能状態ならtrueを返す
	public bool isPlaying;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (BeforePlayClick()) {
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

	//ゲーム開始前に右クリックをしたらtrue
	bool BeforePlayClick()
	{
		return Input.GetMouseButtonDown (1) && !isPlaying;
	}
	//ゲームが始まってなかったらtrueを返す
	public bool BeforeGameStart()
	{
		return !isPlaying;
	}
		
}
