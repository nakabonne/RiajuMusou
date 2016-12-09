using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour {

	//あとで配列にする
	public GameObject level2;

	public GameObject level3;

	bool flag = true; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsLevelOneClear ()) {
			Generate (2);
			flag = false;
		}
		if (IsLevelTwoClear ()) {
			Generate (3);
			flag = true;
		}
	}
	//ステージの生成
	void Generate(int level)
	{
		Debug.Log("呼ばれてるよ");

		switch (level) {
		case 2:
			Debug.Log ("レベル2生成");
			//Instantiate (level2);
			break;
		case 3:
			Debug.Log ("レベル3生成");
			//Instantiate (level3);
			break;
		}


	}


	//レベル1をクリアしたらtrue
	bool IsLevelOneClear()
	{
		return ScoreManager.Instance.killedEnemy >= 10 && flag == true;
	}
	//レベル2をクリアしたらtrue
	bool IsLevelTwoClear()
	{
		return ScoreManager.Instance.killedEnemy >= 20 && flag == false;
	}
}
