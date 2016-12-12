using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour {


	public void GameStart()
	{
		MySceneManager.Instance.GoPrepare ();
	}
}
