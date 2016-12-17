using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerManager : SingletonMonoBehaviour<PartnerManager> {

	//public bool hiroshi = false;
	//public bool satoru = false;
	//それぞれを使用できる数
	public int hiroshihCount;
	public int satoruCount;
	public int akioCount;
	public int daisukeCount;
	public int tomoakiCount;
	public int youichiroCount;


	//現在のパートナー
	public GameObject currentPartner;
	//現在のパートナーの名前
	string currentParnerName = "Takeo";

	// Use this for initialization
	void Start () {
		Initialize ();
		Get ();
		PartnerCheck ();
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
	//どのパートナーが使用可能かチェック
	void PartnerCheck()
	{
		hiroshihCount = PlayerPrefs.GetInt ("HIROSHI");
		satoruCount = PlayerPrefs.GetInt ("SATORU");
		akioCount = PlayerPrefs.GetInt ("AKIO");
		daisukeCount = PlayerPrefs.GetInt ("DAISUKE");
		tomoakiCount = PlayerPrefs.GetInt ("TOMOAKI");
		youichiroCount = PlayerPrefs.GetInt ("YOUICHIRO");
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

	//引数の数に対応するパートナーを返す
	public GameObject RandomPartner(int randomNum)
	{
		GameObject partner = null;
		switch (randomNum) {
		case 1:
			partner = (GameObject)Resources.Load ("PrefabPartners/" + "Hiroshi");
			break;
		case 2:
			partner = (GameObject)Resources.Load ("PrefabPartners/" + "Satoru");
			break;
		case 3:
			partner = (GameObject)Resources.Load ("PrefabPartners/" + "Akio");
			break;
		case 4:
			partner = (GameObject)Resources.Load ("PrefabPartners/" + "Daisuke");
			break;
		case 5:
			partner = (GameObject)Resources.Load ("PrefabPartners/" + "Tomoaki");
			break;
		case 6:
			partner = (GameObject)Resources.Load ("PrefabPartners/" + "Youichiro");
			break;
		}

	
		return partner;
	}
	//パートナーの使用回数を表示
	public void EffectivePartner(int id)
	{
		switch (id) {
		case 1:
			hiroshihCount += 3;
			SaveCount ();
			break;
		case 2:
			satoruCount += 3;
			SaveCount ();
			break;
		case 3:
			akioCount += 3;
			SaveCount ();
			break;
		case 4:
			daisukeCount += 3;
			SaveCount ();
			break;
		case 5:
			tomoakiCount += 3;
			SaveCount ();
			break;
		case 6:
			youichiroCount += 3;
			SaveCount ();
			break;
		}
	
	}
	//カウントをセーブ
	public void SaveCount()
	{
		PlayerPrefs.SetInt ("HIROSHI", hiroshihCount);
		PlayerPrefs.SetInt ("SATORU", satoruCount);
		PlayerPrefs.SetInt ("AKIO", akioCount);
		PlayerPrefs.SetInt ("DAISUKE", daisukeCount);
		PlayerPrefs.SetInt ("TOMOAKI", tomoakiCount);
		PlayerPrefs.SetInt ("YOUICHIRO", youichiroCount);
	}

}
