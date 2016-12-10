using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerManager : SingletonMonoBehaviour<PartnerManager> {

	//現在のパートナー
	public GameObject currentPartner;
	//現在のパートナーの名前
	string currentParnerName;

	// Use this for initialization
	void Start () {
		Initialize ();
		Get ();
	}
	//キーを初期化
	void Initialize()
	{
		if (!PlayerPrefs.HasKey ("PARTNER"))
		{
			PlayerPrefs.SetString("PARTNER","");
		}
	}
	//キーに保存されている値を取得
	void Get()
	{
		currentParnerName = PlayerPrefs.GetString ("PARTNER");
		//パートナーがすでに選択され、保存されている場合
		if (IsChoosingPartner()) {
			//パートナーを、保存されているものに変更する
			Change (currentParnerName);
		}
	}

	//パートナー変更
	public void Change(string name)
	{
		//何も選択しなかったらパートナーは変更しない
		if (name == "") return;
		currentPartner = (GameObject)Resources.Load ("PrefabPartners/" + name);
		//保存
		PlayerPrefs.SetString ("PARTNER", name);
		Debug.Log ("パートナーは" + name + "に変更");
	}
	//パートナーがすでに選択され、保存されている場合trueを返す
	bool IsChoosingPartner()
	{
		return currentParnerName != "";
	}


}
