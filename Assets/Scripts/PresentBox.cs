using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PresentBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Big", 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 4, 0));
	}
	void Big()
	{
		transform.DOPunchScale (new Vector3 (2f, 2f, 2f), 20.0f, 3, 0);
	}
}
