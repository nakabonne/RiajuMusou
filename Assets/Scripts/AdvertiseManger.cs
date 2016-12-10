using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvertiseManger : SingletonMonoBehaviour<AdvertiseManger> {

	//最初はある程度固定

	//動画広告をランダムに表示するための乱数
	public int MovieShowTiming()
	{
		return Random.Range (0, 2);
	}
}
