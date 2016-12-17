using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Generate ();
		CutDownCount ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//パートナー生成
	void Generate()
	{
		//カウントが0のパートナーを選択していたら強制的にたけおにする
		if (PartnerManager.Instance.currentPartner.name == "Hiroshi" && PartnerManager.Instance.hiroshihCount <= 0) {
			PartnerManager.Instance.currentPartner = (GameObject)Resources.Load ("PrefabPartners/Takeo");
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, -2, 1), Quaternion.identity);
		}
		if (PartnerManager.Instance.currentPartner.name == "Satoru" && PartnerManager.Instance.satoruCount <= 0) {
			PartnerManager.Instance.currentPartner = (GameObject)Resources.Load ("PrefabPartners/Takeo");
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, -2, 1), Quaternion.identity);
		}
		if (PartnerManager.Instance.currentPartner.name == "Akio" && PartnerManager.Instance.akioCount <= 0) {
			PartnerManager.Instance.currentPartner = (GameObject)Resources.Load ("PrefabPartners/Takeo");
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, -2, 1), Quaternion.identity);
		}
		if (PartnerManager.Instance.currentPartner.name == "Daisuke" && PartnerManager.Instance.daisukeCount <= 0) {
			PartnerManager.Instance.currentPartner = (GameObject)Resources.Load ("PrefabPartners/Takeo");
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, -2, 1), Quaternion.identity);
		}
		if (PartnerManager.Instance.currentPartner.name == "Tomoaki" && PartnerManager.Instance.tomoakiCount <= 0) {
			PartnerManager.Instance.currentPartner = (GameObject)Resources.Load ("PrefabPartners/Takeo");
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, -2, 1), Quaternion.identity);
		}
		if (PartnerManager.Instance.currentPartner.name == "Youichiro" && PartnerManager.Instance.youichiroCount <= 0) {
			PartnerManager.Instance.currentPartner = (GameObject)Resources.Load ("PrefabPartners/Takeo");
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, -2, 1), Quaternion.identity);
		}
		else {
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, -2, 1), Quaternion.identity);
		}
	}
	//カウントを減らす
	void CutDownCount()
	{
		if (PartnerManager.Instance.currentPartner.name == "Hiroshi"  && PartnerManager.Instance.hiroshihCount >= 0) {
			PartnerManager.Instance.hiroshihCount--;
		}
		if (PartnerManager.Instance.currentPartner.name == "Satoru" && PartnerManager.Instance.satoruCount >= 0) {
			PartnerManager.Instance.satoruCount--;
		}
		if (PartnerManager.Instance.currentPartner.name == "Akio" && PartnerManager.Instance.akioCount >= 0) {
			PartnerManager.Instance.akioCount--;
		}
		if (PartnerManager.Instance.currentPartner.name == "Daisuke" && PartnerManager.Instance.daisukeCount >= 0) {
			PartnerManager.Instance.daisukeCount--;
		}
		if (PartnerManager.Instance.currentPartner.name == "Tomoaki" && PartnerManager.Instance.tomoakiCount >= 0) {
			PartnerManager.Instance.tomoakiCount--;
		}
		if (PartnerManager.Instance.currentPartner.name == "Youichiro" && PartnerManager.Instance.youichiroCount >= 0) {
			PartnerManager.Instance.youichiroCount--;
		}

		//セーブ
		PartnerManager.Instance.SaveCount ();
	}
}
