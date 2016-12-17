using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hiroshi : MonoBehaviour {
	float count = 0;

	public Animator animator;

	float speed = 0.3f;

	public GameObject Bullet;

	Transform target;

	string sceneName;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		target = GameObject.Find ("TargetObj").transform;
		sceneName = SceneManager.GetActiveScene ().name;
	}
	
	// Update is called once per frame
	void Update () {
		if (sceneName == "Gatya") return;

		count += Time.deltaTime;
		//6秒以内かつターゲットに接してない時
		if (count <= 6.0f && !isNear) {
			Move ();
		} else {
			Attack ();
		}


	}

	void Move()
	{
//		transform.LookAt (target.transform);
//		transform.Translate (transform.forward * 0.3f);


		Vector3 vec = target.position - transform.position;

		// ターゲットの方向を向く
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(vec.x, 0, vec.z)), 1.0f);
		transform.Translate(Vector3.forward * speed); // 正面方向に移動
	}

	void Attack()
	{
		animator.SetTrigger ("Attack");
		Instantiate (Bullet, transform.position, Quaternion.identity);
		Invoke ("CountReset", 2.0f);
	}
	void CountReset()
	{
		count = 0;
	}

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
