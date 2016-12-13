using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PartnerMove : MonoBehaviour {

	GameObject targetObj;

	//現在のシーン名
	string sceneName;
	// Use this for initialization
	void Start () {
		targetObj = serchTag (gameObject, "Enemy");
		//現在のシーン名を取得
		sceneName = SceneManager.GetActiveScene ().name;
	}
	
	// Update is called once per frame
	void Update () {
		if (sceneName == "Gatya") return;
		if (GameManager.Instance.BeforeGameStart ()) return;
		Serch ();
		Move ();
	}

	void Serch()
	{
		targetObj = serchTag (gameObject, "Enemy");
	}

	void Move()
	{
		//対象の位置の方向を向く
		transform.LookAt(targetObj.transform);

		//自分自身の位置から相対的に移動する
		transform.Translate(Vector3.forward * 0.1f);
	}

	//指定されたタグの中で最も近いものを取得
	GameObject serchTag(GameObject nowObj,string tagName){
		float tmpDis = 0;           //距離用一時変数
		float nearDis = 0;          //最も近いオブジェクトの距離
		//string nearObjName = "";    //オブジェクト名称
		GameObject targetObj = null; //オブジェクト

		//タグ指定されたオブジェクトを配列で取得する
		foreach (GameObject obs in  GameObject.FindGameObjectsWithTag(tagName)){
			//自身と取得したオブジェクトの距離を取得
			tmpDis = Vector3.Distance(obs.transform.position, nowObj.transform.position);

			//オブジェクトの距離が近いか、距離0であればオブジェクト名を取得
			//一時変数に距離を格納
			if (nearDis == 0 || nearDis > tmpDis){
				nearDis = tmpDis;
				//nearObjName = obs.name;
				targetObj = obs;
			}

		}
		//最も近かったオブジェクトを返す
		//return GameObject.Find(nearObjName);
		return targetObj;
	}
}
