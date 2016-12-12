using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour {

	//あとで配列にする
	public GameObject level2;

	public GameObject level3;
	//次のレベル
	int nextLevel;
	// Use this for initialization
	void Start () {
		nextLevel = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (IsLevelOneClear ()) {
			Generate (2);
			nextLevel = 2;
		}
		if (IsLevelTwoClear ()) {
			Generate (3);
			nextLevel = 3;
		}
	}
	//ステージの生成
	void Generate(int level)
	{

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
		return ScoreManager.Instance.killedEnemy >= 20 && nextLevel == 1;
	}
	//レベル2をクリアしたらtrue
	bool IsLevelTwoClear()
	{
		return ScoreManager.Instance.killedEnemy >= 40 && nextLevel == 2;
	}
}
