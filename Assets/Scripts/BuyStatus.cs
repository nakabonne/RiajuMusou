using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyStatus : MonoBehaviour {
	//値段
	int Price(int level)
	{
		return 80 * level;
	}

	//剣の長さレベルを上げる
	public void UpSordLength()
	{
		if (ExperienceManager.Instance.experience <= 0)
			return;
		//経験値の支払い
		ExperienceManager.Instance.experience -= Price(ParameterManager.Instance.sordLength * 10);
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
		ExperienceManager.Instance.experience -= Price(ParameterManager.Instance.speed * 10);
		ExperienceManager.Instance.Save ();
		//レベルアップ
		ParameterManager.Instance.speed++;
		ParameterManager.Instance.Save ();


	}
}
