using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Generate ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public GameObject enemy;
	//生成
	public void Generate()
	{
		for (int i = 0; i < 50; i++) {
			Instantiate(enemy,GeneratePos(),Quaternion.identity);
		}
		StageChange ();

	}
	Vector3 GeneratePos()
	{
		return new Vector3 (Random.Range (-12, 12), 2, Random.Range (transform.position.z + 20, transform.position.z + 200));
	}

//	//最初の生成
//	void FirstGenerate()
//	{
//		for (int i = 0; i < 50; i++) {
//			Instantiate (enemy, GeneratePos (), new Quaternion (0, Random.Range (0, 360), 0, 0));
//		}
//	}
//	//生成する
//	public void Generate()
//	{
//		//2人とも死なないと実行されない
//		if (BossEnemyManager.deathCount <= 1) return;
//		Debug.Log (GeneratePos ());
//		for (int i = 0; i < 50; i++) {
//			Instantiate (enemy, GeneratePos (), new Quaternion (0, Random.Range (0, 360), 0, 0));
//		}
//		StageChange ();
//	}
	//ステージを一新する
	void StageChange()
	{
		StageManager.nowLelel++;
		GameObject gateObj = GameObject.FindGameObjectWithTag ("Gate");
		Gate gate = gateObj.GetComponent<Gate> ();
		BossEnemyManager.deathCount = 0;
		if (StageManager.nowLelel <= 1) return;
		//ゲートを開ける
		gate.Open ();
		BossGenerate ();
	}
//	//生成ポジション
//	Vector3 GeneratePos()
//	{
//		return new Vector3 (Random.Range (-12, 12), 2, -Random.Range (Depth () - 230, Depth ()));
//	}
//	//生成の奥行きをレベル別で決定
//	float Depth()
//	{
//		return StageManager.nowLelel * 230.0f;
//	}
//

	public GameObject boss;

	GameObject gate;

	//	//ボスの生成
	public void BossGenerate()
	{
		gate = GameObject.FindGameObjectWithTag ("Gate");
		Instantiate (boss, gate.transform.position + new Vector3 (0, 0, -10), Quaternion.identity);
	}








}

//	//レベル1の生成位置
//	Vector3 GeneratePosLevel1()
//	{
//		return new Vector3 (Random.Range (-12, 12), 2, Random.Range (0, 230));
//	}
//	//レベル1の敵を生成
//	void Level1()
//	{
//		for (int i = 0; i < 50; i++) {	
//			Instantiate (level1Enemy, GeneratePosLevel1 (), new Quaternion (0, Random.Range (0, 360), 0, 0));
//		}
//	}
//
//	//レベル2の生成位置
//	Vector3 GeneratePosLevel2()
//	{
//		return new Vector3 (Random.Range (-12, 12), 2, Random.Range (250, 480));
//	}
//	//レベル2の敵を生成
//	void Level2()
//	{
//		for (int i = 0; i < 50; i++) {
//			Instantiate (level2Enemy, GeneratePosLevel2 (), new Quaternion (0, Random.Range (0, 360), 0, 0));
//		}
//		nowLevel = 2;
//	}

