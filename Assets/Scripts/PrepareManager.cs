using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrepareManager : MonoBehaviour {
	
	public Text currentPartner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentPartner.text = "現在のパートナーは" + PartnerManager.Instance.currentPartner.name;
	}

	public void ChangePartner()
	{
		MySceneManager.Instance.GoPartnerChange ();
	}

	public void ChangeItem()
	{
		MySceneManager.Instance.GoItemChange ();
	}

	public void GoMain()
	{
		MySceneManager.Instance.GoMainGame ();
	}
}
