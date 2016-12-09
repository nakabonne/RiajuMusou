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
		//デバッグ用
		if (Input.GetKeyDown (KeyCode.S)) {
			Damage ();
		}
		if (hp <= 0) {
			Deth ();
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

	//ダメージを受けた時の処理
	public void Damage()
	{
		hp--;
	}

	//死んだ時の処理
	void Deth()
	{
		AddScore ();
		AddExperience ();
	
		Destroy (gameObject);
	}
	//スコアを追加する
	void AddScore()
	{
		ScoreManager.Instance.Add ();
	}
	//経験値を追加する
	void AddExperience()
	{
		ExperienceManager.Instance.Add ();
	}
}
