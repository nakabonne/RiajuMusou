using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {

	public static int nowLelel;

	void Start()
	{
		nowLelel = 1;
	}
	void Update()
	{
		Debug.Log (nowLelel);
	}
}
