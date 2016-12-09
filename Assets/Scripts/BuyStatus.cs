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
		//経験値の支払い
		ExperienceManager.Instance.experience -= Price(ParameterManager.Instance.sordLength);
		ExperienceManager.Instance.Save ();
		//レベルアップ
		ParameterManager.Instance.sordLength++;
		ParameterManager.Instance.Save ();

		Debug.Log ("剣の長さレベルは" + ParameterManager.Instance.sordLength);
	}

	//スピードレベルを上げる
	public void UpSpeed()
	{
		//経験値の支払い
		ExperienceManager.Instance.experience -= Price(ParameterManager.Instance.speed);
		ExperienceManager.Instance.Save ();
		//レベルアップ
		ParameterManager.Instance.speed++;
		ParameterManager.Instance.Save ();

		Debug.Log ("スピードは" + ParameterManager.Instance.speed);
	}
}
