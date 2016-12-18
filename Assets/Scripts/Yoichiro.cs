using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Yoichiro : MonoBehaviour {

	public GameObject bullet;
	float count = 0;
	Transform target;
	string sceneName;
	// Use this for initialization
	void Start () {
		sceneName = SceneManager.GetActiveScene ().name;
		if (sceneName == "Main") {
			target = GameObject.Find ("LastTarget").transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (GameManager.Instance.BeforeGameStart ()) return;
		Move ();
		count += Time.deltaTime;
		if (count >= 0.5f) {
			Shot ();
		}
	}
	void Shot()
	{
		Instantiate (bullet, transform.position + new Vector3 (0,1.0f,0), Quaternion.identity);
		count = 0;
		Debug.Log ("ショット");
	}

	void Move()
	{
		//対象の位置の方向を向く
		transform.LookAt(target);

		//自分自身の位置から相対的に移動する
		transform.Translate(Vector3.forward * 0.2f);
	}
}
