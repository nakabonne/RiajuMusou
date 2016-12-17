using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatyaManager : MonoBehaviour {

	int randomNum = 0;

	public GameObject returnButon;

	public GameObject gatyaButton;

	// Use this for initialization
	void Start () {
		randomNum = Random.Range (1, 7);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//ガチャを開始
	public void GatyaStart()
	{
		//経験値を減らす
		ExperienceManager.Instance.experience -= 1000;
		ExperienceManager.Instance.Save ();
		//ランダムに選出されたパートナーを生成
		Instantiate (PartnerManager.Instance.RandomPartner (randomNum),new Vector3 (0,0,0),Quaternion.identity);
		//パートナーを使用可にする
		PartnerManager.Instance.EffectivePartner (randomNum);
		//戻るボタンを表示する
		returnButon.SetActive(true);
		//ガチャボタンを非表示にする
		gatyaButton.SetActive(false);
	}

	public void Return()
	{
		MySceneManager.Instance.GoResult ();
	}

}
