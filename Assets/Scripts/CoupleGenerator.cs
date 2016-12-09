using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//現状使ってない
public class CoupleGenerator : MonoBehaviour {
	public GameObject couple;

	Vector3 randomGeneratePos;
	// Use this for initialization
	void Start () {
		randomGeneratePos = new Vector3 (5, 0, 5);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}








	//ランダムに生成する
//	void RandomGenerate()
//	{
//		Instantiate (couple,RandomGeneratePos,Quaternion.identity);
//		//次回の生成ポジションをランダムに
//		generatePos = new Vector3 (Random.Range (1.0f, 5.0f), 1.0f, Random.Range (1.0f, 5.0f));
//		//1秒後にこの関数を呼び出す
//		Invoke ("Generate", 1.0f);
//	}
}
