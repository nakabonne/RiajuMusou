using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUIManager : MonoBehaviour {

	public Text score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Score ();
	}
	//スコアを表示
	void Score()
	{
		score.text = ScoreManager.Instance.killedEnemy.ToString ();
	}
	//リトライ
	public void Retry()
	{
		MySceneManager.Instance.GoMainGame ();
	}
}
