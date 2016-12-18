using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyStatus : MonoBehaviour {
//	//値段
//	int Price(int level)
//	{
//		return 80 * level;
//	}
	public int swordPrice;
	public int speedPrice;
	void Start()
	{
		//剣の値段
	    swordPrice = ParameterManager.Instance.sordLength * 10;
		//スピードの値段
		speedPrice = ParameterManager.Instance.speed * 10;
	}

	//剣の長さレベルを上げる
	public void UpSordLength()
	{
		if (ExperienceManager.Instance.experience <= 0)
			return;
		//経験値の支払い
		ExperienceManager.Instance.experience -= swordPrice;
		ExperienceManager.Instance.Save ();
		//レベルアップ
		ParameterManager.Instance.sordLength++;
		ParameterManager.Instance.Save ();


	}

	//スピードレベルを上げる
	public void UpSpeed()
	{
		if (ExperienceManager.Instance.experience <= 0)
			return;
		//経験値の支払い
		ExperienceManager.Instance.experience -= speedPrice;
		ExperienceManager.Instance.Save ();
		//レベルアップ
		ParameterManager.Instance.speed++;
		ParameterManager.Instance.Save ();


	}

}
