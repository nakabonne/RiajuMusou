using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TapToStart : MonoBehaviour {

	private float nextTime;
	public float interval = 0.8f; //点滅周期


	// Use this for initialization
	void Start()
	{

		nextTime = Time.time;
	}

	// Update is called once per frame
	void Update()
	{
		//一定時間ごとに点滅
		if ( Time.time > nextTime ) {
			float alpha = GetComponent<CanvasRenderer>().GetAlpha();
			if (alpha == 1.0f)
				GetComponent<CanvasRenderer>().SetAlpha(0.0f);
			else
				GetComponent<CanvasRenderer>().SetAlpha(1.0f);

			nextTime += interval;
		}

	}
}
