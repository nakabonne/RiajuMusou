using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareManager : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangePartner()
	{
		MySceneManager.Instance.GoPartnerChange ();
	}

	public void ChangeItem()
	{
		MySceneManager.Instance.GoItemChange ();
	}
}
