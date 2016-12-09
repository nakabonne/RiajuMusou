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

	//経験値
	public Text experience;

	// Use this for initialization
	void Start () {
		timeManager = timeManagerObj.GetComponent<TimeManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		Time ();
		Score ();
		Experience ();
	}
	//タイムの表示
	void Time()
	{
		time.text = "Time：" + timeManager.time.ToString("f0");
	}
	//スコアの表示
	void Score()
	{
		score.text = "Score：" + ScoreManager.Instance.killedEnemy.ToString ();
	}
	//獲得経験値の表示
	void Experience()
	{
		experience.text = "Experinence：" + ExperienceManager.Instance.experience.ToString();
	}
}
