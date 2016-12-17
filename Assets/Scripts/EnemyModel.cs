using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel : MonoBehaviour {

	public float hp;

	public GameObject spark;

	public Animator animator;

	// Use this for initialization
	void Start () {
		DecideHP ();
		animator = GetComponent<Animator> ();
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
		//火花生成
		Instantiate (spark, transform.position + new Vector3(0,3.0f,0), Quaternion.identity);
	}

	//死んだ時の処理
	void Deth()
	{
		AddScore ();
		AddExperience ();
		//Deathアニメーション実行
		animator.SetBool ("isDeath", true);
	
		Destroy (gameObject,2.0f);
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
