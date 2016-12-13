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
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, 0, 1), Quaternion.identity);
		} else {
			Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (4, 0, 1), Quaternion.identity);
		}
	}
	//カウントを減らす
	void CutDownCount()
	{
		if (PartnerManager.Instance.currentPartner.name == "Hiroshi") {
			PartnerManager.Instance.hiroshihCount--;
		}
		if (PartnerManager.Instance.currentPartner.name == "Satoru") {
			PartnerManager.Instance.satoruCount--;
		}


		//セーブ
		PartnerManager.Instance.SaveCount ();
	}
}
