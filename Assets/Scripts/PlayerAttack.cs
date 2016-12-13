using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	PlayerAnimator playerAnimator;

	public GameObject sword;
	// Use this for initialization
	void Start () {
		playerAnimator = GetComponent<PlayerAnimator> ();
		InvalidCollider ();
	}
	
	// Update is called once per frame
	void Update () {
		//ゲームが始まらないと処理はされない
		if (GameManager.Instance.BeforeGameStart ()) return;

	}
	//攻撃
	public void Attack()
	{
		playerAnimator.Attack ();
		//ソードのこライダーを有効にする
		sword.GetComponent<BoxCollider> ().enabled = true;
		Invoke ("InvalidCollider", 1.5f);
	}
	//剣のこライダーを無効化
	void InvalidCollider()
	{
		sword.GetComponent<BoxCollider> ().enabled = false;
	}
}
