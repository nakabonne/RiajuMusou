using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUIManager : MonoBehaviour {

	public Text score;

	public Text experience;
	//動画広告を見せるボタン
	public GameObject movieShowButton;
	//剣のレベルを表示
	public Text sordLengthLevel;
	//スピードのレベルを表示
	public Text speedLevel;

	//乱数
	int movieRandomShowTiming;
	// Use this for initialization
	void Start () {
		//動画広告ボタンを非表示に
		movieShowButton.SetActive (false);
		//動画を表示するか決定
		movieRandomShowTiming = AdvertiseManger.Instance.MovieShowTiming ();
	}
	
	// Update is called once per frame
	void Update () {
		Score ();
		Experience ();
		ShowMovie ();
		Level ();

	}
	//スコアを表示
	void Score()
	{
		score.text = ScoreManager.Instance.killedEnemy.ToString ();
	}
		
	//経験値を表示
	void Experience()
	{
		experience.text = ExperienceManager.Instance.experience.ToString ();
	}
	//各パラメーターレベルを表示
	void Level()
	{
		sordLengthLevel.text = "Lv:" + ParameterManager.Instance.sordLength;

		speedLevel.text = "Lv:" + ParameterManager.Instance.speed;
	}
	//リトライ
	public void Retry()
	{
		MySceneManager.Instance.GoMainGame ();
	}
	//動画広告ボタンをランダムに生成
	void ShowMovie()
	{
		if (movieRandomShowTiming == 1) {
			movieShowButton.SetActive (true);
		}
	}
}
