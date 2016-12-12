using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	//現在のレベル
	int nowLevel;
	public GameObject level1Enemy;
	public GameObject level2Enemy;

	// Use this for initialization
	void Start () {
		nowLevel = 1;
		//レベル1の敵生成
			Level1 ();
	}
	
	// Update is called once per frame
	void Update () {
		if (ScoreManager.Instance.killedEnemy >= 100 && nowLevel == 1) {
			Level2 ();
		}
	}

	//レベル1の生成位置
	Vector3 GeneratePosLevel1()
	{
		return new Vector3 (Random.Range (-12, 12), 2, Random.Range (0, 230));
	}
	//レベル1の敵を生成
	void Level1()
	{
		for (int i = 0; i < 50; i++) {	
			Instantiate (level1Enemy, GeneratePosLevel1 (), new Quaternion (0, Random.Range (0, 360), 0, 0));
		}
	}

	//レベル2の生成位置
	Vector3 GeneratePosLevel2()
	{
		return new Vector3 (Random.Range (-12, 12), 2, Random.Range (250, 480));
	}
	//レベル2の敵を生成
	void Level2()
	{
		for (int i = 0; i < 50; i++) {
			Instantiate (level2Enemy, GeneratePosLevel2 (), new Quaternion (0, Random.Range (0, 360), 0, 0));
		}
		nowLevel = 2;
	}



}
