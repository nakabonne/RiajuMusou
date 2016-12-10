using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartnerGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Generate ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//パートナー生成
	void Generate()
	{
		Instantiate (PartnerManager.Instance.currentPartner, new Vector3 (1, 0, 1), Quaternion.identity);
	}
}
