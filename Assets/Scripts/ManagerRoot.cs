using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//全シーンで使うマネージャーをまとめるフォルダ
public class ManagerRoot : MonoBehaviour {

	void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
	}


}
