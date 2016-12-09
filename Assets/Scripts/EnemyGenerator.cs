using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	public GameObject level1Enemy;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			Level1 ();
		}
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	//生成位置
	Vector3 GeneratePos()
	{
		return new Vector3 (Random.Range (-12, 12), 2, Random.Range (-12, 12));
	}

	//レベル1の敵を生成
	void Level1()
	{
		Instantiate (level1Enemy,GeneratePos(),new Quaternion (0,Random.Range(0,360),0,0));
	}

}
