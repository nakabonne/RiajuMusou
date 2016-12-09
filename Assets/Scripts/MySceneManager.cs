using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : SingletonMonoBehaviour<MySceneManager> {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoResult()
	{
		SceneManager.LoadScene ("Result");
	}

	public void GoMainGame()
	{
		SceneManager.LoadScene ("Main");
	}
}
