using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : SingletonMonoBehaviour<ExperienceManager> {

	public int experience = 0;
	// Use this for initialization
	void Start () {
		Initialize ();
		Get ();
	}
	//キーを初期化
	void Initialize()
	{
		if (!PlayerPrefs.HasKey ("EXPERIENCE"))
		{
			PlayerPrefs.SetInt("EXPERIENCE",0);
		}
	}
	//キーに保存されている値を取得
	void Get()
	{
		experience = PlayerPrefs.GetInt ("EXPERIENCE");
	}

	//経験値を保存
	public void Save()
	{
		PlayerPrefs.SetInt ("EXPERIENCE", experience);
	}
	//経験値を追加
	public void Add()
	{
		experience += 100;
	}
}
