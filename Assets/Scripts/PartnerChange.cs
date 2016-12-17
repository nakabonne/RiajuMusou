using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartnerChange : MonoBehaviour {

	string choosingPartnerName;

	public GameObject hiroshiButtion;
	public Text hiroshiCountLabel;

	public GameObject satoruButton;
	public Text satoruCountLabel;

	public GameObject akioButton;
	public Text akioCountLabel;

	public GameObject daisukeButton;
	public Text daisukeCountLabel;

	public GameObject tomoakiButton;
	public Text tomoakiCountLabel;

	public GameObject youichiroButton;
	public Text youichiroCountLabel;
	// Use this for initialization
	void Start () {
		DisplayPartner ();
	}
	//どのパートナーボタンを表示するか決定
	void DisplayPartner()
	{
		if (PartnerManager.Instance.hiroshihCount <= 0) {
			hiroshiButtion.SetActive (false);
		}
		if (PartnerManager.Instance.satoruCount <= 0) {
			satoruButton.SetActive (false);
		}
		if (PartnerManager.Instance.akioCount <= 0) {
			akioButton.SetActive (false);
		}
		if (PartnerManager.Instance.daisukeCount <= 0) {
			daisukeButton.SetActive (false);
		}
		if (PartnerManager.Instance.tomoakiCount <= 0) {
			tomoakiButton.SetActive (false);
		}
		if (PartnerManager.Instance.youichiroCount <= 0) {
			youichiroButton.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		CountDisplay ();
	}
	//パートナーカウントを表示する
	void CountDisplay()
	{
		hiroshiCountLabel.text = "× " + PartnerManager.Instance.hiroshihCount.ToString ();
		satoruCountLabel.text = "× " + PartnerManager.Instance.satoruCount.ToString ();
		akioCountLabel.text = "× " + PartnerManager.Instance.akioCount.ToString ();
		daisukeCountLabel.text = "× " + PartnerManager.Instance.daisukeCount.ToString ();
		tomoakiCountLabel.text = "× " + PartnerManager.Instance.tomoakiCount.ToString ();
		youichiroCountLabel.text = "× " + PartnerManager.Instance.youichiroCount.ToString ();
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
