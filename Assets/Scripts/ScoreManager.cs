using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager> {

	//そのゲームで倒されたエネミーの数
	public int killedEnemy;

	//スコア追加
	public void Add()
	{
		killedEnemy++;
	}

}
