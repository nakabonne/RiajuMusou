using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : MonoBehaviour {

	public int hp;

	// Use this for initialization
	void Start () {
		DecideHP ();
	}

	void Update()
	{
		if (hp <= 0) {
			AddScore ();
		}
	}
	//レベルによってHPを決める
	void DecideHP()
	{
		if (LevelisOne())
			hp = 2;
	}


	//このインスタンスがレベル1ならtrueを返す
	bool LevelisOne()
	{
		return this.gameObject.tag == "Level1";
	}

	//死んだ時にスコアを追加する
	void AddScore()
	{
		ScoreManager.Instance.AddScore ();
	}
}
