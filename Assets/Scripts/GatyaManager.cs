using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GatyaManager : MonoBehaviour {

	int randomNum = 0;

	public GameObject returnButon;

	public GameObject gatyaButton;
	public GameObject gatyabutton;

	public GameObject house;

	public GameObject explosion;

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
		Debug.Log ("がちゃーーー");
		house.transform.DOPunchScale (new Vector3 (2f, 2f, 2f), 3f, 3, 0);
		Invoke ("Tanjou",2.0f);
		//経験値を減らす
		ExperienceManager.Instance.experience -= 1000;
		ExperienceManager.Instance.Save ();
		//ランダムに選出されたパートナーを生成
		Instantiate (PartnerManager.Instance.RandomPartner (randomNum),new Vector3 (0,0,-5.0f),Quaternion.identity);
		//パートナーを使用可にする
		PartnerManager.Instance.EffectivePartner (randomNum);
		//ガチャボタンを非表示にする
		gatyaButton.SetActive(false);
		gatyabutton.SetActive (false);
		Invoke ("ReturnButtonDisplay", 3.0f);

	}
	void ReturnButtonDisplay()
	{
		//戻るボタンを表示する
		returnButon.SetActive(true);
	}

	void Tanjou()
	{
		Instantiate (explosion, house.transform.position + new Vector3 (0,1.0f,0), Quaternion.identity);
		Destroy (house);
	}

	public void Return()
	{
		MySceneManager.Instance.GoResult ();
	}

}
