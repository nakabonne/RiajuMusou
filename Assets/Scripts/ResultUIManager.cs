using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUIManager : MonoBehaviour {

	public Text score;

	public Text experience;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Score ();
		Experience ();
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
	//リトライ
	public void Retry()
	{
		MySceneManager.Instance.GoMainGame ();
	}
}
