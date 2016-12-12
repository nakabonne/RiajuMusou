using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour {
	float hp = 1;

	public Animator animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		//1秒後にhpを決める
		//理由：StageManagerのnowLevelが定義される前に呼ばれることを防ぐため
		Invoke ("DecideHP",1.0f); 

	}
	
	// Update is called once per frame
	void Update () {
		if(hp <= 0){
			Deth ();
		}
	}
	//レベル別でHPを決める
	void DecideHP()
	{
		hp = StageManager.nowLelel * 10.0f;
	}
	//死んだ時
	void Deth()
	{
		GameObject enemyGeneratorObj = GameObject.Find ("EnemyGenerator");
		EnemyGenerator enemyGerator = enemyGeneratorObj.GetComponent<EnemyGenerator> ();

		BossEnemyManager.deathCount++;
		enemyGerator.Generate ();
		AddScore ();
		AddExperience ();
		Destroy (gameObject);
	}

	//衝突判定
	void OnTriggerEnter(Collider other)
	{
		//剣に当たったら
		if (other.gameObject.tag == "Sord") {
			Damage ();
		}
	}

	//ダメージを受けた時の処理
	public void Damage()
	{
		hp--;
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
