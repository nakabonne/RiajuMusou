using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : MonoBehaviour {

	public float hp;

	// Use this for initialization
	void Start () {
		DecideHP ();
	}

	void Update()
	{
		if (hp <= 0) {
			Deth ();
		}
	}
	//レベルによってHPを決める
	void DecideHP()
	{
		hp = StageManager.nowLelel;
	}



	//衝突判定
	void OnTriggerEnter(Collider other)
	{
		//剣に当たったら
		if (other.gameObject.tag == "Sord" || other.gameObject.tag =="Partner") {
			Damage ();
		}
	}

	void OnCollisionEnter(Collision other)
	{
		//剣に当たったら
		if (other.gameObject.tag =="Partner") {
			Damage ();
		}
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
