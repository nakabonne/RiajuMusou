using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayreMove : MonoBehaviour {
	//デバッグかどうか
	public bool isDebug;
	//移動スピード
	float speed;
	//元となる位置
	Vector3 prev;
	// Use this for initialization
	void Start () {
		//初期位置を保存
		prev = transform.position;
		//スピードを決定
		speed = ParameterManager.Instance.speed * 0.01f;
	}
	
	// Update is called once per frame
	void Update () {
		//ゲームが始まるまでは実行されない
		if (GameManager.Instance.BeforeGameStart()) return;
		MoveInput ();
		Direction ();
	}
	//移動する
	void MoveInput()
	{
		//デバッグ時
		if (isDebug) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				transform.position += transform.forward;
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				transform.position -= transform.forward;
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				transform.position += transform.right;
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.position -= transform.right;
			}
		}
		//本番
		if (!isDebug) {
			// 右・左
			float x = CrossPlatformInputManager.GetAxisRaw("Horizontal") * 0.2f + speed;

			// 上・下
			float z = CrossPlatformInputManager.GetAxisRaw("Vertical") * 0.2f + speed;
			 
			// 移動する向きを求める
			Vector3 direction = new Vector3 (x,0,z);

			transform.position += direction;
		}
	}

	//向きを決める
	void Direction()
	{
		Vector3 diff = transform.position - prev;
		if (diff.magnitude > 0.01) {
			transform.rotation = Quaternion.LookRotation (diff);
		}
		prev = transform.position;
	}

}
