using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoichiroBullet : MonoBehaviour {
	Transform target;
	// Use this for initialization
	void Start () {
		target = GameObject.Find ("LastTarget").transform;
		Destroy (gameObject, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Enemy"){
			Destroy (gameObject);
		}
	}

	void Move()
	{
		//対象の位置の方向を向く
		transform.LookAt(target);

		//自分自身の位置から相対的に移動する
		transform.Translate(Vector3.forward);
	}
}
