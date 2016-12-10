using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : SingletonMonoBehaviour<MySceneManager> {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void GOTitle()
	{
		SceneManager.LoadScene ("Title");
	}

	public void GoPrepare()
	{
		SceneManager.LoadScene ("Prepare");
	}

	public void GoPartnerChange()
	{
		SceneManager.LoadScene ("PartnerChange");
	}

	public void GoItemChange()
	{
		SceneManager.LoadScene ("ItemChange");
	}


	public void GoMainGame()
	{
		//スコアの初期化
		ScoreManager.Instance.killedEnemy = 0;
		SceneManager.LoadScene ("Main");
	}

	public void GoResult()
	{
		//経験値の保存
		ExperienceManager.Instance.Save ();
		SceneManager.LoadScene ("Result");
	}
}
