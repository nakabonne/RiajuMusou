using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tomoaki : MonoBehaviour {

	float count = 0;

	public Animator animator;

	float speed = 0.01f;

	public GameObject bomb;

	Transform target;

	string sceneName;

	//public GameObject hand;

	//bool isAttacked = false;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		target = GameObject.Find ("TargetObj").transform;
		sceneName = SceneManager.GetActiveScene ().name;
		//hand = GameObject.Find ("RightHandRing4");
	}

	// Update is called once per frame
	void Update () {
		if (sceneName == "Gatya") return;
		if (GameManager.Instance.BeforeGameStart ()) return;

		count += Time.deltaTime;

		//6秒以内かつターゲットに接してない時
		if (count <= 7.0f && !isNear) {
			Move ();
		} 

		if(count > 7.0f)
		{
			Attack ();
		}


	}
	//移動
	void Move()
	{
		//		transform.LookAt (target.transform);
		//		transform.Translate (transform.forward * 0.3f);


//		Vector3 vec = target.position - transform.position;
//
//		// ターゲットの方向を向く
//		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(vec.x, 0, vec.z)), 1.0f);
//		transform.Translate(Vector3.forward * speed); // 正面方向に移動

		Vector3 vec = target.position - transform.position;

		// ターゲットの方向を向く
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(vec.x, 0, vec.z)), 1.0f);
		transform.Translate(Vector3.forward * speed); // 正面方向に移動
	}

	void Attack()
	{
		animator.SetTrigger ("Attack");
		Invoke ("BeamInstantiate", 2.5f);
		count = 0;
	}
	//たま生成
	void BeamInstantiate()
	{
		Instantiate (bomb, transform.position + new Vector3(0,4.0f,2.0f), transform.rotation);
	}
	//------------------------------以下はターゲットに追いついた時の処理
	bool isNear;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "TargetObj") {
			isNear = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == "TargetObj") {
			isNear = false;
		}
	}
}
