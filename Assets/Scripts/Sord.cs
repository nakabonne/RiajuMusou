using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sord : MonoBehaviour {

	void Start () {
		Length ();
	}
	//長さを決定
	void Length()
	{
		transform.localScale += new Vector3 (0, ParameterManager.Instance.sordLength * 0.2f, 0);
	}
}
