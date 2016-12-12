﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerChange : MonoBehaviour {

	string choosingPartnerName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//パートナーを選択
	public void Choose(string partnerName)
	{
		choosingPartnerName = partnerName;

		Debug.Log (choosingPartnerName + "を選択中");
	}

	//パートナーのチェンジを確定
	public void Change()
	{
		//パートナーを選択している場合はPartnerManagerのパートナー情報を変更する
		if (IsChoosing ()) {
			PartnerManager.Instance.Change (choosingPartnerName);
		}
		//Prepareシーンにリダイレクト
		MySceneManager.Instance.GoPrepare ();
	}
	//パートナーを選択している場合のみtrueを返す
	bool IsChoosing()
	{
		return choosingPartnerName != null;
	}
}