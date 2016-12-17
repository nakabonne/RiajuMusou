using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager> {

	//そのゲームで倒されたエネミーの数
	public int killedEnemy;

	//ハイスコア
	public int highScore;

	void Start()
	{
		//HIGHSCOREキーを初期化
		if (!PlayerPrefs.HasKey ("HIGHSCORE")) {
			PlayerPrefs.SetInt ("HIGHSCORE",0);
		}
		//保存されてるハイスコアを取得
		highScore = PlayerPrefs.GetInt ("HIGHSCORE");
	}
	//スコア追加
	public void Add()
	{
		killedEnemy++;
	}
	//ハイスコアをセット
	public void SetHighScore()
	{
		
		//ハイスコアを超えたら更新
		if (killedEnemy > highScore) {
			highScore = killedEnemy;

			PlayerPrefs.SetInt ("HIGHSCORE", highScore);
		}
	}
}
