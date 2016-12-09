using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour {
	//タイム-------------------------
	TimeManager timeManager;
	public GameObject timeManagerObj;
	public Text time;

	//スコア------------------------
	public Text score;

	// Use this for initialization
	void Start () {
		timeManager = timeManagerObj.GetComponent<TimeManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		Time ();
		Score ();
	}
	//タイムの表示
	void Time()
	{
		time.text = timeManager.time.ToString();
	}
	//スコアの表示
	void Score()
	{
		score.text = "スコア：" + ScoreManager.Instance.killedEnemy.ToString ();
	}
}
