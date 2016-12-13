using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatyaManager : MonoBehaviour {

	int randomNum = 0;

	public GameObject returnButon;

	// Use this for initialization
	void Start () {
		randomNum = Random.Range (1, 2);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GatyaStart ();
		}
	}
	//ガチャを開始
	void GatyaStart()
	{
		//経験値を減らす
		ExperienceManager.Instance.experience -= 1000;
		//ランダムに選出されたパートナーを生成
		Instantiate (PartnerManager.Instance.RandomPartner (randomNum),new Vector3 (0,0,0),Quaternion.identity);
		//パートナーを使用可にする
		PartnerManager.Instance.EffectivePartner (randomNum);
		//戻るボタンを表示する
		returnButon.SetActive(true);
	}

	public void Return()
	{
		MySceneManager.Instance.GoResult ();
	}

}
