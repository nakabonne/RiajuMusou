using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PresentBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.DOPunchScale (new Vector3 (2f, 2f, 2f), 20.0f, 3, 0);
	}
	
	// Update is called once per frame
	void Update () {
         
	}
}
