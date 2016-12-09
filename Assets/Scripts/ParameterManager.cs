using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterManager : SingletonMonoBehaviour<ParameterManager> {
	//剣の長さ
	public int sordLength;
	//スピード
	public int speed;

	void Start()
	{
		Initialize ();
		Get ();
	}
	//キーを初期化
	void Initialize()
	{
		if (!PlayerPrefs.HasKey ("SORDLENGTH"))
		{
			PlayerPrefs.SetInt("SORDLENGTH",1);
		}
		if (!PlayerPrefs.HasKey ("SPEED"))
		{
			PlayerPrefs.SetInt("SPEED",1);
		}
	}
	//キーに保存されている値を取得
	void Get()
	{
		sordLength = PlayerPrefs.GetInt ("SORDLENGTH");
		speed = PlayerPrefs.GetInt ("SPEED");
	}
	//保存
	void Save()
	{
		PlayerPrefs.SetInt ("SORDLENGTH",sordLength);
		PlayerPrefs.SetInt ("SPEED",speed);
	}
}
